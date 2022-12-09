<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class HapusKoleksi
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(HapusKoleksi))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LblKoleksi = New System.Windows.Forms.Label()
        Me.BtnHapus = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(257, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(274, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Apakah ingin menghapus koleksi"
        '
        'LblKoleksi
        '
        Me.LblKoleksi.AutoSize = True
        Me.LblKoleksi.ForeColor = System.Drawing.Color.DarkRed
        Me.LblKoleksi.Location = New System.Drawing.Point(317, 164)
        Me.LblKoleksi.Name = "LblKoleksi"
        Me.LblKoleksi.Size = New System.Drawing.Size(19, 25)
        Me.LblKoleksi.TabIndex = 1
        Me.LblKoleksi.Text = "-"
        '
        'BtnHapus
        '
        Me.BtnHapus.BackColor = System.Drawing.Color.Teal
        Me.BtnHapus.FlatAppearance.BorderSize = 0
        Me.BtnHapus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnHapus.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.BtnHapus.ForeColor = System.Drawing.Color.White
        Me.BtnHapus.Location = New System.Drawing.Point(332, 367)
        Me.BtnHapus.Name = "BtnHapus"
        Me.BtnHapus.Size = New System.Drawing.Size(112, 34)
        Me.BtnHapus.TabIndex = 2
        Me.BtnHapus.Text = "Hapus"
        Me.BtnHapus.UseVisualStyleBackColor = False
        '
        'HapusKoleksi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.BtnHapus)
        Me.Controls.Add(Me.LblKoleksi)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "HapusKoleksi"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormHapusKoleksi"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents LblKoleksi As Label
    Friend WithEvents BtnHapus As Button
End Class
