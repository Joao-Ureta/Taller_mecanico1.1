Imports MySql.Data.MySqlClient

Public Class Form4

    Dim connectionString As String = "Server=localhost;Database=taller;User ID=root;Password=Maju2223;SslMode=None;AllowPublicKeyRetrieval=True;"
    Private connection As MySqlConnection

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

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click

        Dim criterio As String = txtDescripcion.Text

        If criterio = "" Then
            MessageBox.Show("Por favor, ingrese un ID o descripción.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        Using conn As New MySqlConnection(connectionString)
            Try
                conn.Open()

                Dim query As String
                If IsNumeric(criterio) Then
                    query = "SELECT * FROM repuestos WHERE RepuestoID = @criterio"
                Else
                    query = "SELECT * FROM repuestos WHERE NombreRepuesto LIKE @criterio"
                End If

                Using cmd As New MySqlCommand(query, conn)
                    If IsNumeric(criterio) Then
                        cmd.Parameters.AddWithValue("@criterio", criterio)
                    Else
                        cmd.Parameters.AddWithValue("@criterio", criterio & "%")
                    End If

                    Dim adapter As New MySqlDataAdapter(cmd)
                    Dim table As New DataTable()
                    adapter.Fill(table)

                    If table.Rows.Count > 0 Then
                        DataGridView1.Columns.Clear()

                        ' Genera columnas automáticamente
                        DataGridView1.AutoGenerateColumns = True

                        ' Asigna el DataSource y refresca
                        DataGridView1.DataSource = table

                        ' Ajusta el tamaño del DataGridView1 para que ocupe todo el espacio disponible
                        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
                        DataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
                        DataGridView1.Refresh()

                    Else
                        MessageBox.Show("Repuesto no encontrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End Using
            Catch ex As Exception
                MessageBox.Show("Error al conectar con la base de datos: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub

    Private Sub btnVisualizar_Click(sender As Object, e As EventArgs) Handles btnVisualizar.Click

        Using conn As New MySqlConnection(connectionString)
            Try
                conn.Open()
                'consulta para seleccionar todos los registros de la tabla usuarios
                Dim query As String = "SELECT * FROM repuestos"

                Using cmd As New MySqlCommand(query, conn)
                    Dim adapter As New MySqlDataAdapter(cmd)
                    Dim table As New DataTable()
                    adapter.Fill(table)

                    If table.Rows.Count > 0 Then
                        MessageBox.Show("Total de repuestos encontrados: " & table.Rows.Count.ToString())

                        'borra las columnas anterioressi existen
                        DataGridView1.Columns.Clear()

                        'genera columnas automaticamente
                        DataGridView1.AutoGenerateColumns = True

                        'asigna el DataSource con todos los registros y refresca
                        DataGridView1.DataSource = table

                        'ajusta el tamaño del DataGridView1
                        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
                        DataGridView1.Refresh()

                    Else
                        MessageBox.Show("No hay repuestos registrados en la base de datos.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                End Using
            Catch ex As Exception
                MessageBox.Show("Error al conectar con la base de datos: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub
End Class
