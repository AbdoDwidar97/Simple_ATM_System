Imports System.Data.SqlClient

Public Class LoginCustomer

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Me.Close()



    End Sub

    Private Sub LoginCustomer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BtnLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnLogin.Click

        Dim Conn As New SqlConnection
        Conn.ConnectionString = "Data Source=.;Initial Catalog=ATMDB;Integrated Security=True"

        Dim Comm As New SqlCommand
        Comm.CommandText = "SELECT UserName, Pass, ID FROM CustomerData WHERE (UserName = @Uname) AND (Pass = @Pass)"

        Dim Prams(1) As SqlParameter

        Prams(0) = New SqlParameter("@Uname", TxtUName.Text)
        Prams(1) = New SqlParameter("@Pass", TxtPass.Text)

        Comm.Parameters.AddRange(Prams)

        Comm.Connection = Conn
        Conn.Open()


        Dim rd As SqlDataReader = Comm.ExecuteReader
        If rd.HasRows Then
            Actions.Show()
            rd.Read()
            Actions.Text = Actions.Text + " _ " + rd("UserName")
            Actions.TxtDepID.Text = rd("ID")
            Actions.TxtWithID.Text = rd("ID")
            Actions.LblUserName.Text = rd("UserName")
            Actions.LblBalance.Text = SettingDB.GetAllBalance(TxtUName.Text)
            Me.Close()
        Else
            MsgBox("Invalid User Name Or Password", MsgBoxStyle.Critical)
        End If

        Conn.Close()


    End Sub
End Class
