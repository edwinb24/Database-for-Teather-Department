Imports System.Data
Imports System.Data.SqlClient

Public Class ChooseToDelete

    Public studentinfo As String
    Public edbackground As String
    Public audition As String

    Dim Conn As New SqlConnection

    Private Sub ChooseToDelete_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        AdminForm.Show()
    End Sub

    Private Sub ChooseToDelete_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If FindApplicantToDelete.GradDate = False Then
            DeleteAllButton.Hide()
        Else
            DeleteAllButton.Show()
        End If

        '
        GetAllData()
    End Sub

    Private Sub SelectButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteButton.Click

        Dim Conn As New SqlConnection
        Dim DeleteApplicantCmd As New SqlCommand
        Conn = LogInForm.Conn

        'declare transaction
        Dim DeleteTrans

        If FindApplicantToDelete.GradDate = False Then

            'Send the insert queries to the database.
            Try
                'open the connection to the DB.
                Conn.Open()

                'give the open connection to the sending command variable.
                DeleteApplicantCmd.Connection = Conn

                'give the transaction the open connection.
                DeleteTrans = Conn.BeginTransaction

                'pass transaction to sql command variable
                DeleteApplicantCmd.Transaction = DeleteTrans

                'give the query to be sent to the command variable for the student info table.
                DeleteApplicantCmd.CommandText = "DELETE FROM StudentInfo WHERE FirstName = '" + Trim(DataGridView1.CurrentRow.Cells.Item(0).Value.ToString) + "' AND LastName = '" + Trim(DataGridView1.CurrentRow.Cells.Item(1).Value.ToString) + "' AND Address = '" + Trim(DataGridView1.CurrentRow.Cells.Item(2).Value.ToString) + "' AND ZipCode = '" + Trim(DataGridView1.CurrentRow.Cells.Item(5).Value.ToString) + "' AND Email = '" + Trim(DataGridView1.CurrentRow.Cells.Item(6).Value.ToString) + "'"

                'execute the query
                DeleteApplicantCmd.ExecuteNonQuery()

                'give the query to be sent to the command variable for the education background table.
                DeleteApplicantCmd.CommandText = "DELETE FROM EducationalBackground WHERE FirstName = '" + Trim(DataGridView1.CurrentRow.Cells.Item(0).Value.ToString) + "' AND LastName = '" + Trim(DataGridView1.CurrentRow.Cells.Item(1).Value.ToString) + "' AND Address = '" + Trim(DataGridView1.CurrentRow.Cells.Item(2).Value.ToString) + "' AND ZipCode = '" + Trim(DataGridView1.CurrentRow.Cells.Item(5).Value.ToString) + "' AND Email = '" + Trim(DataGridView1.CurrentRow.Cells.Item(6).Value.ToString) + "'"

                'execute the query
                DeleteApplicantCmd.ExecuteNonQuery()

                'give the query to be sent to the command variable for the contact table.
                DeleteApplicantCmd.CommandText = "DELETE FROM Contact WHERE FirstName = '" + Trim(DataGridView1.CurrentRow.Cells.Item(0).Value.ToString) + "' AND LastName = '" + Trim(DataGridView1.CurrentRow.Cells.Item(1).Value.ToString) + "' AND Address = '" + Trim(DataGridView1.CurrentRow.Cells.Item(2).Value.ToString) + "' AND ZipCode = '" + Trim(DataGridView1.CurrentRow.Cells.Item(5).Value.ToString) + "' AND Email = '" + Trim(DataGridView1.CurrentRow.Cells.Item(6).Value.ToString) + "'"

                'execute the query
                DeleteApplicantCmd.ExecuteNonQuery()

                'give the query to be sent to the command variable for the audition table.
                DeleteApplicantCmd.CommandText = "DELETE FROM Audition WHERE FirstName = '" + Trim(DataGridView1.CurrentRow.Cells.Item(0).Value.ToString) + "' AND LastName = '" + Trim(DataGridView1.CurrentRow.Cells.Item(1).Value.ToString) + "' AND Address = '" + Trim(DataGridView1.CurrentRow.Cells.Item(2).Value.ToString) + "' AND ZipCode = '" + Trim(DataGridView1.CurrentRow.Cells.Item(5).Value.ToString) + "' AND Email = '" + Trim(DataGridView1.CurrentRow.Cells.Item(6).Value.ToString) + "'"

                'execute the query
                DeleteApplicantCmd.ExecuteNonQuery()

                'commit tranaction now all queries have executed."
                DeleteTrans.Commit()

                'promt the user on success
                MsgBox("Applicant information has been successfully Deleted.", MsgBoxStyle.Information, _
                                       "Successful Deletion")

            Catch ex As Exception
                'rollback transaction upon error
                DeleteTrans.Rollback()
                MsgBox("Error while deleting records in table..." & ex.Message, MsgBoxStyle.Information, "Deletion Failed")
            Finally
                'close the connection regardless of success or failure.
                Conn.Close()
                Cursor.Current = Cursors.Default
            End Try
        End If
        '
        Cursor.Current = Cursors.Default
        'refesh information in the datagrid to show any changes.
        GetAllData()
    End Sub

    Private Sub CancelBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CancelBtn.Click
        AdminForm.Show()
        Me.Close()
    End Sub

    Private Sub NewSearchBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewSearchBtn.Click
        Me.Close()
        FindApplicantToDelete.ShowDialog()
    End Sub

    Private Sub DeleteAllButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteAllButton.Click
        '
        Cursor = Cursors.WaitCursor

        Dim Conn As New SqlConnection
        Dim DeleteApplicantCmd As New SqlCommand
        Dim CheckCmd As New SqlCommand

        Dim Index As Integer = 0
        Dim EndVal As Integer = DataGridView1.RowCount - 1
        Dim ErrorCounter As Integer = 0

        Conn = LogInForm.Conn

        'declare transaction
        Dim DeleteAllTrans

        'delete all the applicants in the datagrid
        For Index = 0 To EndVal Step 1
            Try
                'open the connection to the DB.
                Conn.Open()

                'give the open connection to the sending command variable.
                DeleteApplicantCmd.Connection = Conn

                'give the transaction the open connection.
                DeleteAllTrans = Conn.BeginTransaction

                'pass transaction to sql command variable
                DeleteApplicantCmd.Transaction = DeleteAllTrans

                'give the query to be sent to the command variable for the student info table.
                DeleteApplicantCmd.CommandText = "DELETE FROM StudentInfo WHERE FirstName = '" + Trim(DataGridView1.Rows(Index).Cells.Item(0).Value.ToString) + "' AND LastName = '" + Trim(DataGridView1.Rows(Index).Cells.Item(1).Value.ToString) + "' AND Address = '" + Trim(DataGridView1.Rows(Index).Cells.Item(2).Value.ToString) + "' AND ZipCode = '" + Trim(DataGridView1.Rows(Index).Cells.Item(5).Value.ToString) + "' AND Email = '" + Trim(DataGridView1.Rows(Index).Cells.Item(6).Value.ToString) + "'"

                'execute the query
                DeleteApplicantCmd.ExecuteNonQuery()

                'give the query to be sent to the command variable for the education background table.
                DeleteApplicantCmd.CommandText = "DELETE FROM EducationalBackground WHERE FirstName = '" + Trim(DataGridView1.Rows(Index).Cells.Item(0).Value.ToString) + "' AND LastName = '" + Trim(DataGridView1.Rows(Index).Cells.Item(1).Value.ToString) + "' AND Address = '" + Trim(DataGridView1.Rows(Index).Cells.Item(2).Value.ToString) + "' AND ZipCode = '" + Trim(DataGridView1.Rows(Index).Cells.Item(5).Value.ToString) + "' AND Email = '" + Trim(DataGridView1.Rows(Index).Cells.Item(6).Value.ToString) + "'"

                'execute the query
                DeleteApplicantCmd.ExecuteNonQuery()

                'give the query to be sent to the command variable for the contact table.
                DeleteApplicantCmd.CommandText = "DELETE FROM Contact WHERE FirstName = '" + Trim(DataGridView1.Rows(Index).Cells.Item(0).Value.ToString) + "' AND LastName = '" + Trim(DataGridView1.Rows(Index).Cells.Item(1).Value.ToString) + "' AND Address = '" + Trim(DataGridView1.Rows(Index).Cells.Item(2).Value.ToString) + "' AND ZipCode = '" + Trim(DataGridView1.Rows(Index).Cells.Item(5).Value.ToString) + "' AND Email = '" + Trim(DataGridView1.Rows(Index).Cells.Item(6).Value.ToString) + "'"

                'execute the query
                DeleteApplicantCmd.ExecuteNonQuery()

                'give the query to be sent to the command variable for the audition table.
                DeleteApplicantCmd.CommandText = "DELETE FROM Audition WHERE FirstName = '" + Trim(DataGridView1.Rows(Index).Cells.Item(0).Value.ToString) + "' AND LastName = '" + Trim(DataGridView1.Rows(Index).Cells.Item(1).Value.ToString) + "' AND Address = '" + Trim(DataGridView1.Rows(Index).Cells.Item(2).Value.ToString) + "' AND ZipCode = '" + Trim(DataGridView1.Rows(Index).Cells.Item(5).Value.ToString) + "' AND Email = '" + Trim(DataGridView1.Rows(Index).Cells.Item(6).Value.ToString) + "'"

                'execute the query
                DeleteApplicantCmd.ExecuteNonQuery()

                'commit tranaction now all queries have executed."
                DeleteAllTrans.Commit()

            Catch ex As Exception
                'rollback transaction upon error
                DeleteAllTrans.Rollback()
                'count the number of unsuccessful deletes.
                ErrorCounter = ErrorCounter + 1
            Finally
                'close the connection regardless of success or failure.
                Conn.Close()
            End Try
        Next Index


        'Check and promt if there are errors.
        If ErrorCounter = 0 Then
            'promt the user on success
            MsgBox("All " + Index.ToString + " Applicants' information has been successfully Deleted.", MsgBoxStyle.Information, _
                                   "Successful Deletion")
        Else
            MsgBox(ErrorCounter.ToString + "out of the " + Index.ToString + " Applicants' information has been successfully Deleted.", MsgBoxStyle.Information, _
                                   "Incomplete Deletion")
        End If

        'refesh information in the datagrid to show any changes.
        GetAllData()

        '
        Cursor.Current = Cursors.Default
    End Sub

    Sub GetAllData()
        'Reteives all information about the applicant in the database.
        Conn = LogInForm.Conn

        Dim sql As String
        sql = FindApplicantToDelete.sql

        Dim da As New SqlDataAdapter(sql, Conn)
        Dim ds As New DataSet

        Try
            Conn.Open()
            da.Fill(ds, "ApplicantDeleted")
            DataGridView1.DataSource = ds
            DataGridView1.DataMember = "ApplicantDeleted"
            Conn.Close()

        Catch ex As Exception
            MsgBox("Can not open connection ! for dg")
        Finally
            Conn.Close()
        End Try
    End Sub
End Class
