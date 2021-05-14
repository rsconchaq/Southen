Imports WcfSerialization = System.Runtime.Serialization
Imports System.ComponentModel.DataAnnotations


Public Class Persona
    Private _idPersona As Integer
    Private _Nombre As String
    Private _Apellido As String
    Private _Documento As String
    Private _TipoDocumento As String
    Private _Edad As Integer
    Private _Estado As String
    <WcfSerialization.DataMember(Name:="IdPersona", IsRequired:=False, Order:=0)>
    Public Property IdPersona As Integer
        Get
            Return _idPersona
        End Get
        Set(value As Integer)
            _idPersona = value
        End Set
    End Property
    <WcfSerialization.DataMember(Name:="Nombre", IsRequired:=False, Order:=1)>
    Public Property Nombre As String
        Get
            Return _Nombre
        End Get
        Set(value As String)
            _Nombre = value
        End Set
    End Property
    <WcfSerialization.DataMember(Name:="Apellido", IsRequired:=False, Order:=2)>
    Public Property Apellido As String
        Get
            Return _Apellido
        End Get
        Set(value As String)
            _Apellido = value
        End Set
    End Property
    <WcfSerialization.DataMember(Name:="Documento", IsRequired:=False, Order:=3)>
    Public Property Documento As String
        Get
            Return _Documento
        End Get
        Set(value As String)
            _Documento = value
        End Set
    End Property
    <WcfSerialization.DataMember(Name:="TipoDocumento", IsRequired:=False, Order:=4)>
    Public Property TipoDocumento As String
        Get
            Return _TipoDocumento
        End Get
        Set(value As String)
            _TipoDocumento = value
        End Set
    End Property
    <WcfSerialization.DataMember(Name:="Edad", IsRequired:=False, Order:=5)>
    Public Property Edad As Integer
        Get
            Return _Edad
        End Get
        Set(value As Integer)
            _Edad = value
        End Set
    End Property
    <WcfSerialization.DataMember(Name:="Estado", IsRequired:=False, Order:=6)>
    Public Property Estado As String
        Get
            Return _Estado
        End Get
        Set(value As String)
            _Estado = value
        End Set
    End Property
End Class
