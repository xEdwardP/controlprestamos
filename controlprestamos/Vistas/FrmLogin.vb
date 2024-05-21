Imports System.Data
Imports System.Windows.Forms
Imports System.Threading.Tasks
Public Class FrmLogin
    'Instancias
    Dim h As New Helpers
    Dim db As Db
    Dim auth As New Auth
    Dim app As New APP
    Dim bs As New BootStrapper()
    'Variables
    Dim errors As UInt32
    Dim usuario, clave As String

    Private Sub FrmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Boot()
    End Sub

    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles BtnLogin.Click
        ValidarDatos()
        usuario = TxtUsuario.Text.Trim()
        clave = TxtClave.Text.Trim()
        auth.MakeLogin(usuario, clave)

        If errors = 0 Then
            If auth.MakeLogin(usuario, clave) = True Then
                Dim principal As New FrmMenuPrincipal
                principal.Show()
                Me.Hide()

            Else
                TxtUsuario.Select()
            End If
        End If

    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        Application.Exit()
    End Sub

    Private Sub BtnShowPassword_Click(sender As Object, e As EventArgs) Handles BtnShowPassword.Click
        If TxtClave.UseSystemPasswordChar = TxtClave.UseSystemPasswordChar = True Then
            TxtClave.UseSystemPasswordChar = TxtClave.UseSystemPasswordChar = False
        End If
    End Sub

    Private Sub TxtClave_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtClave.KeyDown
        If e.KeyCode = Keys.Enter Then
            BtnLogin.PerformClick()
        End If
    End Sub

    Private Sub BtnConfiguracion_Click(sender As Object, e As EventArgs) Handles BtnConfiguracion.Click
        Me.Hide()
        Dim loginconfig As New FrmLoginConfiguracion
        loginconfig.Show()
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

    Private Sub Boot()
        Me.Text = app.APPNAME + " | INICIAR SESION | "
        bs.CheckFileConfiguration()
        If bs.ValidarConfiguracion = "False" Then
            h.MsgWarning("NO SE ENCONTRO INFORMACION DE SQL SERVER, POR FAVOR INGRESELA O CONTACTE AL ADMINISTRADOR!")
            BtnLogin.Enabled = False
        ElseIf bs.ValidarConfiguracion = "True" Then
            BtnLogin.Enabled = True
        End If
    End Sub
End Class