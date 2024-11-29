Public Class Main
    Private Sub Label1_Click(sender As Object, e As EventArgs)
        Dim nextBook As New Books()
        Books.Show()
        Me.Hide()

        For Each ctrl As Control In Me.Controls
            If TypeOf ctrl Is Label Then
                ctrl.BackColor = Color.Transparent
            End If
        Next

        ' Highlight the clicked label
        Dim lbl As Label = DirectCast(sender, Label)
        lbl.BackColor = Color.Orange


    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button_Exit.Click
        Application.Exit()
    End Sub



    Private Sub Button_ReturnBooks_Click(sender As Object, e As EventArgs) Handles Button_ReturnBooks.Click
        Dim nextReturnBook As New Books()
        Return_Books.Show()
        Me.Hide()
    End Sub

    Private Sub Button_IssueBooks_Click(sender As Object, e As EventArgs) Handles Button_IssueBooks.Click
        Dim nextIssueBook As New Books()
        Issue_Book.Show()
        Me.Hide()
    End Sub

    Private Sub Button_Books_Click(sender As Object, e As EventArgs) Handles Button_Books.Click
        Dim nextBook As New Books()
        Books.Show()
        Me.Hide()
    End Sub
End Class