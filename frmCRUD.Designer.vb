<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCRUD
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
        Me.btnBackup = New System.Windows.Forms.Button()
        Me.btnLocate = New System.Windows.Forms.Button()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.SuspendLayout()
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(43, 162)
        Me.btnAdd.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(204, 44)
        Me.btnAdd.TabIndex = 0
        Me.btnAdd.Text = "Add Record"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'lblUsername
        '
        Me.lblUsername.AutoSize = True
        Me.lblUsername.Location = New System.Drawing.Point(39, 65)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(93, 16)
        Me.lblUsername.TabIndex = 1
        Me.lblUsername.Text = "Department ID"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(39, 112)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(117, 16)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Department Name"
        '
        'TextDeptID
        '
        Me.TextDeptID.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextDeptID.Location = New System.Drawing.Point(189, 65)
        Me.TextDeptID.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TextDeptID.Name = "TextDeptID"
        Me.TextDeptID.Size = New System.Drawing.Size(536, 38)
        Me.TextDeptID.TabIndex = 3
        '
        'TextDeptName
        '
        Me.TextDeptName.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextDeptName.Location = New System.Drawing.Point(189, 112)
        Me.TextDeptName.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TextDeptName.Name = "TextDeptName"
        Me.TextDeptName.Size = New System.Drawing.Size(536, 38)
        Me.TextDeptName.TabIndex = 4
        '
        'BtnSearch
        '
        Me.BtnSearch.Location = New System.Drawing.Point(569, 10)
        Me.BtnSearch.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnSearch.Name = "BtnSearch"
        Me.BtnSearch.Size = New System.Drawing.Size(156, 44)
        Me.BtnSearch.TabIndex = 5
        Me.BtnSearch.Text = "Search"
        Me.BtnSearch.UseVisualStyleBackColor = True
        '
        'TextSearch
        '
        Me.TextSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextSearch.Location = New System.Drawing.Point(435, 14)
        Me.TextSearch.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TextSearch.Name = "TextSearch"
        Me.TextSearch.Size = New System.Drawing.Size(129, 38)
        Me.TextSearch.TabIndex = 6
        '
        'BtnUpdate
        '
        Me.BtnUpdate.Location = New System.Drawing.Point(277, 162)
        Me.BtnUpdate.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnUpdate.Name = "BtnUpdate"
        Me.BtnUpdate.Size = New System.Drawing.Size(204, 44)
        Me.BtnUpdate.TabIndex = 7
        Me.BtnUpdate.Text = "Update Record"
        Me.BtnUpdate.UseVisualStyleBackColor = True
        '
        'BtnDelete
        '
        Me.BtnDelete.Location = New System.Drawing.Point(522, 162)
        Me.BtnDelete.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(204, 44)
        Me.BtnDelete.TabIndex = 8
        Me.BtnDelete.Text = "Delete Record"
        Me.BtnDelete.UseVisualStyleBackColor = True
        '
        'btnBackup
        '
        Me.btnBackup.Location = New System.Drawing.Point(43, 221)
        Me.btnBackup.Name = "btnBackup"
        Me.btnBackup.Size = New System.Drawing.Size(204, 40)
        Me.btnBackup.TabIndex = 9
        Me.btnBackup.Text = "Backup Database"
        Me.btnBackup.UseVisualStyleBackColor = True
        '
        'btnLocate
        '
        Me.btnLocate.Location = New System.Drawing.Point(277, 224)
        Me.btnLocate.Name = "btnLocate"
        Me.btnLocate.Size = New System.Drawing.Size(204, 37)
        Me.btnLocate.TabIndex = 10
        Me.btnLocate.Text = "Locate Data"
        Me.btnLocate.UseVisualStyleBackColor = True
        '
        'frmCRUD
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(755, 336)
        Me.Controls.Add(Me.btnLocate)
        Me.Controls.Add(Me.btnBackup)
        Me.Controls.Add(Me.BtnDelete)
        Me.Controls.Add(Me.BtnUpdate)
        Me.Controls.Add(Me.TextSearch)
        Me.Controls.Add(Me.BtnSearch)
        Me.Controls.Add(Me.TextDeptName)
        Me.Controls.Add(Me.TextDeptID)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblUsername)
        Me.Controls.Add(Me.btnAdd)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "frmCRUD"
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
    Friend WithEvents btnBackup As Button
    Friend WithEvents btnLocate As Button
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
End Class
