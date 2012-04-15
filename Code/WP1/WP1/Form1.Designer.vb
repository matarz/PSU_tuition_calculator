<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TuitionAndFees
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
        Me.ComputeButton = New System.Windows.Forms.Button()
        Me.UndergraduateRadioButton = New System.Windows.Forms.RadioButton()
        Me.GraduateRadioButton = New System.Windows.Forms.RadioButton()
        Me.CreditsLabel = New System.Windows.Forms.Label()
        Me.SchoolListBox = New System.Windows.Forms.ListBox()
        Me.TotalTextBox = New System.Windows.Forms.TextBox()
        Me.TuitionTextBox = New System.Windows.Forms.TextBox()
        Me.FeesTextBox = New System.Windows.Forms.TextBox()
        Me.TuitionLabel = New System.Windows.Forms.Label()
        Me.FeesLabel = New System.Windows.Forms.Label()
        Me.TotalLabel = New System.Windows.Forms.Label()
        Me.SelectYourSchoolLabel = New System.Windows.Forms.Label()
        Me.ResidentRadioButton = New System.Windows.Forms.RadioButton()
        Me.NonresidentRadioButton = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.CreditsTextBox = New System.Windows.Forms.TextBox()
        Me.GradLevel = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GradLevel.SuspendLayout()
        Me.SuspendLayout()
        '
        'ComputeButton
        '
        Me.ComputeButton.Location = New System.Drawing.Point(332, 240)
        Me.ComputeButton.Name = "ComputeButton"
        Me.ComputeButton.Size = New System.Drawing.Size(69, 54)
        Me.ComputeButton.TabIndex = 0
        Me.ComputeButton.Text = "Compute Tution + Fees"
        Me.ComputeButton.UseVisualStyleBackColor = True
        '
        'UndergraduateRadioButton
        '
        Me.UndergraduateRadioButton.AutoSize = True
        Me.UndergraduateRadioButton.Checked = True
        Me.UndergraduateRadioButton.Location = New System.Drawing.Point(6, 10)
        Me.UndergraduateRadioButton.Name = "UndergraduateRadioButton"
        Me.UndergraduateRadioButton.Size = New System.Drawing.Size(96, 17)
        Me.UndergraduateRadioButton.TabIndex = 3
        Me.UndergraduateRadioButton.TabStop = True
        Me.UndergraduateRadioButton.Text = "Undergraduate"
        Me.UndergraduateRadioButton.UseVisualStyleBackColor = True
        '
        'GraduateRadioButton
        '
        Me.GraduateRadioButton.AutoSize = True
        Me.GraduateRadioButton.Location = New System.Drawing.Point(6, 27)
        Me.GraduateRadioButton.Name = "GraduateRadioButton"
        Me.GraduateRadioButton.Size = New System.Drawing.Size(69, 17)
        Me.GraduateRadioButton.TabIndex = 4
        Me.GraduateRadioButton.Text = "Graduate"
        Me.GraduateRadioButton.UseVisualStyleBackColor = True
        '
        'CreditsLabel
        '
        Me.CreditsLabel.AutoSize = True
        Me.CreditsLabel.Location = New System.Drawing.Point(296, 174)
        Me.CreditsLabel.Name = "CreditsLabel"
        Me.CreditsLabel.Size = New System.Drawing.Size(39, 13)
        Me.CreditsLabel.TabIndex = 6
        Me.CreditsLabel.Text = "Credits"
        '
        'SchoolListBox
        '
        Me.SchoolListBox.FormattingEnabled = True
        Me.SchoolListBox.Items.AddRange(New Object() {"Engineering or Computer Science", "Fine and Performing Arts", "Business - Undergraduate", "Business - Graduate Cohort A", "Business - Graduate Cohort B", "Business - Graduate Cohort C", "Liberal Arts - Level 1", "Liberal Arts - Level 2", "Social Work - Distance Education", "Other"})
        Me.SchoolListBox.Location = New System.Drawing.Point(15, 44)
        Me.SchoolListBox.Name = "SchoolListBox"
        Me.SchoolListBox.Size = New System.Drawing.Size(219, 147)
        Me.SchoolListBox.TabIndex = 7
        '
        'TotalTextBox
        '
        Me.TotalTextBox.Location = New System.Drawing.Point(57, 274)
        Me.TotalTextBox.Name = "TotalTextBox"
        Me.TotalTextBox.Size = New System.Drawing.Size(100, 20)
        Me.TotalTextBox.TabIndex = 8
        '
        'TuitionTextBox
        '
        Me.TuitionTextBox.Location = New System.Drawing.Point(57, 222)
        Me.TuitionTextBox.Name = "TuitionTextBox"
        Me.TuitionTextBox.Size = New System.Drawing.Size(100, 20)
        Me.TuitionTextBox.TabIndex = 9
        '
        'FeesTextBox
        '
        Me.FeesTextBox.Location = New System.Drawing.Point(57, 248)
        Me.FeesTextBox.Name = "FeesTextBox"
        Me.FeesTextBox.Size = New System.Drawing.Size(100, 20)
        Me.FeesTextBox.TabIndex = 10
        '
        'TuitionLabel
        '
        Me.TuitionLabel.AutoSize = True
        Me.TuitionLabel.Location = New System.Drawing.Point(12, 225)
        Me.TuitionLabel.Name = "TuitionLabel"
        Me.TuitionLabel.Size = New System.Drawing.Size(39, 13)
        Me.TuitionLabel.TabIndex = 11
        Me.TuitionLabel.Text = "Tuition"
        '
        'FeesLabel
        '
        Me.FeesLabel.AutoSize = True
        Me.FeesLabel.Location = New System.Drawing.Point(12, 251)
        Me.FeesLabel.Name = "FeesLabel"
        Me.FeesLabel.Size = New System.Drawing.Size(30, 13)
        Me.FeesLabel.TabIndex = 12
        Me.FeesLabel.Text = "Fees"
        '
        'TotalLabel
        '
        Me.TotalLabel.AutoSize = True
        Me.TotalLabel.Location = New System.Drawing.Point(12, 277)
        Me.TotalLabel.Name = "TotalLabel"
        Me.TotalLabel.Size = New System.Drawing.Size(31, 13)
        Me.TotalLabel.TabIndex = 13
        Me.TotalLabel.Text = "Total"
        '
        'SelectYourSchoolLabel
        '
        Me.SelectYourSchoolLabel.AutoSize = True
        Me.SelectYourSchoolLabel.Location = New System.Drawing.Point(12, 28)
        Me.SelectYourSchoolLabel.Name = "SelectYourSchoolLabel"
        Me.SelectYourSchoolLabel.Size = New System.Drawing.Size(98, 13)
        Me.SelectYourSchoolLabel.TabIndex = 14
        Me.SelectYourSchoolLabel.Text = "Select Your School"
        '
        'ResidentRadioButton
        '
        Me.ResidentRadioButton.AutoSize = True
        Me.ResidentRadioButton.Checked = True
        Me.ResidentRadioButton.Location = New System.Drawing.Point(6, 11)
        Me.ResidentRadioButton.Name = "ResidentRadioButton"
        Me.ResidentRadioButton.Size = New System.Drawing.Size(67, 17)
        Me.ResidentRadioButton.TabIndex = 1
        Me.ResidentRadioButton.TabStop = True
        Me.ResidentRadioButton.Text = "Resident"
        Me.ResidentRadioButton.UseVisualStyleBackColor = True
        '
        'NonresidentRadioButton
        '
        Me.NonresidentRadioButton.AutoSize = True
        Me.NonresidentRadioButton.Location = New System.Drawing.Point(6, 27)
        Me.NonresidentRadioButton.Name = "NonresidentRadioButton"
        Me.NonresidentRadioButton.Size = New System.Drawing.Size(82, 17)
        Me.NonresidentRadioButton.TabIndex = 2
        Me.NonresidentRadioButton.Text = "Nonresident"
        Me.NonresidentRadioButton.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.NonresidentRadioButton)
        Me.GroupBox1.Controls.Add(Me.ResidentRadioButton)
        Me.GroupBox1.Location = New System.Drawing.Point(293, 44)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(108, 55)
        Me.GroupBox1.TabIndex = 15
        Me.GroupBox1.TabStop = False
        '
        'CreditsTextBox
        '
        Me.CreditsTextBox.Location = New System.Drawing.Point(341, 171)
        Me.CreditsTextBox.Name = "CreditsTextBox"
        Me.CreditsTextBox.Size = New System.Drawing.Size(36, 20)
        Me.CreditsTextBox.TabIndex = 16
        '
        'GradLevel
        '
        Me.GradLevel.Controls.Add(Me.GraduateRadioButton)
        Me.GradLevel.Controls.Add(Me.UndergraduateRadioButton)
        Me.GradLevel.Location = New System.Drawing.Point(293, 105)
        Me.GradLevel.Name = "GradLevel"
        Me.GradLevel.Size = New System.Drawing.Size(108, 55)
        Me.GradLevel.TabIndex = 17
        Me.GradLevel.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(306, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(118, 13)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Zakaria Almatar, WP#1"
        '
        'TuitionAndFees
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(420, 310)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GradLevel)
        Me.Controls.Add(Me.CreditsTextBox)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.SelectYourSchoolLabel)
        Me.Controls.Add(Me.TotalLabel)
        Me.Controls.Add(Me.FeesLabel)
        Me.Controls.Add(Me.TuitionLabel)
        Me.Controls.Add(Me.FeesTextBox)
        Me.Controls.Add(Me.TuitionTextBox)
        Me.Controls.Add(Me.TotalTextBox)
        Me.Controls.Add(Me.SchoolListBox)
        Me.Controls.Add(Me.CreditsLabel)
        Me.Controls.Add(Me.ComputeButton)
        Me.Name = "TuitionAndFees"
        Me.Text = "Tuition and Fees"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GradLevel.ResumeLayout(False)
        Me.GradLevel.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ComputeButton As System.Windows.Forms.Button
    Friend WithEvents UndergraduateRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents GraduateRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents CreditsLabel As System.Windows.Forms.Label
    Friend WithEvents SchoolListBox As System.Windows.Forms.ListBox
    Friend WithEvents TotalTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TuitionTextBox As System.Windows.Forms.TextBox
    Friend WithEvents FeesTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TuitionLabel As System.Windows.Forms.Label
    Friend WithEvents FeesLabel As System.Windows.Forms.Label
    Friend WithEvents TotalLabel As System.Windows.Forms.Label
    Friend WithEvents SelectYourSchoolLabel As System.Windows.Forms.Label
    Friend WithEvents ResidentRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents NonresidentRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents CreditsTextBox As System.Windows.Forms.TextBox
    Friend WithEvents GradLevel As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label

End Class
