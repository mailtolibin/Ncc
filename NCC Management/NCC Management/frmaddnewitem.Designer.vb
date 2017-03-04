<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmaddnewitem
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.cmbdoq = New System.Windows.Forms.ComboBox()
        Me.cmbtype = New System.Windows.Forms.ComboBox()
        Me.txtrmks = New System.Windows.Forms.TextBox()
        Me.txtino = New System.Windows.Forms.TextBox()
        Me.txtiname = New System.Windows.Forms.TextBox()
        Me.txtprice = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmdsave = New System.Windows.Forms.Button()
        Me.cmdcncl = New System.Windows.Forms.Button()
        Me.cmdext = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.cmbdoq)
        Me.GroupBox1.Controls.Add(Me.cmbtype)
        Me.GroupBox1.Controls.Add(Me.txtrmks)
        Me.GroupBox1.Controls.Add(Me.txtino)
        Me.GroupBox1.Controls.Add(Me.txtiname)
        Me.GroupBox1.Controls.Add(Me.txtprice)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(3, 1)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(374, 232)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "add"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(308, 62)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(58, 24)
        Me.Button1.TabIndex = 3
        Me.Button1.TabStop = False
        Me.Button1.Text = "Add"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'cmbdoq
        '
        Me.cmbdoq.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbdoq.FormattingEnabled = True
        Me.cmbdoq.Items.AddRange(New Object() {"Ea", "Pair", "Ltrs", "grms", "Kgs"})
        Me.cmbdoq.Location = New System.Drawing.Point(90, 103)
        Me.cmbdoq.Name = "cmbdoq"
        Me.cmbdoq.Size = New System.Drawing.Size(212, 22)
        Me.cmbdoq.TabIndex = 3
        '
        'cmbtype
        '
        Me.cmbtype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbtype.FormattingEnabled = True
        Me.cmbtype.Items.AddRange(New Object() {"Ea", "Pair", "Ltrs", "grms", "Kgs"})
        Me.cmbtype.Location = New System.Drawing.Point(90, 61)
        Me.cmbtype.Name = "cmbtype"
        Me.cmbtype.Size = New System.Drawing.Size(212, 22)
        Me.cmbtype.TabIndex = 2
        '
        'txtrmks
        '
        Me.txtrmks.Location = New System.Drawing.Point(90, 197)
        Me.txtrmks.Name = "txtrmks"
        Me.txtrmks.Size = New System.Drawing.Size(212, 20)
        Me.txtrmks.TabIndex = 5
        '
        'txtino
        '
        Me.txtino.Location = New System.Drawing.Point(167, 62)
        Me.txtino.Name = "txtino"
        Me.txtino.Size = New System.Drawing.Size(33, 20)
        Me.txtino.TabIndex = 1
        '
        'txtiname
        '
        Me.txtiname.Location = New System.Drawing.Point(90, 16)
        Me.txtiname.Name = "txtiname"
        Me.txtiname.Size = New System.Drawing.Size(212, 20)
        Me.txtiname.TabIndex = 1
        '
        'txtprice
        '
        Me.txtprice.Location = New System.Drawing.Point(90, 147)
        Me.txtprice.Name = "txtprice"
        Me.txtprice.Size = New System.Drawing.Size(212, 20)
        Me.txtprice.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(14, 200)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(47, 14)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Remarks"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(14, 154)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(31, 14)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Price"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 62)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(31, 14)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Type"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(14, 106)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(31, 14)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "DOQ"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 14)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Item Name"
        '
        'cmdsave
        '
        Me.cmdsave.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdsave.Location = New System.Drawing.Point(128, 248)
        Me.cmdsave.Name = "cmdsave"
        Me.cmdsave.Size = New System.Drawing.Size(69, 25)
        Me.cmdsave.TabIndex = 6
        Me.cmdsave.Text = "ADD"
        Me.cmdsave.UseVisualStyleBackColor = True
        '
        'cmdcncl
        '
        Me.cmdcncl.Location = New System.Drawing.Point(213, 248)
        Me.cmdcncl.Name = "cmdcncl"
        Me.cmdcncl.Size = New System.Drawing.Size(69, 25)
        Me.cmdcncl.TabIndex = 7
        Me.cmdcncl.Text = "CANCEL"
        Me.cmdcncl.UseVisualStyleBackColor = True
        '
        'cmdext
        '
        Me.cmdext.Location = New System.Drawing.Point(297, 248)
        Me.cmdext.Name = "cmdext"
        Me.cmdext.Size = New System.Drawing.Size(69, 25)
        Me.cmdext.TabIndex = 8
        Me.cmdext.Text = "EXIT"
        Me.cmdext.UseVisualStyleBackColor = True
        '
        'frmaddnewitem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(381, 281)
        Me.Controls.Add(Me.cmdext)
        Me.Controls.Add(Me.cmdcncl)
        Me.Controls.Add(Me.cmdsave)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmaddnewitem"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmbtype As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtrmks As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtiname As System.Windows.Forms.TextBox
    Friend WithEvents cmdsave As System.Windows.Forms.Button
    Friend WithEvents cmdcncl As System.Windows.Forms.Button
    Friend WithEvents cmdext As System.Windows.Forms.Button
    Friend WithEvents cmbdoq As System.Windows.Forms.ComboBox
    Friend WithEvents txtprice As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtino As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
