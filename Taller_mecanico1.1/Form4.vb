Imports MySql.Data.MySqlClient

Public Class Form4

    ' Propiedad para almacenar el tipo de usuario
    Public Property TipoUsuario As String
    Dim connectionString As String = "Server=localhost;Database=taller;User ID=root;Password=Maju2223;SslMode=None;AllowPublicKeyRetrieval=True;"
    Private connection As MySqlConnection

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Ocultar el PanelInventario al iniciar el formulario
        PanelInventario.Visible = False

        Try
            'instancia de conexion
            connection = New MySqlConnection(connectionString)

            connection.Open()

            'funcion para cargar comunas
            CargarClientes()

        Catch ex As MySqlException
            'en caso de falla de conexion muestra mensaje de error
            MessageBox.Show("Error al conectar a la base de datos: " & ex.Message)
        Finally
            If connection IsNot Nothing Then connection.Close()
        End Try
    End Sub




    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        ' Crear una nueva instancia de Form2
        Dim form2 As New Form2()

        ' Pasar el tipo de usuario al Form2
        form2.TipoUsuario = Me.TipoUsuario ' Asumiendo que este formulario tiene acceso al tipo de usuario

        ' Mostrar Form2
        form2.Show()

        ' Cerrar el formulario actual
        Me.Close()
    End Sub

    ' Método para mostrar el panel correspondiente y ocultar los demás
    Private Sub ShowPanel(selectedPanel As Panel)
        ' Oculta todos los paneles primero
        PanelInventario.Visible = False
        ' PanelSolicitud.Visible = False
        PanelGarantia.Visible = False
        ' PanelVentas.Visible = False

        ' Muestra el panel seleccionado
        selectedPanel.Visible = True
    End Sub

    Private Sub InventarioDeRepuestosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InventarioDeRepuestosToolStripMenuItem.Click
        ShowPanel(PanelInventario)
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click

        Dim criterio = txtDescripcion.Text

        If criterio = "" Then
            MessageBox.Show("Por favor, ingrese un ID o descripción.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        Using conn As New MySqlConnection(connectionString)
            Try
                conn.Open

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
                    Dim table As New DataTable
                    adapter.Fill(table)

                    If table.Rows.Count > 0 Then
                        DataGridView1.Columns.Clear

                        'genera columnas automaticamente
                        DataGridView1.AutoGenerateColumns = True

                        'asigna el DataSource y refresca
                        DataGridView1.DataSource = table

                        'ajusta el tamaño del DataGridView1 para que ocupe todo el espacio disponible
                        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
                        DataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
                        DataGridView1.Refresh

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
                conn.Open
                'consulta para seleccionar todos los registros de la tabla usuarios
                Dim query = "SELECT * FROM repuestos"

                Using cmd As New MySqlCommand(query, conn)
                    Dim adapter As New MySqlDataAdapter(cmd)
                    Dim table As New DataTable
                    adapter.Fill(table)

                    If table.Rows.Count > 0 Then
                        MessageBox.Show("Total de repuestos encontrados: " & table.Rows.Count.ToString)

                        'borra las columnas anteriores si existen
                        DataGridView1.Columns.Clear

                        'genera columnas automaticamente
                        DataGridView1.AutoGenerateColumns = True

                        'asigna el DataSource con todos los registros y refresca
                        DataGridView1.DataSource = table

                        'ajusta el tamaño del DataGridView1
                        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
                        DataGridView1.Refresh

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
        ' Verifica si el CheckModificar o el CheckEliminar están activados
        If CheckModificar.Checked OrElse CheckEliminar.Checked Then
            If e.RowIndex >= 0 Then
                ' Obtiene la fila seleccionada
                Dim row = DataGridView1.Rows(e.RowIndex)

                ' Carga los datos en los TextBox
                txtID.Text = row.Cells("RepuestoID").Value.ToString()
                txtRepuesto.Text = row.Cells("NombreRepuesto").Value.ToString()
                txtCantidad.Text = row.Cells("CantidadStock").Value.ToString()

                ' Convierte el PrecioUnitario a Decimal, luego a Integer, y finalmente lo convierte a String
                Dim precioUnitarioDecimal As Decimal = Convert.ToDecimal(row.Cells("PrecioUnitario").Value)
                txtPrecio.Text = CInt(precioUnitarioDecimal).ToString() ' Convertir a Integer y luego a String

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

                    'Convertir precioUnitario de decimal a integer antes de usarlo
                    Dim precioUnitario As Integer
                    If Not Integer.TryParse(txtPrecio.Text, precioUnitario) Then
                        MessageBox.Show("El precio debe ser un número entero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Return
                    End If

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

    Private Sub GarantiaDeRepuestosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GarantiaDeRepuestosToolStripMenuItem.Click
        ShowPanel(PanelGarantia)
    End Sub

    Private Sub CargarClientes()
        Try
            'consulta para obtener las comunas de la base de datos
            Dim query As String = "SELECT Rut FROM clientes"
            Dim command As New MySqlCommand(query, connection)

            'ejecuta y lee la consulta
            Dim reader As MySqlDataReader = command.ExecuteReader()

            'limpia el combobox
            cbxCliente.Items.Clear()

            'agregar "seleccione una comuna" como opcion
            cbxCliente.Items.Add("Seleccione un cliente")

            'agrega las comunas al combobox
            While reader.Read()
                cbxCliente.Items.Add(reader("Rut").ToString())
            End While

            reader.Close()

            'para dejar como primer campo "seleccione comuna"
            cbxCliente.SelectedIndex = 0

        Catch ex As MySqlException
            'mensaje para mostrar error en caso de consulta fallida
            MessageBox.Show("Error en la consulta: " & ex.Message)
        End Try
    End Sub

    Private Sub btnBuscar2_Click(sender As Object, e As EventArgs) Handles btnBuscar2.Click

        Dim criterio = txtDescGarantia.Text

        If criterio = "" Then
            MessageBox.Show("Por favor, ingrese un ID o descripción.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        Using conn As New MySqlConnection(connectionString)
            Try
                conn.Open()

                Dim query As String
                If IsNumeric(criterio) Then
                    query = "SELECT * FROM garantiasrepuestos WHERE GarantiaID = @criterio"
                Else
                    query = "SELECT * FROM garantiasrepuestos WHERE NombreRepuesto LIKE @criterio"
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
                        DataGridView2.Columns.Clear()

                        'genera columnas automaticamente
                        DataGridView2.AutoGenerateColumns = True

                        'asigna el DataSource y refresca
                        DataGridView2.DataSource = table

                        'ajusta el tamaño del DataGridView2 para que ocupe todo el espacio disponible
                        DataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
                        DataGridView2.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
                        DataGridView2.Refresh()

                    Else
                        MessageBox.Show("ID y/o Descripcion no encontrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End Using
            Catch ex As Exception
                MessageBox.Show("Error al conectar con la base de datos: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub

    Private Sub btnVisualizar2_Click(sender As Object, e As EventArgs) Handles btnVisualizar2.Click

        Using conn As New MySqlConnection(connectionString)
            Try
                conn.Open()
                'consulta para seleccionar todos los registros de la tabla garantiasrepuestos
                Dim query = "SELECT * FROM garantiasrepuestos"

                Using cmd As New MySqlCommand(query, conn)
                    Dim adapter As New MySqlDataAdapter(cmd)
                    Dim table As New DataTable
                    adapter.Fill(table)

                    If table.Rows.Count > 0 Then
                        MessageBox.Show("Total de Garantias encontrados: " & table.Rows.Count.ToString)

                        'borra las columnas anteriores si existen
                        DataGridView2.Columns.Clear()

                        'genera columnas automaticamente
                        DataGridView2.AutoGenerateColumns = True

                        'asigna el DataSource con todos los registros y refresca
                        DataGridView2.DataSource = table

                        'ajusta el tamaño del DataGridView2
                        DataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
                        DataGridView2.Refresh()

                    Else
                        MessageBox.Show("No hay garantias registradas en la base de datos.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                End Using
            Catch ex As Exception
                MessageBox.Show("Error al conectar con la base de datos: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub

    Private Sub chbxIngresar_CheckedChanged(sender As Object, e As EventArgs) Handles chbxIngresar.CheckedChanged

        'habilita los campos y el boton guardar al marcar chbxIngresar

        txtDesc2.Enabled = chbxIngresar.Checked
        txtDetalle.Enabled = chbxIngresar.Checked
        cbxCliente.Enabled = chbxIngresar.Checked
        FecIni.Enabled = chbxIngresar.Checked
        FecFin.Enabled = chbxIngresar.Checked
        btnGuardar2.Enabled = chbxIngresar.Checked

    End Sub

    Private Sub btnGuardar2_Click(sender As Object, e As EventArgs) Handles btnGuardar2.Click
        'verifica que todos los campos esten llenos
        If String.IsNullOrWhiteSpace(txtDesc2.Text) OrElse
       String.IsNullOrWhiteSpace(txtDetalle.Text) OrElse
       cbxCliente.SelectedItem Is Nothing Then
            MessageBox.Show("Por favor, complete todos los campos antes de guardar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        'muestra mensaje de confirmacion
        Dim result As DialogResult = MessageBox.Show("¿Está seguro que los datos de ingreso son correctos?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        'si el usuario confirma, se guardan los datos
        If result = DialogResult.Yes Then
            Try
                Using connection As New MySqlConnection(connectionString)
                    connection.Open()
                    Dim query As String = "INSERT INTO garantiasrepuestos (NombreRepuesto, DetalleGarantia, Cliente, FechaInicio, FechaFin) VALUES (@NombreRepuesto, @DetalleGarantia, @Cliente, @FechaInicio, @FechaFin)"

                    Using command As New MySqlCommand(query, connection)
                        'obtiene las fechas de los DateTimePicker como objetos Date
                        Dim fechaInicio As Date = FecIni.Value
                        Dim fechaFin As Date = FecFin.Value

                        'agrega los parametros a la consulta
                        command.Parameters.AddWithValue("@NombreRepuesto", txtDesc2.Text)
                        command.Parameters.AddWithValue("@DetalleGarantia", txtDetalle.Text)

                        'obtiene el cliente seleccionado del ComboBox
                        command.Parameters.AddWithValue("@Cliente", cbxCliente.SelectedItem.ToString())

                        command.Parameters.AddWithValue("@FechaInicio", fechaInicio)
                        command.Parameters.AddWithValue("@FechaFin", fechaFin)

                        command.ExecuteNonQuery()

                        'obtener el ID autoincremental recien insertado
                        Dim lastInsertedId As Integer = Convert.ToInt32(command.LastInsertedId)

                        'actualiza el DataGridView2
                        btnVisualizar2_Click(sender, e) 'llama a la funcion que actualiza el DataGridView2

                        'selecciona la fila con el nuevo ID generado
                        For Each row As DataGridViewRow In DataGridView2.Rows
                            If Convert.ToInt32(row.Cells("GarantiaID").Value) = lastInsertedId Then
                                row.Selected = True
                                DataGridView2.FirstDisplayedScrollingRowIndex = row.Index 'desplaza el DataGridView2 hasta el ítem seleccionado
                                Exit For
                            End If
                        Next
                    End Using
                End Using

                MessageBox.Show("Datos guardados exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)

                'limpia los campos despues de guardado exitoso
                txtID2.Clear()
                txtDesc2.Clear()
                txtDetalle.Clear()
                cbxCliente.SelectedIndex = -1 'limpia el ComboBox
                FecIni.Value = DateTime.Now 'restablece los DateTimePicker a la fecha actual
                FecFin.Value = DateTime.Now

            Catch ex As Exception
                MessageBox.Show("Error al guardar los datos: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub chbxModificar_CheckedChanged(sender As Object, e As EventArgs) Handles chbxModificar.CheckedChanged

        'habilita los campos y el botón modificar al marcar chbxModificar
        txtDesc2.Enabled = chbxModificar.Checked
        txtDetalle.Enabled = chbxModificar.Checked
        cbxCliente.Enabled = chbxModificar.Checked
        FecIni.Enabled = chbxModificar.Checked
        FecFin.Enabled = chbxModificar.Checked
        btnModificar2.Enabled = chbxModificar.Checked
    End Sub

    'se carga los datos seleccionados en el DataGridView a los campos de texto y ComboBox
    Private Sub DataGridView2_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellClick
        'verifica si el chbxModificar o el chbxEliminar están activados
        If chbxModificar.Checked OrElse chbxEliminar.Checked Then
            If e.RowIndex >= 0 Then
                'obtiene la fila seleccionada
                Dim row = DataGridView2.Rows(e.RowIndex)

                'carga los datos en los TextBox y ComboBox
                txtID2.Text = row.Cells("GarantiaID").Value.ToString()
                txtDesc2.Text = row.Cells("NombreRepuesto").Value.ToString()
                txtDetalle.Text = row.Cells("DetalleGarantia").Value.ToString()
                cbxCliente.Text = row.Cells("Cliente").Value.ToString()
                FecIni.Value = DateTime.Parse(row.Cells("FechaInicio").Value.ToString())
                FecFin.Value = DateTime.Parse(row.Cells("FechaFin").Value.ToString())
            End If
        End If
    End Sub

    Private Sub btnModificar2_Click(sender As Object, e As EventArgs) Handles btnModificar2.Click
        'verifica si no hay un ítem seleccionado en el DataGridView2
        If String.IsNullOrWhiteSpace(txtID2.Text) Then
            MessageBox.Show("Por favor, seleccione un ítem de la lista para modificar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return 'evita que el código continúe si no hay selección
        End If

        'verifica que todos los campos esten llenos
        If String.IsNullOrWhiteSpace(txtDesc2.Text) OrElse
       String.IsNullOrWhiteSpace(txtDetalle.Text) OrElse
       String.IsNullOrWhiteSpace(cbxCliente.Text) OrElse
       FecIni.Value = Nothing OrElse
       FecFin.Value = Nothing Then
            MessageBox.Show("Por favor, complete todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        'muestra mensaje de confirmacion
        Dim result As DialogResult = MessageBox.Show("¿Está seguro que los datos modificados son correctos?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        'si el usuario confirma, se modifican los datos
        If result = DialogResult.Yes Then
            Try
                Using connection As New MySqlConnection(connectionString)
                    connection.Open()
                    'consulta SQL para modificar el registro en la tabla garantiasrepuestos
                    Dim query As String = "UPDATE garantiasrepuestos SET NombreRepuesto = @NombreRepuesto, DetalleGarantia = @DetalleGarantia, Cliente = @Cliente, FechaInicio = @FechaInicio, FechaFin = @FechaFin WHERE GarantiaID = @GarantiaID"
                    Using command As New MySqlCommand(query, connection)
                        'se asignan los parametros con los valores de los controles
                        command.Parameters.AddWithValue("@GarantiaID", txtID2.Text)
                        command.Parameters.AddWithValue("@NombreRepuesto", txtDesc2.Text)
                        command.Parameters.AddWithValue("@DetalleGarantia", txtDetalle.Text)
                        command.Parameters.AddWithValue("@Cliente", cbxCliente.Text)
                        command.Parameters.AddWithValue("@FechaInicio", FecIni.Value)
                        command.Parameters.AddWithValue("@FechaFin", FecFin.Value)
                        command.ExecuteNonQuery()
                    End Using
                End Using

                MessageBox.Show("Garantía de repuesto modificada exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)

                'se actualiza el DataGridView2
                btnVisualizar2_Click(sender, e) 'llama a la funcion que refresca el DataGridView2

                'busca el registro modificado en el DataGridView2 en base al ID
                For Each row As DataGridViewRow In DataGridView2.Rows
                    ' Compara valores numéricos en lugar de cadenas
                    If Convert.ToInt32(row.Cells("GarantiaID").Value) = Convert.ToInt32(txtID2.Text) Then
                        row.Selected = True
                        DataGridView2.FirstDisplayedScrollingRowIndex = row.Index 'se posiciona en el item seleccionado
                        Exit For
                    End If
                Next


                'limpia los campos despues de la modificacion
                txtID2.Clear()
                txtDesc2.Clear()
                txtDetalle.Clear()
                cbxCliente.SelectedIndex = -1 'desmarcar selección de cliente
                FecIni.Value = DateTime.Now
                FecFin.Value = DateTime.Now

            Catch ex As Exception
                MessageBox.Show("Error al modificar los datos: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub chbxEliminar_CheckedChanged(sender As Object, e As EventArgs) Handles chbxEliminar.CheckedChanged
        'habilita el boton guardar al marcar checkEliminar
        If chbxEliminar.Checked Then
            btnEliminar2.Enabled = True
        Else
            btnEliminar2.Enabled = False
        End If
    End Sub

    Private Sub btnEliminar2_Click(sender As Object, e As EventArgs) Handles btnEliminar2.Click
        ' Verifica si no hay un ítem seleccionado en el DataGridView2
        If String.IsNullOrWhiteSpace(txtID2.Text) Then
            MessageBox.Show("Por favor, seleccione un ítem de la lista para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return ' Evita que el código continúe si no hay selección
        End If

        ' Muestra mensaje de confirmación
        Dim result As DialogResult = MessageBox.Show("¿Está seguro que desea eliminar este registro?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        ' Si el usuario confirma, se elimina el registro
        If result = DialogResult.Yes Then
            Try
                Using connection As New MySqlConnection(connectionString)
                    connection.Open()
                    ' Consulta SQL para eliminar el registro en la tabla garantiasrepuestos
                    Dim query As String = "DELETE FROM garantiasrepuestos WHERE GarantiaID = @GarantiaID"
                    Using command As New MySqlCommand(query, connection)
                        ' Se asigna el parámetro con el valor del campo GarantiaID
                        command.Parameters.AddWithValue("@GarantiaID", txtID2.Text)
                        command.ExecuteNonQuery()
                    End Using
                End Using

                MessageBox.Show("Registro eliminado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)

                ' Se actualiza el DataGridView2
                btnVisualizar2_Click(sender, e) ' Llama a la función que refresca el DataGridView2

                ' Limpia los campos después de la eliminación
                txtID2.Clear()
                txtDesc2.Clear()
                txtDetalle.Clear()
                cbxCliente.SelectedIndex = -1 ' Desmarca selección de cliente
                FecIni.Value = DateTime.Now
                FecFin.Value = DateTime.Now

            Catch ex As Exception
                MessageBox.Show("Error al eliminar el registro: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub
End Class
