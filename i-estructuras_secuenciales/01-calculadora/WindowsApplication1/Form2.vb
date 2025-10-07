Public Class Form2
    ' CALCULADORA

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        ' SUMA 
        TextBox3.Text = Val(TextBox1.Text) + Val(TextBox2.Text)
        TextBox1.Enabled = False
        TextBox2.Enabled = False

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

        ' LIMPIAR
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()

        TextBox1.Enabled = True
        TextBox2.Enabled = True

        TextBox1.Focus()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        ' RESTA
        TextBox3.Text = Val(TextBox1.Text) - Val(TextBox2.Text)
        TextBox1.Enabled = False
        TextBox2.Enabled = False

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        ' MULTIPLICAR
        TextBox3.Text = Val(TextBox1.Text) * Val(TextBox2.Text)
        TextBox1.Enabled = False
        TextBox2.Enabled = False

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        ' DIVIDIR
        TextBox3.Text = Val(TextBox1.Text) / Val(TextBox2.Text)
        TextBox1.Enabled = False
        TextBox2.Enabled = False

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click

        ' SALIR
        End

    End Sub
End Class