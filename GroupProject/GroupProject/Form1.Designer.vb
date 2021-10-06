<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmggg
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmggg))
        Me.btncapture = New System.Windows.Forms.Button()
        Me.btndisplay = New System.Windows.Forms.Button()
        Me.btnsavetofile = New System.Windows.Forms.Button()
        Me.txtdisplay = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btncapture
        '
        Me.btncapture.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.btncapture.Location = New System.Drawing.Point(427, 56)
        Me.btncapture.Name = "btncapture"
        Me.btncapture.Size = New System.Drawing.Size(229, 23)
        Me.btncapture.TabIndex = 0
        Me.btncapture.Text = "Capture Data"
        Me.btncapture.UseVisualStyleBackColor = False
        '
        'btndisplay
        '
        Me.btndisplay.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.btndisplay.Location = New System.Drawing.Point(427, 85)
        Me.btndisplay.Name = "btndisplay"
        Me.btndisplay.Size = New System.Drawing.Size(229, 23)
        Me.btndisplay.TabIndex = 1
        Me.btndisplay.Text = "Display Data"
        Me.btndisplay.UseVisualStyleBackColor = False
        '
        'btnsavetofile
        '
        Me.btnsavetofile.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.btnsavetofile.Location = New System.Drawing.Point(427, 114)
        Me.btnsavetofile.Name = "btnsavetofile"
        Me.btnsavetofile.Size = New System.Drawing.Size(229, 23)
        Me.btnsavetofile.TabIndex = 2
        Me.btnsavetofile.Text = "Save Data to a file"
        Me.btnsavetofile.UseVisualStyleBackColor = False
        '
        'txtdisplay
        '
        Me.txtdisplay.Location = New System.Drawing.Point(12, 56)
        Me.txtdisplay.Multiline = True
        Me.txtdisplay.Name = "txtdisplay"
        Me.txtdisplay.Size = New System.Drawing.Size(396, 394)
        Me.txtdisplay.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.LimeGreen
        Me.Label1.Location = New System.Drawing.Point(162, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(364, 44)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Gang Going Green"
        '
        'frmggg
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.ForestGreen
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(765, 472)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtdisplay)
        Me.Controls.Add(Me.btnsavetofile)
        Me.Controls.Add(Me.btndisplay)
        Me.Controls.Add(Me.btncapture)
        Me.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Name = "frmggg"
        Me.Text = "Gang Going Green"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btncapture As Button
    Friend WithEvents btndisplay As Button
    Friend WithEvents btnsavetofile As Button
    Friend WithEvents txtdisplay As TextBox
    Friend WithEvents Label1 As Label
End Class
