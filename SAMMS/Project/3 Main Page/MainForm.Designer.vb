<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim TreeNode1 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Asset")
        Dim TreeNode2 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Type")
        Dim TreeNode3 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Location")
        Dim TreeNode4 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Owner")
        Dim TreeNode5 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Make & Model")
        Dim TreeNode6 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Add Manually", New System.Windows.Forms.TreeNode() {TreeNode1, TreeNode2, TreeNode3, TreeNode4, TreeNode5})
        Dim TreeNode7 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Import Data")
        Dim TreeNode8 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("View Data")
        Dim TreeNode9 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Reports")
        Dim TreeNode10 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Asset")
        Dim TreeNode11 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Type")
        Dim TreeNode12 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Location")
        Dim TreeNode13 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Owner")
        Dim TreeNode14 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Make & Model")
        Dim TreeNode15 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Add Manually", New System.Windows.Forms.TreeNode() {TreeNode10, TreeNode11, TreeNode12, TreeNode13, TreeNode14})
        Dim TreeNode16 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Import Data")
        Dim TreeNode17 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("View Data")
        Dim TreeNode18 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Reports")
        Dim TreeNode19 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Add KB")
        Dim TreeNode20 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Manage Subjects")
        Dim TreeNode21 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Manage Relevance")
        Dim TreeNode22 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Manage KB's", New System.Windows.Forms.TreeNode() {TreeNode20, TreeNode21})
        Dim TreeNode23 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Add Manually", New System.Windows.Forms.TreeNode() {TreeNode19, TreeNode22})
        Dim TreeNode24 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Import Data")
        Dim TreeNode25 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("View Data")
        Dim TreeNode26 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Reports")
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.GeneralToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LoginToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SwitchUserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LockToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ChangePasswordToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ManagementToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ManageAccountsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ManageGroupsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ManagePermmisionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ManageDatabasesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TicketsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AssetsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KnowledgeDatabaseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogoutToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripContainer1 = New System.Windows.Forms.ToolStripContainer()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabAssets = New System.Windows.Forms.TabPage()
        Me.TreeView1 = New System.Windows.Forms.TreeView()
        Me.txtAssetsAdd = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnAssetQuickSearch = New System.Windows.Forms.Button()
        Me.TabTickets = New System.Windows.Forms.TabPage()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TreeView2 = New System.Windows.Forms.TreeView()
        Me.TbKnowledgeDB = New System.Windows.Forms.TabPage()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TreeKB = New System.Windows.Forms.TreeView()
        Me.MenuStrip1.SuspendLayout()
        Me.ToolStripContainer1.ContentPanel.SuspendLayout()
        Me.ToolStripContainer1.TopToolStripPanel.SuspendLayout()
        Me.ToolStripContainer1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabAssets.SuspendLayout()
        Me.TabTickets.SuspendLayout()
        Me.TbKnowledgeDB.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 15.0!)
        Me.MenuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GeneralToolStripMenuItem, Me.ManagementToolStripMenuItem, Me.HelpToolStripMenuItem, Me.LogoutToolStripMenuItem1})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1016, 29)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'GeneralToolStripMenuItem
        '
        Me.GeneralToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LoginToolStripMenuItem, Me.SwitchUserToolStripMenuItem, Me.LockToolStripMenuItem, Me.ToolStripSeparator1, Me.ChangePasswordToolStripMenuItem, Me.ToolStripSeparator2, Me.ExitToolStripMenuItem})
        Me.GeneralToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.GeneralToolStripMenuItem.Name = "GeneralToolStripMenuItem"
        Me.GeneralToolStripMenuItem.Size = New System.Drawing.Size(76, 25)
        Me.GeneralToolStripMenuItem.Text = "General"
        '
        'LoginToolStripMenuItem
        '
        Me.LoginToolStripMenuItem.Name = "LoginToolStripMenuItem"
        Me.LoginToolStripMenuItem.Size = New System.Drawing.Size(203, 26)
        Me.LoginToolStripMenuItem.Text = "Login"
        '
        'SwitchUserToolStripMenuItem
        '
        Me.SwitchUserToolStripMenuItem.Name = "SwitchUserToolStripMenuItem"
        Me.SwitchUserToolStripMenuItem.Size = New System.Drawing.Size(203, 26)
        Me.SwitchUserToolStripMenuItem.Text = "Switch User"
        '
        'LockToolStripMenuItem
        '
        Me.LockToolStripMenuItem.Name = "LockToolStripMenuItem"
        Me.LockToolStripMenuItem.Size = New System.Drawing.Size(203, 26)
        Me.LockToolStripMenuItem.Text = "Lock"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(200, 6)
        '
        'ChangePasswordToolStripMenuItem
        '
        Me.ChangePasswordToolStripMenuItem.Name = "ChangePasswordToolStripMenuItem"
        Me.ChangePasswordToolStripMenuItem.Size = New System.Drawing.Size(203, 26)
        Me.ChangePasswordToolStripMenuItem.Text = "Change Password"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(200, 6)
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(203, 26)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'ManagementToolStripMenuItem
        '
        Me.ManagementToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ManageAccountsToolStripMenuItem, Me.ManageGroupsToolStripMenuItem, Me.ManagePermmisionsToolStripMenuItem, Me.ManageDatabasesToolStripMenuItem})
        Me.ManagementToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.ManagementToolStripMenuItem.Name = "ManagementToolStripMenuItem"
        Me.ManagementToolStripMenuItem.Size = New System.Drawing.Size(114, 25)
        Me.ManagementToolStripMenuItem.Text = "Management"
        Me.ManagementToolStripMenuItem.Visible = False
        '
        'ManageAccountsToolStripMenuItem
        '
        Me.ManageAccountsToolStripMenuItem.Name = "ManageAccountsToolStripMenuItem"
        Me.ManageAccountsToolStripMenuItem.Size = New System.Drawing.Size(230, 26)
        Me.ManageAccountsToolStripMenuItem.Text = "Manage Accounts"
        '
        'ManageGroupsToolStripMenuItem
        '
        Me.ManageGroupsToolStripMenuItem.Name = "ManageGroupsToolStripMenuItem"
        Me.ManageGroupsToolStripMenuItem.Size = New System.Drawing.Size(230, 26)
        Me.ManageGroupsToolStripMenuItem.Text = "Manage Groups"
        '
        'ManagePermmisionsToolStripMenuItem
        '
        Me.ManagePermmisionsToolStripMenuItem.Name = "ManagePermmisionsToolStripMenuItem"
        Me.ManagePermmisionsToolStripMenuItem.Size = New System.Drawing.Size(230, 26)
        Me.ManagePermmisionsToolStripMenuItem.Text = "Manage Permmisions"
        '
        'ManageDatabasesToolStripMenuItem
        '
        Me.ManageDatabasesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TicketsToolStripMenuItem, Me.AssetsToolStripMenuItem, Me.KnowledgeDatabaseToolStripMenuItem})
        Me.ManageDatabasesToolStripMenuItem.Name = "ManageDatabasesToolStripMenuItem"
        Me.ManageDatabasesToolStripMenuItem.Size = New System.Drawing.Size(230, 26)
        Me.ManageDatabasesToolStripMenuItem.Text = "Manage Databases"
        '
        'TicketsToolStripMenuItem
        '
        Me.TicketsToolStripMenuItem.Name = "TicketsToolStripMenuItem"
        Me.TicketsToolStripMenuItem.Size = New System.Drawing.Size(225, 26)
        Me.TicketsToolStripMenuItem.Text = "Tickets"
        '
        'AssetsToolStripMenuItem
        '
        Me.AssetsToolStripMenuItem.Name = "AssetsToolStripMenuItem"
        Me.AssetsToolStripMenuItem.Size = New System.Drawing.Size(225, 26)
        Me.AssetsToolStripMenuItem.Text = "Assets"
        '
        'KnowledgeDatabaseToolStripMenuItem
        '
        Me.KnowledgeDatabaseToolStripMenuItem.Name = "KnowledgeDatabaseToolStripMenuItem"
        Me.KnowledgeDatabaseToolStripMenuItem.Size = New System.Drawing.Size(225, 26)
        Me.KnowledgeDatabaseToolStripMenuItem.Text = "Knowledge Database"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(54, 25)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'LogoutToolStripMenuItem1
        '
        Me.LogoutToolStripMenuItem1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.LogoutToolStripMenuItem1.Name = "LogoutToolStripMenuItem1"
        Me.LogoutToolStripMenuItem1.Size = New System.Drawing.Size(71, 25)
        Me.LogoutToolStripMenuItem1.Text = "Logout"
        '
        'ToolStripContainer1
        '
        '
        'ToolStripContainer1.ContentPanel
        '
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.Panel1)
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.TabControl1)
        Me.ToolStripContainer1.ContentPanel.Size = New System.Drawing.Size(1016, 573)
        Me.ToolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        '
        'ToolStripContainer1.LeftToolStripPanel
        '
        Me.ToolStripContainer1.LeftToolStripPanel.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.ToolStripContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStripContainer1.Name = "ToolStripContainer1"
        Me.ToolStripContainer1.Size = New System.Drawing.Size(1016, 602)
        Me.ToolStripContainer1.TabIndex = 1
        Me.ToolStripContainer1.Text = "ToolStripContainer1"
        '
        'ToolStripContainer1.TopToolStripPanel
        '
        Me.ToolStripContainer1.TopToolStripPanel.Controls.Add(Me.MenuStrip1)
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Window
        Me.Panel1.Location = New System.Drawing.Point(258, 25)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(755, 541)
        Me.Panel1.TabIndex = 1
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabAssets)
        Me.TabControl1.Controls.Add(Me.TabTickets)
        Me.TabControl1.Controls.Add(Me.TbKnowledgeDB)
        Me.TabControl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.TabControl1.Location = New System.Drawing.Point(3, 3)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(249, 567)
        Me.TabControl1.TabIndex = 0
        '
        'TabAssets
        '
        Me.TabAssets.Controls.Add(Me.TreeView1)
        Me.TabAssets.Controls.Add(Me.txtAssetsAdd)
        Me.TabAssets.Controls.Add(Me.TextBox1)
        Me.TabAssets.Controls.Add(Me.Label1)
        Me.TabAssets.Controls.Add(Me.btnAssetQuickSearch)
        Me.TabAssets.Location = New System.Drawing.Point(4, 25)
        Me.TabAssets.Name = "TabAssets"
        Me.TabAssets.Padding = New System.Windows.Forms.Padding(3)
        Me.TabAssets.Size = New System.Drawing.Size(241, 538)
        Me.TabAssets.TabIndex = 0
        Me.TabAssets.Text = "Assets"
        Me.TabAssets.UseVisualStyleBackColor = True
        '
        'TreeView1
        '
        Me.TreeView1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.TreeView1.Location = New System.Drawing.Point(6, 45)
        Me.TreeView1.Name = "TreeView1"
        TreeNode1.Name = "Asset"
        TreeNode1.Text = "Asset"
        TreeNode2.Name = "Type"
        TreeNode2.Text = "Type"
        TreeNode3.Name = "Location"
        TreeNode3.Text = "Location"
        TreeNode4.Name = "Owner"
        TreeNode4.Text = "Owner"
        TreeNode5.Name = "Make & Model"
        TreeNode5.Text = "Make & Model"
        TreeNode6.Name = "Add Manually"
        TreeNode6.Text = "Add Manually"
        TreeNode7.Name = "Import Data"
        TreeNode7.Text = "Import Data"
        TreeNode8.Name = "View Data"
        TreeNode8.Text = "View Data"
        TreeNode9.Name = "Reports"
        TreeNode9.Text = "Reports"
        Me.TreeView1.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode6, TreeNode7, TreeNode8, TreeNode9})
        Me.TreeView1.Size = New System.Drawing.Size(229, 377)
        Me.TreeView1.TabIndex = 6
        '
        'txtAssetsAdd
        '
        Me.txtAssetsAdd.AutoSize = True
        Me.txtAssetsAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.txtAssetsAdd.Location = New System.Drawing.Point(45, 8)
        Me.txtAssetsAdd.Name = "txtAssetsAdd"
        Me.txtAssetsAdd.Size = New System.Drawing.Size(140, 25)
        Me.txtAssetsAdd.TabIndex = 3
        Me.txtAssetsAdd.Text = "Quick Manage"
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.TextBox1.Location = New System.Drawing.Point(19, 462)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(200, 30)
        Me.TextBox1.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.Label1.Location = New System.Drawing.Point(51, 425)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(131, 25)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Quick Search"
        '
        'btnAssetQuickSearch
        '
        Me.btnAssetQuickSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.btnAssetQuickSearch.Location = New System.Drawing.Point(69, 498)
        Me.btnAssetQuickSearch.Name = "btnAssetQuickSearch"
        Me.btnAssetQuickSearch.Size = New System.Drawing.Size(97, 37)
        Me.btnAssetQuickSearch.TabIndex = 0
        Me.btnAssetQuickSearch.Text = "Search"
        Me.btnAssetQuickSearch.UseVisualStyleBackColor = True
        '
        'TabTickets
        '
        Me.TabTickets.Controls.Add(Me.TextBox2)
        Me.TabTickets.Controls.Add(Me.Label4)
        Me.TabTickets.Controls.Add(Me.Button1)
        Me.TabTickets.Controls.Add(Me.Label2)
        Me.TabTickets.Controls.Add(Me.TreeView2)
        Me.TabTickets.Location = New System.Drawing.Point(4, 25)
        Me.TabTickets.Name = "TabTickets"
        Me.TabTickets.Padding = New System.Windows.Forms.Padding(3)
        Me.TabTickets.Size = New System.Drawing.Size(241, 538)
        Me.TabTickets.TabIndex = 1
        Me.TabTickets.Text = "Tickets"
        Me.TabTickets.UseVisualStyleBackColor = True
        '
        'TextBox2
        '
        Me.TextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.TextBox2.Location = New System.Drawing.Point(22, 462)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(200, 30)
        Me.TextBox2.TabIndex = 11
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.Label4.Location = New System.Drawing.Point(54, 425)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(131, 25)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Quick Search"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.Button1.Location = New System.Drawing.Point(72, 498)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(97, 37)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "Search"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.Label2.Location = New System.Drawing.Point(45, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(140, 25)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Quick Manage"
        '
        'TreeView2
        '
        Me.TreeView2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.TreeView2.Location = New System.Drawing.Point(6, 45)
        Me.TreeView2.Name = "TreeView2"
        TreeNode10.Name = "Asset"
        TreeNode10.Text = "Asset"
        TreeNode11.Name = "Type"
        TreeNode11.Text = "Type"
        TreeNode12.Name = "Location"
        TreeNode12.Text = "Location"
        TreeNode13.Name = "Owner"
        TreeNode13.Text = "Owner"
        TreeNode14.Name = "Make & Model"
        TreeNode14.Text = "Make & Model"
        TreeNode15.Name = "Add Manually"
        TreeNode15.Text = "Add Manually"
        TreeNode16.Name = "Import Data"
        TreeNode16.Text = "Import Data"
        TreeNode17.Name = "View Data"
        TreeNode17.Text = "View Data"
        TreeNode18.Name = "Reports"
        TreeNode18.Text = "Reports"
        Me.TreeView2.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode15, TreeNode16, TreeNode17, TreeNode18})
        Me.TreeView2.Size = New System.Drawing.Size(229, 377)
        Me.TreeView2.TabIndex = 7
        '
        'TbKnowledgeDB
        '
        Me.TbKnowledgeDB.Controls.Add(Me.TextBox3)
        Me.TbKnowledgeDB.Controls.Add(Me.Label5)
        Me.TbKnowledgeDB.Controls.Add(Me.Button2)
        Me.TbKnowledgeDB.Controls.Add(Me.Label3)
        Me.TbKnowledgeDB.Controls.Add(Me.TreeKB)
        Me.TbKnowledgeDB.Location = New System.Drawing.Point(4, 25)
        Me.TbKnowledgeDB.Name = "TbKnowledgeDB"
        Me.TbKnowledgeDB.Padding = New System.Windows.Forms.Padding(3)
        Me.TbKnowledgeDB.Size = New System.Drawing.Size(241, 538)
        Me.TbKnowledgeDB.TabIndex = 2
        Me.TbKnowledgeDB.Text = "Knowledge DB"
        Me.TbKnowledgeDB.UseVisualStyleBackColor = True
        '
        'TextBox3
        '
        Me.TextBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.TextBox3.Location = New System.Drawing.Point(17, 462)
        Me.TextBox3.Multiline = True
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(200, 30)
        Me.TextBox3.TabIndex = 11
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.Label5.Location = New System.Drawing.Point(49, 425)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(131, 25)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Quick Search"
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.Button2.Location = New System.Drawing.Point(67, 498)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(97, 37)
        Me.Button2.TabIndex = 9
        Me.Button2.Text = "Search"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.Label3.Location = New System.Drawing.Point(45, 8)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(140, 25)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Quick Manage"
        '
        'TreeKB
        '
        Me.TreeKB.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.TreeKB.Location = New System.Drawing.Point(6, 45)
        Me.TreeKB.Name = "TreeKB"
        TreeNode19.Name = "NodeAddKB"
        TreeNode19.Tag = "NodeAddKB"
        TreeNode19.Text = "Add KB"
        TreeNode20.Name = "NodeSubjectKB"
        TreeNode20.Tag = "NodeSubjectsKB"
        TreeNode20.Text = "Manage Subjects"
        TreeNode21.Name = "NodeManageRelevance"
        TreeNode21.Tag = "NodeManageRelevance"
        TreeNode21.Text = "Manage Relevance"
        TreeNode22.Name = "NodeManageKB"
        TreeNode22.Tag = "NodeManageKB"
        TreeNode22.Text = "Manage KB's"
        TreeNode23.Name = "NodeAddManuallyKB"
        TreeNode23.Tag = "NodeAddManuallyKB"
        TreeNode23.Text = "Add Manually"
        TreeNode24.Name = "NodeImportDataKB"
        TreeNode24.Text = "Import Data"
        TreeNode25.Name = "NodeViewDataKB"
        TreeNode25.Text = "View Data"
        TreeNode26.Name = "NodeReportsKB"
        TreeNode26.Text = "Reports"
        Me.TreeKB.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode23, TreeNode24, TreeNode25, TreeNode26})
        Me.TreeKB.Size = New System.Drawing.Size(229, 377)
        Me.TreeKB.TabIndex = 7
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(1016, 602)
        Me.Controls.Add(Me.ToolStripContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "MainForm"
        Me.Text = "MainForm"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ToolStripContainer1.ContentPanel.ResumeLayout(False)
        Me.ToolStripContainer1.TopToolStripPanel.ResumeLayout(False)
        Me.ToolStripContainer1.TopToolStripPanel.PerformLayout()
        Me.ToolStripContainer1.ResumeLayout(False)
        Me.ToolStripContainer1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabAssets.ResumeLayout(False)
        Me.TabAssets.PerformLayout()
        Me.TabTickets.ResumeLayout(False)
        Me.TabTickets.PerformLayout()
        Me.TbKnowledgeDB.ResumeLayout(False)
        Me.TbKnowledgeDB.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents GeneralToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LoginToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SwitchUserToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LockToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ChangePasswordToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ManagementToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ManageAccountsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ManageGroupsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ManagePermmisionsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ManageDatabasesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TicketsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AssetsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents KnowledgeDatabaseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LogoutToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ToolStripContainer1 As ToolStripContainer
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabAssets As TabPage
    Friend WithEvents TabTickets As TabPage
    Friend WithEvents TbKnowledgeDB As TabPage
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnAssetQuickSearch As Button
    Friend WithEvents txtAssetsAdd As Label
    Friend WithEvents TreeView1 As TreeView
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents TreeView2 As TreeView
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents TreeKB As TreeView
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
End Class
