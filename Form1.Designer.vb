<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbMenu = New System.Windows.Forms.ComboBox()
        Me.tbHarga = New System.Windows.Forms.TextBox()
        Me.tbJumlah = New System.Windows.Forms.TextBox()
        Me.tbSubTotal = New System.Windows.Forms.TextBox()
        Me.btnPlus = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lbIsiData = New System.Windows.Forms.ListBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.tbTotal = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.tbBayar = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.tbKembali = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(348, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(104, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "My Cashier"
        '
        'cmbMenu
        '
        Me.cmbMenu.FormattingEnabled = True
        Me.cmbMenu.Items.AddRange(New Object() {"Nasi Goreng Vegetarian", "Nasi Goreng Kecap", "Nasi Salmon Mentai", "Nasi Uduk", "Nasi Putih", "Sapi Lada Hitam", "Coto Makassar", "Soto Betawi", "Sop Lidah", "Konro Bakar"})
        Me.cmbMenu.Location = New System.Drawing.Point(127, 124)
        Me.cmbMenu.Name = "cmbMenu"
        Me.cmbMenu.Size = New System.Drawing.Size(138, 21)
        Me.cmbMenu.TabIndex = 1
        Me.cmbMenu.Text = "Nasi Goreng Vegetarian"
        '
        'tbHarga
        '
        Me.tbHarga.Location = New System.Drawing.Point(283, 124)
        Me.tbHarga.Name = "tbHarga"
        Me.tbHarga.Size = New System.Drawing.Size(86, 20)
        Me.tbHarga.TabIndex = 2
        '
        'tbJumlah
        '
        Me.tbJumlah.Location = New System.Drawing.Point(375, 124)
        Me.tbJumlah.Name = "tbJumlah"
        Me.tbJumlah.Size = New System.Drawing.Size(86, 20)
        Me.tbJumlah.TabIndex = 3
        '
        'tbSubTotal
        '
        Me.tbSubTotal.Location = New System.Drawing.Point(467, 125)
        Me.tbSubTotal.Name = "tbSubTotal"
        Me.tbSubTotal.Size = New System.Drawing.Size(86, 20)
        Me.tbSubTotal.TabIndex = 4
        '
        'btnPlus
        '
        Me.btnPlus.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnPlus.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPlus.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnPlus.Location = New System.Drawing.Point(570, 122)
        Me.btnPlus.Name = "btnPlus"
        Me.btnPlus.Size = New System.Drawing.Size(40, 31)
        Me.btnPlus.TabIndex = 5
        Me.btnPlus.Text = "+"
        Me.btnPlus.UseVisualStyleBackColor = False
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(616, 122)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(60, 31)
        Me.btnReset.TabIndex = 6
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(174, 107)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Menu"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(308, 107)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(36, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Harga"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(399, 107)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Jumlah"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(481, 107)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Sub Total"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(599, 106)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(37, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Action"
        '
        'lbIsiData
        '
        Me.lbIsiData.FormattingEnabled = True
        Me.lbIsiData.Location = New System.Drawing.Point(37, 197)
        Me.lbIsiData.Name = "lbIsiData"
        Me.lbIsiData.Size = New System.Drawing.Size(540, 316)
        Me.lbIsiData.TabIndex = 12
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(605, 259)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(40, 17)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Total"
        '
        'tbTotal
        '
        Me.tbTotal.Location = New System.Drawing.Point(667, 258)
        Me.tbTotal.Name = "tbTotal"
        Me.tbTotal.Size = New System.Drawing.Size(103, 20)
        Me.tbTotal.TabIndex = 14
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(605, 303)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(45, 17)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Bayar"
        '
        'tbBayar
        '
        Me.tbBayar.Location = New System.Drawing.Point(667, 302)
        Me.tbBayar.Name = "tbBayar"
        Me.tbBayar.Size = New System.Drawing.Size(103, 20)
        Me.tbBayar.TabIndex = 16
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(603, 442)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(58, 17)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "Kembali"
        '
        'tbKembali
        '
        Me.tbKembali.Location = New System.Drawing.Point(667, 439)
        Me.tbKembali.Name = "tbKembali"
        Me.tbKembali.Size = New System.Drawing.Size(103, 20)
        Me.tbKembali.TabIndex = 18
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 586)
        Me.Controls.Add(Me.tbKembali)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.tbBayar)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.tbTotal)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.lbIsiData)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnPlus)
        Me.Controls.Add(Me.tbSubTotal)
        Me.Controls.Add(Me.tbJumlah)
        Me.Controls.Add(Me.tbHarga)
        Me.Controls.Add(Me.cmbMenu)
        Me.Controls.Add(Me.Label1)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cashier 1.0"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents cmbMenu As ComboBox
    Friend WithEvents tbHarga As TextBox
    Friend WithEvents tbJumlah As TextBox
    Friend WithEvents tbSubTotal As TextBox
    Friend WithEvents btnPlus As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents lbIsiData As ListBox
    Friend WithEvents Label7 As Label
    Friend WithEvents tbTotal As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents tbBayar As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents tbKembali As TextBox
End Class
