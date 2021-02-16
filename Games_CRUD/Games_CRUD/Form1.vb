Imports System.Data.SqlClient

Public Class Form1
    'connect to server'
    Dim connection As New SqlConnection("Data Source=localhost\SQLEXPRESS;Initial Catalog=GamesDB;Integrated Security=True")

    'What happens when the add button is clicked'
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        'Declaring variables'
        Dim id As Integer = txtGameID.Text
        Dim name As String = txtName.Text
        Dim genre As String = comboGenre.Text
        Dim ageRestriction As Integer = comboAge.Text
        Dim year As Integer = comboYear.Text

        'open connection'
        connection.Open()

        'Query'
        Dim command As New SqlCommand("Insert into Game_Setup_Tab values('" & id & "', '" & name & "',
                                                                         '" & genre & "', '" & ageRestriction & "',
                                                                         '" & year & "')", connection)

        'Executes Query'
        command.ExecuteNonQuery()


        'close connection'
        connection.Close()

        'Success Message'
        MessageBox.Show("Game Added")

        'update data grid'
        LoadDataInGrid()
    End Sub

    'Show Database information in the data grid'
    Private Sub LoadDataInGrid()
        Dim command As New SqlCommand("select * from Game_Setup_Tab", connection)
        Dim sda As New SqlDataAdapter(command)
        Dim dt As New DataTable
        sda.Fill(dt)
        gamesDataGrid.DataSource = dt
    End Sub

    'populating grid view on load'
    Private Sub Form1_Load_1(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadDataInGrid()
        gamesDataGrid.ForeColor = Color.Black
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        'Declaring variables'
        Dim id As Integer = txtGameID.Text
        Dim name As String = txtName.Text
        Dim genre As String = comboGenre.Text
        Dim ageRestriction As Integer = comboAge.Text
        Dim year As Integer = comboYear.Text

        'open connection'
        connection.Open()

        'Query'
        Dim command As New SqlCommand("update Game_Setup_Tab set Name ='" & name & "',
                                                                         Genre = '" & genre & "', Agerestriction ='" & ageRestriction & "',
                                                                         YearOfRelease = '" & year & "' where Game_ID ='" & id & "'", connection)

        'Executes Query'
        command.ExecuteNonQuery()


        'close connection'
        connection.Close()

        'Success Message'
        MessageBox.Show("Game Edited")

        'update data grid'
        LoadDataInGrid()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click

        If MessageBox.Show("Are you sure you want to delete?", "Delete item", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            'Declaring variables'
            Dim id As Integer = txtGameID.Text

            'open connection'
            connection.Open()

            'Query'
            Dim command As New SqlCommand("delete Game_Setup_Tab where Game_ID ='" & id & "'", connection)

            'Executes Query'
            command.ExecuteNonQuery()

            'close connection'
            connection.Close()

            'Success Message'
            MessageBox.Show("Game Deleted")
        End If
        'update data grid'
        LoadDataInGrid()
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        'Declaring variables'
        Dim id As Integer = txtGameID.Text

        Dim command As New SqlCommand("select * from Game_Setup_Tab where Game_ID = '" & id & "'", connection)
        Dim sda As New SqlDataAdapter(command)
        Dim dt As New DataTable
        sda.Fill(dt)
        gamesDataGrid.DataSource = dt
    End Sub
End Class
