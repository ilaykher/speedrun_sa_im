<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class studentAttendance
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
        Dim CustomizableEdges1 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges2 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges3 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges4 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges5 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges6 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges7 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges8 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges9 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges10 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        btnStudentProfile = New Guna.UI2.WinForms.Guna2Button()
        btnPresent = New Guna.UI2.WinForms.Guna2Button()
        lblAttendance = New Guna.UI2.WinForms.Guna2HtmlLabel()
        lblStudIDFullName = New Guna.UI2.WinForms.Guna2HtmlLabel()
        lblYrSec = New Guna.UI2.WinForms.Guna2HtmlLabel()
        cmbCourseList = New Guna.UI2.WinForms.Guna2ComboBox()
        btnAttendanceHistory = New Guna.UI2.WinForms.Guna2Button()
        btnViewCourse = New Guna.UI2.WinForms.Guna2Button()
        SuspendLayout()
        ' 
        ' btnStudentProfile
        ' 
        btnStudentProfile.CustomizableEdges = CustomizableEdges1
        btnStudentProfile.DisabledState.BorderColor = Color.DarkGray
        btnStudentProfile.DisabledState.CustomBorderColor = Color.DarkGray
        btnStudentProfile.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnStudentProfile.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btnStudentProfile.Font = New Font("Segoe UI", 9F)
        btnStudentProfile.ForeColor = Color.White
        btnStudentProfile.Location = New Point(608, 12)
        btnStudentProfile.Name = "btnStudentProfile"
        btnStudentProfile.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        btnStudentProfile.Size = New Size(180, 45)
        btnStudentProfile.TabIndex = 0
        btnStudentProfile.Text = "Profile"
        ' 
        ' btnPresent
        ' 
        btnPresent.CustomizableEdges = CustomizableEdges3
        btnPresent.DisabledState.BorderColor = Color.DarkGray
        btnPresent.DisabledState.CustomBorderColor = Color.DarkGray
        btnPresent.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnPresent.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btnPresent.Font = New Font("Segoe UI", 9F)
        btnPresent.ForeColor = Color.White
        btnPresent.Location = New Point(294, 340)
        btnPresent.Name = "btnPresent"
        btnPresent.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        btnPresent.Size = New Size(180, 45)
        btnPresent.TabIndex = 1
        btnPresent.Text = "Present"
        ' 
        ' lblAttendance
        ' 
        lblAttendance.BackColor = Color.Transparent
        lblAttendance.Location = New Point(52, 45)
        lblAttendance.Name = "lblAttendance"
        lblAttendance.Size = New Size(64, 17)
        lblAttendance.TabIndex = 3
        lblAttendance.Text = "Attendance"
        ' 
        ' lblStudIDFullName
        ' 
        lblStudIDFullName.BackColor = Color.Transparent
        lblStudIDFullName.Location = New Point(52, 94)
        lblStudIDFullName.Name = "lblStudIDFullName"
        lblStudIDFullName.Size = New Size(129, 17)
        lblStudIDFullName.TabIndex = 4
        lblStudIDFullName.Text = "(Student ID : FullName )"
        ' 
        ' lblYrSec
        ' 
        lblYrSec.BackColor = Color.Transparent
        lblYrSec.Location = New Point(52, 117)
        lblYrSec.Name = "lblYrSec"
        lblYrSec.Size = New Size(99, 17)
        lblYrSec.TabIndex = 5
        lblYrSec.Text = "(Year and Section)"
        ' 
        ' cmbCourseList
        ' 
        cmbCourseList.BackColor = Color.Transparent
        cmbCourseList.CustomizableEdges = CustomizableEdges5
        cmbCourseList.DrawMode = DrawMode.OwnerDrawFixed
        cmbCourseList.DropDownStyle = ComboBoxStyle.DropDownList
        cmbCourseList.FocusedColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        cmbCourseList.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        cmbCourseList.Font = New Font("Segoe UI", 10F)
        cmbCourseList.ForeColor = Color.FromArgb(CByte(68), CByte(88), CByte(112))
        cmbCourseList.ItemHeight = 30
        cmbCourseList.Items.AddRange(New Object() {"--Select--", "Data Structure and Algorithm", "COmputer Programming", "Web Development"})
        cmbCourseList.Location = New Point(180, 221)
        cmbCourseList.Name = "cmbCourseList"
        cmbCourseList.ShadowDecoration.CustomizableEdges = CustomizableEdges6
        cmbCourseList.Size = New Size(404, 36)
        cmbCourseList.TabIndex = 6
        ' 
        ' btnAttendanceHistory
        ' 
        btnAttendanceHistory.CustomizableEdges = CustomizableEdges7
        btnAttendanceHistory.DisabledState.BorderColor = Color.DarkGray
        btnAttendanceHistory.DisabledState.CustomBorderColor = Color.DarkGray
        btnAttendanceHistory.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnAttendanceHistory.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btnAttendanceHistory.Font = New Font("Segoe UI", 9F)
        btnAttendanceHistory.ForeColor = Color.White
        btnAttendanceHistory.Location = New Point(180, 404)
        btnAttendanceHistory.Name = "btnAttendanceHistory"
        btnAttendanceHistory.ShadowDecoration.CustomizableEdges = CustomizableEdges8
        btnAttendanceHistory.Size = New Size(180, 45)
        btnAttendanceHistory.TabIndex = 7
        btnAttendanceHistory.Text = "Attendance History"
        ' 
        ' btnViewCourse
        ' 
        btnViewCourse.CustomizableEdges = CustomizableEdges9
        btnViewCourse.DisabledState.BorderColor = Color.DarkGray
        btnViewCourse.DisabledState.CustomBorderColor = Color.DarkGray
        btnViewCourse.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnViewCourse.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btnViewCourse.Font = New Font("Segoe UI", 9F)
        btnViewCourse.ForeColor = Color.White
        btnViewCourse.Location = New Point(404, 404)
        btnViewCourse.Name = "btnViewCourse"
        btnViewCourse.ShadowDecoration.CustomizableEdges = CustomizableEdges10
        btnViewCourse.Size = New Size(180, 45)
        btnViewCourse.TabIndex = 8
        btnViewCourse.Text = "View Course"
        ' 
        ' studentAttendance
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 585)
        Controls.Add(btnViewCourse)
        Controls.Add(btnAttendanceHistory)
        Controls.Add(cmbCourseList)
        Controls.Add(lblYrSec)
        Controls.Add(lblStudIDFullName)
        Controls.Add(lblAttendance)
        Controls.Add(btnPresent)
        Controls.Add(btnStudentProfile)
        Name = "studentAttendance"
        StartPosition = FormStartPosition.CenterScreen
        Text = "studentAttendance"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnStudentProfile As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnPresent As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents lblAttendance As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lblStudIDFullName As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lblYrSec As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents cmbCourseList As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents btnAttendanceHistory As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnViewCourse As Guna.UI2.WinForms.Guna2Button
End Class
