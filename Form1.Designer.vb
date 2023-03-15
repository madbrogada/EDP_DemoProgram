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
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextDeptID = New System.Windows.Forms.TextBox()
        Me.TextDeptName = New System.Windows.Forms.TextBox()
        Me.BtnSearch = New System.Windows.Forms.Button()
        Me.TextSearch = New System.Windows.Forms.TextBox()
        Me.BtnUpdate = New System.Windows.Forms.Button()
        Me.BtnDelete = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(48, 203)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(229, 55)
        Me.btnAdd.TabIndex = 0
        Me.btnAdd.Text = "Add Record"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'lblUsername
        '
        Me.lblUsername.AutoSize = True
        Me.lblUsername.Location = New System.Drawing.Point(44, 81)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(115, 20)
        Me.lblUsername.TabIndex = 1
        Me.lblUsername.Text = "Department ID"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(44, 140)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(140, 20)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Department Name"
        '
        'TextDeptID
        '
        Me.TextDeptID.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextDeptID.Location = New System.Drawing.Point(213, 81)
        Me.TextDeptID.Name = "TextDeptID"
        Me.TextDeptID.Size = New System.Drawing.Size(603, 44)
        Me.TextDeptID.TabIndex = 3
        '
        'TextDeptName
        '
        Me.TextDeptName.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextDeptName.Location = New System.Drawing.Point(213, 140)
        Me.TextDeptName.Name = "TextDeptName"
        Me.TextDeptName.Size = New System.Drawing.Size(603, 44)
        Me.TextDeptName.TabIndex = 4
        '
        'BtnSearch
        '
        Me.BtnSearch.Location = New System.Drawing.Point(640, 12)
        Me.BtnSearch.Name = "BtnSearch"
        Me.BtnSearch.Size = New System.Drawing.Size(176, 55)
        Me.BtnSearch.TabIndex = 5
        Me.BtnSearch.Text = "Search"
        Me.BtnSearch.UseVisualStyleBackColor = True
        '
        'TextSearch
        '
        Me.TextSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextSearch.Location = New System.Drawing.Point(489, 17)
        Me.TextSearch.Name = "TextSearch"
        Me.TextSearch.Size = New System.Drawing.Size(145, 44)
        Me.TextSearch.TabIndex = 6
        '
        'BtnUpdate
        '
        Me.BtnUpdate.Location = New System.Drawing.Point(312, 203)
        Me.BtnUpdate.Name = "BtnUpdate"
        Me.BtnUpdate.Size = New System.Drawing.Size(229, 55)
        Me.BtnUpdate.TabIndex = 7
        Me.BtnUpdate.Text = "Update Record"
        Me.BtnUpdate.UseVisualStyleBackColor = True
        '
        'BtnDelete
        '
        Me.BtnDelete.Location = New System.Drawing.Point(587, 203)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(229, 55)
        Me.BtnDelete.TabIndex = 8
        Me.BtnDelete.Text = "Delete Record"
        Me.BtnDelete.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(849, 282)
        Me.Controls.Add(Me.BtnDelete)
        Me.Controls.Add(Me.BtnUpdate)
        Me.Controls.Add(Me.TextSearch)
        Me.Controls.Add(Me.BtnSearch)
        Me.Controls.Add(Me.TextDeptName)
        Me.Controls.Add(Me.TextDeptID)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblUsername)
        Me.Controls.Add(Me.btnAdd)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Main Form"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnAdd As Button
    Friend WithEvents lblUsername As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TextDeptID As TextBox
    Friend WithEvents TextDeptName As TextBox
    Friend WithEvents BtnSearch As Button
    Friend WithEvents TextSearch As TextBox
    Friend WithEvents BtnUpdate As Button
    Friend WithEvents BtnDelete As Button
End Class
