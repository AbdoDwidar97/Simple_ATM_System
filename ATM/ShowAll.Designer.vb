<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ShowAll
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
        Me.BtnBack = New System.Windows.Forms.Button()
        Me.GridResult = New System.Windows.Forms.DataGridView()
        Me.Uname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Job = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Phone = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Mobile = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Email = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Address = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UserName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Pass = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.City = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.GridResult, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnBack
        '
        Me.BtnBack.Font = New System.Drawing.Font("Tahoma", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBack.Location = New System.Drawing.Point(910, 420)
        Me.BtnBack.Name = "BtnBack"
        Me.BtnBack.Size = New System.Drawing.Size(148, 31)
        Me.BtnBack.TabIndex = 2
        Me.BtnBack.Text = "Back"
        Me.BtnBack.UseVisualStyleBackColor = True
        '
        'GridResult
        '
        Me.GridResult.AllowUserToOrderColumns = True
        Me.GridResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GridResult.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Uname, Me.Job, Me.Phone, Me.Mobile, Me.Email, Me.Address, Me.UserName, Me.Pass, Me.City})
        Me.GridResult.Location = New System.Drawing.Point(12, 12)
        Me.GridResult.Name = "GridResult"
        Me.GridResult.Size = New System.Drawing.Size(1046, 402)
        Me.GridResult.TabIndex = 3
        '
        'Uname
        '
        Me.Uname.HeaderText = "Name"
        Me.Uname.Name = "Uname"
        '
        'Job
        '
        Me.Job.HeaderText = "Job"
        Me.Job.Name = "Job"
        '
        'Phone
        '
        Me.Phone.HeaderText = "Phone"
        Me.Phone.Name = "Phone"
        '
        'Mobile
        '
        Me.Mobile.HeaderText = "Mobile"
        Me.Mobile.Name = "Mobile"
        '
        'Email
        '
        Me.Email.HeaderText = "Email"
        Me.Email.Name = "Email"
        '
        'Address
        '
        Me.Address.HeaderText = "Address"
        Me.Address.Name = "Address"
        '
        'UserName
        '
        Me.UserName.HeaderText = "UserName"
        Me.UserName.Name = "UserName"
        '
        'Pass
        '
        Me.Pass.HeaderText = "Pass"
        Me.Pass.Name = "Pass"
        '
        'City
        '
        Me.City.HeaderText = "City"
        Me.City.Name = "City"
        '
        'ShowAll
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1070, 460)
        Me.Controls.Add(Me.GridResult)
        Me.Controls.Add(Me.BtnBack)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "ShowAll"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Show All Customers"
        CType(Me.GridResult, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BtnBack As System.Windows.Forms.Button
    Private WithEvents GridResult As System.Windows.Forms.DataGridView
    Friend WithEvents Uname As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Job As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Phone As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Mobile As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Email As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Address As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UserName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Pass As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents City As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
