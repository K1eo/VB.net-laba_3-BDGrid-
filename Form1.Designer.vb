<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Access
    Inherits System.Windows.Forms.Form

    'Форма переопределяет dispose для очистки списка компонентов.
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

    'Является обязательной для конструктора форм Windows Forms
    Private components As System.ComponentModel.IContainer

    'Примечание: следующая процедура является обязательной для конструктора форм Windows Forms
    'Для ее изменения используйте конструктор форм Windows Form.  
    'Не изменяйте ее в редакторе исходного кода.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.DataGrid1 = New System.Windows.Forms.DataGridView()
        Me.Add1 = New System.Windows.Forms.Button()
        Me.Delete1 = New System.Windows.Forms.Button()
        Me.Open1 = New System.Windows.Forms.Button()
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGrid1
        '
        Me.DataGrid1.AllowUserToAddRows = False
        Me.DataGrid1.AllowUserToDeleteRows = False
        Me.DataGrid1.BackgroundColor = System.Drawing.SystemColors.Control
        Me.DataGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGrid1.Location = New System.Drawing.Point(12, 12)
        Me.DataGrid1.Name = "DataGrid1"
        Me.DataGrid1.ReadOnly = True
        Me.DataGrid1.Size = New System.Drawing.Size(445, 201)
        Me.DataGrid1.TabIndex = 0
        '
        'Add1
        '
        Me.Add1.BackColor = System.Drawing.Color.Black
        Me.Add1.ForeColor = System.Drawing.Color.White
        Me.Add1.Location = New System.Drawing.Point(168, 243)
        Me.Add1.Name = "Add1"
        Me.Add1.Size = New System.Drawing.Size(132, 31)
        Me.Add1.TabIndex = 1
        Me.Add1.Text = "Add"
        Me.Add1.UseVisualStyleBackColor = False
        '
        'Delete1
        '
        Me.Delete1.BackColor = System.Drawing.Color.Black
        Me.Delete1.ForeColor = System.Drawing.Color.White
        Me.Delete1.Location = New System.Drawing.Point(322, 243)
        Me.Delete1.Name = "Delete1"
        Me.Delete1.Size = New System.Drawing.Size(132, 31)
        Me.Delete1.TabIndex = 2
        Me.Delete1.Text = "Delete"
        Me.Delete1.UseVisualStyleBackColor = False
        '
        'Open1
        '
        Me.Open1.BackColor = System.Drawing.Color.Black
        Me.Open1.ForeColor = System.Drawing.Color.White
        Me.Open1.Location = New System.Drawing.Point(17, 243)
        Me.Open1.Name = "Open1"
        Me.Open1.Size = New System.Drawing.Size(132, 31)
        Me.Open1.TabIndex = 3
        Me.Open1.Text = "Open"
        Me.Open1.UseVisualStyleBackColor = False
        '
        'Access
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.ClientSize = New System.Drawing.Size(468, 289)
        Me.Controls.Add(Me.Open1)
        Me.Controls.Add(Me.Delete1)
        Me.Controls.Add(Me.Add1)
        Me.Controls.Add(Me.DataGrid1)
        Me.Name = "Access"
        Me.Text = "Access"
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGrid1 As DataGridView
    Friend WithEvents Add1 As Button
    Friend WithEvents Delete1 As Button
    Friend WithEvents Open1 As Button
End Class
