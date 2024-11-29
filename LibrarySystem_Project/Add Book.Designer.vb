<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Add_Book
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Add_Book))
        Me.Button5 = New System.Windows.Forms.Button()
        Me.TextBoxBookPrice = New System.Windows.Forms.TextBox()
        Me.Table1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BookDataBaseNew2DataSet = New LibrarySystem_Project.BookDataBaseNew2DataSet()
        Me.LabelBookPrice = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TextBoxBookPublication = New System.Windows.Forms.TextBox()
        Me.LabelBookPublication = New System.Windows.Forms.Label()
        Me.TextBoxBookAuthor = New System.Windows.Forms.TextBox()
        Me.LabelBookAuthor = New System.Windows.Forms.Label()
        Me.TextBoxBookName = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.ButtonClear = New System.Windows.Forms.Button()
        Me.ButtonAdd = New System.Windows.Forms.Button()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.ButtonSave = New System.Windows.Forms.Button()
        Me.TextBoxBookQuantity = New System.Windows.Forms.TextBox()
        Me.LabelBookQuantity = New System.Windows.Forms.Label()
        Me.LabelBookName = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Table1TableAdapter = New LibrarySystem_Project.BookDataBaseNew2DataSetTableAdapters.Table1TableAdapter()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.Table1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BookDataBaseNew2DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.FromArgb(CType(CType(108, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(193, Byte), Integer))
        Me.Button5.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button5.Location = New System.Drawing.Point(616, 14)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(75, 32)
        Me.Button5.TabIndex = 9
        Me.Button5.Text = "RETURN"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'TextBoxBookPrice
        '
        Me.TextBoxBookPrice.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Table1BindingSource, "Book Price", True))
        Me.TextBoxBookPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxBookPrice.Location = New System.Drawing.Point(213, 219)
        Me.TextBoxBookPrice.Name = "TextBoxBookPrice"
        Me.TextBoxBookPrice.Size = New System.Drawing.Size(294, 24)
        Me.TextBoxBookPrice.TabIndex = 32
        '
        'Table1BindingSource
        '
        Me.Table1BindingSource.DataMember = "Table1"
        Me.Table1BindingSource.DataSource = Me.BookDataBaseNew2DataSet
        '
        'BookDataBaseNew2DataSet
        '
        Me.BookDataBaseNew2DataSet.DataSetName = "BookDataBaseNew2DataSet"
        Me.BookDataBaseNew2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'LabelBookPrice
        '
        Me.LabelBookPrice.AutoSize = True
        Me.LabelBookPrice.Font = New System.Drawing.Font("Open Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelBookPrice.ForeColor = System.Drawing.Color.Black
        Me.LabelBookPrice.Location = New System.Drawing.Point(22, 220)
        Me.LabelBookPrice.Name = "LabelBookPrice"
        Me.LabelBookPrice.Size = New System.Drawing.Size(94, 23)
        Me.LabelBookPrice.TabIndex = 33
        Me.LabelBookPrice.Text = "Book Price:"
        Me.LabelBookPrice.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Open Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(22, 169)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(175, 23)
        Me.Label9.TabIndex = 30
        Me.Label9.Text = "Books Purchase Date:"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'TextBoxBookPublication
        '
        Me.TextBoxBookPublication.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Table1BindingSource, "Book Publication", True))
        Me.TextBoxBookPublication.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxBookPublication.Location = New System.Drawing.Point(213, 120)
        Me.TextBoxBookPublication.Name = "TextBoxBookPublication"
        Me.TextBoxBookPublication.Size = New System.Drawing.Size(294, 24)
        Me.TextBoxBookPublication.TabIndex = 23
        '
        'LabelBookPublication
        '
        Me.LabelBookPublication.AutoSize = True
        Me.LabelBookPublication.Font = New System.Drawing.Font("Open Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelBookPublication.ForeColor = System.Drawing.Color.Black
        Me.LabelBookPublication.Location = New System.Drawing.Point(22, 121)
        Me.LabelBookPublication.Name = "LabelBookPublication"
        Me.LabelBookPublication.Size = New System.Drawing.Size(141, 23)
        Me.LabelBookPublication.TabIndex = 24
        Me.LabelBookPublication.Text = "Book Publication:"
        Me.LabelBookPublication.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'TextBoxBookAuthor
        '
        Me.TextBoxBookAuthor.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Table1BindingSource, "Book Author", True))
        Me.TextBoxBookAuthor.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxBookAuthor.Location = New System.Drawing.Point(213, 73)
        Me.TextBoxBookAuthor.Name = "TextBoxBookAuthor"
        Me.TextBoxBookAuthor.Size = New System.Drawing.Size(294, 24)
        Me.TextBoxBookAuthor.TabIndex = 21
        '
        'LabelBookAuthor
        '
        Me.LabelBookAuthor.AutoSize = True
        Me.LabelBookAuthor.Font = New System.Drawing.Font("Open Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelBookAuthor.ForeColor = System.Drawing.Color.Black
        Me.LabelBookAuthor.Location = New System.Drawing.Point(22, 74)
        Me.LabelBookAuthor.Name = "LabelBookAuthor"
        Me.LabelBookAuthor.Size = New System.Drawing.Size(158, 23)
        Me.LabelBookAuthor.TabIndex = 22
        Me.LabelBookAuthor.Text = "Book Author Name:"
        Me.LabelBookAuthor.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'TextBoxBookName
        '
        Me.TextBoxBookName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Table1BindingSource, "Book Name", True))
        Me.TextBoxBookName.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxBookName.Location = New System.Drawing.Point(213, 26)
        Me.TextBoxBookName.Name = "TextBoxBookName"
        Me.TextBoxBookName.Size = New System.Drawing.Size(294, 24)
        Me.TextBoxBookName.TabIndex = 19
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Azure
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Controls.Add(Me.ButtonClear)
        Me.Panel2.Controls.Add(Me.ButtonAdd)
        Me.Panel2.Controls.Add(Me.DateTimePicker1)
        Me.Panel2.Controls.Add(Me.ButtonSave)
        Me.Panel2.Controls.Add(Me.TextBoxBookQuantity)
        Me.Panel2.Controls.Add(Me.LabelBookQuantity)
        Me.Panel2.Controls.Add(Me.TextBoxBookPrice)
        Me.Panel2.Controls.Add(Me.LabelBookPrice)
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Controls.Add(Me.TextBoxBookPublication)
        Me.Panel2.Controls.Add(Me.LabelBookPublication)
        Me.Panel2.Controls.Add(Me.TextBoxBookAuthor)
        Me.Panel2.Controls.Add(Me.LabelBookAuthor)
        Me.Panel2.Controls.Add(Me.TextBoxBookName)
        Me.Panel2.Controls.Add(Me.LabelBookName)
        Me.Panel2.Location = New System.Drawing.Point(257, 69)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(540, 381)
        Me.Panel2.TabIndex = 23
        '
        'ButtonClear
        '
        Me.ButtonClear.BackColor = System.Drawing.Color.FromArgb(CType(CType(108, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(193, Byte), Integer))
        Me.ButtonClear.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonClear.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ButtonClear.Location = New System.Drawing.Point(73, 318)
        Me.ButtonClear.Name = "ButtonClear"
        Me.ButtonClear.Size = New System.Drawing.Size(90, 32)
        Me.ButtonClear.TabIndex = 40
        Me.ButtonClear.Text = "Clear"
        Me.ButtonClear.UseVisualStyleBackColor = False
        '
        'ButtonAdd
        '
        Me.ButtonAdd.BackColor = System.Drawing.Color.FromArgb(CType(CType(108, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(193, Byte), Integer))
        Me.ButtonAdd.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonAdd.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ButtonAdd.Location = New System.Drawing.Point(321, 318)
        Me.ButtonAdd.Name = "ButtonAdd"
        Me.ButtonAdd.Size = New System.Drawing.Size(90, 32)
        Me.ButtonAdd.TabIndex = 39
        Me.ButtonAdd.Text = "Add"
        Me.ButtonAdd.UseVisualStyleBackColor = False
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.Table1BindingSource, "Book Date", True))
        Me.DateTimePicker1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Location = New System.Drawing.Point(213, 169)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(294, 24)
        Me.DateTimePicker1.TabIndex = 38
        '
        'ButtonSave
        '
        Me.ButtonSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(108, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(193, Byte), Integer))
        Me.ButtonSave.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonSave.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ButtonSave.Location = New System.Drawing.Point(417, 318)
        Me.ButtonSave.Name = "ButtonSave"
        Me.ButtonSave.Size = New System.Drawing.Size(90, 32)
        Me.ButtonSave.TabIndex = 36
        Me.ButtonSave.Text = "Save"
        Me.ButtonSave.UseVisualStyleBackColor = False
        '
        'TextBoxBookQuantity
        '
        Me.TextBoxBookQuantity.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Table1BindingSource, "Book Quantity", True))
        Me.TextBoxBookQuantity.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxBookQuantity.Location = New System.Drawing.Point(213, 268)
        Me.TextBoxBookQuantity.Name = "TextBoxBookQuantity"
        Me.TextBoxBookQuantity.Size = New System.Drawing.Size(294, 24)
        Me.TextBoxBookQuantity.TabIndex = 34
        '
        'LabelBookQuantity
        '
        Me.LabelBookQuantity.AutoSize = True
        Me.LabelBookQuantity.Font = New System.Drawing.Font("Open Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelBookQuantity.ForeColor = System.Drawing.Color.Black
        Me.LabelBookQuantity.Location = New System.Drawing.Point(22, 269)
        Me.LabelBookQuantity.Name = "LabelBookQuantity"
        Me.LabelBookQuantity.Size = New System.Drawing.Size(121, 23)
        Me.LabelBookQuantity.TabIndex = 35
        Me.LabelBookQuantity.Text = "Book Quantity:"
        Me.LabelBookQuantity.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'LabelBookName
        '
        Me.LabelBookName.AutoSize = True
        Me.LabelBookName.Font = New System.Drawing.Font("Open Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelBookName.ForeColor = System.Drawing.Color.Black
        Me.LabelBookName.Location = New System.Drawing.Point(22, 27)
        Me.LabelBookName.Name = "LabelBookName"
        Me.LabelBookName.Size = New System.Drawing.Size(101, 23)
        Me.LabelBookName.TabIndex = 20
        Me.LabelBookName.Text = "Book Name:"
        Me.LabelBookName.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.FromArgb(CType(CType(108, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(193, Byte), Integer))
        Me.Button4.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button4.Location = New System.Drawing.Point(697, 14)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 32)
        Me.Button4.TabIndex = 8
        Me.Button4.Text = "EXIT"
        Me.Button4.UseVisualStyleBackColor = False
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
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(108, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(193, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Button5)
        Me.Panel1.Controls.Add(Me.Button4)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Panel1.Location = New System.Drawing.Point(-8, 1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(816, 63)
        Me.Panel1.TabIndex = 21
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Anton", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(60, 67)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(117, 47)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "ADD BOOK"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Table1TableAdapter
        '
        Me.Table1TableAdapter.ClearBeforeFill = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(9, 116)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(239, 322)
        Me.PictureBox1.TabIndex = 24
        Me.PictureBox1.TabStop = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(108, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(193, Byte), Integer))
        Me.Button1.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button1.Location = New System.Drawing.Point(225, 318)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(90, 32)
        Me.Button1.TabIndex = 41
        Me.Button1.Text = "Insert Cover"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Add_Book
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Add_Book"
        Me.Text = "Add_Book"
        CType(Me.Table1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BookDataBaseNew2DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button5 As Button
    Friend WithEvents TextBoxBookPrice As TextBox
    Friend WithEvents LabelBookPrice As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents TextBoxBookPublication As TextBox
    Friend WithEvents LabelBookPublication As Label
    Friend WithEvents TextBoxBookAuthor As TextBox
    Friend WithEvents LabelBookAuthor As Label
    Friend WithEvents TextBoxBookName As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents LabelBookName As Label
    Friend WithEvents Button4 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents ButtonSave As Button
    Friend WithEvents TextBoxBookQuantity As TextBox
    Friend WithEvents LabelBookQuantity As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents BookDataBaseNew2DataSet As BookDataBaseNew2DataSet
    Friend WithEvents Table1BindingSource As BindingSource
    Friend WithEvents Table1TableAdapter As BookDataBaseNew2DataSetTableAdapters.Table1TableAdapter
    Friend WithEvents ButtonClear As Button
    Friend WithEvents ButtonAdd As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
