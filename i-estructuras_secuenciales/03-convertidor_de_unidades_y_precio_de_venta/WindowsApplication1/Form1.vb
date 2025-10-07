Public Class Form1


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        ' KILOMETROS A METROS
        TextBox2.Text = Val(TextBox1.Text) * 1000
        TextBox1.ReadOnly = True

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        ' HORAS A SEGUNDOS
        TextBox4.Text = Val(TextBox3.Text) * 3600
        TextBox3.ReadOnly = True

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        ' RESULTADO FINAL
        Button1.PerformClick()
        Button2.PerformClick()

        TextBox5.Text = Val(TextBox2.Text) / Val(TextBox4.Text)

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        ' SALIR
        End

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

        ' LIMPIAR
        Application.Restart()

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' ENFOCAR AL PRIMER TEXTBOX
        TextBox1.Focus()

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click

        ' IR AL FORM2
        Form2.Show()
        Me.Hide()

    End Sub
End Class
