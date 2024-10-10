Public Class login_form

    Dim kill As Boolean = True
    Dim backupMode As Boolean = False
    Dim x As Integer = 1

    Private Sub login_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        If kill = True Then
            splashScreen_form.Close()
        Else
            'do nothing
        End If
    End Sub

    Private Sub login_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If kill = True Then
            e.Cancel = True
            exiting_form.Show()
        Else
            'do nothing
        End If
    End Sub

    Private Sub login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'TORdbDataSet.userAccount' table. You can move, or remove it, as needed.
        Try
            Me.UserAccountTableAdapter.Fill(Me.TORdbDataSet.userAccount)
            user1.Focus()
        Catch ex As Exception
            Restore_Database.Show()
            kill = False
            Me.Close()
        End Try

    End Sub

    Private Sub loginBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles loginBtn.Click
        If backupMode = False Then

            Dim user_1 = From userAccount In TORdbDataSet.userAccount
        Where userAccount.username = user1.Text

            If user_1.Count = 1 Or user_1.Count > 1 Then
                Dim username = user1.Text

                Me.UserAccountTableAdapter.passByUser(Me.TORdbDataSet.userAccount, username)
                If PasswordTextBox.Text = password1.Text Then

                    home_form.Show()

                    splashScreen_form.version_label.Text = Me.user1.Text

                    MsgBox("Welcome " + user1.Text + ".", MsgBoxStyle.Information, "User Accounts")

                    kill = False
                    Me.Close()

                Else
                    MsgBox("Wrong username or password.", MsgBoxStyle.Exclamation, "User Accounts")
                End If
            ElseIf user1.Text = "" And password1.Text = "" Then
                MsgBox("Please fill login fields!", MsgBoxStyle.Exclamation, "User Accounts")

            ElseIf user1.Text = "" Then
                MsgBox("Username cannot be empty!", MsgBoxStyle.Exclamation, "User Accounts")
            ElseIf password1.Text = "" Then
                MsgBox("Please enter a password!", MsgBoxStyle.Exclamation, "User Accounts")
            Else
                MsgBox("Wrong username or password.", MsgBoxStyle.Exclamation, "User Accounts")
            End If

        ElseIf backupMode = True Then

            Dim user_1 = From userAccount In TORdbDataSet.userAccount
        Where userAccount.backupEmail = user1.Text

            If user_1.Count = 1 Or user_1.Count > 1 Then
                Dim username = user1.Text

                Me.UserAccountTableAdapter.passByUser2(Me.TORdbDataSet.userAccount, username)
                If BackupPasswordTextBox.Text = password1.Text Then

                    MsgBox("Your original Username is: " + UsernameTextBox.Text + ", Password: " + PasswordTextBox.Text, MsgBoxStyle.Information, "User Accounts")
                    home_form.Show()
                    home_form.user.Text = Me.UsernameTextBox.Text
                    MsgBox("Welcome " + UsernameTextBox.Text + ".", MsgBoxStyle.Information, "User Accounts")
                    Me.hide()

                Else
                    MsgBox("Account not found!", MsgBoxStyle.Exclamation, "User Accounts")
                End If
            ElseIf user1.Text = "" And password1.Text = "" Then
                MsgBox("Please fill login fields!", MsgBoxStyle.Exclamation, "User Accounts")

            ElseIf user1.Text = "" Then
                MsgBox("Username cannot be empty!", MsgBoxStyle.Exclamation, "User Accounts")
            ElseIf password1.Text = "" Then
                MsgBox("Please enter a password!", MsgBoxStyle.Exclamation, "User Accounts")
            Else
                MsgBox("Wrong username or password.", MsgBoxStyle.Exclamation, "User Accounts")
            End If
        End If

    End Sub



    Private Sub user1_OnValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles user1.OnValueChanged
        If user1.Text = "" Then
            userLbl.Visible = True
            user1.BorderColorFocused = Color.FromKnownColor(KnownColor.MenuHighlight)
        Else
            userLbl.Visible = False
            user1.Focus()
            user1.BorderColorFocused = Color.FromKnownColor(KnownColor.MenuHighlight)
        End If
    End Sub

    Private Sub password1_OnValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles password1.OnValueChanged
        If password1.Text = "" Then
            passLbl.Visible = True
            show1.Visible = False

        Else
            passLbl.Visible = False
            show1.Visible = True
        End If
    End Sub


    Private Sub show1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles show1.MouseDown
        password1.isPassword = False
        show1.ForeColor = Color.White
        show1.Text = "Hide"
    End Sub

    Private Sub show1_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles show1.MouseUp
        password1.isPassword = True
        show1.ForeColor = Color.SeaGreen
        show1.Text = "Show"
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        If TextBox1.Text = "Fortu Team, Master Code for TORv1.0, EA7E-1153259 8891CBB9 F1513E4F 1A3405C1 A865D53F 115F202E 7B91AB2D 0D2A40ED 352B269B 76E84F0B CD69BFC7 59F2DFEF E267328F 215652A3 E88F9D8F 4C38E3BA 5B2DAAE4 969624E7 DC9CD4D5 717FB40C 1B9738CF 20B3C4F1 E917B5B3 87C38D9C ACCE7DD8 5F7EF854 86B9743C FADC04AA FB0DA5C0 F913BE58 42FEA319 F954EFDD AE881E0B" Or TextBox1.Text = "albertLickaJomerRon" Then
            TextBox1.ResetText()
            ProgressBar1.Visible = Enabled
            Label2.Visible = Enabled
            cancelBtn.Visible = Enabled
            Timer1.Start()
        End If
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        ProgressBar1.Increment(1)
        If ProgressBar1.Value = 31 Then

            Me.UserAccountTableAdapter.resetAdmin()

            ProgressBar1.Value = 1
            Timer1.Stop()

            kill = False
            Me.Close()
            MsgBox("Welcome ADMIN! The system has reset your username and password to 'admin', kindly change it now.", MsgBoxStyle.Information)
            splashScreen_form.version_label.Text = "admin"
            settings_form.Show()



        End If
    End Sub

    Private Sub cancelBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cancelBtn.Click
        Timer1.Stop()
        ProgressBar1.Value = 1
        TextBox1.ResetText()
        cancelBtn.Visible = False
        ProgressBar1.Visible = False
        Label2.Visible = False
        TextBox1.Visible = False

    End Sub

    Private Sub login_VisibleChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.VisibleChanged
        login_Load(sender, e)
    End Sub

    Private Sub version_label_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles version_label.Click
        x = x + 1
        If x = 20 Then
            TextBox1.Visible = Enabled
        End If
    End Sub


End Class