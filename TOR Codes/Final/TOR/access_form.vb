Public Class access_form

    Private Sub Access_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        studentsInfo_form.Enabled = True
        settings_form.Enabled = True
    End Sub


    Private Sub Access_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        password1.Focus()

        realPassword_label.Text = Me.UserAccountTableAdapter.selectPassword(splashScreen_form.version_label.Text)
    End Sub

    Private Sub cancel_button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cancel_button.Click
        Me.Close()
    End Sub

    Private Sub action_lbl_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles action_lbl.TextChanged
        If action_lbl.Text = "delete_student_record" Then
            studentsInfo_form.Enabled = False
        Else
            studentsInfo_form.Enabled = True
        End If
        If action_lbl.Text = "backup_database" Then
            settings_form.Enabled = False
        Else
            settings_form.Enabled = True
        End If
    End Sub

    Private Sub continue_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles continue_btn.Click
        Dim action As String = action_lbl.Text

        Select Case action

            Case "delete_student_record"

                If password1.Text = realPassword_label.Text Then
                    Try
                        studentsInfo_form.StudentsInfoBindingSource.RemoveCurrent()
                        studentsInfo_form.Validate()
                        studentsInfo_form.StudentsInfoBindingSource.EndEdit()
                        studentsInfo_form.TableAdapterManager.UpdateAll(studentsInfo_form.TORdbDataSet)

                        studentsInfo_form.StudentSubjectsTableAdapter.DELETE_his_subjects(studentNumber_lbl.Text)

                        Me.Close()
                        MsgBox("Record successfully deleted!", MsgBoxStyle.Information, "Students Record")
                    Catch ex As Exception
                        MsgBox("An error occured while deleting. Try to restart the application.", MsgBoxStyle.Exclamation, "Students Record")
                    End Try
                Else
                    MsgBox("Wrong or empty password!", MsgBoxStyle.Exclamation, "Access Denied!")

                End If

            Case "go_to_settings"

                If password1.Text = realPassword_label.Text Then
                    If previousForm_label.Text = "home_form" Then
                        home_form.settingsSecret_button.Enabled = True
                        home_form.settingsSecret_button.PerformClick()
                        Me.Close()
                    ElseIf previousForm_label.Text = "dashboard_form" Then
                        dashboard_form.settingsSecret_button.Enabled = True
                        dashboard_form.settingsSecret_button.PerformClick()
                        Me.Close()
                    ElseIf previousForm_label.Text = "studentsInfo_form" Then
                        studentsInfo_form.settingsSecret_button.Enabled = True
                        studentsInfo_form.settingsSecret_button.PerformClick()
                        Me.Close()
                    ElseIf previousForm_label.Text = "subjects_form" Then
                        subjects_form.settingsSecret_button.Enabled = True
                        subjects_form.settingsSecret_button.PerformClick()
                        Me.Close()
                    ElseIf previousForm_label.Text = "help_form" Then

                    End If

                Else
                    MsgBox("Wrong or empty password!", MsgBoxStyle.Exclamation, "Access Denied!")

                End If

            Case "backup_database"

                If password1.Text = realPassword_label.Text Then

                    settings_form.FolderBrowserDialog1.SelectedPath = settings_form.backupPath_textbox.Text

                    Try

                        IO.File.Copy("C:\Transcript\TORdb.mdb", settings_form.FolderBrowserDialog1.SelectedPath + "\TORdb.mdb")

                        'Update Database here
                        settings_form.DatabaseTableAdapter.updateBackupDb(settings_form.FolderBrowserDialog1.SelectedPath)
                        settings_form.DatabaseTableAdapter.Fill(Me.TORdbDataSet.database)
                        splashScreen_form.DatabaseTableAdapter.Fill(Me.TORdbDataSet.database)
                        settings_form.Enabled = True
                        Me.Close()
                        MsgBox("Backup successful!")

                    Catch ex As Exception
                        If MsgBox("File already exists. Do you want to update and overwrite it?", MsgBoxStyle.YesNo, "Backup") = MsgBoxResult.Yes Then

                            IO.File.Delete(settings_form.FolderBrowserDialog1.SelectedPath + "\TORdb.mdb")
                            IO.File.Copy("C:\Transcript\TORdb.mdb", settings_form.FolderBrowserDialog1.SelectedPath + "\TORdb.mdb")

                            'Update Database here
                            settings_form.DatabaseTableAdapter.updateBackupDb(settings_form.FolderBrowserDialog1.SelectedPath)
                            settings_form.DatabaseTableAdapter.Fill(Me.TORdbDataSet.database)
                            splashScreen_form.DatabaseTableAdapter.Fill(Me.TORdbDataSet.database)
                            settings_form.Enabled = True
                            Me.Close()
                            MsgBox("Backup successfully updated!")
                        Else
                        End If
                    End Try
                End If

            Case "restore_database"
                If password1.Text = realPassword_label.Text Then
                    IO.File.Delete("C:\Transcript\TORdb.mdb")
                    IO.File.Copy(settings_form.OpenFileDialog1.FileName, "C:\Transcript\TORdb.mdb")
                    Me.Close()
                    MsgBox("Database Updated. The System will start again.", MsgBoxStyle.Information, "Transcript")

                    settings_form.formStatus_label.Text = "Restart"
                    settings_form.Close()

                Else
                    Me.Close()

                End If
            Case "instant_backup"
                If password1.Text = realPassword_label.Text Then

                    Try

                        IO.File.Copy("C:\Transcript\TORdb.mdb", splashScreen_form.backupPath_label.Text + "\TORdb.mdb")

                        'Update Database here
                        splashScreen_form.DatabaseTableAdapter.updateBackupDb(splashScreen_form.backupPath_label.Text)
                        dashboard_form.DatabaseTableAdapter.Fill(Me.TORdbDataSet.database)
                        studentsInfo_form.DatabaseTableAdapter.Fill(Me.TORdbDataSet.database)
                        subjects_form.DatabaseTableAdapter.Fill(Me.TORdbDataSet.database)
                        settings_form.DatabaseTableAdapter.Fill(Me.TORdbDataSet.database)

                        Me.Close()
                        MsgBox("Backup successful!")

                    Catch ex As Exception
                        If MsgBox("File already exists. Do you want to update and overwrite it?", MsgBoxStyle.YesNo, "Backup") = MsgBoxResult.Yes Then

                            IO.File.Delete(splashScreen_form.backupPath_label.Text + "\TORdb.mdb")
                            ' IO.File.Delete(dashboard_form
                            IO.File.Copy("C:\Transcript\TORdb.mdb", splashScreen_form.backupPath_label.Text + "\TORdb.mdb")

                            'Update Database here
                            splashScreen_form.DatabaseTableAdapter.updateBackupDb(splashScreen_form.backupPath_label.Text)
                            dashboard_form.DatabaseTableAdapter.Fill(Me.TORdbDataSet.database)
                            studentsInfo_form.DatabaseTableAdapter.Fill(Me.TORdbDataSet.database)
                            subjects_form.DatabaseTableAdapter.Fill(Me.TORdbDataSet.database)
                            settings_form.DatabaseTableAdapter.Fill(Me.TORdbDataSet.database)

                            Me.Close()
                            MsgBox("Backup successfully updated!")
                        Else
                        End If
                    End Try
                End If

        End Select

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

    Private Sub show1_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles show1.MouseDown
        password1.isPassword = False
        show1.ForeColor = Color.White
        show1.Text = "Hide"
    End Sub

    Private Sub show1_MouseUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles show1.MouseUp
        password1.isPassword = True
        show1.ForeColor = Color.SeaGreen
        show1.Text = "Show"
    End Sub

    Private Sub UserAccountBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.UserAccountBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.TORdbDataSet)

    End Sub

End Class