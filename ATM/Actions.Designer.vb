<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Actions
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.WithDrwalsFrame = New System.Windows.Forms.GroupBox()
        Me.DTPWith = New System.Windows.Forms.DateTimePicker()
        Me.BtnWithOk = New System.Windows.Forms.Button()
        Me.TxtWithAmount = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtWithDetails = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtWithID = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DepositsFrame = New System.Windows.Forms.GroupBox()
        Me.DTPDeposits = New System.Windows.Forms.DateTimePicker()
        Me.BtnDepOk = New System.Windows.Forms.Button()
        Me.TxtDepAmount = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtDepDetails = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TxtDepID = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.LblUserName = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.LblBalance = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.WithDrwalsFrame.SuspendLayout()
        Me.DepositsFrame.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RadioButton2)
        Me.GroupBox1.Controls.Add(Me.RadioButton1)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(727, 79)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Font = New System.Drawing.Font("Tahoma", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.RadioButton2.Location = New System.Drawing.Point(491, 33)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(82, 20)
        Me.RadioButton2.TabIndex = 7
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "Deposits"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Font = New System.Drawing.Font("Tahoma", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton1.Location = New System.Drawing.Point(283, 33)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(100, 20)
        Me.RadioButton1.TabIndex = 6
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "WithDrwals"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(22, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(136, 14)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Choose Your Action :"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'WithDrwalsFrame
        '
        Me.WithDrwalsFrame.Controls.Add(Me.DTPWith)
        Me.WithDrwalsFrame.Controls.Add(Me.BtnWithOk)
        Me.WithDrwalsFrame.Controls.Add(Me.TxtWithAmount)
        Me.WithDrwalsFrame.Controls.Add(Me.Label3)
        Me.WithDrwalsFrame.Controls.Add(Me.TxtWithDetails)
        Me.WithDrwalsFrame.Controls.Add(Me.Label6)
        Me.WithDrwalsFrame.Controls.Add(Me.Label4)
        Me.WithDrwalsFrame.Controls.Add(Me.TxtWithID)
        Me.WithDrwalsFrame.Controls.Add(Me.Label2)
        Me.WithDrwalsFrame.Enabled = False
        Me.WithDrwalsFrame.Location = New System.Drawing.Point(12, 97)
        Me.WithDrwalsFrame.Name = "WithDrwalsFrame"
        Me.WithDrwalsFrame.Size = New System.Drawing.Size(357, 364)
        Me.WithDrwalsFrame.TabIndex = 1
        Me.WithDrwalsFrame.TabStop = False
        Me.WithDrwalsFrame.Text = "WithDrwals"
        '
        'DTPWith
        '
        Me.DTPWith.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.DTPWith.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTPWith.Location = New System.Drawing.Point(78, 106)
        Me.DTPWith.Name = "DTPWith"
        Me.DTPWith.Size = New System.Drawing.Size(252, 22)
        Me.DTPWith.TabIndex = 35
        '
        'BtnWithOk
        '
        Me.BtnWithOk.Font = New System.Drawing.Font("Tahoma", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.BtnWithOk.Location = New System.Drawing.Point(62, 305)
        Me.BtnWithOk.Name = "BtnWithOk"
        Me.BtnWithOk.Size = New System.Drawing.Size(211, 34)
        Me.BtnWithOk.TabIndex = 24
        Me.BtnWithOk.Text = "WithDrwals"
        Me.BtnWithOk.UseVisualStyleBackColor = True
        '
        'TxtWithAmount
        '
        Me.TxtWithAmount.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtWithAmount.Location = New System.Drawing.Point(113, 239)
        Me.TxtWithAmount.Name = "TxtWithAmount"
        Me.TxtWithAmount.Size = New System.Drawing.Size(105, 22)
        Me.TxtWithAmount.TabIndex = 23
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(140, 222)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 14)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "Amount :"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TxtWithDetails
        '
        Me.TxtWithDetails.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtWithDetails.Location = New System.Drawing.Point(78, 165)
        Me.TxtWithDetails.Name = "TxtWithDetails"
        Me.TxtWithDetails.Size = New System.Drawing.Size(252, 22)
        Me.TxtWithDetails.TabIndex = 21
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(6, 168)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(56, 14)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "Details :"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(18, 112)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 14)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Date :"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TxtWithID
        '
        Me.TxtWithID.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtWithID.Location = New System.Drawing.Point(78, 54)
        Me.TxtWithID.Name = "TxtWithID"
        Me.TxtWithID.ReadOnly = True
        Me.TxtWithID.Size = New System.Drawing.Size(105, 22)
        Me.TxtWithID.TabIndex = 17
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(33, 57)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(29, 14)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "ID :"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DepositsFrame
        '
        Me.DepositsFrame.Controls.Add(Me.DTPDeposits)
        Me.DepositsFrame.Controls.Add(Me.BtnDepOk)
        Me.DepositsFrame.Controls.Add(Me.TxtDepAmount)
        Me.DepositsFrame.Controls.Add(Me.Label5)
        Me.DepositsFrame.Controls.Add(Me.TxtDepDetails)
        Me.DepositsFrame.Controls.Add(Me.Label7)
        Me.DepositsFrame.Controls.Add(Me.Label8)
        Me.DepositsFrame.Controls.Add(Me.TxtDepID)
        Me.DepositsFrame.Controls.Add(Me.Label9)
        Me.DepositsFrame.Enabled = False
        Me.DepositsFrame.Location = New System.Drawing.Point(382, 97)
        Me.DepositsFrame.Name = "DepositsFrame"
        Me.DepositsFrame.Size = New System.Drawing.Size(357, 364)
        Me.DepositsFrame.TabIndex = 2
        Me.DepositsFrame.TabStop = False
        Me.DepositsFrame.Text = "Deposits"
        '
        'DTPDeposits
        '
        Me.DTPDeposits.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.DTPDeposits.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTPDeposits.Location = New System.Drawing.Point(88, 106)
        Me.DTPDeposits.Name = "DTPDeposits"
        Me.DTPDeposits.Size = New System.Drawing.Size(252, 22)
        Me.DTPDeposits.TabIndex = 35
        '
        'BtnDepOk
        '
        Me.BtnDepOk.Font = New System.Drawing.Font("Tahoma", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.BtnDepOk.Location = New System.Drawing.Point(72, 305)
        Me.BtnDepOk.Name = "BtnDepOk"
        Me.BtnDepOk.Size = New System.Drawing.Size(211, 34)
        Me.BtnDepOk.TabIndex = 33
        Me.BtnDepOk.Text = "Deposit"
        Me.BtnDepOk.UseVisualStyleBackColor = True
        '
        'TxtDepAmount
        '
        Me.TxtDepAmount.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDepAmount.Location = New System.Drawing.Point(123, 239)
        Me.TxtDepAmount.Name = "TxtDepAmount"
        Me.TxtDepAmount.Size = New System.Drawing.Size(105, 22)
        Me.TxtDepAmount.TabIndex = 32
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(150, 222)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 14)
        Me.Label5.TabIndex = 31
        Me.Label5.Text = "Amount :"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TxtDepDetails
        '
        Me.TxtDepDetails.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDepDetails.Location = New System.Drawing.Point(88, 165)
        Me.TxtDepDetails.Name = "TxtDepDetails"
        Me.TxtDepDetails.Size = New System.Drawing.Size(252, 22)
        Me.TxtDepDetails.TabIndex = 30
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(16, 168)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(56, 14)
        Me.Label7.TabIndex = 29
        Me.Label7.Text = "Details :"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(28, 112)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(44, 14)
        Me.Label8.TabIndex = 27
        Me.Label8.Text = "Date :"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TxtDepID
        '
        Me.TxtDepID.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDepID.Location = New System.Drawing.Point(88, 54)
        Me.TxtDepID.Name = "TxtDepID"
        Me.TxtDepID.ReadOnly = True
        Me.TxtDepID.Size = New System.Drawing.Size(105, 22)
        Me.TxtDepID.TabIndex = 26
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(43, 57)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(29, 14)
        Me.Label9.TabIndex = 25
        Me.Label9.Text = "ID :"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Tahoma", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Button3.Location = New System.Drawing.Point(608, 467)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(131, 27)
        Me.Button3.TabIndex = 25
        Me.Button3.Text = "Back"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(12, 473)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(92, 14)
        Me.Label10.TabIndex = 27
        Me.Label10.Text = "Current User :"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LblUserName
        '
        Me.LblUserName.AutoSize = True
        Me.LblUserName.Font = New System.Drawing.Font("Tahoma", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblUserName.Location = New System.Drawing.Point(110, 473)
        Me.LblUserName.Name = "LblUserName"
        Me.LblUserName.Size = New System.Drawing.Size(129, 14)
        Me.LblUserName.TabIndex = 28
        Me.LblUserName.Text = "Customer UserName"
        Me.LblUserName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Tahoma", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(43, 495)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(61, 14)
        Me.Label11.TabIndex = 29
        Me.Label11.Text = "Balance :"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LblBalance
        '
        Me.LblBalance.AutoSize = True
        Me.LblBalance.Font = New System.Drawing.Font("Tahoma", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblBalance.Location = New System.Drawing.Point(110, 495)
        Me.LblBalance.Name = "LblBalance"
        Me.LblBalance.Size = New System.Drawing.Size(85, 14)
        Me.LblBalance.TabIndex = 30
        Me.LblBalance.Text = "Your Balance"
        Me.LblBalance.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Actions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(751, 518)
        Me.Controls.Add(Me.LblBalance)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.LblUserName)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.DepositsFrame)
        Me.Controls.Add(Me.WithDrwalsFrame)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Actions"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Actions"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.WithDrwalsFrame.ResumeLayout(False)
        Me.WithDrwalsFrame.PerformLayout()
        Me.DepositsFrame.ResumeLayout(False)
        Me.DepositsFrame.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents WithDrwalsFrame As System.Windows.Forms.GroupBox
    Friend WithEvents DepositsFrame As System.Windows.Forms.GroupBox
    Friend WithEvents TxtWithDetails As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TxtWithID As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TxtWithAmount As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents BtnWithOk As System.Windows.Forms.Button
    Friend WithEvents BtnDepOk As System.Windows.Forms.Button
    Friend WithEvents TxtDepAmount As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TxtDepDetails As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TxtDepID As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents DTPWith As System.Windows.Forms.DateTimePicker
    Friend WithEvents DTPDeposits As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents LblUserName As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents LblBalance As System.Windows.Forms.Label
End Class
