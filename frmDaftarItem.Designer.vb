<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDaftarItem
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDaftarItem))
        Panel1 = New Panel()
        cbTampil = New CheckBox()
        btnHapus = New Button()
        btnEdit = New Button()
        btnBaru = New Button()
        btnRefresh = New Button()
        txtSearch = New TextBox()
        Label1 = New Label()
        Panel2 = New Panel()
        dgvData = New DataGridView()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        CType(dgvData, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(cbTampil)
        Panel1.Controls.Add(btnHapus)
        Panel1.Controls.Add(btnEdit)
        Panel1.Controls.Add(btnBaru)
        Panel1.Controls.Add(btnRefresh)
        Panel1.Controls.Add(txtSearch)
        Panel1.Controls.Add(Label1)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1189, 106)
        Panel1.TabIndex = 0
        ' 
        ' cbTampil
        ' 
        cbTampil.AutoSize = True
        cbTampil.Location = New Point(103, 40)
        cbTampil.Name = "cbTampil"
        cbTampil.Size = New Size(119, 19)
        cbTampil.TabIndex = 11
        cbTampil.Text = "Tampilkan Semua"
        cbTampil.UseVisualStyleBackColor = True
        ' 
        ' btnHapus
        ' 
        btnHapus.Location = New Point(271, 65)
        btnHapus.Name = "btnHapus"
        btnHapus.Size = New Size(78, 23)
        btnHapus.TabIndex = 10
        btnHapus.Text = "Hapus Item"
        btnHapus.UseVisualStyleBackColor = True
        ' 
        ' btnEdit
        ' 
        btnEdit.Location = New Point(187, 65)
        btnEdit.Name = "btnEdit"
        btnEdit.Size = New Size(78, 23)
        btnEdit.TabIndex = 9
        btnEdit.Text = "Edit Item"
        btnEdit.UseVisualStyleBackColor = True
        ' 
        ' btnBaru
        ' 
        btnBaru.Location = New Point(103, 65)
        btnBaru.Name = "btnBaru"
        btnBaru.Size = New Size(78, 23)
        btnBaru.TabIndex = 8
        btnBaru.Text = "Item Baru"
        btnBaru.UseVisualStyleBackColor = True
        ' 
        ' btnRefresh
        ' 
        btnRefresh.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnRefresh.Image = My.Resources.Resources.icon_refresh
        btnRefresh.Location = New Point(1135, 6)
        btnRefresh.Name = "btnRefresh"
        btnRefresh.Size = New Size(42, 31)
        btnRefresh.TabIndex = 3
        btnRefresh.UseVisualStyleBackColor = True
        ' 
        ' txtSearch
        ' 
        txtSearch.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        txtSearch.Location = New Point(103, 11)
        txtSearch.Name = "txtSearch"
        txtSearch.Size = New Size(1026, 23)
        txtSearch.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(12, 14)
        Label1.Name = "Label1"
        Label1.Size = New Size(85, 15)
        Label1.TabIndex = 0
        Label1.Text = "Nama Barang :"
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(dgvData)
        Panel2.Dock = DockStyle.Fill
        Panel2.Location = New Point(0, 106)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1189, 522)
        Panel2.TabIndex = 1
        ' 
        ' dgvData
        ' 
        dgvData.AllowUserToAddRows = False
        dgvData.AllowUserToDeleteRows = False
        dgvData.AllowUserToResizeRows = False
        dgvData.BackgroundColor = Color.White
        dgvData.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single
        dgvData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvData.Dock = DockStyle.Fill
        dgvData.Location = New Point(0, 0)
        dgvData.Name = "dgvData"
        dgvData.ReadOnly = True
        dgvData.RowHeadersVisible = False
        dgvData.Size = New Size(1189, 522)
        dgvData.TabIndex = 0
        ' 
        ' frmDaftarItem
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(1189, 628)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "frmDaftarItem"
        Text = "Daftar Item"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        CType(dgvData, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnRefresh As Button
    Friend WithEvents btnHapus As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnBaru As Button
    Friend WithEvents dgvData As DataGridView
    Friend WithEvents cbTampil As CheckBox
End Class
