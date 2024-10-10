<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Restore_Database
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
        Dim restorePath_label As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Restore_Database))
        Me.clearSearch2_btn = New System.Windows.Forms.Button()
        Me.undoChange1_btton = New System.Windows.Forms.Button()
        Me.browse_button = New System.Windows.Forms.Button()
        Me.restorePath_textbox = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.restoreData_button = New System.Windows.Forms.Button()
        Me.TORdbDataSet = New TOR.TORdbDataSet()
        Me.DatabaseBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DatabaseTableAdapter = New TOR.TORdbDataSetTableAdapters.databaseTableAdapter()
        Me.TableAdapterManager = New TOR.TORdbDataSetTableAdapters.TableAdapterManager()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        restorePath_label = New System.Windows.Forms.Label()
        CType(Me.TORdbDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DatabaseBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'restorePath_label
        '
        restorePath_label.AutoSize = True
        restorePath_label.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        restorePath_label.ForeColor = System.Drawing.Color.Black
        restorePath_label.Location = New System.Drawing.Point(65, 103)
        restorePath_label.Name = "restorePath_label"
        restorePath_label.Size = New System.Drawing.Size(140, 18)
        restorePath_label.TabIndex = 1000000005
        restorePath_label.Text = "Database Restore File:"
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
        Me.clearSearch2_btn.Location = New System.Drawing.Point(404, 127)
        Me.clearSearch2_btn.Name = "clearSearch2_btn"
        Me.clearSearch2_btn.Size = New System.Drawing.Size(44, 28)
        Me.clearSearch2_btn.TabIndex = 1000000010
        Me.clearSearch2_btn.Text = "x"
        Me.clearSearch2_btn.UseVisualStyleBackColor = False
        Me.clearSearch2_btn.Visible = False
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
        Me.undoChange1_btton.Location = New System.Drawing.Point(68, 163)
        Me.undoChange1_btton.Name = "undoChange1_btton"
        Me.undoChange1_btton.Size = New System.Drawing.Size(100, 30)
        Me.undoChange1_btton.TabIndex = 1000000009
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
        Me.browse_button.Location = New System.Drawing.Point(455, 126)
        Me.browse_button.Name = "browse_button"
        Me.browse_button.Size = New System.Drawing.Size(70, 30)
        Me.browse_button.TabIndex = 1000000008
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
        Me.restorePath_textbox.Location = New System.Drawing.Point(68, 125)
        Me.restorePath_textbox.Margin = New System.Windows.Forms.Padding(4)
        Me.restorePath_textbox.Name = "restorePath_textbox"
        Me.restorePath_textbox.Size = New System.Drawing.Size(381, 31)
        Me.restorePath_textbox.TabIndex = 1000000007
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
        Me.restoreData_button.Location = New System.Drawing.Point(270, 163)
        Me.restoreData_button.Name = "restoreData_button"
        Me.restoreData_button.Size = New System.Drawing.Size(178, 66)
        Me.restoreData_button.TabIndex = 1000000006
        Me.restoreData_button.Text = "Restore Data"
        Me.restoreData_button.UseVisualStyleBackColor = False
        '
        'TORdbDataSet
        '
        Me.TORdbDataSet.DataSetName = "TORdbDataSet"
        Me.TORdbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DatabaseBindingSource
        '
        Me.DatabaseBindingSource.DataMember = "database"
        Me.DatabaseBindingSource.DataSource = Me.TORdbDataSet
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
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "TORdb.mdb"
        '
        'Restore_Database
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(590, 333)
        Me.Controls.Add(Me.clearSearch2_btn)
        Me.Controls.Add(Me.undoChange1_btton)
        Me.Controls.Add(Me.browse_button)
        Me.Controls.Add(Me.restorePath_textbox)
        Me.Controls.Add(Me.restoreData_button)
        Me.Controls.Add(restorePath_label)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(606, 372)
        Me.MinimumSize = New System.Drawing.Size(606, 372)
        Me.Name = "Restore_Database"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Restore Database"
        Me.TopMost = True
        CType(Me.TORdbDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DatabaseBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents clearSearch2_btn As System.Windows.Forms.Button
    Friend WithEvents undoChange1_btton As System.Windows.Forms.Button
    Friend WithEvents browse_button As System.Windows.Forms.Button
    Friend WithEvents restorePath_textbox As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents restoreData_button As System.Windows.Forms.Button
    Friend WithEvents TORdbDataSet As TOR.TORdbDataSet
    Friend WithEvents DatabaseBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DatabaseTableAdapter As TOR.TORdbDataSetTableAdapters.databaseTableAdapter
    Friend WithEvents TableAdapterManager As TOR.TORdbDataSetTableAdapters.TableAdapterManager
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
End Class
