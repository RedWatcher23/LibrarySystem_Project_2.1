Public Class Return_Books
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles ButtonExit.Click
        Application.Exit()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles ButtonMain.Click
        Dim nextMain As New Books()
        Main.Show()
        Me.Hide()
    End Sub

    Private Sub Return_Books_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'StudentRecord1DataSet.Table1' table. You can move, or remove it, as needed.
        Me.Table1TableAdapter.Fill(Me.StudentRecord1DataSet.Table1)


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles ButtonRefresh.Click
        Try
            Me.Table1TableAdapter.Fill(Me.StudentRecord1DataSet.Table1)
            DataGridView2.Refresh()
            MessageBox.Show("Data refreshed successfully!")
        Catch ex As Exception
            MessageBox.Show("Error refreshing data: " & ex.Message)
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles ButtonRemove.Click
        If DataGridView2.SelectedRows.Count > 0 Then

            Dim selectedRowIndex As Integer = DataGridView2.SelectedRows(0).Index

            Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete this row?", "Confirm Delete", MessageBoxButtons.YesNo)

            If result = DialogResult.Yes Then
                DataGridView2.Rows.RemoveAt(selectedRowIndex)
                Table1TableAdapter.Update(StudentRecord1DataSet.Table1)
            End If
        Else
            MessageBox.Show("Please select a row to delete.", "No Row Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning)

        End If
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellContentClick

    End Sub

    Private Sub TextBoxSearch_TextChanged(sender As Object, e As EventArgs) Handles TextBoxSearch.TextChanged

    End Sub

    Private Sub ButtonSearchStudent_Click(sender As Object, e As EventArgs) Handles ButtonSearchStudent.Click

    End Sub
End Class