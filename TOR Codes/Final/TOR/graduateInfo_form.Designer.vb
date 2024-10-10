<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class graduateInfo_form
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
        Dim Label16 As System.Windows.Forms.Label
        Dim Label15 As System.Windows.Forms.Label
        Dim Label14 As System.Windows.Forms.Label
        Dim DatedLabel As System.Windows.Forms.Label
        Dim DateOfGradLabel As System.Windows.Forms.Label
        Dim SoNoLabel As System.Windows.Forms.Label
        Me.StudentsInfoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TORdbDataSet = New TOR.TORdbDataSet()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PicBrowser = New System.Windows.Forms.OpenFileDialog()
        Me.save = New System.Windows.Forms.Button()
        Me.cancelBtn = New System.Windows.Forms.Button()
        Me.sinfo17 = New System.Windows.Forms.TextBox()
        Me.sinfo19 = New System.Windows.Forms.DateTimePicker()
        Me.sinfo18 = New System.Windows.Forms.DateTimePicker()
        Me.StudentsInfoTableAdapter = New TOR.TORdbDataSetTableAdapters.studentsInfoTableAdapter()
        Me.TableAdapterManager = New TOR.TORdbDataSetTableAdapters.TableAdapterManager()
        Me.rf2 = New System.Windows.Forms.PictureBox()
        Me.studentNoLbl = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.changePicLbl = New System.Windows.Forms.Label()
        Me.DateOfGradDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.DatedDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.SoNoTextBox = New System.Windows.Forms.TextBox()
        Me.PanelPicture = New System.Windows.Forms.Panel()
        Label16 = New System.Windows.Forms.Label()
        Label15 = New System.Windows.Forms.Label()
        Label14 = New System.Windows.Forms.Label()
        DatedLabel = New System.Windows.Forms.Label()
        DateOfGradLabel = New System.Windows.Forms.Label()
        SoNoLabel = New System.Windows.Forms.Label()
        CType(Me.StudentsInfoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TORdbDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rf2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelPicture.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label16
        '
        Label16.AutoSize = True
        Label16.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label16.ForeColor = System.Drawing.Color.Black
        Label16.Location = New System.Drawing.Point(17, 147)
        Label16.Name = "Label16"
        Label16.Size = New System.Drawing.Size(125, 18)
        Label16.TabIndex = 10236
        Label16.Text = "Date of Graduation:"
        '
        'Label15
        '
        Label15.AutoSize = True
        Label15.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label15.ForeColor = System.Drawing.Color.Black
        Label15.Location = New System.Drawing.Point(95, 121)
        Label15.Name = "Label15"
        Label15.Size = New System.Drawing.Size(47, 18)
        Label15.TabIndex = 10238
        Label15.Text = "Dated:"
        '
        'Label14
        '
        Label14.AutoSize = True
        Label14.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label14.ForeColor = System.Drawing.Color.Black
        Label14.Location = New System.Drawing.Point(54, 95)
        Label14.Name = "Label14"
        Label14.Size = New System.Drawing.Size(88, 18)
        Label14.TabIndex = 10237
        Label14.Text = "S.O. Number:"
        '
        'DatedLabel
        '
        DatedLabel.AutoSize = True
        DatedLabel.Location = New System.Drawing.Point(46, 63)
        DatedLabel.Name = "DatedLabel"
        DatedLabel.Size = New System.Drawing.Size(37, 13)
        DatedLabel.TabIndex = 10240
        DatedLabel.Text = "dated:"
        '
        'DateOfGradLabel
        '
        DateOfGradLabel.AutoSize = True
        DateOfGradLabel.Location = New System.Drawing.Point(12, 89)
        DateOfGradLabel.Name = "DateOfGradLabel"
        DateOfGradLabel.Size = New System.Drawing.Size(71, 13)
        DateOfGradLabel.TabIndex = 10241
        DateOfGradLabel.Text = "date Of Grad:"
        '
        'SoNoLabel
        '
        SoNoLabel.AutoSize = True
        SoNoLabel.Location = New System.Drawing.Point(45, 40)
        SoNoLabel.Name = "SoNoLabel"
        SoNoLabel.Size = New System.Drawing.Size(38, 13)
        SoNoLabel.TabIndex = 10239
        SoNoLabel.Text = "so No:"
        '
        'StudentsInfoBindingSource
        '
        Me.StudentsInfoBindingSource.DataMember = "studentsInfo"
        Me.StudentsInfoBindingSource.DataSource = Me.TORdbDataSet
        '
        'TORdbDataSet
        '
        Me.TORdbDataSet.DataSetName = "TORdbDataSet"
        Me.TORdbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(197, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(125, 16)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "Graduate Details"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.Control
        Me.Button1.Enabled = False
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(64, 36)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(384, 34)
        Me.Button1.TabIndex = 21
        Me.Button1.Text = "Fortu, Ronsell John A."
        Me.Button1.UseVisualStyleBackColor = False
        '
        'save
        '
        Me.save.BackColor = System.Drawing.Color.SeaGreen
        Me.save.Cursor = System.Windows.Forms.Cursors.Hand
        Me.save.Enabled = False
        Me.save.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen
        Me.save.FlatAppearance.BorderSize = 0
        Me.save.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.save.ForeColor = System.Drawing.Color.White
        Me.save.Location = New System.Drawing.Point(224, 174)
        Me.save.Name = "save"
        Me.save.Size = New System.Drawing.Size(197, 30)
        Me.save.TabIndex = 23
        Me.save.Text = "Save"
        Me.save.UseVisualStyleBackColor = False
        '
        'cancelBtn
        '
        Me.cancelBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cancelBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cancelBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cancelBtn.FlatAppearance.BorderSize = 0
        Me.cancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cancelBtn.ForeColor = System.Drawing.Color.White
        Me.cancelBtn.Location = New System.Drawing.Point(143, 174)
        Me.cancelBtn.Name = "cancelBtn"
        Me.cancelBtn.Size = New System.Drawing.Size(75, 30)
        Me.cancelBtn.TabIndex = 20
        Me.cancelBtn.Text = "Cancel"
        Me.cancelBtn.UseVisualStyleBackColor = False
        '
        'sinfo17
        '
        Me.sinfo17.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sinfo17.Location = New System.Drawing.Point(143, 93)
        Me.sinfo17.Name = "sinfo17"
        Me.sinfo17.Size = New System.Drawing.Size(278, 22)
        Me.sinfo17.TabIndex = 10239
        '
        'sinfo19
        '
        Me.sinfo19.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sinfo19.CalendarTitleForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.sinfo19.Cursor = System.Windows.Forms.Cursors.Hand
        Me.sinfo19.CustomFormat = "MMMMM dd, yyyy"
        Me.sinfo19.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right
        Me.sinfo19.Enabled = False
        Me.sinfo19.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sinfo19.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.sinfo19.Location = New System.Drawing.Point(143, 145)
        Me.sinfo19.Name = "sinfo19"
        Me.sinfo19.ShowUpDown = True
        Me.sinfo19.Size = New System.Drawing.Size(278, 22)
        Me.sinfo19.TabIndex = 10232
        '
        'sinfo18
        '
        Me.sinfo18.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sinfo18.CalendarForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.sinfo18.CalendarTitleForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.sinfo18.Cursor = System.Windows.Forms.Cursors.Hand
        Me.sinfo18.CustomFormat = "MMMMM dd, yyyy"
        Me.sinfo18.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right
        Me.sinfo18.Enabled = False
        Me.sinfo18.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sinfo18.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.sinfo18.Location = New System.Drawing.Point(143, 119)
        Me.sinfo18.Name = "sinfo18"
        Me.sinfo18.ShowUpDown = True
        Me.sinfo18.Size = New System.Drawing.Size(278, 22)
        Me.sinfo18.TabIndex = 10233
        '
        'StudentsInfoTableAdapter
        '
        Me.StudentsInfoTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.studentsInfoTableAdapter = Me.StudentsInfoTableAdapter
        Me.TableAdapterManager.studentSubjectsTableAdapter = Nothing
        Me.TableAdapterManager.subjectsTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = TOR.TORdbDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.userAccountTableAdapter = Nothing
        '
        'rf2
        '
        Me.rf2.Image = Global.TOR.My.Resources.Resources.redDot
        Me.rf2.Location = New System.Drawing.Point(423, 100)
        Me.rf2.Name = "rf2"
        Me.rf2.Size = New System.Drawing.Size(9, 9)
        Me.rf2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.rf2.TabIndex = 10244
        Me.rf2.TabStop = False
        '
        'studentNoLbl
        '
        Me.studentNoLbl.AutoSize = True
        Me.studentNoLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.studentNoLbl.Location = New System.Drawing.Point(220, 71)
        Me.studentNoLbl.Name = "studentNoLbl"
        Me.studentNoLbl.Size = New System.Drawing.Size(74, 16)
        Me.studentNoLbl.TabIndex = 10245
        Me.studentNoLbl.Text = "Student No"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CustomFormat = "MMMMM dd, yyyy"
        Me.DateTimePicker1.Enabled = False
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.Location = New System.Drawing.Point(568, 175)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(102, 20)
        Me.DateTimePicker1.TabIndex = 10247
        Me.DateTimePicker1.Value = New Date(1988, 12, 26, 0, 0, 0, 0)
        '
        'changePicLbl
        '
        Me.changePicLbl.AutoSize = True
        Me.changePicLbl.Location = New System.Drawing.Point(3, 145)
        Me.changePicLbl.Name = "changePicLbl"
        Me.changePicLbl.Size = New System.Drawing.Size(32, 13)
        Me.changePicLbl.TabIndex = 25
        Me.changePicLbl.Text = "False"
        '
        'DateOfGradDateTimePicker
        '
        Me.DateOfGradDateTimePicker.CustomFormat = "MMMMM dd, yyyy"
        Me.DateOfGradDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.StudentsInfoBindingSource, "dateOfGrad", True))
        Me.DateOfGradDateTimePicker.Enabled = False
        Me.DateOfGradDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateOfGradDateTimePicker.Location = New System.Drawing.Point(89, 85)
        Me.DateOfGradDateTimePicker.Name = "DateOfGradDateTimePicker"
        Me.DateOfGradDateTimePicker.Size = New System.Drawing.Size(79, 20)
        Me.DateOfGradDateTimePicker.TabIndex = 10242
        '
        'DatedDateTimePicker
        '
        Me.DatedDateTimePicker.CustomFormat = "MMMMM dd, yyyy"
        Me.DatedDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.StudentsInfoBindingSource, "dated", True))
        Me.DatedDateTimePicker.Enabled = False
        Me.DatedDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DatedDateTimePicker.Location = New System.Drawing.Point(89, 59)
        Me.DatedDateTimePicker.Name = "DatedDateTimePicker"
        Me.DatedDateTimePicker.Size = New System.Drawing.Size(79, 20)
        Me.DatedDateTimePicker.TabIndex = 10241
        '
        'SoNoTextBox
        '
        Me.SoNoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentsInfoBindingSource, "soNo", True))
        Me.SoNoTextBox.Enabled = False
        Me.SoNoTextBox.Location = New System.Drawing.Point(89, 33)
        Me.SoNoTextBox.Name = "SoNoTextBox"
        Me.SoNoTextBox.Size = New System.Drawing.Size(62, 20)
        Me.SoNoTextBox.TabIndex = 10240
        '
        'PanelPicture
        '
        Me.PanelPicture.BackColor = System.Drawing.SystemColors.ControlDark
        Me.PanelPicture.Controls.Add(Me.SoNoTextBox)
        Me.PanelPicture.Controls.Add(SoNoLabel)
        Me.PanelPicture.Controls.Add(DateOfGradLabel)
        Me.PanelPicture.Controls.Add(Me.DatedDateTimePicker)
        Me.PanelPicture.Controls.Add(Me.DateOfGradDateTimePicker)
        Me.PanelPicture.Controls.Add(DatedLabel)
        Me.PanelPicture.Controls.Add(Me.changePicLbl)
        Me.PanelPicture.Location = New System.Drawing.Point(569, 151)
        Me.PanelPicture.Name = "PanelPicture"
        Me.PanelPicture.Size = New System.Drawing.Size(174, 174)
        Me.PanelPicture.TabIndex = 26
        '
        'changePicture
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(454, 242)
        Me.ControlBox = False
        Me.Controls.Add(Me.studentNoLbl)
        Me.Controls.Add(Me.rf2)
        Me.Controls.Add(Me.sinfo17)
        Me.Controls.Add(Label16)
        Me.Controls.Add(Label15)
        Me.Controls.Add(Label14)
        Me.Controls.Add(Me.sinfo19)
        Me.Controls.Add(Me.sinfo18)
        Me.Controls.Add(Me.PanelPicture)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.save)
        Me.Controls.Add(Me.cancelBtn)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "changePicture"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Graduate Information"
        Me.TopMost = True
        CType(Me.StudentsInfoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TORdbDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rf2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelPicture.ResumeLayout(False)
        Me.PanelPicture.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents PicBrowser As System.Windows.Forms.OpenFileDialog
    Friend WithEvents save As System.Windows.Forms.Button
    Friend WithEvents cancelBtn As System.Windows.Forms.Button
    Friend WithEvents sinfo17 As System.Windows.Forms.TextBox
    Friend WithEvents sinfo19 As System.Windows.Forms.DateTimePicker
    Friend WithEvents sinfo18 As System.Windows.Forms.DateTimePicker
    Friend WithEvents TORdbDataSet As TOR.TORdbDataSet
    Friend WithEvents StudentsInfoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents StudentsInfoTableAdapter As TOR.TORdbDataSetTableAdapters.studentsInfoTableAdapter
    Friend WithEvents TableAdapterManager As TOR.TORdbDataSetTableAdapters.TableAdapterManager
    Friend WithEvents rf2 As System.Windows.Forms.PictureBox
    Friend WithEvents studentNoLbl As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents changePicLbl As System.Windows.Forms.Label
    Friend WithEvents DateOfGradDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents DatedDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents SoNoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PanelPicture As System.Windows.Forms.Panel
End Class
