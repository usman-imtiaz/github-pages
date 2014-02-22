Imports System
Imports System.Data
Imports System.Data.OleDb


Public Class Main

    Dim connection As OleDbConnection
    Dim connectionString As String
    Dim command As OleDbCommand
    Dim ds As New DataSet

    Private Shared Function getConnectionString() As String
        Return "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" _
            & "C:\Users\uzi\Desktop\school\cmpt-399\dataMartProject\dataMart\datamart.accdb"
    End Function

    Private Sub fillData(ByVal i As Integer)

        Try
            connection.Open()
            Dim queryString As String = ""
            Select Case i
                Case 1
                    queryString = "select distinct yearT from timetbl" + " order by yearT asc"
                    Dim da As OleDbDataAdapter = New OleDbDataAdapter(queryString, connection)

                    ds.Clear()
                    da.Fill(ds, "yearT")
                    command = connection.CreateCommand
                    command.CommandText = queryString

                    For x As Integer = 0 To ds.Tables("yearT").Rows.Count - 1
                        yearCombo.Items.Add(ds.Tables("yearT").Rows(x).Item(0))
                    Next
                Case 2
                    queryString = "select distinct country from locationtbl" + " order by country asc"
                    Dim da As OleDbDataAdapter = New OleDbDataAdapter(queryString, connection)

                    ds.Clear()
                    da.Fill(ds, "country")

                    command = connection.CreateCommand
                    command.CommandText = queryString

                    For x As Integer = 0 To ds.Tables("country").Rows.Count - 1
                        countryCombo.Items.Add(ds.Tables("country").Rows(x).Item(0))
                    Next
                Case 3
                    queryString = "select distinct branchtype from branchtbl" + " order by branchtype asc"
                    Dim da As OleDbDataAdapter = New OleDbDataAdapter(queryString, connection)

                    ds.Clear()
                    da.Fill(ds, "branchT")

                    command = connection.CreateCommand
                    command.CommandText = queryString

                    For x As Integer = 0 To ds.Tables("branchT").Rows.Count - 1
                        branchTypeCombo.Items.Add(ds.Tables("branchT").Rows(x).Item(0))
                    Next
                Case 4
                    'will have to coincide with year. depends with year
                    queryString = "select distinct itemtype from itemtbl" + " order by itemtype asc"
                    Dim da As OleDbDataAdapter = New OleDbDataAdapter(queryString, connection)

                    ds.Clear()
                    da.Fill(ds, "itemT")

                    command = connection.CreateCommand
                    command.CommandText = queryString

                    For x As Integer = 0 To ds.Tables("itemT").Rows.Count - 1
                        itemTypeCombo.Items.Add(ds.Tables("itemT").Rows(x).Item(0))
                    Next
            End Select
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        connection.Close()
    End Sub


    Private Sub Main_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        connectionString = getConnectionString()
        connection = New OleDbConnection(connectionString)

        fillData(1)
        fillData(2)
        fillData(3)
        fillData(4)
    End Sub

    Private Sub yearCombo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles yearCombo.SelectedIndexChanged
        connectionString = getConnectionString()
        connection = New OleDbConnection(connectionString)
        quarterCombo.Items.Clear()
        quarterCombo.Text = "Quarter"
        Try
            connection.Open()
            Dim queryString As String = ""
            queryString = "select distinct quarterT from timetbl where timetbl.yearT = " _
                            + yearCombo.Text + " order by quarterT asc"
            Dim da As OleDbDataAdapter = New OleDbDataAdapter(queryString, connection)

            ds.Clear()
            da.Fill(ds, "quarterT")
            '  resulttxtbox.Text = ""

            command = connection.CreateCommand
            command.CommandText = queryString

            For x As Integer = 0 To ds.Tables("quarterT").Rows.Count - 1
                quarterCombo.Items.Add(ds.Tables("quarterT").Rows(x).Item(0))
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        connection.Close()
    End Sub


    Private Sub countryCombo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles countryCombo.SelectedIndexChanged
        connectionString = getConnectionString()
        connection = New OleDbConnection(connectionString)
        provinceCombo.Items.Clear()
        provinceCombo.Text = "Province"
        Try
            connection.Open()
            Dim queryString As String = ""

            queryString = "select distinct province from locationtbl where locationtbl.country = '" _
                            + countryCombo.Text + "'" + " order by province asc"

            Dim da As OleDbDataAdapter = New OleDbDataAdapter(queryString, connection)

            ds.Clear()
            da.Fill(ds, "province")

            command = connection.CreateCommand
            command.CommandText = queryString

            For x As Integer = 0 To ds.Tables("province").Rows.Count - 1
                provinceCombo.Items.Add(ds.Tables("province").Rows(x).Item(0))
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        connection.Close()
    End Sub

    Private Sub ClearList()
        'Clear the list
        listBox1.Items.Clear()
        listBox2.Items.Clear()
        listBox3.Items.Clear()
        'branchTypeCombo.Text = "Branch Type"
        'countryCombo.Text = "Country"
        'yearCombo.Text = "Year"
        'itemTypeCombo.Text = "Type"

    End Sub

    Private Sub clearButton_Click(sender As Object, e As EventArgs) Handles clearButton.Click
        ClearList()
    End Sub

    Private Sub quarterCombo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles quarterCombo.SelectedIndexChanged
        connectionString = getConnectionString()
        connection = New OleDbConnection(connectionString)
        monthCombo.Items.Clear()
        monthCombo.Text = "Month"
        Try
            connection.Open()
            Dim queryString As String = ""

            queryString = "select distinct monthT from timetbl where timetbl.quarterT = " + quarterCombo.Text _
                            + "and timetbl.yearT = " + yearCombo.Text

            Dim da As OleDbDataAdapter = New OleDbDataAdapter(queryString, connection)

            ds.Clear()
            da.Fill(ds, "monthT")

            command = connection.CreateCommand
            command.CommandText = queryString

            For x As Integer = 0 To ds.Tables("monthT").Rows.Count - 1
                monthCombo.Items.Add(ds.Tables("monthT").Rows(x).Item(0))
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        connection.Close()
    End Sub

    Private Sub provinceCombo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles provinceCombo.SelectedIndexChanged
        connectionString = getConnectionString()
        connection = New OleDbConnection(connectionString)
        cityCombo.Items.Clear()
        cityCombo.Text = "City"
        Try
            connection.Open()
            Dim queryString As String = ""

            queryString = "select distinct city from locationtbl where locationtbl.province = '" _
                        + provinceCombo.Text + "'and locationtbl.country = '" + countryCombo.Text + "'" _
                        + " order by city asc"

            Dim da As OleDbDataAdapter = New OleDbDataAdapter(queryString, connection)

            ds.Clear()
            da.Fill(ds, "city")

            command = connection.CreateCommand
            command.CommandText = queryString

            For x As Integer = 0 To ds.Tables("city").Rows.Count - 1
                cityCombo.Items.Add(ds.Tables("city").Rows(x).Item(0))
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        connection.Close()
    End Sub


    Private Sub branchTypeCombo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles branchTypeCombo.SelectedIndexChanged
        connectionString = getConnectionString()
        connection = New OleDbConnection(connectionString)
        branchNameCombo.Items.Clear()
        branchNameCombo.Text = "Branch Name"
        Try
            connection.Open()
            Dim queryString As String = ""

            queryString = "select distinct branchname from branchtbl where branchtbl.branchtype = '" _
                        + branchTypeCombo.Text + "'" + " order by branchname asc"

            Dim da As OleDbDataAdapter = New OleDbDataAdapter(queryString, connection)

            ds.Clear()
            da.Fill(ds, "branchname")

            command = connection.CreateCommand
            command.CommandText = queryString

            For x As Integer = 0 To ds.Tables("branchname").Rows.Count - 1
                branchNameCombo.Items.Add(ds.Tables("branchname").Rows(x).Item(0))
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        connection.Close()
    End Sub

    Private Sub itemTypeCombo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles itemTypeCombo.SelectedIndexChanged
        connectionString = getConnectionString()
        connection = New OleDbConnection(connectionString)
        itemBrandCombo.Items.Clear()
        itemBrandCombo.Text = "Item Brand"
        Try
            connection.Open()
            Dim queryString As String = ""

            queryString = "select distinct itembrand from itemtbl where itemtbl.itemtype = '" _
                        + itemTypeCombo.Text + "'" + " order by itembrand asc"

            Dim da As OleDbDataAdapter = New OleDbDataAdapter(queryString, connection)

            ds.Clear()
            da.Fill(ds, "itemB")

            command = connection.CreateCommand
            command.CommandText = queryString

            For x As Integer = 0 To ds.Tables("itemB").Rows.Count - 1
                itemBrandCombo.Items.Add(ds.Tables("itemB").Rows(x).Item(0))
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        connection.Close()
    End Sub

    Private Sub itemBrandCombo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles itemBrandCombo.SelectedIndexChanged
        connectionString = getConnectionString()
        connection = New OleDbConnection(connectionString)
        itemNameCombo.Items.Clear()
        itemNameCombo.Text = "Item Name"
        Try
            connection.Open()
            Dim queryString As String = ""

            queryString = "select distinct itemname from itemtbl where itemtbl.itembrand = '" _
                        + itemBrandCombo.Text + "'" + " order by itemname asc"

            Dim da As OleDbDataAdapter = New OleDbDataAdapter(queryString, connection)

            ds.Clear()
            da.Fill(ds, "itemN")

            command = connection.CreateCommand
            command.CommandText = queryString

            For x As Integer = 0 To ds.Tables("itemN").Rows.Count - 1
                itemNameCombo.Items.Add(ds.Tables("itemN").Rows(x).Item(0))
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        connection.Close()
    End Sub

    Public Function whichCategory() As String
        Dim supportBox As String = ""
        If yearCombo.SelectedIndex <> -1 Then
            supportBox += ", timetbl"
        End If
        If itemTypeCombo.SelectedIndex <> -1 Then
            supportBox += ", itemtbl"
        End If
        If branchTypeCombo.SelectedIndex <> -1 Then
            supportBox += ", branchtbl"
        End If
        If countryCombo.SelectedIndex <> -1 Then
            supportBox += ", locationtbl"
        End If

        Return supportBox
    End Function

    Private Sub calculateButton_Click(sender As Object, e As EventArgs) Handles calculateButton.Click
        connectionString = getConnectionString()
        connection = New OleDbConnection(connectionString)
        ClearList()

        Dim queryString As String = ""

        Try
            connection.Open()
            queryString = "select unit_sold, dollar, average_sale from facttbl"
            queryString += whichCategory()
            If yearCombo.SelectedIndex <> -1 Then
                queryString += " where facttbl.time_id = timetbl.time_id and timetbl.yearT = " + yearCombo.Text
                If quarterCombo.SelectedIndex <> -1 Then
                    queryString += " and timetbl.quarterT = " + quarterCombo.Text + ""
                    If monthCombo.SelectedIndex <> -1 Then
                        queryString += " and timetbl.monthT = '" + monthCombo.Text + "'"
                    End If
                End If

                If itemTypeCombo.SelectedIndex <> -1 Then
                    queryString += " and facttbl.item_id = itemtbl.item_id " _
                        + "and itemtbl.itemtype = '" + itemTypeCombo.Text + "'"
                    If itemBrandCombo.SelectedIndex <> -1 Then
                        queryString += " and itemtbl.itembrand = '" + itemBrandCombo.Text + "'"
                        If itemNameCombo.SelectedIndex <> -1 Then
                            queryString += " and itemtbl.itemname = '" + itemNameCombo.Text + "'"
                        End If
                    End If
                End If
                If branchTypeCombo.Text <> "Branch Type" Then
                    queryString += " and facttbl.branch_id = branchtbl.branch_id " _
                        + "and branchtbl.branchtype = '" + branchTypeCombo.Text + "'"
                    If branchNameCombo.Text <> "Branch Name" Then
                        queryString += " and branchtbl.branchname = '" + branchNameCombo.Text + "'"
                    End If
                End If
                If countryCombo.Text <> "Country" Then
                    queryString += " and facttbl.location_id = locationtbl.location_id " _
                        + "and locationtbl.country = '" + countryCombo.Text + "'"
                    If provinceCombo.Text <> "Province" Then
                        queryString += " and locationtbl.province = '" + provinceCombo.Text + "'"
                        If cityCombo.Text <> "City" Then
                            queryString += " and locationtbl.city = '" + cityCombo.Text + "'"
                        End If
                    End If
                End If
                queryString += " order by average_sale asc"


                Dim da As OleDbDataAdapter = New OleDbDataAdapter(queryString, connection)

                ds.Clear()
                da.Fill(ds, "calculate")

                command = connection.CreateCommand
                command.CommandText = queryString

                For x As Integer = 0 To ds.Tables("calculate").Rows.Count - 1
                    listBox1.Items.Add(ds.Tables("calculate").Rows(x).Item(0))
                    listBox2.Items.Add(ds.Tables("calculate").Rows(x).Item(1))
                    listBox3.Items.Add(ds.Tables("calculate").Rows(x).Item(2))
                Next
            Else
                MessageBox.Show("Selection too general: Please enter year parameter!", "Error")

            End If
            
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        connection.Close()
    End Sub

End Class
