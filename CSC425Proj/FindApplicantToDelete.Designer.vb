<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FindApplicantToDelete
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FindApplicantToDelete))
        Me.FindApplicantBtn = New System.Windows.Forms.Button
        Me.GradDatePicker = New System.Windows.Forms.NumericUpDown
        Me.LNameTextBox = New System.Windows.Forms.TextBox
        Me.FNameTextBox = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.SubjectComboBox = New System.Windows.Forms.ComboBox
        Me.CancelBtn = New System.Windows.Forms.Button
        CType(Me.GradDatePicker, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FindApplicantBtn
        '
        Me.FindApplicantBtn.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FindApplicantBtn.Location = New System.Drawing.Point(162, 114)
        Me.FindApplicantBtn.Name = "FindApplicantBtn"
        Me.FindApplicantBtn.Size = New System.Drawing.Size(72, 23)
        Me.FindApplicantBtn.TabIndex = 28
        Me.FindApplicantBtn.Text = "Search"
        Me.FindApplicantBtn.UseVisualStyleBackColor = True
        '
        'GradDatePicker
        '
        Me.GradDatePicker.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GradDatePicker.Location = New System.Drawing.Point(114, 70)
        Me.GradDatePicker.Maximum = New Decimal(New Integer() {9999, 0, 0, 0})
        Me.GradDatePicker.Minimum = New Decimal(New Integer() {1980, 0, 0, 0})
        Me.GradDatePicker.Name = "GradDatePicker"
        Me.GradDatePicker.Size = New System.Drawing.Size(109, 27)
        Me.GradDatePicker.TabIndex = 27
        Me.GradDatePicker.Value = New Decimal(New Integer() {1980, 0, 0, 0})
        '
        'LNameTextBox
        '
        Me.LNameTextBox.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LNameTextBox.Location = New System.Drawing.Point(175, 70)
        Me.LNameTextBox.Name = "LNameTextBox"
        Me.LNameTextBox.Size = New System.Drawing.Size(137, 27)
        Me.LNameTextBox.TabIndex = 26
        Me.LNameTextBox.Text = "Enter Last Name..."
        '
        'FNameTextBox
        '
        Me.FNameTextBox.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FNameTextBox.Location = New System.Drawing.Point(16, 70)
        Me.FNameTextBox.Name = "FNameTextBox"
        Me.FNameTextBox.Size = New System.Drawing.Size(131, 27)
        Me.FNameTextBox.TabIndex = 25
        Me.FNameTextBox.Text = "Enter First Name...."
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(135, 20)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "Find Applicant By:"
        '
        'SubjectComboBox
        '
        Me.SubjectComboBox.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SubjectComboBox.FormattingEnabled = True
        Me.SubjectComboBox.Items.AddRange(New Object() {"First Name", "Last Name", "Full Name", "Graduation Date"})
        Me.SubjectComboBox.Location = New System.Drawing.Point(175, 21)
        Me.SubjectComboBox.Name = "SubjectComboBox"
        Me.SubjectComboBox.Size = New System.Drawing.Size(121, 28)
        Me.SubjectComboBox.TabIndex = 23
        '
        'CancelBtn
        '
        Me.CancelBtn.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CancelBtn.Location = New System.Drawing.Point(240, 114)
        Me.CancelBtn.Name = "CancelBtn"
        Me.CancelBtn.Size = New System.Drawing.Size(72, 23)
        Me.CancelBtn.TabIndex = 29
        Me.CancelBtn.Text = "Cancel"
        Me.CancelBtn.UseVisualStyleBackColor = True
        '
        'FindApplicantToDelete
        '
        Me.AcceptButton = Me.FindApplicantBtn
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.CadetBlue
        Me.ClientSize = New System.Drawing.Size(337, 149)
        Me.Controls.Add(Me.CancelBtn)
        Me.Controls.Add(Me.FindApplicantBtn)
        Me.Controls.Add(Me.GradDatePicker)
        Me.Controls.Add(Me.LNameTextBox)
        Me.Controls.Add(Me.FNameTextBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.SubjectComboBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FindApplicantToDelete"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Delete Applicant - Search"
        CType(Me.GradDatePicker, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents FindApplicantBtn As System.Windows.Forms.Button
    Friend WithEvents GradDatePicker As System.Windows.Forms.NumericUpDown
    Friend WithEvents LNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents FNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents SubjectComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents CancelBtn As System.Windows.Forms.Button
End Class
