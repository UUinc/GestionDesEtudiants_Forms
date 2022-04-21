Public Class AdminPage

    Private Sub logout_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles logout_btn.Click
        'wipe information from text box
        LoginPage.username_tb.Text = "Username"
        LoginPage.password_tb.Text = ""

        'show and set same location as admin page
        LoginPage.Show()
        LoginPage.Location = Me.Location

        'hide loginpage
        Me.Hide()
    End Sub
End Class