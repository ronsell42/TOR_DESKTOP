Public Class splashScreen_form

    Dim seconds As Integer = 0

    Private Sub splashScreen_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'TORdbDataSet.database' table. You can move, or remove it, as needed.
        Me.DatabaseTableAdapter.Fill(Me.TORdbDataSet.database)
        loader.Start()

    End Sub

    Private Sub loader_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles loader.Tick
        seconds = seconds + 1
        If seconds = 1 Then
            login_form.Show()
            loader.Stop()
            Me.Hide()
        End If
    End Sub

    Private Sub version_label_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles version_label.TextChanged
        home_form.user.Text = version_label.Text
        dashboard_form.user.Text = version_label.Text
        studentsInfo_form.user.Text = version_label.Text
        subjects_form.user.Text = version_label.Text
        settings_form.user.Text = version_label.Text

    End Sub

    Private Sub DatabaseBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.DatabaseBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.TORdbDataSet)

    End Sub
End Class