Public Class Form1
    Dim rectWidth As Integer
    Dim rectLength As Integer
    Dim rectArea As Integer
    Dim rectPerimeter As Integer
    Dim cirArea As Single
    Dim cirPerimiter As Single
    Dim cirRadius As Single
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        If optRectangle.Checked = True Then
            rectWidth = txtRectWidth.Text
            rectLength = txtRectLength.Text
            rectPerimeter = fnRecPerimeter(rectWidth, rectLength)
            rectArea = fnRecArea(rectWidth, rectLength)
            lstOutput.Items.Add("Rectangle")
            lstOutput.Items.Add("Perimeter: " & rectPerimeter)
            lstOutput.Items.Add("Area: " & rectArea)
        End If
        If optCircle.Checked = True Then
            cirRadius = txtCirRadius.Text
            cirPerimiter = fnCirclePerimeter(cirRadius)
            cirArea = fnCircleArea(cirRadius)
            lstOutput.Items.Add("Circle")
            lstOutput.Items.Add("Perimeter: " & cirPerimiter)
            lstOutput.Items.Add("Area: " & cirArea)
        End If
    End Sub
    Private Function fnRecPerimeter(rectWidth As Integer, rectLength As Integer) As Integer
        Return 2 * (rectWidth + rectLength)
    End Function
    Private Function fnRecArea(rectWidth As Integer, rectLength As Integer) As Integer
        Return rectLength * rectWidth
    End Function
    Private Function fnCirclePerimeter(cirRadius As Single) As Single
        Return 2 * System.Math.PI * cirRadius
    End Function
    Private Function fnCircleArea(cirRadius As Single) As Single
        Return System.Math.PI * cirRadius * cirRadius
    End Function
    Private Sub optRectangle_CheckedChanged(sender As Object, e As EventArgs) Handles optRectangle.CheckedChanged
        If optRectangle.Checked = True Then
            grpRectangle.Visible = True
            grpCircle.Visible = False
        End If
    End Sub
    Private Sub optCircle_CheckedChanged(sender As Object, e As EventArgs) Handles optCircle.CheckedChanged
        If optCircle.Checked = True Then
            grpRectangle.Visible = False
            grpCircle.Visible = True
        End If
    End Sub
End Class