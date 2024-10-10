<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dashboard_form
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
        Dim TotalLabel As System.Windows.Forms.Label
        Dim BackupPathLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dashboard_form))
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim ChartArea2 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend2 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series3 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.paelMenu = New System.Windows.Forms.Panel()
        Me.userPanel = New System.Windows.Forms.Panel()
        Me.user = New System.Windows.Forms.Button()
        Me.logout = New System.Windows.Forms.Button()
        Me.homeBtn = New System.Windows.Forms.Button()
        Me.helpBtn = New System.Windows.Forms.Button()
        Me.settingsBtn = New System.Windows.Forms.Button()
        Me.backupBtn = New System.Windows.Forms.Button()
        Me.subjectsBtn = New System.Windows.Forms.Button()
        Me.studentsBtn = New System.Windows.Forms.Button()
        Me.dashboardBtn = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.settingsSecret_button = New System.Windows.Forms.Button()
        Me.BackupPathLabel1 = New System.Windows.Forms.Label()
        Me.DatabaseBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TORdbDataSet = New TOR.TORdbDataSet()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.totalStudentsLbl = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.totalGradLbl = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.totalPrintLbl = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.realTime = New System.Windows.Forms.Timer(Me.components)
        Me.Chart2 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.StudentsInfoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StudentsInfoTableAdapter = New TOR.TORdbDataSetTableAdapters.studentsInfoTableAdapter()
        Me.TableAdapterManager = New TOR.TORdbDataSetTableAdapters.TableAdapterManager()
        Me.DatabaseTableAdapter = New TOR.TORdbDataSetTableAdapters.databaseTableAdapter()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.TotalPrintBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TotalPrintTableAdapter = New TOR.TORdbDataSetTableAdapters.totalPrintTableAdapter()
        Me.TotalLabel1 = New System.Windows.Forms.Label()
        TotalLabel = New System.Windows.Forms.Label()
        BackupPathLabel = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.paelMenu.SuspendLayout()
        Me.userPanel.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DatabaseBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TORdbDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Chart2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StudentsInfoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TotalPrintBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TotalLabel
        '
        TotalLabel.AutoSize = True
        TotalLabel.Location = New System.Drawing.Point(901, 133)
        TotalLabel.Name = "TotalLabel"
        TotalLabel.Size = New System.Drawing.Size(30, 13)
        TotalLabel.TabIndex = 10259
        TotalLabel.Text = "total:"
        '
        'BackupPathLabel
        '
        BackupPathLabel.AutoSize = True
        BackupPathLabel.Location = New System.Drawing.Point(317, 16)
        BackupPathLabel.Name = "BackupPathLabel"
        BackupPathLabel.Size = New System.Drawing.Size(71, 13)
        BackupPathLabel.TabIndex = 10288
        BackupPathLabel.Text = "backup Path:"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.SeaGreen
        Me.Panel1.Controls.Add(Me.PictureBox3)
        Me.Panel1.Location = New System.Drawing.Point(0, 667)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1348, 20)
        Me.Panel1.TabIndex = 10252
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(-42, 6)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(37, 37)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 10096
        Me.PictureBox3.TabStop = False
        '
        'paelMenu
        '
        Me.paelMenu.BackColor = System.Drawing.Color.SeaGreen
        Me.paelMenu.Controls.Add(Me.userPanel)
        Me.paelMenu.Controls.Add(Me.homeBtn)
        Me.paelMenu.Controls.Add(Me.helpBtn)
        Me.paelMenu.Controls.Add(Me.settingsBtn)
        Me.paelMenu.Controls.Add(Me.backupBtn)
        Me.paelMenu.Controls.Add(Me.subjectsBtn)
        Me.paelMenu.Controls.Add(Me.studentsBtn)
        Me.paelMenu.Controls.Add(Me.dashboardBtn)
        Me.paelMenu.Controls.Add(Me.PictureBox1)
        Me.paelMenu.Controls.Add(Me.settingsSecret_button)
        Me.paelMenu.Controls.Add(BackupPathLabel)
        Me.paelMenu.Controls.Add(Me.BackupPathLabel1)
        Me.paelMenu.Location = New System.Drawing.Point(0, 0)
        Me.paelMenu.Name = "paelMenu"
        Me.paelMenu.Size = New System.Drawing.Size(1356, 45)
        Me.paelMenu.TabIndex = 10250
        '
        'userPanel
        '
        Me.userPanel.Controls.Add(Me.user)
        Me.userPanel.Controls.Add(Me.logout)
        Me.userPanel.Location = New System.Drawing.Point(1099, 0)
        Me.userPanel.Name = "userPanel"
        Me.userPanel.Size = New System.Drawing.Size(237, 45)
        Me.userPanel.TabIndex = 10283
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
        'homeBtn
        '
        Me.homeBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.homeBtn.FlatAppearance.BorderSize = 0
        Me.homeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.homeBtn.Image = Global.TOR.My.Resources.Resources.home_icon_1
        Me.homeBtn.Location = New System.Drawing.Point(-1, 0)
        Me.homeBtn.Name = "homeBtn"
        Me.homeBtn.Size = New System.Drawing.Size(66, 45)
        Me.homeBtn.TabIndex = 7
        Me.homeBtn.UseVisualStyleBackColor = True
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
        Me.helpBtn.TabIndex = 6
        Me.helpBtn.Text = "Tutorials"
        Me.helpBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.helpBtn.UseVisualStyleBackColor = False
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
        Me.settingsBtn.TabIndex = 4
        Me.settingsBtn.Text = "Settings"
        Me.settingsBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.settingsBtn.UseVisualStyleBackColor = False
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
        Me.backupBtn.TabIndex = 3
        Me.backupBtn.Text = "Backup"
        Me.backupBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.backupBtn.UseVisualStyleBackColor = False
        '
        'subjectsBtn
        '
        Me.subjectsBtn.BackColor = System.Drawing.Color.SeaGreen
        Me.subjectsBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.subjectsBtn.FlatAppearance.BorderSize = 0
        Me.subjectsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.subjectsBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.subjectsBtn.ForeColor = System.Drawing.Color.White
        Me.subjectsBtn.Image = Global.TOR.My.Resources.Resources.subjects_icon_1
        Me.subjectsBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.subjectsBtn.Location = New System.Drawing.Point(257, 0)
        Me.subjectsBtn.Name = "subjectsBtn"
        Me.subjectsBtn.Size = New System.Drawing.Size(91, 45)
        Me.subjectsBtn.TabIndex = 2
        Me.subjectsBtn.Text = "Subjects"
        Me.subjectsBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.subjectsBtn.UseVisualStyleBackColor = False
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
        Me.studentsBtn.TabIndex = 1
        Me.studentsBtn.Text = "Students"
        Me.studentsBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.studentsBtn.UseVisualStyleBackColor = False
        '
        'dashboardBtn
        '
        Me.dashboardBtn.BackColor = System.Drawing.Color.White
        Me.dashboardBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dashboardBtn.FlatAppearance.BorderSize = 0
        Me.dashboardBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.dashboardBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dashboardBtn.ForeColor = System.Drawing.Color.SeaGreen
        Me.dashboardBtn.Image = Global.TOR.My.Resources.Resources.dashboard_icon_2
        Me.dashboardBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.dashboardBtn.Location = New System.Drawing.Point(64, 0)
        Me.dashboardBtn.Name = "dashboardBtn"
        Me.dashboardBtn.Size = New System.Drawing.Size(107, 45)
        Me.dashboardBtn.TabIndex = 1
        Me.dashboardBtn.Text = "Dashboard"
        Me.dashboardBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.dashboardBtn.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(-42, 6)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(37, 37)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 10096
        Me.PictureBox1.TabStop = False
        '
        'settingsSecret_button
        '
        Me.settingsSecret_button.Enabled = False
        Me.settingsSecret_button.Location = New System.Drawing.Point(433, 12)
        Me.settingsSecret_button.Name = "settingsSecret_button"
        Me.settingsSecret_button.Size = New System.Drawing.Size(120, 23)
        Me.settingsSecret_button.TabIndex = 10288
        Me.settingsSecret_button.Text = "go_to_settings"
        Me.settingsSecret_button.UseVisualStyleBackColor = True
        '
        'BackupPathLabel1
        '
        Me.BackupPathLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DatabaseBindingSource, "backupPath", True))
        Me.BackupPathLabel1.Location = New System.Drawing.Point(394, 16)
        Me.BackupPathLabel1.Name = "BackupPathLabel1"
        Me.BackupPathLabel1.Size = New System.Drawing.Size(100, 23)
        Me.BackupPathLabel1.TabIndex = 10289
        Me.BackupPathLabel1.Text = "Label17"
        '
        'DatabaseBindingSource
        '
        Me.DatabaseBindingSource.DataMember = "database"
        Me.DatabaseBindingSource.DataSource = Me.TORdbDataSet
        '
        'TORdbDataSet
        '
        Me.TORdbDataSet.DataSetName = "TORdbDataSet"
        Me.TORdbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.DarkOrange
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(40, 157)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(226, 25)
        Me.Label1.TabIndex = 10254
        Me.Label1.Text = "Total Students Record"
        '
        'totalStudentsLbl
        '
        Me.totalStudentsLbl.BackColor = System.Drawing.Color.DarkOrange
        Me.totalStudentsLbl.Cursor = System.Windows.Forms.Cursors.Hand
        Me.totalStudentsLbl.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrange
        Me.totalStudentsLbl.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrange
        Me.totalStudentsLbl.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOrange
        Me.totalStudentsLbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.totalStudentsLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.totalStudentsLbl.ForeColor = System.Drawing.Color.White
        Me.totalStudentsLbl.Location = New System.Drawing.Point(15, 185)
        Me.totalStudentsLbl.Name = "totalStudentsLbl"
        Me.totalStudentsLbl.Size = New System.Drawing.Size(238, 51)
        Me.totalStudentsLbl.TabIndex = 10255
        Me.totalStudentsLbl.Text = "0"
        Me.totalStudentsLbl.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Goldenrod
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(471, 157)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(241, 25)
        Me.Label2.TabIndex = 10254
        Me.Label2.Text = "Total Graduates Record"
        '
        'totalGradLbl
        '
        Me.totalGradLbl.BackColor = System.Drawing.Color.Goldenrod
        Me.totalGradLbl.Cursor = System.Windows.Forms.Cursors.Hand
        Me.totalGradLbl.FlatAppearance.BorderColor = System.Drawing.Color.Goldenrod
        Me.totalGradLbl.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Goldenrod
        Me.totalGradLbl.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Goldenrod
        Me.totalGradLbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.totalGradLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.totalGradLbl.ForeColor = System.Drawing.Color.White
        Me.totalGradLbl.Location = New System.Drawing.Point(459, 185)
        Me.totalGradLbl.Name = "totalGradLbl"
        Me.totalGradLbl.Size = New System.Drawing.Size(246, 51)
        Me.totalGradLbl.TabIndex = 10255
        Me.totalGradLbl.Text = "0"
        Me.totalGradLbl.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.ForestGreen
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(925, 157)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(207, 25)
        Me.Label3.TabIndex = 10254
        Me.Label3.Text = "Total TOR Released"
        '
        'totalPrintLbl
        '
        Me.totalPrintLbl.BackColor = System.Drawing.Color.ForestGreen
        Me.totalPrintLbl.Cursor = System.Windows.Forms.Cursors.Hand
        Me.totalPrintLbl.FlatAppearance.BorderColor = System.Drawing.Color.ForestGreen
        Me.totalPrintLbl.FlatAppearance.MouseDownBackColor = System.Drawing.Color.ForestGreen
        Me.totalPrintLbl.FlatAppearance.MouseOverBackColor = System.Drawing.Color.ForestGreen
        Me.totalPrintLbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.totalPrintLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.totalPrintLbl.ForeColor = System.Drawing.Color.White
        Me.totalPrintLbl.Location = New System.Drawing.Point(900, 185)
        Me.totalPrintLbl.Name = "totalPrintLbl"
        Me.totalPrintLbl.Size = New System.Drawing.Size(282, 51)
        Me.totalPrintLbl.TabIndex = 10255
        Me.totalPrintLbl.Text = "0"
        Me.totalPrintLbl.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.ForestGreen
        Me.Button3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button3.FlatAppearance.BorderColor = System.Drawing.Color.ForestGreen
        Me.Button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.ForestGreen
        Me.Button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.ForestGreen
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Image = Global.TOR.My.Resources.Resources.totalGraduates
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button3.Location = New System.Drawing.Point(900, 119)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(438, 167)
        Me.Button3.TabIndex = 10253
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Goldenrod
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.FlatAppearance.BorderColor = System.Drawing.Color.Goldenrod
        Me.Button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Goldenrod
        Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Goldenrod
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Image = Global.TOR.My.Resources.Resources.totalRelease
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button2.Location = New System.Drawing.Point(457, 119)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(438, 167)
        Me.Button2.TabIndex = 10253
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.DarkOrange
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrange
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrange
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOrange
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Image = Global.TOR.My.Resources.Resources.totalStudents
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.Location = New System.Drawing.Point(14, 119)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(438, 167)
        Me.Button1.TabIndex = 10253
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Chart1
        '
        ChartArea1.Name = "ChartArea1"
        Me.Chart1.ChartAreas.Add(ChartArea1)
        Me.Chart1.Cursor = System.Windows.Forms.Cursors.Hand
        Legend1.Name = "Legend1"
        Me.Chart1.Legends.Add(Legend1)
        Me.Chart1.Location = New System.Drawing.Point(12, 333)
        Me.Chart1.Name = "Chart1"
        Me.Chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright
        Series1.ChartArea = "ChartArea1"
        Series1.Legend = "Legend1"
        Series1.Name = "Course"
        Series1.YValuesPerPoint = 2
        Series2.ChartArea = "ChartArea1"
        Series2.Legend = "Legend1"
        Series2.Name = "Graduated"
        Me.Chart1.Series.Add(Series1)
        Me.Chart1.Series.Add(Series2)
        Me.Chart1.Size = New System.Drawing.Size(599, 317)
        Me.Chart1.TabIndex = 10256
        Me.Chart1.Text = "Chart1"
        '
        'realTime
        '
        '
        'Chart2
        '
        ChartArea2.Name = "ChartArea1"
        Me.Chart2.ChartAreas.Add(ChartArea2)
        Me.Chart2.Cursor = System.Windows.Forms.Cursors.Hand
        Legend2.Name = "Legend1"
        Me.Chart2.Legends.Add(Legend2)
        Me.Chart2.Location = New System.Drawing.Point(900, 333)
        Me.Chart2.Name = "Chart2"
        Series3.ChartArea = "ChartArea1"
        Series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut
        Series3.Legend = "Legend1"
        Series3.Name = "course"
        Me.Chart2.Series.Add(Series3)
        Me.Chart2.Size = New System.Drawing.Size(436, 332)
        Me.Chart2.TabIndex = 10256
        Me.Chart2.Text = "Chart1"
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
        Me.TableAdapterManager.totalPrintTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = TOR.TORdbDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.userAccountTableAdapter = Nothing
        '
        'DatabaseTableAdapter
        '
        Me.DatabaseTableAdapter.ClearBeforeFill = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(602, 425)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 25)
        Me.Label4.TabIndex = 10257
        Me.Label4.Text = "BSIT"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(602, 460)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(68, 25)
        Me.Label5.TabIndex = 10257
        Me.Label5.Text = "BSBA"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(602, 495)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(54, 25)
        Me.Label6.TabIndex = 10257
        Me.Label6.Text = "BSA"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(602, 530)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(84, 25)
        Me.Label7.TabIndex = 10257
        Me.Label7.Text = "BSCrim"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(602, 564)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(103, 25)
        Me.Label8.TabIndex = 10257
        Me.Label8.Text = "Midwifery"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(720, 425)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(24, 25)
        Me.Label9.TabIndex = 10257
        Me.Label9.Text = "0"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(720, 495)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(24, 25)
        Me.Label10.TabIndex = 10257
        Me.Label10.Text = "0"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(720, 460)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(24, 25)
        Me.Label11.TabIndex = 10257
        Me.Label11.Text = "0"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(720, 530)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(24, 25)
        Me.Label12.TabIndex = 10257
        Me.Label12.Text = "0"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(720, 564)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(24, 25)
        Me.Label13.TabIndex = 10257
        Me.Label13.Text = "0"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(130, 308)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(276, 25)
        Me.Label14.TabIndex = 10257
        Me.Label14.Text = "Students Graph Per Course"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(596, 379)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(160, 25)
        Me.Label15.TabIndex = 10257
        Me.Label15.Text = "Students Count"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(983, 308)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(199, 25)
        Me.Label16.TabIndex = 10257
        Me.Label16.Text = "Students Pie Graph"
        '
        'Button4
        '
        Me.Button4.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.Button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(1007, 481)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(111, 35)
        Me.Button4.TabIndex = 10258
        Me.Button4.Text = "0"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Enabled = False
        Me.Button5.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button5.FlatAppearance.BorderSize = 0
        Me.Button5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.Button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Font = New System.Drawing.Font("Trebuchet MS", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Location = New System.Drawing.Point(0, 47)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(1315, 72)
        Me.Button5.TabIndex = 10259
        Me.Button5.Text = "Dashboard"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'TotalPrintBindingSource
        '
        Me.TotalPrintBindingSource.DataMember = "totalPrint"
        Me.TotalPrintBindingSource.DataSource = Me.TORdbDataSet
        '
        'TotalPrintTableAdapter
        '
        Me.TotalPrintTableAdapter.ClearBeforeFill = True
        '
        'TotalLabel1
        '
        Me.TotalLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TotalPrintBindingSource, "total", True))
        Me.TotalLabel1.Location = New System.Drawing.Point(937, 133)
        Me.TotalLabel1.Name = "TotalLabel1"
        Me.TotalLabel1.Size = New System.Drawing.Size(100, 23)
        Me.TotalLabel1.TabIndex = 10260
        Me.TotalLabel1.Text = "Label17"
        '
        'dashboard_form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1348, 687)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Chart2)
        Me.Controls.Add(Me.Chart1)
        Me.Controls.Add(Me.totalPrintLbl)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.totalGradLbl)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.totalStudentsLbl)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.paelMenu)
        Me.Controls.Add(TotalLabel)
        Me.Controls.Add(Me.TotalLabel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(1364, 726)
        Me.MinimumSize = New System.Drawing.Size(1364, 726)
        Me.Name = "dashboard_form"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Dashboard"
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.paelMenu.ResumeLayout(False)
        Me.paelMenu.PerformLayout()
        Me.userPanel.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DatabaseBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TORdbDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Chart2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StudentsInfoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TotalPrintBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents homeBtn As System.Windows.Forms.Button
    Friend WithEvents helpBtn As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents settingsBtn As System.Windows.Forms.Button
    Friend WithEvents backupBtn As System.Windows.Forms.Button
    Friend WithEvents subjectsBtn As System.Windows.Forms.Button
    Friend WithEvents studentsBtn As System.Windows.Forms.Button
    Friend WithEvents paelMenu As System.Windows.Forms.Panel
    Friend WithEvents dashboardBtn As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents totalStudentsLbl As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents totalGradLbl As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents totalPrintLbl As System.Windows.Forms.Button
    Friend WithEvents Chart1 As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents TORdbDataSet As TOR.TORdbDataSet
    Friend WithEvents StudentsInfoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents StudentsInfoTableAdapter As TOR.TORdbDataSetTableAdapters.studentsInfoTableAdapter
    Friend WithEvents TableAdapterManager As TOR.TORdbDataSetTableAdapters.TableAdapterManager
    Friend WithEvents DatabaseBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DatabaseTableAdapter As TOR.TORdbDataSetTableAdapters.databaseTableAdapter
    Friend WithEvents realTime As System.Windows.Forms.Timer
    Friend WithEvents Chart2 As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents userPanel As System.Windows.Forms.Panel
    Friend WithEvents user As System.Windows.Forms.Button
    Friend WithEvents logout As System.Windows.Forms.Button
    Friend WithEvents TotalPrintBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TotalPrintTableAdapter As TOR.TORdbDataSetTableAdapters.totalPrintTableAdapter
    Friend WithEvents TotalLabel1 As System.Windows.Forms.Label
    Friend WithEvents settingsSecret_button As System.Windows.Forms.Button
    Friend WithEvents BackupPathLabel1 As System.Windows.Forms.Label
End Class
