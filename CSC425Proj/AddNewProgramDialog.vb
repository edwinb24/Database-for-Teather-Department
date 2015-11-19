Imports System.Data
Imports System.Data.SqlClient
Public Class AddNewProgramDialog

    Dim toggle As Boolean = False
    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        'validate user input.
        If DegreeTextBox.Text = Nothing Or MajorTextBox.Text = Nothing Or (toggle = True And SpecializationTextBox.Text = Nothing) Then
            'highlight all textboxes with missing information.
            If DegreeTextBox.Text = Nothing Then
                DegreeTextBox.BackColor = Color.Salmon
            End If

            If MajorTextBox.Text = Nothing Then
                MajorTextBox.BackColor = Color.Salmon
            End If

            If toggle = True And SpecializationTextBox.Text = Nothing Then
                SpecializationTextBox.BackColor = Color.Salmon
            End If

            'prompt user to enter missing data.
            MsgBox("Please enter the required information.", , "Missing Creditials")
        Else
            If toggle = False Then
                SpecializationTextBox.Text = "none"
            End If

            Cursor = Cursors.WaitCursor

            Dim Conn As New SqlConnection
            Dim NewApplicantCmd As New SqlCommand
            Conn = LogInForm.Conn

            'Send the insert queries to the database.
            Try
                'open the connection to the DB.
                Conn.Open()

                'give the open connection to the sending command variable.
                NewApplicantCmd.Connection = Conn

                'give the query to be sent to the command variable for the student info table.
                NewApplicantCmd.CommandText = "INSERT INTO Degree VALUES('" + Trim(DegreeTextBox.Text) + "','" + Trim(MajorTextBox.Text) + "','" + Trim(SpecializationTextBox.Text) + "')"

                'execute the query
                NewApplicantCmd.ExecuteNonQuery()

                '
                Cursor.Current = Cursors.Default

                'promt the user on success
                MsgBox("New degree information has been successfully entered.", MsgBoxStyle.OkOnly, _
                                       "Successfully Entered")
                '
                Me.Close()

            Catch ex As Exception
                MessageBox.Show("Error while inserting records in table..." & ex.Message, "Insert Failed")
            Finally
                'close the connection regardless of success or failure.
                Conn.Close()
                Cursor.Current = Cursors.Default
            End Try
        End If
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.Close()
    End Sub

    Private Sub DegreeTextBox_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles DegreeTextBox.Click
        DegreeTextBox.BackColor = Color.White
    End Sub

    Private Sub MajorTextBox_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles MajorTextBox.Click
        MajorTextBox.BackColor = Color.White
    End Sub

    Private Sub SpecializationTextBox_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles SpecializationTextBox.Click
        SpecializationTextBox.BackColor = Color.White
    End Sub

    Private Sub AddNewProgramDialog_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DegreeTextBox.Clear()
        MajorTextBox.Clear()
        SpecializationTextBox.Clear()
        SpecializationTextBox.Hide()
        Cursor = Cursors.Default
        toggle = False
        ShowSpecializationButton.Text = ">>"
    End Sub

    Private Sub ShowSpecializationButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ShowSpecializationButton.Click
        If toggle = False Then
            ShowSpecializationButton.Text = "<<"
            SpecializationTextBox.Show()
            toggle = True
        Else
            ShowSpecializationButton.Text = ">>"
            SpecializationTextBox.Hide()
            toggle = False
        End If
    End Sub
End Class
