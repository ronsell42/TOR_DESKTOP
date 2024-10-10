<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class home_form
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(home_form))
        Me.tutorials_desc = New System.Windows.Forms.Label()
        Me.students_desc = New System.Windows.Forms.Label()
        Me.settings_desc = New System.Windows.Forms.Label()
        Me.subjects_desc = New System.Windows.Forms.Label()
        Me.dashboard_desc = New System.Windows.Forms.Label()
        Me.tutorials_label = New System.Windows.Forms.Label()
        Me.students_lbl = New System.Windows.Forms.Label()
        Me.settings_lbl = New System.Windows.Forms.Label()
        Me.subjects_lbl = New System.Windows.Forms.Label()
        Me.dashboard_lbl = New System.Windows.Forms.Label()
        Me.tutorials_button = New System.Windows.Forms.Button()
        Me.studentsBtn = New System.Windows.Forms.Button()
        Me.settingsBtn = New System.Windows.Forms.Button()
        Me.subjectsBtn = New System.Windows.Forms.Button()
        Me.dashboardBtn = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.user = New System.Windows.Forms.Button()
        Me.logout = New System.Windows.Forms.Button()
        Me.tutorials_icon = New System.Windows.Forms.PictureBox()
        Me.students_icon = New System.Windows.Forms.PictureBox()
        Me.settings_icon = New System.Windows.Forms.PictureBox()
        Me.subjects_icon = New System.Windows.Forms.PictureBox()
        Me.dasboard_icon = New System.Windows.Forms.PictureBox()
        Me.userPanel = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.icon1 = New System.Windows.Forms.PictureBox()
        Me.settingsSecret_button = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        CType(Me.tutorials_icon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.students_icon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.settings_icon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.subjects_icon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dasboard_icon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.userPanel.SuspendLayout()
        CType(Me.icon1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'tutorials_desc
        '
        Me.tutorials_desc.AutoSize = True
        Me.tutorials_desc.Cursor = System.Windows.Forms.Cursors.Hand
        Me.tutorials_desc.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tutorials_desc.ForeColor = System.Drawing.Color.Gray
        Me.tutorials_desc.Location = New System.Drawing.Point(993, 364)
        Me.tutorials_desc.Name = "tutorials_desc"
        Me.tutorials_desc.Size = New System.Drawing.Size(109, 16)
        Me.tutorials_desc.TabIndex = 17
        Me.tutorials_desc.Text = "Learn the system"
        Me.tutorials_desc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'students_desc
        '
        Me.students_desc.AutoSize = True
        Me.students_desc.Cursor = System.Windows.Forms.Cursors.Hand
        Me.students_desc.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.students_desc.ForeColor = System.Drawing.Color.Gray
        Me.students_desc.Location = New System.Drawing.Point(431, 364)
        Me.students_desc.Name = "students_desc"
        Me.students_desc.Size = New System.Drawing.Size(122, 32)
        Me.students_desc.TabIndex = 23
        Me.students_desc.Text = "Information, grades" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "and print TOR"
        Me.students_desc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'settings_desc
        '
        Me.settings_desc.AutoSize = True
        Me.settings_desc.Cursor = System.Windows.Forms.Cursors.Hand
        Me.settings_desc.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.settings_desc.ForeColor = System.Drawing.Color.Gray
        Me.settings_desc.Location = New System.Drawing.Point(787, 364)
        Me.settings_desc.Name = "settings_desc"
        Me.settings_desc.Size = New System.Drawing.Size(145, 32)
        Me.settings_desc.TabIndex = 18
        Me.settings_desc.Text = "User management and" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "database control"
        Me.settings_desc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'subjects_desc
        '
        Me.subjects_desc.AutoSize = True
        Me.subjects_desc.Cursor = System.Windows.Forms.Cursors.Hand
        Me.subjects_desc.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.subjects_desc.ForeColor = System.Drawing.Color.Gray
        Me.subjects_desc.Location = New System.Drawing.Point(615, 364)
        Me.subjects_desc.Name = "subjects_desc"
        Me.subjects_desc.Size = New System.Drawing.Size(111, 32)
        Me.subjects_desc.TabIndex = 19
        Me.subjects_desc.Text = "Modify and" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "manage subjects"
        Me.subjects_desc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dashboard_desc
        '
        Me.dashboard_desc.AutoSize = True
        Me.dashboard_desc.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dashboard_desc.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dashboard_desc.ForeColor = System.Drawing.Color.Gray
        Me.dashboard_desc.Location = New System.Drawing.Point(275, 364)
        Me.dashboard_desc.Name = "dashboard_desc"
        Me.dashboard_desc.Size = New System.Drawing.Size(76, 32)
        Me.dashboard_desc.TabIndex = 20
        Me.dashboard_desc.Text = "Basic stats" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "and graphs"
        Me.dashboard_desc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tutorials_label
        '
        Me.tutorials_label.AutoSize = True
        Me.tutorials_label.Cursor = System.Windows.Forms.Cursors.Hand
        Me.tutorials_label.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tutorials_label.Location = New System.Drawing.Point(1013, 344)
        Me.tutorials_label.Name = "tutorials_label"
        Me.tutorials_label.Size = New System.Drawing.Size(65, 20)
        Me.tutorials_label.TabIndex = 24
        Me.tutorials_label.Text = "Tutorials"
        Me.tutorials_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'students_lbl
        '
        Me.students_lbl.AutoSize = True
        Me.students_lbl.Cursor = System.Windows.Forms.Cursors.Hand
        Me.students_lbl.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.students_lbl.Location = New System.Drawing.Point(460, 344)
        Me.students_lbl.Name = "students_lbl"
        Me.students_lbl.Size = New System.Drawing.Size(66, 20)
        Me.students_lbl.TabIndex = 30
        Me.students_lbl.Text = "Students"
        Me.students_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'settings_lbl
        '
        Me.settings_lbl.AutoSize = True
        Me.settings_lbl.Cursor = System.Windows.Forms.Cursors.Hand
        Me.settings_lbl.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.settings_lbl.Location = New System.Drawing.Point(828, 344)
        Me.settings_lbl.Name = "settings_lbl"
        Me.settings_lbl.Size = New System.Drawing.Size(62, 20)
        Me.settings_lbl.TabIndex = 25
        Me.settings_lbl.Text = "Settings"
        Me.settings_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'subjects_lbl
        '
        Me.subjects_lbl.AutoSize = True
        Me.subjects_lbl.Cursor = System.Windows.Forms.Cursors.Hand
        Me.subjects_lbl.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.subjects_lbl.Location = New System.Drawing.Point(641, 344)
        Me.subjects_lbl.Name = "subjects_lbl"
        Me.subjects_lbl.Size = New System.Drawing.Size(65, 20)
        Me.subjects_lbl.TabIndex = 26
        Me.subjects_lbl.Text = "Subjects"
        Me.subjects_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dashboard_lbl
        '
        Me.dashboard_lbl.AutoSize = True
        Me.dashboard_lbl.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dashboard_lbl.Font = New System.Drawing.Font("Trebuchet MS", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dashboard_lbl.Location = New System.Drawing.Point(271, 344)
        Me.dashboard_lbl.Name = "dashboard_lbl"
        Me.dashboard_lbl.Size = New System.Drawing.Size(78, 20)
        Me.dashboard_lbl.TabIndex = 27
        Me.dashboard_lbl.Text = "Dashboard"
        Me.dashboard_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tutorials_button
        '
        Me.tutorials_button.Cursor = System.Windows.Forms.Cursors.Hand
        Me.tutorials_button.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.tutorials_button.FlatAppearance.BorderSize = 2
        Me.tutorials_button.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.Control
        Me.tutorials_button.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control
        Me.tutorials_button.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control
        Me.tutorials_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.tutorials_button.Location = New System.Drawing.Point(956, 241)
        Me.tutorials_button.Name = "tutorials_button"
        Me.tutorials_button.Size = New System.Drawing.Size(180, 180)
        Me.tutorials_button.TabIndex = 6
        Me.tutorials_button.UseVisualStyleBackColor = True
        '
        'studentsBtn
        '
        Me.studentsBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.studentsBtn.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.studentsBtn.FlatAppearance.BorderSize = 2
        Me.studentsBtn.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.Control
        Me.studentsBtn.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control
        Me.studentsBtn.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control
        Me.studentsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.studentsBtn.Location = New System.Drawing.Point(401, 241)
        Me.studentsBtn.Name = "studentsBtn"
        Me.studentsBtn.Size = New System.Drawing.Size(180, 180)
        Me.studentsBtn.TabIndex = 3
        Me.studentsBtn.UseVisualStyleBackColor = True
        '
        'settingsBtn
        '
        Me.settingsBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.settingsBtn.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.settingsBtn.FlatAppearance.BorderSize = 2
        Me.settingsBtn.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.Control
        Me.settingsBtn.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control
        Me.settingsBtn.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control
        Me.settingsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.settingsBtn.Location = New System.Drawing.Point(770, 241)
        Me.settingsBtn.Name = "settingsBtn"
        Me.settingsBtn.Size = New System.Drawing.Size(180, 180)
        Me.settingsBtn.TabIndex = 4
        Me.settingsBtn.UseVisualStyleBackColor = True
        '
        'subjectsBtn
        '
        Me.subjectsBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.subjectsBtn.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.subjectsBtn.FlatAppearance.BorderSize = 2
        Me.subjectsBtn.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.Control
        Me.subjectsBtn.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control
        Me.subjectsBtn.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control
        Me.subjectsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.subjectsBtn.Location = New System.Drawing.Point(581, 241)
        Me.subjectsBtn.Name = "subjectsBtn"
        Me.subjectsBtn.Size = New System.Drawing.Size(180, 180)
        Me.subjectsBtn.TabIndex = 9
        Me.subjectsBtn.UseVisualStyleBackColor = True
        '
        'dashboardBtn
        '
        Me.dashboardBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dashboardBtn.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.dashboardBtn.FlatAppearance.BorderSize = 2
        Me.dashboardBtn.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.Control
        Me.dashboardBtn.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control
        Me.dashboardBtn.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control
        Me.dashboardBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.dashboardBtn.Location = New System.Drawing.Point(221, 241)
        Me.dashboardBtn.Name = "dashboardBtn"
        Me.dashboardBtn.Size = New System.Drawing.Size(180, 180)
        Me.dashboardBtn.TabIndex = 8
        Me.dashboardBtn.UseVisualStyleBackColor = True
        '
        'ToolTip1
        '
        Me.ToolTip1.AutomaticDelay = 250
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
        Me.ToolTip1.SetToolTip(Me.user, "User")
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
        Me.ToolTip1.SetToolTip(Me.logout, "Logout")
        Me.logout.UseVisualStyleBackColor = False
        '
        'tutorials_icon
        '
        Me.tutorials_icon.Cursor = System.Windows.Forms.Cursors.Hand
        Me.tutorials_icon.Enabled = False
        Me.tutorials_icon.Image = Global.TOR.My.Resources.Resources.help_icon_home
        Me.tutorials_icon.Location = New System.Drawing.Point(1017, 282)
        Me.tutorials_icon.Name = "tutorials_icon"
        Me.tutorials_icon.Size = New System.Drawing.Size(55, 55)
        Me.tutorials_icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.tutorials_icon.TabIndex = 15
        Me.tutorials_icon.TabStop = False
        '
        'students_icon
        '
        Me.students_icon.Cursor = System.Windows.Forms.Cursors.Hand
        Me.students_icon.Enabled = False
        Me.students_icon.Image = Global.TOR.My.Resources.Resources.students_icon_home
        Me.students_icon.Location = New System.Drawing.Point(468, 282)
        Me.students_icon.Name = "students_icon"
        Me.students_icon.Size = New System.Drawing.Size(50, 50)
        Me.students_icon.TabIndex = 10
        Me.students_icon.TabStop = False
        '
        'settings_icon
        '
        Me.settings_icon.Cursor = System.Windows.Forms.Cursors.Hand
        Me.settings_icon.Enabled = False
        Me.settings_icon.Image = Global.TOR.My.Resources.Resources.settings_icon_home
        Me.settings_icon.Location = New System.Drawing.Point(832, 282)
        Me.settings_icon.Name = "settings_icon"
        Me.settings_icon.Size = New System.Drawing.Size(50, 50)
        Me.settings_icon.TabIndex = 13
        Me.settings_icon.TabStop = False
        '
        'subjects_icon
        '
        Me.subjects_icon.Cursor = System.Windows.Forms.Cursors.Hand
        Me.subjects_icon.Enabled = False
        Me.subjects_icon.Image = Global.TOR.My.Resources.Resources.subjects_icon_home
        Me.subjects_icon.Location = New System.Drawing.Point(648, 282)
        Me.subjects_icon.Name = "subjects_icon"
        Me.subjects_icon.Size = New System.Drawing.Size(50, 50)
        Me.subjects_icon.TabIndex = 14
        Me.subjects_icon.TabStop = False
        '
        'dasboard_icon
        '
        Me.dasboard_icon.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dasboard_icon.Enabled = False
        Me.dasboard_icon.Image = Global.TOR.My.Resources.Resources.dashboard_icon_home
        Me.dasboard_icon.Location = New System.Drawing.Point(288, 282)
        Me.dasboard_icon.Name = "dasboard_icon"
        Me.dasboard_icon.Size = New System.Drawing.Size(50, 50)
        Me.dasboard_icon.TabIndex = 16
        Me.dasboard_icon.TabStop = False
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
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(381, 13)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(161, 37)
        Me.Label5.TabIndex = 10286
        Me.Label5.Text = "Transcript"
        '
        'icon1
        '
        Me.icon1.BackColor = System.Drawing.Color.Transparent
        Me.icon1.Image = Global.TOR.My.Resources.Resources.tor1
        Me.icon1.Location = New System.Drawing.Point(320, 6)
        Me.icon1.Name = "icon1"
        Me.icon1.Size = New System.Drawing.Size(58, 54)
        Me.icon1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.icon1.TabIndex = 10285
        Me.icon1.TabStop = False
        '
        'settingsSecret_button
        '
        Me.settingsSecret_button.Enabled = False
        Me.settingsSecret_button.Location = New System.Drawing.Point(801, 298)
        Me.settingsSecret_button.Name = "settingsSecret_button"
        Me.settingsSecret_button.Size = New System.Drawing.Size(120, 23)
        Me.settingsSecret_button.TabIndex = 10287
        Me.settingsSecret_button.Text = "go_to_settings"
        Me.settingsSecret_button.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.GrayText
        Me.Label1.Location = New System.Drawing.Point(395, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(108, 16)
        Me.Label1.TabIndex = 10288
        Me.Label1.Text = "Version 1.0, 2020"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.TOR.My.Resources.Resources.ibsma_logo
        Me.PictureBox1.Location = New System.Drawing.Point(285, 60)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(109, 117)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 10289
        Me.PictureBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Old English Text MT", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(407, 95)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(553, 32)
        Me.Label2.TabIndex = 10290
        Me.Label2.Text = "Institute of Business, Science and Medical Arts"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Trebuchet MS", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.Label3.Location = New System.Drawing.Point(453, 134)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(428, 27)
        Me.Label3.TabIndex = 10291
        Me.Label3.Text = "Welcome! Please choose a menu to continue."
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.GrayText
        Me.Label4.Location = New System.Drawing.Point(98, 68)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(717, 16)
        Me.Label4.TabIndex = 10292
        Me.Label4.Text = "Developed by: Ronsell John A. Fortu together with Jomer M. Leonar, Angel Licka C." &
    " Falquerabao and Albert M. Enriquez."
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.GrayText
        Me.Label6.Location = New System.Drawing.Point(358, 84)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(161, 16)
        Me.Label6.TabIndex = 10292
        Me.Label6.Text = "All Rights Reserved 2020."
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.icon1)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(223, 531)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(913, 111)
        Me.Panel1.TabIndex = 10293
        '
        'home_form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(1348, 687)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.userPanel)
        Me.Controls.Add(Me.tutorials_desc)
        Me.Controls.Add(Me.students_desc)
        Me.Controls.Add(Me.settings_desc)
        Me.Controls.Add(Me.subjects_desc)
        Me.Controls.Add(Me.dashboard_desc)
        Me.Controls.Add(Me.tutorials_label)
        Me.Controls.Add(Me.students_lbl)
        Me.Controls.Add(Me.settings_lbl)
        Me.Controls.Add(Me.subjects_lbl)
        Me.Controls.Add(Me.dashboard_lbl)
        Me.Controls.Add(Me.tutorials_icon)
        Me.Controls.Add(Me.tutorials_button)
        Me.Controls.Add(Me.students_icon)
        Me.Controls.Add(Me.studentsBtn)
        Me.Controls.Add(Me.settings_icon)
        Me.Controls.Add(Me.settingsBtn)
        Me.Controls.Add(Me.subjects_icon)
        Me.Controls.Add(Me.subjectsBtn)
        Me.Controls.Add(Me.dasboard_icon)
        Me.Controls.Add(Me.dashboardBtn)
        Me.Controls.Add(Me.settingsSecret_button)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(1364, 726)
        Me.MinimumSize = New System.Drawing.Size(1364, 726)
        Me.Name = "home_form"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Home"
        CType(Me.tutorials_icon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.students_icon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.settings_icon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.subjects_icon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dasboard_icon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.userPanel.ResumeLayout(False)
        CType(Me.icon1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tutorials_desc As System.Windows.Forms.Label
    Friend WithEvents students_desc As System.Windows.Forms.Label
    Friend WithEvents settings_desc As System.Windows.Forms.Label
    Friend WithEvents subjects_desc As System.Windows.Forms.Label
    Friend WithEvents dashboard_desc As System.Windows.Forms.Label
    Friend WithEvents tutorials_label As System.Windows.Forms.Label
    Friend WithEvents students_lbl As System.Windows.Forms.Label
    Friend WithEvents settings_lbl As System.Windows.Forms.Label
    Friend WithEvents subjects_lbl As System.Windows.Forms.Label
    Friend WithEvents dashboard_lbl As System.Windows.Forms.Label
    Friend WithEvents tutorials_icon As System.Windows.Forms.PictureBox
    Friend WithEvents tutorials_button As System.Windows.Forms.Button
    Friend WithEvents students_icon As System.Windows.Forms.PictureBox
    Friend WithEvents studentsBtn As System.Windows.Forms.Button
    Friend WithEvents settings_icon As System.Windows.Forms.PictureBox
    Friend WithEvents settingsBtn As System.Windows.Forms.Button
    Friend WithEvents subjects_icon As System.Windows.Forms.PictureBox
    Friend WithEvents subjectsBtn As System.Windows.Forms.Button
    Friend WithEvents dasboard_icon As System.Windows.Forms.PictureBox
    Friend WithEvents dashboardBtn As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents userPanel As System.Windows.Forms.Panel
    Friend WithEvents user As System.Windows.Forms.Button
    Friend WithEvents logout As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents icon1 As System.Windows.Forms.PictureBox
    Friend WithEvents settingsSecret_button As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
End Class
