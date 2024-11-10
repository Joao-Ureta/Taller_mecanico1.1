Imports MySql.Data.MySqlClient

Public Class Form5

    ' Propiedad para almacenar el tipo de usuario
    Public Property TipoUsuario As String
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
End Class