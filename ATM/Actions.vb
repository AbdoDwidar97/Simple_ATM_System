Imports System.Data.SqlClient

Public Class Actions

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnWithOk.Click

        '--------------------------------------------------------------------------------------------------------------------------------------------------
        Dim AllBalance As Decimal = LblBalance.Text
        Dim WithDrawalsBalance As Decimal = TxtWithAmount.Text

        If WithDrawalsBalance > AllBalance Then
            MsgBox("Sorry , Your Balance Is Not Enough For WithDrawals", MsgBoxStyle.Critical, "Error")
            Exit Sub
        End If

        '--------------------------------------------------------------------------------------------------------------------------------------------------
        Dim Conn As New SqlConnection
        Conn.ConnectionString = "Data Source=.;Initial Catalog=ATMDB;Integrated Security=True"
        Dim Comm As New SqlCommand
        Comm.Connection = Conn

        Comm.CommandText = "INSERT INTO WithDrawalsData (CustomerUname, CustomerID, Date, Details, Amount) VALUES (@CUName,@CID,@Date,@Details,@Amount)"

        Dim Prams(4) As SqlParameter
        Prams(0) = New SqlParameter("@CID", TxtWithID.Text)
        Prams(1) = New SqlParameter("@Date", DTPWith.Text)
        Prams(2) = New SqlParameter("@Details", TxtWithDetails.Text)
        Prams(3) = New SqlParameter("@Amount", TxtWithAmount.Text)
        Prams(4) = New SqlParameter("@CUName", LblUserName.Text)
        Comm.Parameters.AddRange(Prams)

        Conn.Open()

        Dim Es As Integer = Comm.ExecuteNonQuery()
        If Es > -1 Then
            MsgBox("withDrawal Action Done Successfully", MsgBoxStyle.Information, "Done")

            TxtWithAmount.Text = ""
            TxtWithDetails.Text = ""

            LblBalance.Text = SettingDB.GetAllBalance(LblUserName.Text)

        Else
            MsgBox("Some error Occured , Try Again", MsgBoxStyle.Critical, "Error")
        End If

        Conn.Close()

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Close()
        Form1.Show()

    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged

        WithDrwalsFrame.Enabled = True
        DepositsFrame.Enabled = False

    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged

        WithDrwalsFrame.Enabled = False
        DepositsFrame.Enabled = True

    End Sub

    Private Sub BtnDepOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDepOk.Click

        Dim Conn As New SqlConnection
        Conn.ConnectionString = "Data Source=.;Initial Catalog=ATMDB;Integrated Security=True"
        Dim Comm As New SqlCommand
        Comm.Connection = Conn

        Comm.CommandText = "INSERT INTO DepositsData (CustomerUname, CustomerID, Date, Details, Amount) VALUES (@CUName,@CID,@Date,@Details,@Amount)"

        Dim Prams(4) As SqlParameter
        Prams(0) = New SqlParameter("@CID", TxtDepID.Text)
        Prams(1) = New SqlParameter("@Date", DTPDeposits.Text)
        Prams(2) = New SqlParameter("@Details", TxtDepDetails.Text)
        Prams(3) = New SqlParameter("@Amount", TxtDepAmount.Text)
        Prams(4) = New SqlParameter("@CUName", LblUserName.Text)
        Comm.Parameters.AddRange(Prams)

        Conn.Open()

        Dim Es As Integer = Comm.ExecuteNonQuery()
        If Es > -1 Then
            MsgBox("Deposit Action Done Successfully", MsgBoxStyle.Information, "Done")

            TxtDepAmount.Text = ""
            TxtDepDetails.Text = ""

            LblBalance.Text = SettingDB.GetAllBalance(LblUserName.Text)

        Else
            MsgBox("Some error Occured , Try Again", MsgBoxStyle.Critical, "Error")
        End If

        Conn.Close()

    End Sub

    Private Sub Actions_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class