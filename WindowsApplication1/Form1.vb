Public Class Clase4
    Dim calculo As String

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click

        Select Case calculo
            Case "Cuadrado"
                Dim num As Integer = txtDerecho.Text
                Dim devuelve As Integer = cuadrado(num)
                txtRespuesta.Text = devuelve
            Case "Rectangulo"
                Dim num As Integer = txtDerecho.Text
                Dim num2 As Integer = txtIzquierdo.Text
                Dim devuelve As Integer = rectangulo(num, num2)
                txtRespuesta.Text = devuelve
            Case "Triangulo"
                Dim num As Integer = txtDerecho.Text
                Dim num2 As Integer = txtIzquierdo.Text
                Dim devuelve As Integer = triangulo(num, num2)
                txtRespuesta.Text = devuelve
            Case "Paralelogramo"
                Dim num As Integer = txtDerecho.Text
                Dim num2 As Integer = txtIzquierdo.Text
                Dim devuelve As Integer = paralelogramo(num, num2)
                txtRespuesta.Text = devuelve
            Case ""
                MessageBox.Show("Debe elegir algun metodo")
        End Select

    End Sub
    Function cuadrado(a As Integer)
        Dim total As Integer = a * a
        Return total
    End Function

    Function rectangulo(a As Integer, b As Integer)
        Dim total As Integer = a * b
        Return total
    End Function

    Function triangulo(a As Integer, h As Integer)
        Dim total As Integer = (a * h) / 2
        Return total
    End Function

    Function paralelogramo(a As Integer, h As Integer)
        Dim total As Integer = a * h
        Return total
    End Function

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxAreas.SelectedIndexChanged
        calculo = cbxAreas.SelectedItem
        Select Case calculo
            Case "Cuadrado"
                calculo = "Cuadrado"
                txtDerecho.Visible = True
                lbDerecho.Visible = True
                lbIzquierdo.Visible = False
                txtIzquierdo.Visible = False
            Case "Rectangulo"
                calculo = "Rectangulo"
                txtDerecho.Visible = True
                txtIzquierdo.Visible = True
                lbDerecho.Visible = True
                lbIzquierdo.Visible = True
            Case "Triangulo"
                calculo = "Triangulo"
                txtDerecho.Visible = True
                txtIzquierdo.Visible = True
                lbDerecho.Visible = True
                lbIzquierdo.Visible = True
            Case "Paralelogramo"
                calculo = "Paralelogramo"
                txtDerecho.Visible = True
                txtIzquierdo.Visible = True
                lbDerecho.Visible = True
                lbIzquierdo.Visible = True
        End Select
    End Sub
End Class