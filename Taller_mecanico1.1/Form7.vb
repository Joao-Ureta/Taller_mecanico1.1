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
            'consulta para obtener los tipos de seguro de la base de datos
            Dim query As String = "SELECT Estado FROM solicitudesservicio"
            Dim command As New MySqlCommand(query, connection)

            'ejecuta y lee la consulta
            Dim reader As MySqlDataReader = command.ExecuteReader()

            'limpia el ComboBox
            cbxEstado.Items.Clear()

            'agregar "Estado de seguro" como primer ítem
            cbxEstado.Items.Add("Seleccione estado solicitud")

            'agregar opciones fijas
            cbxEstado.Items.Add("Pendiente")
            cbxEstado.Items.Add("En proceso")
            cbxEstado.Items.Add("Completado")

            ' Crear un HashSet para evitar duplicados
            Dim seguroSet As New HashSet(Of String)

            'agrega los tipos al HashSet
            While reader.Read()
                Dim seguro As String = reader("Estado").ToString()
                seguroSet.Add(seguro) ' Añadir al HashSet (evita duplicados automáticamente)
            End While

            reader.Close()

            'agregar los elementos únicos del HashSet al ComboBox, evitando duplicados
            For Each seguroItem In seguroSet
                ' Verificar que no sea "Completado" o "Pendiente" para evitar duplicados
                If seguroItem <> "Completado" AndAlso seguroItem <> "Pendiente" Then
                    cbxEstado.Items.Add(seguroItem)
                End If
            Next

            'para dejar como primer campo "Estado de seguro"
            cbxEstado.SelectedIndex = 0

        Catch ex As MySqlException
            'mensaje para mostrar error en caso de consulta fallida
            MessageBox.Show("Error en la consulta: " & ex.Message)
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
        'PanelGarantia.Visible = False

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

            ' Agregar "Seleccione estado de servicio" como primer ítem
            cbxEstServ.Items.Add("Seleccione estado de servicio")

            ' Crear un HashSet para evitar duplicados
            Dim estadoSet As New HashSet(Of String)

            ' Agregar los estados al HashSet
            While reader.Read()
                Dim estado As String = reader("Estado").ToString()
                estadoSet.Add(estado) ' Añadir al HashSet (evita duplicados automáticamente)
            End While

            reader.Close()

            ' Agregar los elementos únicos del HashSet al ComboBox, evitando duplicados
            For Each estadoItem In estadoSet
                cbxEstServ.Items.Add(estadoItem)
            Next

            ' Para dejar como primer campo "Seleccione estado de servicio"
            cbxEstServ.SelectedIndex = 0

        Catch ex As MySqlException
            ' Mensaje para mostrar error en caso de consulta fallida
            MessageBox.Show("Error en la consulta: " & ex.Message)
        End Try
    End Sub


    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Dim connection As New MySqlConnection("Server=localhost;Database=taller;User ID=root;Password=Maju2223;SslMode=None;AllowPublicKeyRetrieval=True;")
        Dim command As MySqlCommand
        Dim reader As MySqlDataReader
        Dim input As String = txtRutNom.Text.Trim() ' Valor ingresado en txtRutNom

        ' Variables para almacenar las llaves
        Dim rutEmpleado As String = String.Empty
        Dim rutCliente As String = String.Empty

        Try
            connection.Open()

            ' Consulta para obtener datos de las tablas clientes y solicitudesservicio
            Dim query As String = "SELECT e.Rut AS EmpRut, e.Nombre AS EmpNombre, e.ApellidoP AS EmpApellidoP, c.Rut AS CliRut, c.Nombre AS CliNombre, c.ApellidoP AS CliApellidoP, " &
                              "s.FechaSolicitud, s.DescripcionProblema, s.Estado " &
                              "FROM empleados e " &
                              "INNER JOIN solicitudesservicio s ON e.Rut = s.RutEmpleado " &
                              "INNER JOIN clientes c ON c.Rut = s.Rut " &
                              "WHERE e.Rut = @input OR e.Nombre LIKE @inputName OR c.Rut = @input OR c.Nombre LIKE @inputName"

            command = New MySqlCommand(query, connection)
            command.Parameters.AddWithValue("@input", input)
            command.Parameters.AddWithValue("@inputName", "%" & input & "%") ' Búsqueda parcial por Nombre

            ' Ejecutar la consulta
            reader = command.ExecuteReader()

            If reader.Read() Then
                ' Si la búsqueda es exitosa, obtener los datos
                rutEmpleado = reader("EmpRut").ToString() ' Guardamos el Rut del empleado
                rutCliente = reader("CliRut").ToString() ' Guardamos el Rut del cliente

                ' Obtener los nombres y apellidos
                Dim nombreEmpleado As String = reader("EmpNombre").ToString()
                Dim apellidoEmpleado As String = reader("EmpApellidoP").ToString()
                Dim nombreCliente As String = reader("CliNombre").ToString()
                Dim apellidoCliente As String = reader("CliApellidoP").ToString()
                Dim fechaSolicitud As Date = reader("FechaSolicitud")
                Dim descripcionProblema As String = reader("DescripcionProblema").ToString()
                Dim estado As String = reader("Estado").ToString()

                ' Pasar datos al formulario (solo mostrar nombres y apellidos)
                txtRutCli.Text = nombreCliente & " " & apellidoCliente ' Nombre y ApellidoP del cliente al TextBox
                FecSoli.Value = fechaSolicitud ' FechaSolicitud al DateTimePicker
                txtDesc.Text = descripcionProblema ' DescripcionProblema al TextBox
                cbxEstServ.Text = estado ' Estado al ComboBox

                ' Verificar si los valores de empleado no son NULL antes de asignarlos
                If Not IsDBNull(nombreEmpleado) AndAlso Not IsDBNull(apellidoEmpleado) Then
                    txtEmpleado.Text = nombreEmpleado.ToString() & " " & apellidoEmpleado.ToString() ' Asignar Nombre y ApellidoP del empleado si no son NULL
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
End Class