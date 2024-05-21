Imports System.IO
Imports System.Data.OleDb
Public Class BootStrapper
    Dim ole As New ConexionOleDB()
    Dim h As New Helpers()
    Dim conf As New Configuracion()
    Public Sub ReadConfiguration()
        Try
            Dim query As String = "SELECT * FROM SERVER"
            Dim com As OleDbCommand = New OleDbCommand(query, ole.ConOleDB)
            ole.OpenConnection()
            Dim reader As OleDbDataReader
            reader = com.ExecuteReader()

            If reader.Read() Then
                Env.SERVER = reader("SERVER").ToString()
                Env.USERID = reader("USUARIO").ToString()
                Env.PASSWORD = reader("CLAVE").ToString()
                Env.DATABASE = reader("DATA").ToString()
            Else
                'h.MsgWarning("ERROR AL CARGAR LOS DATOS DE CONFIGURACION!", "ERROR")
            End If

            reader.Close()
            com.Dispose()
            ole.CloseConnection()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            ole.EndsConnection()
        End Try
    End Sub

    Public Sub CheckFileConfiguration()
        Dim path As String = "C:\Data\controlprestamos.accdb"

        If File.Exists(path) Then
            ReadConfiguration()
        Else
            h.MsgWarning("ERROR FATAL, NO SE CARGARON LOS ARCHIVOS DE CONFIGURACION DEL SISTEMA, CONTACTAR AL ADMINISTRADOR!")
            Application.Exit()
        End If
    End Sub

    Public Function ValidarConfiguracion() As String
        Dim resp = ""
        ReadConfiguration()

        If Env.SERVER = "" And Env.DATABASE = "" And Env.USERID = "" And Env.PASSWORD = "" Then
            resp = "False"
        Else
            resp = "True"
        End If

        Return resp
    End Function
End Class
