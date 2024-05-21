Imports System.Data.OleDb
Imports System.IO
Imports System.Data.SqlClient
Public Class ConexionOleDB
    Dim h As New Helpers()
    Public connection_string As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Data\controlprestamos.accdb;Jet OLEDB:Database Password=norman2022"
    Public ConOleDB As New OleDbConnection(connection_string)
    Public Shared INSTANCIA, USER, PASS, BD

    Public Sub OpenConnection()
        Try
            ConOleDB.Open()
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString())
        End Try
    End Sub

    Public Sub CloseConnection()
        Try
            ConOleDB.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString())
        End Try
    End Sub

    Public Sub EndsConnection()
        If ConOleDB.State = ConnectionState.Open Then
            ConOleDB.Close()
        End If
    End Sub
End Class
