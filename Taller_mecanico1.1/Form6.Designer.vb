<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form6
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
        lblTitulo = New Label()
        Panel1 = New Panel()
        lblCliente = New Label()
        Label1 = New Label()
        txtCliente = New TextBox()
        btnBuscar = New Button()
        btnVerTodo = New Button()
        Label2 = New Label()
        DataGridView1 = New DataGridView()
        Rut = New DataGridViewTextBoxColumn()
        Nombre = New DataGridViewTextBoxColumn()
        ApellidoP = New DataGridViewTextBoxColumn()
        ApellidoM = New DataGridViewTextBoxColumn()
        Direccion = New DataGridViewTextBoxColumn()
        Telefono = New DataGridViewTextBoxColumn()
        Comuna = New DataGridViewTextBoxColumn()
        pnlGestionClientes = New Panel()
        Label3 = New Label()
        chbxIngresar = New CheckBox()
        chbxModificar = New CheckBox()
        chbxEliminar = New CheckBox()
        lblRut = New Label()
        lblNombre = New Label()
        lblApellidoP = New Label()
        lblApellidoM = New Label()
        lblDireccion = New Label()
        lblTelefono = New Label()
        lblComuna = New Label()
        txtApellidoP = New TextBox()
        txtApellidoM = New TextBox()
        txtDireccion = New TextBox()
        txtTelefono = New TextBox()
        txtComuna = New TextBox()
        txtNombre = New TextBox()
        txtRut = New TextBox()
        btnGuardar = New Button()
        btnModificar = New Button()
        btnEliminar = New Button()
        PictureBox1 = New PictureBox()
        btnVolver = New Button()
        Panel1.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        pnlGestionClientes.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblTitulo
        ' 
        lblTitulo.AutoSize = True
        lblTitulo.Font = New Font("Arial Black", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTitulo.ForeColor = SystemColors.ButtonHighlight
        lblTitulo.Location = New Point(417, 20)
        lblTitulo.Name = "lblTitulo"
        lblTitulo.Size = New Size(448, 56)
        lblTitulo.TabIndex = 12
        lblTitulo.Text = "Gestión de clientes"
        ' 
        ' Panel1
        ' 
        Panel1.BorderStyle = BorderStyle.Fixed3D
        Panel1.Controls.Add(DataGridView1)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(btnVerTodo)
        Panel1.Controls.Add(btnBuscar)
        Panel1.Controls.Add(txtCliente)
        Panel1.Controls.Add(lblCliente)
        Panel1.Location = New Point(29, 111)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1253, 338)
        Panel1.TabIndex = 13
        ' 
        ' lblCliente
        ' 
        lblCliente.AutoSize = True
        lblCliente.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblCliente.ForeColor = Color.White
        lblCliente.Location = New Point(248, 15)
        lblCliente.Name = "lblCliente"
        lblCliente.Size = New Size(83, 28)
        lblCliente.TabIndex = 1
        lblCliente.Text = "Cliente:"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.ForeColor = Color.White
        Label1.Location = New Point(49, 100)
        Label1.Name = "Label1"
        Label1.Size = New Size(145, 20)
        Label1.TabIndex = 14
        Label1.Text = "Busqueda de cientes"
        ' 
        ' txtCliente
        ' 
        txtCliente.Location = New Point(337, 19)
        txtCliente.Multiline = True
        txtCliente.Name = "txtCliente"
        txtCliente.Size = New Size(443, 28)
        txtCliente.TabIndex = 2
        ' 
        ' btnBuscar
        ' 
        btnBuscar.BackColor = Color.DimGray
        btnBuscar.Font = New Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnBuscar.ForeColor = Color.White
        btnBuscar.Image = My.Resources.Resources.buscar
        btnBuscar.ImageAlign = ContentAlignment.MiddleRight
        btnBuscar.Location = New Point(802, 15)
        btnBuscar.Name = "btnBuscar"
        btnBuscar.Padding = New Padding(0, 0, 20, 0)
        btnBuscar.Size = New Size(129, 35)
        btnBuscar.TabIndex = 21
        btnBuscar.Text = "Buscar"
        btnBuscar.UseVisualStyleBackColor = False
        ' 
        ' btnVerTodo
        ' 
        btnVerTodo.BackColor = Color.DimGray
        btnVerTodo.Font = New Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnVerTodo.ForeColor = Color.White
        btnVerTodo.Image = My.Resources.Resources.visualizar_2
        btnVerTodo.ImageAlign = ContentAlignment.MiddleRight
        btnVerTodo.Location = New Point(937, 14)
        btnVerTodo.Name = "btnVerTodo"
        btnVerTodo.Padding = New Padding(0, 0, 20, 0)
        btnVerTodo.Size = New Size(149, 36)
        btnVerTodo.TabIndex = 24
        btnVerTodo.Text = "Ver todo"
        btnVerTodo.UseVisualStyleBackColor = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.White
        Label2.Location = New Point(337, 50)
        Label2.Name = "Label2"
        Label2.Size = New Size(204, 17)
        Label2.TabIndex = 25
        Label2.Text = "(Ingrese Rut o nombre de cliente)"
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {Rut, Nombre, ApellidoP, ApellidoM, Direccion, Telefono, Comuna})
        DataGridView1.Location = New Point(3, 81)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.Size = New Size(1243, 250)
        DataGridView1.TabIndex = 26
        ' 
        ' Rut
        ' 
        Rut.HeaderText = "Rut"
        Rut.MinimumWidth = 6
        Rut.Name = "Rut"
        Rut.Width = 150
        ' 
        ' Nombre
        ' 
        Nombre.HeaderText = "Nombre"
        Nombre.MinimumWidth = 6
        Nombre.Name = "Nombre"
        Nombre.Width = 155
        ' 
        ' ApellidoP
        ' 
        ApellidoP.HeaderText = "Apellido Paterno"
        ApellidoP.MinimumWidth = 6
        ApellidoP.Name = "ApellidoP"
        ApellidoP.Width = 190
        ' 
        ' ApellidoM
        ' 
        ApellidoM.HeaderText = "Apellido Materno"
        ApellidoM.MinimumWidth = 6
        ApellidoM.Name = "ApellidoM"
        ApellidoM.Width = 190
        ' 
        ' Direccion
        ' 
        Direccion.HeaderText = "Direccion"
        Direccion.MinimumWidth = 6
        Direccion.Name = "Direccion"
        Direccion.Width = 250
        ' 
        ' Telefono
        ' 
        Telefono.HeaderText = "Telefono"
        Telefono.MinimumWidth = 6
        Telefono.Name = "Telefono"
        Telefono.Width = 125
        ' 
        ' Comuna
        ' 
        Comuna.HeaderText = "Comuna"
        Comuna.MinimumWidth = 6
        Comuna.Name = "Comuna"
        Comuna.Width = 125
        ' 
        ' pnlGestionClientes
        ' 
        pnlGestionClientes.BorderStyle = BorderStyle.Fixed3D
        pnlGestionClientes.Controls.Add(btnEliminar)
        pnlGestionClientes.Controls.Add(btnModificar)
        pnlGestionClientes.Controls.Add(btnGuardar)
        pnlGestionClientes.Controls.Add(txtRut)
        pnlGestionClientes.Controls.Add(txtNombre)
        pnlGestionClientes.Controls.Add(txtComuna)
        pnlGestionClientes.Controls.Add(txtTelefono)
        pnlGestionClientes.Controls.Add(txtDireccion)
        pnlGestionClientes.Controls.Add(txtApellidoM)
        pnlGestionClientes.Controls.Add(txtApellidoP)
        pnlGestionClientes.Controls.Add(lblComuna)
        pnlGestionClientes.Controls.Add(lblTelefono)
        pnlGestionClientes.Controls.Add(lblDireccion)
        pnlGestionClientes.Controls.Add(lblApellidoM)
        pnlGestionClientes.Controls.Add(lblApellidoP)
        pnlGestionClientes.Controls.Add(lblNombre)
        pnlGestionClientes.Controls.Add(lblRut)
        pnlGestionClientes.Controls.Add(chbxEliminar)
        pnlGestionClientes.Controls.Add(chbxModificar)
        pnlGestionClientes.Controls.Add(chbxIngresar)
        pnlGestionClientes.Location = New Point(29, 474)
        pnlGestionClientes.Name = "pnlGestionClientes"
        pnlGestionClientes.Size = New Size(851, 438)
        pnlGestionClientes.TabIndex = 15
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.ForeColor = Color.White
        Label3.Location = New Point(53, 464)
        Label3.Name = "Label3"
        Label3.Size = New Size(113, 20)
        Label3.TabIndex = 16
        Label3.Text = "Gestion clientes"
        ' 
        ' chbxIngresar
        ' 
        chbxIngresar.AutoSize = True
        chbxIngresar.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        chbxIngresar.ForeColor = Color.White
        chbxIngresar.Location = New Point(18, 20)
        chbxIngresar.Name = "chbxIngresar"
        chbxIngresar.Size = New Size(139, 24)
        chbxIngresar.TabIndex = 35
        chbxIngresar.Text = "Ingresar cliente"
        chbxIngresar.UseVisualStyleBackColor = True
        ' 
        ' chbxModificar
        ' 
        chbxModificar.AutoSize = True
        chbxModificar.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        chbxModificar.ForeColor = Color.White
        chbxModificar.Location = New Point(183, 20)
        chbxModificar.Name = "chbxModificar"
        chbxModificar.Size = New Size(148, 24)
        chbxModificar.TabIndex = 36
        chbxModificar.Text = "Modificar cliente"
        chbxModificar.UseVisualStyleBackColor = True
        ' 
        ' chbxEliminar
        ' 
        chbxEliminar.AutoSize = True
        chbxEliminar.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        chbxEliminar.ForeColor = Color.White
        chbxEliminar.Location = New Point(353, 20)
        chbxEliminar.Name = "chbxEliminar"
        chbxEliminar.Size = New Size(138, 24)
        chbxEliminar.TabIndex = 37
        chbxEliminar.Text = "Eliminar cliente"
        chbxEliminar.UseVisualStyleBackColor = True
        ' 
        ' lblRut
        ' 
        lblRut.AutoSize = True
        lblRut.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblRut.ForeColor = Color.White
        lblRut.Location = New Point(18, 114)
        lblRut.Name = "lblRut"
        lblRut.Size = New Size(50, 28)
        lblRut.TabIndex = 38
        lblRut.Text = "Rut:"
        ' 
        ' lblNombre
        ' 
        lblNombre.AutoSize = True
        lblNombre.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblNombre.ForeColor = Color.White
        lblNombre.Location = New Point(18, 152)
        lblNombre.Name = "lblNombre"
        lblNombre.Size = New Size(94, 28)
        lblNombre.TabIndex = 39
        lblNombre.Text = "Nombre:"
        ' 
        ' lblApellidoP
        ' 
        lblApellidoP.AutoSize = True
        lblApellidoP.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblApellidoP.ForeColor = Color.White
        lblApellidoP.Location = New Point(18, 189)
        lblApellidoP.Name = "lblApellidoP"
        lblApellidoP.Size = New Size(176, 28)
        lblApellidoP.TabIndex = 40
        lblApellidoP.Text = "Apellido paterno:"
        lblApellidoP.TextAlign = ContentAlignment.TopCenter
        ' 
        ' lblApellidoM
        ' 
        lblApellidoM.AutoSize = True
        lblApellidoM.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblApellidoM.ForeColor = Color.White
        lblApellidoM.Location = New Point(18, 226)
        lblApellidoM.Name = "lblApellidoM"
        lblApellidoM.Size = New Size(182, 28)
        lblApellidoM.TabIndex = 41
        lblApellidoM.Text = "Apellido materno:"
        lblApellidoM.TextAlign = ContentAlignment.TopCenter
        ' 
        ' lblDireccion
        ' 
        lblDireccion.AutoSize = True
        lblDireccion.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblDireccion.ForeColor = Color.White
        lblDireccion.Location = New Point(18, 263)
        lblDireccion.Name = "lblDireccion"
        lblDireccion.Size = New Size(107, 28)
        lblDireccion.TabIndex = 42
        lblDireccion.Text = "Direccion:"
        lblDireccion.TextAlign = ContentAlignment.TopCenter
        ' 
        ' lblTelefono
        ' 
        lblTelefono.AutoSize = True
        lblTelefono.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTelefono.ForeColor = Color.White
        lblTelefono.Location = New Point(18, 301)
        lblTelefono.Name = "lblTelefono"
        lblTelefono.Size = New Size(99, 28)
        lblTelefono.TabIndex = 43
        lblTelefono.Text = "Teléfono:"
        lblTelefono.TextAlign = ContentAlignment.TopCenter
        ' 
        ' lblComuna
        ' 
        lblComuna.AutoSize = True
        lblComuna.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblComuna.ForeColor = Color.White
        lblComuna.Location = New Point(18, 338)
        lblComuna.Name = "lblComuna"
        lblComuna.Size = New Size(94, 28)
        lblComuna.TabIndex = 44
        lblComuna.Text = "Comuna:"
        lblComuna.TextAlign = ContentAlignment.TopCenter
        ' 
        ' txtApellidoP
        ' 
        txtApellidoP.Location = New Point(217, 189)
        txtApellidoP.Multiline = True
        txtApellidoP.Name = "txtApellidoP"
        txtApellidoP.Size = New Size(228, 28)
        txtApellidoP.TabIndex = 45
        ' 
        ' txtApellidoM
        ' 
        txtApellidoM.Location = New Point(217, 226)
        txtApellidoM.Multiline = True
        txtApellidoM.Name = "txtApellidoM"
        txtApellidoM.Size = New Size(228, 28)
        txtApellidoM.TabIndex = 46
        ' 
        ' txtDireccion
        ' 
        txtDireccion.Location = New Point(217, 263)
        txtDireccion.Multiline = True
        txtDireccion.Name = "txtDireccion"
        txtDireccion.Size = New Size(324, 28)
        txtDireccion.TabIndex = 47
        ' 
        ' txtTelefono
        ' 
        txtTelefono.Location = New Point(217, 301)
        txtTelefono.Multiline = True
        txtTelefono.Name = "txtTelefono"
        txtTelefono.Size = New Size(183, 28)
        txtTelefono.TabIndex = 48
        ' 
        ' txtComuna
        ' 
        txtComuna.Location = New Point(217, 338)
        txtComuna.Multiline = True
        txtComuna.Name = "txtComuna"
        txtComuna.Size = New Size(228, 28)
        txtComuna.TabIndex = 49
        ' 
        ' txtNombre
        ' 
        txtNombre.Location = New Point(217, 152)
        txtNombre.Multiline = True
        txtNombre.Name = "txtNombre"
        txtNombre.Size = New Size(228, 28)
        txtNombre.TabIndex = 50
        ' 
        ' txtRut
        ' 
        txtRut.Location = New Point(217, 114)
        txtRut.Multiline = True
        txtRut.Name = "txtRut"
        txtRut.Size = New Size(183, 28)
        txtRut.TabIndex = 51
        ' 
        ' btnGuardar
        ' 
        btnGuardar.BackColor = Color.DimGray
        btnGuardar.Enabled = False
        btnGuardar.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnGuardar.ForeColor = Color.White
        btnGuardar.Image = My.Resources.Resources.guardar
        btnGuardar.ImageAlign = ContentAlignment.MiddleRight
        btnGuardar.Location = New Point(607, 114)
        btnGuardar.Name = "btnGuardar"
        btnGuardar.Padding = New Padding(0, 0, 30, 0)
        btnGuardar.Size = New Size(227, 61)
        btnGuardar.TabIndex = 52
        btnGuardar.Text = "Guardar"
        btnGuardar.UseVisualStyleBackColor = False
        ' 
        ' btnModificar
        ' 
        btnModificar.BackColor = Color.DimGray
        btnModificar.Enabled = False
        btnModificar.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnModificar.ForeColor = Color.White
        btnModificar.Image = My.Resources.Resources.modificar
        btnModificar.ImageAlign = ContentAlignment.MiddleRight
        btnModificar.Location = New Point(607, 206)
        btnModificar.Name = "btnModificar"
        btnModificar.Padding = New Padding(0, 0, 30, 0)
        btnModificar.Size = New Size(227, 61)
        btnModificar.TabIndex = 53
        btnModificar.Text = "Modificar"
        btnModificar.UseVisualStyleBackColor = False
        ' 
        ' btnEliminar
        ' 
        btnEliminar.BackColor = Color.DimGray
        btnEliminar.Enabled = False
        btnEliminar.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnEliminar.ForeColor = Color.White
        btnEliminar.Image = My.Resources.Resources.eliminar
        btnEliminar.ImageAlign = ContentAlignment.MiddleRight
        btnEliminar.Location = New Point(607, 301)
        btnEliminar.Name = "btnEliminar"
        btnEliminar.Padding = New Padding(0, 0, 30, 0)
        btnEliminar.Size = New Size(227, 61)
        btnEliminar.TabIndex = 54
        btnEliminar.Text = "Eliminar"
        btnEliminar.UseVisualStyleBackColor = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.ClientesForm6
        PictureBox1.Location = New Point(931, 507)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(337, 319)
        PictureBox1.TabIndex = 17
        PictureBox1.TabStop = False
        ' 
        ' btnVolver
        ' 
        btnVolver.BackColor = Color.DimGray
        btnVolver.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnVolver.ForeColor = Color.White
        btnVolver.Image = My.Resources.Resources.volver
        btnVolver.ImageAlign = ContentAlignment.MiddleRight
        btnVolver.Location = New Point(1023, 848)
        btnVolver.Name = "btnVolver"
        btnVolver.Padding = New Padding(0, 0, 15, 0)
        btnVolver.Size = New Size(159, 48)
        btnVolver.TabIndex = 20
        btnVolver.Text = "Volver"
        btnVolver.UseVisualStyleBackColor = False
        ' 
        ' Form6
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(35), CByte(35), CByte(35))
        ClientSize = New Size(1314, 924)
        Controls.Add(btnVolver)
        Controls.Add(PictureBox1)
        Controls.Add(Label3)
        Controls.Add(pnlGestionClientes)
        Controls.Add(Label1)
        Controls.Add(Panel1)
        Controls.Add(lblTitulo)
        Name = "Form6"
        Text = "Clientes"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        pnlGestionClientes.ResumeLayout(False)
        pnlGestionClientes.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblTitulo As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblCliente As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtCliente As TextBox
    Friend WithEvents btnBuscar As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents btnVerTodo As Button
    Friend WithEvents Rut As DataGridViewTextBoxColumn
    Friend WithEvents Nombre As DataGridViewTextBoxColumn
    Friend WithEvents ApellidoP As DataGridViewTextBoxColumn
    Friend WithEvents ApellidoM As DataGridViewTextBoxColumn
    Friend WithEvents Direccion As DataGridViewTextBoxColumn
    Friend WithEvents Telefono As DataGridViewTextBoxColumn
    Friend WithEvents Comuna As DataGridViewTextBoxColumn
    Friend WithEvents pnlGestionClientes As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents chbxIngresar As CheckBox
    Friend WithEvents chbxEliminar As CheckBox
    Friend WithEvents chbxModificar As CheckBox
    Friend WithEvents lblNombre As Label
    Friend WithEvents lblRut As Label
    Friend WithEvents lblTelefono As Label
    Friend WithEvents lblDireccion As Label
    Friend WithEvents lblApellidoM As Label
    Friend WithEvents lblApellidoP As Label
    Friend WithEvents txtApellidoP As TextBox
    Friend WithEvents lblComuna As Label
    Friend WithEvents txtRut As TextBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtComuna As TextBox
    Friend WithEvents txtTelefono As TextBox
    Friend WithEvents txtDireccion As TextBox
    Friend WithEvents txtApellidoM As TextBox
    Friend WithEvents btnGuardar As Button
    Friend WithEvents btnModificar As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnVolver As Button
End Class
