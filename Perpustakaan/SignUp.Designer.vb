<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SignUp
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
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.BtnBack = New System.Windows.Forms.Button()
        Me.BtnSignUp = New System.Windows.Forms.Button()
        Me.TxtPassword = New System.Windows.Forms.TextBox()
        Me.TxtUsername = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.CheckPassword = New System.Windows.Forms.CheckBox()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = Global.Perpustakaan.My.Resources.Resources._3d_render_books_stack_blue_background_reading
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Location = New System.Drawing.Point(-1, -1)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(491, 503)
        Me.PictureBox2.TabIndex = 18
        Me.PictureBox2.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 22.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(97, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(279, 229)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(174, 60)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Library"
        '
        'BtnBack
        '
        Me.BtnBack.BackColor = System.Drawing.Color.Teal
        Me.BtnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BtnBack.FlatAppearance.BorderSize = 0
        Me.BtnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnBack.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.BtnBack.ForeColor = System.Drawing.Color.Gold
        Me.BtnBack.Location = New System.Drawing.Point(524, 392)
        Me.BtnBack.Name = "BtnBack"
        Me.BtnBack.Size = New System.Drawing.Size(357, 34)
        Me.BtnBack.TabIndex = 15
        Me.BtnBack.Text = "Back"
        Me.BtnBack.UseVisualStyleBackColor = False
        '
        'BtnSignUp
        '
        Me.BtnSignUp.BackColor = System.Drawing.Color.Gold
        Me.BtnSignUp.FlatAppearance.BorderSize = 0
        Me.BtnSignUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSignUp.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.BtnSignUp.ForeColor = System.Drawing.Color.Teal
        Me.BtnSignUp.Location = New System.Drawing.Point(524, 333)
        Me.BtnSignUp.Name = "BtnSignUp"
        Me.BtnSignUp.Size = New System.Drawing.Size(357, 34)
        Me.BtnSignUp.TabIndex = 14
        Me.BtnSignUp.Text = "Create Account"
        Me.BtnSignUp.UseVisualStyleBackColor = False
        '
        'TxtPassword
        '
        Me.TxtPassword.AutoCompleteCustomSource.AddRange(New String() {"1234", "1235", "1236"})
        Me.TxtPassword.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.TxtPassword.BackColor = System.Drawing.Color.LightSeaGreen
        Me.TxtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtPassword.ForeColor = System.Drawing.Color.Black
        Me.TxtPassword.Location = New System.Drawing.Point(524, 228)
        Me.TxtPassword.Name = "TxtPassword"
        Me.TxtPassword.Size = New System.Drawing.Size(357, 24)
        Me.TxtPassword.TabIndex = 13
        Me.TxtPassword.UseSystemPasswordChar = True
        '
        'TxtUsername
        '
        Me.TxtUsername.AutoCompleteCustomSource.AddRange(New String() {"marwah", "nur", "shafira"})
        Me.TxtUsername.BackColor = System.Drawing.Color.LightSeaGreen
        Me.TxtUsername.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtUsername.ForeColor = System.Drawing.Color.Black
        Me.TxtUsername.Location = New System.Drawing.Point(524, 149)
        Me.TxtUsername.Name = "TxtUsername"
        Me.TxtUsername.Size = New System.Drawing.Size(357, 24)
        Me.TxtUsername.TabIndex = 12
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Teal
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(520, 200)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 25)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Password"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Teal
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(520, 121)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 25)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Username"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Teal
        Me.PictureBox1.Location = New System.Drawing.Point(490, -1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(422, 503)
        Me.PictureBox1.TabIndex = 16
        Me.PictureBox1.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Teal
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 17.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(520, 39)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(137, 46)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "Sign Up"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 22.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(238, 229)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 60)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "Z"
        '
        'CheckPassword
        '
        Me.CheckPassword.AutoSize = True
        Me.CheckPassword.BackColor = System.Drawing.Color.Teal
        Me.CheckPassword.ForeColor = System.Drawing.Color.White
        Me.CheckPassword.Location = New System.Drawing.Point(524, 265)
        Me.CheckPassword.Name = "CheckPassword"
        Me.CheckPassword.Size = New System.Drawing.Size(162, 29)
        Me.CheckPassword.TabIndex = 24
        Me.CheckPassword.Text = "Show Password"
        Me.CheckPassword.UseVisualStyleBackColor = False
        '
        'SignUp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(912, 503)
        Me.Controls.Add(Me.CheckPassword)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.BtnBack)
        Me.Controls.Add(Me.BtnSignUp)
        Me.Controls.Add(Me.TxtPassword)
        Me.Controls.Add(Me.TxtUsername)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Name = "SignUp"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SignUp"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents BtnBack As Button
    Friend WithEvents BtnSignUp As Button
    Friend WithEvents TxtPassword As TextBox
    Friend WithEvents TxtUsername As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents CheckPassword As CheckBox
End Class
