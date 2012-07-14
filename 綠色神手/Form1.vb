'-------------------------------------------------------------------------------------------
' 名稱: 綠色神手
' 作者: 百二級社長顏敬柏
' 創作日期: 2011/5/12
' 最後修改: 2012/7/14
' 信箱: jeremy5189@gmail.com
' 授權: 無償授權給松山資研
'
' 程式運作邏輯: 逐行解釋腳本，將語法統一設計為 語法(參數) 格式，以Split函數分割(
'               分別取得 語法 和 參數，在依照語法去呼叫相應的函數(宣告於 Operations.vb)
'               直譯器開發說明已寫於下方
' Prowl說明: Prowl是一個提供iPhone Push服務的網站，在綠色神手裡使用 設定金鑰("code") 設定
'            Prowl API後 (須到該網站申請)，只要執行到  推送訊息("msg")，你的iPhone就會出現
'            該訊息(msg)，但iPhone尚須先安裝 Prowl 軟體
'-------------------------------------------------------------------------------------------


#Region "Change Log"
'20110413-20110416
'新增語法如下:
'   重複執行區段(times)
'   如果此點顏色為(x,y,r,g,b)
'   開啟網址("URL")

'加入顏色語法熱鍵
'修正[Script]標籤消失

'20110420
'修正迴圈圈數
'加入暫停

'20110716
'加入Prowl推送通知功能

'20111016
'修復DownLabel超出索引Bug
#End Region

Imports System.Threading
Imports System.Drawing.Imaging
Imports System.Net

Public Class MainForm

#Region "全域變數宣告"

    Public Const AppVer = "V1.0"
    Dim isRepeating As Boolean = False
    Public prowlAPI_Key As String = "NO_KEY"

    '檔案系統------------------------
    Dim headerdata As String
    Dim fileIsSaved As Boolean = True
    Dim openedFileName As String
    '--------------------------------

    '語法暫存------------------------
    Dim ScriptLines As String()
    Dim ispause As Boolean = False
    'Dim pauseLine As Integer = 0

    '迴圈處理------------------------
    Dim isLooping As Boolean = False
    Dim loopTime, loopEndLine, loopStartLine As Integer

#End Region

#Region "綠色神手語法直譯器開發說明"

    '# 增加語法請增加一個 Case "語法" 。

    '# 請將要執行動作寫於模組 Operations.vb 裡，再由此呼叫。

    '# 動作需寫成 Function，傳回值為 Boolean，若執行成功則傳回 True，
    '  發生錯誤則傳回 False。

    '# 可由 String陣列 ScriptLines(i) 取得現在執行到的語法

    '# 可用 GetValueInBrackets(string) 函數取得括號內的值，使用範例:
    '  範例 GetValueInBrackets("移到(11,12)") = 11,12
    '  範例 GetValueInBrackets("鎖定目標("Hello")") = "Hello"

    '# 當動作函數傳回 False 時請呼叫 ReportError(行數,[string]) 函數
    '  範例 ReportError(i,"座標不合理")
    '  範例 ReportError(i) 第二個參數可省略，預設為"(無)"
    '  呼叫 ReportError() 函數後將自動停止執行，並顯示錯誤訊息

#End Region

    Private Sub ScriptRunner_BW_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles ScriptRunner_BW.DoWork

        For i As Integer = 0 To ScriptLines.Length - 1

            'If ispause = True Then
            '    While ispause = True

            '    End While
            'End If

            '判斷是否要取消工作
            If ScriptRunner_BW.CancellationPending Then
                Exit For
            End If

            If i + 1 < ScriptLines.Length - 1 Then
                DownLabel.Text = "執行第" & i + 1 & "行中..."
            Else
                DownLabel.Text = "執行中..."
            End If

            If ScriptLines(i) = "Skip" Then '跳過
                Continue For
            End If

            '處理重複執行
            If isLooping = True Then
                If i = loopEndLine Then
                    i = loopStartLine
                    loopTime -= 1
                End If
                If loopTime = 1 Then '0會多一下
                    isLooping = False
                End If
            End If

            '分割括號
            Dim keyword As String() = Split(ScriptLines(i), "(")
            keyword(0) = keyword(0).Replace(Convert.ToChar(32), "")

            Select Case keyword(0)

                '----------------keyboard-------------------
                Case "按下"
                    Dim arg As String = GetValueInBrackets(ScriptLines(i))
                    arg = arg.Replace("""", "")
                    If PressKeyDown(arg) = False Then
                        ReportError(i, "此按鍵不存在或格式錯誤!")
                    End If

                Case "放開"
                    Dim arg As String = GetValueInBrackets(ScriptLines(i))
                    arg = arg.Replace("""", "")
                    If PressKeyUp(arg) = False Then
                        ReportError(i, "此按鍵不存在或格式錯誤!")
                    End If

                Case "按一下"
                    Dim arg As String = GetValueInBrackets(ScriptLines(i))
                    arg = arg.Replace("""", "")
                    If PressKey(arg) = False Then
                        ReportError(i, "此按鍵不存在或格式錯誤!")
                    End If

                Case "傳送字串"
                    Dim arg As String = GetValueInBrackets(ScriptLines(i))
                    arg = arg.Replace("""", "")
                    SendKeys.SendWait(arg)

                    '----------------滑鼠類---------------------

                Case "移到"
                    Dim arg As String = GetValueInBrackets(ScriptLines(i))
                    Dim tmp As String() = arg.Split(",")
                    Dim x, y As Integer
                    x = tmp(0)
                    y = tmp(1)
                    If MouseMoveTo(x, y) = False Then
                        ReportError(i, "滑鼠座標不合理")
                    End If

                Case "按一下左鍵"
                    MouseClicking("Left")

                Case "按一下右鍵"
                    MouseClicking("Right")

                    '-----------------Utility---------------------

                Case "等待"
                    Dim arg As String = GetValueInBrackets(ScriptLines(i))
                    Thread.Sleep(CInt(arg))

                Case "顯示訊息"
                    Dim arg As String = GetValueInBrackets(ScriptLines(i))
                    arg = arg.Replace("""", "") '去除雙引號"
                    MsgBox(arg, MsgBoxStyle.Information, "綠色神手-訊息")

                Case "警示音"
                    Beep(1000, 1000)

                Case "呼叫程式"
                    Dim arg As String = GetValueInBrackets(ScriptLines(i))
                    arg = arg.Replace("""", "") '去除雙引號"
                    Try
                        Shell(arg, AppWinStyle.NormalFocus)
                    Catch ex As System.IO.FileNotFoundException
                        ReportError(i, "呼叫的程式或路徑不存在!")
                    End Try

                Case "開啟網址"
                    Dim arg As String = GetValueInBrackets(ScriptLines(i))
                    arg = arg.Replace("""", "")
                    System.Diagnostics.Process.Start(arg)

                Case "設定金鑰"
                    '設定Prowl金鑰
                    Dim arg As String = GetValueInBrackets(ScriptLines(i))
                    arg = arg.Replace("""", "")
                    prowlAPI_Key = arg

                Case "推送訊息"
                    '推送Prowl訊息
                    If prowlAPI_Key <> "NO_KEY" Then
                        Dim arg As String = GetValueInBrackets(ScriptLines(i))
                        Dim msg As String() = Split(arg, ",")
                        msg(0) = msg(0).Replace("""", "")
                        msg(1) = msg(1).Replace("""", "")
                        If PushMessage(msg(0), msg(1)) = False Then
                            ReportError(i, "推送訊息失敗，請檢查您的 API KEY 或是否遺漏參數?")
                        End If
                    Else
                        ReportError(i, "請先使用 設定金鑰() 函數設定您的 Prowl API Key")
                    End If
                    '----------------Windows------------------------

                Case "目標最大化"
                    If ShowTargetWindows("Max") = False Then
                        ReportError(i, "未鎖定目標!")
                    End If

                Case "目標最小化"
                    If ShowTargetWindows("Min") = False Then
                        ReportError(i, "未鎖定目標!")
                    End If

                Case "關閉目標"
                    If closeTarget() = False Then
                        ReportError(i, "未鎖定目標!")
                    End If

                Case "鎖定目標"
                    Dim arg As String = GetValueInBrackets(ScriptLines(i))
                    arg = arg.Replace("""", vbNullString) '去除雙引號"
                    If LockTarget(arg) = False Then
                        ReportError(i, "查無此目標!")
                    End If

                Case "取得停駐點"
                    If GetFocus() = False Then
                        ReportError(i, "未鎖定目標!")
                    End If

                    '----------------敘述------------------------
                Case "重複執行區段"
                    loopTime = Convert.ToInt32(GetValueInBrackets(ScriptLines(i)))
                    Dim loopn As Integer = i
                    While ScriptLines(loopn) <> "結束區段"
                        loopn += 1
                    End While
                    'loopn = "結束區段"這行的索引
                    isLooping = True
                    loopEndLine = loopn
                    loopStartLine = i + 1

                Case "如果此點顏色為"

                    'Format: 如果此點顏色為(x,y,r,g,b)
                    Dim arg As String = GetValueInBrackets(ScriptLines(i))
                    If ProcessColor(arg) = 0 Then
                        Dim endl As Integer = i
                        While ScriptLines(endl) <> "結束區段"
                            endl += 1
                        End While
                        i = endl '跳過整段
                    End If

                Case "如果此點顏色不為"

                    'Format: 如果此點顏色不為(x,y,r,g,b)
                    Dim arg As String = GetValueInBrackets(ScriptLines(i))
                    If ProcessColor(arg) = 1 Then
                        Dim endl As Integer = i
                        While ScriptLines(endl) <> "結束區段"
                            endl += 1
                        End While
                        i = endl '跳過整段
                    End If

            End Select

        Next

    End Sub

    Private Sub ReportError(ByVal linenum As Integer, Optional ByVal discrip As String = "(無)")
        MsgBox("執行到第" & linenum + 1 & "行時發生錯誤" & vbCrLf & "錯誤詳細說明:" & vbCrLf & discrip, MsgBoxStyle.Critical, "綠色神手偵錯器")
        ScriptRunner_BW.CancelAsync()
    End Sub

    Private Sub StartWork()

        '開始執行按鈕

        If ispause = False Then
            '呼叫 BackGroundWorker 處理
            If ScriptRunner_BW.IsBusy = False Then
                ScriptLines = Split(ScriptText.Text, vbCrLf)
                For i = 0 To ScriptLines.Length - 1

                    If ScriptLines(i) = "" Then
                        ScriptLines(i) = "Skip"
                    End If
                    If ScriptLines(i)(0) = "/" And ScriptLines(i)(1) = "/" Then
                        ScriptLines(i) = "Skip"
                    End If
                Next
                ScriptRunner_BW.RunWorkerAsync()

                DownLabel.Text = "執行第1行中..."

                ScriptText.ReadOnly = True
                RunScriptButton.Enabled = False
                PauseScriptButton.Enabled = True
                StopScriptButton.Enabled = True
            End If

        Else

            ispause = False
            PauseScriptButton.Enabled = True
            RunScriptButton.Enabled = False
            ScriptText.ReadOnly = False
        End If
    End Sub

    Private Sub PauseScriptButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PauseScriptButton.Click
        '未完成
        ispause = True
        ScriptText.ReadOnly = False
        PauseScriptButton.Enabled = False
        RunScriptButton.Enabled = True
        DownLabel.Text = "暫停"
    End Sub

    Private Sub StopScriptButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StopScriptButton.Click
        '停止按鈕
        ScriptRunner_BW.CancelAsync()
        isRepeating = False
        ispause = False
    End Sub

    Private Sub CreateNewFile()
        '新增新的Script
        If CheckIfFileSaved() = False Then
            Exit Sub
        End If

        Dim ast As New AddScriptDialog()
        If ast.ShowDialog() = Windows.Forms.DialogResult.OK Then
            headerdata = "[Header]" & vbCrLf
            headerdata &= "AppVersion=" & AppVer & vbCrLf
            headerdata &= "Title=" & ast.title & vbCrLf
            headerdata &= "Author=" & ast.author & vbCrLf
            headerdata &= "Discription=" & ast.discription & vbCrLf
            fileIsSaved = False
            ScriptText.Clear()
            openedFileName = ast.title & ".txt"
            ScriptText.ReadOnly = False
            Me.Text = "綠色神手 " & AppVer & " - " & ast.title
        End If
    End Sub

    Private Function SaveFile() As String
        '存檔
        If openedFileName <> "" Then
            Dim ofi As New FileInfo(scriptFilePath & "/" & openedFileName)
            If ofi.Exists Then
                If MsgBox("是否複寫已存在之檔案?", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "警告") = MsgBoxResult.No Then
                    Return "cancel"
                End If
            End If
            Dim sw As New StreamWriter(ofi.FullName, False, Encoding.Default)
            sw.Write(headerdata & "[Script]" & vbCrLf & ScriptText.Text)
            sw.Close()
            LoadScriptFiles()
            fileIsSaved = True
        End If
        Return "good"
    End Function

    Private Function CheckIfFileSaved() As Boolean
        '檢查檔案有沒有儲存
        If fileIsSaved = False Then
            Dim ret As Integer
            ret = MsgBox("是否要儲存目前檔案的變更?", MsgBoxStyle.Information + MsgBoxStyle.YesNoCancel)
            Select Case ret
                Case DialogResult.Yes
                    If SaveFile() = "good" Then
                        Return True
                    Else
                        Return False
                    End If

                Case DialogResult.No
                    Return True
                Case DialogResult.Cancel
                    Return False
            End Select
        Else
            Return True
        End If

    End Function

    Private Sub ScriptRunner_BW_RunWorkerCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles ScriptRunner_BW.RunWorkerCompleted
        '完成工作的處理
        If isRepeating = True Then
            Thread.Sleep(300)
            ScriptRunner_BW.RunWorkerAsync()
        Else
            DownLabel.Text = "就緒"
            ScriptText.ReadOnly = False
            RunScriptButton.Enabled = True
            PauseScriptButton.Enabled = False
            StopScriptButton.Enabled = False
            ToolStripButton6.Checked = False
        End If
    End Sub

    Private Sub FileListBox_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FileListBox.DoubleClick
        '開啟檔案的處理
        If CheckIfFileSaved() = False Then
            Exit Sub
        End If

        Dim fn As String = FileListBox.SelectedItem
        Dim filename As String = scriptFilePath & "/" & fn
        openedFileName = fn
        fn = fn.Replace(".txt", "")

        ScriptText.ReadOnly = False

        Me.Text = "綠色神手 " & AppVer & " - " & fn

        Dim sr As New StreamReader(filename, System.Text.Encoding.Default)
        Dim cont As String() = Split(sr.ReadToEnd(), "[Script]")
        ScriptText.Text = cont(1).Remove(0, 1).Remove(0, 1)
        headerdata = cont(0)
        sr.Close()

    End Sub

    Private Sub MainForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = "綠色神手 " & AppVer
        ScriptText.ReadOnly = True
        LoadScriptFiles()
        '取得螢幕解析度
        sx = Screen.PrimaryScreen.Bounds.Width
        sy = Screen.PrimaryScreen.Bounds.Height
        ScriptHelperList.SelectedIndex = 0
    End Sub

#Region "輔助功能程式碼"

    Private Sub RunScriptButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RunScriptButton.Click
        '開始執行按鈕
        StartWork()
    End Sub

    Private Sub ScriptHelperList_MouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ScriptHelperList.MouseDoubleClick
        '語法助手
        If ScriptText.ReadOnly = False Then
            Dim s As String = ScriptHelperList.SelectedItem.ToString()
            If s(0) <> "=" Then
                If s = "重複執行區段(times)" Then
                    ScriptText.SelectedText = (s & vbCrLf & vbCrLf & "結束區段")
                    Exit Sub
                End If
                If s = "如果此點顏色為(x,y,r,g,b)" Then
                    ScriptText.SelectedText = (s & vbCrLf & vbCrLf & "結束區段")
                    Exit Sub
                End If
                ScriptText.AppendText(s & vbCrLf)
            End If
        End If
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        '語法助手
        If ScriptText.ReadOnly = False Then
            Dim s As String = ScriptHelperList.SelectedItem.ToString()
            If s(0) <> "=" Then
                If s = "重複執行區段(times)" Then
                    ScriptText.SelectedText = (s & vbCrLf & vbCrLf & "結束區段")
                    Exit Sub
                End If
                If s = "如果此點顏色為(x,y,r,g,b)" Then
                    ScriptText.SelectedText = (s & vbCrLf & vbCrLf & "結束區段")
                    Exit Sub
                End If
                ScriptText.AppendText(s & vbCrLf)
            End If
        End If
    End Sub

    Private Sub ToolStripButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton4.Click
        FeedBack.Show()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        '重新整理檔案
        LoadScriptFiles()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        '刪除檔案
        If MsgBox("確認刪除所選項目?", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "刪除") = MsgBoxResult.Yes Then
            Dim fi As New FileInfo(scriptFilePath & "/" & FileListBox.SelectedItem.ToString())
            Try
                fi.Delete()
            Catch
                MsgBox("刪除檔案時發生未知錯誤!", MsgBoxStyle.Critical, "Error")
            End Try
            LoadScriptFiles()
        End If
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        '檔案更名
        Dim NewName As String = InputBox("請輸入欲更改之檔名", "更名", FileListBox.SelectedItem.ToString())
        If NewName <> "" Then
            My.Computer.FileSystem.RenameFile(scriptFilePath & "/" & FileListBox.SelectedItem.ToString(), NewName)
            LoadScriptFiles()
        End If
    End Sub

    Private Sub 新增NToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 新增NToolStripButton1.Click
        CreateNewFile()
    End Sub

    Private Sub 開啟OToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 開啟OToolStripButton1.Click
        'MsgBox("Todo:從外部匯入檔案")
    End Sub

    Private Sub 儲存SToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 儲存SToolStripButton1.Click
        SaveFile()
    End Sub

    Private Sub 剪下UToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 剪下UToolStripButton1.Click
        ScriptText.Cut()
    End Sub

    Private Sub 複製CToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 複製CToolStripButton1.Click
        ScriptText.Copy()
    End Sub

    Private Sub 貼上PToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 貼上PToolStripButton1.Click
        ScriptText.Paste()
    End Sub

    Private Sub 說明LToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 說明LToolStripButton1.Click
        AboutBox1.Show()
    End Sub

    Private Sub ScriptText_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ScriptText.TextChanged
        fileIsSaved = False
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If headerdata <> "" Then
            MsgBox(headerdata, MsgBoxStyle.Information, "腳本內容")
        Else
            MsgBox("未載入任何檔案!", MsgBoxStyle.Critical, "Error")
        End If
    End Sub

    Private Sub Hotkeys_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Hotkeys.Tick
        If GetAsyncKeyState(Keys.ShiftKey) And GetAsyncKeyState(Keys.F5) Then
            StartWork()
        End If
        If GetAsyncKeyState(Keys.ShiftKey) And GetAsyncKeyState(Keys.F6) Then
            ScriptRunner_BW.CancelAsync()
        End If
    End Sub

    Private Sub MainForm_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        If CheckIfFileSaved() = False Then
            e.Cancel = True
        End If
    End Sub

    Private Sub ToolStripButton5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton5.Click
        Tools.Show()
    End Sub

    Private Sub ToolStripButton6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton6.Click
        '正在循環按鈕
        If ToolStripButton6.Checked = True Then
            ToolStripButton6.Checked = False
            isRepeating = False
        Else
            ToolStripButton6.Checked = True
            isRepeating = True
        End If
    End Sub

#End Region

End Class