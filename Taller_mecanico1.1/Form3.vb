Imports MySql.Data.MySqlClient

Public Class Form3

    Dim connectionString As String = "Server=localhost;Database=taller;User ID=root;Password=Maju2223;SslMode=None;AllowPublicKeyRetrieval=True;"
    Private connection As MySqlConnection

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try
            'instancia de conexion
            connection = New MySqlConnection(connectionString)

            connection.Open()

            'funcion para cargar tipo (rol)
            CargarTipo()

        Catch ex As MySqlException
            'en caso de falla de conexion muestra mensaje de error
            MessageBox.Show("Error al conectar a la base de datos: " & ex.Message)
        Finally
            If connection IsNot Nothing Then connection.Close()
        End Try
    End Sub

    Private Sub CargarTipo()
        Try
            'consulta para obtener los tipos de la base de datos
            Dim query As String = "SELECT Tipo FROM usuarios"
            Dim command As New MySqlCommand(query, connection)

            'ejecuta y lee la consulta
            Dim reader As MySqlDataReader = command.ExecuteReader()

            'limpia el combobox
            cbxTipo.Items.Clear()

            'agregar "Seleccione un rol de usuario"
            cbxTipo.Items.Add("Seleccione un rol de usuario")

            'agrega los tipos al combobox
            While reader.Read()
                cbxTipo.Items.Add(reader("Tipo").ToString())
            End While

            reader.Close()

            'para dejar como primer campo "Seleccione un rol de usuario"
            cbxTipo.SelectedIndex = 0

        Catch ex As MySqlException
            'mensaje para mostrar error en caso de consulta fallida
            MessageBox.Show("Error en la consulta: " & ex.Message)
        End Try
    End Sub


    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click

        'codigo para volver a form2 (menu)
        Form2.Show()
        Me.Close()

    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click

        Dim rut As String = txtRut.Text

        If rut = "" Then
            MessageBox.Show("Por favor, ingrese un RUT.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        Using conn As New MySqlConnection(connectionString)
            Try
                conn.Open()
                Dim query As String = "SELECT * FROM usuarios WHERE rut = @rut"

                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@rut", rut)

                    Dim adapter As New MySqlDataAdapter(cmd)
                    Dim table As New DataTable()
                    adapter.Fill(table)

                    If table.Rows.Count > 0 Then
                        MessageBox.Show("Datos encontrados: " & table.Rows.Count.ToString())

                        'borra las columnas anteriores si existen
                        DataGridView1.Columns.Clear()

                        'genera columnas automaticamente
                        DataGridView1.AutoGenerateColumns = True

                        'asigna el DataSource y refresca
                        DataGridView1.DataSource = table

                        'ajusta el tamaño del DataGridView1
                        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
                        DataGridView1.Refresh()

                    Else
                        MessageBox.Show("Usuario no encontrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
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
                Dim query As String = "SELECT * FROM usuarios"

                Using cmd As New MySqlCommand(query, conn)
                    Dim adapter As New MySqlDataAdapter(cmd)
                    Dim table As New DataTable()
                    adapter.Fill(table)

                    If table.Rows.Count > 0 Then
                        MessageBox.Show("Total de usuarios encontrados: " & table.Rows.Count.ToString())

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
                        MessageBox.Show("No hay usuarios registrados en la base de datos.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                End Using
            Catch ex As Exception
                MessageBox.Show("Error al conectar con la base de datos: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub

    Private Sub CheckIngresar_CheckedChanged(sender As Object, e As EventArgs) Handles CheckIngresar.CheckedChanged

        'habilita los campos y el boton guardar al marcar checkIngresar
        txtRutDos.Enabled = CheckIngresar.Checked
        txtCorreo.Enabled = CheckIngresar.Checked
        txtContraseña.Enabled = CheckIngresar.Checked
        cbxTipo.Enabled = CheckIngresar.Checked
        btnGuardar.Enabled = CheckIngresar.Checked

    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click

        'verificar que todos los campos esten llenos y que se haya seleccionado un tipo
        If String.IsNullOrWhiteSpace(txtRutDos.Text) OrElse
       String.IsNullOrWhiteSpace(txtCorreo.Text) OrElse
       String.IsNullOrWhiteSpace(txtContraseña.Text) OrElse
       cbxTipo.SelectedIndex = -1 OrElse
       cbxTipo.SelectedItem.ToString() = "Seleccione un rol de usuario" Then ' Asegúrate de que no sea la opción predeterminada
            MessageBox.Show("Por favor, complete todos los campos y seleccione un rol de usuario válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        'muestra mensaje de confirmacion
        Dim result As DialogResult = MessageBox.Show("¿Está seguro que los datos de ingreso son correctos?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        'si usuario confirma, se guardan los datos
        If result = DialogResult.Yes Then
            'guardar datos en la base de datos
            Try
                Using connection As New MySqlConnection(connectionString)
                    connection.Open()
                    Dim query As String = "INSERT INTO usuarios (rut, correo, contraseña, tipo) VALUES (@rut, @correo, @contraseña, @tipo)"
                    Using command As New MySqlCommand(query, connection)
                        command.Parameters.AddWithValue("@rut", txtRutDos.Text)
                        command.Parameters.AddWithValue("@correo", txtCorreo.Text)
                        command.Parameters.AddWithValue("@contraseña", txtContraseña.Text)
                        command.Parameters.AddWithValue("@tipo", cbxTipo.SelectedItem.ToString())
                        command.ExecuteNonQuery()
                    End Using
                End Using
                MessageBox.Show("Datos guardados exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                'limpiar los campos despues de guardado exitoso
                txtRutDos.Clear()
                txtCorreo.Clear()
                txtContraseña.Clear()
                cbxTipo.SelectedIndex = -1 'restablece el comboBox a su estado inicial
            Catch ex As Exception
                MessageBox.Show("Error al guardar los datos: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    'se carga los datos seleccionados en el DataGridView a los campos de texto y ComboBox
    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        'verifica si el CheckModificar o el CheckEliminar estan activados
        If CheckModificar.Checked OrElse CheckEliminar.Checked Then
            If e.RowIndex >= 0 Then
                'obtiene la fila seleccionada
                Dim row As DataGridViewRow = DataGridView1.Rows(e.RowIndex)

                'carga los datos en los textBox y comboBox
                txtRutDos.Text = row.Cells("rut").Value.ToString()
                txtCorreo.Text = row.Cells("correo").Value.ToString()
                txtContraseña.Text = row.Cells("contraseña").Value.ToString()
                cbxTipo.SelectedItem = row.Cells("tipo").Value.ToString()
            End If
        End If
    End Sub

    Private Sub CheckModificar_CheckedChanged(sender As Object, e As EventArgs) Handles CheckModificar.CheckedChanged

        'habilita los campos y el boton guardar al marcar checkModificar
        If CheckModificar.Checked Then
            btnModificar.Enabled = True
            txtCorreo.Enabled = True
            txtContraseña.Enabled = True
            cbxTipo.Enabled = True
        Else
            btnModificar.Enabled = False
            txtCorreo.Enabled = False
            txtContraseña.Enabled = False
            cbxTipo.Enabled = False
        End If
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click

        If String.IsNullOrWhiteSpace(txtCorreo.Text) OrElse
       String.IsNullOrWhiteSpace(txtContraseña.Text) OrElse
       cbxTipo.SelectedIndex = 0 Then 'se verifica que no sea la opcion predeterminada
            Return
        End If

        'muestra mensaje de confirmacion
        Dim result As DialogResult = MessageBox.Show("¿Está seguro de que desea modificar los datos de ingreso?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        'si usuario confirma, se guardan los datos
        If result = DialogResult.Yes Then
            Using conn As New MySqlConnection(connectionString)
                Try
                    conn.Open()
                    Dim query As String = "UPDATE usuarios SET correo = @correo, contraseña = @contraseña, tipo = @tipo WHERE rut = @rut"
                    Using cmd As New MySqlCommand(query, conn)
                        cmd.Parameters.AddWithValue("@correo", txtCorreo.Text)
                        cmd.Parameters.AddWithValue("@contraseña", txtContraseña.Text)
                        cmd.Parameters.AddWithValue("@tipo", cbxTipo.SelectedItem.ToString())
                        cmd.Parameters.AddWithValue("@rut", txtRutDos.Text)

                        Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
                        If rowsAffected > 0 Then
                            MessageBox.Show("Datos actualizados exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)

                            'limpia los campos de texto y el comboBox despues de guardado exitoso
                            txtRutDos.Clear()
                            txtCorreo.Clear()
                            txtContraseña.Clear()
                            cbxTipo.SelectedIndex = -1
                        Else
                            MessageBox.Show("No se actualizaron datos, verifique que el RUT exista.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If
                    End Using
                Catch ex As Exception
                    MessageBox.Show("Error al actualizar los datos: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End Using
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

        'verifica si se ha seleccionado un rut para eliminar
        If String.IsNullOrWhiteSpace(txtRutDos.Text) Then
            MessageBox.Show("Por favor, seleccione un registro para eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        'muestra un mensaje de confirmacion antes de eliminar
        Dim result As DialogResult = MessageBox.Show("¿Está seguro de que desea eliminar el usuario con RUT " & txtRutDos.Text & "?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            Using conn As New MySqlConnection(connectionString)
                Try
                    conn.Open()
                    'consulta para eliminar el usuario
                    Dim query As String = "DELETE FROM usuarios WHERE rut = @rut"
                    Using cmd As New MySqlCommand(query, conn)
                        cmd.Parameters.AddWithValue("@rut", txtRutDos.Text)

                        Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
                        If rowsAffected > 0 Then
                            MessageBox.Show("Usuario eliminado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)

                            'limpia los campos de texto despues de eliminar
                            txtRutDos.Clear()
                            txtCorreo.Clear()
                            txtContraseña.Clear()
                            cbxTipo.SelectedIndex = -1

                            'se actualiza el DataGridView despues de la eliminacion
                            btnVisualizar_Click(sender, e) 'llama a la funcion que refresca la lista de usuarios
                        Else
                            MessageBox.Show("No se pudo eliminar el usuario. Verifique que el RUT sea correcto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If
                    End Using
                Catch ex As Exception
                    MessageBox.Show("Error al eliminar el usuario: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End Using
        End If
    End Sub
End Class