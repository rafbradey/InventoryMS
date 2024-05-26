<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UpdateTAB
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
        gotoADD = New Button()
        gotoREMOVE = New Button()
        Label6 = New Label()
        backBTN = New Button()
        MySqlCommand1 = New MySql.Data.MySqlClient.MySqlCommand()
        DataGridView1 = New DataGridView()
        Label1 = New Label()
        searchBOX = New TextBox()
        searchBTN = New Button()
        Label4 = New Label()
        brandINPUT = New TextBox()
        Label2 = New Label()
        categoryINPUT = New TextBox()
        descriptionINPUT = New TextBox()
        Label3 = New Label()
        itemNAME = New TextBox()
        itemNAMELABEL = New Label()
        expirationLABEL = New Label()
        RadioButton2 = New RadioButton()
        RadioButton1 = New RadioButton()
        DateTimePicker1 = New DateTimePicker()
        priceINPUT = New TextBox()
        Label5 = New Label()
        quantityINPUT = New TextBox()
        Label7 = New Label()
        updateitembtn = New Button()
        itemID = New TextBox()
        itemIDLabel = New Label()
        filterINPUT = New ComboBox()
        Label8 = New Label()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' gotoADD
        ' 
        gotoADD.Location = New Point(613, 22)
        gotoADD.Name = "gotoADD"
        gotoADD.Size = New Size(158, 58)
        gotoADD.TabIndex = 26
        gotoADD.Text = "+ ADD ITEMS"
        gotoADD.UseVisualStyleBackColor = True
        ' 
        ' gotoREMOVE
        ' 
        gotoREMOVE.Location = New Point(777, 22)
        gotoREMOVE.Name = "gotoREMOVE"
        gotoREMOVE.Size = New Size(158, 59)
        gotoREMOVE.TabIndex = 25
        gotoREMOVE.Text = "- REMOVE ITEMS"
        gotoREMOVE.UseVisualStyleBackColor = True
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(27, 22)
        Label6.Name = "Label6"
        Label6.Size = New Size(320, 31)
        Label6.TabIndex = 24
        Label6.Text = "UPDATE ITEM INFORMATION"
        ' 
        ' backBTN
        ' 
        backBTN.Location = New Point(34, 61)
        backBTN.Name = "backBTN"
        backBTN.Size = New Size(159, 36)
        backBTN.TabIndex = 23
        backBTN.Text = "< Back"
        backBTN.UseVisualStyleBackColor = True
        ' 
        ' MySqlCommand1
        ' 
        MySqlCommand1.CacheAge = 0
        MySqlCommand1.Connection = Nothing
        MySqlCommand1.EnableCaching = False
        MySqlCommand1.Transaction = Nothing
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.AllowUserToDeleteRows = False
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(33, 141)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.ReadOnly = True
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.Size = New Size(898, 260)
        DataGridView1.TabIndex = 27
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(187, 108)
        Label1.Name = "Label1"
        Label1.Size = New Size(60, 20)
        Label1.TabIndex = 28
        Label1.Text = "Search: "
        ' 
        ' searchBOX
        ' 
        searchBOX.Location = New Point(253, 106)
        searchBOX.Name = "searchBOX"
        searchBOX.Size = New Size(221, 27)
        searchBOX.TabIndex = 29
        ' 
        ' searchBTN
        ' 
        searchBTN.Location = New Point(480, 106)
        searchBTN.Name = "searchBTN"
        searchBTN.Size = New Size(94, 29)
        searchBTN.TabIndex = 30
        searchBTN.Text = "Search"
        searchBTN.UseVisualStyleBackColor = True
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(91, 487)
        Label4.Name = "Label4"
        Label4.Size = New Size(51, 20)
        Label4.TabIndex = 38
        Label4.Text = "Brand:"
        ' 
        ' brandINPUT
        ' 
        brandINPUT.Location = New Point(148, 482)
        brandINPUT.Name = "brandINPUT"
        brandINPUT.Size = New Size(198, 27)
        brandINPUT.TabIndex = 37
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(73, 452)
        Label2.Name = "Label2"
        Label2.Size = New Size(72, 20)
        Label2.TabIndex = 36
        Label2.Text = "Category:"
        ' 
        ' categoryINPUT
        ' 
        categoryINPUT.Location = New Point(148, 449)
        categoryINPUT.Name = "categoryINPUT"
        categoryINPUT.Size = New Size(198, 27)
        categoryINPUT.TabIndex = 35
        ' 
        ' descriptionINPUT
        ' 
        descriptionINPUT.Location = New Point(148, 515)
        descriptionINPUT.Multiline = True
        descriptionINPUT.Name = "descriptionINPUT"
        descriptionINPUT.Size = New Size(198, 73)
        descriptionINPUT.TabIndex = 34
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(23, 518)
        Label3.Name = "Label3"
        Label3.Size = New Size(126, 20)
        Label3.TabIndex = 33
        Label3.Text = "Item Description: "
        Label3.TextAlign = ContentAlignment.BottomRight
        ' 
        ' itemNAME
        ' 
        itemNAME.Location = New Point(148, 416)
        itemNAME.Name = "itemNAME"
        itemNAME.Size = New Size(198, 27)
        itemNAME.TabIndex = 32
        ' 
        ' itemNAMELABEL
        ' 
        itemNAMELABEL.AutoSize = True
        itemNAMELABEL.Location = New Point(56, 419)
        itemNAMELABEL.Name = "itemNAMELABEL"
        itemNAMELABEL.Size = New Size(86, 20)
        itemNAMELABEL.TabIndex = 31
        itemNAMELABEL.Text = "Item Name:"
        ' 
        ' expirationLABEL
        ' 
        expirationLABEL.AutoSize = True
        expirationLABEL.Location = New Point(552, 452)
        expirationLABEL.Name = "expirationLABEL"
        expirationLABEL.Size = New Size(119, 20)
        expirationLABEL.TabIndex = 46
        expirationLABEL.Text = "Expiration Date: "
        expirationLABEL.Visible = False
        ' 
        ' RadioButton2
        ' 
        RadioButton2.AutoSize = True
        RadioButton2.Location = New Point(741, 415)
        RadioButton2.Name = "RadioButton2"
        RadioButton2.Size = New Size(193, 24)
        RadioButton2.TabIndex = 45
        RadioButton2.TabStop = True
        RadioButton2.Text = "Item has Expiration Date"
        RadioButton2.UseVisualStyleBackColor = True
        ' 
        ' RadioButton1
        ' 
        RadioButton1.AutoSize = True
        RadioButton1.Location = New Point(578, 415)
        RadioButton1.Name = "RadioButton1"
        RadioButton1.Size = New Size(157, 24)
        RadioButton1.TabIndex = 44
        RadioButton1.TabStop = True
        RadioButton1.Text = "No Expiration Date"
        RadioButton1.UseVisualStyleBackColor = True
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Location = New Point(674, 449)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(257, 27)
        DateTimePicker1.TabIndex = 43
        DateTimePicker1.Visible = False
        ' 
        ' priceINPUT
        ' 
        priceINPUT.Location = New Point(441, 449)
        priceINPUT.Name = "priceINPUT"
        priceINPUT.Size = New Size(97, 27)
        priceINPUT.TabIndex = 42
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(391, 452)
        Label5.Name = "Label5"
        Label5.Size = New Size(44, 20)
        Label5.TabIndex = 41
        Label5.Text = "Price:"
        ' 
        ' quantityINPUT
        ' 
        quantityINPUT.Location = New Point(441, 416)
        quantityINPUT.Name = "quantityINPUT"
        quantityINPUT.Size = New Size(97, 27)
        quantityINPUT.TabIndex = 40
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(367, 419)
        Label7.Name = "Label7"
        Label7.Size = New Size(68, 20)
        Label7.TabIndex = 39
        Label7.Text = "Quantity:"
        ' 
        ' updateitembtn
        ' 
        updateitembtn.ForeColor = Color.Green
        updateitembtn.Location = New Point(737, 515)
        updateitembtn.Name = "updateitembtn"
        updateitembtn.Size = New Size(190, 67)
        updateitembtn.TabIndex = 47
        updateitembtn.Text = "UPDATE"
        updateitembtn.UseVisualStyleBackColor = True
        ' 
        ' itemID
        ' 
        itemID.Enabled = False
        itemID.Location = New Point(441, 535)
        itemID.Name = "itemID"
        itemID.Size = New Size(97, 27)
        itemID.TabIndex = 49
        ' 
        ' itemIDLabel
        ' 
        itemIDLabel.AutoSize = True
        itemIDLabel.Location = New Point(367, 538)
        itemIDLabel.Name = "itemIDLabel"
        itemIDLabel.Size = New Size(61, 20)
        itemIDLabel.TabIndex = 48
        itemIDLabel.Text = "Item ID:"
        ' 
        ' filterINPUT
        ' 
        filterINPUT.FormattingEnabled = True
        filterINPUT.Items.AddRange(New Object() {"Name", "Category", "Brand", "Description", "Quantity", "Price", "ID"})
        filterINPUT.Location = New Point(85, 105)
        filterINPUT.Name = "filterINPUT"
        filterINPUT.Size = New Size(96, 28)
        filterINPUT.TabIndex = 51
        filterINPUT.Text = "Name"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(34, 109)
        Label8.Name = "Label8"
        Label8.Size = New Size(45, 20)
        Label8.TabIndex = 52
        Label8.Text = "Filter:"
        ' 
        ' UpdateTAB
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(957, 600)
        Controls.Add(Label8)
        Controls.Add(filterINPUT)
        Controls.Add(itemID)
        Controls.Add(itemIDLabel)
        Controls.Add(updateitembtn)
        Controls.Add(expirationLABEL)
        Controls.Add(RadioButton2)
        Controls.Add(RadioButton1)
        Controls.Add(DateTimePicker1)
        Controls.Add(priceINPUT)
        Controls.Add(Label5)
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
        Controls.Add(searchBTN)
        Controls.Add(searchBOX)
        Controls.Add(Label1)
        Controls.Add(DataGridView1)
        Controls.Add(gotoADD)
        Controls.Add(gotoREMOVE)
        Controls.Add(Label6)
        Controls.Add(backBTN)
        Name = "UpdateTAB"
        Text = "Update"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents gotoADD As Button
    Friend WithEvents gotoREMOVE As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents backBTN As Button
    Friend WithEvents MySqlCommand1 As MySql.Data.MySqlClient.MySqlCommand
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents searchBOX As TextBox
    Friend WithEvents searchBTN As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents brandINPUT As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents categoryINPUT As TextBox
    Friend WithEvents descriptionINPUT As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents itemNAME As TextBox
    Friend WithEvents itemNAMELABEL As Label
    Friend WithEvents expirationLABEL As Label
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents priceINPUT As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents quantityINPUT As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents updateitembtn As Button
    Friend WithEvents itemID As TextBox
    Friend WithEvents itemIDLabel As Label
    Friend WithEvents filterINPUT As ComboBox
    Friend WithEvents Label8 As Label
End Class
