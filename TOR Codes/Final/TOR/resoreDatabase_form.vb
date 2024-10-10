Public Class Restore_Database
    Dim kill As Boolean = True
    Dim restart As Boolean = False

    Private Sub Restore_Database_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'TORdbDataSet.database' table. You can move, or remove it, as needed.
        ' Me.DatabaseTableAdapter.Fill(Me.TORdbDataSet.database)

    End Sub

    Private Sub Restore_Database_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If restart = True Then
            Application.Restart()
        Else
            If kill = True Then
                e.Cancel = True
                exiting_form.Show()
            Else
                'do nothing
            End If
        End If
        
    End Sub

    Private Sub browse_button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles browse_button.Click
        If OpenFileDialog1.ShowDialog = DialogResult.OK Then
            restorePath_textbox.Text = OpenFileDialog1.FileName
        End If
    End Sub

    Private Sub restoreData_button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles restoreData_button.Click
        If restorePath_textbox.Text.Contains("TORdb.mdb") Then
            IO.File.Delete("C:\Transcript\TORdb.mdb")
            IO.File.Copy(OpenFileDialog1.FileName, "C:\Transcript\TORdb.mdb")
            MsgBox("Backup Sucessful. The System will start again.", MsgBoxStyle.Information, "Transcript")

            restart = True
            Me.Close()

        Else
            MsgBox("Invalid file for the scpecified database!", MsgBoxStyle.Exclamation, "Transcript")
        End If
    End Sub

    Private Sub undoChange1_btton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles undoChange1_btton.Click
        If OpenFileDialog1.FileName = "TORdb.mdb" Then
            restorePath_textbox.ResetText()
        Else
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


    Private Sub clearSearch2_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles clearSearch2_btn.Click
        restorePath_textbox.Text = ""
    End Sub

End Class