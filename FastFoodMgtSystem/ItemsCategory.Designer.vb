<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ItemsCategory
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ItemsCategory))
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Panel2 = New Panel()
        Label1 = New Label()
        Panel1 = New Panel()
        Btnback = New Button()
        Button1 = New Button()
        Panel3 = New Panel()
        ComboBox1 = New ComboBox()
        Button4 = New Button()
        Button3 = New Button()
        Button2 = New Button()
        Btnopen = New Button()
        TextBox4 = New TextBox()
        TextBox3 = New TextBox()
        TextBox2 = New TextBox()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        DataGridView1 = New DataGridView()
        txt_SrNo = New DataGridViewTextBoxColumn()
        txt_Category = New DataGridViewTextBoxColumn()
        txt_SellingPrice = New DataGridViewTextBoxColumn()
        txt_GST = New DataGridViewTextBoxColumn()
        txt_ServiceCharges = New DataGridViewTextBoxColumn()
        Panel10 = New Panel()
        Panel2.SuspendLayout()
        Panel1.SuspendLayout()
        Panel3.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.RosyBrown
        Panel2.Controls.Add(Label1)
        Panel2.Location = New Point(12, 38)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(770, 39)
        Panel2.TabIndex = 15
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(280, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(150, 28)
        Label1.TabIndex = 2
        Label1.Text = "ItemsCategory"
        Label1.TextAlign = ContentAlignment.TopCenter
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
        Panel1.TabIndex = 14
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
        ' Panel3
        ' 
        Panel3.Controls.Add(ComboBox1)
        Panel3.Controls.Add(Button4)
        Panel3.Controls.Add(Button3)
        Panel3.Controls.Add(Button2)
        Panel3.Controls.Add(Btnopen)
        Panel3.Controls.Add(TextBox4)
        Panel3.Controls.Add(TextBox3)
        Panel3.Controls.Add(TextBox2)
        Panel3.Controls.Add(Label5)
        Panel3.Controls.Add(Label4)
        Panel3.Controls.Add(Label3)
        Panel3.Controls.Add(Label2)
        Panel3.Location = New Point(12, 83)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(770, 203)
        Panel3.TabIndex = 16
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(155, 7)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(264, 28)
        ComboBox1.TabIndex = 21
        ' 
        ' Button4
        ' 
        Button4.BackColor = Color.Chocolate
        Button4.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button4.ForeColor = Color.White
        Button4.Image = CType(resources.GetObject("Button4.Image"), Image)
        Button4.ImageAlign = ContentAlignment.MiddleLeft
        Button4.Location = New Point(255, 165)
        Button4.Name = "Button4"
        Button4.Size = New Size(79, 29)
        Button4.TabIndex = 20
        Button4.Text = "New"
        Button4.TextAlign = ContentAlignment.MiddleRight
        Button4.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.OliveDrab
        Button3.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button3.ForeColor = Color.White
        Button3.Image = CType(resources.GetObject("Button3.Image"), Image)
        Button3.ImageAlign = ContentAlignment.MiddleLeft
        Button3.Location = New Point(355, 165)
        Button3.Name = "Button3"
        Button3.Size = New Size(94, 29)
        Button3.TabIndex = 19
        Button3.Text = "Update"
        Button3.TextAlign = ContentAlignment.MiddleRight
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.CornflowerBlue
        Button2.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button2.ForeColor = Color.Transparent
        Button2.Image = CType(resources.GetObject("Button2.Image"), Image)
        Button2.ImageAlign = ContentAlignment.MiddleLeft
        Button2.Location = New Point(155, 165)
        Button2.Name = "Button2"
        Button2.Size = New Size(77, 29)
        Button2.TabIndex = 18
        Button2.Text = "Save"
        Button2.TextAlign = ContentAlignment.MiddleRight
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Btnopen
        ' 
        Btnopen.BackColor = Color.FromArgb(CByte(192), CByte(0), CByte(0))
        Btnopen.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Btnopen.ForeColor = Color.White
        Btnopen.Image = CType(resources.GetObject("Btnopen.Image"), Image)
        Btnopen.ImageAlign = ContentAlignment.MiddleLeft
        Btnopen.Location = New Point(470, 165)
        Btnopen.Name = "Btnopen"
        Btnopen.Size = New Size(94, 29)
        Btnopen.TabIndex = 17
        Btnopen.Text = "Delete"
        Btnopen.TextAlign = ContentAlignment.MiddleRight
        Btnopen.UseVisualStyleBackColor = False
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
        Label5.Location = New Point(85, 78)
        Label5.Name = "Label5"
        Label5.Size = New Size(64, 20)
        Label5.TabIndex = 4
        Label5.Text = "GST % :-"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(27, 118)
        Label4.Name = "Label4"
        Label4.Size = New Size(126, 20)
        Label4.TabIndex = 3
        Label4.Text = "Service Charges :-"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(46, 48)
        Label3.Name = "Label3"
        Label3.Size = New Size(103, 20)
        Label3.TabIndex = 2
        Label3.Text = "Selling Price :-"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(67, 10)
        Label2.Name = "Label2"
        Label2.Size = New Size(82, 20)
        Label2.TabIndex = 0
        Label2.Text = "Category :-"
        ' 
        ' DataGridView1
        ' 
        DataGridView1.BackgroundColor = Color.White
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {txt_SrNo, txt_Category, txt_SellingPrice, txt_GST, txt_ServiceCharges})
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = SystemColors.Window
        DataGridViewCellStyle1.Font = New Font("Segoe UI", 12F)
        DataGridViewCellStyle1.ForeColor = SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.False
        DataGridView1.DefaultCellStyle = DataGridViewCellStyle1
        DataGridView1.Location = New Point(12, 292)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.Size = New Size(770, 110)
        DataGridView1.TabIndex = 17
        ' 
        ' txt_SrNo
        ' 
        txt_SrNo.HeaderText = "SrNo"
        txt_SrNo.MinimumWidth = 6
        txt_SrNo.Name = "txt_SrNo"
        txt_SrNo.Width = 98
        ' 
        ' txt_Category
        ' 
        txt_Category.HeaderText = "Category"
        txt_Category.MinimumWidth = 6
        txt_Category.Name = "txt_Category"
        txt_Category.Width = 150
        ' 
        ' txt_SellingPrice
        ' 
        txt_SellingPrice.HeaderText = "Selling Price"
        txt_SellingPrice.MinimumWidth = 6
        txt_SellingPrice.Name = "txt_SellingPrice"
        txt_SellingPrice.Width = 150
        ' 
        ' txt_GST
        ' 
        txt_GST.HeaderText = "GST"
        txt_GST.MinimumWidth = 6
        txt_GST.Name = "txt_GST"
        txt_GST.Width = 150
        ' 
        ' txt_ServiceCharges
        ' 
        txt_ServiceCharges.HeaderText = "Service Charges"
        txt_ServiceCharges.MinimumWidth = 6
        txt_ServiceCharges.Name = "txt_ServiceCharges"
        txt_ServiceCharges.Width = 150
        ' 
        ' Panel10
        ' 
        Panel10.BackColor = Color.Black
        Panel10.Location = New Point(0, 482)
        Panel10.Name = "Panel10"
        Panel10.Size = New Size(797, 11)
        Panel10.TabIndex = 29
        ' 
        ' ItemsCategory
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        Controls.Add(Panel10)
        Controls.Add(DataGridView1)
        Controls.Add(Panel3)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Name = "ItemsCategory"
        Size = New Size(797, 493)
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        Panel1.ResumeLayout(False)
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Btnback As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Btnopen As Button
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents txt_SrNo As DataGridViewTextBoxColumn
    Friend WithEvents txt_Category As DataGridViewTextBoxColumn
    Friend WithEvents txt_SellingPrice As DataGridViewTextBoxColumn
    Friend WithEvents txt_GST As DataGridViewTextBoxColumn
    Friend WithEvents txt_ServiceCharges As DataGridViewTextBoxColumn
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Panel10 As Panel

End Class
