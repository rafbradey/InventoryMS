Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports MySql.Data.MySqlClient
Imports Mysqlx
Public Class removeTAB

    Private Sub removeTAB_close(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Login.Close()
        Me.Close()
        additemsTAB.Close()
        Dashboard.Close()
        Application.Exit()
    End Sub
    Private Sub removeTAB_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.CenterToScreen()
        Me.CenterToParent()
        Me.Text = "Remove Items from Inventory"

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

    Private Sub backBTN_Click(sender As Object, e As EventArgs) Handles backBTN.Click
        Me.Hide()
        Dashboard.Show()
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
            DateTimePicker1.Enabled = False
            expirationLABEL.Visible = True
        End If
    End Sub

    Private Sub removeitembtn_Click(sender As Object, e As EventArgs) Handles removeitembtn.Click

        'are you sure?
        Dim dialog As DialogResult
        dialog = MessageBox.Show("Are you sure you want to delete this item?" & vbCrLf &
                                 "ID: " & itemID.Text & vbCrLf &
                                 "Name: " & itemNAME.Text,
                                 "Delete Item", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        'if no, exit sub
        If dialog = DialogResult.No Then
            Exit Sub
        End If

        'remove selected item from inventory
        Dim conn As MySqlConnection
        conn = New MySqlConnection("server=localhost; userid=root; password=@Mar2022108194; database=inventoryms")

        Try
            conn.Open()
            Dim Query As String
            Query = "DELETE FROM inventoryms.itemlist WHERE ITEM_ID = @ItemID"
            Dim COMMAND As New MySqlCommand(Query, conn)

            COMMAND.Parameters.AddWithValue("@ItemID", Convert.ToInt32(itemID.Text))

            COMMAND.ExecuteNonQuery()

            MessageBox.Show("Item has been deleted." & vbCrLf &
                        "ID: " & itemID.Text,
                        "Item Deleted", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            'refresh data in dashboard
            Dashboard.RefreshData()
            Dashboard.refreshCheckData()

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
        'hide this form and show additemsTAB
        Me.Hide()
        additemsTAB.Show()
    End Sub

    Private Sub gotoUPDATE_Click(sender As Object, e As EventArgs) Handles gotoUPDATE.Click
        'hide this form and show removeTAB
        Me.Hide()
        UpdateTAB.Show()

    End Sub
End Class