Imports System.Data.OleDb

Public Class AfficherPage

    Private Sub back_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles back_btn.Click
        BackToLoginPage()
    End Sub

    Sub BackToLoginPage()
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

        Me.Hide()
    End Sub

    Private Sub AfficherPage_VisibleChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.VisibleChanged

        If Not Visible Then
            Return
        End If

        'Load data from db
        'Create connection with database
        Dim Connection = LoginPage.Connection
        If Connection.State = ConnectionState.Closed Then
            Connection.Open()
        End If

        Try
            'Get student information
            'Get email 
            Dim sqlQry As String = "SELECT email FROM Login WHERE username = @username AND StrComp(passwrd,  @password, 0) = 0"
            Dim cmd As New OleDbCommand(sqlQry, Connection)
            cmd.Parameters.AddWithValue("@username", LoginPage.username_tb.Text)
            cmd.Parameters.AddWithValue("@password", LoginPage.password_tb.Text)
            Dim email As String = cmd.ExecuteScalar().ToString()

            'Get CIN 
            sqlQry = "SELECT cin FROM Login WHERE username = @username AND StrComp(passwrd,  @password, 0) = 0"
            Dim cmd1 As New OleDbCommand(sqlQry, Connection)
            cmd1.Parameters.AddWithValue("@username", LoginPage.username_tb.Text)
            cmd1.Parameters.AddWithValue("@password", LoginPage.password_tb.Text)
            Dim cin As String = cmd1.ExecuteScalar().ToString()

            'Get student_id
            sqlQry = "SELECT student_id FROM Person WHERE cin = @cin"
            Dim cmd2 As New OleDbCommand(sqlQry, Connection)
            cmd2.Parameters.AddWithValue("@cin", cin)
            Dim student_id As Long = Convert.ToInt64(cmd2.ExecuteScalar())

            'Get nom
            sqlQry = "SELECT nom FROM Person WHERE cin = @cin"
            Dim cmd3 As New OleDbCommand(sqlQry, Connection)
            cmd3.Parameters.AddWithValue("@cin", cin)
            Dim nom As String = cmd3.ExecuteScalar().ToString()

            'Get prenom
            sqlQry = "SELECT prenom FROM Person WHERE cin = @cin"
            Dim cmd4 As New OleDbCommand(sqlQry, Connection)
            cmd4.Parameters.AddWithValue("@cin", cin)
            Dim prenom As String = cmd4.ExecuteScalar().ToString()

            'Get date
            sqlQry = "SELECT date_de_naissance FROM Person WHERE cin = @cin"
            Dim cmd5 As New OleDbCommand(sqlQry, Connection)
            cmd5.Parameters.AddWithValue("@cin", cin)
            Dim dateDeNaissance As String = Convert.ToDateTime(cmd5.ExecuteScalar()).ToShortDateString()

            'Get sexe
            sqlQry = "SELECT sex FROM Person WHERE cin = @cin"
            Dim cmd6 As New OleDbCommand(sqlQry, Connection)
            cmd6.Parameters.AddWithValue("@cin", cin)
            Dim sex As String
            If Convert.ToBoolean(cmd6.ExecuteScalar()) = True Then
                sex = "Male"
            Else
                sex = "Female"
            End If

            'Get filiere
            sqlQry = "SELECT filiere FROM Student WHERE student_id = @student_id"
            Dim cmd7 As New OleDbCommand(sqlQry, Connection)
            cmd7.Parameters.AddWithValue("@student_id", student_id)
            Dim filiere As String = cmd7.ExecuteScalar().ToString()

            'Get Scores
            sqlQry = "SELECT score FROM Score WHERE course_id = @course_id AND student_id = @student_id"
            Dim cmd8 As New OleDbCommand(sqlQry, Connection)
            'note1
            cmd8.Parameters.AddWithValue("@course_id", 1)
            cmd8.Parameters.AddWithValue("@student_id", student_id)
            Dim note1 As String = cmd8.ExecuteScalar().ToString()
            'note2
            cmd8.Parameters.Clear()
            cmd8.Parameters.AddWithValue("@course_id", 2)
            cmd8.Parameters.AddWithValue("@student_id", student_id)
            Dim note2 As String = cmd8.ExecuteScalar().ToString()
            'note3
            cmd8.Parameters.Clear()
            cmd8.Parameters.AddWithValue("@course_id", 3)
            cmd8.Parameters.AddWithValue("@student_id", student_id)
            Dim note3 As String = cmd8.ExecuteScalar().ToString()
            'note4
            cmd8.Parameters.Clear()
            cmd8.Parameters.AddWithValue("@course_id", 4)
            cmd8.Parameters.AddWithValue("@student_id", student_id)
            Dim note4 As String = cmd8.ExecuteScalar().ToString()
            'note5
            cmd8.Parameters.Clear()
            cmd8.Parameters.AddWithValue("@course_id", 5)
            cmd8.Parameters.AddWithValue("@student_id", student_id)
            Dim note5 As String = cmd8.ExecuteScalar().ToString()
            'note6
            cmd8.Parameters.Clear()
            cmd8.Parameters.AddWithValue("@course_id", 6)
            cmd8.Parameters.AddWithValue("@student_id", student_id)
            Dim note6 As String = cmd8.ExecuteScalar().ToString()
            'note7
            cmd8.Parameters.Clear()
            cmd8.Parameters.AddWithValue("@course_id", 7)
            cmd8.Parameters.AddWithValue("@student_id", student_id)
            Dim note7 As String = cmd8.ExecuteScalar().ToString()

            'Show data
            cin_tb.Text = cin
            nom_tb.Text = nom
            prenom_tb.Text = prenom
            email_tb.Text = email
            date_de_naissance_tb.Text = dateDeNaissance
            sexe_tb.Text = sex
            filiere_tb.Text = filiere
            'scores
            note1_tb.Text = note1
            note2_tb.Text = note2
            note3_tb.Text = note3
            note4_tb.Text = note4
            note5_tb.Text = note5
            note6_tb.Text = note6
            note7_tb.Text = note7

        Catch ex As Exception
            BackToLoginPage()
        End Try
    End Sub
End Class