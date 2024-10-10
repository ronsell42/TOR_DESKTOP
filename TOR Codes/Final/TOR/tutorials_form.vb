Public Class tutorials_form
    Dim kill As Boolean = True

    Private Sub tutorials_form_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub addStudent_button_click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles addStudent_button.Click
        Process.Start("https://bit.ly/IBSMAtorTut_addStudent")
    End Sub
    Private Sub tutorials_form_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If kill = True Then

            e.Cancel = True
            exiting_form.Show()

        End If
    End Sub

    Private Sub back_button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles back_button.Click
        kill = False
        If backTo_label.Text = home_form.Name Then
            home_form.Show()
        ElseIf backTo_label.Text = dashboard_form.Name Then
            dashboard_form.Show()
        ElseIf backTo_label.Text = studentsInfo_form.Name Then
            studentsInfo_form.Show()
        ElseIf backTo_label.Text = subjects_form.Name Then
            subjects_form.Show()
        ElseIf backTo_label.Text = settings_form.Name Then
            settings_form.Show()
        End If
        Me.Close()
    End Sub

    Private Sub editStudent_button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles editStudent_button.Click
        Process.Start("https://bit.ly/IBSMAtorTut_editStudent")
    End Sub

    Private Sub deleteStudent_button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles deleteStudent_button.Click
        Process.Start("https://bit.ly/IBSMAtorTut_deleteStudent")
    End Sub

    Private Sub addStudentSubject_button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles addStudentSubject_button.Click
        Process.Start("https://bit.ly/IBSMAtorTut_addSS")
    End Sub

    Private Sub printTOR_button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles printTOR_button.Click
        Process.Start("https://bit.ly/IBSMAtorTut_printTOR")
    End Sub

    Private Sub addSubject_button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles addSubject_button.Click
        Process.Start("https://bit.ly/IBSMAtorTut_addSubj")
    End Sub

    Private Sub editSubject_button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles editSubject_button.Click
        Process.Start("https://bit.ly/IBSMAtorTut_editSubj")
    End Sub

    Private Sub deleteSubject_button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles deleteSubject_button.Click
        Process.Start("https://bit.ly/IBSMAtorTut_deleteSubj")
    End Sub

    Private Sub addUser_button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles addUser_button.Click
        Process.Start("https://bit.ly/IBSMAtorTut_addUser")
    End Sub

    Private Sub changePasswordOrUsername_button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles changePasswordOrUsername_button.Click
        Process.Start("https://bit.ly/IBSMAtorTut_modUser")
    End Sub

    Private Sub deleteUser_button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles deleteUser_button.Click
        Process.Start("https://bit.ly/IBSMAtorTut_deleteUser")
    End Sub

    Private Sub howToBackup_button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles howToBackup_button.Click
        Process.Start("https://bit.ly/IBSMAtorTut_backupDb")
    End Sub

    Private Sub howToRestore_button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles howToRestore_button.Click
        Process.Start("https://bit.ly/IBSMAtorTut_restoreDb")
    End Sub
End Class