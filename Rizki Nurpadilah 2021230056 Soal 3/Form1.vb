Public Class Form1
    Dim nilai1 As Integer
    Dim nilai2 As Integer
    Dim total As Double
    Dim namaPengunjung As String
    Dim namaPengunjung2 As String




    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        TambahPengunjung()

        Label1.Text = "Rizki Nurpadilah - 2021230056 - Soal 3"
        Label2.Text = " "
        Label3.Text = "" 'Hasil perhitungan
        Label4.Text = "Login sebagai : " + namaPengunjung

        Button1.Text = "+"
        Button2.Text = "-"
        Button3.Text = "/"
        Button4.Text = "x"
        Button5.Text = " = "
        Button6.Text = "Clear"
        Button7.Text = "ON/OFF"
        Button8.Text = "Ganti user"


        EnabledAll()


    End Sub

    Sub EnabledAll()
        TextBox1.Enabled = False
        TextBox2.Enabled = False
        Button2.Enabled = False
        Button1.Enabled = False
        Button3.Enabled = False
        Button4.Enabled = False
        Button5.Enabled = False
        Button6.Enabled = False
        Button8.Enabled = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Label2.Text = Button1.Text
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Label2.Text = Button2.Text
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Label2.Text = Button3.Text
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Label2.Text = Button4.Text
    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        nilai1 = Val(TextBox1.Text)
        nilai2 = Val(TextBox2.Text)
        total = 0


        If nilai1 = 0 Then
            MsgBox("Nilai yang pertama belum dimasukkan atau salah")
        End If

        If nilai2 = 0 Then
            MsgBox("Nilai yang kedua belum dimasukkan atau salah")
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
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click


        If Button1.Enabled = False Then
            MsgBox("Haloo " + namaPengunjung + ", Selamat datang!!" + vbNewLine + "Saya aplikasi Rizki Nurpadilah - Kalkulator")
            DisabledAll()
            ClearAll()
        Else
            MsgBox("Terima kasih " + namaPengunjung + ", Selamat tinggal!!" + vbNewLine + "Jangan lupa berkunjung lagi ke aplikasi Rizki Nurpadilah - Kalkulator")
            EnabledAll()
            ClearAll()
        End If

    End Sub

    Sub DisabledAll()
        TextBox1.Enabled = True
        TextBox2.Enabled = True
        Button2.Enabled = True
        Button1.Enabled = True
        Button3.Enabled = True
        Button4.Enabled = True
        Button5.Enabled = True
        Button6.Enabled = True
        Button8.Enabled = True
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        TambahPengunjung()
        Label4.Text = "Login sebagai : " + namaPengunjung

    End Sub
    Sub TambahPengunjung()
        namaPengunjung = InputBox("Halo, Siapa nama anda?").ToUpper
    End Sub

End Class
