<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AdminForm))
        Me.MangeUsersBtn = New System.Windows.Forms.Button
        Me.ViewDatabaseBtn = New System.Windows.Forms.Button
        Me.BkToMainBtn = New System.Windows.Forms.Button
        Me.RestoreDBBtn = New System.Windows.Forms.Button
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.FileToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.MainMenuToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.ExitToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.HelpToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.GettingStartedToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.AdminFeaturesToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.AboutToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.MainMenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.GettingStartedToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AdminFeaturesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.DeleteApplicantBtn = New System.Windows.Forms.Button
        Me.BackupDBBtn = New System.Windows.Forms.Button
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        Me.NewDegreeBtn = New System.Windows.Forms.Button
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MangeUsersBtn
        '
        Me.MangeUsersBtn.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MangeUsersBtn.Image = CType(resources.GetObject("MangeUsersBtn.Image"), System.Drawing.Image)
        Me.MangeUsersBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.MangeUsersBtn.Location = New System.Drawing.Point(27, 44)
        Me.MangeUsersBtn.Name = "MangeUsersBtn"
        Me.MangeUsersBtn.Size = New System.Drawing.Size(116, 83)
        Me.MangeUsersBtn.TabIndex = 1
        Me.MangeUsersBtn.Text = "Manage Users"
        Me.MangeUsersBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.MangeUsersBtn.UseVisualStyleBackColor = True
        '
        'ViewDatabaseBtn
        '
        Me.ViewDatabaseBtn.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ViewDatabaseBtn.Image = CType(resources.GetObject("ViewDatabaseBtn.Image"), System.Drawing.Image)
        Me.ViewDatabaseBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.ViewDatabaseBtn.Location = New System.Drawing.Point(223, 44)
        Me.ViewDatabaseBtn.Name = "ViewDatabaseBtn"
        Me.ViewDatabaseBtn.Size = New System.Drawing.Size(116, 83)
        Me.ViewDatabaseBtn.TabIndex = 4
        Me.ViewDatabaseBtn.Text = "View Database"
        Me.ViewDatabaseBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ViewDatabaseBtn.UseVisualStyleBackColor = True
        '
        'BkToMainBtn
        '
        Me.BkToMainBtn.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BkToMainBtn.Location = New System.Drawing.Point(482, 271)
        Me.BkToMainBtn.Name = "BkToMainBtn"
        Me.BkToMainBtn.Size = New System.Drawing.Size(138, 32)
        Me.BkToMainBtn.TabIndex = 7
        Me.BkToMainBtn.Text = "Back to Main Menu"
        Me.BkToMainBtn.UseVisualStyleBackColor = True
        '
        'RestoreDBBtn
        '
        Me.RestoreDBBtn.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RestoreDBBtn.Image = CType(resources.GetObject("RestoreDBBtn.Image"), System.Drawing.Image)
        Me.RestoreDBBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.RestoreDBBtn.Location = New System.Drawing.Point(223, 161)
        Me.RestoreDBBtn.Name = "RestoreDBBtn"
        Me.RestoreDBBtn.Size = New System.Drawing.Size(116, 83)
        Me.RestoreDBBtn.TabIndex = 3
        Me.RestoreDBBtn.Text = "Restore Database"
        Me.RestoreDBBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.RestoreDBBtn.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem1, Me.HelpToolStripMenuItem1})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(632, 24)
        Me.MenuStrip1.TabIndex = 7
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem1
        '
        Me.FileToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MainMenuToolStripMenuItem1, Me.ExitToolStripMenuItem1})
        Me.FileToolStripMenuItem1.Name = "FileToolStripMenuItem1"
        Me.FileToolStripMenuItem1.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem1.Text = "File"
        '
        'MainMenuToolStripMenuItem1
        '
        Me.MainMenuToolStripMenuItem1.Name = "MainMenuToolStripMenuItem1"
        Me.MainMenuToolStripMenuItem1.Size = New System.Drawing.Size(135, 22)
        Me.MainMenuToolStripMenuItem1.Text = "Main Menu"
        '
        'ExitToolStripMenuItem1
        '
        Me.ExitToolStripMenuItem1.Name = "ExitToolStripMenuItem1"
        Me.ExitToolStripMenuItem1.Size = New System.Drawing.Size(135, 22)
        Me.ExitToolStripMenuItem1.Text = "Exit"
        '
        'HelpToolStripMenuItem1
        '
        Me.HelpToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GettingStartedToolStripMenuItem1, Me.AdminFeaturesToolStripMenuItem1, Me.AboutToolStripMenuItem1})
        Me.HelpToolStripMenuItem1.Name = "HelpToolStripMenuItem1"
        Me.HelpToolStripMenuItem1.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem1.Text = "Help"
        '
        'GettingStartedToolStripMenuItem1
        '
        Me.GettingStartedToolStripMenuItem1.Name = "GettingStartedToolStripMenuItem1"
        Me.GettingStartedToolStripMenuItem1.Size = New System.Drawing.Size(157, 22)
        Me.GettingStartedToolStripMenuItem1.Text = "Getting Started"
        '
        'AdminFeaturesToolStripMenuItem1
        '
        Me.AdminFeaturesToolStripMenuItem1.Name = "AdminFeaturesToolStripMenuItem1"
        Me.AdminFeaturesToolStripMenuItem1.Size = New System.Drawing.Size(157, 22)
        Me.AdminFeaturesToolStripMenuItem1.Text = "Admin Features"
        '
        'AboutToolStripMenuItem1
        '
        Me.AboutToolStripMenuItem1.Name = "AboutToolStripMenuItem1"
        Me.AboutToolStripMenuItem1.Size = New System.Drawing.Size(157, 22)
        Me.AboutToolStripMenuItem1.Text = "About..."
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MainMenuToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'MainMenuToolStripMenuItem
        '
        Me.MainMenuToolStripMenuItem.Name = "MainMenuToolStripMenuItem"
        Me.MainMenuToolStripMenuItem.Size = New System.Drawing.Size(135, 22)
        Me.MainMenuToolStripMenuItem.Text = "Main Menu"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(135, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GettingStartedToolStripMenuItem, Me.AdminFeaturesToolStripMenuItem, Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'GettingStartedToolStripMenuItem
        '
        Me.GettingStartedToolStripMenuItem.Name = "GettingStartedToolStripMenuItem"
        Me.GettingStartedToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.GettingStartedToolStripMenuItem.Text = "Getting Started"
        '
        'AdminFeaturesToolStripMenuItem
        '
        Me.AdminFeaturesToolStripMenuItem.Name = "AdminFeaturesToolStripMenuItem"
        Me.AdminFeaturesToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.AdminFeaturesToolStripMenuItem.Text = "Admin Features"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.AboutToolStripMenuItem.Text = "About..."
        '
        'DeleteApplicantBtn
        '
        Me.DeleteApplicantBtn.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DeleteApplicantBtn.Image = CType(resources.GetObject("DeleteApplicantBtn.Image"), System.Drawing.Image)
        Me.DeleteApplicantBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.DeleteApplicantBtn.Location = New System.Drawing.Point(424, 44)
        Me.DeleteApplicantBtn.Name = "DeleteApplicantBtn"
        Me.DeleteApplicantBtn.Size = New System.Drawing.Size(116, 83)
        Me.DeleteApplicantBtn.TabIndex = 5
        Me.DeleteApplicantBtn.Text = " Delete An Applicant"
        Me.DeleteApplicantBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.DeleteApplicantBtn.UseVisualStyleBackColor = True
        '
        'BackupDBBtn
        '
        Me.BackupDBBtn.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BackupDBBtn.Image = CType(resources.GetObject("BackupDBBtn.Image"), System.Drawing.Image)
        Me.BackupDBBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BackupDBBtn.Location = New System.Drawing.Point(27, 161)
        Me.BackupDBBtn.Name = "BackupDBBtn"
        Me.BackupDBBtn.Size = New System.Drawing.Size(116, 83)
        Me.BackupDBBtn.TabIndex = 2
        Me.BackupDBBtn.Text = "Backup Database"
        Me.BackupDBBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BackupDBBtn.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'NewDegreeBtn
        '
        Me.NewDegreeBtn.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NewDegreeBtn.Image = CType(resources.GetObject("NewDegreeBtn.Image"), System.Drawing.Image)
        Me.NewDegreeBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.NewDegreeBtn.Location = New System.Drawing.Point(424, 161)
        Me.NewDegreeBtn.Name = "NewDegreeBtn"
        Me.NewDegreeBtn.Size = New System.Drawing.Size(116, 83)
        Me.NewDegreeBtn.TabIndex = 8
        Me.NewDegreeBtn.Text = "Add A Degree Program"
        Me.NewDegreeBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.NewDegreeBtn.UseVisualStyleBackColor = True
        '
        'AdminForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.CadetBlue
        Me.ClientSize = New System.Drawing.Size(632, 315)
        Me.Controls.Add(Me.NewDegreeBtn)
        Me.Controls.Add(Me.DeleteApplicantBtn)
        Me.Controls.Add(Me.RestoreDBBtn)
        Me.Controls.Add(Me.BkToMainBtn)
        Me.Controls.Add(Me.ViewDatabaseBtn)
        Me.Controls.Add(Me.BackupDBBtn)
        Me.Controls.Add(Me.MangeUsersBtn)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "AdminForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Theatre Arts Application Manager - Administrator Options"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MangeUsersBtn As System.Windows.Forms.Button
    Friend WithEvents BackupDBBtn As System.Windows.Forms.Button
    Friend WithEvents ViewDatabaseBtn As System.Windows.Forms.Button
    Friend WithEvents BkToMainBtn As System.Windows.Forms.Button
    Friend WithEvents RestoreDBBtn As System.Windows.Forms.Button
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GettingStartedToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AdminFeaturesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MainMenuToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeleteApplicantBtn As System.Windows.Forms.Button
    Friend WithEvents FileToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MainMenuToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GettingStartedToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AdminFeaturesToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents NewDegreeBtn As System.Windows.Forms.Button
End Class
