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
        Me.btnNumVenues = New System.Windows.Forms.Button()
        Me.btnCapture = New System.Windows.Forms.Button()
        Me.gridVenue = New UJGrid.UJGrid()
        Me.lblTotalProfit = New System.Windows.Forms.Label()
        Me.txtTotalProfit = New System.Windows.Forms.TextBox()
        Me.txtAverage = New System.Windows.Forms.TextBox()
        Me.txtMax = New System.Windows.Forms.TextBox()
        Me.lblAverage = New System.Windows.Forms.Label()
        Me.lblMax = New System.Windows.Forms.Label()
        Me.txtLess = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnaverage = New System.Windows.Forms.Button()
        Me.btnTotalProfit = New System.Windows.Forms.Button()
        Me.btnmaximum = New System.Windows.Forms.Button()
        Me.btnLess = New System.Windows.Forms.Button()
        Me.btndisplay = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnNumVenues
        '
        Me.btnNumVenues.Location = New System.Drawing.Point(171, 29)
        Me.btnNumVenues.Name = "btnNumVenues"
        Me.btnNumVenues.Size = New System.Drawing.Size(105, 61)
        Me.btnNumVenues.TabIndex = 0
        Me.btnNumVenues.Text = "Input Number of Venues"
        Me.btnNumVenues.UseVisualStyleBackColor = True
        '
        'btnCapture
        '
        Me.btnCapture.Location = New System.Drawing.Point(352, 33)
        Me.btnCapture.Name = "btnCapture"
        Me.btnCapture.Size = New System.Drawing.Size(115, 57)
        Me.btnCapture.TabIndex = 1
        Me.btnCapture.Text = "Capture"
        Me.btnCapture.UseVisualStyleBackColor = True
        '
        'gridVenue
        '
        Me.gridVenue.Cols = 5
        Me.gridVenue.FixedCols = 1
        Me.gridVenue.FixedRows = 1
        Me.gridVenue.Location = New System.Drawing.Point(63, 137)
        Me.gridVenue.Margin = New System.Windows.Forms.Padding(4)
        Me.gridVenue.Name = "gridVenue"
        Me.gridVenue.Scrollbars = System.Windows.Forms.ScrollBars.Both
        Me.gridVenue.Size = New System.Drawing.Size(705, 241)
        Me.gridVenue.TabIndex = 2
        '
        'lblTotalProfit
        '
        Me.lblTotalProfit.AutoSize = True
        Me.lblTotalProfit.Location = New System.Drawing.Point(71, 443)
        Me.lblTotalProfit.Name = "lblTotalProfit"
        Me.lblTotalProfit.Size = New System.Drawing.Size(71, 16)
        Me.lblTotalProfit.TabIndex = 3
        Me.lblTotalProfit.Text = "Total Profit"
        '
        'txtTotalProfit
        '
        Me.txtTotalProfit.Location = New System.Drawing.Point(153, 443)
        Me.txtTotalProfit.Name = "txtTotalProfit"
        Me.txtTotalProfit.Size = New System.Drawing.Size(79, 22)
        Me.txtTotalProfit.TabIndex = 4
        '
        'txtAverage
        '
        Me.txtAverage.Location = New System.Drawing.Point(374, 449)
        Me.txtAverage.Name = "txtAverage"
        Me.txtAverage.Size = New System.Drawing.Size(77, 22)
        Me.txtAverage.TabIndex = 5
        '
        'txtMax
        '
        Me.txtMax.Location = New System.Drawing.Point(656, 437)
        Me.txtMax.Name = "txtMax"
        Me.txtMax.Size = New System.Drawing.Size(77, 22)
        Me.txtMax.TabIndex = 6
        '
        'lblAverage
        '
        Me.lblAverage.AutoSize = True
        Me.lblAverage.Location = New System.Drawing.Point(309, 449)
        Me.lblAverage.Name = "lblAverage"
        Me.lblAverage.Size = New System.Drawing.Size(59, 16)
        Me.lblAverage.TabIndex = 7
        Me.lblAverage.Text = "Average"
        '
        'lblMax
        '
        Me.lblMax.AutoSize = True
        Me.lblMax.Location = New System.Drawing.Point(575, 440)
        Me.lblMax.Name = "lblMax"
        Me.lblMax.Size = New System.Drawing.Size(64, 16)
        Me.lblMax.TabIndex = 8
        Me.lblMax.Text = "Maximum"
        '
        'txtLess
        '
        Me.txtLess.Location = New System.Drawing.Point(486, 898)
        Me.txtLess.Name = "txtLess"
        Me.txtLess.Size = New System.Drawing.Size(77, 22)
        Me.txtLess.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(293, 904)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(152, 16)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Number Of Venues Less"
        '
        'btnaverage
        '
        Me.btnaverage.Location = New System.Drawing.Point(347, 394)
        Me.btnaverage.Name = "btnaverage"
        Me.btnaverage.Size = New System.Drawing.Size(120, 31)
        Me.btnaverage.TabIndex = 11
        Me.btnaverage.Text = "average"
        Me.btnaverage.UseVisualStyleBackColor = True
        '
        'btnTotalProfit
        '
        Me.btnTotalProfit.Location = New System.Drawing.Point(97, 394)
        Me.btnTotalProfit.Name = "btnTotalProfit"
        Me.btnTotalProfit.Size = New System.Drawing.Size(164, 23)
        Me.btnTotalProfit.TabIndex = 12
        Me.btnTotalProfit.Text = "Total Profit"
        Me.btnTotalProfit.UseVisualStyleBackColor = True
        '
        'btnmaximum
        '
        Me.btnmaximum.Location = New System.Drawing.Point(602, 394)
        Me.btnmaximum.Name = "btnmaximum"
        Me.btnmaximum.Size = New System.Drawing.Size(75, 23)
        Me.btnmaximum.TabIndex = 13
        Me.btnmaximum.Text = "maximum"
        Me.btnmaximum.UseVisualStyleBackColor = True
        '
        'btnLess
        '
        Me.btnLess.Location = New System.Drawing.Point(386, 852)
        Me.btnLess.Name = "btnLess"
        Me.btnLess.Size = New System.Drawing.Size(97, 23)
        Me.btnLess.TabIndex = 14
        Me.btnLess.Text = "Venues Less"
        Me.btnLess.UseVisualStyleBackColor = True
        '
        'btndisplay
        '
        Me.btndisplay.Location = New System.Drawing.Point(532, 38)
        Me.btndisplay.Name = "btndisplay"
        Me.btndisplay.Size = New System.Drawing.Size(107, 43)
        Me.btndisplay.TabIndex = 15
        Me.btndisplay.Text = "display"
        Me.btndisplay.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(833, 544)
        Me.Controls.Add(Me.btndisplay)
        Me.Controls.Add(Me.btnLess)
        Me.Controls.Add(Me.btnmaximum)
        Me.Controls.Add(Me.btnTotalProfit)
        Me.Controls.Add(Me.btnaverage)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtLess)
        Me.Controls.Add(Me.lblMax)
        Me.Controls.Add(Me.lblAverage)
        Me.Controls.Add(Me.txtMax)
        Me.Controls.Add(Me.txtAverage)
        Me.Controls.Add(Me.txtTotalProfit)
        Me.Controls.Add(Me.lblTotalProfit)
        Me.Controls.Add(Me.gridVenue)
        Me.Controls.Add(Me.btnCapture)
        Me.Controls.Add(Me.btnNumVenues)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnNumVenues As Button
    Friend WithEvents btnCapture As Button
    Friend WithEvents gridVenue As UJGrid.UJGrid
    Friend WithEvents lblTotalProfit As Label
    Friend WithEvents txtTotalProfit As TextBox
    Friend WithEvents txtAverage As TextBox
    Friend WithEvents txtMax As TextBox
    Friend WithEvents lblAverage As Label
    Friend WithEvents lblMax As Label
    Friend WithEvents txtLess As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents btnaverage As Button
    Friend WithEvents btnTotalProfit As Button
    Friend WithEvents btnmaximum As Button
    Friend WithEvents btnLess As Button
    Friend WithEvents btndisplay As Button
End Class
