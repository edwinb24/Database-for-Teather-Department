Public Class ModeSelectForm
    Public OffCampusMode As Boolean = False

    Private Sub OnCampusBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OnCampusBtn.Click
        OffCampusMode = False
        LogInForm.Show()
        Me.Hide()
    End Sub

    Private Sub OffCampusBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OffCampusBtn.Click
        OffCampusMode = True
        Me.Hide()
        EventForm.ShowDialog()
    End Sub

    Private Sub CloseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseToolStripMenuItem.Click
        'Exits the program.
        Dim UserResponse As MsgBoxResult
        UserResponse = MsgBox("Are you sure you want to exit the program?", MsgBoxStyle.YesNo, "Exit the Program?")

        If (UserResponse = MsgBoxResult.Yes) Then
            End
        End If
    End Sub

    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        AboutForm.ShowDialog()
    End Sub

    Private Sub ModeSelectForm_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        'control the close button and prevent multiple instances from forming.
        If MessageBox.Show("Are you sure you want to exit the program?", "Exit the Program?", MessageBoxButtons.OKCancel) = Windows.Forms.DialogResult.Cancel Then
            e.Cancel = True
        Else
            End
        End If
    End Sub
End Class