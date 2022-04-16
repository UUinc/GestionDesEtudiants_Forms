Public Class LoginPage

    'mouse hover the login button
    Private Sub login_btn_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles login_btn.MouseHover
        login_btn.BackgroundImage = My.Resources.Button_hover
    End Sub

    Private Sub login_btn_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles login_btn.MouseLeave
        login_btn.BackgroundImage = My.Resources.Button
    End Sub

    'mouse click the login botton
    Private Sub login_btn_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles login_btn.MouseDown
        login_btn.BackgroundImage = My.Resources.Button_click
    End Sub

    Private Sub login_btn_MouseUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles login_btn.MouseUp
        login_btn.BackgroundImage = My.Resources.Button
    End Sub
End Class
