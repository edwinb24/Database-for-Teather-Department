<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EventForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EventForm))
        Me.CurrDatePicker = New System.Windows.Forms.DateTimePicker
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.CurrEventTextBox = New System.Windows.Forms.TextBox
        Me.CancelBtn = New System.Windows.Forms.Button
        Me.ContinueBtn = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'CurrDatePicker
        '
        Me.CurrDatePicker.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CurrDatePicker.Location = New System.Drawing.Point(84, 9)
        Me.CurrDatePicker.Name = "CurrDatePicker"
        Me.CurrDatePicker.Size = New System.Drawing.Size(254, 27)
        Me.CurrDatePicker.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 20)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Date:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(5, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 20)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Event:"
        '
        'CurrEventTextBox
        '
        Me.CurrEventTextBox.BackColor = System.Drawing.SystemColors.Window
        Me.CurrEventTextBox.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CurrEventTextBox.Location = New System.Drawing.Point(84, 46)
        Me.CurrEventTextBox.MaxLength = 49
        Me.CurrEventTextBox.Name = "CurrEventTextBox"
        Me.CurrEventTextBox.Size = New System.Drawing.Size(254, 27)
        Me.CurrEventTextBox.TabIndex = 6
        '
        'CancelBtn
        '
        Me.CancelBtn.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CancelBtn.Location = New System.Drawing.Point(286, 95)
        Me.CancelBtn.Name = "CancelBtn"
        Me.CancelBtn.Size = New System.Drawing.Size(80, 26)
        Me.CancelBtn.TabIndex = 7
        Me.CancelBtn.Text = "Cancel"
        Me.CancelBtn.UseVisualStyleBackColor = True
        '
        'ContinueBtn
        '
        Me.ContinueBtn.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ContinueBtn.Location = New System.Drawing.Point(190, 95)
        Me.ContinueBtn.Name = "ContinueBtn"
        Me.ContinueBtn.Size = New System.Drawing.Size(80, 26)
        Me.ContinueBtn.TabIndex = 8
        Me.ContinueBtn.Text = "Continue"
        Me.ContinueBtn.UseVisualStyleBackColor = True
        '
        'EventForm
        '
        Me.AcceptButton = Me.ContinueBtn
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.CadetBlue
        Me.ClientSize = New System.Drawing.Size(378, 133)
        Me.Controls.Add(Me.ContinueBtn)
        Me.Controls.Add(Me.CancelBtn)
        Me.Controls.Add(Me.CurrEventTextBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.CurrDatePicker)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "EventForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "New Applicant - Event"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CurrDatePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents CurrEventTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CancelBtn As System.Windows.Forms.Button
    Friend WithEvents ContinueBtn As System.Windows.Forms.Button
End Class
