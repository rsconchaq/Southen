'------------------------------------------------------------------------------
' <auto-generated>
'     Este código fue generado por una herramienta.
'     Versión de runtime:4.0.30319.42000
'
'     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
'     se vuelve a generar el código.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On


Namespace ServiceReference1
    
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ServiceModel.ServiceContractAttribute(ConfigurationName:="ServiceReference1.IServicioPersonaSoap")>  _
    Public Interface IServicioPersonaSoap
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/IServicioPersonaSoap/MostrarPersona", ReplyAction:="http://tempuri.org/IServicioPersonaSoap/MostrarPersonaResponse")>  _
        Function MostrarPersona() As Southern.DataContracts.Persona()
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/IServicioPersonaSoap/MostrarPersona", ReplyAction:="http://tempuri.org/IServicioPersonaSoap/MostrarPersonaResponse")>  _
        Function MostrarPersonaAsync() As System.Threading.Tasks.Task(Of Southern.DataContracts.Persona())
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/IServicioPersonaSoap/BuscaPersona", ReplyAction:="http://tempuri.org/IServicioPersonaSoap/BuscaPersonaResponse")>  _
        Function BuscaPersona(ByVal nombre As String) As Southern.DataContracts.Persona()
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/IServicioPersonaSoap/BuscaPersona", ReplyAction:="http://tempuri.org/IServicioPersonaSoap/BuscaPersonaResponse")>  _
        Function BuscaPersonaAsync(ByVal nombre As String) As System.Threading.Tasks.Task(Of Southern.DataContracts.Persona())
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/IServicioPersonaSoap/RegistrarPersona", ReplyAction:="http://tempuri.org/IServicioPersonaSoap/RegistrarPersonaResponse"),  _
         System.ServiceModel.ServiceKnownTypeAttribute(GetType(Southern.DataContracts.Persona())),  _
         System.ServiceModel.ServiceKnownTypeAttribute(GetType(Southern.DataContracts.Persona))>  _
        Function RegistrarPersona(ByVal oPersona As Southern.DataContracts.Persona) As Object
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/IServicioPersonaSoap/RegistrarPersona", ReplyAction:="http://tempuri.org/IServicioPersonaSoap/RegistrarPersonaResponse")>  _
        Function RegistrarPersonaAsync(ByVal oPersona As Southern.DataContracts.Persona) As System.Threading.Tasks.Task(Of Object)
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/IServicioPersonaSoap/EliminarPersona", ReplyAction:="http://tempuri.org/IServicioPersonaSoap/EliminarPersonaResponse")>  _
        Function EliminarPersona(ByVal IdPersona As Integer) As Boolean
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/IServicioPersonaSoap/EliminarPersona", ReplyAction:="http://tempuri.org/IServicioPersonaSoap/EliminarPersonaResponse")>  _
        Function EliminarPersonaAsync(ByVal IdPersona As Integer) As System.Threading.Tasks.Task(Of Boolean)
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/IServicioPersonaSoap/ActualizarPersona", ReplyAction:="http://tempuri.org/IServicioPersonaSoap/ActualizarPersonaResponse")>  _
        Function ActualizarPersona(ByVal oPersona As Southern.DataContracts.Persona) As Boolean
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/IServicioPersonaSoap/ActualizarPersona", ReplyAction:="http://tempuri.org/IServicioPersonaSoap/ActualizarPersonaResponse")>  _
        Function ActualizarPersonaAsync(ByVal oPersona As Southern.DataContracts.Persona) As System.Threading.Tasks.Task(Of Boolean)

        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/IServicioPersonaSoap/ConsultaDocumento", ReplyAction:="http://tempuri.org/IServicioPersonaSoap/ConsultaDocumentoResponse")>
        Function ConsultaDocumento(ByVal Documento As String) As Boolean

        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/IServicioPersonaSoap/ConsultaDocumento", ReplyAction:="http://tempuri.org/IServicioPersonaSoap/ConsultaDocumentoResponse")>
        Function ConsultaDocumentoAsync(ByVal Documento As String) As System.Threading.Tasks.Task(Of Boolean)
    End Interface

    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")>
    Public Interface IServicioPersonaSoapChannel
        Inherits ServiceReference1.IServicioPersonaSoap, System.ServiceModel.IClientChannel
    End Interface

    <System.Diagnostics.DebuggerStepThroughAttribute(),
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")>
    Partial Public Class ServicioPersonaSoapClient
        Inherits System.ServiceModel.ClientBase(Of ServiceReference1.IServicioPersonaSoap)
        Implements ServiceReference1.IServicioPersonaSoap

        Public Sub New()
            MyBase.New
        End Sub

        Public Sub New(ByVal endpointConfigurationName As String)
            MyBase.New(endpointConfigurationName)
        End Sub

        Public Sub New(ByVal endpointConfigurationName As String, ByVal remoteAddress As String)
            MyBase.New(endpointConfigurationName, remoteAddress)
        End Sub

        Public Sub New(ByVal endpointConfigurationName As String, ByVal remoteAddress As System.ServiceModel.EndpointAddress)
            MyBase.New(endpointConfigurationName, remoteAddress)
        End Sub

        Public Sub New(ByVal binding As System.ServiceModel.Channels.Binding, ByVal remoteAddress As System.ServiceModel.EndpointAddress)
            MyBase.New(binding, remoteAddress)
        End Sub

        Public Function MostrarPersona() As Southern.DataContracts.Persona() Implements ServiceReference1.IServicioPersonaSoap.MostrarPersona
            Return MyBase.Channel.MostrarPersona
        End Function

        Public Function MostrarPersonaAsync() As System.Threading.Tasks.Task(Of Southern.DataContracts.Persona()) Implements ServiceReference1.IServicioPersonaSoap.MostrarPersonaAsync
            Return MyBase.Channel.MostrarPersonaAsync
        End Function

        Public Function BuscaPersona(ByVal nombre As String) As Southern.DataContracts.Persona() Implements ServiceReference1.IServicioPersonaSoap.BuscaPersona
            Return MyBase.Channel.BuscaPersona(nombre)
        End Function

        Public Function BuscaPersonaAsync(ByVal nombre As String) As System.Threading.Tasks.Task(Of Southern.DataContracts.Persona()) Implements ServiceReference1.IServicioPersonaSoap.BuscaPersonaAsync
            Return MyBase.Channel.BuscaPersonaAsync(nombre)
        End Function

        Public Function RegistrarPersona(ByVal oPersona As Southern.DataContracts.Persona) As Object Implements ServiceReference1.IServicioPersonaSoap.RegistrarPersona
            Return MyBase.Channel.RegistrarPersona(oPersona)
        End Function

        Public Function RegistrarPersonaAsync(ByVal oPersona As Southern.DataContracts.Persona) As System.Threading.Tasks.Task(Of Object) Implements ServiceReference1.IServicioPersonaSoap.RegistrarPersonaAsync
            Return MyBase.Channel.RegistrarPersonaAsync(oPersona)
        End Function

        Public Function EliminarPersona(ByVal IdPersona As Integer) As Boolean Implements ServiceReference1.IServicioPersonaSoap.EliminarPersona
            Return MyBase.Channel.EliminarPersona(IdPersona)
        End Function

        Public Function EliminarPersonaAsync(ByVal IdPersona As Integer) As System.Threading.Tasks.Task(Of Boolean) Implements ServiceReference1.IServicioPersonaSoap.EliminarPersonaAsync
            Return MyBase.Channel.EliminarPersonaAsync(IdPersona)
        End Function

        Public Function ActualizarPersona(ByVal oPersona As Southern.DataContracts.Persona) As Boolean Implements ServiceReference1.IServicioPersonaSoap.ActualizarPersona
            Return MyBase.Channel.ActualizarPersona(oPersona)
        End Function

        Public Function ActualizarPersonaAsync(ByVal oPersona As Southern.DataContracts.Persona) As System.Threading.Tasks.Task(Of Boolean) Implements ServiceReference1.IServicioPersonaSoap.ActualizarPersonaAsync
            Return MyBase.Channel.ActualizarPersonaAsync(oPersona)
        End Function

        Public Function ConsultaDocumento(ByVal Documento As String) As Boolean Implements ServiceReference1.IServicioPersonaSoap.ConsultaDocumento
            Return MyBase.Channel.ConsultaDocumento(Documento)
        End Function

        Public Function ConsultaDocumentoAsync(ByVal Documento As String) As System.Threading.Tasks.Task(Of Boolean) Implements ServiceReference1.IServicioPersonaSoap.ConsultaDocumentoAsync
            Return MyBase.Channel.ConsultaDocumentoAsync(Documento)
        End Function
    End Class
End Namespace
