Imports System.Data
Imports System.Data.SqlClient

Public Class ViewDBForm

    Private Sub AuditionTblBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AuditionTblBtn.Click
        TableLabel.Text = AuditionTblBtn.Text
        TableLabel.Show()
        Dim Conn As New SqlConnection
        Conn = LogInForm.Conn
        Dim sql As String = "select * from Audition"
        Dim adapter As New SqlDataAdapter(sql, Conn)
        Dim ds As New DataSet

        Try
            Conn.Open()

            adapter.Fill(ds, "AuditionTable")
            DataGridView1.DataSource = ds
            DataGridView1.DataMember = "AuditionTable"

            Conn.Close()

        Catch ex As Exception
            MsgBox("Retrieval Error: " & ex.Message, "Data Retrieval Error")
        Finally
            Conn.Close()
        End Try
    End Sub

    Private Sub ContactTblBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ContactTblBtn.Click
        TableLabel.Text = ContactTblBtn.Text
        TableLabel.Show()
        Dim Conn As New SqlConnection
        Conn = LogInForm.Conn
        Dim sql As String = "select * from Contact"
        Dim adapter As New SqlDataAdapter(sql, Conn)
        Dim ds As New DataSet

        Try
            Conn.Open()

            adapter.Fill(ds, "ContactTable")
            DataGridView1.DataSource = ds
            DataGridView1.DataMember = "ContactTable"

            Conn.Close()

        Catch ex As Exception
            MsgBox("Retrieval Error: " & ex.Message, "Data Retrieval Error")
        Finally
            Conn.Close()
        End Try
    End Sub

    Private Sub DegreeTblBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DegreeTblBtn.Click
        TableLabel.Text = DegreeTblBtn.Text
        TableLabel.Show()
        Dim Conn As New SqlConnection
        Conn = LogInForm.Conn
        Dim sql As String = "select * from Degree"
        Dim adapter As New SqlDataAdapter(sql, Conn)
        Dim ds As New DataSet

        Try
            Conn.Open()

            adapter.Fill(ds, "DegreeTable")
            DataGridView1.DataSource = ds
            DataGridView1.DataMember = "DegreeTable"

            Conn.Close()

        Catch ex As Exception
            MsgBox("Retrieval Error: " & ex.Message, "Data Retrieval Error")
        Finally
            Conn.Close()
        End Try
    End Sub

    Private Sub StuInfoTblBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StuInfoTblBtn.Click
        TableLabel.Text = StuInfoTblBtn.Text
        TableLabel.Show()
        Dim Conn As New SqlConnection
        Conn = LogInForm.Conn
        Dim sql As String = "select * from StudentInfo"
        Dim adapter As New SqlDataAdapter(sql, Conn)
        Dim ds As New DataSet

        Try
            Conn.Open()

            adapter.Fill(ds, "StudentInfoTable")
            DataGridView1.DataSource = ds
            DataGridView1.DataMember = "StudentInfoTable"

            Conn.Close()

        Catch ex As Exception
            MsgBox("Retrieval Error: " & ex.Message, "Data Retrieval Error")
        Finally
            Conn.Close()
        End Try
    End Sub

    Private Sub StuEduTblBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StuEduTblBtn.Click
        TableLabel.Text = StuEduTblBtn.Text
        TableLabel.Show()
        Dim Conn As New SqlConnection
        Conn = LogInForm.Conn
        Dim sql As String = "select * from EducationalBackground"
        Dim adapter As New SqlDataAdapter(sql, Conn)
        Dim ds As New DataSet

        Try
            Conn.Open()

            adapter.Fill(ds, "EducationalBackgroundTable")
            DataGridView1.DataSource = ds
            DataGridView1.DataMember = "EducationalBackgroundTable"

            Conn.Close()

        Catch ex As Exception
            MsgBox("Retrieval Error: " & ex.Message, "Data Retrieval Error")
        Finally
            Conn.Close()
        End Try
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

    Private Sub ViewDBForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TableLabel.Hide()
    End Sub
End Class