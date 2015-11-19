<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.ExitBtn = New System.Windows.Forms.Button
        Me.NewApplicantBtn = New System.Windows.Forms.Button
        Me.UpdateApplicantBtn = New System.Windows.Forms.Button
        Me.EmailListBtn = New System.Windows.Forms.Button
        Me.FindApplicantBtn = New System.Windows.Forms.Button
        Me.Button6 = New System.Windows.Forms.Button
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ImportFileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.LogOutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CloseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ManualToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.OpenFileDialog = New System.Windows.Forms.OpenFileDialog
        Me.AdminBtn = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.FileToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.ImportDataToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.LogOutToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.ChangePasswordToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.HelpToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.GettingStartedToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AboutToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ExitBtn
        '
        Me.ExitBtn.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExitBtn.Location = New System.Drawing.Point(587, 252)
        Me.ExitBtn.Name = "ExitBtn"
        Me.ExitBtn.Size = New System.Drawing.Size(79, 35)
        Me.ExitBtn.TabIndex = 0
        Me.ExitBtn.Text = "Exit"
        Me.ExitBtn.UseVisualStyleBackColor = True
        '
        'NewApplicantBtn
        '
        Me.NewApplicantBtn.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NewApplicantBtn.Image = CType(resources.GetObject("NewApplicantBtn.Image"), System.Drawing.Image)
        Me.NewApplicantBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.NewApplicantBtn.Location = New System.Drawing.Point(30, 51)
        Me.NewApplicantBtn.Name = "NewApplicantBtn"
        Me.NewApplicantBtn.Size = New System.Drawing.Size(119, 85)
        Me.NewApplicantBtn.TabIndex = 1
        Me.NewApplicantBtn.Text = "Enter A New Applicant"
        Me.NewApplicantBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.NewApplicantBtn.UseVisualStyleBackColor = True
        '
        'UpdateApplicantBtn
        '
        Me.UpdateApplicantBtn.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UpdateApplicantBtn.Image = CType(resources.GetObject("UpdateApplicantBtn.Image"), System.Drawing.Image)
        Me.UpdateApplicantBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.UpdateApplicantBtn.Location = New System.Drawing.Point(191, 51)
        Me.UpdateApplicantBtn.Name = "UpdateApplicantBtn"
        Me.UpdateApplicantBtn.Size = New System.Drawing.Size(119, 85)
        Me.UpdateApplicantBtn.TabIndex = 2
        Me.UpdateApplicantBtn.Text = "Edit Existing Applicant"
        Me.UpdateApplicantBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.UpdateApplicantBtn.UseVisualStyleBackColor = True
        '
        'EmailListBtn
        '
        Me.EmailListBtn.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmailListBtn.Image = CType(resources.GetObject("EmailListBtn.Image"), System.Drawing.Image)
        Me.EmailListBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.EmailListBtn.Location = New System.Drawing.Point(30, 177)
        Me.EmailListBtn.Name = "EmailListBtn"
        Me.EmailListBtn.Size = New System.Drawing.Size(119, 85)
        Me.EmailListBtn.TabIndex = 3
        Me.EmailListBtn.Text = "Generate " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "E-mail List"
        Me.EmailListBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.EmailListBtn.UseVisualStyleBackColor = True
        '
        'FindApplicantBtn
        '
        Me.FindApplicantBtn.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FindApplicantBtn.Image = CType(resources.GetObject("FindApplicantBtn.Image"), System.Drawing.Image)
        Me.FindApplicantBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.FindApplicantBtn.Location = New System.Drawing.Point(356, 51)
        Me.FindApplicantBtn.Name = "FindApplicantBtn"
        Me.FindApplicantBtn.Size = New System.Drawing.Size(119, 85)
        Me.FindApplicantBtn.TabIndex = 4
        Me.FindApplicantBtn.Text = "Find An Applicant"
        Me.FindApplicantBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.FindApplicantBtn.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.Image = CType(resources.GetObject("Button6.Image"), System.Drawing.Image)
        Me.Button6.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button6.Location = New System.Drawing.Point(191, 177)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(119, 85)
        Me.Button6.TabIndex = 6
        Me.Button6.Text = "View Statistics"
        Me.Button6.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button6.UseVisualStyleBackColor = True
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ImportFileToolStripMenuItem, Me.LogOutToolStripMenuItem, Me.CloseToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'ImportFileToolStripMenuItem
        '
        Me.ImportFileToolStripMenuItem.Name = "ImportFileToolStripMenuItem"
        Me.ImportFileToolStripMenuItem.Size = New System.Drawing.Size(137, 22)
        Me.ImportFileToolStripMenuItem.Text = "Import Data"
        '
        'LogOutToolStripMenuItem
        '
        Me.LogOutToolStripMenuItem.Name = "LogOutToolStripMenuItem"
        Me.LogOutToolStripMenuItem.Size = New System.Drawing.Size(137, 22)
        Me.LogOutToolStripMenuItem.Text = "Log Out"
        '
        'CloseToolStripMenuItem
        '
        Me.CloseToolStripMenuItem.Name = "CloseToolStripMenuItem"
        Me.CloseToolStripMenuItem.Size = New System.Drawing.Size(137, 22)
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
        'AdminBtn
        '
        Me.AdminBtn.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AdminBtn.Image = CType(resources.GetObject("AdminBtn.Image"), System.Drawing.Image)
        Me.AdminBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.AdminBtn.Location = New System.Drawing.Point(356, 177)
        Me.AdminBtn.Name = "AdminBtn"
        Me.AdminBtn.Size = New System.Drawing.Size(119, 85)
        Me.AdminBtn.TabIndex = 8
        Me.AdminBtn.Text = "Administrator" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Options"
        Me.AdminBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.AdminBtn.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button1.Location = New System.Drawing.Point(518, 51)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(119, 85)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "Student Contact Log"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button1.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem1, Me.HelpToolStripMenuItem1})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(7, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(678, 24)
        Me.MenuStrip1.TabIndex = 10
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem1
        '
        Me.FileToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ImportDataToolStripMenuItem, Me.LogOutToolStripMenuItem1, Me.ChangePasswordToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem1.Name = "FileToolStripMenuItem1"
        Me.FileToolStripMenuItem1.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem1.Text = "File"
        '
        'ImportDataToolStripMenuItem
        '
        Me.ImportDataToolStripMenuItem.Name = "ImportDataToolStripMenuItem"
        Me.ImportDataToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.ImportDataToolStripMenuItem.Text = "Import Data"
        '
        'LogOutToolStripMenuItem1
        '
        Me.LogOutToolStripMenuItem1.Name = "LogOutToolStripMenuItem1"
        Me.LogOutToolStripMenuItem1.Size = New System.Drawing.Size(168, 22)
        Me.LogOutToolStripMenuItem1.Text = "Log Out"
        '
        'ChangePasswordToolStripMenuItem
        '
        Me.ChangePasswordToolStripMenuItem.Name = "ChangePasswordToolStripMenuItem"
        Me.ChangePasswordToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.ChangePasswordToolStripMenuItem.Text = "Change Password"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'HelpToolStripMenuItem1
        '
        Me.HelpToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GettingStartedToolStripMenuItem, Me.AboutToolStripMenuItem1})
        Me.HelpToolStripMenuItem1.Name = "HelpToolStripMenuItem1"
        Me.HelpToolStripMenuItem1.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem1.Text = "Help"
        '
        'GettingStartedToolStripMenuItem
        '
        Me.GettingStartedToolStripMenuItem.Name = "GettingStartedToolStripMenuItem"
        Me.GettingStartedToolStripMenuItem.Size = New System.Drawing.Size(153, 22)
        Me.GettingStartedToolStripMenuItem.Text = "Getting Started"
        '
        'AboutToolStripMenuItem1
        '
        Me.AboutToolStripMenuItem1.Name = "AboutToolStripMenuItem1"
        Me.AboutToolStripMenuItem1.Size = New System.Drawing.Size(153, 22)
        Me.AboutToolStripMenuItem1.Text = "About..."
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.CadetBlue
        Me.ClientSize = New System.Drawing.Size(678, 299)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.AdminBtn)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.FindApplicantBtn)
        Me.Controls.Add(Me.EmailListBtn)
        Me.Controls.Add(Me.UpdateApplicantBtn)
        Me.Controls.Add(Me.NewApplicantBtn)
        Me.Controls.Add(Me.ExitBtn)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Theatre Arts Application Manager - Main Menu"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ExitBtn As System.Windows.Forms.Button
    Friend WithEvents NewApplicantBtn As System.Windows.Forms.Button
    Friend WithEvents UpdateApplicantBtn As System.Windows.Forms.Button
    Friend WithEvents EmailListBtn As System.Windows.Forms.Button
    Friend WithEvents FindApplicantBtn As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ImportFileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CloseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ManualToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenFileDialog As System.Windows.Forms.OpenFileDialog
    Friend WithEvents AdminBtn As System.Windows.Forms.Button
    Friend WithEvents LogOutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ImportDataToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LogOutToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GettingStartedToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ChangePasswordToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
