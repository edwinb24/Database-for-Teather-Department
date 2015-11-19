<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FindApplicantToUpdateForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FindApplicantToUpdateForm))
        Me.LNameTextBox = New System.Windows.Forms.TextBox
        Me.FNameTextBox = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.SubjectComboBox = New System.Windows.Forms.ComboBox
        Me.CancelBtn = New System.Windows.Forms.Button
        Me.FindApplicantBtn = New System.Windows.Forms.Button
        Me.DegreeComboBox = New System.Windows.Forms.ComboBox
        Me.MajorComboBox = New System.Windows.Forms.ComboBox
        Me.SelectDegreeLabel = New System.Windows.Forms.Label
        Me.SelectMajorLabel = New System.Windows.Forms.Label
        Me.SearchDateTimePicker = New System.Windows.Forms.DateTimePicker
        Me.SuspendLayout()
        '
        'LNameTextBox
        '
        Me.LNameTextBox.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LNameTextBox.Location = New System.Drawing.Point(176, 65)
        Me.LNameTextBox.Name = "LNameTextBox"
        Me.LNameTextBox.Size = New System.Drawing.Size(137, 26)
        Me.LNameTextBox.TabIndex = 19
        '
        'FNameTextBox
        '
        Me.FNameTextBox.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FNameTextBox.Location = New System.Drawing.Point(12, 65)
        Me.FNameTextBox.Name = "FNameTextBox"
        Me.FNameTextBox.Size = New System.Drawing.Size(131, 26)
        Me.FNameTextBox.TabIndex = 18
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(135, 19)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Find Applicant By:"
        '
        'SubjectComboBox
        '
        Me.SubjectComboBox.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SubjectComboBox.FormattingEnabled = True
        Me.SubjectComboBox.Items.AddRange(New Object() {"First Name", "Last Name", "Full Name", "Degree Program", "Audition Date"})
        Me.SubjectComboBox.Location = New System.Drawing.Point(160, 25)
        Me.SubjectComboBox.Name = "SubjectComboBox"
        Me.SubjectComboBox.Size = New System.Drawing.Size(153, 27)
        Me.SubjectComboBox.TabIndex = 15
        '
        'CancelBtn
        '
        Me.CancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.CancelBtn.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CancelBtn.Location = New System.Drawing.Point(220, 115)
        Me.CancelBtn.Name = "CancelBtn"
        Me.CancelBtn.Size = New System.Drawing.Size(75, 23)
        Me.CancelBtn.TabIndex = 14
        Me.CancelBtn.Text = "Cancel"
        Me.CancelBtn.UseVisualStyleBackColor = True
        '
        'FindApplicantBtn
        '
        Me.FindApplicantBtn.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FindApplicantBtn.Location = New System.Drawing.Point(126, 115)
        Me.FindApplicantBtn.Name = "FindApplicantBtn"
        Me.FindApplicantBtn.Size = New System.Drawing.Size(88, 23)
        Me.FindApplicantBtn.TabIndex = 13
        Me.FindApplicantBtn.Text = "Search"
        Me.FindApplicantBtn.UseVisualStyleBackColor = True
        '
        'DegreeComboBox
        '
        Me.DegreeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.DegreeComboBox.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DegreeComboBox.FormattingEnabled = True
        Me.DegreeComboBox.Location = New System.Drawing.Point(16, 82)
        Me.DegreeComboBox.Name = "DegreeComboBox"
        Me.DegreeComboBox.Size = New System.Drawing.Size(154, 27)
        Me.DegreeComboBox.TabIndex = 20
        '
        'MajorComboBox
        '
        Me.MajorComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.MajorComboBox.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MajorComboBox.FormattingEnabled = True
        Me.MajorComboBox.Location = New System.Drawing.Point(176, 80)
        Me.MajorComboBox.Name = "MajorComboBox"
        Me.MajorComboBox.Size = New System.Drawing.Size(151, 27)
        Me.MajorComboBox.TabIndex = 21
        '
        'SelectDegreeLabel
        '
        Me.SelectDegreeLabel.AutoSize = True
        Me.SelectDegreeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SelectDegreeLabel.Location = New System.Drawing.Point(13, 64)
        Me.SelectDegreeLabel.Name = "SelectDegreeLabel"
        Me.SelectDegreeLabel.Size = New System.Drawing.Size(114, 17)
        Me.SelectDegreeLabel.TabIndex = 22
        Me.SelectDegreeLabel.Text = "Select a Degree:"
        '
        'SelectMajorLabel
        '
        Me.SelectMajorLabel.AutoSize = True
        Me.SelectMajorLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SelectMajorLabel.Location = New System.Drawing.Point(173, 64)
        Me.SelectMajorLabel.Name = "SelectMajorLabel"
        Me.SelectMajorLabel.Size = New System.Drawing.Size(102, 17)
        Me.SelectMajorLabel.TabIndex = 23
        Me.SelectMajorLabel.Text = "Select a Major:"
        '
        'SearchDateTimePicker
        '
        Me.SearchDateTimePicker.CalendarFont = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SearchDateTimePicker.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SearchDateTimePicker.Location = New System.Drawing.Point(39, 68)
        Me.SearchDateTimePicker.Name = "SearchDateTimePicker"
        Me.SearchDateTimePicker.Size = New System.Drawing.Size(236, 23)
        Me.SearchDateTimePicker.TabIndex = 24
        '
        'FindApplicantToUpdateForm
        '
        Me.AcceptButton = Me.FindApplicantBtn
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.CadetBlue
        Me.CancelButton = Me.CancelBtn
        Me.ClientSize = New System.Drawing.Size(339, 150)
        Me.Controls.Add(Me.SearchDateTimePicker)
        Me.Controls.Add(Me.SelectMajorLabel)
        Me.Controls.Add(Me.SelectDegreeLabel)
        Me.Controls.Add(Me.MajorComboBox)
        Me.Controls.Add(Me.DegreeComboBox)
        Me.Controls.Add(Me.LNameTextBox)
        Me.Controls.Add(Me.FNameTextBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.SubjectComboBox)
        Me.Controls.Add(Me.CancelBtn)
        Me.Controls.Add(Me.FindApplicantBtn)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FindApplicantToUpdateForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Edit Applicant - Search"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents FNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents SubjectComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents CancelBtn As System.Windows.Forms.Button
    Friend WithEvents FindApplicantBtn As System.Windows.Forms.Button
    Friend WithEvents DegreeComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents MajorComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents SelectDegreeLabel As System.Windows.Forms.Label
    Friend WithEvents SelectMajorLabel As System.Windows.Forms.Label
    Friend WithEvents SearchDateTimePicker As System.Windows.Forms.DateTimePicker
End Class
