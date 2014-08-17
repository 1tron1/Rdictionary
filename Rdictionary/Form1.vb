Imports System.Text

Public Class Form1

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged


    End Sub
    Sub ALL()
        Dim s As String = "ABCDEFGHIJKLMNOPQURSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789:;"".,/\|{}[]()~`@#$%^&*+=_-"
        Dim r As New Random


        Dim sb As New StringBuilder
        For i As Integer = 1 To (number.Text)
            Dim idx As Integer = r.Next(0, 90)
            sb.Append(s.Substring(idx, 1))
            TextBox1.Text = sb.ToString
        Next
    End Sub

    Sub LetterOnly()
        Dim s As String = "ABCDEFGHIJKLMNOPQURSTUVWXYZabcdefghijklmnopqrstuvwxyz"
        Dim r As New Random


        Dim sb As New StringBuilder
        For i As Integer = 1 To (number.Text)
            Dim idx As Integer = r.Next(0, 52)
            sb.Append(s.Substring(idx, 1))
            TextBox1.Text = sb.ToString
        Next
    End Sub

    Sub Main()

        Dim s As String = "ABCDEFGHIJKLMNOPQURSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789"
        Dim r As New Random


        Dim sb As New StringBuilder
        For i As Integer = 1 To (number.Text)
            Dim idx As Integer = r.Next(0, 62)
            sb.Append(s.Substring(idx, 1))
            TextBox1.Text = sb.ToString


        Next



    End Sub

    Private Sub Gen_Tick(sender As Object, e As EventArgs) Handles Gen.Tick
        Main()
        Dim file As System.IO.StreamWriter
        file = My.Computer.FileSystem.OpenTextFileWriter("C:/Users/Dan/Desktop/dictionary.txt", True)
        file.WriteLine(TextBox1.Text)
        file.Close()
    End Sub

    Private Sub number_TextChanged(sender As Object, e As EventArgs) Handles number.TextChanged

    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Gen.Enabled = True
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Gen.Enabled = False
        letter.Enabled = False
        Allvals.Enabled = False
    End Sub

    Private Sub letter_Tick(sender As Object, e As EventArgs) Handles letter.Tick
        LetterOnly()
        Dim file As System.IO.StreamWriter
        file = My.Computer.FileSystem.OpenTextFileWriter("C:/Users/Dan/Desktop/dictionary.txt", True)
        file.WriteLine(TextBox1.Text)
        file.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        letter.Enabled = True
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Allvals.Enabled = True
    End Sub

    Private Sub Allvals_Tick(sender As Object, e As EventArgs) Handles Allvals.Tick
        ALL()
        Dim file As System.IO.StreamWriter
        file = My.Computer.FileSystem.OpenTextFileWriter("C:/Users/Dan/Desktop/dictionary.txt", True)
        file.WriteLine(TextBox1.Text)
        file.Close()
    End Sub
End Class
