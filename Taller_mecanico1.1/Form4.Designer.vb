﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        MenuStrip1 = New MenuStrip()
        GestiónDeRepuestosToolStripMenuItem = New ToolStripMenuItem()
        InventarioDeRepuestosToolStripMenuItem = New ToolStripMenuItem()
        GarantiaDeRepuestosToolStripMenuItem = New ToolStripMenuItem()
        SolicitudDeRepuestosToolStripMenuItem = New ToolStripMenuItem()
        VentasToolStripMenuItem = New ToolStripMenuItem()
        VentaDeRepuestosToolStripMenuItem = New ToolStripMenuItem()
        HistorialDeVentasToolStripMenuItem = New ToolStripMenuItem()
        PictureBox1 = New PictureBox()
        PanelInventario = New Panel()
        btnEliminar = New Button()
        btnModificar = New Button()
        btnGuardar = New Button()
        txtProvedor = New TextBox()
        txtPrecio = New TextBox()
        txtCantidad = New TextBox()
        txtID = New TextBox()
        txtRepuesto = New TextBox()
        lblProvedor = New Label()
        lblPrecio = New Label()
        lblCantidad = New Label()
        lblRepuesto = New Label()
        lblID = New Label()
        CheckEliminar = New CheckBox()
        CheckModificar = New CheckBox()
        CheckIngresar = New CheckBox()
        btnBuscar = New Button()
        btnVisualizar = New Button()
        txtDescripcion = New TextBox()
        lblDescripcion = New Label()
        DataGridView1 = New DataGridView()
        ID = New DataGridViewTextBoxColumn()
        Repuesto = New DataGridViewTextBoxColumn()
        Cantidad = New DataGridViewTextBoxColumn()
        Precio = New DataGridViewTextBoxColumn()
        Proveedor = New DataGridViewTextBoxColumn()
        Label1 = New Label()
        PanelGarantia = New Panel()
        cbxCliente = New ComboBox()
        FecFin = New DateTimePicker()
        FecIni = New DateTimePicker()
        btnEliminar2 = New Button()
        btnModificar2 = New Button()
        btnGuardar2 = New Button()
        chbxEliminar = New CheckBox()
        chbxModificar = New CheckBox()
        chbxIngresar = New CheckBox()
        txtID2 = New TextBox()
        txtDesc2 = New TextBox()
        txtDetalle = New TextBox()
        lblFecFin = New Label()
        lblFecIni = New Label()
        lblCliente = New Label()
        lblDetalle = New Label()
        lblDesc2 = New Label()
        lblID2 = New Label()
        btnVisualizar2 = New Button()
        btnBuscar2 = New Button()
        txtDescGarantia = New TextBox()
        DataGridView2 = New DataGridView()
        GarantiaID = New DataGridViewTextBoxColumn()
        NombreRepuesto = New DataGridViewTextBoxColumn()
        DetalleGarantia = New DataGridViewTextBoxColumn()
        Cliente = New DataGridViewTextBoxColumn()
        FechaInicio = New DataGridViewTextBoxColumn()
        FechaFin = New DataGridViewTextBoxColumn()
        lblIdDesc = New Label()
        Label2 = New Label()
        PanelVentas = New Panel()
        Label11 = New Label()
        txtPrecioo = New TextBox()
        btnComprar = New Button()
        Label10 = New Label()
        Label9 = New Label()
        txtMonto = New TextBox()
        Label8 = New Label()
        Label7 = New Label()
        Label6 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        txtFecha = New TextBox()
        TxtRutCliente = New TextBox()
        txtCantidadd = New TextBox()
        txtNomRepuesto = New TextBox()
        btnbuscador = New Button()
        btnVerTodo = New Button()
        txtDescrip = New TextBox()
        Label3 = New Label()
        DataGridVentas = New DataGridView()
        DataGridViewTextBoxColumn1 = New DataGridViewTextBoxColumn()
        Descripcion = New DataGridViewTextBoxColumn()
        cantidadd = New DataGridViewTextBoxColumn()
        precioo = New DataGridViewTextBoxColumn()
        Proveedo = New DataGridViewTextBoxColumn()
        panelHistorialVentas = New Panel()
        Label13 = New Label()
        btnBuscarVentas = New Button()
        btnVerTodos = New Button()
        txtNomRep = New TextBox()
        Label12 = New Label()
        DataGridHistorialVentas = New DataGridView()
        DataGridViewTextBoxColumn2 = New DataGridViewTextBoxColumn()
        DataGridViewTextBoxColumn3 = New DataGridViewTextBoxColumn()
        DataGridViewTextBoxColumn4 = New DataGridViewTextBoxColumn()
        DataGridViewTextBoxColumn5 = New DataGridViewTextBoxColumn()
        DataGridViewTextBoxColumn6 = New DataGridViewTextBoxColumn()
        Total = New DataGridViewTextBoxColumn()
        btnVolver = New Button()
        MenuStrip1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        PanelInventario.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        PanelGarantia.SuspendLayout()
        CType(DataGridView2, ComponentModel.ISupportInitialize).BeginInit()
        PanelVentas.SuspendLayout()
        CType(DataGridVentas, ComponentModel.ISupportInitialize).BeginInit()
        panelHistorialVentas.SuspendLayout()
        CType(DataGridHistorialVentas, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.BackColor = Color.DimGray
        MenuStrip1.ImageScalingSize = New Size(20, 20)
        MenuStrip1.Items.AddRange(New ToolStripItem() {GestiónDeRepuestosToolStripMenuItem, VentasToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(1092, 28)
        MenuStrip1.TabIndex = 1
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' GestiónDeRepuestosToolStripMenuItem
        ' 
        GestiónDeRepuestosToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {InventarioDeRepuestosToolStripMenuItem, GarantiaDeRepuestosToolStripMenuItem, SolicitudDeRepuestosToolStripMenuItem})
        GestiónDeRepuestosToolStripMenuItem.Font = New Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GestiónDeRepuestosToolStripMenuItem.ForeColor = Color.White
        GestiónDeRepuestosToolStripMenuItem.Name = "GestiónDeRepuestosToolStripMenuItem"
        GestiónDeRepuestosToolStripMenuItem.Size = New Size(177, 24)
        GestiónDeRepuestosToolStripMenuItem.Text = "Gestión de repuestos"
        ' 
        ' InventarioDeRepuestosToolStripMenuItem
        ' 
        InventarioDeRepuestosToolStripMenuItem.BackColor = Color.DimGray
        InventarioDeRepuestosToolStripMenuItem.ForeColor = Color.White
        InventarioDeRepuestosToolStripMenuItem.Name = "InventarioDeRepuestosToolStripMenuItem"
        InventarioDeRepuestosToolStripMenuItem.Size = New Size(266, 26)
        InventarioDeRepuestosToolStripMenuItem.Text = "Inventario de repuestos"
        ' 
        ' GarantiaDeRepuestosToolStripMenuItem
        ' 
        GarantiaDeRepuestosToolStripMenuItem.BackColor = Color.DimGray
        GarantiaDeRepuestosToolStripMenuItem.ForeColor = Color.White
        GarantiaDeRepuestosToolStripMenuItem.Name = "GarantiaDeRepuestosToolStripMenuItem"
        GarantiaDeRepuestosToolStripMenuItem.Size = New Size(266, 26)
        GarantiaDeRepuestosToolStripMenuItem.Text = "Garantia de repuestos"
        ' 
        ' SolicitudDeRepuestosToolStripMenuItem
        ' 
        SolicitudDeRepuestosToolStripMenuItem.BackColor = Color.DimGray
        SolicitudDeRepuestosToolStripMenuItem.ForeColor = Color.White
        SolicitudDeRepuestosToolStripMenuItem.Name = "SolicitudDeRepuestosToolStripMenuItem"
        SolicitudDeRepuestosToolStripMenuItem.Size = New Size(266, 26)
        SolicitudDeRepuestosToolStripMenuItem.Text = "Solicitud de repuestos"
        ' 
        ' VentasToolStripMenuItem
        ' 
        VentasToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {VentaDeRepuestosToolStripMenuItem, HistorialDeVentasToolStripMenuItem})
        VentasToolStripMenuItem.Font = New Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        VentasToolStripMenuItem.ForeColor = Color.White
        VentasToolStripMenuItem.Name = "VentasToolStripMenuItem"
        VentasToolStripMenuItem.Size = New Size(72, 24)
        VentasToolStripMenuItem.Text = "Ventas"
        ' 
        ' VentaDeRepuestosToolStripMenuItem
        ' 
        VentaDeRepuestosToolStripMenuItem.BackColor = Color.DimGray
        VentaDeRepuestosToolStripMenuItem.ForeColor = Color.White
        VentaDeRepuestosToolStripMenuItem.Name = "VentaDeRepuestosToolStripMenuItem"
        VentaDeRepuestosToolStripMenuItem.Size = New Size(232, 26)
        VentaDeRepuestosToolStripMenuItem.Text = "Venta de repuestos"
        ' 
        ' HistorialDeVentasToolStripMenuItem
        ' 
        HistorialDeVentasToolStripMenuItem.BackColor = Color.Gray
        HistorialDeVentasToolStripMenuItem.ForeColor = Color.White
        HistorialDeVentasToolStripMenuItem.Name = "HistorialDeVentasToolStripMenuItem"
        HistorialDeVentasToolStripMenuItem.Size = New Size(232, 26)
        HistorialDeVentasToolStripMenuItem.Text = "Historial de ventas"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BorderStyle = BorderStyle.Fixed3D
        PictureBox1.Image = My.Resources.Resources.repuestos_logoGrande
        PictureBox1.Location = New Point(124, 130)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(850, 679)
        PictureBox1.TabIndex = 3
        PictureBox1.TabStop = False
        ' 
        ' PanelInventario
        ' 
        PanelInventario.Controls.Add(btnEliminar)
        PanelInventario.Controls.Add(btnModificar)
        PanelInventario.Controls.Add(btnGuardar)
        PanelInventario.Controls.Add(txtProvedor)
        PanelInventario.Controls.Add(txtPrecio)
        PanelInventario.Controls.Add(txtCantidad)
        PanelInventario.Controls.Add(txtID)
        PanelInventario.Controls.Add(txtRepuesto)
        PanelInventario.Controls.Add(lblProvedor)
        PanelInventario.Controls.Add(lblPrecio)
        PanelInventario.Controls.Add(lblCantidad)
        PanelInventario.Controls.Add(lblRepuesto)
        PanelInventario.Controls.Add(lblID)
        PanelInventario.Controls.Add(CheckEliminar)
        PanelInventario.Controls.Add(CheckModificar)
        PanelInventario.Controls.Add(CheckIngresar)
        PanelInventario.Controls.Add(btnBuscar)
        PanelInventario.Controls.Add(btnVisualizar)
        PanelInventario.Controls.Add(txtDescripcion)
        PanelInventario.Controls.Add(lblDescripcion)
        PanelInventario.Controls.Add(DataGridView1)
        PanelInventario.Controls.Add(Label1)
        PanelInventario.Location = New Point(50, 62)
        PanelInventario.Name = "PanelInventario"
        PanelInventario.Size = New Size(989, 781)
        PanelInventario.TabIndex = 4
        PanelInventario.Visible = False
        ' 
        ' btnEliminar
        ' 
        btnEliminar.BackColor = Color.DimGray
        btnEliminar.Enabled = False
        btnEliminar.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnEliminar.ForeColor = Color.White
        btnEliminar.Image = My.Resources.Resources.eliminar
        btnEliminar.ImageAlign = ContentAlignment.MiddleRight
        btnEliminar.Location = New Point(722, 657)
        btnEliminar.Name = "btnEliminar"
        btnEliminar.Padding = New Padding(0, 0, 30, 0)
        btnEliminar.Size = New Size(227, 61)
        btnEliminar.TabIndex = 40
        btnEliminar.Text = "Eliminar"
        btnEliminar.UseVisualStyleBackColor = False
        ' 
        ' btnModificar
        ' 
        btnModificar.BackColor = Color.DimGray
        btnModificar.Enabled = False
        btnModificar.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnModificar.ForeColor = Color.White
        btnModificar.Image = My.Resources.Resources.modificar
        btnModificar.ImageAlign = ContentAlignment.MiddleRight
        btnModificar.Location = New Point(722, 580)
        btnModificar.Name = "btnModificar"
        btnModificar.Padding = New Padding(0, 0, 30, 0)
        btnModificar.Size = New Size(227, 61)
        btnModificar.TabIndex = 39
        btnModificar.Text = "Modificar"
        btnModificar.UseVisualStyleBackColor = False
        ' 
        ' btnGuardar
        ' 
        btnGuardar.BackColor = Color.DimGray
        btnGuardar.Enabled = False
        btnGuardar.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnGuardar.ForeColor = Color.White
        btnGuardar.Image = My.Resources.Resources.guardar
        btnGuardar.ImageAlign = ContentAlignment.MiddleRight
        btnGuardar.Location = New Point(722, 503)
        btnGuardar.Name = "btnGuardar"
        btnGuardar.Padding = New Padding(0, 0, 30, 0)
        btnGuardar.Size = New Size(227, 61)
        btnGuardar.TabIndex = 38
        btnGuardar.Text = "Guardar"
        btnGuardar.UseVisualStyleBackColor = False
        ' 
        ' txtProvedor
        ' 
        txtProvedor.Enabled = False
        txtProvedor.Location = New Point(345, 719)
        txtProvedor.Multiline = True
        txtProvedor.Name = "txtProvedor"
        txtProvedor.Size = New Size(241, 28)
        txtProvedor.TabIndex = 37
        ' 
        ' txtPrecio
        ' 
        txtPrecio.Enabled = False
        txtPrecio.Location = New Point(345, 657)
        txtPrecio.Multiline = True
        txtPrecio.Name = "txtPrecio"
        txtPrecio.Size = New Size(125, 28)
        txtPrecio.TabIndex = 36
        ' 
        ' txtCantidad
        ' 
        txtCantidad.Enabled = False
        txtCantidad.Location = New Point(345, 600)
        txtCantidad.Multiline = True
        txtCantidad.Name = "txtCantidad"
        txtCantidad.Size = New Size(125, 28)
        txtCantidad.TabIndex = 35
        ' 
        ' txtID
        ' 
        txtID.Enabled = False
        txtID.Location = New Point(345, 476)
        txtID.Multiline = True
        txtID.Name = "txtID"
        txtID.Size = New Size(106, 28)
        txtID.TabIndex = 34
        ' 
        ' txtRepuesto
        ' 
        txtRepuesto.Enabled = False
        txtRepuesto.Location = New Point(345, 536)
        txtRepuesto.Multiline = True
        txtRepuesto.Name = "txtRepuesto"
        txtRepuesto.Size = New Size(297, 28)
        txtRepuesto.TabIndex = 33
        ' 
        ' lblProvedor
        ' 
        lblProvedor.AutoSize = True
        lblProvedor.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblProvedor.ForeColor = Color.White
        lblProvedor.Location = New Point(201, 719)
        lblProvedor.Name = "lblProvedor"
        lblProvedor.Size = New Size(104, 28)
        lblProvedor.TabIndex = 32
        lblProvedor.Text = "Provedor:"
        ' 
        ' lblPrecio
        ' 
        lblPrecio.AutoSize = True
        lblPrecio.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblPrecio.ForeColor = Color.White
        lblPrecio.Location = New Point(201, 657)
        lblPrecio.Name = "lblPrecio"
        lblPrecio.Size = New Size(76, 28)
        lblPrecio.TabIndex = 31
        lblPrecio.Text = "Precio:"
        ' 
        ' lblCantidad
        ' 
        lblCantidad.AutoSize = True
        lblCantidad.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblCantidad.ForeColor = Color.White
        lblCantidad.Location = New Point(201, 596)
        lblCantidad.Name = "lblCantidad"
        lblCantidad.Size = New Size(101, 28)
        lblCantidad.TabIndex = 30
        lblCantidad.Text = "Cantidad:"
        ' 
        ' lblRepuesto
        ' 
        lblRepuesto.AutoSize = True
        lblRepuesto.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblRepuesto.ForeColor = Color.White
        lblRepuesto.Location = New Point(201, 536)
        lblRepuesto.Name = "lblRepuesto"
        lblRepuesto.Size = New Size(128, 28)
        lblRepuesto.TabIndex = 29
        lblRepuesto.Text = "Descripcion:"
        ' 
        ' lblID
        ' 
        lblID.AutoSize = True
        lblID.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblID.ForeColor = Color.White
        lblID.Location = New Point(201, 476)
        lblID.Name = "lblID"
        lblID.Size = New Size(38, 28)
        lblID.TabIndex = 28
        lblID.Text = "ID:"
        ' 
        ' CheckEliminar
        ' 
        CheckEliminar.AutoSize = True
        CheckEliminar.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        CheckEliminar.ForeColor = Color.White
        CheckEliminar.Location = New Point(685, 396)
        CheckEliminar.Name = "CheckEliminar"
        CheckEliminar.Size = New Size(154, 24)
        CheckEliminar.TabIndex = 27
        CheckEliminar.Text = "Eliminar repuesto"
        CheckEliminar.UseVisualStyleBackColor = True
        ' 
        ' CheckModificar
        ' 
        CheckModificar.AutoSize = True
        CheckModificar.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        CheckModificar.ForeColor = Color.White
        CheckModificar.Location = New Point(406, 396)
        CheckModificar.Name = "CheckModificar"
        CheckModificar.Size = New Size(164, 24)
        CheckModificar.TabIndex = 26
        CheckModificar.Text = "Modificar repuesto"
        CheckModificar.UseVisualStyleBackColor = True
        ' 
        ' CheckIngresar
        ' 
        CheckIngresar.AutoSize = True
        CheckIngresar.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        CheckIngresar.ForeColor = Color.White
        CheckIngresar.Location = New Point(148, 396)
        CheckIngresar.Name = "CheckIngresar"
        CheckIngresar.Size = New Size(155, 24)
        CheckIngresar.TabIndex = 25
        CheckIngresar.Text = "Ingresar repuesto"
        CheckIngresar.UseVisualStyleBackColor = True
        ' 
        ' btnBuscar
        ' 
        btnBuscar.BackColor = Color.DimGray
        btnBuscar.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnBuscar.ForeColor = Color.White
        btnBuscar.Image = My.Resources.Resources.buscar
        btnBuscar.ImageAlign = ContentAlignment.MiddleRight
        btnBuscar.Location = New Point(567, 110)
        btnBuscar.Name = "btnBuscar"
        btnBuscar.Padding = New Padding(0, 0, 20, 0)
        btnBuscar.Size = New Size(138, 38)
        btnBuscar.TabIndex = 20
        btnBuscar.Text = "Buscar"
        btnBuscar.UseVisualStyleBackColor = False
        ' 
        ' btnVisualizar
        ' 
        btnVisualizar.BackColor = Color.DimGray
        btnVisualizar.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnVisualizar.ForeColor = Color.White
        btnVisualizar.Image = My.Resources.Resources.visualizar_2
        btnVisualizar.ImageAlign = ContentAlignment.MiddleRight
        btnVisualizar.Location = New Point(722, 110)
        btnVisualizar.Name = "btnVisualizar"
        btnVisualizar.Padding = New Padding(0, 0, 20, 0)
        btnVisualizar.Size = New Size(172, 38)
        btnVisualizar.TabIndex = 19
        btnVisualizar.Text = "Visualizar"
        btnVisualizar.UseVisualStyleBackColor = False
        ' 
        ' txtDescripcion
        ' 
        txtDescripcion.Location = New Point(254, 114)
        txtDescripcion.Multiline = True
        txtDescripcion.Name = "txtDescripcion"
        txtDescripcion.Size = New Size(297, 28)
        txtDescripcion.TabIndex = 17
        ' 
        ' lblDescripcion
        ' 
        lblDescripcion.AutoSize = True
        lblDescripcion.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblDescripcion.ForeColor = Color.White
        lblDescripcion.Location = New Point(90, 114)
        lblDescripcion.Name = "lblDescripcion"
        lblDescripcion.Size = New Size(158, 28)
        lblDescripcion.TabIndex = 16
        lblDescripcion.Text = "ID/Descripcion:"
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {ID, Repuesto, Cantidad, Precio, Proveedor})
        DataGridView1.Location = New Point(90, 154)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.Size = New Size(804, 207)
        DataGridView1.TabIndex = 13
        ' 
        ' ID
        ' 
        ID.HeaderText = "ID"
        ID.MinimumWidth = 6
        ID.Name = "ID"
        ID.Width = 125
        ' 
        ' Repuesto
        ' 
        Repuesto.HeaderText = "Descripción"
        Repuesto.MinimumWidth = 6
        Repuesto.Name = "Repuesto"
        Repuesto.Width = 250
        ' 
        ' Cantidad
        ' 
        Cantidad.HeaderText = "Cantidad"
        Cantidad.MinimumWidth = 6
        Cantidad.Name = "Cantidad"
        Cantidad.Width = 125
        ' 
        ' Precio
        ' 
        Precio.HeaderText = "Precio"
        Precio.MinimumWidth = 6
        Precio.Name = "Precio"
        Precio.Width = 125
        ' 
        ' Proveedor
        ' 
        Proveedor.HeaderText = "Proveedor"
        Proveedor.MinimumWidth = 6
        Proveedor.Name = "Proveedor"
        Proveedor.Width = 125
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Arial Black", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.ButtonHighlight
        Label1.Location = New Point(218, 29)
        Label1.Name = "Label1"
        Label1.Size = New Size(546, 56)
        Label1.TabIndex = 12
        Label1.Text = "Inventario de repuestos"
        ' 
        ' PanelGarantia
        ' 
        PanelGarantia.Controls.Add(cbxCliente)
        PanelGarantia.Controls.Add(FecFin)
        PanelGarantia.Controls.Add(FecIni)
        PanelGarantia.Controls.Add(btnEliminar2)
        PanelGarantia.Controls.Add(btnModificar2)
        PanelGarantia.Controls.Add(btnGuardar2)
        PanelGarantia.Controls.Add(chbxEliminar)
        PanelGarantia.Controls.Add(chbxModificar)
        PanelGarantia.Controls.Add(chbxIngresar)
        PanelGarantia.Controls.Add(txtID2)
        PanelGarantia.Controls.Add(txtDesc2)
        PanelGarantia.Controls.Add(txtDetalle)
        PanelGarantia.Controls.Add(lblFecFin)
        PanelGarantia.Controls.Add(lblFecIni)
        PanelGarantia.Controls.Add(lblCliente)
        PanelGarantia.Controls.Add(lblDetalle)
        PanelGarantia.Controls.Add(lblDesc2)
        PanelGarantia.Controls.Add(lblID2)
        PanelGarantia.Controls.Add(btnVisualizar2)
        PanelGarantia.Controls.Add(btnBuscar2)
        PanelGarantia.Controls.Add(txtDescGarantia)
        PanelGarantia.Controls.Add(DataGridView2)
        PanelGarantia.Controls.Add(lblIdDesc)
        PanelGarantia.Controls.Add(Label2)
        PanelGarantia.Location = New Point(50, 65)
        PanelGarantia.Name = "PanelGarantia"
        PanelGarantia.Size = New Size(1001, 785)
        PanelGarantia.TabIndex = 19
        PanelGarantia.Visible = False
        ' 
        ' cbxCliente
        ' 
        cbxCliente.Enabled = False
        cbxCliente.FormattingEnabled = True
        cbxCliente.Location = New Point(725, 571)
        cbxCliente.Name = "cbxCliente"
        cbxCliente.Size = New Size(227, 28)
        cbxCliente.TabIndex = 41
        ' 
        ' FecFin
        ' 
        FecFin.CustomFormat = """yyyy-MM-dd"""
        FecFin.Enabled = False
        FecFin.Format = DateTimePickerFormat.Custom
        FecFin.Location = New Point(725, 662)
        FecFin.Name = "FecFin"
        FecFin.Size = New Size(117, 27)
        FecFin.TabIndex = 40
        ' 
        ' FecIni
        ' 
        FecIni.CustomFormat = """yyyy-MM-dd"""
        FecIni.Enabled = False
        FecIni.Format = DateTimePickerFormat.Custom
        FecIni.Location = New Point(725, 617)
        FecIni.Name = "FecIni"
        FecIni.Size = New Size(117, 27)
        FecIni.TabIndex = 39
        ' 
        ' btnEliminar2
        ' 
        btnEliminar2.BackColor = Color.DimGray
        btnEliminar2.Enabled = False
        btnEliminar2.Font = New Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnEliminar2.ForeColor = Color.White
        btnEliminar2.Image = My.Resources.Resources.eliminar
        btnEliminar2.ImageAlign = ContentAlignment.MiddleRight
        btnEliminar2.Location = New Point(136, 611)
        btnEliminar2.Name = "btnEliminar2"
        btnEliminar2.Padding = New Padding(0, 0, 30, 0)
        btnEliminar2.Size = New Size(221, 61)
        btnEliminar2.TabIndex = 38
        btnEliminar2.Text = "Eliminar"
        btnEliminar2.UseVisualStyleBackColor = False
        ' 
        ' btnModificar2
        ' 
        btnModificar2.BackColor = Color.DimGray
        btnModificar2.Enabled = False
        btnModificar2.Font = New Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnModificar2.ForeColor = Color.White
        btnModificar2.Image = My.Resources.Resources.modificar
        btnModificar2.ImageAlign = ContentAlignment.MiddleRight
        btnModificar2.Location = New Point(136, 524)
        btnModificar2.Name = "btnModificar2"
        btnModificar2.Padding = New Padding(0, 0, 30, 0)
        btnModificar2.Size = New Size(221, 61)
        btnModificar2.TabIndex = 37
        btnModificar2.Text = "Modificar"
        btnModificar2.UseVisualStyleBackColor = False
        ' 
        ' btnGuardar2
        ' 
        btnGuardar2.BackColor = Color.DimGray
        btnGuardar2.Enabled = False
        btnGuardar2.Font = New Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnGuardar2.ForeColor = Color.White
        btnGuardar2.Image = My.Resources.Resources.guardar
        btnGuardar2.ImageAlign = ContentAlignment.MiddleRight
        btnGuardar2.Location = New Point(136, 437)
        btnGuardar2.Name = "btnGuardar2"
        btnGuardar2.Padding = New Padding(0, 0, 30, 0)
        btnGuardar2.Size = New Size(221, 61)
        btnGuardar2.TabIndex = 36
        btnGuardar2.Text = "Guardar"
        btnGuardar2.UseVisualStyleBackColor = False
        ' 
        ' chbxEliminar
        ' 
        chbxEliminar.AutoSize = True
        chbxEliminar.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        chbxEliminar.ForeColor = Color.White
        chbxEliminar.Location = New Point(841, 739)
        chbxEliminar.Name = "chbxEliminar"
        chbxEliminar.Size = New Size(150, 24)
        chbxEliminar.TabIndex = 35
        chbxEliminar.Text = "Eliminar garantia"
        chbxEliminar.UseVisualStyleBackColor = True
        ' 
        ' chbxModificar
        ' 
        chbxModificar.AutoSize = True
        chbxModificar.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        chbxModificar.ForeColor = Color.White
        chbxModificar.Location = New Point(659, 739)
        chbxModificar.Name = "chbxModificar"
        chbxModificar.Size = New Size(160, 24)
        chbxModificar.TabIndex = 34
        chbxModificar.Text = "Modificar garantia"
        chbxModificar.UseVisualStyleBackColor = True
        ' 
        ' chbxIngresar
        ' 
        chbxIngresar.AutoSize = True
        chbxIngresar.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        chbxIngresar.ForeColor = Color.White
        chbxIngresar.Location = New Point(491, 739)
        chbxIngresar.Name = "chbxIngresar"
        chbxIngresar.Size = New Size(151, 24)
        chbxIngresar.TabIndex = 33
        chbxIngresar.Text = "Ingresar garantia"
        chbxIngresar.UseVisualStyleBackColor = True
        ' 
        ' txtID2
        ' 
        txtID2.Enabled = False
        txtID2.Location = New Point(725, 381)
        txtID2.Multiline = True
        txtID2.Name = "txtID2"
        txtID2.Size = New Size(72, 28)
        txtID2.TabIndex = 32
        ' 
        ' txtDesc2
        ' 
        txtDesc2.Enabled = False
        txtDesc2.Location = New Point(725, 424)
        txtDesc2.Multiline = True
        txtDesc2.Name = "txtDesc2"
        txtDesc2.Size = New Size(227, 28)
        txtDesc2.TabIndex = 31
        ' 
        ' txtDetalle
        ' 
        txtDetalle.Enabled = False
        txtDetalle.Location = New Point(725, 470)
        txtDetalle.Multiline = True
        txtDetalle.Name = "txtDetalle"
        txtDetalle.Size = New Size(227, 87)
        txtDetalle.TabIndex = 30
        ' 
        ' lblFecFin
        ' 
        lblFecFin.AutoSize = True
        lblFecFin.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblFecFin.ForeColor = Color.White
        lblFecFin.Location = New Point(513, 661)
        lblFecFin.Name = "lblFecFin"
        lblFecFin.Size = New Size(195, 28)
        lblFecFin.TabIndex = 26
        lblFecFin.Text = "Fecha Finallizacíon:"
        ' 
        ' lblFecIni
        ' 
        lblFecIni.AutoSize = True
        lblFecIni.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblFecIni.ForeColor = Color.White
        lblFecIni.Location = New Point(513, 615)
        lblFecIni.Name = "lblFecIni"
        lblFecIni.Size = New Size(129, 28)
        lblFecIni.TabIndex = 25
        lblFecIni.Text = "Fecha inicio:"
        ' 
        ' lblCliente
        ' 
        lblCliente.AutoSize = True
        lblCliente.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblCliente.ForeColor = Color.White
        lblCliente.Location = New Point(513, 571)
        lblCliente.Name = "lblCliente"
        lblCliente.Size = New Size(83, 28)
        lblCliente.TabIndex = 24
        lblCliente.Text = "Cliente:"
        ' 
        ' lblDetalle
        ' 
        lblDetalle.AutoSize = True
        lblDetalle.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblDetalle.ForeColor = Color.White
        lblDetalle.Location = New Point(516, 470)
        lblDetalle.Name = "lblDetalle"
        lblDetalle.Size = New Size(85, 28)
        lblDetalle.TabIndex = 23
        lblDetalle.Text = "Detalle:"
        ' 
        ' lblDesc2
        ' 
        lblDesc2.AutoSize = True
        lblDesc2.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblDesc2.ForeColor = Color.White
        lblDesc2.Location = New Point(516, 424)
        lblDesc2.Name = "lblDesc2"
        lblDesc2.Size = New Size(128, 28)
        lblDesc2.TabIndex = 22
        lblDesc2.Text = "Descripción:"
        ' 
        ' lblID2
        ' 
        lblID2.AutoSize = True
        lblID2.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblID2.ForeColor = Color.White
        lblID2.Location = New Point(516, 381)
        lblID2.Name = "lblID2"
        lblID2.Size = New Size(38, 28)
        lblID2.TabIndex = 21
        lblID2.Text = "ID:"
        ' 
        ' btnVisualizar2
        ' 
        btnVisualizar2.BackColor = Color.DimGray
        btnVisualizar2.Font = New Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnVisualizar2.ForeColor = Color.White
        btnVisualizar2.Image = My.Resources.Resources.visualizar_2
        btnVisualizar2.ImageAlign = ContentAlignment.MiddleRight
        btnVisualizar2.Location = New Point(803, 110)
        btnVisualizar2.Name = "btnVisualizar2"
        btnVisualizar2.Padding = New Padding(0, 0, 20, 0)
        btnVisualizar2.Size = New Size(149, 36)
        btnVisualizar2.TabIndex = 20
        btnVisualizar2.Text = "Visualizar"
        btnVisualizar2.UseVisualStyleBackColor = False
        ' 
        ' btnBuscar2
        ' 
        btnBuscar2.BackColor = Color.DimGray
        btnBuscar2.Font = New Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnBuscar2.ForeColor = Color.White
        btnBuscar2.Image = My.Resources.Resources.buscar
        btnBuscar2.ImageAlign = ContentAlignment.MiddleRight
        btnBuscar2.Location = New Point(668, 110)
        btnBuscar2.Name = "btnBuscar2"
        btnBuscar2.Padding = New Padding(0, 0, 20, 0)
        btnBuscar2.Size = New Size(129, 36)
        btnBuscar2.TabIndex = 19
        btnBuscar2.Text = "Buscar"
        btnBuscar2.UseVisualStyleBackColor = False
        ' 
        ' txtDescGarantia
        ' 
        txtDescGarantia.Location = New Point(221, 114)
        txtDescGarantia.Multiline = True
        txtDescGarantia.Name = "txtDescGarantia"
        txtDescGarantia.Size = New Size(424, 24)
        txtDescGarantia.TabIndex = 18
        ' 
        ' DataGridView2
        ' 
        DataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView2.Columns.AddRange(New DataGridViewColumn() {GarantiaID, NombreRepuesto, DetalleGarantia, Cliente, FechaInicio, FechaFin})
        DataGridView2.Location = New Point(52, 164)
        DataGridView2.Name = "DataGridView2"
        DataGridView2.RowHeadersWidth = 51
        DataGridView2.Size = New Size(900, 182)
        DataGridView2.TabIndex = 17
        ' 
        ' GarantiaID
        ' 
        GarantiaID.HeaderText = "ID"
        GarantiaID.MinimumWidth = 6
        GarantiaID.Name = "GarantiaID"
        GarantiaID.Width = 80
        ' 
        ' NombreRepuesto
        ' 
        NombreRepuesto.HeaderText = "Descripción"
        NombreRepuesto.MinimumWidth = 6
        NombreRepuesto.Name = "NombreRepuesto"
        NombreRepuesto.Width = 180
        ' 
        ' DetalleGarantia
        ' 
        DetalleGarantia.HeaderText = "Detalle"
        DetalleGarantia.MinimumWidth = 6
        DetalleGarantia.Name = "DetalleGarantia"
        DetalleGarantia.Width = 210
        ' 
        ' Cliente
        ' 
        Cliente.HeaderText = "Cliente"
        Cliente.MinimumWidth = 6
        Cliente.Name = "Cliente"
        Cliente.Width = 125
        ' 
        ' FechaInicio
        ' 
        FechaInicio.HeaderText = "Fecha Inicio"
        FechaInicio.MinimumWidth = 6
        FechaInicio.Name = "FechaInicio"
        FechaInicio.Width = 125
        ' 
        ' FechaFin
        ' 
        FechaFin.HeaderText = "Fecha Finalización"
        FechaFin.MinimumWidth = 6
        FechaFin.Name = "FechaFin"
        FechaFin.Width = 125
        ' 
        ' lblIdDesc
        ' 
        lblIdDesc.AutoSize = True
        lblIdDesc.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblIdDesc.ForeColor = Color.White
        lblIdDesc.Location = New Point(52, 110)
        lblIdDesc.Name = "lblIdDesc"
        lblIdDesc.Size = New Size(158, 28)
        lblIdDesc.TabIndex = 16
        lblIdDesc.Text = "ID/Descripción:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Arial Black", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = SystemColors.ButtonHighlight
        Label2.Location = New Point(221, 24)
        Label2.Name = "Label2"
        Label2.Size = New Size(515, 56)
        Label2.TabIndex = 13
        Label2.Text = "Garantia de repuestos"
        ' 
        ' PanelVentas
        ' 
        PanelVentas.Controls.Add(Label11)
        PanelVentas.Controls.Add(txtPrecioo)
        PanelVentas.Controls.Add(btnComprar)
        PanelVentas.Controls.Add(Label10)
        PanelVentas.Controls.Add(Label9)
        PanelVentas.Controls.Add(txtMonto)
        PanelVentas.Controls.Add(Label8)
        PanelVentas.Controls.Add(Label7)
        PanelVentas.Controls.Add(Label6)
        PanelVentas.Controls.Add(Label5)
        PanelVentas.Controls.Add(Label4)
        PanelVentas.Controls.Add(txtFecha)
        PanelVentas.Controls.Add(TxtRutCliente)
        PanelVentas.Controls.Add(txtCantidadd)
        PanelVentas.Controls.Add(txtNomRepuesto)
        PanelVentas.Controls.Add(btnbuscador)
        PanelVentas.Controls.Add(btnVerTodo)
        PanelVentas.Controls.Add(txtDescrip)
        PanelVentas.Controls.Add(Label3)
        PanelVentas.Controls.Add(DataGridVentas)
        PanelVentas.Location = New Point(12, 34)
        PanelVentas.Name = "PanelVentas"
        PanelVentas.Size = New Size(1080, 816)
        PanelVentas.TabIndex = 20
        PanelVentas.Visible = False
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label11.ForeColor = Color.White
        Label11.Location = New Point(320, 428)
        Label11.Name = "Label11"
        Label11.Size = New Size(59, 23)
        Label11.TabIndex = 40
        Label11.Text = "Precio"
        ' 
        ' txtPrecioo
        ' 
        txtPrecioo.Location = New Point(521, 427)
        txtPrecioo.Name = "txtPrecioo"
        txtPrecioo.ReadOnly = True
        txtPrecioo.Size = New Size(259, 27)
        txtPrecioo.TabIndex = 39
        ' 
        ' btnComprar
        ' 
        btnComprar.Location = New Point(634, 691)
        btnComprar.Name = "btnComprar"
        btnComprar.Size = New Size(146, 29)
        btnComprar.TabIndex = 38
        btnComprar.Text = "Confirmar compra"
        btnComprar.UseVisualStyleBackColor = True
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label10.ForeColor = Color.White
        Label10.Location = New Point(304, 322)
        Label10.Name = "Label10"
        Label10.Size = New Size(475, 31)
        Label10.TabIndex = 37
        Label10.Text = "A continuacion complete los datos faltante"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label9.ForeColor = Color.White
        Label9.Location = New Point(271, 27)
        Label9.Name = "Label9"
        Label9.Size = New Size(577, 31)
        Label9.TabIndex = 36
        Label9.Text = "Por favor busca y seleccione el repuesto que necesite"
        ' 
        ' txtMonto
        ' 
        txtMonto.Location = New Point(521, 616)
        txtMonto.Name = "txtMonto"
        txtMonto.ReadOnly = True
        txtMonto.Size = New Size(259, 27)
        txtMonto.TabIndex = 35
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.ForeColor = Color.White
        Label8.Location = New Point(320, 619)
        Label8.Name = "Label8"
        Label8.Size = New Size(115, 23)
        Label8.TabIndex = 34
        Label8.Text = "Total a pagar"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.ForeColor = Color.White
        Label7.Location = New Point(320, 563)
        Label7.Name = "Label7"
        Label7.Size = New Size(55, 23)
        Label7.TabIndex = 33
        Label7.Text = "Fecha"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = Color.White
        Label6.Location = New Point(320, 517)
        Label6.Name = "Label6"
        Label6.Size = New Size(96, 23)
        Label6.TabIndex = 32
        Label6.Text = "Rut cliente"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.White
        Label5.Location = New Point(320, 471)
        Label5.Name = "Label5"
        Label5.Size = New Size(83, 23)
        Label5.TabIndex = 31
        Label5.Text = "Cantidad"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.White
        Label4.Location = New Point(320, 383)
        Label4.Name = "Label4"
        Label4.Size = New Size(181, 23)
        Label4.TabIndex = 30
        Label4.Text = "Nombre del repuesto"
        ' 
        ' txtFecha
        ' 
        txtFecha.Location = New Point(521, 563)
        txtFecha.Name = "txtFecha"
        txtFecha.ReadOnly = True
        txtFecha.Size = New Size(259, 27)
        txtFecha.TabIndex = 29
        ' 
        ' TxtRutCliente
        ' 
        TxtRutCliente.Location = New Point(521, 517)
        TxtRutCliente.Name = "TxtRutCliente"
        TxtRutCliente.Size = New Size(259, 27)
        TxtRutCliente.TabIndex = 28
        ' 
        ' txtCantidadd
        ' 
        txtCantidadd.Location = New Point(521, 470)
        txtCantidadd.Name = "txtCantidadd"
        txtCantidadd.Size = New Size(259, 27)
        txtCantidadd.TabIndex = 27
        ' 
        ' txtNomRepuesto
        ' 
        txtNomRepuesto.Location = New Point(521, 384)
        txtNomRepuesto.Name = "txtNomRepuesto"
        txtNomRepuesto.ReadOnly = True
        txtNomRepuesto.Size = New Size(259, 27)
        txtNomRepuesto.TabIndex = 26
        ' 
        ' btnbuscador
        ' 
        btnbuscador.BackColor = Color.DimGray
        btnbuscador.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnbuscador.ForeColor = Color.White
        btnbuscador.Image = My.Resources.Resources.buscar
        btnbuscador.ImageAlign = ContentAlignment.MiddleRight
        btnbuscador.Location = New Point(523, 93)
        btnbuscador.Name = "btnbuscador"
        btnbuscador.Padding = New Padding(0, 0, 20, 0)
        btnbuscador.Size = New Size(138, 38)
        btnbuscador.TabIndex = 24
        btnbuscador.Text = "Buscar"
        btnbuscador.UseVisualStyleBackColor = False
        ' 
        ' btnVerTodo
        ' 
        btnVerTodo.BackColor = Color.DimGray
        btnVerTodo.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnVerTodo.ForeColor = Color.White
        btnVerTodo.Image = My.Resources.Resources.visualizar_2
        btnVerTodo.ImageAlign = ContentAlignment.MiddleRight
        btnVerTodo.Location = New Point(864, 93)
        btnVerTodo.Name = "btnVerTodo"
        btnVerTodo.Padding = New Padding(0, 0, 20, 0)
        btnVerTodo.Size = New Size(172, 38)
        btnVerTodo.TabIndex = 23
        btnVerTodo.Text = "Ver todo"
        btnVerTodo.UseVisualStyleBackColor = False
        ' 
        ' txtDescrip
        ' 
        txtDescrip.Location = New Point(210, 97)
        txtDescrip.Multiline = True
        txtDescrip.Name = "txtDescrip"
        txtDescrip.Size = New Size(297, 28)
        txtDescrip.TabIndex = 22
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.White
        Label3.Location = New Point(46, 97)
        Label3.Name = "Label3"
        Label3.Size = New Size(158, 28)
        Label3.TabIndex = 21
        Label3.Text = "ID/Descripcion:"
        ' 
        ' DataGridVentas
        ' 
        DataGridVentas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridVentas.Columns.AddRange(New DataGridViewColumn() {DataGridViewTextBoxColumn1, Descripcion, cantidadd, precioo, Proveedo})
        DataGridVentas.Location = New Point(41, 137)
        DataGridVentas.Name = "DataGridVentas"
        DataGridVentas.RowHeadersWidth = 51
        DataGridVentas.Size = New Size(995, 182)
        DataGridVentas.TabIndex = 18
        ' 
        ' DataGridViewTextBoxColumn1
        ' 
        DataGridViewTextBoxColumn1.HeaderText = "ID"
        DataGridViewTextBoxColumn1.MinimumWidth = 6
        DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        DataGridViewTextBoxColumn1.Width = 80
        ' 
        ' Descripcion
        ' 
        Descripcion.HeaderText = "Descripción"
        Descripcion.MinimumWidth = 6
        Descripcion.Name = "Descripcion"
        Descripcion.Width = 345
        ' 
        ' cantidadd
        ' 
        cantidadd.HeaderText = "Cantidad"
        cantidadd.MinimumWidth = 6
        cantidadd.Name = "cantidadd"
        cantidadd.Width = 210
        ' 
        ' precioo
        ' 
        precioo.HeaderText = "Precio"
        precioo.MinimumWidth = 6
        precioo.Name = "precioo"
        precioo.Width = 125
        ' 
        ' Proveedo
        ' 
        Proveedo.HeaderText = "Proveedor"
        Proveedo.MinimumWidth = 6
        Proveedo.Name = "Proveedo"
        Proveedo.Width = 180
        ' 
        ' panelHistorialVentas
        ' 
        panelHistorialVentas.Controls.Add(Label13)
        panelHistorialVentas.Controls.Add(btnBuscarVentas)
        panelHistorialVentas.Controls.Add(btnVerTodos)
        panelHistorialVentas.Controls.Add(txtNomRep)
        panelHistorialVentas.Controls.Add(Label12)
        panelHistorialVentas.Controls.Add(DataGridHistorialVentas)
        panelHistorialVentas.Location = New Point(12, 31)
        panelHistorialVentas.Name = "panelHistorialVentas"
        panelHistorialVentas.Size = New Size(1074, 803)
        panelHistorialVentas.TabIndex = 41
        panelHistorialVentas.Visible = False
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label13.ForeColor = Color.White
        Label13.Location = New Point(374, 46)
        Label13.Name = "Label13"
        Label13.Size = New Size(281, 41)
        Label13.TabIndex = 29
        Label13.Text = "Historial de ventas"
        ' 
        ' btnBuscarVentas
        ' 
        btnBuscarVentas.BackColor = Color.DimGray
        btnBuscarVentas.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnBuscarVentas.ForeColor = Color.White
        btnBuscarVentas.Image = My.Resources.Resources.buscar
        btnBuscarVentas.ImageAlign = ContentAlignment.MiddleRight
        btnBuscarVentas.Location = New Point(524, 147)
        btnBuscarVentas.Name = "btnBuscarVentas"
        btnBuscarVentas.Padding = New Padding(0, 0, 20, 0)
        btnBuscarVentas.Size = New Size(138, 38)
        btnBuscarVentas.TabIndex = 28
        btnBuscarVentas.Text = "Buscar"
        btnBuscarVentas.UseVisualStyleBackColor = False
        ' 
        ' btnVerTodos
        ' 
        btnVerTodos.BackColor = Color.DimGray
        btnVerTodos.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnVerTodos.ForeColor = Color.White
        btnVerTodos.Image = My.Resources.Resources.visualizar_2
        btnVerTodos.ImageAlign = ContentAlignment.MiddleRight
        btnVerTodos.Location = New Point(853, 146)
        btnVerTodos.Name = "btnVerTodos"
        btnVerTodos.Padding = New Padding(0, 0, 20, 0)
        btnVerTodos.Size = New Size(172, 38)
        btnVerTodos.TabIndex = 27
        btnVerTodos.Text = "Ver todo"
        btnVerTodos.UseVisualStyleBackColor = False
        ' 
        ' txtNomRep
        ' 
        txtNomRep.Location = New Point(211, 151)
        txtNomRep.Multiline = True
        txtNomRep.Name = "txtNomRep"
        txtNomRep.Size = New Size(297, 28)
        txtNomRep.TabIndex = 26
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label12.ForeColor = Color.White
        Label12.Location = New Point(47, 151)
        Label12.Name = "Label12"
        Label12.Size = New Size(158, 28)
        Label12.TabIndex = 25
        Label12.Text = "ID/Descripcion:"
        ' 
        ' DataGridHistorialVentas
        ' 
        DataGridHistorialVentas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridHistorialVentas.Columns.AddRange(New DataGridViewColumn() {DataGridViewTextBoxColumn2, DataGridViewTextBoxColumn3, DataGridViewTextBoxColumn4, DataGridViewTextBoxColumn5, DataGridViewTextBoxColumn6, Total})
        DataGridHistorialVentas.Location = New Point(49, 222)
        DataGridHistorialVentas.Name = "DataGridHistorialVentas"
        DataGridHistorialVentas.RowHeadersWidth = 51
        DataGridHistorialVentas.Size = New Size(976, 169)
        DataGridHistorialVentas.TabIndex = 19
        ' 
        ' DataGridViewTextBoxColumn2
        ' 
        DataGridViewTextBoxColumn2.HeaderText = "ID"
        DataGridViewTextBoxColumn2.MinimumWidth = 6
        DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        DataGridViewTextBoxColumn2.Width = 30
        ' 
        ' DataGridViewTextBoxColumn3
        ' 
        DataGridViewTextBoxColumn3.HeaderText = "Nombre Repuesto"
        DataGridViewTextBoxColumn3.MinimumWidth = 6
        DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        DataGridViewTextBoxColumn3.Width = 380
        ' 
        ' DataGridViewTextBoxColumn4
        ' 
        DataGridViewTextBoxColumn4.HeaderText = "Cantidad vendida"
        DataGridViewTextBoxColumn4.MinimumWidth = 6
        DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        DataGridViewTextBoxColumn4.Width = 125
        ' 
        ' DataGridViewTextBoxColumn5
        ' 
        DataGridViewTextBoxColumn5.HeaderText = "Cliente"
        DataGridViewTextBoxColumn5.MinimumWidth = 6
        DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        DataGridViewTextBoxColumn5.Width = 150
        ' 
        ' DataGridViewTextBoxColumn6
        ' 
        DataGridViewTextBoxColumn6.HeaderText = "Fecha de venta"
        DataGridViewTextBoxColumn6.MinimumWidth = 6
        DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        DataGridViewTextBoxColumn6.Width = 125
        ' 
        ' Total
        ' 
        Total.HeaderText = "Monto total vendido"
        Total.MinimumWidth = 6
        Total.Name = "Total"
        Total.Width = 150
        ' 
        ' btnVolver
        ' 
        btnVolver.BackColor = Color.DimGray
        btnVolver.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnVolver.ForeColor = Color.White
        btnVolver.Image = My.Resources.Resources.volver
        btnVolver.ImageAlign = ContentAlignment.MiddleRight
        btnVolver.Location = New Point(477, 865)
        btnVolver.Name = "btnVolver"
        btnVolver.Padding = New Padding(0, 0, 15, 0)
        btnVolver.Size = New Size(159, 48)
        btnVolver.TabIndex = 18
        btnVolver.Text = "Volver"
        btnVolver.UseVisualStyleBackColor = False
        ' 
        ' Form4
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(35), CByte(35), CByte(35))
        ClientSize = New Size(1092, 925)
        Controls.Add(panelHistorialVentas)
        Controls.Add(PanelVentas)
        Controls.Add(PanelGarantia)
        Controls.Add(btnVolver)
        Controls.Add(PanelInventario)
        Controls.Add(PictureBox1)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        Name = "Form4"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Gestion de repuestos"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        PanelInventario.ResumeLayout(False)
        PanelInventario.PerformLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        PanelGarantia.ResumeLayout(False)
        PanelGarantia.PerformLayout()
        CType(DataGridView2, ComponentModel.ISupportInitialize).EndInit()
        PanelVentas.ResumeLayout(False)
        PanelVentas.PerformLayout()
        CType(DataGridVentas, ComponentModel.ISupportInitialize).EndInit()
        panelHistorialVentas.ResumeLayout(False)
        panelHistorialVentas.PerformLayout()
        CType(DataGridHistorialVentas, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents GestiónDeRepuestosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InventarioDeRepuestosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GarantiaDeRepuestosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SolicitudDeRepuestosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VentasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VentaDeRepuestosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PanelInventario As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents lblDescripcion As Label
    Friend WithEvents txtDescripcion As TextBox
    Friend WithEvents btnVisualizar As Button
    Friend WithEvents btnBuscar As Button
    Friend WithEvents CheckEliminar As CheckBox
    Friend WithEvents CheckModificar As CheckBox
    Friend WithEvents CheckIngresar As CheckBox
    Friend WithEvents lblPrecio As Label
    Friend WithEvents lblCantidad As Label
    Friend WithEvents lblRepuesto As Label
    Friend WithEvents lblID As Label
    Friend WithEvents lblProvedor As Label
    Friend WithEvents btnVolver As Button
    Friend WithEvents txtProvedor As TextBox
    Friend WithEvents txtPrecio As TextBox
    Friend WithEvents txtCantidad As TextBox
    Friend WithEvents txtID As TextBox
    Friend WithEvents txtRepuesto As TextBox
    Friend WithEvents btnGuardar As Button
    Friend WithEvents btnModificar As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents ID As DataGridViewTextBoxColumn
    Friend WithEvents Repuesto As DataGridViewTextBoxColumn
    Friend WithEvents Cantidad As DataGridViewTextBoxColumn
    Friend WithEvents Precio As DataGridViewTextBoxColumn
    Friend WithEvents Proveedor As DataGridViewTextBoxColumn
    Friend WithEvents PanelGarantia As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents txtDescGarantia As TextBox
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents lblIdDesc As Label
    Friend WithEvents btnBuscar2 As Button
    Friend WithEvents btnVisualizar2 As Button
    Friend WithEvents GarantiaID As DataGridViewTextBoxColumn
    Friend WithEvents NombreRepuesto As DataGridViewTextBoxColumn
    Friend WithEvents DetalleGarantia As DataGridViewTextBoxColumn
    Friend WithEvents Cliente As DataGridViewTextBoxColumn
    Friend WithEvents FechaInicio As DataGridViewTextBoxColumn
    Friend WithEvents FechaFin As DataGridViewTextBoxColumn
    Friend WithEvents lblCliente As Label
    Friend WithEvents lblDetalle As Label
    Friend WithEvents lblDesc2 As Label
    Friend WithEvents lblID2 As Label
    Friend WithEvents lblFecFin As Label
    Friend WithEvents lblFecIni As Label
    Friend WithEvents txtID2 As TextBox
    Friend WithEvents txtDesc2 As TextBox
    Friend WithEvents txtDetalle As TextBox
    Friend WithEvents chbxModificar As CheckBox
    Friend WithEvents chbxIngresar As CheckBox
    Friend WithEvents chbxEliminar As CheckBox
    Friend WithEvents btnGuardar2 As Button
    Friend WithEvents btnEliminar2 As Button
    Friend WithEvents btnModificar2 As Button
    Friend WithEvents FecFin As DateTimePicker
    Friend WithEvents FecIni As DateTimePicker
    Friend WithEvents cbxCliente As ComboBox
    Friend WithEvents PanelVentas As Panel
    Friend WithEvents DataGridVentas As DataGridView
    Friend WithEvents btnbuscador As Button
    Friend WithEvents btnVerTodo As Button
    Friend WithEvents txtDescrip As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtFecha As TextBox
    Friend WithEvents TxtRutCliente As TextBox
    Friend WithEvents txtCantidadd As TextBox
    Friend WithEvents txtNomRepuesto As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtMonto As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents HistorialDeVentasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btnComprar As Button
    Friend WithEvents Label11 As Label
    Friend WithEvents txtPrecioo As TextBox
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents Descripcion As DataGridViewTextBoxColumn
    Friend WithEvents cantidadd As DataGridViewTextBoxColumn
    Friend WithEvents precioo As DataGridViewTextBoxColumn
    Friend WithEvents Proveedo As DataGridViewTextBoxColumn
    Friend WithEvents panelHistorialVentas As Panel
    Friend WithEvents DataGridHistorialVentas As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents Total As DataGridViewTextBoxColumn
    Friend WithEvents btnBuscarVentas As Button
    Friend WithEvents btnVerTodos As Button
    Friend WithEvents txtNomRep As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
End Class
