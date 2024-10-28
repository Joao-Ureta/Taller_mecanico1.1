<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
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
        lblBienvenido = New Label()
        Panel1 = New Panel()
        btnClientes = New Button()
        btnEmpleados = New Button()
        btnServicios = New Button()
        btnSieniestros = New Button()
        btnRepuestos = New Button()
        btnUsuarios = New Button()
        Label2 = New Label()
        PictureBox1 = New PictureBox()
        btnSalir = New Button()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Arial Black", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.ButtonHighlight
        Label1.Location = New Point(315, 26)
        Label1.Name = "Label1"
        Label1.Size = New Size(360, 56)
        Label1.TabIndex = 11
        Label1.Text = "Ultra Mecanica"
        ' 
        ' lblBienvenido
        ' 
        lblBienvenido.AutoSize = True
        lblBienvenido.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblBienvenido.ForeColor = SystemColors.AppWorkspace
        lblBienvenido.Location = New Point(30, 102)
        lblBienvenido.Name = "lblBienvenido"
        lblBienvenido.Size = New Size(114, 23)
        lblBienvenido.TabIndex = 12
        lblBienvenido.Text = " Bienvenido, "
        ' 
        ' Panel1
        ' 
        Panel1.BorderStyle = BorderStyle.Fixed3D
        Panel1.Controls.Add(btnClientes)
        Panel1.Controls.Add(btnEmpleados)
        Panel1.Controls.Add(btnServicios)
        Panel1.Controls.Add(btnSieniestros)
        Panel1.Controls.Add(btnRepuestos)
        Panel1.Controls.Add(btnUsuarios)
        Panel1.Location = New Point(30, 166)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(338, 619)
        Panel1.TabIndex = 13
        ' 
        ' btnClientes
        ' 
        btnClientes.BackColor = Color.DimGray
        btnClientes.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnClientes.ForeColor = Color.White
        btnClientes.Image = My.Resources.Resources.clientes
        btnClientes.ImageAlign = ContentAlignment.MiddleRight
        btnClientes.Location = New Point(54, 239)
        btnClientes.Name = "btnClientes"
        btnClientes.Padding = New Padding(0, 0, 30, 0)
        btnClientes.Size = New Size(227, 61)
        btnClientes.TabIndex = 5
        btnClientes.Text = "Clientes"
        btnClientes.UseVisualStyleBackColor = False
        ' 
        ' btnEmpleados
        ' 
        btnEmpleados.BackColor = Color.DimGray
        btnEmpleados.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnEmpleados.ForeColor = Color.White
        btnEmpleados.Image = My.Resources.Resources.empleados
        btnEmpleados.ImageAlign = ContentAlignment.MiddleRight
        btnEmpleados.Location = New Point(54, 60)
        btnEmpleados.Name = "btnEmpleados"
        btnEmpleados.Padding = New Padding(0, 0, 30, 0)
        btnEmpleados.Size = New Size(227, 61)
        btnEmpleados.TabIndex = 4
        btnEmpleados.Text = "Empleados"
        btnEmpleados.UseVisualStyleBackColor = False
        ' 
        ' btnServicios
        ' 
        btnServicios.BackColor = Color.DimGray
        btnServicios.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnServicios.ForeColor = Color.White
        btnServicios.Image = My.Resources.Resources.servicios
        btnServicios.ImageAlign = ContentAlignment.MiddleRight
        btnServicios.Location = New Point(54, 515)
        btnServicios.Name = "btnServicios"
        btnServicios.Padding = New Padding(0, 0, 30, 0)
        btnServicios.Size = New Size(227, 61)
        btnServicios.TabIndex = 3
        btnServicios.Text = "Servicios"
        btnServicios.UseVisualStyleBackColor = False
        ' 
        ' btnSieniestros
        ' 
        btnSieniestros.BackColor = Color.DimGray
        btnSieniestros.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSieniestros.ForeColor = Color.White
        btnSieniestros.Image = My.Resources.Resources.siniestros
        btnSieniestros.ImageAlign = ContentAlignment.MiddleRight
        btnSieniestros.Location = New Point(54, 421)
        btnSieniestros.Name = "btnSieniestros"
        btnSieniestros.Padding = New Padding(0, 0, 30, 0)
        btnSieniestros.Size = New Size(227, 61)
        btnSieniestros.TabIndex = 2
        btnSieniestros.Text = "Siniestros"
        btnSieniestros.UseVisualStyleBackColor = False
        ' 
        ' btnRepuestos
        ' 
        btnRepuestos.BackColor = Color.DimGray
        btnRepuestos.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnRepuestos.ForeColor = Color.White
        btnRepuestos.Image = My.Resources.Resources.repuestos
        btnRepuestos.ImageAlign = ContentAlignment.MiddleRight
        btnRepuestos.Location = New Point(54, 326)
        btnRepuestos.Name = "btnRepuestos"
        btnRepuestos.Padding = New Padding(0, 0, 30, 0)
        btnRepuestos.Size = New Size(227, 61)
        btnRepuestos.TabIndex = 1
        btnRepuestos.Text = "Repuestos"
        btnRepuestos.UseVisualStyleBackColor = False
        ' 
        ' btnUsuarios
        ' 
        btnUsuarios.BackColor = Color.DimGray
        btnUsuarios.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnUsuarios.ForeColor = Color.White
        btnUsuarios.Image = My.Resources.Resources.usuarios2
        btnUsuarios.ImageAlign = ContentAlignment.MiddleRight
        btnUsuarios.Location = New Point(54, 149)
        btnUsuarios.Name = "btnUsuarios"
        btnUsuarios.Padding = New Padding(0, 0, 30, 0)
        btnUsuarios.Size = New Size(227, 61)
        btnUsuarios.TabIndex = 0
        btnUsuarios.Text = "Usuarios"
        btnUsuarios.UseVisualStyleBackColor = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.ForeColor = Color.White
        Label2.Location = New Point(63, 156)
        Label2.Name = "Label2"
        Label2.Size = New Size(46, 20)
        Label2.TabIndex = 14
        Label2.Text = "Menú"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BorderStyle = BorderStyle.Fixed3D
        PictureBox1.Image = My.Resources.Resources.logo
        PictureBox1.Location = New Point(399, 279)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(551, 359)
        PictureBox1.TabIndex = 15
        PictureBox1.TabStop = False
        ' 
        ' btnSalir
        ' 
        btnSalir.BackColor = Color.DimGray
        btnSalir.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSalir.ForeColor = Color.White
        btnSalir.Image = My.Resources.Resources.cerrar_sesion
        btnSalir.ImageAlign = ContentAlignment.MiddleRight
        btnSalir.Location = New Point(727, 781)
        btnSalir.Name = "btnSalir"
        btnSalir.Padding = New Padding(0, 0, 15, 0)
        btnSalir.Size = New Size(223, 52)
        btnSalir.TabIndex = 16
        btnSalir.Text = "Cerrar Sesión"
        btnSalir.UseVisualStyleBackColor = False
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(35), CByte(35), CByte(35))
        ClientSize = New Size(976, 860)
        Controls.Add(btnSalir)
        Controls.Add(PictureBox1)
        Controls.Add(Label2)
        Controls.Add(Panel1)
        Controls.Add(lblBienvenido)
        Controls.Add(Label1)
        Name = "Form2"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Menú"
        Panel1.ResumeLayout(False)
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lblBienvenido As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnUsuarios As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents btnRepuestos As Button
    Friend WithEvents btnSieniestros As Button
    Friend WithEvents btnServicios As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnSalir As Button
    Friend WithEvents btnEmpleados As Button
    Friend WithEvents btnClientes As Button
End Class