Imports System.Reflection.Emit

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label1.Text = "Welcome in Digital Clock"
        Label2.Text = Date.Now.ToString("hh:mm:ss")
        Label3.Text = Date.Now.ToString("tt")
        Label4.Text = Date.Now.ToString("dddd")
        Label5.Text = Date.Now.Date
        Label7.Text = "Time"
        Label8.Text = "Day"
        Label9.Text = "Date"

    End Sub


End Class
