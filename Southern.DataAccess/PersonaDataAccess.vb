Imports Southern.DataContracts
Imports System.Data.SqlClient
Public Class PersonaDataAccess
    Private ConnString As String = "Data Source=DESKTOP-7JTPEF4\MSSQLSERVER1;Initial Catalog=SouthernBD;User ID=sa;Password=123456;"

    Public Function MostrarPersona() As List(Of Persona)
        Dim lista As New List(Of Persona)
        Using cnn As New SqlConnection(ConnString)
            cnn.Open()
            Dim cmd As New SqlCommand("p_mostrartodopersona", cnn)
            cmd.CommandType = CommandType.StoredProcedure
            Dim dr As SqlDataReader
            dr = cmd.ExecuteReader
            While dr.Read
                Dim reg As New Persona
                reg.IdPersona = dr.GetValue(0).ToString()
                reg.Nombre = dr.GetValue(1).ToString()
                reg.Apellido = dr.GetValue(2).ToString()
                reg.Documento = dr.GetValue(3).ToString()
                reg.TipoDocumento = dr.GetValue(4).ToString()
                reg.Edad = dr.GetValue(5).ToString()
                reg.Estado = dr.GetValue(6).ToString()
                lista.Add(reg)
            End While
            dr.Close()
        End Using
        Return lista
    End Function

    Public Function BuscaPersona(ByVal nombre As String) As List(Of Persona)

        Dim lista As New List(Of Persona)
        Using cnn As New SqlConnection(ConnString)
            cnn.Open()
            Try
                Dim cmd As New SqlCommand("p_buscapersona", cnn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@nombre", nombre)
                Dim dr As SqlDataReader
                dr = cmd.ExecuteReader
                While dr.Read
                    Dim reg As New Persona
                    reg.IdPersona = dr.GetValue(0).ToString()
                    reg.Nombre = dr.GetValue(1).ToString()
                    reg.Apellido = dr.GetValue(2).ToString()
                    reg.Documento = dr.GetValue(3).ToString()
                    reg.TipoDocumento = dr.GetValue(4).ToString()
                    reg.Edad = dr.GetValue(5).ToString()
                    reg.Estado = dr.GetValue(6).ToString()
                    lista.Add(reg)
                End While
                dr.Close()
            Catch ex As Exception
            End Try
        End Using

        Return lista

    End Function

    Function RegistrarPersona(oPersona As Persona)

        Using cnn As New SqlConnection(ConnString)
            cnn.Open()

            Dim cmd As New SqlCommand("p_nuevapersona", cnn)
            cmd.CommandType = CommandType.StoredProcedure

            With cmd.Parameters
                .AddWithValue("@Nombre", DbType.String).Value = oPersona.Nombre
                .AddWithValue("@Apellido", DbType.String).Value = oPersona.Apellido
                .AddWithValue("@Documento", DbType.String).Value = oPersona.Documento
                .AddWithValue("@TipoDocumento", DbType.String).Value = oPersona.TipoDocumento
                .AddWithValue("@Edad", DbType.Int32).Value = oPersona.Edad
                .AddWithValue("@Estado", DbType.String).Value = oPersona.Estado

            End With
            cmd.ExecuteNonQuery()
            cnn.Close()

        End Using


    End Function

    Function ActualizarPersona(oPersona As Persona)
        Using cnn As New SqlConnection(ConnString)
            cnn.Open()

            Dim cmd As New SqlCommand("p_modificarpersona", cnn)
            cmd.CommandType = CommandType.StoredProcedure

            With cmd.Parameters
                .AddWithValue("@PersonaId", DbType.Int32).Value = oPersona.IdPersona
                .AddWithValue("@Nombre", DbType.String).Value = oPersona.Nombre
                .AddWithValue("@Apellido", DbType.String).Value = oPersona.Apellido
                .AddWithValue("@Documento", DbType.String).Value = oPersona.Documento
                .AddWithValue("@TipoDocumento", DbType.String).Value = oPersona.TipoDocumento
                .AddWithValue("@Edad", DbType.Int32).Value = oPersona.Edad
                .AddWithValue("@Estado", DbType.String).Value = oPersona.Estado

            End With
            cmd.ExecuteNonQuery()
            cnn.Close()

        End Using
    End Function

    Function EliminarPersona(IdPersona As Integer) As Boolean
        Dim result As Boolean = False
        Dim resultado As Boolean = False

        Using cnn As New SqlConnection(ConnString)
            cnn.Open()
            Try
                Dim cmd As New SqlCommand("p_eliminarpersona", cnn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@IdPersona", IdPersona)
                resultado = cmd.ExecuteNonQuery()
                cnn.Close()

            Catch ex As Exception
            End Try
        End Using

        If (resultado > 0) Then
            result = True
        End If


        Return result
    End Function

    Function ConsultaDocumento(Documento As String) As Boolean
        Dim result As Boolean = False
        Dim resultado As Boolean = False

        Dim lista As New List(Of Persona)
        Using cnn As New SqlConnection(ConnString)
            cnn.Open()
            Try
                Dim cmd As New SqlCommand("p_buscadocumento", cnn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@documento", Documento)
                Dim dr As SqlDataReader
                dr = cmd.ExecuteReader
                While dr.Read
                    Dim reg As New Persona
                    reg.IdPersona = dr.GetValue(0).ToString()
                    reg.Nombre = dr.GetValue(1).ToString()
                    reg.Apellido = dr.GetValue(2).ToString()
                    reg.Documento = dr.GetValue(3).ToString()
                    reg.TipoDocumento = dr.GetValue(4).ToString()
                    reg.Edad = dr.GetValue(5).ToString()
                    reg.Estado = dr.GetValue(6).ToString()
                    lista.Add(reg)
                End While
                dr.Close()
            Catch ex As Exception
            End Try
        End Using



        If (lista.Count > 0) Then
            result = True
        End If


        Return result
    End Function
End Class
