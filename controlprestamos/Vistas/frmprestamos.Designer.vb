<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmprestamos
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmprestamos))
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TxtIdPrestamo = New System.Windows.Forms.TextBox()
        Me.TxtIdentidad = New System.Windows.Forms.TextBox()
        Me.TxtNombre = New System.Windows.Forms.TextBox()
        Me.CmbTipo = New System.Windows.Forms.ComboBox()
        Me.TxtMonto = New System.Windows.Forms.TextBox()
        Me.TxtTasa = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TxtPlazo = New System.Windows.Forms.TextBox()
        Me.DgvData = New System.Windows.Forms.DataGridView()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.BtnNuevo = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BtnGuardarr = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BtnEliminar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.BtnCancelar = New System.Windows.Forms.ToolStripButton()
        Me.BtnSalir = New System.Windows.Forms.ToolStripButton()
        Me.DtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.TxtSearch = New System.Windows.Forms.TextBox()
        Me.BtnSearch = New System.Windows.Forms.Button()
        Me.ChkAutoGen = New System.Windows.Forms.CheckBox()
        Me.BtnGestionarCuotas = New System.Windows.Forms.Button()
        Me.LblResumen = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.BtnExportar = New System.Windows.Forms.Button()
        Me.DcReferencia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DcIdentidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DcNombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DcFecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DcTipo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DcMonto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DcTasaI = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DcPlazo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DcCapital = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DcIntereses = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DcEstado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DgvData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Tai Le", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(11, 97)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(105, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "IDPRESTAMO"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Tai Le", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(488, 97)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 19)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "IDENTIDAD:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Tai Le", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(11, 128)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 19)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "NOMBRE:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Tai Le", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(11, 162)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 19)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "FECHA:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Tai Le", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(747, 162)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(47, 19)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "TIPO:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Tai Le", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(237, 160)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(70, 19)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "MONTO:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Tai Le", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(415, 160)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(52, 19)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "TASA:"
        '
        'TxtIdPrestamo
        '
        Me.TxtIdPrestamo.Font = New System.Drawing.Font("Microsoft Tai Le", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtIdPrestamo.Location = New System.Drawing.Point(119, 94)
        Me.TxtIdPrestamo.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtIdPrestamo.MaxLength = 9
        Me.TxtIdPrestamo.Name = "TxtIdPrestamo"
        Me.TxtIdPrestamo.Size = New System.Drawing.Size(250, 27)
        Me.TxtIdPrestamo.TabIndex = 10
        '
        'TxtIdentidad
        '
        Me.TxtIdentidad.Font = New System.Drawing.Font("Microsoft Tai Le", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtIdentidad.Location = New System.Drawing.Point(588, 94)
        Me.TxtIdentidad.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtIdentidad.MaxLength = 15
        Me.TxtIdentidad.Name = "TxtIdentidad"
        Me.TxtIdentidad.Size = New System.Drawing.Size(345, 27)
        Me.TxtIdentidad.TabIndex = 11
        '
        'TxtNombre
        '
        Me.TxtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtNombre.Font = New System.Drawing.Font("Microsoft Tai Le", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNombre.Location = New System.Drawing.Point(119, 125)
        Me.TxtNombre.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtNombre.MaxLength = 150
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.Size = New System.Drawing.Size(814, 27)
        Me.TxtNombre.TabIndex = 12
        '
        'CmbTipo
        '
        Me.CmbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbTipo.Font = New System.Drawing.Font("Microsoft Tai Le", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbTipo.FormattingEnabled = True
        Me.CmbTipo.Items.AddRange(New Object() {"DIARIO", "SEMANAL", "QUINCENAL", "MENSUAL"})
        Me.CmbTipo.Location = New System.Drawing.Point(798, 157)
        Me.CmbTipo.Margin = New System.Windows.Forms.Padding(2)
        Me.CmbTipo.Name = "CmbTipo"
        Me.CmbTipo.Size = New System.Drawing.Size(135, 27)
        Me.CmbTipo.TabIndex = 14
        '
        'TxtMonto
        '
        Me.TxtMonto.Font = New System.Drawing.Font("Microsoft Tai Le", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtMonto.Location = New System.Drawing.Point(311, 155)
        Me.TxtMonto.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtMonto.MaxLength = 12
        Me.TxtMonto.Name = "TxtMonto"
        Me.TxtMonto.Size = New System.Drawing.Size(100, 27)
        Me.TxtMonto.TabIndex = 15
        Me.TxtMonto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtTasa
        '
        Me.TxtTasa.Font = New System.Drawing.Font("Microsoft Tai Le", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTasa.Location = New System.Drawing.Point(471, 157)
        Me.TxtTasa.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtTasa.MaxLength = 12
        Me.TxtTasa.Name = "TxtTasa"
        Me.TxtTasa.Size = New System.Drawing.Size(100, 27)
        Me.TxtTasa.TabIndex = 16
        Me.TxtTasa.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Tai Le", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(575, 158)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(61, 19)
        Me.Label11.TabIndex = 17
        Me.Label11.Text = "PLAZO:"
        '
        'TxtPlazo
        '
        Me.TxtPlazo.Font = New System.Drawing.Font("Microsoft Tai Le", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPlazo.Location = New System.Drawing.Point(640, 157)
        Me.TxtPlazo.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtPlazo.MaxLength = 5
        Me.TxtPlazo.Name = "TxtPlazo"
        Me.TxtPlazo.Size = New System.Drawing.Size(100, 27)
        Me.TxtPlazo.TabIndex = 18
        Me.TxtPlazo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
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
        Me.DgvData.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DcReferencia, Me.DcIdentidad, Me.DcNombre, Me.DcFecha, Me.DcTipo, Me.DcMonto, Me.DcTasaI, Me.DcPlazo, Me.DcCapital, Me.DcIntereses, Me.DcEstado})
        Me.DgvData.Location = New System.Drawing.Point(15, 251)
        Me.DgvData.Margin = New System.Windows.Forms.Padding(2)
        Me.DgvData.Name = "DgvData"
        Me.DgvData.ReadOnly = True
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle13.Font = New System.Drawing.Font("Microsoft Tai Le", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvData.RowHeadersDefaultCellStyle = DataGridViewCellStyle13
        Me.DgvData.RowHeadersVisible = False
        Me.DgvData.RowHeadersWidth = 51
        Me.DgvData.RowTemplate.Height = 24
        Me.DgvData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvData.Size = New System.Drawing.Size(918, 190)
        Me.DgvData.TabIndex = 23
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.Teal
        Me.Label12.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(-4, 48)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(367, 29)
        Me.Label12.TabIndex = 24
        Me.Label12.Text = "   DATOS GENERALES DEL PRESTAMO"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.Teal
        Me.Label13.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(-6, 200)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(367, 29)
        Me.Label13.TabIndex = 26
        Me.Label13.Text = "   PRESTAMOS REGISTRADOS"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ToolStrip1
        '
        Me.ToolStrip1.AutoSize = False
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BtnNuevo, Me.ToolStripSeparator1, Me.BtnGuardarr, Me.ToolStripSeparator2, Me.BtnEliminar, Me.ToolStripSeparator4, Me.BtnCancelar, Me.BtnSalir})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(957, 38)
        Me.ToolStrip1.TabIndex = 31
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'BtnNuevo
        '
        Me.BtnNuevo.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnNuevo.Image = CType(resources.GetObject("BtnNuevo.Image"), System.Drawing.Image)
        Me.BtnNuevo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.BtnNuevo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnNuevo.Name = "BtnNuevo"
        Me.BtnNuevo.Size = New System.Drawing.Size(81, 35)
        Me.BtnNuevo.Text = "NUEVO"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 38)
        '
        'BtnGuardarr
        '
        Me.BtnGuardarr.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnGuardarr.Image = CType(resources.GetObject("BtnGuardarr.Image"), System.Drawing.Image)
        Me.BtnGuardarr.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.BtnGuardarr.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnGuardarr.Name = "BtnGuardarr"
        Me.BtnGuardarr.Size = New System.Drawing.Size(98, 35)
        Me.BtnGuardarr.Text = "GUARDAR"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 38)
        '
        'BtnEliminar
        '
        Me.BtnEliminar.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEliminar.Image = CType(resources.GetObject("BtnEliminar.Image"), System.Drawing.Image)
        Me.BtnEliminar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.BtnEliminar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(97, 35)
        Me.BtnEliminar.Text = "ELIMINAR"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 38)
        '
        'BtnCancelar
        '
        Me.BtnCancelar.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCancelar.Image = CType(resources.GetObject("BtnCancelar.Image"), System.Drawing.Image)
        Me.BtnCancelar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.BtnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(102, 35)
        Me.BtnCancelar.Text = "CANCELAR"
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
        'DtpFecha
        '
        Me.DtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpFecha.Location = New System.Drawing.Point(119, 158)
        Me.DtpFecha.Name = "DtpFecha"
        Me.DtpFecha.Size = New System.Drawing.Size(113, 27)
        Me.DtpFecha.TabIndex = 32
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Tai Le", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(367, 205)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(72, 19)
        Me.Label14.TabIndex = 33
        Me.Label14.Text = "BUSCAR:"
        '
        'TxtSearch
        '
        Me.TxtSearch.Location = New System.Drawing.Point(440, 202)
        Me.TxtSearch.MaxLength = 150
        Me.TxtSearch.Name = "TxtSearch"
        Me.TxtSearch.Size = New System.Drawing.Size(459, 27)
        Me.TxtSearch.TabIndex = 34
        '
        'BtnSearch
        '
        Me.BtnSearch.Image = CType(resources.GetObject("BtnSearch.Image"), System.Drawing.Image)
        Me.BtnSearch.Location = New System.Drawing.Point(905, 200)
        Me.BtnSearch.Name = "BtnSearch"
        Me.BtnSearch.Size = New System.Drawing.Size(28, 28)
        Me.BtnSearch.TabIndex = 36
        Me.BtnSearch.UseVisualStyleBackColor = True
        '
        'ChkAutoGen
        '
        Me.ChkAutoGen.AutoSize = True
        Me.ChkAutoGen.Checked = True
        Me.ChkAutoGen.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ChkAutoGen.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkAutoGen.Location = New System.Drawing.Point(374, 98)
        Me.ChkAutoGen.Name = "ChkAutoGen"
        Me.ChkAutoGen.Size = New System.Drawing.Size(109, 20)
        Me.ChkAutoGen.TabIndex = 37
        Me.ChkAutoGen.Text = "Auto Generar"
        Me.ChkAutoGen.UseVisualStyleBackColor = True
        '
        'BtnGestionarCuotas
        '
        Me.BtnGestionarCuotas.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnGestionarCuotas.ForeColor = System.Drawing.Color.Blue
        Me.BtnGestionarCuotas.Image = CType(resources.GetObject("BtnGestionarCuotas.Image"), System.Drawing.Image)
        Me.BtnGestionarCuotas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnGestionarCuotas.Location = New System.Drawing.Point(15, 446)
        Me.BtnGestionarCuotas.Name = "BtnGestionarCuotas"
        Me.BtnGestionarCuotas.Size = New System.Drawing.Size(159, 31)
        Me.BtnGestionarCuotas.TabIndex = 38
        Me.BtnGestionarCuotas.Text = "GESTIONAR CUOTAS"
        Me.BtnGestionarCuotas.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnGestionarCuotas.UseVisualStyleBackColor = True
        '
        'LblResumen
        '
        Me.LblResumen.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblResumen.ForeColor = System.Drawing.Color.Teal
        Me.LblResumen.Location = New System.Drawing.Point(529, 446)
        Me.LblResumen.Name = "LblResumen"
        Me.LblResumen.Size = New System.Drawing.Size(404, 23)
        Me.LblResumen.TabIndex = 39
        Me.LblResumen.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Tai Le", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Green
        Me.Label9.Location = New System.Drawing.Point(12, 232)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(271, 16)
        Me.Label9.TabIndex = 41
        Me.Label9.Text = "DOBLE CLICK PARA SELECCIONAR EL REGISTRO"
        '
        'BtnExportar
        '
        Me.BtnExportar.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnExportar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnExportar.Image = CType(resources.GetObject("BtnExportar.Image"), System.Drawing.Image)
        Me.BtnExportar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnExportar.Location = New System.Drawing.Point(180, 446)
        Me.BtnExportar.Name = "BtnExportar"
        Me.BtnExportar.Size = New System.Drawing.Size(159, 31)
        Me.BtnExportar.TabIndex = 42
        Me.BtnExportar.Text = "EXPORTAR A EXCEL"
        Me.BtnExportar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnExportar.UseVisualStyleBackColor = True
        '
        'DcReferencia
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DcReferencia.DefaultCellStyle = DataGridViewCellStyle3
        Me.DcReferencia.HeaderText = "IDPRESTAMO"
        Me.DcReferencia.Name = "DcReferencia"
        Me.DcReferencia.ReadOnly = True
        '
        'DcIdentidad
        '
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DcIdentidad.DefaultCellStyle = DataGridViewCellStyle4
        Me.DcIdentidad.HeaderText = "IDENTIDAD"
        Me.DcIdentidad.Name = "DcIdentidad"
        Me.DcIdentidad.ReadOnly = True
        Me.DcIdentidad.Width = 150
        '
        'DcNombre
        '
        Me.DcNombre.HeaderText = "NOMBRE"
        Me.DcNombre.Name = "DcNombre"
        Me.DcNombre.ReadOnly = True
        Me.DcNombre.Width = 360
        '
        'DcFecha
        '
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DcFecha.DefaultCellStyle = DataGridViewCellStyle5
        Me.DcFecha.HeaderText = "FECHA"
        Me.DcFecha.Name = "DcFecha"
        Me.DcFecha.ReadOnly = True
        '
        'DcTipo
        '
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DcTipo.DefaultCellStyle = DataGridViewCellStyle6
        Me.DcTipo.HeaderText = "TIPO"
        Me.DcTipo.Name = "DcTipo"
        Me.DcTipo.ReadOnly = True
        Me.DcTipo.Width = 140
        '
        'DcMonto
        '
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DcMonto.DefaultCellStyle = DataGridViewCellStyle7
        Me.DcMonto.HeaderText = "MONTO"
        Me.DcMonto.Name = "DcMonto"
        Me.DcMonto.ReadOnly = True
        '
        'DcTasaI
        '
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DcTasaI.DefaultCellStyle = DataGridViewCellStyle8
        Me.DcTasaI.HeaderText = "TASAI"
        Me.DcTasaI.Name = "DcTasaI"
        Me.DcTasaI.ReadOnly = True
        '
        'DcPlazo
        '
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DcPlazo.DefaultCellStyle = DataGridViewCellStyle9
        Me.DcPlazo.HeaderText = "PLAZO"
        Me.DcPlazo.Name = "DcPlazo"
        Me.DcPlazo.ReadOnly = True
        '
        'DcCapital
        '
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DcCapital.DefaultCellStyle = DataGridViewCellStyle10
        Me.DcCapital.HeaderText = "CAPITAL"
        Me.DcCapital.Name = "DcCapital"
        Me.DcCapital.ReadOnly = True
        '
        'DcIntereses
        '
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DcIntereses.DefaultCellStyle = DataGridViewCellStyle11
        Me.DcIntereses.HeaderText = "INTERESES"
        Me.DcIntereses.Name = "DcIntereses"
        Me.DcIntereses.ReadOnly = True
        '
        'DcEstado
        '
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DcEstado.DefaultCellStyle = DataGridViewCellStyle12
        Me.DcEstado.HeaderText = "ESTADO"
        Me.DcEstado.Name = "DcEstado"
        Me.DcEstado.ReadOnly = True
        Me.DcEstado.Width = 140
        '
        'frmprestamos
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.AliceBlue
        Me.ClientSize = New System.Drawing.Size(957, 489)
        Me.ControlBox = False
        Me.Controls.Add(Me.BtnExportar)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.LblResumen)
        Me.Controls.Add(Me.BtnGestionarCuotas)
        Me.Controls.Add(Me.ChkAutoGen)
        Me.Controls.Add(Me.BtnSearch)
        Me.Controls.Add(Me.TxtSearch)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.DtpFecha)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.DgvData)
        Me.Controls.Add(Me.TxtPlazo)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.TxtTasa)
        Me.Controls.Add(Me.TxtMonto)
        Me.Controls.Add(Me.CmbTipo)
        Me.Controls.Add(Me.TxtNombre)
        Me.Controls.Add(Me.TxtIdentidad)
        Me.Controls.Add(Me.TxtIdPrestamo)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Tai Le", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmprestamos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "---"
        CType(Me.DgvData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents TxtIdPrestamo As TextBox
    Friend WithEvents TxtIdentidad As TextBox
    Friend WithEvents TxtNombre As TextBox
    Friend WithEvents CmbTipo As ComboBox
    Friend WithEvents TxtMonto As TextBox
    Friend WithEvents TxtTasa As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents TxtPlazo As TextBox
    Friend WithEvents DgvData As DataGridView
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents BtnNuevo As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents BtnGuardarr As ToolStripButton
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents BtnEliminar As ToolStripButton
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
    Friend WithEvents BtnCancelar As ToolStripButton
    Friend WithEvents BtnSalir As ToolStripButton
    Friend WithEvents DtpFecha As DateTimePicker
    Friend WithEvents Label14 As Label
    Friend WithEvents TxtSearch As TextBox
    Friend WithEvents BtnSearch As Button
    Friend WithEvents ChkAutoGen As CheckBox
    Friend WithEvents BtnGestionarCuotas As Button
    Friend WithEvents LblResumen As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents BtnExportar As Button
    Friend WithEvents DcReferencia As DataGridViewTextBoxColumn
    Friend WithEvents DcIdentidad As DataGridViewTextBoxColumn
    Friend WithEvents DcNombre As DataGridViewTextBoxColumn
    Friend WithEvents DcFecha As DataGridViewTextBoxColumn
    Friend WithEvents DcTipo As DataGridViewTextBoxColumn
    Friend WithEvents DcMonto As DataGridViewTextBoxColumn
    Friend WithEvents DcTasaI As DataGridViewTextBoxColumn
    Friend WithEvents DcPlazo As DataGridViewTextBoxColumn
    Friend WithEvents DcCapital As DataGridViewTextBoxColumn
    Friend WithEvents DcIntereses As DataGridViewTextBoxColumn
    Friend WithEvents DcEstado As DataGridViewTextBoxColumn
End Class
