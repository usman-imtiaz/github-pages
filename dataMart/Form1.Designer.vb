<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
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
        Me.components = New System.ComponentModel.Container()
        Me.yearCombo = New System.Windows.Forms.ComboBox()
        Me.itemNameCombo = New System.Windows.Forms.ComboBox()
        Me.countryCombo = New System.Windows.Forms.ComboBox()
        Me.branchTypeCombo = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.listBox1 = New System.Windows.Forms.ListBox()
        Me.listBox2 = New System.Windows.Forms.ListBox()
        Me.listBox3 = New System.Windows.Forms.ListBox()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.quarterCombo = New System.Windows.Forms.ComboBox()
        Me.monthCombo = New System.Windows.Forms.ComboBox()
        Me.itemTypeCombo = New System.Windows.Forms.ComboBox()
        Me.itemBrandCombo = New System.Windows.Forms.ComboBox()
        Me.ImageList2 = New System.Windows.Forms.ImageList(Me.components)
        Me.provinceCombo = New System.Windows.Forms.ComboBox()
        Me.branchNameCombo = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.cityCombo = New System.Windows.Forms.ComboBox()
        Me.calculateButton = New System.Windows.Forms.Button()
        Me.clearButton = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'yearCombo
        '
        Me.yearCombo.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.yearCombo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.yearCombo.FormattingEnabled = True
        Me.yearCombo.Items.AddRange(New Object() {""})
        Me.yearCombo.Location = New System.Drawing.Point(8, 22)
        Me.yearCombo.Name = "yearCombo"
        Me.yearCombo.Size = New System.Drawing.Size(125, 24)
        Me.yearCombo.TabIndex = 0
        Me.yearCombo.Text = "Year"
        '
        'itemNameCombo
        '
        Me.itemNameCombo.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.itemNameCombo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.itemNameCombo.FormattingEnabled = True
        Me.itemNameCombo.Items.AddRange(New Object() {""})
        Me.itemNameCombo.Location = New System.Drawing.Point(6, 22)
        Me.itemNameCombo.Name = "itemNameCombo"
        Me.itemNameCombo.Size = New System.Drawing.Size(125, 24)
        Me.itemNameCombo.TabIndex = 1
        Me.itemNameCombo.Text = "Name"
        '
        'countryCombo
        '
        Me.countryCombo.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.countryCombo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.countryCombo.FormattingEnabled = True
        Me.countryCombo.Items.AddRange(New Object() {""})
        Me.countryCombo.Location = New System.Drawing.Point(6, 22)
        Me.countryCombo.Name = "countryCombo"
        Me.countryCombo.Size = New System.Drawing.Size(123, 24)
        Me.countryCombo.TabIndex = 2
        Me.countryCombo.Text = "Country"
        '
        'branchTypeCombo
        '
        Me.branchTypeCombo.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.branchTypeCombo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.branchTypeCombo.FormattingEnabled = True
        Me.branchTypeCombo.Items.AddRange(New Object() {""})
        Me.branchTypeCombo.Location = New System.Drawing.Point(6, 51)
        Me.branchTypeCombo.Name = "branchTypeCombo"
        Me.branchTypeCombo.Size = New System.Drawing.Size(123, 24)
        Me.branchTypeCombo.TabIndex = 3
        Me.branchTypeCombo.Text = "Branch Type"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Silver
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 16)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Option"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Silver
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(190, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 16)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Unit Sold"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Silver
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(498, 15)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(103, 16)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Average Sale"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Silver
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(321, 13)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 16)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Dollars"
        '
        'listBox1
        '
        Me.listBox1.FormattingEnabled = True
        Me.listBox1.Location = New System.Drawing.Point(193, 56)
        Me.listBox1.Name = "listBox1"
        Me.listBox1.Size = New System.Drawing.Size(80, 329)
        Me.listBox1.TabIndex = 8
        '
        'listBox2
        '
        Me.listBox2.FormattingEnabled = True
        Me.listBox2.Location = New System.Drawing.Point(324, 56)
        Me.listBox2.Name = "listBox2"
        Me.listBox2.Size = New System.Drawing.Size(99, 329)
        Me.listBox2.TabIndex = 9
        '
        'listBox3
        '
        Me.listBox3.FormattingEnabled = True
        Me.listBox3.Location = New System.Drawing.Point(501, 57)
        Me.listBox3.Name = "listBox3"
        Me.listBox3.Size = New System.Drawing.Size(212, 329)
        Me.listBox3.TabIndex = 10
        '
        'ImageList1
        '
        Me.ImageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.ImageList1.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'quarterCombo
        '
        Me.quarterCombo.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.quarterCombo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.quarterCombo.FormattingEnabled = True
        Me.quarterCombo.Items.AddRange(New Object() {""})
        Me.quarterCombo.Location = New System.Drawing.Point(8, 52)
        Me.quarterCombo.Name = "quarterCombo"
        Me.quarterCombo.Size = New System.Drawing.Size(125, 24)
        Me.quarterCombo.TabIndex = 12
        Me.quarterCombo.Text = "Quarter"
        '
        'monthCombo
        '
        Me.monthCombo.BackColor = System.Drawing.Color.LightSalmon
        Me.monthCombo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.monthCombo.FormattingEnabled = True
        Me.monthCombo.Items.AddRange(New Object() {""})
        Me.monthCombo.Location = New System.Drawing.Point(8, 82)
        Me.monthCombo.Name = "monthCombo"
        Me.monthCombo.Size = New System.Drawing.Size(125, 24)
        Me.monthCombo.TabIndex = 13
        Me.monthCombo.Text = "Month"
        '
        'itemTypeCombo
        '
        Me.itemTypeCombo.BackColor = System.Drawing.Color.DarkOrange
        Me.itemTypeCombo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.itemTypeCombo.FormattingEnabled = True
        Me.itemTypeCombo.Items.AddRange(New Object() {""})
        Me.itemTypeCombo.Location = New System.Drawing.Point(6, 82)
        Me.itemTypeCombo.Name = "itemTypeCombo"
        Me.itemTypeCombo.Size = New System.Drawing.Size(126, 24)
        Me.itemTypeCombo.TabIndex = 15
        Me.itemTypeCombo.Text = "Type"
        '
        'itemBrandCombo
        '
        Me.itemBrandCombo.BackColor = System.Drawing.Color.Olive
        Me.itemBrandCombo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.itemBrandCombo.FormattingEnabled = True
        Me.itemBrandCombo.Items.AddRange(New Object() {""})
        Me.itemBrandCombo.Location = New System.Drawing.Point(6, 52)
        Me.itemBrandCombo.Name = "itemBrandCombo"
        Me.itemBrandCombo.Size = New System.Drawing.Size(125, 24)
        Me.itemBrandCombo.TabIndex = 16
        Me.itemBrandCombo.Text = "Brand"
        '
        'ImageList2
        '
        Me.ImageList2.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.ImageList2.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageList2.TransparentColor = System.Drawing.Color.Transparent
        '
        'provinceCombo
        '
        Me.provinceCombo.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.provinceCombo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.provinceCombo.FormattingEnabled = True
        Me.provinceCombo.Items.AddRange(New Object() {""})
        Me.provinceCombo.Location = New System.Drawing.Point(7, 52)
        Me.provinceCombo.Name = "provinceCombo"
        Me.provinceCombo.Size = New System.Drawing.Size(123, 24)
        Me.provinceCombo.TabIndex = 19
        Me.provinceCombo.Text = "Province"
        '
        'branchNameCombo
        '
        Me.branchNameCombo.BackColor = System.Drawing.Color.Gainsboro
        Me.branchNameCombo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.27!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.branchNameCombo.FormattingEnabled = True
        Me.branchNameCombo.Items.AddRange(New Object() {""})
        Me.branchNameCombo.Location = New System.Drawing.Point(7, 22)
        Me.branchNameCombo.Name = "branchNameCombo"
        Me.branchNameCombo.Size = New System.Drawing.Size(124, 23)
        Me.branchNameCombo.TabIndex = 20
        Me.branchNameCombo.Text = "Branch Name"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.PaleTurquoise
        Me.GroupBox1.Controls.Add(Me.yearCombo)
        Me.GroupBox1.Controls.Add(Me.quarterCombo)
        Me.GroupBox1.Controls.Add(Me.monthCombo)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(14, 41)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(153, 126)
        Me.GroupBox1.TabIndex = 21
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "q"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.PaleTurquoise
        Me.GroupBox2.Controls.Add(Me.itemTypeCombo)
        Me.GroupBox2.Controls.Add(Me.itemNameCombo)
        Me.GroupBox2.Controls.Add(Me.itemBrandCombo)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(11, 182)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(156, 122)
        Me.GroupBox2.TabIndex = 22
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Item"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.PaleTurquoise
        Me.GroupBox3.Controls.Add(Me.branchTypeCombo)
        Me.GroupBox3.Controls.Add(Me.branchNameCombo)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(11, 323)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(156, 87)
        Me.GroupBox3.TabIndex = 23
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Branch"
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.PaleTurquoise
        Me.GroupBox4.Controls.Add(Me.cityCombo)
        Me.GroupBox4.Controls.Add(Me.countryCombo)
        Me.GroupBox4.Controls.Add(Me.provinceCombo)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(11, 440)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(156, 123)
        Me.GroupBox4.TabIndex = 24
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Location"
        '
        'cityCombo
        '
        Me.cityCombo.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.cityCombo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cityCombo.FormattingEnabled = True
        Me.cityCombo.Items.AddRange(New Object() {""})
        Me.cityCombo.Location = New System.Drawing.Point(7, 82)
        Me.cityCombo.Name = "cityCombo"
        Me.cityCombo.Size = New System.Drawing.Size(123, 24)
        Me.cityCombo.TabIndex = 20
        Me.cityCombo.Text = "City"
        '
        'calculateButton
        '
        Me.calculateButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.calculateButton.Location = New System.Drawing.Point(289, 462)
        Me.calculateButton.Name = "calculateButton"
        Me.calculateButton.Size = New System.Drawing.Size(134, 54)
        Me.calculateButton.TabIndex = 25
        Me.calculateButton.Text = "Calculate"
        Me.calculateButton.UseVisualStyleBackColor = True
        '
        'clearButton
        '
        Me.clearButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clearButton.Location = New System.Drawing.Point(459, 462)
        Me.clearButton.Name = "clearButton"
        Me.clearButton.Size = New System.Drawing.Size(134, 54)
        Me.clearButton.TabIndex = 26
        Me.clearButton.Text = "Clear Results"
        Me.clearButton.UseVisualStyleBackColor = True
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(780, 575)
        Me.Controls.Add(Me.clearButton)
        Me.Controls.Add(Me.calculateButton)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.listBox3)
        Me.Controls.Add(Me.listBox2)
        Me.Controls.Add(Me.listBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Main"
        Me.Text = "Main"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents yearCombo As System.Windows.Forms.ComboBox
    Friend WithEvents itemNameCombo As System.Windows.Forms.ComboBox
    Friend WithEvents countryCombo As System.Windows.Forms.ComboBox
    Friend WithEvents branchTypeCombo As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents listBox1 As System.Windows.Forms.ListBox
    Friend WithEvents listBox2 As System.Windows.Forms.ListBox
    Friend WithEvents listBox3 As System.Windows.Forms.ListBox
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents quarterCombo As System.Windows.Forms.ComboBox
    Friend WithEvents monthCombo As System.Windows.Forms.ComboBox
    Friend WithEvents itemTypeCombo As System.Windows.Forms.ComboBox
    Friend WithEvents itemBrandCombo As System.Windows.Forms.ComboBox
    Friend WithEvents ImageList2 As System.Windows.Forms.ImageList
    Friend WithEvents provinceCombo As System.Windows.Forms.ComboBox
    Friend WithEvents branchNameCombo As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents cityCombo As System.Windows.Forms.ComboBox
    Friend WithEvents calculateButton As System.Windows.Forms.Button
    Friend WithEvents clearButton As System.Windows.Forms.Button

End Class
