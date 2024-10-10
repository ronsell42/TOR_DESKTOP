Public Class home_form

    Dim kill As Boolean = True

    Private Sub dashboard_Mousemove(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dashboardBtn.MouseMove, dashboard_lbl.MouseMove, dashboard_desc.MouseMove
        dashboardBtn.FlatAppearance.BorderColor = Color.Silver
    End Sub

    Private Sub dashboard_Mouseleave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dashboardBtn.MouseLeave
        dashboardBtn.FlatAppearance.BorderColor = Color.FromKnownColor(KnownColor.Control)
    End Sub

    Private Sub students_Mousemove(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles studentsBtn.MouseMove, students_lbl.MouseMove, students_desc.MouseMove
        studentsBtn.FlatAppearance.BorderColor = Color.Silver
    End Sub

    Private Sub students_Mouseleave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles studentsBtn.MouseLeave
        studentsBtn.FlatAppearance.BorderColor = Color.FromKnownColor(KnownColor.Control)
    End Sub

    Private Sub subjects_Mousemove(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles subjectsBtn.MouseMove, subjects_lbl.MouseMove, subjects_desc.MouseMove
        subjectsBtn.FlatAppearance.BorderColor = Color.Silver
    End Sub

    Private Sub subjects_Mouseleave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles subjectsBtn.MouseLeave
        subjectsBtn.FlatAppearance.BorderColor = Color.FromKnownColor(KnownColor.Control)
    End Sub



    Private Sub settings_Mousemove(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles settingsBtn.MouseMove, settings_lbl.MouseMove, settings_desc.MouseMove
        settingsBtn.FlatAppearance.BorderColor = Color.Silver
    End Sub

    Private Sub settings_Mouseleave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles settingsBtn.MouseLeave
        settingsBtn.FlatAppearance.BorderColor = Color.FromKnownColor(KnownColor.Control)
    End Sub


    Private Sub help_Mousemove(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tutorials_button.MouseMove, tutorials_label.MouseMove, tutorials_desc.MouseMove
        tutorials_button.FlatAppearance.BorderColor = Color.Silver
    End Sub

    Private Sub help_Mouseleave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tutorials_button.MouseLeave
        tutorials_button.FlatAppearance.BorderColor = Color.FromKnownColor(KnownColor.Control)
    End Sub

    Private Sub dashboardBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dashboardBtn.Click, dashboard_lbl.Click, dashboard_desc.Click
        dashboard_form.Show()
        dashboard_form.Left = Me.Left
        dashboard_form.Top = Me.Top
        kill = False
        Me.Close()
    End Sub

    Private Sub studentsBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles studentsBtn.Click, students_lbl.Click, students_desc.Click
        studentsInfo_form.Show()
        studentsInfo_form.Left = Me.Left
        studentsInfo_form.Top = Me.Top
        kill = False
        Me.Close()
    End Sub

    Private Sub subjectsBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles subjectsBtn.Click, subjects_lbl.Click, subjects_desc.Click
        subjects_form.Show()
        subjects_form.Left = Me.Left
        subjects_form.Top = Me.Top
        kill = False
        Me.Close()
    End Sub

    Private Sub settingsBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles settingsBtn.Click, settings_lbl.Click, settings_desc.Click
        access_form.Show()
        access_form.action_lbl.Text = "go_to_settings"
        access_form.message_lbl.Text = "Do you want to open Settings?"
        access_form.previousForm_label.Text = Me.Name
        access_form.password1.Focus()
    End Sub


    Private Sub user_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles user.TextChanged

    End Sub

    Private Sub logout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles logout.Click
        If MsgBox("Are you sure you want to logout?", MsgBoxStyle.YesNo, "Login") = MsgBoxResult.Yes Then
            login_form.Show()
            login_form.user1.ResetText()
            login_form.password1.ResetText()
            login_form.TextBox1.ResetText()
            login_form.TextBox1.Visible = False
            login_form.ProgressBar1.Visible = False
            login_form.ProgressBar1.Value = 1
            login_form.Label2.Visible = False
            login_form.cancelBtn.Visible = False
            kill = False
            Me.Close()
        Else
            'do nothing
        End If
    End Sub

    Private Sub home_main_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        If kill = True Then
            splashScreen_form.Close()
        Else
            'do nothing
        End If
    End Sub

    Private Sub home_main_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If kill = True Then
            e.Cancel = True
            exiting_form.Show()
        Else
            'do nothing
        End If
    End Sub

    Private Sub settingsSecret_button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles settingsSecret_button.Click
        settings_form.Show()
        settings_form.Left = Me.Left
        settings_form.Top = Me.Top
        kill = False
        Me.Close()
    End Sub

    Private Sub home_form_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        user.Text = splashScreen_form.version_label.Text
    End Sub

    Private Sub helpBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tutorials_button.Click, tutorials_label.Click, tutorials_desc.Click
        tutorials_form.Show()
        tutorials_form.backTo_label.Text = Me.Name
        tutorials_form.Left = Me.Left
        tutorials_form.Top = Me.Top
        kill = False
        Me.Close()
    End Sub

End Class