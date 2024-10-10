<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class tutorials_form
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(tutorials_form))
        Me.header_panel = New System.Windows.Forms.Panel()
        Me.back_button = New System.Windows.Forms.PictureBox()
        Me.menu_label = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.backTo_label = New System.Windows.Forms.Label()
        Me.content_panel = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.icon1 = New System.Windows.Forms.PictureBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.howToRestore_button = New System.Windows.Forms.Button()
        Me.howToBackup_button = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.printTOR_button = New System.Windows.Forms.Button()
        Me.addStudentSubject_button = New System.Windows.Forms.Button()
        Me.deleteStudent_button = New System.Windows.Forms.Button()
        Me.editStudent_button = New System.Windows.Forms.Button()
        Me.addStudent_button = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.deleteUser_button = New System.Windows.Forms.Button()
        Me.changePasswordOrUsername_button = New System.Windows.Forms.Button()
        Me.addUser_button = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.deleteSubject_button = New System.Windows.Forms.Button()
        Me.editSubject_button = New System.Windows.Forms.Button()
        Me.addSubject_button = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.title1_label = New System.Windows.Forms.Label()
        Me.title2_label = New System.Windows.Forms.Label()
        Me.header_panel.SuspendLayout()
        CType(Me.back_button, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.content_panel.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.icon1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'header_panel
        '
        Me.header_panel.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.header_panel.BackColor = System.Drawing.Color.SeaGreen
        Me.header_panel.Controls.Add(Me.back_button)
        Me.header_panel.Controls.Add(Me.menu_label)
        Me.header_panel.Controls.Add(Me.PictureBox1)
        Me.header_panel.Controls.Add(Me.backTo_label)
        Me.header_panel.Location = New System.Drawing.Point(0, 0)
        Me.header_panel.Name = "header_panel"
        Me.header_panel.Size = New System.Drawing.Size(1348, 45)
        Me.header_panel.TabIndex = 10303
        '
        'back_button
        '
        Me.back_button.Cursor = System.Windows.Forms.Cursors.Hand
        Me.back_button.Image = Global.TOR.My.Resources.Resources.back_icon
        Me.back_button.Location = New System.Drawing.Point(11, 3)
        Me.back_button.Name = "back_button"
        Me.back_button.Size = New System.Drawing.Size(57, 40)
        Me.back_button.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.back_button.TabIndex = 10360
        Me.back_button.TabStop = False
        Me.ToolTip1.SetToolTip(Me.back_button, "Back")
        '
        'menu_label
        '
        Me.menu_label.AutoSize = True
        Me.menu_label.Font = New System.Drawing.Font("Trebuchet MS", 18.0!)
        Me.menu_label.ForeColor = System.Drawing.Color.White
        Me.menu_label.Location = New System.Drawing.Point(598, 9)
        Me.menu_label.Name = "menu_label"
        Me.menu_label.Size = New System.Drawing.Size(106, 29)
        Me.menu_label.TabIndex = 10359
        Me.menu_label.Text = "Tutorials"
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
        'backTo_label
        '
        Me.backTo_label.AutoSize = True
        Me.backTo_label.Location = New System.Drawing.Point(612, 21)
        Me.backTo_label.Name = "backTo_label"
        Me.backTo_label.Size = New System.Drawing.Size(50, 13)
        Me.backTo_label.TabIndex = 10361
        Me.backTo_label.Text = "backTo?"
        '
        'content_panel
        '
        Me.content_panel.BackColor = System.Drawing.Color.White
        Me.content_panel.Controls.Add(Me.Panel1)
        Me.content_panel.Controls.Add(Me.GroupBox4)
        Me.content_panel.Controls.Add(Me.GroupBox1)
        Me.content_panel.Controls.Add(Me.GroupBox3)
        Me.content_panel.Controls.Add(Me.GroupBox2)
        Me.content_panel.Location = New System.Drawing.Point(11, 157)
        Me.content_panel.Name = "content_panel"
        Me.content_panel.Size = New System.Drawing.Size(1325, 576)
        Me.content_panel.TabIndex = 10304
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.icon1)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(212, 375)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(913, 111)
        Me.Panel1.TabIndex = 10294
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
        Me.Label4.Text = "Developed by: Ronsell John A. Fortu together with Jomer M. Leonar, Angel Licka C." & _
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
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.howToRestore_button)
        Me.GroupBox4.Controls.Add(Me.howToBackup_button)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.ForeColor = System.Drawing.Color.SeaGreen
        Me.GroupBox4.Location = New System.Drawing.Point(945, 15)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(300, 295)
        Me.GroupBox4.TabIndex = 0
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Database"
        '
        'howToRestore_button
        '
        Me.howToRestore_button.BackColor = System.Drawing.SystemColors.Control
        Me.howToRestore_button.Cursor = System.Windows.Forms.Cursors.Hand
        Me.howToRestore_button.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen
        Me.howToRestore_button.FlatAppearance.BorderSize = 0
        Me.howToRestore_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.howToRestore_button.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.howToRestore_button.ForeColor = System.Drawing.Color.Black
        Me.howToRestore_button.Location = New System.Drawing.Point(22, 82)
        Me.howToRestore_button.Name = "howToRestore_button"
        Me.howToRestore_button.Size = New System.Drawing.Size(253, 43)
        Me.howToRestore_button.TabIndex = 10259
        Me.howToRestore_button.Text = "How to Restore Database?"
        Me.howToRestore_button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.howToRestore_button.UseVisualStyleBackColor = False
        '
        'howToBackup_button
        '
        Me.howToBackup_button.BackColor = System.Drawing.SystemColors.Control
        Me.howToBackup_button.Cursor = System.Windows.Forms.Cursors.Hand
        Me.howToBackup_button.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen
        Me.howToBackup_button.FlatAppearance.BorderSize = 0
        Me.howToBackup_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.howToBackup_button.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.howToBackup_button.ForeColor = System.Drawing.Color.Black
        Me.howToBackup_button.Location = New System.Drawing.Point(22, 33)
        Me.howToBackup_button.Name = "howToBackup_button"
        Me.howToBackup_button.Size = New System.Drawing.Size(253, 43)
        Me.howToBackup_button.TabIndex = 10259
        Me.howToBackup_button.Text = "How to Backup Database?"
        Me.howToBackup_button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.howToBackup_button.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.printTOR_button)
        Me.GroupBox1.Controls.Add(Me.addStudentSubject_button)
        Me.GroupBox1.Controls.Add(Me.deleteStudent_button)
        Me.GroupBox1.Controls.Add(Me.editStudent_button)
        Me.GroupBox1.Controls.Add(Me.addStudent_button)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.SeaGreen
        Me.GroupBox1.Location = New System.Drawing.Point(27, 15)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(300, 295)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Student"
        '
        'printTOR_button
        '
        Me.printTOR_button.BackColor = System.Drawing.SystemColors.Control
        Me.printTOR_button.Cursor = System.Windows.Forms.Cursors.Hand
        Me.printTOR_button.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen
        Me.printTOR_button.FlatAppearance.BorderSize = 0
        Me.printTOR_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.printTOR_button.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.printTOR_button.ForeColor = System.Drawing.Color.Black
        Me.printTOR_button.Location = New System.Drawing.Point(23, 228)
        Me.printTOR_button.Name = "printTOR_button"
        Me.printTOR_button.Size = New System.Drawing.Size(253, 43)
        Me.printTOR_button.TabIndex = 10259
        Me.printTOR_button.Text = "Print TOR"
        Me.printTOR_button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.printTOR_button.UseVisualStyleBackColor = False
        '
        'addStudentSubject_button
        '
        Me.addStudentSubject_button.BackColor = System.Drawing.SystemColors.Control
        Me.addStudentSubject_button.Cursor = System.Windows.Forms.Cursors.Hand
        Me.addStudentSubject_button.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen
        Me.addStudentSubject_button.FlatAppearance.BorderSize = 0
        Me.addStudentSubject_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.addStudentSubject_button.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addStudentSubject_button.ForeColor = System.Drawing.Color.Black
        Me.addStudentSubject_button.Location = New System.Drawing.Point(23, 179)
        Me.addStudentSubject_button.Name = "addStudentSubject_button"
        Me.addStudentSubject_button.Size = New System.Drawing.Size(253, 43)
        Me.addStudentSubject_button.TabIndex = 10259
        Me.addStudentSubject_button.Text = "Add Student Subject"
        Me.addStudentSubject_button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.addStudentSubject_button.UseVisualStyleBackColor = False
        '
        'deleteStudent_button
        '
        Me.deleteStudent_button.BackColor = System.Drawing.SystemColors.Control
        Me.deleteStudent_button.Cursor = System.Windows.Forms.Cursors.Hand
        Me.deleteStudent_button.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen
        Me.deleteStudent_button.FlatAppearance.BorderSize = 0
        Me.deleteStudent_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.deleteStudent_button.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.deleteStudent_button.ForeColor = System.Drawing.Color.Black
        Me.deleteStudent_button.Location = New System.Drawing.Point(23, 130)
        Me.deleteStudent_button.Name = "deleteStudent_button"
        Me.deleteStudent_button.Size = New System.Drawing.Size(253, 43)
        Me.deleteStudent_button.TabIndex = 10259
        Me.deleteStudent_button.Text = "Delete Student"
        Me.deleteStudent_button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.deleteStudent_button.UseVisualStyleBackColor = False
        '
        'editStudent_button
        '
        Me.editStudent_button.BackColor = System.Drawing.SystemColors.Control
        Me.editStudent_button.Cursor = System.Windows.Forms.Cursors.Hand
        Me.editStudent_button.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen
        Me.editStudent_button.FlatAppearance.BorderSize = 0
        Me.editStudent_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.editStudent_button.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.editStudent_button.ForeColor = System.Drawing.Color.Black
        Me.editStudent_button.Location = New System.Drawing.Point(23, 82)
        Me.editStudent_button.Name = "editStudent_button"
        Me.editStudent_button.Size = New System.Drawing.Size(253, 43)
        Me.editStudent_button.TabIndex = 10259
        Me.editStudent_button.Text = "Edit Student"
        Me.editStudent_button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.editStudent_button.UseVisualStyleBackColor = False
        '
        'addStudent_button
        '
        Me.addStudent_button.BackColor = System.Drawing.SystemColors.Control
        Me.addStudent_button.Cursor = System.Windows.Forms.Cursors.Hand
        Me.addStudent_button.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen
        Me.addStudent_button.FlatAppearance.BorderSize = 0
        Me.addStudent_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.addStudent_button.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addStudent_button.ForeColor = System.Drawing.Color.Black
        Me.addStudent_button.Location = New System.Drawing.Point(23, 33)
        Me.addStudent_button.Name = "addStudent_button"
        Me.addStudent_button.Size = New System.Drawing.Size(253, 43)
        Me.addStudent_button.TabIndex = 10259
        Me.addStudent_button.Text = "Add Student"
        Me.addStudent_button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.addStudent_button.UseVisualStyleBackColor = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.deleteUser_button)
        Me.GroupBox3.Controls.Add(Me.changePasswordOrUsername_button)
        Me.GroupBox3.Controls.Add(Me.addUser_button)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.SeaGreen
        Me.GroupBox3.Location = New System.Drawing.Point(639, 15)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(300, 295)
        Me.GroupBox3.TabIndex = 0
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Account"
        '
        'deleteUser_button
        '
        Me.deleteUser_button.BackColor = System.Drawing.SystemColors.Control
        Me.deleteUser_button.Cursor = System.Windows.Forms.Cursors.Hand
        Me.deleteUser_button.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen
        Me.deleteUser_button.FlatAppearance.BorderSize = 0
        Me.deleteUser_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.deleteUser_button.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.deleteUser_button.ForeColor = System.Drawing.Color.Black
        Me.deleteUser_button.Location = New System.Drawing.Point(22, 130)
        Me.deleteUser_button.Name = "deleteUser_button"
        Me.deleteUser_button.Size = New System.Drawing.Size(253, 43)
        Me.deleteUser_button.TabIndex = 10259
        Me.deleteUser_button.Text = "Delete User"
        Me.deleteUser_button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.deleteUser_button.UseVisualStyleBackColor = False
        '
        'changePasswordOrUsername_button
        '
        Me.changePasswordOrUsername_button.BackColor = System.Drawing.SystemColors.Control
        Me.changePasswordOrUsername_button.Cursor = System.Windows.Forms.Cursors.Hand
        Me.changePasswordOrUsername_button.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen
        Me.changePasswordOrUsername_button.FlatAppearance.BorderSize = 0
        Me.changePasswordOrUsername_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.changePasswordOrUsername_button.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.changePasswordOrUsername_button.ForeColor = System.Drawing.Color.Black
        Me.changePasswordOrUsername_button.Location = New System.Drawing.Point(22, 82)
        Me.changePasswordOrUsername_button.Name = "changePasswordOrUsername_button"
        Me.changePasswordOrUsername_button.Size = New System.Drawing.Size(253, 43)
        Me.changePasswordOrUsername_button.TabIndex = 10259
        Me.changePasswordOrUsername_button.Text = "Change Password or Username"
        Me.changePasswordOrUsername_button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.changePasswordOrUsername_button.UseVisualStyleBackColor = False
        '
        'addUser_button
        '
        Me.addUser_button.BackColor = System.Drawing.SystemColors.Control
        Me.addUser_button.Cursor = System.Windows.Forms.Cursors.Hand
        Me.addUser_button.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen
        Me.addUser_button.FlatAppearance.BorderSize = 0
        Me.addUser_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.addUser_button.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addUser_button.ForeColor = System.Drawing.Color.Black
        Me.addUser_button.Location = New System.Drawing.Point(22, 33)
        Me.addUser_button.Name = "addUser_button"
        Me.addUser_button.Size = New System.Drawing.Size(253, 43)
        Me.addUser_button.TabIndex = 10259
        Me.addUser_button.Text = "Add User"
        Me.addUser_button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.addUser_button.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.deleteSubject_button)
        Me.GroupBox2.Controls.Add(Me.editSubject_button)
        Me.GroupBox2.Controls.Add(Me.addSubject_button)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.SeaGreen
        Me.GroupBox2.Location = New System.Drawing.Point(333, 15)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(300, 295)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Subject"
        '
        'deleteSubject_button
        '
        Me.deleteSubject_button.BackColor = System.Drawing.SystemColors.Control
        Me.deleteSubject_button.Cursor = System.Windows.Forms.Cursors.Hand
        Me.deleteSubject_button.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen
        Me.deleteSubject_button.FlatAppearance.BorderSize = 0
        Me.deleteSubject_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.deleteSubject_button.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.deleteSubject_button.ForeColor = System.Drawing.Color.Black
        Me.deleteSubject_button.Location = New System.Drawing.Point(21, 130)
        Me.deleteSubject_button.Name = "deleteSubject_button"
        Me.deleteSubject_button.Size = New System.Drawing.Size(253, 43)
        Me.deleteSubject_button.TabIndex = 10259
        Me.deleteSubject_button.Text = "Delete Subject"
        Me.deleteSubject_button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.deleteSubject_button.UseVisualStyleBackColor = False
        '
        'editSubject_button
        '
        Me.editSubject_button.BackColor = System.Drawing.SystemColors.Control
        Me.editSubject_button.Cursor = System.Windows.Forms.Cursors.Hand
        Me.editSubject_button.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen
        Me.editSubject_button.FlatAppearance.BorderSize = 0
        Me.editSubject_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.editSubject_button.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.editSubject_button.ForeColor = System.Drawing.Color.Black
        Me.editSubject_button.Location = New System.Drawing.Point(21, 82)
        Me.editSubject_button.Name = "editSubject_button"
        Me.editSubject_button.Size = New System.Drawing.Size(253, 43)
        Me.editSubject_button.TabIndex = 10259
        Me.editSubject_button.Text = "Edit Subject"
        Me.editSubject_button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.editSubject_button.UseVisualStyleBackColor = False
        '
        'addSubject_button
        '
        Me.addSubject_button.BackColor = System.Drawing.SystemColors.Control
        Me.addSubject_button.Cursor = System.Windows.Forms.Cursors.Hand
        Me.addSubject_button.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen
        Me.addSubject_button.FlatAppearance.BorderSize = 0
        Me.addSubject_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.addSubject_button.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addSubject_button.ForeColor = System.Drawing.Color.Black
        Me.addSubject_button.Location = New System.Drawing.Point(21, 33)
        Me.addSubject_button.Name = "addSubject_button"
        Me.addSubject_button.Size = New System.Drawing.Size(253, 43)
        Me.addSubject_button.TabIndex = 10259
        Me.addSubject_button.Text = "Add Subject"
        Me.addSubject_button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.addSubject_button.UseVisualStyleBackColor = False
        '
        'title1_label
        '
        Me.title1_label.AutoSize = True
        Me.title1_label.Font = New System.Drawing.Font("Trebuchet MS", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.title1_label.Location = New System.Drawing.Point(260, 72)
        Me.title1_label.Name = "title1_label"
        Me.title1_label.Size = New System.Drawing.Size(863, 29)
        Me.title1_label.TabIndex = 10307
        Me.title1_label.Text = "Please select a tutorial below and make sure you have an internet connection."
        '
        'title2_label
        '
        Me.title2_label.AutoSize = True
        Me.title2_label.Font = New System.Drawing.Font("Trebuchet MS", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.title2_label.Location = New System.Drawing.Point(439, 104)
        Me.title2_label.Name = "title2_label"
        Me.title2_label.Size = New System.Drawing.Size(468, 29)
        Me.title2_label.TabIndex = 10307
        Me.title2_label.Text = "Tutorial will open to your default browser."
        '
        'tutorials_form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1348, 687)
        Me.Controls.Add(Me.header_panel)
        Me.Controls.Add(Me.title2_label)
        Me.Controls.Add(Me.title1_label)
        Me.Controls.Add(Me.content_panel)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(1364, 726)
        Me.MinimumSize = New System.Drawing.Size(1364, 726)
        Me.Name = "tutorials_form"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tutorials"
        Me.header_panel.ResumeLayout(False)
        Me.header_panel.PerformLayout()
        CType(Me.back_button, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.content_panel.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.icon1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents header_panel As System.Windows.Forms.Panel
    Friend WithEvents back_button As System.Windows.Forms.PictureBox
    Friend WithEvents menu_label As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents content_panel As System.Windows.Forms.Panel
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents addStudent_button As System.Windows.Forms.Button
    Friend WithEvents deleteStudent_button As System.Windows.Forms.Button
    Friend WithEvents editStudent_button As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents deleteSubject_button As System.Windows.Forms.Button
    Friend WithEvents editSubject_button As System.Windows.Forms.Button
    Friend WithEvents addSubject_button As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents deleteUser_button As System.Windows.Forms.Button
    Friend WithEvents changePasswordOrUsername_button As System.Windows.Forms.Button
    Friend WithEvents addUser_button As System.Windows.Forms.Button
    Friend WithEvents printTOR_button As System.Windows.Forms.Button
    Friend WithEvents addStudentSubject_button As System.Windows.Forms.Button
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents howToRestore_button As System.Windows.Forms.Button
    Friend WithEvents howToBackup_button As System.Windows.Forms.Button
    Friend WithEvents backTo_label As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents icon1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents title1_label As System.Windows.Forms.Label
    Friend WithEvents title2_label As System.Windows.Forms.Label
End Class
