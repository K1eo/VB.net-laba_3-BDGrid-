Public Class FAdd
    Private Sub Add2_Click(sender As Object, e As EventArgs) Handles Add2.Click
        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Remove2_Click(sender As Object, e As EventArgs) Handles Remove2.Click
        Me.DialogResult = DialogResult.Abort
        Me.Close()
    End Sub

    Private Sub FAdd_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.AcceptButton = Add2
        Me.CancelButton = Remove2
    End Sub
End Class