Module Module1

    Sub Main()
        Dim Plaintext, CipherText As String
        Dim CCkey As Integer
        Dim VCKey As String
        Console.Write("Enter text to be encrypted: ")
        Plaintext = Console.ReadLine
        Console.Write("Enter shift Key: ")
        CCkey = Console.ReadLine
        For i = 0 To Plaintext.Length - 1
            Dim curChar = Plaintext(i)
            Dim charValue = Asc(curChar)
            'If charValue = 32 Then 'Spaces only
            '    CipherText &= " "
            If charValue < Asc("A") Or charValue > Asc("Z") Then
                CipherText &= curChar
            Else
                Dim newCharValue = charValue + CCkey
                If newCharValue > Asc("Z") Then
                    newCharValue -= 26
                End If
                Dim newChar = Chr(newCharValue)
                CipherText &= newChar
            End If


        Next
        Console.WriteLine(CipherText)

    End Sub

End Module
