Imports System.Windows.Forms
Imports System.Data
Public Class Helpers

    Public Function MsgWarning(msg As String, Optional ByVal title As String = "ATENCION") As String
        MessageBox.Show(msg, title, MessageBoxButtons.OK, MessageBoxIcon.Warning)
    End Function

    Public Function MsgSuccess(msg As String, Optional ByVal title As String = "EXITO") As String
        MessageBox.Show(msg, title, MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Function

    Public Function MsgQuestion(msg As String, Optional ByVal title As String = "CONFIRMAR") As String

        Dim resp As String = "N"

        If MessageBox.Show(msg, title, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            resp = "S"
        End If

        Return resp

    End Function

    Public Function ReturnNumbers(str As String) As Double
        Dim double_value As Double = 0
        If Double.TryParse(str, double_value) Then
            double_value = Convert.ToDouble(str)
        Else
            double_value = 0
        End If
        Return double_value
    End Function

    Public Function GetOnlyNumbers(e As KeyPressEventArgs) As Boolean
        Dim resp As Boolean = False

        If Char.IsNumber(e.KeyChar) Then
            resp = True
            'ElseIf e.KeyChar = [Char] Then
            '    resp = True
        End If
        Return resp
    End Function

End Class
