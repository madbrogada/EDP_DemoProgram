Public Class Form5


    Private Sub TextInput_LostFocus(sender As Object, e As EventArgs) Handles TextInput.LostFocus
        With Me
            .TextInput.Text = "Text Box is inactive"
            .CheckBox1.Text = "Hungry"
        End With
    End Sub

    Private Sub TextInput_GotFocus(sender As Object, e As EventArgs) Handles TextInput.GotFocus
        Me.TextInput.Text = "Text Box is Active!"
        Me.CheckBox1.Text = "Happy"
    End Sub


End Class