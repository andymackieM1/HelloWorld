Public Class HelloWorld
    Private Sub HelloWorld_Load(sender As Object, e As EventArgs) Handles Me.Load

        With Me
            .Text = "Hello World"
            .cmdHelloWorld.Text = .Text
            .StartPosition = FormStartPosition.CenterScreen
        End With

    End Sub

    Private Sub cmdHelloWorld_Click(sender As Object, e As EventArgs) Handles cmdHelloWorld.Click

        MessageBox.Show(Me.Text, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

    End Sub
End Class
