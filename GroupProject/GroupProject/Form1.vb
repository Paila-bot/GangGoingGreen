' *****************************************************************
' Team Number: 31
' Team Member 1 Details: Singo, F (221045717)
' Team Member 2 Details: Ramaili, AM (221000696)
' Team Member 3 Details: Mashimpye, AU (218105656)
' Team Member 4 Details: Mapfuwa, P (221105301)
' Practical: Team Project
' Class name: 
' *****************************************************************

Option Strict On
Option Explicit On
Option Infer Off
Public Class frmggg
    Private Industries_Factories() As Factories_Industries
    Private Causes() As Cause
    Private nIF, nCauses As Integer

    Private Sub Cause()
        nCauses = CInt(InputBox("Please enter the number of causes that lead to deforestation."))
        ReDim Causes(nCauses)

        For c As Integer = 1 To nCauses
            Dim cName As String = InputBox("What is the name of the cause?")
            Dim cDescription As String = InputBox("Describe the cause.")
            Dim cPercentage As Double = CDbl(InputBox("How many percentage does this cause contribute to defforestation?"))
            Causes(c) = New Cause(cName, cDescription, cPercentage)
            Causes(c).Name = cName
            Causes(c).Description = cDescription
            Causes(c).Percentage = cPercentage
        Next c
    End Sub


    Private Sub btncapture_Click(sender As Object, e As EventArgs) Handles btncapture.Click
        nIF += 1
        ReDim Preserve Industries_Factories(nIF)

        'Local variables
        Dim opt As Integer = CInt(InputBox("Select the main environmental destruction activity that the company poses on our environments:" & Environment.NewLine & "1. Defforestation" & Environment.NewLine & "2. Green House Gases Emissions " & Environment.NewLine & "3. Water Pollution"))
        Dim Name As String = InputBox("What is the name of the factory/Industry?")
        Dim Description As String = InputBox("What does the " & Name & " factory/Industry produce?")
        Dim Profit As Double = CDbl(InputBox("How much profit does " & Name & " make in a year?"))


        Select Case opt
            Case 1
                Dim LandCleared As Double = CDbl(InputBox("What is the size of the area that was originally occupied by trees Cleared?"))
                Dim nTreesCut As Integer = CInt(InputBox("How many trees in the area were cut?"))
                Dim nCauses As Integer


                Dim Defforestation As Defforestation = New Defforestation(nCauses, Name, Description, Profit, LandCleared, nTreesCut)

                Defforestation.Name = Name
                Defforestation.Description = Description
                Defforestation.Profit = Profit

                Dim numVolunteers As Integer = CInt(InputBox("How many people volunteered to replant trees?"))
                Dim numTreesPlanted As Integer = CInt(InputBox("How many trees were planted?"))
                Dim LandUsed As Double = CDbl(InputBox("What is the area of the land that the trees were planted at?"))
                Dim afforestation As Afforestation = New Afforestation(numVolunteers, numTreesPlanted, LandUsed)
                Cause()
                Industries_Factories(nIF) = Defforestation

            Case 2


                Dim num As Integer = CInt(InputBox("Please enter the number of decades that the green house gas emissions were tracked."))

                Dim objGHG As Greenhousegases = New Greenhousegases(nCauses, Name, Description, Profit, num)

                For d As Integer = 1 To num
                    objGHG.CarbonDioxide(d) = CDbl(InputBox("What were the Carbon Dioxide emissions by the factory/industry " & Name & " in  decade " & d & "?" & "(Please enter your response as a percentage)"))
                    objGHG.Methane(d) = CDbl(InputBox("What were the Methan emissions by the factory/industry " & Name & " in  decade " & d & "?" & "(Please enter your response as a percentage)"))
                    objGHG.NitrousOxide(d) = CDbl(InputBox("What were the Nitrous Oxide emissions by the factory/industry " & Name & " in  decade " & d & "?" & "(Please enter your response as a percentage)"))
                Next d
                Cause()
                Industries_Factories(nIF) = objGHG

            Case 3
                Dim Concentration As Double = CDbl(InputBox("What is the concentration of pollutants in the water body?"))
                Dim areasize As Double = CDbl(InputBox("What is the size of the water body?"))
                Dim waterpollution As WaterPollution = New WaterPollution(nCauses, Name, Description, Profit, areasize, Concentration)
                Dim Population As Integer = CInt(InputBox("What is the size of the marine population in the polluted water body?"))
                Dim NumberOfDead As Integer = CInt(InputBox("What is the number of marine life that died in the water body as a result of water pollution?"))
                Dim bio As BioDiversity = New BioDiversity(Population, NumberOfDead)
                Cause()
                Industries_Factories(nIF) = waterpollution
        End Select
    End Sub

  'Display information
    Private Sub btndisplay_Click(sender As Object, e As EventArgs) Handles btndisplay.Click
        For i As Integer = 1 To nIF
            txtdisplay.Text &= Industries_Factories(i).Display & Environment.NewLine
        Next
    End Sub

    'Save Objects to files
    Private Sub btnsavetofile_Click(sender As Object, e As EventArgs) Handles btnsavetofile.Click
        FS = New FileStream(File, FileMode.Create, FileAccess.Write)
        BF = New binaryformatter()

        For i As Integer = 1 To nIF
            BF.serialize(FS, Industries_Factories(i))
        Next i
        FS.Close()
        MsgBox("All objects saved")
    End Sub
End Class
