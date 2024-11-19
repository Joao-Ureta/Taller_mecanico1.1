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
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As DataGridViewCellStyle = New DataGridViewCellStyle()
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
        PictureBox2 = New PictureBox()
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
        PanelActualizacion = New Panel()
        Label3 = New Label()
        Panel3 = New Panel()
        txtSolicitudID = New TextBox()
        btnActualizar = New Button()
        txtEmpleado = New TextBox()
        cbxEstServ = New ComboBox()
        txtDesc = New TextBox()
        FecSoli = New DateTimePicker()
        txtRutCli = New TextBox()
        lblEmp = New Label()
        lblEstServ = New Label()
        lblDesc = New Label()
        lblFecSoli = New Label()
        lblCli = New Label()
        Label2 = New Label()
        Panel2 = New Panel()
        btnBuscar = New Button()
        txtRutNom = New TextBox()
        lblCloiente = New Label()
        lblTituloActualizacion = New Label()
        PanelListado = New Panel()
        Label5 = New Label()
        Label4 = New Label()
        Panel4 = New Panel()
        DataGridView1 = New DataGridView()
        ID = New DataGridViewTextBoxColumn()
        Rut = New DataGridViewTextBoxColumn()
        FechaSolicitud = New DataGridViewTextBoxColumn()
        DescripcionProblema = New DataGridViewTextBoxColumn()
        Estado = New DataGridViewTextBoxColumn()
        Siniestroid = New DataGridViewTextBoxColumn()
        RutEmplado = New DataGridViewTextBoxColumn()
        lblTitulo = New Label()
        Panel1 = New Panel()
        btnVerTodo = New Button()
        cbxBuscarEstado = New ComboBox()
        btnBuscarCli = New Button()
        txtCliente = New TextBox()
        lblCliente = New Label()
        MenuStrip1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        pnlSolicitudServicio.SuspendLayout()
        pnlIngreso.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        PanelActualizacion.SuspendLayout()
        Panel3.SuspendLayout()
        Panel2.SuspendLayout()
        PanelListado.SuspendLayout()
        Panel4.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
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
        btnVolver.Location = New Point(424, 767)
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
        pnlSolicitudServicio.Size = New Size(860, 713)
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
        pnlIngreso.Controls.Add(PictureBox2)
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
        pnlIngreso.Size = New Size(499, 588)
        pnlIngreso.TabIndex = 31
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BorderStyle = BorderStyle.Fixed3D
        PictureBox2.Image = My.Resources.Resources.RegistroServicio
        PictureBox2.Location = New Point(172, 31)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(155, 129)
        PictureBox2.TabIndex = 49
        PictureBox2.TabStop = False
        ' 
        ' cbxCliente
        ' 
        cbxCliente.FormattingEnabled = True
        cbxCliente.Location = New Point(209, 235)
        cbxCliente.Name = "cbxCliente"
        cbxCliente.Size = New Size(241, 28)
        cbxCliente.TabIndex = 48
        ' 
        ' cbxEmpleado
        ' 
        cbxEmpleado.Enabled = False
        cbxEmpleado.FormattingEnabled = True
        cbxEmpleado.Location = New Point(209, 445)
        cbxEmpleado.Name = "cbxEmpleado"
        cbxEmpleado.Size = New Size(241, 28)
        cbxEmpleado.TabIndex = 47
        ' 
        ' cbxEstado
        ' 
        cbxEstado.Enabled = False
        cbxEstado.FormattingEnabled = True
        cbxEstado.Location = New Point(209, 404)
        cbxEstado.Name = "cbxEstado"
        cbxEstado.Size = New Size(241, 28)
        cbxEstado.TabIndex = 46
        ' 
        ' txtDescripcion
        ' 
        txtDescripcion.Enabled = False
        txtDescripcion.Location = New Point(209, 315)
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
        FecSolicitud.Location = New Point(209, 275)
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
        btnIngresar.Location = New Point(144, 503)
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
        lblEmpleado.Location = New Point(58, 445)
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
        lblEstado.Location = New Point(58, 404)
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
        lblDescripcion.Location = New Point(58, 315)
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
        lblFecha.Location = New Point(58, 275)
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
        lblRutCli.Location = New Point(58, 235)
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
        ' PanelActualizacion
        ' 
        PanelActualizacion.Controls.Add(Label3)
        PanelActualizacion.Controls.Add(Panel3)
        PanelActualizacion.Controls.Add(Label2)
        PanelActualizacion.Controls.Add(Panel2)
        PanelActualizacion.Controls.Add(lblTituloActualizacion)
        PanelActualizacion.Location = New Point(67, 45)
        PanelActualizacion.Name = "PanelActualizacion"
        PanelActualizacion.Size = New Size(877, 707)
        PanelActualizacion.TabIndex = 21
        PanelActualizacion.Visible = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(127, 303)
        Label3.Name = "Label3"
        Label3.Size = New Size(183, 20)
        Label3.TabIndex = 35
        Label3.Text = "Información de servicio"
        ' 
        ' Panel3
        ' 
        Panel3.BorderStyle = BorderStyle.Fixed3D
        Panel3.Controls.Add(txtSolicitudID)
        Panel3.Controls.Add(btnActualizar)
        Panel3.Controls.Add(txtEmpleado)
        Panel3.Controls.Add(cbxEstServ)
        Panel3.Controls.Add(txtDesc)
        Panel3.Controls.Add(FecSoli)
        Panel3.Controls.Add(txtRutCli)
        Panel3.Controls.Add(lblEmp)
        Panel3.Controls.Add(lblEstServ)
        Panel3.Controls.Add(lblDesc)
        Panel3.Controls.Add(lblFecSoli)
        Panel3.Controls.Add(lblCli)
        Panel3.Location = New Point(109, 315)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(659, 365)
        Panel3.TabIndex = 34
        ' 
        ' txtSolicitudID
        ' 
        txtSolicitudID.Location = New Point(270, 28)
        txtSolicitudID.Multiline = True
        txtSolicitudID.Name = "txtSolicitudID"
        txtSolicitudID.Size = New Size(93, 28)
        txtSolicitudID.TabIndex = 52
        txtSolicitudID.Visible = False
        ' 
        ' btnActualizar
        ' 
        btnActualizar.BackColor = Color.DimGray
        btnActualizar.Font = New Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnActualizar.ForeColor = Color.White
        btnActualizar.Image = My.Resources.Resources.modificar
        btnActualizar.ImageAlign = ContentAlignment.MiddleRight
        btnActualizar.Location = New Point(227, 278)
        btnActualizar.Name = "btnActualizar"
        btnActualizar.Padding = New Padding(0, 0, 30, 0)
        btnActualizar.Size = New Size(221, 61)
        btnActualizar.TabIndex = 51
        btnActualizar.Text = "Actualizar"
        btnActualizar.UseVisualStyleBackColor = False
        ' 
        ' txtEmpleado
        ' 
        txtEmpleado.Enabled = False
        txtEmpleado.Location = New Point(270, 240)
        txtEmpleado.Multiline = True
        txtEmpleado.Name = "txtEmpleado"
        txtEmpleado.Size = New Size(311, 28)
        txtEmpleado.TabIndex = 47
        ' 
        ' cbxEstServ
        ' 
        cbxEstServ.FormattingEnabled = True
        cbxEstServ.Location = New Point(270, 199)
        cbxEstServ.Name = "cbxEstServ"
        cbxEstServ.Size = New Size(311, 28)
        cbxEstServ.TabIndex = 46
        ' 
        ' txtDesc
        ' 
        txtDesc.Enabled = False
        txtDesc.Location = New Point(270, 152)
        txtDesc.Multiline = True
        txtDesc.Name = "txtDesc"
        txtDesc.Size = New Size(311, 28)
        txtDesc.TabIndex = 45
        ' 
        ' FecSoli
        ' 
        FecSoli.CustomFormat = """yyyy-MM-dd"""
        FecSoli.Enabled = False
        FecSoli.Format = DateTimePickerFormat.Custom
        FecSoli.Location = New Point(270, 110)
        FecSoli.Name = "FecSoli"
        FecSoli.Size = New Size(178, 28)
        FecSoli.TabIndex = 44
        ' 
        ' txtRutCli
        ' 
        txtRutCli.Enabled = False
        txtRutCli.Location = New Point(270, 62)
        txtRutCli.Multiline = True
        txtRutCli.Name = "txtRutCli"
        txtRutCli.Size = New Size(311, 28)
        txtRutCli.TabIndex = 32
        ' 
        ' lblEmp
        ' 
        lblEmp.AutoSize = True
        lblEmp.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblEmp.ForeColor = Color.White
        lblEmp.Location = New Point(72, 240)
        lblEmp.Name = "lblEmp"
        lblEmp.Size = New Size(186, 28)
        lblEmp.TabIndex = 31
        lblEmp.Text = "Empleado a cargo:"
        ' 
        ' lblEstServ
        ' 
        lblEstServ.AutoSize = True
        lblEstServ.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblEstServ.ForeColor = Color.White
        lblEstServ.Location = New Point(72, 199)
        lblEstServ.Name = "lblEstServ"
        lblEstServ.Size = New Size(160, 28)
        lblEstServ.TabIndex = 30
        lblEstServ.Text = "Estado servicio:"
        ' 
        ' lblDesc
        ' 
        lblDesc.AutoSize = True
        lblDesc.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblDesc.ForeColor = Color.White
        lblDesc.Location = New Point(72, 152)
        lblDesc.Name = "lblDesc"
        lblDesc.Size = New Size(128, 28)
        lblDesc.TabIndex = 29
        lblDesc.Text = "Descripción:"
        ' 
        ' lblFecSoli
        ' 
        lblFecSoli.AutoSize = True
        lblFecSoli.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblFecSoli.ForeColor = Color.White
        lblFecSoli.Location = New Point(72, 110)
        lblFecSoli.Name = "lblFecSoli"
        lblFecSoli.Size = New Size(158, 28)
        lblFecSoli.TabIndex = 28
        lblFecSoli.Text = "Fecha solicitud:"
        ' 
        ' lblCli
        ' 
        lblCli.AutoSize = True
        lblCli.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblCli.ForeColor = Color.White
        lblCli.Location = New Point(72, 62)
        lblCli.Name = "lblCli"
        lblCli.Size = New Size(83, 28)
        lblCli.TabIndex = 27
        lblCli.Text = "Cliente:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(91, 147)
        Label2.Name = "Label2"
        Label2.Size = New Size(154, 20)
        Label2.TabIndex = 33
        Label2.Text = "Busqueda de cliente"
        ' 
        ' Panel2
        ' 
        Panel2.BorderStyle = BorderStyle.Fixed3D
        Panel2.Controls.Add(btnBuscar)
        Panel2.Controls.Add(txtRutNom)
        Panel2.Controls.Add(lblCloiente)
        Panel2.Location = New Point(73, 158)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(731, 125)
        Panel2.TabIndex = 32
        ' 
        ' btnBuscar
        ' 
        btnBuscar.BackColor = Color.DimGray
        btnBuscar.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnBuscar.ForeColor = Color.White
        btnBuscar.Image = My.Resources.Resources.buscar
        btnBuscar.ImageAlign = ContentAlignment.MiddleRight
        btnBuscar.Location = New Point(555, 44)
        btnBuscar.Name = "btnBuscar"
        btnBuscar.Padding = New Padding(0, 0, 20, 0)
        btnBuscar.Size = New Size(138, 38)
        btnBuscar.TabIndex = 29
        btnBuscar.Text = "Buscar"
        btnBuscar.UseVisualStyleBackColor = False
        ' 
        ' txtRutNom
        ' 
        txtRutNom.Location = New Point(199, 48)
        txtRutNom.Multiline = True
        txtRutNom.Name = "txtRutNom"
        txtRutNom.Size = New Size(331, 28)
        txtRutNom.TabIndex = 27
        ' 
        ' lblCloiente
        ' 
        lblCloiente.AutoSize = True
        lblCloiente.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblCloiente.ForeColor = Color.White
        lblCloiente.Location = New Point(34, 48)
        lblCloiente.Name = "lblCloiente"
        lblCloiente.Size = New Size(132, 28)
        lblCloiente.TabIndex = 26
        lblCloiente.Text = "Rut/nombre:"
        ' 
        ' lblTituloActualizacion
        ' 
        lblTituloActualizacion.AutoSize = True
        lblTituloActualizacion.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTituloActualizacion.ForeColor = Color.White
        lblTituloActualizacion.Location = New Point(243, 20)
        lblTituloActualizacion.Name = "lblTituloActualizacion"
        lblTituloActualizacion.Size = New Size(378, 41)
        lblTituloActualizacion.TabIndex = 31
        lblTituloActualizacion.Text = "Actualización de servicios"
        ' 
        ' PanelListado
        ' 
        PanelListado.Controls.Add(Label5)
        PanelListado.Controls.Add(Label4)
        PanelListado.Controls.Add(Panel4)
        PanelListado.Controls.Add(lblTitulo)
        PanelListado.Controls.Add(Panel1)
        PanelListado.Location = New Point(21, 42)
        PanelListado.Name = "PanelListado"
        PanelListado.Size = New Size(977, 719)
        PanelListado.TabIndex = 22
        PanelListado.Visible = False
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(48, 95)
        Label5.Name = "Label5"
        Label5.Size = New Size(171, 20)
        Label5.TabIndex = 23
        Label5.Text = "Busqueda de servicios"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(49, 239)
        Label4.Name = "Label4"
        Label4.Size = New Size(154, 20)
        Label4.TabIndex = 0
        Label4.Text = "Listado de servicios"
        ' 
        ' Panel4
        ' 
        Panel4.BorderStyle = BorderStyle.Fixed3D
        Panel4.Controls.Add(DataGridView1)
        Panel4.Location = New Point(24, 251)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(930, 449)
        Panel4.TabIndex = 19
        ' 
        ' DataGridView1
        ' 
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = SystemColors.Control
        DataGridViewCellStyle1.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle1.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = SystemColors.Control
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle2.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
        DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {ID, Rut, FechaSolicitud, DescripcionProblema, Estado, Siniestroid, RutEmplado})
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = SystemColors.Window
        DataGridViewCellStyle3.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle3.ForeColor = Color.White
        DataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.False
        DataGridView1.DefaultCellStyle = DataGridViewCellStyle3
        DataGridView1.Location = New Point(20, 53)
        DataGridView1.Name = "DataGridView1"
        DataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = SystemColors.Control
        DataGridViewCellStyle4.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle4.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = DataGridViewTriState.True
        DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        DataGridView1.RowHeadersWidth = 51
        DataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = SystemColors.Control
        DataGridViewCellStyle5.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle5.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = DataGridViewTriState.True
        DataGridView1.RowsDefaultCellStyle = DataGridViewCellStyle5
        DataGridView1.Size = New Size(888, 337)
        DataGridView1.TabIndex = 25
        ' 
        ' ID
        ' 
        ID.HeaderText = "ID"
        ID.MinimumWidth = 6
        ID.Name = "ID"
        ID.Width = 40
        ' 
        ' Rut
        ' 
        Rut.HeaderText = "Rut cliente"
        Rut.MinimumWidth = 6
        Rut.Name = "Rut"
        Rut.Width = 125
        ' 
        ' FechaSolicitud
        ' 
        FechaSolicitud.HeaderText = "Fecha solicitud"
        FechaSolicitud.MinimumWidth = 6
        FechaSolicitud.Name = "FechaSolicitud"
        FechaSolicitud.Width = 125
        ' 
        ' DescripcionProblema
        ' 
        DescripcionProblema.HeaderText = "Descripción"
        DescripcionProblema.MinimumWidth = 6
        DescripcionProblema.Name = "DescripcionProblema"
        DescripcionProblema.Width = 220
        ' 
        ' Estado
        ' 
        Estado.HeaderText = "Estado servicio"
        Estado.MinimumWidth = 6
        Estado.Name = "Estado"
        Estado.Width = 125
        ' 
        ' Siniestroid
        ' 
        Siniestroid.HeaderText = "ID siniestro"
        Siniestroid.MinimumWidth = 6
        Siniestroid.Name = "Siniestroid"
        Siniestroid.Width = 80
        ' 
        ' RutEmplado
        ' 
        RutEmplado.HeaderText = "Empleado"
        RutEmplado.MinimumWidth = 6
        RutEmplado.Name = "RutEmplado"
        RutEmplado.Width = 158
        ' 
        ' lblTitulo
        ' 
        lblTitulo.AutoSize = True
        lblTitulo.Font = New Font("Arial Black", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTitulo.ForeColor = SystemColors.ButtonHighlight
        lblTitulo.Location = New Point(211, 23)
        lblTitulo.Name = "lblTitulo"
        lblTitulo.Size = New Size(543, 56)
        lblTitulo.TabIndex = 18
        lblTitulo.Text = "solicitudes de servicios"
        ' 
        ' Panel1
        ' 
        Panel1.BorderStyle = BorderStyle.Fixed3D
        Panel1.Controls.Add(btnVerTodo)
        Panel1.Controls.Add(cbxBuscarEstado)
        Panel1.Controls.Add(btnBuscarCli)
        Panel1.Controls.Add(txtCliente)
        Panel1.Controls.Add(lblCliente)
        Panel1.Location = New Point(24, 105)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(930, 118)
        Panel1.TabIndex = 17
        ' 
        ' btnVerTodo
        ' 
        btnVerTodo.BackColor = Color.DimGray
        btnVerTodo.Font = New Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnVerTodo.ForeColor = Color.White
        btnVerTodo.Image = My.Resources.Resources.visualizar_2
        btnVerTodo.ImageAlign = ContentAlignment.MiddleRight
        btnVerTodo.Location = New Point(778, 35)
        btnVerTodo.Name = "btnVerTodo"
        btnVerTodo.Padding = New Padding(0, 0, 20, 0)
        btnVerTodo.Size = New Size(138, 36)
        btnVerTodo.TabIndex = 24
        btnVerTodo.Text = "Ver todo"
        btnVerTodo.UseVisualStyleBackColor = False
        ' 
        ' cbxBuscarEstado
        ' 
        cbxBuscarEstado.FormattingEnabled = True
        cbxBuscarEstado.Location = New Point(538, 38)
        cbxBuscarEstado.Name = "cbxBuscarEstado"
        cbxBuscarEstado.Size = New Size(221, 28)
        cbxBuscarEstado.TabIndex = 22
        ' 
        ' btnBuscarCli
        ' 
        btnBuscarCli.BackColor = Color.DimGray
        btnBuscarCli.Font = New Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnBuscarCli.ForeColor = Color.White
        btnBuscarCli.Image = My.Resources.Resources.buscar
        btnBuscarCli.ImageAlign = ContentAlignment.MiddleRight
        btnBuscarCli.Location = New Point(401, 34)
        btnBuscarCli.Name = "btnBuscarCli"
        btnBuscarCli.Padding = New Padding(0, 0, 20, 0)
        btnBuscarCli.Size = New Size(123, 35)
        btnBuscarCli.TabIndex = 21
        btnBuscarCli.Text = "Buscar"
        btnBuscarCli.UseVisualStyleBackColor = False
        ' 
        ' txtCliente
        ' 
        txtCliente.Location = New Point(98, 38)
        txtCliente.Multiline = True
        txtCliente.Name = "txtCliente"
        txtCliente.Size = New Size(279, 28)
        txtCliente.TabIndex = 2
        ' 
        ' lblCliente
        ' 
        lblCliente.AutoSize = True
        lblCliente.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblCliente.ForeColor = Color.White
        lblCliente.Location = New Point(3, 38)
        lblCliente.Name = "lblCliente"
        lblCliente.Size = New Size(83, 28)
        lblCliente.TabIndex = 1
        lblCliente.Text = "Cliente:"
        ' 
        ' Form7
        ' 
        AutoScaleDimensions = New SizeF(9F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(35), CByte(35), CByte(35))
        ClientSize = New Size(1019, 828)
        Controls.Add(PanelListado)
        Controls.Add(PanelActualizacion)
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
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        PanelActualizacion.ResumeLayout(False)
        PanelActualizacion.PerformLayout()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        PanelListado.ResumeLayout(False)
        PanelListado.PerformLayout()
        Panel4.ResumeLayout(False)
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
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
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PanelActualizacion As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lblTituloActualizacion As Label
    Friend WithEvents txtRutNom As TextBox
    Friend WithEvents lblCloiente As Label
    Friend WithEvents btnBuscar As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents lblCli As Label
    Friend WithEvents txtRutCli As TextBox
    Friend WithEvents lblEmp As Label
    Friend WithEvents lblEstServ As Label
    Friend WithEvents lblDesc As Label
    Friend WithEvents lblFecSoli As Label
    Friend WithEvents FecSoli As DateTimePicker
    Friend WithEvents txtEmpleado As TextBox
    Friend WithEvents cbxEstServ As ComboBox
    Friend WithEvents txtDesc As TextBox
    Friend WithEvents btnActualizar As Button
    Friend WithEvents txtSolicitudID As TextBox
    Friend WithEvents PanelListado As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents cbxBuscarEstado As ComboBox
    Friend WithEvents btnBuscarCli As Button
    Friend WithEvents txtCliente As TextBox
    Friend WithEvents lblCliente As Label
    Friend WithEvents lblTitulo As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents btnVerTodo As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents ID As DataGridViewTextBoxColumn
    Friend WithEvents Rut As DataGridViewTextBoxColumn
    Friend WithEvents FechaSolicitud As DataGridViewTextBoxColumn
    Friend WithEvents DescripcionProblema As DataGridViewTextBoxColumn
    Friend WithEvents Estado As DataGridViewTextBoxColumn
    Friend WithEvents Siniestroid As DataGridViewTextBoxColumn
    Friend WithEvents RutEmplado As DataGridViewTextBoxColumn

End Class
