Public Class Books
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Application.Exit()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim nextMain As New Books()
        Main.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles AddBook.Click
        'Dim nextAddBook As New Add_Book()
        'nextAddBook.Owner = Me  ' Set the Books form as the owner of the Add_Book form
        'Next
        Add_Book.Show()
        Me.Hide()
    End Sub

    Private Sub Books_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Table1TableAdapter.Fill(Me.BookDataBaseNew2DataSet.Table1)
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            Me.Table1TableAdapter.Fill(Me.BookDataBaseNew2DataSet.Table1)
            DataGridView1.Refresh()
            MessageBox.Show("Data refreshed successfully!")
        Catch ex As Exception
            MessageBox.Show("Error refreshing data: " & ex.Message)
        End Try
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles BookNameSearch.TextChanged
        Try
            Dim filter As String = BookNameSearch.Text.Trim()

            If String.IsNullOrEmpty(filter) Then
                Table1BindingSource.RemoveFilter()
            Else
                Table1BindingSource.Filter = $"BookName LIKE '%{filter}%'"
            End If
        Catch ex As Exception
            MessageBox.Show("Error filtering data: " & ex.Message)
        End Try
    End Sub

    ' Method to refresh DataGridView after adding a new book
    Public Sub RefreshDataGridView()
        Me.Table1TableAdapter.Fill(Me.BookDataBaseNew2DataSet.Table1)
        DataGridView1.Refresh()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If DataGridView1.SelectedRows.Count > 0 Then

            Dim selectedRowIndex As Integer = DataGridView1.SelectedRows(0).Index

            Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete this row?", "Confirm Delete", MessageBoxButtons.YesNo)

            If result = DialogResult.Yes Then
                DataGridView1.Rows.RemoveAt(selectedRowIndex)
                Table1TableAdapter.Update(BookDataBaseNew2DataSet.Table1)
            End If
        Else
            MessageBox.Show("Please select a row to delete.", "No Row Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning)

        End If
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Table1BindingSource.EndEdit()
        Table1TableAdapter.Update(BookDataBaseNew2DataSet.Table1)
        MessageBox.Show("Data has been Updated!")
    End Sub
End Class
