Imports System.Data.OleDb
Imports WindowsApplication1.Class1


Public Class addtype

    Private Sub addtype_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        frmaddnewitem.cmbtype.Items.Clear()
        Call fnaddtype()
    End Sub

    Private Sub addtype_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TXTTYPE.Focus()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles cmdadd.Click
        Dim rstitem As New ADODB.Recordset
        Dim a As Integer
        Try

        
        If TXTTYPE.Text = "" Then
            MessageBox.Show("Can't be blank")
            TXTTYPE.Focus()
            Exit Sub
        End If
        If rstitem.State = 1 Then rstitem.Close()
        rstitem.Open("select * from itype", AdCon_DB, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
        With rstitem
            .AddNew()
            .Fields("itemtype").Value = Trim(TXTTYPE.Text)

            .Update()
            MsgBox("saved successfully", MsgBoxStyle.Information)
            frmaddnewitem.cmbtype.Items.Clear()
                Call fnaddtype()
                a = MsgBox("Do you want to continue Add New Type of item", MsgBoxStyle.YesNo)
                If a = vbYes Then
                    TXTTYPE.Text = ""
                    TXTTYPE.Focus()
                Else
                    Me.Close()
                    frmaddnewitem.cmbtype.Focus()
                End If

            End With
        Catch ex As Exception
            If Err.Number = -2147217887 Then
                MsgBox("Type all ready exist", MsgBoxStyle.Information)
            Else
                MsgBox(Err.Number & ex.Message, MsgBoxStyle.Critical)
            End If
        End Try
    End Sub

    Private Sub cmdext_Click(sender As Object, e As EventArgs) Handles cmdext.Click
        Me.Close()
        frmaddnewitem.cmbtype.Items.Clear()
        Call fnaddtype()
    End Sub
End Class