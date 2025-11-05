Imports Guna.UI2.WinForms

Public Class LoginForm
    Private Sub showPass_CheckedChanged(sender As Object, e As EventArgs) Handles showPass.CheckedChanged
        pwBox.PasswordChar = If(showPass.Checked, ControlChars.NullChar, "*"c)
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

        ' Validate empty username
        If String.IsNullOrWhiteSpace(txtUsername.Text) Then
            MessageBox.Show("Please enter your username.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtUsername.Focus()
            Exit Sub
        End If

        ' Validate empty password
        If String.IsNullOrWhiteSpace(pwBox.Text) Then
            MessageBox.Show("Please enter your password.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            pwBox.Focus()
            Exit Sub
        End If

        ' Validate password length
        If pwBox.Text.Length < 8 Then
            MessageBox.Show("Password must be at least 8 characters long.", "Weak Password", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            pwBox.Focus()
            Exit Sub
        End If

        ' (TEMPORARY) Hardcoded check – We will replace this with Database soon
        ' ────────────────────────────────────────────────────────────────────
        Dim demoUsername As String = "admin"
        Dim demoPassword As String = "admin1234"

        If txtUsername.Text = demoUsername AndAlso pwBox.Text = demoPassword Then
            MessageBox.Show("Login Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ' TODO: Open your dashboard form here
            ' New DashboardForm.Show()
            ' Me.Hide()
        Else
            MessageBox.Show("No user found with those credentials.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub

    Private Sub accLabel_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles accLabel.LinkClicked
        Dim regForm As New AccountCreation()
        regForm.Show()
        Me.Hide()
    End Sub
End Class
