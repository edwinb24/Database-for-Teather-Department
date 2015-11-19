Imports System.Data
Imports System.Data.SqlClient

Public Class SearchResultsForm

    Private Sub CancelBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CancelBtn.Click
        MainForm.Show()
        Me.Close()
    End Sub

    Private Sub NewSearchBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewSearchBtn.Click
        Me.Close()
        FinderForm.ShowDialog()
    End Sub

    Private Sub SearchResultsForm_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        MainForm.Show()
    End Sub

    Private Sub SearchResultsForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim Conn As New SqlConnection
        Dim sql As String

        Conn = LogInForm.Conn
        sql = FinderForm.SearchQuery.CommandText.ToString

        Dim da As New SqlDataAdapter(sql, Conn)
        Dim ds As New DataSet

        Try
            Conn.Open()
            da.Fill(ds, "FindApplicants")
            DataGridView1.DataSource = ds
            DataGridView1.DataMember = "FindApplicants"
            Conn.Close()

        Catch ex As Exception
            MessageBox.Show("Could not connect to the database, please check your connection and try again.", "Search Results Retrieval Failed")
        Finally
            Conn.Close()
        End Try
    End Sub

    Private Sub GenRptBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GenRptBtn.Click
        Cursor = Cursors.WaitCursor
        ApplicantReportForm.Show()
        Cursor = Cursors.Default
    End Sub
End Class