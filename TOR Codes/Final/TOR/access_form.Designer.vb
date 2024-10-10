<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class access_form
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(access_form))
        Me.action_lbl = New System.Windows.Forms.Label()
        Me.message_lbl = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.show1 = New System.Windows.Forms.Button()
        Me.cancel_button = New System.Windows.Forms.Button()
        Me.continue_btn = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.passLbl = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.password1 = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.TORdbDataSet = New TOR.TORdbDataSet()
        Me.UserAccountTableAdapter = New TOR.TORdbDataSetTableAdapters.userAccountTableAdapter()
        Me.realPassword_label = New System.Windows.Forms.Label()
        Me.previousForm_label = New System.Windows.Forms.Label()
        Me.message2_label = New System.Windows.Forms.Button()
        Me.UserAccountBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TableAdapterManager = New TOR.TORdbDataSetTableAdapters.TableAdapterManager()
        Me.studentNumber_lbl = New System.Windows.Forms.Label()
        CType(Me.TORdbDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UserAccountBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'action_lbl
        '
        Me.action_lbl.AutoSize = True
        Me.action_lbl.Location = New System.Drawing.Point(84, 250)
        Me.action_lbl.Name = "action_lbl"
        Me.action_lbl.Size = New System.Drawing.Size(37, 13)
        Me.action_lbl.TabIndex = 10241
        Me.action_lbl.Text = "Action"
        '
        'message_lbl
        '
        Me.message_lbl.FlatAppearance.BorderSize = 0
        Me.message_lbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.message_lbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.message_lbl.Location = New System.Drawing.Point(13, 64)
        Me.message_lbl.Name = "message_lbl"
        Me.message_lbl.Size = New System.Drawing.Size(405, 41)
        Me.message_lbl.TabIndex = 10240
        Me.message_lbl.Text = "Message"
        Me.message_lbl.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(144, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(145, 25)
        Me.Label1.TabIndex = 10239
        Me.Label1.Text = "Confirmation"
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
        Me.show1.Location = New System.Drawing.Point(307, 185)
        Me.show1.Name = "show1"
        Me.show1.Size = New System.Drawing.Size(53, 35)
        Me.show1.TabIndex = 10238
        Me.show1.Text = "Show"
        Me.show1.UseVisualStyleBackColor = False
        Me.show1.Visible = False
        '
        'cancel_button
        '
        Me.cancel_button.BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cancel_button.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cancel_button.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.cancel_button.FlatAppearance.BorderSize = 0
        Me.cancel_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cancel_button.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cancel_button.ForeColor = System.Drawing.Color.White
        Me.cancel_button.Location = New System.Drawing.Point(223, 238)
        Me.cancel_button.Name = "cancel_button"
        Me.cancel_button.Size = New System.Drawing.Size(138, 37)
        Me.cancel_button.TabIndex = 10232
        Me.cancel_button.Text = "Cancel"
        Me.cancel_button.UseVisualStyleBackColor = False
        '
        'continue_btn
        '
        Me.continue_btn.BackColor = System.Drawing.Color.SeaGreen
        Me.continue_btn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.continue_btn.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.continue_btn.FlatAppearance.BorderSize = 0
        Me.continue_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.continue_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.continue_btn.ForeColor = System.Drawing.Color.White
        Me.continue_btn.Location = New System.Drawing.Point(71, 238)
        Me.continue_btn.Name = "continue_btn"
        Me.continue_btn.Size = New System.Drawing.Size(138, 37)
        Me.continue_btn.TabIndex = 10234
        Me.continue_btn.Text = "Continue"
        Me.continue_btn.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label4.Location = New System.Drawing.Point(83, 157)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(276, 20)
        Me.Label4.TabIndex = 10237
        Me.Label4.Text = "continue if you are sure for this action." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'passLbl
        '
        Me.passLbl.AutoSize = True
        Me.passLbl.BackColor = System.Drawing.Color.White
        Me.passLbl.Enabled = False
        Me.passLbl.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.passLbl.Location = New System.Drawing.Point(80, 195)
        Me.passLbl.Name = "passLbl"
        Me.passLbl.Size = New System.Drawing.Size(69, 17)
        Me.passLbl.TabIndex = 10235
        Me.passLbl.Text = "Password"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label3.Location = New System.Drawing.Point(82, 137)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(269, 20)
        Me.Label3.TabIndex = 10236
        Me.Label3.Text = "Please enter your password and click"
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
        Me.password1.Location = New System.Drawing.Point(71, 183)
        Me.password1.Margin = New System.Windows.Forms.Padding(4)
        Me.password1.Name = "password1"
        Me.password1.Size = New System.Drawing.Size(290, 38)
        Me.password1.TabIndex = 10233
        Me.password1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
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
        'realPassword_label
        '
        Me.realPassword_label.AutoSize = True
        Me.realPassword_label.Location = New System.Drawing.Point(237, 250)
        Me.realPassword_label.Name = "realPassword_label"
        Me.realPassword_label.Size = New System.Drawing.Size(52, 13)
        Me.realPassword_label.TabIndex = 10242
        Me.realPassword_label.Text = "password"
        '
        'previousForm_label
        '
        Me.previousForm_label.AutoSize = True
        Me.previousForm_label.Location = New System.Drawing.Point(168, 80)
        Me.previousForm_label.Name = "previousForm_label"
        Me.previousForm_label.Size = New System.Drawing.Size(98, 13)
        Me.previousForm_label.TabIndex = 10243
        Me.previousForm_label.Text = "previousForm_label"
        '
        'message2_label
        '
        Me.message2_label.FlatAppearance.BorderSize = 0
        Me.message2_label.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.message2_label.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.message2_label.Location = New System.Drawing.Point(13, 95)
        Me.message2_label.Name = "message2_label"
        Me.message2_label.Size = New System.Drawing.Size(405, 41)
        Me.message2_label.TabIndex = 10240
        Me.message2_label.Text = "Message:"
        Me.message2_label.UseVisualStyleBackColor = True
        '
        'UserAccountBindingSource
        '
        Me.UserAccountBindingSource.DataMember = "userAccount"
        Me.UserAccountBindingSource.DataSource = Me.TORdbDataSet
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
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
        Me.TableAdapterManager.userAccountTableAdapter = Nothing
        '
        'studentNumber_lbl
        '
        Me.studentNumber_lbl.AutoSize = True
        Me.studentNumber_lbl.Location = New System.Drawing.Point(250, 250)
        Me.studentNumber_lbl.Name = "studentNumber_lbl"
        Me.studentNumber_lbl.Size = New System.Drawing.Size(80, 13)
        Me.studentNumber_lbl.TabIndex = 10244
        Me.studentNumber_lbl.Text = "student number"
        '
        'access_form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(429, 320)
        Me.ControlBox = False
        Me.Controls.Add(Me.cancel_button)
        Me.Controls.Add(Me.realPassword_label)
        Me.Controls.Add(Me.continue_btn)
        Me.Controls.Add(Me.action_lbl)
        Me.Controls.Add(Me.message2_label)
        Me.Controls.Add(Me.message_lbl)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.show1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.passLbl)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.password1)
        Me.Controls.Add(Me.previousForm_label)
        Me.Controls.Add(Me.studentNumber_lbl)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(445, 359)
        Me.MinimumSize = New System.Drawing.Size(445, 359)
        Me.Name = "access_form"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Transcript"
        Me.TopMost = True
        CType(Me.TORdbDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UserAccountBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents action_lbl As System.Windows.Forms.Label
    Friend WithEvents message_lbl As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents show1 As System.Windows.Forms.Button
    Friend WithEvents cancel_button As System.Windows.Forms.Button
    Friend WithEvents continue_btn As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents passLbl As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents password1 As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents TORdbDataSet As TOR.TORdbDataSet
    Friend WithEvents UserAccountBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents UserAccountTableAdapter As TOR.TORdbDataSetTableAdapters.userAccountTableAdapter
    Friend WithEvents TableAdapterManager As TOR.TORdbDataSetTableAdapters.TableAdapterManager
    Friend WithEvents realPassword_label As System.Windows.Forms.Label
    Friend WithEvents previousForm_label As System.Windows.Forms.Label
    Friend WithEvents message2_label As System.Windows.Forms.Button
    Friend WithEvents studentNumber_lbl As System.Windows.Forms.Label
End Class
