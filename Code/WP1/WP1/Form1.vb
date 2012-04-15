Public Class TuitionAndFees
    'UnderGrad and Grad fees per hour
    Dim FeesPerCredit()() As Double = {New Double() {114, 131, 149, 166, 414, 431, 449, 467, 484, 501, 519, 536}, _
                                       New Double() {124, 147, 168, 190, 441, 463, 484, 507, 536}}
    Dim CreditPrice(10, 2, 4) As Double   'Pay per credit
    Dim CreditsCount As Integer           'Number of credits
    Dim Resident As Integer               '1 if Resident or 0 if nonresident
    Dim Graduate As Integer               '1 if Graduate or 0 if undergraduate
    Dim School As Integer                 'School selected
    Dim Tuition As Double                 'Tuition cost
    Dim Fees As Double                    'Fees cost
    Dim Computed As Boolean = 0           'Flag to determine if first computation accrued

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Set school selection to first school
        SchoolListBox.SelectedIndex = 0

        'Engineering or Computer Science - UnderGrad
        CreditPrice(0, 0, 0) = 515      'Nonresident
        CreditPrice(0, 0, 1) = 171      'Resident

        'Engineering or Computer Science - Grad
        CreditPrice(0, 1, 0) = 556      'Nonresident - 12 credits or less
        CreditPrice(0, 1, 1) = 255      'Resident - 12 credits or less
        CreditPrice(0, 1, 2) = 567      'Nonresident - more than 12 credits
        CreditPrice(0, 1, 3) = 375      'Resident - more than 12 credits

        'Fine and Performing Arts - UnderGrad
        CreditPrice(1, 0, 0) = 511      'Nonresident
        CreditPrice(1, 0, 1) = 141      'Resident

        'Fine and Performing Arts - Grad
        CreditPrice(1, 1, 0) = 552      'Nonresident - 12 credits or less
        CreditPrice(1, 1, 1) = 251      'Resident - 12 credits or less
        CreditPrice(1, 1, 2) = 563      'Nonresident - more than 12 credits
        CreditPrice(1, 1, 3) = 371      'Resident - more than 12 credits

        'Business - UnderGraduate
        CreditPrice(2, 0, 0) = 489      'Nonresident
        CreditPrice(2, 0, 1) = 147      'Resident

        'Business - Graduate Cohort A
        CreditPrice(3, 1, 0) = 604      'Nonresident - 12 credits or less
        CreditPrice(3, 1, 1) = 402      'Resident - 12 credits or less
        CreditPrice(3, 1, 2) = 615      'Nonresident - more than 12 credits
        CreditPrice(3, 1, 3) = 522      'Resident - more than 12 credits

        'Business - Graduate Cohort B
        CreditPrice(4, 1, 0) = 604      'Nonresident - 12 credits or less
        CreditPrice(4, 1, 1) = 332      'Resident - 12 credits or less
        CreditPrice(4, 1, 2) = 615      'Nonresident - more than 12 credits
        CreditPrice(4, 1, 3) = 452      'Resident - more than 12 credits

        'Business - Graduate Cohort C
        CreditPrice(5, 1, 0) = 604      'Nonresident - 12 credits or less
        CreditPrice(5, 1, 1) = 377      'Resident - 12 credits or less
        CreditPrice(5, 1, 2) = 615      'Nonresident - more than 12 credits
        CreditPrice(5, 1, 3) = 497      'Resident - more than 12 credits

        'Liberal Arts - Level 1
        CreditPrice(6, 1, 0) = 526      'Nonresident - 12 credits or less
        CreditPrice(6, 1, 1) = 229      'Resident - 12 credits or less
        CreditPrice(6, 1, 2) = 537      'Nonresident - more than 12 credits
        CreditPrice(6, 1, 3) = 349      'Resident - more than 12 credits

        'Liberal Arts - Level 2
        CreditPrice(7, 1, 0) = 536      'Nonresident - 12 credits or less
        CreditPrice(7, 1, 1) = 236      'Resident - 12 credits or less
        CreditPrice(7, 1, 2) = 547      'Nonresident - more than 12 credits
        CreditPrice(7, 1, 3) = 356      'Resident - more than 12 credits

        'Social Work - Distance Education
        CreditPrice(8, 1, 0) = 566      'Nonresident - 12 credits or less
        CreditPrice(8, 1, 1) = 269      'Resident - 12 credits or less
        CreditPrice(8, 1, 2) = 577      'Nonresident - more than 12 credits
        CreditPrice(8, 1, 3) = 389      'Resident - more than 12 credits

        'Other - Base Tuition UnderGrad
        CreditPrice(9, 0, 0) = 475      'Nonresident
        CreditPrice(9, 0, 1) = 136.8    'Resident

        'Other - Base Tuition Grad
        CreditPrice(9, 1, 0) = 511      'Nonresident - 12 credits or less
        CreditPrice(9, 1, 1) = 214      'Resident - 12 credits or less
        CreditPrice(9, 1, 2) = 522      'Nonresident - more than 12 credits
        CreditPrice(9, 1, 3) = 334      'Resident - more than 12 credits

    End Sub

    Private Sub SchoolListBox_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles SchoolListBox.SelectedIndexChanged
        'if school selection doesn't have graduate/undergraduate choice and radios buttons are enabled then disable them
        If SchoolListBox.SelectedIndex > 1 And SchoolListBox.SelectedIndex < 9 And UndergraduateRadioButton.Enabled = True Then
            UndergraduateRadioButton.Enabled = False
            GraduateRadioButton.Enabled = False

        'if school selection has graduate/undergraduate choice and radios buttons are disabled then enable them
        ElseIf (SchoolListBox.SelectedIndex < 2 Or SchoolListBox.SelectedIndex = 9) And UndergraduateRadioButton.Enabled = False Then
            UndergraduateRadioButton.Enabled = True
            GraduateRadioButton.Enabled = True
        End If

        'if first computation happened then compute based on this change
        If Computed = True Then
            ComputeTuition()
        End If
    End Sub

    Private Sub ComputeButton_Click(sender As System.Object, e As System.EventArgs) Handles ComputeButton.Click
        'when computed button is clicked computed total
        ComputeTuition()
    End Sub

    Sub ComputeTuition()
        'fees array length to know fees flat index
        Dim FeesArrayLen As Integer

        'checks credits number validity
        If Char.IsNumber(CreditsTextBox.Text) = False Then
            MsgBox("Please, enter a valid number of credits")
            Return
        End If
        CreditsCount = CreditsTextBox.Text

        'get selected school
        School = SchoolListBox.SelectedIndex

        'get if resident or non resident
        Resident = 0
        If ResidentRadioButton.Checked Then
            Resident = 1
        End If

        'get if graduate or undergraduate
        Graduate = 1
        If ((School < 2 Or School = 9) And GraduateRadioButton.Checked = False) Or (School = 2) Then
            Graduate = 0
        End If

        'calculate tuition
        If Graduate = 1 And CreditsCount > 12 Then
            Tuition = (12 * CreditPrice(School, Graduate, Resident + 2)) + ((CreditsCount - 12) * CreditPrice(School, Graduate, Resident))
        ElseIf Graduate = 1 And CreditsCount <= 12 Then
            Tuition = CreditsCount * CreditPrice(School, Graduate, Resident + 2)
        Else
            Tuition = CreditsCount * CreditPrice(School, Graduate, Resident)
        End If

        'calulate fees
        FeesArrayLen = UBound(FeesPerCredit(Graduate))
        If CreditsCount > FeesArrayLen Then
            Fees = FeesPerCredit(Graduate)(FeesArrayLen)
        Else
            Fees = FeesPerCredit(Graduate)(CreditsCount - 1)
        End If


        TuitionTextBox.Text = Tuition         'add tuition to tuition box
        FeesTextBox.Text = Fees               'add fees to fees box
        TotalTextBox.Text = Tuition + Fees    'add total to total box

        'if first computation happened then turn computed to true
        If Computed = False Then
            Computed = True
        End If
    End Sub

    Private Sub ResidentRadioButton_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles ResidentRadioButton.CheckedChanged
        'on resident radio button change, if not first computation then compute again
        If Computed = True Then
            ComputeTuition()
        End If
    End Sub

    Private Sub GraduateRadioButton_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles GraduateRadioButton.CheckedChanged
        'on graduate radio button change, if not first computation then compute again
        If Computed = True Then
            ComputeTuition()
        End If
    End Sub

    Private Sub CreditsTextBox_TextChanged(sender As System.Object, e As System.EventArgs) Handles CreditsTextBox.TextChanged
        'on credits count change, if not first computation then compute again
        If Char.IsNumber(CreditsTextBox.Text) And Computed = True Then
            ComputeTuition()
        End If
    End Sub
End Class
