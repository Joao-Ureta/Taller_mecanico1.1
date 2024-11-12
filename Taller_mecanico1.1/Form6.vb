Imports MySql.Data.MySqlClient

Public Class Form6

    Dim connectionString As String = "Server=localhost;Database=taller;User ID=root;Password=Maju2223;SslMode=None;AllowPublicKeyRetrieval=True;"
    Private connection As MySqlConnection

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Dim criterio = txtCliente.Text

        If criterio = "" Then
            MessageBox.Show("Por favor, ingrese un rut o nombre de cliente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        Using conn As New MySqlConnection(connectionString)
            Try
                conn.Open()

                Dim query As String
                If IsNumeric(criterio) Then
                    query = "SELECT * FROM clientes WHERE Rut = @criterio"
                Else
                    query = "SELECT * FROM clientes WHERE Nombre LIKE @criterio"
                End If

                Using cmd As New MySqlCommand(query, conn)
                    If IsNumeric(criterio) Then
                        cmd.Parameters.AddWithValue("@criterio", criterio)
                    Else
                        cmd.Parameters.AddWithValue("@criterio", criterio & "%")
                    End If

                    Dim adapter As New MySqlDataAdapter(cmd)
                    Dim table As New DataTable
                    adapter.Fill(table)

                    If table.Rows.Count > 0 Then
                        DataGridView1.Columns.Clear()

                        'genera columnas automaticamente
                        DataGridView1.AutoGenerateColumns = True

                        'asigna el DataSource y refresca
                        DataGridView1.DataSource = table

                        'ajusta el tamaño del DataGridView1 para que ocupe todo el espacio disponible
                        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
                        DataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
                        DataGridView1.Refresh()

                    Else
                        MessageBox.Show("Cliente no encontrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End Using
            Catch ex As Exception
                MessageBox.Show("Error al conectar con la base de datos: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub

    Private Sub btnVerTodo_Click(sender As Object, e As EventArgs) Handles btnVerTodo.Click
        Using conn As New MySqlConnection(connectionString)
            Try
                conn.Open()
                'consulta para seleccionar todos los registros de la tabla usuarios
                Dim query = "SELECT * FROM clientes"

                Using cmd As New MySqlCommand(query, conn)
                    Dim adapter As New MySqlDataAdapter(cmd)
                    Dim table As New DataTable
                    adapter.Fill(table)

                    If table.Rows.Count > 0 Then
                        MessageBox.Show("Total de clientes encontrados: " & table.Rows.Count.ToString)

                        'borra las columnas anteriores si existen
                        DataGridView1.Columns.Clear()

                        'genera columnas automaticamente
                        DataGridView1.AutoGenerateColumns = True

                        'asigna el DataSource con todos los registros y refresca
                        DataGridView1.DataSource = table

                        'ajusta el tamaño del DataGridView1
                        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
                        DataGridView1.Refresh()

                    Else
                        MessageBox.Show("No hay clientes registrados en la base de datos.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                End Using
            Catch ex As Exception
                MessageBox.Show("Error al conectar con la base de datos: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub

    Private Sub chbxIngresar_CheckedChanged(sender As Object, e As EventArgs) Handles chbxIngresar.CheckedChanged
        'habilita los campos y el boton guardar al marcar checkIngresar

        txtRut.Enabled = chbxIngresar.Checked
        txtNombre.Enabled = chbxIngresar.Checked
        txtApellidoP.Enabled = chbxIngresar.Checked
        txtApellidoM.Enabled = chbxIngresar.Checked
        txtDireccion.Enabled = chbxIngresar.Checked
        txtTelefono.Enabled = chbxIngresar.Checked
        txtComuna.Enabled = chbxIngresar.Checked
        btnGuardar.Enabled = chbxIngresar.Checked
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        'verifica que todos los campos estén llenos
        If String.IsNullOrWhiteSpace(txtRut.Text) OrElse
       String.IsNullOrWhiteSpace(txtNombre.Text) OrElse
       String.IsNullOrWhiteSpace(txtApellidoP.Text) OrElse
       String.IsNullOrWhiteSpace(txtApellidoM.Text) OrElse
       String.IsNullOrWhiteSpace(txtDireccion.Text) OrElse
       String.IsNullOrWhiteSpace(txtTelefono.Text) OrElse
       String.IsNullOrWhiteSpace(txtComuna.Text) Then
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
                    Dim query As String = "INSERT INTO clientes (Rut, Nombre, ApellidoP, ApellidoM, Direccion, Telefono, Comuna) VALUES (@Rut, @Nombre, @ApellidoP, @ApellidoM, @Direccion, @Telefono, @Comuna)"

                    Using command As New MySqlCommand(query, connection)

                        'agrega los parámetros a la consulta
                        command.Parameters.AddWithValue("@Rut", txtRut.Text)
                        command.Parameters.AddWithValue("@Nombre", txtNombre.Text)
                        command.Parameters.AddWithValue("@ApellidoP", txtApellidoP.Text)
                        command.Parameters.AddWithValue("@ApellidoM", txtApellidoM.Text)
                        command.Parameters.AddWithValue("@Direccion", txtDireccion.Text)
                        command.Parameters.AddWithValue("@Telefono", txtTelefono.Text)
                        command.Parameters.AddWithValue("@Comuna", txtComuna.Text)

                        command.ExecuteNonQuery()

                        ' Actualiza el DataGridView1
                        btnVerTodo_Click(sender, e) ' Llama a la función que actualiza el DataGridView1

                        ' Selecciona la fila con el nuevo Rut ingresado
                        For Each row As DataGridViewRow In DataGridView1.Rows
                            ' Compara Rut como cadena
                            If row.Cells("Rut").Value.ToString() = txtRut.Text Then
                                row.Selected = True
                                DataGridView1.FirstDisplayedScrollingRowIndex = row.Index ' Desplaza el DataGridView1 hasta el ítem seleccionado
                                Exit For
                            End If
                        Next

                    End Using
                End Using

                MessageBox.Show("Datos guardados exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)

                'limpia los campos después de guardado exitoso
                txtRut.Clear()
                txtNombre.Clear()
                txtApellidoP.Clear()
                txtApellidoM.Clear()
                txtDireccion.Clear()
                txtTelefono.Clear()
                txtComuna.Clear()

            Catch ex As Exception
                MessageBox.Show("Error al guardar los datos: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub chbxModificar_CheckedChanged(sender As Object, e As EventArgs) Handles chbxModificar.CheckedChanged
        'habilita los campos y el boton modificar al marcar chbxModificar
        txtNombre.Enabled = chbxModificar.Checked
        txtApellidoP.Enabled = chbxModificar.Checked
        txtApellidoM.Enabled = chbxModificar.Checked
        txtDireccion.Enabled = chbxModificar.Checked
        txtTelefono.Enabled = chbxModificar.Checked
        txtComuna.Enabled = chbxModificar.Checked
        btnModificar.Enabled = chbxModificar.Checked
    End Sub

    'se carga los datos seleccionados en el DataGridView a los campos de texto y ComboBox
    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        ' Verifica si el CheckModificar o el CheckEliminar están activados
        If chbxModificar.Checked OrElse chbxEliminar.Checked Then
            If e.RowIndex >= 0 Then
                ' Obtiene la fila seleccionada
                Dim row As DataGridViewRow = DataGridView1.Rows(e.RowIndex)

                ' Carga los datos en los TextBox y ComboBox correspondientes

                ' Rut es la clave primaria y se carga en txtRut
                txtRut.Text = row.Cells("Rut").Value.ToString()

                ' Carga los datos en los demás TextBox
                txtNombre.Text = row.Cells("Nombre").Value.ToString()
                txtApellidoP.Text = row.Cells("ApellidoP").Value.ToString()
                txtApellidoM.Text = row.Cells("ApellidoM").Value.ToString()
                txtDireccion.Text = row.Cells("Direccion").Value.ToString()
                txtTelefono.Text = row.Cells("Telefono").Value.ToString()
                txtComuna.Text = row.Cells("Comuna").Value.ToString()
            End If
        End If
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        ' Verifica que el campo de Rut no esté vacío (Rut es la clave primaria)
        If String.IsNullOrWhiteSpace(txtRut.Text) Then
            MessageBox.Show("Por favor, seleccione un registro para modificar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Verifica que los demás campos no estén vacíos
        If String.IsNullOrWhiteSpace(txtNombre.Text) OrElse
           String.IsNullOrWhiteSpace(txtApellidoP.Text) OrElse
           String.IsNullOrWhiteSpace(txtApellidoM.Text) OrElse
           String.IsNullOrWhiteSpace(txtDireccion.Text) OrElse
           String.IsNullOrWhiteSpace(txtTelefono.Text) OrElse
           String.IsNullOrWhiteSpace(txtComuna.Text) Then
            MessageBox.Show("Por favor, complete todos los campos antes de modificar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Muestra mensaje de confirmación antes de modificar
        Dim result As DialogResult = MessageBox.Show("¿Está seguro que desea modificar los datos?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        ' Si el usuario confirma, se procede con la modificación
        If result = DialogResult.Yes Then
            Try
                Using connection As New MySqlConnection(connectionString)
                    connection.Open()

                    ' Consulta SQL para actualizar los datos en la base de datos
                    Dim query As String = "UPDATE clientes SET Nombre = @Nombre, ApellidoP = @ApellidoP, ApellidoM = @ApellidoM, Direccion = @Direccion, Telefono = @Telefono, Comuna = @Comuna WHERE Rut = @Rut"

                    Using command As New MySqlCommand(query, connection)
                        ' Agrega los parámetros con los valores de los campos de texto
                        command.Parameters.AddWithValue("@Rut", txtRut.Text)
                        command.Parameters.AddWithValue("@Nombre", txtNombre.Text)
                        command.Parameters.AddWithValue("@ApellidoP", txtApellidoP.Text)
                        command.Parameters.AddWithValue("@ApellidoM", txtApellidoM.Text)
                        command.Parameters.AddWithValue("@Direccion", txtDireccion.Text)
                        command.Parameters.AddWithValue("@Telefono", txtTelefono.Text)
                        command.Parameters.AddWithValue("@Comuna", txtComuna.Text)

                        ' Ejecuta la consulta de actualización
                        command.ExecuteNonQuery()
                    End Using
                End Using

                ' Mensaje de éxito
                MessageBox.Show("Datos modificados exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)

                ' Actualiza el DataGridView1 llamando a tu método de recarga
                btnVerTodo_Click(sender, e)

                ' Selecciona el ítem modificado en el DataGridView1
                For Each row As DataGridViewRow In DataGridView1.Rows
                    If row.Cells("Rut").Value.ToString() = txtRut.Text Then
                        DataGridView1.ClearSelection() ' Limpia cualquier selección previa
                        row.Selected = True             ' Selecciona la fila modificada
                        DataGridView1.FirstDisplayedScrollingRowIndex = row.Index ' Desplaza el DataGridView a la fila seleccionada
                        Exit For
                    End If
                Next

                ' Limpia los campos después de la modificación exitosa
                txtRut.Clear()
                txtNombre.Clear()
                txtApellidoP.Clear()
                txtApellidoM.Clear()
                txtDireccion.Clear()
                txtTelefono.Clear()
                txtComuna.Clear()

            Catch ex As Exception
                MessageBox.Show("Error al modificar los datos: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub chbxEliminar_CheckedChanged(sender As Object, e As EventArgs) Handles chbxEliminar.CheckedChanged
        'habilita el boton guardar al marcar checkEliminar
        If chbxEliminar.Checked Then
            btnEliminar.Enabled = True
        Else
            btnEliminar.Enabled = False
        End If
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        ' Verifica que el campo de Rut no esté vacío (Rut es la clave primaria)
        If String.IsNullOrWhiteSpace(txtRut.Text) Then
            MessageBox.Show("Por favor, seleccione un registro para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Muestra un mensaje de confirmación antes de eliminar
        Dim result As DialogResult = MessageBox.Show("¿Está seguro que desea eliminar este registro?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        ' Si el usuario confirma, se procede con la eliminación
        If result = DialogResult.Yes Then
            Try
                Using connection As New MySqlConnection(connectionString)
                    connection.Open()

                    ' Consulta SQL para eliminar el registro de la base de datos
                    Dim query As String = "DELETE FROM clientes WHERE Rut = @Rut"

                    Using command As New MySqlCommand(query, connection)
                        ' Agrega el parámetro Rut con el valor del campo de texto
                        command.Parameters.AddWithValue("@Rut", txtRut.Text)

                        ' Ejecuta la consulta de eliminación
                        command.ExecuteNonQuery()
                    End Using
                End Using

                ' Mensaje de éxito
                MessageBox.Show("Registro eliminado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)

                ' Actualiza el DataGridView1 llamando a tu método de recarga
                btnVerTodo_Click(sender, e)

                ' Limpia los campos de texto después de la eliminación exitosa
                txtRut.Clear()
                txtNombre.Clear()
                txtApellidoP.Clear()
                txtApellidoM.Clear()
                txtDireccion.Clear()
                txtTelefono.Clear()
                txtComuna.Clear()

                ' Deselect all rows in DataGridView1
                DataGridView1.ClearSelection()

            Catch ex As Exception
                MessageBox.Show("Error al eliminar el registro: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        ' Código para volver a Form2 (menú)
        Form2.Instance.Show()
        Me.Close()
    End Sub
End Class