Public Class MainForm

    Private Sub NewApplicantBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewApplicantBtn.Click
        EventForm.ShowDialog()
    End Sub

    Private Sub ExitBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitBtn.Click
        'Exits the program.
        Dim UserResponse As MsgBoxResult
        UserResponse = MsgBox("Are you sure you want to exit the program?", MsgBoxStyle.YesNo, "Exit the Program?")

        If (UserResponse = MsgBoxResult.Yes) Then
            End
        End If
    End Sub

    Private Sub UpdateApplicantBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UpdateApplicantBtn.Click
        FindApplicantToUpdateForm.ShowDialog()
    End Sub

    Private Sub FindApplicantBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FindApplicantBtn.Click
        FinderForm.ShowDialog()
    End Sub

    Private Sub MainForm_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        'control the close button and prevent multiple instances from forming.
        If MessageBox.Show("Are you sure you want to exit the program?", "Exit the Program?", MessageBoxButtons.OKCancel) = Windows.Forms.DialogResult.Cancel Then
            e.Cancel = True
        Else
            End
        End If
    End Sub

    Private Sub MainForm_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        'make sure all other open forms are closed when the main menu is shown
        FinderForm.Close()
        NewApplicantForm.Close()
        FinderForm.Close()
        UpdateForm.Close()
        EventForm.Close()
    End Sub

    Private Sub MainForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If LogInForm.UsernameTextBox.Text = "admin" Then
            AdminBtn.Show()
        Else
            AdminBtn.Hide()
        End If
    End Sub

    Private Sub AdminBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AdminBtn.Click
        AdminForm.Show()
        Me.Hide()
    End Sub

    Private Sub ImportDataToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ImportDataToolStripMenuItem.Click
        'This segment of code opens a file dialog when the textbox is clicked.
        Dim Result As DialogResult
        Result = OpenFileDialog.ShowDialog()

        If Result = Windows.Forms.DialogResult.OK Then
            'if the file is good run the commands.
        End If
    End Sub

    Private Sub AboutToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem1.Click
        AboutForm.ShowDialog()
    End Sub

    Private Sub LogOutToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LogOutToolStripMenuItem1.Click
        LogInForm.PasswordTextBox.Clear()
        LogInForm.UsernameTextBox.Clear()
        Me.Close()
        LogInForm.Show()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        'Exits the program.
        Dim UserResponse As MsgBoxResult
        UserResponse = MsgBox("Are you sure you want to exit the program?", MsgBoxStyle.YesNo, "Exit the Program?")

        If (UserResponse = MsgBoxResult.Yes) Then
            End
        End If
    End Sub

    Private Sub ChangePasswordToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChangePasswordToolStripMenuItem.Click
        ChangePwdDialog.ShowDialog()
    End Sub

    Private Sub EmailListBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EmailListBtn.Click
        EmailListForm.ShowDialog()
    End Sub
End Class