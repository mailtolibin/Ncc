Imports System.Windows.Forms
Public Class MDIParent1
    Private Sub MDIParent1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        addtype.MdiParent = Me
        frmaddnewitem.MdiParent = Me
    End Sub

    Private Sub AddNewItemToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddNewItemToolStripMenuItem.Click
        frmaddnewitem.Show()
        frmaddnewitem.cmdsave.Focus()
    End Sub

    Private Sub ReceiptToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReceiptToolStripMenuItem.Click
        frmreceipt.Show()
    End Sub

    Private Sub ToolStrip_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs)

    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ToolTip_Popup(sender As Object, e As PopupEventArgs) Handles ToolTip.Popup

    End Sub
End Class
