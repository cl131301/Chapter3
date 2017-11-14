Public Class Form1

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnCalculateMPG_Click(sender As Object, e As EventArgs) Handles btnCalculateMPG.Click
        Dim dblMPG As Double
        dblMPG = CDbl(TextBox2.Text) / CDbl(TextBox1.Text)
        lblResult.Text = dblMPG
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        lblResult.Text = ""
        TextBox1.Clear()
        TextBox2.Clear()
    End Sub
End Class
