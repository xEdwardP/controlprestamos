Imports Microsoft.Office.Interop.Excel
Imports System.Windows.Forms
Imports System.IO
Public Class Export
    Dim h As New Helpers
    Function DgvExcel(ByVal Dgv As DataGridView) As Boolean
        Dim save As New SaveFileDialog
        Dim ruta As String
        Dim xlApp As Object = CreateObject("Excel.Application")
        Dim path As String = ""
        'Creamos una nueva hoja de calculos
        Dim xlwb As Object = xlApp.WorkBooks.Add()
        Dim xlws As Object = xlwb.WorkSheets(1)
        Try
            'Exportamos los caracteres de las columnas
            For c As Integer = 0 To Dgv.Columns.Count - 1
                xlws.cells(1, c + 1).value = Dgv.Columns(c).HeaderText
            Next
            'Expotaremos las cabeceras de las columnas
            For r As Integer = 0 To Dgv.Rows.Count - 1
                For c As Integer = 0 To Dgv.Columns.Count - 1
                    xlws.Cells(r + 2, c + 1).value = Convert.ToString(Dgv.Item(c, r).Value)
                Next
            Next
            'Guardamos la hoja de excel en la ruta especifica
            Dim savefile As SaveFileDialog = New SaveFileDialog
            savefile.InitialDirectory = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
            savefile.Filter = "Archivo Excel| *.xlsx"
            savefile.FileName = 2

            If savefile.ShowDialog = DialogResult.OK Then
                ruta = savefile.FileName
                xlwb.saveas(ruta)
                xlws = Nothing
                xlwb = Nothing
                xlApp.quit()
                h.MsgSuccess("EXPORTACION EXITOSA!")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Function
End Class
