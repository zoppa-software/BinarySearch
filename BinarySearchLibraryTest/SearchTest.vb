Imports System
Imports Xunit

Imports BinarySearchLibrary

Namespace BinarySearchLibraryTest
    Public Class SearchTest

        <Fact>
        Sub InsertTest()
            Dim inputs = {3, 6, 4, 2, 2, 7, 2, 4, 8, 7, 1, 2, 8, 9, 7, 6, 1, 10, 8, 1, 5, 10, 7, 1, 2, 1, 4, 3, 6, 8}
            Dim outputs As New List(Of Integer)()
            For Each v In inputs
                outputs.SortAndInsert(v)
            Next

            For i As Integer = 0 To outputs.Count - 2
                Assert.True(outputs(i) <= outputs(i + 1))
            Next
        End Sub

        <Fact>
        Sub LeftSearchTest()
            Dim data = {0, 0, 0, 0, 1, 1, 1, 1, 2, 2, 2, 2, 2, 2, 3, 3, 3, 4, 4, 4, 5, 5, 6, 6, 7, 7, 7, 8, 10, 10, 10, 10}
            Assert.Equal(-1, data.LowerEqualSearch(-1))
            Assert.Equal(0, data.LowerEqualSearch(0))
            Assert.Equal(4, data.LowerEqualSearch(1))
            Assert.Equal(8, data.LowerEqualSearch(2))
            Assert.Equal(14, data.LowerEqualSearch(3))
            Assert.Equal(17, data.LowerEqualSearch(4))
            Assert.Equal(20, data.LowerEqualSearch(5))
            Assert.Equal(22, data.LowerEqualSearch(6))
            Assert.Equal(24, data.LowerEqualSearch(7))
            Assert.Equal(27, data.LowerEqualSearch(8))
            Assert.Equal(28, data.LowerEqualSearch(9))
            Assert.Equal(28, data.LowerEqualSearch(10))
            Assert.Equal(32, data.LowerEqualSearch(11))
        End Sub

        <Fact>
        Sub RightSearchTest()
            Dim data = {0, 0, 0, 0, 1, 1, 1, 1, 2, 2, 2, 2, 2, 2, 3, 3, 3, 4, 4, 4, 5, 5, 6, 6, 7, 7, 7, 8, 10, 10, 10, 10}
            Assert.Equal(-1, data.UpperEqualSearch(-1))
            Assert.Equal(3, data.UpperEqualSearch(0))
            Assert.Equal(7, data.UpperEqualSearch(1))
            Assert.Equal(13, data.UpperEqualSearch(2))
            Assert.Equal(16, data.UpperEqualSearch(3))
            Assert.Equal(19, data.UpperEqualSearch(4))
            Assert.Equal(21, data.UpperEqualSearch(5))
            Assert.Equal(23, data.UpperEqualSearch(6))
            Assert.Equal(26, data.UpperEqualSearch(7))
            Assert.Equal(27, data.UpperEqualSearch(8))
            Assert.Equal(27, data.UpperEqualSearch(9))
            Assert.Equal(31, data.UpperEqualSearch(10))
            Assert.Equal(32, data.UpperEqualSearch(11))
        End Sub

    End Class

End Namespace

