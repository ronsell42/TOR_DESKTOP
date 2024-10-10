<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class subjects_form
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
        Dim IDLabel As System.Windows.Forms.Label
        Dim SubjectCodeLabel As System.Windows.Forms.Label
        Dim SubjectNameLabel As System.Windows.Forms.Label
        Dim CreditLabel As System.Windows.Forms.Label
        Dim BackupPathLabel As System.Windows.Forms.Label
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(subjects_form))
        Me.Button3 = New System.Windows.Forms.Button()
        Me.credit = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.title = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.code = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.deleteBtn = New System.Windows.Forms.Button()
        Me.editBtn = New System.Windows.Forms.Button()
        Me.addBtn = New System.Windows.Forms.Button()
        Me.subjectsTbl = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SubjectCodeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SubjectNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CreditDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SubjectsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TORdbDataSet = New TOR.TORdbDataSet()
        Me.subjCreditLbl = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.rf3 = New System.Windows.Forms.PictureBox()
        Me.rf2 = New System.Windows.Forms.PictureBox()
        Me.rf1 = New System.Windows.Forms.PictureBox()
        Me.subjCodeLbl = New System.Windows.Forms.Label()
        Me.subjNameLbl = New System.Windows.Forms.Label()
        Me.IDTextBox = New System.Windows.Forms.TextBox()
        Me.SubjectCodeTextBox = New System.Windows.Forms.TextBox()
        Me.SubjectNameTextBox = New System.Windows.Forms.TextBox()
        Me.CreditTextBox = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.dashboardBtn = New System.Windows.Forms.Button()
        Me.studentsBtn = New System.Windows.Forms.Button()
        Me.subjectsBtn = New System.Windows.Forms.Button()
        Me.backupBtn = New System.Windows.Forms.Button()
        Me.settingsBtn = New System.Windows.Forms.Button()
        Me.helpBtn = New System.Windows.Forms.Button()
        Me.homeBtn = New System.Windows.Forms.Button()
        Me.panelMenu = New System.Windows.Forms.Panel()
        Me.userPanel = New System.Windows.Forms.Panel()
        Me.user = New System.Windows.Forms.Button()
        Me.logout = New System.Windows.Forms.Button()
        Me.settingsSecret_button = New System.Windows.Forms.Button()
        Me.BackupPathLabel1 = New System.Windows.Forms.Label()
        Me.DatabaseBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.searchPanel = New System.Windows.Forms.Panel()
        Me.searchLbl = New System.Windows.Forms.Label()
        Me.clearSearchBtn = New System.Windows.Forms.Button()
        Me.searchbox = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.SubjectsTableAdapter = New TOR.TORdbDataSetTableAdapters.subjectsTableAdapter()
        Me.TableAdapterManager = New TOR.TORdbDataSetTableAdapters.TableAdapterManager()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.DatabaseTableAdapter = New TOR.TORdbDataSetTableAdapters.databaseTableAdapter()
        IDLabel = New System.Windows.Forms.Label()
        SubjectCodeLabel = New System.Windows.Forms.Label()
        SubjectNameLabel = New System.Windows.Forms.Label()
        CreditLabel = New System.Windows.Forms.Label()
        BackupPathLabel = New System.Windows.Forms.Label()
        CType(Me.subjectsTbl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SubjectsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TORdbDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.rf3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rf2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rf1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelMenu.SuspendLayout()
        Me.userPanel.SuspendLayout()
        CType(Me.DatabaseBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.searchPanel.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IDLabel
        '
        IDLabel.AutoSize = True
        IDLabel.Location = New System.Drawing.Point(608, 375)
        IDLabel.Name = "IDLabel"
        IDLabel.Size = New System.Drawing.Size(21, 13)
        IDLabel.TabIndex = 10271
        IDLabel.Text = "ID:"
        '
        'SubjectCodeLabel
        '
        SubjectCodeLabel.AutoSize = True
        SubjectCodeLabel.Location = New System.Drawing.Point(608, 401)
        SubjectCodeLabel.Name = "SubjectCodeLabel"
        SubjectCodeLabel.Size = New System.Drawing.Size(72, 13)
        SubjectCodeLabel.TabIndex = 10273
        SubjectCodeLabel.Text = "subject Code:"
        '
        'SubjectNameLabel
        '
        SubjectNameLabel.AutoSize = True
        SubjectNameLabel.Location = New System.Drawing.Point(608, 427)
        SubjectNameLabel.Name = "SubjectNameLabel"
        SubjectNameLabel.Size = New System.Drawing.Size(75, 13)
        SubjectNameLabel.TabIndex = 10275
        SubjectNameLabel.Text = "subject Name:"
        '
        'CreditLabel
        '
        CreditLabel.AutoSize = True
        CreditLabel.Location = New System.Drawing.Point(608, 453)
        CreditLabel.Name = "CreditLabel"
        CreditLabel.Size = New System.Drawing.Size(36, 13)
        CreditLabel.TabIndex = 10277
        CreditLabel.Text = "credit:"
        '
        'BackupPathLabel
        '
        BackupPathLabel.AutoSize = True
        BackupPathLabel.Location = New System.Drawing.Point(324, 16)
        BackupPathLabel.Name = "BackupPathLabel"
        BackupPathLabel.Size = New System.Drawing.Size(71, 13)
        BackupPathLabel.TabIndex = 10229
        BackupPathLabel.Text = "backup Path:"
        '
        'Button3
        '
        Me.Button3.Enabled = False
        Me.Button3.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.Button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Trebuchet MS", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.Black
        Me.Button3.Location = New System.Drawing.Point(0, 47)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(1315, 72)
        Me.Button3.TabIndex = 10271
        Me.Button3.Text = "Subjects"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'credit
        '
        Me.credit.BorderColorFocused = System.Drawing.SystemColors.MenuHighlight
        Me.credit.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.credit.BorderColorMouseHover = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.credit.BorderThickness = 1
        Me.credit.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.credit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.credit.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.credit.isPassword = False
        Me.credit.Location = New System.Drawing.Point(62, 93)
        Me.credit.Margin = New System.Windows.Forms.Padding(4)
        Me.credit.Name = "credit"
        Me.credit.Size = New System.Drawing.Size(417, 31)
        Me.credit.TabIndex = 10203
        Me.credit.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'title
        '
        Me.title.BorderColorFocused = System.Drawing.SystemColors.MenuHighlight
        Me.title.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.title.BorderColorMouseHover = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.title.BorderThickness = 1
        Me.title.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.title.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.title.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.title.isPassword = False
        Me.title.Location = New System.Drawing.Point(62, 59)
        Me.title.Margin = New System.Windows.Forms.Padding(4)
        Me.title.Name = "title"
        Me.title.Size = New System.Drawing.Size(417, 31)
        Me.title.TabIndex = 10203
        Me.title.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'code
        '
        Me.code.BorderColorFocused = System.Drawing.SystemColors.MenuHighlight
        Me.code.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.code.BorderColorMouseHover = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.code.BorderThickness = 1
        Me.code.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.code.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.code.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.code.isPassword = False
        Me.code.Location = New System.Drawing.Point(62, 25)
        Me.code.Margin = New System.Windows.Forms.Padding(4)
        Me.code.Name = "code"
        Me.code.Size = New System.Drawing.Size(417, 31)
        Me.code.TabIndex = 10203
        Me.code.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
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
        Me.deleteBtn.Location = New System.Drawing.Point(527, 134)
        Me.deleteBtn.Name = "deleteBtn"
        Me.deleteBtn.Size = New System.Drawing.Size(70, 30)
        Me.deleteBtn.TabIndex = 10269
        Me.deleteBtn.Text = "Delete"
        Me.deleteBtn.UseVisualStyleBackColor = False
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
        Me.editBtn.Location = New System.Drawing.Point(454, 134)
        Me.editBtn.Name = "editBtn"
        Me.editBtn.Size = New System.Drawing.Size(70, 30)
        Me.editBtn.TabIndex = 10268
        Me.editBtn.Text = "Edit"
        Me.editBtn.UseVisualStyleBackColor = False
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
        Me.addBtn.Location = New System.Drawing.Point(381, 134)
        Me.addBtn.Name = "addBtn"
        Me.addBtn.Size = New System.Drawing.Size(70, 30)
        Me.addBtn.TabIndex = 10267
        Me.addBtn.Text = "Add"
        Me.addBtn.UseVisualStyleBackColor = False
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
        Me.subjectsTbl.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.IDDataGridViewTextBoxColumn, Me.SubjectCodeDataGridViewTextBoxColumn, Me.SubjectNameDataGridViewTextBoxColumn, Me.CreditDataGridViewTextBoxColumn})
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
        Me.subjectsTbl.Location = New System.Drawing.Point(603, 169)
        Me.subjectsTbl.MultiSelect = False
        Me.subjectsTbl.Name = "subjectsTbl"
        Me.subjectsTbl.ReadOnly = True
        Me.subjectsTbl.RowHeadersVisible = False
        Me.subjectsTbl.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.subjectsTbl.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.subjectsTbl.Size = New System.Drawing.Size(573, 390)
        Me.subjectsTbl.TabIndex = 10266
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "ID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn1.MinimumWidth = 2
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Visible = False
        Me.DataGridViewTextBoxColumn1.Width = 2
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
        Me.SubjectNameDataGridViewTextBoxColumn.Width = 425
        '
        'CreditDataGridViewTextBoxColumn
        '
        Me.CreditDataGridViewTextBoxColumn.DataPropertyName = "credit"
        Me.CreditDataGridViewTextBoxColumn.HeaderText = "Credit"
        Me.CreditDataGridViewTextBoxColumn.Name = "CreditDataGridViewTextBoxColumn"
        Me.CreditDataGridViewTextBoxColumn.ReadOnly = True
        Me.CreditDataGridViewTextBoxColumn.Width = 50
        '
        'SubjectsBindingSource
        '
        Me.SubjectsBindingSource.DataMember = "subjects"
        Me.SubjectsBindingSource.DataSource = Me.TORdbDataSet
        '
        'TORdbDataSet
        '
        Me.TORdbDataSet.DataSetName = "TORdbDataSet"
        Me.TORdbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'subjCreditLbl
        '
        Me.subjCreditLbl.AutoSize = True
        Me.subjCreditLbl.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.subjCreditLbl.Location = New System.Drawing.Point(12, 100)
        Me.subjCreditLbl.Name = "subjCreditLbl"
        Me.subjCreditLbl.Size = New System.Drawing.Size(49, 18)
        Me.subjCreditLbl.TabIndex = 10071
        Me.subjCreditLbl.Text = "Credit:"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.rf3)
        Me.GroupBox3.Controls.Add(Me.rf2)
        Me.GroupBox3.Controls.Add(Me.rf1)
        Me.GroupBox3.Controls.Add(Me.credit)
        Me.GroupBox3.Controls.Add(Me.title)
        Me.GroupBox3.Controls.Add(Me.code)
        Me.GroupBox3.Controls.Add(Me.subjCodeLbl)
        Me.GroupBox3.Controls.Add(Me.subjNameLbl)
        Me.GroupBox3.Controls.Add(Me.subjCreditLbl)
        Me.GroupBox3.Location = New System.Drawing.Point(97, 163)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(515, 159)
        Me.GroupBox3.TabIndex = 10265
        Me.GroupBox3.TabStop = False
        '
        'rf3
        '
        Me.rf3.Image = Global.TOR.My.Resources.Resources.redDot
        Me.rf3.Location = New System.Drawing.Point(486, 106)
        Me.rf3.Name = "rf3"
        Me.rf3.Size = New System.Drawing.Size(9, 9)
        Me.rf3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.rf3.TabIndex = 10229
        Me.rf3.TabStop = False
        Me.rf3.Visible = False
        '
        'rf2
        '
        Me.rf2.Image = Global.TOR.My.Resources.Resources.redDot
        Me.rf2.Location = New System.Drawing.Point(486, 72)
        Me.rf2.Name = "rf2"
        Me.rf2.Size = New System.Drawing.Size(9, 9)
        Me.rf2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.rf2.TabIndex = 10229
        Me.rf2.TabStop = False
        Me.rf2.Visible = False
        '
        'rf1
        '
        Me.rf1.Image = Global.TOR.My.Resources.Resources.redDot
        Me.rf1.Location = New System.Drawing.Point(486, 37)
        Me.rf1.Name = "rf1"
        Me.rf1.Size = New System.Drawing.Size(9, 9)
        Me.rf1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.rf1.TabIndex = 10229
        Me.rf1.TabStop = False
        Me.rf1.Visible = False
        '
        'subjCodeLbl
        '
        Me.subjCodeLbl.AutoSize = True
        Me.subjCodeLbl.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.subjCodeLbl.Location = New System.Drawing.Point(19, 32)
        Me.subjCodeLbl.Name = "subjCodeLbl"
        Me.subjCodeLbl.Size = New System.Drawing.Size(42, 18)
        Me.subjCodeLbl.TabIndex = 10071
        Me.subjCodeLbl.Text = "Code:"
        '
        'subjNameLbl
        '
        Me.subjNameLbl.AutoSize = True
        Me.subjNameLbl.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.subjNameLbl.Location = New System.Drawing.Point(22, 66)
        Me.subjNameLbl.Name = "subjNameLbl"
        Me.subjNameLbl.Size = New System.Drawing.Size(39, 18)
        Me.subjNameLbl.TabIndex = 10071
        Me.subjNameLbl.Text = "Title:"
        '
        'IDTextBox
        '
        Me.IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SubjectsBindingSource, "ID", True))
        Me.IDTextBox.Location = New System.Drawing.Point(689, 372)
        Me.IDTextBox.Name = "IDTextBox"
        Me.IDTextBox.Size = New System.Drawing.Size(100, 20)
        Me.IDTextBox.TabIndex = 10272
        '
        'SubjectCodeTextBox
        '
        Me.SubjectCodeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SubjectsBindingSource, "subjectCode", True))
        Me.SubjectCodeTextBox.Location = New System.Drawing.Point(689, 398)
        Me.SubjectCodeTextBox.Name = "SubjectCodeTextBox"
        Me.SubjectCodeTextBox.Size = New System.Drawing.Size(100, 20)
        Me.SubjectCodeTextBox.TabIndex = 10274
        '
        'SubjectNameTextBox
        '
        Me.SubjectNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SubjectsBindingSource, "subjectName", True))
        Me.SubjectNameTextBox.Location = New System.Drawing.Point(689, 424)
        Me.SubjectNameTextBox.Name = "SubjectNameTextBox"
        Me.SubjectNameTextBox.Size = New System.Drawing.Size(100, 20)
        Me.SubjectNameTextBox.TabIndex = 10276
        '
        'CreditTextBox
        '
        Me.CreditTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SubjectsBindingSource, "credit", True))
        Me.CreditTextBox.Location = New System.Drawing.Point(689, 450)
        Me.CreditTextBox.Name = "CreditTextBox"
        Me.CreditTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CreditTextBox.TabIndex = 10278
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(-45, 5)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(37, 37)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 10096
        Me.PictureBox1.TabStop = False
        '
        'dashboardBtn
        '
        Me.dashboardBtn.BackColor = System.Drawing.Color.SeaGreen
        Me.dashboardBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dashboardBtn.FlatAppearance.BorderSize = 0
        Me.dashboardBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.dashboardBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dashboardBtn.ForeColor = System.Drawing.Color.White
        Me.dashboardBtn.Image = Global.TOR.My.Resources.Resources.dashboard_icon_1
        Me.dashboardBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.dashboardBtn.Location = New System.Drawing.Point(64, 0)
        Me.dashboardBtn.Name = "dashboardBtn"
        Me.dashboardBtn.Size = New System.Drawing.Size(107, 45)
        Me.dashboardBtn.TabIndex = 1
        Me.dashboardBtn.Text = "Dashboard"
        Me.dashboardBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.dashboardBtn.UseVisualStyleBackColor = False
        '
        'studentsBtn
        '
        Me.studentsBtn.BackColor = System.Drawing.Color.SeaGreen
        Me.studentsBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.studentsBtn.FlatAppearance.BorderSize = 0
        Me.studentsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.studentsBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.studentsBtn.ForeColor = System.Drawing.Color.White
        Me.studentsBtn.Image = Global.TOR.My.Resources.Resources.students_icon_1
        Me.studentsBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.studentsBtn.Location = New System.Drawing.Point(170, 0)
        Me.studentsBtn.Name = "studentsBtn"
        Me.studentsBtn.Size = New System.Drawing.Size(88, 45)
        Me.studentsBtn.TabIndex = 2
        Me.studentsBtn.Text = "Students"
        Me.studentsBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.studentsBtn.UseVisualStyleBackColor = False
        '
        'subjectsBtn
        '
        Me.subjectsBtn.BackColor = System.Drawing.Color.White
        Me.subjectsBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.subjectsBtn.FlatAppearance.BorderSize = 0
        Me.subjectsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.subjectsBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.subjectsBtn.ForeColor = System.Drawing.Color.SeaGreen
        Me.subjectsBtn.Image = Global.TOR.My.Resources.Resources.subjects_icon_2
        Me.subjectsBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.subjectsBtn.Location = New System.Drawing.Point(257, 0)
        Me.subjectsBtn.Name = "subjectsBtn"
        Me.subjectsBtn.Size = New System.Drawing.Size(91, 45)
        Me.subjectsBtn.TabIndex = 3
        Me.subjectsBtn.Text = "Subjects"
        Me.subjectsBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.subjectsBtn.UseVisualStyleBackColor = False
        '
        'backupBtn
        '
        Me.backupBtn.BackColor = System.Drawing.Color.SeaGreen
        Me.backupBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.backupBtn.FlatAppearance.BorderSize = 0
        Me.backupBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.backupBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.backupBtn.ForeColor = System.Drawing.Color.White
        Me.backupBtn.Image = Global.TOR.My.Resources.Resources.backup_icon_1
        Me.backupBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.backupBtn.Location = New System.Drawing.Point(347, 0)
        Me.backupBtn.Name = "backupBtn"
        Me.backupBtn.Size = New System.Drawing.Size(87, 45)
        Me.backupBtn.TabIndex = 4
        Me.backupBtn.Text = "Backup"
        Me.backupBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.backupBtn.UseVisualStyleBackColor = False
        '
        'settingsBtn
        '
        Me.settingsBtn.BackColor = System.Drawing.Color.SeaGreen
        Me.settingsBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.settingsBtn.FlatAppearance.BorderSize = 0
        Me.settingsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.settingsBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.settingsBtn.ForeColor = System.Drawing.Color.White
        Me.settingsBtn.Image = Global.TOR.My.Resources.Resources.settings_icon_1
        Me.settingsBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.settingsBtn.Location = New System.Drawing.Point(433, 0)
        Me.settingsBtn.Name = "settingsBtn"
        Me.settingsBtn.Size = New System.Drawing.Size(92, 45)
        Me.settingsBtn.TabIndex = 5
        Me.settingsBtn.Text = "Settings"
        Me.settingsBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.settingsBtn.UseVisualStyleBackColor = False
        '
        'helpBtn
        '
        Me.helpBtn.BackColor = System.Drawing.Color.SeaGreen
        Me.helpBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.helpBtn.FlatAppearance.BorderSize = 0
        Me.helpBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.helpBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.helpBtn.ForeColor = System.Drawing.Color.White
        Me.helpBtn.Image = Global.TOR.My.Resources.Resources.help_icon_1
        Me.helpBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.helpBtn.Location = New System.Drawing.Point(523, 0)
        Me.helpBtn.Name = "helpBtn"
        Me.helpBtn.Size = New System.Drawing.Size(91, 45)
        Me.helpBtn.TabIndex = 7
        Me.helpBtn.Text = "Tutorials"
        Me.helpBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.helpBtn.UseVisualStyleBackColor = False
        '
        'homeBtn
        '
        Me.homeBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.homeBtn.FlatAppearance.BorderSize = 0
        Me.homeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.homeBtn.Image = Global.TOR.My.Resources.Resources.home_icon_1
        Me.homeBtn.Location = New System.Drawing.Point(-1, 0)
        Me.homeBtn.Name = "homeBtn"
        Me.homeBtn.Size = New System.Drawing.Size(66, 45)
        Me.homeBtn.TabIndex = 10097
        Me.homeBtn.UseVisualStyleBackColor = True
        '
        'panelMenu
        '
        Me.panelMenu.BackColor = System.Drawing.Color.SeaGreen
        Me.panelMenu.Controls.Add(Me.userPanel)
        Me.panelMenu.Controls.Add(Me.homeBtn)
        Me.panelMenu.Controls.Add(Me.helpBtn)
        Me.panelMenu.Controls.Add(Me.settingsBtn)
        Me.panelMenu.Controls.Add(Me.backupBtn)
        Me.panelMenu.Controls.Add(Me.subjectsBtn)
        Me.panelMenu.Controls.Add(Me.studentsBtn)
        Me.panelMenu.Controls.Add(Me.dashboardBtn)
        Me.panelMenu.Controls.Add(Me.PictureBox1)
        Me.panelMenu.Controls.Add(Me.settingsSecret_button)
        Me.panelMenu.Controls.Add(BackupPathLabel)
        Me.panelMenu.Controls.Add(Me.BackupPathLabel1)
        Me.panelMenu.Location = New System.Drawing.Point(0, 0)
        Me.panelMenu.Name = "panelMenu"
        Me.panelMenu.Size = New System.Drawing.Size(1348, 45)
        Me.panelMenu.TabIndex = 10264
        '
        'userPanel
        '
        Me.userPanel.Controls.Add(Me.user)
        Me.userPanel.Controls.Add(Me.logout)
        Me.userPanel.Location = New System.Drawing.Point(1099, 0)
        Me.userPanel.Name = "userPanel"
        Me.userPanel.Size = New System.Drawing.Size(237, 45)
        Me.userPanel.TabIndex = 10282
        '
        'user
        '
        Me.user.BackColor = System.Drawing.Color.SeaGreen
        Me.user.Cursor = System.Windows.Forms.Cursors.Hand
        Me.user.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.user.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.user.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.user.ForeColor = System.Drawing.Color.White
        Me.user.Image = Global.TOR.My.Resources.Resources.user_icon
        Me.user.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.user.Location = New System.Drawing.Point(4, 5)
        Me.user.Name = "user"
        Me.user.Size = New System.Drawing.Size(185, 34)
        Me.user.TabIndex = 10099
        Me.user.Text = "Username"
        Me.user.UseVisualStyleBackColor = False
        '
        'logout
        '
        Me.logout.BackColor = System.Drawing.Color.SeaGreen
        Me.logout.Cursor = System.Windows.Forms.Cursors.Hand
        Me.logout.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.logout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red
        Me.logout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.logout.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.logout.ForeColor = System.Drawing.Color.White
        Me.logout.Image = Global.TOR.My.Resources.Resources.logout_icon
        Me.logout.Location = New System.Drawing.Point(188, 5)
        Me.logout.Name = "logout"
        Me.logout.Size = New System.Drawing.Size(44, 34)
        Me.logout.TabIndex = 10098
        Me.logout.UseVisualStyleBackColor = False
        '
        'settingsSecret_button
        '
        Me.settingsSecret_button.Enabled = False
        Me.settingsSecret_button.Location = New System.Drawing.Point(417, 12)
        Me.settingsSecret_button.Name = "settingsSecret_button"
        Me.settingsSecret_button.Size = New System.Drawing.Size(120, 23)
        Me.settingsSecret_button.TabIndex = 10289
        Me.settingsSecret_button.Text = "go_to_settings"
        Me.settingsSecret_button.UseVisualStyleBackColor = True
        '
        'BackupPathLabel1
        '
        Me.BackupPathLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DatabaseBindingSource, "backupPath", True))
        Me.BackupPathLabel1.Location = New System.Drawing.Point(401, 16)
        Me.BackupPathLabel1.Name = "BackupPathLabel1"
        Me.BackupPathLabel1.Size = New System.Drawing.Size(100, 23)
        Me.BackupPathLabel1.TabIndex = 10230
        Me.BackupPathLabel1.Text = "Label1"
        '
        'DatabaseBindingSource
        '
        Me.DatabaseBindingSource.DataMember = "database"
        Me.DatabaseBindingSource.DataSource = Me.TORdbDataSet
        '
        'searchPanel
        '
        Me.searchPanel.Controls.Add(Me.searchLbl)
        Me.searchPanel.Controls.Add(Me.clearSearchBtn)
        Me.searchPanel.Controls.Add(Me.searchbox)
        Me.searchPanel.Location = New System.Drawing.Point(598, 106)
        Me.searchPanel.Name = "searchPanel"
        Me.searchPanel.Size = New System.Drawing.Size(369, 59)
        Me.searchPanel.TabIndex = 10281
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
        'SubjectsTableAdapter
        '
        Me.SubjectsTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.studentSubjectsTableAdapter = Nothing
        Me.TableAdapterManager.subjectsTableAdapter = Me.SubjectsTableAdapter
        Me.TableAdapterManager.totalPrintTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = TOR.TORdbDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.userAccountTableAdapter = Nothing
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.SeaGreen
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Location = New System.Drawing.Point(0, 667)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1348, 20)
        Me.Panel1.TabIndex = 10282
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
        'DatabaseTableAdapter
        '
        Me.DatabaseTableAdapter.ClearBeforeFill = True
        '
        'subjects_form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1348, 687)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.searchPanel)
        Me.Controls.Add(Me.deleteBtn)
        Me.Controls.Add(Me.editBtn)
        Me.Controls.Add(Me.addBtn)
        Me.Controls.Add(Me.subjectsTbl)
        Me.Controls.Add(IDLabel)
        Me.Controls.Add(Me.IDTextBox)
        Me.Controls.Add(SubjectCodeLabel)
        Me.Controls.Add(Me.SubjectCodeTextBox)
        Me.Controls.Add(SubjectNameLabel)
        Me.Controls.Add(Me.SubjectNameTextBox)
        Me.Controls.Add(CreditLabel)
        Me.Controls.Add(Me.CreditTextBox)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.panelMenu)
        Me.Controls.Add(Me.GroupBox3)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(1364, 726)
        Me.MinimumSize = New System.Drawing.Size(1364, 726)
        Me.Name = "subjects_form"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Subjects"
        CType(Me.subjectsTbl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SubjectsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TORdbDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.rf3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rf2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rf1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelMenu.ResumeLayout(False)
        Me.panelMenu.PerformLayout()
        Me.userPanel.ResumeLayout(False)
        CType(Me.DatabaseBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.searchPanel.ResumeLayout(False)
        Me.searchPanel.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents credit As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents title As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents code As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents deleteBtn As System.Windows.Forms.Button
    Friend WithEvents editBtn As System.Windows.Forms.Button
    Friend WithEvents addBtn As System.Windows.Forms.Button
    Friend WithEvents subjectsTbl As System.Windows.Forms.DataGridView
    Friend WithEvents subjCreditLbl As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents subjCodeLbl As System.Windows.Forms.Label
    Friend WithEvents subjNameLbl As System.Windows.Forms.Label
    Friend WithEvents TORdbDataSet As TOR.TORdbDataSet
    Friend WithEvents SubjectsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SubjectsTableAdapter As TOR.TORdbDataSetTableAdapters.subjectsTableAdapter
    Friend WithEvents TableAdapterManager As TOR.TORdbDataSetTableAdapters.TableAdapterManager
    Friend WithEvents IDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SubjectCodeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SubjectNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CreditTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents dashboardBtn As System.Windows.Forms.Button
    Friend WithEvents studentsBtn As System.Windows.Forms.Button
    Friend WithEvents subjectsBtn As System.Windows.Forms.Button
    Friend WithEvents backupBtn As System.Windows.Forms.Button
    Friend WithEvents settingsBtn As System.Windows.Forms.Button
    Friend WithEvents helpBtn As System.Windows.Forms.Button
    Friend WithEvents homeBtn As System.Windows.Forms.Button
    Friend WithEvents panelMenu As System.Windows.Forms.Panel
    Friend WithEvents rf3 As System.Windows.Forms.PictureBox
    Friend WithEvents rf2 As System.Windows.Forms.PictureBox
    Friend WithEvents rf1 As System.Windows.Forms.PictureBox
    Friend WithEvents searchPanel As System.Windows.Forms.Panel
    Friend WithEvents searchLbl As System.Windows.Forms.Label
    Friend WithEvents clearSearchBtn As System.Windows.Forms.Button
    Friend WithEvents searchbox As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents userPanel As System.Windows.Forms.Panel
    Friend WithEvents user As System.Windows.Forms.Button
    Friend WithEvents logout As System.Windows.Forms.Button
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SubjectCodeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SubjectNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CreditDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents settingsSecret_button As System.Windows.Forms.Button
    Friend WithEvents DatabaseBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DatabaseTableAdapter As TOR.TORdbDataSetTableAdapters.databaseTableAdapter
    Friend WithEvents BackupPathLabel1 As System.Windows.Forms.Label
End Class
