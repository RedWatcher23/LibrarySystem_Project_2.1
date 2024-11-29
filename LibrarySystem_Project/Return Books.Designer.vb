<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Return_Books
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Return_Books))
        Me.ButtonRefresh = New System.Windows.Forms.Button()
        Me.ButtonSearchStudent = New System.Windows.Forms.Button()
        Me.TextBoxSearch = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ButtonMain = New System.Windows.Forms.Button()
        Me.ButtonExit = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StudentNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StudentNoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StrandDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SectionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ContactNoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StudentEmailDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BookIssueDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BookNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Table1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StudentRecord1DataSet = New LibrarySystem_Project.StudentRecord1DataSet()
        Me.Table1TableAdapter = New LibrarySystem_Project.StudentRecord1DataSetTableAdapters.Table1TableAdapter()
        Me.ButtonRemove = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Table1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StudentRecord1DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtonRefresh
        '
        Me.ButtonRefresh.BackColor = System.Drawing.Color.FromArgb(CType(CType(108, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(193, Byte), Integer))
        Me.ButtonRefresh.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonRefresh.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ButtonRefresh.Location = New System.Drawing.Point(141, 316)
        Me.ButtonRefresh.Name = "ButtonRefresh"
        Me.ButtonRefresh.Size = New System.Drawing.Size(84, 32)
        Me.ButtonRefresh.TabIndex = 25
        Me.ButtonRefresh.Text = "Refresh"
        Me.ButtonRefresh.UseVisualStyleBackColor = False
        '
        'ButtonSearchStudent
        '
        Me.ButtonSearchStudent.BackColor = System.Drawing.Color.FromArgb(CType(CType(108, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(193, Byte), Integer))
        Me.ButtonSearchStudent.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonSearchStudent.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ButtonSearchStudent.Location = New System.Drawing.Point(31, 316)
        Me.ButtonSearchStudent.Name = "ButtonSearchStudent"
        Me.ButtonSearchStudent.Size = New System.Drawing.Size(104, 32)
        Me.ButtonSearchStudent.TabIndex = 24
        Me.ButtonSearchStudent.Text = "Search Student"
        Me.ButtonSearchStudent.UseVisualStyleBackColor = False
        '
        'TextBoxSearch
        '
        Me.TextBoxSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxSearch.Location = New System.Drawing.Point(31, 286)
        Me.TextBoxSearch.Name = "TextBoxSearch"
        Me.TextBoxSearch.Size = New System.Drawing.Size(194, 24)
        Me.TextBoxSearch.TabIndex = 19
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Open Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(48, 260)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(155, 23)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "Enter Student No#."
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(77, 157)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 100)
        Me.PictureBox1.TabIndex = 20
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Anton", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(56, 98)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(149, 47)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "Issue Books"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(108, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(193, Byte), Integer))
        Me.Panel1.Controls.Add(Me.ButtonMain)
        Me.Panel1.Controls.Add(Me.ButtonExit)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Panel1.Location = New System.Drawing.Point(-8, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(816, 63)
        Me.Panel1.TabIndex = 21
        '
        'ButtonMain
        '
        Me.ButtonMain.BackColor = System.Drawing.Color.FromArgb(CType(CType(108, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(193, Byte), Integer))
        Me.ButtonMain.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonMain.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ButtonMain.Location = New System.Drawing.Point(616, 14)
        Me.ButtonMain.Name = "ButtonMain"
        Me.ButtonMain.Size = New System.Drawing.Size(75, 32)
        Me.ButtonMain.TabIndex = 27
        Me.ButtonMain.Text = "MAIN"
        Me.ButtonMain.UseVisualStyleBackColor = False
        '
        'ButtonExit
        '
        Me.ButtonExit.BackColor = System.Drawing.Color.FromArgb(CType(CType(108, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(193, Byte), Integer))
        Me.ButtonExit.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonExit.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ButtonExit.Location = New System.Drawing.Point(697, 14)
        Me.ButtonExit.Name = "ButtonExit"
        Me.ButtonExit.Size = New System.Drawing.Size(75, 32)
        Me.ButtonExit.TabIndex = 8
        Me.ButtonExit.Text = "EXIT"
        Me.ButtonExit.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Anton", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label2.Location = New System.Drawing.Point(70, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(115, 27)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "LibraryManager"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(39, 21)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(25, 25)
        Me.PictureBox2.TabIndex = 5
        Me.PictureBox2.TabStop = False
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToOrderColumns = True
        Me.DataGridView2.AutoGenerateColumns = False
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.StudentNameDataGridViewTextBoxColumn, Me.StudentNoDataGridViewTextBoxColumn, Me.StrandDataGridViewTextBoxColumn, Me.SectionDataGridViewTextBoxColumn, Me.ContactNoDataGridViewTextBoxColumn, Me.StudentEmailDataGridViewTextBoxColumn, Me.BookIssueDateDataGridViewTextBoxColumn, Me.BookNameDataGridViewTextBoxColumn})
        Me.DataGridView2.DataSource = Me.Table1BindingSource
        Me.DataGridView2.Location = New System.Drawing.Point(251, 69)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(537, 369)
        Me.DataGridView2.TabIndex = 26
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        Me.IDDataGridViewTextBoxColumn.Visible = False
        '
        'StudentNameDataGridViewTextBoxColumn
        '
        Me.StudentNameDataGridViewTextBoxColumn.DataPropertyName = "Student Name"
        Me.StudentNameDataGridViewTextBoxColumn.HeaderText = "Student Name"
        Me.StudentNameDataGridViewTextBoxColumn.Name = "StudentNameDataGridViewTextBoxColumn"
        '
        'StudentNoDataGridViewTextBoxColumn
        '
        Me.StudentNoDataGridViewTextBoxColumn.DataPropertyName = "Student No#"
        Me.StudentNoDataGridViewTextBoxColumn.HeaderText = "Student No#"
        Me.StudentNoDataGridViewTextBoxColumn.Name = "StudentNoDataGridViewTextBoxColumn"
        '
        'StrandDataGridViewTextBoxColumn
        '
        Me.StrandDataGridViewTextBoxColumn.DataPropertyName = "Strand"
        Me.StrandDataGridViewTextBoxColumn.HeaderText = "Strand"
        Me.StrandDataGridViewTextBoxColumn.Name = "StrandDataGridViewTextBoxColumn"
        '
        'SectionDataGridViewTextBoxColumn
        '
        Me.SectionDataGridViewTextBoxColumn.DataPropertyName = "Section"
        Me.SectionDataGridViewTextBoxColumn.HeaderText = "Section"
        Me.SectionDataGridViewTextBoxColumn.Name = "SectionDataGridViewTextBoxColumn"
        '
        'ContactNoDataGridViewTextBoxColumn
        '
        Me.ContactNoDataGridViewTextBoxColumn.DataPropertyName = "Contact No#"
        Me.ContactNoDataGridViewTextBoxColumn.HeaderText = "Contact No#"
        Me.ContactNoDataGridViewTextBoxColumn.Name = "ContactNoDataGridViewTextBoxColumn"
        '
        'StudentEmailDataGridViewTextBoxColumn
        '
        Me.StudentEmailDataGridViewTextBoxColumn.DataPropertyName = "Student Email"
        Me.StudentEmailDataGridViewTextBoxColumn.HeaderText = "Student Email"
        Me.StudentEmailDataGridViewTextBoxColumn.Name = "StudentEmailDataGridViewTextBoxColumn"
        '
        'BookIssueDateDataGridViewTextBoxColumn
        '
        Me.BookIssueDateDataGridViewTextBoxColumn.DataPropertyName = "Book Issue Date"
        Me.BookIssueDateDataGridViewTextBoxColumn.HeaderText = "Book Issue Date"
        Me.BookIssueDateDataGridViewTextBoxColumn.Name = "BookIssueDateDataGridViewTextBoxColumn"
        '
        'BookNameDataGridViewTextBoxColumn
        '
        Me.BookNameDataGridViewTextBoxColumn.DataPropertyName = "Book Name"
        Me.BookNameDataGridViewTextBoxColumn.HeaderText = "Book Name"
        Me.BookNameDataGridViewTextBoxColumn.Name = "BookNameDataGridViewTextBoxColumn"
        '
        'Table1BindingSource
        '
        Me.Table1BindingSource.DataMember = "Table1"
        Me.Table1BindingSource.DataSource = Me.StudentRecord1DataSet
        '
        'StudentRecord1DataSet
        '
        Me.StudentRecord1DataSet.DataSetName = "StudentRecord1DataSet"
        Me.StudentRecord1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Table1TableAdapter
        '
        Me.Table1TableAdapter.ClearBeforeFill = True
        '
        'ButtonRemove
        '
        Me.ButtonRemove.BackColor = System.Drawing.Color.FromArgb(CType(CType(108, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(193, Byte), Integer))
        Me.ButtonRemove.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonRemove.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ButtonRemove.Location = New System.Drawing.Point(141, 354)
        Me.ButtonRemove.Name = "ButtonRemove"
        Me.ButtonRemove.Size = New System.Drawing.Size(84, 32)
        Me.ButtonRemove.TabIndex = 27
        Me.ButtonRemove.Text = "Remove"
        Me.ButtonRemove.UseVisualStyleBackColor = False
        '
        'Return_Books
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ButtonRemove)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.ButtonRefresh)
        Me.Controls.Add(Me.ButtonSearchStudent)
        Me.Controls.Add(Me.TextBoxSearch)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Return_Books"
        Me.Text = "Return_Books"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Table1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StudentRecord1DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ButtonRefresh As Button
    Friend WithEvents ButtonSearchStudent As Button
    Friend WithEvents TextBoxSearch As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents ButtonExit As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents ButtonMain As Button
    Friend WithEvents StudentRecord1DataSet As StudentRecord1DataSet
    Friend WithEvents Table1BindingSource As BindingSource
    Friend WithEvents Table1TableAdapter As StudentRecord1DataSetTableAdapters.Table1TableAdapter
    Friend WithEvents IDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StudentNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StudentNoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StrandDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SectionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ContactNoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StudentEmailDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BookIssueDateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BookNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ButtonRemove As Button
End Class
