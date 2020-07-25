Public Class HTML__Creator

    Private Sub txtCode_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCode.KeyDown
        HTML_Preview.webPreview.DocumentText = txtCode.Text
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCode.TextChanged
        HTML_Preview.webPreview.DocumentText = txtCode.Text

    End Sub

    Private Sub HTML__Creator_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
       
    End Sub
End Class