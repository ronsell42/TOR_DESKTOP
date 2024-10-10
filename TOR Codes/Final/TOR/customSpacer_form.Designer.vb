<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class customSpacer_form
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim SubjectCodeLabel As System.Windows.Forms.Label
        Dim SubjectNameLabel As System.Windows.Forms.Label
        Dim CreditLabel As System.Windows.Forms.Label
        Dim GradeLabel As System.Windows.Forms.Label
        Dim RemarksLabel As System.Windows.Forms.Label
        Dim SemTakenLabel As System.Windows.Forms.Label
        Dim FillerLabel As System.Windows.Forms.Label
        Dim StudentNoLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim IDLabel As System.Windows.Forms.Label
        Dim Label4 As System.Windows.Forms.Label
        Me.SubjectCodeTextBox = New System.Windows.Forms.TextBox()
        Me.StudentSubjectsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TORdbDataSet = New TOR.TORdbDataSet()
        Me.SubjectNameTextBox = New System.Windows.Forms.TextBox()
        Me.CreditTextBox = New System.Windows.Forms.TextBox()
        Me.GradeTextBox = New System.Windows.Forms.TextBox()
        Me.RemarksTextBox = New System.Windows.Forms.TextBox()
        Me.YearTakenTextBox = New System.Windows.Forms.TextBox()
        Me.SemTakenTextBox = New System.Windows.Forms.TextBox()
        Me.FillerTextBox = New System.Windows.Forms.TextBox()
        Me.studentNum = New System.Windows.Forms.Label()
        Me.customSpacingBtn = New System.Windows.Forms.Button()
        Me.addBtn = New System.Windows.Forms.Button()
        Me.StudentNoTextBox = New System.Windows.Forms.TextBox()
        Me.semCBox = New System.Windows.Forms.ComboBox()
        Me.StudentSubjectsTableAdapter = New TOR.TORdbDataSetTableAdapters.studentSubjectsTableAdapter()
        Me.TableAdapterManager = New TOR.TORdbDataSetTableAdapters.TableAdapterManager()
        Me.IDTextBox = New System.Windows.Forms.TextBox()
        Me.SYCBox = New System.Windows.Forms.ComboBox()
        Me.customPanel = New System.Windows.Forms.Panel()
        Me.revertBtn = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        SubjectCodeLabel = New System.Windows.Forms.Label()
        SubjectNameLabel = New System.Windows.Forms.Label()
        CreditLabel = New System.Windows.Forms.Label()
        GradeLabel = New System.Windows.Forms.Label()
        RemarksLabel = New System.Windows.Forms.Label()
        SemTakenLabel = New System.Windows.Forms.Label()
        FillerLabel = New System.Windows.Forms.Label()
        StudentNoLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        IDLabel = New System.Windows.Forms.Label()
        Label4 = New System.Windows.Forms.Label()
        CType(Me.StudentSubjectsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TORdbDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.customPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'SubjectCodeLabel
        '
        SubjectCodeLabel.AutoSize = True
        SubjectCodeLabel.Location = New System.Drawing.Point(295, 232)
        SubjectCodeLabel.Name = "SubjectCodeLabel"
        SubjectCodeLabel.Size = New System.Drawing.Size(72, 13)
        SubjectCodeLabel.TabIndex = 5
        SubjectCodeLabel.Text = "subject Code:"
        '
        'SubjectNameLabel
        '
        SubjectNameLabel.AutoSize = True
        SubjectNameLabel.Location = New System.Drawing.Point(295, 258)
        SubjectNameLabel.Name = "SubjectNameLabel"
        SubjectNameLabel.Size = New System.Drawing.Size(75, 13)
        SubjectNameLabel.TabIndex = 7
        SubjectNameLabel.Text = "subject Name:"
        '
        'CreditLabel
        '
        CreditLabel.AutoSize = True
        CreditLabel.Location = New System.Drawing.Point(295, 284)
        CreditLabel.Name = "CreditLabel"
        CreditLabel.Size = New System.Drawing.Size(36, 13)
        CreditLabel.TabIndex = 9
        CreditLabel.Text = "credit:"
        '
        'GradeLabel
        '
        GradeLabel.AutoSize = True
        GradeLabel.Location = New System.Drawing.Point(295, 310)
        GradeLabel.Name = "GradeLabel"
        GradeLabel.Size = New System.Drawing.Size(37, 13)
        GradeLabel.TabIndex = 11
        GradeLabel.Text = "grade:"
        '
        'RemarksLabel
        '
        RemarksLabel.AutoSize = True
        RemarksLabel.Location = New System.Drawing.Point(295, 336)
        RemarksLabel.Name = "RemarksLabel"
        RemarksLabel.Size = New System.Drawing.Size(47, 13)
        RemarksLabel.TabIndex = 13
        RemarksLabel.Text = "remarks:"
        '
        'SemTakenLabel
        '
        SemTakenLabel.AutoSize = True
        SemTakenLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        SemTakenLabel.Location = New System.Drawing.Point(1, 36)
        SemTakenLabel.Name = "SemTakenLabel"
        SemTakenLabel.Size = New System.Drawing.Size(69, 16)
        SemTakenLabel.TabIndex = 17
        SemTakenLabel.Text = "Semester:"
        '
        'FillerLabel
        '
        FillerLabel.Location = New System.Drawing.Point(0, 0)
        FillerLabel.Name = "FillerLabel"
        FillerLabel.Size = New System.Drawing.Size(100, 23)
        FillerLabel.TabIndex = 31
        '
        'StudentNoLabel
        '
        StudentNoLabel.AutoSize = True
        StudentNoLabel.Location = New System.Drawing.Point(295, 206)
        StudentNoLabel.Name = "StudentNoLabel"
        StudentNoLabel.Size = New System.Drawing.Size(62, 13)
        StudentNoLabel.TabIndex = 3
        StudentNoLabel.Text = "student No:"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(279, 362)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(63, 13)
        Label1.TabIndex = 17
        Label1.Text = "sem Taken:"
        '
        'Label2
        '
        Label2.Location = New System.Drawing.Point(0, 0)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(100, 23)
        Label2.TabIndex = 29
        '
        'IDLabel
        '
        IDLabel.AutoSize = True
        IDLabel.Location = New System.Drawing.Point(330, 440)
        IDLabel.Name = "IDLabel"
        IDLabel.Size = New System.Drawing.Size(21, 13)
        IDLabel.TabIndex = 29
        IDLabel.Text = "ID:"
        '
        'Label4
        '
        Label4.AutoSize = True
        Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label4.Location = New System.Drawing.Point(32, 11)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(38, 16)
        Label4.TabIndex = 17
        Label4.Text = "S.Y. :"
        '
        'SubjectCodeTextBox
        '
        Me.SubjectCodeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentSubjectsBindingSource, "subjectCode", True))
        Me.SubjectCodeTextBox.Location = New System.Drawing.Point(376, 229)
        Me.SubjectCodeTextBox.Name = "SubjectCodeTextBox"
        Me.SubjectCodeTextBox.Size = New System.Drawing.Size(100, 20)
        Me.SubjectCodeTextBox.TabIndex = 6
        '
        'StudentSubjectsBindingSource
        '
        Me.StudentSubjectsBindingSource.DataMember = "studentSubjects"
        Me.StudentSubjectsBindingSource.DataSource = Me.TORdbDataSet
        '
        'TORdbDataSet
        '
        Me.TORdbDataSet.DataSetName = "TORdbDataSet"
        Me.TORdbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SubjectNameTextBox
        '
        Me.SubjectNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentSubjectsBindingSource, "subjectName", True))
        Me.SubjectNameTextBox.Location = New System.Drawing.Point(376, 255)
        Me.SubjectNameTextBox.Name = "SubjectNameTextBox"
        Me.SubjectNameTextBox.Size = New System.Drawing.Size(100, 20)
        Me.SubjectNameTextBox.TabIndex = 8
        '
        'CreditTextBox
        '
        Me.CreditTextBox.Location = New System.Drawing.Point(376, 281)
        Me.CreditTextBox.Name = "CreditTextBox"
        Me.CreditTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CreditTextBox.TabIndex = 10
        '
        'GradeTextBox
        '
        Me.GradeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentSubjectsBindingSource, "grade", True))
        Me.GradeTextBox.Location = New System.Drawing.Point(376, 307)
        Me.GradeTextBox.Name = "GradeTextBox"
        Me.GradeTextBox.Size = New System.Drawing.Size(100, 20)
        Me.GradeTextBox.TabIndex = 12
        '
        'RemarksTextBox
        '
        Me.RemarksTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentSubjectsBindingSource, "remarks", True))
        Me.RemarksTextBox.Location = New System.Drawing.Point(376, 333)
        Me.RemarksTextBox.Name = "RemarksTextBox"
        Me.RemarksTextBox.Size = New System.Drawing.Size(100, 20)
        Me.RemarksTextBox.TabIndex = 14
        '
        'YearTakenTextBox
        '
        Me.YearTakenTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentSubjectsBindingSource, "yearTaken", True))
        Me.YearTakenTextBox.Location = New System.Drawing.Point(376, 385)
        Me.YearTakenTextBox.Name = "YearTakenTextBox"
        Me.YearTakenTextBox.Size = New System.Drawing.Size(100, 20)
        Me.YearTakenTextBox.TabIndex = 16
        '
        'SemTakenTextBox
        '
        Me.SemTakenTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentSubjectsBindingSource, "semTaken", True))
        Me.SemTakenTextBox.Location = New System.Drawing.Point(376, 359)
        Me.SemTakenTextBox.Name = "SemTakenTextBox"
        Me.SemTakenTextBox.Size = New System.Drawing.Size(100, 20)
        Me.SemTakenTextBox.TabIndex = 18
        '
        'FillerTextBox
        '
        Me.FillerTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentSubjectsBindingSource, "filler", True))
        Me.FillerTextBox.Location = New System.Drawing.Point(376, 411)
        Me.FillerTextBox.Name = "FillerTextBox"
        Me.FillerTextBox.Size = New System.Drawing.Size(100, 20)
        Me.FillerTextBox.TabIndex = 20
        '
        'studentNum
        '
        Me.studentNum.AutoSize = True
        Me.studentNum.Location = New System.Drawing.Point(393, 187)
        Me.studentNum.Name = "studentNum"
        Me.studentNum.Size = New System.Drawing.Size(64, 13)
        Me.studentNum.TabIndex = 21
        Me.studentNum.Text = "studentNum"
        '
        'customSpacingBtn
        '
        Me.customSpacingBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.customSpacingBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.customSpacingBtn.Location = New System.Drawing.Point(11, 199)
        Me.customSpacingBtn.Name = "customSpacingBtn"
        Me.customSpacingBtn.Size = New System.Drawing.Size(198, 29)
        Me.customSpacingBtn.TabIndex = 23
        Me.customSpacingBtn.Text = "Add New Space"
        Me.customSpacingBtn.UseVisualStyleBackColor = True
        '
        'addBtn
        '
        Me.addBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.addBtn.Enabled = False
        Me.addBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addBtn.Location = New System.Drawing.Point(0, 63)
        Me.addBtn.Name = "addBtn"
        Me.addBtn.Size = New System.Drawing.Size(197, 30)
        Me.addBtn.TabIndex = 22
        Me.addBtn.Text = "Save"
        Me.addBtn.UseVisualStyleBackColor = True
        '
        'StudentNoTextBox
        '
        Me.StudentNoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentSubjectsBindingSource, "studentNo", True))
        Me.StudentNoTextBox.Location = New System.Drawing.Point(376, 203)
        Me.StudentNoTextBox.Name = "StudentNoTextBox"
        Me.StudentNoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.StudentNoTextBox.TabIndex = 4
        '
        'semCBox
        '
        Me.semCBox.Cursor = System.Windows.Forms.Cursors.Hand
        Me.semCBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.semCBox.Enabled = False
        Me.semCBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.semCBox.FormattingEnabled = True
        Me.semCBox.Items.AddRange(New Object() {"First Semester", "Second Semester", "Summer"})
        Me.semCBox.Location = New System.Drawing.Point(76, 33)
        Me.semCBox.Name = "semCBox"
        Me.semCBox.Size = New System.Drawing.Size(121, 24)
        Me.semCBox.TabIndex = 26
        '
        'StudentSubjectsTableAdapter
        '
        Me.StudentSubjectsTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.coursesTableAdapter = Nothing
        Me.TableAdapterManager.databaseTableAdapter = Nothing
        Me.TableAdapterManager.gradingTableAdapter = Nothing
        Me.TableAdapterManager.logsTableAdapter = Nothing
        Me.TableAdapterManager.pageNumbersTableAdapter = Nothing
        Me.TableAdapterManager.semestersTableAdapter = Nothing
        Me.TableAdapterManager.studentsInfoTableAdapter = Nothing
        Me.TableAdapterManager.studentSubjectsTableAdapter = Me.StudentSubjectsTableAdapter
        Me.TableAdapterManager.subjectsTableAdapter = Nothing
        Me.TableAdapterManager.totalPrintTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = TOR.TORdbDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.userAccountTableAdapter = Nothing
        '
        'IDTextBox
        '
        Me.IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentSubjectsBindingSource, "ID", True))
        Me.IDTextBox.Location = New System.Drawing.Point(376, 437)
        Me.IDTextBox.Name = "IDTextBox"
        Me.IDTextBox.Size = New System.Drawing.Size(100, 20)
        Me.IDTextBox.TabIndex = 30
        '
        'SYCBox
        '
        Me.SYCBox.Cursor = System.Windows.Forms.Cursors.Hand
        Me.SYCBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.SYCBox.Enabled = False
        Me.SYCBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SYCBox.FormattingEnabled = True
        Me.SYCBox.Location = New System.Drawing.Point(76, 3)
        Me.SYCBox.Name = "SYCBox"
        Me.SYCBox.Size = New System.Drawing.Size(121, 24)
        Me.SYCBox.TabIndex = 32
        '
        'customPanel
        '
        Me.customPanel.Controls.Add(Me.revertBtn)
        Me.customPanel.Controls.Add(Me.SYCBox)
        Me.customPanel.Controls.Add(SemTakenLabel)
        Me.customPanel.Controls.Add(Label4)
        Me.customPanel.Controls.Add(Me.addBtn)
        Me.customPanel.Controls.Add(Me.semCBox)
        Me.customPanel.Location = New System.Drawing.Point(11, 231)
        Me.customPanel.Name = "customPanel"
        Me.customPanel.Size = New System.Drawing.Size(200, 133)
        Me.customPanel.TabIndex = 33
        '
        'revertBtn
        '
        Me.revertBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.revertBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.revertBtn.Location = New System.Drawing.Point(0, 99)
        Me.revertBtn.Name = "revertBtn"
        Me.revertBtn.Size = New System.Drawing.Size(197, 30)
        Me.revertBtn.TabIndex = 10387
        Me.revertBtn.Text = "Revert Changes"
        Me.revertBtn.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(63, 171)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(106, 16)
        Me.Label3.TabIndex = 34
        Me.Label3.Text = "Custom Spacing"
        '
        'customSpacer_form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(542, 503)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.customPanel)
        Me.Controls.Add(IDLabel)
        Me.Controls.Add(Me.IDTextBox)
        Me.Controls.Add(Me.customSpacingBtn)
        Me.Controls.Add(Me.studentNum)
        Me.Controls.Add(StudentNoLabel)
        Me.Controls.Add(Me.StudentNoTextBox)
        Me.Controls.Add(SubjectCodeLabel)
        Me.Controls.Add(Me.SubjectCodeTextBox)
        Me.Controls.Add(SubjectNameLabel)
        Me.Controls.Add(Me.SubjectNameTextBox)
        Me.Controls.Add(CreditLabel)
        Me.Controls.Add(Me.CreditTextBox)
        Me.Controls.Add(GradeLabel)
        Me.Controls.Add(Me.GradeTextBox)
        Me.Controls.Add(RemarksLabel)
        Me.Controls.Add(Me.RemarksTextBox)
        Me.Controls.Add(Me.YearTakenTextBox)
        Me.Controls.Add(Label1)
        Me.Controls.Add(Label2)
        Me.Controls.Add(Me.SemTakenTextBox)
        Me.Controls.Add(FillerLabel)
        Me.Controls.Add(Me.FillerTextBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "customSpacer_form"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.TransparencyKey = System.Drawing.Color.White
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.StudentSubjectsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TORdbDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.customPanel.ResumeLayout(False)
        Me.customPanel.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TORdbDataSet As TOR.TORdbDataSet
    Friend WithEvents StudentSubjectsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents StudentSubjectsTableAdapter As TOR.TORdbDataSetTableAdapters.studentSubjectsTableAdapter
    Friend WithEvents TableAdapterManager As TOR.TORdbDataSetTableAdapters.TableAdapterManager
    Friend WithEvents SubjectCodeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SubjectNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CreditTextBox As System.Windows.Forms.TextBox
    Friend WithEvents GradeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents RemarksTextBox As System.Windows.Forms.TextBox
    Friend WithEvents YearTakenTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SemTakenTextBox As System.Windows.Forms.TextBox
    Friend WithEvents FillerTextBox As System.Windows.Forms.TextBox
    Friend WithEvents studentNum As System.Windows.Forms.Label
    Friend WithEvents customSpacingBtn As System.Windows.Forms.Button
    Friend WithEvents addBtn As System.Windows.Forms.Button
    Friend WithEvents StudentNoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents semCBox As System.Windows.Forms.ComboBox
    Friend WithEvents IDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SYCBox As System.Windows.Forms.ComboBox
    Friend WithEvents customPanel As System.Windows.Forms.Panel
    Friend WithEvents revertBtn As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
