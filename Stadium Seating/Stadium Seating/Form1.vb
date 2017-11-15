Public Class Form1

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        lblResult.Text = ""
        textbox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        LabelA.Text = ""
        LabelB.Text = ""
        LabelC.Text = ""
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim dblTotalRevenue As Double
        LabelA.Text = CDbl(textbox1.Text) * 15
        LabelB.Text = CDbl(TextBox2.Text) * 12
        LabelC.Text = CDbl(TextBox3.Text) * 9
        dblTotalRevenue = CDbl(textbox1.Text) * 15 + CDbl(TextBox2.Text) * 12 + CDbl(TextBox3.Text) * 9

        lblResult.Text = dblTotalRevenue.ToString("c")
    End Sub
End Class
