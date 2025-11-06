Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel
Imports MySql.Data.MySqlClient

Public Class AccountCreation



    Private Sub passwdBox_TextChanged(sender As Object, e As EventArgs) Handles passwdBox.TextChanged
        Dim showChar As Char = If(showPass.Checked, ControlChars.NullChar, "*"c)
        passwdBox.PasswordChar = showChar
    End Sub

    Private Sub confpasswdBox_TextChanged(sender As Object, e As EventArgs) Handles confpasswdBox.TextChanged
        Dim showChar As Char = If(showPass.Checked, ControlChars.NullChar, "*"c)
        confpasswdBox.PasswordChar = showChar
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

        ' Basic empty checks
        If labelLast.Text = "" Or labelLast.Text = "" Or labelFirst.Text = "" Or labelUse.Text = "" Or passwdBox.Text = "" Or confpasswdBox.Text = "" Then
            MessageBox.Show("Please fill in all fields.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        ' Password rule: Only letters and numbers
        If Not System.Text.RegularExpressions.Regex.IsMatch(passwdBox.Text, "^[A-Za-z0-9]+$") Then
            MessageBox.Show("Password can only contain letters and numbers.", "Invalid Password", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        ' Password length max 16
        If passwdBox.Text.Length > 16 Then
            MessageBox.Show("Password cannot exceed 16 characters.", "Invalid Password", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        ' Confirm password match
        If passwdBox.Text <> confpasswdBox.Text Then
            MessageBox.Show("Passwords do not match. Please re-enter.", "Mismatch", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim rnd As New Random()
        Dim randomDigits As Integer = rnd.Next(1000, 9999) ' 4 random digits
        Dim studentID As String = "2024" & randomDigits.ToString()

        ' === MYSQL CONNECTION ===
        Dim conString As String = "server=localhost;user id=root;password=;database=speedrun"
        Using con As New MySqlConnection(conString)
            con.Open()

            ' === CHECK DUPLICATE USERNAME ===
            Dim checkCmd As New MySqlCommand("SELECT COUNT(*) FROM students WHERE username = @username", con)
            checkCmd.Parameters.AddWithValue("@username", labelUse)
            Dim exists As Integer = Convert.ToInt32(checkCmd.ExecuteScalar())

            If exists > 0 Then
                MessageBox.Show("Username already exists. Please choose another.", "Duplicate Username", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            ' === INSERT STUDENT RECORD ===
            Dim query As String = "INSERT INTO students (student_id, username, password, last_name, first_name, middle_initials, suffix) " &
                                  "VALUES (@studentID, @username, @password, @last, @first, @middle, @suffix)"

            Using cmd As New MySqlCommand(query, con)
                ' Make sure to pass .Text, not the control itself
                cmd.Parameters.AddWithValue("@studentID", studentID)
                cmd.Parameters.AddWithValue("@username", labelUse.Text.Trim())
                cmd.Parameters.AddWithValue("@password", passwdBox.Text.Trim())
                cmd.Parameters.AddWithValue("@last", labelLast.Text.Trim())
                cmd.Parameters.AddWithValue("@first", labelFirst.Text.Trim())
                cmd.Parameters.AddWithValue("@middle", If(String.IsNullOrEmpty(labelMid.Text.Trim()), DBNull.Value, labelMid.Text.Trim()))
                cmd.Parameters.AddWithValue("@suffix", If(String.IsNullOrEmpty(suffixC.Text.Trim()), DBNull.Value, suffixC.Text.Trim()))

                Dim rows As Integer = cmd.ExecuteNonQuery()

                If rows > 0 Then
                    MessageBox.Show("Account Created Successfully!" & vbCrLf &
                        "Student ID: " & studentID, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Dim login As New LoginForm
                    login.Show()
                    Me.Close()
                Else
                    MessageBox.Show("Account creation failed. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End Using
        End Using
    End Sub

    Private Sub AccountCreation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' === GENERATE STUDENT ID (Starts with 2024 + 4 random digits) ===
        Dim rnd As New Random()
        Dim randomDigits As Integer = rnd.Next(1000, 9999)
        Dim studentID As String = "2024" & randomDigits.ToString()
        txtID.Text = studentID ' display generated ID in the textbox

        ' === SUFFIX OPTIONS ===
        suffixC.Items.Clear()
        suffixC.Items.AddRange(New Object() {
            "",
            "JR",
            "SR",
            "II",
            "III",
            "IV",
            "V"
        })
    End Sub

    Private Sub labelLast_TextChanged(sender As Object, e As EventArgs) Handles labelLast.TextChanged
        labelLast.Text = labelLast.Text.ToUpper()
        labelLast.SelectionStart = labelLast.Text.Length
    End Sub

    Private Sub labelFirst_TextChanged(sender As Object, e As EventArgs) Handles labelFirst.TextChanged
        labelFirst.Text = labelFirst.Text.ToUpper()
        labelFirst.SelectionStart = labelFirst.Text.Length
    End Sub

    Private Sub labelMid_TextChanged(sender As Object, e As EventArgs) Handles labelMid.TextChanged
        labelMid.Text = labelMid.Text.ToUpper()
        labelMid.SelectionStart = labelMid.Text.Length
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Dim login As New LoginForm()
        login.Show()
        Me.Close()

    End Sub

    Private Sub showPass_CheckedChanged(sender As Object, e As EventArgs) Handles showPass.CheckedChanged
        If showPass.Checked Then
            passwdBox.PasswordChar = ControlChars.NullChar
            confpasswdBox.PasswordChar = ControlChars.NullChar
        Else
            passwdBox.PasswordChar = "*"c
            confpasswdBox.PasswordChar = "*"c
        End If
    End Sub

End Class
