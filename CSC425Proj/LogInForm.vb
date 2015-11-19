Imports System.Data
Imports System.Data.SqlClient
Imports System.Security.Cryptography

Public Class LogInForm
    'the connection is made a public global so it can be referenced from form to form.
    'this way we only need to change this string, rather than change strings on EVERY form.
    Public Conn As New SqlConnection("Data Source=127.0.0.1;Network Library=DBMSSOCN;Initial Catalog=TheatreManagerDB;User ID=NICOLE-PC\SQLEXPRESS;Password=;Trusted_Connection=Yes;")
    Dim ConnSuccessful As Boolean = False

    Private Sub ExitBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitBtn.Click
        'Exits the program.
        Dim UserResponse As MsgBoxResult
        UserResponse = MsgBox("Are you sure you want to exit the program?", MsgBoxStyle.YesNo, "Exit?")

        If (UserResponse = MsgBoxResult.Yes) Then
            End
        End If
    End Sub

    Private Sub LogInBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LogInBtn.Click
        Dim Login As New SqlCommand
        Dim DataReader As SqlDataReader
        Dim LoginSuccess As Boolean

        'change cursor to waiting so the user knows something is happening
        Cursor.Current = Cursors.WaitCursor

        'attempt to send the command to the database.
        Try
            'open the connection to the DB.
            Conn.Open()

            'give the open connection to the sending command variable.
            Login.Connection = Conn

            'give the query to be sent to the command variable.
            Login.CommandText = "SELECT COUNT(*) AS SuccessVar, Username, Password FROM Faculty GROUP BY Username, Password HAVING (COUNT(*) = 1) AND (Username ='" + Trim(UsernameTextBox.Text) + "') AND (Password ='" + MD5Encoder(Trim(PasswordTextBox.Text)) + "')"

            'assign the data reader the query results
            DataReader = Login.ExecuteReader

            'read the data returned from the query
            While DataReader.Read()
                'the query returns 1 row 1 column which is indicated by the 0.
                'it's simmilar to the html assignment from last semester in that you need to
                '  know how many rows and coumns that will be returned.
                LoginSuccess = DataReader.Item(0)
            End While

        Catch ex As Exception
            MessageBox.Show("Error while retrieving records in table..." & ex.Message, "Login Failed")
        Finally 'close the connection regardless of success or failure.
            Conn.Close()
        End Try

        'check if the login was successful
        If LoginSuccess = False Then
            CredentialError.Show()
            CredentialError.Text = "Invalid Username or Password." & vbCrLf & "Please try again."
            UsernameTextBox.Text = Nothing
            PasswordTextBox.Text = Nothing
            Cursor.Current = Cursors.Default
        Else
            'If login Successful display main form.
            MainForm.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        AboutForm.ShowDialog()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        'exits the program
        Dim UserResponse As MsgBoxResult
        UserResponse = MsgBox("Are you sure you want to exit the program?", MsgBoxStyle.YesNo)

        If (UserResponse = MsgBoxResult.Yes) Then
            End
        End If
    End Sub

    Private Sub LogInForm_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        'control the close button and prevent multiple instances from forming.
        If MessageBox.Show("Are you sure you want to exit the program?", "Exit the Program?", MessageBoxButtons.OKCancel) = Windows.Forms.DialogResult.Cancel Then
            e.Cancel = True
        Else
            End
        End If
    End Sub

    Private Sub LogInForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CredentialError.Hide()

        Dim UserResponse As MsgBoxResult

        'check if the program can connect to the database.
        ConnSuccessful = False
        TestSqlConnection()

        If ConnSuccessful = False Then
            UserResponse = MsgBox("Could not connect to the database. Please make sure that:" _
                                  + System.Environment.NewLine + System.Environment.NewLine _
                                  + "1: The computer that houses the database is turned on." _
                                  + System.Environment.NewLine _
                                  + "2: The computer that houses the database is connected to the internet" _
                                  + System.Environment.NewLine _
                                  + "3: Your computer is connected to the internet" _
                                  + System.Environment.NewLine _
                                  + "4: The database has not been deleted" + System.Environment.NewLine _
                                  + System.Environment.NewLine _
                                  + "For other problems please contact your network administrator.", MsgBoxStyle.RetryCancel, "Connection Error")

        End If

        If UserResponse = MsgBoxResult.Retry Then
            TestSqlConnection()
        ElseIf UserResponse = MsgBoxResult.Cancel Then
            ModeSelectForm.Show()
            Me.Hide()
        End If

    End Sub

    Sub TestSqlConnection()
        '
        Cursor = Cursors.WaitCursor

        'attempt to make a connection to the database.
        Try
            Conn.Open()
            ConnSuccessful = True

        Catch ex As Exception 'if the connection is unsuccessful display why
            ConnSuccessful = False

        Finally 'whether the connection was successful or not close the connection to the DB.
            Conn.Close()
        End Try

        'change the cursor from waiting, back to default
        Cursor = Cursors.Default
    End Sub

    Function MD5Encoder(ByVal str As String) As String

        Dim Provider As New MD5CryptoServiceProvider
        Dim ByteValue() As Byte
        Dim ByteHash() As Byte
        Dim EncodedString As String = ""
        Dim i As Integer

        'Retrieve a byte array based on the source text
        ByteValue = System.Text.Encoding.UTF8.GetBytes(str)

        'Compute the hash value from the source
        ByteHash = Provider.ComputeHash(ByteValue)
        '
        provider.Clear()
        '
        For i = 0 To ByteHash.Length - 1

            EncodedString &= ByteHash(i).ToString("x").PadLeft(2, "0")

        Next

        'return md5 hashed string
        Return EncodedString
    End Function


End Class
