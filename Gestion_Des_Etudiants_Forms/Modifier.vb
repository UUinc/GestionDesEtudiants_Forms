Imports System.Text.RegularExpressions
Imports System.Data.OleDb

Public Class ModifierPage

    Dim student_id As Long

    Private Sub back_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles back_btn.Click
        ClearUI()

        AdminPage.Show()
        AdminPage.Location = Me.Location
        Me.Hide()
    End Sub

    Private Sub search_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles search_btn.Click
        'Load data from db
        'Create connection with database
        Dim Connection = LoginPage.Connection
        If Connection.State = ConnectionState.Closed Then
            Connection.Open()
        End If

        Try
            Dim cin As String = etudiantCIN_search_tb.Text
            'Get student information
            Dim sqlQry As String = "SELECT COUNT(*) FROM Person WHERE cin = @cin"
            Dim cmd As New OleDbCommand(sqlQry, Connection)
            cmd.Parameters.AddWithValue("@cin", cin)
            Dim count = Convert.ToInt32(cmd.ExecuteScalar())

            If count <= 0 Then
                erreur_cinNotFound_l.Visible = True
                edite_l.Visible = False
                erreur_l.Visible = False
                Return
            End If

            'Get email
            sqlQry = "SELECT email FROM Login WHERE cin = @cin"
            Dim cmd1 As New OleDbCommand(sqlQry, Connection)
            cmd1.Parameters.AddWithValue("@cin", cin)
            Dim email As String = cmd1.ExecuteScalar().ToString()

            'Get student_id
            sqlQry = "SELECT student_id FROM Person WHERE cin = @cin"
            Dim cmd2 As New OleDbCommand(sqlQry, Connection)
            cmd2.Parameters.AddWithValue("@cin", cin)
            student_id = Convert.ToInt64(cmd2.ExecuteScalar())

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
            Dim dateDeNaissance As Date = Convert.ToDateTime(cmd5.ExecuteScalar())

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
            birthdate_picker.Value = dateDeNaissance
            sex_cb.Text = sex
            filiere_cb.Text = filiere
            'scores
            note1_tb.Text = note1
            note2_tb.Text = note2
            note3_tb.Text = note3
            note4_tb.Text = note4
            note5_tb.Text = note5
            note6_tb.Text = note6
            note7_tb.Text = note7

        Catch ex As Exception
            'MessageBox.Show(ex.Message, "Erreur")
        End Try
    End Sub

    Private Sub etudiantCIN_search_tb_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles etudiantCIN_search_tb.TextChanged
        erreur_cinNotFound_l.Visible = False
        edite_l.Visible = False
        erreur_l.Visible = False
    End Sub

    'Repated Code
    Private Sub Edit()

        'Create connection with database
        Dim Connection = LoginPage.Connection
        If Connection.State = ConnectionState.Closed Then
            Connection.Open()
        End If

        Try
            'Update student information
            Dim sqlQry As String = "UPDATE Student SET filiere = @filiere WHERE student_id = @student_id"
            Dim cmd As New OleDbCommand(sqlQry, Connection)
            cmd.Parameters.AddWithValue("@filiere", filiere_cb.Text)
            cmd.Parameters.AddWithValue("@student_id", student_id)
            cmd.ExecuteNonQuery()
            'Update person information
            sqlQry = "UPDATE Person SET cin = @cin, nom = @nom, prenom = @prenom, date_de_naissance = @date_de_naissance, sex = @sex WHERE student_id = @student_id"
            Dim cmd3 As New OleDbCommand(sqlQry, Connection)
            cmd3.Parameters.AddWithValue("@cin", cin_tb.Text)
            cmd3.Parameters.AddWithValue("@nom", nom_tb.Text)
            cmd3.Parameters.AddWithValue("@prenom", prenom_tb.Text)
            cmd3.Parameters.Add("@date_de_naissance", OleDbType.DBDate).Value = DateValue(birthdate_picker.Value.ToString())
            cmd3.Parameters.AddWithValue("@sex", GetSex())
            cmd3.Parameters.AddWithValue("@student_id", student_id)
            cmd3.ExecuteNonQuery()
            'Update user information
            sqlQry = "UPDATE Login SET username = @username, passwrd = @psswrd, email = @email WHERE cin = @cin"
            Dim cmd4 As New OleDbCommand(sqlQry, Connection)
            cmd4.Parameters.AddWithValue("@username", email_tb.Text.Split("@")(0))
            cmd4.Parameters.AddWithValue("@psswrd", email_tb.Text.Split("@")(0) & "123")
            cmd4.Parameters.AddWithValue("@email", email_tb.Text)
            cmd4.Parameters.AddWithValue("@cin", cin_tb.Text)
            cmd4.ExecuteNonQuery()
            'Update student scores information
            sqlQry = "UPDATE Score SET score = @score WHERE course_id = @course_id AND student_id = @student_id"
            Dim cmd5 As New OleDbCommand(sqlQry, Connection)
            'score 1 Programmation Avancee
            cmd5.Parameters.AddWithValue("@score", Double.Parse(note1_tb.Text))
            cmd5.Parameters.AddWithValue("@course_id", 1)
            cmd5.Parameters.AddWithValue("@student_id", student_id)
            cmd5.ExecuteNonQuery()
            'score 2 Programmation Evenmentielle
            cmd5.Parameters.Clear()
            cmd5.Parameters.AddWithValue("@score", Double.Parse(note2_tb.Text))
            cmd5.Parameters.AddWithValue("@course_id", 2)
            cmd5.Parameters.AddWithValue("@student_id", student_id)
            cmd5.ExecuteNonQuery()
            'score 3 Base de donnees
            cmd5.Parameters.Clear()
            cmd5.Parameters.AddWithValue("@score", Double.Parse(note3_tb.Text))
            cmd5.Parameters.AddWithValue("@course_id", 3)
            cmd5.Parameters.AddWithValue("@student_id", student_id)
            cmd5.ExecuteNonQuery()
            'score 4 Systemes d'exploitation
            cmd5.Parameters.Clear()
            cmd5.Parameters.AddWithValue("@score", Double.Parse(note4_tb.Text))
            cmd5.Parameters.AddWithValue("@course_id", 4)
            cmd5.Parameters.AddWithValue("@student_id", student_id)
            cmd5.ExecuteNonQuery()
            'score 5 Analyse
            cmd5.Parameters.Clear()
            cmd5.Parameters.AddWithValue("@score", Double.Parse(note5_tb.Text))
            cmd5.Parameters.AddWithValue("@course_id", 5)
            cmd5.Parameters.AddWithValue("@student_id", student_id)
            cmd5.ExecuteNonQuery()
            'score 6 Statistique
            cmd5.Parameters.Clear()
            cmd5.Parameters.AddWithValue("@score", Double.Parse(note6_tb.Text))
            cmd5.Parameters.AddWithValue("@course_id", 6)
            cmd5.Parameters.AddWithValue("@student_id", student_id)
            cmd5.ExecuteNonQuery()
            'score 7 Electronique analogique
            cmd5.Parameters.Clear()
            cmd5.Parameters.AddWithValue("@score", Double.Parse(note7_tb.Text))
            cmd5.Parameters.AddWithValue("@course_id", 7)
            cmd5.Parameters.AddWithValue("@student_id", student_id)
            cmd5.ExecuteNonQuery()
        Catch ex As Exception
            'MessageBox.Show(ex.Message, "Erreur")
        End Try
    End Sub
    'sauvgarder les donnees
    Private Sub modifier_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles modifier_btn.Click
        erreur_l.Visible = CheckInputs()

        If CheckInputs() Then
            edite_l.Visible = False
            erreur_cinNotFound_l.Visible = False
            Return
        End If

        Edit()
        edite_l.Visible = True
        erreur_cinNotFound_l.Visible = False
        erreur_l.Visible = False
    End Sub

    Private Function CheckInputs() As Boolean
        Dim IsError As Boolean = False

        'CIN
        If Not CheckCINInput() Then
            cin_l.ForeColor = Color.Red
            IsError = True
        Else
            cin_l.ForeColor = Color.Gray
        End If
        'Nom
        If Not CheckNomInput() Then
            nom_l.ForeColor = Color.Red
            IsError = True
        Else
            nom_l.ForeColor = Color.Gray
        End If
        'Prenom
        If Not CheckPrenomInput() Then
            prenom_l.ForeColor = Color.Red
            IsError = True
        Else
            prenom_l.ForeColor = Color.Gray
        End If
        'Email
        If Not CheckEmailInput() Then
            email_l.ForeColor = Color.Red
            IsError = True
        Else
            email_l.ForeColor = Color.Gray
        End If
        'Sex
        If Not CheckSexInput() Then
            sexe_l.ForeColor = Color.Red
            IsError = True
        Else
            sexe_l.ForeColor = Color.Gray
        End If
        'Filiere
        If Not CheckFiliereInput() Then
            filiere_l.ForeColor = Color.Red
            IsError = True
        Else
            filiere_l.ForeColor = Color.Gray
        End If
        'Notes
        If Not CheckNotesInput() Then
            IsError = True
        End If
        Return IsError
    End Function

    Private Function CheckCINInput() As Boolean
        Try
            If Not Char.IsLetter(cin_tb.Text(0)) Then
                Return False
            ElseIf Not Char.IsLetterOrDigit(cin_tb.Text(1)) Then
                Return False
            ElseIf Not IsNumeric(cin_tb.Text.Remove(0, 2)) Then
                Return False
            End If
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Private Function CheckNomInput() As Boolean
        If String.IsNullOrEmpty(nom_tb.Text) Or String.IsNullOrWhiteSpace(nom_tb.Text) Or Not IsAplha(nom_tb.Text) Or nom_tb.ForeColor = Color.Gray Then
            Return False
        End If
        Return True
    End Function

    Private Function CheckPrenomInput() As Boolean
        If String.IsNullOrEmpty(prenom_tb.Text) Or String.IsNullOrWhiteSpace(prenom_tb.Text) Or Not IsAplha(prenom_tb.Text) Or prenom_tb.ForeColor = Color.Gray Then
            Return False
        End If
        Return True
    End Function

    Private Function CheckEmailInput() As Boolean
        Dim email As String = email_tb.Text

        Dim splits() As String = email.Split("@")
        If splits.Length <> 2 Then
            Return False
        End If

        Dim splits2() As String = splits(1).Split(".")
        If splits2.Length <> 2 Then
            Return False
        End If

        If Not (IsAlphaNumeric(splits(0)) And IsAplha(splits2(0)) And IsAplha(splits2(1))) Then
            Return False
        End If

        Return True
    End Function

    Private Function CheckSexInput() As Boolean
        If String.IsNullOrEmpty(sex_cb.Text) Then
            Return False
        End If
        Return True
    End Function

    Private Function CheckFiliereInput() As Boolean
        If String.IsNullOrEmpty(filiere_cb.Text) Then
            Return False
        End If
        Return True
    End Function

    Private Function CheckNotesInput() As Boolean

        Dim value As Double
        Dim isNoError As Boolean = True

        'note 1
        Try
            value = Double.Parse(note1_tb.Text)
            If value < 0 Or value > 20 Then
                Throw New Exception("score is not between 0 and 20")
            End If
            note1_l.ForeColor = Color.Gray
        Catch ex As Exception
            note1_l.ForeColor = Color.Red
            isNoError = False
        End Try

        'note 2
        Try
            value = Double.Parse(note2_tb.Text)
            If value < 0 Or value > 20 Then
                Throw New Exception("score is not between 0 and 20")
            End If
            note2_l.ForeColor = Color.Gray
        Catch ex As Exception
            note2_l.ForeColor = Color.Red
            isNoError = False
        End Try

        'note 3
        Try
            value = Double.Parse(note3_tb.Text)
            If value < 0 Or value > 20 Then
                Throw New Exception("score is not between 0 and 20")
            End If
            note3_l.ForeColor = Color.Gray
        Catch ex As Exception
            note3_l.ForeColor = Color.Red
            isNoError = False
        End Try

        'note 4
        Try
            value = Double.Parse(note4_tb.Text)
            If value < 0 Or value > 20 Then
                Throw New Exception("score is not between 0 and 20")
            End If
            note4_l.ForeColor = Color.Gray
        Catch ex As Exception
            note4_l.ForeColor = Color.Red
            isNoError = False
        End Try

        'note(5)
        Try
            value = Double.Parse(note5_tb.Text)
            If value < 0 Or value > 20 Then
                Throw New Exception("score is not between 0 and 20")
            End If
            note5_l.ForeColor = Color.Gray
        Catch ex As Exception
            note5_l.ForeColor = Color.Red
            isNoError = False
        End Try

        'note 6
        Try
            value = Double.Parse(note6_tb.Text)
            If value < 0 Or value > 20 Then
                Throw New Exception("score is not between 0 and 20")
            End If
            note6_l.ForeColor = Color.Gray
        Catch ex As Exception
            note6_l.ForeColor = Color.Red
            isNoError = False
        End Try

        'note 7
        Try
            value = Double.Parse(note7_tb.Text)
            If value < 0 Or value > 20 Then
                Throw New Exception("score is not between 0 and 20")
            End If
            note7_l.ForeColor = Color.Gray
        Catch ex As Exception
            note7_l.ForeColor = Color.Red
            isNoError = False
        End Try

        Return isNoError
    End Function

    'Tools
    Private Function IsAplha(ByVal str As String) As Boolean
        Dim alpha As Regex = New Regex("[^a-zA-Z]")

        If alpha.IsMatch(str) Then
            Return False
        End If
        Return True
    End Function

    Private Function IsNumeric(ByVal str As String) As Boolean
        Dim numeric As Regex = New Regex("[^0-9]")

        If numeric.IsMatch(str) Then
            Return False
        End If
        Return True
    End Function

    Private Function ContainNumeric(ByVal str As String) As Boolean
        For index = 0 To str.Length - 1
            If Char.IsDigit(str(index)) Then
                Return True
            End If
        Next
        Return False
    End Function

    Private Function IsAlphaNumeric(ByVal str As String) As Boolean
        Dim alphaNumeric As Regex = New Regex("[^a-zA-Z0-9]")

        If alphaNumeric.IsMatch(str) Then
            Return False
        End If
        Return True
    End Function
    Function GetSex() As Boolean
        If sex_cb.Text = "Male" Then
            Return True
        Else
            Return False
        End If
    End Function

    Sub ClearUI()
        etudiantCIN_search_tb.Text = ""
        erreur_cinNotFound_l.Visible = False

        cin_tb.Text = ""
        nom_tb.Text = ""
        prenom_tb.Text = ""
        email_tb.Text = ""
        birthdate_picker.Value = Date.Now
        sex_cb.SelectedIndex = 0
        filiere_cb.SelectedIndex = 0
        'scores
        note1_tb.Text = ""
        note2_tb.Text = ""
        note3_tb.Text = ""
        note4_tb.Text = ""
        note5_tb.Text = ""
        note6_tb.Text = ""
        note7_tb.Text = ""

        erreur_l.Visible = False
        edite_l.Visible = False
    End Sub
End Class