<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox_ValorAngulo = New System.Windows.Forms.TextBox()
        Me.Button_Calcular = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox_Seno = New System.Windows.Forms.TextBox()
        Me.TextBox_Coseno = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(61, 79)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(154, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Ingrese el valor del ángulo "
        '
        'TextBox_ValorAngulo
        '
        Me.TextBox_ValorAngulo.Location = New System.Drawing.Point(266, 79)
        Me.TextBox_ValorAngulo.Name = "TextBox_ValorAngulo"
        Me.TextBox_ValorAngulo.Size = New System.Drawing.Size(260, 20)
        Me.TextBox_ValorAngulo.TabIndex = 1
        '
        'Button_Calcular
        '
        Me.Button_Calcular.Location = New System.Drawing.Point(560, 75)
        Me.Button_Calcular.Name = "Button_Calcular"
        Me.Button_Calcular.Size = New System.Drawing.Size(99, 27)
        Me.Button_Calcular.TabIndex = 2
        Me.Button_Calcular.Text = "Calcular"
        Me.Button_Calcular.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(200, 171)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 15)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Seno:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(187, 208)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 15)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Coseno:"
        '
        'TextBox_Seno
        '
        Me.TextBox_Seno.Location = New System.Drawing.Point(245, 171)
        Me.TextBox_Seno.Name = "TextBox_Seno"
        Me.TextBox_Seno.ReadOnly = True
        Me.TextBox_Seno.Size = New System.Drawing.Size(148, 20)
        Me.TextBox_Seno.TabIndex = 5
        '
        'TextBox_Coseno
        '
        Me.TextBox_Coseno.Location = New System.Drawing.Point(245, 208)
        Me.TextBox_Coseno.Name = "TextBox_Coseno"
        Me.TextBox_Coseno.ReadOnly = True
        Me.TextBox_Coseno.Size = New System.Drawing.Size(148, 20)
        Me.TextBox_Coseno.TabIndex = 6
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(766, 450)
        Me.Controls.Add(Me.TextBox_Coseno)
        Me.Controls.Add(Me.TextBox_Seno)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button_Calcular)
        Me.Controls.Add(Me.TextBox_ValorAngulo)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Cálculo Trigonométrico"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox_ValorAngulo As TextBox
    Friend WithEvents Button_Calcular As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox_Seno As TextBox
    Friend WithEvents TextBox_Coseno As TextBox
End Class
