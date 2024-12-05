<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Billings
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Billings))
        Dim DataGridViewCellStyle5 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Panel1 = New Panel()
        Btnback = New Button()
        Button1 = New Button()
        Panel2 = New Panel()
        Label1 = New Label()
        Label2 = New Label()
        Label5 = New Label()
        ComboBox1 = New ComboBox()
        ComboBox2 = New ComboBox()
        Label3 = New Label()
        ComboBox3 = New ComboBox()
        Label4 = New Label()
        DataGridView1 = New DataGridView()
        txt_TableNo = New DataGridViewTextBoxColumn()
        txt_Customer = New DataGridViewTextBoxColumn()
        Panel3 = New Panel()
        TextBox6 = New TextBox()
        Label7 = New Label()
        TextBox5 = New TextBox()
        TextBox4 = New TextBox()
        TextBox3 = New TextBox()
        TextBox2 = New TextBox()
        Label6 = New Label()
        Label8 = New Label()
        TextBox1 = New TextBox()
        Label9 = New Label()
        Panel4 = New Panel()
        TextBox7 = New TextBox()
        Label10 = New Label()
        TextBox8 = New TextBox()
        TextBox9 = New TextBox()
        TextBox10 = New TextBox()
        TextBox11 = New TextBox()
        Label11 = New Label()
        Label12 = New Label()
        TextBox12 = New TextBox()
        Label13 = New Label()
        Label14 = New Label()
        Label15 = New Label()
        TextBox13 = New TextBox()
        Label16 = New Label()
        TextBox14 = New TextBox()
        Label17 = New Label()
        TextBox15 = New TextBox()
        Label18 = New Label()
        TextBox16 = New TextBox()
        Label19 = New Label()
        TextBox17 = New TextBox()
        Button2 = New Button()
        Button3 = New Button()
        Button4 = New Button()
        Button5 = New Button()
        Panel10 = New Panel()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        Panel3.SuspendLayout()
        Panel4.SuspendLayout()
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
        Panel1.Size = New Size(800, 32)
        Panel1.TabIndex = 26
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
        Panel2.Size = New Size(770, 27)
        Panel2.TabIndex = 27
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(323, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(73, 28)
        Label1.TabIndex = 2
        Label1.Text = "Billing"
        Label1.TextAlign = ContentAlignment.TopCenter
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(12, 80)
        Label2.Name = "Label2"
        Label2.Size = New Size(64, 20)
        Label2.TabIndex = 28
        Label2.Text = "Bill No. :"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(12, 112)
        Label5.Name = "Label5"
        Label5.Size = New Size(72, 20)
        Label5.TabIndex = 31
        Label5.Text = "Bill Type :"
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(12, 137)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(206, 28)
        ComboBox1.TabIndex = 32
        ' 
        ' ComboBox2
        ' 
        ComboBox2.FormattingEnabled = True
        ComboBox2.Location = New Point(12, 245)
        ComboBox2.Name = "ComboBox2"
        ComboBox2.Size = New Size(206, 28)
        ComboBox2.TabIndex = 34
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(12, 222)
        Label3.Name = "Label3"
        Label3.Size = New Size(64, 20)
        Label3.TabIndex = 33
        Label3.Text = "Bill No. :"
        ' 
        ' ComboBox3
        ' 
        ComboBox3.FormattingEnabled = True
        ComboBox3.Location = New Point(12, 191)
        ComboBox3.Name = "ComboBox3"
        ComboBox3.Size = New Size(206, 28)
        ComboBox3.TabIndex = 36
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(12, 168)
        Label4.Name = "Label4"
        Label4.Size = New Size(170, 20)
        Label4.TabIndex = 35
        Label4.Text = "Customer/Group Name :"
        ' 
        ' DataGridView1
        ' 
        DataGridView1.BackgroundColor = Color.White
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {txt_TableNo, txt_Customer})
        DataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = SystemColors.Window
        DataGridViewCellStyle5.Font = New Font("Segoe UI", 12F)
        DataGridViewCellStyle5.ForeColor = SystemColors.ControlText
        DataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = DataGridViewTriState.False
        DataGridView1.DefaultCellStyle = DataGridViewCellStyle5
        DataGridView1.Location = New Point(12, 279)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.Size = New Size(206, 304)
        DataGridView1.TabIndex = 37
        ' 
        ' txt_TableNo
        ' 
        txt_TableNo.HeaderText = "TableNo"
        txt_TableNo.MinimumWidth = 6
        txt_TableNo.Name = "txt_TableNo"
        txt_TableNo.Width = 80
        ' 
        ' txt_Customer
        ' 
        txt_Customer.HeaderText = "Customer"
        txt_Customer.MinimumWidth = 6
        txt_Customer.Name = "txt_Customer"
        txt_Customer.Width = 80
        ' 
        ' Panel3
        ' 
        Panel3.Controls.Add(TextBox6)
        Panel3.Controls.Add(Label7)
        Panel3.Controls.Add(TextBox5)
        Panel3.Controls.Add(TextBox4)
        Panel3.Controls.Add(TextBox3)
        Panel3.Controls.Add(TextBox2)
        Panel3.Controls.Add(Label6)
        Panel3.Controls.Add(Label8)
        Panel3.Controls.Add(TextBox1)
        Panel3.Controls.Add(Label9)
        Panel3.Location = New Point(241, 80)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(490, 212)
        Panel3.TabIndex = 38
        ' 
        ' TextBox6
        ' 
        TextBox6.Location = New Point(145, 176)
        TextBox6.Name = "TextBox6"
        TextBox6.Size = New Size(138, 27)
        TextBox6.TabIndex = 18
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(42, 179)
        Label7.Name = "Label7"
        Label7.Size = New Size(97, 20)
        Label7.TabIndex = 17
        Label7.Text = "Contact No :-"
        ' 
        ' TextBox5
        ' 
        TextBox5.Location = New Point(145, 143)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(264, 27)
        TextBox5.TabIndex = 16
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(145, 44)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(264, 27)
        TextBox4.TabIndex = 15
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(145, 77)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(264, 27)
        TextBox3.TabIndex = 14
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(145, 110)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(264, 27)
        TextBox2.TabIndex = 13
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(60, 82)
        Label6.Name = "Label6"
        Label6.Size = New Size(79, 20)
        Label6.TabIndex = 12
        Label6.Text = " Address :-"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(10, 47)
        Label8.Name = "Label8"
        Label8.Size = New Size(129, 20)
        Label8.TabIndex = 10
        Label8.Text = "Customer Name :-"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(145, 6)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(264, 27)
        TextBox1.TabIndex = 9
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(58, 13)
        Label9.Name = "Label9"
        Label9.Size = New Size(81, 20)
        Label9.TabIndex = 8
        Label9.Text = "Table No :-"
        ' 
        ' Panel4
        ' 
        Panel4.Controls.Add(Label19)
        Panel4.Controls.Add(TextBox17)
        Panel4.Controls.Add(Label18)
        Panel4.Controls.Add(TextBox16)
        Panel4.Controls.Add(Label17)
        Panel4.Controls.Add(TextBox15)
        Panel4.Controls.Add(TextBox14)
        Panel4.Controls.Add(TextBox13)
        Panel4.Controls.Add(Label16)
        Panel4.Controls.Add(Label15)
        Panel4.Controls.Add(Label14)
        Panel4.Controls.Add(TextBox7)
        Panel4.Controls.Add(Label10)
        Panel4.Controls.Add(TextBox8)
        Panel4.Controls.Add(TextBox9)
        Panel4.Controls.Add(TextBox10)
        Panel4.Controls.Add(TextBox11)
        Panel4.Controls.Add(Label11)
        Panel4.Controls.Add(Label12)
        Panel4.Controls.Add(TextBox12)
        Panel4.Controls.Add(Label13)
        Panel4.Location = New Point(241, 310)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(490, 212)
        Panel4.TabIndex = 39
        ' 
        ' TextBox7
        ' 
        TextBox7.Location = New Point(121, 176)
        TextBox7.Name = "TextBox7"
        TextBox7.Size = New Size(96, 27)
        TextBox7.TabIndex = 18
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Location = New Point(18, 176)
        Label10.Name = "Label10"
        Label10.Size = New Size(97, 20)
        Label10.TabIndex = 17
        Label10.Text = "Contact No :-"
        ' 
        ' TextBox8
        ' 
        TextBox8.Location = New Point(121, 143)
        TextBox8.Name = "TextBox8"
        TextBox8.Size = New Size(96, 27)
        TextBox8.TabIndex = 16
        ' 
        ' TextBox9
        ' 
        TextBox9.Location = New Point(121, 44)
        TextBox9.Name = "TextBox9"
        TextBox9.Size = New Size(96, 27)
        TextBox9.TabIndex = 15
        ' 
        ' TextBox10
        ' 
        TextBox10.Location = New Point(121, 80)
        TextBox10.Name = "TextBox10"
        TextBox10.Size = New Size(96, 27)
        TextBox10.TabIndex = 14
        ' 
        ' TextBox11
        ' 
        TextBox11.Location = New Point(121, 110)
        TextBox11.Name = "TextBox11"
        TextBox11.Size = New Size(96, 27)
        TextBox11.TabIndex = 13
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Location = New Point(68, 83)
        Label11.Name = "Label11"
        Label11.Size = New Size(47, 20)
        Label11.TabIndex = 12
        Label11.Text = "VAT :-"
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Location = New Point(10, 47)
        Label12.Name = "Label12"
        Label12.Size = New Size(105, 20)
        Label12.TabIndex = 10
        Label12.Text = "Bill Discount :-"
        ' 
        ' TextBox12
        ' 
        TextBox12.Location = New Point(121, 10)
        TextBox12.Name = "TextBox12"
        TextBox12.Size = New Size(96, 27)
        TextBox12.TabIndex = 9
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Location = New Point(31, 13)
        Label13.Name = "Label13"
        Label13.Size = New Size(84, 20)
        Label13.TabIndex = 8
        Label13.Text = "Sub Total :-"
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Location = New Point(0, 150)
        Label14.Name = "Label14"
        Label14.Size = New Size(120, 20)
        Label14.TabIndex = 19
        Label14.Text = "Service Charge :-"
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.Location = New Point(21, 117)
        Label15.Name = "Label15"
        Label15.Size = New Size(94, 20)
        Label15.TabIndex = 20
        Label15.Text = "Service Tax :-"
        ' 
        ' TextBox13
        ' 
        TextBox13.Location = New Point(338, 10)
        TextBox13.Name = "TextBox13"
        TextBox13.Size = New Size(96, 27)
        TextBox13.TabIndex = 41
        ' 
        ' Label16
        ' 
        Label16.AutoSize = True
        Label16.Location = New Point(222, 13)
        Label16.Name = "Label16"
        Label16.Size = New Size(120, 20)
        Label16.TabIndex = 40
        Label16.Text = "Items Discount :-"
        ' 
        ' TextBox14
        ' 
        TextBox14.Location = New Point(222, 44)
        TextBox14.Name = "TextBox14"
        TextBox14.Size = New Size(96, 27)
        TextBox14.TabIndex = 42
        ' 
        ' Label17
        ' 
        Label17.AutoSize = True
        Label17.Location = New Point(228, 117)
        Label17.Name = "Label17"
        Label17.Size = New Size(90, 20)
        Label17.TabIndex = 44
        Label17.Text = "TA Charge :-"
        ' 
        ' TextBox15
        ' 
        TextBox15.Location = New Point(322, 110)
        TextBox15.Name = "TextBox15"
        TextBox15.Size = New Size(96, 27)
        TextBox15.TabIndex = 43
        ' 
        ' Label18
        ' 
        Label18.AutoSize = True
        Label18.Location = New Point(223, 146)
        Label18.Name = "Label18"
        Label18.Size = New Size(95, 20)
        Label18.TabIndex = 46
        Label18.Text = "HD Charge :-"
        ' 
        ' TextBox16
        ' 
        TextBox16.Location = New Point(324, 143)
        TextBox16.Name = "TextBox16"
        TextBox16.Size = New Size(96, 27)
        TextBox16.TabIndex = 45
        ' 
        ' Label19
        ' 
        Label19.AutoSize = True
        Label19.Location = New Point(263, 183)
        Label19.Name = "Label19"
        Label19.Size = New Size(53, 20)
        Label19.TabIndex = 48
        Label19.Text = "Cash :-"
        ' 
        ' TextBox17
        ' 
        TextBox17.Location = New Point(324, 176)
        TextBox17.Name = "TextBox17"
        TextBox17.Size = New Size(96, 27)
        TextBox17.TabIndex = 47
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.FromArgb(CByte(0), CByte(192), CByte(192))
        Button2.Location = New Point(241, 554)
        Button2.Name = "Button2"
        Button2.Size = New Size(94, 29)
        Button2.TabIndex = 40
        Button2.Text = "New Bill"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.OliveDrab
        Button3.Location = New Point(341, 554)
        Button3.Name = "Button3"
        Button3.Size = New Size(94, 29)
        Button3.TabIndex = 41
        Button3.Text = "Save"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Button4
        ' 
        Button4.BackColor = Color.IndianRed
        Button4.Location = New Point(441, 554)
        Button4.Name = "Button4"
        Button4.Size = New Size(94, 29)
        Button4.TabIndex = 42
        Button4.Text = "Cancel"
        Button4.UseVisualStyleBackColor = False
        ' 
        ' Button5
        ' 
        Button5.BackColor = Color.Khaki
        Button5.Location = New Point(541, 554)
        Button5.Name = "Button5"
        Button5.Size = New Size(94, 29)
        Button5.TabIndex = 43
        Button5.Text = "Lock"
        Button5.UseVisualStyleBackColor = False
        ' 
        ' Panel10
        ' 
        Panel10.BackColor = Color.Black
        Panel10.Location = New Point(0, 589)
        Panel10.Name = "Panel10"
        Panel10.Size = New Size(800, 11)
        Panel10.TabIndex = 44
        ' 
        ' Billings
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(Panel10)
        Controls.Add(Button5)
        Controls.Add(Button4)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Panel4)
        Controls.Add(Panel3)
        Controls.Add(DataGridView1)
        Controls.Add(ComboBox3)
        Controls.Add(Label4)
        Controls.Add(ComboBox2)
        Controls.Add(Label3)
        Controls.Add(ComboBox1)
        Controls.Add(Label5)
        Controls.Add(Label2)
        Controls.Add(Panel1)
        Controls.Add(Panel2)
        Name = "Billings"
        Size = New Size(800, 600)
        Panel1.ResumeLayout(False)
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Btnback As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents ComboBox3 As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents txt_TableNo As DataGridViewTextBoxColumn
    Friend WithEvents txt_Customer As DataGridViewTextBoxColumn
    Friend WithEvents Panel3 As Panel
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents TextBox9 As TextBox
    Friend WithEvents TextBox10 As TextBox
    Friend WithEvents TextBox11 As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents TextBox12 As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents TextBox17 As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents TextBox16 As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents TextBox15 As TextBox
    Friend WithEvents TextBox14 As TextBox
    Friend WithEvents TextBox13 As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Panel10 As Panel

End Class
