Imports System.Data.SqlClient

Public Class ShowAll

    Private Sub ShowAll_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        GridResult.Rows.Clear()

        Dim Conn As New SqlConnection
        Conn.ConnectionString = "Data Source=.;Initial Catalog=ATMDB;Integrated Security=True"

        Dim Comm As New SqlCommand
        Comm.Connection = Conn

        Comm.CommandText = "Select * From CustomerData"

        Conn.Open()

        Dim Rd As SqlDataReader = Comm.ExecuteReader()

        Do While Rd.Read()
            GridResult.Rows.Add(Rd("Name"), Rd("Job"), Rd("Phone"), Rd("Mobile"), Rd("Email"), Rd("Address"), Rd("UserName"), Rd("Pass"), Rd("City"))
        Loop

        Conn.Close()

    End Sub

    Private Sub BtnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBack.Click
        Me.Close()
    End Sub

    Private Sub GridResult_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)

    End Sub
End Class