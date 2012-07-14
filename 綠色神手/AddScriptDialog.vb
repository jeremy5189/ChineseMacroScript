Imports System.Windows.Forms

Public Class AddScriptDialog
    Public title, author, discription As String

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        If TextBox1.Text = "" Then
            TextBox1.BackColor = Color.Red
            Exit Sub
        End If
        title = TextBox1.Text
        author = TextBox2.Text
        discription = TextBox3.Text
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub AddScriptDialog_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim s As String()
        s = My.User.Name.Split("\")
        TextBox2.Text = s(1)
    End Sub

    Private Sub TextBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.Click
        TextBox1.BackColor = Color.White
    End Sub

    Private Sub AddScriptDialog_Activated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        TextBox1.Focus()
    End Sub
End Class
