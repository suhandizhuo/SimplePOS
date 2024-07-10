<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMenuUtama
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMenuUtama))
        Panel2 = New Panel()
        Button1 = New Button()
        Label1 = New Label()
        TabControl1 = New TabControl()
        TabPage1 = New TabPage()
        Splitter3 = New Splitter()
        Panel1 = New Panel()
        Button5 = New Button()
        Button4 = New Button()
        Button3 = New Button()
        Label3 = New Label()
        Splitter2 = New Splitter()
        Panel3 = New Panel()
        btnDaftarItem = New Button()
        Label2 = New Label()
        Splitter1 = New Splitter()
        TabPage2 = New TabPage()
        Splitter4 = New Splitter()
        Panel4 = New Panel()
        Button6 = New Button()
        Label4 = New Label()
        TabPage3 = New TabPage()
        Splitter5 = New Splitter()
        Panel5 = New Panel()
        Button7 = New Button()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        Panel2.SuspendLayout()
        TabControl1.SuspendLayout()
        TabPage1.SuspendLayout()
        Panel1.SuspendLayout()
        Panel3.SuspendLayout()
        TabPage2.SuspendLayout()
        Panel4.SuspendLayout()
        TabPage3.SuspendLayout()
        Panel5.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(Button1)
        Panel2.Controls.Add(Label1)
        Panel2.Dock = DockStyle.Left
        Panel2.Location = New Point(0, 0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(90, 108)
        Panel2.TabIndex = 2
        ' 
        ' Button1
        ' 
        Button1.Dock = DockStyle.Left
        Button1.FlatAppearance.BorderSize = 0
        Button1.FlatAppearance.MouseDownBackColor = Color.Silver
        Button1.FlatAppearance.MouseOverBackColor = Color.Gainsboro
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Image = My.Resources.Resources.icon_home
        Button1.Location = New Point(0, 0)
        Button1.Name = "Button1"
        Button1.Size = New Size(90, 93)
        Button1.TabIndex = 2
        Button1.Text = "Menu Utama"
        Button1.TextAlign = ContentAlignment.BottomCenter
        Button1.TextImageRelation = TextImageRelation.ImageAboveText
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.Dock = DockStyle.Bottom
        Label1.FlatStyle = FlatStyle.Flat
        Label1.ForeColor = Color.SlateGray
        Label1.Location = New Point(0, 93)
        Label1.Name = "Label1"
        Label1.Size = New Size(90, 15)
        Label1.TabIndex = 0
        Label1.Text = "Utama"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' TabControl1
        ' 
        TabControl1.Controls.Add(TabPage1)
        TabControl1.Controls.Add(TabPage2)
        TabControl1.Controls.Add(TabPage3)
        TabControl1.Dock = DockStyle.Top
        TabControl1.Location = New Point(0, 0)
        TabControl1.Name = "TabControl1"
        TabControl1.SelectedIndex = 0
        TabControl1.Size = New Size(1203, 136)
        TabControl1.TabIndex = 2
        ' 
        ' TabPage1
        ' 
        TabPage1.Controls.Add(Splitter3)
        TabPage1.Controls.Add(Panel1)
        TabPage1.Controls.Add(Splitter2)
        TabPage1.Controls.Add(Panel3)
        TabPage1.Controls.Add(Splitter1)
        TabPage1.Controls.Add(Panel2)
        TabPage1.Location = New Point(4, 24)
        TabPage1.Margin = New Padding(0)
        TabPage1.Name = "TabPage1"
        TabPage1.Size = New Size(1195, 108)
        TabPage1.TabIndex = 0
        TabPage1.Text = "Master Data"
        TabPage1.UseVisualStyleBackColor = True
        ' 
        ' Splitter3
        ' 
        Splitter3.BackColor = Color.DarkGray
        Splitter3.Location = New Point(452, 0)
        Splitter3.Name = "Splitter3"
        Splitter3.Size = New Size(1, 108)
        Splitter3.TabIndex = 7
        Splitter3.TabStop = False
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(Button5)
        Panel1.Controls.Add(Button4)
        Panel1.Controls.Add(Button3)
        Panel1.Controls.Add(Label3)
        Panel1.Dock = DockStyle.Left
        Panel1.Location = New Point(182, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(270, 108)
        Panel1.TabIndex = 6
        ' 
        ' Button5
        ' 
        Button5.Dock = DockStyle.Left
        Button5.FlatAppearance.BorderSize = 0
        Button5.FlatAppearance.MouseDownBackColor = Color.Silver
        Button5.FlatAppearance.MouseOverBackColor = Color.Gainsboro
        Button5.FlatStyle = FlatStyle.Flat
        Button5.Image = My.Resources.Resources.icon_saldo_awal
        Button5.Location = New Point(180, 0)
        Button5.Name = "Button5"
        Button5.Size = New Size(90, 93)
        Button5.TabIndex = 5
        Button5.Text = "Daftar Satuan"
        Button5.TextAlign = ContentAlignment.BottomCenter
        Button5.TextImageRelation = TextImageRelation.ImageAboveText
        Button5.UseVisualStyleBackColor = True
        ' 
        ' Button4
        ' 
        Button4.Dock = DockStyle.Left
        Button4.FlatAppearance.BorderSize = 0
        Button4.FlatAppearance.MouseDownBackColor = Color.Silver
        Button4.FlatAppearance.MouseOverBackColor = Color.Gainsboro
        Button4.FlatStyle = FlatStyle.Flat
        Button4.Image = My.Resources.Resources.icon_supplier
        Button4.Location = New Point(90, 0)
        Button4.Name = "Button4"
        Button4.Size = New Size(90, 93)
        Button4.TabIndex = 4
        Button4.Text = "Daftar Supplier"
        Button4.TextAlign = ContentAlignment.BottomCenter
        Button4.TextImageRelation = TextImageRelation.ImageAboveText
        Button4.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Dock = DockStyle.Left
        Button3.FlatAppearance.BorderSize = 0
        Button3.FlatAppearance.MouseDownBackColor = Color.Silver
        Button3.FlatAppearance.MouseOverBackColor = Color.Gainsboro
        Button3.FlatStyle = FlatStyle.Flat
        Button3.Image = My.Resources.Resources.icon_customer
        Button3.Location = New Point(0, 0)
        Button3.Name = "Button3"
        Button3.Size = New Size(90, 93)
        Button3.TabIndex = 3
        Button3.Text = "Daftar Pelanggan"
        Button3.TextAlign = ContentAlignment.BottomCenter
        Button3.TextImageRelation = TextImageRelation.ImageAboveText
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Label3
        ' 
        Label3.Dock = DockStyle.Bottom
        Label3.FlatStyle = FlatStyle.Flat
        Label3.ForeColor = Color.SlateGray
        Label3.Location = New Point(0, 93)
        Label3.Name = "Label3"
        Label3.Size = New Size(270, 15)
        Label3.TabIndex = 0
        Label3.Text = "Data Pendukung"
        Label3.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Splitter2
        ' 
        Splitter2.BackColor = Color.DarkGray
        Splitter2.Location = New Point(181, 0)
        Splitter2.Name = "Splitter2"
        Splitter2.Size = New Size(1, 108)
        Splitter2.TabIndex = 5
        Splitter2.TabStop = False
        ' 
        ' Panel3
        ' 
        Panel3.Controls.Add(btnDaftarItem)
        Panel3.Controls.Add(Label2)
        Panel3.Dock = DockStyle.Left
        Panel3.Location = New Point(91, 0)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(90, 108)
        Panel3.TabIndex = 4
        ' 
        ' btnDaftarItem
        ' 
        btnDaftarItem.Dock = DockStyle.Left
        btnDaftarItem.FlatAppearance.BorderSize = 0
        btnDaftarItem.FlatAppearance.MouseDownBackColor = Color.Silver
        btnDaftarItem.FlatAppearance.MouseOverBackColor = Color.Gainsboro
        btnDaftarItem.FlatStyle = FlatStyle.Flat
        btnDaftarItem.Image = My.Resources.Resources.icon_inventory
        btnDaftarItem.Location = New Point(0, 0)
        btnDaftarItem.Name = "btnDaftarItem"
        btnDaftarItem.Size = New Size(90, 93)
        btnDaftarItem.TabIndex = 4
        btnDaftarItem.Text = "Daftar Item"
        btnDaftarItem.TextAlign = ContentAlignment.BottomCenter
        btnDaftarItem.TextImageRelation = TextImageRelation.ImageAboveText
        btnDaftarItem.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.Dock = DockStyle.Bottom
        Label2.FlatStyle = FlatStyle.Flat
        Label2.ForeColor = Color.SlateGray
        Label2.Location = New Point(0, 93)
        Label2.Name = "Label2"
        Label2.Size = New Size(90, 15)
        Label2.TabIndex = 0
        Label2.Text = "Data Item"
        Label2.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Splitter1
        ' 
        Splitter1.BackColor = Color.DarkGray
        Splitter1.Location = New Point(90, 0)
        Splitter1.Name = "Splitter1"
        Splitter1.Size = New Size(1, 108)
        Splitter1.TabIndex = 3
        Splitter1.TabStop = False
        ' 
        ' TabPage2
        ' 
        TabPage2.Controls.Add(Splitter4)
        TabPage2.Controls.Add(Panel4)
        TabPage2.Location = New Point(4, 24)
        TabPage2.Name = "TabPage2"
        TabPage2.Padding = New Padding(3)
        TabPage2.Size = New Size(1195, 108)
        TabPage2.TabIndex = 1
        TabPage2.Text = "Pembelian"
        TabPage2.UseVisualStyleBackColor = True
        ' 
        ' Splitter4
        ' 
        Splitter4.BackColor = Color.DarkGray
        Splitter4.Location = New Point(93, 3)
        Splitter4.Name = "Splitter4"
        Splitter4.Size = New Size(1, 102)
        Splitter4.TabIndex = 8
        Splitter4.TabStop = False
        ' 
        ' Panel4
        ' 
        Panel4.Controls.Add(Button6)
        Panel4.Controls.Add(Label4)
        Panel4.Dock = DockStyle.Left
        Panel4.Location = New Point(3, 3)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(90, 102)
        Panel4.TabIndex = 3
        ' 
        ' Button6
        ' 
        Button6.Dock = DockStyle.Left
        Button6.FlatAppearance.BorderSize = 0
        Button6.FlatAppearance.MouseDownBackColor = Color.Silver
        Button6.FlatAppearance.MouseOverBackColor = Color.Gainsboro
        Button6.FlatStyle = FlatStyle.Flat
        Button6.Image = My.Resources.Resources.icon_pembelian
        Button6.Location = New Point(0, 0)
        Button6.Name = "Button6"
        Button6.Size = New Size(90, 87)
        Button6.TabIndex = 2
        Button6.Text = "Pembelian"
        Button6.TextAlign = ContentAlignment.BottomCenter
        Button6.TextImageRelation = TextImageRelation.ImageAboveText
        Button6.UseVisualStyleBackColor = True
        ' 
        ' Label4
        ' 
        Label4.Dock = DockStyle.Bottom
        Label4.FlatStyle = FlatStyle.Flat
        Label4.ForeColor = Color.SlateGray
        Label4.Location = New Point(0, 87)
        Label4.Name = "Label4"
        Label4.Size = New Size(90, 15)
        Label4.TabIndex = 0
        Label4.Text = "Pembelian"
        Label4.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' TabPage3
        ' 
        TabPage3.Controls.Add(Splitter5)
        TabPage3.Controls.Add(Panel5)
        TabPage3.Location = New Point(4, 24)
        TabPage3.Name = "TabPage3"
        TabPage3.Padding = New Padding(3)
        TabPage3.Size = New Size(1195, 108)
        TabPage3.TabIndex = 2
        TabPage3.Text = "Penjualan"
        TabPage3.UseVisualStyleBackColor = True
        ' 
        ' Splitter5
        ' 
        Splitter5.BackColor = Color.DarkGray
        Splitter5.Location = New Point(93, 3)
        Splitter5.Name = "Splitter5"
        Splitter5.Size = New Size(1, 102)
        Splitter5.TabIndex = 9
        Splitter5.TabStop = False
        ' 
        ' Panel5
        ' 
        Panel5.Controls.Add(Button7)
        Panel5.Controls.Add(Label5)
        Panel5.Dock = DockStyle.Left
        Panel5.Location = New Point(3, 3)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(90, 102)
        Panel5.TabIndex = 4
        ' 
        ' Button7
        ' 
        Button7.Dock = DockStyle.Left
        Button7.FlatAppearance.BorderSize = 0
        Button7.FlatAppearance.MouseDownBackColor = Color.Silver
        Button7.FlatAppearance.MouseOverBackColor = Color.Gainsboro
        Button7.FlatStyle = FlatStyle.Flat
        Button7.Image = My.Resources.Resources.icon_pembelian
        Button7.Location = New Point(0, 0)
        Button7.Name = "Button7"
        Button7.Size = New Size(90, 87)
        Button7.TabIndex = 2
        Button7.Text = "Penjualan"
        Button7.TextAlign = ContentAlignment.BottomCenter
        Button7.TextImageRelation = TextImageRelation.ImageAboveText
        Button7.UseVisualStyleBackColor = True
        ' 
        ' Label5
        ' 
        Label5.Dock = DockStyle.Bottom
        Label5.FlatStyle = FlatStyle.Flat
        Label5.ForeColor = Color.SlateGray
        Label5.Location = New Point(0, 87)
        Label5.Name = "Label5"
        Label5.Size = New Size(90, 15)
        Label5.TabIndex = 0
        Label5.Text = "Penjualan"
        Label5.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label6
        ' 
        Label6.Font = New Font("Segoe UI", 48F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = Color.DodgerBlue
        Label6.Location = New Point(4, 139)
        Label6.Name = "Label6"
        Label6.Size = New Size(464, 119)
        Label6.TabIndex = 3
        Label6.Text = "Simple POS"
        Label6.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label7
        ' 
        Label7.BackColor = Color.Transparent
        Label7.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label7.ForeColor = Color.DodgerBlue
        Label7.Location = New Point(276, 226)
        Label7.Name = "Label7"
        Label7.Size = New Size(165, 27)
        Label7.TabIndex = 4
        Label7.Text = "by Suhandi Zhuo"
        Label7.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' frmMenuUtama
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(1203, 616)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(TabControl1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "frmMenuUtama"
        Text = "Simple POS"
        Panel2.ResumeLayout(False)
        TabControl1.ResumeLayout(False)
        TabPage1.ResumeLayout(False)
        Panel1.ResumeLayout(False)
        Panel3.ResumeLayout(False)
        TabPage2.ResumeLayout(False)
        Panel4.ResumeLayout(False)
        TabPage3.ResumeLayout(False)
        Panel5.ResumeLayout(False)
        ResumeLayout(False)
    End Sub
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents Splitter1 As Splitter
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents Splitter2 As Splitter
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button5 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents btnDaftarItem As Button
    Friend WithEvents Splitter3 As Splitter
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents Splitter4 As Splitter
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Button6 As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Splitter5 As Splitter
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Button7 As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label

End Class
