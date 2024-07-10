Public Class frmDaftarItem
    Private Sub frmDaftarItem_Load(sender As Object, e As EventArgs) Handles Me.Load
        DataItem()
        TampilkanData()
        itemDS.Tables("Item").DefaultView.RowFilter = "nama_barang='" & "0" & "'"
    End Sub

    Sub TampilkanData()
        With dgvData
            .DataSource = mdlConn.itemDS.Tables("Item")
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
            .Columns(0).HeaderText = "Kode Item"
            .Columns(1).HeaderText = "Nama Barang"
            .Columns(2).HeaderText = "Qty"
            .Columns(3).HeaderText = "Supplier"
            .Columns(4).HeaderText = "Harga Jual"
            .Columns(5).HeaderText = "Harga Beli"
            .Columns(6).HeaderText = "Satuan"
            .Columns(0).Width = 70
            .Columns(1).Width = 300
            .Columns(2).Width = 50
            .Columns(3).Width = 200
            .Columns(4).Width = 150
            .Columns(5).Width = 150
            .Columns(6).Width = 70
        End With
    End Sub

    Private Sub cbTampil_CheckedChanged(sender As Object, e As EventArgs) Handles cbTampil.CheckedChanged
        If cbTampil.CheckState = CheckState.Checked Then
            itemDS.Tables("Item").DefaultView.RowFilter = ""
        Else
            itemDS.Tables("Item").DefaultView.RowFilter = "nama_barang='" & "0" & "'"
        End If

    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        If txtSearch.Text = "" Then
            itemDS.Tables("Item").DefaultView.RowFilter = "nama_barang='" & "0" & "'"
        Else
            itemDS.Tables("Item").DefaultView.RowFilter = "nama_barang like '" & txtSearch.Text & "%'"
        End If
    End Sub
End Class