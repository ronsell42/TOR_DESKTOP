Public Class studentGrades_form

    Dim kill As Boolean = True
    Dim prevSY As String
    Dim prevSem As String
    Dim onEdit As Boolean = False
    Dim searchBoxText As String = ""
    Dim PageNumbersTableAdapter As Object

    Private Sub students_grades_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        If kill = True Then
            Application.Exit()
        Else
            'do nothing
        End If
    End Sub

    Private Sub students_grades_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If kill = True Then
            e.Cancel = True
            exiting_form.Show()
        Else
            'do nothing
        End If
    End Sub

    Private Sub students_grades_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'TORdbDataSet.studentsInfo' table. You can move, or remove it, as needed.
        Me.StudentsInfoTableAdapter.Fill(Me.TORdbDataSet.studentsInfo)

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

        'TODO: This line of code loads data into the 'TORdbDataSet.subjects' table. You can move, or remove it, as needed.
        Me.SubjectsTableAdapter.Fill(Me.TORdbDataSet.subjects)

        Dim SYyear1 As String = Date.Now.ToString("yyyy")
        Dim SYyear2 As String = SYyear1 + 1
        Dim maxDrop1 As Integer = 28 'Equals to 20 MaxDropDownItems

        Do Until yearChoice.MaxDropDownItems = maxDrop1
            yearChoice.Items.Add(SYyear1 + "-" + SYyear2)
            SYyear1 = SYyear1 - 1
            SYyear2 = SYyear2 - 1
            yearChoice.MaxDropDownItems = yearChoice.MaxDropDownItems + 1
        Loop

        'Remarks.SelectedItem = Remarks.Items(0)

        SubjectCodeTextBox2.Text = SubjectCodeTextBox1.Text
        SubjectNameTextBox2.Text = SubjectNameTextBox1.Text
        CreditTextBox2.Text = CreditTextBox1.Text
        'GradeTextBox2.Text = GradeTextBox.Text
        'Remarks.Text = RemarksTextBox.Text

        Timer1.Start()
        subjectsTbl.Sort(subjectsTbl.Columns(0), System.ComponentModel.ListSortDirection.Descending)


    End Sub

    Private Sub syCb1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles yearChoice.TextChanged
        YearTakenTextBox.Text = yearChoice.Text
        prevSY = yearChoice.Text

    End Sub

    Private Sub semCb1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles semChoice.TextChanged
        SemTakenTextBox.Text = semChoice.Text
        prevSem = semChoice.Text
    End Sub

    Private Sub addBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles addBtn.Click
        onEdit = True
        If searchbox.Text = "" Or searchbox.Text = searchBoxText Then

        Else
            Dim searhSubj As String = searchbox.Text + "%"
            Me.SubjectsTableAdapter.seachSubject(Me.TORdbDataSet.subjects, searhSubj, searhSubj)
        End If


        addBtn.Enabled = False
        editBtn.Visible = False
        saveAddBtn.Visible = True
        deleteBtn.Text = "Cancel"

        Dim studentNum As String = studentNo.Text
        Dim year As String = yearSelect.Text
        Dim sem As String = semSelect.Text
        Me.StudentSubjectsTableAdapter.filter(Me.TORdbDataSet.studentSubjects, studentNum, year, sem)
        StudentSubjectsBindingSource.AddNew()

        SubjectCodeTextBox2.Text = SubjectCodeTextBox.Text
        SubjectNameTextBox2.Text = SubjectNameTextBox.Text
        CreditTextBox2.Text = CreditTextBox.Text
        yearChoice.SelectedItem = yearSelect.Text
        semChoice.SelectedItem = semSelect.Text

        addSubj.Text = "On"
        'subjectsTbl.Enabled = True
        ssTbl.Enabled = False
        gradePreview.Enabled = True
        StudentNoTextBox.Text = studentNo.Text


    End Sub

    Private Sub deleteBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles deleteBtn.Click
        If deleteBtn.Text = "Delete" Then
            If MsgBox("Are you sure you want to delete " + "'" + SubjectNameTextBox1.Text + "'" + " from " + studentName.Text + "'s" + " record? This action cannot be undone.", MsgBoxStyle.YesNo, "Student Subjects") = MsgBoxResult.Yes Then
                Try
                    StudentSubjectsBindingSource.RemoveCurrent()
                    Me.Validate()
                    Me.StudentSubjectsBindingSource.EndEdit()
                    Me.TableAdapterManager.UpdateAll(Me.TORdbDataSet)

                    semAterDelBtn_Click(sender, e)

                    MsgBox("Subject deleted!", MsgBoxStyle.Information, "Student Subjects")

                    If semList.Items.Count = 0 Then

                        semAterDelBtn_Click(sender, e)
                    End If

                Catch ex As Exception
                    If MsgBox("An error occured while deleting record. You nothing to delete or try again.", MsgBoxStyle.Exclamation) = MsgBoxResult.Ok Then

                    End If
                End Try

            End If

        ElseIf deleteBtn.Text = "Cancel" Then
            If addSubj.Text = "On" Then
                StudentSubjectsBindingSource.RemoveCurrent()
                addBtn.Enabled = True
                saveAddBtn.Visible = False
                saveEditBtn.Visible = False
                deleteBtn.Text = "Delete"


                addSubj.Text = "Off"
                'subjectsTbl.Enabled = False
                ssTbl.Enabled = True
                gradePreview.Enabled = False

                'Remarks.SelectedItem = Remarks.Items(0)
                addBtn.Enabled = True
                editBtn.Visible = True

                onEdit = False

            ElseIf addSubj.Text = "Off" Then
                addBtn.Enabled = True
                saveAddBtn.Visible = False
                saveEditBtn.Visible = False
                deleteBtn.Text = "Delete"

                yearChoice.Enabled = False
                semChoice.Enabled = False
                yearList.Enabled = True
                semList.Enabled = True
                gradePreview.Enabled = False

                addBtn.Enabled = True
                editBtn.Visible = True

                onEdit = False
            End If

        End If
    End Sub

    Private Sub saveAddBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles saveAddBtn.Click
        If rf1.Visible = True Or rf2.Visible = True Or rf3.Visible = True Or rf4.Visible = True Then
            MsgBox("Please complete the form to continue.", MsgBoxStyle.Exclamation)

        Else
            Dim reserveRemarks As String = ""
            reserveRemarks = Remarks.Text
            Dim subject = From studentSubjects In TORdbDataSet.studentSubjects
                 Where studentSubjects.subjectCode = SubjectCodeTextBox2.Text And studentSubjects.studentNo = StudentNoTextBox.Text
            Me.StudentSubjectsTableAdapter.Fill(Me.TORdbDataSet.studentSubjects)


            StudentSubjectsBindingSource.AddNew()
            StudentNoTextBox.Text = studentNo.Text
            SubjectCodeTextBox1.Text = SubjectCodeTextBox2.Text
            SubjectNameTextBox1.Text = SubjectNameTextBox2.Text
            CreditTextBox1.Text = CreditTextBox2.Text
            GradeTextBox.Text = GradeTextBox2.Text
            RemarksTextBox.Text = reserveRemarks
            YearTakenTextBox.Text = yearChoice.SelectedItem
            SemTakenTextBox.Text = semChoice.SelectedItem

            Try
                If subject.Count = 0 Then
                    Try
                        Me.Validate()
                        Me.StudentSubjectsBindingSource.EndEdit()
                        Me.TableAdapterManager.UpdateAll(Me.TORdbDataSet)
                        Me.StudentSubjectsTableAdapter.Fill(Me.TORdbDataSet.studentSubjects)
                        addSubj.Text = "Off"

                        distinctYearBtn_Click(sender, e)
                        yearList.SelectedItem = yearChoice.SelectedItem
                        semList.SelectedItem = semChoice.SelectedItem

                        addBtn.Enabled = True
                        saveAddBtn.Visible = False
                        editBtn.Visible = True
                        deleteBtn.Text = "Delete"

                        'subjectsTbl.Enabled = False
                        ssTbl.Enabled = True
                        gradePreview.Enabled = False

                        deleteBtn.Enabled = True
                        MsgBox("Saved!", MsgBoxStyle.Information)

                        onEdit = False

                    Catch ex As Exception
                        MsgBox("Error!", MsgBoxStyle.Exclamation)
                    End Try

                ElseIf subject.Count = 1 Then
                    Dim subjCode_scan As String = SubjectCodeTextBox1.Text
                    Dim studentNo_scan As String = studentNo.Text
                    Me.StudentSubjectsTableAdapter.distinctSubj(Me.TORdbDataSet.studentSubjects, studentNo_scan, subjCode_scan)

                    Dim yearTaken As String = YearTakenTextBox.Text
                    Dim semTaken As String = SemTakenTextBox.Text
                    MsgBox("Subject already exists on School Year " + yearTaken + ", " + semTaken + ".")

                    StudentSubjectsBindingSource.AddNew()

                    'StudentSubjectsDataGridView.Enabled = False
                End If
            Catch ex As Exception
                MsgBox("Save Error")
            End Try
        End If


    End Sub

    Private Sub GradeTextBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GradeTextBox2.SelectedIndexChanged
        If GradeTextBox2.Text = "5.0" Then
            Remarks.Text = "Failed"
        ElseIf GradeTextBox2.Text = "DRP" Then
            Remarks.Text = "Officially Dropped"
        ElseIf GradeTextBox2.Text = "INC" Then
            Remarks.Text = "Incomplete"
        Else
            Remarks.Text = "Passed"
        End If

    End Sub

    Private Sub addSubj_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles addSubj.TextChanged
        If addSubj.Text = "On" Then
            SubjectCodeTextBox2.Text = SubjectCodeTextBox.Text
            SubjectNameTextBox2.Text = SubjectNameTextBox.Text
            CreditTextBox2.Text = CreditTextBox.Text
            GradeTextBox2.Text = "0"

            yearChoice.Enabled = True
            semChoice.Enabled = True
            yearList.Enabled = False
            semList.Enabled = False

        ElseIf addSubj.Text = "Off" Then
            SubjectCodeTextBox2.Text = SubjectCodeTextBox1.Text
            SubjectNameTextBox2.Text = SubjectNameTextBox1.Text
            CreditTextBox2.Text = CreditTextBox1.Text

            yearChoice.Enabled = False
            semChoice.Enabled = False
            yearList.Enabled = True
            semList.Enabled = True
        End If
    End Sub

    Private Sub SubjectCodeTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SubjectCodeTextBox.TextChanged, SubjectNameTextBox.TextChanged, CreditTextBox.TextChanged
        If addSubj.Text = "On" Then
            SubjectCodeTextBox2.Text = SubjectCodeTextBox.Text
            SubjectNameTextBox2.Text = SubjectNameTextBox.Text
            CreditTextBox2.Text = CreditTextBox.Text
        Else
            'do nothing
        End If
    End Sub

    Private Sub IDTextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IDTextBox1.TextChanged, SubjectCodeTextBox1.TextChanged, SubjectNameTextBox1.TextChanged, CreditTextBox1.TextChanged, GradeTextBox.TextChanged, RemarksTextBox.TextChanged
        If addSubj.Text = "Off" Then
            SubjectCodeTextBox2.Text = SubjectCodeTextBox1.Text
            SubjectNameTextBox2.Text = SubjectNameTextBox1.Text
            CreditTextBox2.Text = CreditTextBox1.Text
            GradeTextBox2.Text = GradeTextBox.Text
            Remarks.Text = RemarksTextBox.Text

        Else
            'do nothing
        End If
    End Sub

    Private Sub backBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles backBtn.Click
        studentsInfo_form.Show()

        kill = False
        Me.Close()
    End Sub

    Private Sub distinctYearBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles distinctYearBtn.Click
        'step1
        Dim studentNum As String = studentNo.Text
        Me.StudentSubjectsTableAdapter.distinctYear(Me.TORdbDataSet.studentSubjects, studentNum)

        'step2
        yearList.Items.Clear()
        Dim listCount As Integer = 0
        Dim yearCount As Integer

        yearCount = ssTbl.RowCount

        Do Until listCount = yearCount

            yearList.Items.Add(year.Text)

            StudentSubjectsBindingSource.MoveNext()
            listCount = listCount + 1
        Loop

        Try
            yearList.SelectedItem = yearList.Items(0)
            distinctSem_Click(sender, e)
            yearList_Click(sender, e)

        Catch ex As Exception
            reportBtn.Enabled = False
            yearChoice.SelectedItem = yearChoice.Items(0)
            semChoice.SelectedItem = semChoice.Items(0)

            addBtn_Click(sender, e)
            deleteBtn.Enabled = False
            MsgBox("No subjects yet. Please add some to continue.")
            backBtn.Enabled = True
        End Try

    End Sub

    Private Sub yearList_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles yearList.SelectedIndexChanged
        yearSelect.Text = yearList.SelectedItem

        distinctSem_Click(sender, e)

        If Not yearSelect.Text = yearSelect.Name And Not semSelect.Text = semSelect.Name Then
            Dim studentNum As String = studentNo.Text
            Dim year As String = yearSelect.Text
            Dim sem As String = semSelect.Text
            Me.StudentSubjectsTableAdapter.filter(Me.TORdbDataSet.studentSubjects, studentNum, year, sem)
        End If
    End Sub

    Private Sub semList_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles semList.SelectedIndexChanged
        semSelect.Text = semList.SelectedItem
    End Sub

    Private Sub distinctSem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles distinctSem.Click

        'step 1
        Dim studentNum As String = studentNo.Text
        Dim year As String = yearSelect.Text
        Me.StudentSubjectsTableAdapter.distinctSem(Me.TORdbDataSet.studentSubjects, studentNum, year)

        'step2
        semList.Items.Clear()
        Dim listCount As Integer = 0
        Dim semCount As Integer

        semCount = ssTbl.RowCount

        Do Until listCount = semCount

            semList.Items.Add(sem.Text)
            StudentSubjectsBindingSource.MoveNext()
            listCount = listCount + 1
        Loop

        Try
            semList.SelectedItem = semList.Items(0)

        Catch ex As Exception

        End Try
    End Sub

    Private Sub resetTabe_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles resetTable.Click
        Me.StudentSubjectsTableAdapter.Fill(Me.TORdbDataSet.studentSubjects)
    End Sub

    Private Sub semListLbl_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles semSelect.TextChanged
        If Not yearSelect.Text = yearSelect.Name And Not semSelect.Text = semSelect.Name Then
            Dim studentNum As String = studentNo.Text
            Dim year As String = yearSelect.Text
            Dim sem As String = semSelect.Text
            Me.StudentSubjectsTableAdapter.filter(Me.TORdbDataSet.studentSubjects, studentNum, year, sem)

        End If
    End Sub

    Private Sub semList_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles semList.Click
        If Not yearSelect.Text = yearSelect.Name And Not semSelect.Text = semSelect.Name Then
            Dim studentNum As String = studentNo.Text
            Dim year As String = yearSelect.Text
            Dim sem As String = semSelect.Text
            Me.StudentSubjectsTableAdapter.filter(Me.TORdbDataSet.studentSubjects, studentNum, year, sem)
        End If
    End Sub

    Private Sub yearList_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles yearList.Click
        distinctSem_Click(sender, e)

        If Not yearSelect.Text = yearSelect.Name And Not semSelect.Text = semSelect.Name Then
            Dim studentNum As String = studentNo.Text
            Dim year As String = yearSelect.Text
            Dim sem As String = semSelect.Text
            Me.StudentSubjectsTableAdapter.filter(Me.TORdbDataSet.studentSubjects, studentNum, year, sem)
        End If
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Label2.Text = Label2.Text - 1
    End Sub

    Private Sub Label2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.TextChanged
        If Label2.Text = 1 Then
            Timer1.Stop()
            distinctYearBtn_Click(sender, e)
            Dim maxYear As Integer = yearList.Items.Count
            yearList.SelectedIndex = maxYear - 1

            Dim maxSem As Integer = semList.Items.Count
            Timer2.Stop()
            semList.SelectedIndex = maxSem - 1
        End If

    End Sub

    Private Sub editBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles editBtn.Click
        onEdit = True
        editBtn.Visible = False

        yearChoice.Enabled = True
        semChoice.Enabled = True
        yearList.Enabled = False
        semList.Enabled = False

        gradePreview.Enabled = True

        addBtn.Enabled = False
        saveEditBtn.Visible = True
        deleteBtn.Text = "Cancel"

        yearChoice.SelectedItem = YearTakenTextBox.Text
        semChoice.SelectedItem = SemTakenTextBox.Text

    End Sub

    Private Sub yearChoice_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles yearChoice.SelectedIndexChanged, semChoice.SelectedIndexChanged
        If addSubj.Text = "On" Then

            Dim studentNum As String = studentNo.Text
            Dim year As String = yearChoice.Text
            Dim sem As String = semChoice.Text
            Me.StudentSubjectsTableAdapter.filter(Me.TORdbDataSet.studentSubjects, studentNum, year, sem)
            StudentSubjectsBindingSource.AddNew()
        End If
    End Sub

    Private Sub saveEditBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles saveEditBtn.Click
        If rf1.Visible = True Or rf2.Visible = True Or rf3.Visible = True Or rf4.Visible = True Then
            MsgBox("Please complete the form to continue.", MsgBoxStyle.Exclamation)

        Else
            Dim reserveRemarks As String = ""
            reserveRemarks = Remarks.Text

            StudentNoTextBox.Text = studentNo.Text
            SubjectCodeTextBox1.Text = SubjectCodeTextBox2.Text
            SubjectNameTextBox1.Text = SubjectNameTextBox2.Text
            CreditTextBox1.Text = CreditTextBox2.Text
            GradeTextBox.Text = GradeTextBox2.SelectedItem
            RemarksTextBox.Text = reserveRemarks
            YearTakenTextBox.Text = yearChoice.SelectedItem
            SemTakenTextBox.Text = semChoice.SelectedItem

            Try
                Me.Validate()
                Me.StudentSubjectsBindingSource.EndEdit()
                Me.TableAdapterManager.UpdateAll(Me.TORdbDataSet)

                yearList.SelectedItem = yearChoice.SelectedItem
                semList.SelectedItem = semChoice.SelectedItem
                GradeTextBox.Text = GradeTextBox2.Text
                RemarksTextBox.Text = Remarks.Text

                addBtn.Enabled = True
                saveAddBtn.Visible = False
                saveEditBtn.Visible = False
                editBtn.Visible = True
                deleteBtn.Text = "Delete"

                'subjectsTbl.Enabled = False
                ssTbl.Enabled = True
                gradePreview.Enabled = False

                yearChoice.Enabled = False
                semChoice.Enabled = False
                yearList.Enabled = True
                semList.Enabled = True

                distinctYearBtn_Click(sender, e)

                yearList.SelectedItem = yearChoice.SelectedItem
                semList.SelectedItem = semChoice.SelectedItem

                deleteBtn.Enabled = True

                MsgBox("Saved!", MsgBoxStyle.Information)
                onEdit = False
            Catch ex As Exception
                MsgBox("Error!", MsgBoxStyle.Exclamation)
            End Try
        End If



    End Sub

    Private Sub semAterDelBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles semAterDelBtn.Click
        distinctYearBtn_Click(sender, e)
        Dim maxYear As Integer = yearList.Items.Count
        yearList.SelectedIndex = maxYear - 1

        Label3.Text = 2
        Timer2.Start()

    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        Label3.Text = Label3.Text - 1
    End Sub

    Private Sub Label3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.TextChanged
        Dim maxSem As Integer = semList.Items.Count
        If Label3.Text = 1 Then
            Timer2.Stop()
            semList.SelectedIndex = maxSem - 1

        End If
    End Sub

    Private Sub gradePreview_EnabledChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gradePreview.EnabledChanged
        If gradePreview.Enabled = True Then
            PanelList.Left = 825
            gradePreview.Top = 239
            panelChoice.Left = 533

        Else
            PanelList.Left = 533
            gradePreview.Top = 326
            panelChoice.Left = 825
            gradePreview.Top = 326
        End If
    End Sub

    Private Sub reportBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles reportBtn.Click
        report_form.Show()
        report_form.Left = Me.Left
        report_form.Top = Me.Top

        report_form.studentNumber.Text = Me.studentNo.Text


        Dim ds As New TORdbDataSet
        Dim info As New TORdbDataSetTableAdapters.studentsInfoTableAdapter
        Dim subjects As New TORdbDataSetTableAdapters.studentSubjectsTableAdapter
        Dim pageNumbers As New TORdbDataSetTableAdapters.pageNumbersTableAdapter

        Dim studentNum = Me.studentNo.Text
        info.filterInfo(ds.studentsInfo, studentNum)
        subjects.FilteredSubj(ds.studentSubjects, studentNum)
        pageNumbers.filterPage(ds.pageNumbers, studentNum)

        Dim rpt As New report_report
        rpt.SetDataSource(ds)
        report_form.CrystalReportViewer1.ReportSource = rpt

        'rpt.SetParameterValue(0, TextBox1.Text)

        report_form.CrystalReportViewer1.ShowLastPage()
        report_form.maxpage.Text = report_form.CrystalReportViewer1.GetCurrentPageNumber()
        report_form.CrystalReportViewer1.ShowNthPage(report_form.minPage.Text)
        '-------------------------------------------------------
        report_form.currentPageLbl.Text = report_form.minPage.Text
        report_form.maxPageLbl.Text = report_form.maxpage.Text

        If report_form.CrystalReportViewer1.GetCurrentPageNumber() = report_form.maxpage.Text Then
            report_form.previousPageBtn.Image = TOR.My.Resources.Resources.previousPage_2
            report_form.previousPageBtn.Cursor = Cursors.Arrow
            report_form.previousPageBtn.Enabled = False
            report_form.nextPageBtn.Image = TOR.My.Resources.Resources.nextPage_2
            report_form.nextPageBtn.Cursor = Cursors.Arrow
            report_form.nextPageBtn.Enabled = False
        Else
            report_form.previousPageBtn.Image = TOR.My.Resources.Resources.previousPage_2
            report_form.previousPageBtn.Cursor = Cursors.Arrow
            report_form.previousPageBtn.Enabled = False
            report_form.nextPageBtn.Image = TOR.My.Resources.Resources.nextPage_1
            report_form.nextPageBtn.Cursor = Cursors.Hand
            report_form.nextPageBtn.Enabled = True
        End If

        report_form.CrystalReportViewer1.Zoom(85)
        Me.Hide()
    End Sub

    Private Sub searchbox_OnValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles searchbox.OnValueChanged
        If searchbox.Text = "" Then
            searchLbl.Visible = True
            clearSearchBtn.Visible = False
        Else
            searchLbl.Visible = False
            clearSearchBtn.Visible = True
        End If

        searchBoxText = searchbox.Text
        Dim searhSubj As String = searchbox.Text + "%"
        Me.SubjectsTableAdapter.seachSubject(Me.TORdbDataSet.subjects, searhSubj, searhSubj)

    End Sub

    Private Sub clearSearchBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles clearSearchBtn.Click
        searchbox.ResetText()
    End Sub

    Private Sub SubjectCodeTextBox2_OnValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SubjectCodeTextBox2.OnValueChanged
        If SubjectCodeTextBox2.Text = "" Then
            rf1.Visible = True
        Else
            rf1.Visible = False

        End If
    End Sub

    Private Sub SubjectNameTextBox2_OnValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SubjectNameTextBox2.OnValueChanged
        If SubjectNameTextBox2.Text = "" Then
            rf2.Visible = True
        Else
            rf2.Visible = False
        End If
    End Sub

    Private Sub CreditTextBox2_OnValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CreditTextBox2.OnValueChanged
        If CreditTextBox2.Text = "" Then
            rf3.Visible = True
        Else
            rf3.Visible = False
        End If
    End Sub

    Private Sub Remarks_OnValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Remarks.OnValueChanged
        If Remarks.Text = "" Then
            rf4.Visible = True
        Else
            rf4.Visible = False
        End If
    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        StudentsInfoTableAdapter.findRemarks(Me.TORdbDataSet.studentsInfo, studentNo.Text)
    End Sub

    Private Sub studentNo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles studentNo.TextChanged
        StudentsInfoTableAdapter.findRemarks(Me.TORdbDataSet.studentsInfo, studentNo.Text)
    End Sub


    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        studentsInfo_form.Show()

        kill = False
        Me.Close()
    End Sub

    Private Sub deleteBtn_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles deleteBtn.TextChanged
        If deleteBtn.Text = "Cancel" Then
            kill = True
            'PictureBox3.Enabled = False
            searchPanel.Enabled = False
            ssTbl.Enabled = False

            reportBtn.Enabled = False
            backBtn.Enabled = False

        ElseIf deleteBtn.Text = "Delete" Then

            'PictureBox3.Enabled = True
            searchPanel.Enabled = True
            ssTbl.Enabled = True

            reportBtn.Enabled = True
            backBtn.Enabled = True
        End If
    End Sub

End Class