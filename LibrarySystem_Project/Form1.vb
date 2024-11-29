Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim adminUsername As String = "admin"
        Dim adminPassword As String = "password123"


        Dim inputUsername As String = TextBox1.Text
        Dim inputPassword As String = TextBox2.Text


        If inputUsername = adminUsername AndAlso inputPassword = adminPassword Then
            MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Dim nextMain As New Main()
            nextMain.Show()
            Me.Hide()
        Else
            MessageBox.Show("Invalid username or password. Please try again.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub
End Class
