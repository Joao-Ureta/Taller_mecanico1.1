Imports MySql.Data.MySqlClient

Public Class Form5
    ' Propiedad para almacenar el tipo de usuario

    Dim connectionString As String = "Server=localhost;Database=taller;User ID=root;Password=Maju2223;SslMode=None;AllowPublicKeyRetrieval=True;"
    Private connection As MySqlConnection

    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try
            'instancia de conexion
            connection = New MySqlConnection(connectionString)

            connection.Open()

            'funcion para cargar estado (siniestro)
            CargarEstado()
            CargarEstado2()
            CargarCompania()
            CargarSeguro()

        Catch ex As MySqlException
            'en caso de falla de conexion muestra mensaje de error
            MessageBox.Show("Error al conectar a la base de datos: " & ex.Message)
        Finally
            If connection IsNot Nothing Then connection.Close()
        End Try
    End Sub

    Private Sub CargarEstado()
        Try
            'consulta para obtener los tipos de la base de datos
            Dim query As String = "SELECT Estado_Siniestro FROM siniestro"
            Dim command As New MySqlCommand(query, connection)

            'ejecuta y lee la consulta
            Dim reader As MySqlDataReader = command.ExecuteReader()

            'limpia el combobox
            cbxEstado.Items.Clear()

            'agregar "Estado de siniestro" como primer ítem
            cbxEstado.Items.Add("Estado de siniestro")

            ' Crear un HashSet para evitar duplicados
            Dim estadosSet As New HashSet(Of String)

            'agrega los tipos al HashSet
            While reader.Read()
                Dim estado As String = reader("Estado_Siniestro").ToString()
                estadosSet.Add(estado) ' Añadir al HashSet (evita duplicados automáticamente)
            End While

            reader.Close()

            'agregar los elementos únicos del HashSet al ComboBox
            For Each estadoItem In estadosSet
                cbxEstado.Items.Add(estadoItem)
            Next

            'para dejar como primer campo "Seleccione un estado de siniestro"
            cbxEstado.SelectedIndex = 0

        Catch ex As MySqlException
            'mensaje para mostrar error en caso de consulta fallida
            MessageBox.Show("Error en la consulta: " & ex.Message)
        End Try
    End Sub

    Private Sub CargarEstado2()
        Try
            'consulta para obtener los tipos de la base de datos
            Dim query As String = "SELECT Estado_Siniestro FROM siniestro"
            Dim command As New MySqlCommand(query, connection)

            'ejecuta y lee la consulta
            Dim reader As MySqlDataReader = command.ExecuteReader()

            'limpia el combobox
            cbxEstado2.Items.Clear()

            'agregar "Estado de siniestro" como primer ítem
            cbxEstado2.Items.Add("Estado de siniestro")

            ' Crear un HashSet para evitar duplicados
            Dim estadosSet As New HashSet(Of String)

            'agrega los tipos al HashSet
            While reader.Read()
                Dim estado As String = reader("Estado_Siniestro").ToString()
                estadosSet.Add(estado) ' Añadir al HashSet (evita duplicados automáticamente)
            End While

            reader.Close()

            'agregar los elementos únicos del HashSet al ComboBox
            For Each estadoItem In estadosSet
                cbxEstado2.Items.Add(estadoItem)
            Next

            'para dejar como primer campo "Seleccione un estado de siniestro"
            cbxEstado2.SelectedIndex = 0

        Catch ex As MySqlException
            'mensaje para mostrar error en caso de consulta fallida
            MessageBox.Show("Error en la consulta: " & ex.Message)
        End Try
    End Sub

    Private Sub CargarCompania()
        Try
            'consulta para obtener el Rut y Descripcion de la base de datos
            Dim query As String = "SELECT Rut, Descripcion FROM compania"
            Dim command As New MySqlCommand(query, connection)

            'ejecuta y lee la consulta
            Dim reader As MySqlDataReader = command.ExecuteReader()

            'limpia el combobox
            cbxCompañia.Items.Clear()

            'agregar "Seleccione una compañia" como primer ítem
            cbxCompañia.Items.Add("Seleccione una compañia")

            ' Crear una lista para almacenar los KeyValuePair (Rut, Descripcion)
            Dim companias As New List(Of KeyValuePair(Of String, String))

            'agregar los Rut y Descripcion al List
            While reader.Read()
                Dim rut As String = reader("Rut").ToString()
                Dim descripcion As String = reader("Descripcion").ToString()
                companias.Add(New KeyValuePair(Of String, String)(rut, descripcion))
            End While

            reader.Close()

            'agregar los elementos de la lista al ComboBox
            For Each compania In companias
                ' Mostramos la Descripcion, pero almacenamos el Rut
                cbxCompañia.Items.Add(compania.Value)
            Next

            ' Dejar como primer ítem seleccionado "Seleccione una compañia"
            cbxCompañia.SelectedIndex = 0

        Catch ex As MySqlException
            'mensaje para mostrar error en caso de consulta fallida
            MessageBox.Show("Error en la consulta: " & ex.Message)
        End Try
    End Sub


    Private Sub CargarSeguro()
        Try
            'consulta para obtener los tipos de seguro de la base de datos
            Dim query As String = "SELECT Estado_Seguro FROM siniestro"
            Dim command As New MySqlCommand(query, connection)

            'ejecuta y lee la consulta
            Dim reader As MySqlDataReader = command.ExecuteReader()

            'limpia el ComboBox
            cbxSeguro.Items.Clear()

            'agregar "Estado de seguro" como primer ítem
            cbxSeguro.Items.Add("Estado de seguro")

            'agregar opciones fijas
            cbxSeguro.Items.Add("Seguro Vigente")
            cbxSeguro.Items.Add("Seguro Vencido")

            ' Crear un HashSet para evitar duplicados
            Dim seguroSet As New HashSet(Of String)

            'agrega los tipos al HashSet
            While reader.Read()
                Dim seguro As String = reader("Estado_Seguro").ToString()
                seguroSet.Add(seguro) ' Añadir al HashSet (evita duplicados automáticamente)
            End While

            reader.Close()

            'agregar los elementos únicos del HashSet al ComboBox, evitando duplicados
            For Each seguroItem In seguroSet
                ' Verificar que no sea "Seguro Vigente" o "Seguro Vencido" para evitar duplicados
                If seguroItem <> "Seguro Vigente" AndAlso seguroItem <> "Seguro Vencido" Then
                    cbxSeguro.Items.Add(seguroItem)
                End If
            Next

            'para dejar como primer campo "Estado de seguro"
            cbxSeguro.SelectedIndex = 0

        Catch ex As MySqlException
            'mensaje para mostrar error en caso de consulta fallida
            MessageBox.Show("Error en la consulta: " & ex.Message)
        End Try
    End Sub


    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        ' Código para volver a Form2 (menú)
        Form2.Instance.Show()
        Me.Close()
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Dim rut As String = txtCliente.Text

        If rut = "" Then
            MessageBox.Show("Por favor, ingrese un RUT.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        Try
            connection.Open()
            Dim query As String = "SELECT * FROM siniestro WHERE Rut = @Rut"

            Using cmd As New MySqlCommand(query, connection)
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
                    MessageBox.Show("Rut no encontrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al conectar con la base de datos: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub cbxEstado_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxEstado.SelectedIndexChanged
        ' Obtener el estado seleccionado del ComboBox
        Dim estadoSeleccionado As String = cbxEstado.SelectedItem.ToString()

        ' Evitar la búsqueda si el primer ítem es seleccionado ("Estado de siniestro")
        If estadoSeleccionado = "Estado de siniestro" Then
            Return ' No hacer nada si el primer ítem es seleccionado
        End If

        ' Consulta SQL para buscar siniestros relacionados con el estado seleccionado
        Dim query As String = "SELECT * FROM siniestro WHERE Estado_Siniestro = @Estado"

        Try
            ' Asegurarse de que la conexión esté cerrada antes de abrirla
            If connection.State = ConnectionState.Closed Then
                connection.Open()
            End If

            ' Crear el comando SQL
            Dim cmd As New MySqlCommand(query, connection)
            cmd.Parameters.AddWithValue("@Estado", estadoSeleccionado)

            ' Ejecutar la consulta y llenar el DataGridView
            Dim adapter As New MySqlDataAdapter(cmd)
            Dim table As New DataTable()
            adapter.Fill(table)

            ' Verificar si se obtuvieron registros
            If table.Rows.Count > 0 Then
                ' Mostrar los resultados en el DataGridView
                DataGridView1.Columns.Clear()  ' Limpiar las columnas anteriores
                DataGridView1.DataSource = table  ' Asignar la nueva tabla
                DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill ' Ajustar tamaño de columnas

                ' Opcional: Mostrar la cantidad de filas encontradas en un MessageBox
                MessageBox.Show("Cantidad de filas encontradas: " & table.Rows.Count.ToString(), "Resultados", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                ' No se encontraron registros
                MessageBox.Show("No se encontraron siniestros para el estado seleccionado.", "Sin Resultados", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

        Catch ex As MySqlException
            ' Mostrar error en caso de que ocurra una excepción al realizar la consulta
            MessageBox.Show("Error al realizar la búsqueda: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            ' Asegurarse de cerrar la conexión
            If connection IsNot Nothing AndAlso connection.State = ConnectionState.Open Then
                connection.Close()
            End If
        End Try
    End Sub

    ' Ver todos los registros
    Private Sub btnVerTodo_Click(sender As Object, e As EventArgs) Handles btnVerTodo.Click
        Try
            Using connection As New MySqlConnection(connectionString)
                connection.Open()
                Dim query As String = "SELECT * FROM siniestro"
                Using cmd As New MySqlCommand(query, connection)
                    Dim adapter As New MySqlDataAdapter(cmd)
                    Dim table As New DataTable()
                    adapter.Fill(table)

                    If table.Rows.Count > 0 Then
                        MessageBox.Show("Total de siniestros encontrados: " & table.Rows.Count.ToString())
                        DataGridView1.Columns.Clear()
                        DataGridView1.DataSource = table
                        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
                    Else
                        MessageBox.Show("No hay siniestros registrados.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                End Using
            End Using
        Catch ex As MySqlException
            MessageBox.Show("Error al cargar datos: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub chbxIngresar_CheckedChanged(sender As Object, e As EventArgs) Handles chbxIngresar.CheckedChanged
        'habilita los campos y el boton guardar al marcar chbxIngresar
        txtDetalle.Enabled = chbxIngresar.Checked
        cbxEstado2.Enabled = chbxIngresar.Checked
        FecSiniestro.Enabled = chbxIngresar.Checked
        cbxCompañia.Enabled = chbxIngresar.Checked
        txtCliente2.Enabled = chbxIngresar.Checked
        cbxSeguro.Enabled = chbxIngresar.Checked
        btnGuardar.Enabled = chbxIngresar.Checked
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        ' Verificar que todos los campos necesarios estén completos
        If String.IsNullOrWhiteSpace(txtDetalle.Text) Or
   String.IsNullOrWhiteSpace(cbxEstado2.SelectedItem?.ToString()) Or
   FecSiniestro.Value = DateTimePicker.MinimumDateTime OrElse
   String.IsNullOrWhiteSpace(txtCliente2.Text) Or
   String.IsNullOrWhiteSpace(cbxCompañia.SelectedItem?.ToString()) Or
   String.IsNullOrWhiteSpace(cbxSeguro.SelectedItem?.ToString()) Then
            MessageBox.Show("Por favor, complete todos los campos.", "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Verificar si el Rut ingresado existe en la base de datos
        Dim rut As String = txtCliente2.Text.Trim()
        If Not RutExiste(rut) Then
            Dim result As DialogResult = MessageBox.Show("El cliente con este Rut no existe. ¿Desea agregarlo?", "Cliente no encontrado", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If result = DialogResult.Yes Then
                ' Abrir el Form6 para agregar el nuevo cliente
                Dim gestionClientesForm As New Form6()
                gestionClientesForm.Show()
            End If
            Return
        End If

        ' Proceder con la inserción de datos en la base de datos si el Rut existe
        Try
            Using connection As New MySqlConnection(connectionString)
                connection.Open()

                ' Obtener el RutCompania desde la lista de compañias basado en la descripción seleccionada
                Dim rutCompania As String = ObtenerRutCompania(cbxCompañia.SelectedItem.ToString(), connection)

                ' Verificar si se obtuvo un RutCompania válido
                If String.IsNullOrEmpty(rutCompania) Then
                    MessageBox.Show("No se pudo encontrar la compañía seleccionada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return
                End If

                ' Insertar los datos en la tabla Siniestro
                Dim query As String = "INSERT INTO Siniestro (Detalle, Estado_Siniestro, Fecha_Siniestro, RutCompania, Rut, Estado_Seguro) " &
                                  "VALUES (@Detalle, @Estado_Siniestro, @Fecha_Siniestro, @RutCompania, @Rut, @Estado_Seguro)"
                Using command As New MySqlCommand(query, connection)
                    command.Parameters.AddWithValue("@Detalle", If(String.IsNullOrWhiteSpace(txtDetalle.Text), DBNull.Value, txtDetalle.Text.Trim()))
                    command.Parameters.AddWithValue("@Estado_Siniestro", If(String.IsNullOrWhiteSpace(cbxEstado2.SelectedItem?.ToString()), DBNull.Value, cbxEstado2.SelectedItem.ToString()))
                    command.Parameters.AddWithValue("@Fecha_Siniestro", If(FecSiniestro.Value = DateTimePicker.MinimumDateTime, DBNull.Value, FecSiniestro.Value))
                    command.Parameters.AddWithValue("@RutCompania", rutCompania) ' Usamos el RutCompania obtenido
                    command.Parameters.AddWithValue("@Rut", If(String.IsNullOrWhiteSpace(txtCliente2.Text), DBNull.Value, txtCliente2.Text.Trim()))
                    command.Parameters.AddWithValue("@Estado_Seguro", If(String.IsNullOrWhiteSpace(cbxSeguro.SelectedItem?.ToString()), DBNull.Value, cbxSeguro.SelectedItem.ToString()))

                    ' Ejecuta la consulta y obtiene el número de filas afectadas
                    Dim rowsAffected As Integer = command.ExecuteNonQuery()

                    ' Obtener el ID autoincremental recién insertado
                    Dim lastInsertedId As Integer = Convert.ToInt32(command.LastInsertedId)

                    If rowsAffected > 0 Then
                        MessageBox.Show("Datos guardados correctamente.", "Guardado exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information)

                        ' Actualizar el DataGridView después de la inserción
                        btnVerTodo_Click(sender, e) ' Llama a la función que refresca la lista de usuarios

                        ' Seleccionar la fila con el nuevo ID generado
                        For Each row As DataGridViewRow In DataGridView1.Rows
                            If Convert.ToInt32(row.Cells("SiniestroID").Value) = lastInsertedId Then ' Asegúrate de cambiar "SiniestroID" por el nombre correcto de la columna
                                row.Selected = True
                                DataGridView1.FirstDisplayedScrollingRowIndex = row.Index ' Desplazar el DataGridView hasta el ítem seleccionado
                                Exit For
                            End If
                        Next

                        ' Limpiar los campos después de guardar exitosamente
                        txtID.Clear()
                        txtDetalle.Clear()
                        cbxEstado2.SelectedIndex = -1
                        FecSiniestro.Value = DateTime.Now
                        cbxCompañia.SelectedIndex = -1
                        txtCliente2.Clear()
                        cbxSeguro.SelectedIndex = -1

                    Else
                        MessageBox.Show("Hubo un error al guardar los datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al guardar los datos: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Método para obtener el RutCompania basado en la descripción de la compañía
    Private Function ObtenerRutCompania(descripcionCompania As String, connection As MySqlConnection) As String
        Try
            ' Consulta para obtener el Rut de la Compañía basada en la descripción
            Dim query As String = "SELECT Rut FROM Compania WHERE Descripcion = @Descripcion"
            Using command As New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@Descripcion", descripcionCompania)
                Dim result As Object = command.ExecuteScalar()
                If result IsNot Nothing Then
                    Return result.ToString() ' Devuelve el Rut de la compañía
                End If
            End Using
        Catch ex As MySqlException
            MessageBox.Show("Error al obtener el Rut de la compañía: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return String.Empty ' Si no se encuentra el Rut, devuelve vacío
    End Function

    ' Función para verificar si el Rut existe en la base de datos
    Private Function RutExiste(rut As String) As Boolean
        Try
            Using connection As New MySqlConnection(connectionString)
                connection.Open()
                ' Consulta para verificar si el Rut existe en la tabla clientes
                Dim query As String = "SELECT COUNT(*) FROM clientes WHERE Rut = @Rut"
                Using command As New MySqlCommand(query, connection)
                    command.Parameters.AddWithValue("@Rut", rut)
                    Dim count As Integer = Convert.ToInt32(command.ExecuteScalar())
                    Return count > 0
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al verificar el Rut: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Private Sub chbxModificar_CheckedChanged(sender As Object, e As EventArgs) Handles chbxModificar.CheckedChanged
        'habilita los campos y el boton modificar al marcar chbxIngresar

        cbxEstado2.Enabled = chbxModificar.Checked
        btnModificar.Enabled = chbxModificar.Checked
    End Sub

    ' Método para obtener el RutCompania basado en la descripción seleccionada
    Private Function ObtenerRutCompania(descripcionCompania As String) As String
        Try
            ' Consulta para obtener el Rut basado en la descripción de la compañía
            Using connection As New MySqlConnection(connectionString)
                connection.Open()
                Dim query As String = "SELECT Rut FROM Compania WHERE Descripcion = @DescripcionCompania"
                Using command As New MySqlCommand(query, connection)
                    command.Parameters.AddWithValue("@DescripcionCompania", descripcionCompania)
                    Dim rut As Object = command.ExecuteScalar()
                    If rut IsNot Nothing Then
                        Return rut.ToString()
                    End If
                End Using
            End Using
        Catch ex As MySqlException
            MessageBox.Show("Error al obtener el Rut de la compañía: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return String.Empty
    End Function

    ' Evento cuando la selección cambia en el DataGridView
    Private Sub DataGridView1_SelectionChanged(sender As Object, e As EventArgs) Handles DataGridView1.SelectionChanged
        If DataGridView1.SelectedRows.Count > 0 Then
            Dim selectedRow As DataGridViewRow = DataGridView1.SelectedRows(0)

            ' Asignar los valores de la fila seleccionada a los campos
            txtID.Text = selectedRow.Cells("SiniestroID").Value.ToString()
            txtDetalle.Text = selectedRow.Cells("Detalle").Value.ToString()
            cbxEstado2.SelectedItem = selectedRow.Cells("Estado_Siniestro").Value.ToString()
            FecSiniestro.Value = Convert.ToDateTime(selectedRow.Cells("Fecha_Siniestro").Value.ToString())
            txtCliente2.Text = selectedRow.Cells("Rut").Value.ToString()
            cbxSeguro.SelectedItem = selectedRow.Cells("Estado_Seguro").Value.ToString()

            ' Convertir el Rut de la compañía a su descripción en el ComboBox
            Dim rutCompania As String = selectedRow.Cells("RutCompania").Value.ToString()
            cbxCompañia.SelectedItem = ObtenerDescripcionCompania(rutCompania)
        End If
    End Sub

    ' Método para obtener la descripción de la compañía basado en su Rut
    Private Function ObtenerDescripcionCompania(rutCompania As String) As String
        Try
            ' Consulta para obtener la descripción de la Compañía basada en su Rut
            Using connection As New MySqlConnection(connectionString)
                connection.Open()
                Dim query As String = "SELECT Descripcion FROM Compania WHERE Rut = @RutCompania"
                Using command As New MySqlCommand(query, connection)
                    command.Parameters.AddWithValue("@RutCompania", rutCompania)
                    Dim descripcion As Object = command.ExecuteScalar()
                    If descripcion IsNot Nothing Then
                        Return descripcion.ToString()
                    End If
                End Using
            End Using
        Catch ex As MySqlException
            MessageBox.Show("Error al obtener la descripción de la compañía: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return String.Empty
    End Function

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        ' Verificar si hay algo seleccionado en el DataGridView
        If DataGridView1.SelectedRows.Count = 0 Then
            ' Mostrar mensaje de error si no se seleccionó ninguna fila en el DataGridView
            MessageBox.Show("Debe seleccionar un item para modificar.", "Selección requerida", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return ' Salir del método si no hay selección
        End If

        ' Verificar si hay algo seleccionado en el ComboBox de Compañía
        If cbxCompañia.SelectedItem IsNot Nothing Then
            ' Obtener la descripción seleccionada en el ComboBox
            Dim descripcionCompania As String = cbxCompañia.SelectedItem.ToString()

            ' Obtener el RutCompania basado en la descripción seleccionada
            Dim rutCompania As String = ObtenerRutCompania(descripcionCompania)

            If Not String.IsNullOrEmpty(rutCompania) Then
                ' Obtener el ID del siniestro (asumiendo que txtID contiene el SiniestroID)
                Dim siniestroId As Integer = Convert.ToInt32(txtID.Text.Trim())

                Try
                    ' Realizar la actualización en la tabla Siniestros
                    Using connection As New MySqlConnection(connectionString)
                        connection.Open()
                        Dim query As String = "UPDATE Siniestro SET 
                                       Detalle = @Detalle, 
                                       Estado_Siniestro = @Estado_Siniestro, 
                                       Fecha_Siniestro = @Fecha_Siniestro, 
                                       RutCompania = @RutCompania, 
                                       Rut = @Rut, 
                                       Estado_Seguro = @Estado_Seguro 
                                       WHERE SiniestroID = @SiniestroID"

                        Using command As New MySqlCommand(query, connection)
                            ' Asignar los parámetros con los valores correspondientes
                            command.Parameters.AddWithValue("@Detalle", txtDetalle.Text.Trim())
                            command.Parameters.AddWithValue("@Estado_Siniestro", cbxEstado2.SelectedItem.ToString())
                            command.Parameters.AddWithValue("@Fecha_Siniestro", FecSiniestro.Value)
                            command.Parameters.AddWithValue("@RutCompania", rutCompania) ' Usamos el RutCompania obtenido
                            command.Parameters.AddWithValue("@Rut", txtCliente2.Text.Trim())
                            command.Parameters.AddWithValue("@Estado_Seguro", cbxSeguro.SelectedItem.ToString())
                            command.Parameters.AddWithValue("@SiniestroID", siniestroId)

                            ' Ejecutar la consulta
                            command.ExecuteNonQuery()
                        End Using
                    End Using

                    ' Confirmación de la modificación
                    MessageBox.Show("Registro modificado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    'se actualiza el DataGridView2
                    btnVerTodo_Click(sender, e) 'llama a la funcion que refresca el DataGridView2

                    'busca el registro modificado en el DataGridView2 en base al ID
                    For Each row As DataGridViewRow In DataGridView1.Rows
                        ' Compara valores numéricos en lugar de cadenas
                        If Convert.ToInt32(row.Cells("SiniestroID").Value) = Convert.ToInt32(txtID.Text) Then
                            row.Selected = True
                            DataGridView1.FirstDisplayedScrollingRowIndex = row.Index 'se posiciona en el item seleccionado
                            Exit For
                        End If
                    Next

                    'limpia los campos despues de la modificacion
                    txtID.Clear()
                    txtDetalle.Clear()
                    cbxEstado2.SelectedIndex = -1 'restablece el comboBox a su estado inicial
                    FecSiniestro.Value = DateTime.Now 'restablece los DateTimePicker a la fecha actual
                    cbxCompañia.SelectedIndex = -1 'restablece el comboBox a su estado inicial
                    txtCliente2.Clear()
                    cbxSeguro.SelectedIndex = -1 'restablece el comboBox a su estado inicial

                Catch ex As MySqlException

                    MessageBox.Show("Error al modificar el registro: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            Else
                MessageBox.Show("No se encontró el Rut para la compañía seleccionada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            ' Si no se ha seleccionado un item en el ComboBox, mostrar un mensaje de advertencia
            MessageBox.Show("Debe seleccionar una compañía en el ComboBox para continuar.", "Selección requerida", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub
End Class