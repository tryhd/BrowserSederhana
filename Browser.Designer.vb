<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.Highlight
        Me.Button2.Location = New System.Drawing.Point(12, 11)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(63, 21)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Back"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.Highlight
        Me.Button1.Location = New System.Drawing.Point(81, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(57, 21)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Forward"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(274, 13)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(367, 20)
        Me.TextBox1.TabIndex = 3
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.SystemColors.Highlight
        Me.Button3.Location = New System.Drawing.Point(647, 13)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(60, 21)
        Me.Button3.TabIndex = 4
        Me.Button3.Text = "Go"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.SystemColors.Highlight
        Me.Button4.Location = New System.Drawing.Point(144, 12)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(58, 21)
        Me.Button4.TabIndex = 6
        Me.Button4.Text = "Refresh"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.SystemColors.Highlight
        Me.Button5.Location = New System.Drawing.Point(208, 12)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(60, 21)
        Me.Button5.TabIndex = 7
        Me.Button5.Text = "Stop"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.SystemColors.Highlight
        Me.Button6.Location = New System.Drawing.Point(81, 37)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(70, 23)
        Me.Button6.TabIndex = 8
        Me.Button6.Text = "Close Tab"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.SystemColors.Highlight
        Me.Button7.Location = New System.Drawing.Point(12, 37)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(63, 23)
        Me.Button7.TabIndex = 9
        Me.Button7.Text = "New Tab"
        Me.Button7.UseVisualStyleBackColor = False
        '
        'TabControl1
        '
        Me.TabControl1.Location = New System.Drawing.Point(12, 81)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(695, 379)
        Me.TabControl1.TabIndex = 10
        '
        'WebBrowser1
        '
        Me.WebBrowser1.Location = New System.Drawing.Point(12, 81)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.Size = New System.Drawing.Size(818, 379)
        Me.WebBrowser1.TabIndex = 5
        Me.WebBrowser1.Visible = False
        '
        'Button8
        '
        Me.Button8.BackColor = System.Drawing.SystemColors.Highlight
        Me.Button8.Location = New System.Drawing.Point(157, 39)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(33, 21)
        Me.Button8.TabIndex = 11
        Me.Button8.Text = "+"
        Me.Button8.UseVisualStyleBackColor = False
        '
        'Button9
        '
        Me.Button9.BackColor = System.Drawing.SystemColors.Highlight
        Me.Button9.Location = New System.Drawing.Point(196, 39)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(32, 21)
        Me.Button9.TabIndex = 12
        Me.Button9.Text = "-"
        Me.Button9.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(712, 461)
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.WebBrowser1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button2)
        Me.Name = "Form1"
        Me.Text = "UAS Browser"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents WebBrowser1 As System.Windows.Forms.WebBrowser
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents Button9 As System.Windows.Forms.Button

End Class
