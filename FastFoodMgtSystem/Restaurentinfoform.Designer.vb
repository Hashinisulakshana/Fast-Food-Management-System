<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Restaurentinfoform
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Restaurentinfoform))
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Panel1 = New Panel()
        Btnback = New Button()
        Button1 = New Button()
        Panel2 = New Panel()
        Label1 = New Label()
        Panel3 = New Panel()
        Button4 = New Button()
        Button3 = New Button()
        Button2 = New Button()
        Btnopen = New Button()
        PictureBox1 = New PictureBox()
        TextBox8 = New TextBox()
        TextBox7 = New TextBox()
        TextBox6 = New TextBox()
        TextBox5 = New TextBox()
        Label9 = New Label()
        Label8 = New Label()
        Label7 = New Label()
        Label6 = New Label()
        TextBox4 = New TextBox()
        TextBox3 = New TextBox()
        TextBox2 = New TextBox()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        TextBox1 = New TextBox()
        Label2 = New Label()
        Panel4 = New Panel()
        DataGridView1 = New DataGridView()
        txt_RestaurantID = New DataGridViewTextBoxColumn()
        txt_AddressLine1 = New DataGridViewTextBoxColumn()
        txt_AddressLine2 = New DataGridViewTextBoxColumn()
        txt_AddressLine3 = New DataGridViewTextBoxColumn()
        txt_ContactNo = New DataGridViewTextBoxColumn()
        txt_Emailid = New DataGridViewTextBoxColumn()
        txt_GSTNo = New DataGridViewTextBoxColumn()
        Panel10 = New Panel()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        Panel3.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel4.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Black
        Panel1.BackgroundImageLayout = ImageLayout.None
        Panel1.Controls.Add(Btnback)
        Panel1.Controls.Add(Button1)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(797, 32)
        Panel1.TabIndex = 0
        ' 
        ' Btnback
        ' 
        Btnback.BackColor = Color.Transparent
        Btnback.BackgroundImage = CType(resources.GetObject("Btnback.BackgroundImage"), Image)
        Btnback.FlatStyle = FlatStyle.Flat
        Btnback.Location = New Point(12, 4)
        Btnback.Name = "Btnback"
        Btnback.Size = New Size(29, 28)
        Btnback.TabIndex = 11
        Btnback.UseVisualStyleBackColor = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Transparent
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Image = CType(resources.GetObject("Button1.Image"), Image)
        Button1.Location = New Point(765, 4)
        Button1.Name = "Button1"
        Button1.Size = New Size(29, 28)
        Button1.TabIndex = 11
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.RosyBrown
        Panel2.Controls.Add(Label1)
        Panel2.Location = New Point(12, 37)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(770, 39)
        Panel2.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(301, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(194, 28)
        Label1.TabIndex = 2
        Label1.Text = "RESTAURANT INFO"
        Label1.TextAlign = ContentAlignment.TopCenter
        ' 
        ' Panel3
        ' 
        Panel3.Controls.Add(Button4)
        Panel3.Controls.Add(Button3)
        Panel3.Controls.Add(Button2)
        Panel3.Controls.Add(Btnopen)
        Panel3.Controls.Add(PictureBox1)
        Panel3.Controls.Add(TextBox8)
        Panel3.Controls.Add(TextBox7)
        Panel3.Controls.Add(TextBox6)
        Panel3.Controls.Add(TextBox5)
        Panel3.Controls.Add(Label9)
        Panel3.Controls.Add(Label8)
        Panel3.Controls.Add(Label7)
        Panel3.Controls.Add(Label6)
        Panel3.Controls.Add(TextBox4)
        Panel3.Controls.Add(TextBox3)
        Panel3.Controls.Add(TextBox2)
        Panel3.Controls.Add(Label5)
        Panel3.Controls.Add(Label4)
        Panel3.Controls.Add(Label3)
        Panel3.Controls.Add(TextBox1)
        Panel3.Controls.Add(Label2)
        Panel3.Location = New Point(12, 92)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(770, 251)
        Panel3.TabIndex = 2
        ' 
        ' Button4
        ' 
        Button4.BackColor = Color.FromArgb(CByte(192), CByte(64), CByte(0))
        Button4.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button4.ForeColor = Color.White
        Button4.Image = CType(resources.GetObject("Button4.Image"), Image)
        Button4.ImageAlign = ContentAlignment.MiddleLeft
        Button4.Location = New Point(540, 212)
        Button4.Name = "Button4"
        Button4.Size = New Size(79, 29)
        Button4.TabIndex = 20
        Button4.Text = "New"
        Button4.TextAlign = ContentAlignment.MiddleRight
        Button4.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.Goldenrod
        Button3.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button3.ForeColor = Color.White
        Button3.Image = CType(resources.GetObject("Button3.Image"), Image)
        Button3.ImageAlign = ContentAlignment.MiddleLeft
        Button3.Location = New Point(640, 212)
        Button3.Name = "Button3"
        Button3.Size = New Size(94, 29)
        Button3.TabIndex = 19
        Button3.Text = "Update"
        Button3.TextAlign = ContentAlignment.MiddleRight
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.Green
        Button2.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button2.ForeColor = Color.Transparent
        Button2.Image = CType(resources.GetObject("Button2.Image"), Image)
        Button2.ImageAlign = ContentAlignment.MiddleLeft
        Button2.Location = New Point(440, 212)
        Button2.Name = "Button2"
        Button2.Size = New Size(77, 29)
        Button2.TabIndex = 18
        Button2.Text = "Save"
        Button2.TextAlign = ContentAlignment.MiddleRight
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Btnopen
        ' 
        Btnopen.BackColor = Color.Black
        Btnopen.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Btnopen.ForeColor = Color.White
        Btnopen.Image = CType(resources.GetObject("Btnopen.Image"), Image)
        Btnopen.ImageAlign = ContentAlignment.MiddleLeft
        Btnopen.Location = New Point(581, 78)
        Btnopen.Name = "Btnopen"
        Btnopen.Size = New Size(94, 29)
        Btnopen.TabIndex = 17
        Btnopen.Text = "Open"
        Btnopen.TextAlign = ContentAlignment.MiddleRight
        Btnopen.UseVisualStyleBackColor = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(455, 7)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(109, 98)
        PictureBox1.TabIndex = 16
        PictureBox1.TabStop = False
        ' 
        ' TextBox8
        ' 
        TextBox8.Location = New Point(155, 152)
        TextBox8.Name = "TextBox8"
        TextBox8.Size = New Size(166, 27)
        TextBox8.TabIndex = 15
        ' 
        ' TextBox7
        ' 
        TextBox7.Location = New Point(155, 185)
        TextBox7.Name = "TextBox7"
        TextBox7.Size = New Size(166, 27)
        TextBox7.TabIndex = 14
        ' 
        ' TextBox6
        ' 
        TextBox6.Location = New Point(455, 146)
        TextBox6.Name = "TextBox6"
        TextBox6.Size = New Size(264, 27)
        TextBox6.TabIndex = 13
        ' 
        ' TextBox5
        ' 
        TextBox5.Location = New Point(455, 179)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(264, 27)
        TextBox5.TabIndex = 12
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(367, 152)
        Label9.Name = "Label9"
        Label9.Size = New Size(82, 20)
        Label9.TabIndex = 11
        Label9.Text = " Email ID :-"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(38, 153)
        Label8.Name = "Label8"
        Label8.Size = New Size(97, 20)
        Label8.TabIndex = 10
        Label8.Text = "Contact No :-"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(63, 188)
        Label7.Name = "Label7"
        Label7.Size = New Size(72, 20)
        Label7.TabIndex = 9
        Label7.Text = "GST No :-"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(335, 185)
        Label6.Name = "Label6"
        Label6.Size = New Size(114, 20)
        Label6.TabIndex = 8
        Label6.Text = "Base Currency :-"
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(155, 45)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(264, 27)
        TextBox4.TabIndex = 7
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(155, 78)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(264, 27)
        TextBox3.TabIndex = 6
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(155, 111)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(264, 27)
        TextBox2.TabIndex = 5
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(13, 81)
        Label5.Name = "Label5"
        Label5.Size = New Size(122, 20)
        Label5.TabIndex = 4
        Label5.Text = " Address Line 2 :-"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(13, 118)
        Label4.Name = "Label4"
        Label4.Size = New Size(122, 20)
        Label4.TabIndex = 3
        Label4.Text = " Address Line 3 :-"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(13, 48)
        Label3.Name = "Label3"
        Label3.Size = New Size(122, 20)
        Label3.TabIndex = 2
        Label3.Text = " Address Line 1 :-"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(155, 7)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(264, 27)
        TextBox1.TabIndex = 1
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(13, 10)
        Label2.Name = "Label2"
        Label2.Size = New Size(136, 20)
        Label2.TabIndex = 0
        Label2.Text = "Restaurant Name :-"
        ' 
        ' Panel4
        ' 
        Panel4.Controls.Add(DataGridView1)
        Panel4.Location = New Point(12, 349)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(770, 127)
        Panel4.TabIndex = 3
        ' 
        ' DataGridView1
        ' 
        DataGridView1.BackgroundColor = Color.White
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {txt_RestaurantID, txt_AddressLine1, txt_AddressLine2, txt_AddressLine3, txt_ContactNo, txt_Emailid, txt_GSTNo})
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = SystemColors.Window
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 12F)
        DataGridViewCellStyle2.ForeColor = SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.False
        DataGridView1.DefaultCellStyle = DataGridViewCellStyle2
        DataGridView1.Location = New Point(3, 3)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.Size = New Size(754, 110)
        DataGridView1.TabIndex = 0
        ' 
        ' txt_RestaurantID
        ' 
        txt_RestaurantID.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader
        txt_RestaurantID.HeaderText = "RestaurantID"
        txt_RestaurantID.MinimumWidth = 6
        txt_RestaurantID.Name = "txt_RestaurantID"
        txt_RestaurantID.Width = 123
        ' 
        ' txt_AddressLine1
        ' 
        txt_AddressLine1.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader
        txt_AddressLine1.HeaderText = "AddressLine1"
        txt_AddressLine1.MinimumWidth = 6
        txt_AddressLine1.Name = "txt_AddressLine1"
        txt_AddressLine1.Width = 126
        ' 
        ' txt_AddressLine2
        ' 
        txt_AddressLine2.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader
        txt_AddressLine2.HeaderText = "AddressLine2"
        txt_AddressLine2.MinimumWidth = 6
        txt_AddressLine2.Name = "txt_AddressLine2"
        txt_AddressLine2.Width = 126
        ' 
        ' txt_AddressLine3
        ' 
        txt_AddressLine3.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader
        txt_AddressLine3.HeaderText = "AddressLine3"
        txt_AddressLine3.MinimumWidth = 6
        txt_AddressLine3.Name = "txt_AddressLine3"
        txt_AddressLine3.Width = 126
        ' 
        ' txt_ContactNo
        ' 
        txt_ContactNo.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader
        txt_ContactNo.HeaderText = "Contact No"
        txt_ContactNo.MinimumWidth = 6
        txt_ContactNo.Name = "txt_ContactNo"
        txt_ContactNo.Width = 113
        ' 
        ' txt_Emailid
        ' 
        txt_Emailid.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader
        txt_Emailid.HeaderText = "Emailid"
        txt_Emailid.MinimumWidth = 6
        txt_Emailid.Name = "txt_Emailid"
        txt_Emailid.Width = 88
        ' 
        ' txt_GSTNo
        ' 
        txt_GSTNo.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader
        txt_GSTNo.HeaderText = "GST No"
        txt_GSTNo.MinimumWidth = 6
        txt_GSTNo.Name = "txt_GSTNo"
        txt_GSTNo.Width = 88
        ' 
        ' Panel10
        ' 
        Panel10.BackColor = Color.Black
        Panel10.Location = New Point(0, 482)
        Panel10.Name = "Panel10"
        Panel10.Size = New Size(797, 11)
        Panel10.TabIndex = 29
        ' 
        ' Restaurentinfoform
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(Panel10)
        Controls.Add(Panel4)
        Controls.Add(Panel3)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Name = "Restaurentinfoform"
        Size = New Size(797, 493)
        Panel1.ResumeLayout(False)
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel4.ResumeLayout(False)
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Btnback As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Btnopen As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Panel4 As Panel
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents txt_RestaurantID As DataGridViewTextBoxColumn
    Friend WithEvents txt_AddressLine1 As DataGridViewTextBoxColumn
    Friend WithEvents txt_AddressLine2 As DataGridViewTextBoxColumn
    Friend WithEvents txt_AddressLine3 As DataGridViewTextBoxColumn
    Friend WithEvents txt_ContactNo As DataGridViewTextBoxColumn
    Friend WithEvents txt_Emailid As DataGridViewTextBoxColumn
    Friend WithEvents txt_GSTNo As DataGridViewTextBoxColumn
    Friend WithEvents Panel10 As Panel

End Class
