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

Public Class Greenhousegases
    Inherits Factories_Industries
    Private _CarbonDioxide_Emission() As Double 'per decade
    Private _Methane_Emission() As Double
    Private _NitrousOxide_Emission() As Double
    Private _NumDecades As Integer

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

    Public Property NumDecades As Integer
        Get
            Return _NumDecades
        End Get
        Set(value As Integer)
            _NumDecades = value
        End Set
    End Property

    Public Sub New(nFactors As Integer, Name As String, Description As String, Profit As Double, num As Integer)
        MyBase.New(nFactors, Name, Description, Profit)
        NumDecades = num
        ReDim _CarbonDioxide_Emission(num)
        ReDim _Methane_Emission(num)
        ReDim _NitrousOxide_Emission(num)
    End Sub

    Private Function AverageEmission_CO2() As Double
        Dim CO2 As Double
        For d As Integer = 1 To NumDecades
            CO2 += CarbonDioxide(d)
        Next
        Return CO2 / NumDecades
    End Function

    Private Function AverageEmission_NH() As Double
        Dim NH As Double
        For d As Integer = 1 To NumDecades
            NH += Methane(d)
        Next
        Return NH / NumDecades
    End Function

    Private Function AverageEmission_NO() As Double

        Dim No As Double
        For d As Integer = 1 To NumDecades
            No += NitrousOxide(d)
        Next
        Return No / NumDecades
    End Function

    Private Function DetermineTrend_CO2() As Boolean
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

    Private Function Status_CO2() As String
        If (DetermineTrend_CO2() = True) Then
            Return "Air pollution caused by Carbon dioxide is at a constant rate " & ".. ?" 'What's the worse that could happen
        Else
            Return "Air pollution caused by Carbon dioxide is not increasing at a constant rate " & "..?" 'What's the best that could happen
        End If
    End Function

    Private Function DetermineTrend_NH() As Boolean
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

    Private Function Status_NH() As String
        If (DetermineTrend_NH() = True) Then
            Return "Air pollution caused by Methane is at a constant rate " & ".. ?" 'What's the worse that could happen
        Else
            Return "Air pollution caused by Methane is not increasing at a constant rate " & "..?" 'What's the best that could happen
        End If
    End Function

    Private Function DetermineTrend_NO() As Boolean
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

    Private Function Status_NO() As String
        If (DetermineTrend_NO() = True) Then
            Return "Air pollution caused by NitrousOxide is at a constant rate " & ".. ?" 'What's the worse that could happen
        Else
            Return "Air pollution caused by NitrousOxide is not increasing at a constant rate " & "..?" 'What's the best that could happen
        End If
    End Function

    'Gas that contributes the most
    Public Function DetermineWorseGas() As String
        If AverageEmission_CO2() > AverageEmission_NH() And AverageEmission_CO2() > AverageEmission_NO() Then
            Return "Carbon dioxide is the worse because it release more gas over " & NumDecades
        End If
        If AverageEmission_NH() > AverageEmission_CO2() And AverageEmission_NH() > AverageEmission_NO() Then
            Return "Methane is the worse because it release more gas over " & NumDecades
        End If
        If AverageEmission_NO() > AverageEmission_CO2() And AverageEmission_NO() > AverageEmission_NH() Then
            Return "Nitrous Oxide is the worse because it release more gas over " & NumDecades
        End If
    End Function


    'Determine Charges based on Average Carbon Footprint and Whether or not it's increasing
    Public Overrides Function Charges() As Double
        Return ((AverageEmission_CO2() + AverageEmission_NH() + AverageEmission_NO()) / 300) * 1000
    End Function

    'Determine Worse decade for each gas
Public overrides Function Display() As String
        Dim text As String = ""
        text = "Average Emission for Carbon Dioxide: " & CStr(AverageEmission_CO2()) & Environment.NewLine
        text &= "Status for Carbon Dioxide: " & Status_CO2() & Environment.NewLine
        text &= "Average Emission for Methane: " & CStr(AverageEmission_NH()) & Environment.NewLine
        text &= "Status for Carbon Methane: " & Status_NH() & Environment.NewLine
        text &= "Average Emission for NitrousOxide: " & CStr(AverageEmission_NO()) & Environment.NewLine
        text &= "Status for NitrousOxide: " & Status_NO() & Environment.NewLine
        text &= "The worse gas is: " & DetermineWorseGas() & Environment.NewLine
        Return text
    End Function

    'Don't forget to display charges
End Class
