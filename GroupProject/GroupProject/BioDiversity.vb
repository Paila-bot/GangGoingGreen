' *****************************************************************
' Team Number: 31
' Team Member 1 Details: Singo, F (221045717)
' Team Member 2 Details: Ramaili, AM (221000696)
' Team Member 3 Details: Mashimpye, AU (218105656)
' Team Member 4 Details: Mapfuwa, P (221105301)
' Practical: Team Project
' Class name: (BioDiversity)
' *****************************************************************

Option Strict On
Option Explicit On
Option Infer Off

Public Class BioDiversity
    Private _Population As Double
    Private _NumDead As Integer

    Public Property Population As Double
        Set(value As Double)
            _Population = value
        End Set
        Get
            Return _Population
        End Get
    End Property

    Public Property NumberOfDead As Integer
        Set(value As Integer)
            _NumDead = value
        End Set
        Get
            Return _NumDead
        End Get
    End Property

    Public Sub New(population As Integer, ndead As Integer)
        Me.Population = population
        NumberOfDead = ndead
    End Sub

    'Functions
    Public Function Mortality() As Double
        Return (_NumDead / _Population) * 100
    End Function
End Class
