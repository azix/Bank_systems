Module Customer_module
    Public NumberOfAccount As Integer

    Structure CustomerType
        Dim AccountName As String
        Dim AccountType As String
        Dim Withdraw As Integer
        Dim deposit As Integer
        Dim Overdraft As Boolean

    End Structure

    Public Bank(19) As CustomerType
End Module
