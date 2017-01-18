Imports MySql.Data.MySqlClient
Module modVariables
    'Database Connection
    Public conn As MySqlConnection
    Public strCmd As MySqlCommand
    Public READER As MySqlDataReader
    Public da As New MySqlDataAdapter
    Public dr As DataRow

    'Binding Source
    Public bSource As New BindingSource

    'Data Table
    Public dbDataSet As New DataTable

    'Queries
    Public strAddUserQuery As String
    Public strAddMembershipQuery As String

    'Strings
    Public strDatabaseName As String
    Public strServer As String
    Public strUser As String
    Public strPass As String
    Public strDate As String

    'Integer
    Public intYear As Integer
End Module
