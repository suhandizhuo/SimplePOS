Imports System.Data.SqlClient
Imports Windows.Win32.System

Module mdlConn
    Public sqlconn As SqlConnection
    Public sqlcmd As SqlCommand
    Public sqlreader As SqlDataReader
    Public sqladapter As SqlDataAdapter
    Public sqldataset As DataSet
    Public sqlcmb As SqlCommandBuilder
    Public itemDS As DataSet = New DataSet
    Public conn As String = "server=DESKTOP-4T4C40E\SQLEXPRESS;Database=DBPos;Integrated Security=True"

    'Fungsi untuk membuat Table yang diperlukan
    Sub BuatTable()
        With itemDS.Tables
            .Add("Item")
            .Add("Supplier")
            .Add("Pelanggan")
            .Add("Satuan")
            .Add("Penjualan")
            .Add("Pembelian")
            .Add("detJual")
            .Add("detBeli")
        End With
    End Sub

    'Fungsi untuk memanggil data dengan cmd sebagai Command dan table sebagai table tujuan
    Sub CallData(cmd As String, table As String)
        Try
            itemDS.Tables(table).Clear()
            Using sqlconn As New SqlConnection(conn)
                sqlconn.Open()
                Dim sqladapter As New SqlDataAdapter(cmd, sqlconn)
                sqladapter.Fill(itemDS.Tables(table))
            End Using
        Catch Ex As Exception
            MsgBox(Ex.Message)
        End Try
    End Sub

    'Memanggil data-data yang diperlukan untuk Item
    Sub DataItem()
        Dim cmd As String = "SELECT kode_item, nama_barang, qty, nama_supplier, harga_jual, harga_beli, satuan FROM tbl_item i
LEFT JOIN tbl_supplier k ON i.id_supplier = k.id_supplier
LEFT JOIN tbl_satuan j ON i.id_satuan = j.id_satuan"
        CallData(cmd, "Item")
        cmd = "SELECT * FROM tbl_supplier"
        CallData(cmd, "Supplier")
        cmd = "SELECT * FROM tbl_pelanggan"
        CallData(cmd, "Pelanggan")
        cmd = "SELECT * FROM tbl_satuan"
        CallData(cmd, "Satuan")
    End Sub

End Module
