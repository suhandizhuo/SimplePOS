Public Class frmMenuUtama
    Private Sub frmMenuUtama_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BuatTable()
    End Sub

    Private Sub btnDaftarItem_Click(sender As Object, e As EventArgs) Handles btnDaftarItem.Click
        frmDaftarItem.Show()
    End Sub
End Class
