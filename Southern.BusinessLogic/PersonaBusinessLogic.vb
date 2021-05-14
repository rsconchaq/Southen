Imports Southern.DataAccess
Imports Southern.DataContracts
Public Class PersonaBusinessLogic
    Dim oPersonaDataAccess As PersonaDataAccess = New PersonaDataAccess


    Function MostrarPersona() As List(Of Persona)
        Dim lista As New List(Of Persona)
        lista = oPersonaDataAccess.MostrarPersona()
        Return lista
    End Function
    Public Function BuscaPersona(ByVal nombre As String) As List(Of Persona)
        Dim lista As New List(Of Persona)
        lista = oPersonaDataAccess.BuscaPersona(nombre)
        Return lista
    End Function

    Function RegistrarPersona(oPersona As Persona)
        Return oPersonaDataAccess.RegistrarPersona(oPersona)
    End Function

    Function ActualizarPersona(oPersona As Persona)
        Return oPersonaDataAccess.ActualizarPersona(oPersona)
    End Function

    Function EliminarPersona(IdPersona As Integer)
        Return oPersonaDataAccess.EliminarPersona(IdPersona)
    End Function

    Function ConsultaDocumento(Documento As String)
        Return oPersonaDataAccess.ConsultaDocumento(Documento)
    End Function
End Class
