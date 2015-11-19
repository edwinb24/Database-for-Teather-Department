Imports System.Data
Imports System.Data.SqlClient
Imports System.Security.Cryptography

Public Class ChangePwdDialog
    Public OldPassword As String

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        '
        Cursor = Cursors.WaitCursor

        'validate user input.
        If OldPwdTextBox.Text = Nothing Or PwdTextBox1.Text = Nothing Or PwdTextBox2.Text = Nothing Then
            'promt user to enter missin data.
            MsgBox("Please enter the new password for this user.", MsgBoxStyle.Information, "Missing Password")

            'highlight all textboxes with missing information.
            If OldPwdTextBox.Text = Nothing Then
                OldPwdTextBox.BackColor = Color.Salmon
            End If

            If PwdTextBox1.Text = Nothing Then
                PwdTextBox1.BackColor = Color.Salmon
            End If

            If PwdTextBox2.Text = Nothing Then
                PwdTextBox2.BackColor = Color.Salmon
            End If

        ElseIf PwdTextBox1.Text <> PwdTextBox2.Text Then
            MsgBox("The entered passwords do not match.", MsgBoxStyle.Information, "Password Mismatch")
            PwdTextBox1.BackColor = Color.Salmon
            PwdTextBox2.BackColor = Color.Salmon

        ElseIf PwdTextBox1.TextLength < 6 Or PwdTextBox1.TextLength > 12 Then
            PwdTextBox1.BackColor = Color.Salmon
            MsgBox("Password must be 6 to 12 characters long.", MsgBoxStyle.Information, "Invalid Password")

        ElseIf PwdTextBox2.TextLength < 6 Or PwdTextBox2.TextLength > 12 Then
            PwdTextBox2.BackColor = Color.Salmon
            MsgBox("Password must be 6 to 12 characters long.", MsgBoxStyle.Information, "Invalid Password")

        Else
            'get what the current password is.
            GetOldPassword()

            'check if the password in the database is the same as what the user entered.
            If OldPassword.ToString = LogInForm.MD5Encoder(OldPwdTextBox.Text) Then

                Dim ChangePassword As New SqlCommand
                Dim Conn As New SqlConnection()

                'pass database connection to the connection variable.
                Conn = LogInForm.Conn

                'attempt to send the command to the database.
                Try
                    'open the connection to the DB.
                    Conn.Open()

                    'give the open connection to the sending command variable.
                    ChangePassword.Connection = Conn

                    'give the query to be sent to the command variable.
                    ChangePassword.CommandText = "UPDATE Faculty SET Password='" + LogInForm.MD5Encoder(PwdTextBox1.Text) + "' WHERE Username='" + LogInForm.UsernameTextBox.Text + "'"

                    'execute the query
                    ChangePassword.ExecuteNonQuery()

                    MsgBox("Your password has been changed successfully.", MsgBoxStyle.Information, "Password Changed Successfully")

                    Me.Close()

                Catch ex As Exception
                    MsgBox("Could not connect to the database. Please check your connection or contact your administrator", MsgBoxStyle.Information, "Failed to reset password")
                Finally
                    'close the connection regardless of success or failure.
                    Conn.Close()
                End Try

            Else
                MsgBox("The entered value for the old password is incorrect.", MsgBoxStyle.Information, "Incorrect Password")
                OldPwdTextBox.BackColor = Color.Salmon
            End If
        End If
        '
        Cursor = Cursors.Default
    End Sub

    Sub GetOldPassword()
        Dim Conn As New SqlConnection()
        Dim GetOldPwd As New SqlCommand()
        Dim DataReader As SqlDataReader

        'pass database connection to the connection variable.
        Conn = LogInForm.Conn

        'attempt to send the command to the database.
        Try
            'open the connection to the DB.
            Conn.Open()

            'give the open connection to the sending command variable.
            GetOldPwd.Connection = Conn

            'give the query to be sent to the command variable.
            GetOldPwd.CommandText = "SELECT Password FROM Faculty WHERE Username='" + LogInForm.UsernameTextBox.Text + "'"
            'execute the query
            GetOldPwd.ExecuteNonQuery()

            'assign the data reader the query results
            DataReader = GetOldPwd.ExecuteReader

            While DataReader.Read()
                'the query returns 1 row 1 column which is indicated by the 0.
                OldPassword = Trim(DataReader.Item(0))
            End While

        Catch ex As Exception
            MsgBox("Could not connect to the database. Please check your connection or contact your administrator", MsgBoxStyle.Information, "Connection Error")
            Me.Close()
        Finally
            Conn.Close()
        End Try

    End Sub

    Private Sub ChangePwdDialog_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'clear any lingering old user input.
        OldPwdTextBox.Clear()
        PwdTextBox1.Clear()
        PwdTextBox2.Clear()

        'PwdTextBox2.Text = MD5Encoder(InputBox("enter unencrytped string").ToString)
    End Sub

    Private Sub OldPwdTextBox_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles OldPwdTextBox.Click
        OldPwdTextBox.BackColor = Color.White
    End Sub

    Private Sub PwdTextBox1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles PwdTextBox1.Click
        PwdTextBox1.BackColor = Color.White
    End Sub

    Private Sub PwdTextBox2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles PwdTextBox2.Click
        PwdTextBox2.BackColor = Color.White
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub
End Class
