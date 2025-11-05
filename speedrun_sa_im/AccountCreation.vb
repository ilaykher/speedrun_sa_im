Public Class AccountCreation
    Private Sub AccountCreation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtID.Text = GenerateStudentID()
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
    Private Function GenerateStudentID() As String
        Dim rnd As New Random()
        Dim digits As Integer = rnd.Next(10000000, 99999999) ' 8 digits
        Dim letter As Char = Chr(rnd.Next(65, 91)) ' A-Z ASCII range
        Return $"{digits}-{letter}"
    End Function

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

        ' (For now) Show success — we will connect to database next
        MessageBox.Show("Account Created Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

        ' Return to Login Form
        Dim login As New LoginForm
        login.Show()
        Me.Close()
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
