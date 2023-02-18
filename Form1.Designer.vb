<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.txtRectLength = New System.Windows.Forms.TextBox()
        Me.txtRectWidth = New System.Windows.Forms.TextBox()
        Me.lblLength = New System.Windows.Forms.Label()
        Me.lblWidth = New System.Windows.Forms.Label()
        Me.lstOutput = New System.Windows.Forms.ListBox()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.lblCirRadius = New System.Windows.Forms.Label()
        Me.txtCirRadius = New System.Windows.Forms.TextBox()
        Me.optRectangle = New System.Windows.Forms.RadioButton()
        Me.optCircle = New System.Windows.Forms.RadioButton()
        Me.optTrapezium = New System.Windows.Forms.RadioButton()
        Me.grpShapeSelection = New System.Windows.Forms.GroupBox()
        Me.grpRectangle = New System.Windows.Forms.GroupBox()
        Me.grpCircle = New System.Windows.Forms.GroupBox()
        Me.grpTrapezium = New System.Windows.Forms.GroupBox()
        Me.lblTpzSide2 = New System.Windows.Forms.Label()
        Me.lblTpzSide1 = New System.Windows.Forms.Label()
        Me.lblTpzHeight = New System.Windows.Forms.Label()
        Me.txtTpzSide2 = New System.Windows.Forms.TextBox()
        Me.txtTpzSide1 = New System.Windows.Forms.TextBox()
        Me.txtTpzHeight = New System.Windows.Forms.TextBox()
        Me.grpShapeSelection.SuspendLayout()
        Me.grpRectangle.SuspendLayout()
        Me.grpCircle.SuspendLayout()
        Me.grpTrapezium.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtRectLength
        '
        Me.txtRectLength.Location = New System.Drawing.Point(69, 27)
        Me.txtRectLength.Name = "txtRectLength"
        Me.txtRectLength.Size = New System.Drawing.Size(100, 23)
        Me.txtRectLength.TabIndex = 0
        '
        'txtRectWidth
        '
        Me.txtRectWidth.Location = New System.Drawing.Point(69, 56)
        Me.txtRectWidth.Name = "txtRectWidth"
        Me.txtRectWidth.Size = New System.Drawing.Size(100, 23)
        Me.txtRectWidth.TabIndex = 1
        '
        'lblLength
        '
        Me.lblLength.AutoSize = True
        Me.lblLength.Location = New System.Drawing.Point(11, 30)
        Me.lblLength.Name = "lblLength"
        Me.lblLength.Size = New System.Drawing.Size(44, 15)
        Me.lblLength.TabIndex = 2
        Me.lblLength.Text = "Length"
        '
        'lblWidth
        '
        Me.lblWidth.AutoSize = True
        Me.lblWidth.Location = New System.Drawing.Point(11, 64)
        Me.lblWidth.Name = "lblWidth"
        Me.lblWidth.Size = New System.Drawing.Size(39, 15)
        Me.lblWidth.TabIndex = 3
        Me.lblWidth.Text = "Width"
        '
        'lstOutput
        '
        Me.lstOutput.FormattingEnabled = True
        Me.lstOutput.ItemHeight = 15
        Me.lstOutput.Location = New System.Drawing.Point(326, 51)
        Me.lstOutput.Name = "lstOutput"
        Me.lstOutput.Size = New System.Drawing.Size(208, 364)
        Me.lstOutput.TabIndex = 4
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(585, 215)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(75, 23)
        Me.btnCalculate.TabIndex = 5
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'lblCirRadius
        '
        Me.lblCirRadius.AutoSize = True
        Me.lblCirRadius.Location = New System.Drawing.Point(13, 46)
        Me.lblCirRadius.Name = "lblCirRadius"
        Me.lblCirRadius.Size = New System.Drawing.Size(42, 15)
        Me.lblCirRadius.TabIndex = 6
        Me.lblCirRadius.Text = "Radius"
        '
        'txtCirRadius
        '
        Me.txtCirRadius.Location = New System.Drawing.Point(69, 43)
        Me.txtCirRadius.Name = "txtCirRadius"
        Me.txtCirRadius.Size = New System.Drawing.Size(100, 23)
        Me.txtCirRadius.TabIndex = 7
        '
        'optRectangle
        '
        Me.optRectangle.AutoSize = True
        Me.optRectangle.Location = New System.Drawing.Point(13, 22)
        Me.optRectangle.Name = "optRectangle"
        Me.optRectangle.Size = New System.Drawing.Size(77, 19)
        Me.optRectangle.TabIndex = 8
        Me.optRectangle.TabStop = True
        Me.optRectangle.Text = "Rectangle"
        Me.optRectangle.UseVisualStyleBackColor = True
        '
        'optCircle
        '
        Me.optCircle.AutoSize = True
        Me.optCircle.Location = New System.Drawing.Point(13, 47)
        Me.optCircle.Name = "optCircle"
        Me.optCircle.Size = New System.Drawing.Size(55, 19)
        Me.optCircle.TabIndex = 9
        Me.optCircle.TabStop = True
        Me.optCircle.Text = "Circle"
        Me.optCircle.UseVisualStyleBackColor = True
        '
        'optTrapezium
        '
        Me.optTrapezium.AutoSize = True
        Me.optTrapezium.Location = New System.Drawing.Point(13, 72)
        Me.optTrapezium.Name = "optTrapezium"
        Me.optTrapezium.Size = New System.Drawing.Size(79, 19)
        Me.optTrapezium.TabIndex = 10
        Me.optTrapezium.TabStop = True
        Me.optTrapezium.Text = "Trapesium"
        Me.optTrapezium.UseVisualStyleBackColor = True
        '
        'grpShapeSelection
        '
        Me.grpShapeSelection.Controls.Add(Me.optTrapezium)
        Me.grpShapeSelection.Controls.Add(Me.optRectangle)
        Me.grpShapeSelection.Controls.Add(Me.optCircle)
        Me.grpShapeSelection.Location = New System.Drawing.Point(60, 29)
        Me.grpShapeSelection.Name = "grpShapeSelection"
        Me.grpShapeSelection.Size = New System.Drawing.Size(200, 100)
        Me.grpShapeSelection.TabIndex = 11
        Me.grpShapeSelection.TabStop = False
        Me.grpShapeSelection.Text = "Select a Shape"
        '
        'grpRectangle
        '
        Me.grpRectangle.Controls.Add(Me.txtRectLength)
        Me.grpRectangle.Controls.Add(Me.lblLength)
        Me.grpRectangle.Controls.Add(Me.txtRectWidth)
        Me.grpRectangle.Controls.Add(Me.lblWidth)
        Me.grpRectangle.Location = New System.Drawing.Point(60, 254)
        Me.grpRectangle.Name = "grpRectangle"
        Me.grpRectangle.Size = New System.Drawing.Size(200, 100)
        Me.grpRectangle.TabIndex = 12
        Me.grpRectangle.TabStop = False
        Me.grpRectangle.Text = "Enter Length and Width"
        '
        'grpCircle
        '
        Me.grpCircle.Controls.Add(Me.lblCirRadius)
        Me.grpCircle.Controls.Add(Me.txtCirRadius)
        Me.grpCircle.Location = New System.Drawing.Point(60, 360)
        Me.grpCircle.Name = "grpCircle"
        Me.grpCircle.Size = New System.Drawing.Size(200, 100)
        Me.grpCircle.TabIndex = 11
        Me.grpCircle.TabStop = False
        Me.grpCircle.Text = "Enter Circle Radius"
        '
        'grpTrapezium
        '
        Me.grpTrapezium.Controls.Add(Me.lblTpzSide2)
        Me.grpTrapezium.Controls.Add(Me.lblTpzSide1)
        Me.grpTrapezium.Controls.Add(Me.lblTpzHeight)
        Me.grpTrapezium.Controls.Add(Me.txtTpzSide2)
        Me.grpTrapezium.Controls.Add(Me.txtTpzSide1)
        Me.grpTrapezium.Controls.Add(Me.txtTpzHeight)
        Me.grpTrapezium.Location = New System.Drawing.Point(60, 135)
        Me.grpTrapezium.Name = "grpTrapezium"
        Me.grpTrapezium.Size = New System.Drawing.Size(200, 113)
        Me.grpTrapezium.TabIndex = 11
        Me.grpTrapezium.TabStop = False
        Me.grpTrapezium.Text = "Enter Height, and parallel sides"
        '
        'lblTpzSide2
        '
        Me.lblTpzSide2.AutoSize = True
        Me.lblTpzSide2.Location = New System.Drawing.Point(14, 83)
        Me.lblTpzSide2.Name = "lblTpzSide2"
        Me.lblTpzSide2.Size = New System.Drawing.Size(38, 15)
        Me.lblTpzSide2.TabIndex = 5
        Me.lblTpzSide2.Text = "Side 2"
        '
        'lblTpzSide1
        '
        Me.lblTpzSide1.AutoSize = True
        Me.lblTpzSide1.Location = New System.Drawing.Point(14, 54)
        Me.lblTpzSide1.Name = "lblTpzSide1"
        Me.lblTpzSide1.Size = New System.Drawing.Size(38, 15)
        Me.lblTpzSide1.TabIndex = 4
        Me.lblTpzSide1.Text = "Side 1"
        '
        'lblTpzHeight
        '
        Me.lblTpzHeight.AutoSize = True
        Me.lblTpzHeight.Location = New System.Drawing.Point(14, 25)
        Me.lblTpzHeight.Name = "lblTpzHeight"
        Me.lblTpzHeight.Size = New System.Drawing.Size(43, 15)
        Me.lblTpzHeight.TabIndex = 3
        Me.lblTpzHeight.Text = "Height"
        '
        'txtTpzSide2
        '
        Me.txtTpzSide2.Location = New System.Drawing.Point(69, 80)
        Me.txtTpzSide2.Name = "txtTpzSide2"
        Me.txtTpzSide2.Size = New System.Drawing.Size(100, 23)
        Me.txtTpzSide2.TabIndex = 2
        '
        'txtTpzSide1
        '
        Me.txtTpzSide1.Location = New System.Drawing.Point(69, 51)
        Me.txtTpzSide1.Name = "txtTpzSide1"
        Me.txtTpzSide1.Size = New System.Drawing.Size(100, 23)
        Me.txtTpzSide1.TabIndex = 1
        '
        'txtTpzHeight
        '
        Me.txtTpzHeight.Location = New System.Drawing.Point(69, 22)
        Me.txtTpzHeight.Name = "txtTpzHeight"
        Me.txtTpzHeight.Size = New System.Drawing.Size(100, 23)
        Me.txtTpzHeight.TabIndex = 0
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(716, 485)
        Me.Controls.Add(Me.grpTrapezium)
        Me.Controls.Add(Me.grpRectangle)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.lstOutput)
        Me.Controls.Add(Me.grpShapeSelection)
        Me.Controls.Add(Me.grpCircle)
        Me.Name = "Form1"
        Me.Text = "Shapes Calculator"
        Me.grpShapeSelection.ResumeLayout(False)
        Me.grpShapeSelection.PerformLayout()
        Me.grpRectangle.ResumeLayout(False)
        Me.grpRectangle.PerformLayout()
        Me.grpCircle.ResumeLayout(False)
        Me.grpCircle.PerformLayout()
        Me.grpTrapezium.ResumeLayout(False)
        Me.grpTrapezium.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents txtRectLength As TextBox
    Friend WithEvents txtRectWidth As TextBox
    Friend WithEvents lblLength As Label
    Friend WithEvents lblWidth As Label
    Friend WithEvents lstOutput As ListBox
    Friend WithEvents btnCalculate As Button
    Friend WithEvents lblCirRadius As Label
    Friend WithEvents txtCirRadius As TextBox
    Friend WithEvents optRectangle As RadioButton
    Friend WithEvents optCircle As RadioButton
    Friend WithEvents optTrapezium As RadioButton
    Friend WithEvents grpShapeSelection As GroupBox
    Friend WithEvents grpRectangle As GroupBox
    Friend WithEvents grpCircle As GroupBox
    Friend WithEvents grpTrapezium As GroupBox
    Friend WithEvents lblTpzSide2 As Label
    Friend WithEvents lblTpzSide1 As Label
    Friend WithEvents lblTpzHeight As Label
    Friend WithEvents txtTpzSide2 As TextBox
    Friend WithEvents txtTpzSide1 As TextBox
    Friend WithEvents txtTpzHeight As TextBox
End Class
