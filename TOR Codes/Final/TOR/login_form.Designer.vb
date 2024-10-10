<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class login_form
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
        Dim BackupEmailLabel As System.Windows.Forms.Label
        Dim BackupPasswordLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(login_form))
        Me.PasswordTextBox = New System.Windows.Forms.TextBox()
        Me.UserAccountBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TORdbDataSet = New TOR.TORdbDataSet()
        Me.UserAccountTableAdapter = New TOR.TORdbDataSetTableAdapters.userAccountTableAdapter()
        Me.TableAdapterManager = New TOR.TORdbDataSetTableAdapters.TableAdapterManager()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.passLbl = New System.Windows.Forms.Label()
        Me.password1 = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.userLbl = New System.Windows.Forms.Label()
        Me.user1 = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.loginBtn = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.show1 = New System.Windows.Forms.Button()
        Me.UsernameTextBox = New System.Windows.Forms.TextBox()
        Me.BackupPasswordTextBox = New System.Windows.Forms.TextBox()
        Me.BackupEmailTextBox = New System.Windows.Forms.TextBox()
        Me.forgotpassBtn = New System.Windows.Forms.Button()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.version_label = New System.Windows.Forms.Label()
        Me.cancelBtn = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.icon1 = New System.Windows.Forms.PictureBox()
        Me.icon2 = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        UsernameLabel = New System.Windows.Forms.Label()
        BackupEmailLabel = New System.Windows.Forms.Label()
        BackupPasswordLabel = New System.Windows.Forms.Label()
        CType(Me.UserAccountBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TORdbDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.icon1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.icon2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UsernameLabel
        '
        UsernameLabel.AutoSize = True
        UsernameLabel.Enabled = False
        UsernameLabel.Location = New System.Drawing.Point(188, 140)
        UsernameLabel.Name = "UsernameLabel"
        UsernameLabel.Size = New System.Drawing.Size(56, 13)
        UsernameLabel.TabIndex = 10114
        UsernameLabel.Text = "username:"
        '
        'BackupEmailLabel
        '
        BackupEmailLabel.AutoSize = True
        BackupEmailLabel.Location = New System.Drawing.Point(188, 248)
        BackupEmailLabel.Name = "BackupEmailLabel"
        BackupEmailLabel.Size = New System.Drawing.Size(74, 13)
        BackupEmailLabel.TabIndex = 10114
        BackupEmailLabel.Text = "backup Email:"
        '
        'BackupPasswordLabel
        '
        BackupPasswordLabel.AutoSize = True
        BackupPasswordLabel.Location = New System.Drawing.Point(90, 248)
        BackupPasswordLabel.Name = "BackupPasswordLabel"
        BackupPasswordLabel.Size = New System.Drawing.Size(95, 13)
        BackupPasswordLabel.TabIndex = 10115
        BackupPasswordLabel.Text = "backup Password:"
        '
        'PasswordTextBox
        '
        Me.PasswordTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UserAccountBindingSource, "password", True))
        Me.PasswordTextBox.Enabled = False
        Me.PasswordTextBox.Location = New System.Drawing.Point(250, 191)
        Me.PasswordTextBox.Name = "PasswordTextBox"
        Me.PasswordTextBox.Size = New System.Drawing.Size(100, 20)
        Me.PasswordTextBox.TabIndex = 17
        '
        'UserAccountBindingSource
        '
        Me.UserAccountBindingSource.DataMember = "userAccount"
        Me.UserAccountBindingSource.DataSource = Me.TORdbDataSet
        '
        'TORdbDataSet
        '
        Me.TORdbDataSet.DataSetName = "TORdbDataSet"
        Me.TORdbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(570, 39)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(161, 37)
        Me.Label5.TabIndex = 10109
        Me.Label5.Text = "Transcript"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label4.Location = New System.Drawing.Point(72, 60)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(117, 20)
        Me.Label4.TabIndex = 10112
        Me.Label4.Text = "all in one place."
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label3.Location = New System.Drawing.Point(72, 34)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(269, 20)
        Me.Label3.TabIndex = 10111
        Me.Label3.Text = "Record saving, retrieving and printing"
        '
        'passLbl
        '
        Me.passLbl.AutoSize = True
        Me.passLbl.BackColor = System.Drawing.Color.White
        Me.passLbl.Enabled = False
        Me.passLbl.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.passLbl.Location = New System.Drawing.Point(88, 192)
        Me.passLbl.Name = "passLbl"
        Me.passLbl.Size = New System.Drawing.Size(69, 17)
        Me.passLbl.TabIndex = 10106
        Me.passLbl.Text = "Password"
        '
        'password1
        '
        Me.password1.BackColor = System.Drawing.Color.White
        Me.password1.BorderColorFocused = System.Drawing.SystemColors.MenuHighlight
        Me.password1.BorderColorIdle = System.Drawing.Color.DarkGray
        Me.password1.BorderColorMouseHover = System.Drawing.Color.DarkGray
        Me.password1.BorderThickness = 1
        Me.password1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.password1.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.password1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.password1.isPassword = True
        Me.password1.Location = New System.Drawing.Point(79, 180)
        Me.password1.Margin = New System.Windows.Forms.Padding(4)
        Me.password1.Name = "password1"
        Me.password1.Size = New System.Drawing.Size(290, 38)
        Me.password1.TabIndex = 1
        Me.password1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'userLbl
        '
        Me.userLbl.AutoSize = True
        Me.userLbl.BackColor = System.Drawing.Color.White
        Me.userLbl.Enabled = False
        Me.userLbl.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.userLbl.ForeColor = System.Drawing.Color.Black
        Me.userLbl.Location = New System.Drawing.Point(88, 137)
        Me.userLbl.Name = "userLbl"
        Me.userLbl.Size = New System.Drawing.Size(71, 17)
        Me.userLbl.TabIndex = 10107
        Me.userLbl.Text = "Username"
        '
        'user1
        '
        Me.user1.BackColor = System.Drawing.Color.White
        Me.user1.BorderColorFocused = System.Drawing.SystemColors.MenuHighlight
        Me.user1.BorderColorIdle = System.Drawing.Color.DarkGray
        Me.user1.BorderColorMouseHover = System.Drawing.SystemColors.MenuHighlight
        Me.user1.BorderThickness = 1
        Me.user1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.user1.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.user1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.user1.isPassword = False
        Me.user1.Location = New System.Drawing.Point(79, 125)
        Me.user1.Margin = New System.Windows.Forms.Padding(4)
        Me.user1.Name = "user1"
        Me.user1.Size = New System.Drawing.Size(290, 38)
        Me.user1.TabIndex = 0
        Me.user1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Panel2.Controls.Add(Me.loginBtn)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.show1)
        Me.Panel2.Controls.Add(Me.userLbl)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.passLbl)
        Me.Panel2.Controls.Add(Me.user1)
        Me.Panel2.Controls.Add(Me.password1)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(UsernameLabel)
        Me.Panel2.Controls.Add(Me.UsernameTextBox)
        Me.Panel2.Controls.Add(Me.PasswordTextBox)
        Me.Panel2.Controls.Add(BackupPasswordLabel)
        Me.Panel2.Controls.Add(Me.BackupPasswordTextBox)
        Me.Panel2.Controls.Add(BackupEmailLabel)
        Me.Panel2.Controls.Add(Me.BackupEmailTextBox)
        Me.Panel2.Controls.Add(Me.forgotpassBtn)
        Me.Panel2.Location = New System.Drawing.Point(425, 183)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(445, 335)
        Me.Panel2.TabIndex = 10114
        '
        'loginBtn
        '
        Me.loginBtn.BackColor = System.Drawing.Color.SeaGreen
        Me.loginBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.loginBtn.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.loginBtn.FlatAppearance.BorderSize = 0
        Me.loginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.loginBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.loginBtn.ForeColor = System.Drawing.Color.White
        Me.loginBtn.Location = New System.Drawing.Point(79, 235)
        Me.loginBtn.Name = "loginBtn"
        Me.loginBtn.Size = New System.Drawing.Size(290, 37)
        Me.loginBtn.TabIndex = 2
        Me.loginBtn.Text = "Login"
        Me.loginBtn.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(95, 291)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(251, 13)
        Me.Label7.TabIndex = 10230
        Me.Label7.Text = "ronsell42@gmail.com, 09121746578, 09776655052"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.GrayText
        Me.Label8.Location = New System.Drawing.Point(75, 93)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(100, 20)
        Me.Label8.TabIndex = 10110
        Me.Label8.Text = "Please Login"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(100, 275)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(241, 13)
        Me.Label6.TabIndex = 10230
        Me.Label6.Text = "In case of forgetting password, contact developer"
        '
        'show1
        '
        Me.show1.BackColor = System.Drawing.Color.White
        Me.show1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.show1.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen
        Me.show1.FlatAppearance.BorderSize = 0
        Me.show1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SeaGreen
        Me.show1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.show1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.show1.ForeColor = System.Drawing.Color.SeaGreen
        Me.show1.Location = New System.Drawing.Point(315, 182)
        Me.show1.Name = "show1"
        Me.show1.Size = New System.Drawing.Size(53, 35)
        Me.show1.TabIndex = 10222
        Me.show1.Text = "Show"
        Me.show1.UseVisualStyleBackColor = False
        Me.show1.Visible = False
        '
        'UsernameTextBox
        '
        Me.UsernameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UserAccountBindingSource, "username", True))
        Me.UsernameTextBox.Enabled = False
        Me.UsernameTextBox.Location = New System.Drawing.Point(250, 137)
        Me.UsernameTextBox.Name = "UsernameTextBox"
        Me.UsernameTextBox.Size = New System.Drawing.Size(100, 20)
        Me.UsernameTextBox.TabIndex = 10115
        '
        'BackupPasswordTextBox
        '
        Me.BackupPasswordTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UserAccountBindingSource, "backupPassword", True))
        Me.BackupPasswordTextBox.Enabled = False
        Me.BackupPasswordTextBox.Location = New System.Drawing.Point(191, 245)
        Me.BackupPasswordTextBox.Name = "BackupPasswordTextBox"
        Me.BackupPasswordTextBox.Size = New System.Drawing.Size(100, 20)
        Me.BackupPasswordTextBox.TabIndex = 10116
        '
        'BackupEmailTextBox
        '
        Me.BackupEmailTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UserAccountBindingSource, "backupEmail", True))
        Me.BackupEmailTextBox.Enabled = False
        Me.BackupEmailTextBox.Location = New System.Drawing.Point(268, 245)
        Me.BackupEmailTextBox.Name = "BackupEmailTextBox"
        Me.BackupEmailTextBox.Size = New System.Drawing.Size(100, 20)
        Me.BackupEmailTextBox.TabIndex = 10115
        '
        'forgotpassBtn
        '
        Me.forgotpassBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.forgotpassBtn.Enabled = False
        Me.forgotpassBtn.FlatAppearance.BorderSize = 0
        Me.forgotpassBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.forgotpassBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.forgotpassBtn.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.forgotpassBtn.Location = New System.Drawing.Point(107, 240)
        Me.forgotpassBtn.Name = "forgotpassBtn"
        Me.forgotpassBtn.Size = New System.Drawing.Size(165, 25)
        Me.forgotpassBtn.TabIndex = 10116
        Me.forgotpassBtn.Text = "Backup login"
        Me.forgotpassBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.forgotpassBtn.UseVisualStyleBackColor = True
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(503, 559)
        Me.ProgressBar1.Maximum = 31
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(286, 10)
        Me.ProgressBar1.TabIndex = 10225
        Me.ProgressBar1.Value = 1
        Me.ProgressBar1.Visible = False
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(501, 530)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.TextBox1.Size = New System.Drawing.Size(289, 24)
        Me.TextBox1.TabIndex = 10227
        Me.TextBox1.Visible = False
        '
        'version_label
        '
        Me.version_label.AutoSize = True
        Me.version_label.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.version_label.ForeColor = System.Drawing.SystemColors.GrayText
        Me.version_label.Location = New System.Drawing.Point(587, 76)
        Me.version_label.Name = "version_label"
        Me.version_label.Size = New System.Drawing.Size(108, 16)
        Me.version_label.TabIndex = 10229
        Me.version_label.Text = "Version 1.0, 2020"
        '
        'cancelBtn
        '
        Me.cancelBtn.Location = New System.Drawing.Point(603, 592)
        Me.cancelBtn.Name = "cancelBtn"
        Me.cancelBtn.Size = New System.Drawing.Size(75, 23)
        Me.cancelBtn.TabIndex = 10228
        Me.cancelBtn.Text = "Cancel"
        Me.cancelBtn.UseVisualStyleBackColor = True
        Me.cancelBtn.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(508, 575)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(280, 13)
        Me.Label2.TabIndex = 10226
        Me.Label2.Text = "Resetting admin account. This will take up to 30 seconds."
        Me.Label2.Visible = False
        '
        'icon1
        '
        Me.icon1.Image = Global.TOR.My.Resources.Resources.tor1
        Me.icon1.Location = New System.Drawing.Point(509, 32)
        Me.icon1.Name = "icon1"
        Me.icon1.Size = New System.Drawing.Size(58, 54)
        Me.icon1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.icon1.TabIndex = 10108
        Me.icon1.TabStop = False
        '
        'icon2
        '
        Me.icon2.Image = Global.TOR.My.Resources.Resources.tor_1
        Me.icon2.Location = New System.Drawing.Point(509, 32)
        Me.icon2.Name = "icon2"
        Me.icon2.Size = New System.Drawing.Size(58, 54)
        Me.icon2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.icon2.TabIndex = 10108
        Me.icon2.TabStop = False
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Gainsboro
        Me.Panel1.Location = New System.Drawing.Point(164, 121)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(975, 2)
        Me.Panel1.TabIndex = 10291
        '
        'login_form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(1351, 733)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.icon1)
        Me.Controls.Add(Me.icon2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cancelBtn)
        Me.Controls.Add(Me.version_label)
        Me.Controls.Add(Me.Label2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(1367, 772)
        Me.MinimumSize = New System.Drawing.Size(1364, 726)
        Me.Name = "login_form"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        CType(Me.UserAccountBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TORdbDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.icon1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.icon2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TORdbDataSet As TOR.TORdbDataSet
    Friend WithEvents UserAccountBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents UserAccountTableAdapter As TOR.TORdbDataSetTableAdapters.userAccountTableAdapter
    Friend WithEvents TableAdapterManager As TOR.TORdbDataSetTableAdapters.TableAdapterManager
    Friend WithEvents PasswordTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents icon2 As System.Windows.Forms.PictureBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents passLbl As System.Windows.Forms.Label
    Friend WithEvents password1 As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents userLbl As System.Windows.Forms.Label
    Friend WithEvents user1 As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents loginBtn As System.Windows.Forms.Button
    Friend WithEvents UsernameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents forgotpassBtn As System.Windows.Forms.Button
    Friend WithEvents show1 As System.Windows.Forms.Button
    Friend WithEvents icon1 As System.Windows.Forms.PictureBox
    Friend WithEvents BackupEmailTextBox As System.Windows.Forms.TextBox
    Friend WithEvents BackupPasswordTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents cancelBtn As System.Windows.Forms.Button
    Friend WithEvents version_label As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
End Class
