<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MasterEntry
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MasterEntry))
        Label1 = New Label()
        ImportExport = New Panel()
        Notes = New Panel()
        Tables = New Panel()
        Menuitems = New Panel()
        Itemscategory = New Panel()
        InventoryType = New Panel()
        KitchenMaster = New Panel()
        Restaurantinfo = New Panel()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        Label9 = New Label()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.AppWorkspace
        Label1.Location = New Point(26, 43)
        Label1.Name = "Label1"
        Label1.Size = New Size(184, 41)
        Label1.TabIndex = 11
        Label1.Text = "Master Entry"
        ' 
        ' ImportExport
        ' 
        ImportExport.BackColor = Color.Black
        ImportExport.BackgroundImage = CType(resources.GetObject("ImportExport.BackgroundImage"), Image)
        ImportExport.BackgroundImageLayout = ImageLayout.Center
        ImportExport.BorderStyle = BorderStyle.FixedSingle
        ImportExport.Location = New Point(622, 276)
        ImportExport.Name = "ImportExport"
        ImportExport.Size = New Size(147, 103)
        ImportExport.TabIndex = 4
        ' 
        ' Notes
        ' 
        Notes.BackColor = Color.Black
        Notes.BackgroundImage = CType(resources.GetObject("Notes.BackgroundImage"), Image)
        Notes.BackgroundImageLayout = ImageLayout.Center
        Notes.BorderStyle = BorderStyle.FixedSingle
        Notes.Location = New Point(445, 276)
        Notes.Name = "Notes"
        Notes.Size = New Size(147, 103)
        Notes.TabIndex = 5
        ' 
        ' Tables
        ' 
        Tables.BackColor = Color.Black
        Tables.BackgroundImage = CType(resources.GetObject("Tables.BackgroundImage"), Image)
        Tables.BackgroundImageLayout = ImageLayout.Center
        Tables.BorderStyle = BorderStyle.FixedSingle
        Tables.Location = New Point(272, 276)
        Tables.Name = "Tables"
        Tables.Size = New Size(147, 103)
        Tables.TabIndex = 6
        ' 
        ' Menuitems
        ' 
        Menuitems.BackColor = Color.Black
        Menuitems.BackgroundImage = CType(resources.GetObject("Menuitems.BackgroundImage"), Image)
        Menuitems.BackgroundImageLayout = ImageLayout.Center
        Menuitems.BorderStyle = BorderStyle.FixedSingle
        Menuitems.Location = New Point(95, 276)
        Menuitems.Name = "Menuitems"
        Menuitems.Size = New Size(147, 103)
        Menuitems.TabIndex = 7
        ' 
        ' Itemscategory
        ' 
        Itemscategory.BackColor = Color.Black
        Itemscategory.BackgroundImage = CType(resources.GetObject("Itemscategory.BackgroundImage"), Image)
        Itemscategory.BackgroundImageLayout = ImageLayout.Center
        Itemscategory.BorderStyle = BorderStyle.FixedSingle
        Itemscategory.Location = New Point(622, 87)
        Itemscategory.Name = "Itemscategory"
        Itemscategory.Size = New Size(147, 103)
        Itemscategory.TabIndex = 8
        ' 
        ' InventoryType
        ' 
        InventoryType.BackColor = Color.Black
        InventoryType.BackgroundImage = CType(resources.GetObject("InventoryType.BackgroundImage"), Image)
        InventoryType.BackgroundImageLayout = ImageLayout.Center
        InventoryType.BorderStyle = BorderStyle.FixedSingle
        InventoryType.Location = New Point(445, 87)
        InventoryType.Name = "InventoryType"
        InventoryType.Size = New Size(147, 103)
        InventoryType.TabIndex = 9
        ' 
        ' KitchenMaster
        ' 
        KitchenMaster.BackColor = Color.Black
        KitchenMaster.BackgroundImage = CType(resources.GetObject("KitchenMaster.BackgroundImage"), Image)
        KitchenMaster.BackgroundImageLayout = ImageLayout.Center
        KitchenMaster.BorderStyle = BorderStyle.FixedSingle
        KitchenMaster.Location = New Point(272, 87)
        KitchenMaster.Name = "KitchenMaster"
        KitchenMaster.Size = New Size(147, 103)
        KitchenMaster.TabIndex = 10
        ' 
        ' Restaurantinfo
        ' 
        Restaurantinfo.BackColor = Color.Black
        Restaurantinfo.BackgroundImage = CType(resources.GetObject("Restaurantinfo.BackgroundImage"), Image)
        Restaurantinfo.BackgroundImageLayout = ImageLayout.Center
        Restaurantinfo.BorderStyle = BorderStyle.FixedSingle
        Restaurantinfo.Location = New Point(95, 87)
        Restaurantinfo.Name = "Restaurantinfo"
        Restaurantinfo.Size = New Size(147, 103)
        Restaurantinfo.TabIndex = 3
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BorderStyle = BorderStyle.Fixed3D
        Label2.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(107, 206)
        Label2.Name = "Label2"
        Label2.Size = New Size(129, 25)
        Label2.TabIndex = 12
        Label2.Text = "Restaurent Info"
        Label2.TextAlign = ContentAlignment.TopCenter
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BorderStyle = BorderStyle.Fixed3D
        Label3.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(451, 206)
        Label3.Name = "Label3"
        Label3.Size = New Size(124, 25)
        Label3.TabIndex = 13
        Label3.Text = "Inventory Type"
        Label3.TextAlign = ContentAlignment.TopCenter
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BorderStyle = BorderStyle.Fixed3D
        Label4.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(612, 395)
        Label4.Name = "Label4"
        Label4.Size = New Size(160, 25)
        Label4.TabIndex = 14
        Label4.Text = "Menu Items Import"
        Label4.TextAlign = ContentAlignment.TopCenter
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BorderStyle = BorderStyle.Fixed3D
        Label5.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(623, 206)
        Label5.Name = "Label5"
        Label5.Size = New Size(128, 25)
        Label5.TabIndex = 15
        Label5.Text = "Items Category"
        Label5.TextAlign = ContentAlignment.TopCenter
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BorderStyle = BorderStyle.Fixed3D
        Label6.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(482, 395)
        Label6.Name = "Label6"
        Label6.Size = New Size(57, 25)
        Label6.TabIndex = 16
        Label6.Text = "Notes"
        Label6.TextAlign = ContentAlignment.TopCenter
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BorderStyle = BorderStyle.Fixed3D
        Label7.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(308, 395)
        Label7.Name = "Label7"
        Label7.Size = New Size(58, 25)
        Label7.TabIndex = 17
        Label7.Text = "Tables"
        Label7.TextAlign = ContentAlignment.TopCenter
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.BorderStyle = BorderStyle.Fixed3D
        Label8.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label8.Location = New Point(107, 395)
        Label8.Name = "Label8"
        Label8.Size = New Size(103, 25)
        Label8.TabIndex = 18
        Label8.Text = "Menu Items"
        Label8.TextAlign = ContentAlignment.TopCenter
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.BorderStyle = BorderStyle.Fixed3D
        Label9.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label9.Location = New Point(278, 206)
        Label9.Name = "Label9"
        Label9.Size = New Size(126, 25)
        Label9.TabIndex = 19
        Label9.Text = "Kitchen Master"
        Label9.TextAlign = ContentAlignment.TopCenter
        ' 
        ' MasterEntry
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BorderStyle = BorderStyle.Fixed3D
        Controls.Add(Label9)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(ImportExport)
        Controls.Add(Notes)
        Controls.Add(Tables)
        Controls.Add(Menuitems)
        Controls.Add(Itemscategory)
        Controls.Add(InventoryType)
        Controls.Add(KitchenMaster)
        Controls.Add(Restaurantinfo)
        Name = "MasterEntry"
        Size = New Size(794, 446)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents ImportExport As Panel
    Friend WithEvents Notes As Panel
    Friend WithEvents Tables As Panel
    Friend WithEvents Menuitems As Panel
    Friend WithEvents Itemscategory As Panel
    Friend WithEvents InventoryType As Panel
    Friend WithEvents KitchenMaster As Panel
    Friend WithEvents Restaurantinfo As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label

End Class
