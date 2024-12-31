Option Strict On
Option Explicit On

Imports System.Runtime.CompilerServices

Public Module BinarySearch

    <Extension()>
    Public Sub SortAndInsert(Of T As {IComparable(Of T)})(list As IList(Of T), target As T)
        Dim lf As Integer = 0
        Dim rt As Integer = list.Count

        Do While lf < rt
            Dim mid = lf + (rt - lf) \ 2

            Dim cmp = list(mid).CompareTo(target)
            If cmp <= 0 Then
                lf = mid + 1
            Else
                rt = mid
            End If
        Loop

        list.Insert(lf, target)
    End Sub

    <Extension()>
    Public Function LowerEqualSearch(Of T As {IComparable(Of T)})(list As IList(Of T), target As T) As Integer
        Dim lf As Integer = -1
        Dim rt As Integer = list.Count

        Do While rt - lf > 1
            Dim mid = lf + (rt - lf) \ 2

            Dim cmp = list(mid).CompareTo(target)
            If cmp >= 0 Then
                rt = mid
            Else
                lf = mid
            End If
        Loop

        If rt > 0 OrElse list(rt).CompareTo(target) = 0 Then
            Return rt
        Else
            Return -1
        End If
    End Function

    <Extension()>
    Public Function UpperEqualSearch(Of T As {IComparable(Of T)})(list As IList(Of T), target As T) As Integer
        Dim lf As Integer = -1
        Dim rt As Integer = list.Count

        Do While rt - lf > 1
            Dim mid = lf + (rt - lf) \ 2

            Dim cmp = list(mid).CompareTo(target)
            If cmp <= 0 Then
                lf = mid
            Else
                rt = mid
            End If
        Loop


        If lf < list.Count - 1 OrElse list(lf).CompareTo(target) = 0 Then
            Return lf
        Else
            Return list.Count
        End If
    End Function

End Module
