Public Class settings_form

    Dim kill As Boolean = True
    Dim addUser As Boolean = False
    Dim onEdit As Boolean = False
    Dim editMode As Boolean = False
    Dim unchange As Boolean = False

    Private Sub Sett_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        If kill = True Then
            Application.Exit()
        Else
            'do nothing
        End If
    End Sub

    Private Sub Sett_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

        If formStatus_label.Text = "Restart" Then
            
                Application.Restart()

        Else
            If kill = True Then

                If deleteBtn.Text = "Cancel" Then
                    MsgBox("Unable to quit while editing", MsgBoxStyle.Exclamation, "Finish Editing First")
                    e.Cancel = True
                ElseIf deleteBtn.Text = "Delete" Then
                    e.Cancel = True
                    exiting_form.Show()
                End If

            Else

            End If
        End If
    End Sub

    Private Sub Sett_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        user.Text = splashScreen_form.version_label.Text

        'TODO: This line of code loads data into the 'TORdbDataSet.database' table. You can move, or remove it, as needed.
        Me.DatabaseTableAdapter.Fill(Me.TORdbDataSet.database)
        readAccount()
        'TODO: This line of code loads data into the 'TORdbDataSet.userAccount' table. You can move, or remove it, as needed.
        Me.UserAccountTableAdapter.Fill(Me.TORdbDataSet.userAccount)
        accSettBtn_Click(sender, e)

        Dim userName As String = user.Text
        UsertypeBox.Text = Me.UserAccountTableAdapter.typeByUsername(userName)

        If UsertypeBox.Text = "Admin" Or UsertypeBox.Text = "admin" Then
            'do nothing
        Else
            Me.UserAccountTableAdapter.filterUser(Me.TORdbDataSet.userAccount, userName)
            If deleteBtn.Text = "Delete" Then
                deleteBtn.Enabled = False
            Else
                deleteBtn.Enabled = True
            End If

            addBtn.Enabled = False
        End If

    End Sub

    Private Sub showShow()
        'Show1
        If passBox.Text = "" Then
            show1.Visible = False
        Else
            show1.Visible = True
        End If
        'Show2
        If passBox2.Text = "" Then
            show2.Visible = False
        Else
            show2.Visible = True
        End If
        'Show3

    End Sub

    Private Sub hideShow()
        show1.Visible = False
        show2.Visible = False


    End Sub

    Private Sub showRF()
        'rf1
        If completeNameBox.Text = "" Then
            rf1.Visible = True
        Else
            rf1.Visible = False
        End If
        'rf2
        If userBox.Text = "" Then
            rf2.Visible = True
        Else
            rf2.Visible = False
        End If
        'rf3
        If passBox.Text = "" Then
            rf3.Visible = True
        Else
            rf3.Visible = False
        End If
        'rf4


    End Sub

    Private Sub hideRF()
        rf1.Visible = False
        rf2.Visible = False
        rf3.Visible = False

    End Sub
    Private Sub writeAccount()
        completeNameBox.Enabled = True
        completeNameBox.BorderColorIdle = Color.FromArgb(64, 64, 64)
        completeNameBox.BorderColorMouseHover = Color.FromArgb(64, 64, 64)
        userBox.Enabled = True
        userBox.BorderColorIdle = Color.FromArgb(64, 64, 64)
        userBox.BorderColorMouseHover = Color.FromArgb(64, 64, 64)
        acctypeBox.Visible = False
        passBox.Enabled = True
        passBox.BorderColorIdle = Color.FromArgb(64, 64, 64)
        passBox.BorderColorMouseHover = Color.FromArgb(64, 64, 64)
        passBox2.Enabled = True
        passBox2.BorderColorIdle = Color.FromArgb(64, 64, 64)
        passBox2.BorderColorMouseHover = Color.FromArgb(64, 64, 64)
        passBox2.Visible = True
        accountDetailsArea.Height = 153


        showShow()
        showRF()
    End Sub

    Private Sub readAccount()
        completeNameBox.Enabled = False
        completeNameBox.BorderColorIdle = Color.White
        completeNameBox.BorderColorMouseHover = Color.White
        userBox.Enabled = False
        userBox.BorderColorIdle = Color.White
        userBox.BorderColorMouseHover = Color.White
        acctypeBox.Visible = True
        passBox.Enabled = False
        passBox.BorderColorIdle = Color.White
        passBox.BorderColorMouseHover = Color.White
        passBox2.Enabled = False
        passBox2.BorderColorIdle = Color.White
        passBox2.BorderColorMouseHover = Color.White
        accountDetailsArea.Height = 111

        hideShow()
        hideRF()
    End Sub
    Private Sub homeBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles homeBtn.Click
        home_form.Show()
        home_form.Left = Me.Left
        home_form.Top = Me.Top
        kill = False
        Me.Close()
    End Sub

    Private Sub dashboardBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dashboardBtn.Click
        dashboard_form.Show()
        dashboard_form.Left = Me.Left
        dashboard_form.Top = Me.Top
        kill = False
        Me.Close()
    End Sub

    Private Sub studentsBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles studentsBtn.Click
        studentsInfo_form.Show()
        studentsInfo_form.Left = Me.Left
        studentsInfo_form.Top = Me.Top
        kill = False
        Me.Close()
    End Sub

    Private Sub subjectsBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles subjectsBtn.Click
        subjects_form.Show()
        subjects_form.Left = Me.Left
        subjects_form.Top = Me.Top
        kill = False
        Me.Close()
    End Sub

    Private Sub accSettBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles accSettBtn.Click
        SettingsTabControl.SelectedTab = accSett

        accSettBtn.BackColor = Color.SeaGreen
        accSettBtn.ForeColor = Color.White

        backupSettBtn.BackColor = Color.FromKnownColor(KnownColor.Control)
        backupSettBtn.ForeColor = Color.Black

        aboutSettBtn.BackColor = Color.FromKnownColor(KnownColor.Control)
        aboutSettBtn.ForeColor = Color.Black
    End Sub

    Private Sub backupSettBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles backupSettBtn.Click
        SettingsTabControl.SelectedTab = backupSett

        accSettBtn.BackColor = Color.FromKnownColor(KnownColor.Control)
        accSettBtn.ForeColor = Color.Black

        backupSettBtn.BackColor = Color.SeaGreen
        backupSettBtn.ForeColor = Color.White

        aboutSettBtn.BackColor = Color.FromKnownColor(KnownColor.Control)
        aboutSettBtn.ForeColor = Color.Black
    End Sub

    Private Sub aboutSettBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles aboutSettBtn.Click
        SettingsTabControl.SelectedTab = aboutSett

        accSettBtn.BackColor = Color.FromKnownColor(KnownColor.Control)
        accSettBtn.ForeColor = Color.Black

        backupSettBtn.BackColor = Color.FromKnownColor(KnownColor.Control)
        backupSettBtn.ForeColor = Color.Black

        aboutSettBtn.BackColor = Color.SeaGreen
        aboutSettBtn.ForeColor = Color.White
    End Sub

    Private Sub addBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles addBtn.Click

        userTbl.Enabled = False
        onEdit = True
        writeAccount()

        UserAccountBindingSource.AddNew()

        UserTextBox.Text = "Member" 'default
        addUser = True
        addBtn.Enabled = False
        editBtn.Text = "Save"
        deleteBtn.Text = "Cancel"
    End Sub

    Private Sub UsernameTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UsernameTextBox.TextChanged
        userBox.Text = UsernameTextBox.Text
    End Sub

    Private Sub PasswordTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PasswordTextBox.TextChanged
        passBox.Text = PasswordTextBox.Text
    End Sub


    Private Sub editBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles editBtn.Click

        If editBtn.Text = "Edit" Then
            editMode = True
            userTbl.Enabled = False
            onEdit = True
            writeAccount()


            addBtn.Enabled = False
            editBtn.Text = "Save"
            deleteBtn.Text = "Cancel"

            passBox2.Text = passBox.Text

        ElseIf editBtn.Text = "Save" Then
            If passBox.Text = PasswordTextBox.Text Then
                passBox2.Text = passBox.Text
            End If

            'Check if complete
            If Not completeNameBox.Text = "" And Not userBox.Text = "" And Not passBox.Text = "" And Not passBox2.Text = "" And passBox.Text = passBox2.Text Then
                CompleteNameTextBox.Text = completeNameBox.Text
                If UsernameTextBox.Text = userBox.Text And PasswordTextBox.Text = passBox.Text Then
                    unchange = True
                Else
                    unchange = False
                End If
                UsernameTextBox.Text = userBox.Text
                PasswordTextBox.Text = passBox.Text

                Try

                    Me.Validate()
                    Me.UserAccountBindingSource.EndEdit()
                    Me.TableAdapterManager.UpdateAll(Me.TORdbDataSet)
                    Me.UserAccountTableAdapter.Fill(Me.TORdbDataSet.userAccount)

                    addUser = False
                    If UsertypeBox.Text = "Admin" Or UsertypeBox.Text = "admin" Then
                        addBtn.Enabled = True
                    Else
                        addBtn.Enabled = False
                    End If

                    editBtn.Text = "Edit"
                    deleteBtn.Text = "Delete"

                    userTbl.Enabled = True

                    If editMode = False Then

                        MsgBox("Saved!", MsgBoxStyle.Information)
                        readAccount()

                        onEdit = False
                    Else
                        If unchange = True Then

                            MsgBox("Saved!", MsgBoxStyle.Information)
                            readAccount()

                            onEdit = False
                        Else
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

                            readAccount()
                            MsgBox("Updated! Please login again.", MsgBoxStyle.Information)
                            Me.Close()

                            onEdit = False
                            editMode = False
                        End If

                    End If

                Catch ex As Exception
                    MsgBox("Error! Username already exists.", MsgBoxStyle.Exclamation)
                End Try
            Else

                MsgBox("Please complete the form to continue.", MsgBoxStyle.Exclamation)
            End If

            End If
    End Sub

    Private Sub deleteBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles deleteBtn.Click
        editMode = False
        If deleteBtn.Text = "Delete" Then
            If UserTextBox.Text = "Admin" Then
                deleteBtn.Enabled = True
            Else
                deleteBtn.Enabled = False

            End If
            If MsgBox("Are you sure you want to delete " + "'" + UsernameTextBox.Text + "' from the record? This action cannot be undone.", MsgBoxStyle.YesNo, "Students Record") = MsgBoxResult.Yes Then
                UserAccountBindingSource.RemoveCurrent()
                Me.Validate()
                Me.UserAccountBindingSource.EndEdit()
                Me.TableAdapterManager.UpdateAll(Me.TORdbDataSet)
                MsgBox("User deleted!", MsgBoxStyle.Information, "User Account")
                If acctypeBox.Text = "Admin" Then
                    deleteBtn.Enabled = False
                Else
                    deleteBtn.Enabled = True
                End If
            End If
        ElseIf deleteBtn.Text = "Cancel" Then
            If addUser = True Then
                readAccount()
                UserAccountBindingSource.RemoveCurrent()
                If UsertypeBox.Text = "Admin" Then
                    addBtn.Enabled = True
                Else
                    addBtn.Enabled = False
                End If

                editBtn.Text = "Edit"
                deleteBtn.Text = "Delete"
                addUser = False

                show1.Visible = False
                Me.UserAccountTableAdapter.Fill(Me.TORdbDataSet.userAccount)

            ElseIf addUser = False Then
                addUser = False
                readAccount()
                If UsertypeBox.Text = "Admin" Then
                    addBtn.Enabled = True
                Else
                    addBtn.Enabled = False
                End If

                editBtn.Text = "Edit"
                deleteBtn.Text = "Delete"
                show1.Visible = False

                'cancel all changes
                completeNameBox.Text = CompleteNameTextBox.Text
                userBox.Text = UsernameTextBox.Text
                passBox.Text = PasswordTextBox.Text


            End If
            onEdit = False
            userTbl.Enabled = True

        End If
    End Sub

    Private Sub UserTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UserTextBox.TextChanged
        acctypeBox.Text = UserTextBox.Text

        If UserTextBox.Text = "Admin" And deleteBtn.Text = "Delete" Then
            deleteBtn.Enabled = False
        Else
            deleteBtn.Enabled = True
        End If


    End Sub

    Private Sub CompleteNameTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CompleteNameTextBox.TextChanged
        completeNameBox.Text = CompleteNameTextBox.Text
    End Sub

    Private Sub passBox_OnValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles passBox.OnValueChanged
        If Not PasswordTextBox.Text = passBox.Text Then
            accountDetailsArea.Height = 189
            passBox2.Enabled = True
        Else
            accountDetailsArea.Height = 153
            passBox2.Enabled = False
        End If
        '''''''''''''''''''
        If accountDetailsArea.Height = 189 Then
            If passBox.Text = passBox2.Text Then
                notMatch1.ForeColor = Color.SeaGreen
                notMatch1.Text = "Passwords match"
            Else
                notMatch1.ForeColor = Color.Red
                notMatch1.Text = "Passwords do not match"
            End If
        End If

        If onEdit = True Then
            If passBox.Text = "" Then
                show1.Visible = False
                rf3.Visible = True
            Else
                show1.Visible = True
                rf3.Visible = False
            End If

        ElseIf onEdit = False Then

            show1.Visible = False
            rf3.Visible = False

        End If


    End Sub



    Private Sub passBox2_VisibleChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles passBox2.VisibleChanged
        If passBox2.Visible = True Then
            notMatch1.Visible = True
        Else
            notMatch1.Visible = False
        End If
    End Sub


    Private Sub passBox2_OnValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles passBox2.OnValueChanged
        If passBox.Text = passBox2.Text Then
            notMatch1.ForeColor = Color.SeaGreen
            notMatch1.Text = "Passwords match"
        Else
            notMatch1.ForeColor = Color.Red
            notMatch1.Text = "Passwords do not match"
        End If

        'Show2
        If passBox2.Text = "" Then
            show2.Visible = False
        Else
            show2.Visible = True
        End If
    End Sub


    Private Sub show1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles show1.MouseDown
        passBox.isPassword = False
        show1.ForeColor = Color.White
        show1.Text = "Hide"
    End Sub

    Private Sub show1_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles show1.MouseUp
        passBox.isPassword = True
        show1.ForeColor = Color.SeaGreen
        show1.Text = "Show"
    End Sub

    Private Sub show2_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles show2.MouseDown
        passBox2.isPassword = False
        show2.ForeColor = Color.White
        show2.Text = "Hide"
    End Sub

    Private Sub show2_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles show2.MouseUp
        passBox2.isPassword = True
        show2.ForeColor = Color.SeaGreen
        show2.Text = "Show"
    End Sub

    Private Sub deleteBtn_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles deleteBtn.TextChanged


        If UsertypeBox.Text = "Member" And deleteBtn.Text = "Delete" Then
            deleteBtn.Enabled = False
        Else
            If UserTextBox.Text = "Admin" And deleteBtn.Text = "Delete" Then
                deleteBtn.Enabled = False
            Else
                deleteBtn.Enabled = True
            End If
        End If

        
            If deleteBtn.Text = "Cancel" Then
                kill = True
            paelMenu.Enabled = False
            userTbl.Enabled = False
            Panel1.Enabled = False
                
            ElseIf deleteBtn.Text = "Delete" Then
            paelMenu.Enabled = True
            userTbl.Enabled = True
            Panel1.Enabled = True
               
            End If
    End Sub

    Private Sub completeNameBox_OnValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles completeNameBox.OnValueChanged
        'rf1
        If completeNameBox.Text = "" Then
            rf1.Visible = True
        Else
            rf1.Visible = False
        End If
    End Sub

    Private Sub userBox_OnValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles userBox.OnValueChanged
        'rf2
        If userBox.Text = "" Then
            rf2.Visible = True
        Else
            rf2.Visible = False
        End If

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

    Private Sub user_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles user.TextChanged
        Dim userName As String = UserUsername.Text
        Try

            UsertypeBox.Text = Me.UserAccountTableAdapter.typeByUsername(userName)
        Catch ex As Exception

        End Try

    End Sub

    Private Sub BackupPathTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BackupPathTextBox.TextChanged
        backupPath_textbox.Text = BackupPathTextBox.Text
    End Sub

    Private Sub undoChange_button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles undoChange_button.Click
        backupPath_textbox.Text = BackupPathTextBox.Text
    End Sub

    Private Sub backupPath_textbox_OnValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles backupPath_textbox.OnValueChanged
        If Not backupPath_textbox.Text = BackupPathTextBox.Text Then
            undoChange_button.Visible = True
        Else
            undoChange_button.Visible = False
        End If

        If backupPath_textbox.Text = "" Or backupPath_textbox.Text.Count < 3 Then
            backupNow_button.Enabled = False
            clearSearch1_btn.Visible = False
        Else
            backupNow_button.Enabled = True
            clearSearch1_btn.Visible = True
        End If
    End Sub

    Private Sub change_button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles change_button.Click
        If FolderBrowserDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            backupPath_textbox.Text = FolderBrowserDialog1.SelectedPath

            Dim root As Environment.SpecialFolder = FolderBrowserDialog1.RootFolder
        End If
    End Sub

    Private Sub backupNow_button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles backupNow_button.Click
        If backupPath_textbox.Text.Contains(":\") Then
            access_form.Show()
            access_form.message_lbl.Text = "Backup database to: "
            access_form.message2_label.Text = FolderBrowserDialog1.SelectedPath
            access_form.action_lbl.Text = "backup_database"
            access_form.password1.Focus()
               
        Else
            MsgBox("Please enter a valid path.", MsgBoxStyle.Exclamation, "Ivalid")
        End If



    End Sub

    Private Sub browse_button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles browse_button.Click
        If OpenFileDialog1.ShowDialog = DialogResult.OK Then
            restorePath_textbox.Text = OpenFileDialog1.FileName
        End If
    End Sub

    Private Sub restorePath_textbox_OnValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles restorePath_textbox.OnValueChanged
        If restorePath_textbox.Text = "" Or restorePath_textbox.Text.Count < 12 Then
            restoreData_button.Enabled = False

        Else
            restoreData_button.Enabled = True
        End If

        If Not restorePath_textbox.Text = OpenFileDialog1.FileName Then
            undoChange1_btton.Visible = True
        Else
            undoChange1_btton.Visible = False

        End If

        If restorePath_textbox.Text = "" Then
            clearSearch2_btn.Visible = False
        Else
            clearSearch2_btn.Visible = True
        End If
    End Sub


    Private Sub undoChange1_btton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles undoChange1_btton.Click
        If OpenFileDialog1.FileName = "TORdb.mdb" Then
            restorePath_textbox.ResetText()
        Else
            restorePath_textbox.Text = OpenFileDialog1.FileName
        End If

    End Sub

    Private Sub clearSearch1_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles clearSearch1_btn.Click
        backupPath_textbox.Text = ""
    End Sub

    Private Sub clearSearch2_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles clearSearch2_btn.Click
        restorePath_textbox.Text = ""
    End Sub


    Private Sub restoreData_button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles restoreData_button.Click
        If restorePath_textbox.Text.Contains("TORdb.mdb") Then

            access_form.Show()
            access_form.message_lbl.Text = "You are about to update your database from: "
            access_form.message2_label.Text = OpenFileDialog1.FileName
            access_form.action_lbl.Text = "restore_database"
            access_form.password1.Focus()
          
        Else
            MsgBox("Invalid file for the scpecified database!", MsgBoxStyle.Exclamation, "Transcript")
        End If
    End Sub

    Private Sub backupBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles backupBtn.Click
        If BackupPathLabel2.Text.Contains(":\") Then
            access_form.Show()
            access_form.message_lbl.Text = "Backup database to: "
            access_form.message2_label.Text = BackupPathLabel2.Text
            access_form.action_lbl.Text = "instant_backup"
            access_form.password1.Focus()

        Else
            MsgBox("Please enter a valid path.", MsgBoxStyle.Exclamation, "Ivalid")
        End If
    End Sub


    Private Sub helpBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles helpBtn.Click
        tutorials_form.Show()
        tutorials_form.backTo_label.Text = Me.Name
        tutorials_form.Left = Me.Left
        tutorials_form.Top = Me.Top
        kill = False
        Me.Close()
    End Sub

End Class