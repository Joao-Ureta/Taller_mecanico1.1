<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        RUT = New DataGridViewTextBoxColumn()
        CORREO = New DataGridViewTextBoxColumn()
        Contraseña = New DataGridViewTextBoxColumn()
        Tipo = New DataGridViewTextBoxColumn()
        Label1 = New Label()
        btnVolver = New Button()
        MenuStrip1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        PanelInventario.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
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
        VentasToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {VentaDeRepuestosToolStripMenuItem})
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
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {RUT, CORREO, Contraseña, Tipo})
        DataGridView1.Location = New Point(90, 154)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.Size = New Size(804, 207)
        DataGridView1.TabIndex = 13
        ' 
        ' RUT
        ' 
        RUT.HeaderText = "Rut"
        RUT.MinimumWidth = 6
        RUT.Name = "RUT"
        RUT.Width = 150
        ' 
        ' CORREO
        ' 
        CORREO.HeaderText = "CORREO"
        CORREO.MinimumWidth = 6
        CORREO.Name = "CORREO"
        CORREO.Width = 250
        ' 
        ' Contraseña
        ' 
        Contraseña.HeaderText = "Contraseña"
        Contraseña.MinimumWidth = 6
        Contraseña.Name = "Contraseña"
        Contraseña.Width = 150
        ' 
        ' Tipo
        ' 
        Tipo.HeaderText = "Tipo"
        Tipo.MinimumWidth = 6
        Tipo.Name = "Tipo"
        Tipo.Width = 200
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
        Controls.Add(btnVolver)
        Controls.Add(PanelInventario)
        Controls.Add(PictureBox1)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        Name = "Form4"
        Text = "Form4"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        PanelInventario.ResumeLayout(False)
        PanelInventario.PerformLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents RUT As DataGridViewTextBoxColumn
    Friend WithEvents CORREO As DataGridViewTextBoxColumn
    Friend WithEvents Contraseña As DataGridViewTextBoxColumn
    Friend WithEvents Tipo As DataGridViewTextBoxColumn
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
End Class
