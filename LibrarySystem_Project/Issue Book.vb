Public Class Issue_Book
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Application.Exit()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim nextMain As New Books()
        Main.Show()
        Me.Hide()
    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub Issue_Book_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'StudentRecord1DataSet11.Table1' table. You can move, or remove it, as needed.
        Me.Table1TableAdapter1.Fill(Me.StudentRecord1DataSet11.Table1)
        'TODO: This line of code loads data into the 'BookDataBaseNew2DataSet.Table1' table. You can move, or remove it, as needed.
        Me.Table1TableAdapter.Fill(Me.BookDataBaseNew2DataSet.Table1)



    End Sub

    Private Sub IssueBookButton_Click(sender As Object, e As EventArgs) Handles IssueBookButton.Click
        Table1BindingSource1.AddNew()
    End Sub

    Private Sub ButtonSave_Click(sender As Object, e As EventArgs) Handles ButtonSave.Click
        Table1BindingSource1.EndEdit()
        Table1TableAdapter1.Update(StudentRecord1DataSet11.Table1)
        Table1TableAdapter.Update(BookDataBaseNew2DataSet.Table1)
        MessageBox.Show("Data saved successfully!")
    End Sub
End Class