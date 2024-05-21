Imports controlprestamos.Db
Imports clo
Public Class frmprestamos
    Dim db As New Db
    Dim h As New Helpers
    Dim app As New APP

    Dim idprestamo, identidad, nombre, fecha, tipo, estado As String
    Dim monto, tasai, Plazo As Double
    Dim deudatotal, cuota, intereses, capital As Double
    Dim idcorre As String = "PREST"
    Dim errors As Int32 = 0
    Private Sub frmprestamos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Boot()
        Me.Text = app.APPNAME + " | REGISTRAR PRESTAMO |"
    End Sub

    Private Sub limpiarform()
        TxtIdPrestamo.Clear()
        TxtIdentidad.Clear()
        TxtNombre.Clear()
        CmbTipo.SelectedIndex = -1
        TxtMonto.Clear()
        TxtTasa.Clear()
        TxtPlazo.Clear()

    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        Dim msg As String = "¿DESEA CANCELAR LA OPERACION EN CURSO?"
        If h.MsgQuestion(msg) = "S" Then
            limpiarform()
            Boot()
        End If
    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Me.Close()
    End Sub

    Private Sub BtnGestionarCuotas_Click(sender As Object, e As EventArgs) Handles BtnGestionarCuotas.Click
        If DgvData.Rows.Count > 0 Then
            Dim idprestamo As String
            idprestamo = DgvData.CurrentRow.Cells(0).Value.ToString

            Dim cuotas As New FrmPrestamosyCuotas

            Me.AddOwnedForm(cuotas)
            cuotas.idprestamos = idprestamo
            cuotas.ShowDialog()
        End If
    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        Dim msg As String = "¿DESEA ELIMINAR EL REGISTRO SELECCIONADO?"
        If h.MsgQuestion(msg) = "S" Then
            Dim idpt = TxtIdPrestamo.Text.Trim()
            If db.Delete("Prestamos", "IDPRESTAMO", idpt) > 0 Then
                db.RawSQL("UPDATE LETRAS SET DEL='S' WHERE IDPRESTAMO = '" + idpt + "'")
                h.MsgSuccess("LA INFORMACION SE ELIMINO CORRECTAMENTE!")
                limpiarform()
                Boot()
            End If
        End If
    End Sub

    Private Sub DgvData_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvData.CellDoubleClick
        If DgvData.Rows.Count > 0 Then
            Dim id As String = DgvData.CurrentRow.Cells(0).Value.ToString()
            GetInfoPrestamos(id)
            'LblResumen
            Dim idpt As String = TxtIdPrestamo.Text.Trim()
            Dim canceladas, pendientes As String
            Dim condicionA = "IDPRESTAMO='" + idpt + "' AND ESTADO='CANCELADO'"
            canceladas = db.GetNumRows("LETRAS", condicionA)
            Dim condicionB = "IDPRESTAMO='" + idpt + "' AND ESTADO='PENDIENTE'"
            pendientes = db.GetNumRows("LETRAS", condicionB)
            LblResumen.Text = "HAY " + canceladas + " CUOTAS CANCELADAS Y " + pendientes + " CUOTAS PENDIENTES"
        End If
    End Sub

    Private Sub TxtIdentidad_TextChanged(sender As Object, e As EventArgs) Handles TxtIdentidad.TextChanged
        If TxtIdentidad.Text.Length > 12 Then
            Dim condition As String = $"IDENTIDAD='{TxtIdentidad.Text.Trim()}'"
            Dim nombreb As String = db.Hook("NOMBRE", "DATOSPERSONA", condition)
            TxtNombre.Text = nombreb.ToString()
        Else
            TxtNombre.Clear()
        End If
    End Sub

    Private Sub TxtIdentidad_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtIdentidad.KeyDown
        If e.KeyCode = Keys.Enter And TxtIdentidad.Text.Length > 12 Then
            Dim condition As String = $"IDENTIDAD='{TxtIdentidad.Text.Trim()}'"
            Dim nombreb As String = db.Hook("NOMBRE", "DATOSPERSONA", condition)
            TxtNombre.Text = nombreb.ToString()
        End If

    End Sub

    Private Sub BtnGuardarr_Click(sender As Object, e As EventArgs) Handles BtnGuardarr.Click
        If errors = 0 Then
            SetValues()
            Dim fields As String = "IDPRESTAMO, IDENTIDAD, NOMBRE, FECHA, TIPO, MONTO, TASAI, PLAZO, CAPITAL, INTERESES"
            Dim values = $"'{idprestamo}', '{identidad}', '{nombre}', '{fecha}', '{tipo}', {monto}, {tasai}, {Plazo}, {capital}, {intereses}"
            If db.Save("Prestamos", fields, values) > 0 Then
                h.MsgSuccess("EL PRESTAMO SE REGISTRO EXITOSAMENTE!")
                Operacion()
                If ChkAutoGen.Checked = True Then
                    db.SetLast(idcorre)
                End If
                limpiarform()
                Boot()
            End If
        End If
    End Sub

    Private Sub TxtIdentidad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtIdentidad.KeyPress
        'e.Handled = (IIf(h.GetOnlyNumbers(e), False, True))
    End Sub

    Private Sub TxtSearch_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtSearch.KeyDown
        If e.KeyCode = Keys.Enter Then
            BtnSearch.PerformClick()
        End If
    End Sub

    Private Sub BtnExportar_Click(sender As Object, e As EventArgs) Handles BtnExportar.Click
        Dim export As New Export
        export.DgvExcel(DgvData)
    End Sub

    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click
        BtnNuevo.Enabled = False
        BtnGuardarr.Enabled = True
        BtnEliminar.Enabled = False
        BtnCancelar.Enabled = True
        BtnSalir.Enabled = False
        EnabledControls()
        AutoGenCodigo()
        TxtSearch.Enabled = False
        BtnSearch.Enabled = False
        TxtIdPrestamo.Select()
        ChkAutoGen.Enabled = False
    End Sub

    'Metodo con el que inicia el formulario
    Private Sub Boot()
        LblResumen.Text = ""
        DgvData.Rows.Clear()
        BtnNuevo.Enabled = True
        BtnGuardarr.Enabled = False
        BtnEliminar.Enabled = False
        BtnCancelar.Enabled = False
        BtnSalir.Enabled = True
        DisabledControls()
        TxtSearch.Enabled = True
        BtnSearch.Enabled = True
        TxtSearch.Select()
        ChkAutoGen.Enabled = True
    End Sub

    'Metodo que muestra informacion en el datagriedview
    Public Function GetPrestamos(Optional ByVal search As String = "")
        Dim condition As String = ""

        If search = "" Then
            condition = "DEL='N'"
        Else
            condition = "NOMBRE LIKE '%" + search + "%' AND DEL='N'"
        End If

        Dim data As DataTable = db.Find("PRESTAMOS", "*", condition)

        If data.Rows.Count > 0 Then
            Dim _referencia, _identidad, _nombre, _fecha, _tipo, _tasai, _plazo, _estado As String
            Dim _monto, _capital, _intereses As Double
            DgvData.Rows.Clear()

            For Each row As DataRow In data.Rows
                _referencia = row("IDPRESTAMO").ToString()
                _identidad = row("IDENTIDAD").ToString()
                _nombre = row("NOMBRE").ToString()
                _fecha = Convert.ToDateTime(row("FECHA")).ToShortDateString()
                _tipo = row("TIPO").ToString()
                _monto = row("MONTO").ToString()
                _tasai = row("TASAI").ToString()
                _plazo = row("PLAZO").ToString()
                _capital = row("CAPITAL").ToString()
                _intereses = row("INTERESES").ToString()
                _estado = row("ESTADO").ToString()

                DgvData.Rows.Add(_referencia, _identidad, _nombre, _fecha, _tipo, _monto.ToString("N2"), _tasai, _plazo, _capital.ToString("N2"), _intereses.ToString("N2"), _estado)
            Next
            data.Dispose()

        Else
            h.MsgWarning("NO SE ENCONTRARON COINCIDENCIAS!")
            TxtSearch.Select()
        End If
    End Function

    Private Sub BtnSearch_Click(sender As Object, e As EventArgs) Handles BtnSearch.Click
        Dim search As String = TxtSearch.Text.Trim()
        GetPrestamos(search)
    End Sub

    'Metodo que inserta a las variable valores
    Private Sub SetValues()
        errors = 0
        'monto = 0
        'tasai = 0
        'Plazo = 0

        idprestamo = TxtIdPrestamo.Text
        identidad = TxtIdentidad.Text
        nombre = TxtNombre.Text.Trim()
        fecha = DtpFecha.Text
        tipo = CmbTipo.Text.Trim()
        monto = TxtMonto.Text.Trim()
        tasai = TxtTasa.Text.Trim()
        Plazo = TxtPlazo.Text.Trim()

        If CmbTipo.Text = "DIARIO" Then
            deudatotal = monto * (tasai / 100) * Plazo + monto
            cuota = deudatotal / Plazo
            capital = cuota * ((100 - tasai) / 100)
            intereses = cuota * (tasai / 100)
        End If

        If CmbTipo.Text = "SEMANAL" Then
            deudatotal = monto * (tasai / 100) * (Plazo * 7) + monto
            cuota = deudatotal / (Plazo * 7)
            capital = cuota * ((100 - tasai) / 100)
            intereses = cuota * (tasai / 100)
        End If

        If CmbTipo.Text = "QUINCENAL" Then
            deudatotal = monto * (tasai / 100) * (Plazo * 15) + monto
            cuota = deudatotal / (Plazo * 15)
            capital = cuota * ((100 - tasai) / 100)
            intereses = cuota * (tasai / 100)
        End If

        If CmbTipo.Text = "MENSUAL" Then
            deudatotal = monto * (tasai / 100) * (Plazo * 30) + monto
            cuota = deudatotal / (Plazo * 30)
            capital = cuota * ((100 - tasai) / 100)
            intereses = cuota * (tasai / 100)
        End If
    End Sub

    'Metodo que crea las cuotas o letras
    Private Sub Operacion()
        SetValues()

        For i = 1 To Plazo Step 1
            Dim fields As String = "IDPRESTAMO, NUM, CUOTA, CAPITAL, INTERESES"
            Dim values = $"'{idprestamo}', '{i}', {cuota}, {capital}, {intereses}"
            If db.Save("LETRAS", fields, values) > 0 Then
            End If
        Next
        h.MsgSuccess("SE CREARON LAS CUOTAS CORRECTAMENTE!")

        'If CmbTipo.Text = "DIARIO" Then
        '    Dim i As Int16

        '    For i = 1 To Plazo Step 1
        '        Dim fields As String = "IDPRESTAMO, NUM, CAPITAL, INTERESES"
        '        Dim values = $"'{idprestamo}', '{i}', {capital}, {intereses}"
        '        If db.Save("LETRAS", fields, values) > 0 Then
        '        End If
        '    Next
        '    h.MsgSuccess("SE CREARON LAS CUOTAS CORRECTAMENTE!")
        'End If

        'If CmbTipo.Text = "SEMANAL" Then
        '    Dim i As Int16

        '    For i = 1 To Plazo Step 1
        '        Dim fields As String = "IDPRESTAMO, NUM, CAPITAL, INTERESES"
        '        Dim values = $"'{idprestamo}', '{i}', {capital}, {intereses}"
        '        If db.Save("LETRAS", fields, values) > 0 Then
        '        End If
        '    Next
        '    h.MsgSuccess("SE CREARON LAS CUOTAS CORRECTAMENTE!")
        'End If

        'If CmbTipo.Text = "QUINCENAL" Then
        '    Dim i As Int16

        '    For i = 1 To Plazo Step 1
        '        Dim fields As String = "IDPRESTAMO, NUM, CAPITAL, INTERESES"
        '        Dim values = $"'{idprestamo}', '{i}', {capital}, {intereses}"
        '        If db.Save("LETRAS", fields, values) > 0 Then
        '        End If
        '    Next
        '    h.MsgSuccess("SE CREARON LAS CUOTAS CORRECTAMENTE!")
        'End If

        'If CmbTipo.Text = "MENSUAL" Then
        '    Dim i As Int16

        '    For i = 1 To Plazo Step 1
        '        Dim fields As String = "IDPRESTAMO, NUM, CAPITAL, INTERESES"
        '        Dim values = $"'{idprestamo}', '{i}', {capital}, {intereses}"
        '        If db.Save("LETRAS", fields, values) > 0 Then
        '        End If
        '    Next
        '    h.MsgSuccess("SE CREARON LAS CUOTAS CORRECTAMENTE!")
        'End If
    End Sub

    'Metodo que habilita los campos
    Private Sub EnabledControls()
        TxtIdPrestamo.Enabled = True
        TxtIdentidad.Enabled = True
        TxtNombre.Enabled = True
        DtpFecha.Enabled = True
        CmbTipo.Enabled = True
        TxtMonto.Enabled = True
        TxtTasa.Enabled = True
        TxtPlazo.Enabled = True
    End Sub

    'Metodo que desactiva los campos
    Private Sub DisabledControls()
        TxtIdPrestamo.Enabled = False
        TxtIdentidad.Enabled = False
        TxtNombre.Enabled = False
        DtpFecha.Enabled = False
        CmbTipo.Enabled = False
        TxtMonto.Enabled = False
        TxtTasa.Enabled = False
        TxtPlazo.Enabled = False
    End Sub

    'Metodo que Genera de manera automatica el IDPRESTAMO
    Private Sub AutoGenCodigo()
        If ChkAutoGen.Checked = True Then
            TxtIdPrestamo.Text = "PRS" + db.GetNext(idcorre)
            TxtIdPrestamo.Enabled = False
            TxtIdentidad.Select()
        Else
            TxtIdPrestamo.Clear()
            TxtIdPrestamo.Select()
            TxtIdPrestamo.Enabled = True
        End If
    End Sub

    'Metodo que trae la informacion de la base de datos y la inserta en los campos
    Private Function GetInfoPrestamos(id As String) As String
        Dim condicion As String = "IDPRESTAMO='" + id + "' AND DEL='N'"
        Dim data As DataTable = db.Find("Prestamos", "*", condicion)

        If data.Rows.Count > 0 Then
            Dim info As DataRow = data.Rows(0)
            TxtIdPrestamo.Text = info("IDPRESTAMO").ToString()
            TxtIdentidad.Text = info("IDENTIDAD").ToString()
            TxtNombre.Text = info("NOMBRE").ToString()
            DtpFecha.Value = info("FECHA").ToString()
            CmbTipo.Text = info("TIPO").ToString()
            TxtMonto.Text = info("MONTO").ToString()
            TxtPlazo.Text = info("PLAZO").ToString()
            TxtTasa.Text = info("TASAI").ToString()

            BtnNuevo.Enabled = False
            BtnGuardarr.Enabled = False
            BtnEliminar.Enabled = True
            BtnCancelar.Enabled = True
            BtnSalir.Enabled = False

            EnabledControls()
            TxtIdPrestamo.Enabled = False

            'LblResumen
            Dim idpt As String = TxtIdPrestamo.Text.Trim()
            Dim canceladas, pendientes As String
            Dim condicionA = "IDPRESTAMO='" + idpt + "' AND ESTADO='CANCELADO'"
            canceladas = db.GetNumRows("LETRAS", condicionA)
            Dim condicionB = "IDPRESTAMO='" + idpt + "' AND ESTADO='PENDIENTE'"
            pendientes = db.GetNumRows("LETRAS", condicionB)
            LblResumen.Text = "HAY " + canceladas + " CUOTAS CANCELADAS Y " + pendientes + " CUOTAS PENDIENTES"
        Else
            h.MsgWarning("ERROR AL RECUPERAR LOS DATOS DEL REGISTRO SELECCIONADO!")
        End If
    End Function

    'Public Function DataExcel(ByVal midgv As DataGridView) As Boolean
    '    Dim exApp As New Microsoft.Office.Interop.Excel.Application
    '    Dim exLibro As New Microsoft.Office.Interop.Excel.Workbook
    '    Dim exHoja As New Microsoft.Office.Interop.Excel.Worksheet

    '    Try
    '        exLibro = exApp.Workbooks.Add 'Se crea el Libro'
    '        exHoja = exLibro.Worksheets.Add()
    '        'Filas y Columnas
    '        Dim numcolumnas As Integer = midgv.Columns.Count
    '        Dim numfilas As Integer = midgv.Rows.Count
    '        'For i As Integer = 1 To numcolumnas
    '        For i As Integer = 1 To numcolumnas
    '            exHoja.Cells.Item(1, i) = midgv.Columns(i - 1).Name.ToString()
    '        Next
    '        For fila As Integer = 0 To numfilas - 1
    '            Dim col
    '            exHoja.Cells.Item(fila + 2, col + 1) = midgv.Rows(fila).Cells(col).Value
    '        Next
    '        exHoja.Rows.Item(1).Font.bold = 1
    '        exHoja.Rows.Item(1).HorizontalAligment = 3
    '        exHoja.Columns.AutoFit()
    '        exHoja.Columns.HorizontalAlignment = 2
    '        exApp = Nothing
    '        exLibro = Nothing
    '        exApp = Nothing
    '    Catch ex As Exception
    '        h.MsgWarning(ex.Message, "ERROR CRITICO")
    '        h.MsgWarning("ERROR AL EXPORTAR A EXCEL!")
    '        Return False
    '    End Try
    '    Return True
    'End Function
End Class