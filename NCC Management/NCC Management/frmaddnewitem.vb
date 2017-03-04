Imports System.Data.OleDb
Imports WindowsApplication1.Class1
Public Class frmaddnewitem

    Private Sub frmaddnewitem_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            cmbtype.Items.Clear()
            Call fnaddtype()
            Call fnfrmclr()
            Call fnfrmlk()
            cmdsave.Focus()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub txtiprice_TextChanged(sender As Object, e As EventArgs) Handles txtrmks.TextChanged, txtiname.TextChanged, txtprice.TextChanged, txtino.TextChanged

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click, Label4.Click, Label5.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles cmdsave.Click
        Dim rstitem As New ADODB.Recordset
        If LCase(cmdsave.Text) = "add" Then
            Call fnfrmunlk()
            txtiname.Focus()
            cmdsave.Text = "SAVE"

        ElseIf LCase(cmdsave.Text) = "save" Then
            If txtiname.Text = "" Then
                MsgBox("Enter the name of the item", MsgBoxStyle.Information)
                txtiname.Focus()
                Exit Sub
            End If
            If txtprice.Text = "" Then
                MessageBox.Show("Can't be blank")
                txtprice.Focus()
                Exit Sub
            End If
            If txtrmks.Text = "" Then
                MessageBox.Show("Can't be blank")
                txtrmks.Focus()
                Exit Sub
            End If
            If cmbdoq.Text = "" Then
                MessageBox.Show("Can't be blank")
                cmbdoq.Focus()
                Exit Sub
            End If
            If cmbtype.Text = "" Then
                MessageBox.Show("Can't be blank")
                cmbtype.Focus()
                Exit Sub
            End If
            Call MaxBno()
            If rstitem.State = 1 Then rstitem.Close()
            rstitem.Open("select * from item", AdCon_DB, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
            With rstitem
                .AddNew()
                .Fields("itemid").Value = Trim(txtino.Text)
                .Fields("itemname").Value = Trim(txtiname.Text)
                .Fields("itype").Value = Trim(cmbtype.Text)
                .Fields("doq").Value = Trim(cmbdoq.Text)
                .Fields("price").Value = Trim(txtprice.Text)
                .Fields("qty").Value = "0"
                .Fields("rmks").Value = Trim(txtrmks.Text)
                .Update()
                MsgBox("saved successfully", MsgBoxStyle.Information)
                Call fnfrmclr()
                Call fnfrmlk()
                cmdsave.Focus()
            End With

        End If

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles cmdext.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles cmdcncl.Click

    End Sub

    Private Sub cmbtype_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbtype.SelectedIndexChanged

    End Sub
    Private Sub MaxBno()
        Dim rstMax As New ADODB.Recordset
        Try
            rstMax.Open("select max(val(itemid)) from item", AdCon_DB, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
            With rstMax
                If .EOF = False Then
                    If IsDBNull(.Fields(0).Value) = False Then
                        txtino.Text = .Fields(0).Value + 1
                    Else
                        txtino.Text = 1
                    End If
                Else
                    txtino.Text = 1
                End If
            End With
            rstMax.Close()
        Catch ex As Exception
            rstMax.Close()
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub fnfrmclr()
        txtiname.Text = ""
        cmbtype.SelectedIndex = 0
        cmbdoq.SelectedIndex = 0
        txtprice.Text = ""
        txtrmks.Text = "-"
        cmdsave.Text = "ADD"


    End Sub
    Private Sub fnfrmlk()
        txtiname.Enabled = False
        cmbtype.Enabled = False
        cmbdoq.Enabled = False
        txtprice.Enabled = False
        txtrmks.Enabled = False
        cmdcncl.Enabled = False
        cmdsave.Focus()
    End Sub
    Private Sub fnfrmunlk()
        txtiname.Enabled = True
        cmbtype.Enabled = True
        cmbdoq.Enabled = True
        txtprice.Enabled = True
        txtrmks.Enabled = True
        cmdsave.Enabled = True
        cmdcncl.Enabled = True
        txtiname.Focus()
    End Sub
    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        addtype.Show()
        addtype.TXTTYPE.Focus()
    End Sub


End Class