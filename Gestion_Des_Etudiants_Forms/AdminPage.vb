Public Class AdminPage

    Private Sub logout_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles logout_btn.Click
        'wipe information from text box
        LoginPage.username_tb.Text = "Username"
        LoginPage.username_tb.ForeColor = Color.Gray
        LoginPage.password_tb.Text = "Password"
        LoginPage.password_tb.ForeColor = Color.Gray
        LoginPage.password_tb.PasswordChar = ""
        LoginPage.showpassword_btn.BackgroundImage = My.Resources.blind
        LoginPage.showpassword_btn.Visible = False

        LoginPage.erreur_l.Visible = False

        'show and set same location as admin page
        LoginPage.Show()
        LoginPage.Location = Me.Location

        'change tab index
        LoginPage.username_tb.Select()

        'hide loginpage
        Me.Hide()
    End Sub

    Private Sub Ajouter_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Ajouter_btn.Click
        AjouterPage.Show()
        AjouterPage.Location = Me.Location
        Me.Hide()
    End Sub

    Private Sub modifier_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles modifier_btn.Click
        ModifierPage.Show()
        ModifierPage.Location = Me.Location
        Me.Hide()
    End Sub

    Private Sub Supprimer_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Supprimer_btn.Click
        SupprimerPage.Show()
        SupprimerPage.Location = Me.Location
        Me.Hide()
    End Sub

    Private Sub Afficher_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        AfficherPage.Show()
        AfficherPage.Location = Me.Location
        Me.Hide()
    End Sub
End Class