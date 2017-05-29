Imports System.Data
Imports System.Data.SqlClient


Public Class Form1

    Private conexion As SqlConnection
    Private listaId As List(Of String)

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexion = New SqlConnection

        conexion.ConnectionString = "Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=MAGATZEM;Trusted_Connection=True;"

        Try
            conexion.Open()
        Catch
            MsgBox("Hay un problema con la cada de conexion, o la base de datos no esta restaurada.")
        End Try

        If conexion.State = ConnectionState.Closed Then
            MsgBox("Se va a cerrar el programa. Hasta pronto.")
            Me.Close()
        End If

        listaId = New List(Of String)

        'If ListBoxEmpleados.Items.Count > 0 Then
        '    ListBoxEmpleados.SelectedIndex = 0
        'End If
    End Sub

    Private Sub ButtonCargarDatos_Click(sender As Object, e As EventArgs) Handles ButtonCargarDatos.Click
        CargarDatos()

    End Sub

    ' **********************************************************************************************************
    ' Metodo que carga en un listBox todos los empleados de la base de datos y los ordena por ID o por APELLIDO
    ' **********************************************************************************************************
    Private Sub CargarDatos()
        Dim command As SqlCommand
        Dim reader As SqlDataReader

        'metemos en esta command la select que queremos hacer
        command = New SqlCommand
        command.Connection = conexion
        command.CommandText = "SELECT IdEmpleado, Apellidos, Nombre, Cargo, FechaNacimiento, Jefe FROM Empleados"

        'Ahora miramos cual de los filtros esta selecionado
        If RadioButtonFiltroConJefe.Checked Then
            command.CommandText = command.CommandText + " WHERE Jefe IS NOT NULL"
        ElseIf RadioButtonFiltroSinJefe.Checked Then
            command.CommandText = command.CommandText + " WHERE Jefe IS NULL"
        End If

        'Miramos cual de los dos radioButtons estan seleccionados y añadimos un ORDER BY a la command
        If RadioButtonOrdenarId.Checked Then
            command.CommandText = command.CommandText + " ORDER BY IdEmpleado"
        Else
            command.CommandText = command.CommandText + " ORDER BY Apellidos"
        End If

        'Ejecutamos la select que hemos creado arriba y metemos la respuesta en el reader
        reader = command.ExecuteReader()

        ' Limpiamos el listBox y hacenos un bucle para recorrer el reader y poner los valores que hemos pedio en la select
        ListBoxEmpleados.Items.Clear()
        While reader.Read()
            ListBoxEmpleados.Items.Add(reader(0) & " - " & reader(1) & " - " & reader(2))
        End While
        reader.Close()
        command.Dispose()
        ListBoxEmpleados.SelectedIndex = 0

    End Sub


    ' ****************************************************************************************************************************************************************
    ' Este metodo mira que elemento de la lista hemos seleccionado y hace una select para cargar todos los datos restantes de ese empleado y los carga en los textBox
    ' ****************************************************************************************************************************************************************
    Private Sub ListBoxEmpleados_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBoxEmpleados.SelectedIndexChanged
        Dim jefe As String = ""
        Dim command As SqlCommand
        Dim reader As SqlDataReader

        ' Con estas dos lineas meto en la variable id la linea que hayan seleccionado y luego digo que me 
        ' guarde el valor que este antes del primer '-' para conseguir el id del empleado seleccionado
        Dim id As String = ListBoxEmpleados.Items.Item(ListBoxEmpleados.SelectedIndex)
        id = id.Split("-")(0)

        'Hago una select para saber toda la informacion del usuario que han seleccionado y cargarlo en los textBox
        command = New SqlCommand
        command.Connection = conexion
        command.CommandText = "SELECT IdEmpleado, Apellidos, Nombre, Cargo, FechaNacimiento, Jefe FROM Empleados WHERE IdEmpleado = " & id

        reader = command.ExecuteReader

        While reader.Read
            TextBoxId.Text = reader(0).ToString
            TextBoxApellido.Text = reader(1).ToString
            TextBoxNombre.Text = reader(2).ToString
            TextBoxCargo.Text = reader(3).ToString
            TextBoxFechaNacimiento.Text = reader(4)

            'Aqui le resto uno al reader porque el combobox el usuario 1 es el 0, (Sino siempre me coje el empleado de debajo
            'el catch es porque en el caso de que sea null no le puede restar uno
            Try
                jefe = reader(5).ToString() - 1
            Catch ex As Exception
                jefe = ""
            End Try


        End While

        reader.Close()
        command.Dispose()

        LlenarComboBox(TextBoxId.Text)

        If jefe <> "" Then
            ComboBoxJefe.SelectedIndex = CInt(jefe)
        Else
            ComboBoxJefe.Text = ""
        End If

    End Sub

    ' *************************************************************************************
    ' Este metodo rellena el comboBox con todos los empleados que haya en la base de datos
    ' *************************************************************************************
    Public Sub LlenarComboBox(idEmpleado As String)

        Dim command As SqlCommand
        Dim reader As SqlDataReader

        command = New SqlCommand
        command.Connection = conexion
        command.CommandText = "SELECT idEmpleado, Apellidos, Nombre FROM Empleados;"' WHERE IdEmpleado != " & idEmpleado & " ORDER BY idEmpleado;"

        reader = command.ExecuteReader

        ComboBoxJefe.Items.Clear()
        listaId.Clear()

        While reader.Read
            ComboBoxJefe.Items.Add(reader(1).ToString + " - " + reader(2).ToString)
            listaId.Add(reader(0))
        End While

        reader.Close()
        command.Dispose()

    End Sub

    ' *****************************************
    ' Metodo que pasa al SIGUIENTE del listbox
    ' *****************************************
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ButtonSiguiente.Click
        Try
            ListBoxEmpleados.SelectedIndex = Me.ListBoxEmpleados.SelectedIndex + 1
        Catch ex As Exception
            ListBoxEmpleados.SelectedIndex = 0
            'MsgBox("Has llegado al limite de la lista")
        End Try

    End Sub

    ' ****************************************
    ' Metodo que pasa al ANTERIOR del listbox
    ' ****************************************
    Private Sub ButtonAnterior_Click(sender As Object, e As EventArgs) Handles ButtonAnterior.Click
        Try
            ListBoxEmpleados.SelectedIndex = Me.ListBoxEmpleados.SelectedIndex - 1
        Catch ex As Exception
            ListBoxEmpleados.SelectedIndex = Me.ListBoxEmpleados.Items.Count - 1
            'MsgBox("Has llegado al limite de la lista")
        End Try
    End Sub

    ' **************************************
    ' Metodo que INSERTA un nuevo registro
    ' ****************************************
    Private Sub ButtonInsertar_Click(sender As Object, e As EventArgs) Handles ButtonInsertar.Click
        'If TextBoxApellido.Text = "" Or TextBoxNombre.Text = "" Or TextBoxCargo.Text = "" Or TextBoxFechaNacimiento.Text = "" Then
        '    MsgBox("Los campos con un '*' són obligatorios para insertar un usuario.")
        'End If

        'Compruebo que la fecha tiene un formato correcto
        Dim fecha As Boolean = IsDate(TextBoxFechaNacimiento.Text)
        If fecha = False Then
            MsgBox("La fecha no tiene un formato valido, revisalo." + vbNewLine +
            "El formato debería ser 'dia/mes/año'.")
        Else
            Dim command As SqlCommand
            command = New SqlCommand
            command.Connection = conexion

            'Compruebo si el combobox del jefe lo han puesto vacio y en ese caso introduzco el valor NULL en el parametro de jefe
            Dim jefe As Integer
            jefe = ComboBoxJefe.SelectedIndex + 1
            If ComboBoxJefe.Text = "" Then
                command.CommandText = String.Format("INSERT INTO Empleados (Apellidos, Nombre, Cargo, FechaNacimiento, Jefe) VALUES ('{0}', '{1}', '{2}', '{3}', NULL)", TextBoxApellido.Text, TextBoxNombre.Text, TextBoxCargo.Text, TextBoxFechaNacimiento.Text)
            Else
                command.CommandText = String.Format("INSERT INTO Empleados (Apellidos, Nombre, Cargo, FechaNacimiento, Jefe) VALUES ('{0}', '{1}', '{2}', '{3}', {4})", TextBoxApellido.Text, TextBoxNombre.Text, TextBoxCargo.Text, TextBoxFechaNacimiento.Text, jefe)
            End If


            Select Case MsgBox("¿Esta seguro que desea insertar un empleado con estos datos?", MsgBoxStyle.YesNo, "caption")
                Case MsgBoxResult.Yes
                    If command.ExecuteNonQuery() = 1 Then
                        MsgBox("Empleado creado.")
                        CargarDatos()
                        'Dim ultimoItem As Integer
                        'ultimoItem = ListBoxEmpleados.Items.Count
                        ListBoxEmpleados.SelectedIndex = ListBoxEmpleados.Items.Count - 1
                    Else
                        MsgBox("Ha habido un problema al modificar el empleado seleccionado")
                    End If

                Case MsgBoxResult.No

            End Select
        End If

    End Sub

    ' *********************************************
    ' Metodo que MODIFICA el registro seleccionado
    ' *********************************************
    Private Sub ButtonModificar_Click(sender As Object, e As EventArgs) Handles ButtonModificar.Click
        If ListBoxEmpleados.SelectedIndex <> -1 Then
            Dim id As String = ListBoxEmpleados.Items.Item(ListBoxEmpleados.SelectedIndex)
            id = id.Split("-")(0)

            'Compruebo que la fecha tiene un formato correcto
            Dim fecha As Boolean = IsDate(TextBoxFechaNacimiento.Text)
            If fecha = False Then
                MsgBox("La fecha no tiene un formato valido, revisalo." + vbNewLine +
                    "El formato debería ser 'dia/mes/año'.")
            Else
                Dim jefe As Integer
                jefe = ComboBoxJefe.SelectedIndex + 1

                Dim command As SqlCommand
                command = New SqlCommand
                command.Connection = conexion
                'Compruebo si el combobox del jefe lo han puesto vacio y en ese caso introduzco el valor NULL en el parametro de jefe
                If ComboBoxJefe.Text = "" Then
                    command.CommandText = String.Format("UPDATE Empleados SET Apellidos='{1}', Nombre = '{2}', Cargo = '{3}', FechaNacimiento ='{4}', Jefe = NULL WHERE idEmpleado = {0}", id, TextBoxApellido.Text, TextBoxNombre.Text, TextBoxCargo.Text, TextBoxFechaNacimiento.Text)
                Else
                    command.CommandText = String.Format("UPDATE Empleados SET Apellidos='{1}', Nombre = '{2}', Cargo = '{3}', FechaNacimiento = '{4}', Jefe = {5} WHERE idEmpleado = {0}", id, TextBoxApellido.Text, TextBoxNombre.Text, TextBoxCargo.Text, TextBoxFechaNacimiento.Text, jefe)
                End If


                Select Case MsgBox("¿Esta seguro que desea modificar este empleado?", MsgBoxStyle.YesNo, "caption")
                    Case MsgBoxResult.Yes
                        If command.ExecuteNonQuery() = 1 Then
                            MsgBox("Se ha modificado el empleado numero " + id)
                            CargarDatos()
                            ListBoxEmpleados.SelectedIndex = ListBoxEmpleados.Items.Count - 1
                        Else
                            MsgBox("Ha habido un problema al modificar el empleado seleccionado")
                        End If

                    Case MsgBoxResult.No

                End Select
            End If

        Else
            MsgBox("No se puede modificar el empleado, porque no tienes ningun empleado seleccionado.")
        End If
    End Sub

    ' *******************************************
    ' Metodo que ELIMINA el registro seleccioado
    ' *******************************************
    Private Sub ButtonEliminar_Click(sender As Object, e As EventArgs) Handles ButtonEliminar.Click
        If ListBoxEmpleados.SelectedIndex <> -1 Then
            Dim id As String = ListBoxEmpleados.Items.Item(ListBoxEmpleados.SelectedIndex)
            id = id.Split("-")(0)

            Dim command As SqlCommand
            command = New SqlCommand
            command.Connection = conexion
            command.CommandText = "DELETE Empleados WHERE idEmpleado = " & id

            Select Case MsgBox("¿Esta seguro que desea eliminar el empleado seleccionado?", MsgBoxStyle.YesNo, "caption")
                Case MsgBoxResult.Yes
                    If command.ExecuteNonQuery() = 1 Then
                        CargarDatos()
                        MsgBox("Se ha borrado el empleado numero " + id)
                        ListBoxEmpleados.SelectedIndex = Me.ListBoxEmpleados.SelectedIndex
                    Else
                        MsgBox("Ha habido un problema al intentar borrar el empleado seleccionado.")
                    End If

                Case MsgBoxResult.No

            End Select
        Else
            MsgBox("No se puede borrar el empleado, porque no tienes ningun empleado seleccionado.")
        End If
    End Sub
End Class
