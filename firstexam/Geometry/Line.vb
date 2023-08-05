

Namespace Geometry

    Public Class Line
        Public Property StartPoint As Point
        Public Property EndPoint As Point

        Public Sub New(ByVal startPoint As Point, ByVal endPoint As Point)
            Me.StartPoint = startPoint
            Me.EndPoint = endPoint
        End Sub
    End Class
End Namespace