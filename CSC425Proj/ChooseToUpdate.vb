Imports System.Data
Imports System.Data.SqlClient

Public Class ChooseToUpdate

    Public sql As String

    Dim Conn As SqlConnection

    Private Sub ChooseToUpdate_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        MainForm.Show()
    End Sub

    Private Sub ChooseToUpdate_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Conn = LogInForm.Conn

        Dim sql As String
        sql = FindApplicantToUpdateForm.sql

        Dim da As New SqlDataAdapter(sql, Conn)
        Dim ds As New DataSet

        Try
            Conn.Open()
            da.Fill(ds, "ApplicantUpdate")
            DataGridView1.DataSource = ds
            DataGridView1.DataMember = "ApplicantUpdate"
            Conn.Close()

        Catch ex As Exception
            MsgBox("Can not open connection ! ")
        Finally
            Conn.Close()
        End Try
    End Sub

    Private Sub SelectButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SelectButton.Click
        If DataGridView1.CurrentRow.Cells.Item(6).Value.ToString = Nothing And DataGridView1.CurrentRow.Cells.Item(7).Value.ToString = Nothing And DataGridView1.CurrentRow.Cells.Item(8).Value.ToString = Nothing Then
            sql = "SELECT * FROM EditApplicantView WHERE FirstName = '" + DataGridView1.CurrentRow.Cells.Item(0).Value.ToString _
            + "' AND LastName = '" + DataGridView1.CurrentRow.Cells.Item(1).Value.ToString _
            + "' AND Event = '" + DataGridView1.CurrentRow.Cells.Item(2).Value.ToString _
            + "' AND DegreeType = '" + DataGridView1.CurrentRow.Cells.Item(3).Value.ToString _
            + "' AND Major = '" + DataGridView1.CurrentRow.Cells.Item(4).Value.ToString _
            + "' AND Specialization = '" + DataGridView1.CurrentRow.Cells.Item(5).Value.ToString _
            + "' AND HighSchool = '" + DataGridView1.CurrentRow.Cells.Item(9).Value.ToString _
            + "' AND GradYear = '" + DataGridView1.CurrentRow.Cells.Item(10).Value.ToString _
            + "' AND Test = '" + DataGridView1.CurrentRow.Cells.Item(11).Value.ToString _
            + "' AND Score = '" + DataGridView1.CurrentRow.Cells.Item(12).Value.ToString + "'"
        Else
            sql = "SELECT * FROM EditApplicantView WHERE FirstName = '" + DataGridView1.CurrentRow.Cells.Item(0).Value.ToString _
            + "' AND LastName = '" + DataGridView1.CurrentRow.Cells.Item(1).Value.ToString _
            + "' AND Event = '" + DataGridView1.CurrentRow.Cells.Item(2).Value.ToString _
            + "' AND DegreeType = '" + DataGridView1.CurrentRow.Cells.Item(3).Value.ToString _
            + "' AND Major = '" + DataGridView1.CurrentRow.Cells.Item(4).Value.ToString _
            + "' AND Specialization = '" + DataGridView1.CurrentRow.Cells.Item(5).Value.ToString _
            + "' AND [Audition Date] = '" + DataGridView1.CurrentRow.Cells.Item(6).Value.ToString _
            + "' AND [Audition Score] = '" + DataGridView1.CurrentRow.Cells.Item(7).Value.ToString _
            + "' AND Notes = '" + DataGridView1.CurrentRow.Cells.Item(8).Value.ToString _
            + "' AND HighSchool = '" + DataGridView1.CurrentRow.Cells.Item(9).Value.ToString _
            + "' AND GradYear = '" + DataGridView1.CurrentRow.Cells.Item(10).Value.ToString _
            + "' AND Test = '" + DataGridView1.CurrentRow.Cells.Item(11).Value.ToString _
            + "' AND Score = '" + DataGridView1.CurrentRow.Cells.Item(12).Value.ToString + "'"
        End If

        Me.Hide()
        UpdateForm.Show()
    End Sub

    Private Sub CancelBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CancelBtn.Click
        MainForm.Show()
        Me.Close()
    End Sub

    Private Sub NewSearchBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewSearchBtn.Click
        Me.Close()
        FindApplicantToUpdateForm.ShowDialog()
    End Sub

End Class