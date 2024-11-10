Public Class Form2

    ' Propiedad para almacenar el tipo de usuario
    Public Property TipoUsuario As String

    '' Evento Activated: cada vez que Form2 se active, revisa el tipo de usuario y ajusta los botones
    Private Sub Form2_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        ActualizarBotones()
    End Sub

    ' Método para habilitar o deshabilitar botones según el tipo de usuario
    Private Sub ActualizarBotones()
        If TipoUsuario = "Administrador" OrElse TipoUsuario = "Gerente" Then
            btnUsuarios.Enabled = True
            btnEmpleados.Enabled = True
        Else
            btnUsuarios.Enabled = False
            btnEmpleados.Enabled = False
        End If
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        ' Código para cerrar sesión
        Form1.Show()
        Me.Close()
    End Sub

    Private Sub btnUsuarios_Click(sender As Object, e As EventArgs) Handles btnUsuarios.Click
        ' Código para ir a Form3 (gestión usuarios)
        Form3.Show()
        Me.Close()
    End Sub

    Private Sub btnEmpleados_Click(sender As Object, e As EventArgs) Handles btnEmpleados.Click
        ' Código para ir a Form5 (gestión empleados)
        'Form5.Show()
        Me.Close()
    End Sub

    Private Sub btnRepuestos_Click(sender As Object, e As EventArgs) Handles btnRepuestos.Click
        ' Código para ir a Form4 (gestión repuestos)
        Form4.Show()
        Me.Close()
    End Sub

    Private Sub btnSieniestros_Click(sender As Object, e As EventArgs) Handles btnSieniestros.Click
        ' Código para ir a Form5 (gestión siniestros)
        Form5.Show()
        Me.Close()
    End Sub
End Class
