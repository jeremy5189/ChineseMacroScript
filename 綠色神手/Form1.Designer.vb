<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form 覆寫 Dispose 以清除元件清單。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    '為 Windows Form 設計工具的必要項
    Private components As System.ComponentModel.IContainer

    '注意: 以下為 Windows Form 設計工具所需的程序
    '可以使用 Windows Form 設計工具進行修改。
    '請不要使用程式碼編輯器進行修改。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.ScriptRunner_BW = New System.ComponentModel.BackgroundWorker
        Me.新增NToolStripButton = New System.Windows.Forms.ToolStripButton
        Me.開啟OToolStripButton = New System.Windows.Forms.ToolStripButton
        Me.儲存SToolStripButton = New System.Windows.Forms.ToolStripButton
        Me.剪下UToolStripButton = New System.Windows.Forms.ToolStripButton
        Me.複製CToolStripButton = New System.Windows.Forms.ToolStripButton
        Me.貼上PToolStripButton = New System.Windows.Forms.ToolStripButton
        Me.說明LToolStripButton = New System.Windows.Forms.ToolStripButton
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.新增NToolStripButton1 = New System.Windows.Forms.ToolStripButton
        Me.開啟OToolStripButton1 = New System.Windows.Forms.ToolStripButton
        Me.儲存SToolStripButton1 = New System.Windows.Forms.ToolStripButton
        Me.toolStripSeparator = New System.Windows.Forms.ToolStripSeparator
        Me.剪下UToolStripButton1 = New System.Windows.Forms.ToolStripButton
        Me.複製CToolStripButton1 = New System.Windows.Forms.ToolStripButton
        Me.貼上PToolStripButton1 = New System.Windows.Forms.ToolStripButton
        Me.toolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.RunScriptButton = New System.Windows.Forms.ToolStripButton
        Me.PauseScriptButton = New System.Windows.Forms.ToolStripButton
        Me.StopScriptButton = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripButton5 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripButton6 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripButton4 = New System.Windows.Forms.ToolStripButton
        Me.說明LToolStripButton1 = New System.Windows.Forms.ToolStripButton
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip
        Me.DownLabel = New System.Windows.Forms.ToolStripStatusLabel
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.FileMang = New System.Windows.Forms.TabPage
        Me.Button4 = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.FileListBox = New System.Windows.Forms.ListBox
        Me.ScriptHelp = New System.Windows.Forms.TabPage
        Me.Button5 = New System.Windows.Forms.Button
        Me.ScriptHelperList = New System.Windows.Forms.ListBox
        Me.ScriptText = New System.Windows.Forms.TextBox
        Me.Hotkeys = New System.Windows.Forms.Timer(Me.components)
        Me.ToolStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.FileMang.SuspendLayout()
        Me.ScriptHelp.SuspendLayout()
        Me.SuspendLayout()
        '
        'ScriptRunner_BW
        '
        Me.ScriptRunner_BW.WorkerSupportsCancellation = True
        '
        '新增NToolStripButton
        '
        Me.新增NToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.新增NToolStripButton.Image = CType(resources.GetObject("新增NToolStripButton.Image"), System.Drawing.Image)
        Me.新增NToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.新增NToolStripButton.Name = "新增NToolStripButton"
        Me.新增NToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.新增NToolStripButton.Text = "新增(&N)"
        '
        '開啟OToolStripButton
        '
        Me.開啟OToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.開啟OToolStripButton.Image = CType(resources.GetObject("開啟OToolStripButton.Image"), System.Drawing.Image)
        Me.開啟OToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.開啟OToolStripButton.Name = "開啟OToolStripButton"
        Me.開啟OToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.開啟OToolStripButton.Text = "開啟(&O)"
        '
        '儲存SToolStripButton
        '
        Me.儲存SToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.儲存SToolStripButton.Image = CType(resources.GetObject("儲存SToolStripButton.Image"), System.Drawing.Image)
        Me.儲存SToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.儲存SToolStripButton.Name = "儲存SToolStripButton"
        Me.儲存SToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.儲存SToolStripButton.Text = "儲存(&S)"
        '
        '剪下UToolStripButton
        '
        Me.剪下UToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.剪下UToolStripButton.Image = CType(resources.GetObject("剪下UToolStripButton.Image"), System.Drawing.Image)
        Me.剪下UToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.剪下UToolStripButton.Name = "剪下UToolStripButton"
        Me.剪下UToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.剪下UToolStripButton.Text = "剪下(&U)"
        '
        '複製CToolStripButton
        '
        Me.複製CToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.複製CToolStripButton.Image = CType(resources.GetObject("複製CToolStripButton.Image"), System.Drawing.Image)
        Me.複製CToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.複製CToolStripButton.Name = "複製CToolStripButton"
        Me.複製CToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.複製CToolStripButton.Text = "複製(&C)"
        '
        '貼上PToolStripButton
        '
        Me.貼上PToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.貼上PToolStripButton.Image = CType(resources.GetObject("貼上PToolStripButton.Image"), System.Drawing.Image)
        Me.貼上PToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.貼上PToolStripButton.Name = "貼上PToolStripButton"
        Me.貼上PToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.貼上PToolStripButton.Text = "貼上(&P)"
        '
        '說明LToolStripButton
        '
        Me.說明LToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.說明LToolStripButton.Image = CType(resources.GetObject("說明LToolStripButton.Image"), System.Drawing.Image)
        Me.說明LToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.說明LToolStripButton.Name = "說明LToolStripButton"
        Me.說明LToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.說明LToolStripButton.Text = "說明(&L)"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = Global.綠色神手.My.Resources.Resources._1299247034_player_play
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton1.Text = "執行"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton2.Image = Global.綠色神手.My.Resources.Resources._1299247043_player_pause
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton2.Text = "暫停"
        '
        'ToolStripButton3
        '
        Me.ToolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton3.Image = Global.綠色神手.My.Resources.Resources._1299247024_player_stop
        Me.ToolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton3.Name = "ToolStripButton3"
        Me.ToolStripButton3.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton3.Text = "停止"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.新增NToolStripButton1, Me.開啟OToolStripButton1, Me.儲存SToolStripButton1, Me.toolStripSeparator, Me.剪下UToolStripButton1, Me.複製CToolStripButton1, Me.貼上PToolStripButton1, Me.toolStripSeparator1, Me.RunScriptButton, Me.PauseScriptButton, Me.StopScriptButton, Me.ToolStripSeparator2, Me.ToolStripButton5, Me.ToolStripButton6, Me.ToolStripButton4, Me.說明LToolStripButton1})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(768, 25)
        Me.ToolStrip1.TabIndex = 0
        '
        '新增NToolStripButton1
        '
        Me.新增NToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.新增NToolStripButton1.Image = CType(resources.GetObject("新增NToolStripButton1.Image"), System.Drawing.Image)
        Me.新增NToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.新增NToolStripButton1.Name = "新增NToolStripButton1"
        Me.新增NToolStripButton1.Size = New System.Drawing.Size(23, 22)
        Me.新增NToolStripButton1.Text = "新增(&N)"
        '
        '開啟OToolStripButton1
        '
        Me.開啟OToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.開啟OToolStripButton1.Image = CType(resources.GetObject("開啟OToolStripButton1.Image"), System.Drawing.Image)
        Me.開啟OToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.開啟OToolStripButton1.Name = "開啟OToolStripButton1"
        Me.開啟OToolStripButton1.Size = New System.Drawing.Size(23, 22)
        Me.開啟OToolStripButton1.Text = "開啟(&O)"
        '
        '儲存SToolStripButton1
        '
        Me.儲存SToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.儲存SToolStripButton1.Image = CType(resources.GetObject("儲存SToolStripButton1.Image"), System.Drawing.Image)
        Me.儲存SToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.儲存SToolStripButton1.Name = "儲存SToolStripButton1"
        Me.儲存SToolStripButton1.Size = New System.Drawing.Size(23, 22)
        Me.儲存SToolStripButton1.Text = "儲存(&S)"
        '
        'toolStripSeparator
        '
        Me.toolStripSeparator.Name = "toolStripSeparator"
        Me.toolStripSeparator.Size = New System.Drawing.Size(6, 25)
        '
        '剪下UToolStripButton1
        '
        Me.剪下UToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.剪下UToolStripButton1.Image = CType(resources.GetObject("剪下UToolStripButton1.Image"), System.Drawing.Image)
        Me.剪下UToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.剪下UToolStripButton1.Name = "剪下UToolStripButton1"
        Me.剪下UToolStripButton1.Size = New System.Drawing.Size(23, 22)
        Me.剪下UToolStripButton1.Text = "剪下(&X)"
        '
        '複製CToolStripButton1
        '
        Me.複製CToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.複製CToolStripButton1.Image = CType(resources.GetObject("複製CToolStripButton1.Image"), System.Drawing.Image)
        Me.複製CToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.複製CToolStripButton1.Name = "複製CToolStripButton1"
        Me.複製CToolStripButton1.Size = New System.Drawing.Size(23, 22)
        Me.複製CToolStripButton1.Text = "複製(&C)"
        '
        '貼上PToolStripButton1
        '
        Me.貼上PToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.貼上PToolStripButton1.Image = CType(resources.GetObject("貼上PToolStripButton1.Image"), System.Drawing.Image)
        Me.貼上PToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.貼上PToolStripButton1.Name = "貼上PToolStripButton1"
        Me.貼上PToolStripButton1.Size = New System.Drawing.Size(23, 22)
        Me.貼上PToolStripButton1.Text = "貼上(&V)"
        '
        'toolStripSeparator1
        '
        Me.toolStripSeparator1.Name = "toolStripSeparator1"
        Me.toolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'RunScriptButton
        '
        Me.RunScriptButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.RunScriptButton.Image = Global.綠色神手.My.Resources.Resources._1299247034_player_play
        Me.RunScriptButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.RunScriptButton.Name = "RunScriptButton"
        Me.RunScriptButton.Size = New System.Drawing.Size(23, 22)
        Me.RunScriptButton.Text = "執行(&E)"
        '
        'PauseScriptButton
        '
        Me.PauseScriptButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.PauseScriptButton.Enabled = False
        Me.PauseScriptButton.Image = Global.綠色神手.My.Resources.Resources._1299247043_player_pause
        Me.PauseScriptButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.PauseScriptButton.Name = "PauseScriptButton"
        Me.PauseScriptButton.Size = New System.Drawing.Size(23, 22)
        Me.PauseScriptButton.Text = "暫停(&P)"
        '
        'StopScriptButton
        '
        Me.StopScriptButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.StopScriptButton.Enabled = False
        Me.StopScriptButton.Image = Global.綠色神手.My.Resources.Resources._1299247024_player_stop
        Me.StopScriptButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.StopScriptButton.Name = "StopScriptButton"
        Me.StopScriptButton.Size = New System.Drawing.Size(23, 22)
        Me.StopScriptButton.Text = "停止(&T)"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton5
        '
        Me.ToolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton5.Image = CType(resources.GetObject("ToolStripButton5.Image"), System.Drawing.Image)
        Me.ToolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton5.Name = "ToolStripButton5"
        Me.ToolStripButton5.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton5.Text = "滑鼠工具箱"
        '
        'ToolStripButton6
        '
        Me.ToolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton6.Image = CType(resources.GetObject("ToolStripButton6.Image"), System.Drawing.Image)
        Me.ToolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton6.Name = "ToolStripButton6"
        Me.ToolStripButton6.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton6.Text = "重複執行"
        '
        'ToolStripButton4
        '
        Me.ToolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton4.Image = CType(resources.GetObject("ToolStripButton4.Image"), System.Drawing.Image)
        Me.ToolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton4.Name = "ToolStripButton4"
        Me.ToolStripButton4.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton4.Text = "Feedback(&F)"
        '
        '說明LToolStripButton1
        '
        Me.說明LToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.說明LToolStripButton1.Image = CType(resources.GetObject("說明LToolStripButton1.Image"), System.Drawing.Image)
        Me.說明LToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.說明LToolStripButton1.Name = "說明LToolStripButton1"
        Me.說明LToolStripButton1.Size = New System.Drawing.Size(23, 22)
        Me.說明LToolStripButton1.Text = "說明(&L)"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DownLabel})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 527)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(768, 22)
        Me.StatusStrip1.TabIndex = 1
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'DownLabel
        '
        Me.DownLabel.Name = "DownLabel"
        Me.DownLabel.Size = New System.Drawing.Size(32, 17)
        Me.DownLabel.Text = "就緒"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.TabControl1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 25)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(190, 502)
        Me.Panel1.TabIndex = 0
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.FileMang)
        Me.TabControl1.Controls.Add(Me.ScriptHelp)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(190, 375)
        Me.TabControl1.TabIndex = 2
        '
        'FileMang
        '
        Me.FileMang.Controls.Add(Me.Button4)
        Me.FileMang.Controls.Add(Me.Button3)
        Me.FileMang.Controls.Add(Me.Button2)
        Me.FileMang.Controls.Add(Me.Button1)
        Me.FileMang.Controls.Add(Me.FileListBox)
        Me.FileMang.Location = New System.Drawing.Point(4, 22)
        Me.FileMang.Name = "FileMang"
        Me.FileMang.Padding = New System.Windows.Forms.Padding(3)
        Me.FileMang.Size = New System.Drawing.Size(182, 349)
        Me.FileMang.TabIndex = 0
        Me.FileMang.Text = "腳本管理員"
        Me.FileMang.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(10, 314)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 8
        Me.Button4.Text = "更名(&R)"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(10, 285)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 7
        Me.Button3.Text = "更新(&F)"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(93, 314)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 6
        Me.Button2.Text = "內容(&I)"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(93, 285)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "刪除(&D)"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'FileListBox
        '
        Me.FileListBox.FormattingEnabled = True
        Me.FileListBox.ItemHeight = 12
        Me.FileListBox.Location = New System.Drawing.Point(6, 6)
        Me.FileListBox.Name = "FileListBox"
        Me.FileListBox.Size = New System.Drawing.Size(170, 268)
        Me.FileListBox.TabIndex = 4
        '
        'ScriptHelp
        '
        Me.ScriptHelp.Controls.Add(Me.Button5)
        Me.ScriptHelp.Controls.Add(Me.ScriptHelperList)
        Me.ScriptHelp.Location = New System.Drawing.Point(4, 22)
        Me.ScriptHelp.Name = "ScriptHelp"
        Me.ScriptHelp.Padding = New System.Windows.Forms.Padding(3)
        Me.ScriptHelp.Size = New System.Drawing.Size(182, 349)
        Me.ScriptHelp.TabIndex = 1
        Me.ScriptHelp.Text = "語法助理"
        Me.ScriptHelp.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(6, 304)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(170, 23)
        Me.Button5.TabIndex = 6
        Me.Button5.Text = "插入選取項目(&I)"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'ScriptHelperList
        '
        Me.ScriptHelperList.FormattingEnabled = True
        Me.ScriptHelperList.ItemHeight = 12
        Me.ScriptHelperList.Items.AddRange(New Object() {"=====鍵盤=====", "按下(""KeyName"")", "放開(""KeyName"")", "按一下(""KeyName"")", "傳送字串(""String"")", "=====滑鼠=====", "移到(num,num)", "按一下左鍵()", "按一下右鍵()", "=====一般=====", "等待(ms)", "顯示訊息(""Msg"")", "警示音()", "呼叫程式(""Path"")", "開啟網址(""Url"")", "設定金鑰(""Prowl API"")", "推送訊息(""Title"",""Msg"")", "=====視窗=====", "鎖定目標(""WinText"")", "目標最大化()", "目標最小化()", "關閉目標()", "取得停駐點()", "=====敘述=====", "重複執行區段(times)", "如果此點顏色為(x,y,r,g,b)", "如果此點顏色不為(x,y,r,g,b)"})
        Me.ScriptHelperList.Location = New System.Drawing.Point(6, 6)
        Me.ScriptHelperList.Name = "ScriptHelperList"
        Me.ScriptHelperList.Size = New System.Drawing.Size(170, 292)
        Me.ScriptHelperList.TabIndex = 5
        '
        'ScriptText
        '
        Me.ScriptText.Dock = System.Windows.Forms.DockStyle.Right
        Me.ScriptText.Font = New System.Drawing.Font("新細明體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.ScriptText.Location = New System.Drawing.Point(186, 25)
        Me.ScriptText.Multiline = True
        Me.ScriptText.Name = "ScriptText"
        Me.ScriptText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.ScriptText.Size = New System.Drawing.Size(582, 502)
        Me.ScriptText.TabIndex = 3
        '
        'Hotkeys
        '
        Me.Hotkeys.Enabled = True
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(768, 549)
        Me.Controls.Add(Me.ScriptText)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(784, 587)
        Me.MinimumSize = New System.Drawing.Size(784, 587)
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "綠色神手"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.FileMang.ResumeLayout(False)
        Me.ScriptHelp.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ScriptRunner_BW As System.ComponentModel.BackgroundWorker
    Friend WithEvents 新增NToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents 開啟OToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents 儲存SToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents 剪下UToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents 複製CToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents 貼上PToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents 說明LToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton3 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents 新增NToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents 開啟OToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents 儲存SToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents toolStripSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents 剪下UToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents 複製CToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents 貼上PToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents toolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents 說明LToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents RunScriptButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents PauseScriptButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents StopScriptButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents ScriptText As System.Windows.Forms.TextBox
    Friend WithEvents DownLabel As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripButton4 As System.Windows.Forms.ToolStripButton
    Friend WithEvents Hotkeys As System.Windows.Forms.Timer
    Friend WithEvents ToolStripButton5 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton6 As System.Windows.Forms.ToolStripButton
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents FileMang As System.Windows.Forms.TabPage
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents FileListBox As System.Windows.Forms.ListBox
    Friend WithEvents ScriptHelp As System.Windows.Forms.TabPage
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents ScriptHelperList As System.Windows.Forms.ListBox

End Class
