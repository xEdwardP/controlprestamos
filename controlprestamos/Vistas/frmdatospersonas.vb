Imports controlprestamos.Db
Public Class frmdatospersonas
    Dim db As New Db
    Dim h As New Helpers
    Dim identidad, tipoid, tipo, nombre, direccion, telefono, correo As String
    Dim errors As Int16
    Dim app As New APP
    Private Sub frmdatospersonas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Boot()
        Me.Text = app.APPNAME + " | REGISTRAR PERSONA | "
    End Sub

    Private Sub limpiarForm()
        TxtIdentidad.Clear()
        CmbtipoId.SelectedIndex = -1
        CmbTipo.SelectedIndex = -1
        TxtNombre.Clear()
        TxtDireccion.Clear()
        TxtTelefono.Clear()
        TxtCorreo.Clear()
    End Sub

    Private Sub BtnGuardarr_Click(sender As Object, e As EventArgs) Handles BtnGuardarr.Click
        ValidarDatos()

        If errors = 0 Then
            SetValues()
            Dim values As String = "'" + identidad + "', '" + nombre + "', '" + direccion + "', '" + correo + "', '" + telefono + "', '" + tipoid + "', '" + tipo + "'"
            Dim fields As String = "IDENTIDAD, NOMBRE, DIRECCION, CORREO, TELEFONO, TIPOID, TIPO"

            If db.Save("DATOSPERSONA", fields, values) > 0 Then
                h.MsgSuccess("LOS DATOS SE REGISTRARON EXITOSAMENTE!")
                limpiarForm()
                Boot()
            End If
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
        TxtIdentidad.Select()
    End Sub

    Private Sub BtnEditar_Click(sender As Object, e As EventArgs) Handles BtnEditar.Click
        ValidarDatos()
        If errors = 0 Then
            SetValues()
            Dim msg As String = "DESEA APLICAR LOS SIGUIENTES CAMBIOS?"
            If h.MsgQuestion(msg) = "S" Then
                Dim valores As String = $"NOMBRE='{nombre}', DIRECCION='{direccion}', CORREO='{correo}', TELEFONO='{telefono}', TIPO='{tipo}', TIPOID='{tipoid}'"
                Dim idpersona As String = TxtIdentidad.Text.Trim()
                Dim condicion As String = "IDENTIDAD ='" + identidad + "'"

                If db.Update("DATOSPERSONA", valores, condicion) > 0 Then
                    h.MsgSuccess("LOS CAMBIOS SE APLICARON CORRECTAMENTE!")
                    limpiarForm()
                    Boot()
                End If
            End If
        End If
    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        Dim msg As String = "¿DESEA ELIMINAR EL REGISTRO SELECCIONADO?"
        If h.MsgQuestion(msg) = "S" Then
            Dim idpersona As String = TxtIdentidad.Text.Trim()
            If db.Delete("DATOSPERSONA", "IDENTIDAD", idpersona) > 0 Then
                h.MsgSuccess("LA INFORMACION SE ELIMINO CORRECTAMENTE!")
                limpiarForm()
                Boot()
            End If
        End If
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        Dim msg As String = "¿DESEA CANCELAR LA OPERACION EN CURSO?"
        If h.MsgQuestion(msg) = "S" Then
            limpiarForm()
            Boot()
        End If
    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Close()
    End Sub

    Private Sub GetDatosPersona(Optional ByVal search As String = "")
        Dim condition As String = ""
        Dim fields As String = "IDENTIDAD, NOMBRE, TELEFONO"
        If search = "" Then
            condition = "DEL='N'"

        Else
            condition = "NOMBRE LIKE '%" + search + "%' AND DEL='N'"
        End If

        Dim data As DataTable = db.Find("DATOSPERSONA", fields, condition)

        If data.Rows.Count > 0 Then
            Dim _identidad, _nombre, _telefono
            DgvPersonas.Rows.Clear()

            For Each row As DataRow In data.Rows
                _identidad = row("IDENTIDAD").ToString()
                _nombre = row("NOMBRE").ToString()
                _telefono = row("TELEFONO").ToString()

                DgvPersonas.Rows.Add(_identidad, _nombre, _telefono)
            Next
            data.Dispose()

        Else
            h.MsgWarning("NO SE ENCONTRARON COINCIDENCIAS!")
            TxtSearch.Select()
        End If
    End Sub

    Private Sub DgvPersonas_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvPersonas.CellDoubleClick
        If DgvPersonas.Rows.Count > 0 Then
            Dim id As String = DgvPersonas.CurrentRow.Cells(0).Value.ToString()
            GetInfoPersonas(id)
        End If
    End Sub

    Private Sub BtnSearch_Click(sender As Object, e As EventArgs) Handles BtnSearch.Click
        Dim search As String = TxtSearch.Text.Trim()
        GetDatosPersona(search)
    End Sub

    Private Sub TxtSearch_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtSearch.KeyDown
        If e.KeyCode = Keys.Enter Then
            BtnSearch.PerformClick()
        End If
    End Sub

    Private Sub SetValues()
        errors = 0

        identidad = TxtIdentidad.Text
        tipoid = CmbtipoId.Text
        tipo = CmbTipo.Text
        nombre = TxtNombre.Text
        direccion = TxtDireccion.Text
        telefono = TxtTelefono.Text
        correo = TxtCorreo.Text
    End Sub

    Private Sub Boot()
        DgvPersonas.Rows.Clear()
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
    End Sub

    Private Sub EnabledControls()
        TxtIdentidad.Enabled = True
        TxtNombre.Enabled = True
        TxtDireccion.Enabled = True
        TxtCorreo.Enabled = True
        TxtTelefono.Enabled = True
        CmbTipo.Enabled = True
        CmbtipoId.Enabled = True
    End Sub

    Private Sub DisableControls()
        TxtIdentidad.Enabled = False
        TxtNombre.Enabled = False
        TxtDireccion.Enabled = False
        TxtCorreo.Enabled = False
        TxtTelefono.Enabled = False
        CmbTipo.Enabled = False
        CmbtipoId.Enabled = False
    End Sub

    Private Function GetInfoPersonas(id As String)
        Dim condition As String = "IDENTIDAD='" + id + "' AND DEL='N'"
        Dim data As DataTable = db.Find("DATOSPERSONA", "*", condition)

        If data.Rows.Count > 0 Then
            Dim info As DataRow = data.Rows(0)
            TxtIdentidad.Text = info("IDENTIDAD").ToString()
            TxtNombre.Text = info("NOMBRE").ToString()
            TxtDireccion.Text = info("DIRECCION").ToString()
            TxtCorreo.Text = info("CORREO").ToString()
            TxtTelefono.Text = info("TELEFONO").ToString()
            CmbTipo.Text = info("TIPO").ToString()
            CmbtipoId.Text = info("TIPOID").ToString()

            BtnNuevo.Enabled = False
            BtnGuardarr.Enabled = False
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

    Private Sub ValidarDatos()
        SetValues()
        errors = 0

        If identidad.Length < 13 Then
            h.MsgWarning("INGRESE UN No. DE IDENTIDAD VALIDO!")
            TxtIdentidad.Select()
            errors += 1
            Return
        End If
        If nombre.Length = 0 Then
            h.MsgWarning("INGRESE EL NOMBRE!")
            TxtNombre.Select()
            errors += 1
            Return
        End If
        If direccion.Length = 0 Then
            h.MsgWarning("INGRESE LA DIRECCION!")
            TxtDireccion.Select()
            errors += 1
            Return
        End If
        If correo.Length = 0 Then
            h.MsgWarning("INGRESE EL CORREO!")
            TxtCorreo.Select()
            errors += 1
            Return
        End If
        If telefono.Length < 8 Then
            h.MsgWarning("INGRESE UN No. DE TELEFONO VALIDO!")
            TxtTelefono.Select()
            errors += 1
            Return
        End If
        If CmbTipo.Text = "" Then
            h.MsgWarning("SELECCIONE EL TIPO!")
            CmbTipo.Select()
            errors += 1
            Return
        End If
        If CmbtipoId.Text = "" Then
            h.MsgWarning("SELECCIONE EL TIPO DE ID!")
            CmbtipoId.Select()
            errors += 1
            Return
        End If
    End Sub
End Class