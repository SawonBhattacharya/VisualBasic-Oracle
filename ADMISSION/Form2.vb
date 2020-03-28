Public Class Form2

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet111.ADDRESS' table. You can move, or remove it, as needed.

        'TODO: This line of code loads data into the 'DataSet11.ADDRESS' table. You can move, or remove it, as needed.
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If IsNumeric(TextBox5.Text) Then
            ADDRESSTableAdapter.Insert(TextBox1.Text, TextBox2.Text, TextBox3.Text, TextBox4.Text, TextBox5.Text, TextBox7.Text, TextBox6.Text)
            Me.DataSet111.ADDRESS.AcceptChanges()
            Me.Hide()
            Form3.Show()
        Else
            MessageBox.Show("Only use numbers", Label6.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
    Private Sub Form2_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Application.Exit()
    End Sub
End Class