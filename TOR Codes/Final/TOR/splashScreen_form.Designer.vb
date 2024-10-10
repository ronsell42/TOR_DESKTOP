<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class splashScreen_form
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(splashScreen_form))
        Me.loader = New System.Windows.Forms.Timer(Me.components)
        Me.version_label = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.icon1 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.backupPath_label = New System.Windows.Forms.Label()
        Me.DatabaseBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TORdbDataSet = New TOR.TORdbDataSet()
        Me.DatabaseTableAdapter = New TOR.TORdbDataSetTableAdapters.databaseTableAdapter()
        Me.TableAdapterManager = New TOR.TORdbDataSetTableAdapters.TableAdapterManager()
        Me.Panel3 = New System.Windows.Forms.Panel()
        CType(Me.icon1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DatabaseBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TORdbDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'loader
        '
        Me.loader.Interval = 1000
        '
        'version_label
        '
        Me.version_label.AutoSize = True
        Me.version_label.BackColor = System.Drawing.Color.SeaGreen
        Me.version_label.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.version_label.ForeColor = System.Drawing.Color.White
        Me.version_label.Location = New System.Drawing.Point(165, 113)
        Me.version_label.Name = "version_label"
        Me.version_label.Size = New System.Drawing.Size(108, 16)
        Me.version_label.TabIndex = 4
        Me.version_label.Text = "Version 1.0, 2020"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.SeaGreen
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(150, 76)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(161, 37)
        Me.Label5.TabIndex = 10112
        Me.Label5.Text = "Transcript"
        '
        'icon1
        '
        Me.icon1.BackColor = System.Drawing.Color.SeaGreen
        Me.icon1.Image = Global.TOR.My.Resources.Resources.tor1
        Me.icon1.Location = New System.Drawing.Point(89, 69)
        Me.icon1.Name = "icon1"
        Me.icon1.Size = New System.Drawing.Size(58, 54)
        Me.icon1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.icon1.TabIndex = 10111
        Me.icon1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.SeaGreen
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(79, 138)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(267, 37)
        Me.Label2.TabIndex = 10113
        Me.Label2.Text = "Fast and Secure"
        '
        'backupPath_label
        '
        Me.backupPath_label.AutoSize = True
        Me.backupPath_label.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DatabaseBindingSource, "backupPath", True))
        Me.backupPath_label.Location = New System.Drawing.Point(86, 156)
        Me.backupPath_label.Name = "backupPath_label"
        Me.backupPath_label.Size = New System.Drawing.Size(65, 13)
        Me.backupPath_label.TabIndex = 10114
        Me.backupPath_label.Text = "backupPath"
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
        'DatabaseTableAdapter
        '
        Me.DatabaseTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.coursesTableAdapter = Nothing
        Me.TableAdapterManager.databaseTableAdapter = Me.DatabaseTableAdapter
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
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.SeaGreen
        Me.Panel3.Controls.Add(Me.backupPath_label)
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(419, 240)
        Me.Panel3.TabIndex = 10117
        '
        'splashScreen_form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(419, 240)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.icon1)
        Me.Controls.Add(Me.version_label)
        Me.Controls.Add(Me.Panel3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(419, 240)
        Me.MinimumSize = New System.Drawing.Size(419, 240)
        Me.Name = "splashScreen_form"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "la"
        CType(Me.icon1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DatabaseBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TORdbDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents loader As System.Windows.Forms.Timer
    Friend WithEvents version_label As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents icon1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents backupPath_label As System.Windows.Forms.Label
    Friend WithEvents TORdbDataSet As TOR.TORdbDataSet
    Friend WithEvents DatabaseBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DatabaseTableAdapter As TOR.TORdbDataSetTableAdapters.databaseTableAdapter
    Friend WithEvents TableAdapterManager As TOR.TORdbDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
End Class
