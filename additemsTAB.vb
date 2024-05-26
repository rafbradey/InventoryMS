
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports MySql.Data.MySqlClient
Imports Mysqlx

Public Class additemsTAB
    Dim conn As MySqlConnection
    Dim COMMAND As MySqlCommand

    Private Sub additemsTAB_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToParent()
        Dashboard.LoadData(DataGridView1)
        Dashboard.RefreshData()
        Dashboard.refreshCheckData()
        Me.Text = "Add Items into Inventory"


    End Sub

    'If Exit button is clicked, close also the hidden application Login.vb
    Private Sub additemsTAB_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Login.Close()
        Application.Exit()
    End Sub
    Private Sub addITEMbtn_Click(sender As Object, e As EventArgs) Handles addITEMbtn.Click

        Dim conn As MySqlConnection
        conn = New MySqlConnection("server=localhost; userid=root; password=@Mar2022108194; database=inventoryms")

        Try
            conn.Open()
            Dim Query As String
            Query = "INSERT INTO inventoryms.itemlist (ITEM_NAME, ITEM_CATEGORY, ITEM_BRAND, ITEM_DESCRIPTION, ITEM_QUANTITY, ITEM_PRICE, ITEM_EXPIRATION) VALUES (@ItemName, @ItemCategory, @ItemBrand, @ItemDescription, @ItemQuantity, @ItemPrice, @ItemExpiration)"
            Dim COMMAND As New MySqlCommand(Query, conn)

            ' Assuming you have corresponding TextBox or input controls for each attribute
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

            'get the auto-incremented ID of the last inserted item, and store it into newItemID
            Dim newItemID As Integer = Convert.ToInt32(COMMAND.LastInsertedId)

            MessageBox.Show("Item has been added to the list." & vbCrLf &
                        "ID: " & newItemID.ToString() & vbCrLf &
                        "Item Name: " & itemNAME.Text,
                        "Item Added", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            'refresh data in dashboard
            Dashboard.RefreshData()
            Dashboard.refreshCheckData()
        Catch ex As Exception
            MessageBox.Show("Error connecting to database: " & ex.Message)
        Finally
            conn.Close()
        End Try

    End Sub


    Private Sub addbackBTN_Click(sender As Object, e As EventArgs) Handles addbackBTN.Click
        Me.Hide()
        Dashboard.Show()
        Me.CenterToParent()
        Me.CenterToScreen()



    End Sub


    Private Sub priceINPUT_TextChanged(sender As Object, e As EventArgs) Handles priceINPUT.TextChanged
        Try
            Dim decValue As Decimal

            If Decimal.TryParse(priceINPUT.Text, decValue) AndAlso decValue >= 0 Then
            ElseIf String.IsNullOrEmpty(priceINPUT.Text) Then

            Else
                MessageBox.Show("Error! Enter Positive Numbers Only!", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                priceINPUT.Clear()
            End If
        Catch ex As Exception
            MessageBox.Show("An unexpected error occurred: " & ex.Message, "Unexpected Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            priceINPUT.Clear()
        End Try
    End Sub

    Private Sub quantityINPUT_TextChanged(sender As Object, e As EventArgs) Handles quantityINPUT.TextChanged
        Try
            Dim intValue As Integer

            If Integer.TryParse(quantityINPUT.Text, intValue) AndAlso intValue >= 0 Then

            ElseIf String.IsNullOrEmpty(quantityINPUT.Text) Then

            Else

                MessageBox.Show("Error! Enter Positive Whole Numbers Only!", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                quantityINPUT.Clear()
            End If
        Catch ex As Exception
            MessageBox.Show("An unexpected error occurred: " & ex.Message, "Unexpected Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            quantityINPUT.Clear()
        End Try
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        'Disable if radiobutton 2 is checked
        If RadioButton1.Checked = True Then

            DateTimePicker1.Enabled = False
        End If
    End Sub
    'automatic enable radiobutton1 when loaded
    Private Sub additemsTAB_Load_1(sender As Object, e As EventArgs) Handles MyBase.Load
        RadioButton1.Checked = True
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

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub descriptionINPUT_TextChanged(sender As Object, e As EventArgs) Handles descriptionINPUT.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        'Are you sure you want to clear all fields?
        Dim result As Integer = MessageBox.Show("Are you sure you want to clear all fields?", "Clear Fields", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.No Then
            Exit Sub
        Else
            itemNAME.Clear()
            categoryINPUT.Clear()
            brandINPUT.Clear()
            descriptionINPUT.Clear()
            quantityINPUT.Clear()
            priceINPUT.Clear()
            RadioButton1.Checked = True
        End If

        MessageBox.Show("All fields have been cleared.", "Clear Fields", MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Sub



    Private Sub gotoREMOVE_Click(sender As Object, e As EventArgs) Handles gotoREMOVE.Click
        Me.Hide()
        removeTAB.Show()
    End Sub

    Private Sub gotoUPDATE_Click(sender As Object, e As EventArgs) Handles gotoUPDATE.Click
        Me.Hide()
        UpdateTAB.Show()
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
End Class
