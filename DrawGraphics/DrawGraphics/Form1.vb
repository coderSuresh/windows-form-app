Imports System.Drawing.Drawing2D
Public Class Form1
    Dim g As Graphics
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        g = Panel1.CreateGraphics()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Panel1.Refresh()
        Dim r As New Rectangle(10, 10, 100, 100)
        g.DrawRectangle(Pens.Red, r)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Panel1.Refresh()
        Dim r As New Rectangle(10, 10, 100, 100)
        g.DrawEllipse(Pens.Purple, r)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Panel1.Refresh()
        Dim r As New Rectangle(10, 10, 100, 200)
        g.DrawEllipse(Pens.Purple, r)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Panel1.Refresh()
        g.DrawLine(Pens.Blue, 20, 30, 20, 200)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Panel1.Refresh()
        Dim p(3) As Point
        p(0) = New Point(20, 30)
        p(1) = New Point(50, 10)
        p(2) = New Point(30, 40)
        g.DrawPolygon(Pens.Purple, p)
    End Sub
End Class
