<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddNewProgramDialog
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AddNewProgramDialog))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel
        Me.OK_Button = New System.Windows.Forms.Button
        Me.Cancel_Button = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.DegreeTextBox = New System.Windows.Forms.TextBox
        Me.MajorTextBox = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.SpecializationTextBox = New System.Windows.Forms.TextBox
        Me.SpecializationLabel = New System.Windows.Forms.Label
        Me.ShowSpecializationButton = New System.Windows.Forms.Button
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.31507!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.68493!))
        Me.TableLayoutPanel1.Controls.Add(Me.OK_Button, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Cancel_Button, 1, 0)
        Me.TableLayoutPanel1.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(399, 101)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(146, 29)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'OK_Button
        '
        Me.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.OK_Button.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.OK_Button.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.OK_Button.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OK_Button.Location = New System.Drawing.Point(3, 3)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(65, 23)
        Me.OK_Button.TabIndex = 4
        Me.OK_Button.Text = "OK"
        Me.OK_Button.UseVisualStyleBackColor = False
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Cancel_Button.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cancel_Button.Location = New System.Drawing.Point(75, 3)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(67, 23)
        Me.Cancel_Button.TabIndex = 5
        Me.Cancel_Button.Text = "Cancel"
        Me.Cancel_Button.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(119, 19)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Type of Degree:"
        '
        'DegreeTextBox
        '
        Me.DegreeTextBox.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DegreeTextBox.Location = New System.Drawing.Point(16, 50)
        Me.DegreeTextBox.Name = "DegreeTextBox"
        Me.DegreeTextBox.Size = New System.Drawing.Size(122, 26)
        Me.DegreeTextBox.TabIndex = 1
        '
        'MajorTextBox
        '
        Me.MajorTextBox.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MajorTextBox.Location = New System.Drawing.Point(189, 50)
        Me.MajorTextBox.Name = "MajorTextBox"
        Me.MajorTextBox.Size = New System.Drawing.Size(122, 26)
        Me.MajorTextBox.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(185, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 19)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Major:"
        '
        'SpecializationTextBox
        '
        Me.SpecializationTextBox.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SpecializationTextBox.Location = New System.Drawing.Point(358, 50)
        Me.SpecializationTextBox.Name = "SpecializationTextBox"
        Me.SpecializationTextBox.Size = New System.Drawing.Size(122, 26)
        Me.SpecializationTextBox.TabIndex = 3
        '
        'SpecializationLabel
        '
        Me.SpecializationLabel.AutoSize = True
        Me.SpecializationLabel.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SpecializationLabel.Location = New System.Drawing.Point(354, 19)
        Me.SpecializationLabel.Name = "SpecializationLabel"
        Me.SpecializationLabel.Size = New System.Drawing.Size(107, 19)
        Me.SpecializationLabel.TabIndex = 5
        Me.SpecializationLabel.Text = "Specialization:"
        '
        'ShowSpecializationButton
        '
        Me.ShowSpecializationButton.Location = New System.Drawing.Point(467, 18)
        Me.ShowSpecializationButton.Name = "ShowSpecializationButton"
        Me.ShowSpecializationButton.Size = New System.Drawing.Size(30, 23)
        Me.ShowSpecializationButton.TabIndex = 6
        Me.ShowSpecializationButton.Text = ">>"
        Me.ShowSpecializationButton.UseVisualStyleBackColor = True
        '
        'AddNewProgramDialog
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.CadetBlue
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(557, 148)
        Me.Controls.Add(Me.ShowSpecializationButton)
        Me.Controls.Add(Me.SpecializationTextBox)
        Me.Controls.Add(Me.SpecializationLabel)
        Me.Controls.Add(Me.MajorTextBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DegreeTextBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "AddNewProgramDialog"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add A New Degree Program"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DegreeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents MajorTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents SpecializationTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SpecializationLabel As System.Windows.Forms.Label
    Friend WithEvents ShowSpecializationButton As System.Windows.Forms.Button

End Class
