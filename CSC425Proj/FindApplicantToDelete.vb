Imports System.Data
Imports System.Data.SqlClient

Public Class FindApplicantToDelete
    'Used to control select statement
    Public sql As String
    Public GradDate As Boolean

    Private Sub SubjectComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SubjectComboBox.SelectedIndexChanged
        If SubjectComboBox.Text = "First Name" Then
            GradDate = False
            GradDatePicker.Hide()
            FNameTextBox.BackColor = Color.White
            FNameTextBox.Text = "Enter First Name..."
            FNameTextBox.Show()
            LNameTextBox.Hide()
        ElseIf SubjectComboBox.Text = "Last Name" Then
            GradDate = False
            GradDatePicker.Hide()
            FNameTextBox.Hide()
            LNameTextBox.BackColor = Color.White
            LNameTextBox.Text = "Enter Last Name..."
            LNameTextBox.Show()
        ElseIf SubjectComboBox.Text = "Full Name" Then
            GradDate = False
            GradDatePicker.Hide()
            FNameTextBox.Text = "Enter First Name..."
            LNameTextBox.Text = "Enter Last Name..."
            FNameTextBox.BackColor = Color.White
            LNameTextBox.BackColor = Color.White
            FNameTextBox.Show()
            LNameTextBox.Show()
        ElseIf SubjectComboBox.Text = "Graduation Date" Then
            GradDate = True
            FNameTextBox.Hide()
            LNameTextBox.Hide()
            GradDatePicker.Show()
        End If
    End Sub

    Private Sub CancelBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub FinderForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        FNameTextBox.Hide()
        LNameTextBox.Hide()
        GradDatePicker.Hide()
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

    Private Sub FindApplicantBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FindApplicantBtn.Click
        Dim Conn As SqlConnection
        Conn = LogInForm.Conn
        Dim CheckCmd As New SqlCommand
        Dim DR As SqlDataReader

        sql = Nothing

        'validate user input.
        If SubjectComboBox.Text = "First Name" And (FNameTextBox.Text = Nothing Or FNameTextBox.Text = "Enter First Name...") Then
            MsgBox("Please enter the first name of the desired applicant.", MsgBoxStyle.Information, "Missing Credentials")
            FNameTextBox.BackColor = Color.Salmon

        ElseIf SubjectComboBox.Text = "Last Name" And (LNameTextBox.Text = Nothing Or LNameTextBox.Text = "Enter Last Name...") Then
            MsgBox("Please enter the last name of the desired applicant.", , "Missing Credentials")
            LNameTextBox.BackColor = Color.Salmon

        ElseIf SubjectComboBox.Text = "Full Name" And ((FNameTextBox.Text = Nothing Or FNameTextBox.Text = "Enter First Name...") Or (LNameTextBox.Text = Nothing Or FNameTextBox.Text = "Enter Last Name...")) Then
            MsgBox("Please enter the missing credentials of the desired applicant.", MsgBoxStyle.Information, "Missing Credentials")
            FNameTextBox.BackColor = Color.Salmon
            LNameTextBox.BackColor = Color.Salmon

        Else
            'give the query to be sent to the command variable for the student info table.
            'Get the info to be displayed in the ChoosetoDelete Form based on what the user has inputted
            Conn.Open()
            CheckCmd.Connection = Conn

            If SubjectComboBox.Text = "Full Name" Then
                sql = "SELECT DISTINCT StudentInfo.FirstName, StudentInfo.LastName, StudentInfo.Address, City, State, StudentInfo.ZipCode, StudentInfo.Email, Date, Event, HighSchool, GradYear FROM StudentInfo, EducationalBackground WHERE StudentInfo.FirstName = EducationalBackground.FirstName AND StudentInfo.LastName = EducationalBackground.LastName AND StudentInfo.Address = EducationalBackground.Address AND StudentInfo.Email = EducationalBackground.Email AND StudentInfo.ZipCode = EducationalBackground.ZipCode AND StudentInfo.FirstName = '" + Trim(FNameTextBox.Text) + "' AND StudentInfo.LastName = '" + Trim(LNameTextBox.Text) + "'"
            ElseIf SubjectComboBox.Text = "First Name" Then
                sql = "SELECT DISTINCT StudentInfo.FirstName, StudentInfo.LastName, StudentInfo.Address, City, State, StudentInfo.ZipCode, StudentInfo.Email, Date, Event, HighSchool, GradYear FROM StudentInfo, EducationalBackground WHERE StudentInfo.FirstName = EducationalBackground.FirstName AND StudentInfo.LastName = EducationalBackground.LastName AND StudentInfo.Address = EducationalBackground.Address AND StudentInfo.Email = EducationalBackground.Email AND StudentInfo.ZipCode = EducationalBackground.ZipCode AND StudentInfo.FirstName = '" + Trim(FNameTextBox.Text) + "'"
            ElseIf SubjectComboBox.Text = "Last Name" Then
                sql = "SELECT DISTINCT StudentInfo.FirstName, StudentInfo.LastName, StudentInfo.Address, City, State, StudentInfo.ZipCode, StudentInfo.Email, Date, Event, HighSchool, GradYear FROM StudentInfo, EducationalBackground WHERE StudentInfo.FirstName = EducationalBackground.FirstName AND StudentInfo.LastName = EducationalBackground.LastName AND StudentInfo.Address = EducationalBackground.Address AND StudentInfo.Email = EducationalBackground.Email AND StudentInfo.ZipCode = EducationalBackground.ZipCode AND StudentInfo.LastName = '" + Trim(LNameTextBox.Text) + "'"
            ElseIf SubjectComboBox.Text = "Graduation Date" Then
                sql = "SELECT DISTINCT StudentInfo.FirstName, StudentInfo.LastName, StudentInfo.Address, City, State, StudentInfo.ZipCode, StudentInfo.Email, Date, Event, HighSchool, GradYear FROM StudentInfo, EducationalBackground WHERE StudentInfo.FirstName = EducationalBackground.FirstName AND StudentInfo.LastName = EducationalBackground.LastName AND StudentInfo.Address = EducationalBackground.Address AND StudentInfo.Email = EducationalBackground.Email AND StudentInfo.ZipCode = EducationalBackground.ZipCode AND GradYear = '" + GradDatePicker.Value.ToString + "'"
            End If

            'Check to see if the applicants are in the database
            CheckCmd.CommandText = sql
            DR = CheckCmd.ExecuteReader
            'If so, proceed to ChooseToUpdate Form
            If DR.Read() Then
                DR.Close()
                Conn.Close()
                AdminForm.Hide()
                ChooseToDelete.Show()
                Me.Close()
                'Otherwise, alert the user that there is no such applicant
            Else
                DR.Close()
                Conn.Close()
                MsgBox("There are no applicants matching the given search parameters.", MsgBoxStyle.Information, "No Results")
            End If
        End If

    End Sub

    Private Sub CancelBtn_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CancelBtn.Click
        Me.Close()
    End Sub
End Class