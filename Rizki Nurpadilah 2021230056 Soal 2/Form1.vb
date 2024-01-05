Public Class Form1
    Dim cuaca As String
    Dim jarak As String
    Dim transportasi As String
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Button1.Select()
        ClearAll()

    End Sub

    Sub ClearAll()
        Button1.Enabled = False
        RadioButton1.Checked = False
        RadioButton2.Checked = False
        RadioButton3.Checked = False
        RadioButton4.Checked = False
        Label3.Text = ""

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Rekomendasi(cuaca, jarak)

    End Sub

    Sub Rekomendasi(ByRef cuaca As String, ByRef jarak As String)
        ''PAKAI OPERATOR AND
        'If cuaca = "cerah" And jarak = "dekat" Then
        '    transportasi = "sepeda"
        'End If
        'If cuaca = "cerah" And jarak = "jauh" Then
        '    transportasi = "mobil"
        'End If
        'If cuaca = "hujan" And jarak = "dekat" Then
        '    transportasi = "payung"
        'End If
        'If cuaca = "hujan" And jarak = "jauh" Then
        '    transportasi = "pesawat"
        'End If


        'PAKAI NESTED IF
        If cuaca = "cerah" Then
            If jarak = "dekat" Then
                transportasi = "Sepeda"
            Else
                transportasi = "Mobil"
            End If
        End If

        If cuaca = "hujan" Then
            If jarak = "dekat" Then
                transportasi = "Payung"
            Else
                transportasi = "Pesawat"
            End If
        End If

        PrintRekomen(transportasi, cuaca, jarak)

    End Sub

    Sub PrintRekomen(ByRef transport As String, ByRef cuaca As String, ByRef jarak As String)
        Label3.Text = "Silahkan naik : " + transport + vbNewLine + "Karena cuaca sedang " + cuaca + " dan jaraknya " + jarak
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        cuaca = "cerah"
        CekCuacaDanJarak()
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        cuaca = "hujan"
        CekCuacaDanJarak()
    End Sub

    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton4.CheckedChanged
        jarak = "dekat"
        CekCuacaDanJarak()

    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        jarak = "jauh"
        CekCuacaDanJarak()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ClearAll()

    End Sub

    Function CekCuaca()
        If RadioButton1.Checked Or RadioButton2.Checked Then
            CekCuaca = True
        Else
            CekCuaca = False
        End If

    End Function

    Function CekJarak()
        If RadioButton3.Checked Or RadioButton4.Checked Then
            CekJarak = True
        Else
            CekJarak = False
        End If
    End Function
    Sub CekCuacaDanJarak()
        If CekCuaca() And CekJarak() Then
            Button1.Enabled = True
        End If

    End Sub
End Class
