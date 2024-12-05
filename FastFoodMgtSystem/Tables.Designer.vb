<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Tables
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Tables))
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Panel1 = New Panel()
        Btnback = New Button()
        Button1 = New Button()
        Panel2 = New Panel()
        Label1 = New Label()
        DataGridView1 = New DataGridView()
        txt_tableno = New DataGridViewTextBoxColumn()
        txt_TableType = New DataGridViewTextBoxColumn()
        txt_Status = New DataGridViewTextBoxColumn()
        Panel3 = New Panel()
        Button4 = New Button()
        ComboBox1 = New ComboBox()
        Label3 = New Label()
        Btnopen = New Button()
        Button3 = New Button()
        Button2 = New Button()
        TextBox1 = New TextBox()
        Label2 = New Label()
        Panel10 = New Panel()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
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
        Panel1.TabIndex = 20
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
        Panel2.TabIndex = 21
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(323, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(62, 28)
        Label1.TabIndex = 2
        Label1.Text = "Table"
        Label1.TextAlign = ContentAlignment.TopCenter
        ' 
        ' DataGridView1
        ' 
        DataGridView1.BackgroundColor = Color.White
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {txt_tableno, txt_TableType, txt_Status})
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = SystemColors.Window
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 12F)
        DataGridViewCellStyle2.ForeColor = SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.False
        DataGridView1.DefaultCellStyle = DataGridViewCellStyle2
        DataGridView1.Location = New Point(16, 252)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.Size = New Size(434, 221)
        DataGridView1.TabIndex = 23
        ' 
        ' txt_tableno
        ' 
        txt_tableno.AutoSizeMode = DataGridViewAutoSizeColumnMode.None
        txt_tableno.HeaderText = "Table No"
        txt_tableno.MinimumWidth = 6
        txt_tableno.Name = "txt_tableno"
        txt_tableno.Width = 125
        ' 
        ' txt_TableType
        ' 
        txt_TableType.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader
        txt_TableType.HeaderText = "TableType"
        txt_TableType.MinimumWidth = 6
        txt_TableType.Name = "txt_TableType"
        txt_TableType.Width = 104
        ' 
        ' txt_Status
        ' 
        txt_Status.HeaderText = "Status"
        txt_Status.MinimumWidth = 6
        txt_Status.Name = "txt_Status"
        txt_Status.Width = 125
        ' 
        ' Panel3
        ' 
        Panel3.Controls.Add(Button4)
        Panel3.Controls.Add(ComboBox1)
        Panel3.Controls.Add(Label3)
        Panel3.Controls.Add(Btnopen)
        Panel3.Controls.Add(Button3)
        Panel3.Controls.Add(Button2)
        Panel3.Controls.Add(TextBox1)
        Panel3.Controls.Add(Label2)
        Panel3.Location = New Point(13, 110)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(770, 114)
        Panel3.TabIndex = 22
        ' 
        ' Button4
        ' 
        Button4.BackColor = Color.DarkSeaGreen
        Button4.Font = New Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button4.Location = New Point(343, 38)
        Button4.Name = "Button4"
        Button4.Size = New Size(137, 29)
        Button4.TabIndex = 24
        Button4.Text = "Activate/Deactivate"
        Button4.UseVisualStyleBackColor = False
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(155, 40)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(179, 28)
        ComboBox1.TabIndex = 23
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(31, 52)
        Label3.Name = "Label3"
        Label3.Size = New Size(92, 20)
        Label3.TabIndex = 22
        Label3.Text = "Table Type :-"
        ' 
        ' Btnopen
        ' 
        Btnopen.BackColor = Color.Black
        Btnopen.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Btnopen.ForeColor = Color.White
        Btnopen.Image = CType(resources.GetObject("Btnopen.Image"), Image)
        Btnopen.ImageAlign = ContentAlignment.MiddleLeft
        Btnopen.Location = New Point(554, 73)
        Btnopen.Name = "Btnopen"
        Btnopen.Size = New Size(94, 29)
        Btnopen.TabIndex = 21
        Btnopen.Text = "Delete"
        Btnopen.TextAlign = ContentAlignment.MiddleRight
        Btnopen.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.Black
        Button3.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button3.ForeColor = Color.White
        Button3.Image = CType(resources.GetObject("Button3.Image"), Image)
        Button3.ImageAlign = ContentAlignment.MiddleLeft
        Button3.Location = New Point(431, 73)
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
        Button2.Location = New Point(322, 73)
        Button2.Name = "Button2"
        Button2.Size = New Size(77, 29)
        Button2.TabIndex = 18
        Button2.Text = "Save"
        Button2.TextAlign = ContentAlignment.MiddleRight
        Button2.UseVisualStyleBackColor = False
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(155, 7)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(179, 27)
        TextBox1.TabIndex = 1
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(31, 14)
        Label2.Name = "Label2"
        Label2.Size = New Size(81, 20)
        Label2.TabIndex = 0
        Label2.Text = "Table No :-"
        ' 
        ' Panel10
        ' 
        Panel10.BackColor = Color.Black
        Panel10.Location = New Point(0, 482)
        Panel10.Name = "Panel10"
        Panel10.Size = New Size(797, 11)
        Panel10.TabIndex = 29
        ' 
        ' Tables
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(Panel10)
        Controls.Add(DataGridView1)
        Controls.Add(Panel3)
        Controls.Add(Panel1)
        Controls.Add(Panel2)
        Name = "Tables"
        Size = New Size(797, 493)
        Panel1.ResumeLayout(False)
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Btnback As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Btnopen As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Button4 As Button
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_tableno As DataGridViewTextBoxColumn
    Friend WithEvents txt_TableType As DataGridViewTextBoxColumn
    Friend WithEvents txt_Status As DataGridViewTextBoxColumn
    Friend WithEvents Panel10 As Panel

End Class
