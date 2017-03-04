<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class addtype
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
        Me.cmdadd = New System.Windows.Forms.Button()
        Me.cmdext = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TXTTYPE = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'cmdadd
        '
        Me.cmdadd.Location = New System.Drawing.Point(124, 63)
        Me.cmdadd.Name = "cmdadd"
        Me.cmdadd.Size = New System.Drawing.Size(75, 23)
        Me.cmdadd.TabIndex = 0
        Me.cmdadd.Text = "SAVE"
        Me.cmdadd.UseVisualStyleBackColor = True
        '
        'cmdext
        '
        Me.cmdext.Location = New System.Drawing.Point(211, 63)
        Me.cmdext.Name = "cmdext"
        Me.cmdext.Size = New System.Drawing.Size(75, 23)
        Me.cmdext.TabIndex = 0
        Me.cmdext.Text = "EXIT"
        Me.cmdext.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(30, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "ADD NEW TYPE"
        '
        'TXTTYPE
        '
        Me.TXTTYPE.Location = New System.Drawing.Point(144, 19)
        Me.TXTTYPE.Name = "TXTTYPE"
        Me.TXTTYPE.Size = New System.Drawing.Size(142, 20)
        Me.TXTTYPE.TabIndex = 2
        '
        'addtype
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(293, 94)
        Me.Controls.Add(Me.TXTTYPE)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmdext)
        Me.Controls.Add(Me.cmdadd)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "addtype"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdadd As System.Windows.Forms.Button
    Friend WithEvents cmdext As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TXTTYPE As System.Windows.Forms.TextBox
End Class
