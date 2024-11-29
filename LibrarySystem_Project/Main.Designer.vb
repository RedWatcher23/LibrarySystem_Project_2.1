<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button_Exit = New System.Windows.Forms.Button()
        Me.Button_ReturnBooks = New System.Windows.Forms.Button()
        Me.Button_IssueBooks = New System.Windows.Forms.Button()
        Me.Button_Books = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(108, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(193, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Button_Exit)
        Me.Panel1.Controls.Add(Me.Button_ReturnBooks)
        Me.Panel1.Controls.Add(Me.Button_IssueBooks)
        Me.Panel1.Controls.Add(Me.Button_Books)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Panel1.Location = New System.Drawing.Point(-7, -2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(816, 63)
        Me.Panel1.TabIndex = 0
        '
        'Button_Exit
        '
        Me.Button_Exit.BackColor = System.Drawing.Color.FromArgb(CType(CType(108, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(193, Byte), Integer))
        Me.Button_Exit.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Exit.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button_Exit.Location = New System.Drawing.Point(697, 14)
        Me.Button_Exit.Name = "Button_Exit"
        Me.Button_Exit.Size = New System.Drawing.Size(75, 32)
        Me.Button_Exit.TabIndex = 8
        Me.Button_Exit.Text = "EXIT"
        Me.Button_Exit.UseVisualStyleBackColor = False
        '
        'Button_ReturnBooks
        '
        Me.Button_ReturnBooks.BackColor = System.Drawing.Color.FromArgb(CType(CType(108, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(193, Byte), Integer))
        Me.Button_ReturnBooks.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_ReturnBooks.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button_ReturnBooks.Location = New System.Drawing.Point(587, 14)
        Me.Button_ReturnBooks.Name = "Button_ReturnBooks"
        Me.Button_ReturnBooks.Size = New System.Drawing.Size(104, 32)
        Me.Button_ReturnBooks.TabIndex = 7
        Me.Button_ReturnBooks.Text = "RETURN BOOKS"
        Me.Button_ReturnBooks.UseVisualStyleBackColor = False
        '
        'Button_IssueBooks
        '
        Me.Button_IssueBooks.BackColor = System.Drawing.Color.FromArgb(CType(CType(108, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(193, Byte), Integer))
        Me.Button_IssueBooks.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_IssueBooks.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button_IssueBooks.Location = New System.Drawing.Point(477, 14)
        Me.Button_IssueBooks.Name = "Button_IssueBooks"
        Me.Button_IssueBooks.Size = New System.Drawing.Size(104, 32)
        Me.Button_IssueBooks.TabIndex = 6
        Me.Button_IssueBooks.Text = "ISSUE BOOKS"
        Me.Button_IssueBooks.UseVisualStyleBackColor = False
        '
        'Button_Books
        '
        Me.Button_Books.BackColor = System.Drawing.Color.FromArgb(CType(CType(108, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(193, Byte), Integer))
        Me.Button_Books.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Books.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button_Books.Location = New System.Drawing.Point(396, 14)
        Me.Button_Books.Name = "Button_Books"
        Me.Button_Books.Size = New System.Drawing.Size(75, 32)
        Me.Button_Books.TabIndex = 1
        Me.Button_Books.Text = "BOOKS"
        Me.Button_Books.UseVisualStyleBackColor = False
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
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(-10, 50)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(816, 63)
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Anton", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(24, 136)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(190, 47)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "LibraryManager"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(29, 192)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(374, 51)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Welcome to our library's online public access catalog." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Search our catalog to vie" &
    "w bibliography information on " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "holdings we have in our library"
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Main"
        Me.Text = "Main"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Button_Books As Button
    Friend WithEvents Button_Exit As Button
    Friend WithEvents Button_ReturnBooks As Button
    Friend WithEvents Button_IssueBooks As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents Label3 As Label
End Class
