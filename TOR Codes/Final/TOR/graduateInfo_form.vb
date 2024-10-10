Public Class graduateInfo_form

    Private Sub cancelBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cancelBtn.Click
        If Me.changePicLbl.Text = "True" Then ' picture changed
            studentsInfo_form.Show()
            studentsInfo_form.Enabled = True
            Me.Close()

            studentsInfo_form.Enabled = True

        ElseIf Me.changePicLbl.Text = "False" Then 'just add a picture
            studentsInfo_form.Show()
            studentsInfo_form.Enabled = True
            Me.Close()

            studentsInfo_form.graduateCheckBox.Checked = False

        End If

    End Sub

    Private Sub save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles save.Click
        studentsInfo_form.Enabled = True
        studentsInfo_form.Show()

        studentsInfo_form.SoNoTextBox.Text = Me.SoNoTextBox.Text

        studentsInfo_form.sinfo18.Value = Me.sinfo18.Value
        studentsInfo_form.sinfo18.Value = Me.sinfo18.Value
        studentsInfo_form.sinfo19.Value = Me.sinfo19.Value
        studentsInfo_form.sinfo19.Value = Me.sinfo19.Value


        Me.Hide()
        studentsInfo_form.editBtn.PerformClick()

        Me.Close()
    End Sub


    Private Sub changePicture_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'TODO: This line of code loads data into the 'TORdbDataSet.studentsInfo' table. You can move, or remove it, as needed.
        Me.StudentsInfoTableAdapter.Fill(Me.TORdbDataSet.studentsInfo)

    End Sub

    Private Sub sinfo17_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sinfo17.TextChanged
        SoNoTextBox.Text = sinfo17.Text

        If sinfo17.Text = "" Then
            save.Enabled = False
            If changePicLbl.Text = "False" Then

                rf2.Visible = True

                sinfo17.Enabled = False
                sinfo18.Enabled = False
                sinfo19.Enabled = False
            Else

                rf2.Visible = True
                sinfo17.Enabled = True
                sinfo18.Enabled = True
                sinfo19.Enabled = True
            End If

        Else
            save.Enabled = True

            rf2.Visible = False
            sinfo17.Enabled = True
            sinfo18.Enabled = True
            sinfo19.Enabled = True

            sinfo18.Value = DateTimePicker1.Value
            sinfo18.Value = Date.Now()
            sinfo19.Value = DateTimePicker1.Value
            sinfo19.Value = Date.Now()
        End If

    End Sub

    Private Sub SoNoTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SoNoTextBox.TextChanged
        sinfo17.Text = SoNoTextBox.text

    End Sub

    Private Sub DatedDateTimePicker_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DatedDateTimePicker.ValueChanged
        sinfo18.Value = DatedDateTimePicker.Value
    End Sub

    Private Sub DateOfGradDateTimePicker_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateOfGradDateTimePicker.ValueChanged
        sinfo19.Value = DateOfGradDateTimePicker.Value
    End Sub

    Private Sub sinfo18_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sinfo18.ValueChanged
        DatedDateTimePicker.Value = sinfo18.Value
    End Sub

    Private Sub sinfo19_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sinfo19.ValueChanged
        DateOfGradDateTimePicker.Value = sinfo19.Value
    End Sub

    Private Sub studentNoLbl_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles studentNoLbl.TextChanged
        Me.StudentsInfoTableAdapter.filterInfo(Me.TORdbDataSet.studentsInfo, studentNoLbl.Text)
    End Sub

End Class