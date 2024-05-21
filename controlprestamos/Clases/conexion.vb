Imports System.Data.SqlClient
Imports System.Data
Imports System.Windows.Forms
Public Class conexion
    Inherits ConexionOleDB
    Dim h As New Helpers()
    Dim conf As New Configuracion()

    Dim SERVER As String = conf.Hook("SERVER", "SERVER")
    Dim USUARIO As String = conf.Hook("USUARIO", "SERVER")
    Dim CLAVE As String = conf.Hook("CLAVE", "SERVER")
    Dim DATA As String = conf.Hook("DATA", "SERVER")
    Dim stringconnection As String = "Server=" + SERVER + ";Database=" + DATA + ";User Id=" + USUARIO + ";Password=" + CLAVE + " "
    Public CONSQL = New SqlConnection(stringconnection)

    Public Sub AbrirConexion()
        Try
            ConSQL.Open()
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString())
        End Try
    End Sub

    Public Sub CerrarConexion()
        Try
            ConSQL.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString())
        End Try
    End Sub

    Public Sub TerminarConexion()
        If ConSQL.State = ConnectionState.Open Then
            ConSQL.Close()
        End If
    End Sub
End Class
