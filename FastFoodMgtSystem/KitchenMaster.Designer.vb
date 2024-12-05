<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class KitchenMaster
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
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(KitchenMaster))
        Panel1 = New Panel()
        Btnback = New Button()
        Button1 = New Button()
        Panel2 = New Panel()
        Label1 = New Label()
        Panel3 = New Panel()
        CheckBox1 = New CheckBox()
        Label6 = New Label()
        ComboBox1 = New ComboBox()
        Button4 = New Button()
        Button3 = New Button()
        Button2 = New Button()
        Label3 = New Label()
        TextBox1 = New TextBox()
        Label2 = New Label()
        DataGridView1 = New DataGridView()
        txt_Kitchenname = New DataGridViewTextBoxColumn()
        txt_PrinterName = New DataGridViewTextBoxColumn()
        txt_IsEnabled = New DataGridViewCheckBoxColumn()
        Label4 = New Label()
        Label5 = New Label()
        Panel4 = New Panel()
        Button5 = New Button()
        Button6 = New Button()
        Panel5 = New Panel()
        Button7 = New Button()
        Button8 = New Button()
        Panel10 = New Panel()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        Panel3.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        Panel4.SuspendLayout()
        Panel5.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Black
        Panel1.BackgroundImageLayout = ImageLayout.None
        Panel1.Controls.Add(Panel4)
        Panel1.Controls.Add(Btnback)
        Panel1.Controls.Add(Button1)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(797, 32)
        Panel1.TabIndex = 1
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
        Panel2.TabIndex = 12
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(290, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(182, 28)
        Label1.TabIndex = 2
        Label1.Text = "KITCHEN MASTER"
        Label1.TextAlign = ContentAlignment.TopCenter
        ' 
        ' Panel3
        ' 
        Panel3.Controls.Add(CheckBox1)
        Panel3.Controls.Add(Label6)
        Panel3.Controls.Add(ComboBox1)
        Panel3.Controls.Add(Button4)
        Panel3.Controls.Add(Button3)
        Panel3.Controls.Add(Button2)
        Panel3.Controls.Add(Label3)
        Panel3.Controls.Add(TextBox1)
        Panel3.Controls.Add(Label2)
        Panel3.Location = New Point(12, 83)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(770, 145)
        Panel3.TabIndex = 13
        ' 
        ' CheckBox1
        ' 
        CheckBox1.AutoSize = True
        CheckBox1.Location = New Point(155, 86)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.Size = New Size(18, 17)
        CheckBox1.TabIndex = 17
        CheckBox1.UseVisualStyleBackColor = True
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(43, 83)
        Label6.Name = "Label6"
        Label6.Size = New Size(86, 20)
        Label6.TabIndex = 22
        Label6.Text = "IsEnabled :-"
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(155, 45)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(264, 28)
        ComboBox1.TabIndex = 21
        ' 
        ' Button4
        ' 
        Button4.BackColor = Color.Black
        Button4.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button4.ForeColor = Color.White
        Button4.Image = CType(resources.GetObject("Button4.Image"), Image)
        Button4.ImageAlign = ContentAlignment.MiddleLeft
        Button4.Location = New Point(442, 92)
        Button4.Name = "Button4"
        Button4.Size = New Size(79, 29)
        Button4.TabIndex = 20
        Button4.Text = "New"
        Button4.TextAlign = ContentAlignment.MiddleRight
        Button4.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.Black
        Button3.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button3.ForeColor = Color.White
        Button3.Image = CType(resources.GetObject("Button3.Image"), Image)
        Button3.ImageAlign = ContentAlignment.MiddleLeft
        Button3.Location = New Point(542, 92)
        Button3.Name = "Button3"
        Button3.Size = New Size(94, 29)
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
        Button2.Location = New Point(342, 92)
        Button2.Name = "Button2"
        Button2.Size = New Size(77, 29)
        Button2.TabIndex = 18
        Button2.Text = "Save"
        Button2.TextAlign = ContentAlignment.MiddleRight
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(20, 48)
        Label3.Name = "Label3"
        Label3.Size = New Size(109, 20)
        Label3.TabIndex = 2
        Label3.Text = "Printer Name :-"
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
        Label2.Location = New Point(14, 10)
        Label2.Name = "Label2"
        Label2.Size = New Size(115, 20)
        Label2.TabIndex = 0
        Label2.Text = "Kitchen Name :-"
        ' 
        ' DataGridView1
        ' 
        DataGridView1.BackgroundColor = Color.White
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {txt_Kitchenname, txt_PrinterName, txt_IsEnabled})
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = SystemColors.Window
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 12F)
        DataGridViewCellStyle2.ForeColor = SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.False
        DataGridView1.DefaultCellStyle = DataGridViewCellStyle2
        DataGridView1.Location = New Point(123, 234)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.Size = New Size(530, 152)
        DataGridView1.TabIndex = 14
        ' 
        ' txt_Kitchenname
        ' 
        txt_Kitchenname.AutoSizeMode = DataGridViewAutoSizeColumnMode.None
        txt_Kitchenname.HeaderText = "KitchenName"
        txt_Kitchenname.MinimumWidth = 6
        txt_Kitchenname.Name = "txt_Kitchenname"
        txt_Kitchenname.Width = 250
        ' 
        ' txt_PrinterName
        ' 
        txt_PrinterName.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader
        txt_PrinterName.HeaderText = "Printername"
        txt_PrinterName.MinimumWidth = 6
        txt_PrinterName.Name = "txt_PrinterName"
        txt_PrinterName.Width = 118
        ' 
        ' txt_IsEnabled
        ' 
        txt_IsEnabled.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader
        txt_IsEnabled.HeaderText = "IsEnabled"
        txt_IsEnabled.MinimumWidth = 6
        txt_IsEnabled.Name = "txt_IsEnabled"
        txt_IsEnabled.Resizable = DataGridViewTriState.True
        txt_IsEnabled.SortMode = DataGridViewColumnSortMode.Automatic
        txt_IsEnabled.Width = 102
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI Semilight", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(70, 403)
        Label4.Name = "Label4"
        Label4.Size = New Size(62, 23)
        Label4.TabIndex = 15
        Label4.Text = "Note :-"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI Semilight", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.Gray
        Label5.Location = New Point(138, 403)
        Label5.Name = "Label5"
        Label5.Size = New Size(635, 23)
        Label5.TabIndex = 16
        Label5.Text = "If printer shared on network then use network path of shared printer as printer name"
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = Color.Black
        Panel4.BackgroundImageLayout = ImageLayout.None
        Panel4.Controls.Add(Panel5)
        Panel4.Controls.Add(Button5)
        Panel4.Controls.Add(Button6)
        Panel4.Dock = DockStyle.Top
        Panel4.Location = New Point(0, 0)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(797, 32)
        Panel4.TabIndex = 12
        ' 
        ' Button5
        ' 
        Button5.BackColor = Color.Transparent
        Button5.BackgroundImage = CType(resources.GetObject("Button5.BackgroundImage"), Image)
        Button5.FlatStyle = FlatStyle.Flat
        Button5.Location = New Point(12, 4)
        Button5.Name = "Button5"
        Button5.Size = New Size(29, 28)
        Button5.TabIndex = 11
        Button5.UseVisualStyleBackColor = False
        ' 
        ' Button6
        ' 
        Button6.BackColor = Color.Transparent
        Button6.FlatStyle = FlatStyle.Flat
        Button6.Image = CType(resources.GetObject("Button6.Image"), Image)
        Button6.Location = New Point(765, 4)
        Button6.Name = "Button6"
        Button6.Size = New Size(29, 28)
        Button6.TabIndex = 11
        Button6.UseVisualStyleBackColor = False
        ' 
        ' Panel5
        ' 
        Panel5.BackColor = Color.Black
        Panel5.BackgroundImageLayout = ImageLayout.None
        Panel5.Controls.Add(Button7)
        Panel5.Controls.Add(Button8)
        Panel5.Dock = DockStyle.Top
        Panel5.Location = New Point(0, 0)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(797, 32)
        Panel5.TabIndex = 12
        ' 
        ' Button7
        ' 
        Button7.BackColor = Color.Transparent
        Button7.BackgroundImage = CType(resources.GetObject("Button7.BackgroundImage"), Image)
        Button7.FlatStyle = FlatStyle.Flat
        Button7.Location = New Point(12, 4)
        Button7.Name = "Button7"
        Button7.Size = New Size(29, 28)
        Button7.TabIndex = 11
        Button7.UseVisualStyleBackColor = False
        ' 
        ' Button8
        ' 
        Button8.BackColor = Color.Transparent
        Button8.FlatStyle = FlatStyle.Flat
        Button8.Image = CType(resources.GetObject("Button8.Image"), Image)
        Button8.Location = New Point(765, 4)
        Button8.Name = "Button8"
        Button8.Size = New Size(29, 28)
        Button8.TabIndex = 11
        Button8.UseVisualStyleBackColor = False
        ' 
        ' Panel10
        ' 
        Panel10.BackColor = Color.Black
        Panel10.Location = New Point(0, 482)
        Panel10.Name = "Panel10"
        Panel10.Size = New Size(797, 11)
        Panel10.TabIndex = 29
        ' 
        ' KitchenMaster
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(Panel10)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(DataGridView1)
        Controls.Add(Panel3)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Name = "KitchenMaster"
        Size = New Size(797, 493)
        Panel1.ResumeLayout(False)
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        Panel4.ResumeLayout(False)
        Panel5.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Btnback As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents txt_Kitchenname As DataGridViewTextBoxColumn
    Friend WithEvents txt_PrinterName As DataGridViewTextBoxColumn
    Friend WithEvents txt_IsEnabled As DataGridViewCheckBoxColumn
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Button7 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Panel10 As Panel

End Class
