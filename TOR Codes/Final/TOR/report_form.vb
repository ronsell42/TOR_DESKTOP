Public Class report_form

    Dim kill As Boolean = True
    Dim plus1 As String = ""

    Private Sub backBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles backBtn.Click
        If MsgBox("Going back will reset all your custom spaces. Click 'Yes' to continue.", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then

            ' Me.StudentSubjectsTableAdapter.deleteFiller()
            ' Me.refreshBtn.PerformClick()
            ' students_grades.Show()
            'students_grades.Left = Me.Left
            'students_grades.Top = Me.Top
            'Me.Close()

            Me.StudentSubjectsTableAdapter.deleteFiller()
            refreshBtn.PerformClick()
            customSpacer_form.customSpacingBtn.Text = "Add New Space"
            customSpacer_form.SYCBox.Enabled = False
            customSpacer_form.semCBox.Enabled = False
            customSpacer_form.addBtn.Enabled = False
            refreshBtn.Enabled = True

            studentGrades_form.Show()
            studentGrades_form.Left = Me.Left
            studentGrades_form.Top = Me.Top
            Me.Hide()

        End If

    End Sub

    Private Sub nextPage()
        CrystalReportViewer1.ShowNextPage()
        curentPage.Text = CrystalReportViewer1.GetCurrentPageNumber()
        currentPageLbl.Text = curentPage.Text

    End Sub

    Private Sub previousPageBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles previousPageBtn.Click

        CrystalReportViewer1.ShowPreviousPage()

        curentPage.Text = CrystalReportViewer1.GetCurrentPageNumber()
        If curentPage.Text = maxpage.Text Then
            nextPageBtn.Image = TOR.My.Resources.Resources.nextPage_2
            nextPageBtn.Enabled = False
        Else
            nextPageBtn.Image = TOR.My.Resources.Resources.nextPage_1
            nextPageBtn.Enabled = True
        End If
        If curentPage.Text = minPage.Text Then
            previousPageBtn.Image = TOR.My.Resources.Resources.previousPage_2
            previousPageBtn.Enabled = False
        Else
            previousPageBtn.Image = TOR.My.Resources.Resources.previousPage_1
            previousPageBtn.Enabled = True
        End If
        currentPageLbl.Text = curentPage.Text
    End Sub

    Private Sub refreshBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles refreshBtn.Click
        Dim prevPage As String
        prevPage = currentPageLbl.Text
        Me.report_Load(sender, e)
        Do Until currentPageLbl.Text = prevPage
            nextPageBtn_Click(sender, e)
        Loop

        customSpacer_form.customSpacingBtn.Text = "Add New Space"
        customSpacer_form.SYCBox.Enabled = False
        customSpacer_form.semCBox.Enabled = False
        customSpacer_form.addBtn.Enabled = False
    End Sub

    Private Sub printBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles printBtn.Click
        CrystalReportViewer1.PrintReport()
        If MsgBox("Do you want to add this print to TOR release?", MsgBoxStyle.YesNo, "Students Record") = MsgBoxResult.Yes Then

            Dim add = TotalLabel1.Text + 1
            Me.TotalPrintTableAdapter.updatePrinted(add)
        End If
    End Sub

    Private Sub nextPageBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nextPageBtn.Click
        CrystalReportViewer1.ShowNextPage()
        curentPage.Text = CrystalReportViewer1.GetCurrentPageNumber()
        currentPageLbl.Text = curentPage.Text
        If curentPage.Text = maxpage.Text Then
            nextPageBtn.Image = TOR.My.Resources.Resources.nextPage_2
            nextPageBtn.Enabled = False
        Else
            nextPageBtn.Image = TOR.My.Resources.Resources.nextPage_1
            nextPageBtn.Enabled = True
        End If
        If curentPage.Text = minPage.Text Then
            previousPageBtn.Image = TOR.My.Resources.Resources.previousPage_2
            previousPageBtn.Enabled = False
        Else
            previousPageBtn.Image = TOR.My.Resources.Resources.previousPage_1
            previousPageBtn.Enabled = True
        End If
    End Sub

    Private Sub PageNumbersBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.PageNumbersBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.TORdbDataSet)

    End Sub


    Private Sub PageNumbersBindingNavigatorSaveItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.PageNumbersBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.TORdbDataSet)

    End Sub

    Private Sub report_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        If kill = True Then
            Me.StudentSubjectsTableAdapter.deleteFiller()
            Application.Exit()
        Else
            'do nothing
        End If
    End Sub

    Private Sub report_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If kill = True Then
            e.Cancel = True
            exiting_form.Show()
        Else
            'do nothing
        End If

    End Sub

    Private Sub report_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'TORdbDataSet.totalPrint' table. You can move, or remove it, as needed.
        Me.TotalPrintTableAdapter.Fill(Me.TORdbDataSet.totalPrint)
        'TODO: This line of code loads data into the 'TORdbDataSet.studentsInfo' table. You can move, or remove it, as needed.
        Me.StudentsInfoTableAdapter.Fill(Me.TORdbDataSet.studentsInfo)

        studentNumber.Text = studentGrades_form.studentNo.Text
        'Me.StudentsInfoTableAdapter.getSoNumber(Me.TORdbDataSet.studentsInfo, studentNumber.Text)

        Dim ds As New TORdbDataSet
        Dim info As New TORdbDataSetTableAdapters.studentsInfoTableAdapter
        Dim subjects As New TORdbDataSetTableAdapters.studentSubjectsTableAdapter
        Dim pageNumbers As New TORdbDataSetTableAdapters.pageNumbersTableAdapter

        Dim studentNum = Me.studentNumber.Text
        info.filterInfo(ds.studentsInfo, studentNum)
        subjects.FilteredSubj(ds.studentSubjects, studentNum)
        pageNumbers.filterPage(ds.pageNumbers, studentNum)

        Dim rpt As New report_report
        rpt.SetDataSource(ds)
        CrystalReportViewer1.ReportSource = rpt

        CrystalReportViewer1.ShowLastPage()
        maxpage.Text = CrystalReportViewer1.GetCurrentPageNumber()
        CrystalReportViewer1.ShowNthPage(minPage.Text)
        '-------------------------------------------------------
        currentPageLbl.Text = minPage.Text
        maxPageLbl.Text = maxpage.Text

        If CrystalReportViewer1.GetCurrentPageNumber() = maxpage.Text Then
            previousPageBtn.Image = TOR.My.Resources.Resources.previousPage_2
            previousPageBtn.Cursor = Cursors.Arrow
            previousPageBtn.Enabled = False
            nextPageBtn.Image = TOR.My.Resources.Resources.nextPage_2
            nextPageBtn.Cursor = Cursors.Arrow
            nextPageBtn.Enabled = False
        Else
            previousPageBtn.Image = TOR.My.Resources.Resources.previousPage_2
            previousPageBtn.Cursor = Cursors.Arrow
            previousPageBtn.Enabled = False
            nextPageBtn.Image = TOR.My.Resources.Resources.nextPage_1
            nextPageBtn.Cursor = Cursors.Hand
            nextPageBtn.Enabled = True
        End If

        CrystalReportViewer1.Zoom(85)

        'TODO: This line of code loads data into the 'TORdbDataSet.studentSubjects' table. You can move, or remove it, as needed.
        Me.StudentSubjectsTableAdapter.Fill(Me.TORdbDataSet.studentSubjects)
        'TODO: This line of code loads data into the 'TORdbDataSet.pageNumbers' table. You can move, or remove it, as needed.
        Me.PageNumbersTableAdapter.Fill(Me.TORdbDataSet.pageNumbers)

        With customSpacer_form
            .TopLevel = False
            Panel11.Controls.Add(customSpacer_form)
            .BringToFront()
            .Show()
            customSpacer_form.studentNum.Text = Me.studentNumber.Text
        End With

    End Sub


    Private Sub currentPageLbl_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles currentPageLbl.TextChanged
        plus1 = currentPageLbl.Text + 1
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim ds As New TORdbDataSet
        Dim info As New TORdbDataSetTableAdapters.studentsInfoTableAdapter
        Dim subjects As New TORdbDataSetTableAdapters.studentSubjectsTableAdapter
        'Dim pageNumbers As New TORdbDataSetTableAdapters.pageNumbersTableAdapter

        Dim studentNum = studentGrades_form.studentNo.Text
        info.filterInfo(ds.studentsInfo, studentNum)

        subjects.FilteredSubj(ds.studentSubjects, studentNum)
        PageNumbersTableAdapter.filterPage(ds.pageNumbers, studentNum)

        Dim rpt As New report_report
        rpt.SetDataSource(ds)
        CrystalReportViewer1.ReportSource = rpt

        'rpt.SetParameterValue(1, "REMARKS: Continued on page")

        CrystalReportViewer1.ShowLastPage()
        maxpage.Text = CrystalReportViewer1.GetCurrentPageNumber()
        CrystalReportViewer1.ShowNthPage(minPage.Text)
        '-------------------------------------------------------
        currentPageLbl.Text = minPage.Text
        maxPageLbl.Text = maxpage.Text

        If Me.CrystalReportViewer1.GetCurrentPageNumber() = Me.maxpage.Text Then
            Me.previousPageBtn.Image = TOR.My.Resources.Resources.previousPage_2
            Me.previousPageBtn.Cursor = Cursors.Arrow
            Me.previousPageBtn.Enabled = False
            Me.nextPageBtn.Image = TOR.My.Resources.Resources.nextPage_2
            Me.nextPageBtn.Cursor = Cursors.Arrow
            Me.nextPageBtn.Enabled = False
        Else
            Me.previousPageBtn.Image = TOR.My.Resources.Resources.previousPage_2
            Me.previousPageBtn.Cursor = Cursors.Arrow
            Me.previousPageBtn.Enabled = False
            Me.nextPageBtn.Image = TOR.My.Resources.Resources.nextPage_1
            Me.nextPageBtn.Cursor = Cursors.Hand
            Me.nextPageBtn.Enabled = True
        End If

        Me.CrystalReportViewer1.Zoom(85)
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nextBtn.Click
        'INITIALIZE TO DEFAULT FORMAT
        IO.File.Delete("C:\Transcript\process1_format_notGrad_step1_1pages.docx")
        IO.File.Copy("C:\Transcript\origFormat_process1_format_notGrad_step1_1pages.docx", "C:\Transcript\process1_format_notGrad_step1_1pages.docx")

        IO.File.Delete("C:\Transcript\process1_format_notGrad_step1_2pages.docx")
        IO.File.Copy("C:\Transcript\origFormat_process1_format_notGrad_step1_2pages.docx", "C:\Transcript\process1_format_notGrad_step1_2pages.docx")

        IO.File.Delete("C:\Transcript\process1_format_notGrad_step1_3pages.docx")
        IO.File.Copy("C:\Transcript\origFormat_process1_format_notGrad_step1_3pages.docx", "C:\Transcript\process1_format_notGrad_step1_3pages.docx")

        IO.File.Delete("C:\Transcript\process1_format_notGrad_step1_4pages.docx")
        IO.File.Copy("C:\Transcript\origFormat_process1_format_notGrad_step1_4pages.docx", "C:\Transcript\process1_format_notGrad_step1_4pages.docx")

        IO.File.Delete("C:\Transcript\process1_format_notGrad_step1_5pages.docx")
        IO.File.Copy("C:\Transcript\origFormat_process1_format_notGrad_step1_5pages.docx", "C:\Transcript\process1_format_notGrad_step1_5pages.docx")

        IO.File.Delete("C:\Transcript\process1_format_notGrad_step1_6pages.docx")
        IO.File.Copy("C:\Transcript\origFormat_process1_format_notGrad_step1_6pages.docx", "C:\Transcript\process1_format_notGrad_step1_6pages.docx")

        IO.File.Delete("C:\Transcript\process1_format_notGrad_step1_7pages.docx")
        IO.File.Copy("C:\Transcript\origFormat_process1_format_notGrad_step1_7pages.docx", "C:\Transcript\process1_format_notGrad_step1_7pages.docx")

        'FOR GRADUATE FORMAT
        IO.File.Delete("C:\Transcript\process1_format_grad_step1_1pages.docx")
        IO.File.Copy("C:\Transcript\origFormat_process1_format_grad_step1_1pages.docx", "C:\Transcript\process1_format_grad_step1_1pages.docx")

        IO.File.Delete("C:\Transcript\process1_format_grad_step1_2pages.docx")
        IO.File.Copy("C:\Transcript\origFormat_process1_format_grad_step1_2pages.docx", "C:\Transcript\process1_format_grad_step1_2pages.docx")

        IO.File.Delete("C:\Transcript\process1_format_grad_step1_3pages.docx")
        IO.File.Copy("C:\Transcript\origFormat_process1_format_grad_step1_3pages.docx", "C:\Transcript\process1_format_grad_step1_3pages.docx")

        IO.File.Delete("C:\Transcript\process1_format_grad_step1_4pages.docx")
        IO.File.Copy("C:\Transcript\origFormat_process1_format_grad_step1_4pages.docx", "C:\Transcript\process1_format_grad_step1_4pages.docx")

        IO.File.Delete("C:\Transcript\process1_format_grad_step1_5pages.docx")
        IO.File.Copy("C:\Transcript\origFormat_process1_format_grad_step1_5pages.docx", "C:\Transcript\process1_format_grad_step1_5pages.docx")

        IO.File.Delete("C:\Transcript\process1_format_grad_step1_6pages.docx")
        IO.File.Copy("C:\Transcript\origFormat_process1_format_grad_step1_6pages.docx", "C:\Transcript\process1_format_grad_step1_6pages.docx")

        IO.File.Delete("C:\Transcript\process1_format_grad_step1_7pages.docx")
        IO.File.Copy("C:\Transcript\origFormat_process1_format_grad_step1_7pages.docx", "C:\Transcript\process1_format_grad_step1_7pages.docx")

        MsgBox("The system will open Microsoft Word.")

        If soNumber.Text = "" Then 'No value ‪

            If maxPageLbl.Text = "1" Then
                System.Diagnostics.Process.Start("C:\Transcript\process1_format_notGrad_step1_1pages.docx")

            ElseIf maxPageLbl.Text = "2" Then
                System.Diagnostics.Process.Start("C:\Transcript\process1_format_notGrad_step1_2pages.docx")

            ElseIf maxPageLbl.Text = "3" Then
                System.Diagnostics.Process.Start("C:\Transcript\process1_format_notGrad_step1_3pages.docx")


            ElseIf maxPageLbl.Text = "4" Then
                System.Diagnostics.Process.Start("C:\Transcript\process1_format_notGrad_step1_4pages.docx")

            ElseIf maxPageLbl.Text = "5" Then
                System.Diagnostics.Process.Start("C:\Transcript\process1_format_notGrad_step1_5pages.docx")

            ElseIf maxPageLbl.Text = "6" Then
                System.Diagnostics.Process.Start("C:\Transcript\process1_format_notGrad_step1_6pages.docx")

            ElseIf maxPageLbl.Text = "7" Then
                System.Diagnostics.Process.Start("C:\Transcript\process1_format_notGrad_step1_7pages.docx")
            Else
                MsgBox("Number of pages reaches the limit of the system.")
            End If

        Else 'if graduated student
            If maxPageLbl.Text = "1" Then
                System.Diagnostics.Process.Start("C:\Transcript\process1_format_grad_step1_1pages.docx")

            ElseIf maxPageLbl.Text = "2" Then
                System.Diagnostics.Process.Start("C:\Transcript\process1_format_grad_step1_2pages.docx")

            ElseIf maxPageLbl.Text = "3" Then
                System.Diagnostics.Process.Start("C:\Transcript\process1_format_grad_step1_3pages.docx")

            ElseIf maxPageLbl.Text = "4" Then
                System.Diagnostics.Process.Start("C:\Transcript\process1_format_grad_step1_4pages.docx")

            ElseIf maxPageLbl.Text = "5" Then
                System.Diagnostics.Process.Start("C:\Transcript\process1_format_grad_step1_5pages.docx")

            ElseIf maxPageLbl.Text = "6" Then
                System.Diagnostics.Process.Start("C:\Transcript\process1_format_grad_step1_6pages.docx")

            ElseIf maxPageLbl.Text = "7" Then
                System.Diagnostics.Process.Start("C:\Transcript\process1_format_grad_step1_7pages.docx")
            Else
                MsgBox("Number of pages reaches the limit of the system.")
            End If
        End If


    End Sub

    Private Sub addBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Me.Validate()
            Me.StudentSubjectsBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.TORdbDataSet)
            Me.StudentSubjectsTableAdapter.Fill(Me.TORdbDataSet.studentSubjects)
            'refreshBtn_Click(sender, e)s

            MsgBox("Added")
        Catch ex As Exception
            MsgBox("An unexpected error occured. Try to close this page and reopen.")
        End Try

    End Sub

    Private Sub studentNumber_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles studentNumber.TextChanged
        soNumber.Text = Me.StudentsInfoTableAdapter.getSoNumber(studentNumber.Text)

    End Sub

End Class