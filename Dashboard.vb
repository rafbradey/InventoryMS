
Imports System.Security.Cryptography
Imports MySql.Data.MySqlClient
Imports Mysqlx
Public Class Dashboard
    Dim conn As MySqlConnection
    Dim COMMAND As MySqlCommand
    Dim SDA As New MySqlDataAdapter
    Dim dbDataSet As New DataTable

    Private Sub Dashboard_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Login.Close()
        additemsTAB.Close()
        Application.Exit()
    End Sub
    Private Sub additemstabBTN_Click(sender As Object, e As EventArgs) Handles additemstabBTN.Click
        Me.Hide()
        additemsTAB.Show()
    End Sub

    Private Sub updateTABbtn_Click(sender As Object, e As EventArgs) Handles updateTABbtn.Click
        'Go to Update Form
        Me.Hide()
        UpdateTAB.Show()

    End Sub

    Private Sub removeTABbtn_Click(sender As Object, e As EventArgs) Handles removeTABbtn.Click
        Me.Hide()
        removeTAB.Show()
    End Sub


    'Show Tables from Database

    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToParent()
        LoadData(dashboardDATAGRID)
        Me.Text = "Dashboard"

        refreshCheckData()



    End Sub

    ' Refresh Method
    Public Sub refreshCheckData()
        Dim indateCTR As Integer = 0
        Dim nearExpiryCTR As Integer = 0
        Dim expiredCTR As Integer = 0

        Dim instockCTR As Integer = 0
        Dim lowstockCTR As Integer = 0
        Dim outofstockCTR As Integer = 0

        indateCheckCount(indateCTR)
        nearExpiryCheckCount(nearExpiryCTR)
        expiredCheckCount(expiredCTR)

        stockLevelCheck(instockCTR)
        lowstockCheck(lowstockCTR)
        outofstockCheck(outofstockCTR)
    End Sub

    ' In-Date Items Count
    Public Sub indateCheckCount(ByRef indateCTR As Integer)
        indateCTR = 0 ' Reset the counter
        Dim conn As MySqlConnection
        conn = New MySqlConnection("server=localhost; userid=root; password=@Mar2022108194; database=inventoryms")
        Dim reader As MySqlDataReader
        Try
            conn.Open()
            Dim Query1 As String
            ' Select all items that have expiration date and are not expired and is not near expiry
            Query1 = "SELECT COUNT(*) FROM inventoryms.itemlist WHERE ITEM_EXPIRATION > CURDATE() AND ITEM_EXPIRATION > DATE_ADD(CURDATE(), INTERVAL 1 MONTH)"
            COMMAND = New MySqlCommand(Query1, conn)
            reader = COMMAND.ExecuteReader
            If reader.Read Then
                indateCTR = reader.GetInt32(0)
                indateBTN.Text = "IN-DATE: " & indateCTR
            End If
        Catch ex As Exception
            MessageBox.Show("Error connecting to database: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    ' Near-Expiry Items Count
    Public Sub nearExpiryCheckCount(ByRef nearExpiryCTR As Integer)
        nearExpiryCTR = 0 ' Reset the counter
        Dim conn As MySqlConnection
        conn = New MySqlConnection("server=localhost; userid=root; password=@Mar2022108194; database=inventoryms")
        Dim reader As MySqlDataReader
        Try
            conn.Open()
            Dim Query2 As String
            Query2 = "SELECT COUNT(*) FROM inventoryms.itemlist WHERE ITEM_EXPIRATION BETWEEN CURDATE() AND DATE_ADD(CURDATE(), INTERVAL 1 MONTH)"
            COMMAND = New MySqlCommand(Query2, conn)
            reader = COMMAND.ExecuteReader
            If reader.Read Then
                nearExpiryCTR = reader.GetInt32(0)
                nearBTN.Text = "NEAR-EXPIRY: " & nearExpiryCTR
            End If
        Catch ex As Exception
            MessageBox.Show("Error connecting to database: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    ' Expired Items Count
    Public Sub expiredCheckCount(ByRef expiredCTR As Integer)
        expiredCTR = 0 ' Reset the counter
        Dim conn As MySqlConnection
        conn = New MySqlConnection("server=localhost; userid=root; password=@Mar2022108194; database=inventoryms")
        Dim reader As MySqlDataReader
        Try
            conn.Open()
            Dim Query3 As String
            Query3 = "SELECT COUNT(*) FROM inventoryms.itemlist WHERE ITEM_EXPIRATION < CURDATE()"
            COMMAND = New MySqlCommand(Query3, conn)
            reader = COMMAND.ExecuteReader
            If reader.Read Then
                expiredCTR = reader.GetInt32(0)
                expiredBTN.Text = "EXPIRED: " & expiredCTR
            End If
        Catch ex As Exception
            MessageBox.Show("Error connecting to database: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    ' Check Stock Level that is greater than 0
    Public Sub stockLevelCheck(ByRef instockCTR As Integer)
        Dim conn As MySqlConnection
        conn = New MySqlConnection("server=localhost; userid=root; password=@Mar2022108194; database=inventoryms")
        Dim reader As MySqlDataReader
        Try
            conn.Open()
            Dim Query4 As String
            Query4 = "SELECT COUNT(*) FROM inventoryms.itemlist WHERE ITEM_QUANTITY > 10"
            COMMAND = New MySqlCommand(Query4, conn)
            reader = COMMAND.ExecuteReader
            If reader.Read Then
                instockCTR = reader.GetInt32(0)
                instock.Text = "IN-STOCK: " & instockCTR
            End If
        Catch ex As Exception
            MessageBox.Show("Error connecting to database: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Public Sub lowstockCheck(ByRef lowstockCTR As Integer)
        Dim conn As MySqlConnection
        conn = New MySqlConnection("server=localhost; userid=root; password=@Mar2022108194; database=inventoryms")
        Dim reader As MySqlDataReader
        Try
            conn.Open()
            Dim Query5 As String
            Query5 = "SELECT COUNT(*) FROM inventoryms.itemlist WHERE ITEM_QUANTITY <= 10"
            COMMAND = New MySqlCommand(Query5, conn)
            reader = COMMAND.ExecuteReader
            If reader.Read Then
                lowstockCTR = reader.GetInt32(0)
                lowstock.Text = "LOW STOCK: " & lowstockCTR
            End If
        Catch ex As Exception
            MessageBox.Show("Error connecting to database: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Public Sub outofstockCheck(ByRef outofstockCTR As Integer)
        Dim conn As MySqlConnection
        conn = New MySqlConnection("server=localhost; userid=root; password=@Mar2022108194; database=inventoryms")
        Dim reader As MySqlDataReader
        Try
            conn.Open()
            Dim Query6 As String
            Query6 = "SELECT COUNT(*) FROM inventoryms.itemlist WHERE ITEM_QUANTITY = 0"
            COMMAND = New MySqlCommand(Query6, conn)
            reader = COMMAND.ExecuteReader
            If reader.Read Then
                outofstockCTR = reader.GetInt32(0)
                outofstock.Text = "OUT OF STOCK: " & outofstockCTR
            End If
        Catch ex As Exception
            MessageBox.Show("Error connecting to database: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub




    Public Sub LoadData(ByVal dataGrid As DataGridView)
        conn = New MySqlConnection
        conn.ConnectionString = "server=localhost; userid=root; password=@Mar2022108194; database=inventoryms"
        Dim bSource As New BindingSource
        Try
            conn.Open()
            Dim Query As String
            Query = "SELECT * FROM inventoryms.itemlist"
            COMMAND = New MySqlCommand(Query, conn)
            SDA.SelectCommand = COMMAND
            SDA.Fill(dbDataSet)
            bSource.DataSource = dbDataSet
            dataGrid.DataSource = bSource ' Use the passed DataGridView instead of dashboardDATAGRID
            SDA.Update(dbDataSet)
            conn.Close()
        Catch ex As Exception
            MessageBox.Show("Error connecting to database: " & ex.Message)
        Finally
            conn.Dispose()
        End Try
    End Sub

    Public Sub RefreshData()
        dashboardDATAGRID.DataSource = Nothing ' Clear the DataGridView

        ' Clear the existing data in the DataTable
        dbDataSet.Clear()

        Try
            conn = New MySqlConnection
            conn.ConnectionString = "server=localhost; userid=root; password=@Mar2022108194; database=inventoryms"
            Dim Query As String
            Query = "SELECT * FROM inventoryms.itemlist"
            COMMAND = New MySqlCommand(Query, conn)
            SDA.SelectCommand = COMMAND
            SDA.Fill(dbDataSet)
            dashboardDATAGRID.DataSource = dbDataSet
        Catch ex As Exception
            MessageBox.Show("Error connecting to database: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub refreshBTN_Click(sender As Object, e As EventArgs) Handles refreshBTN.Click
        RefreshData()
    End Sub




    Private Sub searchBOX1_TextChanged(sender As Object, e As EventArgs) Handles searchBOX1.TextChanged
        If searchBOX1.Text = "" Then
            LoadData(dashboardDATAGRID)
            RefreshData()
            refreshCheckData()

        End If
    End Sub

    Private Sub searchBTN1_Click(sender As Object, e As EventArgs) Handles searchBTN1.Click
        Dim conn As MySqlConnection
        conn = New MySqlConnection("server=localhost; userid=root; password=@Mar2022108194; database=inventoryms")

        Try
            conn.Open()
            Dim Query1 As String

            If filterINPUT1.Text = "ID" Then
                Query1 = "SELECT * FROM inventoryms.itemlist WHERE ITEM_ID = @searchNum"
            ElseIf filterINPUT1.Text = "Name" Then
                Query1 = "SELECT * FROM inventoryms.itemlist WHERE ITEM_NAME LIKE @searchText"
            ElseIf filterINPUT1.Text = "Category" Then
                Query1 = "SELECT * FROM inventoryms.itemlist WHERE ITEM_CATEGORY LIKE @searchText"
            ElseIf filterINPUT1.Text = "Brand" Then
                Query1 = "SELECT * FROM inventoryms.itemlist WHERE ITEM_BRAND LIKE @searchText"
            ElseIf filterINPUT1.Text = "Description" Then
                Query1 = "SELECT * FROM inventoryms.itemlist WHERE ITEM_DESCRIPTION LIKE @searchText"
            ElseIf filterINPUT1.Text = "Quantity" Then
                Query1 = "SELECT * FROM inventoryms.itemlist WHERE ITEM_QUANTITY = @searchNum"
            ElseIf filterINPUT1.Text = "Price" Then
                Query1 = "SELECT * FROM inventoryms.itemlist WHERE ITEM_PRICE = @searchNum"
            End If

            Dim COMMAND As New MySqlCommand(Query1, conn)

            'for Texts
            COMMAND.Parameters.AddWithValue("@searchText", "%" & searchBOX1.Text & "%")
            'for numbers
            COMMAND.Parameters.AddWithValue("@searchNum", searchBOX1.Text)

            Dim SDA As New MySqlDataAdapter
            Dim dbDataSet As New DataTable
            Dim bSource As New BindingSource

            SDA.SelectCommand = COMMAND
            SDA.Fill(dbDataSet)
            bSource.DataSource = dbDataSet
            dashboardDATAGRID.DataSource = bSource
            SDA.Update(dbDataSet)

            conn.Close()
        Catch ex As Exception
            MessageBox.Show("Error connecting to database: " & ex.Message)
        Finally
            conn.Close()
        End Try

    End Sub

    Private Sub LOGOUT_Click(sender As Object, e As EventArgs) Handles LOGOUT.Click
        Me.Hide()
        Login.Show()
    End Sub

    Private Sub aboutPOP_Click(sender As Object, e As EventArgs) Handles aboutPOP.Click
        'About Pop Up Message
        MessageBox.Show("Inventory Management System" & vbCrLf & "Version 1.0" & vbCrLf & "Developed by: raf5000" &
                        vbCrLf & "All Rights Reserved 2024", "About", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
End Class