Module modFunctions
    'Set Validity
    Public Sub SetExpirationDate()
        intYear = Format(Date.Now, "yyyy") + 3
        strDate = intYear & "-" & Format(Date.Now, "MM-dd")
    End Sub
End Module
