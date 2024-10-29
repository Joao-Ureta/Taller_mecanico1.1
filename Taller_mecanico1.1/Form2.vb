Public Class Form2

    ' Propiedad para almacenar el tipo de usuario
    Public Property TipoUsuario As String

    ' Evento Activated: cada vez que Form2 se active, revisa el tipo de usuario y ajusta los botones
    Private Sub Form2_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        ' Verificar el tipo de usuario y habilitar/deshabilitar los botones
        If TipoUsuario = "Administrador" OrElse TipoUsuario = "Gerente" Then
            btnUsuarios.Enabled = True
            btnEmpleados.Enabled = True
        Else
            btnUsuarios.Enabled = False
            btnEmpleados.Enabled = False
        End If
    End Sub


    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click

        'codigo para cerrar sesion

        Form1.Show()
        Me.Close()

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
End Class