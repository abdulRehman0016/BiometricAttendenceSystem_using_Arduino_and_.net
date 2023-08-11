<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Me.chkteacher = New System.Windows.Forms.CheckBox()
        Me.chkstu1 = New System.Windows.Forms.CheckBox()
        Me.chkstu2 = New System.Windows.Forms.CheckBox()
        Me.chkstu3 = New System.Windows.Forms.CheckBox()
        Me.chkstu4 = New System.Windows.Forms.CheckBox()
        Me.chkstu5 = New System.Windows.Forms.CheckBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblmins = New System.Windows.Forms.Label()
        Me.lblsecs = New System.Windows.Forms.Label()
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'chkteacher
        '
        Me.chkteacher.AutoSize = True
        Me.chkteacher.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkteacher.Location = New System.Drawing.Point(552, 82)
        Me.chkteacher.Name = "chkteacher"
        Me.chkteacher.Size = New System.Drawing.Size(83, 21)
        Me.chkteacher.TabIndex = 0
        Me.chkteacher.Text = "Teacher"
        Me.chkteacher.UseVisualStyleBackColor = True
        '
        'chkstu1
        '
        Me.chkstu1.AutoSize = True
        Me.chkstu1.Location = New System.Drawing.Point(552, 124)
        Me.chkstu1.Name = "chkstu1"
        Me.chkstu1.Size = New System.Drawing.Size(91, 21)
        Me.chkstu1.TabIndex = 1
        Me.chkstu1.Text = "Student 1"
        Me.chkstu1.UseVisualStyleBackColor = True
        '
        'chkstu2
        '
        Me.chkstu2.AutoSize = True
        Me.chkstu2.Location = New System.Drawing.Point(552, 169)
        Me.chkstu2.Name = "chkstu2"
        Me.chkstu2.Size = New System.Drawing.Size(91, 21)
        Me.chkstu2.TabIndex = 2
        Me.chkstu2.Text = "Student 2"
        Me.chkstu2.UseVisualStyleBackColor = True
        '
        'chkstu3
        '
        Me.chkstu3.AutoSize = True
        Me.chkstu3.Location = New System.Drawing.Point(552, 209)
        Me.chkstu3.Name = "chkstu3"
        Me.chkstu3.Size = New System.Drawing.Size(91, 21)
        Me.chkstu3.TabIndex = 3
        Me.chkstu3.Text = "Student 3"
        Me.chkstu3.UseVisualStyleBackColor = True
        '
        'chkstu4
        '
        Me.chkstu4.AutoSize = True
        Me.chkstu4.Location = New System.Drawing.Point(552, 247)
        Me.chkstu4.Name = "chkstu4"
        Me.chkstu4.Size = New System.Drawing.Size(91, 21)
        Me.chkstu4.TabIndex = 4
        Me.chkstu4.Text = "Student 4"
        Me.chkstu4.UseVisualStyleBackColor = True
        '
        'chkstu5
        '
        Me.chkstu5.AutoSize = True
        Me.chkstu5.Location = New System.Drawing.Point(552, 288)
        Me.chkstu5.Name = "chkstu5"
        Me.chkstu5.Size = New System.Drawing.Size(91, 21)
        Me.chkstu5.TabIndex = 5
        Me.chkstu5.Text = "Student 5"
        Me.chkstu5.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(34, 40)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(422, 93)
        Me.TextBox1.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(27, 136)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(172, 37)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Lapsed Time"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(197, 200)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(115, 29)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Seconds"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Label3.Location = New System.Drawing.Point(29, 200)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(104, 29)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Minutes"
        '
        'lblmins
        '
        Me.lblmins.AutoSize = True
        Me.lblmins.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblmins.Location = New System.Drawing.Point(40, 247)
        Me.lblmins.Name = "lblmins"
        Me.lblmins.Size = New System.Drawing.Size(33, 36)
        Me.lblmins.TabIndex = 10
        Me.lblmins.Text = "0"
        '
        'lblsecs
        '
        Me.lblsecs.AutoSize = True
        Me.lblsecs.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblsecs.Location = New System.Drawing.Point(211, 247)
        Me.lblsecs.Name = "lblsecs"
        Me.lblsecs.Size = New System.Drawing.Size(33, 36)
        Me.lblsecs.TabIndex = 11
        Me.lblsecs.Text = "0"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'Timer2
        '
        Me.Timer2.Enabled = True
        Me.Timer2.Interval = 2000
        '
        'Timer3
        '
        Me.Timer3.Interval = 1000
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblsecs)
        Me.Controls.Add(Me.lblmins)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.chkstu5)
        Me.Controls.Add(Me.chkstu4)
        Me.Controls.Add(Me.chkstu3)
        Me.Controls.Add(Me.chkstu2)
        Me.Controls.Add(Me.chkstu1)
        Me.Controls.Add(Me.chkteacher)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "Form1"
        Me.Text = "Biometric Attendence System 0.1v"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents chkteacher As CheckBox
    Friend WithEvents chkstu1 As CheckBox
    Friend WithEvents chkstu2 As CheckBox
    Friend WithEvents chkstu3 As CheckBox
    Friend WithEvents chkstu4 As CheckBox
    Friend WithEvents chkstu5 As CheckBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblmins As Label
    Friend WithEvents lblsecs As Label
    Friend WithEvents SerialPort1 As IO.Ports.SerialPort
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Timer2 As Timer
    Friend WithEvents Timer3 As Timer
End Class
