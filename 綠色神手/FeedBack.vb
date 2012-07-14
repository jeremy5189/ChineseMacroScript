Imports System.Windows.Forms
Imports System.Web

Public Class FeedBack
    Dim na, email, comm As String
    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click


        na = base64Encode(HttpUtility.UrlEncode(TextBox1.Text))
        email = base64Encode(TextBox2.Text)
        comm = base64Encode(HttpUtility.UrlEncode(TextBox3.Text))

        MsgBox("傳送回報需一定的時間，請耐心等候，謝謝!", MsgBoxStyle.Information, "Feedback")

        BackgroundWorker1.RunWorkerAsync()

      
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Function base64Encode(ByVal data As String) As String
        Try
            Dim encData_byte As Byte() = New Byte(data.Length - 1) {}
            encData_byte = System.Text.Encoding.UTF8.GetBytes(data)
            Dim encodedData As String = Convert.ToBase64String(encData_byte)
            Return encodedData
        Catch
            Return "Encode Error"
        End Try
    End Function

    Private Sub BackgroundWorker1_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        Dim r As String
        Dim k As String = "http://ssinrc.org/feedback/gmh_feedback.php?from=" & na & "&fadr=" & email & "&msg=" & comm
        ' Debug.Print(k)
        r = GetHttpTxt(k)
        If r <> "SendFail" Then
            MsgBox("您的IP: " & r & vbCrLf & "感謝您的回報!", MsgBoxStyle.Information, "Feedback")
        Else
            MsgBox("發生不明錯誤!", MsgBoxStyle.Critical, "Error")
        End If

    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(ByVal sender As System.Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub
End Class
