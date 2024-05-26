<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class additemsTAB
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
        itemNAMELABEL = New Label()
        itemNAME = New TextBox()
        addITEMbtn = New Button()
        addbackBTN = New Button()
        DataGridView1 = New DataGridView()
        Label1 = New Label()
        descriptionINPUT = New TextBox()
        categoryINPUT = New TextBox()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        brandINPUT = New TextBox()
        quantityINPUT = New TextBox()
        priceINPUT = New TextBox()
        Label5 = New Label()
        DateTimePicker1 = New DateTimePicker()
        RadioButton1 = New RadioButton()
        RadioButton2 = New RadioButton()
        expirationLABEL = New Label()
        Label6 = New Label()
        Button1 = New Button()
        Label8 = New Label()
        filterINPUT = New ComboBox()
        searchBTN = New Button()
        searchBOX = New TextBox()
        Label7 = New Label()
        gotoREMOVE = New Button()
        gotoUPDATE = New Button()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' itemNAMELABEL
        ' 
        itemNAMELABEL.AutoSize = True
        itemNAMELABEL.Location = New Point(63, 408)
        itemNAMELABEL.Name = "itemNAMELABEL"
        itemNAMELABEL.Size = New Size(86, 20)
        itemNAMELABEL.TabIndex = 0
        itemNAMELABEL.Text = "Item Name:"
        ' 
        ' itemNAME
        ' 
        itemNAME.Location = New Point(155, 405)
        itemNAME.Name = "itemNAME"
        itemNAME.Size = New Size(198, 27)
        itemNAME.TabIndex = 1
        ' 
        ' addITEMbtn
        ' 
        addITEMbtn.ForeColor = SystemColors.Highlight
        addITEMbtn.Location = New Point(745, 521)
        addITEMbtn.Name = "addITEMbtn"
        addITEMbtn.Size = New Size(190, 67)
        addITEMbtn.TabIndex = 2
        addITEMbtn.Text = "+ Add Item"
        addITEMbtn.UseVisualStyleBackColor = True
        ' 
        ' addbackBTN
        ' 
        addbackBTN.Location = New Point(37, 59)
        addbackBTN.Name = "addbackBTN"
        addbackBTN.Size = New Size(159, 36)
        addbackBTN.TabIndex = 3
        addbackBTN.Text = "< Back"
        addbackBTN.UseVisualStyleBackColor = True
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.AllowUserToDeleteRows = False
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(37, 108)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.ReadOnly = True
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.Size = New Size(898, 278)
        DataGridView1.TabIndex = 4
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(30, 507)
        Label1.Name = "Label1"
        Label1.Size = New Size(126, 20)
        Label1.TabIndex = 5
        Label1.Text = "Item Description: "
        Label1.TextAlign = ContentAlignment.BottomRight
        ' 
        ' descriptionINPUT
        ' 
        descriptionINPUT.Location = New Point(155, 504)
        descriptionINPUT.Multiline = True
        descriptionINPUT.Name = "descriptionINPUT"
        descriptionINPUT.Size = New Size(198, 84)
        descriptionINPUT.TabIndex = 6
        ' 
        ' categoryINPUT
        ' 
        categoryINPUT.Location = New Point(155, 438)
        categoryINPUT.Name = "categoryINPUT"
        categoryINPUT.Size = New Size(198, 27)
        categoryINPUT.TabIndex = 7
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(80, 441)
        Label2.Name = "Label2"
        Label2.Size = New Size(72, 20)
        Label2.TabIndex = 8
        Label2.Text = "Category:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(371, 408)
        Label3.Name = "Label3"
        Label3.Size = New Size(68, 20)
        Label3.TabIndex = 9
        Label3.Text = "Quantity:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(98, 476)
        Label4.Name = "Label4"
        Label4.Size = New Size(51, 20)
        Label4.TabIndex = 11
        Label4.Text = "Brand:"
        ' 
        ' brandINPUT
        ' 
        brandINPUT.Location = New Point(155, 471)
        brandINPUT.Name = "brandINPUT"
        brandINPUT.Size = New Size(198, 27)
        brandINPUT.TabIndex = 10
        ' 
        ' quantityINPUT
        ' 
        quantityINPUT.Location = New Point(445, 405)
        quantityINPUT.Name = "quantityINPUT"
        quantityINPUT.Size = New Size(97, 27)
        quantityINPUT.TabIndex = 12
        ' 
        ' priceINPUT
        ' 
        priceINPUT.Location = New Point(445, 438)
        priceINPUT.Name = "priceINPUT"
        priceINPUT.Size = New Size(97, 27)
        priceINPUT.TabIndex = 14
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(395, 441)
        Label5.Name = "Label5"
        Label5.Size = New Size(44, 20)
        Label5.TabIndex = 13
        Label5.Text = "Price:"
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Location = New Point(678, 438)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(257, 27)
        DateTimePicker1.TabIndex = 15
        DateTimePicker1.Visible = False
        ' 
        ' RadioButton1
        ' 
        RadioButton1.AutoSize = True
        RadioButton1.Location = New Point(582, 404)
        RadioButton1.Name = "RadioButton1"
        RadioButton1.Size = New Size(157, 24)
        RadioButton1.TabIndex = 16
        RadioButton1.TabStop = True
        RadioButton1.Text = "No Expiration Date"
        RadioButton1.UseVisualStyleBackColor = True
        ' 
        ' RadioButton2
        ' 
        RadioButton2.AutoSize = True
        RadioButton2.Location = New Point(745, 404)
        RadioButton2.Name = "RadioButton2"
        RadioButton2.Size = New Size(193, 24)
        RadioButton2.TabIndex = 17
        RadioButton2.TabStop = True
        RadioButton2.Text = "Item has Expiration Date"
        RadioButton2.UseVisualStyleBackColor = True
        ' 
        ' expirationLABEL
        ' 
        expirationLABEL.AutoSize = True
        expirationLABEL.Location = New Point(556, 441)
        expirationLABEL.Name = "expirationLABEL"
        expirationLABEL.Size = New Size(119, 20)
        expirationLABEL.TabIndex = 18
        expirationLABEL.Text = "Expiration Date: "
        expirationLABEL.Visible = False
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(30, 20)
        Label6.Name = "Label6"
        Label6.Size = New Size(274, 31)
        Label6.TabIndex = 19
        Label6.Text = "Add Items into Inventory"
        ' 
        ' Button1
        ' 
        Button1.ForeColor = Color.Maroon
        Button1.Location = New Point(528, 521)
        Button1.Name = "Button1"
        Button1.Size = New Size(190, 67)
        Button1.TabIndex = 20
        Button1.Text = "RESET FIELDS"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(207, 67)
        Label8.Name = "Label8"
        Label8.Size = New Size(45, 20)
        Label8.TabIndex = 66
        Label8.Text = "Filter:"
        ' 
        ' filterINPUT
        ' 
        filterINPUT.FormattingEnabled = True
        filterINPUT.Items.AddRange(New Object() {"Name", "Category", "Brand", "Description", "Quantity", "Price", "ID"})
        filterINPUT.Location = New Point(258, 63)
        filterINPUT.Name = "filterINPUT"
        filterINPUT.Size = New Size(96, 28)
        filterINPUT.TabIndex = 65
        filterINPUT.Text = "Name"
        ' 
        ' searchBTN
        ' 
        searchBTN.Location = New Point(653, 64)
        searchBTN.Name = "searchBTN"
        searchBTN.Size = New Size(94, 29)
        searchBTN.TabIndex = 64
        searchBTN.Text = "Search"
        searchBTN.UseVisualStyleBackColor = True
        ' 
        ' searchBOX
        ' 
        searchBOX.Location = New Point(426, 64)
        searchBOX.Name = "searchBOX"
        searchBOX.Size = New Size(221, 27)
        searchBOX.TabIndex = 63
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(360, 66)
        Label7.Name = "Label7"
        Label7.Size = New Size(60, 20)
        Label7.TabIndex = 62
        Label7.Text = "Search: "
        ' 
        ' gotoREMOVE
        ' 
        gotoREMOVE.Location = New Point(623, 10)
        gotoREMOVE.Name = "gotoREMOVE"
        gotoREMOVE.Size = New Size(158, 41)
        gotoREMOVE.TabIndex = 68
        gotoREMOVE.Text = "- REMOVE ITEMS"
        gotoREMOVE.UseVisualStyleBackColor = True
        ' 
        ' gotoUPDATE
        ' 
        gotoUPDATE.Location = New Point(787, 10)
        gotoUPDATE.Name = "gotoUPDATE"
        gotoUPDATE.Size = New Size(158, 41)
        gotoUPDATE.TabIndex = 67
        gotoUPDATE.Text = "* UPDATE ITEMS"
        gotoUPDATE.UseVisualStyleBackColor = True
        ' 
        ' additemsTAB
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(957, 600)
        Controls.Add(gotoREMOVE)
        Controls.Add(gotoUPDATE)
        Controls.Add(Label8)
        Controls.Add(filterINPUT)
        Controls.Add(searchBTN)
        Controls.Add(searchBOX)
        Controls.Add(Label7)
        Controls.Add(Button1)
        Controls.Add(Label6)
        Controls.Add(expirationLABEL)
        Controls.Add(RadioButton2)
        Controls.Add(RadioButton1)
        Controls.Add(DateTimePicker1)
        Controls.Add(priceINPUT)
        Controls.Add(Label5)
        Controls.Add(quantityINPUT)
        Controls.Add(Label4)
        Controls.Add(brandINPUT)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(categoryINPUT)
        Controls.Add(descriptionINPUT)
        Controls.Add(Label1)
        Controls.Add(DataGridView1)
        Controls.Add(addbackBTN)
        Controls.Add(addITEMbtn)
        Controls.Add(itemNAME)
        Controls.Add(itemNAMELABEL)
        Margin = New Padding(3, 4, 3, 4)
        Name = "additemsTAB"
        Text = "Form1"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents itemNAMELABEL As Label
    Friend WithEvents itemNAME As TextBox
    Friend WithEvents addITEMbtn As Button
    Friend WithEvents addbackBTN As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents descriptionINPUT As TextBox
    Friend WithEvents categoryINPUT As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents brandINPUT As TextBox
    Friend WithEvents quantityINPUT As TextBox
    Friend WithEvents priceINPUT As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents expirationLABEL As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents filterINPUT As ComboBox
    Friend WithEvents searchBTN As Button
    Friend WithEvents searchBOX As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents gotoREMOVE As Button
    Friend WithEvents gotoUPDATE As Button

End Class
