Imports System.IO
Module Module1

    Sub Main()
        Console.WriteLine(D2P1)
    End Sub
    Function Day1P1()
        Dim f As New StreamReader("c:\advent\day1p1.txt")
        Dim prev As Integer = Integer.MaxValue
        Dim count = 0
        Dim newNum As Integer
        Do
            newNum = f.ReadLine
            If newNum > prev Then
                count += 1
            End If
            prev = newNum
        Loop Until f.EndOfStream
        Return count
    End Function
    Function Day1P2()
        Dim f As New StreamReader("c:\advent\day1p1.txt")
        Dim prev As Integer = Integer.MaxValue
        Dim count = 0
        Dim newNum As Integer
        Dim Scans As New List(Of Integer)

        Do
            Scans.Add(f.ReadLine)
        Loop Until f.EndOfStream

        For i = 0 To Scans.Count - 3
            Dim sum As Integer = 0
            For j = i To i + 2
                sum += Scans(j)
            Next
            If sum > prev Then
                count += 1
            End If
            prev = sum
        Next
        Return count
    End Function
    Function  d2p1()
        dim f as new StreamReader("C:\advent\day2p1.txt")
        dim l as new List(Of string)
        Do
            l.Add(f.ReadLine())
            
        Loop until f.EndOfStream
        dim depth,h as Integer
        depth = 0
        h = 0
        for each com in l
            dim direction = com.Split((" "))
            select case direction(0)
case "forward"
    h += direction(1)
    case "down"
        depth += direction(1)
        case "up"
            depth -= direction(1)
            End Select
        Next
        Return h*depth
        
    End Function
End Module
