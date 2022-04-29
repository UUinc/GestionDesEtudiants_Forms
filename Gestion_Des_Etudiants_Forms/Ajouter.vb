Imports System.Text.RegularExpressions
Imports System.Data.OleDb

Public Class AjouterPage
    Private Sub back_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles back_btn.Click
        AdminPage.Show()
        AdminPage.Location = Me.Location
        Me.Hide()

        'sex placeholder
        Sex_placeholder.Visible = True
        'filiere placeholder
        filiere_placeholder.Visible = True
    End Sub
    'CIN Text Box
    Private Sub cin_tb_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cin_tb.Enter
        If cin_tb.Text = "CIN" Then
            cin_tb.Text = ""
        End If
        cin_tb.ForeColor = Color.Black
    End Sub

    Private Sub cin_tb_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cin_tb.Leave
        If cin_tb.Text = "" Then
            cin_tb.Text = "CIN"
            cin_tb.ForeColor = Color.Gray
        End If
    End Sub
    'Nom Text Box
    Private Sub nom_tb_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nom_tb.Enter
        If nom_tb.Text = "Nom" Then
            nom_tb.Text = ""
        End If
        nom_tb.ForeColor = Color.Black
    End Sub

    Private Sub nom_tb_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nom_tb.Leave
        If nom_tb.Text = "" Then
            nom_tb.Text = "Nom"
            nom_tb.ForeColor = Color.Gray
        End If
    End Sub
    'Prenom Text Box
    Private Sub prenom_tb_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles prenom_tb.Enter
        If prenom_tb.Text = "Prenom" Then
            prenom_tb.Text = ""
        End If
        prenom_tb.ForeColor = Color.Black
    End Sub

    Private Sub prenom_tb_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles prenom_tb.Leave
        If prenom_tb.Text = "" Then
            prenom_tb.Text = "Prenom"
            prenom_tb.ForeColor = Color.Gray
        End If
    End Sub
    'Email Text Box
    Private Sub email_tb_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles email_tb.Enter
        If email_tb.Text = "Email" Then
            email_tb.Text = ""
        End If
        email_tb.ForeColor = Color.Black
    End Sub

    Private Sub email_tb_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles email_tb.Leave
        If email_tb.Text = "" Then
            email_tb.Text = "Email"
            email_tb.ForeColor = Color.Gray
        End If
    End Sub

    Private Sub sex_CB_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sex_cb.SelectedIndexChanged
        Sex_placeholder.Visible = False
    End Sub

    Private Sub filiere_CB_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles filiere_cb.SelectedIndexChanged
        filiere_placeholder.Visible = False
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
            cmd4.Parameters.AddWithValue("@username", email_tb.Text)
            cmd4.Parameters.AddWithValue("@psswrd", email_tb.Text)
            cmd4.Parameters.AddWithValue("@email", email_tb.Text)
            cmd4.Parameters.AddWithValue("@permission", False)
            cmd4.Parameters.AddWithValue("@cin", cin_tb.Text)
            cmd4.ExecuteNonQuery()
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
            Sex_placeholder.ForeColor = Color.Red
            IsError = True
        End If
        'Filiere
        If Not CheckFiliereInput() Then
            filiere_placeholder.ForeColor = Color.Red
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
End Class