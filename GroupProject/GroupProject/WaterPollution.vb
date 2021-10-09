' *****************************************************************
' Team Number: 31
' Team Member 1 Details: Singo, F (221045717)
' Team Member 2 Details: Ramaili, AM (221000696)
' Team Member 3 Details: Mashimpye, AU (218105656)
' Team Member 4 Details: Mapfuwa, P (221105301)
' Practical: Team Project
' Class name: (WaterPollution)
' *****************************************************************

'Option statements
Option Strict On
Option Explicit On
Option Infer Off

'Derived class
Public Class WaterPollution

    Inherits Factories_Industries

    Private _Bio As BioDiversity
    Private _SizeOfArea, _Concentration As Double

    'Property methods
    Public Property Bio As BioDiversity
        Set(value As BioDiversity)
            _Bio = value
        End Set
        Get
            Return _Bio
        End Get
    End Property

    Public Property Size As Double
        Set(value As Double)
            _SizeOfArea = value
        End Set
        Get
            Return _SizeOfArea
        End Get
    End Property

    Public Property Concentration As Double
        Set(value As Double)
            _Concentration = value
        End Set
        Get
            Return _Concentration
        End Get
    End Property

    'Constructor
    Public Sub New(nFactors As Integer, Name As String, Description As String, Profit As Double, sizeofarea As Double, concentration As Double)
        MyBase.New(nFactors, Name, Description, Profit)
        _SizeOfArea = sizeofarea
        _Concentration = concentration
    End Sub

    'Methods
    'Function to calculate Pollution level based on the concentration of pollution *  by size of polluted area
    Public Function PollutionLevel() As Double
        Return (_SizeOfArea * _Concentration)
    End Function

    'Overrided function to Calculate Charges based on Pollution level * size of polluted area
    Public Overrides Function Charges() As Double
        Return (_SizeOfArea * PollutionLevel())
    End Function
    
    'Function to display details of the Waterpollution class
    Public Overrides Function Display() As String
        Dim disp As String = " "
        disp &= "Waterpollution: " &  MyBase.Display & Environment.Newline
        disp &= "Pollution Level: " & PollutionLevel() & Environment.Newline
        disp &= "Charges: " & Charges() & Environment.Newline
        return disp
    End function
End Class


