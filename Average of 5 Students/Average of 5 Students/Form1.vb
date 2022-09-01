Public Class Form1
    Dim NameInput(5) As String
    Dim age(5) As Integer
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For i = 0 To 4
            NameInput(i) = InputBox("Enter a name", "Input")
            ListBox1.Items.Add(Name(i))
            age(i) = Int(InputBox("Enter the age", "Input"))
            ListBox1.Items.Add(age(i))
        Next
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim avg As Decimal
        Dim sum As Integer = 0
        For i = 0 To 4
            sum += age(i)
        Next
        avg = sum / 5
        MessageBox.Show("The average of age is " & avg)
    End Sub
End Class
