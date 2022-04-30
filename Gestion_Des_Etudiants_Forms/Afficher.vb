Public Class AfficherPage

    Private Sub back_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles back_btn.Click

        If LoginPage.GetPermission() = True Then
            AdminPage.Show()
            AdminPage.Location = Me.Location
        Else
            'wipe information from text box
            LoginPage.username_tb.Text = "Username"
            LoginPage.username_tb.ForeColor = Color.Gray
            LoginPage.password_tb.Text = ""
            LoginPage.password_tb.ForeColor = Color.Gray
            LoginPage.showpassword_btn.Visible = False
            LoginPage.erreur_l.Visible = False

            LoginPage.username_tb.Select()

            LoginPage.Show()
            LoginPage.Location = Me.Location
        End If
        Me.Hide()
    End Sub
End Class