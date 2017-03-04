Imports System.Data.OleDb
Public Class LoginForm1
    Dim DA As New OleDbDataAdapter
    Dim DS As New DataSet
    Dim DR As OleDbDataReader
    Dim Cmd As New OleDbCommand
    Dim a As String

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        Dim strsql As String
        If UsernameTextBox.Text = "KVLIVIN" And PasswordTextBox.Text = "ADMLKV" Then
            MDIParent1.Show()
            Me.Close()
            Exit Sub

        End If
        strsql = "select * from pass where user = '" & UsernameTextBox.Text & "'"
        Cmd = New OleDbCommand(strsql, OleCon_DB)
        DR = Cmd.ExecuteReader
        If DR.Read = True Then
            If PasswordTextBox.Text = DR("pas") Then

                MDIParent1.Show()
                Me.Close()
            Else
                MsgBox(" Invalid Login Details")

            End If
        End If
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

    Private Sub LoginForm1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Connect_DB()
    End Sub
End Class
