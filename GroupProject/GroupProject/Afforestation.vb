' *****************************************************************
' Team Number: 31
' Team Member 1 Details: Singo, F (221045717)
' Team Member 2 Details: Ramaili, AM (221000696)
' Team Member 3 Details: Mashimpye, AU (218105656)
' Team Member 4 Details: Mapfuwa, P (221105301)
' Practical: Team Project
' Class name: (Afforestation)
' *****************************************************************

Option Strict On
Option Explicit On
Option Infer Off
Public Class Afforestation
    Private _numVolunteers As Integer
    Private _numTreesPlanted As Integer
    Private _LandUsed As Double


    Public Property numVolunteers As Integer
        Get
            Return _numVolunteers
        End Get
        Set(value As Integer)
            _numVolunteers = value
        End Set
    End Property

    Public Property numTreesPlanted As Integer
        Get
            Return _numTreesPlanted
        End Get
        Set(value As Integer)
            _numTreesPlanted = value
        End Set
    End Property

    Public Property LandUsed As Double
        Get
            Return _LandUsed
        End Get
        Set(value As Double)
            _LandUsed = value
        End Set
    End Property

    Public Sub New(nV As Integer, ntp As Integer, landused As Double)
        numVolunteers = nV
        numTreesPlanted = ntp
        Me.LandUsed = landused
    End Sub

    'Methods
    Public Function Rating() As String
        Dim Rate As String = " "
        If numTreesPlanted <= 0 And numTreesPlanted < 15 Then
            Rate = "Thank you"
        ElseIf numTreesPlanted >= 15 And numTreesPlanted < 50 Then
            Rate = "Appreciated"
        Else
            Rate = "Highly Appreciated"
        End If
        Return Rate
    End Function
End Class
