'Morgan Puckett
'RCET0265
'Spring 2022
'Roll the dice, list box
'

Public Class MP_RollTheDice_ListBox

    Private Sub MP_RollTheDice_ListBox_Load(sender As Object, e As EventArgs) Handles Me.Load
        DrawColumns()
        RollDice()
        Console.ReadLine()
    End Sub

    'These varibles allow for easy changes to all code
    Dim line As String
    Dim columnUBound As Integer = 1
    Dim Bound As Integer = 5
    Dim lineLength As Integer = 12
    Dim test As String

    'Draws title and options of roll
    Sub DrawColumns()
        line = ""

        For i = 1 To columnUBound

            If i = 1 Then
                DisplayListBox.Items.Add("Roll The Dice".PadLeft(35))
            End If
            DisplayListBox.Items.Add((StrDup((56), "-")))

            For j = 2 To lineLength

                line += Str(j).PadLeft(5)
                Console.Write(line)

            Next
            DisplayListBox.Items.Add(line)
            Console.WriteLine(line)
            line = ""
        Next
        'Divider
        DisplayListBox.Items.Add((StrDup((56), "-")))
    End Sub

    'draws and creates random numbers to be placed in array 
    Dim arrayLength As Integer = 12
    Sub RollDice()
        Dim rndNumbers(arrayLength) As Integer
        Dim currentNumber As Integer

        For i = 1 To 1000
            currentNumber = RandomNumberInRange(12, 2)
            rndNumbers(currentNumber) += 1
        Next

        For j = 2 To UBound(rndNumbers)

            test += CStr(rndNumbers(j)).PadLeft(5)
            Console.Write(test)

        Next
        DisplayListBox.Items.Add(test)
        Console.WriteLine(test)
        test = ""
    End Sub

    'Creates random numbers 
    Function RandomNumberInRange(Optional max% = 10%, Optional min% = 0%) As Integer
        Dim _max% = max - min
        If _max < 0 Then
            Throw New System.ArgumentException("Maximum number must be greater than minimum number")
        End If
        Randomize(DateTime.Now.Millisecond)
        Return CInt(System.Math.Floor(Rnd() * (_max + 1))) + min
    End Function

End Class
