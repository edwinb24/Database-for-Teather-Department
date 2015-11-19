Imports System.Data
Imports System.Data.SqlClient
Public Class FindApplicantToUpdateForm
    'Used to control select statement
    Public sql As String

    Private Sub SubjectComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SubjectComboBox.SelectedIndexChanged
        If SubjectComboBox.Text = "First Name" Then
            FNameTextBox.Show()
            FNameTextBox.Text = "Enter First Name..."
            LNameTextBox.Hide()
            DegreeComboBox.Hide()
            SelectDegreeLabel.Hide()
            MajorComboBox.Hide()
            SelectMajorLabel.Hide()
            SearchDateTimePicker.Hide()
        ElseIf SubjectComboBox.Text = "Last Name" Then
            FNameTextBox.Hide()
            LNameTextBox.Show()
            LNameTextBox.Text = "Enter Last Name..."
            DegreeComboBox.Hide()
            SelectDegreeLabel.Hide()
            MajorComboBox.Hide()
            SelectMajorLabel.Hide()
            SearchDateTimePicker.Hide()
        ElseIf SubjectComboBox.Text = "Full Name" Then
            FNameTextBox.Show()
            LNameTextBox.Show()
            FNameTextBox.Text = "Enter First Name..."
            LNameTextBox.Text = "Enter Last Name..."
            DegreeComboBox.Hide()
            SelectDegreeLabel.Hide()
            MajorComboBox.Hide()
            SelectMajorLabel.Hide()
            SearchDateTimePicker.Hide()
        ElseIf SubjectComboBox.Text = "Degree Program" Then
            DegreeComboBox.Text = Nothing
            MajorComboBox.Items.Clear()
            FNameTextBox.Hide()
            LNameTextBox.Hide()
            DegreeComboBox.Show()
            SelectDegreeLabel.Show()
            MajorComboBox.Show()
            SelectMajorLabel.Show()
            SearchDateTimePicker.Hide()
        ElseIf SubjectComboBox.Text = "Audition Date" Then
            FNameTextBox.Hide()
            LNameTextBox.Hide()
            DegreeComboBox.Hide()
            SelectDegreeLabel.Hide()
            MajorComboBox.Hide()
            SelectMajorLabel.Hide()
            SearchDateTimePicker.Refresh()
            SearchDateTimePicker.Show()
        End If
    End Sub

    Private Sub CancelBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CancelBtn.Click
        Me.Close()
        MainForm.Show()
    End Sub

    Private Sub FinderForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FNameTextBox.Clear()
        LNameTextBox.Clear()
        FNameTextBox.Hide()
        LNameTextBox.Hide()
        SubjectComboBox.Text = Nothing
        DegreeComboBox.Hide()
        SelectDegreeLabel.Hide()
        MajorComboBox.Hide()
        SelectMajorLabel.Hide()
        SearchDateTimePicker.Hide()

        Dim Conn As SqlConnection
        Conn = LogInForm.Conn
        Dim GetDegree As New SqlCommand
        Dim DataReader As SqlDataReader
        Conn.Open()

        'give the open connection to the sending command variable.
        GetDegree.Connection = Conn

        GetDegree.CommandText = "SELECT DISTINCT Type FROM Degree"
        DataReader = GetDegree.ExecuteReader
        While DataReader.Read()
            DegreeComboBox.Items.Add(DataReader.Item(0))
        End While
        DataReader.Close()

        Conn.Close()
    End Sub

    Private Sub FNameTextBox_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles FNameTextBox.Click
        FNameTextBox.Clear()
        FNameTextBox.BackColor = Color.White
    End Sub


    Private Sub LNameTextBox_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles LNameTextBox.Click
        LNameTextBox.Clear()
        LNameTextBox.BackColor = Color.White
    End Sub
    Private Sub DegreeComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DegreeComboBox.SelectedIndexChanged
        'clear the combo box for the new items to be populated.
        MajorComboBox.Items.Clear()

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
            GetMajor.CommandText = "SELECT DISTINCT Major FROM Degree WHERE Type='" + DegreeComboBox.Text + "'"

            'assign the data reader the query results
            DataReader = GetMajor.ExecuteReader

            'read the data returned from the query into the combobox.
            While DataReader.Read()
                MajorComboBox.Items.Add(Trim(DataReader.Item(0).ToString))
            End While

        Catch ex As Exception
            MessageBox.Show("Retrieval Error: " & ex.Message, "Major Retrieval Failed")
        Finally 'close the connection regardless of success or failure.
            Conn.Close()
        End Try
    End Sub

    Private Sub FindApplicantBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FindApplicantBtn.Click
        Dim AudDate As String = Nothing
        Dim Conn As SqlConnection
        Conn = LogInForm.Conn
        Dim CheckCmd As New SqlCommand
        Dim DR As SqlDataReader

        sql = Nothing

        'validate user input.
        If SubjectComboBox.Text = Nothing Or (SubjectComboBox.Text <> "First Name" And SubjectComboBox.Text <> "Last Name" And SubjectComboBox.Text <> "Full Name" And SubjectComboBox.Text <> "Degree Program" And SubjectComboBox.Text <> "Audition Date") Then
            MsgBox("Please select a valid method for finding an applicant", , "Missing Credentials")
            SubjectComboBox.BackColor = Color.Salmon
        ElseIf SubjectComboBox.Text = "First Name" And (FNameTextBox.Text = Nothing Or FNameTextBox.Text = "Enter First Name...") Then
            MsgBox("Please enter the first name of the desired applicant.", , "Missing Credentials")
            FNameTextBox.BackColor = Color.Salmon
        ElseIf SubjectComboBox.Text = "Last Name" And (LNameTextBox.Text = Nothing Or LNameTextBox.Text = "Enter Last Name...") Then
            MsgBox("Please enter the last name of the desired applicant.", , "Missing Credentials")
            LNameTextBox.BackColor = Color.Salmon
        ElseIf SubjectComboBox.Text = "Full Name" And (FNameTextBox.Text = Nothing Or FNameTextBox.Text = "Enter First Name...") And (LNameTextBox.Text = Nothing Or LNameTextBox.Text = "Enter Last Name...") Then
            MsgBox("Please enter the first and last name of the desired applicant.", , "Missing Credentials")
            FNameTextBox.BackColor = Color.Salmon
            LNameTextBox.BackColor = Color.Salmon
        ElseIf SubjectComboBox.Text = "Full Name" And (FNameTextBox.Text = Nothing Or FNameTextBox.Text = "Enter First Name...") Then
            MsgBox("Please enter the first name of the desired applicant.", , "Missing Credentials")
            FNameTextBox.BackColor = Color.Salmon
        ElseIf SubjectComboBox.Text = "Full Name" And (LNameTextBox.Text = Nothing Or FNameTextBox.Text = "Enter Last Name...") Then
            MsgBox("Please enter the last name of the desired applicant.", , "Missing Credentials")
            LNameTextBox.BackColor = Color.Salmon
        ElseIf SubjectComboBox.Text = "Degree Program" And DegreeComboBox.Text = Nothing And MajorComboBox.Text = Nothing Then
            MsgBox("Please select the degree and major of the desired applicant.", , "Missing Credentials")
            SelectDegreeLabel.ForeColor = Color.Red
            SelectMajorLabel.ForeColor = Color.Red
        ElseIf SubjectComboBox.Text = "Degree Program" And DegreeComboBox.Text = Nothing Then
            MsgBox("Please select the degree of the desired applicant.", , "Missing Credentials")
            SelectDegreeLabel.ForeColor = Color.Red
        ElseIf SubjectComboBox.Text = "Degree Program" And MajorComboBox.Text = Nothing Then
            MsgBox("Please select the major of the desired applicant.", , "Missing Credentials")
            SelectMajorLabel.ForeColor = Color.Red

        Else
            'give the query to be sent to the command variable for the student info table.
            'Get the info to be displayed in the ChoosetoUpdate Form based on what the user has inputted
            Conn.Open()
            CheckCmd.Connection = Conn
            If SubjectComboBox.Text = "Full Name" Then
                sql = "SELECT * FROM FindApplicantView WHERE FirstName = '" + Trim(FNameTextBox.Text) + "' LastName = '" + Trim(LNameTextBox.Text) + "'"
            ElseIf SubjectComboBox.Text = "First Name" Then
                sql = "SELECT * FROM FindApplicantView WHERE FirstName = '" + Trim(FNameTextBox.Text) + "'"
            ElseIf SubjectComboBox.Text = "Last Name" Then
                sql = "SELECT * FROM FindApplicantView WHERE LastName = '" + Trim(LNameTextBox.Text) + "'"
            ElseIf SubjectComboBox.Text = "Degree Program" Then
                sql = "SELECT * FROM FindApplicantView WHERE DegreeType = '" + Trim(DegreeComboBox.Text) + "' AND Major = '" + Trim(MajorComboBox.Text) + "'"
            ElseIf SubjectComboBox.Text = "Audition Date" Then
                AudDate = SearchDateTimePicker.Value.Month.ToString + "/" + SearchDateTimePicker.Value.Day.ToString + _
                        "/" + SearchDateTimePicker.Value.Year.ToString
                sql = "SELECT * FROM FindApplicantView WHERE [Audition Date] = '" + Trim(AudDate) + "'"
            End If

            'Check to see if the applicants are in the database
            CheckCmd.CommandText = sql
            DR = CheckCmd.ExecuteReader
            'If so, proceed to ChooseToUpdate Form
            If DR.Read() Then
                DR.Close()
                Conn.Close()
                MainForm.Hide()
                ChooseToUpdate.Show()
                Me.Close()
                'Otherwise, alert the user that there is no such applicant
            Else
                DR.Close()
                Conn.Close()
                MsgBox("Applicant not found!", , "Applicant Not Found in Database")
            End If
        End If
    End Sub
    Private Sub SubjectComboBox_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles SubjectComboBox.SelectedValueChanged
        SubjectComboBox.BackColor = Color.White
    End Sub
    Private Sub DegreeComboBox_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DegreeComboBox.SelectedValueChanged
        SelectDegreeLabel.ForeColor = Color.Black
    End Sub
    Private Sub MajorComboBox_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles MajorComboBox.SelectedValueChanged
        SelectMajorLabel.ForeColor = Color.Black
    End Sub
End Class
