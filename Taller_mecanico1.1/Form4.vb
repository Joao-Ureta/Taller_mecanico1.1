Public Class Form4
    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Ocultar el PanelInventario al iniciar el formulario
        PanelInventario.Visible = False
    End Sub

    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        ' Código para volver a Form2 (menú)
        Form2.Show()
        Me.Close()
    End Sub

    ' Método para mostrar el panel correspondiente y ocultar los demás
    Private Sub ShowPanel(selectedPanel As Panel)
        ' Oculta todos los paneles primero
        PanelInventario.Visible = False
        ' PanelSolicitud.Visible = False
        ' PanelGarantia.Visible = False
        ' PanelVentas.Visible = False

        ' Muestra el panel seleccionado
        selectedPanel.Visible = True
    End Sub

    Private Sub InventarioDeRepuestosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InventarioDeRepuestosToolStripMenuItem.Click
        ShowPanel(PanelInventario)
    End Sub
End Class
