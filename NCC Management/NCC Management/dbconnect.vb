Imports System.Data
Imports System.Data.OleDb

Module dbconnect
    Public OleCon_DB As New OleDbConnection
    Public CommmonDataAdapter As New OleDbDataAdapter
    Public CommonCommand As New OleDbCommand
    Public CommonDataSet As New DataSet
    Public AdCon_DB As New ADODB.Connection
    Dim rstitem As New ADODB.Recordset
    Dim strTemp As String
    Dim strDatabase As String
    Dim mAppPath As String
    Public Sub Connect_DB()
        Try

            mAppPath = System.Reflection.Assembly.GetExecutingAssembly.Location
            'MsgBox(My.Application.Info.DirectoryPath)
            OleCon_DB = New OleDbConnection("provider=MicroSoft.jet.OLEDDB.4.0;" & "Data Source = " & My.Application.Info.DirectoryPath & "\data\NCC1.mdb;Jet OLEDB:Database Password=lkv123adm;persist Security Info=true")
            'MsgBox(My.Application.Info.DirectoryPath)
            AdCon_DB.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source= " & My.Application.Info.DirectoryPath & "\data\NCC1.mdb;Jet OLEDB:Database Password=lkv123adm;persist Security Info=true"
            AdCon_DB.Open()

           
            CommonCommand.Connection = OleCon_DB
            Dim dbProvider As String
            Dim dbSource As String

            dbProvider = "PROVIDER=Microsoft.Jet.OLEDB.4.0;"
            'MsgBox(My.Application.Info.DirectoryPath)
            dbSource = "Data Source = " & My.Application.Info.DirectoryPath & "\data\NCC1.mdb;Jet OLEDB:Database Password=lkv123adm;persist Security Info=true"
            OleCon_DB.ConnectionString = dbProvider & dbSource
            OleCon_DB.Open() 
        Catch ex As Exception
            MsgBox(ex.Message)
            LoginForm1.Close()
        End Try

    End Sub

End Module
