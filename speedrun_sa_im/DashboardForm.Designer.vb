' ==========================================
' FILENAME: /Forms/DashboardForm.Designer.vb
' PURPOSE: Designer file for DashboardForm with side navigation + Student Portal button
' AUTHOR: System
' DATE: 2025-10-14
' LAST UPDATED: 2025-10-25 - Merged with Student Portal button
' Edited By Rovic
' For Future users please do not remove this header
' ==========================================

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DashboardForm
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
        components = New ComponentModel.Container()
        Dim CustomizableEdges25 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges26 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges11 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges12 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges13 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges14 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges15 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges16 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges17 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges18 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges19 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges20 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges21 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges22 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges23 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges24 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges9 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges10 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges3 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges4 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges5 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges6 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges7 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges8 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges1 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges2 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(components)
        pnlSidebar = New Guna.UI2.WinForms.Guna2Panel()
        Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        btnLogout = New Guna.UI2.WinForms.Guna2Button()
        btnFaculty = New Guna.UI2.WinForms.Guna2Button()
        btnStudentMng = New Guna.UI2.WinForms.Guna2Button()
        btnCourses = New Guna.UI2.WinForms.Guna2Button()
        btnStudents = New Guna.UI2.WinForms.Guna2Button()
        pnlUserInfo = New Guna.UI2.WinForms.Guna2Panel()
        lblRole = New Label()
        lblWelcome = New Label()
        pnlTop = New Guna.UI2.WinForms.Guna2Panel()
        lblPageTitle = New Label()
        btnMinimize = New Guna.UI2.WinForms.Guna2Button()
        btnMaximize = New Guna.UI2.WinForms.Guna2Button()
        btnClose = New Guna.UI2.WinForms.Guna2Button()
        pnlContent = New Guna.UI2.WinForms.Guna2Panel()
        Guna2DragControl1 = New Guna.UI2.WinForms.Guna2DragControl(components)
        Guna2ShadowForm1 = New Guna.UI2.WinForms.Guna2ShadowForm(components)
        pnlSidebar.SuspendLayout()
        pnlUserInfo.SuspendLayout()
        pnlTop.SuspendLayout()
        SuspendLayout()
        ' 
        ' Guna2Elipse1
        ' 
        Guna2Elipse1.BorderRadius = 15
        Guna2Elipse1.TargetControl = Me
        ' 
        ' pnlSidebar
        ' 
        pnlSidebar.BackColor = Color.FromArgb(CByte(44), CByte(62), CByte(80))
        pnlSidebar.Controls.Add(Guna2Button1)
        pnlSidebar.Controls.Add(btnLogout)
        pnlSidebar.Controls.Add(btnFaculty)
        pnlSidebar.Controls.Add(btnStudentMng)
        pnlSidebar.Controls.Add(btnCourses)
        pnlSidebar.Controls.Add(btnStudents)
        pnlSidebar.Controls.Add(pnlUserInfo)
        pnlSidebar.CustomizableEdges = CustomizableEdges25
        pnlSidebar.Dock = DockStyle.Left
        pnlSidebar.Location = New Point(0, 0)
        pnlSidebar.Margin = New Padding(4)
        pnlSidebar.Name = "pnlSidebar"
        pnlSidebar.ShadowDecoration.CustomizableEdges = CustomizableEdges26
        pnlSidebar.Size = New Size(291, 808)
        pnlSidebar.TabIndex = 0
        ' 
        ' Guna2Button1
        ' 
        Guna2Button1.BorderRadius = 5
        Guna2Button1.CustomizableEdges = CustomizableEdges11
        Guna2Button1.DisabledState.BorderColor = Color.DarkGray
        Guna2Button1.DisabledState.CustomBorderColor = Color.DarkGray
        Guna2Button1.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        Guna2Button1.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        Guna2Button1.FillColor = Color.Transparent
        Guna2Button1.Font = New Font("Segoe UI", 10.5F)
        Guna2Button1.ForeColor = Color.White
        Guna2Button1.HoverState.FillColor = Color.FromArgb(CByte(26), CByte(188), CByte(156))
        Guna2Button1.HoverState.ForeColor = Color.White
        Guna2Button1.Location = New Point(10, 331)
        Guna2Button1.Margin = New Padding(4)
        Guna2Button1.Name = "Guna2Button1"
        Guna2Button1.ShadowDecoration.CustomizableEdges = CustomizableEdges12
        Guna2Button1.Size = New Size(269, 52)
        Guna2Button1.TabIndex = 11
        Guna2Button1.Text = "Attendance"
        Guna2Button1.TextAlign = HorizontalAlignment.Left
        ' 
        ' btnLogout
        ' 
        btnLogout.BorderRadius = 5
        btnLogout.CustomizableEdges = CustomizableEdges13
        btnLogout.DisabledState.BorderColor = Color.DarkGray
        btnLogout.DisabledState.CustomBorderColor = Color.DarkGray
        btnLogout.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnLogout.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btnLogout.Dock = DockStyle.Bottom
        btnLogout.FillColor = Color.FromArgb(CByte(231), CByte(76), CByte(60))
        btnLogout.Font = New Font("Segoe UI", 10.5F, FontStyle.Bold)
        btnLogout.ForeColor = Color.White
        btnLogout.HoverState.FillColor = Color.FromArgb(CByte(192), CByte(57), CByte(43))
        btnLogout.Location = New Point(0, 750)
        btnLogout.Margin = New Padding(4)
        btnLogout.Name = "btnLogout"
        btnLogout.ShadowDecoration.CustomizableEdges = CustomizableEdges14
        btnLogout.Size = New Size(291, 58)
        btnLogout.TabIndex = 10
        btnLogout.Text = "Logout"
        ' 
        ' btnFaculty
        ' 
        btnFaculty.BorderRadius = 5
        btnFaculty.CustomizableEdges = CustomizableEdges15
        btnFaculty.DisabledState.BorderColor = Color.DarkGray
        btnFaculty.DisabledState.CustomBorderColor = Color.DarkGray
        btnFaculty.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnFaculty.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btnFaculty.FillColor = Color.Transparent
        btnFaculty.Font = New Font("Segoe UI", 10.5F)
        btnFaculty.ForeColor = Color.White
        btnFaculty.HoverState.FillColor = Color.FromArgb(CByte(26), CByte(188), CByte(156))
        btnFaculty.HoverState.ForeColor = Color.White
        btnFaculty.Location = New Point(13, 391)
        btnFaculty.Margin = New Padding(4)
        btnFaculty.Name = "btnFaculty"
        btnFaculty.ShadowDecoration.CustomizableEdges = CustomizableEdges16
        btnFaculty.Size = New Size(269, 52)
        btnFaculty.TabIndex = 6
        btnFaculty.Text = "awdaw"
        btnFaculty.TextAlign = HorizontalAlignment.Left
        ' 
        ' btnStudentMng
        ' 
        btnStudentMng.BorderRadius = 5
        btnStudentMng.CustomizableEdges = CustomizableEdges17
        btnStudentMng.DisabledState.BorderColor = Color.DarkGray
        btnStudentMng.DisabledState.CustomBorderColor = Color.DarkGray
        btnStudentMng.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnStudentMng.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btnStudentMng.FillColor = Color.Transparent
        btnStudentMng.Font = New Font("Segoe UI", 10.5F)
        btnStudentMng.ForeColor = Color.White
        btnStudentMng.HoverState.FillColor = Color.FromArgb(CByte(26), CByte(188), CByte(156))
        btnStudentMng.HoverState.ForeColor = Color.White
        btnStudentMng.Location = New Point(10, 271)
        btnStudentMng.Margin = New Padding(4)
        btnStudentMng.Name = "btnStudentMng"
        btnStudentMng.ShadowDecoration.CustomizableEdges = CustomizableEdges18
        btnStudentMng.Size = New Size(269, 52)
        btnStudentMng.TabIndex = 5
        btnStudentMng.Text = "Student Management"
        btnStudentMng.TextAlign = HorizontalAlignment.Left
        ' 
        ' btnCourses
        ' 
        btnCourses.BorderRadius = 5
        btnCourses.CustomizableEdges = CustomizableEdges19
        btnCourses.DisabledState.BorderColor = Color.DarkGray
        btnCourses.DisabledState.CustomBorderColor = Color.DarkGray
        btnCourses.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnCourses.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btnCourses.FillColor = Color.Transparent
        btnCourses.Font = New Font("Segoe UI", 10.5F)
        btnCourses.ForeColor = Color.White
        btnCourses.HoverState.FillColor = Color.FromArgb(CByte(26), CByte(188), CByte(156))
        btnCourses.HoverState.ForeColor = Color.White
        btnCourses.Location = New Point(10, 214)
        btnCourses.Margin = New Padding(4)
        btnCourses.Name = "btnCourses"
        btnCourses.ShadowDecoration.CustomizableEdges = CustomizableEdges20
        btnCourses.Size = New Size(269, 52)
        btnCourses.TabIndex = 4
        btnCourses.Text = "Courses"
        btnCourses.TextAlign = HorizontalAlignment.Left
        ' 
        ' btnStudents
        ' 
        btnStudents.BorderRadius = 5
        btnStudents.CustomizableEdges = CustomizableEdges21
        btnStudents.DisabledState.BorderColor = Color.DarkGray
        btnStudents.DisabledState.CustomBorderColor = Color.DarkGray
        btnStudents.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnStudents.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btnStudents.FillColor = Color.Transparent
        btnStudents.Font = New Font("Segoe UI", 10.5F)
        btnStudents.ForeColor = Color.White
        btnStudents.HoverState.FillColor = Color.FromArgb(CByte(26), CByte(188), CByte(156))
        btnStudents.HoverState.ForeColor = Color.White
        btnStudents.Location = New Point(10, 152)
        btnStudents.Margin = New Padding(4)
        btnStudents.Name = "btnStudents"
        btnStudents.ShadowDecoration.CustomizableEdges = CustomizableEdges22
        btnStudents.Size = New Size(269, 52)
        btnStudents.TabIndex = 3
        btnStudents.Text = "Student Portal"
        btnStudents.TextAlign = HorizontalAlignment.Left
        ' 
        ' pnlUserInfo
        ' 
        pnlUserInfo.BackColor = Color.FromArgb(CByte(46), CByte(139), CByte(87))
        pnlUserInfo.Controls.Add(lblRole)
        pnlUserInfo.Controls.Add(lblWelcome)
        pnlUserInfo.CustomizableEdges = CustomizableEdges23
        pnlUserInfo.Dock = DockStyle.Top
        pnlUserInfo.Location = New Point(0, 0)
        pnlUserInfo.Margin = New Padding(4)
        pnlUserInfo.Name = "pnlUserInfo"
        pnlUserInfo.ShadowDecoration.CustomizableEdges = CustomizableEdges24
        pnlUserInfo.Size = New Size(291, 139)
        pnlUserInfo.TabIndex = 0
        ' 
        ' lblRole
        ' 
        lblRole.Dock = DockStyle.Bottom
        lblRole.Font = New Font("Segoe UI", 9F)
        lblRole.ForeColor = Color.White
        lblRole.Location = New Point(0, 105)
        lblRole.Margin = New Padding(4, 0, 4, 0)
        lblRole.Name = "lblRole"
        lblRole.Size = New Size(291, 34)
        lblRole.TabIndex = 1
        lblRole.Text = "Role: Admin"
        lblRole.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblWelcome
        ' 
        lblWelcome.Dock = DockStyle.Top
        lblWelcome.Font = New Font("Segoe UI", 11F, FontStyle.Bold)
        lblWelcome.ForeColor = Color.White
        lblWelcome.Location = New Point(0, 0)
        lblWelcome.Margin = New Padding(4, 0, 4, 0)
        lblWelcome.Name = "lblWelcome"
        lblWelcome.Size = New Size(291, 82)
        lblWelcome.TabIndex = 0
        lblWelcome.Text = "Welcome, User"
        lblWelcome.TextAlign = ContentAlignment.BottomCenter
        ' 
        ' pnlTop
        ' 
        pnlTop.BackColor = Color.White
        pnlTop.Controls.Add(lblPageTitle)
        pnlTop.Controls.Add(btnMinimize)
        pnlTop.Controls.Add(btnMaximize)
        pnlTop.Controls.Add(btnClose)
        pnlTop.CustomizableEdges = CustomizableEdges9
        pnlTop.Dock = DockStyle.Top
        pnlTop.Location = New Point(291, 0)
        pnlTop.Margin = New Padding(4)
        pnlTop.Name = "pnlTop"
        pnlTop.ShadowDecoration.CustomizableEdges = CustomizableEdges10
        pnlTop.ShadowDecoration.Depth = 5
        pnlTop.ShadowDecoration.Enabled = True
        pnlTop.Size = New Size(1109, 69)
        pnlTop.TabIndex = 1
        ' 
        ' lblPageTitle
        ' 
        lblPageTitle.AutoSize = True
        lblPageTitle.Font = New Font("Segoe UI", 14F, FontStyle.Bold)
        lblPageTitle.ForeColor = Color.FromArgb(CByte(44), CByte(62), CByte(80))
        lblPageTitle.Location = New Point(24, 20)
        lblPageTitle.Margin = New Padding(4, 0, 4, 0)
        lblPageTitle.Name = "lblPageTitle"
        lblPageTitle.Size = New Size(109, 25)
        lblPageTitle.TabIndex = 3
        lblPageTitle.Text = "Dashboard"
        ' 
        ' btnMinimize
        ' 
        btnMinimize.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnMinimize.BorderRadius = 5
        btnMinimize.CustomizableEdges = CustomizableEdges3
        btnMinimize.DisabledState.BorderColor = Color.DarkGray
        btnMinimize.DisabledState.CustomBorderColor = Color.DarkGray
        btnMinimize.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnMinimize.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btnMinimize.FillColor = Color.FromArgb(CByte(241), CByte(196), CByte(15))
        btnMinimize.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        btnMinimize.ForeColor = Color.White
        btnMinimize.Location = New Point(945, 17)
        btnMinimize.Margin = New Padding(4)
        btnMinimize.Name = "btnMinimize"
        btnMinimize.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        btnMinimize.Size = New Size(41, 40)
        btnMinimize.TabIndex = 2
        btnMinimize.Text = "-"
        ' 
        ' btnMaximize
        ' 
        btnMaximize.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnMaximize.BorderRadius = 5
        btnMaximize.CustomizableEdges = CustomizableEdges5
        btnMaximize.DisabledState.BorderColor = Color.DarkGray
        btnMaximize.DisabledState.CustomBorderColor = Color.DarkGray
        btnMaximize.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnMaximize.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btnMaximize.FillColor = Color.FromArgb(CByte(46), CByte(204), CByte(113))
        btnMaximize.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        btnMaximize.ForeColor = Color.White
        btnMaximize.Location = New Point(998, 17)
        btnMaximize.Margin = New Padding(4)
        btnMaximize.Name = "btnMaximize"
        btnMaximize.ShadowDecoration.CustomizableEdges = CustomizableEdges6
        btnMaximize.Size = New Size(41, 40)
        btnMaximize.TabIndex = 1
        btnMaximize.Text = "□"
        ' 
        ' btnClose
        ' 
        btnClose.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnClose.BorderRadius = 5
        btnClose.CustomizableEdges = CustomizableEdges7
        btnClose.DisabledState.BorderColor = Color.DarkGray
        btnClose.DisabledState.CustomBorderColor = Color.DarkGray
        btnClose.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnClose.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btnClose.FillColor = Color.FromArgb(CByte(231), CByte(76), CByte(60))
        btnClose.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        btnClose.ForeColor = Color.White
        btnClose.Location = New Point(1050, 17)
        btnClose.Margin = New Padding(4)
        btnClose.Name = "btnClose"
        btnClose.ShadowDecoration.CustomizableEdges = CustomizableEdges8
        btnClose.Size = New Size(41, 40)
        btnClose.TabIndex = 0
        btnClose.Text = "X"
        ' 
        ' pnlContent
        ' 
        pnlContent.BackColor = Color.FromArgb(CByte(244), CByte(246), CByte(247))
        pnlContent.CustomizableEdges = CustomizableEdges1
        pnlContent.Dock = DockStyle.Fill
        pnlContent.Location = New Point(291, 69)
        pnlContent.Margin = New Padding(4)
        pnlContent.Name = "pnlContent"
        pnlContent.Padding = New Padding(24, 23, 24, 23)
        pnlContent.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        pnlContent.Size = New Size(1109, 739)
        pnlContent.TabIndex = 2
        ' 
        ' Guna2DragControl1
        ' 
        Guna2DragControl1.DockIndicatorTransparencyValue = 0.6R
        Guna2DragControl1.TargetControl = pnlTop
        Guna2DragControl1.UseTransparentDrag = True
        ' 
        ' Guna2ShadowForm1
        ' 
        Guna2ShadowForm1.TargetForm = Me
        ' 
        ' DashboardForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1400, 808)
        Controls.Add(pnlContent)
        Controls.Add(pnlTop)
        Controls.Add(pnlSidebar)
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(4)
        Name = "DashboardForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Dashboard - Student Management System"
        pnlSidebar.ResumeLayout(False)
        pnlUserInfo.ResumeLayout(False)
        pnlTop.ResumeLayout(False)
        pnlTop.PerformLayout()
        ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents pnlSidebar As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents pnlUserInfo As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents lblWelcome As Label
    Friend WithEvents lblRole As Label
    Friend WithEvents btnStudents As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnCourses As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnStudentMng As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnFaculty As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnLogout As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents pnlTop As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents lblPageTitle As Label
    Friend WithEvents btnClose As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnMaximize As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnMinimize As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents pnlContent As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2DragControl1 As Guna.UI2.WinForms.Guna2DragControl
    Friend WithEvents Guna2ShadowForm1 As Guna.UI2.WinForms.Guna2ShadowForm
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
End Class