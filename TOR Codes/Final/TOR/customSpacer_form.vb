Public Class customSpacer_form

    Private Sub StudentSubjectsBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.StudentSubjectsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.TORdbDataSet)

    End Sub

    Private Sub custom_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'TORdbDataSet.studentSubjects' table. You can move, or remove it, as needed.
        Me.StudentSubjectsTableAdapter.Fill(Me.TORdbDataSet.studentSubjects)

        Dim SYyear1 As String = Date.Now.ToString("yyyy")
        Dim SYyear2 As String = SYyear1 + 1
        Dim maxDrop1 As Integer = 28 'Equals to 20 MaxDropDownItems

        Do Until SYCBox.MaxDropDownItems = maxDrop1
            SYCBox.Items.Add(SYyear1 + "-" + SYyear2)
            SYyear1 = SYyear1 - 1
            SYyear2 = SYyear2 - 1
            SYCBox.MaxDropDownItems = SYCBox.MaxDropDownItems + 1
        Loop
    End Sub

    Private Sub saveBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles addBtn.Click
        StudentNoTextBox.Text = studentNum.Text
        SemTakenTextBox.Text = semCBox.Text
        YearTakenTextBox.Text = SYCBox.Text
        Try
            Me.Validate()
            Me.StudentSubjectsBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.TORdbDataSet)
            Me.StudentSubjectsTableAdapter.Fill(Me.TORdbDataSet.studentSubjects)

            customSpacingBtn.Text = "Add New Space"
            SYCBox.Enabled = False
            semCBox.Enabled = False
            addBtn.Enabled = False
            report_form.refreshBtn.Enabled = True
            report_form.refreshBtn.PerformClick()
            MsgBox("One space added.")
        Catch ex As Exception
            MsgBox("An unexpected error occured. Please try again.")
            report_form.refreshBtn.PerformClick()
        End Try
    End Sub

    Private Sub semCBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles semCBox.SelectedIndexChanged
        SemTakenTextBox.Text = semCBox.SelectedItem

        If semCBox.Text = "" Or SYCBox.Text = "" Then
            addBtn.Enabled = False
        Else
            addBtn.Enabled = True
        End If
    End Sub

    Private Sub SYCBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SYCBox.SelectedIndexChanged
        YearTakenTextBox.Text = SYCBox.Text
    End Sub

    Private Sub customSpacingBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles customSpacingBtn.Click
        If customSpacingBtn.Text = "Add New Space" Then
            report_form.refreshBtn.Enabled = False
            SYCBox.Enabled = True
            semCBox.Enabled = True


            StudentSubjectsBindingSource.AddNew()
            StudentNoTextBox.Text = studentNum.Text
            SubjectCodeTextBox.Text = " "
            SubjectNameTextBox.Text = " "
            GradeTextBox.Text = " "
            RemarksTextBox.Text = " "
            SemTakenTextBox.Text = semCBox.Text
            YearTakenTextBox.Text = SYCBox.Text
            FillerTextBox.Text = "True"
            customSpacingBtn.Text = "Cancel"

            If SYCBox.Text = "" Or semCBox.Text = "" Then
                addBtn.Enabled = False

            Else
                addBtn.Enabled = True
            End If
        Else
            StudentSubjectsBindingSource.RemoveCurrent()
            SYCBox.Enabled = False
            semCBox.Enabled = False
            addBtn.Enabled = False
            customSpacingBtn.Text = "Add New Space"
            report_form.refreshBtn.Enabled = True
        End If

    End Sub

    Private Sub revertBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles revertBtn.Click
        If MsgBox("Reverting will reset all your custom spaces. Click 'Yes' to continue.", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Me.StudentSubjectsTableAdapter.deleteFiller()
            report_form.refreshBtn.PerformClick()
            customSpacingBtn.Text = "Add New Space"
            SYCBox.Enabled = False
            semCBox.Enabled = False
            addBtn.Enabled = False
            report_form.refreshBtn.Enabled = True
        End If
    End Sub
End Class