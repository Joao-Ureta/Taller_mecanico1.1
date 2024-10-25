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
        components = New ComponentModel.Container()
        Label1 = New Label()
        Panel1 = New Panel()
        PanelInventario = New Panel()
        txtProvedor = New TextBox()
        txtId = New TextBox()
        txtDescripcion2 = New TextBox()
        txtCantidad = New TextBox()
        txtPrecio = New TextBox()
        Label9 = New Label()
        Label8 = New Label()
        Label6 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        btnGuardar = New Button()
        btnEliminar = New Button()
        btnModificar = New Button()
        CheckEliminar = New CheckBox()
        CheckModificar = New CheckBox()
        CheckIngresar = New CheckBox()
        btnVisualizar = New Button()
        btnBuscar = New Button()
        txtDescripcion = New TextBox()
        Label3 = New Label()
        DataGridView1 = New DataGridView()
        RUT = New DataGridViewTextBoxColumn()
        CORREO = New DataGridViewTextBoxColumn()
        Contraseña = New DataGridViewTextBoxColumn()
        Tipo = New DataGridViewTextBoxColumn()
        Label2 = New Label()
        PictureBox1 = New PictureBox()
        MenuStrip1 = New MenuStrip()
        InventarioRepuestosToolStripMenuItem = New ToolStripMenuItem()
        InventarioDeRepuestosToolStripMenuItem = New ToolStripMenuItem()
        SolicitudDeRepuestosToolStripMenuItem1 = New ToolStripMenuItem()
        GarantiaDeRepuestosToolStripMenuItem1 = New ToolStripMenuItem()
        VentasDeRepuestosToolStripMenuItem = New ToolStripMenuItem()
        VentasDeRepuestosToolStripMenuItem1 = New ToolStripMenuItem()
        ErrorProvider1 = New ErrorProvider(components)
        btnVolver = New Button()
        Panel1.SuspendLayout()
        PanelInventario.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        MenuStrip1.SuspendLayout()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Arial Black", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.ButtonHighlight
        Label1.Location = New Point(452, 24)
        Label1.Name = "Label1"
        Label1.Size = New Size(493, 56)
        Label1.TabIndex = 12
        Label1.Text = "Gestión de repuestos"
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(PanelInventario)
        Panel1.Controls.Add(PictureBox1)
        Panel1.Controls.Add(MenuStrip1)
        Panel1.Location = New Point(12, 133)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1409, 687)
        Panel1.TabIndex = 13
        ' 
        ' PanelInventario
        ' 
        PanelInventario.Controls.Add(txtProvedor)
        PanelInventario.Controls.Add(txtId)
        PanelInventario.Controls.Add(txtDescripcion2)
        PanelInventario.Controls.Add(txtCantidad)
        PanelInventario.Controls.Add(txtPrecio)
        PanelInventario.Controls.Add(Label9)
        PanelInventario.Controls.Add(Label8)
        PanelInventario.Controls.Add(Label6)
        PanelInventario.Controls.Add(Label5)
        PanelInventario.Controls.Add(Label4)
        PanelInventario.Controls.Add(btnGuardar)
        PanelInventario.Controls.Add(btnEliminar)
        PanelInventario.Controls.Add(btnModificar)
        PanelInventario.Controls.Add(CheckEliminar)
        PanelInventario.Controls.Add(CheckModificar)
        PanelInventario.Controls.Add(CheckIngresar)
        PanelInventario.Controls.Add(btnVisualizar)
        PanelInventario.Controls.Add(btnBuscar)
        PanelInventario.Controls.Add(txtDescripcion)
        PanelInventario.Controls.Add(Label3)
        PanelInventario.Controls.Add(DataGridView1)
        PanelInventario.Controls.Add(Label2)
        PanelInventario.Location = New Point(22, 59)
        PanelInventario.Name = "PanelInventario"
        PanelInventario.Size = New Size(1364, 612)
        PanelInventario.TabIndex = 2
        ' 
        ' txtProvedor
        ' 
        txtProvedor.Enabled = False
        txtProvedor.Location = New Point(1052, 450)
        txtProvedor.Multiline = True
        txtProvedor.Name = "txtProvedor"
        txtProvedor.Size = New Size(260, 28)
        txtProvedor.TabIndex = 41
        ' 
        ' txtId
        ' 
        txtId.Enabled = False
        txtId.Location = New Point(1052, 227)
        txtId.Multiline = True
        txtId.Name = "txtId"
        txtId.Size = New Size(130, 28)
        txtId.TabIndex = 40
        ' 
        ' txtDescripcion2
        ' 
        txtDescripcion2.Enabled = False
        txtDescripcion2.Location = New Point(1052, 277)
        txtDescripcion2.Multiline = True
        txtDescripcion2.Name = "txtDescripcion2"
        txtDescripcion2.Size = New Size(260, 28)
        txtDescripcion2.TabIndex = 39
        ' 
        ' txtCantidad
        ' 
        txtCantidad.Enabled = False
        txtCantidad.Location = New Point(1052, 334)
        txtCantidad.Multiline = True
        txtCantidad.Name = "txtCantidad"
        txtCantidad.Size = New Size(130, 28)
        txtCantidad.TabIndex = 38
        ' 
        ' txtPrecio
        ' 
        txtPrecio.Enabled = False
        txtPrecio.Location = New Point(1052, 393)
        txtPrecio.Multiline = True
        txtPrecio.Name = "txtPrecio"
        txtPrecio.Size = New Size(130, 28)
        txtPrecio.TabIndex = 37
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label9.ForeColor = Color.White
        Label9.Location = New Point(889, 450)
        Label9.Name = "Label9"
        Label9.Size = New Size(104, 28)
        Label9.TabIndex = 36
        Label9.Text = "Provedor:"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.ForeColor = Color.White
        Label8.Location = New Point(889, 393)
        Label8.Name = "Label8"
        Label8.Size = New Size(157, 28)
        Label8.TabIndex = 35
        Label8.Text = "Precio unitario:"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = Color.White
        Label6.Location = New Point(889, 334)
        Label6.Name = "Label6"
        Label6.Size = New Size(101, 28)
        Label6.TabIndex = 33
        Label6.Text = "Cantidad:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.White
        Label5.Location = New Point(889, 277)
        Label5.Name = "Label5"
        Label5.Size = New Size(128, 28)
        Label5.TabIndex = 32
        Label5.Text = "Descripcion:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.White
        Label4.Location = New Point(889, 227)
        Label4.Name = "Label4"
        Label4.Size = New Size(38, 28)
        Label4.TabIndex = 31
        Label4.Text = "ID:"
        ' 
        ' btnGuardar
        ' 
        btnGuardar.BackColor = Color.DimGray
        btnGuardar.Enabled = False
        btnGuardar.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnGuardar.ForeColor = Color.White
        btnGuardar.Image = My.Resources.Resources.guardar
        btnGuardar.ImageAlign = ContentAlignment.MiddleRight
        btnGuardar.Location = New Point(41, 505)
        btnGuardar.Name = "btnGuardar"
        btnGuardar.Padding = New Padding(0, 0, 30, 0)
        btnGuardar.Size = New Size(227, 61)
        btnGuardar.TabIndex = 30
        btnGuardar.Text = "Guardar"
        btnGuardar.UseVisualStyleBackColor = False
        ' 
        ' btnEliminar
        ' 
        btnEliminar.BackColor = Color.DimGray
        btnEliminar.Enabled = False
        btnEliminar.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnEliminar.ForeColor = Color.White
        btnEliminar.Image = My.Resources.Resources.eliminar
        btnEliminar.ImageAlign = ContentAlignment.MiddleRight
        btnEliminar.Location = New Point(584, 505)
        btnEliminar.Name = "btnEliminar"
        btnEliminar.Padding = New Padding(0, 0, 30, 0)
        btnEliminar.Size = New Size(227, 61)
        btnEliminar.TabIndex = 29
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
        btnModificar.Location = New Point(315, 505)
        btnModificar.Name = "btnModificar"
        btnModificar.Padding = New Padding(0, 0, 30, 0)
        btnModificar.Size = New Size(227, 61)
        btnModificar.TabIndex = 28
        btnModificar.Text = "Modificar"
        btnModificar.UseVisualStyleBackColor = False
        ' 
        ' CheckEliminar
        ' 
        CheckEliminar.AutoSize = True
        CheckEliminar.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        CheckEliminar.ForeColor = Color.White
        CheckEliminar.Location = New Point(1202, 121)
        CheckEliminar.Name = "CheckEliminar"
        CheckEliminar.Size = New Size(144, 24)
        CheckEliminar.TabIndex = 27
        CheckEliminar.Text = "Eliminar usuario"
        CheckEliminar.UseVisualStyleBackColor = True
        ' 
        ' CheckModificar
        ' 
        CheckModificar.AutoSize = True
        CheckModificar.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        CheckModificar.ForeColor = Color.White
        CheckModificar.Location = New Point(1022, 121)
        CheckModificar.Name = "CheckModificar"
        CheckModificar.Size = New Size(154, 24)
        CheckModificar.TabIndex = 26
        CheckModificar.Text = "Modificar usuario"
        CheckModificar.UseVisualStyleBackColor = True
        ' 
        ' CheckIngresar
        ' 
        CheckIngresar.AutoSize = True
        CheckIngresar.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        CheckIngresar.ForeColor = Color.White
        CheckIngresar.Location = New Point(850, 121)
        CheckIngresar.Name = "CheckIngresar"
        CheckIngresar.Size = New Size(145, 24)
        CheckIngresar.TabIndex = 25
        CheckIngresar.Text = "Ingresar usuario"
        CheckIngresar.UseVisualStyleBackColor = True
        ' 
        ' btnVisualizar
        ' 
        btnVisualizar.BackColor = Color.DimGray
        btnVisualizar.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnVisualizar.ForeColor = Color.White
        btnVisualizar.Image = My.Resources.Resources.visualizar_2
        btnVisualizar.ImageAlign = ContentAlignment.MiddleRight
        btnVisualizar.Location = New Point(668, 93)
        btnVisualizar.Name = "btnVisualizar"
        btnVisualizar.Padding = New Padding(0, 0, 20, 0)
        btnVisualizar.Size = New Size(159, 38)
        btnVisualizar.TabIndex = 19
        btnVisualizar.Text = "Visualizar"
        btnVisualizar.UseVisualStyleBackColor = False
        ' 
        ' btnBuscar
        ' 
        btnBuscar.BackColor = Color.DimGray
        btnBuscar.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnBuscar.ForeColor = Color.White
        btnBuscar.Image = My.Resources.Resources.buscar
        btnBuscar.ImageAlign = ContentAlignment.MiddleRight
        btnBuscar.Location = New Point(524, 93)
        btnBuscar.Name = "btnBuscar"
        btnBuscar.Padding = New Padding(0, 0, 20, 0)
        btnBuscar.Size = New Size(138, 38)
        btnBuscar.TabIndex = 18
        btnBuscar.Text = "Buscar"
        btnBuscar.UseVisualStyleBackColor = False
        ' 
        ' txtDescripcion
        ' 
        txtDescripcion.Location = New Point(184, 97)
        txtDescripcion.Multiline = True
        txtDescripcion.Name = "txtDescripcion"
        txtDescripcion.Size = New Size(324, 28)
        txtDescripcion.TabIndex = 17
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.White
        Label3.Location = New Point(23, 97)
        Label3.Name = "Label3"
        Label3.Size = New Size(155, 28)
        Label3.TabIndex = 16
        Label3.Text = "Id/Descripcion:"
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {RUT, CORREO, Contraseña, Tipo})
        DataGridView1.Location = New Point(23, 149)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.Size = New Size(804, 329)
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
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.White
        Label2.Location = New Point(429, 22)
        Label2.Name = "Label2"
        Label2.Size = New Size(398, 46)
        Label2.TabIndex = 0
        Label2.Text = "Inventario de repuestos"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.logo2
        PictureBox1.Location = New Point(382, 147)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(646, 426)
        PictureBox1.TabIndex = 1
        PictureBox1.TabStop = False
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.BackColor = Color.DimGray
        MenuStrip1.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        MenuStrip1.ImageScalingSize = New Size(20, 20)
        MenuStrip1.Items.AddRange(New ToolStripItem() {InventarioRepuestosToolStripMenuItem, VentasDeRepuestosToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(1409, 28)
        MenuStrip1.TabIndex = 0
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' InventarioRepuestosToolStripMenuItem
        ' 
        InventarioRepuestosToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {InventarioDeRepuestosToolStripMenuItem, SolicitudDeRepuestosToolStripMenuItem1, GarantiaDeRepuestosToolStripMenuItem1})
        InventarioRepuestosToolStripMenuItem.Font = New Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        InventarioRepuestosToolStripMenuItem.ForeColor = Color.White
        InventarioRepuestosToolStripMenuItem.Name = "InventarioRepuestosToolStripMenuItem"
        InventarioRepuestosToolStripMenuItem.Size = New Size(177, 24)
        InventarioRepuestosToolStripMenuItem.Text = "Gestion de repuestos"
        ' 
        ' InventarioDeRepuestosToolStripMenuItem
        ' 
        InventarioDeRepuestosToolStripMenuItem.BackColor = Color.DimGray
        InventarioDeRepuestosToolStripMenuItem.ForeColor = Color.White
        InventarioDeRepuestosToolStripMenuItem.Name = "InventarioDeRepuestosToolStripMenuItem"
        InventarioDeRepuestosToolStripMenuItem.Size = New Size(266, 26)
        InventarioDeRepuestosToolStripMenuItem.Text = "Inventario de repuestos"
        ' 
        ' SolicitudDeRepuestosToolStripMenuItem1
        ' 
        SolicitudDeRepuestosToolStripMenuItem1.BackColor = Color.DimGray
        SolicitudDeRepuestosToolStripMenuItem1.ForeColor = Color.White
        SolicitudDeRepuestosToolStripMenuItem1.Name = "SolicitudDeRepuestosToolStripMenuItem1"
        SolicitudDeRepuestosToolStripMenuItem1.Size = New Size(266, 26)
        SolicitudDeRepuestosToolStripMenuItem1.Text = "Solicitud de repuestos"
        ' 
        ' GarantiaDeRepuestosToolStripMenuItem1
        ' 
        GarantiaDeRepuestosToolStripMenuItem1.BackColor = Color.DimGray
        GarantiaDeRepuestosToolStripMenuItem1.ForeColor = Color.White
        GarantiaDeRepuestosToolStripMenuItem1.Name = "GarantiaDeRepuestosToolStripMenuItem1"
        GarantiaDeRepuestosToolStripMenuItem1.Size = New Size(266, 26)
        GarantiaDeRepuestosToolStripMenuItem1.Text = "Garantia de repuestos"
        ' 
        ' VentasDeRepuestosToolStripMenuItem
        ' 
        VentasDeRepuestosToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {VentasDeRepuestosToolStripMenuItem1})
        VentasDeRepuestosToolStripMenuItem.Font = New Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        VentasDeRepuestosToolStripMenuItem.ForeColor = Color.White
        VentasDeRepuestosToolStripMenuItem.Name = "VentasDeRepuestosToolStripMenuItem"
        VentasDeRepuestosToolStripMenuItem.Size = New Size(72, 24)
        VentasDeRepuestosToolStripMenuItem.Text = "Ventas"
        ' 
        ' VentasDeRepuestosToolStripMenuItem1
        ' 
        VentasDeRepuestosToolStripMenuItem1.BackColor = Color.DimGray
        VentasDeRepuestosToolStripMenuItem1.ForeColor = Color.White
        VentasDeRepuestosToolStripMenuItem1.Name = "VentasDeRepuestosToolStripMenuItem1"
        VentasDeRepuestosToolStripMenuItem1.Size = New Size(239, 26)
        VentasDeRepuestosToolStripMenuItem1.Text = "Ventas de repuestos"
        ' 
        ' ErrorProvider1
        ' 
        ErrorProvider1.ContainerControl = Me
        ' 
        ' btnVolver
        ' 
        btnVolver.BackColor = Color.DimGray
        btnVolver.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnVolver.ForeColor = Color.White
        btnVolver.Image = My.Resources.Resources.volver
        btnVolver.ImageAlign = ContentAlignment.MiddleRight
        btnVolver.Location = New Point(1262, 846)
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
        ClientSize = New Size(1433, 906)
        Controls.Add(btnVolver)
        Controls.Add(Panel1)
        Controls.Add(Label1)
        MainMenuStrip = MenuStrip1
        Name = "Form4"
        Text = "Form4"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        PanelInventario.ResumeLayout(False)
        PanelInventario.PerformLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents InventarioRepuestosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VentasDeRepuestosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents SolicitudDeRepuestosToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents GarantiaDeRepuestosToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents VentasDeRepuestosToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents InventarioDeRepuestosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnVolver As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents PanelInventario As Panel
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents RUT As DataGridViewTextBoxColumn
    Friend WithEvents CORREO As DataGridViewTextBoxColumn
    Friend WithEvents Contraseña As DataGridViewTextBoxColumn
    Friend WithEvents Tipo As DataGridViewTextBoxColumn
    Friend WithEvents Label3 As Label
    Friend WithEvents txtDescripcion As TextBox
    Friend WithEvents btnBuscar As Button
    Friend WithEvents btnVisualizar As Button
    Friend WithEvents CheckEliminar As CheckBox
    Friend WithEvents CheckModificar As CheckBox
    Friend WithEvents CheckIngresar As CheckBox
    Friend WithEvents btnModificar As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnGuardar As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtProvedor As TextBox
    Friend WithEvents txtId As TextBox
    Friend WithEvents txtDescripcion2 As TextBox
    Friend WithEvents txtCantidad As TextBox
    Friend WithEvents txtPrecio As TextBox
    Friend WithEvents Label9 As Label
End Class
