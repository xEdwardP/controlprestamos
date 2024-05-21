Public Class FrmEmpleados
    'Instancias
    Dim app As New APP
    Dim db As New Db
    Dim h As New Helpers

    'Variables
    Dim identidad, nombre, direccion, correo, telefono, fechanac, genero, tipo As String
    Dim errors As Int16

    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click
        BtnNuevo.Enabled = False
        BtnGuardar.Enabled = True
        BtnEditar.Enabled = False
        BtnEliminar.Enabled = False
        BtnCancelar.Enabled = True
        BtnSalir.Enabled = False
        EnabledControls()
        TxtBuscar.Enabled = False
        BtnBuscar.Enabled = False
        TxtIdentidad.Select()
    End Sub

    Private Sub FrmEmpleados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = app.APPNAME + " | REGISTRAR EMPLEADOS |"
        Boot()
    End Sub

    Private Sub BtnEditar_Click(sender As Object, e As EventArgs) Handles BtnEditar.Click
        ValidarDatos()

        If errors = 0 Then
            SetValues()
            Dim msg As String = "DESEA APLICAR LOS SIGUIENTES CAMBIOS!"
            If h.MsgQuestion(msg) = "S" Then
                Dim values = $"NOMBRE='{nombre}', DIRECCION='{direccion}', CORREO='{correo}', TELEFONO='{telefono}', FECHANAC='{fechanac}', GENERO='{genero}', TIPO='{tipo}'"
                Dim idempleado = TxtIdentidad.Text.Trim()
                Dim condition As String = "IDENTIDAD='" + idempleado + "'"

                If db.Update("EMPLEADOS", values, condition) > 0 Then
                    h.MsgSuccess("LOS CAMBIOS SE APLICARON CORRECTAMENTE!")
                    LimpiarCampos()
                    Boot()
                End If
            End If
        End If
    End Sub

    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click
        Dim search As String = TxtBuscar.Text.Trim()
        GetEmpleados(search)
    End Sub

    Private Sub TxtBuscar_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtBuscar.KeyDown
        If e.KeyCode = Keys.Enter Then
            BtnBuscar.PerformClick()
        End If
    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        Dim msg As String = "¿DESEA ELIMINAR EL REGISTRO SELECCIONADO?"
        If h.MsgQuestion(msg) = "S" Then
            Dim idempleado As String = TxtIdentidad.Text.Trim()
            If db.Delete("EMPLEADOS", "IDENTIDAD", idempleado) > 0 Then
                h.MsgSuccess("EL USUARIO SE ELIMINO CORRECTAMENTE!")
                LimpiarCampos()
                Boot()
            End If
        End If
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        Dim msg As String = "¿DESEA CANCELAR LA OPERACION EN CURSO?"
        If h.MsgQuestion(msg) = "S" Then
            LimpiarCampos()
            Boot()
        End If
    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Close()
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        ValidarDatos()
        If errors = 0 Then
            SetValues()
            Dim values, fields
            values = $"'{identidad}', '{nombre}', '{direccion}', '{correo}', '{telefono}', '{fechanac}', '{genero}', '{tipo}'"
            fields = "IDENTIDAD, NOMBRE, DIRECCION, CORREO, TELEFONO, FECHANAC, GENERO, TIPO"
            If db.Save("EMPLEADOS", fields, values) > 0 Then
                h.MsgSuccess("EL EMPLEADO " + nombre + " SE REGISTRO CORRECTAMENTE!")
                LimpiarCampos()
                Boot()
            End If
        End If
    End Sub

    Private Sub LimpiarCampos()
        TxtIdentidad.Clear()
        TxtNombre.Clear()
        TxtDireccion.Clear()
        TxtCorreo.Clear()
        TxtTelefono.Clear()
        DtpFechaNac.ResetText()
        CmbGenero.SelectedIndex = -1
        CmbTipo.SelectedIndex = -1
    End Sub

    Private Sub DgvData_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvData.CellDoubleClick
        If DgvData.Rows.Count > 0 Then
            Dim id As String = DgvData.CurrentRow.Cells(0).Value.ToString()
            GetInfoEmpleados(id)
        End If
    End Sub

    Private Sub EnabledControls()
        TxtIdentidad.Enabled = True
        TxtNombre.Enabled = True
        TxtDireccion.Enabled = True
        TxtCorreo.Enabled = True
        TxtTelefono.Enabled = True
        DtpFechaNac.Enabled = True
        CmbGenero.Enabled = True
        CmbTipo.Enabled = True
    End Sub

    Private Sub DisabledControls()
        TxtIdentidad.Enabled = False
        TxtNombre.Enabled = False
        TxtDireccion.Enabled = False
        TxtCorreo.Enabled = False
        TxtTelefono.Enabled = False
        DtpFechaNac.Enabled = False
        CmbGenero.Enabled = False
        CmbTipo.Enabled = False
    End Sub

    Private Function GetEmpleados(Optional ByVal search As String = "") As String
        Dim condicion As String = ""
        Dim fields As String = "IDENTIDAD, NOMBRE, TIPO"

        If search = "" Then
            condicion = "DEL='N'"
        Else
            condicion = "NOMBRE LIKE '%" + search + "%' AND DEL='N'"
        End If

        Dim data As DataTable = db.Find("EMPLEADOS", fields, condicion)

        If data.Rows.Count > 0 Then
            Dim i As Int16
            Dim _identidad, _nombre, _tipo
            DgvData.Rows.Clear()

            For Each row As DataRow In data.Rows
                _identidad = row("IDENTIDAD").ToString()
                _nombre = row("NOMBRE").ToString()
                _tipo = row("TIPO").ToString()

                DgvData.Rows.Add(_identidad, _nombre, _tipo)
            Next
            data.Dispose()
        Else
            h.MsgWarning("NO SE ENCONTRARON COINCIDENCIAS!")
            TxtBuscar.Clear()
        End If
    End Function

    Private Function GetInfoEmpleados(id As String)
        Dim condition As String = "IDENTIDAD='" + id + "' AND DEL='N'"
        Dim data As DataTable = db.Find("EMPLEADOS", "*", condition)

        If data.Rows.Count > 0 Then
            Dim info As DataRow = data.Rows(0)
            TxtIdentidad.Text = info("IDENTIDAD").ToString()
            TxtNombre.Text = info("NOMBRE").ToString()
            TxtDireccion.Text = info("DIRECCION").ToString()
            TxtCorreo.Text = info("CORREO").ToString()
            TxtTelefono.Text = info("TELEFONO").ToString()
            DtpFechaNac.Value = info("FECHANAC").ToString()
            CmbGenero.Text = info("GENERO").ToString()
            CmbTipo.Text = info("TIPO").ToString()

            BtnNuevo.Enabled = False
            BtnGuardar.Enabled = False
            BtnEditar.Enabled = True
            BtnEliminar.Enabled = True
            BtnCancelar.Enabled = True
            BtnSalir.Enabled = False

            EnabledControls()
            TxtIdentidad.Enabled = False
        Else
            h.MsgWarning("ERROR AL RECUPERAR LOS DATOS DEL REGISTRO SELECCIONADO!")
        End If
    End Function

    Private Sub SetValues()
        identidad = TxtIdentidad.Text.Trim()
        nombre = TxtNombre.Text.Trim()
        direccion = TxtDireccion.Text.Trim()
        correo = TxtCorreo.Text.Trim()
        telefono = TxtTelefono.Text.Trim()
        fechanac = DtpFechaNac.Text
        genero = CmbGenero.Text
        tipo = CmbTipo.Text
    End Sub

    Private Sub ValidarDatos()
        SetValues()
        errors = 0

        If identidad.Length = 0 Then
            h.MsgWarning("INGRESE EL No. DE IDENTIDAD DEL EMPLEADO!")
            TxtIdentidad.Select()
            errors += 1
            Return
        End If
        If nombre.Length = 0 Then
            h.MsgWarning("INGRESE EL NOMBRE DEL EMPLEADO!")
            TxtNombre.Select()
            errors += 1
            Return
        End If
        If direccion.Length = 0 Then
            h.MsgWarning("IGRESE LA DIRECCION DEL EMPLEADO!")
            TxtDireccion.Select()
            errors += 1
            Return
        End If
        If correo.Length = 0 Then
            h.MsgWarning("INGRESE EL CORREO DEL EMPLEADO!")
            TxtCorreo.Select()
            errors += 1
        End If
        If telefono.Length = 0 Then
            h.MsgWarning("INGRESE EL No. DE TELEFONO DEL CLIENTE!")
            TxtTelefono.Select()
            errors += 1
            Return
        End If
        If genero.Length = 0 Then
            h.MsgWarning("SELECCIONE EL GENERO DEL EMPLEADO!")
            CmbGenero.Select()
            errors += 1
            Return
        End If
        If tipo.Length = 0 Then
            h.MsgWarning("SELECCIONE EL TIPO DE ACCESO AL SISTEMA DEL EMPLEADO!")
            CmbTipo.Select()
            errors += 1
            Return
        End If
    End Sub

    Private Sub Boot()
        DgvData.Rows.Clear()
        BtnNuevo.Enabled = True
        BtnGuardar.Enabled = False
        BtnEditar.Enabled = False
        BtnEliminar.Enabled = False
        BtnCancelar.Enabled = False
        BtnSalir.Enabled = True
        DisabledControls()
        TxtBuscar.Enabled = True
        BtnBuscar.Enabled = True
        TxtBuscar.Select()
    End Sub

End Class