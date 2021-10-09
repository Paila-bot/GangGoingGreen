' *****************************************************************
' Team Number: 31
' Team Member 1 Details: Singo, F (221045717)
' Team Member 2 Details: Ramaili, AM (221000696)
' Team Member 3 Details: Mashimpye, AU (218105656)
' Team Member 4 Details: Mapfuwa, P (221105301)
' Practical: Team Project
' Class name: (Cause)
' *****************************************************************

'Option statements
Option Strict On
Option Explicit On
Option Infer Off

'A composition of the base class
Public Class Cause
    Private _Name As String
    Private _Description As String
    Private _Percentage As Double

    'Property methods
    Public Property Name As String
        Get
            Return _Name
        End Get
        Set(value As String)
            _Name = value
        End Set
    End Property

    Public Property Description As String
        Get
            Return _Description
        End Get
        Set(value As String)
            _Description = value
        End Set
    End Property

    Public Property Percentage As Double
        Get
            Return _Percentage
        End Get
        Set(value As Double)
            If _Percentage < 0 Then
                _Percentage = 0
            Else
                _Percentage = value
            End If

        End Set
    End Property

    'Constructor
    Public Sub New(n As String, d As String, p As Double)
        Description = d
        Percentage = p
        Name = n
    End Sub


End Class
