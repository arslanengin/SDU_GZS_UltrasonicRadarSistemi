Imports System.IO.Ports

Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If My.Settings.user.Contains(TextBox1.Text) = True Then
            If My.Settings.pass.Contains(TextBox2.Text) = True Then
                If Not ComboBox1.Text = "" Then
                    My.Settings.port = ComboBox1.Text
                    My.Settings.Save()
                    Form2.Show()
                    Me.Close()
                Else
                    MsgBox("PORT ADI BOŞ OLAMAZ")
                End If
            Else
                MsgBox("HATALI PAROLA")
            End If
        Else
            MsgBox("HATALI KULLANICI ADI")
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.Items.Clear()
        For Each pr In My.Computer.Ports.SerialPortNames
            ComboBox1.Items.Add(pr)
        Next
    End Sub
End Class
