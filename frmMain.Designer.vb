<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.grpWhatIsYourNeed = New System.Windows.Forms.GroupBox()
        Me.radNeed5 = New System.Windows.Forms.RadioButton()
        Me.radNeed4 = New System.Windows.Forms.RadioButton()
        Me.radNeed3 = New System.Windows.Forms.RadioButton()
        Me.radNeed2 = New System.Windows.Forms.RadioButton()
        Me.radNeed1 = New System.Windows.Forms.RadioButton()
        Me.txtVerse = New System.Windows.Forms.TextBox()
        Me.chkDisplayIns = New System.Windows.Forms.CheckBox()
        Me.lblCount = New System.Windows.Forms.Label()
        Me.lblDisplay = New System.Windows.Forms.Label()
        Me.btnShowVerse = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.lblInsDisplay = New System.Windows.Forms.Label()
        Me.grpWhatIsYourNeed.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpWhatIsYourNeed
        '
        Me.grpWhatIsYourNeed.Controls.Add(Me.radNeed5)
        Me.grpWhatIsYourNeed.Controls.Add(Me.radNeed4)
        Me.grpWhatIsYourNeed.Controls.Add(Me.radNeed3)
        Me.grpWhatIsYourNeed.Controls.Add(Me.radNeed2)
        Me.grpWhatIsYourNeed.Controls.Add(Me.radNeed1)
        Me.grpWhatIsYourNeed.Location = New System.Drawing.Point(59, 42)
        Me.grpWhatIsYourNeed.Name = "grpWhatIsYourNeed"
        Me.grpWhatIsYourNeed.Size = New System.Drawing.Size(200, 244)
        Me.grpWhatIsYourNeed.TabIndex = 0
        Me.grpWhatIsYourNeed.TabStop = False
        Me.grpWhatIsYourNeed.Text = "What is your need?"
        '
        'radNeed5
        '
        Me.radNeed5.AutoSize = True
        Me.radNeed5.Location = New System.Drawing.Point(19, 203)
        Me.radNeed5.Name = "radNeed5"
        Me.radNeed5.Size = New System.Drawing.Size(104, 20)
        Me.radNeed5.TabIndex = 4
        Me.radNeed5.TabStop = True
        Me.radNeed5.Text = "Compassion"
        Me.radNeed5.UseVisualStyleBackColor = True
        '
        'radNeed4
        '
        Me.radNeed4.AutoSize = True
        Me.radNeed4.Location = New System.Drawing.Point(19, 165)
        Me.radNeed4.Name = "radNeed4"
        Me.radNeed4.Size = New System.Drawing.Size(123, 20)
        Me.radNeed4.TabIndex = 3
        Me.radNeed4.TabStop = True
        Me.radNeed4.Text = "Encouragement"
        Me.radNeed4.UseVisualStyleBackColor = True
        '
        'radNeed3
        '
        Me.radNeed3.AutoSize = True
        Me.radNeed3.Location = New System.Drawing.Point(19, 121)
        Me.radNeed3.Name = "radNeed3"
        Me.radNeed3.Size = New System.Drawing.Size(75, 20)
        Me.radNeed3.TabIndex = 2
        Me.radNeed3.TabStop = True
        Me.radNeed3.Text = "Humility"
        Me.radNeed3.UseVisualStyleBackColor = True
        '
        'radNeed2
        '
        Me.radNeed2.AutoSize = True
        Me.radNeed2.Location = New System.Drawing.Point(19, 76)
        Me.radNeed2.Name = "radNeed2"
        Me.radNeed2.Size = New System.Drawing.Size(86, 20)
        Me.radNeed2.TabIndex = 1
        Me.radNeed2.TabStop = True
        Me.radNeed2.Text = "Guidance"
        Me.radNeed2.UseVisualStyleBackColor = True
        '
        'radNeed1
        '
        Me.radNeed1.AutoSize = True
        Me.radNeed1.Location = New System.Drawing.Point(19, 34)
        Me.radNeed1.Name = "radNeed1"
        Me.radNeed1.Size = New System.Drawing.Size(95, 20)
        Me.radNeed1.TabIndex = 0
        Me.radNeed1.TabStop = True
        Me.radNeed1.Text = "Knowledge"
        Me.radNeed1.UseVisualStyleBackColor = True
        '
        'txtVerse
        '
        Me.txtVerse.Location = New System.Drawing.Point(363, 42)
        Me.txtVerse.Multiline = True
        Me.txtVerse.Name = "txtVerse"
        Me.txtVerse.Size = New System.Drawing.Size(395, 210)
        Me.txtVerse.TabIndex = 8
        Me.txtVerse.TabStop = False
        Me.txtVerse.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'chkDisplayIns
        '
        Me.chkDisplayIns.AutoSize = True
        Me.chkDisplayIns.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.chkDisplayIns.Location = New System.Drawing.Point(472, 16)
        Me.chkDisplayIns.Name = "chkDisplayIns"
        Me.chkDisplayIns.Size = New System.Drawing.Size(120, 20)
        Me.chkDisplayIns.TabIndex = 2
        Me.chkDisplayIns.Text = "Include Contact"
        Me.chkDisplayIns.UseVisualStyleBackColor = True
        '
        'lblCount
        '
        Me.lblCount.AutoSize = True
        Me.lblCount.Location = New System.Drawing.Point(211, 357)
        Me.lblCount.Name = "lblCount"
        Me.lblCount.Size = New System.Drawing.Size(104, 16)
        Me.lblCount.TabIndex = 5
        Me.lblCount.Text = "Number of Visits"
        '
        'lblDisplay
        '
        Me.lblDisplay.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDisplay.Location = New System.Drawing.Point(343, 318)
        Me.lblDisplay.Name = "lblDisplay"
        Me.lblDisplay.Size = New System.Drawing.Size(103, 84)
        Me.lblDisplay.TabIndex = 6
        Me.lblDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnShowVerse
        '
        Me.btnShowVerse.Location = New System.Drawing.Point(59, 348)
        Me.btnShowVerse.Name = "btnShowVerse"
        Me.btnShowVerse.Size = New System.Drawing.Size(75, 54)
        Me.btnShowVerse.TabIndex = 1
        Me.btnShowVerse.Text = "&Show Verse"
        Me.btnShowVerse.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(669, 290)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 51)
        Me.btnClear.TabIndex = 3
        Me.btnClear.Text = "&Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(669, 367)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 47)
        Me.btnClose.TabIndex = 4
        Me.btnClose.Text = "Clos&e"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'lblInsDisplay
        '
        Me.lblInsDisplay.Location = New System.Drawing.Point(492, 269)
        Me.lblInsDisplay.Name = "lblInsDisplay"
        Me.lblInsDisplay.Size = New System.Drawing.Size(100, 72)
        Me.lblInsDisplay.TabIndex = 7
        Me.lblInsDisplay.Text = "Benjamin Andrews" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Prof. Dyer" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.lblInsDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblInsDisplay.Visible = False
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblInsDisplay)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnShowVerse)
        Me.Controls.Add(Me.lblDisplay)
        Me.Controls.Add(Me.lblCount)
        Me.Controls.Add(Me.chkDisplayIns)
        Me.Controls.Add(Me.txtVerse)
        Me.Controls.Add(Me.grpWhatIsYourNeed)
        Me.Name = "frmMain"
        Me.Text = "Bible Verse"
        Me.grpWhatIsYourNeed.ResumeLayout(False)
        Me.grpWhatIsYourNeed.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents grpWhatIsYourNeed As GroupBox
    Friend WithEvents radNeed5 As RadioButton
    Friend WithEvents radNeed4 As RadioButton
    Friend WithEvents radNeed3 As RadioButton
    Friend WithEvents radNeed2 As RadioButton
    Friend WithEvents radNeed1 As RadioButton
    Friend WithEvents txtVerse As TextBox
    Friend WithEvents chkDisplayIns As CheckBox
    Friend WithEvents lblCount As Label
    Friend WithEvents lblDisplay As Label
    Friend WithEvents btnShowVerse As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents lblInsDisplay As Label
End Class
