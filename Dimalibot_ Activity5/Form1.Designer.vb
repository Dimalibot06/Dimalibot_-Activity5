<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Label1 = New Label()
        Label2 = New Label()
        txtfirstnumber = New TextBox()
        txtsecondnumber = New TextBox()
        btndivide = New Button()
        lblresult = New Label()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(28, 28)
        Label1.Name = "Label1"
        Label1.Size = New Size(72, 15)
        Label1.TabIndex = 1
        Label1.Text = "first number"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(28, 72)
        Label2.Name = "Label2"
        Label2.Size = New Size(90, 15)
        Label2.TabIndex = 1
        Label2.Text = "second number"
        ' 
        ' txtfirstnumber
        ' 
        txtfirstnumber.Location = New Point(28, 46)
        txtfirstnumber.Name = "txtfirstnumber"
        txtfirstnumber.Size = New Size(100, 23)
        txtfirstnumber.TabIndex = 3
        ' 
        ' txtsecondnumber
        ' 
        txtsecondnumber.Location = New Point(28, 90)
        txtsecondnumber.Name = "txtsecondnumber"
        txtsecondnumber.Size = New Size(100, 23)
        txtsecondnumber.TabIndex = 4
        ' 
        ' btndivide
        ' 
        btndivide.Location = New Point(28, 119)
        btndivide.Name = "btndivide"
        btndivide.Size = New Size(75, 23)
        btndivide.TabIndex = 5
        btndivide.Text = "divide"
        btndivide.UseVisualStyleBackColor = True
        ' 
        ' lblresult
        ' 
        lblresult.AutoSize = True
        lblresult.Location = New Point(28, 155)
        lblresult.Name = "lblresult"
        lblresult.Size = New Size(44, 15)
        lblresult.TabIndex = 6
        lblresult.Text = "answer"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(484, 450)
        Controls.Add(lblresult)
        Controls.Add(btndivide)
        Controls.Add(txtsecondnumber)
        Controls.Add(txtfirstnumber)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtfirstnumber As TextBox
    Friend WithEvents txtsecondnumber As TextBox
    Friend WithEvents btndivide As Button
    Friend WithEvents lblresult As Label
End Class
