Public Class Form1
    Public Sub form_center(ByVal frm As Form, Optional ByVal parent As Form = Nothing)

        Dim x As Integer
        Dim y As Integer
        Dim r As Rectangle

        If Not parent Is Nothing Then
            r = parent.ClientRectangle
            x = r.Width - frm.Width + parent.Left
            y = r.Height - frm.Height + parent.Top
        Else
            r = Screen.PrimaryScreen.WorkingArea
            x = r.Width - frm.Width
            y = r.Height - frm.Height
        End If

        x = CInt(x / 2)
        y = CInt(y / 2)

        frm.StartPosition = FormStartPosition.Manual
        frm.Location = New Point(x, y)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If ProgressBar1.Value + 1 < ProgressBar1.Maximum Then
            ProgressBar1.Value += 1
            Threading.Thread.Sleep(500)
            ProgressBar1.Value += 5
            Threading.Thread.Sleep(250)
            ProgressBar1.Value += 3
            Threading.Thread.Sleep(1700)
            ProgressBar1.Value += 12
            Threading.Thread.Sleep(50)
            ProgressBar1.Value += 4
            Threading.Thread.Sleep(500)
            ProgressBar1.Value += 9
            ProgressBar1.Value += 1
            Threading.Thread.Sleep(3500)
            ProgressBar1.Value += 16
            ProgressBar1.Value += 15
            Threading.Thread.Sleep(500)
            ProgressBar1.Value += 5
            Threading.Thread.Sleep(1400)
            ProgressBar1.Value += 10
            Threading.Thread.Sleep(1900)
            ProgressBar1.Value += 18
            Threading.Thread.Sleep(10)
            ProgressBar1.Value += 1
            Form2.Show()
        End If
    End Sub
End Class
