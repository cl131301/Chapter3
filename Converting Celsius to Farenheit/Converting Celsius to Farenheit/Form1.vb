Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim F As Double

        F = CDbl(C.Text) * 1.8 + 32
        lblResults.Text = F
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        lblResults.Text = ""
        C.Clear()
    End Sub

End Class
