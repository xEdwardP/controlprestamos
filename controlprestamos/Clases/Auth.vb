Imports System.Data.SqlClient
Imports System.Data
Imports System.Windows.Forms
Public Class Auth

    Inherits conexion
    Dim db As New Db
    Dim h As New Helpers

    Dim com As SqlCommand
    Dim data As DataTable
    Dim reader As SqlDataReader
    Dim q As String

    Public Function MakeLogin(username As String, password As String) As Boolean
        Dim response As Boolean
        response = False

        Dim condition As String
        condition = "USUARIO='" + username + "'"
        Dim data As DataTable
        data = db.Find("USUARIOS", "*", condition)

        If data.Rows.Count > 0 Then
            Dim info As DataRow
            info = data.Rows(0)
            Dim usuario As String = info("USUARIO").ToString()
            Dim clave As String = info("CLAVE").ToString()
            Dim nombre As String = info("Nombre").ToString()

            If username = usuario And password = clave Then
                response = True

            Else
                h.MsgWarning("EL NOMBRE DEL USUARIO Y/O LA CLAVE QUE INGRESO PARECEN SER INCORRECTAS")
            End If

        Else
            h.MsgWarning("EL USUARIO QUE INGRESO NO EXISTE!")
        End If

        data.Dispose()
        Return response
    End Function

End Class
