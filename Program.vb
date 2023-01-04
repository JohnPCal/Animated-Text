Imports System

Module Animated_Text
    Dim str_phrase As String = "The quick brown fox jumps over the lazy dog"
    Sub Main()
        Console.WriteLine("**String Functions**" & vbCrLf)
        Console.WriteLine("Phrase = " & str_phrase)
        Console.WriteLine("First letter = " & str_phrase(0))
        Console.WriteLine("Number of letters = " & str_phrase.Length)
        Console.WriteLine("Last letter = " & str_phrase.Length - 1)
        Console.WriteLine("Upper case = " & str_phrase.ToUpper)
        Console.WriteLine("Lower case = " & str_phrase.ToLower)
        Console.WriteLine(" o's replaces with '*' = " & str_phrase.Replace("o", "*"))
        Console.WriteLine("Character 7-15 = " & str_phrase.Substring(7))
        Console.WriteLine("Backwards = " & StrReverse(str_phrase))
        Console.WriteLine("Position of fox = " & InStr(str_phrase, "fox")) 'displays number position
        Console.WriteLine(vbCrLf)

        Console.WriteLine("Loop through all words")
        For count1 = 0 To str_phrase.Length - 1
            If count1 = 0 Then
                Console.ForegroundColor = ConsoleColor.Yellow
            ElseIf count1 = 4 Then
                Console.ForegroundColor = ConsoleColor.Red
            ElseIf count1 = 10 Then
                Console.ForegroundColor = ConsoleColor.Green
            ElseIf count1 = 16 Then
                Console.ForegroundColor = ConsoleColor.Cyan
            ElseIf count1 = 20 Then
                Console.ForegroundColor = ConsoleColor.Magenta
            ElseIf count1 = 26 Then
                Console.ForegroundColor = ConsoleColor.Blue
            ElseIf count1 = 31 Then
                Console.ForegroundColor = ConsoleColor.White
            ElseIf count1 = 35 Then
                Console.ForegroundColor = ConsoleColor.DarkCyan
            ElseIf count1 = 40 Then
                Console.ForegroundColor = ConsoleColor.DarkRed
            End If
            Console.Write(str_phrase(count1))
        Next
        'John Calverley
    End Sub

End Module
