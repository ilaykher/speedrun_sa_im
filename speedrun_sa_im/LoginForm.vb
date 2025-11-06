Imports Guna.UI2.WinForms
Imports MySql.Data.MySqlClient

Public Class LoginForm
    Dim connectionString As String = "server=localhost;userid=root;password=;database=speedrun"

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

        ' Actual Database Login
        Using conn As New MySqlConnection(connectionString)
            Try
                conn.Open()
                Dim query As String = "SELECT user_id, username, role FROM users WHERE username=@username AND password=@password LIMIT 1"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@username", txtUsername.Text.Trim())
                    cmd.Parameters.AddWithValue("@password", pwBox.Text.Trim())

                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        If reader.Read() Then
                            Dim role As String = reader("role").ToString()

                            Select Case role.ToLower()
                                Case "admin"
                                    MessageBox.Show("Welcome Admin!", "Login Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                    Dim adminForm As New DashboardForm
                                    adminForm.Show()
                                    Me.Hide()

                                Case "faculty"
                                    MessageBox.Show("Welcome Faculty!", "Login Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                    Dim facultyForm As New FacultyPortal
                                    facultyForm.Show()
                                    Me.Hide()

                                Case "student"
                                    MessageBox.Show("Welcome Student!", "Login Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                    Dim studentForm As New StudentAttendance
                                    studentForm.Show()
                                    Me.Hide()

                                Case Else
                                    MessageBox.Show("Unknown role assigned.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            End Select
                        Else
                            MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If
                    End Using
                End Using

            Catch ex As Exception
                MessageBox.Show("Database Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                conn.Close()
            End Try
        End Using
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub

    Private Sub accLabel_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles accLabel.LinkClicked
        Dim regForm As New AccountCreation()
        regForm.Show()
        Me.Hide()
    End Sub

    Private Sub txtUsername_TextChanged(sender As Object, e As EventArgs) Handles txtUsername.TextChanged

    End Sub

    Private Sub pwBox_TextChanged(sender As Object, e As EventArgs) Handles pwBox.TextChanged

    End Sub

    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
