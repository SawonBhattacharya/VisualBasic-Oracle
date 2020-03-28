Public Class Form5

    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet111.ADMISSION' table. You can move, or remove it, as needed.
        'TODO: This line of code loads data into the 'DataSet11.ADMISSION' table. You can move, or remove it, as needed.


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ADMISSIONTableAdapter.Insert(TextBox1.Text, TextBox2.Text, TextBox3.Text, TextBox4.Text, TextBox5.Text, TextBox6.Text)
        Me.DataSet111.PERSONAL_DETAILS.AcceptChanges()
        MessageBox.Show("Your database has been updated!!!")
        Me.Hide()
        Form7.Show()
    End Sub
End Class