Imports System.Data.OleDb

Public Class LoginPage
    'database connection
    Dim Connection As New OleDbConnection(My.Settings.GestionDesEtudiants_DBConnectionString)

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
    'Login button click
    Private Sub login_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles login_btn.Click

        If Connection.State = ConnectionState.Closed Then
            Connection.Open()
        End If

        Dim cmd As New OleDbCommand("select count(*) from login where username=? and password=?", Connection)
        cmd.Parameters.AddWithValue("@1", OleDbType.VarChar).Value = username_tb.Text
        cmd.Parameters.AddWithValue("@2", OleDbType.VarChar).Value = password_tb.Text
        Dim count = Convert.ToInt32(cmd.ExecuteScalar())

        If count > 0 Then
            MsgBox("Login succeeded", MsgBoxStyle.Information)
        Else
            MsgBox("Username or Password is incorrect", MsgBoxStyle.Critical)
        End If
    End Sub
End Class
