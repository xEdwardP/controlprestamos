Public Class FrmLoginConfiguracion
    Dim app As New APP()
    Dim h As New Helpers()
    Dim c As New Configuracion()
    Dim errors As Int16
    Dim usuario, clave As String
    Private Sub FrmLoginConfiguracion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = app.APPNAME + " | INICIAR SESION | " + " | CONFIGURACION |"
    End Sub

    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles BtnLogin.Click
        ValidarDatos()
        usuario = TxtUsuario.Text.Trim()
        clave = TxtClave.Text.Trim()

        Dim recordset As DataTable = c.Find("USUARIOS", "*", "USUARIO='" + usuario + "'")

        If recordset.Rows.Count > 0 Then
            Dim user As DataRow = recordset.Rows(0)

            If user("USUARIO").ToString() = usuario And user("CLAVE").ToString() = clave Then
                Dim config As New FrmServerConfig
                config.Show()
                Me.Hide()
            Else
                h.MsgWarning("LAS CREDENCIALES INGRESADAS SON INCORRECTAS!")
            End If
        Else
            h.MsgWarning("LAS CREDENCIALES INGRESADAS SON INCORRECTAS")
        End If
        recordset.Dispose()
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        Dim login As New FrmLogin()
        login.Show()
        Me.Hide()
    End Sub

    Private Sub BtnShowPassword_Click(sender As Object, e As EventArgs) Handles BtnShowPassword.Click
        If TxtClave.UseSystemPasswordChar = TxtClave.UseSystemPasswordChar = True Then
            TxtClave.UseSystemPasswordChar = TxtClave.UseSystemPasswordChar = False
        End If
    End Sub

    Private Sub ValidarDatos()
        errors = 0
        usuario = TxtUsuario.Text
        clave = TxtClave.Text

        If usuario.Length = 0 Then
            h.MsgWarning("INGRESE EL NOMBRE DE USUARIO!")
            TxtUsuario.Select()
            errors += 1
            Return
        End If
        If clave.Length = 0 Then
            h.MsgWarning("INGRESE UNA CLAVE VALIDA!")
            clave = TxtClave.Text.Trim()
            errors += 1
            Return
        End If
    End Sub
End Class