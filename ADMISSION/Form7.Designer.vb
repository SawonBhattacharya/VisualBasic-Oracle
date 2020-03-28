<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form7
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.DataGridView6 = New System.Windows.Forms.DataGridView()
        Me.DataGridView5 = New System.Windows.Forms.DataGridView()
        Me.DataGridView4 = New System.Windows.Forms.DataGridView()
        Me.DataGridView3 = New System.Windows.Forms.DataGridView()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.DataSet111 = New ADMISSION.DataSet11()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.BindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.BindingSource3 = New System.Windows.Forms.BindingSource(Me.components)
        Me.BindingSource4 = New System.Windows.Forms.BindingSource(Me.components)
        Me.BindingSource5 = New System.Windows.Forms.BindingSource(Me.components)
        Me.BindingSource6 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ADDRESSTableAdapter = New ADMISSION.DataSet11TableAdapters.ADDRESSTableAdapter()
        Me.ADMISSIONTableAdapter = New ADMISSION.DataSet11TableAdapters.ADMISSIONTableAdapter()
        Me.STUDENTTableAdapter = New ADMISSION.DataSet11TableAdapters.STUDENTTableAdapter()
        Me.RANKTableAdapter = New ADMISSION.DataSet11TableAdapters.RANKTableAdapter()
        Me.PERSONAL_DETAILSTableAdapter = New ADMISSION.DataSet11TableAdapters.PERSONAL_DETAILSTableAdapter()
        Me.PAYMENT_DETAILSTableAdapter = New ADMISSION.DataSet11TableAdapters.PAYMENT_DETAILSTableAdapter()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.DataGridView6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet111, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView6
        '
        Me.DataGridView6.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.DataGridView6.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView6.Location = New System.Drawing.Point(695, 271)
        Me.DataGridView6.Margin = New System.Windows.Forms.Padding(2)
        Me.DataGridView6.Name = "DataGridView6"
        Me.DataGridView6.RowTemplate.Height = 24
        Me.DataGridView6.Size = New System.Drawing.Size(292, 254)
        Me.DataGridView6.TabIndex = 1
        '
        'DataGridView5
        '
        Me.DataGridView5.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.DataGridView5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView5.Location = New System.Drawing.Point(376, 271)
        Me.DataGridView5.Margin = New System.Windows.Forms.Padding(2)
        Me.DataGridView5.Name = "DataGridView5"
        Me.DataGridView5.RowTemplate.Height = 24
        Me.DataGridView5.Size = New System.Drawing.Size(292, 254)
        Me.DataGridView5.TabIndex = 2
        '
        'DataGridView4
        '
        Me.DataGridView4.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.DataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView4.Location = New System.Drawing.Point(59, 271)
        Me.DataGridView4.Margin = New System.Windows.Forms.Padding(2)
        Me.DataGridView4.Name = "DataGridView4"
        Me.DataGridView4.RowTemplate.Height = 24
        Me.DataGridView4.Size = New System.Drawing.Size(292, 254)
        Me.DataGridView4.TabIndex = 3
        '
        'DataGridView3
        '
        Me.DataGridView3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.DataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView3.Location = New System.Drawing.Point(695, 1)
        Me.DataGridView3.Margin = New System.Windows.Forms.Padding(2)
        Me.DataGridView3.Name = "DataGridView3"
        Me.DataGridView3.RowTemplate.Height = 24
        Me.DataGridView3.Size = New System.Drawing.Size(292, 248)
        Me.DataGridView3.TabIndex = 4
        '
        'DataGridView2
        '
        Me.DataGridView2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Location = New System.Drawing.Point(376, 1)
        Me.DataGridView2.Margin = New System.Windows.Forms.Padding(2)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.RowTemplate.Height = 24
        Me.DataGridView2.Size = New System.Drawing.Size(292, 248)
        Me.DataGridView2.TabIndex = 5
        '
        'DataGridView1
        '
        Me.DataGridView1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(59, 1)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(2)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(292, 248)
        Me.DataGridView1.TabIndex = 6
        '
        'DataSet111
        '
        Me.DataSet111.DataSetName = "DataSet11"
        Me.DataSet111.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BindingSource1
        '
        Me.BindingSource1.DataMember = "ADDRESS"
        Me.BindingSource1.DataSource = Me.DataSet111
        '
        'BindingSource2
        '
        Me.BindingSource2.DataMember = "ADMISSION"
        Me.BindingSource2.DataSource = Me.DataSet111
        '
        'BindingSource3
        '
        Me.BindingSource3.DataMember = "PAYMENT_DETAILS"
        Me.BindingSource3.DataSource = Me.DataSet111
        '
        'BindingSource4
        '
        Me.BindingSource4.DataMember = "PERSONAL_DETAILS"
        Me.BindingSource4.DataSource = Me.DataSet111
        '
        'BindingSource5
        '
        Me.BindingSource5.DataMember = "RANK"
        Me.BindingSource5.DataSource = Me.DataSet111
        '
        'BindingSource6
        '
        Me.BindingSource6.DataMember = "STUDENT"
        Me.BindingSource6.DataSource = Me.DataSet111
        '
        'ADDRESSTableAdapter
        '
        Me.ADDRESSTableAdapter.ClearBeforeFill = True
        '
        'ADMISSIONTableAdapter
        '
        Me.ADMISSIONTableAdapter.ClearBeforeFill = True
        '
        'STUDENTTableAdapter
        '
        Me.STUDENTTableAdapter.ClearBeforeFill = True
        '
        'RANKTableAdapter
        '
        Me.RANKTableAdapter.ClearBeforeFill = True
        '
        'PERSONAL_DETAILSTableAdapter
        '
        Me.PERSONAL_DETAILSTableAdapter.ClearBeforeFill = True
        '
        'PAYMENT_DETAILSTableAdapter
        '
        Me.PAYMENT_DETAILSTableAdapter.ClearBeforeFill = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(440, 543)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(167, 25)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "EXIT"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form7
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1046, 582)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DataGridView6)
        Me.Controls.Add(Me.DataGridView5)
        Me.Controls.Add(Me.DataGridView4)
        Me.Controls.Add(Me.DataGridView3)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Form7"
        Me.Text = "Form7"
        CType(Me.DataGridView6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet111, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridView6 As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridView5 As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridView4 As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridView3 As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents DataSet111 As ADMISSION.DataSet11
    Friend WithEvents BindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents BindingSource2 As System.Windows.Forms.BindingSource
    Friend WithEvents BindingSource3 As System.Windows.Forms.BindingSource
    Friend WithEvents BindingSource4 As System.Windows.Forms.BindingSource
    Friend WithEvents BindingSource5 As System.Windows.Forms.BindingSource
    Friend WithEvents BindingSource6 As System.Windows.Forms.BindingSource
    Friend WithEvents ADDRESSTableAdapter As ADMISSION.DataSet11TableAdapters.ADDRESSTableAdapter
    Friend WithEvents ADMISSIONTableAdapter As ADMISSION.DataSet11TableAdapters.ADMISSIONTableAdapter
    Friend WithEvents STUDENTTableAdapter As ADMISSION.DataSet11TableAdapters.STUDENTTableAdapter
    Friend WithEvents RANKTableAdapter As ADMISSION.DataSet11TableAdapters.RANKTableAdapter
    Friend WithEvents PERSONAL_DETAILSTableAdapter As ADMISSION.DataSet11TableAdapters.PERSONAL_DETAILSTableAdapter
    Friend WithEvents PAYMENT_DETAILSTableAdapter As ADMISSION.DataSet11TableAdapters.PAYMENT_DETAILSTableAdapter
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
