<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRentals
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.grpStructures = New System.Windows.Forms.GroupBox()
        Me.radCabin = New System.Windows.Forms.RadioButton()
        Me.radYurt = New System.Windows.Forms.RadioButton()
        Me.radPrimitive = New System.Windows.Forms.RadioButton()
        Me.lblNumOfDays = New System.Windows.Forms.Label()
        Me.txtNumberOfDays = New System.Windows.Forms.TextBox()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.lstDisplay = New System.Windows.Forms.ListBox()
        Me.grpStructures.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpStructures
        '
        Me.grpStructures.Controls.Add(Me.radCabin)
        Me.grpStructures.Controls.Add(Me.radYurt)
        Me.grpStructures.Controls.Add(Me.radPrimitive)
        Me.grpStructures.Location = New System.Drawing.Point(25, 45)
        Me.grpStructures.Name = "grpStructures"
        Me.grpStructures.Size = New System.Drawing.Size(200, 230)
        Me.grpStructures.TabIndex = 0
        Me.grpStructures.TabStop = False
        Me.grpStructures.Text = "Structures"
        '
        'radCabin
        '
        Me.radCabin.AutoSize = True
        Me.radCabin.Location = New System.Drawing.Point(7, 103)
        Me.radCabin.Name = "radCabin"
        Me.radCabin.Size = New System.Drawing.Size(99, 29)
        Me.radCabin.TabIndex = 2
        Me.radCabin.TabStop = True
        Me.radCabin.Text = "Cabin"
        Me.radCabin.UseVisualStyleBackColor = True
        '
        'radYurt
        '
        Me.radYurt.AutoSize = True
        Me.radYurt.Location = New System.Drawing.Point(7, 67)
        Me.radYurt.Name = "radYurt"
        Me.radYurt.Size = New System.Drawing.Size(83, 29)
        Me.radYurt.TabIndex = 1
        Me.radYurt.TabStop = True
        Me.radYurt.Text = "Yurt"
        Me.radYurt.UseVisualStyleBackColor = True
        '
        'radPrimitive
        '
        Me.radPrimitive.AutoSize = True
        Me.radPrimitive.Location = New System.Drawing.Point(7, 31)
        Me.radPrimitive.Name = "radPrimitive"
        Me.radPrimitive.Size = New System.Drawing.Size(125, 29)
        Me.radPrimitive.TabIndex = 0
        Me.radPrimitive.TabStop = True
        Me.radPrimitive.Text = "Primitive"
        Me.radPrimitive.UseVisualStyleBackColor = True
        '
        'lblNumOfDays
        '
        Me.lblNumOfDays.AutoSize = True
        Me.lblNumOfDays.Location = New System.Drawing.Point(369, 45)
        Me.lblNumOfDays.Name = "lblNumOfDays"
        Me.lblNumOfDays.Size = New System.Drawing.Size(172, 25)
        Me.lblNumOfDays.TabIndex = 1
        Me.lblNumOfDays.Text = "Number of Days:"
        '
        'txtNumberOfDays
        '
        Me.txtNumberOfDays.Location = New System.Drawing.Point(374, 73)
        Me.txtNumberOfDays.Name = "txtNumberOfDays"
        Me.txtNumberOfDays.Size = New System.Drawing.Size(137, 31)
        Me.txtNumberOfDays.TabIndex = 2
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(364, 148)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(158, 65)
        Me.btnCalculate.TabIndex = 3
        Me.btnCalculate.Text = "Calculate Rental Fee"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Location = New System.Drawing.Point(79, 334)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(111, 25)
        Me.lblTotal.TabIndex = 4
        Me.lblTotal.Text = "Total Due:"
        '
        'lstDisplay
        '
        Me.lstDisplay.FormattingEnabled = True
        Me.lstDisplay.ItemHeight = 25
        Me.lstDisplay.Location = New System.Drawing.Point(196, 334)
        Me.lstDisplay.Name = "lstDisplay"
        Me.lstDisplay.Size = New System.Drawing.Size(289, 79)
        Me.lstDisplay.TabIndex = 5
        '
        'frmRentals
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lstDisplay)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.txtNumberOfDays)
        Me.Controls.Add(Me.lblNumOfDays)
        Me.Controls.Add(Me.grpStructures)
        Me.Name = "frmRentals"
        Me.Text = "Rentals"
        Me.grpStructures.ResumeLayout(False)
        Me.grpStructures.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents grpStructures As GroupBox
    Friend WithEvents radCabin As RadioButton
    Friend WithEvents radYurt As RadioButton
    Friend WithEvents radPrimitive As RadioButton
    Friend WithEvents lblNumOfDays As Label
    Friend WithEvents txtNumberOfDays As TextBox
    Friend WithEvents btnCalculate As Button
    Friend WithEvents lblTotal As Label
    Friend WithEvents lstDisplay As ListBox
End Class
