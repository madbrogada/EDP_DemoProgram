<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        Me.BtnRunSamplecode = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'BtnRunSamplecode
        '
        Me.BtnRunSamplecode.Location = New System.Drawing.Point(255, 294)
        Me.BtnRunSamplecode.Name = "BtnRunSamplecode"
        Me.BtnRunSamplecode.Size = New System.Drawing.Size(423, 97)
        Me.BtnRunSamplecode.TabIndex = 0
        Me.BtnRunSamplecode.Text = "Run Sample Code"
        Me.BtnRunSamplecode.UseVisualStyleBackColor = True
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(882, 506)
        Me.Controls.Add(Me.BtnRunSamplecode)
        Me.Name = "Form4"
        Me.Text = "Form4"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BtnRunSamplecode As Button
End Class
