Public Class Form1

    Dim NotaCorteI As Double = 0
    Dim NotaCorteII As Double = 0
    Dim NotaCorteIII As Double = 0

    Private Sub BlockStudentInfo()

        TextBox1.ReadOnly = True
        TextBox2.ReadOnly = True
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        ' CALCULAR CORTE I
        NotaCorteI = (Val(TextBox3.Text) * 0.15) + (Val(TextBox4.Text) * 0.15)
        TextBox13.Text = (NotaCorteI / 6) * 20
        TextBox14.Text = ((Val(TextBox13.Text) / 20)) * 30

        BlockStudentInfo()
        TextBox4.ReadOnly = True
        TextBox3.ReadOnly = True

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

        ' CALCULAR CORTE II
        NotaCorteII = (Val(TextBox5.Text) * 0.1) + (Val(TextBox6.Text) * 0.15) + (Val(TextBox7.Text) * 0.05)
        TextBox16.Text = (NotaCorteII / 6) * 20
        TextBox15.Text = ((Val(TextBox16.Text)) / 20) * 30

        BlockStudentInfo()
        TextBox5.ReadOnly = True
        TextBox6.ReadOnly = True
        TextBox7.ReadOnly = True
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click

        ' CALCULAR CORTE III
        NotaCorteIII = ((Val(TextBox8.Text) * 0.2) + (Val(TextBox9.Text) * 0.1) + (Val(TextBox10.Text) * 0.1))
        TextBox18.Text = (NotaCorteIII / 8) * 20
        TextBox17.Text = ((Val(TextBox18.Text)) / 20) * 40

        BlockStudentInfo()
        TextBox8.ReadOnly = True
        TextBox9.ReadOnly = True
        TextBox10.ReadOnly = True
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        ' ACTIVAR BOTONES
        Button4.PerformClick()
        Button5.PerformClick()
        Button6.PerformClick()

        ' RESULTADO FINAL
        TextBox11.Text = NotaCorteI + NotaCorteII + NotaCorteIII
        TextBox12.Text = Val(TextBox14.Text) + Val(TextBox15.Text) + Val(TextBox17.Text)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        ' LIMPIAR
        For Each control As Control In Me.Controls
            If TypeOf control Is TextBox Then

                control.Text = ""
            End If
        Next

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        End
    End Sub
End Class
