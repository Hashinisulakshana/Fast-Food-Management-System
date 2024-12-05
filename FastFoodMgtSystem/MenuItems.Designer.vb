<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenuItems
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MenuItems))
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Panel1 = New Panel()
        Btnback = New Button()
        Button1 = New Button()
        Label1 = New Label()
        DataGridView1 = New DataGridView()
        Panel2 = New Panel()
        Panel3 = New Panel()
        TextBox5 = New TextBox()
        Label9 = New Label()
        TextBox2 = New TextBox()
        Label4 = New Label()
        TextBox3 = New TextBox()
        ComboBox1 = New ComboBox()
        Label8 = New Label()
        ComboBox3 = New ComboBox()
        Label7 = New Label()
        TextBox1 = New TextBox()
        Label6 = New Label()
        ComboBox2 = New ComboBox()
        Button3 = New Button()
        Button2 = New Button()
        Btnopen = New Button()
        TextBox4 = New TextBox()
        Label5 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        txt_ItemID = New DataGridViewTextBoxColumn()
        txt_ItemName = New DataGridViewTextBoxColumn()
        txt_Category = New DataGridViewTextBoxColumn()
        txt_GST = New DataGridViewTextBoxColumn()
        txt_InventoryType = New DataGridViewTextBoxColumn()
        txt_Rate = New DataGridViewTextBoxColumn()
        txt_Discount = New DataGridViewTextBoxColumn()
        Panel1.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        Panel3.SuspendLayout()
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
        Panel1.TabIndex = 18
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
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(323, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(115, 28)
        Label1.TabIndex = 2
        Label1.Text = "Menu Item"
        Label1.TextAlign = ContentAlignment.TopCenter
        ' 
        ' DataGridView1
        ' 
        DataGridView1.BackgroundColor = Color.Silver
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {txt_ItemID, txt_ItemName, txt_Category, txt_GST, txt_InventoryType, txt_Rate, txt_Discount})
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = SystemColors.Window
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 12F)
        DataGridViewCellStyle2.ForeColor = SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.False
        DataGridView1.DefaultCellStyle = DataGridViewCellStyle2
        DataGridView1.Location = New Point(12, 380)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.Size = New Size(770, 110)
        DataGridView1.TabIndex = 20
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.RosyBrown
        Panel2.Controls.Add(Label1)
        Panel2.Location = New Point(12, 38)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(770, 39)
        Panel2.TabIndex = 19
        ' 
        ' Panel3
        ' 
        Panel3.Controls.Add(TextBox5)
        Panel3.Controls.Add(Label9)
        Panel3.Controls.Add(TextBox2)
        Panel3.Controls.Add(Label4)
        Panel3.Controls.Add(TextBox3)
        Panel3.Controls.Add(ComboBox1)
        Panel3.Controls.Add(Label8)
        Panel3.Controls.Add(ComboBox3)
        Panel3.Controls.Add(Label7)
        Panel3.Controls.Add(TextBox1)
        Panel3.Controls.Add(Label6)
        Panel3.Controls.Add(ComboBox2)
        Panel3.Controls.Add(Button3)
        Panel3.Controls.Add(Button2)
        Panel3.Controls.Add(Btnopen)
        Panel3.Controls.Add(TextBox4)
        Panel3.Controls.Add(Label5)
        Panel3.Controls.Add(Label3)
        Panel3.Controls.Add(Label2)
        Panel3.Location = New Point(12, 83)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(770, 291)
        Panel3.TabIndex = 21
        ' 
        ' TextBox5
        ' 
        TextBox5.Location = New Point(455, 145)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(77, 27)
        TextBox5.TabIndex = 33
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(369, 152)
        Label9.Name = "Label9"
        Label9.Size = New Size(80, 20)
        Label9.TabIndex = 32
        Label9.Text = "Discount :-"
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(155, 145)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(77, 27)
        TextBox2.TabIndex = 31
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(97, 148)
        Label4.Name = "Label4"
        Label4.Size = New Size(52, 20)
        Label4.TabIndex = 30
        Label4.Text = "Rate :-"
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(155, 7)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(264, 27)
        TextBox3.TabIndex = 29
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(155, 77)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(264, 28)
        ComboBox1.TabIndex = 28
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(323, 114)
        Label8.Name = "Label8"
        Label8.Size = New Size(126, 20)
        Label8.TabIndex = 27
        Label8.Text = "Service Charges :-"
        ' 
        ' ComboBox3
        ' 
        ComboBox3.FormattingEnabled = True
        ComboBox3.Location = New Point(455, 111)
        ComboBox3.Name = "ComboBox3"
        ComboBox3.Size = New Size(161, 28)
        ComboBox3.TabIndex = 26
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(15, 114)
        Label7.Name = "Label7"
        Label7.Size = New Size(134, 20)
        Label7.TabIndex = 25
        Label7.Text = "Kitchen / Section :-"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(183, 257)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(188, 27)
        TextBox1.TabIndex = 24
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(13, 264)
        Label6.Name = "Label6"
        Label6.Size = New Size(164, 20)
        Label6.TabIndex = 23
        Label6.Text = "Search By Item Name :-"
        ' 
        ' ComboBox2
        ' 
        ComboBox2.FormattingEnabled = True
        ComboBox2.Location = New Point(155, 111)
        ComboBox2.Name = "ComboBox2"
        ComboBox2.Size = New Size(161, 28)
        ComboBox2.TabIndex = 22
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.Black
        Button3.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button3.ForeColor = Color.White
        Button3.Image = CType(resources.GetObject("Button3.Image"), Image)
        Button3.ImageAlign = ContentAlignment.MiddleLeft
        Button3.Location = New Point(283, 202)
        Button3.Name = "Button3"
        Button3.Size = New Size(105, 29)
        Button3.TabIndex = 19
        Button3.Text = "Update"
        Button3.TextAlign = ContentAlignment.MiddleRight
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.Black
        Button2.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button2.ForeColor = Color.Transparent
        Button2.Image = CType(resources.GetObject("Button2.Image"), Image)
        Button2.ImageAlign = ContentAlignment.MiddleLeft
        Button2.Location = New Point(155, 202)
        Button2.Name = "Button2"
        Button2.Size = New Size(92, 29)
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
        Btnopen.Location = New Point(438, 202)
        Btnopen.Name = "Btnopen"
        Btnopen.Size = New Size(94, 29)
        Btnopen.TabIndex = 17
        Btnopen.Text = "Delete"
        Btnopen.TextAlign = ContentAlignment.MiddleRight
        Btnopen.UseVisualStyleBackColor = False
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(155, 40)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(264, 27)
        TextBox4.TabIndex = 7
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(67, 80)
        Label5.Name = "Label5"
        Label5.Size = New Size(82, 20)
        Label5.TabIndex = 4
        Label5.Text = "Category :-"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(53, 43)
        Label3.Name = "Label3"
        Label3.Size = New Size(96, 20)
        Label3.TabIndex = 2
        Label3.Text = "Item Name :-"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(78, 10)
        Label2.Name = "Label2"
        Label2.Size = New Size(71, 20)
        Label2.TabIndex = 0
        Label2.Text = "Item ID :-"
        ' 
        ' txt_ItemID
        ' 
        txt_ItemID.HeaderText = "ItemID"
        txt_ItemID.MinimumWidth = 6
        txt_ItemID.Name = "txt_ItemID"
        txt_ItemID.Width = 80
        ' 
        ' txt_ItemName
        ' 
        txt_ItemName.HeaderText = "ItemName"
        txt_ItemName.MinimumWidth = 6
        txt_ItemName.Name = "txt_ItemName"
        ' 
        ' txt_Category
        ' 
        txt_Category.HeaderText = "Category"
        txt_Category.MinimumWidth = 6
        txt_Category.Name = "txt_Category"
        ' 
        ' txt_GST
        ' 
        txt_GST.HeaderText = "Kitchen/Section"
        txt_GST.MinimumWidth = 6
        txt_GST.Name = "txt_GST"
        txt_GST.Width = 120
        ' 
        ' txt_InventoryType
        ' 
        txt_InventoryType.HeaderText = "InventoryType"
        txt_InventoryType.MinimumWidth = 6
        txt_InventoryType.Name = "txt_InventoryType"
        txt_InventoryType.Width = 110
        ' 
        ' txt_Rate
        ' 
        txt_Rate.HeaderText = "Rate"
        txt_Rate.MinimumWidth = 6
        txt_Rate.Name = "txt_Rate"
        ' 
        ' txt_Discount
        ' 
        txt_Discount.HeaderText = "Discount"
        txt_Discount.MinimumWidth = 6
        txt_Discount.Name = "txt_Discount"
        txt_Discount.Width = 125
        ' 
        ' MenuItems
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(Panel3)
        Controls.Add(Panel1)
        Controls.Add(DataGridView1)
        Controls.Add(Panel2)
        Name = "MenuItems"
        Size = New Size(797, 493)
        Panel1.ResumeLayout(False)
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Btnback As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Btnopen As Button
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents ComboBox3 As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_ItemID As DataGridViewTextBoxColumn
    Friend WithEvents txt_ItemName As DataGridViewTextBoxColumn
    Friend WithEvents txt_Category As DataGridViewTextBoxColumn
    Friend WithEvents txt_GST As DataGridViewTextBoxColumn
    Friend WithEvents txt_InventoryType As DataGridViewTextBoxColumn
    Friend WithEvents txt_Rate As DataGridViewTextBoxColumn
    Friend WithEvents txt_Discount As DataGridViewTextBoxColumn

End Class
