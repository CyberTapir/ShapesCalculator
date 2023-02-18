Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        grpCircle.Visible = False
        grpRectangle.Visible = False
        grpTrapezium.Visible = False
    End Sub
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        If optRectangle.Checked = True Then
            subRectangles()
        End If

        If optCircle.Checked = True Then
            subCircles()
        End If

        If optTrapezium.Checked = True Then
            subTrapeziums()
        End If
    End Sub
    Private Sub subRectangles()
        Dim rectWidth As Integer
        Dim rectLength As Integer
        Dim rectArea As Integer
        Dim rectPerimeter As Integer

        rectWidth = txtRectWidth.Text
        rectLength = txtRectLength.Text
        rectPerimeter = fnRecPerimeter(rectWidth, rectLength)
        rectArea = fnRecArea(rectWidth, rectLength)

        lstOutput.Items.Add("Rectangle")
        lstOutput.Items.Add("Perimeter: " & rectPerimeter)
        lstOutput.Items.Add("Area: " & rectArea)
    End Sub
    Private Sub subCircles()
        Dim cirArea As Single
        Dim cirPerimiter As Single
        Dim cirRadius As Single

        cirRadius = txtCirRadius.Text
        cirPerimiter = fnCirclePerimeter(cirRadius)
        cirArea = fnCircleArea(cirRadius)

        lstOutput.Items.Add("Circle")
        lstOutput.Items.Add("Perimeter: " & cirPerimiter)
        lstOutput.Items.Add("Area: " & cirArea)
    End Sub
    Private Sub subTrapeziums()
        Dim tpzHeight As Integer
        Dim tpzSide1 As Integer
        Dim tpzSide2 As Integer
        Dim tpzArea As Integer

        tpzHeight = txtTpzHeight.Text
        tpzSide1 = txtTpzSide1.Text
        tpzSide2 = txtTpzSide2.Text
        tpzArea = fnTrapeziumArea(tpzHeight, tpzSide1, tpzSide2)

        lstOutput.Items.Add("Trapezium")
        lstOutput.Items.Add("Area: " & tpzArea)
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
    Private Function fnTrapeziumArea(height As Integer, side1 As Integer, side2 As Integer) As Integer
        Return (height / 2) * (side1 + side2)
    End Function
    Private Sub optRectangle_CheckedChanged(sender As Object, e As EventArgs) Handles optRectangle.CheckedChanged
        grpCircle.Visible = False
        grpRectangle.Visible = True
        grpTrapezium.Visible = False
    End Sub
    Private Sub optCircle_CheckedChanged(sender As Object, e As EventArgs) Handles optCircle.CheckedChanged
        grpCircle.Visible = True
        grpRectangle.Visible = False
        grpTrapezium.Visible = False
    End Sub
    Private Sub optTrapezium_CheckedChanged(sender As Object, e As EventArgs) Handles optTrapezium.CheckedChanged
        grpTrapezium.Visible = True
        grpCircle.Visible = False
        grpRectangle.Visible = False
    End Sub
End Class