<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoginForm
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
        components = New ComponentModel.Container()
        Guna2BorderlessLoginForm = New Guna.UI2.WinForms.Guna2BorderlessForm(components)
        SuspendLayout()
        ' 
        ' Guna2BorderlessLoginForm
        ' 
        Guna2BorderlessLoginForm.BorderRadius = 8
        Guna2BorderlessLoginForm.ContainerControl = Me
        Guna2BorderlessLoginForm.DockIndicatorTransparencyValue = 0.6R
        Guna2BorderlessLoginForm.TransparentWhileDrag = True
        ' 
        ' LoginForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(483, 512)
        FormBorderStyle = FormBorderStyle.None
        Name = "LoginForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Login"
        ResumeLayout(False)
    End Sub

    Friend WithEvents Guna2BorderlessLoginForm As Guna.UI2.WinForms.Guna2BorderlessForm
End Class
