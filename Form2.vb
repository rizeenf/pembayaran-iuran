Public Class Form2
    Dim item As String
    Dim quantity As Integer
    Dim price As Integer
    Dim disc As Integer
    Dim discRp As Integer
    Dim total As Integer
    Dim totalAfterDisc As Integer
    Dim totalAfterPPN As Double
    Public totalBayar As Integer
    Public uangCust As Integer
    Public namaKasir As String
    Public namaPembeli As String
    Dim PPN As Double

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.ContextMenuStrip = ContextMenuStrip1

        Label1.Text = "List item"
        Button1.Text = "Pilih item"
        Button2.Enabled = False
        Button4.Enabled = False
        Button6.Enabled = False
        Button7.Enabled = False
        Button5.Enabled = False


        TextBox1.Enabled = False
        TextBox2.Enabled = False

        TextBox3.Enabled = False
        TextBox4.Enabled = False
        TextBox5.Enabled = False
        TextBox6.Enabled = False
        TextBox7.Enabled = False
        TextBox8.Enabled = False
        TextBox9.Enabled = False
        TextBox12.Enabled = False
        TextBox13.Enabled = False


        GroupBox3.Hide()
        GroupBox4.Hide()

        Dim barang(3) As String
        barang(0) = "IURAN KREDIT MOTOR"
        barang(1) = "IURAN KREDIT MOBIL"
        barang(2) = "IURAN KREDIT RUMAH"
        barang(3) = "KREDIT LAINNYA"


        ItemQuantity()
        ListBarang(barang)
        ListDiskon()

        With DataGridView1
            .ColumnCount = 3
            .Columns(0).Name = "Item"
            .Columns(0).Width = 185

            .Columns(1).Name = "Qty"
            .Columns(1).Width = 50

            .Columns(2).Name = "Harga"
            .Columns(2).Width = 100


        End With

    End Sub

    Sub ListBarang(barang)
        For Each item As String In barang
            ComboBox1.Items.Add(item)
        Next
    End Sub

    Sub ItemQuantity()
        Dim i As Integer
        For i = 1 To 1
            ComboBox2.Items.Add(i)
        Next
    End Sub
    Sub ListDiskon()
        ComboBox3.Items.Add(0)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        'popup qty dan harga
        item = ComboBox1.SelectedItem()

        quantity = ComboBox2.SelectedItem()
        price = Val(InputBox("Masukkan Harga"))
        disc = ComboBox3.SelectedItem()


        'cek Qty
        CekQty(quantity, price)

        'input label (qty dan harga) di form 
        TextBox1.Text = item
        TextBox2.Text = quantity
        TextBox3.Text = price

        GroupBox4.Show()
        TextBox4.Text = CekHarga(quantity, price)   'Cek harga sebelum diskon
        TextBox7.Text = ComboBox3.SelectedItem()    'Diskon
        TextBox5.Text = CalcDiscount(disc, total)   'Nominal Diskon
        TextBox6.Text = TotalHargaExPPN(total, discRp)   'Harga bersih sblm PPN
        TextBox9.Text = TotalPPN(totalAfterDisc)   'Harga bersih
        TextBox12.Text = TotalHarga(totalAfterDisc, PPN)   'Harga bersih + PPN


        GroupBox3.Show()
        Button2.Show()

    End Sub

    Sub CekQty(qty As Integer, price As Integer)
        If qty <= 0 Then
            MsgBox("Anda belum memasukkan qty")
        End If
        If price <= 0 Then
            MsgBox("Anda belum memasukkan harga")
        End If
    End Sub

    Function CekHarga(qty As Integer, price As Integer) As Integer
        CekHarga = qty * price
        total = CekHarga

        Return CekHarga
    End Function

    Function TotalPPN(harga As Integer) As Integer
        TotalPPN = harga * 0.11
        PPN = TotalPPN
        Return TotalPPN
    End Function

    Function TotalHargaExPPN(harga As Integer, disc As Integer) As Integer
        TotalHargaExPPN = harga - disc
        totalAfterDisc = TotalHargaExPPN
        Return TotalHargaExPPN
    End Function

    Function TotalHarga(totalAfterDisc As Double, PPN As Double) As Integer
        TotalHarga = totalAfterDisc + PPN
        totalAfterPPN = TotalHarga
        Return TotalHarga
    End Function

    Function CalcDiscount(disc As Integer, price As Integer) As Integer
        CalcDiscount = (disc / 100) * price
        discRp = CalcDiscount
        Return CalcDiscount
    End Function

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        MetodeDebit()
        MetodeCash()
        Button4.Enabled = True
        Button3.Enabled = False
        namaKasir = TextBox10.Text
        namaPembeli = TextBox11.Text
    End Sub
    Sub MetodeCash()
        If TextBox10.Text = "" Then
            MsgBox("Masukkan nama Kasir terlebih dahulu !")
        Else
            TextBox10.Enabled = False
            Button2.Enabled = True
        End If

    End Sub

    Sub MetodeDebit()
        If TextBox11.Text = "" Then
            MsgBox("Masukkan nama pembeli terlebih dahulu")
        Else
            TextBox11.Enabled = False
            Button2.Enabled = True
        End If

    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs)
        Button2.Enabled = True


    End Sub

    Sub ResetAll()
        ComboBox1.Text = ""
        ComboBox2.Text = ""
        ComboBox3.Text = ""
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""
        TextBox7.Text = ""
        TextBox9.Text = ""
        TextBox12.Text = ""


        GroupBox3.Hide()
        GroupBox4.Hide()
        Button2.Hide()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        EditKasir()
        Button4.Enabled = False
        Button3.Enabled = True
    End Sub

    Sub EditKasir()
        TextBox10.Enabled = True
        TextBox11.Enabled = True
        Button2.Enabled = False
    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TambahKeKeranjang()

        totalBayar += totalAfterPPN
        TextBox13.Text = totalBayar

        Button6.Enabled = True
        Button7.Enabled = True
        Button5.Enabled = True

        ResetAll()
    End Sub

    Sub TambahKeKeranjang()
        DataGridView1.Rows.Add(1)
        DataGridView1.Rows(DataGridView1.RowCount - 2).Cells(0).Value = item
        DataGridView1.Rows(DataGridView1.RowCount - 2).Cells(1).Value = quantity
        DataGridView1.Rows(DataGridView1.RowCount - 2).Cells(2).Value = totalAfterPPN
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click

        If DataGridView1.CurrentRow.Index <> DataGridView1.NewRowIndex Then
            DataGridView1.Rows.RemoveAt(DataGridView1.CurrentRow.Index)
            totalBayar -= DataGridView1.CurrentRow.Cells(2).Value
            TextBox13.Text = totalBayar
        Else
            MsgBox("Pilih item yang ingin dihapus")
        End If
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        DataGridView1.Rows.Clear()
        totalBayar = 0
        TextBox13.Text = totalBayar
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim berhasil As String = "Total Bayar anda sebesar  : "

        If totalBayar = 0 Then
            MsgBox("Anda belum belanja !")
        Else
            MsgBox(berhasil + totalBayar.ToString())
            uangCust = Val(InputBox("Masukkan Uang Customer !"))
            CekUangCust()
        End If

    End Sub

    Sub CekUangCust()
        If uangCust < totalBayar Then
            MsgBox("Uang Customer Kurang !!!")

        Else
            Form3.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub FormLoginToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FormLoginToolStripMenuItem.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub RefreshToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RefreshToolStripMenuItem.Click
        ResetAll()
        DataGridView1.Rows.Clear()
        totalBayar = 0
        TextBox13.Text = totalBayar

    End Sub

    Private Sub CopyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopyToolStripMenuItem.Click
        Me.Hide()
    End Sub
End Class