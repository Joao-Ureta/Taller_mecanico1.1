<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form7
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
        MenuStrip1 = New MenuStrip()
        GestiónDeServiciosToolStripMenuItem = New ToolStripMenuItem()
        SolicitudServiciosToolStripMenuItem = New ToolStripMenuItem()
        ActualizarServicioToolStripMenuItem = New ToolStripMenuItem()
        ListadoServiciosToolStripMenuItem = New ToolStripMenuItem()
        PictureBox1 = New PictureBox()
        btnVolver = New Button()
        pnlSolicitudServicio = New Panel()
        Label1 = New Label()
        pnlIngreso = New Panel()
        cbxCliente = New ComboBox()
        cbxEmpleado = New ComboBox()
        cbxEstado = New ComboBox()
        txtDescripcion = New TextBox()
        FecSolicitud = New DateTimePicker()
        btnIngresar = New Button()
        lblEmpleado = New Label()
        lblEstado = New Label()
        lblDescripcion = New Label()
        lblFecha = New Label()
        lblRutCli = New Label()
        lblTituloSolicitudServicio = New Label()
        MenuStrip1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        pnlSolicitudServicio.SuspendLayout()
        pnlIngreso.SuspendLayout()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.BackColor = Color.DimGray
        MenuStrip1.ImageScalingSize = New Size(20, 20)
        MenuStrip1.Items.AddRange(New ToolStripItem() {GestiónDeServiciosToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(1019, 28)
        MenuStrip1.TabIndex = 2
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' GestiónDeServiciosToolStripMenuItem
        ' 
        GestiónDeServiciosToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {SolicitudServiciosToolStripMenuItem, ActualizarServicioToolStripMenuItem, ListadoServiciosToolStripMenuItem})
        GestiónDeServiciosToolStripMenuItem.Font = New Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GestiónDeServiciosToolStripMenuItem.ForeColor = Color.White
        GestiónDeServiciosToolStripMenuItem.Name = "GestiónDeServiciosToolStripMenuItem"
        GestiónDeServiciosToolStripMenuItem.Size = New Size(170, 24)
        GestiónDeServiciosToolStripMenuItem.Text = "Gestión de servicios"
        ' 
        ' SolicitudServiciosToolStripMenuItem
        ' 
        SolicitudServiciosToolStripMenuItem.BackColor = Color.DimGray
        SolicitudServiciosToolStripMenuItem.ForeColor = Color.White
        SolicitudServiciosToolStripMenuItem.Name = "SolicitudServiciosToolStripMenuItem"
        SolicitudServiciosToolStripMenuItem.Size = New Size(242, 26)
        SolicitudServiciosToolStripMenuItem.Text = "Solicitud de servicio"
        ' 
        ' ActualizarServicioToolStripMenuItem
        ' 
        ActualizarServicioToolStripMenuItem.BackColor = Color.DimGray
        ActualizarServicioToolStripMenuItem.ForeColor = Color.White
        ActualizarServicioToolStripMenuItem.Name = "ActualizarServicioToolStripMenuItem"
        ActualizarServicioToolStripMenuItem.Size = New Size(242, 26)
        ActualizarServicioToolStripMenuItem.Text = "Actualizar servicio"
        ' 
        ' ListadoServiciosToolStripMenuItem
        ' 
        ListadoServiciosToolStripMenuItem.BackColor = Color.DimGray
        ListadoServiciosToolStripMenuItem.ForeColor = Color.White
        ListadoServiciosToolStripMenuItem.Name = "ListadoServiciosToolStripMenuItem"
        ListadoServiciosToolStripMenuItem.Size = New Size(242, 26)
        ListadoServiciosToolStripMenuItem.Text = "Listado de servicios"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.Form7Principal
        PictureBox1.Location = New Point(71, 44)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(845, 677)
        PictureBox1.TabIndex = 3
        PictureBox1.TabStop = False
        ' 
        ' btnVolver
        ' 
        btnVolver.BackColor = Color.DimGray
        btnVolver.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnVolver.ForeColor = Color.White
        btnVolver.Image = My.Resources.Resources.volver
        btnVolver.ImageAlign = ContentAlignment.MiddleRight
        btnVolver.Location = New Point(417, 740)
        btnVolver.Name = "btnVolver"
        btnVolver.Padding = New Padding(0, 0, 15, 0)
        btnVolver.Size = New Size(159, 48)
        btnVolver.TabIndex = 19
        btnVolver.Text = "Volver"
        btnVolver.UseVisualStyleBackColor = False
        ' 
        ' pnlSolicitudServicio
        ' 
        pnlSolicitudServicio.Controls.Add(Label1)
        pnlSolicitudServicio.Controls.Add(pnlIngreso)
        pnlSolicitudServicio.Controls.Add(lblTituloSolicitudServicio)
        pnlSolicitudServicio.Location = New Point(69, 48)
        pnlSolicitudServicio.Name = "pnlSolicitudServicio"
        pnlSolicitudServicio.Size = New Size(860, 673)
        pnlSolicitudServicio.TabIndex = 20
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(199, 99)
        Label1.Name = "Label1"
        Label1.Size = New Size(198, 20)
        Label1.TabIndex = 32
        Label1.Text = "Ingreso solicitud garantia"
        ' 
        ' pnlIngreso
        ' 
        pnlIngreso.BorderStyle = BorderStyle.Fixed3D
        pnlIngreso.Controls.Add(cbxCliente)
        pnlIngreso.Controls.Add(cbxEmpleado)
        pnlIngreso.Controls.Add(cbxEstado)
        pnlIngreso.Controls.Add(txtDescripcion)
        pnlIngreso.Controls.Add(FecSolicitud)
        pnlIngreso.Controls.Add(btnIngresar)
        pnlIngreso.Controls.Add(lblEmpleado)
        pnlIngreso.Controls.Add(lblEstado)
        pnlIngreso.Controls.Add(lblDescripcion)
        pnlIngreso.Controls.Add(lblFecha)
        pnlIngreso.Controls.Add(lblRutCli)
        pnlIngreso.Location = New Point(181, 111)
        pnlIngreso.Name = "pnlIngreso"
        pnlIngreso.Size = New Size(499, 527)
        pnlIngreso.TabIndex = 31
        ' 
        ' cbxCliente
        ' 
        cbxCliente.FormattingEnabled = True
        cbxCliente.Location = New Point(169, 116)
        cbxCliente.Name = "cbxCliente"
        cbxCliente.Size = New Size(156, 28)
        cbxCliente.TabIndex = 48
        ' 
        ' cbxEmpleado
        ' 
        cbxEmpleado.Enabled = False
        cbxEmpleado.FormattingEnabled = True
        cbxEmpleado.Location = New Point(169, 326)
        cbxEmpleado.Name = "cbxEmpleado"
        cbxEmpleado.Size = New Size(241, 28)
        cbxEmpleado.TabIndex = 47
        ' 
        ' cbxEstado
        ' 
        cbxEstado.Enabled = False
        cbxEstado.FormattingEnabled = True
        cbxEstado.Location = New Point(169, 285)
        cbxEstado.Name = "cbxEstado"
        cbxEstado.Size = New Size(241, 28)
        cbxEstado.TabIndex = 46
        ' 
        ' txtDescripcion
        ' 
        txtDescripcion.Enabled = False
        txtDescripcion.Location = New Point(169, 196)
        txtDescripcion.Multiline = True
        txtDescripcion.Name = "txtDescripcion"
        txtDescripcion.Size = New Size(241, 75)
        txtDescripcion.TabIndex = 45
        ' 
        ' FecSolicitud
        ' 
        FecSolicitud.CustomFormat = """yyyy-MM-dd"""
        FecSolicitud.Enabled = False
        FecSolicitud.Format = DateTimePickerFormat.Custom
        FecSolicitud.Location = New Point(169, 156)
        FecSolicitud.Name = "FecSolicitud"
        FecSolicitud.Size = New Size(155, 28)
        FecSolicitud.TabIndex = 44
        ' 
        ' btnIngresar
        ' 
        btnIngresar.BackColor = Color.DimGray
        btnIngresar.Enabled = False
        btnIngresar.Font = New Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnIngresar.ForeColor = Color.White
        btnIngresar.Image = My.Resources.Resources.guardar
        btnIngresar.ImageAlign = ContentAlignment.MiddleRight
        btnIngresar.Location = New Point(141, 427)
        btnIngresar.Name = "btnIngresar"
        btnIngresar.Padding = New Padding(0, 0, 30, 0)
        btnIngresar.Size = New Size(221, 61)
        btnIngresar.TabIndex = 38
        btnIngresar.Text = "Ingresar"
        btnIngresar.UseVisualStyleBackColor = False
        ' 
        ' lblEmpleado
        ' 
        lblEmpleado.AutoSize = True
        lblEmpleado.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblEmpleado.ForeColor = Color.White
        lblEmpleado.Location = New Point(18, 326)
        lblEmpleado.Name = "lblEmpleado"
        lblEmpleado.Size = New Size(110, 28)
        lblEmpleado.TabIndex = 30
        lblEmpleado.Text = "Empleado:"
        ' 
        ' lblEstado
        ' 
        lblEstado.AutoSize = True
        lblEstado.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblEstado.ForeColor = Color.White
        lblEstado.Location = New Point(18, 285)
        lblEstado.Name = "lblEstado"
        lblEstado.Size = New Size(80, 28)
        lblEstado.TabIndex = 29
        lblEstado.Text = "Estado:"
        ' 
        ' lblDescripcion
        ' 
        lblDescripcion.AutoSize = True
        lblDescripcion.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblDescripcion.ForeColor = Color.White
        lblDescripcion.Location = New Point(18, 196)
        lblDescripcion.Name = "lblDescripcion"
        lblDescripcion.Size = New Size(128, 28)
        lblDescripcion.TabIndex = 28
        lblDescripcion.Text = "Descripción:"
        ' 
        ' lblFecha
        ' 
        lblFecha.AutoSize = True
        lblFecha.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblFecha.ForeColor = Color.White
        lblFecha.Location = New Point(18, 156)
        lblFecha.Name = "lblFecha"
        lblFecha.Size = New Size(71, 28)
        lblFecha.TabIndex = 27
        lblFecha.Text = "Fecha:"
        ' 
        ' lblRutCli
        ' 
        lblRutCli.AutoSize = True
        lblRutCli.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblRutCli.ForeColor = Color.White
        lblRutCli.Location = New Point(18, 116)
        lblRutCli.Name = "lblRutCli"
        lblRutCli.Size = New Size(50, 28)
        lblRutCli.TabIndex = 26
        lblRutCli.Text = "Rut:"
        ' 
        ' lblTituloSolicitudServicio
        ' 
        lblTituloSolicitudServicio.AutoSize = True
        lblTituloSolicitudServicio.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTituloSolicitudServicio.ForeColor = Color.White
        lblTituloSolicitudServicio.Location = New Point(274, 17)
        lblTituloSolicitudServicio.Name = "lblTituloSolicitudServicio"
        lblTituloSolicitudServicio.Size = New Size(302, 41)
        lblTituloSolicitudServicio.TabIndex = 30
        lblTituloSolicitudServicio.Text = "Solicitud de servicio"
        ' 
        ' Form7
        ' 
        AutoScaleDimensions = New SizeF(9F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(35), CByte(35), CByte(35))
        ClientSize = New Size(1019, 800)
        Controls.Add(pnlSolicitudServicio)
        Controls.Add(btnVolver)
        Controls.Add(PictureBox1)
        Controls.Add(MenuStrip1)
        Font = New Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ForeColor = Color.White
        Name = "Form7"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Servicios"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        pnlSolicitudServicio.ResumeLayout(False)
        pnlSolicitudServicio.PerformLayout()
        pnlIngreso.ResumeLayout(False)
        pnlIngreso.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents GestiónDeServiciosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SolicitudServiciosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListadoServiciosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ActualizarServicioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnVolver As Button
    Friend WithEvents pnlSolicitudServicio As Panel
    Friend WithEvents lblTituloSolicitudServicio As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents pnlIngreso As Panel
    Friend WithEvents lblRutCli As Label
    Friend WithEvents lblEmpleado As Label
    Friend WithEvents lblEstado As Label
    Friend WithEvents lblDescripcion As Label
    Friend WithEvents lblFecha As Label
    Friend WithEvents btnIngresar As Button
    Friend WithEvents cbxEstado As ComboBox
    Friend WithEvents txtDescripcion As TextBox
    Friend WithEvents FecSolicitud As DateTimePicker
    Friend WithEvents cbxEmpleado As ComboBox
    Friend WithEvents cbxCliente As ComboBox

End Class
