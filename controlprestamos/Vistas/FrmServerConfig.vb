Imports System.Data.SqlClient
Public Class FrmServerConfig

    Dim h As New Helpers()
    Dim c As New Configuracion()
    Dim app As New APP()
    Public instanciasql, usersql, clavesql, bdsql As String
    Dim errors As Int16
    Private Sub FrmServerConfig_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = app.APPNAME + " | CONFIGURACION DE SQL SERVER | "
        CheckInformation()
    End Sub

    Private Sub BtnProbarConexion_Click(sender As Object, e As EventArgs) Handles BtnProbarConexion.Click
        SetValues()
        Dim connection_string = "Server=" + instanciasql + ";Database=" + bdsql + ";User Id=" + usersql + ";Password=" + clavesql + " "
        Dim ConSQL As New SqlConnection(connection_string)

        Try
            ConSQL.Open()
            If ConSQL.State = ConnectionState.Open Then
                h.MsgSuccess("LA CONEXION DE PRUEBA SE REALIZO CORRECTAMENTE!")
                ConSQL.Close()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            h.MsgWarning("VERIFIQUE QUE LA INFORMACION INGRESADA SEA LA CORRECTA!")
        End Try
    End Sub

    Private Sub CheckInformation()
        Dim recorset As DataTable = c.Find("SERVER", "*")

        If recorset.Rows.Count > 0 Then
            Dim info As DataRow = recorset.Rows(0)
            TxtInstancia.Text = info("SERVER").ToString()
            TxtUsuarioSQL.Text = info("USUARIO").ToString()
            TxtClaveSQL.Text = info("CLAVE").ToString()
            TxtBD.Text = info("DATA").ToString()

            BtnGuardar.Enabled = False
            BtnEditar.Enabled = True
            BtnCancelar.Enabled = True
            BtnSalir.Enabled = True
        Else
            BtnGuardar.Enabled = True
            BtnEditar.Enabled = False
            BtnCancelar.Enabled = True
            BtnSalir.Enabled = True
            TxtInstancia.Select()
        End If
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        If errors = 0 Then
            SetValues()
            Dim fields, values As String
            fields = "SERVER, USUARIO, CLAVE, DATA"
            values = $"'{instanciasql}', '{usersql}', '{clavesql}', '{bdsql}'"

            If c.Save("SERVER", fields, values) > 0 Then
                h.MsgSuccess("LA CONFIGURACION SE GUARDO CORRECTAMENTE!")
                CheckInformation()
            End If
        End If
    End Sub

    Private Sub BtnEditar_Click(sender As Object, e As EventArgs) Handles BtnEditar.Click
        If errors = 0 Then
            SetValues()
            Dim values = $"SERVER='{instanciasql}', USUARIO='{usersql}', CLAVE='{clavesql}', DATA='{bdsql}'"

            If c.Update("SERVER", values) > 0 Then
                h.MsgSuccess("LOS CAMBIOS SE APLICARON CORRECTAMENTE!")
                CheckInformation()
            End If
        End If
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        Dim msg As String = "DESEA CANCELAR LA OPERACION EN CURSO?"
        If h.MsgQuestion(msg) = "S" Then
            LimpiarCampos()
        End If
    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Close()
        Dim login As New FrmLogin()
        login.Show()
    End Sub

    Private Sub SetValues()
        instanciasql = TxtInstancia.Text.Trim()
        usersql = TxtUsuarioSQL.Text.Trim()
        clavesql = TxtClaveSQL.Text.Trim()
        bdsql = TxtBD.Text.Trim()
    End Sub

    Private Sub LimpiarCampos()
        TxtInstancia.Clear()
        TxtBD.Clear()
        TxtUsuarioSQL.Clear()
        TxtClaveSQL.Clear()
    End Sub
End Class