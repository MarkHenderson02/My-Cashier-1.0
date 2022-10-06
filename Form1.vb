Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub

    Private Sub tbJumlah_TextChanged(sender As Object, e As EventArgs) Handles tbJumlah.TextChanged
        tbSubTotal.Text = Val(tbHarga.Text) * Val(tbJumlah.Text)
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        tbHarga.Text = ""
        tbJumlah.Text = ""
        tbSubTotal.Text = ""
    End Sub

    Public total As Double = 0
    Private Sub btnPlus_Click(sender As Object, e As EventArgs) Handles btnPlus.Click
        Dim subtotal As Double
        Dim isidata As String

        subtotal = Val(tbSubTotal.Text)
        total = total + subtotal
        tbTotal.Text = total
        isidata = cmbMenu.Text + vbTab + tbHarga.Text + vbTab + tbJumlah.Text + vbTab + tbSubTotal.Text
        lbIsiData.Items.Add(isidata)
        tbHarga.Text = ""
        tbJumlah.Text = ""
        tbSubTotal.Text = ""
    End Sub

    Private Sub tbKembali_TextChanged(sender As Object, e As EventArgs) Handles tbKembali.TextChanged

    End Sub

    Private Sub tbBayar_TextChanged(sender As Object, e As EventArgs) Handles tbBayar.TextChanged
        Dim bayar, kembali As Double

        bayar = Val(tbBayar.Text)
        kembali = bayar - total
        tbKembali.Text = kembali
    End Sub

    Private Sub tbBayar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbBayar.KeyPress
        Dim kembali As Double
        If (e.KeyChar = vbCr) Then
            kembali = Val(tbKembali.Text)
            If kembali < 0 Then
                MsgBox("Maaf Pembayaran Anda Kurang")
            Else
                MsgBox("Terima Kasih Atas Pembayaran Anda")
            End If
        End If

    End Sub
End Class
