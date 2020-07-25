Imports System.Net.WebRequestMethods

Public Class frmNeutrino

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub NewTabToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewTabToolStripMenuItem.Click

    End Sub

    Private Sub MenuStrip1_ItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button8_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGo.Click
        If Address.Text = "" Then Return
        NeutrinoWB.Navigate(Address.Text)
        My.Settings.SetHistory.Add(Address.Text)

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        NeutrinoWB.Stop()

    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        NeutrinoWB.Refresh()

    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        NeutrinoWB.Navigate(My.Settings.Homepage)

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        NeutrinoWB.GoForward()

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        NeutrinoWB.GoBack()

    End Sub

    Private Sub NeutrinoWB_DocumentCompleted(ByVal sender As System.Object, ByVal e As System.Windows.Forms.WebBrowserDocumentCompletedEventArgs) Handles NeutrinoWB.DocumentCompleted
        Me.Text = "Neutrino " + " - " + NeutrinoWB.DocumentTitle
        lblProg.Visible = False
        My.Settings.SetHistory.Add(NeutrinoWB.Url.ToString)
        For Each HisItem As String In My.Settings.SetHistory
            tabHistory.DropDownItems.Add(HisItem)
        Next
        For Each hItem As String In My.Settings.SetHistory
            Address.Items.Add(hItem)
        Next

    End Sub

    Private Sub btnGoogle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGoogle.Click
        NeutrinoWB.Navigate("http://www.google.com")
    End Sub

    Private Sub btnGmail_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGmail.Click
        NeutrinoWB.Navigate("http://www.gmail.com")
    End Sub

    Private Sub btnYahoo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnYahoo.Click
        NeutrinoWB.Navigate("http://www.yahoo.com")
    End Sub

    Private Sub btnWikipedia_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnWikipedia.Click
        NeutrinoWB.Navigate("http://www.wikipedia.com")
    End Sub

    Private Sub btnFacebook_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFacebook.Click
        NeutrinoWB.Navigate("http://www.facebook.com")
    End Sub

    Private Sub btnTwitter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTwitter.Click
        NeutrinoWB.Navigate("http://www.twitter.com")
    End Sub

    Private Sub btnMSN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMSN.Click
        NeutrinoWB.Navigate("http://www.msn.com")
    End Sub

    Private Sub btnLinkedin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLinkedin.Click
        NeutrinoWB.Navigate("http://www.linkedin.com")
    End Sub

    Private Sub btnBlogger_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBlogger.Click
        NeutrinoWB.Navigate("http://www.blogger.com")
    End Sub

    Private Sub btnWordpress_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnWordpress.Click
        NeutrinoWB.Navigate("http://www.wordpress.com")
    End Sub

    Private Sub btnShakir_World_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShakir_World.Click
        NeutrinoWB.Navigate("http://www.shakir-world.0fees.net")
    End Sub

    Private Sub PrintToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintToolStripMenuItem1.Click
        NeutrinoWB.ShowPrintDialog()

    End Sub

    Private Sub PrintPreviewToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintPreviewToolStripMenuItem.Click
        NeutrinoWB.ShowPrintPreviewDialog()

    End Sub

    Private Sub PageSetupToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PageSetupToolStripMenuItem.Click
        NeutrinoWB.ShowPageSetupDialog()

    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        End
    End Sub

    Private Sub CutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)



    End Sub

    Private Sub CopyToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub

    Private Sub PasteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub WebsitePropertiesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WebsitePropertiesToolStripMenuItem.Click
        NeutrinoWB.ShowPropertiesDialog()

    End Sub

    Private Sub OptionsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OptionsToolStripMenuItem.Click
        Options.Show()

    End Sub

    Private Sub frmNeutrino_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Options.CheckBox1.Checked = True Then
            Me.grpFavourite.Visible = True
        ElseIf Options.CheckBox1.Checked = False Then
            Me.grpFavourite.Visible = False
        End If
        Me.Panel1.Height = 77
        Options.CheckBox1.Checked = False
        Options.CheckBox2.Checked = True
        Options.CheckBox3.Checked = True
        Options.CheckBox4.Checked = True
        Options.CheckBox5.Checked = True
        Options.CheckBox6.Checked = True
        Options.CheckBox7.Checked = False
        Me.Panel1.Show()


        Me.ShowInTaskbar = True
        For Each Item As String In My.Settings.AllBookmarks
            Options.chklstBookmark.Items.Add(Item)
        Next
        For Each Item As String In My.Settings.AllBookmarks
            tabBookmark.DropDownItems.Add(Item)
        Next
        For Each HistoryItem As String In My.Settings.SetHistory
            tabHistory.DropDownItems.Add(HistoryItem)
        Next
        For Each HistoryItem As String In My.Settings.SetHistory
            Address.Items.Add(HistoryItem)
        Next
        NeutrinoWB.Navigate(My.Settings.Homepage)
    End Sub

    Private Sub ViewPageSourceToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViewPageSourceToolStripMenuItem.Click
        View_Page_Source.Show()

    End Sub

    Private Sub HTMLEditorToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HTMLEditorToolStripMenuItem1.Click
        HTML_Preview.Show()
        HTML__Creator.Show()

    End Sub

    Private Sub ShowHTMLPreviewWindowToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ShowHTMLPreviewWindowToolStripMenuItem.Click
        HTML_Preview.Show()

    End Sub

    Private Sub ShowHTMLCreatorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ShowHTMLCreatorToolStripMenuItem.Click
        HTML__Creator.Show()

    End Sub

    Private Sub NeutrinoWB_DocumentTitleChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles NeutrinoWB.DocumentTitleChanged
        Me.Text = "Neutrino " + " - " + NeutrinoWB.DocumentTitle
    End Sub

    Private Sub NeutrinoWB_Navigated(ByVal sender As Object, ByVal e As System.Windows.Forms.WebBrowserNavigatedEventArgs) Handles NeutrinoWB.Navigated
        Me.Address.Text = Me.NeutrinoWB.Url.ToString

        
    End Sub

    Private Sub NeutrinoWB_Navigating(ByVal sender As Object, ByVal e As System.Windows.Forms.WebBrowserNavigatingEventArgs) Handles NeutrinoWB.Navigating

        lblProg.Visible = True
        
    End Sub


    Private Sub NeutrinoWB_StatusTextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles NeutrinoWB.StatusTextChanged
        Me.lblDocStatus.Text = NeutrinoWB.StatusText

    End Sub

    Private Sub Address_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Address.KeyDown
        If IsInputKey(Keys.Enter) Then
            btnGo.Select()

        End If

    End Sub


    Private Sub Address_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Address.SelectedValueChanged
        btnGo.Select()

    End Sub



    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        Dim googleSearch As String
        Dim wikiSearch As String
        Dim yahSearch As String
        googleSearch = "http://www.google.com/search?hl=en&q=" + txtSearch.Text
        wikiSearch = "http://en.wikipedia.org/wiki/" + txtSearch.Text
        yahSearch = "http://search.yahoo.com/search?p=" + txtSearch.Text

        If cmbSearchEng.Text = "" Then MsgBox("Please first select a search engine.")
        If cmbSearchEng.Text = "Google" Then

            NeutrinoWB.Navigate(googleSearch)
        ElseIf cmbSearchEng.Text = "WikiPedia" Then
            NeutrinoWB.Navigate(wikiSearch)
        ElseIf cmbSearchEng.Text = "Yahoo" Then
            NeutrinoWB.Navigate(yahSearch)
        End If
    End Sub


    Private Sub NewWindowToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewWindowToolStripMenuItem.Click
        Dim newWin As New frmNeutrino
        newWin.Show()

    End Sub

    Private Sub VisibleInTaskbarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VisibleInTaskbarToolStripMenuItem.Click
        If VisibleInTaskbarToolStripMenuItem.Checked = True Then
            VisibleInTaskbarToolStripMenuItem.CheckState = CheckState.Unchecked
            Me.ShowInTaskbar = False
        ElseIf VisibleInTaskbarToolStripMenuItem.Checked = False Then
            VisibleInTaskbarToolStripMenuItem.CheckState = CheckState.Checked
            Me.ShowInTaskbar = True

        End If
    End Sub


    Private Sub Timer1_Tick_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        
        lblTime.Text = Now
    End Sub

    
    Private Sub Address_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Address.SelectedIndexChanged
        NeutrinoWB.Navigate(Address.Text)
    End Sub

   
    Private Sub Address_TextUpdate(ByVal sender As Object, ByVal e As System.EventArgs) Handles Address.TextUpdate

    End Sub

    Private Sub Address_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Address.Validated
        btnGo.Select()
    End Sub

    Private Sub AboutNeutrinoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutNeutrinoToolStripMenuItem.Click
        About_Neutrino.Show()

    End Sub
End Class
