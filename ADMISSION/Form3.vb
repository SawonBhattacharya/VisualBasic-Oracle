Public Class Form3

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet111.PERSONAL_DETAILS' table. You can move, or remove it, as needed.



    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If IsDate(TextBox6.Text) And IsNumeric(TextBox4.Text) Then
            PERSONAL_DETAILSTableAdapter.Insert(TextBox1.Text, TextBox2.Text, TextBox3.Text, TextBox4.Text, TextBox5.Text, TextBox6.Text)
            Me.DataSet111.PERSONAL_DETAILS.AcceptChanges()
            MessageBox.Show("You have successfully registered!!!")
            Me.Hide()
            Form0.Show()
        Else
            MessageBox.Show("Only use numbers", Label4.Text + " & " + Label8.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
End Class