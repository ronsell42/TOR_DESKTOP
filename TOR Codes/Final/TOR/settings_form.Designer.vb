<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class settings_form
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
        Dim UsernameLabel As System.Windows.Forms.Label
        Dim PasswordLabel As System.Windows.Forms.Label
        Dim PinCodeLabel As System.Windows.Forms.Label
        Dim BackupEmailLabel As System.Windows.Forms.Label
        Dim BackupPasswordLabel As System.Windows.Forms.Label
        Dim UserLabel As System.Windows.Forms.Label
        Dim qweLbl As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim Label10 As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim CompleteNameLabel As System.Windows.Forms.Label
        Dim backupPath_label As System.Windows.Forms.Label
        Dim BackupPathLabel As System.Windows.Forms.Label
        Dim restorePath_label As System.Windows.Forms.Label
        Dim BackupPathLabel1 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(settings_form))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
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
        Me.BackupPathLabel2 = New System.Windows.Forms.Label()
        Me.DatabaseBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TORdbDataSet = New TOR.TORdbDataSet()
        Me.accSettBtn = New System.Windows.Forms.Button()
        Me.backupSettBtn = New System.Windows.Forms.Button()
        Me.aboutSettBtn = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.CompleteNameTextBox = New System.Windows.Forms.TextBox()
        Me.UserAccountBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UserTextBox = New System.Windows.Forms.TextBox()
        Me.BackupPasswordTextBox = New System.Windows.Forms.TextBox()
        Me.BackupEmailTextBox = New System.Windows.Forms.TextBox()
        Me.BAccountNameTextBox = New System.Windows.Forms.TextBox()
        Me.PinCodeTextBox = New System.Windows.Forms.TextBox()
        Me.UsernameTextBox = New System.Windows.Forms.TextBox()
        Me.PasswordTextBox = New System.Windows.Forms.TextBox()
        Me.SettingsTabControl = New System.Windows.Forms.TabControl()
        Me.backupSett = New System.Windows.Forms.TabPage()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.clearSearch2_btn = New System.Windows.Forms.Button()
        Me.clearSearch1_btn = New System.Windows.Forms.Button()
        Me.undoChange1_btton = New System.Windows.Forms.Button()
        Me.browse_button = New System.Windows.Forms.Button()
        Me.restorePath_textbox = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.restoreData_button = New System.Windows.Forms.Button()
        Me.backupNow_button = New System.Windows.Forms.Button()
        Me.change_button = New System.Windows.Forms.Button()
        Me.undoChange_button = New System.Windows.Forms.Button()
        Me.backupPath_textbox = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.formStatus_label = New System.Windows.Forms.Label()
        Me.BackupPathTextBox = New System.Windows.Forms.TextBox()
        Me.accSett = New System.Windows.Forms.TabPage()
        Me.UsertypeBox = New System.Windows.Forms.Button()
        Me.userTbl = New System.Windows.Forms.DataGridView()
        Me.accQ = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UsernameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.deleteBtn = New System.Windows.Forms.Button()
        Me.editBtn = New System.Windows.Forms.Button()
        Me.addBtn = New System.Windows.Forms.Button()
        Me.accountDetailsArea = New System.Windows.Forms.GroupBox()
        Me.show2 = New System.Windows.Forms.Button()
        Me.passBox2 = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.rf2 = New System.Windows.Forms.PictureBox()
        Me.rf3 = New System.Windows.Forms.PictureBox()
        Me.rf1 = New System.Windows.Forms.PictureBox()
        Me.completeNameBox = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.show1 = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.notMatch1 = New System.Windows.Forms.Label()
        Me.acctypeBox = New System.Windows.Forms.Label()
        Me.userBox = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.passBox = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.UserUsername = New System.Windows.Forms.Button()
        Me.aboutSett = New System.Windows.Forms.TabPage()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.FolderBrowserDialog2 = New System.Windows.Forms.FolderBrowserDialog()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.UserAccountTableAdapter = New TOR.TORdbDataSetTableAdapters.userAccountTableAdapter()
        Me.TableAdapterManager = New TOR.TORdbDataSetTableAdapters.TableAdapterManager()
        Me.DatabaseTableAdapter = New TOR.TORdbDataSetTableAdapters.databaseTableAdapter()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.icon1 = New System.Windows.Forms.PictureBox()
        UsernameLabel = New System.Windows.Forms.Label()
        PasswordLabel = New System.Windows.Forms.Label()
        PinCodeLabel = New System.Windows.Forms.Label()
        BackupEmailLabel = New System.Windows.Forms.Label()
        BackupPasswordLabel = New System.Windows.Forms.Label()
        UserLabel = New System.Windows.Forms.Label()
        qweLbl = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        Label10 = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        CompleteNameLabel = New System.Windows.Forms.Label()
        backupPath_label = New System.Windows.Forms.Label()
        BackupPathLabel = New System.Windows.Forms.Label()
        restorePath_label = New System.Windows.Forms.Label()
        BackupPathLabel1 = New System.Windows.Forms.Label()
        Me.paelMenu.SuspendLayout()
        Me.userPanel.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DatabaseBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TORdbDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.UserAccountBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SettingsTabControl.SuspendLayout()
        Me.backupSett.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.accSett.SuspendLayout()
        CType(Me.userTbl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.accountDetailsArea.SuspendLayout()
        CType(Me.rf2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rf3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rf1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.aboutSett.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel6.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.icon1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UsernameLabel
        '
        UsernameLabel.AutoSize = True
        UsernameLabel.Location = New System.Drawing.Point(117, 405)
        UsernameLabel.Name = "UsernameLabel"
        UsernameLabel.Size = New System.Drawing.Size(56, 13)
        UsernameLabel.TabIndex = 3
        UsernameLabel.Text = "username:"
        '
        'PasswordLabel
        '
        PasswordLabel.AutoSize = True
        PasswordLabel.Location = New System.Drawing.Point(117, 431)
        PasswordLabel.Name = "PasswordLabel"
        PasswordLabel.Size = New System.Drawing.Size(55, 13)
        PasswordLabel.TabIndex = 5
        PasswordLabel.Text = "password:"
        '
        'PinCodeLabel
        '
        PinCodeLabel.AutoSize = True
        PinCodeLabel.Location = New System.Drawing.Point(117, 457)
        PinCodeLabel.Name = "PinCodeLabel"
        PinCodeLabel.Size = New System.Drawing.Size(52, 13)
        PinCodeLabel.TabIndex = 7
        PinCodeLabel.Text = "pin Code:"
        '
        'BackupEmailLabel
        '
        BackupEmailLabel.AutoSize = True
        BackupEmailLabel.Location = New System.Drawing.Point(117, 509)
        BackupEmailLabel.Name = "BackupEmailLabel"
        BackupEmailLabel.Size = New System.Drawing.Size(74, 13)
        BackupEmailLabel.TabIndex = 11
        BackupEmailLabel.Text = "backup Email:"
        '
        'BackupPasswordLabel
        '
        BackupPasswordLabel.AutoSize = True
        BackupPasswordLabel.Location = New System.Drawing.Point(117, 535)
        BackupPasswordLabel.Name = "BackupPasswordLabel"
        BackupPasswordLabel.Size = New System.Drawing.Size(95, 13)
        BackupPasswordLabel.TabIndex = 13
        BackupPasswordLabel.Text = "backup Password:"
        '
        'UserLabel
        '
        UserLabel.AutoSize = True
        UserLabel.Location = New System.Drawing.Point(117, 587)
        UserLabel.Name = "UserLabel"
        UserLabel.Size = New System.Drawing.Size(30, 13)
        UserLabel.TabIndex = 17
        UserLabel.Text = "user:"
        '
        'qweLbl
        '
        qweLbl.AutoSize = True
        qweLbl.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        qweLbl.ForeColor = System.Drawing.Color.Black
        qweLbl.Location = New System.Drawing.Point(49, 159)
        qweLbl.Name = "qweLbl"
        qweLbl.Size = New System.Drawing.Size(120, 18)
        qweLbl.TabIndex = 10217
        qweLbl.Text = "Re-Enter Password:"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label1.ForeColor = System.Drawing.Color.Black
        Label1.Location = New System.Drawing.Point(103, 119)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(66, 18)
        Label1.TabIndex = 10217
        Label1.Text = "Password:"
        '
        'Label10
        '
        Label10.AutoSize = True
        Label10.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label10.ForeColor = System.Drawing.Color.Black
        Label10.Location = New System.Drawing.Point(99, 80)
        Label10.Name = "Label10"
        Label10.Size = New System.Drawing.Size(71, 18)
        Label10.TabIndex = 10217
        Label10.Text = "Username:"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label2.ForeColor = System.Drawing.Color.Black
        Label2.Location = New System.Drawing.Point(65, 42)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(105, 18)
        Label2.TabIndex = 10217
        Label2.Text = "Complete Name:"
        '
        'CompleteNameLabel
        '
        CompleteNameLabel.AutoSize = True
        CompleteNameLabel.Location = New System.Drawing.Point(128, 379)
        CompleteNameLabel.Name = "CompleteNameLabel"
        CompleteNameLabel.Size = New System.Drawing.Size(84, 13)
        CompleteNameLabel.TabIndex = 10255
        CompleteNameLabel.Text = "complete Name:"
        '
        'backupPath_label
        '
        backupPath_label.AutoSize = True
        backupPath_label.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        backupPath_label.ForeColor = System.Drawing.Color.Black
        backupPath_label.Location = New System.Drawing.Point(91, 50)
        backupPath_label.Name = "backupPath_label"
        backupPath_label.Size = New System.Drawing.Size(141, 18)
        backupPath_label.TabIndex = 10218
        backupPath_label.Text = "Database Backup Path:"
        '
        'BackupPathLabel
        '
        BackupPathLabel.AutoSize = True
        BackupPathLabel.Location = New System.Drawing.Point(451, 120)
        BackupPathLabel.Name = "BackupPathLabel"
        BackupPathLabel.Size = New System.Drawing.Size(71, 13)
        BackupPathLabel.TabIndex = 10255
        BackupPathLabel.Text = "backup Path:"
        '
        'restorePath_label
        '
        restorePath_label.AutoSize = True
        restorePath_label.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        restorePath_label.ForeColor = System.Drawing.Color.Black
        restorePath_label.Location = New System.Drawing.Point(93, 184)
        restorePath_label.Name = "restorePath_label"
        restorePath_label.Size = New System.Drawing.Size(140, 18)
        restorePath_label.TabIndex = 10218
        restorePath_label.Text = "Database Restore File:"
        '
        'BackupPathLabel1
        '
        BackupPathLabel1.AutoSize = True
        BackupPathLabel1.Location = New System.Drawing.Point(331, 14)
        BackupPathLabel1.Name = "BackupPathLabel1"
        BackupPathLabel1.Size = New System.Drawing.Size(71, 13)
        BackupPathLabel1.TabIndex = 1000000005
        BackupPathLabel1.Text = "backup Path:"
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
        Me.paelMenu.Controls.Add(BackupPathLabel1)
        Me.paelMenu.Controls.Add(Me.BackupPathLabel2)
        Me.paelMenu.Location = New System.Drawing.Point(0, 0)
        Me.paelMenu.Name = "paelMenu"
        Me.paelMenu.Size = New System.Drawing.Size(1348, 45)
        Me.paelMenu.TabIndex = 10251
        '
        'userPanel
        '
        Me.userPanel.Controls.Add(Me.user)
        Me.userPanel.Controls.Add(Me.logout)
        Me.userPanel.Location = New System.Drawing.Point(1099, 0)
        Me.userPanel.Name = "userPanel"
        Me.userPanel.Size = New System.Drawing.Size(237, 45)
        Me.userPanel.TabIndex = 10284
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
        Me.settingsBtn.BackColor = System.Drawing.Color.White
        Me.settingsBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.settingsBtn.FlatAppearance.BorderSize = 0
        Me.settingsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.settingsBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.settingsBtn.ForeColor = System.Drawing.Color.SeaGreen
        Me.settingsBtn.Image = Global.TOR.My.Resources.Resources.settings_icon_2
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
        'BackupPathLabel2
        '
        Me.BackupPathLabel2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DatabaseBindingSource, "backupPath", True))
        Me.BackupPathLabel2.Location = New System.Drawing.Point(423, 14)
        Me.BackupPathLabel2.Name = "BackupPathLabel2"
        Me.BackupPathLabel2.Size = New System.Drawing.Size(100, 23)
        Me.BackupPathLabel2.TabIndex = 1000000006
        Me.BackupPathLabel2.Text = "Label5"
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
        'accSettBtn
        '
        Me.accSettBtn.BackColor = System.Drawing.SystemColors.Control
        Me.accSettBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.accSettBtn.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen
        Me.accSettBtn.FlatAppearance.BorderSize = 0
        Me.accSettBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.accSettBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.accSettBtn.ForeColor = System.Drawing.Color.Black
        Me.accSettBtn.Location = New System.Drawing.Point(0, 2)
        Me.accSettBtn.Name = "accSettBtn"
        Me.accSettBtn.Size = New System.Drawing.Size(253, 43)
        Me.accSettBtn.TabIndex = 10255
        Me.accSettBtn.Text = "Account Settings"
        Me.accSettBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.accSettBtn.UseVisualStyleBackColor = False
        '
        'backupSettBtn
        '
        Me.backupSettBtn.BackColor = System.Drawing.SystemColors.Control
        Me.backupSettBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.backupSettBtn.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen
        Me.backupSettBtn.FlatAppearance.BorderSize = 0
        Me.backupSettBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.backupSettBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.backupSettBtn.ForeColor = System.Drawing.Color.Black
        Me.backupSettBtn.Location = New System.Drawing.Point(0, 45)
        Me.backupSettBtn.Name = "backupSettBtn"
        Me.backupSettBtn.Size = New System.Drawing.Size(253, 43)
        Me.backupSettBtn.TabIndex = 10255
        Me.backupSettBtn.Text = "Backup and Restore"
        Me.backupSettBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.backupSettBtn.UseVisualStyleBackColor = False
        '
        'aboutSettBtn
        '
        Me.aboutSettBtn.BackColor = System.Drawing.SystemColors.Control
        Me.aboutSettBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.aboutSettBtn.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen
        Me.aboutSettBtn.FlatAppearance.BorderSize = 0
        Me.aboutSettBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.aboutSettBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.aboutSettBtn.ForeColor = System.Drawing.Color.Black
        Me.aboutSettBtn.Location = New System.Drawing.Point(0, 88)
        Me.aboutSettBtn.Name = "aboutSettBtn"
        Me.aboutSettBtn.Size = New System.Drawing.Size(253, 43)
        Me.aboutSettBtn.TabIndex = 10255
        Me.aboutSettBtn.Text = "About"
        Me.aboutSettBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.aboutSettBtn.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Control
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.accSettBtn)
        Me.Panel1.Controls.Add(Me.aboutSettBtn)
        Me.Panel1.Controls.Add(Me.backupSettBtn)
        Me.Panel1.Controls.Add(CompleteNameLabel)
        Me.Panel1.Controls.Add(Me.CompleteNameTextBox)
        Me.Panel1.Controls.Add(BackupPasswordLabel)
        Me.Panel1.Controls.Add(Me.UserTextBox)
        Me.Panel1.Controls.Add(UserLabel)
        Me.Panel1.Controls.Add(Me.BackupPasswordTextBox)
        Me.Panel1.Controls.Add(Me.BackupEmailTextBox)
        Me.Panel1.Controls.Add(UsernameLabel)
        Me.Panel1.Controls.Add(BackupEmailLabel)
        Me.Panel1.Controls.Add(Me.BAccountNameTextBox)
        Me.Panel1.Controls.Add(PasswordLabel)
        Me.Panel1.Controls.Add(Me.PinCodeTextBox)
        Me.Panel1.Controls.Add(PinCodeLabel)
        Me.Panel1.Location = New System.Drawing.Point(116, 106)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(256, 427)
        Me.Panel1.TabIndex = 10256
        '
        'Panel3
        '
        Me.Panel3.Location = New System.Drawing.Point(3, 358)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(326, 246)
        Me.Panel3.TabIndex = 10257
        '
        'CompleteNameTextBox
        '
        Me.CompleteNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UserAccountBindingSource, "completeName", True))
        Me.CompleteNameTextBox.Enabled = False
        Me.CompleteNameTextBox.Location = New System.Drawing.Point(218, 376)
        Me.CompleteNameTextBox.Name = "CompleteNameTextBox"
        Me.CompleteNameTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CompleteNameTextBox.TabIndex = 10256
        '
        'UserAccountBindingSource
        '
        Me.UserAccountBindingSource.DataMember = "userAccount"
        Me.UserAccountBindingSource.DataSource = Me.TORdbDataSet
        '
        'UserTextBox
        '
        Me.UserTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UserAccountBindingSource, "user", True))
        Me.UserTextBox.Enabled = False
        Me.UserTextBox.Location = New System.Drawing.Point(218, 584)
        Me.UserTextBox.Name = "UserTextBox"
        Me.UserTextBox.Size = New System.Drawing.Size(100, 20)
        Me.UserTextBox.TabIndex = 18
        '
        'BackupPasswordTextBox
        '
        Me.BackupPasswordTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UserAccountBindingSource, "backupPassword", True))
        Me.BackupPasswordTextBox.Enabled = False
        Me.BackupPasswordTextBox.Location = New System.Drawing.Point(218, 532)
        Me.BackupPasswordTextBox.Name = "BackupPasswordTextBox"
        Me.BackupPasswordTextBox.Size = New System.Drawing.Size(100, 20)
        Me.BackupPasswordTextBox.TabIndex = 14
        '
        'BackupEmailTextBox
        '
        Me.BackupEmailTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UserAccountBindingSource, "backupEmail", True))
        Me.BackupEmailTextBox.Enabled = False
        Me.BackupEmailTextBox.Location = New System.Drawing.Point(218, 506)
        Me.BackupEmailTextBox.Name = "BackupEmailTextBox"
        Me.BackupEmailTextBox.Size = New System.Drawing.Size(100, 20)
        Me.BackupEmailTextBox.TabIndex = 12
        '
        'BAccountNameTextBox
        '
        Me.BAccountNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UserAccountBindingSource, "bAccountName", True))
        Me.BAccountNameTextBox.Enabled = False
        Me.BAccountNameTextBox.Location = New System.Drawing.Point(218, 480)
        Me.BAccountNameTextBox.Name = "BAccountNameTextBox"
        Me.BAccountNameTextBox.Size = New System.Drawing.Size(100, 20)
        Me.BAccountNameTextBox.TabIndex = 10
        '
        'PinCodeTextBox
        '
        Me.PinCodeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UserAccountBindingSource, "pinCode", True))
        Me.PinCodeTextBox.Enabled = False
        Me.PinCodeTextBox.Location = New System.Drawing.Point(218, 454)
        Me.PinCodeTextBox.Name = "PinCodeTextBox"
        Me.PinCodeTextBox.Size = New System.Drawing.Size(100, 20)
        Me.PinCodeTextBox.TabIndex = 8
        '
        'UsernameTextBox
        '
        Me.UsernameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UserAccountBindingSource, "username", True))
        Me.UsernameTextBox.Enabled = False
        Me.UsernameTextBox.Location = New System.Drawing.Point(270, 568)
        Me.UsernameTextBox.Name = "UsernameTextBox"
        Me.UsernameTextBox.Size = New System.Drawing.Size(137, 20)
        Me.UsernameTextBox.TabIndex = 4
        '
        'PasswordTextBox
        '
        Me.PasswordTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UserAccountBindingSource, "password", True))
        Me.PasswordTextBox.Enabled = False
        Me.PasswordTextBox.Location = New System.Drawing.Point(270, 542)
        Me.PasswordTextBox.Name = "PasswordTextBox"
        Me.PasswordTextBox.Size = New System.Drawing.Size(137, 20)
        Me.PasswordTextBox.TabIndex = 6
        '
        'SettingsTabControl
        '
        Me.SettingsTabControl.Controls.Add(Me.backupSett)
        Me.SettingsTabControl.Controls.Add(Me.accSett)
        Me.SettingsTabControl.Controls.Add(Me.aboutSett)
        Me.SettingsTabControl.Location = New System.Drawing.Point(358, 23)
        Me.SettingsTabControl.Name = "SettingsTabControl"
        Me.SettingsTabControl.SelectedIndex = 0
        Me.SettingsTabControl.Size = New System.Drawing.Size(978, 652)
        Me.SettingsTabControl.TabIndex = 10257
        '
        'backupSett
        '
        Me.backupSett.BackColor = System.Drawing.Color.White
        Me.backupSett.Controls.Add(Me.GroupBox1)
        Me.backupSett.Controls.Add(BackupPathLabel)
        Me.backupSett.Controls.Add(Me.BackupPathTextBox)
        Me.backupSett.Location = New System.Drawing.Point(4, 22)
        Me.backupSett.Name = "backupSett"
        Me.backupSett.Padding = New System.Windows.Forms.Padding(3)
        Me.backupSett.Size = New System.Drawing.Size(970, 626)
        Me.backupSett.TabIndex = 1
        Me.backupSett.Text = "Backup"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.clearSearch2_btn)
        Me.GroupBox1.Controls.Add(Me.clearSearch1_btn)
        Me.GroupBox1.Controls.Add(Me.undoChange1_btton)
        Me.GroupBox1.Controls.Add(Me.browse_button)
        Me.GroupBox1.Controls.Add(Me.restorePath_textbox)
        Me.GroupBox1.Controls.Add(Me.restoreData_button)
        Me.GroupBox1.Controls.Add(Me.backupNow_button)
        Me.GroupBox1.Controls.Add(Me.change_button)
        Me.GroupBox1.Controls.Add(restorePath_label)
        Me.GroupBox1.Controls.Add(backupPath_label)
        Me.GroupBox1.Controls.Add(Me.undoChange_button)
        Me.GroupBox1.Controls.Add(Me.backupPath_textbox)
        Me.GroupBox1.Controls.Add(Me.formStatus_label)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.SeaGreen
        Me.GroupBox1.Location = New System.Drawing.Point(19, 89)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(614, 399)
        Me.GroupBox1.TabIndex = 10275
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Backup and Restore"
        '
        'clearSearch2_btn
        '
        Me.clearSearch2_btn.BackColor = System.Drawing.Color.White
        Me.clearSearch2_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.clearSearch2_btn.FlatAppearance.BorderColor = System.Drawing.Color.Lavender
        Me.clearSearch2_btn.FlatAppearance.BorderSize = 0
        Me.clearSearch2_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lavender
        Me.clearSearch2_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lavender
        Me.clearSearch2_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.clearSearch2_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clearSearch2_btn.Location = New System.Drawing.Point(432, 208)
        Me.clearSearch2_btn.Name = "clearSearch2_btn"
        Me.clearSearch2_btn.Size = New System.Drawing.Size(44, 28)
        Me.clearSearch2_btn.TabIndex = 1000000004
        Me.clearSearch2_btn.Text = "x"
        Me.clearSearch2_btn.UseVisualStyleBackColor = False
        Me.clearSearch2_btn.Visible = False
        '
        'clearSearch1_btn
        '
        Me.clearSearch1_btn.BackColor = System.Drawing.Color.White
        Me.clearSearch1_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.clearSearch1_btn.FlatAppearance.BorderColor = System.Drawing.Color.Lavender
        Me.clearSearch1_btn.FlatAppearance.BorderSize = 0
        Me.clearSearch1_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lavender
        Me.clearSearch1_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lavender
        Me.clearSearch1_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.clearSearch1_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clearSearch1_btn.Location = New System.Drawing.Point(431, 74)
        Me.clearSearch1_btn.Name = "clearSearch1_btn"
        Me.clearSearch1_btn.Size = New System.Drawing.Size(44, 28)
        Me.clearSearch1_btn.TabIndex = 1000000003
        Me.clearSearch1_btn.Text = "x"
        Me.clearSearch1_btn.UseVisualStyleBackColor = False
        Me.clearSearch1_btn.Visible = False
        '
        'undoChange1_btton
        '
        Me.undoChange1_btton.BackColor = System.Drawing.Color.SeaGreen
        Me.undoChange1_btton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.undoChange1_btton.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen
        Me.undoChange1_btton.FlatAppearance.BorderSize = 0
        Me.undoChange1_btton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.undoChange1_btton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.undoChange1_btton.ForeColor = System.Drawing.Color.White
        Me.undoChange1_btton.Location = New System.Drawing.Point(96, 244)
        Me.undoChange1_btton.Name = "undoChange1_btton"
        Me.undoChange1_btton.Size = New System.Drawing.Size(100, 30)
        Me.undoChange1_btton.TabIndex = 1000000002
        Me.undoChange1_btton.Text = "Undo Change"
        Me.undoChange1_btton.UseVisualStyleBackColor = False
        Me.undoChange1_btton.Visible = False
        '
        'browse_button
        '
        Me.browse_button.BackColor = System.Drawing.Color.SeaGreen
        Me.browse_button.Cursor = System.Windows.Forms.Cursors.Hand
        Me.browse_button.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen
        Me.browse_button.FlatAppearance.BorderSize = 0
        Me.browse_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.browse_button.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.browse_button.ForeColor = System.Drawing.Color.White
        Me.browse_button.Location = New System.Drawing.Point(483, 207)
        Me.browse_button.Name = "browse_button"
        Me.browse_button.Size = New System.Drawing.Size(70, 30)
        Me.browse_button.TabIndex = 1000000001
        Me.browse_button.Text = "Browse"
        Me.browse_button.UseVisualStyleBackColor = False
        '
        'restorePath_textbox
        '
        Me.restorePath_textbox.BorderColorFocused = System.Drawing.SystemColors.MenuHighlight
        Me.restorePath_textbox.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.restorePath_textbox.BorderColorMouseHover = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.restorePath_textbox.BorderThickness = 1
        Me.restorePath_textbox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.restorePath_textbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.restorePath_textbox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.restorePath_textbox.isPassword = False
        Me.restorePath_textbox.Location = New System.Drawing.Point(96, 206)
        Me.restorePath_textbox.Margin = New System.Windows.Forms.Padding(4)
        Me.restorePath_textbox.Name = "restorePath_textbox"
        Me.restorePath_textbox.Size = New System.Drawing.Size(381, 31)
        Me.restorePath_textbox.TabIndex = 10273
        Me.restorePath_textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'restoreData_button
        '
        Me.restoreData_button.BackColor = System.Drawing.Color.SeaGreen
        Me.restoreData_button.Cursor = System.Windows.Forms.Cursors.Hand
        Me.restoreData_button.Enabled = False
        Me.restoreData_button.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen
        Me.restoreData_button.FlatAppearance.BorderSize = 0
        Me.restoreData_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.restoreData_button.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.restoreData_button.ForeColor = System.Drawing.Color.White
        Me.restoreData_button.Location = New System.Drawing.Point(298, 244)
        Me.restoreData_button.Name = "restoreData_button"
        Me.restoreData_button.Size = New System.Drawing.Size(178, 66)
        Me.restoreData_button.TabIndex = 10272
        Me.restoreData_button.Text = "Restore Data"
        Me.restoreData_button.UseVisualStyleBackColor = False
        '
        'backupNow_button
        '
        Me.backupNow_button.BackColor = System.Drawing.Color.SeaGreen
        Me.backupNow_button.Cursor = System.Windows.Forms.Cursors.Hand
        Me.backupNow_button.Enabled = False
        Me.backupNow_button.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen
        Me.backupNow_button.FlatAppearance.BorderSize = 0
        Me.backupNow_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.backupNow_button.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.backupNow_button.ForeColor = System.Drawing.Color.White
        Me.backupNow_button.Location = New System.Drawing.Point(298, 110)
        Me.backupNow_button.Name = "backupNow_button"
        Me.backupNow_button.Size = New System.Drawing.Size(179, 66)
        Me.backupNow_button.TabIndex = 10272
        Me.backupNow_button.Text = "Backup Now"
        Me.backupNow_button.UseVisualStyleBackColor = False
        '
        'change_button
        '
        Me.change_button.BackColor = System.Drawing.Color.SeaGreen
        Me.change_button.Cursor = System.Windows.Forms.Cursors.Hand
        Me.change_button.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen
        Me.change_button.FlatAppearance.BorderSize = 0
        Me.change_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.change_button.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.change_button.ForeColor = System.Drawing.Color.White
        Me.change_button.Location = New System.Drawing.Point(483, 73)
        Me.change_button.Name = "change_button"
        Me.change_button.Size = New System.Drawing.Size(70, 30)
        Me.change_button.TabIndex = 10255
        Me.change_button.Text = "Change"
        Me.change_button.UseVisualStyleBackColor = False
        '
        'undoChange_button
        '
        Me.undoChange_button.BackColor = System.Drawing.Color.SeaGreen
        Me.undoChange_button.Cursor = System.Windows.Forms.Cursors.Hand
        Me.undoChange_button.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen
        Me.undoChange_button.FlatAppearance.BorderSize = 0
        Me.undoChange_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.undoChange_button.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.undoChange_button.ForeColor = System.Drawing.Color.White
        Me.undoChange_button.Location = New System.Drawing.Point(94, 110)
        Me.undoChange_button.Name = "undoChange_button"
        Me.undoChange_button.Size = New System.Drawing.Size(100, 30)
        Me.undoChange_button.TabIndex = 10255
        Me.undoChange_button.Text = "Undo Change"
        Me.undoChange_button.UseVisualStyleBackColor = False
        Me.undoChange_button.Visible = False
        '
        'backupPath_textbox
        '
        Me.backupPath_textbox.BorderColorFocused = System.Drawing.SystemColors.MenuHighlight
        Me.backupPath_textbox.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.backupPath_textbox.BorderColorMouseHover = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.backupPath_textbox.BorderThickness = 1
        Me.backupPath_textbox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.backupPath_textbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.backupPath_textbox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.backupPath_textbox.isPassword = False
        Me.backupPath_textbox.Location = New System.Drawing.Point(93, 72)
        Me.backupPath_textbox.Margin = New System.Windows.Forms.Padding(4)
        Me.backupPath_textbox.Name = "backupPath_textbox"
        Me.backupPath_textbox.Size = New System.Drawing.Size(383, 31)
        Me.backupPath_textbox.TabIndex = 1
        Me.backupPath_textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'formStatus_label
        '
        Me.formStatus_label.AutoSize = True
        Me.formStatus_label.Location = New System.Drawing.Point(399, 270)
        Me.formStatus_label.Name = "formStatus_label"
        Me.formStatus_label.Size = New System.Drawing.Size(76, 16)
        Me.formStatus_label.TabIndex = 1000000005
        Me.formStatus_label.Text = "form_status"
        '
        'BackupPathTextBox
        '
        Me.BackupPathTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DatabaseBindingSource, "backupPath", True))
        Me.BackupPathTextBox.Enabled = False
        Me.BackupPathTextBox.Location = New System.Drawing.Point(528, 117)
        Me.BackupPathTextBox.Name = "BackupPathTextBox"
        Me.BackupPathTextBox.Size = New System.Drawing.Size(100, 20)
        Me.BackupPathTextBox.TabIndex = 10256
        '
        'accSett
        '
        Me.accSett.BackColor = System.Drawing.Color.White
        Me.accSett.Controls.Add(Me.UsertypeBox)
        Me.accSett.Controls.Add(Me.userTbl)
        Me.accSett.Controls.Add(Me.deleteBtn)
        Me.accSett.Controls.Add(Me.editBtn)
        Me.accSett.Controls.Add(Me.addBtn)
        Me.accSett.Controls.Add(Me.accountDetailsArea)
        Me.accSett.Controls.Add(Me.UserUsername)
        Me.accSett.Location = New System.Drawing.Point(4, 22)
        Me.accSett.Name = "accSett"
        Me.accSett.Padding = New System.Windows.Forms.Padding(3)
        Me.accSett.Size = New System.Drawing.Size(970, 626)
        Me.accSett.TabIndex = 0
        Me.accSett.Text = "Account"
        '
        'UsertypeBox
        '
        Me.UsertypeBox.BackColor = System.Drawing.Color.White
        Me.UsertypeBox.Cursor = System.Windows.Forms.Cursors.Hand
        Me.UsertypeBox.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen
        Me.UsertypeBox.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.UsertypeBox.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.UsertypeBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.UsertypeBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UsertypeBox.ForeColor = System.Drawing.Color.SeaGreen
        Me.UsertypeBox.Location = New System.Drawing.Point(187, 63)
        Me.UsertypeBox.Name = "UsertypeBox"
        Me.UsertypeBox.Size = New System.Drawing.Size(84, 30)
        Me.UsertypeBox.TabIndex = 10274
        Me.UsertypeBox.Text = "Type"
        Me.UsertypeBox.UseVisualStyleBackColor = False
        '
        'userTbl
        '
        Me.userTbl.AllowUserToAddRows = False
        Me.userTbl.AllowUserToDeleteRows = False
        Me.userTbl.AllowUserToResizeColumns = False
        Me.userTbl.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Honeydew
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.MediumSeaGreen
        Me.userTbl.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.userTbl.AutoGenerateColumns = False
        Me.userTbl.BackgroundColor = System.Drawing.Color.White
        Me.userTbl.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
        Me.userTbl.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.SeaGreen
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SeaGreen
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.userTbl.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.userTbl.ColumnHeadersHeight = 35
        Me.userTbl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.userTbl.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.accQ, Me.UsernameDataGridViewTextBoxColumn})
        Me.userTbl.Cursor = System.Windows.Forms.Cursors.Hand
        Me.userTbl.DataSource = Me.UserAccountBindingSource
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.MediumSeaGreen
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.userTbl.DefaultCellStyle = DataGridViewCellStyle3
        Me.userTbl.EnableHeadersVisualStyles = False
        Me.userTbl.Location = New System.Drawing.Point(642, 61)
        Me.userTbl.MultiSelect = False
        Me.userTbl.Name = "userTbl"
        Me.userTbl.ReadOnly = True
        Me.userTbl.RowHeadersVisible = False
        Me.userTbl.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.userTbl.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.userTbl.Size = New System.Drawing.Size(223, 426)
        Me.userTbl.TabIndex = 10273
        '
        'accQ
        '
        Me.accQ.DataPropertyName = "accQ"
        Me.accQ.HeaderText = "accQ"
        Me.accQ.Name = "accQ"
        Me.accQ.ReadOnly = True
        Me.accQ.Visible = False
        '
        'UsernameDataGridViewTextBoxColumn
        '
        Me.UsernameDataGridViewTextBoxColumn.DataPropertyName = "username"
        Me.UsernameDataGridViewTextBoxColumn.HeaderText = "Users List"
        Me.UsernameDataGridViewTextBoxColumn.Name = "UsernameDataGridViewTextBoxColumn"
        Me.UsernameDataGridViewTextBoxColumn.ReadOnly = True
        Me.UsernameDataGridViewTextBoxColumn.Width = 220
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
        Me.deleteBtn.Location = New System.Drawing.Point(423, 63)
        Me.deleteBtn.Name = "deleteBtn"
        Me.deleteBtn.Size = New System.Drawing.Size(70, 30)
        Me.deleteBtn.TabIndex = 10270
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
        Me.editBtn.Location = New System.Drawing.Point(350, 63)
        Me.editBtn.Name = "editBtn"
        Me.editBtn.Size = New System.Drawing.Size(70, 30)
        Me.editBtn.TabIndex = 10269
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
        Me.addBtn.Location = New System.Drawing.Point(277, 63)
        Me.addBtn.Name = "addBtn"
        Me.addBtn.Size = New System.Drawing.Size(70, 30)
        Me.addBtn.TabIndex = 10268
        Me.addBtn.Text = "Add"
        Me.addBtn.UseVisualStyleBackColor = False
        '
        'accountDetailsArea
        '
        Me.accountDetailsArea.Controls.Add(Me.show2)
        Me.accountDetailsArea.Controls.Add(Me.passBox2)
        Me.accountDetailsArea.Controls.Add(Me.rf2)
        Me.accountDetailsArea.Controls.Add(Me.rf3)
        Me.accountDetailsArea.Controls.Add(Me.rf1)
        Me.accountDetailsArea.Controls.Add(Me.completeNameBox)
        Me.accountDetailsArea.Controls.Add(Me.show1)
        Me.accountDetailsArea.Controls.Add(Me.Label7)
        Me.accountDetailsArea.Controls.Add(Me.notMatch1)
        Me.accountDetailsArea.Controls.Add(Me.acctypeBox)
        Me.accountDetailsArea.Controls.Add(Me.userBox)
        Me.accountDetailsArea.Controls.Add(Me.passBox)
        Me.accountDetailsArea.Controls.Add(qweLbl)
        Me.accountDetailsArea.Controls.Add(Label1)
        Me.accountDetailsArea.Controls.Add(Label2)
        Me.accountDetailsArea.Controls.Add(Label10)
        Me.accountDetailsArea.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.accountDetailsArea.ForeColor = System.Drawing.Color.SeaGreen
        Me.accountDetailsArea.Location = New System.Drawing.Point(19, 89)
        Me.accountDetailsArea.Name = "accountDetailsArea"
        Me.accountDetailsArea.Size = New System.Drawing.Size(614, 196)
        Me.accountDetailsArea.TabIndex = 10264
        Me.accountDetailsArea.TabStop = False
        Me.accountDetailsArea.Text = "Account Details"
        '
        'show2
        '
        Me.show2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.show2.FlatAppearance.BorderSize = 0
        Me.show2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SeaGreen
        Me.show2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.show2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.show2.ForeColor = System.Drawing.Color.SeaGreen
        Me.show2.Location = New System.Drawing.Point(419, 154)
        Me.show2.Name = "show2"
        Me.show2.Size = New System.Drawing.Size(53, 28)
        Me.show2.TabIndex = 10221
        Me.show2.Text = "Show"
        Me.show2.UseVisualStyleBackColor = True
        Me.show2.Visible = False
        '
        'passBox2
        '
        Me.passBox2.BorderColorFocused = System.Drawing.SystemColors.MenuHighlight
        Me.passBox2.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.passBox2.BorderColorMouseHover = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.passBox2.BorderThickness = 1
        Me.passBox2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.passBox2.Enabled = False
        Me.passBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.passBox2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.passBox2.isPassword = True
        Me.passBox2.Location = New System.Drawing.Point(170, 152)
        Me.passBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.passBox2.Name = "passBox2"
        Me.passBox2.Size = New System.Drawing.Size(303, 31)
        Me.passBox2.TabIndex = 3
        Me.passBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'rf2
        '
        Me.rf2.Image = Global.TOR.My.Resources.Resources.redDot
        Me.rf2.Location = New System.Drawing.Point(284, 87)
        Me.rf2.Name = "rf2"
        Me.rf2.Size = New System.Drawing.Size(9, 9)
        Me.rf2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.rf2.TabIndex = 10229
        Me.rf2.TabStop = False
        '
        'rf3
        '
        Me.rf3.Image = Global.TOR.My.Resources.Resources.redDot
        Me.rf3.Location = New System.Drawing.Point(478, 125)
        Me.rf3.Name = "rf3"
        Me.rf3.Size = New System.Drawing.Size(9, 9)
        Me.rf3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.rf3.TabIndex = 10229
        Me.rf3.TabStop = False
        '
        'rf1
        '
        Me.rf1.Image = Global.TOR.My.Resources.Resources.redDot
        Me.rf1.Location = New System.Drawing.Point(478, 47)
        Me.rf1.Name = "rf1"
        Me.rf1.Size = New System.Drawing.Size(9, 9)
        Me.rf1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.rf1.TabIndex = 10229
        Me.rf1.TabStop = False
        '
        'completeNameBox
        '
        Me.completeNameBox.BorderColorFocused = System.Drawing.SystemColors.MenuHighlight
        Me.completeNameBox.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.completeNameBox.BorderColorMouseHover = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.completeNameBox.BorderThickness = 1
        Me.completeNameBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.completeNameBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.completeNameBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.completeNameBox.isPassword = False
        Me.completeNameBox.Location = New System.Drawing.Point(171, 35)
        Me.completeNameBox.Margin = New System.Windows.Forms.Padding(4)
        Me.completeNameBox.Name = "completeNameBox"
        Me.completeNameBox.Size = New System.Drawing.Size(303, 31)
        Me.completeNameBox.TabIndex = 0
        Me.completeNameBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'show1
        '
        Me.show1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.show1.FlatAppearance.BorderSize = 0
        Me.show1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SeaGreen
        Me.show1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.show1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.show1.ForeColor = System.Drawing.Color.SeaGreen
        Me.show1.Location = New System.Drawing.Point(419, 115)
        Me.show1.Name = "show1"
        Me.show1.Size = New System.Drawing.Size(53, 28)
        Me.show1.TabIndex = 10221
        Me.show1.Text = "Show"
        Me.show1.UseVisualStyleBackColor = True
        Me.show1.Visible = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Red
        Me.Label7.Location = New System.Drawing.Point(477, 42)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(0, 16)
        Me.Label7.TabIndex = 10219
        Me.Label7.Visible = False
        '
        'notMatch1
        '
        Me.notMatch1.AutoSize = True
        Me.notMatch1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.notMatch1.ForeColor = System.Drawing.Color.Red
        Me.notMatch1.Location = New System.Drawing.Point(472, 160)
        Me.notMatch1.Name = "notMatch1"
        Me.notMatch1.Size = New System.Drawing.Size(141, 15)
        Me.notMatch1.TabIndex = 10219
        Me.notMatch1.Text = "Passwords do not match"
        Me.notMatch1.Visible = False
        '
        'acctypeBox
        '
        Me.acctypeBox.AutoSize = True
        Me.acctypeBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.acctypeBox.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.acctypeBox.Location = New System.Drawing.Point(300, 82)
        Me.acctypeBox.Name = "acctypeBox"
        Me.acctypeBox.Size = New System.Drawing.Size(40, 16)
        Me.acctypeBox.TabIndex = 10218
        Me.acctypeBox.Text = "Type"
        '
        'userBox
        '
        Me.userBox.BorderColorFocused = System.Drawing.SystemColors.MenuHighlight
        Me.userBox.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.userBox.BorderColorMouseHover = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.userBox.BorderThickness = 1
        Me.userBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.userBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.userBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.userBox.isPassword = False
        Me.userBox.Location = New System.Drawing.Point(171, 74)
        Me.userBox.Margin = New System.Windows.Forms.Padding(4)
        Me.userBox.Name = "userBox"
        Me.userBox.Size = New System.Drawing.Size(109, 31)
        Me.userBox.TabIndex = 1
        Me.userBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'passBox
        '
        Me.passBox.BorderColorFocused = System.Drawing.SystemColors.MenuHighlight
        Me.passBox.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.passBox.BorderColorMouseHover = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.passBox.BorderThickness = 1
        Me.passBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.passBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.passBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.passBox.isPassword = True
        Me.passBox.Location = New System.Drawing.Point(170, 113)
        Me.passBox.Margin = New System.Windows.Forms.Padding(4)
        Me.passBox.Name = "passBox"
        Me.passBox.Size = New System.Drawing.Size(303, 31)
        Me.passBox.TabIndex = 2
        Me.passBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'UserUsername
        '
        Me.UserUsername.Location = New System.Drawing.Point(727, 68)
        Me.UserUsername.Name = "UserUsername"
        Me.UserUsername.Size = New System.Drawing.Size(75, 23)
        Me.UserUsername.TabIndex = 10275
        Me.UserUsername.Text = "admin"
        Me.UserUsername.UseVisualStyleBackColor = True
        '
        'aboutSett
        '
        Me.aboutSett.BackColor = System.Drawing.Color.White
        Me.aboutSett.Controls.Add(Me.Label4)
        Me.aboutSett.Controls.Add(Me.PictureBox3)
        Me.aboutSett.Controls.Add(Me.Label8)
        Me.aboutSett.Controls.Add(Me.Label3)
        Me.aboutSett.Location = New System.Drawing.Point(4, 22)
        Me.aboutSett.Name = "aboutSett"
        Me.aboutSett.Padding = New System.Windows.Forms.Padding(3)
        Me.aboutSett.Size = New System.Drawing.Size(970, 626)
        Me.aboutSett.TabIndex = 2
        Me.aboutSett.Text = "About"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Old English Text MT", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(155, 83)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(553, 32)
        Me.Label4.TabIndex = 10296
        Me.Label4.Text = "Institute of Business, Science and Medical Arts"
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.TOR.My.Resources.Resources.ibsma_logo
        Me.PictureBox3.Location = New System.Drawing.Point(49, 48)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(109, 117)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 10295
        Me.PictureBox3.TabStop = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(180, 138)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(644, 304)
        Me.Label8.TabIndex = 10294
        Me.Label8.Text = resources.GetString("Label8.Text")
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(194, 165)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(0, 13)
        Me.Label3.TabIndex = 10294
        '
        'Panel4
        '
        Me.Panel4.Location = New System.Drawing.Point(1287, 45)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(49, 488)
        Me.Panel4.TabIndex = 10276
        '
        'Panel5
        '
        Me.Panel5.Location = New System.Drawing.Point(87, 45)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(293, 61)
        Me.Panel5.TabIndex = 10277
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.SeaGreen
        Me.Panel6.Controls.Add(Me.PictureBox2)
        Me.Panel6.Location = New System.Drawing.Point(0, 667)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(1348, 20)
        Me.Panel6.TabIndex = 10278
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
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "TORdb.mdb"
        '
        'UserAccountTableAdapter
        '
        Me.UserAccountTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.subjectsTableAdapter = Nothing
        Me.TableAdapterManager.totalPrintTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = TOR.TORdbDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.userAccountTableAdapter = Me.UserAccountTableAdapter
        '
        'DatabaseTableAdapter
        '
        Me.DatabaseTableAdapter.ClearBeforeFill = True
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Controls.Add(Me.Label11)
        Me.Panel2.Controls.Add(Me.icon1)
        Me.Panel2.Location = New System.Drawing.Point(257, 533)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1079, 142)
        Me.Panel2.TabIndex = 10258
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.GrayText
        Me.Label6.Location = New System.Drawing.Point(326, 80)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(161, 16)
        Me.Label6.TabIndex = 10296
        Me.Label6.Text = "All Rights Reserved 2020."
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.GrayText
        Me.Label5.Location = New System.Drawing.Point(66, 64)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(717, 16)
        Me.Label5.TabIndex = 10297
        Me.Label5.Text = "Developed by: Ronsell John A. Fortu together with Jomer M. Leonar, Angel Licka C." & _
            " Falquerabao and Albert M. Enriquez."
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.GrayText
        Me.Label9.Location = New System.Drawing.Point(363, 46)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(108, 16)
        Me.Label9.TabIndex = 10295
        Me.Label9.Text = "Version 1.0, 2020"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(349, 9)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(161, 37)
        Me.Label11.TabIndex = 10294
        Me.Label11.Text = "Transcript"
        '
        'icon1
        '
        Me.icon1.BackColor = System.Drawing.Color.Transparent
        Me.icon1.Image = Global.TOR.My.Resources.Resources.tor1
        Me.icon1.Location = New System.Drawing.Point(288, 2)
        Me.icon1.Name = "icon1"
        Me.icon1.Size = New System.Drawing.Size(58, 54)
        Me.icon1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.icon1.TabIndex = 10293
        Me.icon1.TabStop = False
        '
        'settings_form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1348, 687)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.paelMenu)
        Me.Controls.Add(Me.PasswordTextBox)
        Me.Controls.Add(Me.UsernameTextBox)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.SettingsTabControl)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(1364, 726)
        Me.MinimumSize = New System.Drawing.Size(1364, 726)
        Me.Name = "settings_form"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Settings"
        Me.paelMenu.ResumeLayout(False)
        Me.paelMenu.PerformLayout()
        Me.userPanel.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DatabaseBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TORdbDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.UserAccountBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SettingsTabControl.ResumeLayout(False)
        Me.backupSett.ResumeLayout(False)
        Me.backupSett.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.accSett.ResumeLayout(False)
        CType(Me.userTbl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.accountDetailsArea.ResumeLayout(False)
        Me.accountDetailsArea.PerformLayout()
        CType(Me.rf2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rf3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rf1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.aboutSett.ResumeLayout(False)
        Me.aboutSett.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel6.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.icon1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents paelMenu As System.Windows.Forms.Panel
    Friend WithEvents homeBtn As System.Windows.Forms.Button
    Friend WithEvents helpBtn As System.Windows.Forms.Button
    Friend WithEvents settingsBtn As System.Windows.Forms.Button
    Friend WithEvents backupBtn As System.Windows.Forms.Button
    Friend WithEvents subjectsBtn As System.Windows.Forms.Button
    Friend WithEvents studentsBtn As System.Windows.Forms.Button
    Friend WithEvents dashboardBtn As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents accSettBtn As System.Windows.Forms.Button
    Friend WithEvents backupSettBtn As System.Windows.Forms.Button
    Friend WithEvents aboutSettBtn As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents SettingsTabControl As System.Windows.Forms.TabControl
    Friend WithEvents accSett As System.Windows.Forms.TabPage
    Friend WithEvents backupSett As System.Windows.Forms.TabPage
    Friend WithEvents aboutSett As System.Windows.Forms.TabPage
    Friend WithEvents TORdbDataSet As TOR.TORdbDataSet
    Friend WithEvents UserAccountBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents UserAccountTableAdapter As TOR.TORdbDataSetTableAdapters.userAccountTableAdapter
    Friend WithEvents UsernameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PasswordTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PinCodeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents BAccountNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents BackupEmailTextBox As System.Windows.Forms.TextBox
    Friend WithEvents BackupPasswordTextBox As System.Windows.Forms.TextBox
    Friend WithEvents UserTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TableAdapterManager As TOR.TORdbDataSetTableAdapters.TableAdapterManager
    Friend WithEvents accountDetailsArea As System.Windows.Forms.GroupBox
    Friend WithEvents userBox As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents passBox As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents passBox2 As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents deleteBtn As System.Windows.Forms.Button
    Friend WithEvents editBtn As System.Windows.Forms.Button
    Friend WithEvents addBtn As System.Windows.Forms.Button
    Friend WithEvents userTbl As System.Windows.Forms.DataGridView
    Friend WithEvents completeNameBox As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents CompleteNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents UsertypeBox As System.Windows.Forms.Button
    Friend WithEvents acctypeBox As System.Windows.Forms.Label
    Friend WithEvents UserUsername As System.Windows.Forms.Button
    Friend WithEvents notMatch1 As System.Windows.Forms.Label
    Friend WithEvents show1 As System.Windows.Forms.Button
    Friend WithEvents show2 As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents rf1 As System.Windows.Forms.PictureBox
    Friend WithEvents rf2 As System.Windows.Forms.PictureBox
    Friend WithEvents rf3 As System.Windows.Forms.PictureBox
    Friend WithEvents userPanel As System.Windows.Forms.Panel
    Friend WithEvents user As System.Windows.Forms.Button
    Friend WithEvents logout As System.Windows.Forms.Button
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents accQ As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UsernameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents backupPath_textbox As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents change_button As System.Windows.Forms.Button
    Friend WithEvents DatabaseBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DatabaseTableAdapter As TOR.TORdbDataSetTableAdapters.databaseTableAdapter
    Friend WithEvents BackupPathTextBox As System.Windows.Forms.TextBox
    Friend WithEvents undoChange_button As System.Windows.Forms.Button
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents restoreData_button As System.Windows.Forms.Button
    Friend WithEvents backupNow_button As System.Windows.Forms.Button
    Friend WithEvents restorePath_textbox As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents browse_button As System.Windows.Forms.Button
    Friend WithEvents FolderBrowserDialog2 As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents undoChange1_btton As System.Windows.Forms.Button
    Friend WithEvents clearSearch1_btn As System.Windows.Forms.Button
    Friend WithEvents clearSearch2_btn As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents formStatus_label As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents BackupPathLabel2 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents icon1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
End Class
