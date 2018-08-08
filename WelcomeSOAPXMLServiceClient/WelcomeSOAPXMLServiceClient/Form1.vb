Public Class Form1
    Private client As New ServiceReference1.Service1Client

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub submitButton_Click(sender As Object, e As EventArgs) Handles submitButton.Click
        MessageBox.Show(client.Welcome(TextBox1.Text))


    End Sub
End Class
