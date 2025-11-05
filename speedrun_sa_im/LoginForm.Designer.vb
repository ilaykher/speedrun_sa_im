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
        Dim CustomizableEdges11 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges12 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges9 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges10 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges1 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges2 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges3 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges4 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges5 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges6 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges7 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges8 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Guna2BorderlessLoginForm = New Guna.UI2.WinForms.Guna2BorderlessForm(components)
        HeaderPanel = New Guna.UI2.WinForms.Guna2Panel()
        Label1 = New Label()
        CardPanel = New Guna.UI2.WinForms.Guna2Panel()
        accLabel = New LinkLabel()
        btnExit = New Guna.UI2.WinForms.Guna2Button()
        btnLogin = New Guna.UI2.WinForms.Guna2Button()
        showPass = New Guna.UI2.WinForms.Guna2CheckBox()
        pwBox = New Guna.UI2.WinForms.Guna2TextBox()
        txtUsername = New Guna.UI2.WinForms.Guna2TextBox()
        Label3 = New Label()
        Label2 = New Label()
        HeaderPanel.SuspendLayout()
        CardPanel.SuspendLayout()
        SuspendLayout()
        ' 
        ' Guna2BorderlessLoginForm
        ' 
        Guna2BorderlessLoginForm.BorderRadius = 20
        Guna2BorderlessLoginForm.ContainerControl = Me
        Guna2BorderlessLoginForm.DockIndicatorTransparencyValue = 0.6R
        Guna2BorderlessLoginForm.TransparentWhileDrag = True
        ' 
        ' HeaderPanel
        ' 
        HeaderPanel.Controls.Add(Label1)
        HeaderPanel.CustomizableEdges = CustomizableEdges11
        HeaderPanel.Dock = DockStyle.Top
        HeaderPanel.FillColor = Color.FromArgb(CByte(43), CByte(122), CByte(75))
        HeaderPanel.Location = New Point(0, 0)
        HeaderPanel.Name = "HeaderPanel"
        HeaderPanel.ShadowDecoration.CustomizableEdges = CustomizableEdges12
        HeaderPanel.Size = New Size(483, 100)
        HeaderPanel.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Segoe UI", 20F, FontStyle.Bold)
        Label1.ForeColor = Color.WhiteSmoke
        Label1.Location = New Point(44, 30)
        Label1.Name = "Label1"
        Label1.Size = New Size(394, 37)
        Label1.TabIndex = 0
        Label1.Text = "Student Management System"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' CardPanel
        ' 
        CardPanel.BackColor = Color.Transparent
        CardPanel.BorderRadius = 20
        CardPanel.Controls.Add(accLabel)
        CardPanel.Controls.Add(btnExit)
        CardPanel.Controls.Add(btnLogin)
        CardPanel.Controls.Add(showPass)
        CardPanel.Controls.Add(pwBox)
        CardPanel.Controls.Add(txtUsername)
        CardPanel.Controls.Add(Label3)
        CardPanel.Controls.Add(Label2)
        CardPanel.CustomizableEdges = CustomizableEdges9
        CardPanel.FillColor = Color.LightGray
        CardPanel.Location = New Point(42, 122)
        CardPanel.Name = "CardPanel"
        CardPanel.ShadowDecoration.BorderRadius = 20
        CardPanel.ShadowDecoration.Color = Color.Gray
        CardPanel.ShadowDecoration.CustomizableEdges = CustomizableEdges10
        CardPanel.ShadowDecoration.Enabled = True
        CardPanel.Size = New Size(400, 451)
        CardPanel.TabIndex = 1
        ' 
        ' accLabel
        ' 
        accLabel.AutoSize = True
        accLabel.Font = New Font("Segoe UI Semibold", 8.25F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        accLabel.Location = New Point(196, 415)
        accLabel.Name = "accLabel"
        accLabel.Size = New Size(193, 13)
        accLabel.TabIndex = 7
        accLabel.TabStop = True
        accLabel.Text = "No account yet? Click here to sign up."
        ' 
        ' btnExit
        ' 
        btnExit.BorderRadius = 10
        btnExit.CustomizableEdges = CustomizableEdges1
        btnExit.DisabledState.BorderColor = Color.DarkGray
        btnExit.DisabledState.CustomBorderColor = Color.DarkGray
        btnExit.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnExit.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btnExit.FillColor = Color.FromArgb(CByte(214), CByte(69), CByte(69))
        btnExit.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnExit.ForeColor = Color.White
        btnExit.Location = New Point(42, 339)
        btnExit.Name = "btnExit"
        btnExit.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        btnExit.Size = New Size(320, 45)
        btnExit.TabIndex = 6
        btnExit.Text = "Exit"
        ' 
        ' btnLogin
        ' 
        btnLogin.BorderRadius = 10
        btnLogin.CustomizableEdges = CustomizableEdges3
        btnLogin.DisabledState.BorderColor = Color.DarkGray
        btnLogin.DisabledState.CustomBorderColor = Color.DarkGray
        btnLogin.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnLogin.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btnLogin.FillColor = Color.FromArgb(CByte(43), CByte(122), CByte(75))
        btnLogin.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnLogin.ForeColor = Color.White
        btnLogin.Location = New Point(42, 288)
        btnLogin.Name = "btnLogin"
        btnLogin.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        btnLogin.Size = New Size(320, 45)
        btnLogin.TabIndex = 5
        btnLogin.Text = "Sign In"
        ' 
        ' showPass
        ' 
        showPass.AutoSize = True
        showPass.CheckedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        showPass.CheckedState.BorderRadius = 0
        showPass.CheckedState.BorderThickness = 0
        showPass.CheckedState.FillColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        showPass.Location = New Point(42, 260)
        showPass.Name = "showPass"
        showPass.Size = New Size(108, 19)
        showPass.TabIndex = 4
        showPass.Text = "Show Password"
        showPass.UncheckedState.BorderColor = Color.FromArgb(CByte(125), CByte(137), CByte(149))
        showPass.UncheckedState.BorderRadius = 0
        showPass.UncheckedState.BorderThickness = 0
        showPass.UncheckedState.FillColor = Color.FromArgb(CByte(125), CByte(137), CByte(149))
        ' 
        ' pwBox
        ' 
        pwBox.BorderRadius = 8
        pwBox.CustomizableEdges = CustomizableEdges5
        pwBox.DefaultText = ""
        pwBox.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        pwBox.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        pwBox.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        pwBox.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        pwBox.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        pwBox.Font = New Font("Segoe UI", 9F)
        pwBox.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        pwBox.Location = New Point(42, 189)
        pwBox.MaxLength = 16
        pwBox.Name = "pwBox"
        pwBox.PasswordChar = "*"c
        pwBox.PlaceholderText = "Password"
        pwBox.SelectedText = ""
        pwBox.ShadowDecoration.CustomizableEdges = CustomizableEdges6
        pwBox.Size = New Size(320, 59)
        pwBox.TabIndex = 3
        ' 
        ' txtUsername
        ' 
        txtUsername.BorderRadius = 8
        txtUsername.CustomizableEdges = CustomizableEdges7
        txtUsername.DefaultText = ""
        txtUsername.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        txtUsername.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        txtUsername.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txtUsername.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txtUsername.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        txtUsername.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtUsername.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        txtUsername.Location = New Point(42, 117)
        txtUsername.MaxLength = 16
        txtUsername.Name = "txtUsername"
        txtUsername.PlaceholderText = "Username"
        txtUsername.SelectedText = ""
        txtUsername.ShadowDecoration.CustomizableEdges = CustomizableEdges8
        txtUsername.Size = New Size(320, 59)
        txtUsername.TabIndex = 2
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = SystemColors.ControlDarkDark
        Label3.Location = New Point(83, 80)
        Label3.Name = "Label3"
        Label3.Size = New Size(246, 21)
        Label3.TabIndex = 1
        Label3.Text = "Enter your credentials to continue."
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = SystemColors.ControlDarkDark
        Label2.Location = New Point(117, 23)
        Label2.Name = "Label2"
        Label2.Size = New Size(168, 45)
        Label2.TabIndex = 0
        Label2.Text = "Welcome!"
        ' 
        ' LoginForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.WhiteSmoke
        ClientSize = New Size(483, 597)
        Controls.Add(CardPanel)
        Controls.Add(HeaderPanel)
        FormBorderStyle = FormBorderStyle.None
        Name = "LoginForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Login"
        HeaderPanel.ResumeLayout(False)
        HeaderPanel.PerformLayout()
        CardPanel.ResumeLayout(False)
        CardPanel.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Guna2BorderlessLoginForm As Guna.UI2.WinForms.Guna2BorderlessForm
    Friend WithEvents HeaderPanel As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents CardPanel As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtUsername As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btnExit As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnLogin As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents showPass As Guna.UI2.WinForms.Guna2CheckBox
    Friend WithEvents pwBox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents accLabel As LinkLabel
End Class
