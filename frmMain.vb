' Variables and Decisions Programming Assignment.
' Display Bible verses that relates to a user selected need.
' Benjamin Andrews


' I will not use code that was never covered in class or in our textbook.
' If you do you must be able to explain your code when asked by the professor.
' Using code outside of the resources provided, it can be flagged and reported as an academic integrity violation if there is any suspicion of copying/cheating.


Public Class frmMain
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click

        'Closes the application.
        Me.Close()

    End Sub

    Private Sub btnShowVerse_Click(sender As Object, e As EventArgs) Handles btnShowVerse.Click
        'Declare variables for use in case statement.

        Dim strproverbs1_7 As String = "The fear of the Lord is the beginning of knowledge; fools despise wisdom and discipline."
        Dim strproverbs13_24 As String = "The one who will not use the rod hates his son, but the one who loves him disciplines him diligently."
        Dim strproverbs18_12 As String = "Before his downfall a person's heart is proud, but humility comes before honor."
        Dim strproverbs27_17 As String = "Iron sharpens iron, and one person sharpens another."
        Dim strproverbs10_12 As String = "Hatred stirs up conflicts, but love covers all offenses."

        ' Declare variables for counter

        Static intcombined As Integer

        ' Case statement for displaying text

        Select Case True
            Case radNeed1.Checked
                txtVerse.Text = strproverbs1_7
            Case radNeed2.Checked
                txtVerse.Text = strproverbs13_24
            Case radNeed3.Checked
                txtVerse.Text = strproverbs18_12
            Case radNeed4.Checked
                txtVerse.Text = strproverbs27_17
            Case radNeed5.Checked
                txtVerse.Text = strproverbs10_12
            Case Else
                MessageBox.Show("Select a Need")
                Return
        End Select

        ' Display instructor information.

        If chkDisplayIns.Checked = True Then
            lblInsDisplay.Show()
        ElseIf chkDisplayIns.Checked = False Then
            lblInsDisplay.Hide()

        End If


        ' Statement for counter.

        intcombined = intcombined + 1

        ' Display counter.

        lblDisplay.Text = intcombined.ToString()

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'Clear contents of text box.

        txtVerse.Text = String.Empty

        ' Clear count display

        lblDisplay.Text = String.Empty

        ' Clear radio buttons

        radNeed1.Checked = False
        radNeed2.Checked = False
        radNeed3.Checked = False
        radNeed4.Checked = False
        radNeed5.Checked = False

        ' Clear checkbox and hide contact label

        lblInsDisplay.Hide()
        chkDisplayIns.Checked = False



    End Sub
End Class
