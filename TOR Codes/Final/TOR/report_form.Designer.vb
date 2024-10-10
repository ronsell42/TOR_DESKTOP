<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class report_form
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(report_form))
        Me.IDLabel = New System.Windows.Forms.Label()
        Me.StudentNoLabel = New System.Windows.Forms.Label()
        Me.RemarksLabel = New System.Windows.Forms.Label()
        Me.panelMenu = New System.Windows.Forms.Panel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.maxPageLbl = New System.Windows.Forms.Label()
        Me.currentPageLbl = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.backBtn = New System.Windows.Forms.Button()
        Me.minPage = New System.Windows.Forms.Label()
        Me.maxpage = New System.Windows.Forms.Label()
        Me.curentPage = New System.Windows.Forms.Label()
        Me.refreshBtn = New System.Windows.Forms.Button()
        Me.printBtn = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.IDTextBox = New System.Windows.Forms.TextBox()
        Me.PageNumbersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TORdbDataSet = New TOR.TORdbDataSet()
        Me.StudentNoTextBox = New System.Windows.Forms.TextBox()
        Me.RemarksTextBox = New System.Windows.Forms.TextBox()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel11 = New System.Windows.Forms.Panel()
        Me.TotalLabel1 = New System.Windows.Forms.Label()
        Me.TotalPrintBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.studentNumber = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.nextBtn = New System.Windows.Forms.Button()
        Me.s = New System.Windows.Forms.Panel()
        Me.soNumber = New System.Windows.Forms.Label()
        Me.Panel12 = New System.Windows.Forms.Panel()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.Panel13 = New System.Windows.Forms.Panel()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.nextPageBtn = New Bunifu.Framework.UI.BunifuImageButton()
        Me.previousPageBtn = New Bunifu.Framework.UI.BunifuImageButton()
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.StudentsInfoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TableAdapterManager = New TOR.TORdbDataSetTableAdapters.TableAdapterManager()
        Me.PageNumbersTableAdapter = New TOR.TORdbDataSetTableAdapters.pageNumbersTableAdapter()
        Me.StudentSubjectsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StudentSubjectsTableAdapter = New TOR.TORdbDataSetTableAdapters.studentSubjectsTableAdapter()
        Me.StudentsInfoTableAdapter = New TOR.TORdbDataSetTableAdapters.studentsInfoTableAdapter()
        Me.TotalPrintTableAdapter = New TOR.TORdbDataSetTableAdapters.totalPrintTableAdapter()
        TotalLabel = New System.Windows.Forms.Label()
        Me.panelMenu.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PageNumbersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TORdbDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel11.SuspendLayout()
        CType(Me.TotalPrintBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.s.SuspendLayout()
        Me.Panel13.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nextPageBtn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.previousPageBtn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StudentsInfoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StudentSubjectsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TotalLabel
        '
        TotalLabel.AutoSize = True
        TotalLabel.Location = New System.Drawing.Point(-80, 561)
        TotalLabel.Name = "TotalLabel"
        TotalLabel.Size = New System.Drawing.Size(30, 13)
        TotalLabel.TabIndex = 0
        TotalLabel.Text = "total:"
        '
        'IDLabel
        '
        Me.IDLabel.AutoSize = True
        Me.IDLabel.Enabled = False
        Me.IDLabel.Location = New System.Drawing.Point(1118, 458)
        Me.IDLabel.Name = "IDLabel"
        Me.IDLabel.Size = New System.Drawing.Size(21, 13)
        Me.IDLabel.TabIndex = 10368
        Me.IDLabel.Text = "ID:"
        '
        'StudentNoLabel
        '
        Me.StudentNoLabel.AutoSize = True
        Me.StudentNoLabel.Enabled = False
        Me.StudentNoLabel.Location = New System.Drawing.Point(1118, 484)
        Me.StudentNoLabel.Name = "StudentNoLabel"
        Me.StudentNoLabel.Size = New System.Drawing.Size(62, 13)
        Me.StudentNoLabel.TabIndex = 10370
        Me.StudentNoLabel.Text = "student No:"
        '
        'RemarksLabel
        '
        Me.RemarksLabel.AutoSize = True
        Me.RemarksLabel.Enabled = False
        Me.RemarksLabel.Location = New System.Drawing.Point(1118, 510)
        Me.RemarksLabel.Name = "RemarksLabel"
        Me.RemarksLabel.Size = New System.Drawing.Size(47, 13)
        Me.RemarksLabel.TabIndex = 10372
        Me.RemarksLabel.Text = "remarks:"
        '
        'panelMenu
        '
        Me.panelMenu.BackColor = System.Drawing.Color.SeaGreen
        Me.panelMenu.Controls.Add(Me.Button2)
        Me.panelMenu.Controls.Add(Me.Label6)
        Me.panelMenu.Controls.Add(Me.PictureBox1)
        Me.panelMenu.Location = New System.Drawing.Point(12, 0)
        Me.panelMenu.Name = "panelMenu"
        Me.panelMenu.Size = New System.Drawing.Size(1299, 45)
        Me.panelMenu.TabIndex = 10266
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(261, -27)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 10382
        Me.Button2.Text = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Trebuchet MS", 18.0!)
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(581, 9)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(155, 29)
        Me.Label6.TabIndex = 10360
        Me.Label6.Text = "Print Preview"
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
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(697, 659)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(21, 17)
        Me.Label23.TabIndex = 10270
        Me.Label23.Text = "of"
        '
        'maxPageLbl
        '
        Me.maxPageLbl.AutoSize = True
        Me.maxPageLbl.Location = New System.Drawing.Point(717, 661)
        Me.maxPageLbl.Name = "maxPageLbl"
        Me.maxPageLbl.Size = New System.Drawing.Size(13, 13)
        Me.maxPageLbl.TabIndex = 10271
        Me.maxPageLbl.Text = "1"
        '
        'currentPageLbl
        '
        Me.currentPageLbl.AutoSize = True
        Me.currentPageLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.currentPageLbl.Location = New System.Drawing.Point(682, 661)
        Me.currentPageLbl.Name = "currentPageLbl"
        Me.currentPageLbl.Size = New System.Drawing.Size(14, 13)
        Me.currentPageLbl.TabIndex = 10272
        Me.currentPageLbl.Text = "1"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(635, 659)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(42, 17)
        Me.Label21.TabIndex = 10269
        Me.Label21.Text = "Page"
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
        Me.backBtn.Location = New System.Drawing.Point(491, 651)
        Me.backBtn.Name = "backBtn"
        Me.backBtn.Size = New System.Drawing.Size(70, 30)
        Me.backBtn.TabIndex = 10352
        Me.backBtn.Text = "Back"
        Me.backBtn.UseVisualStyleBackColor = False
        '
        'minPage
        '
        Me.minPage.AutoSize = True
        Me.minPage.Location = New System.Drawing.Point(335, 103)
        Me.minPage.Name = "minPage"
        Me.minPage.Size = New System.Drawing.Size(13, 13)
        Me.minPage.TabIndex = 10353
        Me.minPage.Text = "1"
        '
        'maxpage
        '
        Me.maxpage.AutoSize = True
        Me.maxpage.Location = New System.Drawing.Point(408, 103)
        Me.maxpage.Name = "maxpage"
        Me.maxpage.Size = New System.Drawing.Size(13, 13)
        Me.maxpage.TabIndex = 10353
        Me.maxpage.Text = "0"
        '
        'curentPage
        '
        Me.curentPage.AutoSize = True
        Me.curentPage.Location = New System.Drawing.Point(464, 103)
        Me.curentPage.Name = "curentPage"
        Me.curentPage.Size = New System.Drawing.Size(13, 13)
        Me.curentPage.TabIndex = 10353
        Me.curentPage.Text = "0"
        '
        'refreshBtn
        '
        Me.refreshBtn.BackColor = System.Drawing.Color.SeaGreen
        Me.refreshBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.refreshBtn.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen
        Me.refreshBtn.FlatAppearance.BorderSize = 0
        Me.refreshBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.refreshBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.refreshBtn.ForeColor = System.Drawing.Color.White
        Me.refreshBtn.Location = New System.Drawing.Point(805, 651)
        Me.refreshBtn.Name = "refreshBtn"
        Me.refreshBtn.Size = New System.Drawing.Size(70, 30)
        Me.refreshBtn.TabIndex = 10356
        Me.refreshBtn.Text = "Refresh"
        Me.refreshBtn.UseVisualStyleBackColor = False
        '
        'printBtn
        '
        Me.printBtn.BackColor = System.Drawing.Color.SeaGreen
        Me.printBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.printBtn.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen
        Me.printBtn.FlatAppearance.BorderSize = 0
        Me.printBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.printBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.printBtn.ForeColor = System.Drawing.Color.White
        Me.printBtn.Location = New System.Drawing.Point(957, 651)
        Me.printBtn.Name = "printBtn"
        Me.printBtn.Size = New System.Drawing.Size(70, 30)
        Me.printBtn.TabIndex = 10357
        Me.printBtn.Text = "Final Step"
        Me.printBtn.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Location = New System.Drawing.Point(13, 587)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1329, 48)
        Me.Panel1.TabIndex = 10358
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.Panel3.Location = New System.Drawing.Point(321, 40)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(776, 10)
        Me.Panel3.TabIndex = 10360
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(57, 414)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(123, 23)
        Me.Button1.TabIndex = 10368
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'IDTextBox
        '
        Me.IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PageNumbersBindingSource, "ID", True))
        Me.IDTextBox.Enabled = False
        Me.IDTextBox.Location = New System.Drawing.Point(1186, 455)
        Me.IDTextBox.Name = "IDTextBox"
        Me.IDTextBox.Size = New System.Drawing.Size(100, 20)
        Me.IDTextBox.TabIndex = 10369
        '
        'PageNumbersBindingSource
        '
        Me.PageNumbersBindingSource.DataMember = "pageNumbers"
        Me.PageNumbersBindingSource.DataSource = Me.TORdbDataSet
        '
        'TORdbDataSet
        '
        Me.TORdbDataSet.DataSetName = "TORdbDataSet"
        Me.TORdbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'StudentNoTextBox
        '
        Me.StudentNoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PageNumbersBindingSource, "studentNo", True))
        Me.StudentNoTextBox.Enabled = False
        Me.StudentNoTextBox.Location = New System.Drawing.Point(1186, 481)
        Me.StudentNoTextBox.Name = "StudentNoTextBox"
        Me.StudentNoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.StudentNoTextBox.TabIndex = 10371
        '
        'RemarksTextBox
        '
        Me.RemarksTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PageNumbersBindingSource, "remarks", True))
        Me.RemarksTextBox.Enabled = False
        Me.RemarksTextBox.Location = New System.Drawing.Point(1186, 507)
        Me.RemarksTextBox.Name = "RemarksTextBox"
        Me.RemarksTextBox.Size = New System.Drawing.Size(100, 20)
        Me.RemarksTextBox.TabIndex = 10373
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.White
        Me.Panel6.Location = New System.Drawing.Point(321, 571)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(776, 76)
        Me.Panel6.TabIndex = 10377
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Panel8.Location = New System.Drawing.Point(17, 571)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(223, 74)
        Me.Panel8.TabIndex = 10379
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Location = New System.Drawing.Point(240, 11)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(857, 41)
        Me.Panel2.TabIndex = 10376
        '
        'Panel11
        '
        Me.Panel11.BackColor = System.Drawing.SystemColors.Control
        Me.Panel11.Controls.Add(Me.TotalLabel1)
        Me.Panel11.Controls.Add(TotalLabel)
        Me.Panel11.Location = New System.Drawing.Point(1097, 0)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Size = New System.Drawing.Size(219, 645)
        Me.Panel11.TabIndex = 10381
        '
        'TotalLabel1
        '
        Me.TotalLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TotalPrintBindingSource, "total", True))
        Me.TotalLabel1.Location = New System.Drawing.Point(-44, 561)
        Me.TotalLabel1.Name = "TotalLabel1"
        Me.TotalLabel1.Size = New System.Drawing.Size(100, 23)
        Me.TotalLabel1.TabIndex = 1
        Me.TotalLabel1.Text = "Label2"
        '
        'TotalPrintBindingSource
        '
        Me.TotalPrintBindingSource.DataMember = "totalPrint"
        Me.TotalPrintBindingSource.DataSource = Me.TORdbDataSet
        '
        'studentNumber
        '
        Me.studentNumber.AutoSize = True
        Me.studentNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.studentNumber.Location = New System.Drawing.Point(245, 22)
        Me.studentNumber.Name = "studentNumber"
        Me.studentNumber.Size = New System.Drawing.Size(77, 16)
        Me.studentNumber.TabIndex = 0
        Me.studentNumber.Text = "Student No."
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.White
        Me.Panel4.Location = New System.Drawing.Point(1014, 51)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(83, 566)
        Me.Panel4.TabIndex = 10375
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.White
        Me.Panel5.Location = New System.Drawing.Point(253, 50)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(82, 585)
        Me.Panel5.TabIndex = 10374
        '
        'nextBtn
        '
        Me.nextBtn.BackColor = System.Drawing.Color.SeaGreen
        Me.nextBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.nextBtn.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen
        Me.nextBtn.FlatAppearance.BorderSize = 0
        Me.nextBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.nextBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nextBtn.ForeColor = System.Drawing.Color.White
        Me.nextBtn.Location = New System.Drawing.Point(881, 651)
        Me.nextBtn.Name = "nextBtn"
        Me.nextBtn.Size = New System.Drawing.Size(70, 30)
        Me.nextBtn.TabIndex = 10356
        Me.nextBtn.Text = "Step 1"
        Me.nextBtn.UseVisualStyleBackColor = False
        '
        's
        '
        Me.s.BackColor = System.Drawing.SystemColors.Control
        Me.s.Controls.Add(Me.soNumber)
        Me.s.Controls.Add(Me.studentNumber)
        Me.s.Location = New System.Drawing.Point(11, 0)
        Me.s.Name = "s"
        Me.s.Size = New System.Drawing.Size(242, 645)
        Me.s.TabIndex = 10361
        '
        'soNumber
        '
        Me.soNumber.AutoSize = True
        Me.soNumber.Location = New System.Drawing.Point(243, 35)
        Me.soNumber.Name = "soNumber"
        Me.soNumber.Size = New System.Drawing.Size(60, 13)
        Me.soNumber.TabIndex = 1
        Me.soNumber.Text = "So Number"
        '
        'Panel12
        '
        Me.Panel12.BackColor = System.Drawing.SystemColors.Control
        Me.Panel12.Location = New System.Drawing.Point(1336, 0)
        Me.Panel12.Name = "Panel12"
        Me.Panel12.Size = New System.Drawing.Size(10, 645)
        Me.Panel12.TabIndex = 10382
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.SystemColors.Control
        Me.Panel7.Location = New System.Drawing.Point(1314, 585)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(22, 60)
        Me.Panel7.TabIndex = 10383
        '
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.SystemColors.Control
        Me.Panel9.Location = New System.Drawing.Point(1314, 0)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(22, 42)
        Me.Panel9.TabIndex = 10384
        '
        'Panel13
        '
        Me.Panel13.BackColor = System.Drawing.Color.SeaGreen
        Me.Panel13.Controls.Add(Me.Button4)
        Me.Panel13.Controls.Add(Me.Label1)
        Me.Panel13.Controls.Add(Me.PictureBox2)
        Me.Panel13.Location = New System.Drawing.Point(259, 634)
        Me.Panel13.Name = "Panel13"
        Me.Panel13.Size = New System.Drawing.Size(834, 11)
        Me.Panel13.TabIndex = 10385
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(261, -27)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 10382
        Me.Button4.Text = "Button4"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Trebuchet MS", 18.0!)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(581, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(155, 29)
        Me.Label1.TabIndex = 10360
        Me.Label1.Text = "Print Preview"
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
        'nextPageBtn
        '
        Me.nextPageBtn.BackColor = System.Drawing.Color.Transparent
        Me.nextPageBtn.Image = Global.TOR.My.Resources.Resources.nextPage_1
        Me.nextPageBtn.ImageActive = Nothing
        Me.nextPageBtn.Location = New System.Drawing.Point(747, 651)
        Me.nextPageBtn.Name = "nextPageBtn"
        Me.nextPageBtn.Size = New System.Drawing.Size(36, 28)
        Me.nextPageBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.nextPageBtn.TabIndex = 10276
        Me.nextPageBtn.TabStop = False
        Me.nextPageBtn.Zoom = 10
        '
        'previousPageBtn
        '
        Me.previousPageBtn.BackColor = System.Drawing.Color.Transparent
        Me.previousPageBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.previousPageBtn.Image = Global.TOR.My.Resources.Resources.previousPage_1
        Me.previousPageBtn.ImageActive = Nothing
        Me.previousPageBtn.Location = New System.Drawing.Point(585, 651)
        Me.previousPageBtn.Name = "previousPageBtn"
        Me.previousPageBtn.Size = New System.Drawing.Size(36, 28)
        Me.previousPageBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.previousPageBtn.TabIndex = 10277
        Me.previousPageBtn.TabStop = False
        Me.previousPageBtn.Zoom = 10
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = -1
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrystalReportViewer1.DisplayToolbar = False
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(12, 12)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.ShowCloseButton = False
        Me.CrystalReportViewer1.ShowCopyButton = False
        Me.CrystalReportViewer1.ShowExportButton = False
        Me.CrystalReportViewer1.ShowGotoPageButton = False
        Me.CrystalReportViewer1.ShowGroupTreeButton = False
        Me.CrystalReportViewer1.ShowLogo = False
        Me.CrystalReportViewer1.ShowPageNavigateButtons = False
        Me.CrystalReportViewer1.ShowParameterPanelButton = False
        Me.CrystalReportViewer1.ShowPrintButton = False
        Me.CrystalReportViewer1.ShowRefreshButton = False
        Me.CrystalReportViewer1.ShowTextSearchButton = False
        Me.CrystalReportViewer1.ShowZoomButton = False
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(1334, 599)
        Me.CrystalReportViewer1.TabIndex = 10267
        Me.CrystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'StudentsInfoBindingSource
        '
        Me.StudentsInfoBindingSource.DataMember = "studentsInfo"
        Me.StudentsInfoBindingSource.DataSource = Me.TORdbDataSet
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.coursesTableAdapter = Nothing
        Me.TableAdapterManager.databaseTableAdapter = Nothing
        Me.TableAdapterManager.gradingTableAdapter = Nothing
        Me.TableAdapterManager.logsTableAdapter = Nothing
        Me.TableAdapterManager.pageNumbersTableAdapter = Me.PageNumbersTableAdapter
        Me.TableAdapterManager.semestersTableAdapter = Nothing
        Me.TableAdapterManager.studentsInfoTableAdapter = Nothing
        Me.TableAdapterManager.studentSubjectsTableAdapter = Nothing
        Me.TableAdapterManager.subjectsTableAdapter = Nothing
        Me.TableAdapterManager.totalPrintTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = TOR.TORdbDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.userAccountTableAdapter = Nothing
        '
        'PageNumbersTableAdapter
        '
        Me.PageNumbersTableAdapter.ClearBeforeFill = True
        '
        'StudentSubjectsBindingSource
        '
        Me.StudentSubjectsBindingSource.DataMember = "studentSubjects"
        Me.StudentSubjectsBindingSource.DataSource = Me.TORdbDataSet
        '
        'StudentSubjectsTableAdapter
        '
        Me.StudentSubjectsTableAdapter.ClearBeforeFill = True
        '
        'StudentsInfoTableAdapter
        '
        Me.StudentsInfoTableAdapter.ClearBeforeFill = True
        '
        'TotalPrintTableAdapter
        '
        Me.TotalPrintTableAdapter.ClearBeforeFill = True
        '
        'report_form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1348, 687)
        Me.Controls.Add(Me.Panel11)
        Me.Controls.Add(Me.nextBtn)
        Me.Controls.Add(Me.Panel13)
        Me.Controls.Add(Me.Panel9)
        Me.Controls.Add(Me.Panel7)
        Me.Controls.Add(Me.Panel12)
        Me.Controls.Add(Me.s)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel8)
        Me.Controls.Add(Me.nextPageBtn)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.currentPageLbl)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.panelMenu)
        Me.Controls.Add(Me.maxPageLbl)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.refreshBtn)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.backBtn)
        Me.Controls.Add(Me.previousPageBtn)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Controls.Add(Me.curentPage)
        Me.Controls.Add(Me.maxpage)
        Me.Controls.Add(Me.minPage)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.IDLabel)
        Me.Controls.Add(Me.IDTextBox)
        Me.Controls.Add(Me.StudentNoLabel)
        Me.Controls.Add(Me.StudentNoTextBox)
        Me.Controls.Add(Me.RemarksLabel)
        Me.Controls.Add(Me.RemarksTextBox)
        Me.Controls.Add(Me.printBtn)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(1364, 726)
        Me.MinimumSize = New System.Drawing.Size(1364, 726)
        Me.Name = "report_form"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Report"
        Me.panelMenu.ResumeLayout(False)
        Me.panelMenu.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PageNumbersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TORdbDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel11.ResumeLayout(False)
        Me.Panel11.PerformLayout()
        CType(Me.TotalPrintBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.s.ResumeLayout(False)
        Me.s.PerformLayout()
        Me.Panel13.ResumeLayout(False)
        Me.Panel13.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nextPageBtn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.previousPageBtn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StudentsInfoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StudentSubjectsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents panelMenu As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents nextPageBtn As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents previousPageBtn As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents maxPageLbl As System.Windows.Forms.Label
    Friend WithEvents currentPageLbl As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents backBtn As System.Windows.Forms.Button
    Friend WithEvents minPage As System.Windows.Forms.Label
    Friend WithEvents maxpage As System.Windows.Forms.Label
    Friend WithEvents curentPage As System.Windows.Forms.Label
    Friend WithEvents refreshBtn As System.Windows.Forms.Button
    Friend WithEvents printBtn As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents PageNumbersBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TORdbDataSet As TOR.TORdbDataSet
    Friend WithEvents TableAdapterManager As TOR.TORdbDataSetTableAdapters.TableAdapterManager
    Friend WithEvents PageNumbersTableAdapter As TOR.TORdbDataSetTableAdapters.pageNumbersTableAdapter
    Friend WithEvents IDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents StudentNoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents RemarksTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents Panel8 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents nextBtn As System.Windows.Forms.Button
    Friend WithEvents s As System.Windows.Forms.Panel
    Friend WithEvents Panel12 As System.Windows.Forms.Panel
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents Panel9 As System.Windows.Forms.Panel
    Friend WithEvents Panel13 As System.Windows.Forms.Panel
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents StudentSubjectsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents StudentSubjectsTableAdapter As TOR.TORdbDataSetTableAdapters.studentSubjectsTableAdapter
    Friend WithEvents IDLabel As System.Windows.Forms.Label
    Friend WithEvents StudentNoLabel As System.Windows.Forms.Label
    Friend WithEvents RemarksLabel As System.Windows.Forms.Label
    Friend WithEvents studentNumber As System.Windows.Forms.Label
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents soNumber As System.Windows.Forms.Label
    Friend WithEvents StudentsInfoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents StudentsInfoTableAdapter As TOR.TORdbDataSetTableAdapters.studentsInfoTableAdapter
    Friend WithEvents Panel11 As System.Windows.Forms.Panel
    Friend WithEvents TotalPrintBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TotalPrintTableAdapter As TOR.TORdbDataSetTableAdapters.totalPrintTableAdapter
    Friend WithEvents TotalLabel1 As System.Windows.Forms.Label
End Class
