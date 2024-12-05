<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Records
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Records))
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Panel1 = New Panel()
        Btnback = New Button()
        Button1 = New Button()
        Panel2 = New Panel()
        Label1 = New Label()
        DataGridView1 = New DataGridView()
        txt_DishName = New DataGridViewTextBoxColumn()
        txt_Category = New DataGridViewTextBoxColumn()
        txt_Kitchen = New DataGridViewTextBoxColumn()
        txt_InventoryType = New DataGridViewTextBoxColumn()
        txt_Discount = New DataGridViewTextBoxColumn()
        Panel3 = New Panel()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
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
        Panel1.TabIndex = 24
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
        Panel2.Location = New Point(12, 38)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(770, 39)
        Panel2.TabIndex = 25
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(323, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(87, 28)
        Label1.TabIndex = 2
        Label1.Text = "Records"
        Label1.TextAlign = ContentAlignment.TopCenter
        ' 
        ' DataGridView1
        ' 
        DataGridView1.BackgroundColor = Color.White
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {txt_DishName, txt_Category, txt_Kitchen, txt_InventoryType, txt_Discount})
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = SystemColors.Window
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 12F)
        DataGridViewCellStyle2.ForeColor = SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.False
        DataGridView1.DefaultCellStyle = DataGridViewCellStyle2
        DataGridView1.Location = New Point(62, 107)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.Size = New Size(672, 348)
        DataGridView1.TabIndex = 26
        ' 
        ' txt_DishName
        ' 
        txt_DishName.AutoSizeMode = DataGridViewAutoSizeColumnMode.None
        txt_DishName.HeaderText = "DishName"
        txt_DishName.MinimumWidth = 6
        txt_DishName.Name = "txt_DishName"
        txt_DishName.Width = 130
        ' 
        ' txt_Category
        ' 
        txt_Category.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader
        txt_Category.HeaderText = "Category"
        txt_Category.MinimumWidth = 6
        txt_Category.Name = "txt_Category"
        txt_Category.Width = 98
        ' 
        ' txt_Kitchen
        ' 
        txt_Kitchen.HeaderText = "Kitchen"
        txt_Kitchen.MinimumWidth = 6
        txt_Kitchen.Name = "txt_Kitchen"
        txt_Kitchen.Width = 130
        ' 
        ' txt_InventoryType
        ' 
        txt_InventoryType.HeaderText = "InventoryType"
        txt_InventoryType.MinimumWidth = 6
        txt_InventoryType.Name = "txt_InventoryType"
        txt_InventoryType.Width = 130
        ' 
        ' txt_Discount
        ' 
        txt_Discount.HeaderText = "Discount"
        txt_Discount.MinimumWidth = 6
        txt_Discount.Name = "txt_Discount"
        txt_Discount.Width = 130
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.Black
        Panel3.Location = New Point(0, 469)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(797, 24)
        Panel3.TabIndex = 27
        ' 
        ' Records
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(Panel3)
        Controls.Add(DataGridView1)
        Controls.Add(Panel1)
        Controls.Add(Panel2)
        Name = "Records"
        Size = New Size(797, 493)
        Panel1.ResumeLayout(False)
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Btnback As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents txt_DishName As DataGridViewTextBoxColumn
    Friend WithEvents txt_Category As DataGridViewTextBoxColumn
    Friend WithEvents txt_Kitchen As DataGridViewTextBoxColumn
    Friend WithEvents txt_InventoryType As DataGridViewTextBoxColumn
    Friend WithEvents txt_Discount As DataGridViewTextBoxColumn
    Friend WithEvents Panel3 As Panel

End Class
