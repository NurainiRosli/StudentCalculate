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
        Me.BtnCalculate = New System.Windows.Forms.Button()
        Me.lblJumlahMakmal = New System.Windows.Forms.Label()
        Me.JumlahPelajar = New System.Windows.Forms.NumericUpDown()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        CType(Me.JumlahPelajar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'BtnCalculate
        '
        Me.BtnCalculate.Location = New System.Drawing.Point(406, 109)
        Me.BtnCalculate.Name = "BtnCalculate"
        Me.BtnCalculate.Size = New System.Drawing.Size(75, 23)
        Me.BtnCalculate.TabIndex = 0
        Me.BtnCalculate.Text = "Enter"
        Me.BtnCalculate.UseVisualStyleBackColor = True
        '
        'lblJumlahMakmal
        '
        Me.lblJumlahMakmal.AutoSize = True
        Me.lblJumlahMakmal.Location = New System.Drawing.Point(381, 154)
        Me.lblJumlahMakmal.Name = "lblJumlahMakmal"
        Me.lblJumlahMakmal.Size = New System.Drawing.Size(0, 13)
        Me.lblJumlahMakmal.TabIndex = 1
        '
        'JumlahPelajar
        '
        Me.JumlahPelajar.Location = New System.Drawing.Point(145, 0)
        Me.JumlahPelajar.Name = "JumlahPelajar"
        Me.JumlahPelajar.Size = New System.Drawing.Size(120, 20)
        Me.JumlahPelajar.TabIndex = 2
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.JumlahPelajar)
        Me.GroupBox1.Location = New System.Drawing.Point(241, 74)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(299, 29)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Insert the total of students :"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lblJumlahMakmal)
        Me.Controls.Add(Me.BtnCalculate)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.JumlahPelajar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnCalculate As Button
    Friend WithEvents lblJumlahMakmal As Label
    Friend WithEvents JumlahPelajar As NumericUpDown
    Friend WithEvents GroupBox1 As GroupBox
End Class
