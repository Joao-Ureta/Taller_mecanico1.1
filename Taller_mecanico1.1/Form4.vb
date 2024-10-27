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

    Private Sub CheckIngresar_CheckedChanged(sender As Object, e As EventArgs) Handles CheckIngresar.CheckedChanged

        'habilita los campos y el boton guardar al marcar checkIngresar

        txtRepuesto.Enabled = CheckIngresar.Checked
        txtCantidad.Enabled = CheckIngresar.Checked
        txtPrecio.Enabled = CheckIngresar.Checked
        txtProvedor.Enabled = CheckIngresar.Checked
        btnGuardar.Enabled = CheckIngresar.Checked

    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click

        'verifica que todos los campos esten llenos
        If String.IsNullOrWhiteSpace(txtRepuesto.Text) OrElse
           String.IsNullOrWhiteSpace(txtCantidad.Text) OrElse
           String.IsNullOrWhiteSpace(txtPrecio.Text) OrElse
           String.IsNullOrWhiteSpace(txtProvedor.Text) Then
            MessageBox.Show("Por favor, complete todos los campos antes de guardar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        'muestra mensaje de confirmación
        Dim result As DialogResult = MessageBox.Show("¿Está seguro que los datos de ingreso son correctos?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        'si el usuario confirma, se guardan los datos
        If result = DialogResult.Yes Then
            Try
                Using connection As New MySqlConnection(connectionString)
                    connection.Open()
                    Dim query As String = "INSERT INTO repuestos (NombreRepuesto, CantidadStock, PrecioUnitario, Proveedor) VALUES (@NombreRepuesto, @CantidadStock, @PrecioUnitario, @Proveedor)"

                    Using command As New MySqlCommand(query, connection)
                        'se convierten los valores de texto a los tipos de datos integer y decimal
                        Dim cantidadStock As Integer = Convert.ToInt32(txtCantidad.Text)
                        Dim precioUnitario As Decimal = Convert.ToDecimal(txtPrecio.Text)

                        'agrega los parametros a la consulta
                        command.Parameters.AddWithValue("@NombreRepuesto", txtRepuesto.Text)
                        command.Parameters.AddWithValue("@CantidadStock", cantidadStock)
                        command.Parameters.AddWithValue("@PrecioUnitario", precioUnitario)
                        command.Parameters.AddWithValue("@Proveedor", txtProvedor.Text)

                        command.ExecuteNonQuery()

                        'obtener el ID autoincremental recien insertado
                        Dim lastInsertedId As Integer = Convert.ToInt32(command.LastInsertedId)

                        'actualiza el DataGridView
                        btnVisualizar_Click(sender, e) 'llama a la funcion que actualiza el DataGridView

                        'selecciona la fila con el nuevo ID generado
                        For Each row As DataGridViewRow In DataGridView1.Rows
                            If Convert.ToInt32(row.Cells("RepuestoID").Value) = lastInsertedId Then
                                row.Selected = True
                                DataGridView1.FirstDisplayedScrollingRowIndex = row.Index ' Desplazar el DataGridView hasta el ítem seleccionado
                                Exit For
                            End If
                        Next
                    End Using
                End Using

                MessageBox.Show("Datos guardados exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)

                'limpia los campos despues de guardado exitoso
                txtID.Clear()
                txtRepuesto.Clear()
                txtCantidad.Clear()
                txtPrecio.Clear()
                txtProvedor.Clear()

            Catch ex As Exception
                MessageBox.Show("Error al guardar los datos: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub CheckModificar_CheckedChanged(sender As Object, e As EventArgs) Handles CheckModificar.CheckedChanged

        'habilita los campos y el boton modificar al marcar checkModificar
        If CheckModificar.Checked Then
            btnModificar.Enabled = True
            txtRepuesto.Enabled = True
            txtCantidad.Enabled = True
            txtPrecio.Enabled = True
            txtProvedor.Enabled = True
        Else
            btnModificar.Enabled = False
            txtRepuesto.Enabled = False
            txtCantidad.Enabled = False
            txtPrecio.Enabled = False
            txtProvedor.Enabled = False
        End If
    End Sub

    'se carga los datos seleccionados en el DataGridView a los campos de texto y ComboBox
    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        'verifica si el CheckModificar o el CheckEliminar estan activados
        If CheckModificar.Checked OrElse CheckEliminar.Checked Then
            If e.RowIndex >= 0 Then
                'obtiene la fila seleccionada
                Dim row As DataGridViewRow = DataGridView1.Rows(e.RowIndex)

                'carga los datos en los textBox
                txtID.Text = row.Cells("RepuestoID").Value.ToString()
                txtRepuesto.Text = row.Cells("NombreRepuesto").Value.ToString()
                txtCantidad.Text = row.Cells("CantidadStock").Value.ToString()
                txtPrecio.Text = row.Cells("PrecioUnitario").Value.ToString()
                txtProvedor.Text = row.Cells("Proveedor").Value.ToString()
            End If
        End If
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click

        'verifica que todos los campos esten llenos
        If String.IsNullOrWhiteSpace(txtID.Text) OrElse
       String.IsNullOrWhiteSpace(txtRepuesto.Text) OrElse
       String.IsNullOrWhiteSpace(txtCantidad.Text) OrElse
       String.IsNullOrWhiteSpace(txtPrecio.Text) OrElse
       String.IsNullOrWhiteSpace(txtProvedor.Text) Then
            MessageBox.Show("Por favor, complete todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        'muestra mensaje de confirmacion
        Dim result As DialogResult = MessageBox.Show("¿Está seguro que desea modificar este repuesto?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        'si el usuario confirma, se modifican los datos
        If result = DialogResult.Yes Then
            Try
                Using connection As New MySqlConnection(connectionString)
                    connection.Open()
                    'consulta SQL para modificar el registro en la tabla repuestos
                    Dim query As String = "UPDATE repuestos SET NombreRepuesto = @NombreRepuesto, CantidadStock = @CantidadStock, PrecioUnitario = @PrecioUnitario, Proveedor = @Proveedor WHERE RepuestoID = @RepuestoID"
                    Using command As New MySqlCommand(query, connection)
                        'se asignan los parametros con los valores de los TextBox
                        command.Parameters.AddWithValue("@RepuestoID", txtID.Text)
                        command.Parameters.AddWithValue("@NombreRepuesto", txtRepuesto.Text)
                        command.Parameters.AddWithValue("@CantidadStock", txtCantidad.Text)
                        command.Parameters.AddWithValue("@PrecioUnitario", txtPrecio.Text)
                        command.Parameters.AddWithValue("@Proveedor", txtProvedor.Text)
                        command.ExecuteNonQuery()
                    End Using
                End Using

                MessageBox.Show("Repuesto modificado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)

                'se actualiza el DataGridView
                btnVisualizar_Click(sender, e) ' Llama a la función que refresca el DataGridView

                'busca el registro modificado en el DataGridView en base al ID 
                For Each row As DataGridViewRow In DataGridView1.Rows
                    If row.Cells("RepuestoID").Value.ToString() = txtID.Text Then
                        row.Selected = True
                        DataGridView1.FirstDisplayedScrollingRowIndex = row.Index 'se posiciona en el ítem seleccionado
                        Exit For
                    End If
                Next

                'limpia los campos despues de la modificacion
                txtID.Clear()
                txtRepuesto.Clear()
                txtCantidad.Clear()
                txtPrecio.Clear()
                txtProvedor.Clear()

            Catch ex As Exception
                MessageBox.Show("Error al modificar los datos: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub CheckEliminar_CheckedChanged(sender As Object, e As EventArgs) Handles CheckEliminar.CheckedChanged

        'habilita el boton guardar al marcar checkEliminar
        If CheckEliminar.Checked Then
            btnEliminar.Enabled = True
        Else
            btnEliminar.Enabled = False
        End If
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click

        'verifica si se ha seleccionado un id para eliminar
        If String.IsNullOrWhiteSpace(txtID.Text) Then
            MessageBox.Show("Por favor, seleccione un registro para eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        'muestra un mensaje de confirmacion antes de eliminar
        Dim result As DialogResult = MessageBox.Show("¿Está seguro de que desea eliminar el repuesto con ID " & txtID.Text & "?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            Using conn As New MySqlConnection(connectionString)
                Try
                    conn.Open()
                    'consulta para eliminar el repuesto
                    Dim query As String = "DELETE FROM repuestos WHERE RepuestoID = @RepuestoID"
                    Using cmd As New MySqlCommand(query, conn)
                        cmd.Parameters.AddWithValue("@RepuestoID", txtID.Text)

                        Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
                        If rowsAffected > 0 Then
                            MessageBox.Show("Repuesto eliminado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)

                            'limpia los campos de texto despues de eliminar
                            txtID.Clear()
                            txtRepuesto.Clear()
                            txtCantidad.Clear()
                            txtPrecio.Clear()
                            txtProvedor.Clear()


                            'se actualiza el DataGridView despues de la eliminacion
                            btnVisualizar_Click(sender, e) 'llama a la funcion que refresca la lista de repuestos
                        Else
                            MessageBox.Show("No se pudo eliminar el repuesto. Verifique que el ID exista en la base de datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If
                    End Using
                Catch ex As Exception
                    MessageBox.Show("Error al eliminar el repuesto: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End Using
        End If
    End Sub
End Class
