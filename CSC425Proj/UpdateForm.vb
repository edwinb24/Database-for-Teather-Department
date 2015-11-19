Imports System.Data
Imports System.Data.SqlClient

Public Class UpdateForm
    Dim auditionbool As Boolean = False
    Dim FName As String
    Dim LName As String
    Dim Email As String
    Dim Zip As String
    Dim Address As String

    Private Sub CancelBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CancelBtn.Click
        MainForm.Show()
        ChooseToUpdate.Close()
        Me.Close()
    End Sub

    Private Sub SubmitBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SubmitBtn.Click
        Dim Err As Boolean = False

        'highlight all textboxes with missing information.
        'highlight all textboxes with missing information.
        If FirstNameTextBox.Text = Nothing Then
            FirstNameTextBox.BackColor = Color.Salmon
            Err = True
        End If

        If LastNameTextBox.Text = Nothing Then
            LastNameTextBox.BackColor = Color.Salmon
            Err = True
        End If

        If AddressTextBox.Text = Nothing Then
            AddressTextBox.BackColor = Color.Salmon
            Err = True
        End If

        If ZipCodeTextBox.Text = Nothing Then
            ZipCodeTextBox.BackColor = Color.Salmon
            Err = True
        End If

        If EmailTextBox.Text = Nothing Then
            EmailTextBox.BackColor = Color.Salmon
            Err = True
        End If

        If ((ComboBox2.Text <> Nothing Or EmailRadioBtn.Checked = True Or PhoneRadioBtn.Checked = True) And ReasonTextBox.Text = Nothing) Then
            ReasonTextBox.BackColor = Color.Salmon
            Err = True
        End If

        If (TestComboBox.Text = "Placement Test" Or TestComboBox.Text = Nothing) And TestScoreTextBox.Text <> Nothing Then
            TestComboBox.BackColor = Color.Salmon
            Err = True
        ElseIf TestComboBox.Text <> Nothing And TestComboBox.Text <> "Placement Test" And TestScoreTextBox.Text = Nothing Then
            TestScoreTextBox.BackColor = Color.Salmon
            Err = True
        End If

        If DegreeComboBox.Text <> Nothing And MajorComboBox.Text = Nothing Then
            SelectMajorLabel.ForeColor = Color.Red
            Err = True
        End If

        If Err = True Then
            'prompt user to enter missing data.
            MsgBox("Please enter the required information.", , "Missing Creditials")
            'switch the current tab so the user sees which fields are missing.
            TabControl.SelectedTab = ContactInfoTab
        End If

        If Err = False Then
            'Use variables for check boxes and radio buttons in the sql statement
            Dim Visited As String
            If VisitStatusCheckBox.Checked = True Then
                Visited = "True"
            Else
                Visited = "False"
            End If

            Dim Enrolled As String
            If EnrolledStatusCheckBox.Checked = True Then
                Enrolled = "True"
            Else
                Enrolled = "False"
            End If

            Dim Applied As String
            If AppliedStatusCheckBox.Checked = True Then
                Applied = "True"
            Else
                Applied = "False"
            End If

            Dim Via As String
            If EmailRadioBtn.Checked = True Then
                Via = "Email"
            Else
                Via = "Phone"
            End If

            If TestComboBox.Text = "Placement Test" And TestScoreTextBox.Text = Nothing Then
                TestComboBox.Text = Nothing
            End If

            'Convert Contact Date Picker to a usable string for the database
            Dim ContactDate As String
            ContactDate = ContactDatePicker.Value.Month.ToString + "/" + ContactDatePicker.Value.Day.ToString + _
                        "/" + ContactDatePicker.Value.Year.ToString

            'Convert Audition Date Picker to a usable string for the database
            Dim AuditionDate As String
            AuditionDate = AuditionDatePicker.Value.Month.ToString + "/" + AuditionDatePicker.Value.Day.ToString + _
                        "/" + AuditionDatePicker.Value.Year.ToString

            Dim Conn As New SqlConnection
            Dim UpdateCmd As New SqlCommand
            Conn = LogInForm.Conn

            'declare transaction
            Dim UpdateTrans

            'Send the insert queries to the database.
            Try
                'open the connection to the DB.
                Conn.Open()

                'give the open connection to the sending command variable.
                UpdateCmd.Connection = Conn

                'give the transaction the open connection.
                UpdateTrans = Conn.BeginTransaction

                'pass transaction to sql command variable
                UpdateCmd.Transaction = UpdateTrans

                'give the query to be sent to the command variable for the student info table.
                UpdateCmd.CommandText = "UPDATE StudentInfo SET FirstName = '" + Trim(FirstNameTextBox.Text) + "', LastName = '" + Trim(LastNameTextBox.Text) + "',  Address = '" + Trim(AddressTextBox.Text) + "', Email = '" + Trim(EmailTextBox.Text) + "', City = '" + Trim(CityTextBox.Text) + "', State = '" + Trim(StateComboBox.Text) + "', ZipCode = '" + ZipCodeTextBox.Text + "', HomeNumber = '" + TelephoneMaskedTextBox.Text + "', CellNumber = '" + CellphoneMaskedTextBox.Text + "', Date = '" + Trim(DateTextBox.Text) + "', Event = '" + Trim(EventTextBox.Text) + "', DegreeType = '" + Trim(DegreeComboBox.Text) + "', Major = '" + Trim(MajorComboBox.Text) + "', Specialization = '" + Trim(SpecializationComboBox.Text) + "', Visited = '" + Visited + "', Enrolled = '" + Enrolled + "', Applied = '" + Applied + "' WHERE FirstName = '" + FName + "' and LastName = '" + LName + "' and Address = '" + Address + "' and ZipCode = '" + Zip + "' and Email = '" + Email + "'"
                'execute the query
                UpdateCmd.ExecuteNonQuery()

                'give the query to be sent to the command variable for the education background table.
                UpdateCmd.CommandText = "UPDATE EducationalBackground SET FirstName = '" + Trim(FirstNameTextBox.Text) + "', LastName = '" + Trim(LastNameTextBox.Text) + "', Address = '" + Trim(AddressTextBox.Text) + "', ZipCode = '" + ZipCodeTextBox.Text + "', Email = '" + Trim(EmailTextBox.Text) + "', HighSchool = '" + Trim(HighSchoolTextBox.Text) + "', GradYear = '" + Trim(TextBox16.Text) + "', Test = '" + Trim(TestComboBox.Text) + "', Score = '" + Trim(TestScoreTextBox.Text) + "', GPA = '" + Trim(GPATextBox.Text) + "', ClassRank = '" + Trim(ClassRankTextBox.Text) + "', ClassSize = '" + Trim(ClassSizeTextBox.Text) + "', CollegesAttended = '" + Trim(CollegeTextBox.Text) + "' WHERE FirstName = '" + FName + "' and LastName = '" + LName + "' and Address = '" + Address + "' and ZipCode = '" + Zip + "' and Email = '" + Email + "'"

                'execute the query
                UpdateCmd.ExecuteNonQuery()

                'If a new contact has been entered, insert into the database
                If ComboBox2.Text <> Nothing And ReasonTextBox.Text <> Nothing And (EmailRadioBtn.Checked = True Or PhoneRadioBtn.Checked = True) Then
                    'give the query to be sent to the command variable for the contact table.
                    UpdateCmd.CommandText = "INSERT INTO Contact VALUES('" + Trim(FirstNameTextBox.Text) + "', '" + Trim(LastNameTextBox.Text) + "', '" + Trim(AddressTextBox.Text) + "', '" + ZipCodeTextBox.Text + "', '" + Trim(EmailTextBox.Text) + "', '" + ContactDate + "', '" + Trim(ReasonTextBox.Text) + "', '" + Trim(ComboBox2.Text) + "', '" + Via + "')"

                    'execute the query
                    UpdateCmd.ExecuteNonQuery()
                End If

                'Update the contact log for primary key in case the primary key has been changed
                UpdateCmd.CommandText = "UPDATE Contact SET FirstName = '" + Trim(FirstNameTextBox.Text) + "', LastName = '" + Trim(LastNameTextBox.Text) + "', Address = '" + Trim(AddressTextBox.Text) + "', Email = '" + Trim(EmailTextBox.Text) + "', ZipCode = '" + ZipCodeTextBox.Text + "' WHERE FirstName = '" + FName + "' and LastName = '" + LName + "' and Address = '" + Address + "' and ZipCode = '" + Zip + "' and Email = '" + Email + "'"
                UpdateCmd.ExecuteNonQuery()

                'If the student already has audition information, update changes, otherwise insert an audition into the database
                If auditionbool = True Then
                    'give the query to be sent to the command variable for the audition table.
                    UpdateCmd.CommandText = "UPDATE Audition SET FirstName = '" + Trim(FirstNameTextBox.Text) + "', LastName = '" + Trim(LastNameTextBox.Text) + "', Address = '" + Trim(AddressTextBox.Text) + "', Email = '" + Trim(EmailTextBox.Text) + "', ZipCode = '" + ZipCodeTextBox.Text + "', FacultyName= '" + Trim(ComboBox1.Text) + "', Score = '" + AudRatingComboBox.Text + "', Notes = '" + Trim(AudNotesTextBox.Text) + "', Date = '" + AuditionDate + "' WHERE FirstName = '" + FName + "' and LastName = '" + LName + "' and Address = '" + Address + "' and ZipCode = '" + Zip + "' and Email = '" + Email + "'"
                ElseIf ComboBox1.Text <> Nothing And AudRatingComboBox.Text <> Nothing Then
                    UpdateCmd.CommandText = "INSERT INTO Audition VALUES('" + Trim(FirstNameTextBox.Text) + "', '" + Trim(LastNameTextBox.Text) + "', '" + Trim(AddressTextBox.Text) + "', '" + ZipCodeTextBox.Text + "', '" + Trim(EmailTextBox.Text) + "', '" + Trim(ComboBox1.Text) + "', '" + Trim(AudRatingComboBox.Text) + "', '" + Trim(AudNotesTextBox.Text) + "', '" + AuditionDate + "')"
                End If

                'execute the query
                UpdateCmd.ExecuteNonQuery()


                'commit tranaction now all queries have executed."
                UpdateTrans.Commit()

                'promt the user on success
                MsgBox("Applicant information has been successfully updated.", MsgBoxStyle.OkOnly, _
                                       "Successfully Updated")
                '
                Cursor.Current = Cursors.Default

            Catch ex As Exception
                'rollback transaction upon error
                UpdateTrans.Rollback()
                MessageBox.Show("Error while updating records in table..." & ex.Message, "Update Failed")
            Finally
                'close the connection regardless of success or failure.
                Conn.Close()
                Cursor.Current = Cursors.Default
            End Try

            ChooseToUpdate.Close()
            Me.Close()
            MainForm.Show()
        End If
    End Sub

    Private Sub EnrolledStatusCheckBox_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EnrolledStatusCheckBox.CheckedChanged
        If AppliedStatusCheckBox.Checked = False And EnrolledStatusCheckBox.Checked = True Then
            EnrolledStatusCheckBox.Checked = False
            MsgBox("A Student cannot be enrolled if they have not applied.", , "Enrollment Error")
        End If
    End Sub

    Private Sub AppliedStatusCheckBox_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AppliedStatusCheckBox.CheckedChanged
        If AppliedStatusCheckBox.Checked = False And EnrolledStatusCheckBox.Checked = True Then
            EnrolledStatusCheckBox.Checked = False
            MsgBox("A Student cannot be enrolled if they have not applied.", , "Enrollment Error")
        End If
    End Sub

    Private Sub MajorComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MajorComboBox.SelectedIndexChanged
        SpecializationComboBox.Items.Clear()

        SelectSpecializationLabel.Hide()
        SpecializationComboBox.Hide()

        Dim GetSpecialization As New SqlCommand
        Dim DataReader As SqlDataReader
        Dim Conn As New SqlConnection()
        Dim Spec As String

        'pass database connection to the connection variable.
        Conn = LogInForm.Conn

        'attempt to send the command to the database.
        Try
            'open the connection to the DB.
            Conn.Open()

            'give the open connection to the sending command variable.
            GetSpecialization.Connection = Conn

            'give the query to be sent to the command variable.
            GetSpecialization.CommandText = "SELECT DISTINCT Specialization FROM Degree WHERE Type = '" + Trim(DegreeComboBox.Text) + "' AND Major = '" + Trim(MajorComboBox.Text) + "'"
            'assign the data reader the query results
            DataReader = GetSpecialization.ExecuteReader

            'read the data returned from the query into the combobox.
            While DataReader.Read()
                Spec = Trim(DataReader.Item(0).ToString)
                If Spec = "none" Then
                    SpecializationComboBox.Hide()
                    SelectSpecializationLabel.Hide()
                    SpecializationComboBox.Text = "none"
                Else
                    SpecializationComboBox.Show()
                    SelectSpecializationLabel.Show()
                    SpecializationComboBox.Text = "Select Specialization"
                    SpecializationComboBox.Items.Add(Trim(DataReader.Item(0).ToString))
                End If
            End While

            DataReader.Close()

        Catch ex As Exception
            MessageBox.Show("Retrieval Error: " & ex.Message, "Specialization Retrieval Failed")
        Finally 'close the connection regardless of success or failure.
            Conn.Close()
        End Try
    End Sub

    Private Sub DegreeComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DegreeComboBox.SelectedIndexChanged
        'clear the combo box for the new items to be populated.
        MajorComboBox.Items.Clear()
        SpecializationComboBox.Hide()
        SelectSpecializationLabel.Hide()
        SpecializationComboBox.Items.Clear()
        SpecializationComboBox.Text = "none"

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

    Private Sub UpdateForm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'hide the specialization box until it is needed.
        SpecializationComboBox.Hide()
        SelectSpecializationLabel.Hide()

        'Get the student's info that was selected from the ChooseToUpdate Form
        Dim Conn As SqlConnection
        Conn = LogInForm.Conn

        Dim PopulateTrans
        Dim PopulateUpdateForm As New SqlCommand

        Dim DataReader As SqlDataReader

        Dim sql As String
        sql = ChooseToUpdate.sql

        Dim DegreeType As String = "Degree"
        Dim Major As String = "Major"
        Dim Spec As String = "Specialization"

        Try
            'open the connection to the DB.
            Conn.Open()

            'give the open connection to the sending command variable.
            PopulateUpdateForm.Connection = Conn

            'give the transaction the open connection.
            PopulateTrans = Conn.BeginTransaction

            'pass transaction to sql command variable
            PopulateUpdateForm.Transaction = PopulateTrans

            'give the query to be sent to the command variable for the student info table.
            PopulateUpdateForm.CommandText = sql
            DataReader = PopulateUpdateForm.ExecuteReader

            'Populate the form with the info from the StudentInfo table
            While DataReader.Read()
                FirstNameTextBox.Text = Trim(DataReader.Item(0).ToString)
                LastNameTextBox.Text = Trim(DataReader.Item(1).ToString)
                AddressTextBox.Text = Trim(DataReader.Item(2).ToString)
                CityTextBox.Text = Trim(DataReader.Item(3).ToString)
                StateComboBox.Text = Trim(DataReader.Item(4).ToString)
                ZipCodeTextBox.Text = Trim(DataReader.Item(5).ToString)
                EmailTextBox.Text = Trim(DataReader.Item(6).ToString)
                TelephoneMaskedTextBox.Text = Trim(DataReader.Item(7).ToString)
                CellphoneMaskedTextBox.Text = Trim(DataReader.Item(8).ToString)
                DateTextBox.Text = Trim(DataReader.Item(9).ToString)
                EventTextBox.Text = Trim(DataReader.Item(10).ToString)
                If DataReader.Item(11).ToString = "True" Then
                    VisitStatusCheckBox.Checked = True
                End If
                If DataReader.Item(12).ToString = "True" Then
                    AppliedStatusCheckBox.Checked = True
                End If
                If DataReader.Item(13).ToString = "True" Then
                    EnrolledStatusCheckBox.Checked = True
                End If
                DegreeType = Trim(DataReader.Item(14).ToString)
                Major = Trim(DataReader.Item(15).ToString)
                Spec = Trim(DataReader.Item(16).ToString)
                InterestsTextBox.Text = Trim(DataReader.Item(17).ToString)
                HighSchoolTextBox.Text = Trim(DataReader.Item(18).ToString)
                TextBox16.Text = Trim(DataReader.Item(19).ToString)
                TestComboBox.Text = Trim(DataReader.Item(20).ToString)
                TestScoreTextBox.Text = Trim(DataReader.Item(21).ToString)
                GPATextBox.Text = Trim(DataReader.Item(22).ToString)
                ClassRankTextBox.Text = Trim(DataReader.Item(23).ToString)
                ClassSizeTextBox.Text = Trim(DataReader.Item(24).ToString)
                CollegeTextBox.Text = Trim(DataReader.Item(25).ToString)
                ' If (DataReader.Read()) Then
                auditionbool = True
                ComboBox1.Text = Trim(DataReader.Item(26).ToString)
                AudRatingComboBox.Text = Trim(DataReader.Item(27).ToString)
                AudNotesTextBox.Text = Trim(DataReader.Item(28).ToString)
                AuditionDatePicker.Text = Trim(DataReader.Item(29).ToString)
                ' End If
            End While

            DataReader.Close()

            DegreeComboBox.Items.Add("")

            PopulateUpdateForm.CommandText = "SELECT DISTINCT Type FROM Degree"
            DataReader = PopulateUpdateForm.ExecuteReader

            While DataReader.Read()
                DegreeComboBox.Items.Add(DataReader.Item(0))
            End While
            DataReader.Close()

            'Populate the form with the faculties' names in the faculty combo boxes under the audition and contact tabs
            PopulateUpdateForm.CommandText = "SELECT DISTINCT FacultyName FROM Faculty"
            DataReader = PopulateUpdateForm.ExecuteReader

            While DataReader.Read()
                ComboBox1.Items.Add(Trim(DataReader.Item(0)))
                ComboBox2.Items.Add(Trim(DataReader.Item(0)))
            End While
            DataReader.Close()

            'commit tranaction now all queries have executed.
            PopulateTrans.Commit()

            Cursor.Current = Cursors.Default

            'Store the student's name, email, address, and zipcode for use in updating
            FName = Trim(FirstNameTextBox.Text)
            LName = Trim(LastNameTextBox.Text)
            Email = Trim(EmailTextBox.Text)
            Zip = Trim(ZipCodeTextBox.Text)
            Address = Trim(AddressTextBox.Text)

        Catch ex As Exception
            'rollback transaction upon error
            PopulateTrans.Rollback()
            MessageBox.Show("Error while populating fields" & ex.Message, "Populating failed")
        Finally
            'close the connection regardless of success or failure.
            Conn.Close()

            'Populate degree, major and specialization boxes
            DegreeComboBox.Text = DegreeType
            MajorComboBox.Text = Major

            If Spec <> Nothing Then
                SpecializationComboBox.Show()
                SpecializationComboBox.Text = Spec
            End If
            Cursor.Current = Cursors.Default
        End Try
    End Sub
    Private Sub MajorComboBox_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles MajorComboBox.SelectedValueChanged
        SelectMajorLabel.ForeColor = Color.Black
    End Sub

    Private Sub SpecializationComboBox_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles SpecializationComboBox.SelectedValueChanged
        SpecializationComboBox.BackColor = Color.White
        SelectSpecializationLabel.ForeColor = Color.Black
    End Sub

    Private Sub FirstNameTextBox_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles FirstNameTextBox.Click
        FirstNameTextBox.BackColor = Color.White
    End Sub

    Private Sub LastNameTextBox_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles LastNameTextBox.Click
        LastNameTextBox.BackColor = Color.White
    End Sub

    Private Sub AddressTextBox_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles AddressTextBox.Click
        AddressTextBox.BackColor = Color.White
    End Sub

    Private Sub EmailTextBox_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles EmailTextBox.Click
        EmailTextBox.BackColor = Color.White
    End Sub

    Private Sub ZipCodeTextBox_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ZipCodeTextBox.Click
        ZipCodeTextBox.BackColor = Color.White
    End Sub

    Private Sub TestScoreTextBox_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles TestScoreTextBox.Click
        TestScoreTextBox.BackColor = Color.White
    End Sub

    Private Sub TestComboBox_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles TestComboBox.Click
        TestComboBox.BackColor = Color.White
    End Sub

    Private Sub ViewContactButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViewContactButton.Click

    End Sub
End Class