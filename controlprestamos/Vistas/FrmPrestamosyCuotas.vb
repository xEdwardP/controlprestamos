Public Class FrmPrestamosyCuotas

    Dim db As New Db
    Dim h As New Helpers
    Dim app As New APP
    Public idprestamos As String

    Private Sub FrmPrestamosyCuotas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = app.APPNAME + "| CUOTAS DEL PRESTAMO |"
        TxtIdPrestamo.Text = idprestamos
        GetCuotas()
        InfoCanceladas()
        Totalizar()
    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Dim prestamos As New frmprestamos()
        frmprestamos.Owner = Me
        prestamos.GetPrestamos("")
        Me.Close()
    End Sub

    'Trae la informacion de la base de datos y la muestra en el data gried view
    Private Sub GetCuotas()
        Dim fields, condition As String
        fields = "IDPRESTAMO, NUM, CUOTA, CAPITAL, INTERESES, ESTADO"
        condition = "IDPRESTAMO='" + TxtIdPrestamo.Text.Trim() + "'"

        Dim data As DataTable = db.Find("LETRAS", fields, condition)

        If data.Rows.Count > 0 Then
            Dim _idprestamo, _num, _estado
            Dim _capital, _intereses, _cuota As Double
            Dim _status As Boolean
            DgvData.Rows.Clear()

            For Each row As DataRow In data.Rows
                _idprestamo = row("IDPRESTAMO").ToString()
                _num = row("NUM").ToString()
                _cuota = row("CUOTA").ToString()
                _capital = row("CAPITAL").ToString()
                _intereses = row("INTERESES").ToString()
                _estado = row("ESTADO").ToString()

                _status = (IIf(_estado = "PENDIENTE", False, True))


                DgvData.Rows.Add(_idprestamo, _num, _cuota.ToString("N2"), _capital.ToString("N2"), _intereses.ToString("N2"), _status)
            Next
            data.Dispose()
        Else
            h.MsgWarning("NO SE ENCONTRARON CUOTAS!")
        End If
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        Dim msg As String = "DESEA GUARDAR LOS CAMBIOS REALIZADOS?"
        If h.MsgQuestion(msg) = "S" Then
            Dim _idprestamo, _status, _valorestado, condicion, fechapago As String
            Dim i As Int16
            For i = 0 To i > DgvData.Rows.Count Step 1
                _idprestamo = DgvData.Rows(i).Cells(0).Value.ToString()
                _status = DgvData.Rows(i).Cells(5).Value.ToString()
                _valorestado = (IIf(_status = "False", "PENDIENTE", "CANCELADO"))

                fechapago = DateTime.Today.ToShortDateString
                Dim fields As String = "FECHAPAGO='" + fechapago + "' ,ESTADO='" + _valorestado + "'"
                Dim num As String = DgvData.CurrentRow.Cells(1).Value.ToString()
                condicion = "IDPRESTAMO='" + TxtIdPrestamo.Text.Trim() + "' AND NUM='" + num + "'"

                db.Update("LETRAS", fields, condicion)
            Next
            h.MsgSuccess("LOS CAMBIOS SE APLICARON CORRECTAMENTE!")
            GetCuotas()
            InfoCanceladas()
            Totalizar()
        End If
    End Sub

    'Metodo que Actualiza el prestamo a CANCELADO si todas las cuotas fueron canceladas
    Private Sub InfoCanceladas()
        Dim condition As String = "IDPRESTAMO='" + idprestamos + "' AND ESTADO='PENDIENTE'"
        Dim pendientes As String = db.GetNumRows("LETRAS", condition)

        If pendientes = 0 Then
            Dim nuevovalor As String = "CANCELADO"
            Dim values As String = "ESTADO='" + nuevovalor + "'"
            Dim condicionb As String = "IDPRESTAMO='" + idprestamos + "'"

            If db.Update("Prestamos", values, condicionb) > 0 Then
                h.MsgWarning("EL PRESTAMO NO TIENE CUOTAS PENDIENTES, HA SIDO CANCELADO!")
            End If
            BtnGuardar.Enabled = False
        Else
            BtnGuardar.Enabled = True
        End If
    End Sub

    Private Sub Totalizar()
        If DgvData.Rows.Count > 0 Then
            Dim idp As String = "IDPRESTAMO='" + idprestamos + "'"
            Dim valorcuota As Double = Convert.ToDouble(db.Hook("CUOTA", "LETRAS", idp))

            'Calculo del monto total
            Dim condicion As String = "IDPRESTAMO='" + idprestamos + "'"
            Dim cuotas As Double = db.GetNumRows("LETRAS", condicion)

            Dim montototal As Double = cuotas * valorcuota
            LblMontoTotal.Text = "L. " + montototal.ToString("N2")

            'Calculo del monto pendiente
            Dim condicion2 As String = "IDPRESTAMO='" + idprestamos + "' AND ESTADO='PENDIENTE'"
            Dim cuotaspendientes As Double = db.GetNumRows("LETRAS", condicion2)

            Dim montopendiente As Double = cuotaspendientes * valorcuota
            LblMontoPendiente.Text = "L. " + montopendiente.ToString("N2")

            'Calculo del monto cancelado
            Dim condicion3 As String = "IDPRESTAMO='" + idprestamos + "' AND ESTADO='CANCELADO'"
            Dim cuotascanceladas As Double = db.GetNumRows("LETRAS", condicion3)

            Dim montocancelado As Double = cuotascanceladas * valorcuota
            LblMontoCancelado.Text = "L. " + montocancelado.ToString("N2")
        End If
    End Sub
End Class