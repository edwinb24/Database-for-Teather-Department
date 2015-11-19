Imports System.Data
Imports System.Data.SqlClient

Public Class EmailListForm

    Private Sub BackBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BackBtn.Click
        MainForm.Show()
        Me.Close()
    End Sub

    Private Sub EmailListForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        FilterComboBox.Text = "Filter List By:"

        'Get email addresses from the database.
        Dim Conn As New SqlConnection
        Dim sql As String

        Conn = LogInForm.Conn
        sql = "SELECT * FROM EmailListView"

        Dim da As New SqlDataAdapter(sql, Conn)
        Dim ds As New DataSet

        Try
            Conn.Open()
            da.Fill(ds, "EmailList")
            DataGridView1.DataSource = ds
            DataGridView1.DataMember = "EmailList"
            Conn.Close()

        Catch ex As Exception
            MessageBox.Show("Could not connect to the database, please check your connection and try again.", "Search Results Retrieval Failed")
        Finally
            Conn.Close()
        End Try
    End Sub

    Private Sub CopyToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CopyToolStripMenuItem.Click
        'Copy Text from datagrid to the windows O/S clipboard
        Clipboard.SetDataObject(Trim(DataGridView1.GetClipboardContent.GetText.ToString))
    End Sub

    Private Sub CopyBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CopyBtn.Click
        'Copy Text from datagrid to the windows O/S clipboard
        Clipboard.SetDataObject(Trim(DataGridView1.GetClipboardContent.GetText.ToString))
    End Sub

    Private Sub FilterComboBox_DropDown(ByVal sender As Object, ByVal e As System.EventArgs) Handles FilterComboBox.DropDown
        '
        Cursor = Cursors.WaitCursor

        'clear the combo box for the new items to be populated.
        FilterComboBox.Items.Clear()
        FilterComboBox.Items.Add("None")

        'Load degree programs at form load.
        Dim GetMajors As New SqlCommand
        Dim DataReader As SqlDataReader
        Dim Conn As New SqlConnection()

        'pass database connection to the connection variable.
        Conn = LogInForm.Conn

        'attempt to send the command to the database.
        Try
            'open the connection to the DB.
            Conn.Open()

            'give the open connection to the sending command variable.
            GetMajors.Connection = Conn

            'give the query to be sent to the command variable.
            GetMajors.CommandText = "SELECT DISTINCT Major FROM Degree"

            'assign the data reader the query results
            DataReader = GetMajors.ExecuteReader

            'read the data returned from the query into the combobox.
            While DataReader.Read()
                FilterComboBox.Items.Add(Trim(DataReader.Item(0).ToString))
            End While

        Catch ex As Exception
            MessageBox.Show("Retrieval Error: " & ex.Message, "Major Retrieval Failed")
        Finally 'close the connection regardless of success or failure.
            Conn.Close()
            Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub FilterComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FilterComboBox.SelectedIndexChanged
        Dim Conn As New SqlConnection
        Dim sql As String

        Conn = LogInForm.Conn

        If FilterComboBox.Text = "None" Then
            sql = "SELECT * FROM EmailListView"
        Else
            sql = "SELECT * FROM EmailListView WHERE Major='" + FilterComboBox.Text + "'"
        End If

        Dim da As New SqlDataAdapter(sql, Conn)
        Dim ds As New DataSet

        Try
            Conn.Open()
            da.Fill(ds, "EmailList")
            DataGridView1.DataSource = ds
            DataGridView1.DataMember = "EmailList"
            Conn.Close()

        Catch ex As Exception
            MessageBox.Show("Could not connect to the database, please check your connection and try again.", "Search Results Retrieval Failed")
        Finally
            Conn.Close()
        End Try
    End Sub
End Class