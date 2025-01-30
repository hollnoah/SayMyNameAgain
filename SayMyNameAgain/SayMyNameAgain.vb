Module SayMyNameAgain

    Sub Main()
        Console.WriteLine("What's your name?")
        Dim Name As String = Console.ReadLine()

        Select Case Name.ToLower()


            Case "emily"
                Console.WriteLine("Hey Emily! It's so good to see you!")

            Case "joe"
                Console.WriteLine("Joe Joe Joe... what brings you to my module?")

            Case "noah"
                Console.WriteLine("Hey Noah! How's that ark coming along?")

            Case Else
                Console.WriteLine("You're not special enough for a custom greeting, sorry not sorry")
        End Select
    End Sub

End Module
