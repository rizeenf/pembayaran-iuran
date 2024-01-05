Public Class Form3
    Public bayar As Integer
    Public uang As Integer
    Public kasir As String
    Public pembeli As String
    Dim uangKembalian As Integer

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        bayar = Form2.totalBayar
        uang = Form2.uangCust
        kasir = Form2.namaKasir
        pembeli = Form2.namaPembeli

        Label4.Text = kasir
        Label5.Text = pembeli

        Label15.Text = bayar
        Label16.Text = uang

        uangKembalian = uang - bayar
        Label17.Text = uangKembalian

    End Sub


End Class