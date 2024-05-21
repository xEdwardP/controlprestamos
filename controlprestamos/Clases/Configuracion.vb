Imports System.Data.OleDb
Public Class Configuracion
    Inherits ConexionOleDB
    Dim com As OleDbCommand
    Dim reader As OleDbDataReader
    Dim query As String

    Public Function Save(tabla As String, campos As String, values As String, Optional ByVal debug As String = "") As Int32
        Dim res As Int32 = 0
        query = "INSERT INTO " + tabla + " (" + campos + ") VALUES(" + values + ")"

        If debug = "True" Then
            MessageBox.Show(query)
        End If

        Try
            com = New OleDbCommand(query, ConOleDB)
            OpenConnection()
            res = com.ExecuteNonQuery()

            com.Dispose()
            CloseConnection()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            EndsConnection()
        End Try

        Return res
    End Function

    Public Function Find(tabla As String, campos As String, Optional ByVal condicion As String = "") As DataTable
        Dim Data = New DataTable

        If condicion = "" Then
            query = "SELECT " + campos + " FROM " + tabla
        Else
            query = "SELECT " + campos + " FROM " + tabla + " WHERE " + condicion
        End If

        Try
            com = New OleDbCommand(query, ConOleDB)
            OpenConnection()
            reader = com.ExecuteReader
            Data.Load(reader)

            reader.Close()
            com.Dispose()
            CloseConnection()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            EndsConnection()
        End Try
        Return Data
    End Function

    Public Function Update(tabla As String, valores As String, Optional ByVal condicion As String = "", Optional ByVal debug As String = "") As Int32
        Dim ra As Int32 = 0

        If condicion = "" Then
            query = "UPDATE " + tabla + " SET " + valores
        Else
            query = "UPDATE " + tabla + " SET " + valores + " WHERE " + condicion
        End If

        If debug = "True" Then
            MessageBox.Show(query)
        End If

        Try
            com = New OleDbCommand(query, ConOleDB)
            OpenConnection()

            ra = com.ExecuteNonQuery

            com.Dispose()
            CloseConnection()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            EndsConnection()
        End Try
        Return ra
    End Function

    Public Function Hook(campo As String, tabla As String, Optional ByVal condicion As String = "")
        Dim fish As String = ""

        Try
            If condicion = "" Then
                query = "SELECT " + campo + " AS FISH FROM " + tabla + " "
            Else
                query = "SELECT " + campo + " AS FISH FROM " + tabla + " WHERE " + condicion
            End If

            com = New OleDbCommand(query, ConOleDB)
            Dim recordset As OleDbDataReader
            OpenConnection()
            recordset = com.ExecuteReader

            If recordset.Read Then
                fish = recordset("FISH").ToString()
            End If

            recordset.Close()
            com.Dispose()
            CloseConnection()
        Catch ex As Exception
            MessageBox.Show(ex.Message)

        Finally
            EndsConnection()
        End Try
        Return fish
    End Function
End Class
