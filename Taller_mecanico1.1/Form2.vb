Public Class Form2

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