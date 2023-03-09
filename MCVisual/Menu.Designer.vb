<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Menu
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnEjercicio1 = New System.Windows.Forms.Button()
        Me.btnEjercicio2 = New System.Windows.Forms.Button()
        Me.btnEjercicio3 = New System.Windows.Forms.Button()
        Me.btnEjercicio5 = New System.Windows.Forms.Button()
        Me.btnEjercicio4 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(152, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(157, 21)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Examen Medio Curso"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(119, 82)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(220, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Selecciona el ejercicio que deseas revisar"
        '
        'btnEjercicio1
        '
        Me.btnEjercicio1.Location = New System.Drawing.Point(97, 135)
        Me.btnEjercicio1.Name = "btnEjercicio1"
        Me.btnEjercicio1.Size = New System.Drawing.Size(104, 31)
        Me.btnEjercicio1.TabIndex = 2
        Me.btnEjercicio1.Text = "Ejercicio No.1"
        Me.btnEjercicio1.UseVisualStyleBackColor = True
        '
        'btnEjercicio2
        '
        Me.btnEjercicio2.Location = New System.Drawing.Point(97, 188)
        Me.btnEjercicio2.Name = "btnEjercicio2"
        Me.btnEjercicio2.Size = New System.Drawing.Size(104, 31)
        Me.btnEjercicio2.TabIndex = 3
        Me.btnEjercicio2.Text = "Ejercicio No.2"
        Me.btnEjercicio2.UseVisualStyleBackColor = True
        '
        'btnEjercicio3
        '
        Me.btnEjercicio3.Location = New System.Drawing.Point(97, 245)
        Me.btnEjercicio3.Name = "btnEjercicio3"
        Me.btnEjercicio3.Size = New System.Drawing.Size(104, 31)
        Me.btnEjercicio3.TabIndex = 4
        Me.btnEjercicio3.Text = "Ejercicio No.3"
        Me.btnEjercicio3.UseVisualStyleBackColor = True
        '
        'btnEjercicio5
        '
        Me.btnEjercicio5.Location = New System.Drawing.Point(263, 188)
        Me.btnEjercicio5.Name = "btnEjercicio5"
        Me.btnEjercicio5.Size = New System.Drawing.Size(104, 31)
        Me.btnEjercicio5.TabIndex = 6
        Me.btnEjercicio5.Text = "Ejercicio No.5"
        Me.btnEjercicio5.UseVisualStyleBackColor = True
        '
        'btnEjercicio4
        '
        Me.btnEjercicio4.Location = New System.Drawing.Point(263, 135)
        Me.btnEjercicio4.Name = "btnEjercicio4"
        Me.btnEjercicio4.Size = New System.Drawing.Size(104, 31)
        Me.btnEjercicio4.TabIndex = 5
        Me.btnEjercicio4.Text = "Ejercicio No.4"
        Me.btnEjercicio4.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(40, 320)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 15)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Nombre"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(40, 348)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 15)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Matrícula"
        '
        'Menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(471, 385)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnEjercicio5)
        Me.Controls.Add(Me.btnEjercicio4)
        Me.Controls.Add(Me.btnEjercicio3)
        Me.Controls.Add(Me.btnEjercicio2)
        Me.Controls.Add(Me.btnEjercicio1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Menu"
        Me.Text = "Menu Programación Visual"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnEjercicio1 As Button
    Friend WithEvents btnEjercicio2 As Button
    Friend WithEvents btnEjercicio3 As Button
    Friend WithEvents btnEjercicio5 As Button
    Friend WithEvents btnEjercicio4 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
End Class
