Public Class Form1
    Dim user1 As String = "admin"
    Dim user2 As String = "user"
    Dim user3 As String = "rizki"
    Dim inputUser As String
    Dim inputPass As String



    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = "Silahkan login"
        Label5.Text = "Username"
        Label6.Text = "Password"
        Label7.Text = "List user (username/password) : "
        Label2.Text = user1 + "/" + user1
        Label3.Text = user2 + "/" + user2
        Label4.Text = user3 + "/" + user3
        Button1.Text = "Login"
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox2.PasswordChar = "*"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        inputUser = TextBox1.Text
        inputPass = TextBox2.Text

        'Cek kosong
        CekInputKosong(TextBox1, TextBox2)

        'Cek valid and go to next page
        CekValidateUser(inputUser, inputPass)

        'clear 
        ClearLogin(TextBox1, TextBox2)
    End Sub

    Sub CekValidateUser(inputUser As String, inputPass As String)
        Dim berhasil As String = "Anda berhasil login sebagai "

        If inputUser = user1 And inputPass = user1 Then
            MsgBox(berhasil + user1)
            Form2.Show()
            Me.Hide()
        ElseIf inputUser = user2 And inputPass = user2 Then
            MsgBox(berhasil + user2)
            Form2.Show()
            Me.Hide()
        ElseIf inputUser = user3 And inputPass = user3 Then
            MsgBox(berhasil + user3)
            Form2.Show()
            Me.Hide()
        Else
            MsgBox("Akses tidak ada, anda gagal login !")
        End If

    End Sub

    Sub CekInputKosong(TextBox1 As TextBox, TextBox2 As TextBox)
        If TextBox1.Text = "" Then
            MsgBox("Silahkan masukkan username terlebih dahulu !")
            TextBox1.Focus()
        End If

        If TextBox2.Text = "" Then
            MsgBox("Silahkan masukkan password terlebih dahulu !")
            TextBox1.Focus()
        End If
    End Sub

    Sub ClearLogin(TextBox1 As TextBox, TextBox2 As TextBox)
        TextBox1.Text = ""
        TextBox2.Text = ""
    End Sub

End Class
