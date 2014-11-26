Imports System.ComponentModel
Imports Microsoft.Win32

Public Class miConfiguracion

    Sub New()

    End Sub

    Private _Linea As Integer

    <Category("General"), Description("Indique la linea de producción en donde se ubica este puesto.")> _
    Public Property Linea As Integer
        Set(value As Integer)
            _Linea = value
        End Set
        Get
            Return _Linea
        End Get
    End Property

    Public Function SaveSettings() As Boolean
        Dim key As RegistryKey = Registry.CurrentUser.OpenSubKey("Software\\VB and VBA Program Settings\\Gestion V.4\\TomaDatosProduccion\\Settings", True)
        If key Is Nothing Then
            key = Registry.CurrentUser.CreateSubKey("Software\\VB and VBA Program Settings\\Gestion V.4\\TomaDatosProduccion\\Settings")
        End If
        key.SetValue("Linea", _Linea)
    End Function

    Public Sub LoadSettings()
        Dim key As RegistryKey = Registry.CurrentUser.OpenSubKey("Software\\VB and VBA Program Settings\\Gestion V.4\\TomaDatosProduccion\\Settings", False)
        If Not key Is Nothing Then
            _Linea = key.GetValue("Linea")
        Else
            key = Registry.CurrentUser.CreateSubKey("Software\\VB and VBA Program Settings\\Gestion V.4\\TomaDatosProduccion\\Settings")
            key.SetValue("Linea", 0)
        End If
    End Sub
End Class