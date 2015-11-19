<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FinderForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FinderForm))
        Me.FindApplicantsBtn = New System.Windows.Forms.Button
        Me.CancelBtn = New System.Windows.Forms.Button
        Me.SubjectComboBox = New System.Windows.Forms.ComboBox
        Me.MajorComboBox = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.FNameTextBox = New System.Windows.Forms.TextBox
        Me.LNameTextBox = New System.Windows.Forms.TextBox
        Me.GradDatePicker = New System.Windows.Forms.NumericUpDown
        Me.AuditionDatePicker = New System.Windows.Forms.DateTimePicker
        CType(Me.GradDatePicker, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FindApplicantsBtn
        '
        Me.FindApplicantsBtn.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FindApplicantsBtn.Location = New System.Drawing.Point(160, 128)
        Me.FindApplicantsBtn.Name = "FindApplicantsBtn"
        Me.FindApplicantsBtn.Size = New System.Drawing.Size(75, 25)
        Me.FindApplicantsBtn.TabIndex = 0
        Me.FindApplicantsBtn.Text = "Search"
        Me.FindApplicantsBtn.UseVisualStyleBackColor = True
        '
        'CancelBtn
        '
        Me.CancelBtn.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CancelBtn.Location = New System.Drawing.Point(241, 128)
        Me.CancelBtn.Name = "CancelBtn"
        Me.CancelBtn.Size = New System.Drawing.Size(75, 25)
        Me.CancelBtn.TabIndex = 1
        Me.CancelBtn.Text = "Cancel"
        Me.CancelBtn.UseVisualStyleBackColor = True
        '
        'SubjectComboBox
        '
        Me.SubjectComboBox.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SubjectComboBox.FormattingEnabled = True
        Me.SubjectComboBox.Items.AddRange(New Object() {"Major", "First Name", "Last Name", "Full Name", "Graduation Date", "Audition Date"})
        Me.SubjectComboBox.Location = New System.Drawing.Point(160, 21)
        Me.SubjectComboBox.Name = "SubjectComboBox"
        Me.SubjectComboBox.Size = New System.Drawing.Size(121, 28)
        Me.SubjectComboBox.TabIndex = 2
        '
        'MajorComboBox
        '
        Me.MajorComboBox.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MajorComboBox.FormattingEnabled = True
        Me.MajorComboBox.Items.AddRange(New Object() {"Music", "Art", "Example", "Etc..."})
        Me.MajorComboBox.Location = New System.Drawing.Point(68, 68)
        Me.MajorComboBox.Name = "MajorComboBox"
        Me.MajorComboBox.Size = New System.Drawing.Size(183, 26)
        Me.MajorComboBox.TabIndex = 3
        Me.MajorComboBox.Text = "-- Please Selelect A Major --"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(135, 20)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Find Applicant By:"
        '
        'FNameTextBox
        '
        Me.FNameTextBox.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FNameTextBox.Location = New System.Drawing.Point(16, 68)
        Me.FNameTextBox.Name = "FNameTextBox"
        Me.FNameTextBox.Size = New System.Drawing.Size(131, 26)
        Me.FNameTextBox.TabIndex = 5
        Me.FNameTextBox.Text = "Enter First Name...."
        '
        'LNameTextBox
        '
        Me.LNameTextBox.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LNameTextBox.Location = New System.Drawing.Point(160, 68)
        Me.LNameTextBox.Name = "LNameTextBox"
        Me.LNameTextBox.Size = New System.Drawing.Size(137, 26)
        Me.LNameTextBox.TabIndex = 6
        Me.LNameTextBox.Text = "Enter Last Name..."
        '
        'GradDatePicker
        '
        Me.GradDatePicker.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GradDatePicker.Location = New System.Drawing.Point(88, 69)
        Me.GradDatePicker.Maximum = New Decimal(New Integer() {9999, 0, 0, 0})
        Me.GradDatePicker.Minimum = New Decimal(New Integer() {1980, 0, 0, 0})
        Me.GradDatePicker.Name = "GradDatePicker"
        Me.GradDatePicker.Size = New System.Drawing.Size(109, 26)
        Me.GradDatePicker.TabIndex = 12
        Me.GradDatePicker.Value = New Decimal(New Integer() {1980, 0, 0, 0})
        '
        'AuditionDatePicker
        '
        Me.AuditionDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.AuditionDatePicker.Location = New System.Drawing.Point(113, 69)
        Me.AuditionDatePicker.Name = "AuditionDatePicker"
        Me.AuditionDatePicker.Size = New System.Drawing.Size(111, 20)
        Me.AuditionDatePicker.TabIndex = 13
        '
        'FinderForm
        '
        Me.AcceptButton = Me.FindApplicantsBtn
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.CadetBlue
        Me.ClientSize = New System.Drawing.Size(328, 165)
        Me.Controls.Add(Me.AuditionDatePicker)
        Me.Controls.Add(Me.GradDatePicker)
        Me.Controls.Add(Me.LNameTextBox)
        Me.Controls.Add(Me.FNameTextBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MajorComboBox)
        Me.Controls.Add(Me.SubjectComboBox)
        Me.Controls.Add(Me.CancelBtn)
        Me.Controls.Add(Me.FindApplicantsBtn)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FinderForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "View Applicant - Search"
        CType(Me.GradDatePicker, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents FindApplicantsBtn As System.Windows.Forms.Button
    Friend WithEvents CancelBtn As System.Windows.Forms.Button
    Friend WithEvents SubjectComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents MajorComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents FNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents LNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents GradDatePicker As System.Windows.Forms.NumericUpDown
    Friend WithEvents AuditionDatePicker As System.Windows.Forms.DateTimePicker
End Class
