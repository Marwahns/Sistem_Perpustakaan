<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Perpustakaan
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Perpustakaan))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.KoleksiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TambahKoleksiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KoleksiBuku = New System.Windows.Forms.ListBox()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.BtnTambah = New System.Windows.Forms.ToolStripButton()
        Me.BtnKurang = New System.Windows.Forms.ToolStripButton()
        Me.DataGridKoleksi = New System.Windows.Forms.DataGridView()
        Me.BtnRemove = New System.Windows.Forms.Button()
        Me.BtnSelect = New System.Windows.Forms.Button()
        Me.BtnUpdate = New System.Windows.Forms.Button()
        Me.LblDate = New System.Windows.Forms.Label()
        Me.LblTime = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.MenuStrip1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.DataGridKoleksi, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.KoleksiToolStripMenuItem, Me.LogoutToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(942, 33)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'KoleksiToolStripMenuItem
        '
        Me.KoleksiToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TambahKoleksiToolStripMenuItem})
        Me.KoleksiToolStripMenuItem.Name = "KoleksiToolStripMenuItem"
        Me.KoleksiToolStripMenuItem.Size = New System.Drawing.Size(83, 29)
        Me.KoleksiToolStripMenuItem.Text = "Koleksi"
        '
        'TambahKoleksiToolStripMenuItem
        '
        Me.TambahKoleksiToolStripMenuItem.Name = "TambahKoleksiToolStripMenuItem"
        Me.TambahKoleksiToolStripMenuItem.Size = New System.Drawing.Size(236, 34)
        Me.TambahKoleksiToolStripMenuItem.Text = "Tambah Koleksi"
        '
        'LogoutToolStripMenuItem
        '
        Me.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        Me.LogoutToolStripMenuItem.Size = New System.Drawing.Size(85, 29)
        Me.LogoutToolStripMenuItem.Text = "Logout"
        '
        'KoleksiBuku
        '
        Me.KoleksiBuku.FormattingEnabled = True
        Me.KoleksiBuku.ItemHeight = 25
        Me.KoleksiBuku.Location = New System.Drawing.Point(12, 155)
        Me.KoleksiBuku.Name = "KoleksiBuku"
        Me.KoleksiBuku.Size = New System.Drawing.Size(418, 354)
        Me.KoleksiBuku.TabIndex = 3
        '
        'ToolStrip1
        '
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BtnTambah, Me.BtnKurang})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 33)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(942, 33)
        Me.ToolStrip1.TabIndex = 4
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'BtnTambah
        '
        Me.BtnTambah.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BtnTambah.Image = CType(resources.GetObject("BtnTambah.Image"), System.Drawing.Image)
        Me.BtnTambah.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnTambah.Name = "BtnTambah"
        Me.BtnTambah.Size = New System.Drawing.Size(34, 28)
        Me.BtnTambah.Text = "ToolStripButton1"
        '
        'BtnKurang
        '
        Me.BtnKurang.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BtnKurang.Image = CType(resources.GetObject("BtnKurang.Image"), System.Drawing.Image)
        Me.BtnKurang.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnKurang.Name = "BtnKurang"
        Me.BtnKurang.Size = New System.Drawing.Size(34, 28)
        Me.BtnKurang.Text = "ToolStripButton2"
        '
        'DataGridKoleksi
        '
        Me.DataGridKoleksi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridKoleksi.Location = New System.Drawing.Point(436, 155)
        Me.DataGridKoleksi.Name = "DataGridKoleksi"
        Me.DataGridKoleksi.RowHeadersWidth = 62
        Me.DataGridKoleksi.RowTemplate.Height = 33
        Me.DataGridKoleksi.Size = New System.Drawing.Size(493, 354)
        Me.DataGridKoleksi.TabIndex = 5
        '
        'BtnRemove
        '
        Me.BtnRemove.BackColor = System.Drawing.Color.Teal
        Me.BtnRemove.FlatAppearance.BorderSize = 0
        Me.BtnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnRemove.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.BtnRemove.ForeColor = System.Drawing.Color.White
        Me.BtnRemove.Location = New System.Drawing.Point(817, 515)
        Me.BtnRemove.Name = "BtnRemove"
        Me.BtnRemove.Size = New System.Drawing.Size(112, 34)
        Me.BtnRemove.TabIndex = 6
        Me.BtnRemove.Text = "Remove"
        Me.BtnRemove.UseVisualStyleBackColor = False
        '
        'BtnSelect
        '
        Me.BtnSelect.BackColor = System.Drawing.Color.Teal
        Me.BtnSelect.FlatAppearance.BorderSize = 0
        Me.BtnSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSelect.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.BtnSelect.ForeColor = System.Drawing.Color.White
        Me.BtnSelect.Location = New System.Drawing.Point(699, 515)
        Me.BtnSelect.Name = "BtnSelect"
        Me.BtnSelect.Size = New System.Drawing.Size(112, 34)
        Me.BtnSelect.TabIndex = 7
        Me.BtnSelect.Text = "Select"
        Me.BtnSelect.UseVisualStyleBackColor = False
        '
        'BtnUpdate
        '
        Me.BtnUpdate.BackColor = System.Drawing.Color.Teal
        Me.BtnUpdate.FlatAppearance.BorderSize = 0
        Me.BtnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnUpdate.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.BtnUpdate.ForeColor = System.Drawing.Color.White
        Me.BtnUpdate.Location = New System.Drawing.Point(581, 515)
        Me.BtnUpdate.Name = "BtnUpdate"
        Me.BtnUpdate.Size = New System.Drawing.Size(112, 34)
        Me.BtnUpdate.TabIndex = 8
        Me.BtnUpdate.Text = "Update"
        Me.BtnUpdate.UseVisualStyleBackColor = False
        '
        'LblDate
        '
        Me.LblDate.AutoSize = True
        Me.LblDate.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LblDate.Location = New System.Drawing.Point(597, 66)
        Me.LblDate.Name = "LblDate"
        Me.LblDate.Size = New System.Drawing.Size(58, 30)
        Me.LblDate.TabIndex = 9
        Me.LblDate.Text = "Date"
        '
        'LblTime
        '
        Me.LblTime.AutoSize = True
        Me.LblTime.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LblTime.Location = New System.Drawing.Point(692, 91)
        Me.LblTime.Name = "LblTime"
        Me.LblTime.Size = New System.Drawing.Size(83, 41)
        Me.LblTime.TabIndex = 10
        Me.LblTime.Text = "Time"
        '
        'Timer1
        '
        '
        'Perpustakaan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(942, 569)
        Me.Controls.Add(Me.LblTime)
        Me.Controls.Add(Me.LblDate)
        Me.Controls.Add(Me.BtnUpdate)
        Me.Controls.Add(Me.BtnSelect)
        Me.Controls.Add(Me.BtnRemove)
        Me.Controls.Add(Me.DataGridKoleksi)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.KoleksiBuku)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Perpustakaan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.DataGridKoleksi, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents KoleksiToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TambahKoleksiToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents KoleksiBuku As ListBox
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents BtnTambah As ToolStripButton
    Friend WithEvents BtnKurang As ToolStripButton
    Friend WithEvents DataGridKoleksi As DataGridView
    Friend WithEvents BtnRemove As Button
    Friend WithEvents BtnSelect As Button
    Friend WithEvents BtnUpdate As Button
    Friend WithEvents LogoutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LblDate As Label
    Friend WithEvents LblTime As Label
    Friend WithEvents Timer1 As Timer
End Class
