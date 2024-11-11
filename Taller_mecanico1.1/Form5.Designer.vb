<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form5
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
        lblTitulo = New Label()
        Panel1 = New Panel()
        DataGridView1 = New DataGridView()
        ID = New DataGridViewTextBoxColumn()
        Detalle = New DataGridViewTextBoxColumn()
        Estado = New DataGridViewTextBoxColumn()
        Fecha = New DataGridViewTextBoxColumn()
        Compañia = New DataGridViewTextBoxColumn()
        Cliente = New DataGridViewTextBoxColumn()
        seguro = New DataGridViewTextBoxColumn()
        btnVerTodo = New Button()
        cbxEstado = New ComboBox()
        Label2 = New Label()
        btnBuscar = New Button()
        txtCliente = New TextBox()
        lblCliente = New Label()
        Label1 = New Label()
        Panel2 = New Panel()
        cbxCompañia = New ComboBox()
        btnModificar = New Button()
        btnGuardar = New Button()
        cbxSeguro = New ComboBox()
        lblSeguro = New Label()
        txtCliente2 = New TextBox()
        lblCliente2 = New Label()
        lblCompañia = New Label()
        FecSiniestro = New DateTimePicker()
        lblFecha = New Label()
        cbxEstado2 = New ComboBox()
        lblEstado = New Label()
        txtDetalle = New TextBox()
        txtID = New TextBox()
        lblDetalle = New Label()
        lblID = New Label()
        chbxModificar = New CheckBox()
        chbxIngresar = New CheckBox()
        Label3 = New Label()
        PictureBox1 = New PictureBox()
        btnVolver = New Button()
        PictureBox2 = New PictureBox()
        Panel1.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblTitulo
        ' 
        lblTitulo.AutoSize = True
        lblTitulo.Font = New Font("Arial Black", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTitulo.ForeColor = SystemColors.ButtonHighlight
        lblTitulo.Location = New Point(317, 24)
        lblTitulo.Name = "lblTitulo"
        lblTitulo.Size = New Size(489, 56)
        lblTitulo.TabIndex = 14
        lblTitulo.Text = "Gestión de siniestros"
        ' 
        ' Panel1
        ' 
        Panel1.BorderStyle = BorderStyle.Fixed3D
        Panel1.Controls.Add(DataGridView1)
        Panel1.Controls.Add(btnVerTodo)
        Panel1.Controls.Add(cbxEstado)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(btnBuscar)
        Panel1.Controls.Add(txtCliente)
        Panel1.Controls.Add(lblCliente)
        Panel1.Location = New Point(67, 128)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1013, 407)
        Panel1.TabIndex = 15
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {ID, Detalle, Estado, Fecha, Compañia, Cliente, seguro})
        DataGridView1.Location = New Point(3, 118)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.Size = New Size(1003, 264)
        DataGridView1.TabIndex = 24
        ' 
        ' ID
        ' 
        ID.HeaderText = "ID"
        ID.MinimumWidth = 6
        ID.Name = "ID"
        ID.Width = 40
        ' 
        ' Detalle
        ' 
        Detalle.HeaderText = "Detalle siniestro"
        Detalle.MinimumWidth = 6
        Detalle.Name = "Detalle"
        Detalle.Width = 250
        ' 
        ' Estado
        ' 
        Estado.HeaderText = "Estado"
        Estado.MinimumWidth = 6
        Estado.Name = "Estado"
        Estado.Width = 125
        ' 
        ' Fecha
        ' 
        Fecha.HeaderText = "Fecha siniestro"
        Fecha.MinimumWidth = 6
        Fecha.Name = "Fecha"
        Fecha.Width = 125
        ' 
        ' Compañia
        ' 
        Compañia.HeaderText = "Compañia"
        Compañia.MinimumWidth = 6
        Compañia.Name = "Compañia"
        Compañia.Width = 125
        ' 
        ' Cliente
        ' 
        Cliente.HeaderText = "Cliente"
        Cliente.MinimumWidth = 6
        Cliente.Name = "Cliente"
        Cliente.Width = 125
        ' 
        ' seguro
        ' 
        seguro.HeaderText = "Estado seguro"
        seguro.MinimumWidth = 6
        seguro.Name = "seguro"
        seguro.Width = 158
        ' 
        ' btnVerTodo
        ' 
        btnVerTodo.BackColor = Color.DimGray
        btnVerTodo.Font = New Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnVerTodo.ForeColor = Color.White
        btnVerTodo.Image = My.Resources.Resources.visualizar_2
        btnVerTodo.ImageAlign = ContentAlignment.MiddleRight
        btnVerTodo.Location = New Point(777, 18)
        btnVerTodo.Name = "btnVerTodo"
        btnVerTodo.Padding = New Padding(0, 0, 20, 0)
        btnVerTodo.Size = New Size(149, 36)
        btnVerTodo.TabIndex = 23
        btnVerTodo.Text = "Ver todo"
        btnVerTodo.UseVisualStyleBackColor = False
        ' 
        ' cbxEstado
        ' 
        cbxEstado.FormattingEnabled = True
        cbxEstado.Location = New Point(631, 70)
        cbxEstado.Name = "cbxEstado"
        cbxEstado.Size = New Size(295, 28)
        cbxEstado.TabIndex = 22
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.White
        Label2.Location = New Point(175, 54)
        Label2.Name = "Label2"
        Label2.Size = New Size(157, 17)
        Label2.TabIndex = 21
        Label2.Text = "(Ingrese un rut de cliente)"
        ' 
        ' btnBuscar
        ' 
        btnBuscar.BackColor = Color.DimGray
        btnBuscar.Font = New Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnBuscar.ForeColor = Color.White
        btnBuscar.Image = My.Resources.Resources.buscar
        btnBuscar.ImageAlign = ContentAlignment.MiddleRight
        btnBuscar.Location = New Point(631, 19)
        btnBuscar.Name = "btnBuscar"
        btnBuscar.Padding = New Padding(0, 0, 20, 0)
        btnBuscar.Size = New Size(129, 35)
        btnBuscar.TabIndex = 20
        btnBuscar.Text = "Buscar"
        btnBuscar.UseVisualStyleBackColor = False
        ' 
        ' txtCliente
        ' 
        txtCliente.Location = New Point(175, 23)
        txtCliente.Multiline = True
        txtCliente.Name = "txtCliente"
        txtCliente.Size = New Size(437, 28)
        txtCliente.TabIndex = 1
        ' 
        ' lblCliente
        ' 
        lblCliente.AutoSize = True
        lblCliente.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblCliente.ForeColor = Color.White
        lblCliente.Location = New Point(70, 23)
        lblCliente.Name = "lblCliente"
        lblCliente.Size = New Size(83, 28)
        lblCliente.TabIndex = 0
        lblCliente.Text = "Cliente:"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.ForeColor = Color.White
        Label1.Location = New Point(90, 117)
        Label1.Name = "Label1"
        Label1.Size = New Size(160, 20)
        Label1.TabIndex = 0
        Label1.Text = "Busqueda de siniestros"
        ' 
        ' Panel2
        ' 
        Panel2.BorderStyle = BorderStyle.Fixed3D
        Panel2.Controls.Add(cbxCompañia)
        Panel2.Controls.Add(btnModificar)
        Panel2.Controls.Add(btnGuardar)
        Panel2.Controls.Add(cbxSeguro)
        Panel2.Controls.Add(lblSeguro)
        Panel2.Controls.Add(txtCliente2)
        Panel2.Controls.Add(lblCliente2)
        Panel2.Controls.Add(lblCompañia)
        Panel2.Controls.Add(FecSiniestro)
        Panel2.Controls.Add(lblFecha)
        Panel2.Controls.Add(cbxEstado2)
        Panel2.Controls.Add(lblEstado)
        Panel2.Controls.Add(txtDetalle)
        Panel2.Controls.Add(txtID)
        Panel2.Controls.Add(lblDetalle)
        Panel2.Controls.Add(lblID)
        Panel2.Controls.Add(chbxModificar)
        Panel2.Controls.Add(chbxIngresar)
        Panel2.Location = New Point(543, 562)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(537, 515)
        Panel2.TabIndex = 16
        ' 
        ' cbxCompañia
        ' 
        cbxCompañia.Enabled = False
        cbxCompañia.FormattingEnabled = True
        cbxCompañia.Location = New Point(170, 286)
        cbxCompañia.Name = "cbxCompañia"
        cbxCompañia.Size = New Size(293, 28)
        cbxCompañia.TabIndex = 51
        ' 
        ' btnModificar
        ' 
        btnModificar.BackColor = Color.DimGray
        btnModificar.Enabled = False
        btnModificar.Font = New Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnModificar.ForeColor = Color.White
        btnModificar.Image = My.Resources.Resources.modificar
        btnModificar.ImageAlign = ContentAlignment.MiddleRight
        btnModificar.Location = New Point(288, 429)
        btnModificar.Name = "btnModificar"
        btnModificar.Padding = New Padding(0, 0, 30, 0)
        btnModificar.Size = New Size(221, 61)
        btnModificar.TabIndex = 50
        btnModificar.Text = "Modificar"
        btnModificar.UseVisualStyleBackColor = False
        ' 
        ' btnGuardar
        ' 
        btnGuardar.BackColor = Color.DimGray
        btnGuardar.Enabled = False
        btnGuardar.Font = New Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnGuardar.ForeColor = Color.White
        btnGuardar.Image = My.Resources.Resources.guardar
        btnGuardar.ImageAlign = ContentAlignment.MiddleRight
        btnGuardar.Location = New Point(31, 429)
        btnGuardar.Name = "btnGuardar"
        btnGuardar.Padding = New Padding(0, 0, 30, 0)
        btnGuardar.Size = New Size(221, 61)
        btnGuardar.TabIndex = 37
        btnGuardar.Text = "Guardar"
        btnGuardar.UseVisualStyleBackColor = False
        ' 
        ' cbxSeguro
        ' 
        cbxSeguro.Enabled = False
        cbxSeguro.FormattingEnabled = True
        cbxSeguro.Location = New Point(170, 363)
        cbxSeguro.Name = "cbxSeguro"
        cbxSeguro.Size = New Size(293, 28)
        cbxSeguro.TabIndex = 49
        ' 
        ' lblSeguro
        ' 
        lblSeguro.AutoSize = True
        lblSeguro.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblSeguro.ForeColor = Color.White
        lblSeguro.Location = New Point(55, 363)
        lblSeguro.Name = "lblSeguro"
        lblSeguro.Size = New Size(83, 28)
        lblSeguro.TabIndex = 48
        lblSeguro.Text = "Seguro:"
        ' 
        ' txtCliente2
        ' 
        txtCliente2.Enabled = False
        txtCliente2.Location = New Point(170, 324)
        txtCliente2.Multiline = True
        txtCliente2.Name = "txtCliente2"
        txtCliente2.Size = New Size(191, 28)
        txtCliente2.TabIndex = 47
        ' 
        ' lblCliente2
        ' 
        lblCliente2.AutoSize = True
        lblCliente2.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblCliente2.ForeColor = Color.White
        lblCliente2.Location = New Point(53, 324)
        lblCliente2.Name = "lblCliente2"
        lblCliente2.Size = New Size(83, 28)
        lblCliente2.TabIndex = 46
        lblCliente2.Text = "Cliente:"
        ' 
        ' lblCompañia
        ' 
        lblCompañia.AutoSize = True
        lblCompañia.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblCompañia.ForeColor = Color.White
        lblCompañia.Location = New Point(53, 286)
        lblCompañia.Name = "lblCompañia"
        lblCompañia.Size = New Size(111, 28)
        lblCompañia.TabIndex = 44
        lblCompañia.Text = "Compañia:"
        ' 
        ' FecSiniestro
        ' 
        FecSiniestro.CustomFormat = """yyyy-MM-dd"""
        FecSiniestro.Enabled = False
        FecSiniestro.Format = DateTimePickerFormat.Custom
        FecSiniestro.Location = New Point(170, 248)
        FecSiniestro.Name = "FecSiniestro"
        FecSiniestro.Size = New Size(147, 27)
        FecSiniestro.TabIndex = 43
        ' 
        ' lblFecha
        ' 
        lblFecha.AutoSize = True
        lblFecha.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblFecha.ForeColor = Color.White
        lblFecha.Location = New Point(53, 247)
        lblFecha.Name = "lblFecha"
        lblFecha.Size = New Size(71, 28)
        lblFecha.TabIndex = 42
        lblFecha.Text = "Fecha:"
        ' 
        ' cbxEstado2
        ' 
        cbxEstado2.Enabled = False
        cbxEstado2.FormattingEnabled = True
        cbxEstado2.Location = New Point(170, 210)
        cbxEstado2.Name = "cbxEstado2"
        cbxEstado2.Size = New Size(293, 28)
        cbxEstado2.TabIndex = 41
        ' 
        ' lblEstado
        ' 
        lblEstado.AutoSize = True
        lblEstado.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblEstado.ForeColor = Color.White
        lblEstado.Location = New Point(53, 210)
        lblEstado.Name = "lblEstado"
        lblEstado.Size = New Size(80, 28)
        lblEstado.TabIndex = 40
        lblEstado.Text = "Estado:"
        ' 
        ' txtDetalle
        ' 
        txtDetalle.Enabled = False
        txtDetalle.Location = New Point(170, 103)
        txtDetalle.Multiline = True
        txtDetalle.Name = "txtDetalle"
        txtDetalle.Size = New Size(293, 97)
        txtDetalle.TabIndex = 39
        ' 
        ' txtID
        ' 
        txtID.Enabled = False
        txtID.Location = New Point(170, 66)
        txtID.Multiline = True
        txtID.Name = "txtID"
        txtID.Size = New Size(94, 28)
        txtID.TabIndex = 38
        ' 
        ' lblDetalle
        ' 
        lblDetalle.AutoSize = True
        lblDetalle.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblDetalle.ForeColor = Color.White
        lblDetalle.Location = New Point(53, 103)
        lblDetalle.Name = "lblDetalle"
        lblDetalle.Size = New Size(85, 28)
        lblDetalle.TabIndex = 37
        lblDetalle.Text = "Detalle:"
        ' 
        ' lblID
        ' 
        lblID.AutoSize = True
        lblID.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblID.ForeColor = Color.White
        lblID.Location = New Point(53, 66)
        lblID.Name = "lblID"
        lblID.Size = New Size(38, 28)
        lblID.TabIndex = 36
        lblID.Text = "ID:"
        ' 
        ' chbxModificar
        ' 
        chbxModificar.AutoSize = True
        chbxModificar.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        chbxModificar.ForeColor = Color.White
        chbxModificar.Location = New Point(288, 24)
        chbxModificar.Name = "chbxModificar"
        chbxModificar.Size = New Size(213, 24)
        chbxModificar.TabIndex = 35
        chbxModificar.Text = "Modificar estado siniestro"
        chbxModificar.UseVisualStyleBackColor = True
        ' 
        ' chbxIngresar
        ' 
        chbxIngresar.AutoSize = True
        chbxIngresar.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        chbxIngresar.ForeColor = Color.White
        chbxIngresar.Location = New Point(99, 24)
        chbxIngresar.Name = "chbxIngresar"
        chbxIngresar.Size = New Size(153, 24)
        chbxIngresar.TabIndex = 34
        chbxIngresar.Text = "Ingresar siniestro"
        chbxIngresar.UseVisualStyleBackColor = True
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.ForeColor = Color.White
        Label3.Location = New Point(564, 552)
        Label3.Name = "Label3"
        Label3.Size = New Size(145, 20)
        Label3.TabIndex = 17
        Label3.Text = "Gestión de siniestros"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Location = New Point(0, 0)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(100, 50)
        PictureBox1.TabIndex = 20
        PictureBox1.TabStop = False
        ' 
        ' btnVolver
        ' 
        btnVolver.BackColor = Color.DimGray
        btnVolver.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnVolver.ForeColor = Color.White
        btnVolver.Image = My.Resources.Resources.volver
        btnVolver.ImageAlign = ContentAlignment.MiddleRight
        btnVolver.Location = New Point(213, 1029)
        btnVolver.Name = "btnVolver"
        btnVolver.Padding = New Padding(0, 0, 15, 0)
        btnVolver.Size = New Size(159, 48)
        btnVolver.TabIndex = 19
        btnVolver.Text = "Volver"
        btnVolver.UseVisualStyleBackColor = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BorderStyle = BorderStyle.Fixed3D
        PictureBox2.Image = My.Resources.Resources.Form5Siniestro
        PictureBox2.Location = New Point(114, 630)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(342, 338)
        PictureBox2.TabIndex = 21
        PictureBox2.TabStop = False
        ' 
        ' Form5
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(35), CByte(35), CByte(35))
        ClientSize = New Size(1130, 1107)
        Controls.Add(PictureBox2)
        Controls.Add(btnVolver)
        Controls.Add(PictureBox1)
        Controls.Add(Label3)
        Controls.Add(Panel2)
        Controls.Add(Label1)
        Controls.Add(Panel1)
        Controls.Add(lblTitulo)
        Name = "Form5"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Siniestros"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblTitulo As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents txtCliente As TextBox
    Friend WithEvents lblCliente As Label
    Friend WithEvents btnBuscar As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents cbxEstado As ComboBox
    Friend WithEvents btnVerTodo As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents ID As DataGridViewTextBoxColumn
    Friend WithEvents Detalle As DataGridViewTextBoxColumn
    Friend WithEvents Estado As DataGridViewTextBoxColumn
    Friend WithEvents Fecha As DataGridViewTextBoxColumn
    Friend WithEvents Compañia As DataGridViewTextBoxColumn
    Friend WithEvents Cliente As DataGridViewTextBoxColumn
    Friend WithEvents seguro As DataGridViewTextBoxColumn
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents lblDetalle As Label
    Friend WithEvents lblID As Label
    Friend WithEvents chbxModificar As CheckBox
    Friend WithEvents chbxIngresar As CheckBox
    Friend WithEvents lblFecha As Label
    Friend WithEvents cbxEstado2 As ComboBox
    Friend WithEvents lblEstado As Label
    Friend WithEvents txtDetalle As TextBox
    Friend WithEvents txtID As TextBox
    Friend WithEvents FecSiniestro As DateTimePicker
    Friend WithEvents lblCompañia As Label
    Friend WithEvents lblCliente2 As Label
    Friend WithEvents txtCliente2 As TextBox
    Friend WithEvents cbxSeguro As ComboBox
    Friend WithEvents lblSeguro As Label
    Friend WithEvents btnGuardar As Button
    Friend WithEvents btnModificar As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnVolver As Button
    Friend WithEvents cbxCompañia As ComboBox
    Friend WithEvents PictureBox2 As PictureBox
End Class
