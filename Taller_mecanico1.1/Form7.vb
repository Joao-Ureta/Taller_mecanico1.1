Imports MySql.Data.MySqlClient

Public Class Form7

    Dim connectionString As String = "Server=localhost;Database=taller;User ID=root;Password=Maju2223;SslMode=None;AllowPublicKeyRetrieval=True;"
    Private connection As MySqlConnection

    Private Sub Form7_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' Ocultar el pnlSolicitudServicio al iniciar el formulario
        pnlSolicitudServicio.Visible = False

        Try
            'instancia de conexion
            connection = New MySqlConnection(connectionString)

            connection.Open()

            'funcion para cargar comunas
            CargarEstado()
            CargarEmpleado()
            CargarCliente()
            CargarEstadoServicio() ' Llamada para cargar el ComboBox cbxEstServ
            CargarEstado2()

        Catch ex As MySqlException
            'en caso de falla de conexion muestra mensaje de error
            MessageBox.Show("Error al conectar a la base de datos: " & ex.Message)
        Finally
            If connection IsNot Nothing Then connection.Close()
        End Try

        ' Para mostrar la fecha actual de la compra
        FecSolicitud.Text = DateTime.Now.ToString("yyyy-MM-dd")

    End Sub

    Private Sub CargarEstado()
        Try
            ' Consulta para obtener los estados de servicio de la base de datos
            Dim query As String = "SELECT Estado FROM solicitudesservicio"
            Dim command As New MySqlCommand(query, connection)

            ' Ejecuta y lee la consulta
            Dim reader As MySqlDataReader = command.ExecuteReader()

            ' Limpiar el ComboBox
            cbxEstado.Items.Clear()

            ' Crear un HashSet para evitar duplicados
            Dim estadoSet As New HashSet(Of String)

            ' Agregar las opciones fijas al HashSet
            estadoSet.Add("Pendiente")
            estadoSet.Add("En proceso")
            estadoSet.Add("Completado")

            ' Agregar los estados de la base de datos al HashSet
            While reader.Read()
                Dim estado As String = reader("Estado").ToString()
                estadoSet.Add(estado) ' Añadir al HashSet (evita duplicados automáticamente)
            End While

            reader.Close()

            ' Agregar los elementos únicos del HashSet al ComboBox, ordenándolos
            Dim sortedEstados = estadoSet.OrderBy(Function(e) e).ToList()
            For Each estadoItem In sortedEstados
                cbxEstado.Items.Add(estadoItem)
            Next

            ' Agregar "Seleccione estado de servicio" como primera opción
            cbxEstado.Items.Insert(0, "Seleccione estado de servicio")

            ' Seleccionar por defecto "Seleccione estado de servicio"
            cbxEstado.SelectedIndex = 0

        Catch ex As MySqlException
            ' Mensaje para mostrar error en caso de consulta fallida
            MessageBox.Show("Error en la consulta: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub CargarEstado2()
        Try
            ' Consulta para obtener los estados de servicio de la base de datos
            Dim query As String = "SELECT Estado FROM solicitudesservicio"
            Dim command As New MySqlCommand(query, connection)

            ' Ejecuta y lee la consulta
            Dim reader As MySqlDataReader = command.ExecuteReader()

            ' Limpiar el ComboBox
            cbxBuscarEstado.Items.Clear()

            ' Crear un HashSet para evitar duplicados
            Dim estadoSet As New HashSet(Of String)

            ' Agregar las opciones fijas al HashSet
            estadoSet.Add("Pendiente")
            estadoSet.Add("En proceso")
            estadoSet.Add("Completado")

            ' Agregar los estados de la base de datos al HashSet
            While reader.Read()
                Dim estado As String = reader("Estado").ToString()
                estadoSet.Add(estado) ' Añadir al HashSet (evita duplicados automáticamente)
            End While

            reader.Close()

            ' Agregar los elementos únicos del HashSet al ComboBox, ordenándolos
            Dim sortedEstados = estadoSet.OrderBy(Function(e) e).ToList()
            For Each estadoItem In sortedEstados
                cbxBuscarEstado.Items.Add(estadoItem)
            Next

            ' Agregar "Seleccione estado de servicio" como primera opción
            cbxBuscarEstado.Items.Insert(0, "Seleccione estado de servicio")

            ' Seleccionar por defecto "Seleccione estado de servicio"
            cbxBuscarEstado.SelectedIndex = 0

        Catch ex As MySqlException
            ' Mensaje para mostrar error en caso de consulta fallida
            MessageBox.Show("Error en la consulta: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub CargarEmpleado()
        Try
            'consulta para obtener el Rut y Descripcion de la base de datos
            Dim query As String = "SELECT Rut, Nombre FROM empleados"
            Dim command As New MySqlCommand(query, connection)

            'ejecuta y lee la consulta
            Dim reader As MySqlDataReader = command.ExecuteReader()

            'limpia el combobox
            cbxEmpleado.Items.Clear()

            'agregar "Seleccione una compañia" como primer ítem
            cbxEmpleado.Items.Add("Seleccione un empleado")

            ' Crear una lista para almacenar los KeyValuePair (Rut, Nombre)
            Dim nombreEmp As New List(Of KeyValuePair(Of String, String))

            'agregar los Rut y nombre empleado al List
            While reader.Read()
                Dim rut As String = reader("Rut").ToString()
                Dim nombre As String = reader("Nombre").ToString()
                nombreEmp.Add(New KeyValuePair(Of String, String)(rut, nombre))
            End While

            reader.Close()

            'agregar los elementos de la lista al ComboBox
            For Each empleado In nombreEmp
                ' Mostramos el nombre, pero almacenamos el Rut
                cbxEmpleado.Items.Add(empleado.Value)
            Next

            ' Dejar como primer ítem seleccionado "Seleccione un empleado"
            cbxEmpleado.SelectedIndex = 0

        Catch ex As MySqlException
            'mensaje para mostrar error en caso de consulta fallida
            MessageBox.Show("Error en la consulta: " & ex.Message)
        End Try
    End Sub

    Private Sub CargarCliente()
        Try
            'consulta para obtener el Rut y Nombre de la base de datos
            Dim query As String = "SELECT Rut, Nombre FROM clientes"
            Dim command As New MySqlCommand(query, connection)

            'ejecuta y lee la consulta
            Dim reader As MySqlDataReader = command.ExecuteReader()

            'limpia el combobox
            cbxCliente.Items.Clear()

            'agregar "Seleccione una compañia" como primer ítem
            cbxCliente.Items.Add("Seleccione un cliente")

            ' Crear una lista para almacenar los KeyValuePair (Rut, Nombre)
            Dim nombreCli As New List(Of KeyValuePair(Of String, String))

            'agregar los Rut y nombre cliente al List
            While reader.Read()
                Dim rut As String = reader("Rut").ToString()
                Dim nombre As String = reader("Nombre").ToString()
                nombreCli.Add(New KeyValuePair(Of String, String)(rut, nombre))
            End While

            reader.Close()

            'agregar los elementos de la lista al ComboBox
            For Each cliente In nombreCli
                ' Mostramos el nombre, pero almacenamos el Rut
                cbxCliente.Items.Add(cliente.Value)
            Next

            ' Dejar como primer ítem seleccionado "Seleccione un empleado"
            cbxCliente.SelectedIndex = 0

        Catch ex As MySqlException
            'mensaje para mostrar error en caso de consulta fallida
            MessageBox.Show("Error en la consulta: " & ex.Message)
        End Try
    End Sub

    ' Método para mostrar el panel correspondiente y ocultar los demás
    Private Sub ShowPanel(selectedPanel As Panel)
        'Oculta todos los paneles primero
        pnlSolicitudServicio.Visible = False
        PanelActualizacion.Visible = False
        PanelListado.Visible = False

        ' Muestra el panel seleccionado
        selectedPanel.Visible = True
    End Sub

    Private Sub SolicitudServiciosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SolicitudServiciosToolStripMenuItem.Click
        ShowPanel(pnlSolicitudServicio)
    End Sub


    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        ' Código para volver a Form2 (menú)
        Form2.Instance.Show()
        Me.Close()
    End Sub

    Private Sub cbxCliente_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxCliente.SelectedIndexChanged
        ' Verificar que se haya seleccionado un cliente válido
        If cbxCliente.SelectedIndex = 0 Then
            BloquearCampos() ' Bloquear los campos si no se ha seleccionado un cliente
            Return
        End If

        ' Obtener el Rut del cliente seleccionado basado en el índice del ComboBox
        Dim rutCliente As String = ObtenerRutDesdeComboBox(cbxCliente.SelectedItem.ToString())
        If String.IsNullOrEmpty(rutCliente) Then
            Return
        End If

        ' Verificar si el cliente tiene un siniestro asociado
        Dim siniestroID As String = ObtenerSiniestroid(rutCliente)
        If String.IsNullOrEmpty(siniestroID) Then
            MessageBox.Show("El cliente seleccionado no está asociado a ningún siniestro activo.", "Sin siniestros", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            BloquearCampos() ' Bloquear el resto de los campos si no tiene siniestro
        Else
            MessageBox.Show("El cliente está asociado al siniestro ID: " & siniestroID, "Cliente asociado", MessageBoxButtons.OK, MessageBoxIcon.Information)
            DesbloquearCampos() ' Desbloquear los campos si tiene siniestro asociado
        End If
    End Sub

    Private Sub btnIngresar_Click(sender As Object, e As EventArgs) Handles btnIngresar.Click
        ' Verificar que se haya seleccionado un cliente válido
        If cbxCliente.SelectedIndex = 0 Then
            MessageBox.Show("Por favor, seleccione un cliente válido.", "Cliente no seleccionado", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            BloquearCampos() ' Bloquear los campos si no se ha seleccionado un cliente
            Return
        End If

        ' Obtener el Rut del cliente seleccionado basado en el índice del ComboBox
        Dim rutCliente As String = ObtenerRutDesdeComboBox(cbxCliente.SelectedItem.ToString())
        If String.IsNullOrEmpty(rutCliente) Then
            MessageBox.Show("Error al obtener el Rut del cliente seleccionado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Verificar si el cliente tiene un siniestro asociado
        Dim siniestroID As String = ObtenerSiniestroid(rutCliente)
        If String.IsNullOrEmpty(siniestroID) Then
            MessageBox.Show("El cliente seleccionado no está asociado a ningún siniestro activo.", "Sin siniestros", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            BloquearCampos() ' Bloquear el resto de los campos si no tiene siniestro
        Else
            MessageBox.Show("El cliente está asociado al siniestro ID: " & siniestroID, "Cliente asociado", MessageBoxButtons.OK, MessageBoxIcon.Information)
            DesbloquearCampos() ' Desbloquear los campos si tiene siniestro asociado
        End If

        ' Desbloquear los campos si tiene un siniestro asociado
        DesbloquearCampos()

        ' Verificar si se ha seleccionado un empleado válido
        If cbxEmpleado.SelectedIndex = 0 Then
            MessageBox.Show("Por favor, seleccione un empleado.", "Empleado no seleccionado", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Obtener el Rut del empleado basado en el nombre seleccionado
        Dim rutEmpleado As String = ObtenerRutEmpleado(cbxEmpleado.SelectedItem.ToString())
        If String.IsNullOrEmpty(rutEmpleado) Then
            MessageBox.Show("No se pudo obtener el Rut del empleado seleccionado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Proceder con la inserción de datos en la base de datos
        Try
            Using connection As New MySqlConnection(connectionString)
                connection.Open()

                ' Insertar los datos en la tabla solicitudesservicio
                Dim query As String = "INSERT INTO solicitudesservicio (Rut, FechaSolicitud, DescripcionProblema, Estado, Siniestroid, RutEmpleado) " &
                                  "VALUES (@Rut, @FechaSolicitud, @DescripcionProblema, @Estado, @Siniestroid, @RutEmpleado)"
                Using command As New MySqlCommand(query, connection)
                    command.Parameters.AddWithValue("@Rut", rutCliente)
                    command.Parameters.AddWithValue("@FechaSolicitud", FecSolicitud.Value)
                    command.Parameters.AddWithValue("@DescripcionProblema", txtDescripcion.Text.Trim())
                    command.Parameters.AddWithValue("@Estado", cbxEstado.SelectedItem.ToString())
                    command.Parameters.AddWithValue("@Siniestroid", siniestroID)
                    command.Parameters.AddWithValue("@RutEmpleado", rutEmpleado)

                    command.ExecuteNonQuery()

                    ' Limpiar campos después de guardar
                    LimpiarCampos()
                    MessageBox.Show("Solicitud de servicio ingresada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al guardar los datos: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Función para obtener el Rut del cliente seleccionado desde el ComboBox
    Private Function ObtenerRutDesdeComboBox(nombreCliente As String) As String
        Try
            Using connection As New MySqlConnection(connectionString)
                connection.Open()
                Dim query As String = "SELECT Rut FROM clientes WHERE Nombre = @Nombre"
                Using command As New MySqlCommand(query, connection)
                    command.Parameters.AddWithValue("@Nombre", nombreCliente)
                    Dim result As Object = command.ExecuteScalar()
                    If result IsNot Nothing Then
                        Return result.ToString()
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al obtener el Rut del cliente: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return String.Empty
    End Function

    ' Función para verificar si el cliente tiene un siniestro asociado y devolver su ID
    Private Function ObtenerSiniestroid(rutCliente As String) As String
        Try
            Using connection As New MySqlConnection(connectionString)
                connection.Open()
                Dim query As String = "SELECT SiniestroID FROM siniestro WHERE Rut = @Rut AND Estado_Siniestro = 'Activo' ORDER BY Fecha_Siniestro DESC LIMIT 1"
                Using command As New MySqlCommand(query, connection)
                    command.Parameters.AddWithValue("@Rut", rutCliente)
                    Dim result As Object = command.ExecuteScalar()
                    If result IsNot Nothing Then
                        Return result.ToString()
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al obtener el ID del siniestro: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return String.Empty
    End Function

    ' Función para obtener el Rut del empleado basado en el nombre
    Private Function ObtenerRutEmpleado(nombreEmpleado As String) As String
        Try
            Using connection As New MySqlConnection(connectionString)
                connection.Open()
                Dim query As String = "SELECT Rut FROM empleados WHERE Nombre = @Nombre"
                Using command As New MySqlCommand(query, connection)
                    command.Parameters.AddWithValue("@Nombre", nombreEmpleado)
                    Dim result As Object = command.ExecuteScalar()
                    If result IsNot Nothing Then
                        Return result.ToString()
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al obtener el Rut del empleado: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return String.Empty
    End Function

    ' Métodos auxiliares para bloquear y desbloquear campos
    Private Sub BloquearCampos()
        FecSolicitud.Enabled = False
        txtDescripcion.Enabled = False
        cbxEstado.Enabled = False
        cbxEmpleado.Enabled = False
        btnIngresar.Enabled = False
    End Sub

    Private Sub DesbloquearCampos()
        FecSolicitud.Enabled = True
        txtDescripcion.Enabled = True
        cbxEstado.Enabled = True
        cbxEmpleado.Enabled = True
        btnIngresar.Enabled = True
    End Sub

    ' Método para limpiar campos después de guardar
    Private Sub LimpiarCampos()
        cbxCliente.SelectedIndex = 0
        FecSolicitud.Value = DateTime.Now
        txtDescripcion.Clear()
        cbxEstado.SelectedIndex = -1
        cbxEmpleado.SelectedIndex = -1
    End Sub

    Private Sub ActualizarServicioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ActualizarServicioToolStripMenuItem.Click
        ShowPanel(PanelActualizacion)
    End Sub

    Private Sub CargarEstadoServicio()
        Try
            ' Consulta para obtener los estados de servicio de la base de datos
            Dim query As String = "SELECT Estado FROM solicitudesservicio"
            Dim command As New MySqlCommand(query, connection)

            ' Ejecuta y lee la consulta
            Dim reader As MySqlDataReader = command.ExecuteReader()

            ' Limpiar el ComboBox
            cbxEstServ.Items.Clear()

            ' Crear un HashSet para evitar duplicados
            Dim estadoSet As New HashSet(Of String)

            ' Agregar las opciones fijas al HashSet
            estadoSet.Add("Pendiente")
            estadoSet.Add("En proceso")
            estadoSet.Add("Completado")

            ' Agregar los estados de la base de datos al HashSet
            While reader.Read()
                Dim estado As String = reader("Estado").ToString()
                estadoSet.Add(estado) ' Añadir al HashSet (evita duplicados automáticamente)
            End While

            reader.Close()

            ' Agregar los elementos únicos del HashSet al ComboBox, ordenándolos
            Dim sortedEstados = estadoSet.OrderBy(Function(e) e).ToList()
            For Each estadoItem In sortedEstados
                cbxEstServ.Items.Add(estadoItem)
            Next

            ' Agregar "Seleccione estado de servicio" como primera opción
            cbxEstServ.Items.Insert(0, "Seleccione estado de servicio")

            ' Seleccionar por defecto "Seleccione estado de servicio"
            cbxEstServ.SelectedIndex = 0

        Catch ex As MySqlException
            ' Mensaje para mostrar error en caso de consulta fallida
            MessageBox.Show("Error en la consulta: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Dim connection As New MySqlConnection("Server=localhost;Database=taller;User ID=root;Password=Maju2223;SslMode=None;AllowPublicKeyRetrieval=True;")
        Dim command As MySqlCommand
        Dim reader As MySqlDataReader
        Dim input = txtRutNom.Text.Trim ' Valor ingresado en txtRutNom

        ' Variables para almacenar las llaves
        Dim rutEmpleado = String.Empty
        Dim rutCliente = String.Empty

        Try
            connection.Open()

            ' Consulta para obtener datos de las tablas clientes y solicitudesservicio
            Dim query = "SELECT s.SolicitudID, e.Rut AS EmpRut, e.Nombre AS EmpNombre, e.ApellidoP AS EmpApellidoP, c.Rut AS CliRut, c.Nombre AS CliNombre, c.ApellidoP AS CliApellidoP, " &
                              "s.FechaSolicitud, s.DescripcionProblema, s.Estado " &
                              "FROM empleados e " &
                              "INNER JOIN solicitudesservicio s ON e.Rut = s.RutEmpleado " &
                              "INNER JOIN clientes c ON c.Rut = s.Rut " &
                              "WHERE e.Rut = @input OR e.Nombre LIKE @inputName OR c.Rut = @input OR c.Nombre LIKE @inputName"

            command = New MySqlCommand(query, connection)
            command.Parameters.AddWithValue("@input", input)
            command.Parameters.AddWithValue("@inputName", "%" & input & "%") ' Búsqueda parcial por Nombre

            ' Ejecutar la consulta
            reader = command.ExecuteReader

            If reader.Read Then
                ' Si la búsqueda es exitosa, obtener los datos
                txtSolicitudID.Text = reader("SolicitudID").ToString ' Guardar el ID en el TextBox oculto
                rutEmpleado = reader("EmpRut").ToString ' Guardamos el Rut del empleado
                rutCliente = reader("CliRut").ToString ' Guardamos el Rut del cliente

                ' Obtener los nombres y apellidos
                Dim nombreEmpleado = reader("EmpNombre").ToString
                Dim apellidoEmpleado = reader("EmpApellidoP").ToString
                Dim nombreCliente = reader("CliNombre").ToString
                Dim apellidoCliente = reader("CliApellidoP").ToString
                Dim fechaSolicitud As Date = reader("FechaSolicitud")
                Dim descripcionProblema = reader("DescripcionProblema").ToString
                Dim estado = reader("Estado").ToString

                ' Pasar datos al formulario (solo mostrar nombres y apellidos)
                txtRutCli.Text = nombreCliente & " " & apellidoCliente ' Nombre y ApellidoP del cliente al TextBox
                FecSoli.Value = fechaSolicitud ' FechaSolicitud al DateTimePicker
                txtDesc.Text = descripcionProblema ' DescripcionProblema al TextBox
                cbxEstServ.Text = estado ' Estado al ComboBox

                ' Verificar si los valores de empleado no son NULL antes de asignarlos
                If Not IsDBNull(nombreEmpleado) AndAlso Not IsDBNull(apellidoEmpleado) Then
                    txtEmpleado.Text = nombreEmpleado.ToString & " " & apellidoEmpleado.ToString ' Asignar Nombre y ApellidoP del empleado si no son NULL
                Else
                    txtEmpleado.Text = String.Empty ' Si es NULL, limpiar el TextBox
                End If

                ' Asignar los Ruts a variables internas (no mostrarlos en los campos de texto)
                ' No se asignan al TextBox del formulario
                ' rutEmpleado y rutCliente estarán disponibles para guardarse en la base de datos más tarde

            Else
                ' Mostrar mensaje si no se encuentra el cliente o la solicitud
                MessageBox.Show("No se encontró información para este cliente o solicitud.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            ' Manejar errores
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            ' Cerrar la conexión
            connection.Close()
        End Try
    End Sub

    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        'valida que el SolicitudID este disponible
        If String.IsNullOrWhiteSpace(txtSolicitudID.Text) Then
            MessageBox.Show("No se ha seleccionado ninguna solicitud válida. Realice una búsqueda primero.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Try
            ' Abrir conexión a la base de datos
            connection.Open()

            ' Consulta para actualizar el estado
            Dim query As String = "UPDATE solicitudesservicio SET Estado = @estado WHERE SolicitudID = @solicitudID"
            Dim command As New MySqlCommand(query, connection)
            command.Parameters.AddWithValue("@estado", cbxEstServ.Text.Trim())
            command.Parameters.AddWithValue("@solicitudID", Convert.ToInt32(txtSolicitudID.Text)) ' Usar el campo oculto

            ' Ejecutar la consulta
            Dim rowsAffected As Integer = command.ExecuteNonQuery()

            If rowsAffected > 0 Then
                MessageBox.Show("Estado actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                LimpiarCampos2()
            Else
                MessageBox.Show("No se encontró la solicitud con el ID especificado.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If

        Catch ex As Exception
            ' Manejar errores
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            ' Cerrar la conexión
            connection.Close()
        End Try
    End Sub

    ' Método para limpiar campos después de actualizar
    Private Sub LimpiarCampos2()

        txtSolicitudID.Clear()
        txtRutCli.Clear()
        txtRutNom.Clear()
        FecSoli.Value = DateTime.Now
        txtDesc.Clear()
        cbxEstServ.SelectedIndex = 0
        txtEmpleado.Clear()
    End Sub

    Private Sub ListadoServiciosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListadoServiciosToolStripMenuItem.Click
        ShowPanel(PanelListado)
    End Sub

    Private Sub btnBuscarCli_Click(sender As Object, e As EventArgs) Handles btnBuscarCli.Click
        Dim rut As String = txtCliente.Text.Trim() ' Obtener el RUT ingresado

        If rut = "" Then
            MessageBox.Show("Por favor, ingrese un RUT.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        ' Definir las variables para los RUTs de empleado y cliente
        Dim rutEmpleado As String = String.Empty
        Dim rutCliente As String = String.Empty

        Try
            connection.Open()

            ' Consulta para obtener datos de las tablas empleados, clientes y solicitudesservicio
            Dim query As String = "SELECT s.SolicitudID, e.Rut AS EmpRut, e.Nombre AS EmpNombre, e.ApellidoP AS EmpApellidoP, c.Rut AS CliRut, " &
                              "c.Nombre AS CliNombre, c.ApellidoP AS CliApellidoP, s.FechaSolicitud, s.DescripcionProblema, s.Estado, " &
                              "s.Siniestroid, e.Nombre AS EmpleadoNombre, e.ApellidoP AS EmpleadoApellido " &
                              "FROM empleados e " &
                              "INNER JOIN solicitudesservicio s ON e.Rut = s.RutEmpleado " &
                              "INNER JOIN clientes c ON c.Rut = s.Rut " &
                              "WHERE e.Rut = @input OR e.Nombre LIKE @inputName OR c.Rut = @input OR c.Nombre LIKE @inputName"

            ' Preparar el comando y los parámetros para la consulta
            Using cmd As New MySqlCommand(query, connection)
                cmd.Parameters.AddWithValue("@input", rut)
                cmd.Parameters.AddWithValue("@inputName", "%" & rut & "%") ' Búsqueda parcial por nombre

                Dim reader As MySqlDataReader = cmd.ExecuteReader()

                ' Limpiar cualquier dato previo en el DataGridView
                DataGridView1.Columns.Clear()

                If reader.HasRows Then
                    ' Crear las columnas para el DataGridView
                    DataGridView1.Columns.Add("SolicitudID", "ID")
                    DataGridView1.Columns.Add("Cliente", "Cliente")
                    DataGridView1.Columns.Add("FechaSolicitud", "Fecha solicitud")
                    DataGridView1.Columns.Add("DescripcionProblema", "Descripción")
                    DataGridView1.Columns.Add("Estado", "Estado servicio")
                    DataGridView1.Columns.Add("SiniestroID", "ID siniestro")
                    DataGridView1.Columns.Add("Empleado", "Empleado")

                    ' Leer los datos del reader y agregarlos al DataGridView
                    While reader.Read()
                        ' Concatenar Nombre y Apellido del Cliente
                        Dim cliente As String = reader("CliNombre").ToString() & " " & reader("CliApellidoP").ToString()

                        ' Concatenar Nombre y Apellido del Empleado
                        Dim empleado As String = reader("EmpleadoNombre").ToString() & " " & reader("EmpleadoApellido").ToString()

                        ' Agregar los datos a las filas del DataGridView
                        DataGridView1.Rows.Add(
                        reader("SolicitudID").ToString(),
                        cliente,
                        reader("FechaSolicitud").ToString(),
                        reader("DescripcionProblema").ToString(),
                        reader("Estado").ToString(),
                        reader("Siniestroid").ToString(),
                        empleado
                    )
                    End While

                    ' Ajustar el tamaño de las columnas
                    DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
                    DataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells

                Else
                    ' Si no se encuentran registros, mostrar mensaje
                    MessageBox.Show("No se encontró información para este RUT o nombre.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End Using
        Catch ex As Exception
            ' Manejar errores
            MessageBox.Show("Error al conectar con la base de datos: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            ' Cerrar la conexión
            connection.Close()
        End Try
    End Sub

    Private Sub cbxBuscarEstado_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxBuscarEstado.SelectedIndexChanged
        ' Obtener el estado seleccionado del ComboBox
        Dim estadoSeleccionado As String = cbxBuscarEstado.SelectedItem.ToString()

        ' Evitar la búsqueda si el primer ítem es seleccionado ("Estado de servicio")
        If estadoSeleccionado = "Estado de servicio" Then
            Return ' No hacer nada si el primer ítem es seleccionado
        End If

        ' Consulta SQL para buscar solicitudes relacionadas con el estado seleccionado
        Dim query As String = "SELECT s.SolicitudID, " &
                          "CONCAT(c.Nombre, ' ', c.ApellidoP) AS Cliente, " &
                          "s.FechaSolicitud, " &
                          "s.DescripcionProblema, " &
                          "s.Estado, " &
                          "s.Siniestroid, " &
                          "CONCAT(e.Nombre, ' ', e.ApellidoP) AS Empleado " &
                          "FROM solicitudesservicio s " &
                          "LEFT JOIN clientes c ON s.Rut = c.Rut " &
                          "LEFT JOIN empleados e ON s.RutEmpleado = e.Rut " &
                          "WHERE s.Estado = @Estado"

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

                ' Cambiar los títulos de las columnas
                DataGridView1.Columns(0).HeaderText = "ID Solicitud"
                DataGridView1.Columns(1).HeaderText = "Cliente"
                DataGridView1.Columns(2).HeaderText = "Fecha Solicitud"
                DataGridView1.Columns(3).HeaderText = "Descripción"
                DataGridView1.Columns(4).HeaderText = "Estado servicio"
                DataGridView1.Columns(5).HeaderText = "ID Siniestro"
                DataGridView1.Columns(6).HeaderText = "Empleado"

                ' Opcional: Mostrar la cantidad de filas encontradas en un MessageBox
                MessageBox.Show("Cantidad de filas encontradas: " & table.Rows.Count.ToString(), "Resultados", MessageBoxButtons.OK, MessageBoxIcon.Information)

                ' Ajustar el tamaño de las columnas
                DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
                DataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
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

    Private Sub btnVerTodo_Click(sender As Object, e As EventArgs) Handles btnVerTodo.Click
        Try
            Using connection As New MySqlConnection(connectionString)
                connection.Open()
                ' Consulta SQL
                Dim query As String = "SELECT 
                                    ss.SolicitudID,
                                    CONCAT(c.Nombre, ' ', c.ApellidoP) AS Cliente,
                                    ss.FechaSolicitud,
                                    ss.DescripcionProblema,
                                    ss.Estado,
                                    ss.Siniestroid,
                                    CONCAT(e.Nombre, ' ', e.ApellidoP) AS Empleado
                                FROM 
                                    solicitudesservicio ss
                                LEFT JOIN 
                                    clientes c ON ss.Rut = c.Rut
                                LEFT JOIN 
                                    empleados e ON ss.RutEmpleado = e.Rut;"

                Using cmd As New MySqlCommand(query, connection)
                    Dim adapter As New MySqlDataAdapter(cmd)
                    Dim table As New DataTable()
                    adapter.Fill(table)

                    If table.Rows.Count > 0 Then
                        MessageBox.Show("Total de servicios encontrados: " & table.Rows.Count.ToString())
                        DataGridView1.Columns.Clear()
                        DataGridView1.DataSource = table

                        ' Configuración del DataGridView
                        DataGridView1.Columns("SolicitudID").HeaderText = "ID"
                        DataGridView1.Columns("Cliente").HeaderText = "Cliente"
                        DataGridView1.Columns("FechaSolicitud").HeaderText = "Fecha Solicitud"
                        DataGridView1.Columns("DescripcionProblema").HeaderText = "Descripción"
                        DataGridView1.Columns("Estado").HeaderText = "Estado Servicio"
                        DataGridView1.Columns("Siniestroid").HeaderText = "ID Siniestro"
                        DataGridView1.Columns("Empleado").HeaderText = "Empleado"

                        ' Ajustar el ancho de las columnas
                        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
                        DataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
                    Else
                        MessageBox.Show("No hay siniestros registrados.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                End Using
            End Using
        Catch ex As MySqlException
            MessageBox.Show("Error al cargar datos: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class