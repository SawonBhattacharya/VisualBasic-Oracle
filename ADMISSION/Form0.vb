Public Class Form0

    Private Sub Form0_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Button3.Hide()
        Label2.Hide()
        Label3.Hide()
        TextBox1.Hide()
        TextBox2.Hide()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Button1.Hide()
        Button2.Hide()
        Button5.Hide()
        Label2.Show()
        Label3.Show()
        Button3.Show()
        TextBox1.Show()
        TextBox2.Show()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim user As String, pass As String
        user = TextBox1.Text
        pass = TextBox2.Text
        If String.Compare(user, "SYSTEM") = 0 And String.Compare(pass, "system") = 0 Then
            Me.Hide()
            Form7.Show()
        Else
            MsgBox("LogIn denied!!!Wring User_ID/Password")

        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Form1.Show()

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Hide()
        Form5.Show()
    End Sub
End Class