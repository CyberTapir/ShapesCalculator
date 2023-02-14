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
        Me.SuspendLayout()
        '
        'txtRectLength
        '
        Me.txtRectLength.Location = New System.Drawing.Point(108, 211)
        Me.txtRectLength.Name = "txtRectLength"
        Me.txtRectLength.Size = New System.Drawing.Size(100, 23)
        Me.txtRectLength.TabIndex = 0
        '
        'txtRectWidth
        '
        Me.txtRectWidth.Location = New System.Drawing.Point(108, 240)
        Me.txtRectWidth.Name = "txtRectWidth"
        Me.txtRectWidth.Size = New System.Drawing.Size(100, 23)
        Me.txtRectWidth.TabIndex = 1
        '
        'lblLength
        '
        Me.lblLength.AutoSize = True
        Me.lblLength.Location = New System.Drawing.Point(61, 214)
        Me.lblLength.Name = "lblLength"
        Me.lblLength.Size = New System.Drawing.Size(44, 15)
        Me.lblLength.TabIndex = 2
        Me.lblLength.Text = "Length"
        '
        'lblWidth
        '
        Me.lblWidth.AutoSize = True
        Me.lblWidth.Location = New System.Drawing.Point(61, 243)
        Me.lblWidth.Name = "lblWidth"
        Me.lblWidth.Size = New System.Drawing.Size(39, 15)
        Me.lblWidth.TabIndex = 3
        Me.lblWidth.Text = "Width"
        '
        'lstOutput
        '
        Me.lstOutput.FormattingEnabled = True
        Me.lstOutput.ItemHeight = 15
        Me.lstOutput.Location = New System.Drawing.Point(317, 29)
        Me.lstOutput.Name = "lstOutput"
        Me.lstOutput.Size = New System.Drawing.Size(208, 364)
        Me.lstOutput.TabIndex = 4
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(592, 344)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(75, 23)
        Me.btnCalculate.TabIndex = 5
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.lstOutput)
        Me.Controls.Add(Me.lblWidth)
        Me.Controls.Add(Me.lblLength)
        Me.Controls.Add(Me.txtRectWidth)
        Me.Controls.Add(Me.txtRectLength)
        Me.Name = "Form1"
        Me.Text = "Shapes Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtRectLength As TextBox
    Friend WithEvents txtRectWidth As TextBox
    Friend WithEvents lblLength As Label
    Friend WithEvents lblWidth As Label
    Friend WithEvents lstOutput As ListBox
    Friend WithEvents btnCalculate As Button
End Class
