<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPrestamosyCuotas
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmPrestamosyCuotas))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.TxtIdPrestamo = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.DgvData = New System.Windows.Forms.DataGridView()
        Me.DcIdPrestamo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DcNCuota = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DcCuota = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DcCapital = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DcIntereses = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DcESTADO = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.BtnSalir = New System.Windows.Forms.ToolStripButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LblMontoPendiente = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.LblMontoCancelado = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.LblMontoTotal = New System.Windows.Forms.Label()
        CType(Me.DgvData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'BtnGuardar
        '
        Me.BtnGuardar.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnGuardar.ForeColor = System.Drawing.Color.Teal
        Me.BtnGuardar.Image = CType(resources.GetObject("BtnGuardar.Image"), System.Drawing.Image)
        Me.BtnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnGuardar.Location = New System.Drawing.Point(686, 46)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(141, 28)
        Me.BtnGuardar.TabIndex = 41
        Me.BtnGuardar.Text = "Guardar Cambios"
        Me.BtnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnGuardar.UseVisualStyleBackColor = True
        '
        'TxtIdPrestamo
        '
        Me.TxtIdPrestamo.Location = New System.Drawing.Point(484, 47)
        Me.TxtIdPrestamo.MaxLength = 9
        Me.TxtIdPrestamo.Name = "TxtIdPrestamo"
        Me.TxtIdPrestamo.ReadOnly = True
        Me.TxtIdPrestamo.Size = New System.Drawing.Size(196, 27)
        Me.TxtIdPrestamo.TabIndex = 40
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Tai Le", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(373, 50)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(105, 19)
        Me.Label14.TabIndex = 39
        Me.Label14.Text = "IDPRESTAMO"
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.Teal
        Me.Label13.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(0, 45)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(367, 29)
        Me.Label13.TabIndex = 38
        Me.Label13.Text = "   CUOTAS DEL PRESTAMO SOLICITADO"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DgvData
        '
        Me.DgvData.AllowUserToAddRows = False
        Me.DgvData.AllowUserToDeleteRows = False
        Me.DgvData.AllowUserToResizeColumns = False
        Me.DgvData.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.AliceBlue
        Me.DgvData.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Tai Le", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvData.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvData.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DcIdPrestamo, Me.DcNCuota, Me.DcCuota, Me.DcCapital, Me.DcIntereses, Me.DcESTADO})
        Me.DgvData.Location = New System.Drawing.Point(11, 89)
        Me.DgvData.Margin = New System.Windows.Forms.Padding(2)
        Me.DgvData.Name = "DgvData"
        Me.DgvData.RowHeadersVisible = False
        Me.DgvData.RowHeadersWidth = 51
        Me.DgvData.RowTemplate.Height = 24
        Me.DgvData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvData.Size = New System.Drawing.Size(859, 337)
        Me.DgvData.TabIndex = 37
        '
        'DcIdPrestamo
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DcIdPrestamo.DefaultCellStyle = DataGridViewCellStyle3
        Me.DcIdPrestamo.HeaderText = "IDPRESTAMO"
        Me.DcIdPrestamo.Name = "DcIdPrestamo"
        Me.DcIdPrestamo.ReadOnly = True
        Me.DcIdPrestamo.Width = 150
        '
        'DcNCuota
        '
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DcNCuota.DefaultCellStyle = DataGridViewCellStyle4
        Me.DcNCuota.HeaderText = "NCUOTA"
        Me.DcNCuota.Name = "DcNCuota"
        '
        'DcCuota
        '
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DcCuota.DefaultCellStyle = DataGridViewCellStyle5
        Me.DcCuota.HeaderText = "CUOTA"
        Me.DcCuota.Name = "DcCuota"
        '
        'DcCapital
        '
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DcCapital.DefaultCellStyle = DataGridViewCellStyle6
        Me.DcCapital.HeaderText = "CAPITAL"
        Me.DcCapital.Name = "DcCapital"
        Me.DcCapital.ReadOnly = True
        Me.DcCapital.Width = 150
        '
        'DcIntereses
        '
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DcIntereses.DefaultCellStyle = DataGridViewCellStyle7
        Me.DcIntereses.HeaderText = "INTERESES"
        Me.DcIntereses.Name = "DcIntereses"
        Me.DcIntereses.ReadOnly = True
        Me.DcIntereses.Width = 150
        '
        'DcESTADO
        '
        Me.DcESTADO.HeaderText = "ESTADO"
        Me.DcESTADO.Name = "DcESTADO"
        Me.DcESTADO.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DcESTADO.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DcESTADO.Width = 180
        '
        'ToolStrip1
        '
        Me.ToolStrip1.AutoSize = False
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BtnSalir})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(881, 38)
        Me.ToolStrip1.TabIndex = 42
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'BtnSalir
        '
        Me.BtnSalir.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.BtnSalir.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSalir.Image = CType(resources.GetObject("BtnSalir.Image"), System.Drawing.Image)
        Me.BtnSalir.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.BtnSalir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(71, 35)
        Me.BtnSalir.Text = "SALIR"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Green
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(364, 16)
        Me.Label1.TabIndex = 43
        Me.Label1.Text = "MARQUE LA CASILLA SI LA CUOTA HA SIDO CANCELADA!"
        '
        'LblMontoPendiente
        '
        Me.LblMontoPendiente.BackColor = System.Drawing.Color.CadetBlue
        Me.LblMontoPendiente.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblMontoPendiente.ForeColor = System.Drawing.Color.White
        Me.LblMontoPendiente.Location = New System.Drawing.Point(759, 432)
        Me.LblMontoPendiente.Name = "LblMontoPendiente"
        Me.LblMontoPendiente.Size = New System.Drawing.Size(111, 29)
        Me.LblMontoPendiente.TabIndex = 44
        Me.LblMontoPendiente.Text = "0.00"
        Me.LblMontoPendiente.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Teal
        Me.Label2.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(607, 432)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(146, 29)
        Me.Label2.TabIndex = 45
        Me.Label2.Text = "MONTO PENDIENTE:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Teal
        Me.Label3.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(338, 432)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(146, 29)
        Me.Label3.TabIndex = 47
        Me.Label3.Text = "MONTO CANCELADO:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblMontoCancelado
        '
        Me.LblMontoCancelado.BackColor = System.Drawing.Color.CadetBlue
        Me.LblMontoCancelado.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblMontoCancelado.ForeColor = System.Drawing.Color.White
        Me.LblMontoCancelado.Location = New System.Drawing.Point(490, 432)
        Me.LblMontoCancelado.Name = "LblMontoCancelado"
        Me.LblMontoCancelado.Size = New System.Drawing.Size(111, 29)
        Me.LblMontoCancelado.TabIndex = 46
        Me.LblMontoCancelado.Text = "0.00"
        Me.LblMontoCancelado.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Teal
        Me.Label4.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(74, 432)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(141, 29)
        Me.Label4.TabIndex = 49
        Me.Label4.Text = "MONTO TOTAL:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblMontoTotal
        '
        Me.LblMontoTotal.BackColor = System.Drawing.Color.CadetBlue
        Me.LblMontoTotal.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblMontoTotal.ForeColor = System.Drawing.Color.White
        Me.LblMontoTotal.Location = New System.Drawing.Point(221, 432)
        Me.LblMontoTotal.Name = "LblMontoTotal"
        Me.LblMontoTotal.Size = New System.Drawing.Size(111, 29)
        Me.LblMontoTotal.TabIndex = 48
        Me.LblMontoTotal.Text = "0.00"
        Me.LblMontoTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'FrmPrestamosyCuotas
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.AliceBlue
        Me.ClientSize = New System.Drawing.Size(881, 474)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.LblMontoTotal)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.LblMontoCancelado)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.LblMontoPendiente)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.BtnGuardar)
        Me.Controls.Add(Me.TxtIdPrestamo)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.DgvData)
        Me.Font = New System.Drawing.Font("Microsoft Tai Le", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmPrestamosyCuotas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "---"
        CType(Me.DgvData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnGuardar As Button
    Friend WithEvents TxtIdPrestamo As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents DgvData As DataGridView
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents BtnSalir As ToolStripButton
    Friend WithEvents Label1 As Label
    Friend WithEvents DcIdPrestamo As DataGridViewTextBoxColumn
    Friend WithEvents DcNCuota As DataGridViewTextBoxColumn
    Friend WithEvents DcCuota As DataGridViewTextBoxColumn
    Friend WithEvents DcCapital As DataGridViewTextBoxColumn
    Friend WithEvents DcIntereses As DataGridViewTextBoxColumn
    Friend WithEvents DcESTADO As DataGridViewCheckBoxColumn
    Friend WithEvents LblMontoPendiente As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents LblMontoCancelado As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents LblMontoTotal As Label
End Class
