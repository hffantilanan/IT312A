Imports MySql.Data.MySqlClient
Module modVariables
    'Database Connection
    Public conn As MySqlConnection
    Public strCmd As MySqlCommand
    Public READER As MySqlDataReader
    Public da As MySqlDataAdapter
    Public dr As DataRow


    'Strings
    Public strDatabaseName As String
    Public strServer As String
    Public strUser As String
    Public strPass As String
End Module
