Module Module1

    Sub Main()
        Dim k As UInteger ' Количество прочитанных чтраниц в день
        Dim n As UInteger ' Количество оставшихся не прочитанных страниц
        Console.Write("Сколько страниц будете читать в день? ")
        UInteger.TryParse(Console.ReadLine(), k)
        Console.Write("Сколько страниц осталось прочитать? ")
        UInteger.TryParse(Console.ReadLine(), n)
        Dim d = n \ k + n Mod k ' Количество дней, на которое хватит книги
        ' Вывод на экран
        Console.WriteLine($"Этой книги вам хватит ещё на {d} дня(ей).")
        Console.Read() ' Нажать клавишу "Enter" для закрытия окна
    End Sub

End Module
