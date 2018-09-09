Imports System.Data.SqlClient

Public Class CustomersForm
    Public Selected As String

    Private Sub BtnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBack.Click
        Me.Close()
        Form1.Show()

    End Sub

    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click

        '-------------------------------------------------------------------------------------------------------------

        If TxtAdrs.Text = "" Or TxtCity.Text = "" Or TxtJob.Text = "" Or TxtMail.Text = "" Or TxtMob.Text = "" Or TxtName.Text = "" Or TxtPhone.Text = "" Or TxtPwd.Text = "" Or TxtUserName.Text = "" Then
            MsgBox("Inter Full Information", MsgBoxStyle.Critical, "Error")
            Exit Sub
        End If

        '-------------------------------------------------------------------------------------------------------------
        Dim Conn As New SqlConnection
        Conn.ConnectionString = "Data Source=.;Initial Catalog=ATMDB;Integrated Security=True"
        Dim Comm As New SqlCommand
        Comm.Connection = Conn

        '--------------------------------------------------------------------------------------------------------------


        Comm.CommandText = "Select * From CustomerData Where UserName = '" + TxtUserName.Text + "'"

        Conn.Open()
        Dim Rd As SqlDataReader = Comm.ExecuteReader()

        Do While Rd.Read()
            If Rd.HasRows Then
                MsgBox(" User Name Is Really Existing , Insert Another One", MsgBoxStyle.Critical, "Error")
                Conn.Close()
                Exit Sub
            End If
        Loop

        Conn.Close()


        '---------------------------------------------------------------------------------------------------------------


        Comm.CommandText = "INSERT INTO CustomerData (Name, Job, Phone, Mobile, Email, Address, UserName, Pass, City) VALUES (@Name,@Job,@Phone,@Mob,@Mail,@Adrs,@Uname,@Pass,@City)"

        Dim Prams(8) As SqlParameter
        Prams(0) = New SqlParameter("@Name", TxtName.Text)
        Prams(1) = New SqlParameter("@Job", TxtJob.Text)
        Prams(2) = New SqlParameter("@Phone", TxtPhone.Text)
        Prams(3) = New SqlParameter("@Mob", TxtMob.Text)
        Prams(4) = New SqlParameter("@Mail", TxtMail.Text)
        Prams(5) = New SqlParameter("@Adrs", TxtAdrs.Text)
        Prams(6) = New SqlParameter("@Uname", TxtUserName.Text)
        Prams(7) = New SqlParameter("@Pass", TxtPwd.Text)
        Prams(8) = New SqlParameter("@City", TxtCity.Text)
        Comm.Parameters.AddRange(Prams)

        Conn.Open()

        Dim Es As Integer = Comm.ExecuteNonQuery()
        If Es > -1 Then
            MsgBox("Customer Data Saved Successfully", MsgBoxStyle.Information, "Done")

            TxtAdrs.Text = ""
            TxtCity.Text = ""
            TxtID.Text = ""
            TxtJob.Text = ""
            TxtMail.Text = ""
            TxtMob.Text = ""
            TxtName.Text = ""
            TxtPhone.Text = ""
            TxtUserName.Text = ""
            TxtPwd.Text = ""

        Else
            MsgBox("Some Error Occured , Please Try Again", MsgBoxStyle.Critical, "Error")
        End If

        Conn.Close()

    End Sub

    Private Sub BtnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSearch.Click

        Dim Conn As New SqlConnection
        Conn.ConnectionString = "Data Source=.;Initial Catalog=ATMDB;Integrated Security=True"

        Dim Comm As New SqlCommand
        Comm.Connection = Conn

        Dim SearchUserName As String = InputBox("Input User Name :", "Search")
        Comm.CommandText = "Select * From CustomerData Where UserName = '" + SearchUserName + "'"

        Conn.Open()

        Dim Rd As SqlDataReader = Comm.ExecuteReader()
        Rd.Read()

        If Rd.HasRows Then

            TxtID.Text = Rd("ID")
            TxtName.Text = Rd("Name")
            TxtJob.Text = Rd("Job")
            TxtPhone.Text = Rd("Phone")
            TxtMob.Text = Rd("Mobile")
            TxtMail.Text = Rd("Email")
            TxtAdrs.Text = Rd("Address")
            TxtUserName.Text = Rd("UserName")
            TxtPwd.Text = Rd("Pass")
            TxtCity.Text = Rd("City")

            Selected = Rd("UserName")
        Else

            MsgBox("Customer User Name Not Found", MsgBoxStyle.Critical, "Error")

        End If

        Conn.Close()


    End Sub

    Private Sub CustomersForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BtnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEdit.Click

        If TxtAdrs.Text = "" Or TxtCity.Text = "" Or TxtJob.Text = "" Or TxtMail.Text = "" Or TxtMob.Text = "" Or TxtName.Text = "" Or TxtPhone.Text = "" Or TxtPwd.Text = "" Or TxtUserName.Text = "" Then
            MsgBox("Inter Full Information", MsgBoxStyle.Critical, "Error")
            Exit Sub
        End If

        Dim Conn As New SqlConnection
        Conn.ConnectionString = "Data Source=.;Initial Catalog=ATMDB;Integrated Security=True"

        Dim Comm As New SqlCommand
        Comm.Connection = Conn

        Comm.CommandText = "UPDATE CustomerData SET Name = @Name, Job = @Job, Phone = @Phone, Mobile = @Mob, Email = @Mail, Address = @Adrs, UserName = @UName, Pass = @Pass, City = @City Where UserName = '" + Selected + "'"

        Dim Prams(8) As SqlParameter
        Prams(0) = New SqlParameter("@Name", TxtName.Text)
        Prams(1) = New SqlParameter("@Job", TxtJob.Text)
        Prams(2) = New SqlParameter("@Phone", TxtPhone.Text)
        Prams(3) = New SqlParameter("@Mob", TxtMob.Text)
        Prams(4) = New SqlParameter("@Mail", TxtMail.Text)
        Prams(5) = New SqlParameter("@Adrs", TxtAdrs.Text)
        Prams(6) = New SqlParameter("@UName", TxtUserName.Text)
        Prams(7) = New SqlParameter("@Pass", TxtPwd.Text)
        Prams(8) = New SqlParameter("@City", TxtCity.Text)
        Comm.Parameters.AddRange(Prams)

        Conn.Open()

        Dim Es As Integer = Comm.ExecuteNonQuery()

        If Es > -1 Then
            MsgBox("Customer Data Updated Successfully", MsgBoxStyle.Information, "Done")
            TxtAdrs.Text = ""
            TxtCity.Text = ""
            TxtID.Text = ""
            TxtJob.Text = ""
            TxtMail.Text = ""
            TxtMob.Text = ""
            TxtName.Text = ""
            TxtPhone.Text = ""
            TxtUserName.Text = ""
            TxtPwd.Text = ""
        Else
            MsgBox("Some Error Occured , Try Again", MsgBoxStyle.Critical, "error")
        End If

        Conn.Close()


    End Sub

    Private Sub BtnDel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDel.Click

        If TxtAdrs.Text = "" Or TxtCity.Text = "" Or TxtJob.Text = "" Or TxtMail.Text = "" Or TxtMob.Text = "" Or TxtName.Text = "" Or TxtPhone.Text = "" Or TxtPwd.Text = "" Or TxtUserName.Text = "" Then
            MsgBox("Inter Full Information", MsgBoxStyle.Critical, "Error")
            Exit Sub
        End If

        Dim Conn As New SqlConnection
        Conn.ConnectionString = "Data Source=.;Initial Catalog=ATMDB;Integrated Security=True"
        Dim Comm As New SqlCommand
        Comm.Connection = Conn

        Comm.CommandText = "DELETE FROM CustomerData Where UserName = '" + Selected + "'"

        Conn.Open()

        Dim Es As Integer = Comm.ExecuteNonQuery()

        If Es > -1 Then
            MsgBox("Customer Data Deleted Successfully", MsgBoxStyle.Information, "Done")
            TxtAdrs.Text = ""
            TxtCity.Text = ""
            TxtID.Text = ""
            TxtJob.Text = ""
            TxtMail.Text = ""
            TxtMob.Text = ""
            TxtName.Text = ""
            TxtPhone.Text = ""
            TxtUserName.Text = ""
            TxtPwd.Text = ""

            Comm.CommandText = "Delete From WithDrawalsData Where CustomerUname = '" + Selected + "'"
            Dim Dp As Integer = Comm.ExecuteNonQuery()
            Comm.CommandText = "Delete From DepositsData Where CustomerUname = '" + Selected + "'"
            Dim Wi As Integer = Comm.ExecuteNonQuery()
        Else
            MsgBox("Some Error Occured , Try Acain", MsgBoxStyle.Critical, "error")
        End If

        Conn.Close()

    End Sub

    Private Sub BtnShow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnShow.Click

        ShowAll.ShowDialog()


    End Sub
End Class