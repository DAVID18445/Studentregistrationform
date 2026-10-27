Public Class st2form
    Private Sub st2form_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If ComboBox1.Text = "" Then
            MessageBox.Show("Please select your Programme.")
            Exit Sub
        End If

        If ComboBox2.Text = "" Then
            MessageBox.Show("Please select your Year of Study.")
            Exit Sub
        End If

        If TextBox1.Text = "" Then
            MessageBox.Show("Please enter your Email.")
            Exit Sub
        End If

        MessageBox.Show("Academic information saved successfully.")

        Form1.Show()
        Me.Hide()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        ComboBox1.SelectedIndex = -1
        ComboBox2.SelectedIndex = -1
        TextBox1.Clear()

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim result As DialogResult

        result = MessageBox.Show(
        "Are you sure you want to exit?",
        "Confirm Exit",
        MessageBoxButtons.YesNo,
        MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.SelectedIndex <> -1 Then
            lblProgramme.Text = "Selected Programme: " & ComboBox1.Text
        Else
            lblProgramme.Text = "Selected Programme: None"
        End If
    End Sub
End Class