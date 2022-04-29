Public Class SupprimerPage

    Private Sub back_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles back_btn.Click
        AdminPage.Show()
        AdminPage.Location = Me.Location
        Me.Hide()
    End Sub
End Class