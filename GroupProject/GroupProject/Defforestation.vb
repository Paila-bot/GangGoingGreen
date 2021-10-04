' *****************************************************************
' Team Number: 31
' Team Member 1 Details: Singo, F (221045717)
' Team Member 2 Details: Ramaili, AM (221000696)
' Team Member 3 Details: Mashimpye, AU (218105656)
' Team Member 4 Details: Mapfuwa, P (221105301)
' Practical: Team Project
' Class name: (Defforestation)
' *****************************************************************

Option Strict On
Option Explicit On
Option Infer Off
Public Class Defforestation

    Inherits Factories_Industries

    Private _Afforestation As Afforestation
    Private _nTreesCut As Integer
    Private _LandCleared As Double

    'Properties
    Public Property Afforestation As Afforestation
        Get
            Return _Afforestation
        End Get
        Set(value As Afforestation)
            _Afforestation = value
        End Set
    End Property

    Public Property nTreesCut As Integer
        Get
            Return _nTreesCut
        End Get
        Set(value As Integer)

        End Set
    End Property

    Private Property LandCleared As Double
        Get
            Return _LandCleared
        End Get
        Set(value As Double)
            _LandCleared = value
        End Set
    End Property

    Public Sub New(nFactors As Integer, Name As String, Description As String, Profit As Double, LandCleared As Double, ntreescut As Integer)
        MyBase.New(nFactors, Name, Description, Profit)
        Me.LandCleared = LandCleared
        Me.nTreesCut = ntreescut
    End Sub

    'Methods
    'Overriden

    Public Overrides Function Charges() As Double
        Return (LandCleared / nTreesCut) * 1000
    End Function

    Public Function AverageLandUsed() As Double
        Return (LandCleared + nTreesCut) / 2
    End Function
End Class
