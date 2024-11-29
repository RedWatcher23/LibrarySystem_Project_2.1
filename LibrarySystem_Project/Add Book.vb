Public Class Add_Book
    Public Sub ClearTextBoxes()
        TextBoxBookName.Text = ""
        TextBoxBookAuthor.Text = ""
        TextBoxBookPrice.Text = ""
        TextBoxBookPublication.Text = ""
        TextBoxBookQuantity.Text = ""
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim nextBooks As New Books()
        Books.Show()
        Me.Hide()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Application.Exit()
    End Sub

    Private Sub Add_Book_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ClearTextBoxes()
        Me.Table1TableAdapter.Fill(Me.BookDataBaseNew2DataSet.Table1)
    End Sub

    Private Sub ButtonClear_Click(sender As Object, e As EventArgs) Handles ButtonClear.Click
        ClearTextBoxes()
    End Sub

    Private Sub ButtonAdd_Click(sender As Object, e As EventArgs) Handles ButtonAdd.Click
        Table1BindingSource.AddNew()
    End Sub

    Private Sub ButtonSave_Click(sender As Object, e As EventArgs) Handles ButtonSave.Click
        Table1BindingSource.EndEdit()
        Table1TableAdapter.Update(BookDataBaseNew2DataSet.Table1)
        MessageBox.Show("Data saved successfully!")

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub
End Class
