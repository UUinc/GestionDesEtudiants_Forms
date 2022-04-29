Imports System.Data.OleDb

Public Class LoginPage
    'database connection
    Public Connection As New OleDbConnection(My.Settings.GestionDesEtudiants_DBConnectionString)

    'mouse hover the login button
    Private Sub login_btn_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles login_btn.MouseEnter
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
            username_tb.ForeColor = Color.Black
        End If
    End Sub

    Private Sub username_tb_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles username_tb.Leave
        If username_tb.Text = "" Then
            username_tb.Text = "Username"
            username_tb.ForeColor = Color.Gray
        End If
    End Sub
    'password textbox placeholder
    Private Sub password_tb_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles password_tb.Enter
        If password_tb.Text = "Password" Then
            password_tb.Text = ""
            showpassword_btn.Visible = True
            password_tb.PasswordChar = "•"
            password_tb.ForeColor = Color.Black
        End If
    End Sub

    Private Sub password_tb_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles password_tb.Leave
        If password_tb.Text = "" Then
            password_tb.Text = "Password"
            showpassword_btn.Visible = False
            password_tb.PasswordChar = ""
            password_tb.ForeColor = Color.Gray
            'also hide the error label
            erreur_l.Visible = False
        End If
    End Sub
    'Login button click
    Private Sub login_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles login_btn.Click
        Login()
    End Sub

    Private Sub password_tb_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles password_tb.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
            Login()
        End If
    End Sub

    Sub Login()
        If Connection.State = ConnectionState.Closed Then
            Connection.Open()
        End If

        Dim cmd As New OleDbCommand("select count(*) from Login where username= @username and passwrd= @password", Connection)
        cmd.Parameters.AddWithValue("@username", OleDbType.VarChar).Value = username_tb.Text
        cmd.Parameters.AddWithValue("@password", OleDbType.VarChar).Value = password_tb.Text
        Dim count = Convert.ToInt32(cmd.ExecuteScalar())

        If count > 0 Then
            'show and set same location as loginpage
            AdminPage.Show()
            AdminPage.Location = Me.Location

            'hide loginpage
            Me.Hide()

        Else
            erreur_l.Visible = True
        End If
    End Sub

    Private Sub showpassword_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles showpassword_btn.Click
        If password_tb.PasswordChar = "•"c Then
            password_tb.PasswordChar = ""
            'show img
            showpassword_btn.BackgroundImage = My.Resources.show
        Else
            password_tb.PasswordChar = "•"c
            'hide img
            showpassword_btn.BackgroundImage = My.Resources.blind
        End If
    End Sub
End Class
