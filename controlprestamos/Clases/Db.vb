Imports System.Data.SqlClient
Imports System.Data
Imports System.Windows.Forms

Public Class Db
    Inherits conexion
    Dim com As SqlCommand
    Dim data As DataTable
    Dim reader As SqlDataReader
    Dim q As String

    Public Function Save(tabla As String, campos As String, values As String, Optional ByVal debug As String = "") As Int32
        Dim res As Int32 = 0
        q = "INSERT INTO " + tabla + " (" + campos + ") VALUES(" + values + ")"

        If debug = "True" Then
            MessageBox.Show(q)
        End If

        Try
            com = New SqlCommand(q, ConSQL)
            AbrirConexion()
            res = com.ExecuteNonQuery()

            com.Dispose()
            CerrarConexion()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            TerminarConexion()
        End Try

        Return res
    End Function

    Public Function Find(tabla As String, campos As String, Optional ByVal condicion As String = "") As DataTable
        data = New DataTable

        If condicion = "" Then
            q = "SELECT " + campos + " FROM " + tabla
        Else
            q = "SELECT " + campos + " FROM " + tabla + " WHERE " + condicion
        End If

        Try
            com = New SqlCommand(q, ConSQL)
            AbrirConexion()
            reader = com.ExecuteReader
            data.Load(reader)

            reader.Close()
            com.Dispose()
            CerrarConexion()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            TerminarConexion()
        End Try
        Return data
    End Function

    Public Function Update(tabla As String, valores As String, Optional ByVal condicion As String = "", Optional ByVal debug As String = "") As Int32
        Dim ra As Int32 = 0

        If condicion = "" Then
            q = "UPDATE " + tabla + " SET " + valores
        Else
            q = "UPDATE " + tabla + " SET " + valores + " WHERE " + condicion
        End If

        If debug = "True" Then
            MessageBox.Show(q)
        End If

        Try
            com = New SqlCommand(q, ConSQL)
            AbrirConexion()

            ra = com.ExecuteNonQuery

            com.Dispose()
            CerrarConexion()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            TerminarConexion()
        End Try
        Return ra
    End Function

    Public Function Delete(tabla As String, pk As String, value As String)
        Dim rd As Int32 = 0
        Try
            q = "UPDATE " + tabla + " SET DEL='S' WHERE " + pk + "='" + value + "'"
            com = New SqlCommand(q, ConSQL)
            AbrirConexion()

            rd = com.ExecuteNonQuery

            com.Dispose()
            CerrarConexion()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            TerminarConexion()
        End Try

        Return rd
    End Function

    Public Function RawSQL(query As String, Optional ByVal debug As String = "") As Int32
        Dim ra As Int32 = 0

        If debug = "True" Then
            MessageBox.Show(query)
        End If

        Try
            com = New SqlCommand(query, ConSQL)
            AbrirConexion()
            ra = com.ExecuteNonQuery

            com.Dispose()
            CerrarConexion()
        Catch ex As Exception
            MessageBox.Show(ex.Message)

        Finally
            TerminarConexion()
        End Try

        Return ra
    End Function

    Public Function Hook(campo As String, tabla As String, Optional ByVal condicion As String = "")
        Dim fish As String = ""

        Try
            If condicion = "" Then
                q = "SELECT " + campo + " AS FISH FROM " + tabla + " "
            Else
                q = "SELECT " + campo + " AS FISH FROM " + tabla + " WHERE " + condicion
            End If

            com = New SqlCommand(q, ConSQL)
            Dim recordset As SqlDataReader
            AbrirConexion()
            recordset = com.ExecuteReader

            If recordset.Read Then
                fish = recordset("FISH").ToString()
            End If

            recordset.Close()
            com.Dispose()
            CerrarConexion()
        Catch ex As Exception
            MessageBox.Show(ex.Message)

        Finally
            TerminarConexion()
        End Try
        Return fish
    End Function

    Public Function GetNext(id As String) As String
        Dim siguiente As String = ""
        Dim condicion As String = "WHERE IDCORRE = '" + id + "'"

        q = "SELECT ULTIMO + 1 AS NEXT FROM CORRELATIVOS " + condicion

        Try
            com = New SqlCommand(q, ConSQL)
            AbrirConexion()
            Dim DRNEXT As SqlDataReader
            DRNEXT = com.ExecuteReader

            Dim corre As Int32 = 0
            If DRNEXT.Read() Then
                corre = Convert.ToInt32(DRNEXT("NEXT").ToString())
            Else
                MessageBox.Show("ERROR AL GENERAR EL CORRELATIVO, CONTACTAR AL ADMINISTRADOR")
            End If

            DRNEXT.Close()
            com.Dispose()
            CerrarConexion()

            If corre >= 1 And corre <= 9 Then
                siguiente = "00000" + corre.ToString()
            ElseIf Corre >= 10 And Corre <= 99 Then
                siguiente = "0000" + corre.ToString()
            ElseIf Corre >= 100 And Corre <= 999 Then
                siguiente = "000" + corre.ToString()
            ElseIf Corre >= 1000 And Corre <= 9999 Then
                siguiente = "00" + corre.ToString()
            ElseIf Corre >= 10000 And Corre <= 99999 Then
                siguiente = "0" + corre.ToString()
            ElseIf Corre >= 100000 And Corre <= 999999 Then
                siguiente = corre.ToString()
            Else
                MessageBox.Show("ERROR AL GENERAR EL CORRELATIVO, HA LLEGADO AL MÁXIMO!")
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            TerminarConexion()
        End Try

        Return siguiente
    End Function

    Public Function SetLast(id As String)
        Dim condition As String = "WHERE IDCORRE='" + id + "'"
        q = "UPDATE CORRELATIVOS SET ULTIMO = ULTIMO + 1 WHERE IDCORRE='" + id + "'"

        Try
            com = New SqlCommand(q, ConSQL)
            AbrirConexion()
            com.ExecuteNonQuery()

            com.Dispose()
            CerrarConexion()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            TerminarConexion()
        End Try
    End Function

    Public Function GetNumRows(tabla As String, Optional ByVal condition As String = "", Optional ByVal debug As String = "") As Int16
        Dim numrows As Int16 = 0
        If condition = "" Then
            q = "SELECT COUNT(*) AS NUMROWS FROM " + tabla
        Else
            q = "SELECT COUNT(*) AS NUMROWS FROM " + tabla + " WHERE " + condition
        End If

        If debug = "True" Then
            MessageBox.Show(q)
        End If

        Try
            com = New SqlCommand(q, ConSQL)
            AbrirConexion()
            reader = com.ExecuteReader

            If reader.Read() Then
                numrows = Convert.ToInt16(reader("NUMROWS").ToString())
            Else
                MessageBox.Show("ERROR FATAL AL PROCESAR EL COMANDO ESPECIFICADO")
            End If
            reader.Close()
            com.Dispose()
            CerrarConexion()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            TerminarConexion()
        End Try
        Return numrows
    End Function

End Class
