Imports System.Data
Imports System.Data.SqlClient

Public Class AddNewUserDialog

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        '
        Cursor = Cursors.WaitCursor

        'validate user input.
        If FacultyTextBox.Text = Nothing Or UsernameTextBox.Text = Nothing Or _
                                        PwdTextBox1.Text = Nothing Or PwdTextBox2.Text = Nothing Then
            'promt user to enter missin data.
            MsgBox("Please enter the missing information.", MsgBoxStyle.Information, "Missing Creditials")

            'highlight all textboxes with missing information.
            If FacultyTextBox.Text = Nothing Then
                FacultyTextBox.BackColor = Color.Salmon
            End If

            If UsernameTextBox.Text = Nothing Then
                UsernameTextBox.BackColor = Color.Salmon
            End If

            If PwdTextBox1.Text = Nothing Then
                PwdTextBox1.BackColor = Color.Salmon
            End If

            If PwdTextBox2.Text = Nothing Then
                PwdTextBox2.BackColor = Color.Salmon
            End If

        ElseIf PwdTextBox1.Text <> PwdTextBox2.Text Then
            MsgBox("The entered password do not match.", MsgBoxStyle.Information, "Password Mismatch")
            PwdTextBox1.BackColor = Color.Salmon
            PwdTextBox2.BackColor = Color.Salmon

        ElseIf PwdTextBox1.TextLength < 6 Or PwdTextBox1.TextLength > 12 Then
            PwdTextBox1.BackColor = Color.Salmon
            MsgBox("Password must be 6 to 12 characters long.", MsgBoxStyle.Information, "Invalid Password")

        ElseIf PwdTextBox2.TextLength < 6 Or PwdTextBox2.TextLength > 12 Then
            PwdTextBox2.BackColor = Color.Salmon
            MsgBox("Password must be 6 to 12 characters long.", MsgBoxStyle.Information, "Invalid Password")


        Else
            Dim AddUser As New SqlCommand
            Dim Conn As New SqlConnection()

            'pass database connection to the connection variable.
            Conn = LogInForm.Conn

            'attempt to send the command to the database.
            Try
                'open the connection to the DB.
                Conn.Open()

                'give the open connection to the sending command variable.
                AddUser.Connection = Conn

                'give the query to be sent to the command variable.
                AddUser.CommandText = "INSERT INTO Faculty VALUES('" + FacultyTextBox.Text + "','" + UsernameTextBox.Text + "','" + LogInForm.MD5Encoder(PwdTextBox1.Text) + "')"

                'execute the query
                AddUser.ExecuteNonQuery()

                Me.Close()

            Catch ex As Exception
                MessageBox.Show("Insert Error: " & ex.Message, "Failed to add new user")
            Finally
                'close the connection regardless of success or failure.
                Conn.Close()
            End Try
        End If
        '
        Cursor = Cursors.Default
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.Close()
    End Sub

    Private Sub FacultyTextBox_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles FacultyTextBox.Click
        FacultyTextBox.BackColor = Color.White
    End Sub

    Private Sub UsernameTextBox_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles UsernameTextBox.Click
        UsernameTextBox.BackColor = Color.White
    End Sub

    Private Sub PwdTextBox1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles PwdTextBox1.Click
        PwdTextBox1.BackColor = Color.White
    End Sub

    Private Sub PwdTextBox2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles PwdTextBox2.Click
        PwdTextBox2.BackColor = Color.White
    End Sub

    Private Sub AddNewUserDialog_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
