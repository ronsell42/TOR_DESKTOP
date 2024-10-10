<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class studentGrades_form
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
        Dim IDLabel1 As System.Windows.Forms.Label
        Dim StudentNoLabel As System.Windows.Forms.Label
        Dim SubjectCodeLabel1 As System.Windows.Forms.Label
        Dim SubjectNameLabel1 As System.Windows.Forms.Label
        Dim CreditLabel1 As System.Windows.Forms.Label
        Dim GradeLabel As System.Windows.Forms.Label
        Dim RemarksLabel As System.Windows.Forms.Label
        Dim YearTakenLabel As System.Windows.Forms.Label
        Dim SemTakenLabel As System.Windows.Forms.Label
        Dim IDLabel As System.Windows.Forms.Label
        Dim SubjectCodeLabel As System.Windows.Forms.Label
        Dim SubjectNameLabel As System.Windows.Forms.Label
        Dim CreditLabel As System.Windows.Forms.Label
        Dim ReqRemarksLabel As System.Windows.Forms.Label
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(studentGrades_form))
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.ssTbl = New System.Windows.Forms.DataGridView()
        Me.SubjectCodeDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SubjectNameDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CreditDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GradeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RemarksDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StudentSubjectsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TORdbDataSet = New TOR.TORdbDataSet()
        Me.gradePreview = New System.Windows.Forms.Panel()
        Me.rf4 = New System.Windows.Forms.PictureBox()
        Me.rf3 = New System.Windows.Forms.PictureBox()
        Me.rf2 = New System.Windows.Forms.PictureBox()
        Me.rf1 = New System.Windows.Forms.PictureBox()
        Me.GradeTextBox2 = New System.Windows.Forms.ComboBox()
        Me.Remarks = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.CreditTextBox2 = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.SubjectNameTextBox2 = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.SubjectCodeTextBox2 = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.editBtn = New System.Windows.Forms.Button()
        Me.saveAddBtn = New System.Windows.Forms.Button()
        Me.yearSelect = New System.Windows.Forms.Label()
        Me.semSelect = New System.Windows.Forms.Label()
        Me.saveEditBtn = New System.Windows.Forms.Button()
        Me.sem = New System.Windows.Forms.TextBox()
        Me.resetTable = New System.Windows.Forms.Button()
        Me.distinctSem = New System.Windows.Forms.Button()
        Me.year = New System.Windows.Forms.TextBox()
        Me.distinctYearBtn = New System.Windows.Forms.Button()
        Me.addSubj = New System.Windows.Forms.Label()
        Me.semList = New System.Windows.Forms.ListBox()
        Me.yearList = New System.Windows.Forms.ListBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.reportBtn = New System.Windows.Forms.Button()
        Me.panelChoice = New System.Windows.Forms.Panel()
        Me.semChoice = New System.Windows.Forms.ComboBox()
        Me.yearChoice = New System.Windows.Forms.ComboBox()
        Me.Tester = New System.Windows.Forms.Button()
        Me.PanelList = New System.Windows.Forms.Panel()
        Me.backBtn = New System.Windows.Forms.Button()
        Me.semAterDelBtn = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.panelMenu = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.subjectsTbl = New System.Windows.Forms.DataGridView()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SubjectCodeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SubjectNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CreditDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.studentQ = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SubjectsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.IDTextBox1 = New System.Windows.Forms.TextBox()
        Me.StudentNoTextBox = New System.Windows.Forms.TextBox()
        Me.SubjectCodeTextBox1 = New System.Windows.Forms.TextBox()
        Me.SubjectNameTextBox1 = New System.Windows.Forms.TextBox()
        Me.CreditTextBox1 = New System.Windows.Forms.TextBox()
        Me.GradeTextBox = New System.Windows.Forms.TextBox()
        Me.YearTakenTextBox = New System.Windows.Forms.TextBox()
        Me.SemTakenTextBox = New System.Windows.Forms.TextBox()
        Me.RemarksTextBox = New System.Windows.Forms.TextBox()
        Me.IDTextBox = New System.Windows.Forms.TextBox()
        Me.SubjectCodeTextBox = New System.Windows.Forms.TextBox()
        Me.SubjectNameTextBox = New System.Windows.Forms.TextBox()
        Me.CreditTextBox = New System.Windows.Forms.TextBox()
        Me.deleteBtn = New System.Windows.Forms.Button()
        Me.addBtn = New System.Windows.Forms.Button()
        Me.studentNo = New System.Windows.Forms.Button()
        Me.studentName = New System.Windows.Forms.Button()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SubjectsTableAdapter = New TOR.TORdbDataSetTableAdapters.subjectsTableAdapter()
        Me.StudentSubjectsTableAdapter = New TOR.TORdbDataSetTableAdapters.studentSubjectsTableAdapter()
        Me.TableAdapterManager = New TOR.TORdbDataSetTableAdapters.TableAdapterManager()
        Me.searchPanel = New System.Windows.Forms.Panel()
        Me.searchLbl = New System.Windows.Forms.Label()
        Me.clearSearchBtn = New System.Windows.Forms.Button()
        Me.searchbox = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.StudentsInfoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StudentsInfoTableAdapter = New TOR.TORdbDataSetTableAdapters.studentsInfoTableAdapter()
        Me.ReqRemarksTextBox = New System.Windows.Forms.TextBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        IDLabel1 = New System.Windows.Forms.Label()
        StudentNoLabel = New System.Windows.Forms.Label()
        SubjectCodeLabel1 = New System.Windows.Forms.Label()
        SubjectNameLabel1 = New System.Windows.Forms.Label()
        CreditLabel1 = New System.Windows.Forms.Label()
        GradeLabel = New System.Windows.Forms.Label()
        RemarksLabel = New System.Windows.Forms.Label()
        YearTakenLabel = New System.Windows.Forms.Label()
        SemTakenLabel = New System.Windows.Forms.Label()
        IDLabel = New System.Windows.Forms.Label()
        SubjectCodeLabel = New System.Windows.Forms.Label()
        SubjectNameLabel = New System.Windows.Forms.Label()
        CreditLabel = New System.Windows.Forms.Label()
        ReqRemarksLabel = New System.Windows.Forms.Label()
        CType(Me.ssTbl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StudentSubjectsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TORdbDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gradePreview.SuspendLayout()
        CType(Me.rf4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rf3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rf2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rf1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelChoice.SuspendLayout()
        Me.PanelList.SuspendLayout()
        Me.panelMenu.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.subjectsTbl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SubjectsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.searchPanel.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StudentsInfoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IDLabel1
        '
        IDLabel1.AutoSize = True
        IDLabel1.Location = New System.Drawing.Point(219, 286)
        IDLabel1.Name = "IDLabel1"
        IDLabel1.Size = New System.Drawing.Size(21, 13)
        IDLabel1.TabIndex = 10318
        IDLabel1.Text = "ID:"
        '
        'StudentNoLabel
        '
        StudentNoLabel.AutoSize = True
        StudentNoLabel.Location = New System.Drawing.Point(219, 312)
        StudentNoLabel.Name = "StudentNoLabel"
        StudentNoLabel.Size = New System.Drawing.Size(62, 13)
        StudentNoLabel.TabIndex = 10321
        StudentNoLabel.Text = "student No:"
        '
        'SubjectCodeLabel1
        '
        SubjectCodeLabel1.AutoSize = True
        SubjectCodeLabel1.Location = New System.Drawing.Point(219, 338)
        SubjectCodeLabel1.Name = "SubjectCodeLabel1"
        SubjectCodeLabel1.Size = New System.Drawing.Size(72, 13)
        SubjectCodeLabel1.TabIndex = 10323
        SubjectCodeLabel1.Text = "subject Code:"
        '
        'SubjectNameLabel1
        '
        SubjectNameLabel1.AutoSize = True
        SubjectNameLabel1.Location = New System.Drawing.Point(219, 364)
        SubjectNameLabel1.Name = "SubjectNameLabel1"
        SubjectNameLabel1.Size = New System.Drawing.Size(75, 13)
        SubjectNameLabel1.TabIndex = 10325
        SubjectNameLabel1.Text = "subject Name:"
        '
        'CreditLabel1
        '
        CreditLabel1.AutoSize = True
        CreditLabel1.Location = New System.Drawing.Point(219, 390)
        CreditLabel1.Name = "CreditLabel1"
        CreditLabel1.Size = New System.Drawing.Size(36, 13)
        CreditLabel1.TabIndex = 10327
        CreditLabel1.Text = "credit:"
        '
        'GradeLabel
        '
        GradeLabel.AutoSize = True
        GradeLabel.Location = New System.Drawing.Point(219, 416)
        GradeLabel.Name = "GradeLabel"
        GradeLabel.Size = New System.Drawing.Size(37, 13)
        GradeLabel.TabIndex = 10329
        GradeLabel.Text = "grade:"
        '
        'RemarksLabel
        '
        RemarksLabel.AutoSize = True
        RemarksLabel.Location = New System.Drawing.Point(219, 442)
        RemarksLabel.Name = "RemarksLabel"
        RemarksLabel.Size = New System.Drawing.Size(47, 13)
        RemarksLabel.TabIndex = 10331
        RemarksLabel.Text = "remarks:"
        '
        'YearTakenLabel
        '
        YearTakenLabel.AutoSize = True
        YearTakenLabel.Location = New System.Drawing.Point(219, 468)
        YearTakenLabel.Name = "YearTakenLabel"
        YearTakenLabel.Size = New System.Drawing.Size(64, 13)
        YearTakenLabel.TabIndex = 10333
        YearTakenLabel.Text = "year Taken:"
        '
        'SemTakenLabel
        '
        SemTakenLabel.AutoSize = True
        SemTakenLabel.Location = New System.Drawing.Point(219, 494)
        SemTakenLabel.Name = "SemTakenLabel"
        SemTakenLabel.Size = New System.Drawing.Size(63, 13)
        SemTakenLabel.TabIndex = 10335
        SemTakenLabel.Text = "sem Taken:"
        '
        'IDLabel
        '
        IDLabel.AutoSize = True
        IDLabel.Location = New System.Drawing.Point(32, 312)
        IDLabel.Name = "IDLabel"
        IDLabel.Size = New System.Drawing.Size(21, 13)
        IDLabel.TabIndex = 10311
        IDLabel.Text = "ID:"
        '
        'SubjectCodeLabel
        '
        SubjectCodeLabel.AutoSize = True
        SubjectCodeLabel.Location = New System.Drawing.Point(32, 338)
        SubjectCodeLabel.Name = "SubjectCodeLabel"
        SubjectCodeLabel.Size = New System.Drawing.Size(72, 13)
        SubjectCodeLabel.TabIndex = 10313
        SubjectCodeLabel.Text = "subject Code:"
        '
        'SubjectNameLabel
        '
        SubjectNameLabel.AutoSize = True
        SubjectNameLabel.Location = New System.Drawing.Point(32, 364)
        SubjectNameLabel.Name = "SubjectNameLabel"
        SubjectNameLabel.Size = New System.Drawing.Size(75, 13)
        SubjectNameLabel.TabIndex = 10315
        SubjectNameLabel.Text = "subject Name:"
        '
        'CreditLabel
        '
        CreditLabel.AutoSize = True
        CreditLabel.Location = New System.Drawing.Point(32, 390)
        CreditLabel.Name = "CreditLabel"
        CreditLabel.Size = New System.Drawing.Size(36, 13)
        CreditLabel.TabIndex = 10317
        CreditLabel.Text = "credit:"
        '
        'ReqRemarksLabel
        '
        ReqRemarksLabel.AutoSize = True
        ReqRemarksLabel.Location = New System.Drawing.Point(330, 497)
        ReqRemarksLabel.Name = "ReqRemarksLabel"
        ReqRemarksLabel.Size = New System.Drawing.Size(70, 13)
        ReqRemarksLabel.TabIndex = 10359
        ReqRemarksLabel.Text = "req Remarks:"
        '
        'ssTbl
        '
        Me.ssTbl.AllowUserToAddRows = False
        Me.ssTbl.AllowUserToDeleteRows = False
        Me.ssTbl.AllowUserToResizeColumns = False
        Me.ssTbl.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Honeydew
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.MediumSeaGreen
        Me.ssTbl.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.ssTbl.AutoGenerateColumns = False
        Me.ssTbl.BackgroundColor = System.Drawing.Color.White
        Me.ssTbl.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
        Me.ssTbl.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.SeaGreen
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SeaGreen
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ssTbl.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.ssTbl.ColumnHeadersHeight = 35
        Me.ssTbl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.ssTbl.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SubjectCodeDataGridViewTextBoxColumn1, Me.SubjectNameDataGridViewTextBoxColumn1, Me.CreditDataGridViewTextBoxColumn1, Me.GradeDataGridViewTextBoxColumn, Me.RemarksDataGridViewTextBoxColumn})
        Me.ssTbl.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ssTbl.DataSource = Me.StudentSubjectsBindingSource
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.MediumSeaGreen
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.ssTbl.DefaultCellStyle = DataGridViewCellStyle3
        Me.ssTbl.EnableHeadersVisualStyles = False
        Me.ssTbl.Location = New System.Drawing.Point(809, 148)
        Me.ssTbl.Name = "ssTbl"
        Me.ssTbl.ReadOnly = True
        Me.ssTbl.RowHeadersVisible = False
        Me.ssTbl.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.ssTbl.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.ssTbl.Size = New System.Drawing.Size(528, 385)
        Me.ssTbl.TabIndex = 10304
        '
        'SubjectCodeDataGridViewTextBoxColumn1
        '
        Me.SubjectCodeDataGridViewTextBoxColumn1.DataPropertyName = "subjectCode"
        Me.SubjectCodeDataGridViewTextBoxColumn1.HeaderText = "Code"
        Me.SubjectCodeDataGridViewTextBoxColumn1.Name = "SubjectCodeDataGridViewTextBoxColumn1"
        Me.SubjectCodeDataGridViewTextBoxColumn1.ReadOnly = True
        Me.SubjectCodeDataGridViewTextBoxColumn1.Width = 50
        '
        'SubjectNameDataGridViewTextBoxColumn1
        '
        Me.SubjectNameDataGridViewTextBoxColumn1.DataPropertyName = "subjectName"
        Me.SubjectNameDataGridViewTextBoxColumn1.HeaderText = "Title"
        Me.SubjectNameDataGridViewTextBoxColumn1.Name = "SubjectNameDataGridViewTextBoxColumn1"
        Me.SubjectNameDataGridViewTextBoxColumn1.ReadOnly = True
        Me.SubjectNameDataGridViewTextBoxColumn1.Width = 290
        '
        'CreditDataGridViewTextBoxColumn1
        '
        Me.CreditDataGridViewTextBoxColumn1.DataPropertyName = "credit"
        Me.CreditDataGridViewTextBoxColumn1.HeaderText = "Credit"
        Me.CreditDataGridViewTextBoxColumn1.Name = "CreditDataGridViewTextBoxColumn1"
        Me.CreditDataGridViewTextBoxColumn1.ReadOnly = True
        Me.CreditDataGridViewTextBoxColumn1.Width = 50
        '
        'GradeDataGridViewTextBoxColumn
        '
        Me.GradeDataGridViewTextBoxColumn.DataPropertyName = "grade"
        Me.GradeDataGridViewTextBoxColumn.HeaderText = "Grade"
        Me.GradeDataGridViewTextBoxColumn.Name = "GradeDataGridViewTextBoxColumn"
        Me.GradeDataGridViewTextBoxColumn.ReadOnly = True
        Me.GradeDataGridViewTextBoxColumn.Width = 50
        '
        'RemarksDataGridViewTextBoxColumn
        '
        Me.RemarksDataGridViewTextBoxColumn.DataPropertyName = "remarks"
        Me.RemarksDataGridViewTextBoxColumn.HeaderText = "Remarks"
        Me.RemarksDataGridViewTextBoxColumn.Name = "RemarksDataGridViewTextBoxColumn"
        Me.RemarksDataGridViewTextBoxColumn.ReadOnly = True
        Me.RemarksDataGridViewTextBoxColumn.Width = 65
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
        'gradePreview
        '
        Me.gradePreview.Controls.Add(Me.rf4)
        Me.gradePreview.Controls.Add(Me.rf3)
        Me.gradePreview.Controls.Add(Me.rf2)
        Me.gradePreview.Controls.Add(Me.rf1)
        Me.gradePreview.Controls.Add(Me.GradeTextBox2)
        Me.gradePreview.Controls.Add(Me.Remarks)
        Me.gradePreview.Controls.Add(Me.CreditTextBox2)
        Me.gradePreview.Controls.Add(Me.SubjectNameTextBox2)
        Me.gradePreview.Controls.Add(Me.SubjectCodeTextBox2)
        Me.gradePreview.Controls.Add(Me.Label4)
        Me.gradePreview.Controls.Add(Me.Label5)
        Me.gradePreview.Enabled = False
        Me.gradePreview.Location = New System.Drawing.Point(533, 326)
        Me.gradePreview.Name = "gradePreview"
        Me.gradePreview.Size = New System.Drawing.Size(272, 207)
        Me.gradePreview.TabIndex = 10339
        '
        'rf4
        '
        Me.rf4.Image = Global.TOR.My.Resources.Resources.redDot
        Me.rf4.Location = New System.Drawing.Point(160, 111)
        Me.rf4.Name = "rf4"
        Me.rf4.Size = New System.Drawing.Size(10, 10)
        Me.rf4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.rf4.TabIndex = 10229
        Me.rf4.TabStop = False
        '
        'rf3
        '
        Me.rf3.Image = Global.TOR.My.Resources.Resources.redDot
        Me.rf3.Location = New System.Drawing.Point(161, 87)
        Me.rf3.Name = "rf3"
        Me.rf3.Size = New System.Drawing.Size(10, 10)
        Me.rf3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.rf3.TabIndex = 10229
        Me.rf3.TabStop = False
        '
        'rf2
        '
        Me.rf2.Image = Global.TOR.My.Resources.Resources.redDot
        Me.rf2.Location = New System.Drawing.Point(259, 45)
        Me.rf2.Name = "rf2"
        Me.rf2.Size = New System.Drawing.Size(10, 10)
        Me.rf2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.rf2.TabIndex = 10229
        Me.rf2.TabStop = False
        '
        'rf1
        '
        Me.rf1.Image = Global.TOR.My.Resources.Resources.redDot
        Me.rf1.Location = New System.Drawing.Point(196, 15)
        Me.rf1.Name = "rf1"
        Me.rf1.Size = New System.Drawing.Size(10, 10)
        Me.rf1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.rf1.TabIndex = 10229
        Me.rf1.TabStop = False
        '
        'GradeTextBox2
        '
        Me.GradeTextBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.GradeTextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GradeTextBox2.FormattingEnabled = True
        Me.GradeTextBox2.Items.AddRange(New Object() {"1.0", "1.2", "1.3", "1.4", "1.5", "1.6", "1.7", "1.8", "1.9", "2.0", "2.1", "2.2", "2.3", "2.4", "2.5", "2.6", "2.7", "2.8", "2.9", "3.0", "3.1", "3.2", "3.3", "3.4", "3.5", "5.0", "DRP", "INC"})
        Me.GradeTextBox2.Location = New System.Drawing.Point(101, 104)
        Me.GradeTextBox2.Name = "GradeTextBox2"
        Me.GradeTextBox2.Size = New System.Drawing.Size(53, 24)
        Me.GradeTextBox2.TabIndex = 10133
        '
        'Remarks
        '
        Me.Remarks.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Remarks.Enabled = False
        Me.Remarks.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Remarks.ForeColor = System.Drawing.Color.Black
        Me.Remarks.HintForeColor = System.Drawing.Color.Empty
        Me.Remarks.HintText = ""
        Me.Remarks.isPassword = False
        Me.Remarks.LineFocusedColor = System.Drawing.Color.CornflowerBlue
        Me.Remarks.LineIdleColor = System.Drawing.Color.Black
        Me.Remarks.LineMouseHoverColor = System.Drawing.Color.Black
        Me.Remarks.LineThickness = 1
        Me.Remarks.Location = New System.Drawing.Point(100, 136)
        Me.Remarks.Margin = New System.Windows.Forms.Padding(4)
        Me.Remarks.Name = "Remarks"
        Me.Remarks.Size = New System.Drawing.Size(168, 33)
        Me.Remarks.TabIndex = 10132
        Me.Remarks.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'CreditTextBox2
        '
        Me.CreditTextBox2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.CreditTextBox2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CreditTextBox2.ForeColor = System.Drawing.Color.Black
        Me.CreditTextBox2.HintForeColor = System.Drawing.Color.Empty
        Me.CreditTextBox2.HintText = ""
        Me.CreditTextBox2.isPassword = False
        Me.CreditTextBox2.LineFocusedColor = System.Drawing.Color.CornflowerBlue
        Me.CreditTextBox2.LineIdleColor = System.Drawing.Color.Black
        Me.CreditTextBox2.LineMouseHoverColor = System.Drawing.Color.Black
        Me.CreditTextBox2.LineThickness = 1
        Me.CreditTextBox2.Location = New System.Drawing.Point(101, 66)
        Me.CreditTextBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.CreditTextBox2.Name = "CreditTextBox2"
        Me.CreditTextBox2.Size = New System.Drawing.Size(53, 33)
        Me.CreditTextBox2.TabIndex = 10130
        Me.CreditTextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'SubjectNameTextBox2
        '
        Me.SubjectNameTextBox2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.SubjectNameTextBox2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SubjectNameTextBox2.ForeColor = System.Drawing.Color.Black
        Me.SubjectNameTextBox2.HintForeColor = System.Drawing.Color.Empty
        Me.SubjectNameTextBox2.HintText = ""
        Me.SubjectNameTextBox2.isPassword = False
        Me.SubjectNameTextBox2.LineFocusedColor = System.Drawing.Color.CornflowerBlue
        Me.SubjectNameTextBox2.LineIdleColor = System.Drawing.Color.Black
        Me.SubjectNameTextBox2.LineMouseHoverColor = System.Drawing.Color.Black
        Me.SubjectNameTextBox2.LineThickness = 1
        Me.SubjectNameTextBox2.Location = New System.Drawing.Point(-1, 31)
        Me.SubjectNameTextBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.SubjectNameTextBox2.Name = "SubjectNameTextBox2"
        Me.SubjectNameTextBox2.Size = New System.Drawing.Size(253, 33)
        Me.SubjectNameTextBox2.TabIndex = 10130
        Me.SubjectNameTextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'SubjectCodeTextBox2
        '
        Me.SubjectCodeTextBox2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.SubjectCodeTextBox2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SubjectCodeTextBox2.ForeColor = System.Drawing.Color.Black
        Me.SubjectCodeTextBox2.HintForeColor = System.Drawing.Color.Empty
        Me.SubjectCodeTextBox2.HintText = ""
        Me.SubjectCodeTextBox2.isPassword = False
        Me.SubjectCodeTextBox2.LineFocusedColor = System.Drawing.Color.CornflowerBlue
        Me.SubjectCodeTextBox2.LineIdleColor = System.Drawing.Color.Black
        Me.SubjectCodeTextBox2.LineMouseHoverColor = System.Drawing.Color.Black
        Me.SubjectCodeTextBox2.LineThickness = 1
        Me.SubjectCodeTextBox2.Location = New System.Drawing.Point(68, -4)
        Me.SubjectCodeTextBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.SubjectCodeTextBox2.Name = "SubjectCodeTextBox2"
        Me.SubjectCodeTextBox2.Size = New System.Drawing.Size(121, 33)
        Me.SubjectCodeTextBox2.TabIndex = 10130
        Me.SubjectCodeTextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(50, 111)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 18)
        Me.Label4.TabIndex = 10033
        Me.Label4.Text = "Grade:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(33, 143)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 18)
        Me.Label5.TabIndex = 10033
        Me.Label5.Text = "Remarks:"
        '
        'editBtn
        '
        Me.editBtn.BackColor = System.Drawing.Color.SeaGreen
        Me.editBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.editBtn.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen
        Me.editBtn.FlatAppearance.BorderSize = 0
        Me.editBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.editBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.editBtn.ForeColor = System.Drawing.Color.White
        Me.editBtn.Location = New System.Drawing.Point(633, 151)
        Me.editBtn.Name = "editBtn"
        Me.editBtn.Size = New System.Drawing.Size(70, 30)
        Me.editBtn.TabIndex = 10306
        Me.editBtn.Text = "Edit"
        Me.editBtn.UseVisualStyleBackColor = False
        '
        'saveAddBtn
        '
        Me.saveAddBtn.BackColor = System.Drawing.Color.SeaGreen
        Me.saveAddBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.saveAddBtn.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen
        Me.saveAddBtn.FlatAppearance.BorderSize = 0
        Me.saveAddBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.saveAddBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.saveAddBtn.ForeColor = System.Drawing.Color.White
        Me.saveAddBtn.Location = New System.Drawing.Point(633, 151)
        Me.saveAddBtn.Name = "saveAddBtn"
        Me.saveAddBtn.Size = New System.Drawing.Size(70, 30)
        Me.saveAddBtn.TabIndex = 10309
        Me.saveAddBtn.Text = "Save"
        Me.saveAddBtn.UseVisualStyleBackColor = False
        Me.saveAddBtn.Visible = False
        '
        'yearSelect
        '
        Me.yearSelect.AutoSize = True
        Me.yearSelect.Location = New System.Drawing.Point(18, 46)
        Me.yearSelect.Name = "yearSelect"
        Me.yearSelect.Size = New System.Drawing.Size(57, 13)
        Me.yearSelect.TabIndex = 10290
        Me.yearSelect.Text = "yearSelect"
        '
        'semSelect
        '
        Me.semSelect.AutoSize = True
        Me.semSelect.Location = New System.Drawing.Point(134, 46)
        Me.semSelect.Name = "semSelect"
        Me.semSelect.Size = New System.Drawing.Size(56, 13)
        Me.semSelect.TabIndex = 10290
        Me.semSelect.Text = "semSelect"
        '
        'saveEditBtn
        '
        Me.saveEditBtn.BackColor = System.Drawing.Color.SeaGreen
        Me.saveEditBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.saveEditBtn.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen
        Me.saveEditBtn.FlatAppearance.BorderSize = 0
        Me.saveEditBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.saveEditBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.saveEditBtn.ForeColor = System.Drawing.Color.White
        Me.saveEditBtn.Location = New System.Drawing.Point(633, 151)
        Me.saveEditBtn.Name = "saveEditBtn"
        Me.saveEditBtn.Size = New System.Drawing.Size(70, 30)
        Me.saveEditBtn.TabIndex = 10307
        Me.saveEditBtn.Text = "Save"
        Me.saveEditBtn.UseVisualStyleBackColor = False
        Me.saveEditBtn.Visible = False
        '
        'sem
        '
        Me.sem.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentSubjectsBindingSource, "semTaken", True))
        Me.sem.Enabled = False
        Me.sem.Location = New System.Drawing.Point(656, 212)
        Me.sem.Name = "sem"
        Me.sem.Size = New System.Drawing.Size(138, 20)
        Me.sem.TabIndex = 10347
        '
        'resetTable
        '
        Me.resetTable.Location = New System.Drawing.Point(890, 158)
        Me.resetTable.Name = "resetTable"
        Me.resetTable.Size = New System.Drawing.Size(75, 23)
        Me.resetTable.TabIndex = 10346
        Me.resetTable.Text = "resetTable"
        Me.resetTable.UseVisualStyleBackColor = True
        '
        'distinctSem
        '
        Me.distinctSem.Location = New System.Drawing.Point(971, 158)
        Me.distinctSem.Name = "distinctSem"
        Me.distinctSem.Size = New System.Drawing.Size(75, 23)
        Me.distinctSem.TabIndex = 10345
        Me.distinctSem.Text = "distinctSemBtn"
        Me.distinctSem.UseVisualStyleBackColor = True
        '
        'year
        '
        Me.year.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentSubjectsBindingSource, "yearTaken", True))
        Me.year.Enabled = False
        Me.year.Location = New System.Drawing.Point(551, 213)
        Me.year.Name = "year"
        Me.year.Size = New System.Drawing.Size(99, 20)
        Me.year.TabIndex = 10344
        '
        'distinctYearBtn
        '
        Me.distinctYearBtn.Location = New System.Drawing.Point(809, 158)
        Me.distinctYearBtn.Name = "distinctYearBtn"
        Me.distinctYearBtn.Size = New System.Drawing.Size(75, 23)
        Me.distinctYearBtn.TabIndex = 10343
        Me.distinctYearBtn.Text = "distinctYear"
        Me.distinctYearBtn.UseVisualStyleBackColor = True
        '
        'addSubj
        '
        Me.addSubj.AutoSize = True
        Me.addSubj.Location = New System.Drawing.Point(566, 158)
        Me.addSubj.Name = "addSubj"
        Me.addSubj.Size = New System.Drawing.Size(21, 13)
        Me.addSubj.TabIndex = 10342
        Me.addSubj.Text = "Off"
        '
        'semList
        '
        Me.semList.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.semList.FormattingEnabled = True
        Me.semList.ItemHeight = 17
        Me.semList.Location = New System.Drawing.Point(123, 8)
        Me.semList.Name = "semList"
        Me.semList.Size = New System.Drawing.Size(138, 106)
        Me.semList.TabIndex = 10282
        '
        'yearList
        '
        Me.yearList.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.yearList.FormattingEnabled = True
        Me.yearList.ItemHeight = 17
        Me.yearList.Location = New System.Drawing.Point(8, 8)
        Me.yearList.Name = "yearList"
        Me.yearList.Size = New System.Drawing.Size(109, 106)
        Me.yearList.TabIndex = 10281
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(753, 71)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(13, 13)
        Me.Label2.TabIndex = 10348
        Me.Label2.Text = "2"
        '
        'reportBtn
        '
        Me.reportBtn.BackColor = System.Drawing.Color.SeaGreen
        Me.reportBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.reportBtn.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen
        Me.reportBtn.FlatAppearance.BorderSize = 0
        Me.reportBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.reportBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.reportBtn.ForeColor = System.Drawing.Color.White
        Me.reportBtn.Location = New System.Drawing.Point(1265, 539)
        Me.reportBtn.Name = "reportBtn"
        Me.reportBtn.Size = New System.Drawing.Size(70, 30)
        Me.reportBtn.TabIndex = 10355
        Me.reportBtn.Text = "Report"
        Me.reportBtn.UseVisualStyleBackColor = False
        '
        'panelChoice
        '
        Me.panelChoice.Controls.Add(Me.semChoice)
        Me.panelChoice.Controls.Add(Me.yearChoice)
        Me.panelChoice.Location = New System.Drawing.Point(825, 204)
        Me.panelChoice.Name = "panelChoice"
        Me.panelChoice.Size = New System.Drawing.Size(272, 40)
        Me.panelChoice.TabIndex = 10354
        '
        'semChoice
        '
        Me.semChoice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.semChoice.Enabled = False
        Me.semChoice.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.semChoice.FormattingEnabled = True
        Me.semChoice.Items.AddRange(New Object() {"First Semester", "Second Semester", "Summer"})
        Me.semChoice.Location = New System.Drawing.Point(114, 5)
        Me.semChoice.Name = "semChoice"
        Me.semChoice.Size = New System.Drawing.Size(138, 24)
        Me.semChoice.TabIndex = 10279
        '
        'yearChoice
        '
        Me.yearChoice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.yearChoice.Enabled = False
        Me.yearChoice.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.yearChoice.FormattingEnabled = True
        Me.yearChoice.Location = New System.Drawing.Point(-1, 5)
        Me.yearChoice.Name = "yearChoice"
        Me.yearChoice.Size = New System.Drawing.Size(109, 24)
        Me.yearChoice.TabIndex = 10279
        '
        'Tester
        '
        Me.Tester.Location = New System.Drawing.Point(809, 158)
        Me.Tester.Name = "Tester"
        Me.Tester.Size = New System.Drawing.Size(75, 23)
        Me.Tester.TabIndex = 10353
        Me.Tester.Text = "Tester"
        Me.Tester.UseVisualStyleBackColor = True
        '
        'PanelList
        '
        Me.PanelList.Controls.Add(Me.semList)
        Me.PanelList.Controls.Add(Me.yearList)
        Me.PanelList.Controls.Add(Me.yearSelect)
        Me.PanelList.Controls.Add(Me.semSelect)
        Me.PanelList.Location = New System.Drawing.Point(533, 204)
        Me.PanelList.Name = "PanelList"
        Me.PanelList.Size = New System.Drawing.Size(272, 116)
        Me.PanelList.TabIndex = 10352
        '
        'backBtn
        '
        Me.backBtn.BackColor = System.Drawing.Color.SeaGreen
        Me.backBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.backBtn.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen
        Me.backBtn.FlatAppearance.BorderSize = 0
        Me.backBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.backBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.backBtn.ForeColor = System.Drawing.Color.White
        Me.backBtn.Location = New System.Drawing.Point(475, 547)
        Me.backBtn.Name = "backBtn"
        Me.backBtn.Size = New System.Drawing.Size(70, 30)
        Me.backBtn.TabIndex = 10351
        Me.backBtn.Text = "Back"
        Me.backBtn.UseVisualStyleBackColor = False
        '
        'semAterDelBtn
        '
        Me.semAterDelBtn.Location = New System.Drawing.Point(1051, 158)
        Me.semAterDelBtn.Name = "semAterDelBtn"
        Me.semAterDelBtn.Size = New System.Drawing.Size(75, 23)
        Me.semAterDelBtn.TabIndex = 10349
        Me.semAterDelBtn.Text = "semAftDel"
        Me.semAterDelBtn.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(772, 71)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(13, 13)
        Me.Label3.TabIndex = 10350
        Me.Label3.Text = "2"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(653, 190)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 18)
        Me.Label1.TabIndex = 10337
        Me.Label1.Text = "Semester"
        '
        'panelMenu
        '
        Me.panelMenu.BackColor = System.Drawing.Color.SeaGreen
        Me.panelMenu.Controls.Add(Me.Label6)
        Me.panelMenu.Controls.Add(Me.PictureBox1)
        Me.panelMenu.Location = New System.Drawing.Point(0, 0)
        Me.panelMenu.Name = "panelMenu"
        Me.panelMenu.Size = New System.Drawing.Size(1348, 45)
        Me.panelMenu.TabIndex = 10302
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Trebuchet MS", 18.0!)
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(581, 9)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(178, 29)
        Me.Label6.TabIndex = 10359
        Me.Label6.Text = "Student Grades"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(-51, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(37, 37)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 10096
        Me.PictureBox1.TabStop = False
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(538, 190)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(80, 18)
        Me.Label13.TabIndex = 10338
        Me.Label13.Text = "School Year"
        '
        'subjectsTbl
        '
        Me.subjectsTbl.AllowUserToAddRows = False
        Me.subjectsTbl.AllowUserToDeleteRows = False
        Me.subjectsTbl.AllowUserToResizeColumns = False
        Me.subjectsTbl.AllowUserToResizeRows = False
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.Honeydew
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.MediumSeaGreen
        Me.subjectsTbl.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        Me.subjectsTbl.AutoGenerateColumns = False
        Me.subjectsTbl.BackgroundColor = System.Drawing.Color.White
        Me.subjectsTbl.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
        Me.subjectsTbl.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.SeaGreen
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.SeaGreen
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.subjectsTbl.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.subjectsTbl.ColumnHeadersHeight = 35
        Me.subjectsTbl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.subjectsTbl.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.SubjectCodeDataGridViewTextBoxColumn, Me.SubjectNameDataGridViewTextBoxColumn, Me.CreditDataGridViewTextBoxColumn, Me.studentQ})
        Me.subjectsTbl.Cursor = System.Windows.Forms.Cursors.Hand
        Me.subjectsTbl.DataSource = Me.SubjectsBindingSource
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.MediumSeaGreen
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.subjectsTbl.DefaultCellStyle = DataGridViewCellStyle6
        Me.subjectsTbl.EnableHeadersVisualStyles = False
        Me.subjectsTbl.Location = New System.Drawing.Point(12, 148)
        Me.subjectsTbl.MultiSelect = False
        Me.subjectsTbl.Name = "subjectsTbl"
        Me.subjectsTbl.ReadOnly = True
        Me.subjectsTbl.RowHeadersVisible = False
        Me.subjectsTbl.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.subjectsTbl.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.subjectsTbl.Size = New System.Drawing.Size(513, 385)
        Me.subjectsTbl.TabIndex = 10303
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.MinimumWidth = 2
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        Me.IDDataGridViewTextBoxColumn.ReadOnly = True
        Me.IDDataGridViewTextBoxColumn.Width = 2
        '
        'SubjectCodeDataGridViewTextBoxColumn
        '
        Me.SubjectCodeDataGridViewTextBoxColumn.DataPropertyName = "subjectCode"
        Me.SubjectCodeDataGridViewTextBoxColumn.HeaderText = "Code"
        Me.SubjectCodeDataGridViewTextBoxColumn.Name = "SubjectCodeDataGridViewTextBoxColumn"
        Me.SubjectCodeDataGridViewTextBoxColumn.ReadOnly = True
        Me.SubjectCodeDataGridViewTextBoxColumn.Width = 75
        '
        'SubjectNameDataGridViewTextBoxColumn
        '
        Me.SubjectNameDataGridViewTextBoxColumn.DataPropertyName = "subjectName"
        Me.SubjectNameDataGridViewTextBoxColumn.HeaderText = "Title"
        Me.SubjectNameDataGridViewTextBoxColumn.Name = "SubjectNameDataGridViewTextBoxColumn"
        Me.SubjectNameDataGridViewTextBoxColumn.ReadOnly = True
        Me.SubjectNameDataGridViewTextBoxColumn.Width = 365
        '
        'CreditDataGridViewTextBoxColumn
        '
        Me.CreditDataGridViewTextBoxColumn.DataPropertyName = "credit"
        Me.CreditDataGridViewTextBoxColumn.HeaderText = "Credit"
        Me.CreditDataGridViewTextBoxColumn.Name = "CreditDataGridViewTextBoxColumn"
        Me.CreditDataGridViewTextBoxColumn.ReadOnly = True
        Me.CreditDataGridViewTextBoxColumn.Width = 50
        '
        'studentQ
        '
        Me.studentQ.DataPropertyName = "studentQ"
        Me.studentQ.HeaderText = "studentQ"
        Me.studentQ.Name = "studentQ"
        Me.studentQ.ReadOnly = True
        Me.studentQ.Visible = False
        '
        'SubjectsBindingSource
        '
        Me.SubjectsBindingSource.DataMember = "subjects"
        Me.SubjectsBindingSource.DataSource = Me.TORdbDataSet
        '
        'IDTextBox1
        '
        Me.IDTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentSubjectsBindingSource, "ID", True))
        Me.IDTextBox1.Enabled = False
        Me.IDTextBox1.Location = New System.Drawing.Point(300, 283)
        Me.IDTextBox1.Name = "IDTextBox1"
        Me.IDTextBox1.Size = New System.Drawing.Size(100, 20)
        Me.IDTextBox1.TabIndex = 10320
        '
        'StudentNoTextBox
        '
        Me.StudentNoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentSubjectsBindingSource, "studentNo", True))
        Me.StudentNoTextBox.Enabled = False
        Me.StudentNoTextBox.Location = New System.Drawing.Point(300, 309)
        Me.StudentNoTextBox.Name = "StudentNoTextBox"
        Me.StudentNoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.StudentNoTextBox.TabIndex = 10322
        '
        'SubjectCodeTextBox1
        '
        Me.SubjectCodeTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentSubjectsBindingSource, "subjectCode", True))
        Me.SubjectCodeTextBox1.Enabled = False
        Me.SubjectCodeTextBox1.Location = New System.Drawing.Point(300, 335)
        Me.SubjectCodeTextBox1.Name = "SubjectCodeTextBox1"
        Me.SubjectCodeTextBox1.Size = New System.Drawing.Size(100, 20)
        Me.SubjectCodeTextBox1.TabIndex = 10324
        '
        'SubjectNameTextBox1
        '
        Me.SubjectNameTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentSubjectsBindingSource, "subjectName", True))
        Me.SubjectNameTextBox1.Enabled = False
        Me.SubjectNameTextBox1.Location = New System.Drawing.Point(300, 361)
        Me.SubjectNameTextBox1.Name = "SubjectNameTextBox1"
        Me.SubjectNameTextBox1.Size = New System.Drawing.Size(100, 20)
        Me.SubjectNameTextBox1.TabIndex = 10326
        '
        'CreditTextBox1
        '
        Me.CreditTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentSubjectsBindingSource, "credit", True))
        Me.CreditTextBox1.Enabled = False
        Me.CreditTextBox1.Location = New System.Drawing.Point(300, 387)
        Me.CreditTextBox1.Name = "CreditTextBox1"
        Me.CreditTextBox1.Size = New System.Drawing.Size(100, 20)
        Me.CreditTextBox1.TabIndex = 10328
        '
        'GradeTextBox
        '
        Me.GradeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentSubjectsBindingSource, "grade", True))
        Me.GradeTextBox.Enabled = False
        Me.GradeTextBox.Location = New System.Drawing.Point(300, 413)
        Me.GradeTextBox.Name = "GradeTextBox"
        Me.GradeTextBox.Size = New System.Drawing.Size(100, 20)
        Me.GradeTextBox.TabIndex = 10330
        '
        'YearTakenTextBox
        '
        Me.YearTakenTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentSubjectsBindingSource, "yearTaken", True))
        Me.YearTakenTextBox.Enabled = False
        Me.YearTakenTextBox.Location = New System.Drawing.Point(300, 465)
        Me.YearTakenTextBox.Name = "YearTakenTextBox"
        Me.YearTakenTextBox.Size = New System.Drawing.Size(100, 20)
        Me.YearTakenTextBox.TabIndex = 10334
        '
        'SemTakenTextBox
        '
        Me.SemTakenTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentSubjectsBindingSource, "semTaken", True))
        Me.SemTakenTextBox.Enabled = False
        Me.SemTakenTextBox.Location = New System.Drawing.Point(300, 491)
        Me.SemTakenTextBox.Name = "SemTakenTextBox"
        Me.SemTakenTextBox.Size = New System.Drawing.Size(100, 20)
        Me.SemTakenTextBox.TabIndex = 10336
        '
        'RemarksTextBox
        '
        Me.RemarksTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentSubjectsBindingSource, "remarks", True))
        Me.RemarksTextBox.Enabled = False
        Me.RemarksTextBox.Location = New System.Drawing.Point(300, 439)
        Me.RemarksTextBox.Name = "RemarksTextBox"
        Me.RemarksTextBox.Size = New System.Drawing.Size(100, 20)
        Me.RemarksTextBox.TabIndex = 10332
        '
        'IDTextBox
        '
        Me.IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SubjectsBindingSource, "ID", True))
        Me.IDTextBox.Enabled = False
        Me.IDTextBox.Location = New System.Drawing.Point(113, 309)
        Me.IDTextBox.Name = "IDTextBox"
        Me.IDTextBox.Size = New System.Drawing.Size(100, 20)
        Me.IDTextBox.TabIndex = 10312
        '
        'SubjectCodeTextBox
        '
        Me.SubjectCodeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SubjectsBindingSource, "subjectCode", True))
        Me.SubjectCodeTextBox.Enabled = False
        Me.SubjectCodeTextBox.Location = New System.Drawing.Point(113, 335)
        Me.SubjectCodeTextBox.Name = "SubjectCodeTextBox"
        Me.SubjectCodeTextBox.Size = New System.Drawing.Size(100, 20)
        Me.SubjectCodeTextBox.TabIndex = 10314
        '
        'SubjectNameTextBox
        '
        Me.SubjectNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SubjectsBindingSource, "subjectName", True))
        Me.SubjectNameTextBox.Enabled = False
        Me.SubjectNameTextBox.Location = New System.Drawing.Point(113, 361)
        Me.SubjectNameTextBox.Name = "SubjectNameTextBox"
        Me.SubjectNameTextBox.Size = New System.Drawing.Size(100, 20)
        Me.SubjectNameTextBox.TabIndex = 10316
        '
        'CreditTextBox
        '
        Me.CreditTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SubjectsBindingSource, "credit", True))
        Me.CreditTextBox.Enabled = False
        Me.CreditTextBox.Location = New System.Drawing.Point(113, 387)
        Me.CreditTextBox.Name = "CreditTextBox"
        Me.CreditTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CreditTextBox.TabIndex = 10319
        '
        'deleteBtn
        '
        Me.deleteBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.deleteBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.deleteBtn.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen
        Me.deleteBtn.FlatAppearance.BorderSize = 0
        Me.deleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.deleteBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.deleteBtn.ForeColor = System.Drawing.Color.White
        Me.deleteBtn.Location = New System.Drawing.Point(709, 151)
        Me.deleteBtn.Name = "deleteBtn"
        Me.deleteBtn.Size = New System.Drawing.Size(70, 30)
        Me.deleteBtn.TabIndex = 10310
        Me.deleteBtn.Text = "Delete"
        Me.deleteBtn.UseVisualStyleBackColor = False
        '
        'addBtn
        '
        Me.addBtn.BackColor = System.Drawing.Color.SeaGreen
        Me.addBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.addBtn.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen
        Me.addBtn.FlatAppearance.BorderSize = 0
        Me.addBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.addBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addBtn.ForeColor = System.Drawing.Color.White
        Me.addBtn.Location = New System.Drawing.Point(557, 151)
        Me.addBtn.Name = "addBtn"
        Me.addBtn.Size = New System.Drawing.Size(70, 30)
        Me.addBtn.TabIndex = 10308
        Me.addBtn.Text = "Add"
        Me.addBtn.UseVisualStyleBackColor = False
        '
        'studentNo
        '
        Me.studentNo.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.studentNo.FlatAppearance.BorderSize = 0
        Me.studentNo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.studentNo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.studentNo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.studentNo.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.studentNo.Location = New System.Drawing.Point(-9, 55)
        Me.studentNo.Name = "studentNo"
        Me.studentNo.Size = New System.Drawing.Size(1345, 38)
        Me.studentNo.TabIndex = 10341
        Me.studentNo.Text = "Student No."
        Me.studentNo.UseVisualStyleBackColor = True
        '
        'studentName
        '
        Me.studentName.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.studentName.FlatAppearance.BorderSize = 0
        Me.studentName.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.studentName.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.studentName.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.studentName.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.studentName.Location = New System.Drawing.Point(-6, 74)
        Me.studentName.Name = "studentName"
        Me.studentName.Size = New System.Drawing.Size(1341, 49)
        Me.studentName.TabIndex = 10340
        Me.studentName.Text = "Last Name, First Name MI."
        Me.studentName.UseVisualStyleBackColor = True
        '
        'Timer2
        '
        Me.Timer2.Interval = 1
        '
        'Timer1
        '
        Me.Timer1.Interval = 1
        '
        'SubjectsTableAdapter
        '
        Me.SubjectsTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.subjectsTableAdapter = Me.SubjectsTableAdapter
        Me.TableAdapterManager.totalPrintTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = TOR.TORdbDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.userAccountTableAdapter = Nothing
        '
        'searchPanel
        '
        Me.searchPanel.Controls.Add(Me.searchLbl)
        Me.searchPanel.Controls.Add(Me.clearSearchBtn)
        Me.searchPanel.Controls.Add(Me.searchbox)
        Me.searchPanel.Location = New System.Drawing.Point(166, 86)
        Me.searchPanel.Name = "searchPanel"
        Me.searchPanel.Size = New System.Drawing.Size(369, 59)
        Me.searchPanel.TabIndex = 10356
        '
        'searchLbl
        '
        Me.searchLbl.AutoSize = True
        Me.searchLbl.BackColor = System.Drawing.Color.White
        Me.searchLbl.Enabled = False
        Me.searchLbl.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.searchLbl.ForeColor = System.Drawing.Color.Black
        Me.searchLbl.Location = New System.Drawing.Point(121, 33)
        Me.searchLbl.Name = "searchLbl"
        Me.searchLbl.Size = New System.Drawing.Size(124, 17)
        Me.searchLbl.TabIndex = 10278
        Me.searchLbl.Text = "Search Code, Title"
        '
        'clearSearchBtn
        '
        Me.clearSearchBtn.BackColor = System.Drawing.Color.White
        Me.clearSearchBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.clearSearchBtn.FlatAppearance.BorderColor = System.Drawing.Color.Lavender
        Me.clearSearchBtn.FlatAppearance.BorderSize = 0
        Me.clearSearchBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lavender
        Me.clearSearchBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lavender
        Me.clearSearchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.clearSearchBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clearSearchBtn.Location = New System.Drawing.Point(315, 28)
        Me.clearSearchBtn.Name = "clearSearchBtn"
        Me.clearSearchBtn.Size = New System.Drawing.Size(44, 28)
        Me.clearSearchBtn.TabIndex = 10277
        Me.clearSearchBtn.Text = "x"
        Me.clearSearchBtn.UseVisualStyleBackColor = False
        Me.clearSearchBtn.Visible = False
        '
        'searchbox
        '
        Me.searchbox.BackColor = System.Drawing.Color.White
        Me.searchbox.BorderColorFocused = System.Drawing.Color.CornflowerBlue
        Me.searchbox.BorderColorIdle = System.Drawing.Color.DimGray
        Me.searchbox.BorderColorMouseHover = System.Drawing.Color.CornflowerBlue
        Me.searchbox.BorderThickness = 1
        Me.searchbox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.searchbox.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.searchbox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.searchbox.isPassword = False
        Me.searchbox.Location = New System.Drawing.Point(4, 26)
        Me.searchbox.Margin = New System.Windows.Forms.Padding(4)
        Me.searchbox.Name = "searchbox"
        Me.searchbox.Size = New System.Drawing.Size(356, 31)
        Me.searchbox.TabIndex = 10279
        Me.searchbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.SeaGreen
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Location = New System.Drawing.Point(0, 667)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1348, 20)
        Me.Panel1.TabIndex = 10359
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(-42, 6)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(37, 37)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 10096
        Me.PictureBox2.TabStop = False
        '
        'StudentsInfoBindingSource
        '
        Me.StudentsInfoBindingSource.DataMember = "studentsInfo"
        Me.StudentsInfoBindingSource.DataSource = Me.TORdbDataSet
        '
        'StudentsInfoTableAdapter
        '
        Me.StudentsInfoTableAdapter.ClearBeforeFill = True
        '
        'ReqRemarksTextBox
        '
        Me.ReqRemarksTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentsInfoBindingSource, "reqRemarks", True))
        Me.ReqRemarksTextBox.Enabled = False
        Me.ReqRemarksTextBox.Location = New System.Drawing.Point(406, 494)
        Me.ReqRemarksTextBox.Name = "ReqRemarksTextBox"
        Me.ReqRemarksTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ReqRemarksTextBox.TabIndex = 10360
        '
        'studentGrades_form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1348, 687)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.searchPanel)
        Me.Controls.Add(Me.addBtn)
        Me.Controls.Add(Me.subjectsTbl)
        Me.Controls.Add(IDLabel1)
        Me.Controls.Add(StudentNoLabel)
        Me.Controls.Add(SubjectCodeLabel1)
        Me.Controls.Add(SubjectNameLabel1)
        Me.Controls.Add(CreditLabel1)
        Me.Controls.Add(GradeLabel)
        Me.Controls.Add(RemarksLabel)
        Me.Controls.Add(YearTakenLabel)
        Me.Controls.Add(SemTakenLabel)
        Me.Controls.Add(IDLabel)
        Me.Controls.Add(SubjectCodeLabel)
        Me.Controls.Add(SubjectNameLabel)
        Me.Controls.Add(CreditLabel)
        Me.Controls.Add(Me.IDTextBox1)
        Me.Controls.Add(Me.StudentNoTextBox)
        Me.Controls.Add(Me.SubjectCodeTextBox1)
        Me.Controls.Add(Me.SubjectNameTextBox1)
        Me.Controls.Add(Me.CreditTextBox1)
        Me.Controls.Add(Me.GradeTextBox)
        Me.Controls.Add(Me.YearTakenTextBox)
        Me.Controls.Add(Me.SemTakenTextBox)
        Me.Controls.Add(Me.RemarksTextBox)
        Me.Controls.Add(Me.IDTextBox)
        Me.Controls.Add(Me.SubjectCodeTextBox)
        Me.Controls.Add(Me.SubjectNameTextBox)
        Me.Controls.Add(Me.CreditTextBox)
        Me.Controls.Add(Me.studentNo)
        Me.Controls.Add(Me.ssTbl)
        Me.Controls.Add(Me.gradePreview)
        Me.Controls.Add(Me.editBtn)
        Me.Controls.Add(Me.saveAddBtn)
        Me.Controls.Add(Me.saveEditBtn)
        Me.Controls.Add(Me.resetTable)
        Me.Controls.Add(Me.distinctSem)
        Me.Controls.Add(Me.distinctYearBtn)
        Me.Controls.Add(Me.addSubj)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.reportBtn)
        Me.Controls.Add(Me.panelChoice)
        Me.Controls.Add(Me.Tester)
        Me.Controls.Add(Me.PanelList)
        Me.Controls.Add(Me.backBtn)
        Me.Controls.Add(Me.semAterDelBtn)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.panelMenu)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.deleteBtn)
        Me.Controls.Add(Me.studentName)
        Me.Controls.Add(Me.sem)
        Me.Controls.Add(Me.year)
        Me.Controls.Add(ReqRemarksLabel)
        Me.Controls.Add(Me.ReqRemarksTextBox)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(1364, 726)
        Me.MinimumSize = New System.Drawing.Size(1364, 726)
        Me.Name = "studentGrades_form"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Students"
        CType(Me.ssTbl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StudentSubjectsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TORdbDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gradePreview.ResumeLayout(False)
        Me.gradePreview.PerformLayout()
        CType(Me.rf4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rf3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rf2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rf1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelChoice.ResumeLayout(False)
        Me.PanelList.ResumeLayout(False)
        Me.PanelList.PerformLayout()
        Me.panelMenu.ResumeLayout(False)
        Me.panelMenu.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.subjectsTbl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SubjectsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.searchPanel.ResumeLayout(False)
        Me.searchPanel.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StudentsInfoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ssTbl As System.Windows.Forms.DataGridView
    Friend WithEvents gradePreview As System.Windows.Forms.Panel
    Friend WithEvents GradeTextBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents Remarks As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents CreditTextBox2 As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents SubjectNameTextBox2 As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents SubjectCodeTextBox2 As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents editBtn As System.Windows.Forms.Button
    Friend WithEvents saveAddBtn As System.Windows.Forms.Button
    Friend WithEvents yearSelect As System.Windows.Forms.Label
    Friend WithEvents semSelect As System.Windows.Forms.Label
    Friend WithEvents saveEditBtn As System.Windows.Forms.Button
    Friend WithEvents sem As System.Windows.Forms.TextBox
    Friend WithEvents resetTable As System.Windows.Forms.Button
    Friend WithEvents distinctSem As System.Windows.Forms.Button
    Friend WithEvents year As System.Windows.Forms.TextBox
    Friend WithEvents distinctYearBtn As System.Windows.Forms.Button
    Friend WithEvents addSubj As System.Windows.Forms.Label
    Friend WithEvents semList As System.Windows.Forms.ListBox
    Friend WithEvents yearList As System.Windows.Forms.ListBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents reportBtn As System.Windows.Forms.Button
    Friend WithEvents panelChoice As System.Windows.Forms.Panel
    Friend WithEvents semChoice As System.Windows.Forms.ComboBox
    Friend WithEvents yearChoice As System.Windows.Forms.ComboBox
    Friend WithEvents Tester As System.Windows.Forms.Button
    Friend WithEvents PanelList As System.Windows.Forms.Panel
    Friend WithEvents backBtn As System.Windows.Forms.Button
    Friend WithEvents semAterDelBtn As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents panelMenu As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents subjectsTbl As System.Windows.Forms.DataGridView
    Friend WithEvents IDTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents StudentNoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SubjectCodeTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents SubjectNameTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents CreditTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents GradeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents YearTakenTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SemTakenTextBox As System.Windows.Forms.TextBox
    Friend WithEvents RemarksTextBox As System.Windows.Forms.TextBox
    Friend WithEvents IDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SubjectCodeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SubjectNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CreditTextBox As System.Windows.Forms.TextBox
    Friend WithEvents deleteBtn As System.Windows.Forms.Button
    Friend WithEvents addBtn As System.Windows.Forms.Button
    Friend WithEvents studentNo As System.Windows.Forms.Button
    Friend WithEvents studentName As System.Windows.Forms.Button
    Friend WithEvents TORdbDataSet As TOR.TORdbDataSet
    Friend WithEvents SubjectsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SubjectsTableAdapter As TOR.TORdbDataSetTableAdapters.subjectsTableAdapter
    Friend WithEvents StudentSubjectsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents StudentSubjectsTableAdapter As TOR.TORdbDataSetTableAdapters.studentSubjectsTableAdapter
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents TableAdapterManager As TOR.TORdbDataSetTableAdapters.TableAdapterManager
    Friend WithEvents searchPanel As System.Windows.Forms.Panel
    Friend WithEvents searchLbl As System.Windows.Forms.Label
    Friend WithEvents clearSearchBtn As System.Windows.Forms.Button
    Friend WithEvents searchbox As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents rf4 As System.Windows.Forms.PictureBox
    Friend WithEvents rf3 As System.Windows.Forms.PictureBox
    Friend WithEvents rf2 As System.Windows.Forms.PictureBox
    Friend WithEvents rf1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents studentQ As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SubjectCodeDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SubjectNameDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CreditDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GradeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RemarksDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents IDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SubjectCodeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SubjectNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CreditDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents StudentsInfoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents StudentsInfoTableAdapter As TOR.TORdbDataSetTableAdapters.studentsInfoTableAdapter
    Friend WithEvents ReqRemarksTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
End Class
