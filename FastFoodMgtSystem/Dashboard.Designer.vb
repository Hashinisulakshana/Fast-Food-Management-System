<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Dashboard
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Dashboard))
        Label10 = New Label()
        Label9 = New Label()
        Label8 = New Label()
        PictureBox12 = New PictureBox()
        Panel5 = New Panel()
        Label6 = New Label()
        PictureBox15 = New PictureBox()
        Panel8 = New Panel()
        PictureBox11 = New PictureBox()
        PictureBox3 = New PictureBox()
        Panel7 = New Panel()
        Panel9 = New Panel()
        Label5 = New Label()
        Panel6 = New Panel()
        Label7 = New Label()
        PictureBox13 = New PictureBox()
        CType(PictureBox12, ComponentModel.ISupportInitialize).BeginInit()
        Panel5.SuspendLayout()
        CType(PictureBox15, ComponentModel.ISupportInitialize).BeginInit()
        Panel8.SuspendLayout()
        CType(PictureBox11, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        Panel7.SuspendLayout()
        Panel9.SuspendLayout()
        Panel6.SuspendLayout()
        CType(PictureBox13, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.ForeColor = Color.Transparent
        Label10.Location = New Point(33, 34)
        Label10.Name = "Label10"
        Label10.Size = New Size(115, 20)
        Label10.TabIndex = 2
        Label10.Text = "Rejected Orders"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.ForeColor = Color.Transparent
        Label9.Location = New Point(18, 34)
        Label9.Name = "Label9"
        Label9.Size = New Size(121, 20)
        Label9.TabIndex = 3
        Label9.Text = "Delivered Orders"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.ForeColor = Color.Transparent
        Label8.Location = New Point(6, 32)
        Label8.Name = "Label8"
        Label8.Size = New Size(110, 20)
        Label8.TabIndex = 2
        Label8.Text = "Pending Orders"
        ' 
        ' PictureBox12
        ' 
        PictureBox12.BackColor = Color.RosyBrown
        PictureBox12.BackgroundImage = CType(resources.GetObject("PictureBox12.BackgroundImage"), Image)
        PictureBox12.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox12.Location = New Point(523, 102)
        PictureBox12.Name = "PictureBox12"
        PictureBox12.Size = New Size(62, 61)
        PictureBox12.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox12.TabIndex = 20
        PictureBox12.TabStop = False
        ' 
        ' Panel5
        ' 
        Panel5.BackColor = Color.FromArgb(CByte(5), CByte(25), CByte(30))
        Panel5.Controls.Add(Label6)
        Panel5.ForeColor = Color.Transparent
        Panel5.Location = New Point(73, 134)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(165, 100)
        Panel5.TabIndex = 14
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.ForeColor = Color.Transparent
        Label6.Location = New Point(14, 32)
        Label6.Name = "Label6"
        Label6.Size = New Size(90, 20)
        Label6.TabIndex = 0
        Label6.Text = "Total Orders"
        ' 
        ' PictureBox15
        ' 
        PictureBox15.BackColor = Color.RosyBrown
        PictureBox15.BackgroundImage = CType(resources.GetObject("PictureBox15.BackgroundImage"), Image)
        PictureBox15.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox15.Location = New Point(410, 263)
        PictureBox15.Name = "PictureBox15"
        PictureBox15.Size = New Size(52, 59)
        PictureBox15.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox15.TabIndex = 24
        PictureBox15.TabStop = False
        ' 
        ' Panel8
        ' 
        Panel8.BackColor = Color.FromArgb(CByte(5), CByte(25), CByte(30))
        Panel8.Controls.Add(Label10)
        Panel8.Location = New Point(396, 291)
        Panel8.Name = "Panel8"
        Panel8.Size = New Size(165, 100)
        Panel8.TabIndex = 23
        ' 
        ' PictureBox11
        ' 
        PictureBox11.BackColor = Color.RosyBrown
        PictureBox11.BackgroundImage = CType(resources.GetObject("PictureBox11.BackgroundImage"), Image)
        PictureBox11.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox11.Location = New Point(160, 261)
        PictureBox11.Name = "PictureBox11"
        PictureBox11.Size = New Size(52, 61)
        PictureBox11.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox11.TabIndex = 19
        PictureBox11.TabStop = False
        ' 
        ' PictureBox3
        ' 
        PictureBox3.BackColor = Color.RosyBrown
        PictureBox3.BackgroundImage = CType(resources.GetObject("PictureBox3.BackgroundImage"), Image)
        PictureBox3.Location = New Point(87, 92)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(59, 61)
        PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox3.TabIndex = 18
        PictureBox3.TabStop = False
        ' 
        ' Panel7
        ' 
        Panel7.BackColor = Color.FromArgb(CByte(5), CByte(25), CByte(30))
        Panel7.Controls.Add(Label8)
        Panel7.Location = New Point(508, 134)
        Panel7.Name = "Panel7"
        Panel7.Size = New Size(165, 100)
        Panel7.TabIndex = 16
        ' 
        ' Panel9
        ' 
        Panel9.BackColor = Color.FromArgb(CByte(5), CByte(25), CByte(30))
        Panel9.Controls.Add(Label9)
        Panel9.Location = New Point(142, 291)
        Panel9.Name = "Panel9"
        Panel9.Size = New Size(165, 100)
        Panel9.TabIndex = 17
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = SystemColors.ControlDarkDark
        Label5.Location = New Point(37, 32)
        Label5.Name = "Label5"
        Label5.Size = New Size(126, 31)
        Label5.TabIndex = 13
        Label5.Text = "Dashboard"
        ' 
        ' Panel6
        ' 
        Panel6.BackColor = Color.FromArgb(CByte(5), CByte(25), CByte(30))
        Panel6.Controls.Add(Label7)
        Panel6.Location = New Point(307, 134)
        Panel6.Name = "Panel6"
        Panel6.Size = New Size(165, 100)
        Panel6.TabIndex = 25
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.ForeColor = Color.Transparent
        Label7.Location = New Point(12, 32)
        Label7.Name = "Label7"
        Label7.Size = New Size(80, 20)
        Label7.TabIndex = 1
        Label7.Text = "Total Sales"
        ' 
        ' PictureBox13
        ' 
        PictureBox13.BackColor = Color.RosyBrown
        PictureBox13.Image = CType(resources.GetObject("PictureBox13.Image"), Image)
        PictureBox13.Location = New Point(319, 92)
        PictureBox13.Name = "PictureBox13"
        PictureBox13.Size = New Size(59, 61)
        PictureBox13.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox13.TabIndex = 26
        PictureBox13.TabStop = False
        ' 
        ' Dashboard
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(Panel6)
        Controls.Add(PictureBox13)
        Controls.Add(PictureBox12)
        Controls.Add(Panel5)
        Controls.Add(PictureBox15)
        Controls.Add(Panel8)
        Controls.Add(PictureBox11)
        Controls.Add(PictureBox3)
        Controls.Add(Panel7)
        Controls.Add(Panel9)
        Controls.Add(Label5)
        Name = "Dashboard"
        Size = New Size(798, 450)
        CType(PictureBox12, ComponentModel.ISupportInitialize).EndInit()
        Panel5.ResumeLayout(False)
        Panel5.PerformLayout()
        CType(PictureBox15, ComponentModel.ISupportInitialize).EndInit()
        Panel8.ResumeLayout(False)
        Panel8.PerformLayout()
        CType(PictureBox11, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        Panel7.ResumeLayout(False)
        Panel7.PerformLayout()
        Panel9.ResumeLayout(False)
        Panel9.PerformLayout()
        Panel6.ResumeLayout(False)
        Panel6.PerformLayout()
        CType(PictureBox13, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents PictureBox12 As PictureBox
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents PictureBox15 As PictureBox
    Friend WithEvents Panel8 As Panel
    Friend WithEvents PictureBox11 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Panel9 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents PictureBox13 As PictureBox

End Class
