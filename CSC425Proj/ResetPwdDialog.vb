Imports System.Data
Imports System.Data.SqlClient

Public Class ResetPwdDialog

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        '
        Cursor = Cursors.WaitCursor

        'validate user input.
        If PwdTextBox1.Text = Nothing Or PwdTextBox2.Text = Nothing Then
            'promt user to enter missin data.
            MsgBox("Please enter the new new password for this user.", MsgBoxStyle.Information, "Missing Password")

            'highlight all textboxes with missing information.
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
            Dim UserResponse As MsgBoxResult
            UserResponse = MsgBox("You are about to reset the password for the user, " + Trim(UserDBForm.DataGridView1.CurrentRow.Cells.Item(0).Value.ToString) + ", are you sure you want to do this?", MsgBoxStyle.YesNoCancel, "Confirm Selection")

            If UserResponse = MsgBoxResult.Yes Then

                Dim ResetPassword As New SqlCommand
                Dim Conn As New SqlConnection()

                'pass database connection to the connection variable.
                Conn = LogInForm.Conn

                'attempt to send the command to the database.
                Try
                    'open the connection to the DB.
                    Conn.Open()

                    'give the open connection to the sending command variable.
                    ResetPassword.Connection = Conn

                    'give the query to be sent to the command variable.
                    ResetPassword.CommandText = "UPDATE Faculty SET Password='" + LogInForm.MD5Encoder(PwdTextBox1.Text) + "' WHERE Username='" + UserDBForm.DataGridView1.CurrentRow.Cells.Item(1).Value.ToString + "'"

                    'execute the query
                    ResetPassword.ExecuteNonQuery()

                    Me.Close()

                Catch ex As Exception
                    MessageBox.Show("Update Error: " & ex.Message, "Failed to reset password")
                Finally
                    'close the connection regardless of success or failure.
                    Conn.Close()
                End Try

            Else
                Me.Close()
            End If
        End If
        '
        Cursor = Cursors.Default
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub ResetPwdDialog_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        PwdTextBox1.Clear()
        PwdTextBox2.Clear()

        'get the old password and store it for later use.
    End Sub

    Private Sub PwdTextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PwdTextBox1.TextChanged
        PwdTextBox1.BackColor = Color.White
    End Sub

    Private Sub PwdTextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PwdTextBox2.TextChanged
        PwdTextBox2.BackColor = Color.White
    End Sub
End Class
