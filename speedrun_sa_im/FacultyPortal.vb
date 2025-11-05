' ==========================================
' FILENAME: /Forms/FacultyPortal.vb
' PURPOSE: Faculty portal main form (with hover effect and logout confirmation)
' DESIGN: Guna UI2 Framework
' ==========================================

Imports Guna.UI2.WinForms
Imports System.Windows.Forms

Public Class FacultyPortal

    ' === FORM LOAD ===
    Private Sub FacultyPortal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Rounded borderless design
        Me.Guna2BorderlessForm1.BorderRadius = 15
        Me.Guna2BorderlessForm1.ContainerControl = Me
        Me.Guna2BorderlessForm1.TransparentWhileDrag = True

        ' Apply Guna UI design
        ApplyDesign()

        ' Default welcome text
        lblWelcome.Text = "Welcome, Faculty!"
    End Sub


    ' === DESIGN SETTINGS ===
    Private Sub ApplyDesign()
        ' Keep header and logout button color as in the Designer
        pnlmain.FillColor = Color.WhiteSmoke

        ' Button design for attendance, student, and course
        Dim buttons() As Guna2Button = {btnAttendance, btnStudent, btncourse}
        For Each btn As Guna2Button In buttons
            btn.BorderRadius = 10
            btn.FillColor = Color.Transparent
            btn.ForeColor = Color.White
            btn.HoverState.FillColor = Color.FromArgb(26, 188, 156) ' Hover color
        Next

        ' Logout button (keep existing color, only set rounded edges)
        btnLogOut.BorderRadius = 10
        btnLogOut.HoverState.FillColor = Color.FromArgb(26, 188, 156) ' Same hover color for consistency
    End Sub


    ' === HEADER DRAG FEATURE ===
    Private isDragging As Boolean = False
    Private mouseX As Integer
    Private mouseY As Integer

    Private Sub pnlHeader_MouseDown(sender As Object, e As MouseEventArgs) Handles pnlHeader.MouseDown
        isDragging = True
        mouseX = Cursor.Position.X - Me.Left
        mouseY = Cursor.Position.Y - Me.Top
    End Sub

    Private Sub pnlHeader_MouseMove(sender As Object, e As MouseEventArgs) Handles pnlHeader.MouseMove
        If isDragging Then
            Me.Left = Cursor.Position.X - mouseX
            Me.Top = Cursor.Position.Y - mouseY
        End If
    End Sub

    Private Sub pnlHeader_MouseUp(sender As Object, e As MouseEventArgs) Handles pnlHeader.MouseUp
        isDragging = False
    End Sub


    ' === BUTTONS (READY TO CONNECT) ===
    Private Sub btnAttendance_Click(sender As Object, e As EventArgs) Handles btnAttendance.Click
        pnlmain.Controls.Clear()
        ' To do: connect attendance page later
    End Sub

    Private Sub btnStudent_Click(sender As Object, e As EventArgs) Handles btnStudent.Click
        pnlmain.Controls.Clear()
        ' To do: connect student page later
    End Sub

    Private Sub btncourse_Click(sender As Object, e As EventArgs) Handles btncourse.Click
        pnlmain.Controls.Clear()
        ' To do: connect course page later
    End Sub


    ' === LOGOUT FUNCTION ===
    Private Sub btnLogOut_Click(sender As Object, e As EventArgs) Handles btnLogOut.Click
        Dim result As DialogResult = MessageBox.Show(
            "Are you sure you want to log out?",
            "Confirm Logout",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question
        )

        If result = DialogResult.Yes Then
            ' Hide this form and show login form
            Me.Hide()
            LoginForm.Show()
        End If
    End Sub

End Class
