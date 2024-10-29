Imports MySql.Data.MySqlClient

Public Class Form1
    ' Declarar la conexión sin inicializarla
    Dim conexion As MySqlConnection

    ' Evento Load del Formulario
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Agregar los idiomas al ComboBox1
        ComboBox1.Items.Add("Español")
        ComboBox1.Items.Add("English")

        ' Establecer "Español" como el idioma predeterminado
        ComboBox1.SelectedItem = "Español"
    End Sub

    ' Evento SelectedIndexChanged del ComboBox1
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.SelectedItem.ToString() = "English" Then
            ' Cambiar los textos al inglés
            Label1.Text = "Welcome to Ultra Mechanics"
            Label2.Text = "Email"
            Label3.Text = "Password"
            btnIniciarSesion.Text = "Login"
            Label4.Text = "Select language"
            Label6.Text = "© Non-commercial product developed by Nikens Pierre and Joao Ureta 2024. All rights reserved."
        Else
            ' Cambiar los textos al español
            Label1.Text = "Bienvenido a Ultra Mecánica"
            Label2.Text = "Correo"
            Label3.Text = "Contraseña"
            btnIniciarSesion.Text = "Iniciar Sesión"
            Label4.Text = "Seleccionar idioma"
            Label6.Text = "© Producto no comercial desarrollado por Nikens Pierre y Joao Ureta 2024. Todos los derechos reservados."
        End If
    End Sub

    ' Evento Click del Botón Iniciar Sesión
    Private Sub btnIniciarSesion_Click(sender As Object, e As EventArgs) Handles btnIniciarSesion.Click
        ' Obtener los valores ingresados por el usuario
        Dim nombreUsuario As String = txtNombreUsuario.Text
        Dim contrasena As String = txtContrasena.Text

        ' Verificar si los campos están vacíos
        If String.IsNullOrWhiteSpace(nombreUsuario) Then
            Dim mensajeCorreo As String = If(ComboBox1.SelectedItem.ToString() = "English", "Please enter your email.", "Por favor ingrese su correo.")
            Dim tituloCorreo As String = If(ComboBox1.SelectedItem.ToString() = "English", "Empty Email Field", "Campo de Correo Vacío")
            MessageBox.Show(mensajeCorreo, tituloCorreo, MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return ' Detener la ejecución si el correo está vacío
        End If

        If String.IsNullOrWhiteSpace(contrasena) Then
            Dim mensajeContrasena As String = If(ComboBox1.SelectedItem.ToString() = "English", "Please enter your password.", "Por favor ingrese su contraseña.")
            Dim tituloContrasena As String = If(ComboBox1.SelectedItem.ToString() = "English", "Empty Password Field", "Campo de Contraseña Vacío")
            MessageBox.Show(mensajeContrasena, tituloContrasena, MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return ' Detener la ejecución si la contraseña está vacía
        End If

        Try
            ' Inicializar la conexión
            conexion = New MySqlConnection("Server=localhost;Database=taller;User ID=root;Password=Maju2223;SslMode=None;AllowPublicKeyRetrieval=True;")

            ' Comando SQL para verificar los datos del usuario
            Dim query As String = "SELECT Correo, Tipo FROM usuarios WHERE Correo = @NombreUsuario AND Contraseña = @Contrasena"
            Dim comando As New MySqlCommand(query, conexion)

            ' Añadir los parámetros
            comando.Parameters.AddWithValue("@NombreUsuario", nombreUsuario)
            comando.Parameters.AddWithValue("@Contrasena", contrasena)

            ' Abrir la conexión
            conexion.Open()

            ' Ejecutar el comando
            Dim lector As MySqlDataReader = comando.ExecuteReader()

            ' Verificar si el lector tiene filas (usuario encontrado)
            If lector.HasRows Then
                lector.Read() ' Leer los datos
                Dim nombre As String = lector("Correo").ToString()
                Dim tipoUsuario As String = lector("Tipo").ToString() ' Obtener el tipo de usuario

                ' Cerrar el lector y la conexión
                lector.Close()
                conexion.Close()

                ' Abrir el Form2 y pasar el tipo de usuario
                Dim form2 As New Form2()
                form2.TipoUsuario = tipoUsuario ' Asignar el tipo de usuario a la propiedad en Form2


                ' Configurar el mensaje de bienvenida
                form2.lblBienvenido.Text = If(ComboBox1.SelectedItem.ToString() = "English", $"Welcome, {nombre}", $"Bienvenido, {nombre}")

                ' Habilitar o deshabilitar botones según el tipo de usuario
                If tipoUsuario = "Administrador" OrElse tipoUsuario = "Gerente" Then
                    form2.btnUsuarios.Enabled = True
                    form2.btnEmpleados.Enabled = True
                Else
                    form2.btnUsuarios.Enabled = False
                    form2.btnEmpleados.Enabled = False
                End If

                ' Mostrar Form2 centrado
                form2.StartPosition = FormStartPosition.CenterScreen
                form2.Show()

                ' Ocultar el Form1
                Me.Hide()
            Else
                ' Usuario no encontrado
                Dim mensajeError As String = If(ComboBox1.SelectedItem.ToString() = "English", "User does not exist or password is incorrect.", "Usuario inexistente o contraseña incorrecta")
                Dim tituloError As String = If(ComboBox1.SelectedItem.ToString() = "English", "Login Error", "Error de inicio de sesión")
                MessageBox.Show(mensajeError, tituloError, MessageBoxButtons.OK, MessageBoxIcon.Error)

                ' Cerrar el lector y la conexión
                lector.Close()
                conexion.Close()
            End If
        Catch ex As MySqlException
            ' Mostrar mensaje de error si algo falla
            MessageBox.Show("Error en la conexión o consulta: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            ' Asegurar que la conexión se cierre
            If conexion IsNot Nothing AndAlso conexion.State = ConnectionState.Open Then
                conexion.Close()
            End If
        End Try
    End Sub
End Class
