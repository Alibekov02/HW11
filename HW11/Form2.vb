Imports System.Reflection.Emit
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form2
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim filePath As String
        Dim openFileDialog1 As New OpenFileDialog()

        ' Задаем свойства диалогового окна
        openFileDialog1.Title = "Выберите файл"
        'openFileDialog1.Filter = "Текстовые файлы (*.txt)|*.txt|Все файлы (*.*)|*.*"

        ' Открываем диалоговое окно
        If openFileDialog1.ShowDialog() = DialogResult.OK Then
            ' Получаем путь к выбранному файлу
            Dim selectedFilePath As String = openFileDialog1.FileName

            ' Здесь можно выполнить нужные действия с выбранным файлом
            ' Например, вывести путь к файлу в текстовое поле
            filePath = selectedFilePath
            PictureBox1.Image = System.Drawing.Image.FromFile(filePath)

            ' Устанавливаем новое максимальное значение HScrollBar
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Label1.Text = System.DateTime.Now.ToLongDateString + " " + System.DateTime.Now.ToLongTimeString
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Me.Label1.Text = System.DateTime.Now.ToLongDateString + " " + System.DateTime.Now.ToLongTimeString
    End Sub
End Class