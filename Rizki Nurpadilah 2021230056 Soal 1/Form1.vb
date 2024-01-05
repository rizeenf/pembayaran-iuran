Public Class Form1
    Dim nilai1 As Double
    Dim nilai2 As Double
    Dim total As Double

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.AutoSize = False
        TextBox1.Height = 30
        TextBox2.AutoSize = False
        TextBox2.Height = 30
        Label3.AutoSize = False
        Label3.Height = 25

        Label1.Text = "Rizki Nurpadilah - 2021230056 - Soal 1"
        Label2.Text = " "
        Label3.Text = "" 'Hasil perhitungan

        RadioButton1.Text = "Penjumlahan"
        RadioButton2.Text = "Pengurangan"
        RadioButton3.Text = "Perkalian"
        RadioButton4.Text = "Pembagian"
        Button5.Text = " = "
        Button6.Text = "Bersihkan"

    End Sub

    Private Sub RadioButton1_Click(sender As Object, e As EventArgs) Handles RadioButton1.Click
        Label2.Text = "+"
    End Sub

    Private Sub RadioButton2_Click(sender As Object, e As EventArgs) Handles RadioButton2.Click
        Label2.Text = "-"
    End Sub
    Private Sub RadioButton3_Click(sender As Object, e As EventArgs) Handles RadioButton3.Click
        Label2.Text = "x"
    End Sub
    Private Sub RadioButton4_Click(sender As Object, e As EventArgs) Handles RadioButton4.Click
        Label2.Text = "/"
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        nilai1 = Val(TextBox1.Text)
        nilai2 = Val(TextBox2.Text)
        total = 0

        If nilai1 = 0 Then
            MsgBox("Nilai yang pertama belum dimasukkan atau salah")
            TextBox1.Select()
        End If

        If nilai2 = 0 Then
            MsgBox("Nilai yang kedua belum dimasukkan atau salah")
            TextBox2.Select()
        End If

        If Label2.Text = " " Then
            MsgBox("Silahkan pilih operator")
        End If

        Kalkulasi(Label2)
    End Sub

    Sub Kalkulasi(ByRef label As Label)
        If label.Text = "+" Then
            Penjumlahan(nilai1, nilai2)
        End If
        If label.Text = "-" Then
            Pengurangan(nilai1, nilai2)
        End If
        If label.Text = "/" Then
            Pembagian(nilai1, nilai2)
        End If
        If label.Text = "x" Then
            Perkalian(nilai1, nilai2)
        End If
    End Sub

    Function Penjumlahan(ByVal number1 As Integer, ByVal number2 As Integer)
        Penjumlahan = number1 + number2
        Label3.Text = Penjumlahan
    End Function
    Function Perkalian(ByVal number1 As Integer, ByVal number2 As Integer)
        Perkalian = number1 * number2
        Label3.Text = Perkalian
    End Function
    Function Pengurangan(ByVal number1 As Integer, ByVal number2 As Integer)
        Pengurangan = number1 - number2
        Label3.Text = Pengurangan
    End Function
    Function Pembagian(ByVal number1 As Integer, ByVal number2 As Integer)
        Pembagian = number1 / number2
        Label3.Text = Pembagian
    End Function

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        ClearAll()
    End Sub

    Sub ClearAll()
        Label2.Text = " "
        Label3.Text = ""
        TextBox1.Text = ""
        TextBox2.Text = ""
        RadioButton1.Checked = False
        RadioButton2.Checked = False
        RadioButton3.Checked = False
        RadioButton4.Checked = False
    End Sub

End Class
