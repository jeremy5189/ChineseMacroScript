Module Operations

    '以下為可直接使用的全域變數(皆已賦值)
    '------------------------------------------
    '儲存應用程式所在路徑
    Public myPath As String
    '儲存腳本檔案所在路徑(不含最後面的/)
    Public scriptFilePath As String
    '儲存滑鼠座標的Structure
    Public mouse_location As New POINTAPI
    '儲存螢幕解析度
    Public sx As Integer
    Public sy As Integer
    '儲存鎖定目標的Handle代碼
    Public targetHandle As Integer

    '抓色資料------------------------
    Private Structure colorStruc
        Dim x As Integer
        Dim y As Integer
        Dim R As Integer
        Dim G As Integer
        Dim B As Integer
    End Structure

    Public Sub LoadScriptFiles()

        '清空列表
        MainForm.FileListBox.Items.Clear()

        myPath = Application.StartupPath
        scriptFilePath = myPath & "\Scripts"

        Dim thisDIr As New DirectoryInfo(scriptFilePath)
        Dim fileList As FileInfo() = thisDIr.GetFiles("*.txt")

        For Each files As FileInfo In fileList
            MainForm.FileListBox.Items.Add(files.Name)
        Next

        If MainForm.FileListBox.Items.Count > 0 Then

            MainForm.FileListBox.SelectedIndex = 0
        End If

    End Sub

    Public Function LockTarget(ByVal idfer As String) As Boolean
        '鎖定目標
        Dim t As String = idfer

        Dim hwnd As Integer = FindWindow(vbNullString, t)

        If hwnd = 0 Then
            hwnd = FindWindow(idfer, vbNullString)
        End If

        If hwnd = 0 Then
            Return False
        End If

        targetHandle = hwnd
        Return True

    End Function

    Public Sub UnLockTarget()

        targetHandle = 0

    End Sub

    Public Function MouseMoveTo(ByVal x As Integer, ByVal y As Integer) As Boolean
        '移動滑鼠到
        If IsNumeric(x) = False Or IsNumeric(y) = False Then
            Return False
        End If

        If x > sx Or y > sx Then
            Return False
        End If

        SetCursorPos(x, y)
        Return True

    End Function

    Public Function MouseClicking(ByVal type As String) As Boolean
        '模擬滑鼠按下事件
        GetCursorPos(mouse_location)

        If type = "Left" Then
            mouse_event(MOUSEEVENTF_LEFTDOWN, mouse_location.x, mouse_location.y, 0, 0)
            mouse_event(MOUSEEVENTF_LEFTUP, mouse_location.x, mouse_location.y, 0, 0)
        End If

        If type = "Right" Then
            mouse_event(MOUSEEVENTF_RIGHTDOWN, mouse_location.x, mouse_location.y, 0, 0)
            mouse_event(MOUSEEVENTF_RIGHTUP, mouse_location.x, mouse_location.y, 0, 0)
        End If

        Return True

    End Function

    Public Function ShowTargetWindows(ByVal type As String) As Boolean
        '放大縮小目標
        If targetHandle = 0 Then
            Return False
        End If

        If type = "Max" Then
            ShowWindow(targetHandle, 3)
        End If

        If type = "Min" Then
            ShowWindow(targetHandle, 6)
        End If

        Return True

    End Function

    Public Function closeTarget() As Boolean
        '關閉目標
        If targetHandle = 0 Then
            Return False
        Else
            PostMessage(targetHandle, &H10, 0, 0)
        End If
        Return True
    End Function

    Public Function PressKeyDown(ByVal keyid As String) As Boolean
        '模擬按下按鍵
        Dim id As Integer = GetKeyCode(keyid)

        If id = -1 Then
            Return False
        Else
            keybd_event(id, 0, 0, 0)
            Return True
        End If

    End Function

    Public Function PressKeyUp(ByVal keyid As String) As Boolean
        '模擬放開按鍵
        Dim id As Integer = GetKeyCode(keyid)

        If id = -1 Then
            Return False
        Else
            keybd_event(id, 0, KEYEVENTF_KEYUP, 0)
            Return True
        End If

    End Function

    Public Function PressKey(ByVal keyid As String) As Boolean
        '模擬按一下按鍵
        Dim id As Integer = GetKeyCode(keyid)

        If id = -1 Then
            Return False
        Else
            keybd_event(id, 0, 0, 0)
            keybd_event(id, 0, KEYEVENTF_KEYUP, 0)
            Return True
        End If

    End Function

    Public Function GetFocus() As Boolean
        '取得停駐點
        If targetHandle = 0 Then
            Return False
        Else
            SetForegroundWindow(targetHandle)
            Return True
        End If

    End Function

    '轉換KeyCode
    Private Function GetKeyCode(ByVal i As String) As Integer

        Dim id As Integer

        Select Case i
            Case "A"
                id = Keys.A
            Case "B"
                id = Keys.B
            Case "C"
                id = Keys.C
            Case "D"
                id = Keys.D
            Case "E"
                id = Keys.E
            Case "F"
                id = Keys.F
            Case "G"
                id = Keys.G
            Case "H"
                id = Keys.H
            Case "I"
                id = Keys.I
            Case "J"
                id = Keys.J
            Case "K"
                id = Keys.K
            Case "L"
                id = Keys.L
            Case "M"
                id = Keys.M
            Case "N"
                id = Keys.N
            Case "O"
                id = Keys.O
            Case "P"
                id = Keys.P
            Case "Q"
                id = Keys.Q
            Case "R"
                id = Keys.R
            Case "S"
                id = Keys.S
            Case "T"
                id = Keys.T
            Case "U"
                id = Keys.U
            Case "V"
                id = Keys.V
            Case "W"
                id = Keys.W
            Case "X"
                id = Keys.X
            Case "Y"
                id = Keys.Y
            Case "Z"
                id = Keys.Z

            Case "Ctrl"
                id = Keys.ControlKey
            Case "Shift"
                id = Keys.ShiftKey
            Case "Alt"
                id = 18
            Case "Enter"
                id = Keys.Enter

            Case "Home"
                id = Keys.Home
            Case "End"
                id = Keys.End
            Case "PageDown"
                id = Keys.PageDown
            Case "PageUp"
                id = Keys.PageUp
            Case "Del"
                id = Keys.Delete
            Case "Back"
                id = Keys.Back

            Case "Left"
                id = 37
            Case "Up"
                id = 38
            Case "Right"
                id = 39
            Case "Down"
                id = 40

            Case "Menu" 'bad
                id = 12
            Case "Capslock" 'bad
                id = 14

            Case "Tab"
                id = 9

            Case "0"
                id = Keys.D0
            Case "1"
                id = Keys.D1
            Case "2"
                id = Keys.D2
            Case "3"
                id = Keys.D3
            Case "4"
                id = Keys.D4
            Case "5"
                id = Keys.D5
            Case "6"
                id = Keys.D6
            Case "7"
                id = Keys.D7
            Case "8"
                id = Keys.D8
            Case "9"
                id = Keys.D9

            Case "F1"
                id = Keys.F1
            Case "F2"
                id = Keys.F2
            Case "F3"
                id = Keys.F3
            Case "F4"
                id = Keys.F4
            Case "F5"
                id = Keys.F5
            Case "F6"
                id = Keys.F6
            Case "F7"
                id = Keys.F7
            Case "F8"
                id = Keys.F8
            Case "F9"
                id = Keys.F9
            Case "F10"
                id = Keys.F11
            Case "F11"
                id = Keys.F11
            Case "F12"
                id = Keys.F12


            Case Else
                id = -1

        End Select

        Return id

    End Function

    Public Function ProcessColor(ByVal arg As String) As Integer
        '判斷顏色
        Dim cd As New colorStruc
        Try
            Dim data As String() = Split(arg, ",")
            cd.x = Convert.ToInt32(data(0))
            cd.y = Convert.ToInt32(data(1))
            cd.R = Convert.ToInt32(data(2))
            cd.G = Convert.ToInt32(data(3))
            cd.B = Convert.ToInt32(data(4))
        Catch
            Return -1 '參數錯誤
        End Try

        Dim de As Color = MyGetPixel(cd.x, cd.y)
        Dim match As Boolean = False
        If de.R = cd.R Then
            If de.G = cd.G Then
                If de.B = cd.B Then
                    match = True
                End If
            End If
        End If

        If match = False Then
            Return 0 '顏色不合
        Else
            Return 1 '顏色正確
        End If

    End Function

    Public Function PushMessage(ByVal title As String, ByVal msg As String) As Boolean
        '推送Prowl訊息
        Dim ret As Boolean = True

        Dim config As New Prowl.ProwlClientConfiguration
        config.ApplicationName = "綠色神手訊息"
        config.ApiKeychain = MainForm.prowlAPI_Key

        Dim pr As New Prowl.ProwlClient(config)

        Dim n As New Prowl.ProwlNotification
        n.Priority = 0
        n.Event = title
        n.Description = msg

        Try
            pr.PostNotification(n)
        Catch
            ret = False
        End Try

        Return ret

    End Function

End Module
