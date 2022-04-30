Imports System.Text.RegularExpressions
Imports System.Data.OleDb

Public Class AjouterPage
    Private Sub back_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles back_btn.Click
        ClearUI()

        AdminPage.Show()
        AdminPage.Location = Me.Location
        Me.Hide()
    End Sub

    Private Sub Save()

        'Create connection with database
        Dim Connection = LoginPage.Connection
        If Connection.State = ConnectionState.Closed Then
            Connection.Open()
        End If

        Try
            'Fill student information
            Dim sqlQry As String = "INSERT INTO Student(filiere) VALUES(@filiere)"
            Dim cmd As New OleDbCommand(sqlQry, Connection)
            cmd.Parameters.AddWithValue("@filiere", filiere_cb.Text)
            cmd.ExecuteNonQuery()

            sqlQry = "SELECT @@IDENTITY"
            Dim cmd2 As New OleDbCommand(sqlQry, Connection)
            Dim cmd_result As Long = CInt(cmd2.ExecuteScalar())

            'Fill person information
            sqlQry = "INSERT INTO Person(cin, nom, prenom, date_de_naissance, sex, student_id) VALUES(@cin, @nom, @prenom, @date_de_naissance, @sex, @student_id)"
            Dim cmd3 As New OleDbCommand(sqlQry, Connection)
            cmd3.Parameters.AddWithValue("@cin", cin_tb.Text)
            cmd3.Parameters.AddWithValue("@nom", nom_tb.Text)
            cmd3.Parameters.AddWithValue("@prenom", prenom_tb.Text)
            cmd3.Parameters.Add("@date_de_naissance", OleDbType.DBDate).Value = DateValue(birthdate_picker.Value.ToString())
            cmd3.Parameters.AddWithValue("@sex", GetSex())
            cmd3.Parameters.AddWithValue("@student_id", cmd_result)
            cmd3.ExecuteNonQuery()

            'Fill user information
            sqlQry = "INSERT INTO Login(username, passwrd, email, permission, cin) VALUES(@username, @psswrd, @email, @permission, @cin)"
            Dim cmd4 As New OleDbCommand(sqlQry, Connection)
            cmd4.Parameters.AddWithValue("@username", email_tb.Text.Split("@")(0))
            cmd4.Parameters.AddWithValue("@psswrd", email_tb.Text.Split("@")(0) & "123")
            cmd4.Parameters.AddWithValue("@email", email_tb.Text)
            cmd4.Parameters.AddWithValue("@permission", False)
            cmd4.Parameters.AddWithValue("@cin", cin_tb.Text)
            cmd4.ExecuteNonQuery()

            'Fill student scores information
            sqlQry = "INSERT INTO Score(score, course_id, student_id) VALUES(@score, @course_id, @student_id)"
            Dim cmd5 As New OleDbCommand(sqlQry, Connection)
            'score 1 Programmation Avancee
            cmd5.Parameters.AddWithValue("@score", Double.Parse(note1_tb.Text))
            cmd5.Parameters.AddWithValue("@course_id", 1)
            cmd5.Parameters.AddWithValue("@student_id", cmd_result)
            cmd5.ExecuteNonQuery()
            'score 2 Programmation Evenmentielle
            cmd5.Parameters.Clear()
            cmd5.Parameters.AddWithValue("@score", Double.Parse(note2_tb.Text))
            cmd5.Parameters.AddWithValue("@course_id", 2)
            cmd5.Parameters.AddWithValue("@student_id", cmd_result)
            cmd5.ExecuteNonQuery()
            'score 3 Base de donnees
            cmd5.Parameters.Clear()
            cmd5.Parameters.AddWithValue("@score", Double.Parse(note3_tb.Text))
            cmd5.Parameters.AddWithValue("@course_id", 3)
            cmd5.Parameters.AddWithValue("@student_id", cmd_result)
            cmd5.ExecuteNonQuery()
            'score 4 Systemes d'exploitation
            cmd5.Parameters.Clear()
            cmd5.Parameters.AddWithValue("@score", Double.Parse(note4_tb.Text))
            cmd5.Parameters.AddWithValue("@course_id", 4)
            cmd5.Parameters.AddWithValue("@student_id", cmd_result)
            cmd5.ExecuteNonQuery()
            'score 5 Analyse
            cmd5.Parameters.Clear()
            cmd5.Parameters.AddWithValue("@score", Double.Parse(note5_tb.Text))
            cmd5.Parameters.AddWithValue("@course_id", 5)
            cmd5.Parameters.AddWithValue("@student_id", cmd_result)
            cmd5.ExecuteNonQuery()
            'score 6 Statistique
            cmd5.Parameters.Clear()
            cmd5.Parameters.AddWithValue("@score", Double.Parse(note6_tb.Text))
            cmd5.Parameters.AddWithValue("@course_id", 6)
            cmd5.Parameters.AddWithValue("@student_id", cmd_result)
            cmd5.ExecuteNonQuery()
            'score 7 Electronique analogique
            cmd5.Parameters.Clear()
            cmd5.Parameters.AddWithValue("@score", Double.Parse(note7_tb.Text))
            cmd5.Parameters.AddWithValue("@course_id", 7)
            cmd5.Parameters.AddWithValue("@student_id", cmd_result)
            cmd5.ExecuteNonQuery()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Erreur")
        End Try
    End Sub
    'sauvgarder les donnees
    Private Sub save_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles save_btn.Click
        erreur_l.Visible = CheckInputs()
        
        If CheckInputs() Then
            Return
        End If

        Save()
        MessageBox.Show("saved")
    End Sub

    Private Function CheckInputs() As Boolean
        Dim IsError As Boolean = False

        'CIN
        If Not CheckCINInput() Then
            cin_tb.ForeColor = Color.Red
            IsError = True
        End If
        'Nom
        If Not CheckNomInput() Then
            nom_tb.ForeColor = Color.Red
            IsError = True
        End If
        'Prenom
        If Not CheckPrenomInput() Then
            prenom_tb.ForeColor = Color.Red
            IsError = True
        End If
        'Email
        If Not CheckEmailInput() Then
            email_tb.ForeColor = Color.Red
            IsError = True
        End If
        'Sex
        If Not CheckSexInput() Then
            sex_cb.ForeColor = Color.Red
            IsError = True
        End If
        'Filiere
        If Not CheckFiliereInput() Then
            filiere_cb.ForeColor = Color.Red
            IsError = True
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
    End Sub
End Class