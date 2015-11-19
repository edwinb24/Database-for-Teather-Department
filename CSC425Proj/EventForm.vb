Public Class EventForm
    Public CurrDate As Date
    Public CurrEvent As String

    Private Sub CancelBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CancelBtn.Click

        If ModeSelectForm.OffCampusMode = True Then
            ModeSelectForm.Show()
            Me.Close()
        Else
            Me.Close()
        End If

    End Sub

    Private Sub ContinueBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ContinueBtn.Click

        If CurrEventTextBox.Text = Nothing Then
            MsgBox("Please enter the name of an event", , "Enter an event")
            CurrEventTextBox.BackColor = Color.Salmon
        Else
            CurrDate = CurrDatePicker.Value
            CurrEvent = CurrEventTextBox.Text
            MainForm.Hide()
            Me.Hide()
            NewApplicantForm.Show()
        End If

    End Sub

    Private Sub CurrEventTextBox_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles CurrEventTextBox.Click
        CurrEventTextBox.BackColor = Color.White
    End Sub

    Private Sub EventForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CurrEventTextBox.Clear()
    End Sub
End Class