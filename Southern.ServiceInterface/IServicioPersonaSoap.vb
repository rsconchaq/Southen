Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.ServiceModel
Imports WCF = System.ServiceModel
Imports System.Net.Security
Imports Southern.DataContracts
<ServiceContract()>
Public Interface IServicioPersonaSoap

    <OperationContract>
    Function MostrarPersona() As List(Of Persona)

    <OperationContract>
    Function BuscaPersona(ByVal nombre As String) As List(Of Persona)
    <OperationContract>
    Function RegistrarPersona(oPersona As Persona)

    <OperationContract>
    Function EliminarPersona(IdPersona As Integer) As Boolean

    <OperationContract>
    Function ActualizarPersona(oPersona As Persona) As Boolean
    <OperationContract>
    Function ConsultaDocumento(Documento As String) As Boolean

End Interface
