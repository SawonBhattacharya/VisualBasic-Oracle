Public Class Form6

    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet111.PAYMENT_DETAILS' table. You can move, or remove it, as needed.
       
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        PAYMENT_DETAILSTableAdapter.Insert(TextBox1.Text, TextBox2.Text, TextBox3.Text, TextBox4.Text, TextBox5.Text)
        Me.DataSet111.PAYMENT_DETAILS.AcceptChanges()
        Me.Hide()
        MsgBox("Data Successfuly Inserted ")

    End Sub
End Class