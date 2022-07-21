Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim date1, date2 As Date
        Dim datet As TimeSpan
        Dim diff As Double
        Dim year, month, day, year1 As Integer
        date1 = DateTimePicker1.Value.ToShortDateString
        date2 = DateTimePicker2.Value.ToShortDateString
        datet = date2 - date1
        diff = datet.Days
        year = Int(diff / 365)
        year1 = diff Mod 365
        month = Int(year1 / 30)
        day = Int(year1 Mod 30)
        lyear.Text = year
        lmonths.Text = month
        ldays.Text = day
    End Sub
End Class
