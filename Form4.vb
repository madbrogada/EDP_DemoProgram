﻿Imports MySql.Data.MySqlClient

Public Class Form4
    Public Sub InsertRow(myConnectionString As String)
        'If myConnectionString = "" Then
        'myConnectionString = "Database=simulation;Data Source=localhost;User Id=edpadmin;Password=mike"
        'End If
        Dim myConnection As New MySqlConnection(myConnectionString)
        Dim myInsertQuery As String = "INSERT INTO department (dnumber, dname) Values('7', 'Computer Networks')"
        Dim myCommand As New MySqlCommand(myInsertQuery)
        MsgBox(myInsertQuery)
        myCommand.Connection = myConnection
        myConnection.Open()
        myCommand.ExecuteNonQuery()
        myCommand.Connection.Close()
    End Sub
    Private Sub BtnRunSamplecode_Click(sender As Object, e As EventArgs) Handles BtnRunSamplecode.Click
        Call InsertRow("Database=simulation;Data Source=localhost;User Id=edpadmin;Password=mike")
    End Sub
End Class