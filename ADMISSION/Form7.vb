Public Class Form7

    Private Sub Form7_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet111.PAYMENT_DETAILS' table. You can move, or remove it, as needed.
        Me.PAYMENT_DETAILSTableAdapter.Fill(Me.DataSet111.PAYMENT_DETAILS)
        'TODO: This line of code loads data into the 'DataSet111.PERSONAL_DETAILS' table. You can move, or remove it, as needed.
        Me.PERSONAL_DETAILSTableAdapter.Fill(Me.DataSet111.PERSONAL_DETAILS)
        'TODO: This line of code loads data into the 'DataSet111.RANK' table. You can move, or remove it, as needed.
        Me.RANKTableAdapter.Fill(Me.DataSet111.RANK)
        'TODO: This line of code loads data into the 'DataSet111.STUDENT' table. You can move, or remove it, as needed.
        Me.STUDENTTableAdapter.Fill(Me.DataSet111.STUDENT)
        'TODO: This line of code loads data into the 'DataSet111.ADMISSION' table. You can move, or remove it, as needed.
        Me.ADMISSIONTableAdapter.Fill(Me.DataSet111.ADMISSION)
        'TODO: This line of code loads data into the 'DataSet111.ADDRESS' table. You can move, or remove it, as needed.
        Me.ADDRESSTableAdapter.Fill(Me.DataSet111.ADDRESS)
        'TODO: This line of code loads data into the 'DataSet11.STUDENT' table. You can move, or remove it, as needed.
        

        DataGridView1.DataSource = BindingSource1
        DataGridView2.DataSource = BindingSource2
        DataGridView3.DataSource = BindingSource3
        DataGridView4.DataSource = BindingSource4
        DataGridView5.DataSource = BindingSource5
        DataGridView6.DataSource = BindingSource6

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Application.Exit()
     
    End Sub
End Class