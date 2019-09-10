<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmApp
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
        Me.btnTotal = New System.Windows.Forms.Button()
        Me.lblHeader = New System.Windows.Forms.Label()
        Me.lblHours = New System.Windows.Forms.Label()
        Me.lblWage = New System.Windows.Forms.Label()
        Me.lblTotalLabel = New System.Windows.Forms.Label()
        Me.lblIncome = New System.Windows.Forms.Label()
        Me.txtHours = New System.Windows.Forms.TextBox()
        Me.txtWage = New System.Windows.Forms.TextBox()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnTotal
        '
        Me.btnTotal.AutoSize = True
        Me.btnTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTotal.Location = New System.Drawing.Point(44, 179)
        Me.btnTotal.Name = "btnTotal"
        Me.btnTotal.Size = New System.Drawing.Size(85, 30)
        Me.btnTotal.TabIndex = 0
        Me.btnTotal.Text = "Calculate"
        Me.btnTotal.UseVisualStyleBackColor = True
        '
        'lblHeader
        '
        Me.lblHeader.AutoSize = True
        Me.lblHeader.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeader.Location = New System.Drawing.Point(36, 24)
        Me.lblHeader.Name = "lblHeader"
        Me.lblHeader.Size = New System.Drawing.Size(148, 24)
        Me.lblHeader.TabIndex = 1
        Me.lblHeader.Text = "Wage Calculator"
        '
        'lblHours
        '
        Me.lblHours.AutoSize = True
        Me.lblHours.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHours.Location = New System.Drawing.Point(40, 62)
        Me.lblHours.Name = "lblHours"
        Me.lblHours.Size = New System.Drawing.Size(111, 20)
        Me.lblHours.TabIndex = 2
        Me.lblHours.Text = "Hours Worked"
        '
        'lblWage
        '
        Me.lblWage.AutoSize = True
        Me.lblWage.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWage.Location = New System.Drawing.Point(40, 102)
        Me.lblWage.Name = "lblWage"
        Me.lblWage.Size = New System.Drawing.Size(100, 20)
        Me.lblWage.TabIndex = 3
        Me.lblWage.Text = "Hourly Wage"
        '
        'lblTotalLabel
        '
        Me.lblTotalLabel.AutoSize = True
        Me.lblTotalLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalLabel.Location = New System.Drawing.Point(40, 143)
        Me.lblTotalLabel.Name = "lblTotalLabel"
        Me.lblTotalLabel.Size = New System.Drawing.Size(101, 20)
        Me.lblTotalLabel.TabIndex = 4
        Me.lblTotalLabel.Text = "Total Income"
        '
        'lblIncome
        '
        Me.lblIncome.AutoSize = True
        Me.lblIncome.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIncome.Location = New System.Drawing.Point(162, 143)
        Me.lblIncome.Name = "lblIncome"
        Me.lblIncome.Size = New System.Drawing.Size(141, 20)
        Me.lblIncome.TabIndex = 5
        Me.lblIncome.Text = "XXXXXXXXXXXX"
        Me.lblIncome.Visible = False
        '
        'txtHours
        '
        Me.txtHours.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHours.Location = New System.Drawing.Point(183, 61)
        Me.txtHours.Name = "txtHours"
        Me.txtHours.Size = New System.Drawing.Size(38, 26)
        Me.txtHours.TabIndex = 6
        '
        'txtWage
        '
        Me.txtWage.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtWage.Location = New System.Drawing.Point(157, 102)
        Me.txtWage.Name = "txtWage"
        Me.txtWage.Size = New System.Drawing.Size(64, 26)
        Me.txtWage.TabIndex = 7
        '
        'btnClear
        '
        Me.btnClear.AutoSize = True
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(162, 179)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(85, 30)
        Me.btnClear.TabIndex = 8
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.AutoSize = True
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(280, 179)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(85, 30)
        Me.btnExit.TabIndex = 9
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmApp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(533, 399)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.txtWage)
        Me.Controls.Add(Me.txtHours)
        Me.Controls.Add(Me.lblIncome)
        Me.Controls.Add(Me.lblTotalLabel)
        Me.Controls.Add(Me.lblWage)
        Me.Controls.Add(Me.lblHours)
        Me.Controls.Add(Me.lblHeader)
        Me.Controls.Add(Me.btnTotal)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "frmApp"
        Me.Text = "Testing"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnTotal As Button
    Friend WithEvents lblHeader As Label
    Friend WithEvents lblHours As Label
    Friend WithEvents lblWage As Label
    Friend WithEvents lblTotalLabel As Label
    Friend WithEvents lblIncome As Label
    Friend WithEvents txtHours As TextBox
    Friend WithEvents txtWage As TextBox
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
End Class
