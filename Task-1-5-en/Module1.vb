Module Module1

    Sub Main()
        Dim k As UInteger ' Quantity of pages to read per day
        Dim n As UInteger ' Quantity of pages remain to read
        Console.Write("How many pages will you read per day? ")
        UInteger.TryParse(Console.ReadLine(), k)
        Console.Write("How many pages remain to read? ")
        UInteger.TryParse(Console.ReadLine(), n)
        Dim d = n \ k + n Mod k ' Number Of days the book will last
        ' Print to screen
        Console.WriteLine($"This book will last you another {d} days.")
        Console.Read() ' Press key "Enter" to close window
    End Sub

End Module
