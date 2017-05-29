<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ButtonCargarDatos = New System.Windows.Forms.Button()
        Me.RadioButtonOrdenarId = New System.Windows.Forms.RadioButton()
        Me.RadioButtonOrdenarApellido = New System.Windows.Forms.RadioButton()
        Me.ListBoxEmpleados = New System.Windows.Forms.ListBox()
        Me.TextBoxId = New System.Windows.Forms.TextBox()
        Me.TextBoxApellido = New System.Windows.Forms.TextBox()
        Me.TextBoxNombre = New System.Windows.Forms.TextBox()
        Me.TextBoxCargo = New System.Windows.Forms.TextBox()
        Me.TextBoxFechaNacimiento = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ComboBoxJefe = New System.Windows.Forms.ComboBox()
        Me.ButtonSiguiente = New System.Windows.Forms.Button()
        Me.ButtonAnterior = New System.Windows.Forms.Button()
        Me.ButtonModificar = New System.Windows.Forms.Button()
        Me.ButtonInsertar = New System.Windows.Forms.Button()
        Me.ButtonEliminar = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.RadioButtonFiltroSinJefe = New System.Windows.Forms.RadioButton()
        Me.RadioButtonFiltroConJefe = New System.Windows.Forms.RadioButton()
        Me.RadioButtonSinFiltro = New System.Windows.Forms.RadioButton()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(184, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(132, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Lista de Empleados"
        '
        'ButtonCargarDatos
        '
        Me.ButtonCargarDatos.Location = New System.Drawing.Point(12, 40)
        Me.ButtonCargarDatos.Name = "ButtonCargarDatos"
        Me.ButtonCargarDatos.Size = New System.Drawing.Size(108, 38)
        Me.ButtonCargarDatos.TabIndex = 1
        Me.ButtonCargarDatos.Text = "Cargar datos"
        Me.ButtonCargarDatos.UseVisualStyleBackColor = True
        '
        'RadioButtonOrdenarId
        '
        Me.RadioButtonOrdenarId.AutoSize = True
        Me.RadioButtonOrdenarId.Checked = True
        Me.RadioButtonOrdenarId.Location = New System.Drawing.Point(12, 111)
        Me.RadioButtonOrdenarId.Name = "RadioButtonOrdenarId"
        Me.RadioButtonOrdenarId.Size = New System.Drawing.Size(116, 21)
        Me.RadioButtonOrdenarId.TabIndex = 2
        Me.RadioButtonOrdenarId.TabStop = True
        Me.RadioButtonOrdenarId.Text = "Ordear por ID"
        Me.RadioButtonOrdenarId.UseVisualStyleBackColor = True
        '
        'RadioButtonOrdenarApellido
        '
        Me.RadioButtonOrdenarApellido.AutoSize = True
        Me.RadioButtonOrdenarApellido.Location = New System.Drawing.Point(12, 138)
        Me.RadioButtonOrdenarApellido.Name = "RadioButtonOrdenarApellido"
        Me.RadioButtonOrdenarApellido.Size = New System.Drawing.Size(161, 21)
        Me.RadioButtonOrdenarApellido.TabIndex = 3
        Me.RadioButtonOrdenarApellido.Text = "Ordenar por Apellido"
        Me.RadioButtonOrdenarApellido.UseVisualStyleBackColor = True
        '
        'ListBoxEmpleados
        '
        Me.ListBoxEmpleados.FormattingEnabled = True
        Me.ListBoxEmpleados.ItemHeight = 16
        Me.ListBoxEmpleados.Location = New System.Drawing.Point(187, 29)
        Me.ListBoxEmpleados.Name = "ListBoxEmpleados"
        Me.ListBoxEmpleados.Size = New System.Drawing.Size(264, 228)
        Me.ListBoxEmpleados.TabIndex = 4
        '
        'TextBoxId
        '
        Me.TextBoxId.Enabled = False
        Me.TextBoxId.Location = New System.Drawing.Point(478, 52)
        Me.TextBoxId.Name = "TextBoxId"
        Me.TextBoxId.Size = New System.Drawing.Size(175, 22)
        Me.TextBoxId.TabIndex = 7
        '
        'TextBoxApellido
        '
        Me.TextBoxApellido.Location = New System.Drawing.Point(478, 109)
        Me.TextBoxApellido.Name = "TextBoxApellido"
        Me.TextBoxApellido.Size = New System.Drawing.Size(175, 22)
        Me.TextBoxApellido.TabIndex = 8
        '
        'TextBoxNombre
        '
        Me.TextBoxNombre.Location = New System.Drawing.Point(478, 165)
        Me.TextBoxNombre.Name = "TextBoxNombre"
        Me.TextBoxNombre.Size = New System.Drawing.Size(175, 22)
        Me.TextBoxNombre.TabIndex = 9
        '
        'TextBoxCargo
        '
        Me.TextBoxCargo.Location = New System.Drawing.Point(478, 222)
        Me.TextBoxCargo.Name = "TextBoxCargo"
        Me.TextBoxCargo.Size = New System.Drawing.Size(175, 22)
        Me.TextBoxCargo.TabIndex = 10
        '
        'TextBoxFechaNacimiento
        '
        Me.TextBoxFechaNacimiento.Location = New System.Drawing.Point(478, 281)
        Me.TextBoxFechaNacimiento.Name = "TextBoxFechaNacimiento"
        Me.TextBoxFechaNacimiento.Size = New System.Drawing.Size(175, 22)
        Me.TextBoxFechaNacimiento.TabIndex = 11
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(478, 86)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 17)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Apellido*"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(478, 199)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(51, 17)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Cargo*"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(478, 29)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(21, 17)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "ID"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(478, 142)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 17)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Nombre*"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(478, 258)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(146, 17)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "Fecha de Nacimiento*"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(478, 316)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(35, 17)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "Jefe"
        '
        'ComboBoxJefe
        '
        Me.ComboBoxJefe.FormattingEnabled = True
        Me.ComboBoxJefe.Location = New System.Drawing.Point(478, 336)
        Me.ComboBoxJefe.Name = "ComboBoxJefe"
        Me.ComboBoxJefe.Size = New System.Drawing.Size(175, 24)
        Me.ComboBoxJefe.TabIndex = 12
        '
        'ButtonSiguiente
        '
        Me.ButtonSiguiente.Location = New System.Drawing.Point(292, 263)
        Me.ButtonSiguiente.Name = "ButtonSiguiente"
        Me.ButtonSiguiente.Size = New System.Drawing.Size(99, 33)
        Me.ButtonSiguiente.TabIndex = 6
        Me.ButtonSiguiente.Text = "Siguiente"
        Me.ButtonSiguiente.UseVisualStyleBackColor = True
        '
        'ButtonAnterior
        '
        Me.ButtonAnterior.Location = New System.Drawing.Point(187, 263)
        Me.ButtonAnterior.Name = "ButtonAnterior"
        Me.ButtonAnterior.Size = New System.Drawing.Size(99, 33)
        Me.ButtonAnterior.TabIndex = 5
        Me.ButtonAnterior.Text = "Anterior"
        Me.ButtonAnterior.UseVisualStyleBackColor = True
        '
        'ButtonModificar
        '
        Me.ButtonModificar.Location = New System.Drawing.Point(520, 384)
        Me.ButtonModificar.Name = "ButtonModificar"
        Me.ButtonModificar.Size = New System.Drawing.Size(99, 33)
        Me.ButtonModificar.TabIndex = 14
        Me.ButtonModificar.Text = "Modificar"
        Me.ButtonModificar.UseVisualStyleBackColor = True
        '
        'ButtonInsertar
        '
        Me.ButtonInsertar.Location = New System.Drawing.Point(415, 384)
        Me.ButtonInsertar.Name = "ButtonInsertar"
        Me.ButtonInsertar.Size = New System.Drawing.Size(99, 33)
        Me.ButtonInsertar.TabIndex = 13
        Me.ButtonInsertar.Text = "Insertar"
        Me.ButtonInsertar.UseVisualStyleBackColor = True
        '
        'ButtonEliminar
        '
        Me.ButtonEliminar.Location = New System.Drawing.Point(625, 384)
        Me.ButtonEliminar.Name = "ButtonEliminar"
        Me.ButtonEliminar.Size = New System.Drawing.Size(99, 33)
        Me.ButtonEliminar.TabIndex = 15
        Me.ButtonEliminar.Text = "Eliminar"
        Me.ButtonEliminar.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.RadioButtonFiltroSinJefe)
        Me.Panel1.Controls.Add(Me.RadioButtonFiltroConJefe)
        Me.Panel1.Controls.Add(Me.RadioButtonSinFiltro)
        Me.Panel1.Location = New System.Drawing.Point(12, 228)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(161, 100)
        Me.Panel1.TabIndex = 20
        '
        'RadioButtonFiltroSinJefe
        '
        Me.RadioButtonFiltroSinJefe.AutoSize = True
        Me.RadioButtonFiltroSinJefe.Location = New System.Drawing.Point(3, 66)
        Me.RadioButtonFiltroSinJefe.Name = "RadioButtonFiltroSinJefe"
        Me.RadioButtonFiltroSinJefe.Size = New System.Drawing.Size(76, 21)
        Me.RadioButtonFiltroSinJefe.TabIndex = 22
        Me.RadioButtonFiltroSinJefe.Text = "Sin jefe"
        Me.RadioButtonFiltroSinJefe.UseVisualStyleBackColor = True
        '
        'RadioButtonFiltroConJefe
        '
        Me.RadioButtonFiltroConJefe.AutoSize = True
        Me.RadioButtonFiltroConJefe.Location = New System.Drawing.Point(3, 39)
        Me.RadioButtonFiltroConJefe.Name = "RadioButtonFiltroConJefe"
        Me.RadioButtonFiltroConJefe.Size = New System.Drawing.Size(81, 21)
        Me.RadioButtonFiltroConJefe.TabIndex = 1
        Me.RadioButtonFiltroConJefe.Text = "Con jefe"
        Me.RadioButtonFiltroConJefe.UseVisualStyleBackColor = True
        '
        'RadioButtonSinFiltro
        '
        Me.RadioButtonSinFiltro.AutoSize = True
        Me.RadioButtonSinFiltro.Checked = True
        Me.RadioButtonSinFiltro.Location = New System.Drawing.Point(3, 12)
        Me.RadioButtonSinFiltro.Name = "RadioButtonSinFiltro"
        Me.RadioButtonSinFiltro.Size = New System.Drawing.Size(80, 21)
        Me.RadioButtonSinFiltro.TabIndex = 0
        Me.RadioButtonSinFiltro.TabStop = True
        Me.RadioButtonSinFiltro.Text = "Sin filtro"
        Me.RadioButtonSinFiltro.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(12, 208)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(46, 17)
        Me.Label8.TabIndex = 21
        Me.Label8.Text = "Filtros"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(845, 496)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ButtonEliminar)
        Me.Controls.Add(Me.ButtonInsertar)
        Me.Controls.Add(Me.ButtonModificar)
        Me.Controls.Add(Me.ButtonAnterior)
        Me.Controls.Add(Me.ButtonSiguiente)
        Me.Controls.Add(Me.ComboBoxJefe)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBoxFechaNacimiento)
        Me.Controls.Add(Me.TextBoxCargo)
        Me.Controls.Add(Me.TextBoxNombre)
        Me.Controls.Add(Me.TextBoxApellido)
        Me.Controls.Add(Me.TextBoxId)
        Me.Controls.Add(Me.ListBoxEmpleados)
        Me.Controls.Add(Me.RadioButtonOrdenarApellido)
        Me.Controls.Add(Me.RadioButtonOrdenarId)
        Me.Controls.Add(Me.ButtonCargarDatos)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents ButtonCargarDatos As Button
    Friend WithEvents RadioButtonOrdenarId As RadioButton
    Friend WithEvents RadioButtonOrdenarApellido As RadioButton
    Friend WithEvents ListBoxEmpleados As ListBox
    Friend WithEvents TextBoxId As TextBox
    Friend WithEvents TextBoxApellido As TextBox
    Friend WithEvents TextBoxNombre As TextBox
    Friend WithEvents TextBoxCargo As TextBox
    Friend WithEvents TextBoxFechaNacimiento As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents ComboBoxJefe As ComboBox
    Friend WithEvents ButtonSiguiente As Button
    Friend WithEvents ButtonAnterior As Button
    Friend WithEvents ButtonModificar As Button
    Friend WithEvents ButtonInsertar As Button
    Friend WithEvents ButtonEliminar As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents RadioButtonFiltroSinJefe As RadioButton
    Friend WithEvents RadioButtonFiltroConJefe As RadioButton
    Friend WithEvents RadioButtonSinFiltro As RadioButton
    Friend WithEvents Label8 As Label
End Class
