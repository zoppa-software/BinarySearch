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
            Assert.Equal(-1, data.LeftSearch(-1))
            Assert.Equal(0, data.LeftSearch(0))
            Assert.Equal(4, data.LeftSearch(1))
            Assert.Equal(8, data.LeftSearch(2))
            Assert.Equal(14, data.LeftSearch(3))
            Assert.Equal(17, data.LeftSearch(4))
            Assert.Equal(20, data.LeftSearch(5))
            Assert.Equal(22, data.LeftSearch(6))
            Assert.Equal(24, data.LeftSearch(7))
            Assert.Equal(27, data.LeftSearch(8))
            Assert.Equal(28, data.LeftSearch(9))
            Assert.Equal(28, data.LeftSearch(10))
            Assert.Equal(32, data.LeftSearch(11))
        End Sub

        <Fact>
        Sub RightSearchTest()
            Dim data = {0, 0, 0, 0, 1, 1, 1, 1, 2, 2, 2, 2, 2, 2, 3, 3, 3, 4, 4, 4, 5, 5, 6, 6, 7, 7, 7, 8, 10, 10, 10, 10}
            Assert.Equal(-1, data.RightSearch(-1))
            Assert.Equal(3, data.RightSearch(0))
            Assert.Equal(7, data.RightSearch(1))
            Assert.Equal(13, data.RightSearch(2))
            Assert.Equal(16, data.RightSearch(3))
            Assert.Equal(19, data.RightSearch(4))
            Assert.Equal(21, data.RightSearch(5))
            Assert.Equal(23, data.RightSearch(6))
            Assert.Equal(26, data.RightSearch(7))
            Assert.Equal(27, data.RightSearch(8))
            Assert.Equal(27, data.RightSearch(9))
            Assert.Equal(31, data.RightSearch(10))
            Assert.Equal(32, data.RightSearch(11))
        End Sub

    End Class

End Namespace

