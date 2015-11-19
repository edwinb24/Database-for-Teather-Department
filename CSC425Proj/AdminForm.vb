Imports System.Data
Imports System.Data.SqlClient

Public Class AdminForm

    Private Sub BkToMainBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BkToMainBtn.Click
        Me.Hide()
        MainForm.Show()
    End Sub

    Private Sub MangeUsersBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MangeUsersBtn.Click
        UserDBForm.ShowDialog()
    End Sub

    Private Sub EditDatabaseBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViewDatabaseBtn.Click
        ViewDBForm.ShowDialog()
    End Sub

    Private Sub DeleteApplicantBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteApplicantBtn.Click
        FindApplicantToDelete.ShowDialog()
    End Sub

    Private Sub MainMenuToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MainMenuToolStripMenuItem1.Click
        Me.Close()
        MainForm.Show()
    End Sub

    Private Sub ExitToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem1.Click
        'Exits the program.
        Dim UserResponse As MsgBoxResult
        UserResponse = MsgBox("Are you sure you want to exit the program?", MsgBoxStyle.YesNo, "Exit the Program?")

        If (UserResponse = MsgBoxResult.Yes) Then
            End
        End If
    End Sub

    Private Sub AboutToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem1.Click
        AboutForm.ShowDialog()
    End Sub

    Private Sub AdminForm_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        'control the close button and prevent multiple instances from forming.
        If MessageBox.Show("Are you sure you want to exit the program?", "Exit the Program?", MessageBoxButtons.OKCancel) = Windows.Forms.DialogResult.Cancel Then
            e.Cancel = True
        Else
            End
        End If
    End Sub

    Private Sub BackupDBBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BackupDBBtn.Click
        '
        Cursor = Cursors.WaitCursor

        Dim Conn As New SqlConnection
        Conn = LogInForm.Conn
        Dim Cmd As New SqlCommand
        Dim OpenFile As New FolderBrowserDialog
        Dim file_path As String = Nothing

        'Open the dialog window that allows the user to chose a folder to store the backup copy of the database
        If OpenFile.ShowDialog = DialogResult.OK Then
            file_path = OpenFile.SelectedPath.ToString
        End If

        'Back up the database using a SQL statement
        Conn.Open()
        Cmd.Connection = Conn
        Cmd.CommandText = "backup database TheatreManagerDB to disk='" + file_path + "TheatreManagerDB.bak'"

        Cmd.ExecuteNonQuery()

        Conn.Close()

        Cursor = Cursors.Default
    End Sub

    Private Sub RestoreDBBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RestoreDBBtn.Click
        Dim Conn As New SqlConnection
        Conn = LogInForm.Conn
        Dim Cmd As New SqlCommand
        Dim file_path As String = Nothing
        Dim OpenFile As New OpenFileDialog

        'Open a dialog window that allows the user to choose the backup file that restores the database
        If OpenFile.ShowDialog = DialogResult.OK Then
            file_path = OpenFile.FileName.ToString
        End If

        'Restored the database with a SQL statement
        Conn.Open()
        Cmd.Connection = Conn
        Cmd.CommandText = "restore database TheatreManagerDB from disk='" + file_path + "' with replace"
        Cmd.ExecuteNonQuery()

        Conn.Close()
    End Sub

    Private Sub AdminForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub NewDegreeBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewDegreeBtn.Click
        AddNewProgramDialog.Show()
    End Sub
End Class