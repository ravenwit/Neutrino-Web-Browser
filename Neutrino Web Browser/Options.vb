Public Class Options

    Private Sub Options_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        txtOldHome.Text = My.Settings.Homepage.ToString
        txtOldHome.ReadOnly = True
        
        Me.ShowInTaskbar = True
        For Each Item As String In My.Settings.AllBookmarks
            Me.chklstBookmark.Items.Add(Item)
        Next
        
    End Sub

    Private Sub btnApply_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnApply.Click
        My.Settings.Homepage = txtNewHome.Text
        txtOldHome.Text = My.Settings.Homepage
        MsgBox("Your home page is sat")
    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If CheckBox1.Checked = True Then
            frmNeutrino.grpFavourite.Visible = True
            frmNeutrino.Panel1.Height = 142
        ElseIf CheckBox1.Checked = False Then
            frmNeutrino.grpFavourite.Visible = False
            frmNeutrino.Panel1.Height = 77
        End If
    End Sub

    Private Sub CheckBox2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked = True Then
            frmNeutrino.ShowInTaskbar = True
        ElseIf CheckBox2.Checked = False Then
            frmNeutrino.ShowInTaskbar = False

        End If
    End Sub

    Private Sub CheckBox5_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox5.CheckedChanged
        If CheckBox5.Checked = True Then
            View_Page_Source.ShowInTaskbar = True
        ElseIf CheckBox5.Checked = False Then
            View_Page_Source.ShowInTaskbar = False

        End If
    End Sub

    Private Sub CheckBox3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox3.CheckedChanged
        If CheckBox3.Checked = True Then
            HTML_Preview.ShowInTaskbar = True
        ElseIf CheckBox3.Checked = False Then
            HTML_Preview.ShowInTaskbar = False

        End If
    End Sub

    Private Sub CheckBox4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox4.CheckedChanged
        If CheckBox4.Checked = True Then
            HTML__Creator.ShowInTaskbar = True
        ElseIf CheckBox4.Checked = False Then
            HTML__Creator.ShowInTaskbar = False

        End If
    End Sub

    Private Sub CheckBox6_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox6.CheckedChanged
        If CheckBox6.Checked = True Then
            Me.ShowInTaskbar = True
        ElseIf CheckBox6.Checked = False Then
            Me.ShowInTaskbar = False

        End If
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        My.Settings.AllBookmarks.Add(frmNeutrino.NeutrinoWB.Url.ToString)
        chklstBookmark.Items.Clear()
        For Each Item As String In My.Settings.AllBookmarks
            Me.chklstBookmark.Items.Add(Item)
        Next
        For Each Item As String In My.Settings.AllBookmarks
            frmNeutrino.tabBookmark.DropDownItems.Add(Item)
        Next
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        My.Settings.AllBookmarks.Clear()
        chklstBookmark.Items.Clear()
        For Each Item As String In My.Settings.AllBookmarks
            frmNeutrino.tabBookmark.DropDownItems.Add(Item)
        Next
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim bookmarkurl As String
        bookmarkurl = InputBox("Please enter the url", "Add Bookmark")
        My.Settings.AllBookmarks.Add(bookmarkurl.ToString)
        chklstBookmark.Items.Clear()
        For Each Item As String In My.Settings.AllBookmarks
            Me.chklstBookmark.Items.Add(Item)
        Next
        For Each Item As String In My.Settings.AllBookmarks
            frmNeutrino.tabBookmark.DropDownItems.Add(Item)
        Next
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        My.Settings.AllBookmarks.Remove(chklstBookmark.SelectedItem)
        chklstBookmark.Items.Clear()
        For Each Item As String In My.Settings.AllBookmarks
            Me.chklstBookmark.Items.Add(Item)
        Next
        For Each Item As String In My.Settings.AllBookmarks
            frmNeutrino.tabBookmark.DropDownItems.Add(Item)
        Next
    End Sub

   
    Private Sub CheckBox7_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox7.CheckedChanged
        If CheckBox7.Checked = True Then
            frmNeutrino.Panel1.Height = 24
        ElseIf CheckBox7.Checked = False Then
            If CheckBox1.Checked = True Then
                frmNeutrino.Panel1.Height = 130
            ElseIf CheckBox1.Checked = False Then
                frmNeutrino.Panel1.Height = 77
            End If
        End If
    End Sub

    Private Sub CheckBox8_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub chklstBookmark_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles chklstBookmark.DoubleClick
        frmNeutrino.NeutrinoWB.Navigate(chklstBookmark.SelectedItem)
    End Sub

    
    Private Sub chklstBookmark_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chklstBookmark.SelectedIndexChanged

    End Sub

    Private Sub CheckBox1_CheckedChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            frmNeutrino.grpFavourite.Visible = True
            frmNeutrino.Panel1.Height = 130
        ElseIf CheckBox1.Checked = False Then
            frmNeutrino.grpFavourite.Visible = False
            frmNeutrino.Panel1.Height = 77
        End If
    End Sub
End Class
