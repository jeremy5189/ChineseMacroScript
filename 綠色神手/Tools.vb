Imports System.Threading
Public Class Tools

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        GetCursorPos(mouse_location)
        Label2.Text = "X = " & mouse_location.x & " Y = " & mouse_location.y
        Dim g As Color = MyGetPixel(mouse_location.x, mouse_location.y)
        Label5.BackColor = g
        Label7.Text = g.R & "," & g.G & "," & g.B
        Label10.Text = ColorTranslator.ToHtml(g)

        If GetAsyncKeyState(Keys.F9) Then
            If MainForm.ScriptText.ReadOnly = False Then
                MainForm.ScriptText.SelectedText = "移到(" & mouse_location.x & "," & mouse_location.y & ")" & vbCrLf
                Thread.Sleep(100)
            End If
        End If

        If GetAsyncKeyState(Keys.F10) Then
            If MainForm.ScriptText.ReadOnly = False Then
                MainForm.ScriptText.SelectedText = "如果此點顏色為(" & mouse_location.x & "," & mouse_location.y & "," & g.R & "," & g.G & "," & g.B & ")" & vbCrLf
                Thread.Sleep(100)
            End If
        End If
    End Sub

    Private Sub Tools_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown

        Dim keycode As Integer = e.KeyCode

        Select Case keycode
            Case 37
                'Left
                SetCursorPos(Cursor.Position.X - 1, Cursor.Position.Y)
            Case 38
                'Up
                SetCursorPos(Cursor.Position.X, Cursor.Position.Y - 1)
            Case 39
                'Right
                SetCursorPos(Cursor.Position.X + 1, Cursor.Position.Y)
            Case 40
                'Down
                SetCursorPos(Cursor.Position.X, Cursor.Position.Y + 1)
            Case Else

        End Select


    End Sub
End Class