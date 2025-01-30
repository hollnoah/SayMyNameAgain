Module SayMyNameAgain

    Sub Main()
        Console.WriteLine("What's your name?") 'displays whats your name to user
        Dim Name As String = Console.ReadLine() 'reads anything typed by the user as a name

        Select Case Name.ToLower() 'allows for lower case lettering

            'if any of the following cases are detetced, it will choose from the following
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
