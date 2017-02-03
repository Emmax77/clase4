<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Clase4
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
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.txtDerecho = New System.Windows.Forms.TextBox()
        Me.lbTitulo = New System.Windows.Forms.Label()
        Me.cbxAreas = New System.Windows.Forms.ComboBox()
        Me.lbDerecho = New System.Windows.Forms.Label()
        Me.lbIzquierdo = New System.Windows.Forms.Label()
        Me.txtIzquierdo = New System.Windows.Forms.TextBox()
        Me.txtRespuesta = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(28, 157)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(75, 23)
        Me.btnAceptar.TabIndex = 0
        Me.btnAceptar.Text = "CALCULAR"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'txtDerecho
        '
        Me.txtDerecho.Location = New System.Drawing.Point(28, 115)
        Me.txtDerecho.Name = "txtDerecho"
        Me.txtDerecho.Size = New System.Drawing.Size(88, 20)
        Me.txtDerecho.TabIndex = 1
        Me.txtDerecho.Text = "0"
        Me.txtDerecho.Visible = False
        '
        'lbTitulo
        '
        Me.lbTitulo.AutoSize = True
        Me.lbTitulo.Location = New System.Drawing.Point(25, 18)
        Me.lbTitulo.Name = "lbTitulo"
        Me.lbTitulo.Size = New System.Drawing.Size(226, 13)
        Me.lbTitulo.TabIndex = 2
        Me.lbTitulo.Text = "Seleccione alguna figura para calcular su area"
        '
        'cbxAreas
        '
        Me.cbxAreas.FormattingEnabled = True
        Me.cbxAreas.Items.AddRange(New Object() {"Cuadrado", "Rectangulo", "Triangulo", "Paralelogramo"})
        Me.cbxAreas.Location = New System.Drawing.Point(28, 43)
        Me.cbxAreas.Name = "cbxAreas"
        Me.cbxAreas.Size = New System.Drawing.Size(121, 21)
        Me.cbxAreas.TabIndex = 3
        '
        'lbDerecho
        '
        Me.lbDerecho.AutoSize = True
        Me.lbDerecho.Location = New System.Drawing.Point(28, 84)
        Me.lbDerecho.Name = "lbDerecho"
        Me.lbDerecho.Size = New System.Drawing.Size(50, 13)
        Me.lbDerecho.TabIndex = 4
        Me.lbDerecho.Text = "Numero1"
        Me.lbDerecho.Visible = False
        '
        'lbIzquierdo
        '
        Me.lbIzquierdo.AutoSize = True
        Me.lbIzquierdo.Location = New System.Drawing.Point(151, 84)
        Me.lbIzquierdo.Name = "lbIzquierdo"
        Me.lbIzquierdo.Size = New System.Drawing.Size(50, 13)
        Me.lbIzquierdo.TabIndex = 5
        Me.lbIzquierdo.Text = "Numero2"
        Me.lbIzquierdo.Visible = False
        '
        'txtIzquierdo
        '
        Me.txtIzquierdo.Location = New System.Drawing.Point(154, 114)
        Me.txtIzquierdo.Name = "txtIzquierdo"
        Me.txtIzquierdo.Size = New System.Drawing.Size(100, 20)
        Me.txtIzquierdo.TabIndex = 6
        Me.txtIzquierdo.Text = "0"
        Me.txtIzquierdo.Visible = False
        '
        'txtRespuesta
        '
        Me.txtRespuesta.Location = New System.Drawing.Point(28, 217)
        Me.txtRespuesta.Name = "txtRespuesta"
        Me.txtRespuesta.Size = New System.Drawing.Size(149, 20)
        Me.txtRespuesta.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(25, 201)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(152, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "El area de la figura elegida es: "
        '
        'Clase4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtRespuesta)
        Me.Controls.Add(Me.txtIzquierdo)
        Me.Controls.Add(Me.lbIzquierdo)
        Me.Controls.Add(Me.lbDerecho)
        Me.Controls.Add(Me.cbxAreas)
        Me.Controls.Add(Me.lbTitulo)
        Me.Controls.Add(Me.txtDerecho)
        Me.Controls.Add(Me.btnAceptar)
        Me.Name = "Clase4"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnAceptar As Button
    Friend WithEvents txtDerecho As TextBox
    Friend WithEvents lbTitulo As Label
    Friend WithEvents cbxAreas As ComboBox
    Friend WithEvents lbDerecho As Label
    Friend WithEvents lbIzquierdo As Label
    Friend WithEvents txtIzquierdo As TextBox
    Friend WithEvents txtRespuesta As TextBox
    Friend WithEvents Label1 As Label
End Class
