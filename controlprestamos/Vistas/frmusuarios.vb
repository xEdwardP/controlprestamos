Imports controlprestamos.Db
Public Class frmusuarios
    Dim db As New Db
    Dim h As New Helpers
    Dim app As New APP
    Dim usuar, clave, nombrec, genero, correo, fechanac As String
    Dim errorss As Int16

    Private Sub limpiarform()
        TxtUsuario.Clear()
        TxtClave.Clear()
        TxtNombre.Clear()
        DtpFechaNac.Text = DateTime.Today.ToShortDateString()
        CmbSexo.SelectedIndex = -1
        TxtCorreo.Clear()
    End Sub

    Private Sub frmusuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Boot()
        Me.Text = app.APPNAME + " | REGISTRAR USUARIO | "
    End Sub

    Private Sub BtnSearch_Click(sender As Object, e As EventArgs) Handles BtnSearch.Click
        Dim search As String = TxtSearch.Text.Trim()
        GetUsuarios(search)
    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Me.Close()
    End Sub

    Private Sub BtnGuardarr_Click(sender As Object, e As EventArgs) Handles BtnGuardarr.Click
        ValidarDatos()
        If errorss = 0 Then
            SetValues()
            Dim valores As String
            valores = $"'{usuar}','{clave}','{nombrec}','{fechanac}','{genero}','{correo}'"
            Dim fields As String = "Usuario, Clave, Nombre, FechaNac, Sexo, Correo"
            Dim res As Int32
            res = db.Save("Usuarios", fields, valores)
            If res > 0 Then
                h.MsgSuccess("EL USUARIO SE REGISTRO EXITOSAMENTE!")
                limpiarform()
                Boot()
            End If
        End If
    End Sub

    Private Sub DgvData_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvData.CellDoubleClick
        If DgvData.Rows.Count > 0 Then
            Dim id As String = DgvData.CurrentRow.Cells(0).Value.ToString()
            GetInfoUsuarios(id)
            BtnShowPassword.Enabled = True
        End If
    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        Dim msg As String = "¿DESEA ELIMINAR EL REGISTRO SELECCIONADO?"
        If h.MsgQuestion(msg) = "S" Then
            Dim idusuario As String = TxtUsuario.Text.Trim()
            If db.Delete("USUARIOS", "Usuario", idusuario) > 0 Then
                h.MsgSuccess("EL USUARIO SE ELIMINO CORRECTAMENTE!")
                limpiarform()
                Boot()
            End If
        End If
    End Sub

    Private Sub BtnEditar_Click(sender As Object, e As EventArgs) Handles BtnEditar.Click
        ValidarDatos()

        If errorss = 0 Then
            SetValues()
            Dim msg As String = "DESEA APLICAR LOS SIGUIENTES CAMBIOS!"

            If h.MsgQuestion(msg) = "S" Then
                Dim values As String = "Clave='" + clave + "',Nombre='" + nombrec + "',FechaNac='" + fechanac + "',Sexo='" + genero + "',Correo='" + correo + "'"
                Dim idusuario As String = TxtUsuario.Text.Trim()
                Dim condition As String = "Usuario='" + idusuario + "'"

                If db.Update("USUARIOS", values, condition) > 0 Then
                    h.MsgSuccess("LOS CAMBIOS SE APLICARON CORRECTAMENTE!")
                    limpiarform()
                    Boot()
                End If

            End If
        End If
    End Sub

    Private Sub SetValues()
        usuar = TxtUsuario.Text.Trim()
        clave = TxtClave.Text.Trim()
        nombrec = TxtNombre.Text.Trim()
        correo = TxtCorreo.Text.Trim()
        genero = CmbSexo.Text
        fechanac = DtpFechaNac.Text
    End Sub

    Private Sub ValidarDatos()
        SetValues()
        errorss = 0

        If usuar.Length = 0 Then
            h.MsgWarning("INGRESE EL NOMBRE DE USUARIO!")
            TxtUsuario.Select()
            errorss += 1
            Return
        End If
        If Clave.Length = 0 Then
            h.MsgWarning("INGRESE LA CLAVE DE USUARIO!")
            TxtUsuario.Select()
            errorss += 1
            Return
        End If
        If nombrec.Length = 0 Then
            h.MsgWarning("INGRESE EL NOMBRE DE USUARIO!")
            TxtNombre.Select()
            errorss += 1
            Return
        End If
        If genero = "" Then
            h.MsgWarning("SELECCIONE EL GENERO DEL USUARIO!")
            CmbSexo.Select()
            errorss += 1
            Return
        End If
        If Correo.Length = 0 Then
            h.MsgWarning("INGRESE EL CORREO DEL USUARIO!")
            TxtCorreo.Select()
            errorss += 1
            Return
        End If
    End Sub

    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click
        BtnNuevo.Enabled = False
        BtnGuardarr.Enabled = True
        BtnEditar.Enabled = False
        BtnEliminar.Enabled = False
        BtnCancelar.Enabled = True
        BtnSalir.Enabled = False
        EnabledControls()
        TxtSearch.Enabled = False
        BtnSearch.Enabled = False
        TxtUsuario.Select()
        BtnShowPassword.Enabled = True
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        Dim msg As String = "¿DESEA CANCELAR LA OPERACION EN CURSO?"
        If h.MsgQuestion(msg) = "S" Then
            limpiarform()
            Boot()
        End If
    End Sub

    Private Sub BtnShowPassword_Click(sender As Object, e As EventArgs) Handles BtnShowPassword.Click
        If TxtClave.UseSystemPasswordChar = TxtClave.UseSystemPasswordChar = True Then
            TxtClave.UseSystemPasswordChar = TxtClave.UseSystemPasswordChar = False
        End If
    End Sub

    Private Sub TxtSearch_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtSearch.KeyDown
        If e.KeyCode = Keys.Enter Then
            BtnSearch.PerformClick()
        End If
    End Sub

    Private Function GetUsuarios(Optional ByVal search As String = "")
        Dim condition As String = ""
        If search = "" Then
            condition = "DEL='N' AND usuario<>'Admin'"
        Else
            condition = "Usuario LIKE '%" + search + "%' AND Del='N' AND Usuario<>'Admin'"
        End If

        Dim fields As String = "Usuario, Nombre, Del"

        Dim data As DataTable
        data = db.Find("USUARIOS", fields, condition)

        If data.Rows.Count > 0 Then
            Dim _usuario, _nombrec
            DgvData.Rows.Clear()

            For Each row As DataRow In data.Rows
                _usuario = row("Usuario").ToString()
                _nombrec = row("Nombre").ToString()

                DgvData.Rows.Add(_usuario, _nombrec)
            Next
            data.Dispose()
        Else
            h.MsgWarning("NO SE ENCONTRARON COINCIDENCIAS!")
            TxtSearch.Select()
        End If
    End Function

    Private Function GetInfoUsuarios(id As String)
        Dim condition As String = "Usuario='" + id + "' AND Del='N'"
        Dim data As DataTable = db.Find("USUARIOS", "*", condition)

        If data.Rows.Count > 0 Then
            Dim info As DataRow = data.Rows(0)
            TxtUsuario.Text = info("Usuario").ToString()
            TxtClave.Text = info("Clave").ToString()
            TxtNombre.Text = info("Nombre").ToString()
            TxtCorreo.Text = info("Correo").ToString()
            CmbSexo.Text = info("Sexo").ToString()
            DtpFechaNac.Value = info("FechaNac").ToString()

            BtnNuevo.Enabled = False
            BtnGuardarr.Enabled = False
            BtnEditar.Enabled = True
            BtnEliminar.Enabled = True
            BtnCancelar.Enabled = True
            BtnSalir.Enabled = False

            EnabledControls()
            TxtUsuario.Enabled = False

        Else
            h.MsgWarning("ERROR AL RECUPERAR LOS DATOS DEL REGISTRO SELECCIONADO!")
        End If
    End Function

    Private Sub Boot()
        DgvData.Rows.Clear()
        BtnNuevo.Enabled = True
        BtnGuardarr.Enabled = False
        BtnEditar.Enabled = False
        BtnEliminar.Enabled = False
        BtnCancelar.Enabled = False
        BtnSalir.Enabled = True
        DisableControls()
        TxtSearch.Enabled = True
        BtnSearch.Enabled = True
        TxtSearch.Select()
        BtnShowPassword.Enabled = False
    End Sub

    Private Sub DisableControls()
        TxtUsuario.Enabled = False
        TxtClave.Enabled = False
        TxtNombre.Enabled = False
        TxtCorreo.Enabled = False
        CmbSexo.Enabled = False
        DtpFechaNac.Enabled = False
    End Sub

    Private Sub EnabledControls()
        TxtUsuario.Enabled = True
        TxtClave.Enabled = True
        TxtNombre.Enabled = True
        TxtCorreo.Enabled = True
        CmbSexo.Enabled = True
        DtpFechaNac.Enabled = True
    End Sub

    'Private Sub UpdateUserEmpleados()
    '    Dim iduser As String =
    '    db.RawSQL("UPDATE EMPLEADOS SET USUARIO='" + +"'")
    'End Sub
End Class