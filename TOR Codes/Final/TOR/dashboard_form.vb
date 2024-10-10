Public Class dashboard_form

    Dim kill As Boolean = True
    Private Sub dashboard_main_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        If kill = True Then
            Application.Exit()
        Else
            'do nothing
        End If
    End Sub

    Private Sub dashboard_main_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If kill = True Then
            e.Cancel = True
            exiting_form.Show()
        Else
            'do nothing
        End If
    End Sub

    Private Sub Dashboard_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        totalPrintLbl.Text = TotalLabel1.Text
        user.Text = splashScreen_form.version_label.Text

        'TODO: This line of code loads data into the 'TORdbDataSet.totalPrint' table. You can move, or remove it, as needed.
        Me.TotalPrintTableAdapter.Fill(Me.TORdbDataSet.totalPrint)

        'TODO: This line of code loads data into the 'TORdbDataSet.database' table. You can move, or remove it, as needed.
        Me.DatabaseTableAdapter.Fill(Me.TORdbDataSet.database)
        'TODO: This line of code loads data into the 'TORdbDataSet.studentsInfo' table. You can move, or remove it, as needed.
        Dim bsit As Integer = Me.StudentsInfoTableAdapter.countBSIT()
        Dim bsba As Integer = Me.StudentsInfoTableAdapter.countBSBA()
        Dim bsa As Integer = Me.StudentsInfoTableAdapter.countBSA()
        Dim bscrim As Integer = Me.StudentsInfoTableAdapter.countCrim()
        Dim midwif As Integer = Me.StudentsInfoTableAdapter.countMid()

        Dim Gradbsit As Integer = Me.StudentsInfoTableAdapter.gradBSIT()
        Dim Gradbsba As Integer = Me.StudentsInfoTableAdapter.gradBSBA()
        Dim Gradbsa As Integer = Me.StudentsInfoTableAdapter.gradBSA()
        Dim Gradcrim As Integer = Me.StudentsInfoTableAdapter.gradBSCrim()
        Dim GradMid As Integer = Me.StudentsInfoTableAdapter.gradMid()


        Me.Chart1.Series(0).Points.AddXY("BSIT", bsit)
        Me.Chart1.Series(0).Points.AddXY("BSBA", bsba)
        Me.Chart1.Series(0).Points.AddXY("BSA", bsa)
        Me.Chart1.Series(0).Points.AddXY("BSCrim", bscrim)
        Me.Chart1.Series(0).Points.AddXY("Midwifery", midwif)

        Me.Chart1.Series(1).Points.AddXY("BSIT", Gradbsit)
        Me.Chart1.Series(1).Points.AddXY("BSBA", Gradbsba)
        Me.Chart1.Series(1).Points.AddXY("BSA", Gradbsa)
        Me.Chart1.Series(1).Points.AddXY("BSCrim", Gradcrim)
        Me.Chart1.Series(1).Points.AddXY("Midwifery", GradMid)

        Label9.Text = bsit
        Label11.Text = bsba
        Label10.Text = bsa
        Label12.Text = bscrim
        Label13.Text = midwif

        Me.Chart2.Series(0).Points.AddXY("BSIT", bsit)
        Me.Chart2.Series(0).Points.AddXY("BSBA", bsba)
        Me.Chart2.Series(0).Points.AddXY("BSA", bsa)
        Me.Chart2.Series(0).Points.AddXY("BSCrim", bscrim)
        Me.Chart2.Series(0).Points.AddXY("Midwifery", midwif)

        realTime.Start()
    End Sub

    Private Sub homeBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles homeBtn.Click
        home_form.Show()
        home_form.Left = Me.Left
        home_form.Top = Me.Top
        kill = False
        Me.Close()
    End Sub

    Private Sub dashboardBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dashboardBtn.Click

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

    Private Sub StudentsInfoBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.StudentsInfoBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.TORdbDataSet)

    End Sub

    Private Sub realTime_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles realTime.Tick
        Me.Validate()
        Me.StudentsInfoBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.TORdbDataSet)

        Me.Validate()
        Me.DatabaseBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.TORdbDataSet)

        totalStudentsLbl.Text = Me.StudentsInfoTableAdapter.totalStudents()
        totalGradLbl.Text = Me.StudentsInfoTableAdapter.totalGrad()
        Button4.Text = Me.StudentsInfoTableAdapter.totalStudents()

        Dim bsit As Integer = Me.StudentsInfoTableAdapter.countBSIT()
        Dim bsba As Integer = Me.StudentsInfoTableAdapter.countBSBA()
        Dim bsa As Integer = Me.StudentsInfoTableAdapter.countBSA()
        Dim bscrim As Integer = Me.StudentsInfoTableAdapter.countCrim()
        Dim midwif As Integer = Me.StudentsInfoTableAdapter.countMid()

        Label9.Text = bsit
        Label11.Text = bsba
        Label10.Text = bsa
        Label12.Text = bscrim
        Label13.Text = midwif

    End Sub


    Private Sub settingsBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles settingsBtn.Click
        access_form.Show()
        access_form.action_lbl.Text = "go_to_settings"
        access_form.message_lbl.Text = "Do you want to open Settings?"
        access_form.previousForm_label.Text = Me.Name
        access_form.password1.Focus()
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

    Private Sub TotalLabel1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TotalLabel1.TextChanged
        totalPrintLbl.Text = TotalLabel1.Text
    End Sub

    Private Sub settingsSecret_button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles settingsSecret_button.Click
        settings_form.Show()
        settings_form.Left = Me.Left
        settings_form.Top = Me.Top
        kill = False
        Me.Close()
    End Sub
End Class