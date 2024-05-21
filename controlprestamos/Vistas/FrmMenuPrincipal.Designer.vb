<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmMenuPrincipal
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMenuPrincipal))
        Me.TsPrincipal = New System.Windows.Forms.ToolStrip()
        Me.BtnDatosPersona = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BtnPrestamos = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.BtnUsuarios = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.lblFecha = New System.Windows.Forms.ToolStripStatusLabel()
        Me.BtnEmpleados = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.TsPrincipal.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TsPrincipal
        '
        Me.TsPrincipal.AutoSize = False
        Me.TsPrincipal.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BtnDatosPersona, Me.ToolStripSeparator1, Me.BtnPrestamos, Me.ToolStripSeparator3, Me.BtnUsuarios, Me.ToolStripSeparator2, Me.BtnEmpleados, Me.ToolStripSeparator5})
        Me.TsPrincipal.Location = New System.Drawing.Point(0, 0)
        Me.TsPrincipal.Name = "TsPrincipal"
        Me.TsPrincipal.Size = New System.Drawing.Size(800, 35)
        Me.TsPrincipal.TabIndex = 1
        Me.TsPrincipal.Text = "ToolStrip1"
        '
        'BtnDatosPersona
        '
        Me.BtnDatosPersona.Font = New System.Drawing.Font("Microsoft New Tai Lue", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDatosPersona.Image = CType(resources.GetObject("BtnDatosPersona.Image"), System.Drawing.Image)
        Me.BtnDatosPersona.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnDatosPersona.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.BtnDatosPersona.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnDatosPersona.Name = "BtnDatosPersona"
        Me.BtnDatosPersona.Size = New System.Drawing.Size(143, 32)
        Me.BtnDatosPersona.Text = "DATOS PERSONA"
        Me.BtnDatosPersona.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 35)
        '
        'BtnPrestamos
        '
        Me.BtnPrestamos.Font = New System.Drawing.Font("Microsoft New Tai Lue", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPrestamos.Image = CType(resources.GetObject("BtnPrestamos.Image"), System.Drawing.Image)
        Me.BtnPrestamos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnPrestamos.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.BtnPrestamos.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnPrestamos.Name = "BtnPrestamos"
        Me.BtnPrestamos.Size = New System.Drawing.Size(112, 32)
        Me.BtnPrestamos.Text = "PRESTAMOS"
        Me.BtnPrestamos.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 35)
        '
        'BtnUsuarios
        '
        Me.BtnUsuarios.Font = New System.Drawing.Font("Microsoft New Tai Lue", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnUsuarios.Image = CType(resources.GetObject("BtnUsuarios.Image"), System.Drawing.Image)
        Me.BtnUsuarios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnUsuarios.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.BtnUsuarios.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnUsuarios.Name = "BtnUsuarios"
        Me.BtnUsuarios.Size = New System.Drawing.Size(99, 32)
        Me.BtnUsuarios.Text = "USUARIOS"
        Me.BtnUsuarios.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 35)
        '
        'StatusStrip1
        '
        Me.StatusStrip1.AutoSize = False
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator4, Me.lblFecha})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 420)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(800, 30)
        Me.StatusStrip1.TabIndex = 3
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 30)
        '
        'lblFecha
        '
        Me.lblFecha.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFecha.ForeColor = System.Drawing.Color.Black
        Me.lblFecha.Image = CType(resources.GetObject("lblFecha.Image"), System.Drawing.Image)
        Me.lblFecha.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(47, 25)
        Me.lblFecha.Text = "---"
        Me.lblFecha.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'BtnEmpleados
        '
        Me.BtnEmpleados.Font = New System.Drawing.Font("Microsoft New Tai Lue", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEmpleados.Image = CType(resources.GetObject("BtnEmpleados.Image"), System.Drawing.Image)
        Me.BtnEmpleados.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnEmpleados.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.BtnEmpleados.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnEmpleados.Name = "BtnEmpleados"
        Me.BtnEmpleados.Size = New System.Drawing.Size(113, 32)
        Me.BtnEmpleados.Text = "EMPLEADOS"
        Me.BtnEmpleados.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 35)
        '
        'FrmMenuPrincipal
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.AliceBlue
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.TsPrincipal)
        Me.Font = New System.Drawing.Font("Microsoft Tai Le", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.IsMdiContainer = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmMenuPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "---"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.TsPrincipal.ResumeLayout(False)
        Me.TsPrincipal.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TsPrincipal As ToolStrip
    Friend WithEvents BtnDatosPersona As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents BtnPrestamos As ToolStripButton
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents BtnUsuarios As ToolStripButton
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents lblFecha As ToolStripStatusLabel
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
    Friend WithEvents BtnEmpleados As ToolStripButton
    Friend WithEvents ToolStripSeparator5 As ToolStripSeparator
End Class
