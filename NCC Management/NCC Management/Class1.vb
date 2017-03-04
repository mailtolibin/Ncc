Imports System.Data.OleDb
Public Class Class1
    Public Shared Sub fnaddtype()
        Dim DA As New OleDbDataAdapter
        Dim DS As New DataSet
        Dim DR As OleDbDataReader
        Dim Cmd As New OleDbCommand
        Dim strsql As String
        Try
            strsql = "select * from itype"
            Cmd = New OleDbCommand(strsql, OleCon_DB)
            DR = Cmd.ExecuteReader
            While DR.Read = True
                frmaddnewitem.cmbtype.Items.Add(DR("itemtype"))
            End While
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub
   
End Class
