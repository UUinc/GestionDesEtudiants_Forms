Imports System.Data.OleDb

Public Class SupprimerPage

    Private Sub back_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles back_btn.Click
        AdminPage.Show()
        AdminPage.Location = Me.Location
        Me.Hide()
    End Sub

    Private Sub supprimer_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles supprimer_btn.Click
        'Load data from db
        'Create connection with database
        Dim Connection = LoginPage.Connection
        If Connection.State = ConnectionState.Closed Then
            Connection.Open()
        End If

        Try
            'Get student_id
            Dim sqlQry = "SELECT student_id FROM Person WHERE cin = @cin"
            Dim cmd As New OleDbCommand(sqlQry, Connection)
            cmd.Parameters.AddWithValue("@cin", cin_tb.Text)

            If vbEmpty = cmd.ExecuteScalar() Then
                erreur_l.Visible = True
                Return
            End If

            Dim student_id As Long = Convert.ToInt64(cmd.ExecuteScalar())

            'Delete student information
            sqlQry = "DELETE FROM Student WHERE student_id = @student_id"
            Dim cmd2 As New OleDbCommand(sqlQry, Connection)
            cmd2.Parameters.AddWithValue("@student_id", student_id)
            cmd2.ExecuteNonQuery()

            MessageBox.Show("Deleted")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Erreur")
        End Try
    End Sub

    Private Sub cin_tb_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cin_tb.TextChanged
        erreur_l.Visible = False
    End Sub
End Class