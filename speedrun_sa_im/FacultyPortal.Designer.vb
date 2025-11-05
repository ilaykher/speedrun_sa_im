Imports Guna.UI2.WinForms

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FacultyPortal
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
        Dim CustomizableEdges7 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Suite.CustomizableEdges()
        Dim CustomizableEdges8 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Suite.CustomizableEdges()
        Dim CustomizableEdges1 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Suite.CustomizableEdges()
        Dim CustomizableEdges2 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Suite.CustomizableEdges()
        Dim CustomizableEdges3 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Suite.CustomizableEdges()
        Dim CustomizableEdges4 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Suite.CustomizableEdges()
        Dim CustomizableEdges5 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Suite.CustomizableEdges()
        Dim CustomizableEdges6 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Suite.CustomizableEdges()
        Dim CustomizableEdges23 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Suite.CustomizableEdges()
        Dim CustomizableEdges24 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Suite.CustomizableEdges()
        Dim CustomizableEdges11 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Suite.CustomizableEdges()
        Dim CustomizableEdges12 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Suite.CustomizableEdges()
        Dim CustomizableEdges13 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Suite.CustomizableEdges()
        Dim CustomizableEdges14 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Suite.CustomizableEdges()
        Dim CustomizableEdges15 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Suite.CustomizableEdges()
        Dim CustomizableEdges16 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Suite.CustomizableEdges()
        Dim CustomizableEdges17 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Suite.CustomizableEdges()
        Dim CustomizableEdges18 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Suite.CustomizableEdges()
        Dim CustomizableEdges19 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Suite.CustomizableEdges()
        Dim CustomizableEdges20 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Suite.CustomizableEdges()
        Dim CustomizableEdges21 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Suite.CustomizableEdges()
        Dim CustomizableEdges22 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Suite.CustomizableEdges()
        Dim CustomizableEdges9 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Suite.CustomizableEdges()
        Dim CustomizableEdges10 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Suite.CustomizableEdges()
        Guna2BorderlessForm1 = New Guna2BorderlessForm(components)
        Guna2DragControl1 = New Guna2DragControl(components)
        pnlHeader = New Guna2Panel()
        lbHeader = New Guna2HtmlLabel()
        Guna2ControlBox3 = New Guna2ControlBox()
        Guna2ControlBox1 = New Guna2ControlBox()
        Guna2ControlBox2 = New Guna2ControlBox()
        Guna2BorderlessForm2 = New Guna2BorderlessForm(components)
        GpnlSideBar = New Guna2CustomGradientPanel()
        btncourse = New Guna2Button()
        btnStudent = New Guna2Button()
        Guna2Panel1 = New Guna2Panel()
        lblWelcome = New Guna2HtmlLabel()
        btnLogOut = New Guna2Button()
        btnStudentManagement = New Guna2Button()
        btnAttendance = New Guna2Button()
        pnlmain = New Guna2Panel()
        Guna2ShadowPanel1 = New Guna2ShadowPanel()
        pnlHeader.SuspendLayout()
        GpnlSideBar.SuspendLayout()
        Guna2Panel1.SuspendLayout()
        Guna2ShadowPanel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Guna2BorderlessForm1
        ' 
        Guna2BorderlessForm1.ContainerControl = Me
        Guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6R
        Guna2BorderlessForm1.TransparentWhileDrag = True
        ' 
        ' Guna2DragControl1
        ' 
        Guna2DragControl1.DockIndicatorTransparencyValue = 0.6R
        Guna2DragControl1.TargetControl = pnlHeader
        Guna2DragControl1.UseTransparentDrag = True
        ' 
        ' pnlHeader
        ' 
        pnlHeader.BackColor = Color.White
        pnlHeader.Controls.Add(lbHeader)
        pnlHeader.Controls.Add(Guna2ControlBox3)
        pnlHeader.Controls.Add(Guna2ControlBox1)
        pnlHeader.Controls.Add(Guna2ControlBox2)
        pnlHeader.CustomizableEdges = CustomizableEdges7
        pnlHeader.Dock = DockStyle.Top
        pnlHeader.Location = New Point(268, 0)
        pnlHeader.Name = "pnlHeader"
        pnlHeader.ShadowDecoration.CustomizableEdges = CustomizableEdges8
        pnlHeader.Size = New Size(932, 103)
        pnlHeader.TabIndex = 4
        ' 
        ' lbHeader
        ' 
        lbHeader.BackColor = Color.Transparent
        lbHeader.Font = New Font("Segoe UI Variable Text", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lbHeader.ForeColor = Color.Black
        lbHeader.Location = New Point(16, 29)
        lbHeader.Name = "lbHeader"
        lbHeader.Size = New Size(209, 45)
        lbHeader.TabIndex = 0
        lbHeader.Text = "Faculty Portal"
        ' 
        ' Guna2ControlBox3
        ' 
        Guna2ControlBox3.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Guna2ControlBox3.ControlBoxType = Enums.ControlBoxType.MinimizeBox
        Guna2ControlBox3.CustomizableEdges = CustomizableEdges1
        Guna2ControlBox3.FillColor = Color.White
        Guna2ControlBox3.IconColor = Color.DimGray
        Guna2ControlBox3.Location = New Point(830, 3)
        Guna2ControlBox3.Name = "Guna2ControlBox3"
        Guna2ControlBox3.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        Guna2ControlBox3.Size = New Size(30, 23)
        Guna2ControlBox3.TabIndex = 2
        ' 
        ' Guna2ControlBox1
        ' 
        Guna2ControlBox1.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Guna2ControlBox1.CustomizableEdges = CustomizableEdges3
        Guna2ControlBox1.FillColor = Color.White
        Guna2ControlBox1.IconColor = Color.DimGray
        Guna2ControlBox1.Location = New Point(902, 3)
        Guna2ControlBox1.Name = "Guna2ControlBox1"
        Guna2ControlBox1.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        Guna2ControlBox1.Size = New Size(30, 23)
        Guna2ControlBox1.TabIndex = 0
        ' 
        ' Guna2ControlBox2
        ' 
        Guna2ControlBox2.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Guna2ControlBox2.ControlBoxType = Enums.ControlBoxType.MaximizeBox
        Guna2ControlBox2.CustomizableEdges = CustomizableEdges5
        Guna2ControlBox2.FillColor = Color.White
        Guna2ControlBox2.IconColor = Color.DimGray
        Guna2ControlBox2.Location = New Point(866, 3)
        Guna2ControlBox2.Name = "Guna2ControlBox2"
        Guna2ControlBox2.ShadowDecoration.CustomizableEdges = CustomizableEdges6
        Guna2ControlBox2.Size = New Size(30, 23)
        Guna2ControlBox2.TabIndex = 1
        ' 
        ' Guna2BorderlessForm2
        ' 
        Guna2BorderlessForm2.ContainerControl = Me
        Guna2BorderlessForm2.DockIndicatorTransparencyValue = 0.6R
        Guna2BorderlessForm2.TransparentWhileDrag = True
        ' 
        ' GpnlSideBar
        ' 
        GpnlSideBar.BackColor = Color.Transparent
        GpnlSideBar.Controls.Add(btncourse)
        GpnlSideBar.Controls.Add(btnStudent)
        GpnlSideBar.Controls.Add(Guna2Panel1)
        GpnlSideBar.Controls.Add(btnLogOut)
        GpnlSideBar.Controls.Add(btnStudentManagement)
        GpnlSideBar.Controls.Add(btnAttendance)
        GpnlSideBar.CustomizableEdges = CustomizableEdges23
        GpnlSideBar.Dock = DockStyle.Left
        GpnlSideBar.FillColor = Color.FromArgb(CByte(44), CByte(62), CByte(80))
        GpnlSideBar.FillColor2 = Color.FromArgb(CByte(44), CByte(62), CByte(80))
        GpnlSideBar.FillColor3 = Color.FromArgb(CByte(44), CByte(62), CByte(80))
        GpnlSideBar.FillColor4 = Color.FromArgb(CByte(44), CByte(62), CByte(80))
        GpnlSideBar.ForeColor = Color.FromArgb(CByte(44), CByte(62), CByte(80))
        GpnlSideBar.Location = New Point(0, 0)
        GpnlSideBar.Name = "GpnlSideBar"
        GpnlSideBar.ShadowDecoration.CustomizableEdges = CustomizableEdges24
        GpnlSideBar.Size = New Size(268, 800)
        GpnlSideBar.TabIndex = 0
        ' 
        ' btncourse
        ' 
        btncourse.BorderRadius = 5
        btncourse.CustomizableEdges = CustomizableEdges11
        btncourse.DisabledState.BorderColor = Color.DarkGray
        btncourse.DisabledState.CustomBorderColor = Color.DarkGray
        btncourse.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btncourse.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btncourse.FillColor = Color.Transparent
        btncourse.Font = New Font("Segoe UI Variable Display Semib", 12F, FontStyle.Bold)
        btncourse.ForeColor = Color.White
        btncourse.Location = New Point(10, 264)
        btncourse.Name = "btncourse"
        btncourse.ShadowDecoration.CustomizableEdges = CustomizableEdges12
        btncourse.Size = New Size(252, 45)
        btncourse.TabIndex = 7
        btncourse.Text = "Course"
        btncourse.TextAlign = HorizontalAlignment.Left
        ' 
        ' btnStudent
        ' 
        btnStudent.BorderRadius = 5
        btnStudent.CustomizableEdges = CustomizableEdges13
        btnStudent.DisabledState.BorderColor = Color.DarkGray
        btnStudent.DisabledState.CustomBorderColor = Color.DarkGray
        btnStudent.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnStudent.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btnStudent.FillColor = Color.Transparent
        btnStudent.Font = New Font("Segoe UI Variable Display Semib", 12F, FontStyle.Bold)
        btnStudent.ForeColor = Color.White
        btnStudent.Location = New Point(10, 213)
        btnStudent.Name = "btnStudent"
        btnStudent.ShadowDecoration.CustomizableEdges = CustomizableEdges14
        btnStudent.Size = New Size(252, 45)
        btnStudent.TabIndex = 6
        btnStudent.Text = "Student Management"
        btnStudent.TextAlign = HorizontalAlignment.Left
        ' 
        ' Guna2Panel1
        ' 
        Guna2Panel1.BackColor = Color.SeaGreen
        Guna2Panel1.Controls.Add(lblWelcome)
        Guna2Panel1.CustomizableEdges = CustomizableEdges15
        Guna2Panel1.Location = New Point(0, 0)
        Guna2Panel1.Name = "Guna2Panel1"
        Guna2Panel1.ShadowDecoration.CustomizableEdges = CustomizableEdges16
        Guna2Panel1.Size = New Size(268, 103)
        Guna2Panel1.TabIndex = 0
        ' 
        ' lblWelcome
        ' 
        lblWelcome.BackColor = Color.Transparent
        lblWelcome.Font = New Font("Segoe UI Variable Text", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblWelcome.ForeColor = Color.White
        lblWelcome.Location = New Point(12, 40)
        lblWelcome.Name = "lblWelcome"
        lblWelcome.Size = New Size(174, 34)
        lblWelcome.TabIndex = 0
        lblWelcome.Text = "Welcome, User"
        ' 
        ' btnLogOut
        ' 
        btnLogOut.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        btnLogOut.BorderRadius = 5
        btnLogOut.CustomizableEdges = CustomizableEdges17
        btnLogOut.DisabledState.BorderColor = Color.DarkGray
        btnLogOut.DisabledState.CustomBorderColor = Color.DarkGray
        btnLogOut.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnLogOut.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btnLogOut.FillColor = Color.FromArgb(CByte(231), CByte(76), CByte(60))
        btnLogOut.Font = New Font("Segoe UI Variable Display Semib", 12F, FontStyle.Bold)
        btnLogOut.ForeColor = Color.White
        btnLogOut.Location = New Point(3, 752)
        btnLogOut.Name = "btnLogOut"
        btnLogOut.ShadowDecoration.CustomizableEdges = CustomizableEdges18
        btnLogOut.Size = New Size(259, 45)
        btnLogOut.TabIndex = 4
        btnLogOut.Text = "Log out"
        btnLogOut.TextAlign = HorizontalAlignment.Left
        ' 
        ' btnStudentManagement
        ' 
        btnStudentManagement.CustomizableEdges = CustomizableEdges19
        btnStudentManagement.Font = New Font("Segoe UI", 9F)
        btnStudentManagement.ForeColor = Color.White
        btnStudentManagement.Location = New Point(0, 0)
        btnStudentManagement.Name = "btnStudentManagement"
        btnStudentManagement.ShadowDecoration.CustomizableEdges = CustomizableEdges20
        btnStudentManagement.Size = New Size(180, 45)
        btnStudentManagement.TabIndex = 5
        ' 
        ' btnAttendance
        ' 
        btnAttendance.BorderRadius = 5
        btnAttendance.CustomizableEdges = CustomizableEdges21
        btnAttendance.DisabledState.BorderColor = Color.DarkGray
        btnAttendance.DisabledState.CustomBorderColor = Color.DarkGray
        btnAttendance.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnAttendance.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btnAttendance.FillColor = Color.Transparent
        btnAttendance.Font = New Font("Segoe UI Variable Display Semib", 12F, FontStyle.Bold)
        btnAttendance.ForeColor = Color.White
        btnAttendance.Location = New Point(10, 162)
        btnAttendance.Name = "btnAttendance"
        btnAttendance.ShadowDecoration.CustomizableEdges = CustomizableEdges22
        btnAttendance.Size = New Size(252, 45)
        btnAttendance.TabIndex = 0
        btnAttendance.Text = "Attendance"
        btnAttendance.TextAlign = HorizontalAlignment.Left
        ' 
        ' pnlmain
        ' 
        pnlmain.CustomizableEdges = CustomizableEdges9
        pnlmain.Dock = DockStyle.Fill
        pnlmain.Location = New Point(268, 0)
        pnlmain.Name = "pnlmain"
        pnlmain.ShadowDecoration.CustomizableEdges = CustomizableEdges10
        pnlmain.Size = New Size(932, 800)
        pnlmain.TabIndex = 2
        ' 
        ' Guna2ShadowPanel1
        ' 
        Guna2ShadowPanel1.BackColor = Color.Transparent
        Guna2ShadowPanel1.BackgroundImageLayout = ImageLayout.None
        Guna2ShadowPanel1.Controls.Add(pnlHeader)
        Guna2ShadowPanel1.Controls.Add(pnlmain)
        Guna2ShadowPanel1.Controls.Add(GpnlSideBar)
        Guna2ShadowPanel1.Dock = DockStyle.Fill
        Guna2ShadowPanel1.FillColor = Color.White
        Guna2ShadowPanel1.Location = New Point(0, 0)
        Guna2ShadowPanel1.Margin = New Padding(0)
        Guna2ShadowPanel1.Name = "Guna2ShadowPanel1"
        Guna2ShadowPanel1.ShadowColor = Color.Black
        Guna2ShadowPanel1.Size = New Size(1200, 800)
        Guna2ShadowPanel1.TabIndex = 3
        ' 
        ' FacultyPortal
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1200, 800)
        Controls.Add(Guna2ShadowPanel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "FacultyPortal"
        Text = "FacultyPortal"
        pnlHeader.ResumeLayout(False)
        pnlHeader.PerformLayout()
        GpnlSideBar.ResumeLayout(False)
        Guna2Panel1.ResumeLayout(False)
        Guna2Panel1.PerformLayout()
        Guna2ShadowPanel1.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents Guna2BorderlessForm1 As Guna.UI2.WinForms.Guna2BorderlessForm
    Friend WithEvents Guna2DragControl1 As Guna.UI2.WinForms.Guna2DragControl
    Friend WithEvents Guna2BorderlessForm2 As Guna.UI2.WinForms.Guna2BorderlessForm
    Friend WithEvents Guna2ShadowPanel1 As Guna.UI2.WinForms.Guna2ShadowPanel
    Friend WithEvents pnlHeader As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents lbHeader As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2ControlBox3 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents Guna2ControlBox1 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents Guna2ControlBox2 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents pnlmain As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents GpnlSideBar As Guna.UI2.WinForms.Guna2CustomGradientPanel
    Friend WithEvents btnLogOut As Guna.UI2.WinForms.Guna2Button
    Private btnStudentManagement As Guna2Button
    Friend WithEvents Guna2Button4 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Button3 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Button2 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnAttendance As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents btnStudent As Guna2Button
    Friend WithEvents lblWelcome As Guna2HtmlLabel
    Friend WithEvents btncourse As Guna2Button
End Class
