Public Class Form1


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If (Val(TextBox1.Text) > 0 And Val(TextBox1.Text) <= 115) Then
            If (Val(TextBox1.Text) >= 1 And Val(TextBox1.Text) <= 4) Then
                TextBox2.Text = "Eres un niño/a"
                TextBox1.ReadOnly = True

            ElseIf (Val(TextBox1.Text) >= 5 And Val(TextBox1.Text) <= 9) Then
                TextBox2.Text = "Eres un Parvulo/a"
                TextBox1.ReadOnly = True

            ElseIf (Val(TextBox1.Text) >= 10 And Val(TextBox1.Text) <= 12) Then
                TextBox2.Text = "Eres un/una Pre-Adolescente"
                TextBox1.ReadOnly = True

            ElseIf (Val(TextBox1.Text) >= 13 And Val(TextBox1.Text) <= 17) Then
                TextBox2.Text = "Eres un/una Adolescente"
                TextBox1.ReadOnly = True

            ElseIf (Val(TextBox1.Text) >= 18 And Val(TextBox1.Text) <= 30) Then
                TextBox2.Text = "Eres un Joven"
                TextBox1.ReadOnly = True

            ElseIf (Val(TextBox1.Text) > 30 And Val(TextBox1.Text) <= 60) Then
                TextBox2.Text = "Eres un Adulto/a"
                TextBox1.ReadOnly = True

            ElseIf (Val(TextBox1.Text) > 60 And Val(TextBox1.Text) <= 115) Then
                TextBox2.Text = "Eres una persona de tercera edad"
                TextBox1.ReadOnly = True
            End If
        Else
            TextBox2.Text = "ERROR: Ingrese un numero valido"

        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        End
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TextBox1.Clear()
        TextBox2.Clear()

        TextBox1.ReadOnly = False
    End Sub
End Class
