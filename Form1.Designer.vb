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
        Me.ButtonConnect = New System.Windows.Forms.Button()
        Me.TextBoxName = New System.Windows.Forms.TextBox()
        Me.TextBoxAge = New System.Windows.Forms.TextBox()
        Me.TextBoxEmail = New System.Windows.Forms.TextBox()
        Me.lblName = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ButtonInsert = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ButtonRead = New System.Windows.Forms.Button()
        Me.ButtonUpdate = New System.Windows.Forms.Button()
        Me.ButtonDelete = New System.Windows.Forms.Button()
        Me.TextBoxHiddenID = New System.Windows.Forms.TextBox()
        Me.ButtonViewDeleted = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtonConnect
        '
        Me.ButtonConnect.Font = New System.Drawing.Font("Bahnschrift Condensed", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonConnect.Location = New System.Drawing.Point(12, 12)
        Me.ButtonConnect.Name = "ButtonConnect"
        Me.ButtonConnect.Size = New System.Drawing.Size(535, 104)
        Me.ButtonConnect.TabIndex = 0
        Me.ButtonConnect.Text = "Connect MySQL"
        Me.ButtonConnect.UseVisualStyleBackColor = True
        '
        'TextBoxName
        '
        Me.TextBoxName.Location = New System.Drawing.Point(45, 122)
        Me.TextBoxName.Name = "TextBoxName"
        Me.TextBoxName.Size = New System.Drawing.Size(502, 20)
        Me.TextBoxName.TabIndex = 1
        '
        'TextBoxAge
        '
        Me.TextBoxAge.Location = New System.Drawing.Point(45, 148)
        Me.TextBoxAge.Name = "TextBoxAge"
        Me.TextBoxAge.Size = New System.Drawing.Size(502, 20)
        Me.TextBoxAge.TabIndex = 1
        '
        'TextBoxEmail
        '
        Me.TextBoxEmail.Location = New System.Drawing.Point(45, 174)
        Me.TextBoxEmail.Name = "TextBoxEmail"
        Me.TextBoxEmail.Size = New System.Drawing.Size(502, 20)
        Me.TextBoxEmail.TabIndex = 1
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.BackColor = System.Drawing.Color.Transparent
        Me.lblName.Font = New System.Drawing.Font("High Tower Text", 9.0!)
        Me.lblName.ForeColor = System.Drawing.Color.Black
        Me.lblName.Location = New System.Drawing.Point(3, 124)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(36, 15)
        Me.lblName.TabIndex = 2
        Me.lblName.Text = "Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("High Tower Text", 9.0!)
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(5, 152)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(27, 15)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Age"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("High Tower Text", 9.0!)
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(5, 178)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(34, 15)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Email"
        '
        'ButtonInsert
        '
        Me.ButtonInsert.Font = New System.Drawing.Font("Cambria", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonInsert.Location = New System.Drawing.Point(12, 225)
        Me.ButtonInsert.Name = "ButtonInsert"
        Me.ButtonInsert.Size = New System.Drawing.Size(535, 23)
        Me.ButtonInsert.TabIndex = 3
        Me.ButtonInsert.Text = "Insert Data"
        Me.ButtonInsert.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Cambria", 8.25!)
        Me.btnExit.Location = New System.Drawing.Point(12, 497)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(535, 23)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.DimGray
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.DataGridView1.Location = New System.Drawing.Point(12, 341)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(535, 150)
        Me.DataGridView1.TabIndex = 5
        '
        'ButtonRead
        '
        Me.ButtonRead.Font = New System.Drawing.Font("Cambria", 8.25!)
        Me.ButtonRead.Location = New System.Drawing.Point(12, 254)
        Me.ButtonRead.Name = "ButtonRead"
        Me.ButtonRead.Size = New System.Drawing.Size(535, 23)
        Me.ButtonRead.TabIndex = 6
        Me.ButtonRead.Text = "Read Data"
        Me.ButtonRead.UseVisualStyleBackColor = True
        '
        'ButtonUpdate
        '
        Me.ButtonUpdate.Font = New System.Drawing.Font("Cambria", 8.25!)
        Me.ButtonUpdate.Location = New System.Drawing.Point(12, 283)
        Me.ButtonUpdate.Name = "ButtonUpdate"
        Me.ButtonUpdate.Size = New System.Drawing.Size(535, 23)
        Me.ButtonUpdate.TabIndex = 7
        Me.ButtonUpdate.Text = "Update Data"
        Me.ButtonUpdate.UseVisualStyleBackColor = True
        '
        'ButtonDelete
        '
        Me.ButtonDelete.Font = New System.Drawing.Font("Cambria", 8.25!)
        Me.ButtonDelete.Location = New System.Drawing.Point(12, 312)
        Me.ButtonDelete.Name = "ButtonDelete"
        Me.ButtonDelete.Size = New System.Drawing.Size(535, 23)
        Me.ButtonDelete.TabIndex = 7
        Me.ButtonDelete.Text = "Delete Data"
        Me.ButtonDelete.UseVisualStyleBackColor = True
        '
        'TextBoxHiddenID
        '
        Me.TextBoxHiddenID.Location = New System.Drawing.Point(45, 200)
        Me.TextBoxHiddenID.Name = "TextBoxHiddenID"
        Me.TextBoxHiddenID.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxHiddenID.TabIndex = 8
        '
        'ButtonViewDeleted
        '
        Me.ButtonViewDeleted.Font = New System.Drawing.Font("Cambria", 8.25!)
        Me.ButtonViewDeleted.Location = New System.Drawing.Point(12, 526)
        Me.ButtonViewDeleted.Name = "ButtonViewDeleted"
        Me.ButtonViewDeleted.Size = New System.Drawing.Size(535, 23)
        Me.ButtonViewDeleted.TabIndex = 9
        Me.ButtonViewDeleted.Text = "View Deleted"
        Me.ButtonViewDeleted.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.CornflowerBlue
        Me.ClientSize = New System.Drawing.Size(559, 572)
        Me.Controls.Add(Me.ButtonViewDeleted)
        Me.Controls.Add(Me.TextBoxHiddenID)
        Me.Controls.Add(Me.ButtonDelete)
        Me.Controls.Add(Me.ButtonUpdate)
        Me.Controls.Add(Me.ButtonRead)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.ButtonInsert)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.TextBoxEmail)
        Me.Controls.Add(Me.TextBoxAge)
        Me.Controls.Add(Me.TextBoxName)
        Me.Controls.Add(Me.ButtonConnect)
        Me.Name = "Form1"
        Me.Text = " "
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ButtonConnect As Button
    Friend WithEvents TextBoxName As TextBox
    Friend WithEvents TextBoxAge As TextBox
    Friend WithEvents TextBoxEmail As TextBox
    Friend WithEvents lblName As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents ButtonInsert As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents ButtonRead As Button
    Friend WithEvents ButtonUpdate As Button
    Friend WithEvents ButtonDelete As Button
    Friend WithEvents TextBoxHiddenID As TextBox
    Friend WithEvents ButtonViewDeleted As Button
End Class
