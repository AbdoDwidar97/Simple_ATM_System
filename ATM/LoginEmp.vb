Imports System.Data.SqlClient

Public Class LoginEmp

    Private Sub BtnLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnLogin.Click

        Dim Conn As New SqlConnection
        Conn.ConnectionString = "Data Source=.;Initial Catalog=ATMDB;Integrated Security=True"

        Dim Comm As New SqlCommand
        Comm.CommandText = "SELECT EmpUserName, EmpPass FROM EmpUser WHERE (EmpUserName = @Uname) AND (EmpPass = @Pass)"

        Dim Prams(1) As SqlParameter

        Prams(0) = New SqlParameter("@Uname", TxtUName.Text)
        Prams(1) = New SqlParameter("@Pass", TxtPass.Text)

        Comm.Parameters.AddRange(Prams)

        Comm.Connection = Conn
        Conn.Open()

        
        Dim rd As SqlDataReader = Comm.ExecuteReader
        If rd.HasRows Then
            CustomersForm.Show()
            rd.Read()
            CustomersForm.Text = CustomersForm.Text + " _ " + rd("EmpUserName")
            Me.Close()
        Else
            MsgBox("Invalid User Name Or Password", MsgBoxStyle.Critical)
        End If

        Conn.Close()



    End Sub

End Class
