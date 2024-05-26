<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Dashboard
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
        additemstabBTN = New Button()
        updateTABbtn = New Button()
        removeTABbtn = New Button()
        LOGOUT = New Button()
        dashboardDATAGRID = New DataGridView()
        Label1 = New Label()
        Label2 = New Label()
        expiredBTN = New Button()
        aboutPOP = New Button()
        Label3 = New Label()
        nearBTN = New Button()
        indateBTN = New Button()
        refreshBTN = New Button()
        Label4 = New Label()
        instock = New Button()
        lowstock = New Button()
        outofstock = New Button()
        Label8 = New Label()
        filterINPUT1 = New ComboBox()
        searchBTN1 = New Button()
        searchBOX1 = New TextBox()
        Label5 = New Label()
        CType(dashboardDATAGRID, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' additemstabBTN
        ' 
        additemstabBTN.Location = New Point(12, 77)
        additemstabBTN.Name = "additemstabBTN"
        additemstabBTN.Size = New Size(195, 106)
        additemstabBTN.TabIndex = 0
        additemstabBTN.Text = "ADD ITEMS"
        additemstabBTN.UseVisualStyleBackColor = True
        ' 
        ' updateTABbtn
        ' 
        updateTABbtn.Location = New Point(12, 199)
        updateTABbtn.Name = "updateTABbtn"
        updateTABbtn.Size = New Size(195, 106)
        updateTABbtn.TabIndex = 1
        updateTABbtn.Text = "UPDATE ITEM INFORMATION"
        updateTABbtn.UseVisualStyleBackColor = True
        ' 
        ' removeTABbtn
        ' 
        removeTABbtn.Location = New Point(12, 320)
        removeTABbtn.Name = "removeTABbtn"
        removeTABbtn.Size = New Size(195, 106)
        removeTABbtn.TabIndex = 2
        removeTABbtn.Text = "REMOVE ITEMS"
        removeTABbtn.UseVisualStyleBackColor = True
        ' 
        ' LOGOUT
        ' 
        LOGOUT.ForeColor = Color.Crimson
        LOGOUT.Location = New Point(12, 597)
        LOGOUT.Name = "LOGOUT"
        LOGOUT.Size = New Size(195, 51)
        LOGOUT.TabIndex = 3
        LOGOUT.Text = "LOGOUT"
        LOGOUT.UseVisualStyleBackColor = True
        ' 
        ' dashboardDATAGRID
        ' 
        dashboardDATAGRID.AllowUserToAddRows = False
        dashboardDATAGRID.AllowUserToDeleteRows = False
        dashboardDATAGRID.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dashboardDATAGRID.Location = New Point(228, 115)
        dashboardDATAGRID.Name = "dashboardDATAGRID"
        dashboardDATAGRID.ReadOnly = True
        dashboardDATAGRID.RowHeadersWidth = 51
        dashboardDATAGRID.Size = New Size(722, 311)
        dashboardDATAGRID.TabIndex = 4
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(228, 75)
        Label1.Name = "Label1"
        Label1.Size = New Size(141, 38)
        Label1.TabIndex = 5
        Label1.Text = "ITEM LIST"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 16F)
        Label2.Location = New Point(12, 19)
        Label2.Name = "Label2"
        Label2.Size = New Size(449, 37)
        Label2.TabIndex = 6
        Label2.Text = "INVENTORY MANAGEMENT SYSTEM"
        ' 
        ' expiredBTN
        ' 
        expiredBTN.Location = New Point(714, 478)
        expiredBTN.Name = "expiredBTN"
        expiredBTN.Size = New Size(236, 63)
        expiredBTN.TabIndex = 7
        expiredBTN.Text = "EXPIRED: 0"
        expiredBTN.UseVisualStyleBackColor = True
        ' 
        ' aboutPOP
        ' 
        aboutPOP.Location = New Point(12, 445)
        aboutPOP.Name = "aboutPOP"
        aboutPOP.Size = New Size(195, 106)
        aboutPOP.TabIndex = 8
        aboutPOP.Text = "About"
        aboutPOP.UseVisualStyleBackColor = True
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(221, 437)
        Label3.Name = "Label3"
        Label3.Size = New Size(506, 38)
        Label3.TabIndex = 9
        Label3.Text = "INVENTORY ITEM EXPIRATION STATUS"
        ' 
        ' nearBTN
        ' 
        nearBTN.Location = New Point(472, 478)
        nearBTN.Name = "nearBTN"
        nearBTN.Size = New Size(236, 63)
        nearBTN.TabIndex = 13
        nearBTN.Text = "NEAR-EXPIRATION:  0"
        nearBTN.UseVisualStyleBackColor = True
        ' 
        ' indateBTN
        ' 
        indateBTN.Location = New Point(230, 478)
        indateBTN.Name = "indateBTN"
        indateBTN.Size = New Size(236, 63)
        indateBTN.TabIndex = 14
        indateBTN.Text = "IN-DATE: 0"
        indateBTN.UseVisualStyleBackColor = True
        ' 
        ' refreshBTN
        ' 
        refreshBTN.Location = New Point(762, 12)
        refreshBTN.Name = "refreshBTN"
        refreshBTN.Size = New Size(188, 45)
        refreshBTN.TabIndex = 15
        refreshBTN.Text = "Refresh"
        refreshBTN.UseVisualStyleBackColor = True
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(228, 544)
        Label4.Name = "Label4"
        Label4.Size = New Size(363, 38)
        Label4.TabIndex = 16
        Label4.Text = "INVENTORY STOCK STATUS"
        ' 
        ' instock
        ' 
        instock.Location = New Point(230, 585)
        instock.Name = "instock"
        instock.Size = New Size(236, 63)
        instock.TabIndex = 17
        instock.Text = "IN-STOCK"
        instock.UseVisualStyleBackColor = True
        ' 
        ' lowstock
        ' 
        lowstock.Location = New Point(472, 585)
        lowstock.Name = "lowstock"
        lowstock.Size = New Size(236, 63)
        lowstock.TabIndex = 18
        lowstock.Text = "LOW STOCK"
        lowstock.UseVisualStyleBackColor = True
        ' 
        ' outofstock
        ' 
        outofstock.Location = New Point(714, 585)
        outofstock.Name = "outofstock"
        outofstock.Size = New Size(236, 63)
        outofstock.TabIndex = 19
        outofstock.Text = "OUT OF STOCK: 0"
        outofstock.UseVisualStyleBackColor = True
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(364, 83)
        Label8.Name = "Label8"
        Label8.Size = New Size(45, 20)
        Label8.TabIndex = 57
        Label8.Text = "Filter:"
        ' 
        ' filterINPUT1
        ' 
        filterINPUT1.FormattingEnabled = True
        filterINPUT1.Items.AddRange(New Object() {"Name", "Category", "Brand", "Description", "Quantity", "Price", "ID"})
        filterINPUT1.Location = New Point(415, 79)
        filterINPUT1.Name = "filterINPUT1"
        filterINPUT1.Size = New Size(96, 28)
        filterINPUT1.TabIndex = 56
        filterINPUT1.Text = "Name"
        ' 
        ' searchBTN1
        ' 
        searchBTN1.Location = New Point(810, 80)
        searchBTN1.Name = "searchBTN1"
        searchBTN1.Size = New Size(94, 29)
        searchBTN1.TabIndex = 55
        searchBTN1.Text = "Search"
        searchBTN1.UseVisualStyleBackColor = True
        ' 
        ' searchBOX1
        ' 
        searchBOX1.Location = New Point(583, 80)
        searchBOX1.Name = "searchBOX1"
        searchBOX1.Size = New Size(221, 27)
        searchBOX1.TabIndex = 54
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(517, 82)
        Label5.Name = "Label5"
        Label5.Size = New Size(60, 20)
        Label5.TabIndex = 53
        Label5.Text = "Search: "
        ' 
        ' Dashboard
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(962, 663)
        Controls.Add(Label8)
        Controls.Add(filterINPUT1)
        Controls.Add(searchBTN1)
        Controls.Add(searchBOX1)
        Controls.Add(Label5)
        Controls.Add(outofstock)
        Controls.Add(lowstock)
        Controls.Add(instock)
        Controls.Add(Label4)
        Controls.Add(refreshBTN)
        Controls.Add(indateBTN)
        Controls.Add(nearBTN)
        Controls.Add(Label3)
        Controls.Add(aboutPOP)
        Controls.Add(expiredBTN)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(dashboardDATAGRID)
        Controls.Add(LOGOUT)
        Controls.Add(removeTABbtn)
        Controls.Add(updateTABbtn)
        Controls.Add(additemstabBTN)
        Name = "Dashboard"
        Text = "LOGOUT"
        CType(dashboardDATAGRID, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents additemstabBTN As Button
    Friend WithEvents updateTABbtn As Button
    Friend WithEvents removeTABbtn As Button
    Friend WithEvents LOGOUT As Button
    Friend WithEvents dashboardDATAGRID As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents expiredBTN As Button
    Friend WithEvents aboutPOP As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents nearBTN As Button
    Friend WithEvents indateBTN As Button
    Friend WithEvents refreshBTN As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents instock As Button
    Friend WithEvents lowstock As Button
    Friend WithEvents outofstock As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents filterINPUT1 As ComboBox
    Friend WithEvents searchBTN1 As Button
    Friend WithEvents searchBOX1 As TextBox
    Friend WithEvents Label5 As Label
End Class
