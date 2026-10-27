Public Class Form1
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click, Label5.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        lblNameCount.Text = "Characters: " & TextBox1.Text.Length
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label1_Click_1(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim student As New Student()

        student.FullName = TextBox1.Text
        student.RegistrationNumber = TextBox2.Text
        student.Programme = st2form.ComboBox1.Text

        If Not student.IsValid() Then
            If String.IsNullOrWhiteSpace(student.FullName) Then
                MessageBox.Show("Please enter your full name.")
            ElseIf String.IsNullOrWhiteSpace(student.RegistrationNumber) Then
                MessageBox.Show("Please enter your registration number.")
            Else
                MessageBox.Show("Please select your programme.")
            End If
            Exit Sub
        End If

        If String.IsNullOrWhiteSpace(ComboBox1.Text) Then
            MessageBox.Show("Please select your gender.")
            Exit Sub
        End If

        MessageBox.Show("Student information saved successfully.")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        TextBox1.Clear()
        TextBox2.Clear()
        ComboBox1.SelectedIndex = -1
        DateTimePicker1.Value = DateTime.Today

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

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles lblNameCount.Click

    End Sub
End Class
