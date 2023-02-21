<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAirBnb
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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblHeading = New System.Windows.Forms.Label()
        Me.lblDescription = New System.Windows.Forms.Label()
        Me.lblNumberNights = New System.Windows.Forms.Label()
        Me.lblCostStay = New System.Windows.Forms.Label()
        Me.lblTotalCost = New System.Windows.Forms.Label()
        Me.txtNights = New System.Windows.Forms.TextBox()
        Me.btnDisplayCost = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Airbnb_Reservations.My.Resources.Resources.airbnb
        Me.PictureBox1.Location = New System.Drawing.Point(4, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(471, 476)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'lblHeading
        '
        Me.lblHeading.AutoSize = True
        Me.lblHeading.Font = New System.Drawing.Font("Broadway", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeading.Location = New System.Drawing.Point(524, 32)
        Me.lblHeading.Name = "lblHeading"
        Me.lblHeading.Size = New System.Drawing.Size(351, 42)
        Me.lblHeading.TabIndex = 1
        Me.lblHeading.Text = "Orlando AirBnB"
        '
        'lblDescription
        '
        Me.lblDescription.AutoSize = True
        Me.lblDescription.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescription.Location = New System.Drawing.Point(580, 95)
        Me.lblDescription.Name = "lblDescription"
        Me.lblDescription.Size = New System.Drawing.Size(239, 25)
        Me.lblDescription.TabIndex = 2
        Me.lblDescription.Text = "Only $79.00 per night"
        '
        'lblNumberNights
        '
        Me.lblNumberNights.AutoSize = True
        Me.lblNumberNights.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumberNights.Location = New System.Drawing.Point(526, 177)
        Me.lblNumberNights.Name = "lblNumberNights"
        Me.lblNumberNights.Size = New System.Drawing.Size(201, 26)
        Me.lblNumberNights.TabIndex = 3
        Me.lblNumberNights.Text = "Number of Nights:"
        '
        'lblCostStay
        '
        Me.lblCostStay.AutoSize = True
        Me.lblCostStay.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCostStay.Location = New System.Drawing.Point(526, 235)
        Me.lblCostStay.Name = "lblCostStay"
        Me.lblCostStay.Size = New System.Drawing.Size(142, 26)
        Me.lblCostStay.TabIndex = 4
        Me.lblCostStay.Text = "Cost of Stay:"
        '
        'lblTotalCost
        '
        Me.lblTotalCost.AutoSize = True
        Me.lblTotalCost.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalCost.Location = New System.Drawing.Point(769, 235)
        Me.lblTotalCost.Name = "lblTotalCost"
        Me.lblTotalCost.Size = New System.Drawing.Size(36, 26)
        Me.lblTotalCost.TabIndex = 5
        Me.lblTotalCost.Text = "$0"
        '
        'txtNights
        '
        Me.txtNights.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNights.Location = New System.Drawing.Point(774, 168)
        Me.txtNights.Name = "txtNights"
        Me.txtNights.Size = New System.Drawing.Size(45, 35)
        Me.txtNights.TabIndex = 6
        Me.txtNights.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnDisplayCost
        '
        Me.btnDisplayCost.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDisplayCost.Location = New System.Drawing.Point(506, 331)
        Me.btnDisplayCost.Name = "btnDisplayCost"
        Me.btnDisplayCost.Size = New System.Drawing.Size(105, 36)
        Me.btnDisplayCost.TabIndex = 7
        Me.btnDisplayCost.Text = "Display Cost"
        Me.btnDisplayCost.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(646, 331)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(105, 36)
        Me.btnClear.TabIndex = 8
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(787, 331)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(105, 36)
        Me.btnExit.TabIndex = 9
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmAirBnb
        '
        Me.AcceptButton = Me.btnDisplayCost
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.BurlyWood
        Me.ClientSize = New System.Drawing.Size(921, 484)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnDisplayCost)
        Me.Controls.Add(Me.txtNights)
        Me.Controls.Add(Me.lblTotalCost)
        Me.Controls.Add(Me.lblCostStay)
        Me.Controls.Add(Me.lblNumberNights)
        Me.Controls.Add(Me.lblDescription)
        Me.Controls.Add(Me.lblHeading)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "frmAirBnb"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AirBnB Reservations"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblHeading As Label
    Friend WithEvents lblDescription As Label
    Friend WithEvents lblNumberNights As Label
    Friend WithEvents lblCostStay As Label
    Friend WithEvents lblTotalCost As Label
    Friend WithEvents txtNights As TextBox
    Friend WithEvents btnDisplayCost As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
End Class
