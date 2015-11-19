<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ModeSelectForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ModeSelectForm))
        Me.OnCampusBtn = New System.Windows.Forms.Button
        Me.OffCampusBtn = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.MenuBar = New System.Windows.Forms.MenuStrip
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CloseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ManualToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.MenuBar.SuspendLayout()
        Me.SuspendLayout()
        '
        'OnCampusBtn
        '
        Me.OnCampusBtn.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OnCampusBtn.Location = New System.Drawing.Point(29, 62)
        Me.OnCampusBtn.Name = "OnCampusBtn"
        Me.OnCampusBtn.Size = New System.Drawing.Size(138, 71)
        Me.OnCampusBtn.TabIndex = 0
        Me.OnCampusBtn.Text = "On-Campus" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Mode"
        Me.OnCampusBtn.UseVisualStyleBackColor = True
        '
        'OffCampusBtn
        '
        Me.OffCampusBtn.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OffCampusBtn.Location = New System.Drawing.Point(223, 62)
        Me.OffCampusBtn.Name = "OffCampusBtn"
        Me.OffCampusBtn.Size = New System.Drawing.Size(138, 71)
        Me.OffCampusBtn.TabIndex = 1
        Me.OffCampusBtn.Text = "Off-Campus" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Mode"
        Me.OffCampusBtn.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(57, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(236, 20)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Please select your desired mode:"
        '
        'MenuBar
        '
        Me.MenuBar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuBar.Location = New System.Drawing.Point(0, 0)
        Me.MenuBar.Name = "MenuBar"
        Me.MenuBar.Size = New System.Drawing.Size(389, 24)
        Me.MenuBar.TabIndex = 8
        Me.MenuBar.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CloseToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'CloseToolStripMenuItem
        '
        Me.CloseToolStripMenuItem.Name = "CloseToolStripMenuItem"
        Me.CloseToolStripMenuItem.Size = New System.Drawing.Size(92, 22)
        Me.CloseToolStripMenuItem.Text = "Exit"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ManualToolStripMenuItem, Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'ManualToolStripMenuItem
        '
        Me.ManualToolStripMenuItem.Name = "ManualToolStripMenuItem"
        Me.ManualToolStripMenuItem.Size = New System.Drawing.Size(153, 22)
        Me.ManualToolStripMenuItem.Text = "Getting Started"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(153, 22)
        Me.AboutToolStripMenuItem.Text = "About..."
        '
        'ModeSelectForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.CadetBlue
        Me.ClientSize = New System.Drawing.Size(389, 158)
        Me.Controls.Add(Me.MenuBar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.OffCampusBtn)
        Me.Controls.Add(Me.OnCampusBtn)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "ModeSelectForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Theatre Arts Application Manager - Select A Mode"
        Me.MenuBar.ResumeLayout(False)
        Me.MenuBar.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents OnCampusBtn As System.Windows.Forms.Button
    Friend WithEvents OffCampusBtn As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents MenuBar As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CloseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ManualToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
