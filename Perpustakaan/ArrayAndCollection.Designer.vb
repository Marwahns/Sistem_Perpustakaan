<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ArrayAndCollection
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
        Me.ListBoxStrukturArray = New System.Windows.Forms.ListBox()
        Me.LblStrukturArray = New System.Windows.Forms.Label()
        Me.ListBoxArrayDinamic = New System.Windows.Forms.ListBox()
        Me.LblArrayDinamic = New System.Windows.Forms.Label()
        Me.ListBoxArrayMultiDimension = New System.Windows.Forms.ListBox()
        Me.LblArrayMultiDimension = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LblStack = New System.Windows.Forms.Label()
        Me.ListBoxStack = New System.Windows.Forms.ListBox()
        Me.LblHashtable = New System.Windows.Forms.Label()
        Me.ListBoxHashtable = New System.Windows.Forms.ListBox()
        Me.LblArrayList = New System.Windows.Forms.Label()
        Me.ListBoxArrayList = New System.Windows.Forms.ListBox()
        Me.LblQueue = New System.Windows.Forms.Label()
        Me.ListBoxQueue = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'ListBoxStrukturArray
        '
        Me.ListBoxStrukturArray.FormattingEnabled = True
        Me.ListBoxStrukturArray.ItemHeight = 25
        Me.ListBoxStrukturArray.Location = New System.Drawing.Point(227, 149)
        Me.ListBoxStrukturArray.Name = "ListBoxStrukturArray"
        Me.ListBoxStrukturArray.Size = New System.Drawing.Size(158, 154)
        Me.ListBoxStrukturArray.TabIndex = 0
        '
        'LblStrukturArray
        '
        Me.LblStrukturArray.AutoSize = True
        Me.LblStrukturArray.Location = New System.Drawing.Point(240, 111)
        Me.LblStrukturArray.Name = "LblStrukturArray"
        Me.LblStrukturArray.Size = New System.Drawing.Size(121, 25)
        Me.LblStrukturArray.TabIndex = 1
        Me.LblStrukturArray.Text = "Struktur Array"
        '
        'ListBoxArrayDinamic
        '
        Me.ListBoxArrayDinamic.FormattingEnabled = True
        Me.ListBoxArrayDinamic.ItemHeight = 25
        Me.ListBoxArrayDinamic.Location = New System.Drawing.Point(461, 149)
        Me.ListBoxArrayDinamic.Name = "ListBoxArrayDinamic"
        Me.ListBoxArrayDinamic.Size = New System.Drawing.Size(158, 154)
        Me.ListBoxArrayDinamic.TabIndex = 2
        '
        'LblArrayDinamic
        '
        Me.LblArrayDinamic.AutoSize = True
        Me.LblArrayDinamic.Location = New System.Drawing.Point(480, 111)
        Me.LblArrayDinamic.Name = "LblArrayDinamic"
        Me.LblArrayDinamic.Size = New System.Drawing.Size(123, 25)
        Me.LblArrayDinamic.TabIndex = 3
        Me.LblArrayDinamic.Text = "Array Dinamic"
        '
        'ListBoxArrayMultiDimension
        '
        Me.ListBoxArrayMultiDimension.FormattingEnabled = True
        Me.ListBoxArrayMultiDimension.ItemHeight = 25
        Me.ListBoxArrayMultiDimension.Location = New System.Drawing.Point(691, 149)
        Me.ListBoxArrayMultiDimension.Name = "ListBoxArrayMultiDimension"
        Me.ListBoxArrayMultiDimension.Size = New System.Drawing.Size(158, 154)
        Me.ListBoxArrayMultiDimension.TabIndex = 4
        '
        'LblArrayMultiDimension
        '
        Me.LblArrayMultiDimension.AutoSize = True
        Me.LblArrayMultiDimension.Location = New System.Drawing.Point(674, 111)
        Me.LblArrayMultiDimension.Name = "LblArrayMultiDimension"
        Me.LblArrayMultiDimension.Size = New System.Drawing.Size(189, 25)
        Me.LblArrayMultiDimension.TabIndex = 5
        Me.LblArrayMultiDimension.Text = "Array Multi Dimension"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(490, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(116, 41)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "ARRAY"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(461, 378)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(200, 41)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "COLLECTION"
        '
        'LblStack
        '
        Me.LblStack.AutoSize = True
        Me.LblStack.Location = New System.Drawing.Point(645, 452)
        Me.LblStack.Name = "LblStack"
        Me.LblStack.Size = New System.Drawing.Size(53, 25)
        Me.LblStack.TabIndex = 13
        Me.LblStack.Text = "Stack"
        '
        'ListBoxStack
        '
        Me.ListBoxStack.FormattingEnabled = True
        Me.ListBoxStack.ItemHeight = 25
        Me.ListBoxStack.Location = New System.Drawing.Point(593, 490)
        Me.ListBoxStack.Name = "ListBoxStack"
        Me.ListBoxStack.Size = New System.Drawing.Size(158, 154)
        Me.ListBoxStack.TabIndex = 12
        '
        'LblHashtable
        '
        Me.LblHashtable.AutoSize = True
        Me.LblHashtable.Location = New System.Drawing.Point(381, 452)
        Me.LblHashtable.Name = "LblHashtable"
        Me.LblHashtable.Size = New System.Drawing.Size(91, 25)
        Me.LblHashtable.TabIndex = 11
        Me.LblHashtable.Text = "Hashtable"
        '
        'ListBoxHashtable
        '
        Me.ListBoxHashtable.FormattingEnabled = True
        Me.ListBoxHashtable.ItemHeight = 25
        Me.ListBoxHashtable.Location = New System.Drawing.Point(344, 490)
        Me.ListBoxHashtable.Name = "ListBoxHashtable"
        Me.ListBoxHashtable.Size = New System.Drawing.Size(158, 154)
        Me.ListBoxHashtable.TabIndex = 10
        '
        'LblArrayList
        '
        Me.LblArrayList.AutoSize = True
        Me.LblArrayList.Location = New System.Drawing.Point(142, 452)
        Me.LblArrayList.Name = "LblArrayList"
        Me.LblArrayList.Size = New System.Drawing.Size(80, 25)
        Me.LblArrayList.TabIndex = 9
        Me.LblArrayList.Text = "ArrayList"
        '
        'ListBoxArrayList
        '
        Me.ListBoxArrayList.FormattingEnabled = True
        Me.ListBoxArrayList.ItemHeight = 25
        Me.ListBoxArrayList.Location = New System.Drawing.Point(104, 490)
        Me.ListBoxArrayList.Name = "ListBoxArrayList"
        Me.ListBoxArrayList.Size = New System.Drawing.Size(158, 154)
        Me.ListBoxArrayList.TabIndex = 8
        '
        'LblQueue
        '
        Me.LblQueue.AutoSize = True
        Me.LblQueue.Location = New System.Drawing.Point(890, 452)
        Me.LblQueue.Name = "LblQueue"
        Me.LblQueue.Size = New System.Drawing.Size(64, 25)
        Me.LblQueue.TabIndex = 15
        Me.LblQueue.Text = "Queue"
        '
        'ListBoxQueue
        '
        Me.ListBoxQueue.FormattingEnabled = True
        Me.ListBoxQueue.ItemHeight = 25
        Me.ListBoxQueue.Location = New System.Drawing.Point(840, 490)
        Me.ListBoxQueue.Name = "ListBoxQueue"
        Me.ListBoxQueue.Size = New System.Drawing.Size(158, 154)
        Me.ListBoxQueue.TabIndex = 14
        '
        'StrukturArray
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1107, 714)
        Me.Controls.Add(Me.LblQueue)
        Me.Controls.Add(Me.ListBoxQueue)
        Me.Controls.Add(Me.LblStack)
        Me.Controls.Add(Me.ListBoxStack)
        Me.Controls.Add(Me.LblHashtable)
        Me.Controls.Add(Me.ListBoxHashtable)
        Me.Controls.Add(Me.LblArrayList)
        Me.Controls.Add(Me.ListBoxArrayList)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LblArrayMultiDimension)
        Me.Controls.Add(Me.ListBoxArrayMultiDimension)
        Me.Controls.Add(Me.LblArrayDinamic)
        Me.Controls.Add(Me.ListBoxArrayDinamic)
        Me.Controls.Add(Me.LblStrukturArray)
        Me.Controls.Add(Me.ListBoxStrukturArray)
        Me.Name = "StrukturArray"
        Me.Text = "StrukturArray"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ListBoxStrukturArray As ListBox
    Friend WithEvents LblStrukturArray As Label
    Friend WithEvents ListBoxArrayDinamic As ListBox
    Friend WithEvents LblArrayDinamic As Label
    Friend WithEvents ListBoxArrayMultiDimension As ListBox
    Friend WithEvents LblArrayMultiDimension As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents LblStack As Label
    Friend WithEvents ListBoxStack As ListBox
    Friend WithEvents LblHashtable As Label
    Friend WithEvents ListBoxHashtable As ListBox
    Friend WithEvents LblArrayList As Label
    Friend WithEvents ListBoxArrayList As ListBox
    Friend WithEvents LblQueue As Label
    Friend WithEvents ListBoxQueue As ListBox
End Class
