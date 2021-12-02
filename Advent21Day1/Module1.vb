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
Function d2p2()
        Dim f As New StreamReader("day2.txt")
        Dim l As New List(Of String)
        Do
            l.Add(f.ReadLine())

        Loop Until f.EndOfStream

        Dim aim, depth, h As Integer
        aim = 0
        h = 0
        depth = 0
        For Each com In l
            Dim direction = com.Split((" "))
            Select Case direction(0)
                Case "forward"
                    h += direction(1)
                    depth += aim * direction(1)
                Case "down"
                    aim += direction(1)
                Case "up"
                    aim -= direction(1)
            End Select

        Next
        Return h * depth
End Module
