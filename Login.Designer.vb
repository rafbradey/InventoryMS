<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Label1 = New Label()
        Label2 = New Label()
        usernameINPUT = New TextBox()
        passwordINPUT = New TextBox()
        Label3 = New Label()
        loginBTN = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F)
        Label1.Location = New Point(229, 161)
        Label1.Name = "Label1"
        Label1.Size = New Size(108, 28)
        Label1.TabIndex = 0
        Label1.Text = "Username: "
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F)
        Label2.Location = New Point(229, 204)
        Label2.Name = "Label2"
        Label2.Size = New Size(102, 28)
        Label2.TabIndex = 1
        Label2.Text = "Password: "
        ' 
        ' usernameINPUT
        ' 
        usernameINPUT.Location = New Point(332, 162)
        usernameINPUT.Name = "usernameINPUT"
        usernameINPUT.Size = New Size(232, 27)
        usernameINPUT.TabIndex = 2
        ' 
        ' passwordINPUT
        ' 
        passwordINPUT.Location = New Point(332, 206)
        passwordINPUT.Name = "passwordINPUT"
        passwordINPUT.Size = New Size(232, 27)
        passwordINPUT.TabIndex = 3
        passwordINPUT.UseSystemPasswordChar = True
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 16F)
        Label3.Location = New Point(22, 25)
        Label3.Name = "Label3"
        Label3.Size = New Size(383, 37)
        Label3.TabIndex = 4
        Label3.Text = "Inventory Management System"
        ' 
        ' loginBTN
        ' 
        loginBTN.Location = New Point(383, 249)
        loginBTN.Name = "loginBTN"
        loginBTN.Size = New Size(119, 38)
        loginBTN.TabIndex = 5
        loginBTN.Text = "LOGIN"
        loginBTN.UseVisualStyleBackColor = True
        ' 
        ' Login
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(loginBTN)
        Controls.Add(Label3)
        Controls.Add(passwordINPUT)
        Controls.Add(usernameINPUT)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Login"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents usernameINPUT As TextBox
    Friend WithEvents passwordINPUT As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents loginBTN As Button
End Class
