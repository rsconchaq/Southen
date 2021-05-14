Imports Southern.ServiceInterface
Imports Southern.DataContracts
Imports Southern.BusinessLogic
Public Class ServicioPersona
    Implements IServicioPersonaSoap

    Dim oPersonaBusinessLogic As PersonaBusinessLogic = New PersonaBusinessLogic

    Public Function ActualizarPersona(oPersona As Persona) As Boolean Implements IServicioPersonaSoap.ActualizarPersona
        Return oPersonaBusinessLogic.ActualizarPersona(oPersona)
    End Function

    Public Function BuscaPersona(nombre As String) As List(Of Persona) Implements IServicioPersonaSoap.BuscaPersona
        Return oPersonaBusinessLogic.BuscaPersona(nombre)
    End Function

    Public Function ConsultaDocumento(Documento As String) As Boolean Implements IServicioPersonaSoap.ConsultaDocumento
        Return oPersonaBusinessLogic.ConsultaDocumento(Documento)
    End Function

    Public Function EliminarPersona(IdPersona As Integer) As Boolean Implements IServicioPersonaSoap.EliminarPersona
        Return oPersonaBusinessLogic.EliminarPersona(IdPersona)
    End Function

    Public Function MostrarPersona() As List(Of Persona) Implements IServicioPersonaSoap.MostrarPersona
        Return oPersonaBusinessLogic.MostrarPersona()
    End Function

    Public Function RegistrarPersona(oPersona As Persona) As Object Implements IServicioPersonaSoap.RegistrarPersona
        Return oPersonaBusinessLogic.RegistrarPersona(oPersona)
    End Function
End Class
