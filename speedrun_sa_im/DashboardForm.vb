' ==========================================
' FILENAME: /Forms/DashboardForm.vb
' PURPOSE: Main dashboard form with role-based navigation - MERGED VERSION
' AUTHOR: System
' DATE: 2025-10-17
' LAST UPDATED: 2025-10-25 - Merged student portal functionality
' Edited By Rovic
' For Future users please do not remove this header
' ==========================================
Imports Guna.UI2.WinForms

Public Class DashboardForm

    Private Sub btnMinimize_Click(sender As Object, e As EventArgs) Handles btnMinimize.Click
        Try
            Me.WindowState = FormWindowState.Minimized
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnMaximize_Click(sender As Object, e As EventArgs) Handles btnMaximize.Click
        Try
            If Me.WindowState = FormWindowState.Normal Then
                Me.WindowState = FormWindowState.Maximized
                btnMaximize.Text = "❐"
            Else
                Me.WindowState = FormWindowState.Normal
                btnMaximize.Text = "□"
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Dim confirm As DialogResult = MessageBox.Show("Are you sure you want to Exit?",
                                                 "Confirm Exit",
                                                 MessageBoxButtons.YesNo,
                                                 MessageBoxIcon.Question)
        If confirm = DialogResult.Yes Then
            ' Clear the content panel so no form stays loaded
            pnlContent.Controls.Clear()

            ' Make sure all open child forms are closed
            For Each f As Form In Application.OpenForms.OfType(Of Form).ToList()
                If f.Name <> "" Then
                    f.Close()
                End If
            Next

            ' Show the login form (only once)
            'Dim login As New LoginForm()
            'login.Show()'

            ' Finally hide this main form
            Me.Close()
        End If
    End Sub

    Private Sub btnStudents_Click(sender As Object, e As EventArgs) Handles btnStudents.Click

    End Sub
End Class