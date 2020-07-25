<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNeutrino
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmNeutrino))
        Me.NeutrinoWB = New System.Windows.Forms.WebBrowser()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.grpFavourite = New System.Windows.Forms.GroupBox()
        Me.btnShakir_World = New System.Windows.Forms.Button()
        Me.btnGoogle = New System.Windows.Forms.Button()
        Me.btnFacebook = New System.Windows.Forms.Button()
        Me.btnTwitter = New System.Windows.Forms.Button()
        Me.btnWikipedia = New System.Windows.Forms.Button()
        Me.btnMSN = New System.Windows.Forms.Button()
        Me.btnGmail = New System.Windows.Forms.Button()
        Me.btnBlogger = New System.Windows.Forms.Button()
        Me.btnYahoo = New System.Windows.Forms.Button()
        Me.btnLinkedin = New System.Windows.Forms.Button()
        Me.btnWordpress = New System.Windows.Forms.Button()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.cmbSearchEng = New System.Windows.Forms.ComboBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.Address = New System.Windows.Forms.ComboBox()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.btnGo = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewTabToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewWindowToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CloseTabToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.PrintToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrintToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrintPreviewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PageSetupToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OptionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VisibleInTaskbarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BookmarksAndHistoryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.tabBookmark = New System.Windows.Forms.ToolStripMenuItem()
        Me.tabHistory = New System.Windows.Forms.ToolStripMenuItem()
        Me.DevelperToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewPageSourceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HTMLEditorToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ShowHTMLPreviewWindowToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ShowHTMLCreatorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.WebsitePropertiesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutNeutrinoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.lblDocStatus = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblProg = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblTime = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Panel1.SuspendLayout()
        Me.grpFavourite.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'NeutrinoWB
        '
        Me.NeutrinoWB.Dock = System.Windows.Forms.DockStyle.Fill
        Me.NeutrinoWB.Location = New System.Drawing.Point(0, 130)
        Me.NeutrinoWB.MinimumSize = New System.Drawing.Size(20, 20)
        Me.NeutrinoWB.Name = "NeutrinoWB"
        Me.NeutrinoWB.Size = New System.Drawing.Size(1290, 297)
        Me.NeutrinoWB.TabIndex = 0
        Me.NeutrinoWB.Url = New System.Uri("http://www.google.com", System.UriKind.Absolute)
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.MistyRose
        Me.Panel1.Controls.Add(Me.grpFavourite)
        Me.Panel1.Controls.Add(Me.txtSearch)
        Me.Panel1.Controls.Add(Me.cmbSearchEng)
        Me.Panel1.Controls.Add(Me.btnSearch)
        Me.Panel1.Controls.Add(Me.Address)
        Me.Panel1.Controls.Add(Me.Button6)
        Me.Panel1.Controls.Add(Me.Button5)
        Me.Panel1.Controls.Add(Me.btnGo)
        Me.Panel1.Controls.Add(Me.Button3)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.MenuStrip1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1290, 130)
        Me.Panel1.TabIndex = 1
        '
        'grpFavourite
        '
        Me.grpFavourite.Controls.Add(Me.btnShakir_World)
        Me.grpFavourite.Controls.Add(Me.btnGoogle)
        Me.grpFavourite.Controls.Add(Me.btnFacebook)
        Me.grpFavourite.Controls.Add(Me.btnTwitter)
        Me.grpFavourite.Controls.Add(Me.btnWikipedia)
        Me.grpFavourite.Controls.Add(Me.btnMSN)
        Me.grpFavourite.Controls.Add(Me.btnGmail)
        Me.grpFavourite.Controls.Add(Me.btnBlogger)
        Me.grpFavourite.Controls.Add(Me.btnYahoo)
        Me.grpFavourite.Controls.Add(Me.btnLinkedin)
        Me.grpFavourite.Controls.Add(Me.btnWordpress)
        Me.grpFavourite.Location = New System.Drawing.Point(248, 58)
        Me.grpFavourite.Name = "grpFavourite"
        Me.grpFavourite.Size = New System.Drawing.Size(643, 70)
        Me.grpFavourite.TabIndex = 33
        Me.grpFavourite.TabStop = False
        Me.grpFavourite.Text = "Favourites"
        Me.ToolTip1.SetToolTip(Me.grpFavourite, "Favourite Bar")
        '
        'btnShakir_World
        '
        Me.btnShakir_World.Image = CType(resources.GetObject("btnShakir_World.Image"), System.Drawing.Image)
        Me.btnShakir_World.Location = New System.Drawing.Point(567, 19)
        Me.btnShakir_World.Name = "btnShakir_World"
        Me.btnShakir_World.Size = New System.Drawing.Size(48, 41)
        Me.btnShakir_World.TabIndex = 29
        Me.ToolTip1.SetToolTip(Me.btnShakir_World, "Shakir-World")
        Me.btnShakir_World.UseVisualStyleBackColor = True
        '
        'btnGoogle
        '
        Me.btnGoogle.Image = CType(resources.GetObject("btnGoogle.Image"), System.Drawing.Image)
        Me.btnGoogle.Location = New System.Drawing.Point(42, 19)
        Me.btnGoogle.Name = "btnGoogle"
        Me.btnGoogle.Size = New System.Drawing.Size(46, 41)
        Me.btnGoogle.TabIndex = 19
        Me.ToolTip1.SetToolTip(Me.btnGoogle, "Google")
        Me.btnGoogle.UseVisualStyleBackColor = True
        '
        'btnFacebook
        '
        Me.btnFacebook.Image = CType(resources.GetObject("btnFacebook.Image"), System.Drawing.Image)
        Me.btnFacebook.Location = New System.Drawing.Point(255, 19)
        Me.btnFacebook.Name = "btnFacebook"
        Me.btnFacebook.Size = New System.Drawing.Size(46, 41)
        Me.btnFacebook.TabIndex = 20
        Me.ToolTip1.SetToolTip(Me.btnFacebook, "Facebook")
        Me.btnFacebook.UseVisualStyleBackColor = True
        '
        'btnTwitter
        '
        Me.btnTwitter.Image = CType(resources.GetObject("btnTwitter.Image"), System.Drawing.Image)
        Me.btnTwitter.Location = New System.Drawing.Point(307, 19)
        Me.btnTwitter.Name = "btnTwitter"
        Me.btnTwitter.Size = New System.Drawing.Size(46, 41)
        Me.btnTwitter.TabIndex = 21
        Me.ToolTip1.SetToolTip(Me.btnTwitter, "Twitter")
        Me.btnTwitter.UseVisualStyleBackColor = True
        '
        'btnWikipedia
        '
        Me.btnWikipedia.Image = CType(resources.GetObject("btnWikipedia.Image"), System.Drawing.Image)
        Me.btnWikipedia.Location = New System.Drawing.Point(198, 19)
        Me.btnWikipedia.Name = "btnWikipedia"
        Me.btnWikipedia.Size = New System.Drawing.Size(51, 41)
        Me.btnWikipedia.TabIndex = 28
        Me.ToolTip1.SetToolTip(Me.btnWikipedia, "WikiPedia")
        Me.btnWikipedia.UseVisualStyleBackColor = True
        '
        'btnMSN
        '
        Me.btnMSN.Image = CType(resources.GetObject("btnMSN.Image"), System.Drawing.Image)
        Me.btnMSN.Location = New System.Drawing.Point(359, 19)
        Me.btnMSN.Name = "btnMSN"
        Me.btnMSN.Size = New System.Drawing.Size(46, 41)
        Me.btnMSN.TabIndex = 22
        Me.ToolTip1.SetToolTip(Me.btnMSN, "MSN")
        Me.btnMSN.UseVisualStyleBackColor = True
        '
        'btnGmail
        '
        Me.btnGmail.Image = CType(resources.GetObject("btnGmail.Image"), System.Drawing.Image)
        Me.btnGmail.Location = New System.Drawing.Point(94, 19)
        Me.btnGmail.Name = "btnGmail"
        Me.btnGmail.Size = New System.Drawing.Size(46, 41)
        Me.btnGmail.TabIndex = 27
        Me.ToolTip1.SetToolTip(Me.btnGmail, "GMail")
        Me.btnGmail.UseVisualStyleBackColor = True
        '
        'btnBlogger
        '
        Me.btnBlogger.Image = CType(resources.GetObject("btnBlogger.Image"), System.Drawing.Image)
        Me.btnBlogger.Location = New System.Drawing.Point(463, 19)
        Me.btnBlogger.Name = "btnBlogger"
        Me.btnBlogger.Size = New System.Drawing.Size(46, 41)
        Me.btnBlogger.TabIndex = 23
        Me.ToolTip1.SetToolTip(Me.btnBlogger, "Blogger")
        Me.btnBlogger.UseVisualStyleBackColor = True
        '
        'btnYahoo
        '
        Me.btnYahoo.Image = CType(resources.GetObject("btnYahoo.Image"), System.Drawing.Image)
        Me.btnYahoo.Location = New System.Drawing.Point(146, 19)
        Me.btnYahoo.Name = "btnYahoo"
        Me.btnYahoo.Size = New System.Drawing.Size(46, 41)
        Me.btnYahoo.TabIndex = 26
        Me.ToolTip1.SetToolTip(Me.btnYahoo, "Yahoo")
        Me.btnYahoo.UseVisualStyleBackColor = True
        '
        'btnLinkedin
        '
        Me.btnLinkedin.Image = CType(resources.GetObject("btnLinkedin.Image"), System.Drawing.Image)
        Me.btnLinkedin.Location = New System.Drawing.Point(411, 19)
        Me.btnLinkedin.Name = "btnLinkedin"
        Me.btnLinkedin.Size = New System.Drawing.Size(46, 41)
        Me.btnLinkedin.TabIndex = 24
        Me.ToolTip1.SetToolTip(Me.btnLinkedin, "Linkedin")
        Me.btnLinkedin.UseVisualStyleBackColor = True
        '
        'btnWordpress
        '
        Me.btnWordpress.Image = CType(resources.GetObject("btnWordpress.Image"), System.Drawing.Image)
        Me.btnWordpress.Location = New System.Drawing.Point(515, 19)
        Me.btnWordpress.Name = "btnWordpress"
        Me.btnWordpress.Size = New System.Drawing.Size(46, 41)
        Me.btnWordpress.TabIndex = 25
        Me.ToolTip1.SetToolTip(Me.btnWordpress, "Wordpress")
        Me.btnWordpress.UseVisualStyleBackColor = True
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(897, 36)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(237, 20)
        Me.txtSearch.TabIndex = 31
        Me.ToolTip1.SetToolTip(Me.txtSearch, "Write what you want to search")
        '
        'cmbSearchEng
        '
        Me.cmbSearchEng.FormattingEnabled = True
        Me.cmbSearchEng.Items.AddRange(New Object() {"Google", "WikiPedia", "Yahoo"})
        Me.cmbSearchEng.Location = New System.Drawing.Point(1140, 36)
        Me.cmbSearchEng.Name = "cmbSearchEng"
        Me.cmbSearchEng.Size = New System.Drawing.Size(92, 21)
        Me.cmbSearchEng.TabIndex = 30
        Me.ToolTip1.SetToolTip(Me.cmbSearchEng, "Select a search engine")
        '
        'btnSearch
        '
        Me.btnSearch.Image = CType(resources.GetObject("btnSearch.Image"), System.Drawing.Image)
        Me.btnSearch.Location = New System.Drawing.Point(1238, 34)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(40, 23)
        Me.btnSearch.TabIndex = 8
        Me.ToolTip1.SetToolTip(Me.btnSearch, "Search")
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'Address
        '
        Me.Address.BackColor = System.Drawing.SystemColors.Info
        Me.Address.FormattingEnabled = True
        Me.Address.Location = New System.Drawing.Point(248, 36)
        Me.Address.Name = "Address"
        Me.Address.Size = New System.Drawing.Size(600, 21)
        Me.Address.TabIndex = 7
        Me.ToolTip1.SetToolTip(Me.Address, "Web Address")
        '
        'Button6
        '
        Me.Button6.Image = CType(resources.GetObject("Button6.Image"), System.Drawing.Image)
        Me.Button6.Location = New System.Drawing.Point(158, 27)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(39, 36)
        Me.Button6.TabIndex = 6
        Me.ToolTip1.SetToolTip(Me.Button6, "Reload current page")
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Image = CType(resources.GetObject("Button5.Image"), System.Drawing.Image)
        Me.Button5.Location = New System.Drawing.Point(8, 28)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(37, 44)
        Me.Button5.TabIndex = 5
        Me.ToolTip1.SetToolTip(Me.Button5, "Go Back")
        Me.Button5.UseVisualStyleBackColor = True
        '
        'btnGo
        '
        Me.btnGo.Image = CType(resources.GetObject("btnGo.Image"), System.Drawing.Image)
        Me.btnGo.Location = New System.Drawing.Point(850, 36)
        Me.btnGo.Name = "btnGo"
        Me.btnGo.Size = New System.Drawing.Size(27, 21)
        Me.btnGo.TabIndex = 4
        Me.ToolTip1.SetToolTip(Me.btnGo, "Go")
        Me.btnGo.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Image = CType(resources.GetObject("Button3.Image"), System.Drawing.Image)
        Me.Button3.Location = New System.Drawing.Point(203, 27)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(39, 36)
        Me.Button3.TabIndex = 3
        Me.ToolTip1.SetToolTip(Me.Button3, "Stop loading current page")
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.Location = New System.Drawing.Point(51, 28)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(36, 44)
        Me.Button2.TabIndex = 2
        Me.ToolTip1.SetToolTip(Me.Button2, "Go Forward")
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(113, 28)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(39, 36)
        Me.Button1.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.Button1, "Go to Home")
        Me.Button1.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.ToolsToolStripMenuItem, Me.BookmarksAndHistoryToolStripMenuItem, Me.DevelperToolStripMenuItem, Me.AboutToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1290, 24)
        Me.MenuStrip1.TabIndex = 32
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewTabToolStripMenuItem, Me.NewWindowToolStripMenuItem, Me.CloseTabToolStripMenuItem, Me.ToolStripMenuItem1, Me.PrintToolStripMenuItem, Me.ToolStripMenuItem2, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Image = CType(resources.GetObject("FileToolStripMenuItem.Image"), System.Drawing.Image)
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(53, 20)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'NewTabToolStripMenuItem
        '
        Me.NewTabToolStripMenuItem.Name = "NewTabToolStripMenuItem"
        Me.NewTabToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.NewTabToolStripMenuItem.Size = New System.Drawing.Size(220, 22)
        Me.NewTabToolStripMenuItem.Text = "New Tab"
        '
        'NewWindowToolStripMenuItem
        '
        Me.NewWindowToolStripMenuItem.Name = "NewWindowToolStripMenuItem"
        Me.NewWindowToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
                    Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.NewWindowToolStripMenuItem.Size = New System.Drawing.Size(220, 22)
        Me.NewWindowToolStripMenuItem.Text = "New Window"
        '
        'CloseTabToolStripMenuItem
        '
        Me.CloseTabToolStripMenuItem.Name = "CloseTabToolStripMenuItem"
        Me.CloseTabToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
                    Or System.Windows.Forms.Keys.E), System.Windows.Forms.Keys)
        Me.CloseTabToolStripMenuItem.Size = New System.Drawing.Size(220, 22)
        Me.CloseTabToolStripMenuItem.Text = "Close Tab"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(217, 6)
        '
        'PrintToolStripMenuItem
        '
        Me.PrintToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PrintToolStripMenuItem1, Me.PrintPreviewToolStripMenuItem, Me.PageSetupToolStripMenuItem})
        Me.PrintToolStripMenuItem.Image = CType(resources.GetObject("PrintToolStripMenuItem.Image"), System.Drawing.Image)
        Me.PrintToolStripMenuItem.Name = "PrintToolStripMenuItem"
        Me.PrintToolStripMenuItem.Size = New System.Drawing.Size(220, 22)
        Me.PrintToolStripMenuItem.Text = "&Print"
        '
        'PrintToolStripMenuItem1
        '
        Me.PrintToolStripMenuItem1.Image = CType(resources.GetObject("PrintToolStripMenuItem1.Image"), System.Drawing.Image)
        Me.PrintToolStripMenuItem1.Name = "PrintToolStripMenuItem1"
        Me.PrintToolStripMenuItem1.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
        Me.PrintToolStripMenuItem1.Size = New System.Drawing.Size(143, 22)
        Me.PrintToolStripMenuItem1.Text = "Print"
        '
        'PrintPreviewToolStripMenuItem
        '
        Me.PrintPreviewToolStripMenuItem.Name = "PrintPreviewToolStripMenuItem"
        Me.PrintPreviewToolStripMenuItem.Size = New System.Drawing.Size(143, 22)
        Me.PrintPreviewToolStripMenuItem.Text = "Print Preview"
        '
        'PageSetupToolStripMenuItem
        '
        Me.PageSetupToolStripMenuItem.Name = "PageSetupToolStripMenuItem"
        Me.PageSetupToolStripMenuItem.Size = New System.Drawing.Size(143, 22)
        Me.PageSetupToolStripMenuItem.Text = "Page Setup"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(217, 6)
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.E), System.Windows.Forms.Keys)
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(220, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'ToolsToolStripMenuItem
        '
        Me.ToolsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OptionsToolStripMenuItem, Me.VisibleInTaskbarToolStripMenuItem})
        Me.ToolsToolStripMenuItem.Image = CType(resources.GetObject("ToolsToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ToolsToolStripMenuItem.Name = "ToolsToolStripMenuItem"
        Me.ToolsToolStripMenuItem.Size = New System.Drawing.Size(64, 20)
        Me.ToolsToolStripMenuItem.Text = "Tools"
        '
        'OptionsToolStripMenuItem
        '
        Me.OptionsToolStripMenuItem.Name = "OptionsToolStripMenuItem"
        Me.OptionsToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.OptionsToolStripMenuItem.Text = "Options"
        '
        'VisibleInTaskbarToolStripMenuItem
        '
        Me.VisibleInTaskbarToolStripMenuItem.Checked = True
        Me.VisibleInTaskbarToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.VisibleInTaskbarToolStripMenuItem.Name = "VisibleInTaskbarToolStripMenuItem"
        Me.VisibleInTaskbarToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.VisibleInTaskbarToolStripMenuItem.Text = "Visible In Taskbar"
        '
        'BookmarksAndHistoryToolStripMenuItem
        '
        Me.BookmarksAndHistoryToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tabBookmark, Me.tabHistory})
        Me.BookmarksAndHistoryToolStripMenuItem.Name = "BookmarksAndHistoryToolStripMenuItem"
        Me.BookmarksAndHistoryToolStripMenuItem.Size = New System.Drawing.Size(142, 20)
        Me.BookmarksAndHistoryToolStripMenuItem.Text = "Bookmarks and History"
        '
        'tabBookmark
        '
        Me.tabBookmark.Image = CType(resources.GetObject("tabBookmark.Image"), System.Drawing.Image)
        Me.tabBookmark.Name = "tabBookmark"
        Me.tabBookmark.Size = New System.Drawing.Size(152, 22)
        Me.tabBookmark.Text = "Bookmarks"
        '
        'tabHistory
        '
        Me.tabHistory.Name = "tabHistory"
        Me.tabHistory.Size = New System.Drawing.Size(152, 22)
        Me.tabHistory.Text = "History"
        '
        'DevelperToolStripMenuItem
        '
        Me.DevelperToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ViewPageSourceToolStripMenuItem, Me.HTMLEditorToolStripMenuItem1, Me.ToolStripSeparator2, Me.WebsitePropertiesToolStripMenuItem})
        Me.DevelperToolStripMenuItem.Name = "DevelperToolStripMenuItem"
        Me.DevelperToolStripMenuItem.Size = New System.Drawing.Size(99, 20)
        Me.DevelperToolStripMenuItem.Text = "Web Developer"
        '
        'ViewPageSourceToolStripMenuItem
        '
        Me.ViewPageSourceToolStripMenuItem.Name = "ViewPageSourceToolStripMenuItem"
        Me.ViewPageSourceToolStripMenuItem.Size = New System.Drawing.Size(172, 22)
        Me.ViewPageSourceToolStripMenuItem.Text = "View Page Source"
        '
        'HTMLEditorToolStripMenuItem1
        '
        Me.HTMLEditorToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ShowHTMLPreviewWindowToolStripMenuItem, Me.ShowHTMLCreatorToolStripMenuItem})
        Me.HTMLEditorToolStripMenuItem1.Name = "HTMLEditorToolStripMenuItem1"
        Me.HTMLEditorToolStripMenuItem1.Size = New System.Drawing.Size(172, 22)
        Me.HTMLEditorToolStripMenuItem1.Text = "HTML Editor"
        '
        'ShowHTMLPreviewWindowToolStripMenuItem
        '
        Me.ShowHTMLPreviewWindowToolStripMenuItem.Name = "ShowHTMLPreviewWindowToolStripMenuItem"
        Me.ShowHTMLPreviewWindowToolStripMenuItem.Size = New System.Drawing.Size(230, 22)
        Me.ShowHTMLPreviewWindowToolStripMenuItem.Text = "Show HTML Preview Window"
        '
        'ShowHTMLCreatorToolStripMenuItem
        '
        Me.ShowHTMLCreatorToolStripMenuItem.Name = "ShowHTMLCreatorToolStripMenuItem"
        Me.ShowHTMLCreatorToolStripMenuItem.Size = New System.Drawing.Size(230, 22)
        Me.ShowHTMLCreatorToolStripMenuItem.Text = "Show HTML Creator"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(169, 6)
        '
        'WebsitePropertiesToolStripMenuItem
        '
        Me.WebsitePropertiesToolStripMenuItem.Name = "WebsitePropertiesToolStripMenuItem"
        Me.WebsitePropertiesToolStripMenuItem.Size = New System.Drawing.Size(172, 22)
        Me.WebsitePropertiesToolStripMenuItem.Text = "Website Properties"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutNeutrinoToolStripMenuItem, Me.ToolStripSeparator1})
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(52, 20)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'AboutNeutrinoToolStripMenuItem
        '
        Me.AboutNeutrinoToolStripMenuItem.Name = "AboutNeutrinoToolStripMenuItem"
        Me.AboutNeutrinoToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.AboutNeutrinoToolStripMenuItem.Text = "About Neutrino"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(154, 6)
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblDocStatus, Me.lblProg, Me.lblTime})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 427)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1290, 22)
        Me.StatusStrip1.TabIndex = 2
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'lblDocStatus
        '
        Me.lblDocStatus.Name = "lblDocStatus"
        Me.lblDocStatus.Size = New System.Drawing.Size(39, 17)
        Me.lblDocStatus.Text = "Status"
        Me.lblDocStatus.ToolTipText = "Text"
        '
        'lblProg
        '
        Me.lblProg.Image = CType(resources.GetObject("lblProg.Image"), System.Drawing.Image)
        Me.lblProg.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.lblProg.Name = "lblProg"
        Me.lblProg.Size = New System.Drawing.Size(618, 17)
        Me.lblProg.Spring = True
        Me.lblProg.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal
        Me.lblProg.ToolTipText = "Progressing..."
        Me.lblProg.Visible = False
        '
        'lblTime
        '
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(1236, 17)
        Me.lblTime.Spring = True
        Me.lblTime.Text = "Time"
        Me.lblTime.ToolTipText = "Current Local Time"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1
        '
        'frmNeutrino
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1290, 449)
        Me.Controls.Add(Me.NeutrinoWB)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmNeutrino"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Neutrino"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.grpFavourite.ResumeLayout(False)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents NeutrinoWB As System.Windows.Forms.WebBrowser
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents Address As System.Windows.Forms.ComboBox
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents btnGo As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents cmbSearchEng As System.Windows.Forms.ComboBox
    Friend WithEvents btnShakir_World As System.Windows.Forms.Button
    Friend WithEvents btnWikipedia As System.Windows.Forms.Button
    Friend WithEvents btnGmail As System.Windows.Forms.Button
    Friend WithEvents btnYahoo As System.Windows.Forms.Button
    Friend WithEvents btnWordpress As System.Windows.Forms.Button
    Friend WithEvents btnLinkedin As System.Windows.Forms.Button
    Friend WithEvents btnBlogger As System.Windows.Forms.Button
    Friend WithEvents btnMSN As System.Windows.Forms.Button
    Friend WithEvents btnTwitter As System.Windows.Forms.Button
    Friend WithEvents btnFacebook As System.Windows.Forms.Button
    Friend WithEvents btnGoogle As System.Windows.Forms.Button
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NewTabToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NewWindowToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CloseTabToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents grpFavourite As System.Windows.Forms.GroupBox
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents PrintToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PrintToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PrintPreviewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PageSetupToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OptionsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DevelperToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewPageSourceToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HTMLEditorToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents WebsitePropertiesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ShowHTMLPreviewWindowToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ShowHTMLCreatorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblDocStatus As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents VisibleInTaskbarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblProg As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents BookmarksAndHistoryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tabBookmark As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tabHistory As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblTime As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutNeutrinoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator

End Class
