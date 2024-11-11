Public Class Form2

    ' Propiedad para almacenar el tipo de usuario
    Public Property TipoUsuario As String



    ' Crear una instancia compartida de Form2
    Private Shared _instance As Form2

    Public Shared ReadOnly Property Instance() As Form2
        Get
            If _instance Is Nothing OrElse _instance.IsDisposed Then
                _instance = New Form2()
            End If
            Return _instance
        End Get
    End Property

    ' Constructor privado
    Private Sub New()
        InitializeComponent()
    End Sub







    ' Evento Activador: cada vez que Form2 se active, revisa el tipo de usuario y ajusta los botones
    Private Sub Form2_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        UpdateButtonStates()
    End Sub

    Private Sub UpdateButtonStates()
        If Globals.LoggedInUserType = "Administrador" OrElse Globals.LoggedInUserType = "Gerente" Then
            btnEmpleados.Enabled = True
            btnUsuarios.Enabled = True
        Else
            btnEmpleados.Enabled = False
            btnUsuarios.Enabled = False
        End If
    End Sub




    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click

        'codigo para cerrar sesion

        ' Mostrar mensaje de confirmación
        Dim resultado As DialogResult = MessageBox.Show("¿Está seguro que desea cerrar sesión?", "Cerrar Sesión", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If resultado = DialogResult.Yes Then
            ' Restablecer la variable global del tipo de usuario
            Globals.LoggedInUserType = Nothing

            ' Limpiar los campos de texto en Form1
            Form1.ClearLoginFields()

            ' Mostrar Form1 nuevamente
            Form1.Show()

            ' Ocultar o cerrar el formulario actual
            Me.Hide()
        End If

    End Sub

    Private Sub btnUsuarios_Click(sender As Object, e As EventArgs) Handles btnUsuarios.Click

        'codigo para ir a form3 (gestion usuarios)
        Form3.Show()
        Me.Close()

    End Sub

    Private Sub btnEmpleados_Click(sender As Object, e As EventArgs) Handles btnEmpleados.Click

    End Sub

    Private Sub btnRepuestos_Click(sender As Object, e As EventArgs) Handles btnRepuestos.Click

        'codigo para ir a form4 (gestion usuarios)
        Form4.Show()
        Me.Close()

    End Sub

    Private Sub btnSieniestros_Click(sender As Object, e As EventArgs) Handles btnSieniestros.Click
        'codigo para ir a form5 (gestion usuarios)
        Form5.Show()
        Me.Close()
    End Sub

    Private Sub btnClientes_Click(sender As Object, e As EventArgs) Handles btnClientes.Click
        'codigo para ir a form5 (gestion usuarios)
        Form6.Show()
        Me.Close()
    End Sub
End Class