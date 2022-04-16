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

    'username textbox placeholder
    Private Sub username_tb_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles username_tb.Enter
        If username_tb.Text = "Username" Then
            username_tb.Text = ""
        End If
    End Sub

    Private Sub username_tb_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles username_tb.Leave
        If username_tb.Text = "" Then
            username_tb.Text = "Username"
        End If
    End Sub
    'password textbox placeholder
    Private Sub password_tb_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles password_tb.Enter
        If password_tb.Text = "Password" Then
            password_tb.Text = ""
            password_tb.PasswordChar = "•"
        End If
    End Sub

    Private Sub password_tb_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles password_tb.Leave
        If password_tb.Text = "" Then
            password_tb.Text = "Password"
            password_tb.PasswordChar = ""
        End If
    End Sub
End Class
