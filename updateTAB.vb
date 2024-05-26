
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports MySql.Data.MySqlClient
Imports Mysqlx


Public Class UpdateTAB

    Private Sub backBTN_Click(sender As Object, e As EventArgs) Handles backBTN.Click
        Me.Hide()
        Dashboard.Show()
    End Sub



    'When Exit Button is clicked
    Private Sub updateTAB_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Login.Close()
        Dashboard.Close()
        Application.Exit()
    End Sub
    Private Sub updateTAB_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.CenterToScreen()
        Me.CenterToParent()
        Me.Text = "Update Item Information"

        'Load DataGrid
        Dashboard.LoadData(DataGridView1)
        Dashboard.RefreshData()
        Dashboard.refreshCheckData()

    End Sub

    Private Sub DataGridView1_SelectionChanged(sender As Object, e As EventArgs) Handles DataGridView1.SelectionChanged
        If DataGridView1.SelectedRows.Count > 0 Then
            Dim selectedRow As DataGridViewRow = DataGridView1.SelectedRows(0)

            ' Populate Textboxes
            itemID.Text = selectedRow.Cells(0).Value.ToString()
            itemNAME.Text = selectedRow.Cells(1).Value.ToString()
            categoryINPUT.Text = selectedRow.Cells(2).Value.ToString()
            brandINPUT.Text = selectedRow.Cells(3).Value.ToString()
            descriptionINPUT.Text = selectedRow.Cells(4).Value.ToString()
            quantityINPUT.Text = selectedRow.Cells(5).Value.ToString()
            priceINPUT.Text = selectedRow.Cells(6).Value.ToString()

            ' Check if item has expiration date
            If String.IsNullOrEmpty(selectedRow.Cells(7).Value.ToString()) Then
                RadioButton1.Checked = True
            Else
                RadioButton2.Checked = True
                DateTimePicker1.Text = selectedRow.Cells(7).Value.ToString()
            End If
        End If
    End Sub

    Private Sub updateitemBTN_Click(sender As Object, e As EventArgs) Handles updateitembtn.Click
        Dim conn As MySqlConnection
        conn = New MySqlConnection("server=localhost; userid=root; password=@Mar2022108194; database=inventoryms")

        Try
            conn.Open()
            Dim Query As String
            Query = "UPDATE inventoryms.itemlist SET ITEM_NAME = @ItemName, ITEM_CATEGORY = @ItemCategory, ITEM_BRAND = @ItemBrand, ITEM_DESCRIPTION = @ItemDescription, ITEM_QUANTITY = @ItemQuantity, ITEM_PRICE = @ItemPrice, ITEM_EXPIRATION = @ItemExpiration WHERE ITEM_ID = @ItemID"
            Dim COMMAND As New MySqlCommand(Query, conn)

            COMMAND.Parameters.AddWithValue("@ItemID", Convert.ToInt32(itemID.Text))
            COMMAND.Parameters.AddWithValue("@ItemName", itemNAME.Text)
            COMMAND.Parameters.AddWithValue("@ItemCategory", categoryINPUT.Text)
            COMMAND.Parameters.AddWithValue("@ItemBrand", brandINPUT.Text)
            COMMAND.Parameters.AddWithValue("@ItemDescription", descriptionINPUT.Text)
            COMMAND.Parameters.AddWithValue("@ItemQuantity", Convert.ToInt32(quantityINPUT.Text))
            COMMAND.Parameters.AddWithValue("@ItemPrice", Convert.ToDouble(priceINPUT.Text))
            ' If RadioButton1 is checked, set the expiration date to NULL
            If RadioButton1.Checked Then
                COMMAND.Parameters.AddWithValue("@ItemExpiration", DBNull.Value)
            Else
                COMMAND.Parameters.AddWithValue("@ItemExpiration", Convert.ToDateTime(DateTimePicker1.Text))
            End If

            COMMAND.ExecuteNonQuery()

            MessageBox.Show("Item has been updated." & vbCrLf &
                        "ID: " & itemID.Text & vbCrLf &
                        "Item Name: " & itemNAME.Text,
                        "Item Updated", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            'refresh data in dashboard
            Dashboard.RefreshData()
            Dashboard.refreshCheckData()

        Catch ex As Exception
            MessageBox.Show("Error connecting to database: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub


    Private Sub RadioButton1_CheckedChanged_1(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        'Enable if radiobutton 1 is checked
        If RadioButton1.Checked = True Then
            DateTimePicker1.Visible = False
            expirationLABEL.Visible = False
        End If
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        'Enable if radiobutton 2 is checked
        If RadioButton2.Checked = True Then
            DateTimePicker1.Visible = True
            DateTimePicker1.Enabled = True
            expirationLABEL.Visible = True
        End If
    End Sub

    Private Sub searchBTN_Click(sender As Object, e As EventArgs) Handles searchBTN.Click
        Dim conn As MySqlConnection
        conn = New MySqlConnection("server=localhost; userid=root; password=@Mar2022108194; database=inventoryms")

        Try
            conn.Open()
            Dim Query As String

            If filterINPUT.Text = "ID" Then
                Query = "SELECT * FROM inventoryms.itemlist WHERE ITEM_ID = @searchNum"
            ElseIf filterINPUT.Text = "Name" Then
                Query = "SELECT * FROM inventoryms.itemlist WHERE ITEM_NAME LIKE @searchText"
            ElseIf filterINPUT.Text = "Category" Then
                Query = "SELECT * FROM inventoryms.itemlist WHERE ITEM_CATEGORY LIKE @searchText"
            ElseIf filterINPUT.Text = "Brand" Then
                Query = "SELECT * FROM inventoryms.itemlist WHERE ITEM_BRAND LIKE @searchText"
            ElseIf filterINPUT.Text = "Description" Then
                Query = "SELECT * FROM inventoryms.itemlist WHERE ITEM_DESCRIPTION LIKE @searchText"
            ElseIf filterINPUT.Text = "Quantity" Then
                Query = "SELECT * FROM inventoryms.itemlist WHERE ITEM_QUANTITY = @searchNum"
            ElseIf filterINPUT.Text = "Price" Then
                Query = "SELECT * FROM inventoryms.itemlist WHERE ITEM_PRICE = @searchNum"
            End If

            Dim COMMAND As New MySqlCommand(Query, conn)

            'for Texts
            COMMAND.Parameters.AddWithValue("@searchText", "%" & searchBOX.Text & "%")
            'for numbers
            COMMAND.Parameters.AddWithValue("@searchNum", searchBOX.Text)

            Dim SDA As New MySqlDataAdapter
            Dim dbDataSet As New DataTable
            Dim bSource As New BindingSource

            SDA.SelectCommand = COMMAND
            SDA.Fill(dbDataSet)
            bSource.DataSource = dbDataSet
            DataGridView1.DataSource = bSource
            SDA.Update(dbDataSet)

            conn.Close()
        Catch ex As Exception
            MessageBox.Show("Error connecting to database: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub searchBOX_TextChanged(sender As Object, e As EventArgs) Handles searchBOX.TextChanged
        If searchBOX.Text = "" Then
            Dashboard.LoadData(DataGridView1)
            Dashboard.RefreshData()
            Dashboard.refreshCheckData()
        End If
    End Sub

    Private Sub gotoADD_Click(sender As Object, e As EventArgs) Handles gotoADD.Click
        Me.Hide()
        additemsTAB.Show()
    End Sub

    Private Sub gotoREMOVE_Click(sender As Object, e As EventArgs) Handles gotoREMOVE.Click
        'Hide this form and show the remove items form
        Me.Hide()
        removeTAB.Show()
    End Sub
End Class