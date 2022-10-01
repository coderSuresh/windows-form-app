Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a, b, c, greatest As Integer
        a = Int(TextBox1.Text)
        b = Int(TextBox2.Text)
        c = Int(TextBox3.Text)
        If (a > b) Then
            If (a > c) Then
                greatest = a
            Else greatest = c
            End If
        Else
            If (b > c) Then
                greatest = b
            Else greatest = c
            End If
        End If
        MessageBox.Show(greatest & " is the greatest number from")
    End Sub
End Class
