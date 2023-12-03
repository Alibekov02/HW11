<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Форма переопределяет dispose для очистки списка компонентов.
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

    'Является обязательной для конструктора форм Windows Forms
    Private components As System.ComponentModel.IContainer

    'Примечание: следующая процедура является обязательной для конструктора форм Windows Forms
    'Для ее изменения используйте конструктор форм Windows Form.  
    'Не изменяйте ее в редакторе исходного кода.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.MonthCalendar1 = New System.Windows.Forms.MonthCalendar()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(513, 18)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(386, 408)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Button1.Location = New System.Drawing.Point(25, 18)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(190, 101)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Суротту танда"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 249)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(185, 25)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Учурдагы убакыт"
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Button2.Location = New System.Drawing.Point(73, 299)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(122, 45)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Башта"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        '
        'MonthCalendar1
        '
        Me.MonthCalendar1.Location = New System.Drawing.Point(227, 18)
        Me.MonthCalendar1.Name = "MonthCalendar1"
        Me.MonthCalendar1.TabIndex = 4
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(942, 486)
        Me.Controls.Add(Me.MonthCalendar1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Form2"
        Me.Text = "Сурот менен иштоо"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents MonthCalendar1 As MonthCalendar
End Class
