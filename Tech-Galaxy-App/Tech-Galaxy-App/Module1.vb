Imports System.Data.OleDb
Module Module1
    Public con As OleDbConnection = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\db_techgalaxy.accdb")
    Public StoreDate As String
End Module
