Imports System.IO
Public Class Form1
    Dim fs As FileStream
    Dim sw As StreamWriter
    Dim sr As StreamReader
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        fs = New FileStream("D:\emp.dat", FileMode.OpenOrCreate, FileAccess.ReadWrite)
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim name, address As String
        Dim salary As Integer

        'get data from the form
        name = TextBox1.Text
        address = TextBox2.Text
        salary = Int(TextBox3.Text)

        sw = New StreamWriter(fs)
        sw.WriteLine(name & vbCrLf & address & vbCrLf & salary)
        sw.Close()
        MessageBox.Show("File written successfully")
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        sr = New StreamReader(fs)
        MessageBox.Show(sr.ReadToEnd())
        sr.Close()

    End Sub
End Class
