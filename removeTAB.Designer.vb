<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class removeTAB
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
        Label8 = New Label()
        filterINPUT = New ComboBox()
        searchBTN = New Button()
        searchBOX = New TextBox()
        Label1 = New Label()
        gotoADD = New Button()
        gotoUPDATE = New Button()
        Label6 = New Label()
        backBTN = New Button()
        DataGridView1 = New DataGridView()
        itemID = New TextBox()
        removeitembtn = New Button()
        expirationLABEL = New Label()
        RadioButton2 = New RadioButton()
        RadioButton1 = New RadioButton()
        DateTimePicker1 = New DateTimePicker()
        priceINPUT = New TextBox()
        quantityINPUT = New TextBox()
        Label7 = New Label()
        Label4 = New Label()
        brandINPUT = New TextBox()
        Label2 = New Label()
        categoryINPUT = New TextBox()
        descriptionINPUT = New TextBox()
        Label3 = New Label()
        itemNAME = New TextBox()
        itemNAMELABEL = New Label()
        itemIDLabel = New Label()
        Label5 = New Label()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(32, 104)
        Label8.Name = "Label8"
        Label8.Size = New Size(45, 20)
        Label8.TabIndex = 61
        Label8.Text = "Filter:"
        ' 
        ' filterINPUT
        ' 
        filterINPUT.FormattingEnabled = True
        filterINPUT.Items.AddRange(New Object() {"Name", "Category", "Brand", "Description", "Quantity", "Price", "ID"})
        filterINPUT.Location = New Point(83, 100)
        filterINPUT.Name = "filterINPUT"
        filterINPUT.Size = New Size(96, 28)
        filterINPUT.TabIndex = 60
        filterINPUT.Text = "Name"
        ' 
        ' searchBTN
        ' 
        searchBTN.Location = New Point(478, 101)
        searchBTN.Name = "searchBTN"
        searchBTN.Size = New Size(94, 29)
        searchBTN.TabIndex = 59
        searchBTN.Text = "Search"
        searchBTN.UseVisualStyleBackColor = True
        ' 
        ' searchBOX
        ' 
        searchBOX.Location = New Point(251, 101)
        searchBOX.Name = "searchBOX"
        searchBOX.Size = New Size(221, 27)
        searchBOX.TabIndex = 58
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(185, 103)
        Label1.Name = "Label1"
        Label1.Size = New Size(60, 20)
        Label1.TabIndex = 57
        Label1.Text = "Search: "
        ' 
        ' gotoADD
        ' 
        gotoADD.Location = New Point(611, 17)
        gotoADD.Name = "gotoADD"
        gotoADD.Size = New Size(158, 58)
        gotoADD.TabIndex = 56
        gotoADD.Text = "+ ADD ITEMS"
        gotoADD.UseVisualStyleBackColor = True
        ' 
        ' gotoUPDATE
        ' 
        gotoUPDATE.Location = New Point(775, 17)
        gotoUPDATE.Name = "gotoUPDATE"
        gotoUPDATE.Size = New Size(158, 59)
        gotoUPDATE.TabIndex = 55
        gotoUPDATE.Text = "* UPDATE ITEMS"
        gotoUPDATE.UseVisualStyleBackColor = True
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(25, 17)
        Label6.Name = "Label6"
        Label6.Size = New Size(177, 31)
        Label6.TabIndex = 54
        Label6.Text = "REMOVE ITEMS"
        ' 
        ' backBTN
        ' 
        backBTN.Location = New Point(32, 56)
        backBTN.Name = "backBTN"
        backBTN.Size = New Size(159, 36)
        backBTN.TabIndex = 53
        backBTN.Text = "< Back"
        backBTN.UseVisualStyleBackColor = True
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.AllowUserToDeleteRows = False
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(32, 136)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.ReadOnly = True
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.Size = New Size(898, 260)
        DataGridView1.TabIndex = 62
        ' 
        ' itemID
        ' 
        itemID.Enabled = False
        itemID.Location = New Point(440, 526)
        itemID.Name = "itemID"
        itemID.Size = New Size(97, 27)
        itemID.TabIndex = 79
        ' 
        ' removeitembtn
        ' 
        removeitembtn.ForeColor = Color.Firebrick
        removeitembtn.Location = New Point(736, 506)
        removeitembtn.Name = "removeitembtn"
        removeitembtn.Size = New Size(190, 67)
        removeitembtn.TabIndex = 78
        removeitembtn.Text = "- REMOVE"
        removeitembtn.UseVisualStyleBackColor = True
        ' 
        ' expirationLABEL
        ' 
        expirationLABEL.AutoSize = True
        expirationLABEL.Location = New Point(551, 443)
        expirationLABEL.Name = "expirationLABEL"
        expirationLABEL.Size = New Size(119, 20)
        expirationLABEL.TabIndex = 77
        expirationLABEL.Text = "Expiration Date: "
        expirationLABEL.Visible = False
        ' 
        ' RadioButton2
        ' 
        RadioButton2.AutoSize = True
        RadioButton2.Enabled = False
        RadioButton2.Location = New Point(740, 406)
        RadioButton2.Name = "RadioButton2"
        RadioButton2.Size = New Size(193, 24)
        RadioButton2.TabIndex = 76
        RadioButton2.TabStop = True
        RadioButton2.Text = "Item has Expiration Date"
        RadioButton2.UseVisualStyleBackColor = True
        ' 
        ' RadioButton1
        ' 
        RadioButton1.AutoSize = True
        RadioButton1.Enabled = False
        RadioButton1.Location = New Point(577, 406)
        RadioButton1.Name = "RadioButton1"
        RadioButton1.Size = New Size(157, 24)
        RadioButton1.TabIndex = 75
        RadioButton1.TabStop = True
        RadioButton1.Text = "No Expiration Date"
        RadioButton1.UseVisualStyleBackColor = True
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Enabled = False
        DateTimePicker1.Location = New Point(673, 440)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(257, 27)
        DateTimePicker1.TabIndex = 74
        DateTimePicker1.Visible = False
        ' 
        ' priceINPUT
        ' 
        priceINPUT.Enabled = False
        priceINPUT.Location = New Point(440, 440)
        priceINPUT.Name = "priceINPUT"
        priceINPUT.Size = New Size(97, 27)
        priceINPUT.TabIndex = 73
        ' 
        ' quantityINPUT
        ' 
        quantityINPUT.Enabled = False
        quantityINPUT.Location = New Point(440, 407)
        quantityINPUT.Name = "quantityINPUT"
        quantityINPUT.Size = New Size(97, 27)
        quantityINPUT.TabIndex = 72
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(366, 410)
        Label7.Name = "Label7"
        Label7.Size = New Size(68, 20)
        Label7.TabIndex = 71
        Label7.Text = "Quantity:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(90, 478)
        Label4.Name = "Label4"
        Label4.Size = New Size(51, 20)
        Label4.TabIndex = 70
        Label4.Text = "Brand:"
        ' 
        ' brandINPUT
        ' 
        brandINPUT.Enabled = False
        brandINPUT.Location = New Point(147, 473)
        brandINPUT.Name = "brandINPUT"
        brandINPUT.Size = New Size(198, 27)
        brandINPUT.TabIndex = 69
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(72, 443)
        Label2.Name = "Label2"
        Label2.Size = New Size(72, 20)
        Label2.TabIndex = 68
        Label2.Text = "Category:"
        ' 
        ' categoryINPUT
        ' 
        categoryINPUT.Enabled = False
        categoryINPUT.Location = New Point(147, 440)
        categoryINPUT.Name = "categoryINPUT"
        categoryINPUT.Size = New Size(198, 27)
        categoryINPUT.TabIndex = 67
        ' 
        ' descriptionINPUT
        ' 
        descriptionINPUT.Enabled = False
        descriptionINPUT.Location = New Point(147, 506)
        descriptionINPUT.Multiline = True
        descriptionINPUT.Name = "descriptionINPUT"
        descriptionINPUT.Size = New Size(198, 73)
        descriptionINPUT.TabIndex = 66
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(22, 509)
        Label3.Name = "Label3"
        Label3.Size = New Size(126, 20)
        Label3.TabIndex = 65
        Label3.Text = "Item Description: "
        Label3.TextAlign = ContentAlignment.BottomRight
        ' 
        ' itemNAME
        ' 
        itemNAME.Enabled = False
        itemNAME.Location = New Point(147, 407)
        itemNAME.Name = "itemNAME"
        itemNAME.Size = New Size(198, 27)
        itemNAME.TabIndex = 64
        ' 
        ' itemNAMELABEL
        ' 
        itemNAMELABEL.AutoSize = True
        itemNAMELABEL.Location = New Point(55, 410)
        itemNAMELABEL.Name = "itemNAMELABEL"
        itemNAMELABEL.Size = New Size(86, 20)
        itemNAMELABEL.TabIndex = 63
        itemNAMELABEL.Text = "Item Name:"
        ' 
        ' itemIDLabel
        ' 
        itemIDLabel.AutoSize = True
        itemIDLabel.Location = New Point(373, 529)
        itemIDLabel.Name = "itemIDLabel"
        itemIDLabel.Size = New Size(61, 20)
        itemIDLabel.TabIndex = 80
        itemIDLabel.Text = "Item ID:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(390, 443)
        Label5.Name = "Label5"
        Label5.Size = New Size(44, 20)
        Label5.TabIndex = 81
        Label5.Text = "Price:"
        ' 
        ' removeTAB
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(957, 600)
        Controls.Add(Label5)
        Controls.Add(itemIDLabel)
        Controls.Add(itemID)
        Controls.Add(removeitembtn)
        Controls.Add(expirationLABEL)
        Controls.Add(RadioButton2)
        Controls.Add(RadioButton1)
        Controls.Add(DateTimePicker1)
        Controls.Add(priceINPUT)
        Controls.Add(quantityINPUT)
        Controls.Add(Label7)
        Controls.Add(Label4)
        Controls.Add(brandINPUT)
        Controls.Add(Label2)
        Controls.Add(categoryINPUT)
        Controls.Add(descriptionINPUT)
        Controls.Add(Label3)
        Controls.Add(itemNAME)
        Controls.Add(itemNAMELABEL)
        Controls.Add(DataGridView1)
        Controls.Add(Label8)
        Controls.Add(filterINPUT)
        Controls.Add(searchBTN)
        Controls.Add(searchBOX)
        Controls.Add(Label1)
        Controls.Add(gotoADD)
        Controls.Add(gotoUPDATE)
        Controls.Add(Label6)
        Controls.Add(backBTN)
        Name = "removeTAB"
        Text = "removeTAB"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label8 As Label
    Friend WithEvents filterINPUT As ComboBox
    Friend WithEvents searchBTN As Button
    Friend WithEvents searchBOX As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents gotoADD As Button
    Friend WithEvents gotoUPDATE As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents backBTN As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents itemID As TextBox
    Friend WithEvents removeitembtn As Button
    Friend WithEvents expirationLABEL As Label
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents priceINPUT As TextBox
    Friend WithEvents quantityINPUT As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents brandINPUT As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents categoryINPUT As TextBox
    Friend WithEvents descriptionINPUT As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents itemNAME As TextBox
    Friend WithEvents itemNAMELABEL As Label
    Friend WithEvents itemIDLabel As Label
    Friend WithEvents Label5 As Label
End Class
