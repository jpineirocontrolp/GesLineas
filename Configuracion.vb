Imports System.ComponentModel
Imports Microsoft.Win32

Public Class miConfiguracion

    Sub New()

    End Sub
    Private _Linea As Integer
    Private _AccionCambioTurno As Integer
    Private _AccionCambioOperario As Integer
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
    Public Sub SaveSettings()
        Dim key As RegistryKey = Registry.CurrentUser.OpenSubKey("Software\\VB and VBA Program Settings\\Gestion V.4\\TomaDatosProduccion\\Settings", True)
        If key Is Nothing Then
            key = Registry.CurrentUser.CreateSubKey("Software\\VB and VBA Program Settings\\Gestion V.4\\TomaDatosProduccion\\Settings")
        End If
        key.SetValue("Linea", _Linea)
        key.SetValue("AccionCambioTurno", _AccionCambioTurno)
        key.SetValue("AccionCambioOperario", _AccionCambioOperario)
    End Sub

    Public Sub LoadSettings()
        Dim key As RegistryKey = Registry.CurrentUser.OpenSubKey("Software\\VB and VBA Program Settings\\Gestion V.4\\TomaDatosProduccion\\Settings", False)
        If Not key Is Nothing Then
            _Linea = key.GetValue("Linea")
            _AccionCambioTurno = key.GetValue("AccionCambioTurno")
            _AccionCambioOperario = key.GetValue("AccionCambioOperario")
        Else
            key = Registry.CurrentUser.CreateSubKey("Software\\VB and VBA Program Settings\\Gestion V.4\\TomaDatosProduccion\\Settings")
            key.SetValue("Linea", 0)
            key.SetValue("AccionCambioTurno", 0)
            key.SetValue("AccionCambioOperario", 0)
        End If
    End Sub
End Class