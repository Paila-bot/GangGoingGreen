' *****************************************************************
' Team Number: 31
' Team Member 1 Details: Singo, F (221045717)
' Team Member 2 Details: Ramaili, AM (221000696)
' Team Member 3 Details: Mashimpye, AU (218105656)
' Team Member 4 Details: Mapfuwa, P (221105301)
' Practical: Team Project
' Class name: (Greenhousegases)
' *****************************************************************

Option Strict On
Option Explicit On
Option Infer Off

<Serializable> Public Class Greenhousegases
    Inherits Factories_Industries

#Region "Variables"
    Private _CarbonDioxide_Emission() As Double 'per decade
    Private _Methane_Emission() As Double
    Private _NitrousOxide_Emission() As Double
    Private _OtherGases_Emission() As Double
    Private _NumDecades As Integer
#End Region

#Region "Property Methods"
    Public Property CarbonDioxide(index As Integer) As Double
        Get
            Return _CarbonDioxide_Emission(index)
        End Get
        Set(value As Double)
            _CarbonDioxide_Emission(index) = value
        End Set
    End Property

    Public Property Methane(index As Integer) As Double
        Get
            Return _Methane_Emission(index)
        End Get
        Set(value As Double)
            _Methane_Emission(index) = value
        End Set
    End Property

    Public Property NitrousOxide(index As Integer) As Double
        Get
            Return _NitrousOxide_Emission(index)
        End Get
        Set(value As Double)
            _NitrousOxide_Emission(index) = value
        End Set
    End Property

    Public Property OtherGases(index As Integer) As Double
        Get
            Return _OtherGases_Emission(index)
        End Get
        Set(value As Double)
            _OtherGases_Emission(index) = value
        End Set
    End Property

    Public Property NumDecades As Integer
        Get
            Return _NumDecades
        End Get
        Set(value As Integer)
            _NumDecades = value
        End Set
    End Property
#End Region

#Region "Constructor"
    Public Sub New(nFactors As Integer, Name As String, Description As String, Profit As Double, num As Integer)
        MyBase.New(nFactors, Name, Description, Profit)
        NumDecades = num
        ReDim _CarbonDioxide_Emission(num)
        ReDim _Methane_Emission(num)
        ReDim _NitrousOxide_Emission(num)
        ReDim _OtherGases_Emission(num)
    End Sub

#End Region

#Region "Methods"
    Public Function AverageCO2() As Double
        Dim CO2 As Double
        For d As Integer = 1 To NumDecades
            CO2 += CarbonDioxide(d)
        Next
        Return CO2 / NumDecades
    End Function

    Public Function AverageMethane() As Double
        Dim NH As Double
        For d As Integer = 1 To NumDecades
            NH += Methane(d)
        Next
        Return NH / NumDecades
    End Function

    Public Function AverageNO() As Double

        Dim No As Double
        For d As Integer = 1 To NumDecades
            No += NitrousOxide(d)
        Next
        Return No / NumDecades
    End Function

    Public Function AverageOtherGases() As Double
        Dim Othergases As Double
        For d As Integer = 1 To NumDecades
            Othergases += CarbonDioxide(d)
        Next
        Return Othergases / NumDecades
    End Function

    Public Function Trend_CO2() As Boolean
        Dim inc As Boolean = True
        Dim count As Integer = 1


        While count <= NumDecades And inc = True
            If CarbonDioxide(count) < CarbonDioxide(count + 1) Then
                count += 1
                inc = True
            Else
                inc = False
            End If
        End While
        Return inc
    End Function

    Public Function trend_Methane() As Boolean
        Dim inc As Boolean = True
        Dim count As Integer = 1


        While count <= NumDecades And inc = True
            If Methane(count) < Methane(count + 1) Then
                count += 1
                inc = True
            Else
                inc = False
            End If
        End While
        Return inc
    End Function

    Public Function trend_NO() As Boolean
        Dim inc As Boolean = True
        Dim count As Integer = 1

        While count <= NumDecades And inc = True
            If NitrousOxide(count) < NitrousOxide(count + 1) Then
                count += 1
                inc = True
            Else
                inc = False
            End If
        End While
        Return inc
    End Function


    Public Function trend_Othergases() As Boolean
        Dim inc As Boolean = True
        Dim count As Integer = 1


        While count <= NumDecades And inc = True
            If OtherGases(count) < OtherGases(count + 1) Then
                count += 1
                inc = True
            Else
                inc = False
            End If
        End While
        Return inc

    End Function


    'Determine the Gas that contributes the most to global warning
    Public Function WorseGas() As String
        If AverageCO2() > AverageMethane() And AverageCO2() > AverageNO() Then
            Return "Carbon dioxide is the worse because it released more gas over " & NumDecades

        ElseIf AverageMethane() > AverageCO2() And AverageMethane() > AverageNO() Then
            Return "Methane is the worse because it released more gas over " & NumDecades

        ElseIf AverageNO() > AverageCO2() And AverageNO() > AverageMethane() Then
            Return "Nitrous Oxide is the worse because it released more gas over " & NumDecades
        Else
            Return "Othergases released more gas over " & NumDecades
        End If
    End Function

    'Determine the status based on Carbon Footprint trends
    Public Function Status() As String
        If (Trend_CO2() = True) Then
            Return "Air pollution caused by Carbon dioxide and Methane is increasing at a constant rate. This will cause Extreme weather, food supply disruptions, and increase wildfires."
        Else
            Return "Air pollution caused by Carbon dioxide and Methane is not increasing at a constant rate. This is good for the environment"
        End If
    End Function

    'Determine Charges based on whether or not the emission  is increasing
    Public Overrides Function Charges() As Double
        Dim Charge As Double
        If Trend_CO2() = True Then
            Charge += 50000
        End If
        If trend_Methane() = True Then
            Charge += 400000
        End If
        If trend_NO() = True Then
            Charge += 300000
        End If
        If trend_Othergases() = True Then
            Charge += 100000
        End If
        Return (Charge / 400) * 1000
    End Function

    'Display information
    Public Overrides Function Display() As String
        Dim text As String = ""
        text = MyBase.Display
        text &= "Average Emission for Carbon Dioxide: " & CStr(AverageCO2()) & Environment.NewLine
        text &= "Average Emission for Methane: " & CStr(AverageMethane()) & Environment.NewLine
        text &= "Average Emission for NitrousOxide: " & CStr(AverageNO()) & Environment.NewLine
        text &= "Average Emission for othergases: " & CStr(AverageOtherGases()) & Environment.NewLine
        text &= "Status: " & Status() & Environment.NewLine
        text &= "The worse gas is: " & WorseGas() & Environment.NewLine
        text &= "Charges: " & Charges() & Environment.NewLine
        Return text
    End Function

#End Region
End Class

