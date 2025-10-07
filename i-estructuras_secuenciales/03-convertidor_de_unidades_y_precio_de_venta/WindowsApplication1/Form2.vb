Public Class Form2


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        ' (((10 * 0.3) + 10) * 0.16) + ((10 * 0.3) + 10)
        ' TextBox2.Text = (((Val(TextBox1.Text) * 0.3) + 10) * 0.16) + ((Val(TextBox1.Text)) * 0.3) + Val(TextBox1.Text)

        TextBox4.Text = (Val(TextBox1.Text) * 0.3)
        TextBox5.Text = ((Val(TextBox4.Text) + Val(TextBox1.Text)) * 0.16)

        TextBox2.Text = Val(TextBox5.Text) + Val(TextBox4.Text) + Val(TextBox1.Text)
        TextBox3.Text = Math.Round(Val(TextBox2.Text) / 177.61, 2)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        End
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Application.Restart()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Form1.Show()
        Me.Hide()
    End Sub
End Class