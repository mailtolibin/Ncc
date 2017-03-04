<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmreceipt
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmbtype = New System.Windows.Forms.ComboBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtqty = New System.Windows.Forms.TextBox()
        Me.lbldoq = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtrmks = New System.Windows.Forms.TextBox()
        Me.cmdreceipt = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.cmbino = New System.Windows.Forms.ComboBox()
        Me.cmbiname = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtprice = New System.Windows.Forms.Label()
        Me.grid1 = New System.Windows.Forms.DataGridView()
        Me.txtrcptno = New System.Windows.Forms.TextBox()
        CType(Me.grid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(26, 53)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Item Name"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(190, 11)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(136, 26)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "IF the Price is different Go to add item and add a new item "
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(198, 78)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(60, 26)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Add New"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(260, 49)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(55, 25)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "Refresh"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(26, 15)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(31, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Type"
        '
        'cmbtype
        '
        Me.cmbtype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbtype.FormattingEnabled = True
        Me.cmbtype.Location = New System.Drawing.Point(99, 12)
        Me.cmbtype.Name = "cmbtype"
        Me.cmbtype.Size = New System.Drawing.Size(85, 21)
        Me.cmbtype.TabIndex = 1
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CustomFormat = "dd/MM/yyyy"
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.Location = New System.Drawing.Point(478, 8)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(155, 20)
        Me.DateTimePicker1.TabIndex = 7
        Me.DateTimePicker1.Value = New Date(2016, 12, 15, 23, 8, 47, 0)
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(413, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(30, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Date"
        '
        'txtqty
        '
        Me.txtqty.Location = New System.Drawing.Point(478, 52)
        Me.txtqty.Name = "txtqty"
        Me.txtqty.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtqty.Size = New System.Drawing.Size(85, 20)
        Me.txtqty.TabIndex = 2
        '
        'lbldoq
        '
        Me.lbldoq.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.lbldoq.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldoq.Location = New System.Drawing.Point(562, 56)
        Me.lbldoq.Name = "lbldoq"
        Me.lbldoq.Size = New System.Drawing.Size(34, 16)
        Me.lbldoq.TabIndex = 8
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(413, 59)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(46, 13)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Quantity"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(413, 96)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(49, 13)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Remarks"
        '
        'txtrmks
        '
        Me.txtrmks.Location = New System.Drawing.Point(478, 89)
        Me.txtrmks.Name = "txtrmks"
        Me.txtrmks.Size = New System.Drawing.Size(241, 20)
        Me.txtrmks.TabIndex = 2
        Me.txtrmks.Text = "-"
        '
        'cmdreceipt
        '
        Me.cmdreceipt.Location = New System.Drawing.Point(545, 127)
        Me.cmdreceipt.Name = "cmdreceipt"
        Me.cmdreceipt.Size = New System.Drawing.Size(78, 27)
        Me.cmdreceipt.TabIndex = 9
        Me.cmdreceipt.Text = "Save"
        Me.cmdreceipt.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(641, 127)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(78, 27)
        Me.Button3.TabIndex = 9
        Me.Button3.Text = "Exit"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(726, 487)
        Me.ShapeContainer1.TabIndex = 10
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape1
        '
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 0
        Me.LineShape1.X2 = 722
        Me.LineShape1.Y1 = 122
        Me.LineShape1.Y2 = 117
        '
        'cmbino
        '
        Me.cmbino.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbino.FormattingEnabled = True
        Me.cmbino.Location = New System.Drawing.Point(321, 53)
        Me.cmbino.Name = "cmbino"
        Me.cmbino.Size = New System.Drawing.Size(50, 21)
        Me.cmbino.TabIndex = 1
        '
        'cmbiname
        '
        Me.cmbiname.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbiname.FormattingEnabled = True
        Me.cmbiname.Location = New System.Drawing.Point(99, 49)
        Me.cmbiname.Name = "cmbiname"
        Me.cmbiname.Size = New System.Drawing.Size(155, 21)
        Me.cmbiname.TabIndex = 13
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(26, 89)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(31, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Price"
        '
        'txtprice
        '
        Me.txtprice.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.txtprice.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.txtprice.Location = New System.Drawing.Point(99, 89)
        Me.txtprice.Name = "txtprice"
        Me.txtprice.Size = New System.Drawing.Size(85, 17)
        Me.txtprice.TabIndex = 14
        Me.txtprice.Text = "Label8"
        '
        'grid1
        '
        Me.grid1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders
        Me.grid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grid1.Location = New System.Drawing.Point(0, 160)
        Me.grid1.Name = "grid1"
        Me.grid1.ReadOnly = True
        Me.grid1.Size = New System.Drawing.Size(721, 324)
        Me.grid1.TabIndex = 16
        '
        'txtrcptno
        '
        Me.txtrcptno.Location = New System.Drawing.Point(211, 82)
        Me.txtrcptno.Name = "txtrcptno"
        Me.txtrcptno.Size = New System.Drawing.Size(33, 20)
        Me.txtrcptno.TabIndex = 17
        '
        'frmreceipt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(726, 487)
        Me.Controls.Add(Me.grid1)
        Me.Controls.Add(Me.txtprice)
        Me.Controls.Add(Me.cmbiname)
        Me.Controls.Add(Me.cmbino)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.cmdreceipt)
        Me.Controls.Add(Me.lbldoq)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtrmks)
        Me.Controls.Add(Me.txtqty)
        Me.Controls.Add(Me.cmbtype)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtrcptno)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.Name = "frmreceipt"
        Me.Text = "Receipt"
        CType(Me.grid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cmbtype As System.Windows.Forms.ComboBox
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtqty As System.Windows.Forms.TextBox
    Friend WithEvents lbldoq As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtrmks As System.Windows.Forms.TextBox
    Friend WithEvents cmdreceipt As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents cmbino As System.Windows.Forms.ComboBox
    Friend WithEvents cmbiname As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtprice As System.Windows.Forms.Label
    Friend WithEvents grid1 As System.Windows.Forms.DataGridView
    Friend WithEvents txtrcptno As System.Windows.Forms.TextBox
End Class
