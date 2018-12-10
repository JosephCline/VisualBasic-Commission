Module Module1

    Sub Main()
        ' The disk file name for this lab problem is K:\Conti\Cis 125\Data\Testlab3vb.dat
        Dim iCount As Integer
        Dim sEmployeename As String
        Dim dSalesamount As Decimal
        Dim dComission As Decimal
        Dim dTotal As Decimal

        iCount = 0
        Console.Write("Please enter your name")
        sEmployeename = Console.ReadLine
        Console.Write("Please enter your sales amount for the period")
        dSalesamount = Console.Readline

        While dSalesamount <> -9
            If dSalesamount >= 1000 Then
                dRate = 0.04
                iCount = iCount + 1

            ElseIf dSalesamount >= 600 Then
                dRate = 0.03
            ElseIf dSalesamount >= 300 Then
                dRate = 0.02
            Else
                dRate = 0.01
            End If
            dCommission = dSalesamount * dRate
            Console.Write("Comission earned for " & sEmployeename & "is " & FormatCurrency(dCommission))
            dTotal = Console.Readline
        End While
        Console.Write("Total number of employees that earned a 4% commissiom is" & iCount)
        Console.ReadKey()
    End Sub

End Module
