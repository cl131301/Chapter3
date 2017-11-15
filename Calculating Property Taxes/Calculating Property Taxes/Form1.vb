Public Class Form1

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        lblResult.Text = ""
        TextBox1.Clear()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim dblPropertyValue As Double
        dblPropertyValue = (CDbl(TextBox1.Text) * 0.6) * 0.0064
        lblResult.Text = dblPropertyValue.ToString("c")
    End Sub

End Class
