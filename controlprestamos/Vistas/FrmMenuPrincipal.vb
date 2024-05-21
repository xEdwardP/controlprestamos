Public Class FrmMenuPrincipal
    Dim app As New APP
    Dim h As New Helpers
    Private Sub FrmMenuPrincipal_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        'Dim msg As String = "DESEA CERRAR LA APLICACION?"
        'If h.MsgQuestion(msg) = "S" Then
        '    Application.Exit()
        'End If
        Application.Exit()
    End Sub

    Private Sub FrmMenuPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetInfoInicial()
    End Sub

    Private Sub BtnDatosPersona_Click(sender As Object, e As EventArgs) Handles BtnDatosPersona.Click
        Dim datosp As New frmdatospersonas
        datosp.Show()
    End Sub

    Private Sub BtnPrestamos_Click(sender As Object, e As EventArgs) Handles BtnPrestamos.Click
        Dim prestamos As New frmprestamos
        prestamos.Show()
    End Sub

    Private Sub BtnUsuarios_Click(sender As Object, e As EventArgs) Handles BtnUsuarios.Click
        Dim usuarios As New frmusuarios
        usuarios.Show()
    End Sub

    Private Sub SetInfoInicial()
        Me.Text = app.APPNAME + " | MENU PRINCIPAL | "
        lblFecha.Text = DateTime.Today.ToLongDateString().ToUpper()
    End Sub

    Private Sub BtnEmpleados_Click(sender As Object, e As EventArgs) Handles BtnEmpleados.Click
        Dim empleados As New FrmEmpleados
        empleados.Show()
    End Sub
End Class