Imports System.Data.SqlClient

Public Class SettingDB

    Public Shared Function GetDepositsBalance(ByVal CustomerUname As String) As Decimal

        Try

            Dim Conn As New SqlConnection
            Conn.ConnectionString = "Data Source=.;Initial Catalog=ATMDB;Integrated Security=True"
            Dim Comm As New SqlCommand
            Comm.Connection = Conn

            Comm.CommandText = "select SUM(Amount) as [DepBalance] From DepositsData where CustomerUname = '" + CustomerUname + "'"

            Conn.Open()

            Dim Reader As SqlDataReader = Comm.ExecuteReader()
            Reader.Read()

            If Reader.HasRows Then
                Return Reader("DepBalance")
            Else
                Return 0
            End If

        Catch ex As Exception
            Return 0
        End Try
        
    End Function

    Public Shared Function GetWithDrawalsBalance(ByVal CustomerUname As String) As Decimal

        
        Try

            Dim Conn As New SqlConnection
            Conn.ConnectionString = "Data Source=.;Initial Catalog=ATMDB;Integrated Security=True"
            Dim Comm As New SqlCommand
            Comm.Connection = Conn

            Comm.CommandText = "select SUM(Amount) as [WithBalance] From WithDrawalsData where CustomerUname = '" + CustomerUname + "'"

            Conn.Open()

            Dim Reader As SqlDataReader = Comm.ExecuteReader()
            Reader.Read()

            If Reader.HasRows Then
                Return Reader("WithBalance")
            Else
                Return 0

            End If

        Catch ex As Exception

            Return 0

        End Try


    End Function

    Public Shared Function GetAllBalance(ByVal CustomerUname As String) As Decimal

        Dim ResultBalance As Decimal

        ResultBalance = GetDepositsBalance(CustomerUname) - GetWithDrawalsBalance(CustomerUname)

        Return ResultBalance

    End Function
End Class
