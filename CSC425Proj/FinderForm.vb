Imports System.Data
Imports System.Data.SqlClient

Public Class FinderForm
    'Used to control select statement
    Public SearchQuery As New SqlCommand
    Dim AuditionDate As String
    Dim HasResults As Boolean

    Private Sub SubjectComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SubjectComboBox.SelectedIndexChanged
        If SubjectComboBox.Text = "Major" Then
            FNameTextBox.Hide()
            GradDatePicker.Hide()
            AuditionDatePicker.Hide()
            LNameTextBox.Hide()
            MajorComboBox.Text = "-- Please Selelect A Major --"
            MajorComboBox.Show()
        ElseIf SubjectComboBox.Text = "First Name" Then
            MajorComboBox.Hide()
            GradDatePicker.Hide()
            LNameTextBox.Hide()
            AuditionDatePicker.Hide()
            FNameTextBox.BackColor = Color.White
            FNameTextBox.Text = "Enter First Name..."
            FNameTextBox.Show()
        ElseIf SubjectComboBox.Text = "Last Name" Then
            MajorComboBox.Hide()
            GradDatePicker.Hide()
            AuditionDatePicker.Hide()
            FNameTextBox.Hide()
            LNameTextBox.BackColor = Color.White
            LNameTextBox.Text = "Enter Last Name..."
            LNameTextBox.Show()
        ElseIf SubjectComboBox.Text = "Full Name" Then
            MajorComboBox.Hide()
            GradDatePicker.Hide()
            AuditionDatePicker.Hide()
            FNameTextBox.Text = "Enter First Name..."
            LNameTextBox.Text = "Enter Last Name..."
            FNameTextBox.BackColor = Color.White
            LNameTextBox.BackColor = Color.White
            FNameTextBox.Show()
            LNameTextBox.Show()
        ElseIf SubjectComboBox.Text = "Graduation Date" Then
            MajorComboBox.Hide()
            FNameTextBox.Hide()
            LNameTextBox.Hide()
            AuditionDatePicker.Hide()
            GradDatePicker.Show()
        ElseIf SubjectComboBox.Text = "Audition Date" Then
            MajorComboBox.Hide()
            FNameTextBox.Hide()
            LNameTextBox.Hide()
            GradDatePicker.Hide()
            AuditionDatePicker.Show()
        End If
    End Sub

    Private Sub CancelBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CancelBtn.Click
        Me.Close()
    End Sub

    Private Sub FinderForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MajorComboBox.Hide()
        FNameTextBox.Hide()
        LNameTextBox.Hide()
        GradDatePicker.Hide()
        AuditionDatePicker.Hide()
        SubjectComboBox.Text = Nothing
    End Sub

    Private Sub FNameTextBox_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles FNameTextBox.Click
        FNameTextBox.Clear()
        FNameTextBox.BackColor = Color.White
    End Sub

    Private Sub LNameTextBox_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles LNameTextBox.Click
        LNameTextBox.Clear()
        LNameTextBox.BackColor = Color.White
    End Sub

    Private Sub MajorComboBox_DropDown(ByVal sender As Object, ByVal e As System.EventArgs) Handles MajorComboBox.DropDown
        '
        Cursor = Cursors.WaitCursor

        'clear the combo box for the new items to be populated.
        MajorComboBox.Items.Clear()

        'Load degree programs at form load.
        Dim GetMajor As New SqlCommand
        Dim DataReader As SqlDataReader
        Dim Conn As New SqlConnection()

        'pass database connection to the connection variable.
        Conn = LogInForm.Conn

        'attempt to send the command to the database.
        Try
            'open the connection to the DB.
            Conn.Open()

            'give the open connection to the sending command variable.
            GetMajor.Connection = Conn

            'give the query to be sent to the command variable.
            GetMajor.CommandText = "SELECT DISTINCT Major FROM Degree"

            'assign the data reader the query results
            DataReader = GetMajor.ExecuteReader

            'read the data returned from the query into the combobox.
            While DataReader.Read()
                MajorComboBox.Items.Add(Trim(DataReader.Item(0).ToString))
            End While

        Catch ex As Exception
            MessageBox.Show("Could not connect to the database, please check your connection and try again.", "Major Retrieval Failed")
        Finally 'close the connection regardless of success or failure.
            Conn.Close()
            Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub FindApplicantsBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FindApplicantsBtn.Click
        'validate user input.
        If SubjectComboBox.Text = Nothing Then
            SubjectComboBox.BackColor = Color.Salmon
            MsgBox("Please choose your desired search parameters from the drop down menu.", MsgBoxStyle.OkOnly, "Missing Credentials")

        ElseIf SubjectComboBox.Text = "First Name" And (FNameTextBox.Text = Nothing Or FNameTextBox.Text = "Enter First Name...") Then
            MsgBox("Please enter the first name of the desired applicant.", MsgBoxStyle.Information, "Missing Credentials")
            FNameTextBox.BackColor = Color.Salmon

        ElseIf SubjectComboBox.Text = "Last Name" And (LNameTextBox.Text = Nothing Or LNameTextBox.Text = "Enter Last Name...") Then
            MsgBox("Please enter the last name of the desired applicant.", MsgBoxStyle.Information, "Missing Credentials")
            LNameTextBox.BackColor = Color.Salmon

        ElseIf SubjectComboBox.Text = "Full Name" And ((FNameTextBox.Text = Nothing Or FNameTextBox.Text = "Enter First Name...") Or (LNameTextBox.Text = Nothing Or FNameTextBox.Text = "Enter Last Name...")) Then
            MsgBox("Please enter the missing credentials of the desired applicant.", MsgBoxStyle.Information, "Missing Credentials")
            FNameTextBox.BackColor = Color.Salmon
            LNameTextBox.BackColor = Color.Salmon

        Else
            'give the query to be sent to the command variable based on the search parameters.
            If SubjectComboBox.Text = "Full Name" Then
                SearchQuery.CommandText = "SELECT * FROM FindStudentInfoView WHERE FirstName='" + FNameTextBox.Text + "' AND LastName='" + LNameTextBox.Text + "'"
                GetSearchResults()

            ElseIf SubjectComboBox.Text = "First Name" Then
                SearchQuery.CommandText = "SELECT * FROM FindApplicantView WHERE FirstName='" + FNameTextBox.Text + "'"
                GetSearchResults()

            ElseIf SubjectComboBox.Text = "Last Name" Then
                SearchQuery.CommandText = "SELECT * FROM FindApplicantView WHERE LastName='" + LNameTextBox.Text + "'"
                GetSearchResults()

            ElseIf SubjectComboBox.Text = "Graduation Date" Then
                SearchQuery.CommandText = "SELECT * FROM FindApplicantView WHERE GradYear='" + GradDatePicker.Value.ToString + "'"
                GetSearchResults()

            ElseIf SubjectComboBox.Text = "Major" Then
                SearchQuery.CommandText = "SELECT * FROM FindApplicantView WHERE Major='" + MajorComboBox.SelectedItem.ToString + "'"
                GetSearchResults()

            ElseIf SubjectComboBox.Text = "Audition Date" Then
                SearchQuery.CommandText = "SELECT * FROM FindApplicantView WHERE [Audition Date]='" + AuditionDate + "'"
                GetSearchResults()
            End If

            'check if the query returned any results.
            If HasResults = False Then
                MsgBox("There are no applicants matching the given search parameters.", MsgBoxStyle.Information, "No Results")
            Else
                MainForm.Hide()
                SearchResultsForm.Show()
                Me.Close()
            End If

        End If
    End Sub

    Sub GetSearchResults()

        Dim SearchDataReader As SqlDataReader
        Dim Conn As New SqlConnection()

        'change cursor to waiting so the user knows something is happening
        Cursor.Current = Cursors.WaitCursor

        'pass database connection to the connection variable.
        Conn = LogInForm.Conn

        'give the open connection to the sending command variable.
        SearchQuery.Connection = Conn

        'attempt to send the command to the database.
        Try
            'open the connection to the DB.
            Conn.Open()

            'assign the data reader the query results
            SearchDataReader = SearchQuery.ExecuteReader

            'check if the query returned any results.
            If SearchDataReader.HasRows = True Then
                HasResults = True
            Else
                HasResults = False
            End If

        Catch ex As Exception
            'MessageBox.Show("Could not connect to the database, please check your connection and try again.", "Search Results Retrieval Failed")
            MsgBox("Error: " + ex.Message)
        Finally
            'close the connection regardless of success or failure.
            Conn.Close()
        End Try
        '
        Cursor.Current = Cursors.Default
    End Sub

    Private Sub AuditionDatePicker_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AuditionDatePicker.ValueChanged
        'Convert Audition Date Picker to a usable string for the database
        AuditionDate = AuditionDatePicker.Value.Month.ToString + "/" + AuditionDatePicker.Value.Day.ToString + _
                    "/" + AuditionDatePicker.Value.Year.ToString
    End Sub
End Class