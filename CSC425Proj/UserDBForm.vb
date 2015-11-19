Imports System.Data
Imports System.Data.SqlClient

Public Class UserDBForm
    Dim Conn As SqlConnection

    Private Sub UserDBForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        GetAllData()
    End Sub

    Sub GetAllData()
        'Reteives all data in the faculty table of the database.
        Conn = LogInForm.Conn
        Dim sql As String = "select FacultyName, Username from Faculty"
        Dim adapter As New SqlDataAdapter(sql, Conn)
        Dim ds As New DataSet

        Try
            Conn.Open()
            adapter.Fill(ds, "FacultyTable")
            DataGridView1.DataSource = ds
            DataGridView1.DataMember = "FacultyTable"
            Conn.Close()

        Catch ex As Exception
            MsgBox("Can not open connection ! ")
        Finally
            Conn.Close()
        End Try
    End Sub

    Private Sub UserDBForm_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseClick
        'MsgBox(DataGridView1.CurrentCell.Value.ToString)
    End Sub

    Private Sub DeleteUserBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteUserBtn.Click
        Dim UserResponse As MsgBoxResult
        If Trim(DataGridView1.CurrentRow.Cells.Item(0).Value.ToString) = "Administrator" Then
            MsgBox("You cannot delete the Administrator Account.", MsgBoxStyle.Information, "Error")
        Else
            UserResponse = MsgBox("NOTE: All Changes Are Final!!" + System.Environment.NewLine + "You are about to delete the user, '" + Trim(DataGridView1.CurrentRow.Cells.Item(0).Value.ToString) + "', are you sure you want to do this?", MsgBoxStyle.YesNoCancel, "Confirm Selection")
        End If

        If UserResponse = MsgBoxResult.Yes Then
            Dim DeleteUser As New SqlCommand
            Dim Conn As New SqlConnection()

            'pass database connection to the connection variable.
            Conn = LogInForm.Conn

            'attempt to send the command to the database.
            Try
                'open the connection to the DB.
                Conn.Open()

                'give the open connection to the sending command variable.
                DeleteUser.Connection = Conn

                'give the query to be sent to the command variable.
                DeleteUser.CommandText = "DELETE FROM Faculty WHERE Username='" + DataGridView1.CurrentRow.Cells.Item(1).Value.ToString + "'"

                'execute the query
                DeleteUser.ExecuteNonQuery()

            Catch ex As Exception
                MessageBox.Show("Deletion Error: " & ex.Message, "Failed to delete user")
            Finally
                'close the connection regardless of success or failure.
                Conn.Close()
                'reload datagrid data
                GetAllData()
                DataGridView1.Refresh()
            End Try
        End If
    End Sub

    Private Sub ChangePwdBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ResetPwdBtn.Click
        'InputBox("Enter the new password", "New password")
        ResetPwdDialog.ShowDialog()
        GetAllData()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        AddNewUserDialog.ShowDialog()
        GetAllData()
    End Sub

    Private Sub AboutToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem1.Click
        AboutForm.ShowDialog()
    End Sub

    Private Sub ExitToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem1.Click
        'Exits the program.
        Dim UserResponse As MsgBoxResult
        UserResponse = MsgBox("Are you sure you want to exit the program?", MsgBoxStyle.YesNo, "Exit the Program?")

        If (UserResponse = MsgBoxResult.Yes) Then
            End
        End If
    End Sub

    Private Sub MainMenuToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MainMenuToolStripMenuItem1.Click
        Me.Close()
        AdminForm.Close()
        MainForm.Show()
    End Sub
End Class