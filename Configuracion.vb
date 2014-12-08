Imports System.ComponentModel
Imports Microsoft.Win32

Public Class miConfiguracion

    Sub New()

    End Sub
    Private _Linea As Integer
    Private _AccionCambioTurno As Integer
    Private _AccionCambioOperario As Integer
    Private _AccionAveria As Integer
    Private _AccionParada As Integer
    Private _CodigoLinea As String
    Private _AccionPesado As Integer
    Private _AccionLoteado As Integer
    Private _AccionAjuste As Integer
    Private _AccionDefecto As Integer

    <Category("Linea"), Description("Indique la linea de producción en donde se ubica este puesto.")> _
    Public Property Linea As Integer
        Set(value As Integer)
            _Linea = value
        End Set
        Get
            Return _Linea
        End Get
    End Property
    <Category("Turno"), Description("Indique la Acción que dispara el cambio de turno.")> _
    Public Property AccionCambioTurno As Integer
        Set(value As Integer)
            _AccionCambioTurno = value
        End Set
        Get
            Return _AccionCambioTurno
        End Get
    End Property

    <Category("Turno"), Description("Indique la Accion que dispara el cambio de Operario.")> _
    Public Property AccionCambioOperario As Integer
        Set(value As Integer)
            _AccionCambioOperario = value
        End Set
        Get
            Return _AccionCambioOperario
        End Get
    End Property

    <Category("Averia"), Description("Indique la Acción que dispara la averia.")> _
    Public Property AccionAveria As Integer
        Set(value As Integer)
            _AccionAveria = value
        End Set
        Get
            Return _AccionAveria
        End Get
    End Property
    <Category("Averia"), Description("Indique el Codigo de la Linea en Mantenimiento.")> _
    Public Property CodigoLinea As String
        Set(value As String)
            _CodigoLinea = value
        End Set
        Get
            Return _CodigoLinea
        End Get
    End Property

    <Category("Parada"), Description("Indique la Acción que dispara la parada.")> _
    Public Property AccionParada As Integer
        Set(value As Integer)
            _AccionParada = value
        End Set
        Get
            Return _AccionParada
        End Get
    End Property


    <Category("Loteado/Pesado"), Description("Indique la Acción que dispara el loteado.")> _
    Public Property AccionLoteado As Integer
        Set(value As Integer)
            _AccionLoteado = value
        End Set
        Get
            Return _AccionLoteado
        End Get
    End Property
    <Category("Loteado/Pesado"), Description("Indique la Acción que dispara el Pesado.")> _
    Public Property AccionPesado As Integer
        Set(value As Integer)
            _AccionPesado = value
        End Set
        Get
            Return _AccionPesado
        End Get
    End Property

    <Category("Ajuste"), Description("Indique la Acción que dispara el Ajuste.")> _
    Public Property AccionAjuste As Integer
        Set(value As Integer)
            _AccionAjuste = value
        End Set
        Get
            Return _AccionAjuste
        End Get
    End Property
    <Category("Defecto"), Description("Indique la Acción que se dispara por defecto.")> _
    Public Property AccionDefecto As Integer
        Set(value As Integer)
            _AccionDefecto = value
        End Set
        Get
            Return _AccionDefecto
        End Get
    End Property
    Public Sub SaveSettings()
        Dim key As RegistryKey = Registry.CurrentUser.OpenSubKey("Software\\VB and VBA Program Settings\\Gestion V.4\\TomaDatosProduccion\\Settings", True)
        If key Is Nothing Then
            key = Registry.CurrentUser.CreateSubKey("Software\\VB and VBA Program Settings\\Gestion V.4\\TomaDatosProduccion\\Settings")
        End If
        key.SetValue("Linea", _Linea)
        key.SetValue("AccionCambioTurno", _AccionCambioTurno)
        key.SetValue("AccionCambioOperario", _AccionCambioOperario)
        key.SetValue("AccionAveria", _AccionAveria)
        key.SetValue("AccionParada", _AccionParada)
        key.SetValue("CodigoLinea", _CodigoLinea)
        key.SetValue("AccionLoteado", _AccionLoteado)
        key.SetValue("AccionPesado", _AccionPesado)
        key.SetValue("AccionAjuste", _AccionAjuste)
        key.SetValue("AccionDefecto", _AccionDefecto)
    End Sub

    Public Sub LoadSettings()
        Dim key As RegistryKey = Registry.CurrentUser.OpenSubKey("Software\\VB and VBA Program Settings\\Gestion V.4\\TomaDatosProduccion\\Settings", False)
        If Not key Is Nothing Then
            _Linea = key.GetValue("Linea")
            _AccionCambioTurno = key.GetValue("AccionCambioTurno")
            _AccionCambioOperario = key.GetValue("AccionCambioOperario")
            _AccionAveria = key.GetValue("AccionAveria")
            _AccionParada = key.GetValue("AccionParada")
            _CodigoLinea = key.GetValue("CodigoLinea")
            _AccionLoteado = key.GetValue("AccionLoteado")
            _AccionPesado = key.GetValue("AccionPesado")
            _AccionAjuste = key.GetValue("AccionAjuste")
            _AccionDefecto = key.GetValue("AccionDefecto")
        Else
            key = Registry.CurrentUser.CreateSubKey("Software\\VB and VBA Program Settings\\Gestion V.4\\TomaDatosProduccion\\Settings")
            key.SetValue("Linea", 0)
            key.SetValue("AccionCambioTurno", 0)
            key.SetValue("AccionCambioOperario", 0)
            key.SetValue("AccionAveria", 0)
            key.SetValue("AccionParada", 0)
            key.SetValue("CodigoLinea", "000")
            key.SetValue("AccionLoteado", 0)
            key.SetValue("AccionPesado", 0)
            key.SetValue("AccionAjuste", 0)
            key.SetValue("AccionDefecto", 0)
        End If
    End Sub
End Class