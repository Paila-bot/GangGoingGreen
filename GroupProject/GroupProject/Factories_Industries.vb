' *****************************************************************
' Team Number: 31
' Team Member 1 Details: Singo, F (221045717)
' Team Member 2 Details: Ramaili, AM (221000696)
' Team Member 3 Details: Mashimpye, AU (218105656)
' Team Member 4 Details: Mapfuwa, P (221105301)
' Practical: Team Project
' Class name: (Factories_Industries)
' *****************************************************************

Option Strict On
Option Explicit On
Option Infer Off
'Base Class
Public MustInherit Class Factories_Industries
    Private _Name As String
    Private _Description As String
    Private _Profit As Double
    Private _Cause() As Cause
    Private Shared _PermitNo As Integer

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

    Public Property Profit As Double
        Get
            Return _Profit
        End Get
        Set(value As Double)
            _Profit = value
        End Set
    End Property

    Public Property Cause(Index As Integer) As Cause
        Get
            Return _Cause(Index)
        End Get
        Set(value As Cause)
            _Cause(Index) = value
        End Set
    End Property

    Public Shared Property PermitNo As Integer
        Get
            Return _PermitNo
        End Get
        Set(value As Integer)
            _PermitNo = value
        End Set
    End Property

    Public Sub New(nFactors As Integer, name As String, description As String, profit As Double)
        Me.Name = name
        Me.Description = description
        Me.Profit = profit
        ReDim _Cause(nFactors)
    End Sub

    Public MustOverride Function Charges() As Double

    Public Function WorstImpact() As String
        Dim worst As Double = Cause(1).Percentage
        Dim index As Integer = 1
        For n As Integer = 1 To _Cause.Length - 1
            If worst > Cause(n).Percentage Then
                worst = Cause(n).Percentage
                index = n
            End If
        Next n
        Return "The activity that causes more harm to the environment is " & Cause(index).Name & " and has a damage percentage of " & Cause(index).Percentage & " on the environment."
    End Function
    
    Public Overridable Function Display() As String
        Dim tex as string = " "
        tex &= "Company Name: " & Name  & Environment.Newline
        tex &= "Company Description: " & Description & Environment.Newline
        tex &= "Annual Profit: " & Profit & Environment.Newline
        Return tex
    End Function
End Class
