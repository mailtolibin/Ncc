Imports System.Data.OleDb
Imports System.Data
Public Class frmreceipt


    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        frmaddnewitem.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Call fnadditem()
    End Sub

    Private Sub frmreceipt_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim DA As New OleDbDataAdapter
        Dim DS As New DataSet
        Dim DR As OleDbDataReader
        Dim Cmd As New OleDbCommand
        Dim strsql As String

        strsql = "delete * from treceipt"
        Cmd = New OleDbCommand(strsql, OleCon_DB)
        DR = Cmd.ExecuteReader
        cmbiname.Items.Clear()
        cmbino.Items.Clear()
        Call fnaddtype()
        Call fnadditem()
        cmbtype.SelectedIndex = 0







    End Sub
    Public Sub fnadditem()
        Dim DA As New OleDbDataAdapter
        Dim DS As New DataSet
        Dim DR As OleDbDataReader
        Dim Cmd As New OleDbCommand
        Dim strsql, titemname As String
        Try
            cmbiname.Items.Clear()
            cmbino.Items.Clear()
            If cmbtype.Text <> "" Then
                strsql = "select   * from item where itype = '" & cmbtype.Text & "'"
                Cmd = New OleDbCommand(strsql, OleCon_DB)
                DR = Cmd.ExecuteReader
                While DR.Read = True
                    titemname = DR("itemname") + "    Rs:" + DR("price")
                    cmbino.Items.Add(DR("itemid"))
                    cmbiname.Items.Add(titemname)
                End While
            End If
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub
    Public Sub fnaddtype()
        Dim DA As New OleDbDataAdapter
        Dim DS As New DataSet
        Dim DR As OleDbDataReader
        Dim Cmd As New OleDbCommand
        Dim strsql As String
        Try
            cmbtype.Items.Clear()
            strsql = "select itemtype from itype"
            Cmd = New OleDbCommand(strsql, OleCon_DB)
            DR = Cmd.ExecuteReader
            While DR.Read = True
                cmbtype.Items.Add(DR("itemtype"))
            End While
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbtype.SelectedIndexChanged
        Call fnadditem()
        

    End Sub
    Public Sub ShowInGrid()
        'Try

        Dim strQry As String
        strQry = "Select rcptno,rcptdate,itemname,itype,price,qty from treceipt,item where treceipt.itemid=item.itemid"
        Dim da As New OleDbDataAdapter(strQry, OleCon_DB)
        Dim ds As New DataSet
        'Try
        da.Fill(ds)
        With grid1
            .DataSource = ds.Tables(0)
            .Refresh()

            .Columns(3).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells

        End With

        'Catch ex As Exception
        'MessageBox.Show(ex.Message, ProductName, MessageBoxButtons.OK)
        'End Try
    End Sub
    Private Sub cmbiname_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbino.SelectedIndexChanged
        Dim DA As New OleDbDataAdapter
        Dim DS As New DataSet
        Dim DR As OleDbDataReader
        Dim Cmd As New OleDbCommand
        Dim strsql As String
        Try
            cmbino.SelectedIndex = cmbiname.SelectedIndex

            strsql = "select   * from item where itemid = '" & cmbino.Text & "'"
            Cmd = New OleDbCommand(strsql, OleCon_DB)
            DR = Cmd.ExecuteReader
            If DR.Read = True Then
                txtprice.Text = DR("price")
                lbldoq.Text = DR("doq")

            End If
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub cmbiname_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles cmbiname.SelectedIndexChanged
        cmbino.SelectedIndex = cmbiname.SelectedIndex
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub DateTimePicker1_Validated(sender As Object, e As EventArgs) Handles DateTimePicker1.Validated

    End Sub

    

    Private Sub grid1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub cmdreceipt_Click(sender As Object, e As EventArgs) Handles cmdreceipt.Click
        Dim InsertQry As String
        Dim rstreceipt As New ADODB.Recordset
        Dim trstreceipt As New ADODB.Recordset
        If cmbtype.Text = "" Then
            MsgBox("Enter the name of the item", MsgBoxStyle.Information)
            cmbtype.Focus()
            Exit Sub
        End If
        If cmbiname.Text = "" Then
            MessageBox.Show("Can't be blank")
            cmbiname.Focus()
            Exit Sub
        End If
        If txtqty.Text = "" Then
            MessageBox.Show("Can't be blank")
            txtqty.Focus()
            Exit Sub
        End If
        If txtrmks.Text = "" Then
            MessageBox.Show("Can't be blank")
            txtrmks.Focus()
            Exit Sub
        End If
        Call tMaxBno()
        InsertQry = "Insert into treceipt(rcptno,rcptdate,itemid,rcptqty,rmks) Values('" & txtrcptno.Text & "',#" & Format(DateTimePicker1.Value, "MM/dd/yyyy") & "#,'" & cmbino.Text & "','" & txtqty.Text & "','" & txtrmks.Text & "')"
        CommonCommand = New OleDbCommand(InsertQry, OleCon_DB)
        CommonCommand.ExecuteNonQuery()
        Call MaxBno()
        InsertQry = "Insert into receipt(rcptno,rcptdate,itemid,rcptqty,rmks) Values('" & txtrcptno.Text & "',#" & Format(DateTimePicker1.Value, "MM/dd/yyyy") & "#,'" & cmbino.Text & "','" & txtqty.Text & "','" & txtrmks.Text & "')"
        CommonCommand = New OleDbCommand(InsertQry, OleCon_DB)
        CommonCommand.ExecuteNonQuery()

        If rstreceipt.State = 1 Then rstreceipt.Close()
        rstreceipt.Open("select * from item where itemid='" & cmbino.Text & "'", AdCon_DB, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
        rstreceipt.Fields("qty").Value = CInt(rstreceipt.Fields("qty").Value) + CInt(txtqty.Text)
        rstreceipt.Update()
        MsgBox("saved successfully", MsgBoxStyle.Information)
        Call ShowInGrid()
    End Sub
    Private Sub MaxBno()
        Dim rstMax As New ADODB.Recordset
        Try
            rstMax.Open("select max(val(rcptno)) from receipt", AdCon_DB, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
            With rstMax
                If .EOF = False Then
                    If IsDBNull(.Fields(0).Value) = False Then
                        txtrcptno.Text = .Fields(0).Value + 1
                    Else
                        txtrcptno.Text = 1
                    End If
                Else
                    txtrcptno.Text = 1
                End If
            End With
            rstMax.Close()
        Catch ex As Exception
            rstMax.Close()
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub tMaxBno()
        Dim rstMax As New ADODB.Recordset
        Try
            rstMax.Open("select max(val(rcptno)) from treceipt", AdCon_DB, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
            With rstMax
                If .EOF = False Then
                    If IsDBNull(.Fields(0).Value) = False Then
                        txtrcptno.Text = .Fields(0).Value + 1
                    Else
                        txtrcptno.Text = 1
                    End If
                Else
                    txtrcptno.Text = 1
                End If
            End With
            rstMax.Close()
        Catch ex As Exception
            rstMax.Close()
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub grid1_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles grid1.CellContentClick
        Call ShowInGrid()
        ' grid1.Refresh()
    End Sub
End Class