Imports Guna.UI2.WinForms

Public Class StudentAttendance

    ' === VARIABLES ===
    Private studentID As String
    Private studentName As String
    Private yearSection As String

    ' === FORM LOAD ===
    Private Sub StudentAttendance_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Apply rounded corners
        Dim borderRadius As New Guna2Elipse()
        borderRadius.TargetControl = Me
        borderRadius.BorderRadius = 20

        ' Load subjects into ComboBox
        LoadSubjects()

        ' Display student info if logged in
        DisplayStudentInfo()

        ' Add hover effects to all buttons
        AddHoverEffect(btnpresent)
        AddHoverEffect(btnstudentportal)
        AddHoverEffect(btnlogout)
    End Sub

    ' === SHOW STUDENT INFO (CALLED WHEN LOGGED IN) ===
    Public Sub SetStudentInfo(id As String, name As String, yrSec As String)
        studentID = id
        studentName = name
        yearSection = yrSec
    End Sub

    Private Sub DisplayStudentInfo()
        ' If logged in, show details
        If Not String.IsNullOrEmpty(studentID) AndAlso Not String.IsNullOrEmpty(studentName) AndAlso Not String.IsNullOrEmpty(yearSection) Then
            lblstudent.Text = studentID
            lblname.Text = studentName
            lblYearSection.Text = yearSection
        Else
            lblstudent.Text = "N/A"
            lblname.Text = "N/A"
            lblYearSection.Text = "N/A"
        End If
    End Sub

    ' === LOAD SUBJECTS ===
    Private Sub LoadSubjects()
        cmbsubdesc.Items.Clear()
        cmbsubdesc.Items.AddRange({
            "Computer Programming 1",
            "Database Management System",
            "Software Engineering",
            "Web Development"
        })
        cmbsubdesc.SelectedIndex = -1
    End Sub

    ' === VALIDATION ===
    Private Function ValidateFields() As Boolean
        If String.IsNullOrWhiteSpace(lblstudent.Text) OrElse lblstudent.Text = "N/A" Then
            MessageBox.Show("Student ID is missing.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If
        If String.IsNullOrWhiteSpace(lblname.Text) OrElse lblname.Text = "N/A" Then
            MessageBox.Show("Student name is missing.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If
        If String.IsNullOrWhiteSpace(lblYearSection.Text) OrElse lblYearSection.Text = "N/A" Then
            MessageBox.Show("Year and Section is missing.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If
        If cmbsubdesc.SelectedIndex = -1 Then
            MessageBox.Show("Please select a subject.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If
        Return True
    End Function

    ' === BUTTON: MARK PRESENT ===
    Private Sub btnpresent_Click(sender As Object, e As EventArgs) Handles btnpresent.Click
        If Not ValidateFields() Then Exit Sub

        MessageBox.Show("Attendance recorded successfully!", "Attendance", MessageBoxButtons.OK, MessageBoxIcon.Information)
        cmbsubdesc.SelectedIndex = -1
    End Sub

#Region "Student Portal (if needed)"
    'Private Sub btnstudentportal_Click(sender As Object, e As EventArgs) Handles btnstudentportal.Click
    '    Dim portalForm As New StudentPortalForm()
    '    portalForm.Show()
    '    Me.Hide()
    'End Sub
#End Region

    ' === BUTTON: LOG OUT ===
    Private Sub btnlogout_Click(sender As Object, e As EventArgs) Handles btnlogout.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to log out?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Dim loginForm As New LoginForm()
            loginForm.Show()
            Me.Close()
        End If
    End Sub

    ' === HOVER EFFECTS FOR BUTTONS ===
    Private Sub AddHoverEffect(btn As Guna2Button)
        Dim defaultColor As Color = btn.FillColor
        Dim hoverColor As Color = Color.FromArgb(26, 188, 156)

        AddHandler btn.MouseEnter, Sub()
                                       btn.FillColor = hoverColor
                                   End Sub

        AddHandler btn.MouseLeave, Sub()
                                       btn.FillColor = defaultColor
                                   End Sub
    End Sub

End Class
