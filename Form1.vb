Public Class Form1
    Dim rectWidth As Integer
    Dim rectLength As Integer
    Dim rectArea As Integer
    Dim rectPerimeter As Integer
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        rectWidth = txtRectWidth.Text
        rectLength = txtRectLength.Text
        rectPerimeter = fnRecPerimeter(rectWidth, rectLength)
        rectArea = fnRecArea(rectWidth, rectLength)
        lstOutput.Items.Add("Rectangle")
        lstOutput.Items.Add("Perimeter: " & rectPerimeter)
        lstOutput.Items.Add("Area: " & rectArea)

    End Sub
    Private Function fnRecPerimeter(rectWidth As Integer, rectLength As Integer) As Integer
        Return 2 * (rectWidth + rectLength)
    End Function
    Private Function fnRecArea(rectWidth As Integer, rectLength As Integer) As Integer
        Return rectLength * rectWidth
    End Function
End Class