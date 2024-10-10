Public Class studentsInfo_form
    Dim kill As Boolean = True
    Dim addStudent As Boolean = False
    Dim onEdit As Boolean = False
    Dim gradRequirements As Boolean = False
    Dim cleardates As Boolean = False

    Private Sub students_information_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        If kill = True Then
            Application.Exit()
        Else
            'do nothing
        End If
    End Sub
    'ShorcutZone
    Private Sub students_information_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyUp
        If e.KeyCode = Keys.ControlKey Then
            shortcutsTextBox.Visible = False
            shortcutsTextBox.ResetText()
        End If
    End Sub

    Private Sub students_information_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown

        If e.KeyCode = Keys.ControlKey Then
            shortcutsTextBox.Visible = True
            shortcutsTextBox.ResetText()
        End If

        If shortcutsTextBox.Visible = True Then
            'Edit Data
            If e.KeyCode = Keys.E Then
                shortcutsTextBox.Text = shortcutsTextBox.Text + "E"
            End If

            'Save Data
            If e.KeyCode = Keys.S Then
                shortcutsTextBox.Text = shortcutsTextBox.Text + "S"
            End If

            'Delete Data
            If e.KeyCode = Keys.D Then
                shortcutsTextBox.Text = shortcutsTextBox.Text + "D"
            End If

        End If
        'Delete Data
        If e.KeyCode = Keys.Delete Then
            deleteBtn.PerformClick()
        End If

        'Enter Search
        If e.KeyCode = Keys.Enter Then
            searchBtn.PerformClick()
        End If

    End Sub

    Private Sub shortcutsTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles shortcutsTextBox.TextChanged
        If shortcutsTextBox.Text.Count = 2 Then
            shortcutsTextBox.ResetText()
            shortcutsTextBox.Visible = False
        End If

        'Edit Data
        If shortcutsTextBox.Text = "E" Then
            If onEdit = False Then
                editBtn.PerformClick()
            Else
                'do nothing
            End If
        End If

        'Save Data
        If shortcutsTextBox.Text = "S" Then
            If onEdit = True Then
                editBtn.PerformClick()
            Else
                'do nothing
            End If
        End If

        'Delete Data
        If shortcutsTextBox.Text = "D" Then
            If onEdit = False Then
                deleteBtn.PerformClick()
            Else
                'do nothing
            End If
        End If

    End Sub

    Private Sub students_information_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'TORdbDataSet.studentSubjects' table. You can move, or remove it, as needed.
        Try
            Me.StudentSubjectsTableAdapter.Fill(Me.TORdbDataSet.studentSubjects)
        Catch ex As Exception
            Try
                Me.StudentSubjectsTableAdapter.Fill(Me.TORdbDataSet.studentSubjects)
            Catch ex1 As Exception
                MessageBox.Show(ex1.Message)
            End Try

        End Try

        'TODO: This line of code loads data into the 'TORdbDataSet.database' table. You can move, or remove it, as needed.
        Me.DatabaseTableAdapter.Fill(Me.TORdbDataSet.database)
        'TODO: This line of code loads data into the 'TORdbDataSet.database' table. You can move, or remove it, as needed.
        Me.DatabaseTableAdapter.Fill(Me.TORdbDataSet.database)
        'TODO: This line of code loads data into the 'TORdbDataSet.database' table. You can move, or remove it, as needed.
        Me.DatabaseTableAdapter.Fill(Me.TORdbDataSet.database)
        user.Text = splashScreen_form.version_label.Text
        readStudent()


        'TODO: This line of code loads data into the 'TORdbDataSet.courses' table. You can move, or remove it, as needed.
        Me.CoursesTableAdapter.Fill(Me.TORdbDataSet.courses)
        'TODO: This line of code loads data into the 'TORdbDataSet.studentsInfo' table. You can move, or remove it, as needed.
        Me.StudentsInfoTableAdapter.Fill(Me.TORdbDataSet.studentsInfo)
        'TODO: This line of code loads data into the 'TORdbDataSet.courses' table. You can move, or remove it, as needed.
        Me.CoursesTableAdapter.Fill(Me.TORdbDataSet.courses)
        'TODO: This line of code loads data into the 'TORdbDataSet.studentsInfo' table. You can move, or remove it, as needed.
        Me.StudentsInfoTableAdapter.Fill(Me.TORdbDataSet.studentsInfo)


        studentsTbl.Sort(studentsTbl.Columns(0), System.ComponentModel.ListSortDirection.Descending)
    End Sub

    '>>>functions
    Private Sub readStudent()
        studentsTbl.Enabled = True

        sinfo1.Enabled = False
        sinfo1.BorderColorIdle = Color.White
        sinfo1.BorderColorMouseHover = Color.White
        sinfo2.Enabled = False
        sinfo2.BorderColorIdle = Color.White
        sinfo2.BorderColorMouseHover = Color.White
        sinfo3.Enabled = False
        sinfo3.BorderColorIdle = Color.White
        sinfo3.BorderColorMouseHover = Color.White
        sinfo4.Enabled = False
        sinfo4.BorderColorIdle = Color.White
        sinfo4.BorderColorMouseHover = Color.White
        includeDot.Visible = False
        sinfo5.Visible = False
        sinfo52.Visible = True
        sinfo3.BorderColorMouseHover = Color.White
        sinfo6.Enabled = False
        sinfo6.BorderColorIdle = Color.White
        sinfo6.BorderColorMouseHover = Color.White
        sinfo3.BorderColorMouseHover = Color.White
        sinfo7.Enabled = False
        sinfo7.BorderColorIdle = Color.White
        sinfo7.BorderColorMouseHover = Color.White
        sinfo8.Visible = False
        sinfo82.Visible = True
        sinfo9.Enabled = False
        sinfo9.BorderColorIdle = Color.White
        sinfo9.BorderColorMouseHover = Color.White
        sinfo10.Visible = False
        sinfo102.Visible = True
        sinfo11.Enabled = False
        sinfo11.BorderColorIdle = Color.White
        sinfo11.BorderColorMouseHover = Color.White
        sinfo12.Enabled = False
        sinfo12.BorderColorIdle = Color.White
        sinfo12.BorderColorMouseHover = Color.White
        sinfo13.Enabled = False
        sinfo13.BorderColorIdle = Color.White
        sinfo13.BorderColorMouseHover = Color.White
        sinfo14.Enabled = False
        sinfo14.BorderColorIdle = Color.White
        sinfo14.BorderColorMouseHover = Color.White
        sinfo15.Enabled = False
        sinfo15.BorderColorIdle = Color.White
        sinfo15.BorderColorMouseHover = Color.White
        sinfo16.Enabled = False
        sinfo16.BorderColorIdle = Color.White
        sinfo16.BorderColorMouseHover = Color.White
        graduateCheckBox.Enabled = False
        sinfo17.Enabled = False
        sinfo18.Visible = False
        sinfo182.Visible = True
        sinfo19.Visible = False
        sinfo192.Visible = True
        'rf
        rf1.Visible = False
        rf2.Visible = False
        rf3.Visible = False
        rf4.Visible = False

        rf6.Visible = False
        rf7.Visible = False

        rf9.Visible = False

        rf11.Visible = False
        rf12.Visible = False
        rf13.Visible = False
        rf14.Visible = False

        rf16.Visible = False
    End Sub

    Private Sub writeStudent()
        studentsTbl.Enabled = False

        sinfo1.Enabled = True
        sinfo1.BorderColorIdle = Color.FromArgb(64, 64, 64)
        sinfo1.BorderColorMouseHover = Color.FromArgb(64, 64, 64)
        sinfo2.Enabled = True
        sinfo2.BorderColorIdle = Color.FromArgb(64, 64, 64)
        sinfo2.BorderColorMouseHover = Color.FromArgb(64, 64, 64)
        sinfo3.Enabled = True
        sinfo3.BorderColorIdle = Color.FromArgb(64, 64, 64)
        sinfo3.BorderColorMouseHover = Color.FromArgb(64, 64, 64)
        sinfo4.Enabled = True
        sinfo4.BorderColorIdle = Color.FromArgb(64, 64, 64)
        sinfo4.BorderColorMouseHover = Color.FromArgb(64, 64, 64)
        includeDot.Visible = True
        sinfo5.Visible = True
        sinfo52.Visible = False
        sinfo3.BorderColorMouseHover = Color.FromArgb(64, 64, 64)
        sinfo6.Enabled = True
        sinfo6.BorderColorIdle = Color.FromArgb(64, 64, 64)
        sinfo6.BorderColorMouseHover = Color.FromArgb(64, 64, 64)
        sinfo3.BorderColorMouseHover = Color.FromArgb(64, 64, 64)
        sinfo7.Enabled = True
        sinfo7.BorderColorIdle = Color.FromArgb(64, 64, 64)
        sinfo7.BorderColorMouseHover = Color.FromArgb(64, 64, 64)
        sinfo8.Visible = True
        sinfo82.Visible = False
        sinfo9.Enabled = True
        sinfo9.BorderColorIdle = Color.FromArgb(64, 64, 64)
        sinfo9.BorderColorMouseHover = Color.FromArgb(64, 64, 64)
        sinfo10.Visible = True
        sinfo10.Text = sinfo102.Text
        sinfo102.Text = DegreeTitleTextBox.Text
        sinfo102.Visible = False
        sinfo11.Enabled = True
        sinfo11.BorderColorIdle = Color.FromArgb(64, 64, 64)
        sinfo11.BorderColorMouseHover = Color.FromArgb(64, 64, 64)
        sinfo12.Enabled = True
        sinfo12.BorderColorIdle = Color.FromArgb(64, 64, 64)
        sinfo12.BorderColorMouseHover = Color.FromArgb(64, 64, 64)
        sinfo13.Enabled = True
        sinfo13.BorderColorIdle = Color.FromArgb(64, 64, 64)
        sinfo13.BorderColorMouseHover = Color.FromArgb(64, 64, 64)
        sinfo14.Enabled = True
        sinfo14.BorderColorIdle = Color.FromArgb(64, 64, 64)
        sinfo14.BorderColorMouseHover = Color.FromArgb(64, 64, 64)
        sinfo15.Enabled = True
        sinfo15.BorderColorIdle = Color.FromArgb(64, 64, 64)
        sinfo15.BorderColorMouseHover = Color.FromArgb(64, 64, 64)
        sinfo16.Enabled = True
        sinfo16.BorderColorIdle = Color.FromArgb(64, 64, 64)
        sinfo16.BorderColorMouseHover = Color.FromArgb(64, 64, 64)
        graduateCheckBox.Enabled = True

        If graduateCheckBox.Checked = False Then
            sinfo17.Enabled = False

        ElseIf graduateCheckBox.Checked = True Then
            sinfo17.Enabled = True
            If addStudent = True Then

            Else

            End If

        End If
        sinfo18.Visible = True
        sinfo182.Visible = False
        sinfo19.Visible = True
        sinfo192.Visible = False

        'rf
        If sinfo1.Text = "" Then
            rf1.Visible = True
        Else
            rf1.Visible = False
        End If
        If sinfo2.Text = "" Then
            rf2.Visible = True
        Else
            rf2.Visible = False
        End If
        If sinfo3.Text = "" Then
            rf3.Visible = True
        Else
            rf3.Visible = False
        End If
        If sinfo4.Text = "" Then
            rf4.Visible = True
        Else
            rf4.Visible = False
        End If
        If sinfo6.Text = "" Then
            rf6.Visible = True
        Else
            rf6.Visible = False
        End If
        If sinfo7.Text = "" Then
            rf7.Visible = True
        Else
            rf7.Visible = False
        End If
        If sinfo9.Text = "" Then
            rf9.Visible = True
        Else
            rf9.Visible = False
        End If
        If sinfo11.Text = "" Then
            rf11.Visible = True
        Else
            rf11.Visible = False
        End If
        If sinfo12.Text = "" Then
            rf12.Visible = True
        Else
            rf12.Visible = False
        End If
        If sinfo13.Text = "" Then
            rf13.Visible = True
        Else
            rf13.Visible = False
        End If
        If sinfo14.Text = "" Then
            rf14.Visible = True
        Else
            rf14.Visible = False
        End If
    End Sub
    'functions<<<

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

    End Sub

    Private Sub subjectsBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles subjectsBtn.Click
        subjects_form.Show()
        subjects_form.Left = Me.Left
        subjects_form.Top = Me.Top
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

    Private Sub settingsBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles settingsBtn.Click
        access_form.Show()
        access_form.action_lbl.Text = "go_to_settings"
        access_form.message_lbl.Text = "Do you want to open Settings?"
        access_form.previousForm_label.Text = Me.Name
        access_form.password1.Focus()
    End Sub

    Private Sub historyBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub helpBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles helpBtn.Click
        tutorials_form.Show()
        tutorials_form.backTo_label.Text = Me.Name
        tutorials_form.Left = Me.Left
        tutorials_form.Top = Me.Top
        kill = False
        Me.Close()
    End Sub

    Private Sub addBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles addBtn.Click
        addStudent = True
        writeStudent()
        onEdit = True
        StudentsInfoBindingSource.AddNew()

        addBtn.Enabled = False
        editBtn.Text = "Save"
        deleteBtn.Text = "Cancel"
        sinfo5.Value = DateTimePicker1.Value
        sinfo5.Value = Date.Now()
        DOA2TextBox_TextChanged(sender, e)
    End Sub

    Public Sub editBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles editBtn.Click
        If editBtn.Text = "Edit" Then
            writeStudent()
            onEdit = True

            addBtn.Enabled = False
            editBtn.Text = "Save"
            deleteBtn.Text = "Cancel"

            If graduateCheckBox.Checked = True Then
                Label19.Text = "Yes"
            Else
                Label19.Text = "No"
            End If

        ElseIf editBtn.Text = "Save" Then

            If rf1.Visible = True Or rf2.Visible = True Or rf3.Visible = True Or rf4.Visible = True Or rf6.Visible = True Or rf7.Visible = True Or rf9.Visible = True Or rf11.Visible = True Or rf12.Visible = True Or rf13.Visible = True Or rf14.Visible = True Or rf15.Visible = True Or rf16.Visible = True Then
                MsgBox("Please complete the form to continue.", MsgBoxStyle.Exclamation)
            Else
                If sinfo10.Text = Label18.Text Then
                    DegreeTitleTextBox.Text = Label18.Text
                Else
                    DegreeTitleTextBox.Text = sinfo10.Text
                End If

                Try
                    WholeNameTextBox.Text = sinfo2.Text + ", " + sinfo3.Text + " " + sinfo4.Text
                    WholeNameTextBox1.Text = WholeNameTextBox.Text.ToUpper

                    'Gets the latest edited record
                    currentQBtn.Text = sinfo1.Text

                    Me.Validate()
                    Me.StudentsInfoBindingSource.EndEdit()
                    Me.TableAdapterManager.UpdateAll(Me.TORdbDataSet)
                    Me.StudentsInfoTableAdapter.Fill(Me.TORdbDataSet.studentsInfo)
                    currentQBtn.PerformClick()
                    addStudent = False

                    addBtn.Enabled = True
                    editBtn.Text = "Edit"
                    deleteBtn.Text = "Delete"
                    onEdit = False
                    readStudent()
                    MsgBox("Data Saved!", MsgBoxStyle.Information)

                Catch ex As Exception
                    MsgBox("Error saving data. Username already exists!", MsgBoxStyle.Exclamation)
                    Me.StudentsInfoTableAdapter.Fill(Me.TORdbDataSet.studentsInfo)
                End Try
            End If
        End If



    End Sub

    Private Sub sinfo1_OnValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sinfo1.OnValueChanged
        StudentNoTextBox.Text = sinfo1.Text
        If sinfo1.Text = "" Then
            rf1.Visible = True
        Else
            rf1.Visible = False
        End If
    End Sub

    Private Sub sinfo2_OnValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sinfo2.OnValueChanged
        LastNameTextBox.Text = sinfo2.Text
        If sinfo2.Text = "" Then
            rf2.Visible = True
        Else
            rf2.Visible = False
        End If
    End Sub

    Private Sub sinfo3_OnValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sinfo3.OnValueChanged
        FirstNameTextBox.Text = sinfo3.Text
        If sinfo3.Text = "" Then
            rf3.Visible = True
        Else
            rf3.Visible = False
        End If
    End Sub

    Private Sub sinfo4_OnValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sinfo4.OnValueChanged
        MInitialTextBox.Text = sinfo4.Text
        If sinfo4.Text = "" Then
            rf4.Visible = True
        Else
            rf4.Visible = False
        End If
    End Sub

    Private Sub sinfo5_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sinfo5.ValueChanged
        BirthdayDateTimePicker.Value = sinfo5.Value
    End Sub

    Private Sub sinfo6_OnValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sinfo6.OnValueChanged
        PlaceOfBirthTextBox.Text = sinfo6.Text
        If sinfo6.Text = "" Then
            rf6.Visible = True
        Else
            rf6.Visible = False
        End If
    End Sub

    Private Sub sinfo7_OnValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sinfo7.OnValueChanged
        HomeAddressTextBox.Text = sinfo7.Text
        If sinfo7.Text = "" Then
            rf7.Visible = True
        Else
            rf7.Visible = False
        End If
    End Sub

    Private Sub sinfo9_OnValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sinfo9.OnValueChanged
        ECFTextBox.Text = sinfo9.Text
        If sinfo9.Text = "" Then
            rf9.Visible = True
        Else
            rf9.Visible = False
        End If
    End Sub

    Private Sub sinfo10_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sinfo10.SelectedIndexChanged

    End Sub

    Private Sub sinfo11_OnValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sinfo11.OnValueChanged
        ElementaryTextBox.Text = sinfo11.Text
        If sinfo11.Text = "" Then
            rf11.Visible = True
        Else
            rf11.Visible = False
        End If
    End Sub

    Private Sub sinfo12_OnValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sinfo12.OnValueChanged
        ElemYearTextBox.Text = sinfo12.Text
        If sinfo12.Text = "" Then
            rf12.Visible = True
        Else
            rf12.Visible = False
        End If
    End Sub

    Private Sub sinfo13_OnValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sinfo13.OnValueChanged
        SecondaryTextBox.Text = sinfo13.Text
        If sinfo13.Text = "" Then
            rf13.Visible = True
        Else
            rf13.Visible = False
        End If
    End Sub

    Private Sub sinfo14_OnValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sinfo14.OnValueChanged
        SecondaryYearTextBox.Text = sinfo14.Text
        If sinfo14.Text = "" Then
            rf14.Visible = True
        Else
            rf14.Visible = False
        End If
    End Sub

    Private Sub sinfo15_OnValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sinfo15.OnValueChanged, sinfo16.OnValueChanged
        LastAttendedTextBox.Text = sinfo15.Text

        If onEdit = True Then
            If Not sinfo15.Text = "" Then
                If sinfo16.Text = "" Then
                    rf15.Visible = True
                Else
                    rf15.Visible = False
                End If
            Else
                rf15.Visible = False
            End If
        End If
    End Sub

    Private Sub sinfo16_OnValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sinfo16.OnValueChanged
        LastYearTextBox.Text = sinfo16.Text

    End Sub

    Private Sub graduateCheckBox_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles graduateCheckBox.CheckedChanged
        If graduateCheckBox.Checked = True Then
            graduateGB.Enabled = True
        ElseIf graduateCheckBox.Checked = False Then

            If Label19.Text = "Yes" Then
                graduateGB.Enabled = True
            Else
                graduateGB.Enabled = False
            End If

        End If

        If graduateCheckBox.Checked = False And sinfo17.Text = "" And Label19.Text = "Yes" And onEdit = True Then
            If MsgBox("Are you sure you want to remove " + "'" + sinfo2.Text + ", " + sinfo3.Text + " " + sinfo4.Text + " as a graduate student?", MsgBoxStyle.YesNo, "Students Record") = MsgBoxResult.Yes Then

                SoNoTextBox.ResetText()
                rf16.Visible = False
                'save ========>>>>>>>
                cleardates = True
                Try
                    currentQBtn.Text = sinfo1.Text

                    Me.Validate()
                    Me.StudentsInfoBindingSource.EndEdit()
                    Me.TableAdapterManager.UpdateAll(Me.TORdbDataSet)

                    Me.StudentsInfoTableAdapter.Fill(Me.TORdbDataSet.studentsInfo)
                    currentQBtn.PerformClick()

                    addStudent = False

                    addBtn.Enabled = True
                    editBtn.Text = "Edit"
                    deleteBtn.Text = "Delete"
                    onEdit = False
                    readStudent()
                    MsgBox("Data Saved!", MsgBoxStyle.Information)
                Catch ex As Exception

                    MsgBox("")
                    Me.StudentsInfoTableAdapter.Fill(Me.TORdbDataSet.studentsInfo)
                End Try

                'save  <<<<<<<<<<<<<<<==========
                graduateCheckBox.Checked = False

            Else

                Me.StudentsInfoBindingSource.ResetBindings(True)

            End If

        ElseIf graduateCheckBox.Checked = False And Label19.Text = "Yes" And onEdit = True Then
            SoNoTextBox.ResetText()
            graduateCheckBox.Checked = False
        End If

    End Sub

    Private Sub sinfo17_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sinfo17.TextChanged
        If sinfo17.Text = "" Then
            graduateGB.Height = 50

            If Label19.Text = "Yes" And onEdit = True Then
                graduateCheckBox.ForeColor = Color.SeaGreen
                graduateCheckBox.Checked = True
            Else
                graduateCheckBox.ForeColor = Color.Black
                graduateCheckBox.Checked = False
            End If

        Else
            graduateGB.Height = 120

            graduateCheckBox.Checked = True
            graduateCheckBox.ForeColor = Color.SeaGreen
        End If

        If sinfo17.Text = "" And onEdit = True And graduateCheckBox.Checked = True Then
            rf16.Visible = True
        Else
            rf16.Visible = False
        End If

        SoNoTextBox.Text = sinfo17.Text

    End Sub

    Private Sub sinfo18_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sinfo18.ValueChanged
        DatedDateTimePicker.Value = sinfo18.Value
    End Sub

    Private Sub sinfo19_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sinfo19.ValueChanged
        DateOfGradDateTimePicker.Value = sinfo19.Value
    End Sub

    Public Sub deleteBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles deleteBtn.Click
        If deleteBtn.Text = "Delete" Then
            If MsgBox("Are you sure you want to delete " + "'" + sinfo1.Text + ", " + sinfo2.Text + " from the record? All the subjects will also be deleted.", MsgBoxStyle.YesNo, "Students Record") = MsgBoxResult.Yes Then
                access_form.Show()
                access_form.action_lbl.Text = "delete_student_record"
                access_form.message_lbl.Text = "You are going to delete"
                access_form.message2_label.Text = sinfo1.Text + ", " + sinfo2.Text + "' " + "permanently."
                access_form.studentNumber_lbl.Text = sinfo1.Text

            End If
        ElseIf deleteBtn.Text = "Cancel" Then
            If addStudent = True Then
                readStudent()
                StudentsInfoBindingSource.RemoveCurrent()
                addBtn.Enabled = True
                editBtn.Text = "Edit"
                deleteBtn.Text = "Delete"
                addStudent = False

                onEdit = False
                Me.StudentsInfoTableAdapter.Fill(Me.TORdbDataSet.studentsInfo)
                DOA2TextBox_TextChanged(sender, e)
            ElseIf addStudent = False Then
                readStudent()
                addBtn.Enabled = True
                editBtn.Text = "Edit"
                deleteBtn.Text = "Delete"
                StudentsInfoBindingSource.ResetBindings(True)
                onEdit = False
            End If

        End If
    End Sub

    Private Sub StudentNoTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StudentNoTextBox.TextChanged
        sinfo1.Text = StudentNoTextBox.Text
    End Sub

    Private Sub LastNameTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LastNameTextBox.TextChanged
        sinfo2.Text = LastNameTextBox.Text
    End Sub

    Private Sub FirstNameTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FirstNameTextBox.TextChanged
        sinfo3.Text = FirstNameTextBox.Text
    End Sub

    Private Sub MInitialTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MInitialTextBox.TextChanged
        sinfo4.Text = MInitialTextBox.Text
    End Sub

    Private Sub BirthdayDateTimePicker_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BirthdayDateTimePicker.ValueChanged
        sinfo5.Value = BirthdayDateTimePicker.Text
        sinfo52.Text = BirthdayDateTimePicker.Text
    End Sub

    Private Sub PlaceOfBirthTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PlaceOfBirthTextBox.TextChanged
        sinfo6.Text = PlaceOfBirthTextBox.Text
    End Sub

    Private Sub HomeAddressTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HomeAddressTextBox.TextChanged
        sinfo7.Text = HomeAddressTextBox.Text
    End Sub

    Private Sub ECFTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ECFTextBox.TextChanged
        sinfo9.Text = ECFTextBox.Text
    End Sub

    Private Sub SoNoTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SoNoTextBox.TextChanged
        sinfo17.Text = SoNoTextBox.Text

    End Sub

    Private Sub DatedDateTimePicker_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DatedDateTimePicker.ValueChanged
        sinfo18.Value = DatedDateTimePicker.Value
        sinfo182.Text = DatedDateTimePicker.Text
    End Sub

    Private Sub DateOfGradDateTimePicker_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateOfGradDateTimePicker.ValueChanged
        sinfo19.Value = DateOfGradDateTimePicker.Value
        sinfo192.Text = DateOfGradDateTimePicker.Text
    End Sub

    Private Sub ElementaryTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ElementaryTextBox.TextChanged
        sinfo11.Text = ElementaryTextBox.Text
    End Sub

    Private Sub ElemYearTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ElemYearTextBox.TextChanged
        sinfo12.Text = ElemYearTextBox.Text
    End Sub

    Private Sub SecondaryTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SecondaryTextBox.TextChanged
        sinfo13.Text = SecondaryTextBox.Text
    End Sub

    Private Sub SecondaryYearTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SecondaryYearTextBox.TextChanged
        sinfo14.Text = SecondaryYearTextBox.Text
    End Sub

    Private Sub LastAttendedTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LastAttendedTextBox.TextChanged
        sinfo15.Text = LastAttendedTextBox.Text
    End Sub

    Private Sub LastYearTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LastYearTextBox.TextChanged
        sinfo16.Text = LastYearTextBox.Text
    End Sub

    Private Sub DegreeTitleTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DegreeTitleTextBox.TextChanged
        sinfo102.Text = DegreeTitleTextBox.Text
    End Sub

    Private Sub nextBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nextBtn.Click
        studentGrades_form.Show()
        studentGrades_form.studentNo.Text = Me.sinfo1.Text
        studentGrades_form.studentName.Text = Me.sinfo2.Text + ", " + sinfo3.Text + " " + sinfo4.Text


        Me.Hide()
    End Sub


    Private Sub changePicLbl_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        graduateInfo_form.changePicLbl.Text = "True"

        graduateInfo_form.Show()
        graduateInfo_form.Button1.Text = sinfo2.Text + ", " + sinfo3.Text + " " + sinfo4.Text
        graduateInfo_form.studentNoLbl.Text = sinfo1.Text
        Me.Enabled = False
    End Sub

    Private Sub graduateCheckBox_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles graduateCheckBox.Click
        If graduateCheckBox.Checked = True Then
            If Label19.Text = "No" Then
                If sinfo17.Text = "" Then
                    graduateInfo_form.Show()
                    graduateInfo_form.Button1.Text = sinfo2.Text + ", " + sinfo3.Text + " " + sinfo4.Text
                    graduateInfo_form.studentNoLbl.Text = sinfo1.Text
                    Me.Enabled = False
                End If
            Else
                '
            End If
        End If
    End Sub

    Private Sub sinfo102_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sinfo102.TextChanged
        Label17.Text = sinfo102.Text
    End Sub

    Private Sub Label17_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label17.TextChanged
        If Not Label17.Text = "" Then
            Label18.Text = Label17.Text
        End If

    End Sub

    Private Sub currentQBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles currentQBtn.Click
        If cleardates = True Then
        Else
        End If

        Dim maxQ As String = Me.StudentsInfoTableAdapter.latest() + 1
        Me.StudentsInfoTableAdapter.UpdateQ(maxQ, currentQBtn.Text)
        If cleardates = True Then
            Me.StudentsInfoTableAdapter.clearDates(currentQBtn.Text)
            cleardates = False
        Else
            'do nothing
        End If

        Me.StudentsInfoTableAdapter.Fill(Me.TORdbDataSet.studentsInfo)
    End Sub

    Private Sub searchbox_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles searchbox.Click, searchLbl.Click
        searchbox.BackColor = Color.White
        searchLbl.BackColor = Color.White

    End Sub

    Private Sub searchbox_OnValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles searchbox.OnValueChanged
        If searchbox.Text = "" Then
            searchLbl.Visible = True
            clearSeacrch.Visible = False
            searchBtn.Enabled = False
            Me.StudentsInfoTableAdapter.Fill(Me.TORdbDataSet.studentsInfo)
            sinfo52.Visible = True
            sinfo82.Visible = True

        Else
            searchLbl.Visible = False
            clearSeacrch.Visible = True
            searchBtn.Enabled = True
        End If

    End Sub

    Private Sub clearSeacrch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles clearSeacrch.Click
        searchbox.ResetText()
    End Sub

    Private Sub searchBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles searchBtn.Click
        Dim studentSearch As String = searchbox.Text + "%"
        Me.StudentsInfoTableAdapter.searchStudent(Me.TORdbDataSet.studentsInfo, studentSearch, studentSearch, studentSearch, studentSearch)

        If sinfo1.Text = "" Then
            rf1.Visible = False
            rf2.Visible = False
            rf3.Visible = False
            rf4.Visible = False
            rf6.Visible = False
            rf7.Visible = False
            rf9.Visible = False
            rf11.Visible = False
            rf12.Visible = False
            rf13.Visible = False
            rf14.Visible = False
            rf15.Visible = False
            rf16.Visible = False
            sinfo52.Visible = False
            sinfo82.Visible = False
        Else
            sinfo52.Visible = True
            sinfo82.Visible = True

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
            Me.Hide()
        Else
            'do nothing
        End If
    End Sub

    Private Sub sinfo8_OnValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sinfo8.OnValueChanged
        DOA2TextBox.Text = sinfo8.Text
    End Sub

    Private Sub DOA2TextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DOA2TextBox.TextChanged
        sinfo82.Text = DOA2TextBox.Text
        sinfo8.Text = DOA2TextBox.Text
    End Sub

    Private Sub students_information_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
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

    Private Sub settingsSecret_button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles settingsSecret_button.Click
        settings_form.Show()
        settings_form.Left = Me.Left
        settings_form.Top = Me.Top
        kill = False
        Me.Close()
    End Sub

    Private Sub deleteBtn_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles deleteBtn.TextChanged
        If deleteBtn.Text = "Cancel" Then
            kill = True
            panelMenu.Enabled = False
            searchPanel.Enabled = False
            studentsTbl.Enabled = False
            nextBtn.Enabled = False

        ElseIf deleteBtn.Text = "Delete" Then

            panelMenu.Enabled = True
            searchPanel.Enabled = True
            studentsTbl.Enabled = True
            nextBtn.Enabled = True
        End If
    End Sub

    Private Sub BunifuCustomDataGrid1_MouseDown(sender As Object, e As MouseEventArgs)
        If e.Button = MouseButtons.Right Then
            MsgBox("Right Button Clicked")
        End If
    End Sub
End Class