Public Class Form1
    Private Sub BtnCalculate_Click(sender As Object, e As EventArgs) Handles BtnCalculate.Click
        Const intMaksima As Integer = 40
        Dim intJumlahPelajar As Integer
        intJumlahPelajar = JumlahPelajar.Value
        Dim intMakmal As Integer

        intMakmal = Math.Ceiling(intJumlahPelajar / intMaksima)
        lblJumlahMakmal.Text = intMakmal.ToString & "  makmal yang diperlukan"
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
