Imports System.Data
Imports System.Data.SqlClient
Imports Microsoft.Office.Interop
Imports System.IO


Public Class NewApplicantForm
    Dim xlApp As Excel.Application
    Dim xlWorkBook As Excel.Workbook
    Dim xlWorkSheet As Excel.Worksheet
    Dim misValue As Object = System.Reflection.Missing.Value
    Dim I As Integer = 0
    Private FormReloader As NewApplicantForm
    
    ' Friend module Module1
    'Friend F1 As EventForm
    ' End Module

    Private Sub releaseObject(ByVal obj As Object)
        Try
            System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
            obj = Nothing
        Catch ex As Exception
            obj = Nothing
        Finally
            GC.Collect()
        End Try

    End Sub

    Private Sub CancelBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CancelBtn.Click
        
        xlWorkBook.SaveAs("C:\Users\edwin_b24\Lindenwood\Lindenwood spr 2011!\Adv Database\database\Base FINAL2\cosas.xlsx")
        xlWorkSheet.SaveAs("C:\Users\edwin_b24\Lindenwood\Lindenwood spr 2011!\Adv Database\database\Base FINAL2\cosassheet.xlsx")


        xlWorkBook.Close()
        xlApp.Quit()

     
        If ModeSelectForm.OffCampusMode = True Then
            Me.Close()
            ModeSelectForm.Show()
        Else
            Me.Close()
            'EventForm.Close()
        End If
    End Sub

    Private Sub NewApplicantForm_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If ModeSelectForm.OffCampusMode = True Then

            releaseObject(xlApp)
            releaseObject(xlWorkBook)
            releaseObject(xlWorkSheet)
         
        End If

        ' MainForm.Show()
    End Sub

    Private Sub NewApplicantForm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        '  If I = 1 Then
        'I = 2
        'xlWorkBook.SaveAs("C:\Users\edwin_b24\Lindenwood\Lindenwood spr 2011!\Adv Database\database\Base FINAL\cosas.xlsx")
        'ElseIf I > 1 Then
        'xlWorkBook.Save()
        'End If


        If I = 0 Then
            xlApp = New Excel.ApplicationClass
            xlWorkBook = xlApp.Workbooks.Add(misValue)
            xlWorkSheet = xlWorkBook.Sheets(1)
            I = 1
        End If

        'hide the specialization box until it is needed.
        SpecializationComboBox.Hide()
        SelectSpecializationLabel.Hide()

        DegreeComboBox.Items.Add("")

        Dim Conn As SqlConnection
        Conn = LogInForm.Conn
        Dim LoadNewApp As New SqlCommand
        Dim DataReader As SqlDataReader
        LoadNewApp.Connection = Conn

        Conn.Open()
        LoadNewApp.CommandText = "SELECT DISTINCT Type FROM Degree"
        DataReader = LoadNewApp.ExecuteReader
        While DataReader.Read()
            DegreeComboBox.Items.Add(DataReader.Item(0))
        End While
        DataReader.Close()
        Conn.Close()

        'Set the current value of the grad date picker to the current year
        'rather than the minimum value.
        GradDatePicker.Value = EventForm.CurrDate.Year
    End Sub

    Private Sub SubmitBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SubmitBtn.Click
        'validate user input.
        Dim Err As Boolean = False

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
            'change cursor to waiting so the user knows something is happening
            Cursor.Current = Cursors.WaitCursor

            Dim EventDate As String
            EventDate = EventForm.CurrDate.Month.ToString + "/" + EventForm.CurrDate.Day.ToString + _
                        "/" + EventForm.CurrDate.Year.ToString

            If TestComboBox.Text = "Placement Test" And TestScoreTextBox.Text = Nothing Then
                TestComboBox.Text = Nothing
            End If

            If ModeSelectForm.OffCampusMode = True Then


                xlWorkSheet.Cells(1, 1) = "LALALA"
                xlWorkSheet.Cells(2, 2) = FirstNameTextBox.Text
                xlWorkSheet.Cells(2, 3) = LastNameTextBox.Text
                xlWorkSheet.Cells(2, 4) = AddressTextBox.Text
                xlWorkSheet.Cells(2, 5) = CityTextBox.Text
                xlWorkSheet.Cells(2, 6) = StateComboBox.Text
                xlWorkSheet.Cells(2, 7) = ZipCodeTextBox.Text
                xlWorkSheet.Cells(2, 8) = EmailTextBox.Text
                xlWorkSheet.Cells(2, 9) = TelephoneMaskedTextBox.Text
                xlWorkSheet.Cells(2, 10) = CellphoneMaskedTextBox.Text
                xlWorkSheet.Cells(2, 11) = HighSchoolTextBox.Text
                xlWorkSheet.Cells(2, 12) = GradDatePicker.Value.ToString
                xlWorkSheet.Cells(2, 13) = TestComboBox.Text
                xlWorkSheet.Cells(2, 14) = TestScoreTextBox.Text
                xlWorkSheet.Cells(2, 15) = GPATextBox.Text
                xlWorkSheet.Cells(2, 16) = ClassRankTextBox.Text
                xlWorkSheet.Cells(2, 17) = ClassSizeTextBox.Text
                xlWorkSheet.Cells(2, 18) = CollegeTextBox.Text
                xlWorkSheet.Cells(2, 19) = DegreeComboBox.Text
                xlWorkSheet.Cells(2, 20) = MajorComboBox.Text
                xlWorkSheet.Cells(2, 21) = SpecializationComboBox.Text
                xlWorkSheet.Cells(2, 22) = InterestsTextBox.Text

               

                Dim MyFileStream As New IO.FileStream(EventForm.CurrEvent + " " + _
                                                      EventForm.CurrDate.Month.ToString + "-" + _
                                                      EventForm.CurrDate.Day.ToString + "-" + _
                                                      EventForm.CurrDate.Year.ToString + ".txt", _
                                                      IO.FileMode.Append, IO.FileAccess.Write, _
                                                      IO.FileShare.None)

                Dim MyFileWriter As New IO.StreamWriter(MyFileStream)
                MyFileWriter.Write(FirstNameTextBox.Text + " " + LastNameTextBox.Text + " " + AddressTextBox.Text + " " + CityTextBox.Text + " " + StateComboBox.Text + " " + ZipCodeTextBox.Text + " " + EmailTextBox.Text + " " + TelephoneMaskedTextBox.Text + " " + CellphoneMaskedTextBox.Text + " " + HighSchoolTextBox.Text + " " + GradDatePicker.Value.ToString + " " + TestComboBox.Text + " " + TestScoreTextBox.Text + " " + GPATextBox.Text + " " + ClassRankTextBox.Text + " " + ClassSizeTextBox.Text + " " + CollegeTextBox.Text + " " + DegreeComboBox.Text + " " + MajorComboBox.Text + " " + SpecializationComboBox.Text + " " + InterestsTextBox.Text + Environment.NewLine)

                'close stream when done writing.
                MyFileWriter.Close()

                'promt the user on success
                MsgBox("Applicant information has been successfully entered.", MsgBoxStyle.OkOnly, _
                                       "Successfully Entered")
                '
                Cursor.Current = Cursors.Default

                'load a new form
                FormReloader = New NewApplicantForm
                Me.Close()
                FormReloader.Show()
            Else
                Dim Conn As New SqlConnection
                Dim NewApplicantCmd As New SqlCommand
                Conn = LogInForm.Conn

                'declare transaction
                Dim InsertTrans

                'Send the insert queries to the database.
                Try
                    'open the connection to the DB.
                    Conn.Open()

                    'give the open connection to the sending command variable.
                    NewApplicantCmd.Connection = Conn

                    'give the transaction the open connection.
                    InsertTrans = Conn.BeginTransaction

                    'pass transaction to sql command variable
                    NewApplicantCmd.Transaction = InsertTrans

                    'give the query to be sent to the command variable for the student info table.
                    NewApplicantCmd.CommandText = "INSERT INTO StudentInfo VALUES('" + Trim(FirstNameTextBox.Text) + "','" + Trim(LastNameTextBox.Text) + "','" + Trim(AddressTextBox.Text) + "','" + Trim(CityTextBox.Text) + "','" + StateComboBox.Text + "','" + Trim(ZipCodeTextBox.Text) + "','" + Trim(EmailTextBox.Text) + "','" + TelephoneMaskedTextBox.Text + "','" + CellphoneMaskedTextBox.Text + "','" + EventDate.ToString + "','" + Trim(EventForm.CurrEventTextBox.Text) + "','0','0','0','" + Trim(DegreeComboBox.Text) + "', '" + Trim(MajorComboBox.Text) + "','" + Trim(SpecializationComboBox.Text) + "','" + Trim(InterestsTextBox.Text) + "')"

                    'execute the query
                    NewApplicantCmd.ExecuteNonQuery()

                    'give the query to be sent to the command variable for the education background table.
                    NewApplicantCmd.CommandText = "INSERT INTO EducationalBackground VALUES('" + Trim(FirstNameTextBox.Text) + "','" + Trim(LastNameTextBox.Text) + "','" + Trim(AddressTextBox.Text) + "','" + Trim(ZipCodeTextBox.Text) + "','" + Trim(EmailTextBox.Text) + "','" + Trim(HighSchoolTextBox.Text) + "','" + Trim(GradDatePicker.Value.ToString) + "','" + TestComboBox.Text + "','" + Trim(TestScoreTextBox.Text) + "','" + Trim(GPATextBox.Text) + "','" + Trim(ClassRankTextBox.Text) + "','" + Trim(ClassSizeTextBox.Text) + "','" + Trim(CollegeTextBox.Text) + "')"

                    'execute the query
                    NewApplicantCmd.ExecuteNonQuery()

                    'commit tranaction now all queries have executed.
                    InsertTrans.Commit()

                    'promt the user on success
                    MsgBox("Applicant information has been successfully entered.", MsgBoxStyle.Information, _
                                           "Successfully Entered")
                    '
                    Cursor.Current = Cursors.Default

                    'load a new form
                    FormReloader = New NewApplicantForm
                    Me.Close()
                    FormReloader.Show()

                Catch ex As Exception
                    'rollback transaction upon error
                    InsertTrans.Rollback()
                    MessageBox.Show("Error while inserting records in table..." & ex.Message, "Insert Failed")
                Finally
                    'close the connection regardless of success or failure.
                    Conn.Close()
                    Cursor.Current = Cursors.Default
                End Try
            End If
            End If
    End Sub

    Private Sub NextBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NextBtn.Click
        TabControl.SelectedTab = EducationInfoTab
    End Sub

    Private Sub TabBackBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabBackBtn.Click
        TabControl.SelectedTab = ContactInfoTab
    End Sub

    Private Sub MajorComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MajorComboBox.SelectedIndexChanged
        'set specializations to none when major is not tech theatre.
        SpecializationComboBox.Items.Clear()

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

    Private Sub TestComboBox_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TestComboBox.SelectedValueChanged
        TestComboBox.BackColor = Color.White
    End Sub

    Private Sub MajorComboBox_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles MajorComboBox.SelectedValueChanged
        SelectMajorLabel.ForeColor = Color.Black
    End Sub

    Private Sub SpecializationComboBox_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles SpecializationComboBox.SelectedValueChanged
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
End Class