Public Class Form4

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet111.RANK' table. You can move, or remove it, as needed.

        'TODO: This line of code loads data into the 'DataSet1.RANK' table. You can move, or remove it, as needed.


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        RANKTableAdapter.Insert(TextBox1.Text, TextBox2.Text, TextBox3.Text, TextBox4.Text, TextBox5.Text)
        Me.DataSet111.RANK.AcceptChanges()
        Me.Hide()
        Form5.Show()
    End Sub
End Class