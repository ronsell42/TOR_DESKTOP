Public Class subjects_form

    Dim kill As Boolean = True
    Dim addSubj As Boolean = False

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

    Private Sub homeBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles homeBtn.Click
        home_form.Show()
        home_form.Left = Me.Left
        home_form.Top = Me.Top
        kill = False
        Me.Close()
    End Sub

    Private Sub subjects_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        If kill = True Then
            Application.Exit()
        Else
            'do nothing
        End If
    End Sub

    Private Sub subjects_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
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
    End Sub

    Private Sub subjects_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'TORdbDataSet.database' table. You can move, or remove it, as needed.
        Me.DatabaseTableAdapter.Fill(Me.TORdbDataSet.database)
        'TODO: This line of code loads data into the 'TORdbDataSet.database' table. You can move, or remove it, as needed.
        Me.DatabaseTableAdapter.Fill(Me.TORdbDataSet.database)
        user.Text = splashScreen_form.version_label.Text

        'TODO: This line of code loads data into the 'TORdbDataSet.subjects' table. You can move, or remove it, as needed.
        Me.SubjectsTableAdapter.Fill(Me.TORdbDataSet.subjects)

        readSubject()
        subjectsTbl.Sort(subjectsTbl.Columns(0), System.ComponentModel.ListSortDirection.Descending)
    End Sub

    Private Sub readSubject()
        code.Enabled = False
        code.BorderColorIdle = Color.White
        code.BorderColorMouseHover = Color.White
        title.Enabled = False
        title.BorderColorIdle = Color.White
        title.BorderColorMouseHover = Color.White
        credit.Enabled = False
        credit.BorderColorIdle = Color.White
        credit.BorderColorMouseHover = Color.White
    End Sub

    Private Sub writeSubject()
        code.Enabled = True
        code.BorderColorIdle = Color.FromArgb(64, 64, 64)
        code.BorderColorMouseHover = Color.FromArgb(64, 64, 64)
        title.Enabled = True
        title.BorderColorIdle = Color.FromArgb(64, 64, 64)
        title.BorderColorMouseHover = Color.FromArgb(64, 64, 64)
        credit.Enabled = True
        credit.BorderColorIdle = Color.FromArgb(64, 64, 64)
        credit.BorderColorMouseHover = Color.FromArgb(64, 64, 64)
    End Sub

    Private Sub addBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles addBtn.Click
        writeSubject()

        SubjectsBindingSource.AddNew()
        addSubj = True
        addBtn.Enabled = False
        editBtn.Text = "Save"
        deleteBtn.Text = "Cancel"
        subjectsTbl.Enabled = False
    End Sub

    Private Sub editBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles editBtn.Click
        If editBtn.Text = "Edit" Then
            addBtn.Enabled = False
            editBtn.Text = "Save"

            deleteBtn.Text = "Cancel"
            subjectsTbl.Enabled = False

            writeSubject()

        ElseIf editBtn.Text = "Save" Then

            If rf1.Visible = True Or rf2.Visible = True Or rf3.Visible = True Then
                MsgBox("Please complete the form to continue.", MsgBoxStyle.Exclamation)

            Else
                Try
                    Me.Validate()
                    Me.SubjectsBindingSource.EndEdit()
                    Me.TableAdapterManager.UpdateAll(Me.TORdbDataSet)
                    Me.SubjectsTableAdapter.Fill(Me.TORdbDataSet.subjects)

                    addBtn.Enabled = True
                    editBtn.Text = "Edit"
                    deleteBtn.Text = "Delete"

                    readSubject()

                    'MsgBox("Saved!", MsgBoxStyle.Information)

                    subjectsTbl.Enabled = True
                Catch ex As Exception
                    MsgBox("Error!", MsgBoxStyle.Exclamation)
                End Try

            End If
        End If
    End Sub

    Private Sub deleteBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles deleteBtn.Click
        If deleteBtn.Text = "Delete" Then
            If MsgBox("Are you sure you want to delete " + "'" + title.Text + " from the record? This action cannot be undone.", MsgBoxStyle.YesNo, "Students Record") = MsgBoxResult.Yes Then
                SubjectsBindingSource.RemoveCurrent()
                Me.Validate()
                Me.SubjectsBindingSource.EndEdit()
                Me.TableAdapterManager.UpdateAll(Me.TORdbDataSet)
                MsgBox("Record deleted!", MsgBoxStyle.Information, "Students Record")
            End If
        ElseIf deleteBtn.Text = "Cancel" Then
            If addSubj = True Then
                'readStudent()
                SubjectsBindingSource.RemoveCurrent()
                addBtn.Enabled = True
                editBtn.Text = "Edit"
                deleteBtn.Text = "Delete"
                addSubj = False

                subjectsTbl.Enabled = True
                readSubject()
                Me.SubjectsTableAdapter.Fill(Me.TORdbDataSet.subjects)

            ElseIf addSubj = False Then
                'readStudent()
                addBtn.Enabled = True
                editBtn.Text = "Edit"
                deleteBtn.Text = "Delete"
                subjectsTbl.Enabled = True
                readSubject()
                SubjectsBindingSource.ResetBindings(True)
            End If

        End If
    End Sub

    Private Sub SubjectCodeTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SubjectCodeTextBox.TextChanged
        code.Text = SubjectCodeTextBox.Text
    End Sub

    Private Sub SubjectNameTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SubjectNameTextBox.TextChanged
        title.Text = SubjectNameTextBox.Text
    End Sub

    Private Sub CreditTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CreditTextBox.TextChanged
        credit.Text = CreditTextBox.Text
    End Sub

    Private Sub code_OnValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles code.OnValueChanged
        SubjectCodeTextBox.Text = code.Text
        If code.Text = "" Then
            rf1.Visible = True
        Else
            rf1.Visible = False
        End If
    End Sub

    Private Sub title_OnValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles title.OnValueChanged
        SubjectNameTextBox.Text = title.Text
        If title.Text = "" Then
            rf2.Visible = True
        Else
            rf2.Visible = False
        End If
    End Sub

    Private Sub credit_OnValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles credit.OnValueChanged
        CreditTextBox.Text = credit.Text
        If credit.Text = "" Then
            rf3.Visible = True
        Else
            Try
                credit.Text = credit.Text - 1 + 1
                rf3.Visible = False
            Catch ex As Exception
                rf3.Visible = True
            End Try

        End If

    End Sub

    Private Sub settingsBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles settingsBtn.Click
        access_form.Show()
        access_form.action_lbl.Text = "go_to_settings"
        access_form.message_lbl.Text = "Do you want to open Settings?"
        access_form.previousForm_label.Text = Me.Name
        access_form.password1.Focus()
    End Sub

    Private Sub searchbox_OnValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles searchbox.OnValueChanged
        If searchbox.Text = "" Then
            searchLbl.Visible = True
            clearSearchBtn.Visible = False
        Else
            searchLbl.Visible = False
            clearSearchBtn.Visible = True
        End If

        Dim searhSubj As String = searchbox.Text + "%"
        Me.SubjectsTableAdapter.seachSubject(Me.TORdbDataSet.subjects, searhSubj, searhSubj)

        If code.Text = "" Then
            rf1.Visible = False
            rf2.Visible = False
            rf3.Visible = False

        End If
    End Sub

    Private Sub clearSearchBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles clearSearchBtn.Click
        searchbox.ResetText()

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
            Me.Hide()
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

    Private Sub backupBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles backupBtn.Click
        If BackupPathLabel1.Text.Contains(":\") Then
            access_form.Show()
            access_form.message_lbl.Text = "Backup database to: "
            access_form.message2_label.Text = BackupPathLabel1.Text
            access_form.action_lbl.Text = "instant_backup"
            access_form.password1.Focus()

        Else
            MsgBox("Please enter a valid path.", MsgBoxStyle.Exclamation, "Ivalid")
        End If
    End Sub

    Private Sub deleteBtn_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles deleteBtn.TextChanged
        If deleteBtn.Text = "Cancel" Then
            kill = True
            panelMenu.Enabled = False
            searchPanel.Enabled = False

        ElseIf deleteBtn.Text = "Delete" Then

            panelMenu.Enabled = True
            searchPanel.Enabled = True
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