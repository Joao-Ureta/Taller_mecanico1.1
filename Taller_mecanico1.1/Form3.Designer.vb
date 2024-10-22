<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form3
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
        Label1 = New Label()
        DataGridView1 = New DataGridView()
        RUT = New DataGridViewTextBoxColumn()
        CORREO = New DataGridViewTextBoxColumn()
        Contraseña = New DataGridViewTextBoxColumn()
        Tipo = New DataGridViewTextBoxColumn()
        Panel1 = New Panel()
        btnVisualizar = New Button()
        btnBuscar = New Button()
        txtRut = New TextBox()
        Label3 = New Label()
        Label2 = New Label()
        btnVolver = New Button()
        Panel2 = New Panel()
        CheckEliminar = New CheckBox()
        CheckModificar = New CheckBox()
        CheckIngresar = New CheckBox()
        cbxTipo = New ComboBox()
        txtCorreo = New TextBox()
        txtRutDos = New TextBox()
        txtContraseña = New TextBox()
        Label8 = New Label()
        Label7 = New Label()
        Label6 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        btnGuardar = New Button()
        btnModificar = New Button()
        btnEliminar = New Button()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Arial Black", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.ButtonHighlight
        Label1.Location = New Point(273, 26)
        Label1.Name = "Label1"
        Label1.Size = New Size(460, 56)
        Label1.TabIndex = 11
        Label1.Text = "Gestión de usuarios"
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {RUT, CORREO, Contraseña, Tipo})
        DataGridView1.Location = New Point(75, 78)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.Size = New Size(804, 183)
        DataGridView1.TabIndex = 12
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
        ' Panel1
        ' 
        Panel1.BorderStyle = BorderStyle.Fixed3D
        Panel1.Controls.Add(btnVisualizar)
        Panel1.Controls.Add(btnBuscar)
        Panel1.Controls.Add(txtRut)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(DataGridView1)
        Panel1.Location = New Point(28, 116)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(940, 281)
        Panel1.TabIndex = 13
        ' 
        ' btnVisualizar
        ' 
        btnVisualizar.BackColor = Color.DimGray
        btnVisualizar.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnVisualizar.ForeColor = Color.White
        btnVisualizar.Image = My.Resources.Resources.visualizar_2
        btnVisualizar.ImageAlign = ContentAlignment.MiddleRight
        btnVisualizar.Location = New Point(574, 16)
        btnVisualizar.Name = "btnVisualizar"
        btnVisualizar.Padding = New Padding(0, 0, 20, 0)
        btnVisualizar.Size = New Size(172, 38)
        btnVisualizar.TabIndex = 18
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
        btnBuscar.Location = New Point(418, 16)
        btnBuscar.Name = "btnBuscar"
        btnBuscar.Padding = New Padding(0, 0, 20, 0)
        btnBuscar.Size = New Size(138, 38)
        btnBuscar.TabIndex = 17
        btnBuscar.Text = "Buscar"
        btnBuscar.UseVisualStyleBackColor = False
        ' 
        ' txtRut
        ' 
        txtRut.Location = New Point(141, 22)
        txtRut.Multiline = True
        txtRut.Name = "txtRut"
        txtRut.Size = New Size(242, 28)
        txtRut.TabIndex = 16
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.White
        Label3.Location = New Point(75, 22)
        Label3.Name = "Label3"
        Label3.Size = New Size(50, 28)
        Label3.TabIndex = 15
        Label3.Text = "Rut:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.ForeColor = Color.White
        Label2.Location = New Point(53, 107)
        Label2.Name = "Label2"
        Label2.Size = New Size(177, 20)
        Label2.TabIndex = 14
        Label2.Text = "Visualización de usuarios:"
        ' 
        ' btnVolver
        ' 
        btnVolver.BackColor = Color.DimGray
        btnVolver.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnVolver.ForeColor = Color.White
        btnVolver.Image = My.Resources.Resources.volver
        btnVolver.ImageAlign = ContentAlignment.MiddleRight
        btnVolver.Location = New Point(750, 786)
        btnVolver.Name = "btnVolver"
        btnVolver.Padding = New Padding(0, 0, 15, 0)
        btnVolver.Size = New Size(159, 48)
        btnVolver.TabIndex = 17
        btnVolver.Text = "Volver"
        btnVolver.UseVisualStyleBackColor = False
        ' 
        ' Panel2
        ' 
        Panel2.BorderStyle = BorderStyle.Fixed3D
        Panel2.Controls.Add(CheckEliminar)
        Panel2.Controls.Add(CheckModificar)
        Panel2.Controls.Add(CheckIngresar)
        Panel2.Controls.Add(cbxTipo)
        Panel2.Controls.Add(txtCorreo)
        Panel2.Controls.Add(txtRutDos)
        Panel2.Controls.Add(txtContraseña)
        Panel2.Controls.Add(Label8)
        Panel2.Controls.Add(Label7)
        Panel2.Controls.Add(Label6)
        Panel2.Controls.Add(Label5)
        Panel2.Location = New Point(28, 418)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(611, 416)
        Panel2.TabIndex = 18
        ' 
        ' CheckEliminar
        ' 
        CheckEliminar.AutoSize = True
        CheckEliminar.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        CheckEliminar.ForeColor = Color.White
        CheckEliminar.Location = New Point(435, 24)
        CheckEliminar.Name = "CheckEliminar"
        CheckEliminar.Size = New Size(144, 24)
        CheckEliminar.TabIndex = 26
        CheckEliminar.Text = "Eliminar usuario"
        CheckEliminar.UseVisualStyleBackColor = True
        ' 
        ' CheckModificar
        ' 
        CheckModificar.AutoSize = True
        CheckModificar.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        CheckModificar.ForeColor = Color.White
        CheckModificar.Location = New Point(229, 24)
        CheckModificar.Name = "CheckModificar"
        CheckModificar.Size = New Size(154, 24)
        CheckModificar.TabIndex = 25
        CheckModificar.Text = "Modificar usuario"
        CheckModificar.UseVisualStyleBackColor = True
        ' 
        ' CheckIngresar
        ' 
        CheckIngresar.AutoSize = True
        CheckIngresar.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        CheckIngresar.ForeColor = Color.White
        CheckIngresar.Location = New Point(27, 24)
        CheckIngresar.Name = "CheckIngresar"
        CheckIngresar.Size = New Size(145, 24)
        CheckIngresar.TabIndex = 24
        CheckIngresar.Text = "Ingresar usuario"
        CheckIngresar.UseVisualStyleBackColor = True
        ' 
        ' cbxTipo
        ' 
        cbxTipo.Enabled = False
        cbxTipo.FormattingEnabled = True
        cbxTipo.Location = New Point(243, 322)
        cbxTipo.Name = "cbxTipo"
        cbxTipo.Size = New Size(248, 28)
        cbxTipo.TabIndex = 23
        ' 
        ' txtCorreo
        ' 
        txtCorreo.Enabled = False
        txtCorreo.Location = New Point(243, 190)
        txtCorreo.Multiline = True
        txtCorreo.Name = "txtCorreo"
        txtCorreo.Size = New Size(248, 28)
        txtCorreo.TabIndex = 22
        ' 
        ' txtRutDos
        ' 
        txtRutDos.Enabled = False
        txtRutDos.Location = New Point(243, 123)
        txtRutDos.Multiline = True
        txtRutDos.Name = "txtRutDos"
        txtRutDos.Size = New Size(174, 28)
        txtRutDos.TabIndex = 21
        ' 
        ' txtContraseña
        ' 
        txtContraseña.Enabled = False
        txtContraseña.Location = New Point(243, 252)
        txtContraseña.Multiline = True
        txtContraseña.Name = "txtContraseña"
        txtContraseña.Size = New Size(174, 28)
        txtContraseña.TabIndex = 20
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.ForeColor = Color.White
        Label8.Location = New Point(92, 318)
        Label8.Name = "Label8"
        Label8.Size = New Size(59, 28)
        Label8.TabIndex = 19
        Label8.Text = "Tipo:"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.ForeColor = Color.White
        Label7.Location = New Point(92, 252)
        Label7.Name = "Label7"
        Label7.Size = New Size(123, 28)
        Label7.TabIndex = 18
        Label7.Text = "Contraseña:"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = Color.White
        Label6.Location = New Point(92, 190)
        Label6.Name = "Label6"
        Label6.Size = New Size(80, 28)
        Label6.TabIndex = 17
        Label6.Text = "Correo:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.White
        Label5.Location = New Point(92, 123)
        Label5.Name = "Label5"
        Label5.Size = New Size(50, 28)
        Label5.TabIndex = 16
        Label5.Text = "Rut:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.ForeColor = Color.White
        Label4.Location = New Point(56, 408)
        Label4.Name = "Label4"
        Label4.Size = New Size(141, 20)
        Label4.TabIndex = 19
        Label4.Text = "Gestión de usuarios:"
        ' 
        ' btnGuardar
        ' 
        btnGuardar.BackColor = Color.DimGray
        btnGuardar.Enabled = False
        btnGuardar.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnGuardar.ForeColor = Color.White
        btnGuardar.Image = My.Resources.Resources.guardar
        btnGuardar.ImageAlign = ContentAlignment.MiddleRight
        btnGuardar.Location = New Point(713, 479)
        btnGuardar.Name = "btnGuardar"
        btnGuardar.Padding = New Padding(0, 0, 30, 0)
        btnGuardar.Size = New Size(227, 61)
        btnGuardar.TabIndex = 21
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
        btnModificar.Location = New Point(713, 565)
        btnModificar.Name = "btnModificar"
        btnModificar.Padding = New Padding(0, 0, 30, 0)
        btnModificar.Size = New Size(227, 61)
        btnModificar.TabIndex = 22
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
        btnEliminar.Location = New Point(713, 651)
        btnEliminar.Name = "btnEliminar"
        btnEliminar.Padding = New Padding(0, 0, 30, 0)
        btnEliminar.Size = New Size(227, 61)
        btnEliminar.TabIndex = 23
        btnEliminar.Text = "Eliminar"
        btnEliminar.UseVisualStyleBackColor = False
        ' 
        ' Form3
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(35), CByte(35), CByte(35))
        ClientSize = New Size(997, 846)
        Controls.Add(btnEliminar)
        Controls.Add(btnModificar)
        Controls.Add(btnGuardar)
        Controls.Add(Label4)
        Controls.Add(Panel2)
        Controls.Add(btnVolver)
        Controls.Add(Label2)
        Controls.Add(Panel1)
        Controls.Add(Label1)
        Name = "Form3"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Gestion usuarios"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents RUT As DataGridViewTextBoxColumn
    Friend WithEvents CORREO As DataGridViewTextBoxColumn
    Friend WithEvents Contraseña As DataGridViewTextBoxColumn
    Friend WithEvents Tipo As DataGridViewTextBoxColumn
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents btnBuscar As Button
    Friend WithEvents txtRut As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btnVolver As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents txtContraseña As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtCorreo As TextBox
    Friend WithEvents txtRutDos As TextBox
    Friend WithEvents btnVisualizar As Button
    Friend WithEvents btnGuardar As Button
    Friend WithEvents btnModificar As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents cbxTipo As ComboBox
    Friend WithEvents CheckIngresar As CheckBox
    Friend WithEvents CheckEliminar As CheckBox
    Friend WithEvents CheckModificar As CheckBox
End Class
