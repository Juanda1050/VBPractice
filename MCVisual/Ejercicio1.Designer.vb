<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Ejercicio1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btnCalif = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtCalif = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtMensaje = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnCalif
        '
        Me.btnCalif.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCalif.Location = New System.Drawing.Point(231, 180)
        Me.btnCalif.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnCalif.Name = "btnCalif"
        Me.btnCalif.Size = New System.Drawing.Size(82, 22)
        Me.btnCalif.TabIndex = 0
        Me.btnCalif.Text = "Calificar"
        Me.btnCalif.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(82, 126)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 15)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Calificación:"
        '
        'txtCalif
        '
        Me.txtCalif.Location = New System.Drawing.Point(201, 121)
        Me.txtCalif.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtCalif.Name = "txtCalif"
        Me.txtCalif.Size = New System.Drawing.Size(198, 23)
        Me.txtCalif.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(220, 27)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 21)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Ejercicio No.1"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(82, 76)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(361, 15)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Determinar el alumno cuenta con una calificación aprobatoria o no"
        '
        'txtMensaje
        '
        Me.txtMensaje.AutoSize = True
        Me.txtMensaje.Location = New System.Drawing.Point(433, 123)
        Me.txtMensaje.Name = "txtMensaje"
        Me.txtMensaje.Size = New System.Drawing.Size(0, 15)
        Me.txtMensaje.TabIndex = 5
        '
        'Ejercicio1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(588, 246)
        Me.Controls.Add(Me.txtMensaje)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtCalif)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnCalif)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Ejercicio1"
        Me.Text = "Programación Visual"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnCalif As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtCalif As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtMensaje As Label
End Class
