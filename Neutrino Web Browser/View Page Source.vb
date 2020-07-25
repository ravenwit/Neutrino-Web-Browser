Public Class View_Page_Source

    Private Sub View_Page_Source_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim DocUrl As String
        Dim DocTitle As String
        DocUrl = frmNeutrino.NeutrinoWB.Url.ToString
        DocTitle = frmNeutrino.NeutrinoWB.DocumentTitle
        Me.Text = "Source : " + " " + DocUrl + "  "
        txtSource.ReadOnly = True
        txtSource.ScrollBars = ScrollBars.Both
        txtSource.Text = frmNeutrino.NeutrinoWB.DocumentText


    End Sub
End Class