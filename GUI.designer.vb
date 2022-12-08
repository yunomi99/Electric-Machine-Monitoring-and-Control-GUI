<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormTA
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormTA))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.PictureBoxConnectionInd = New System.Windows.Forms.PictureBox()
        Me.LabelStatus = New System.Windows.Forms.Label()
        Me.ButtonDisconnect = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboBoxBaudRate = New System.Windows.Forms.ComboBox()
        Me.ComboBoxPort = New System.Windows.Forms.ComboBox()
        Me.ButtonConnect = New System.Windows.Forms.Button()
        Me.ButtonScanPort = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.LabelIrd = New System.Windows.Forms.Label()
        Me.LabelTemp = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ComboBox_selang = New System.Windows.Forms.ComboBox()
        Me.ComboBox_time = New System.Windows.Forms.ComboBox()
        Me.LabelArus = New System.Windows.Forms.Label()
        Me.LabelTegangan = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.LabelRecord = New System.Windows.Forms.Label()
        Me.PictureBoxRecordInd = New System.Windows.Forms.PictureBox()
        Me.ButtonClear = New System.Windows.Forms.Button()
        Me.ButtonStopRecording = New System.Windows.Forms.Button()
        Me.ButtonStartRecording = New System.Windows.Forms.Button()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.ButtonLoad = New System.Windows.Forms.Button()
        Me.ButtonSaveToExcel = New System.Windows.Forms.Button()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.No = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Tegangan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Arus = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DAYA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TEMP = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Waktu = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Tanggal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.ZedGraphControl2 = New ZedGraph.ZedGraphControl()
        Me.ZedGraphControl1 = New ZedGraph.ZedGraphControl()
        Me.Label_now = New System.Windows.Forms.Label()
        Me.Label_temp = New System.Windows.Forms.Label()
        Me.Label_start = New System.Windows.Forms.Label()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.PictureBoxUNP = New System.Windows.Forms.PictureBox()
        Me.LabelWaktu = New System.Windows.Forms.Label()
        Me.LabelJudul = New System.Windows.Forms.Label()
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.TimerSerial = New System.Windows.Forms.Timer(Me.components)
        Me.TimerDataLogRecord = New System.Windows.Forms.Timer(Me.components)
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Labelsuhu = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBoxConnectionInd, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.PictureBoxRecordInd, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        CType(Me.PictureBoxUNP, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox8.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.PictureBoxConnectionInd)
        Me.GroupBox1.Controls.Add(Me.LabelStatus)
        Me.GroupBox1.Controls.Add(Me.ButtonDisconnect)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.ComboBoxBaudRate)
        Me.GroupBox1.Controls.Add(Me.ComboBoxPort)
        Me.GroupBox1.Controls.Add(Me.ButtonConnect)
        Me.GroupBox1.Controls.Add(Me.ButtonScanPort)
        Me.GroupBox1.Location = New System.Drawing.Point(824, 138)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Size = New System.Drawing.Size(378, 109)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Connection"
        '
        'PictureBoxConnectionInd
        '
        Me.PictureBoxConnectionInd.Image = Global.Desktop_TA.My.Resources.Resources.OFF
        Me.PictureBoxConnectionInd.Location = New System.Drawing.Point(344, 0)
        Me.PictureBoxConnectionInd.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBoxConnectionInd.Name = "PictureBoxConnectionInd"
        Me.PictureBoxConnectionInd.Size = New System.Drawing.Size(13, 12)
        Me.PictureBoxConnectionInd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBoxConnectionInd.TabIndex = 1
        Me.PictureBoxConnectionInd.TabStop = False
        '
        'LabelStatus
        '
        Me.LabelStatus.AutoSize = True
        Me.LabelStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LabelStatus.Location = New System.Drawing.Point(196, 0)
        Me.LabelStatus.Name = "LabelStatus"
        Me.LabelStatus.Size = New System.Drawing.Size(130, 17)
        Me.LabelStatus.TabIndex = 6
        Me.LabelStatus.Text = "Status : Disconnect"
        '
        'ButtonDisconnect
        '
        Me.ButtonDisconnect.Location = New System.Drawing.Point(201, 70)
        Me.ButtonDisconnect.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ButtonDisconnect.Name = "ButtonDisconnect"
        Me.ButtonDisconnect.Size = New System.Drawing.Size(167, 31)
        Me.ButtonDisconnect.TabIndex = 5
        Me.ButtonDisconnect.Text = "Disconnect"
        Me.ButtonDisconnect.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(197, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 17)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Baud Rate:"
        '
        'ComboBoxBaudRate
        '
        Me.ComboBoxBaudRate.FormattingEnabled = True
        Me.ComboBoxBaudRate.Items.AddRange(New Object() {"1200", "2400", "4800", "9600", "19200", "38400", "57600", "115200"})
        Me.ComboBoxBaudRate.Location = New System.Drawing.Point(279, 28)
        Me.ComboBoxBaudRate.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ComboBoxBaudRate.Name = "ComboBoxBaudRate"
        Me.ComboBoxBaudRate.Size = New System.Drawing.Size(89, 24)
        Me.ComboBoxBaudRate.TabIndex = 3
        '
        'ComboBoxPort
        '
        Me.ComboBoxPort.FormattingEnabled = True
        Me.ComboBoxPort.Location = New System.Drawing.Point(116, 27)
        Me.ComboBoxPort.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ComboBoxPort.Name = "ComboBoxPort"
        Me.ComboBoxPort.Size = New System.Drawing.Size(80, 24)
        Me.ComboBoxPort.TabIndex = 2
        '
        'ButtonConnect
        '
        Me.ButtonConnect.Location = New System.Drawing.Point(5, 70)
        Me.ButtonConnect.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ButtonConnect.Name = "ButtonConnect"
        Me.ButtonConnect.Size = New System.Drawing.Size(172, 31)
        Me.ButtonConnect.TabIndex = 1
        Me.ButtonConnect.Text = "Connect"
        Me.ButtonConnect.UseVisualStyleBackColor = True
        '
        'ButtonScanPort
        '
        Me.ButtonScanPort.Location = New System.Drawing.Point(5, 26)
        Me.ButtonScanPort.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ButtonScanPort.Name = "ButtonScanPort"
        Me.ButtonScanPort.Size = New System.Drawing.Size(108, 34)
        Me.ButtonScanPort.TabIndex = 0
        Me.ButtonScanPort.Text = "Scan Port"
        Me.ButtonScanPort.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.LabelIrd)
        Me.GroupBox2.Controls.Add(Me.LabelTemp)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.ComboBox_selang)
        Me.GroupBox2.Controls.Add(Me.ComboBox_time)
        Me.GroupBox2.Controls.Add(Me.LabelArus)
        Me.GroupBox2.Controls.Add(Me.LabelTegangan)
        Me.GroupBox2.Location = New System.Drawing.Point(1209, 138)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox2.Size = New System.Drawing.Size(244, 109)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Incoming Data"
        '
        'LabelIrd
        '
        Me.LabelIrd.AutoSize = True
        Me.LabelIrd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LabelIrd.Location = New System.Drawing.Point(104, 79)
        Me.LabelIrd.Name = "LabelIrd"
        Me.LabelIrd.Size = New System.Drawing.Size(67, 17)
        Me.LabelIrd.TabIndex = 11
        Me.LabelIrd.Text = "Waiting..."
        '
        'LabelTemp
        '
        Me.LabelTemp.AutoSize = True
        Me.LabelTemp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LabelTemp.Location = New System.Drawing.Point(104, 55)
        Me.LabelTemp.Name = "LabelTemp"
        Me.LabelTemp.Size = New System.Drawing.Size(67, 17)
        Me.LabelTemp.TabIndex = 10
        Me.LabelTemp.Text = "Waiting..."
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(14, 28)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 17)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Timer :"
        '
        'ComboBox_selang
        '
        Me.ComboBox_selang.FormattingEnabled = True
        Me.ComboBox_selang.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31", "32", "33", "34", "35", "36", "37", "38", "39", "40", "41", "42", "43", "44", "45", "46", "47", "48", "49", "50", "51", "52", "53", "54", "55", "56", "57", "58", "59", "60"})
        Me.ComboBox_selang.Location = New System.Drawing.Point(68, 25)
        Me.ComboBox_selang.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ComboBox_selang.Name = "ComboBox_selang"
        Me.ComboBox_selang.Size = New System.Drawing.Size(64, 24)
        Me.ComboBox_selang.TabIndex = 9
        '
        'ComboBox_time
        '
        Me.ComboBox_time.FormattingEnabled = True
        Me.ComboBox_time.Items.AddRange(New Object() {"Detik", "Menit"})
        Me.ComboBox_time.Location = New System.Drawing.Point(138, 25)
        Me.ComboBox_time.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ComboBox_time.Name = "ComboBox_time"
        Me.ComboBox_time.Size = New System.Drawing.Size(89, 24)
        Me.ComboBox_time.TabIndex = 7
        '
        'LabelArus
        '
        Me.LabelArus.AutoSize = True
        Me.LabelArus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LabelArus.Location = New System.Drawing.Point(14, 79)
        Me.LabelArus.Name = "LabelArus"
        Me.LabelArus.Size = New System.Drawing.Size(67, 17)
        Me.LabelArus.TabIndex = 8
        Me.LabelArus.Text = "Waiting..."
        '
        'LabelTegangan
        '
        Me.LabelTegangan.AutoSize = True
        Me.LabelTegangan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LabelTegangan.Location = New System.Drawing.Point(14, 55)
        Me.LabelTegangan.Name = "LabelTegangan"
        Me.LabelTegangan.Size = New System.Drawing.Size(67, 17)
        Me.LabelTegangan.TabIndex = 7
        Me.LabelTegangan.Text = "Waiting..."
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox3.Controls.Add(Me.LabelRecord)
        Me.GroupBox3.Controls.Add(Me.PictureBoxRecordInd)
        Me.GroupBox3.Controls.Add(Me.ButtonClear)
        Me.GroupBox3.Controls.Add(Me.ButtonStopRecording)
        Me.GroupBox3.Controls.Add(Me.ButtonStartRecording)
        Me.GroupBox3.Controls.Add(Me.RichTextBox1)
        Me.GroupBox3.Location = New System.Drawing.Point(824, 252)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox3.Size = New System.Drawing.Size(378, 100)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Control"
        '
        'LabelRecord
        '
        Me.LabelRecord.AutoSize = True
        Me.LabelRecord.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LabelRecord.Location = New System.Drawing.Point(196, 0)
        Me.LabelRecord.Name = "LabelRecord"
        Me.LabelRecord.Size = New System.Drawing.Size(132, 17)
        Me.LabelRecord.TabIndex = 8
        Me.LabelRecord.Text = "Status : Not Record"
        '
        'PictureBoxRecordInd
        '
        Me.PictureBoxRecordInd.Image = Global.Desktop_TA.My.Resources.Resources.PAUSE
        Me.PictureBoxRecordInd.Location = New System.Drawing.Point(344, 0)
        Me.PictureBoxRecordInd.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBoxRecordInd.Name = "PictureBoxRecordInd"
        Me.PictureBoxRecordInd.Size = New System.Drawing.Size(13, 12)
        Me.PictureBoxRecordInd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBoxRecordInd.TabIndex = 7
        Me.PictureBoxRecordInd.TabStop = False
        '
        'ButtonClear
        '
        Me.ButtonClear.Location = New System.Drawing.Point(5, 61)
        Me.ButtonClear.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ButtonClear.Name = "ButtonClear"
        Me.ButtonClear.Size = New System.Drawing.Size(366, 30)
        Me.ButtonClear.TabIndex = 9
        Me.ButtonClear.Text = "Clear Data Table"
        Me.ButtonClear.UseVisualStyleBackColor = True
        '
        'ButtonStopRecording
        '
        Me.ButtonStopRecording.Location = New System.Drawing.Point(199, 21)
        Me.ButtonStopRecording.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ButtonStopRecording.Name = "ButtonStopRecording"
        Me.ButtonStopRecording.Size = New System.Drawing.Size(172, 36)
        Me.ButtonStopRecording.TabIndex = 8
        Me.ButtonStopRecording.Text = "Stop Recording"
        Me.ButtonStopRecording.UseVisualStyleBackColor = True
        '
        'ButtonStartRecording
        '
        Me.ButtonStartRecording.Location = New System.Drawing.Point(5, 21)
        Me.ButtonStartRecording.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ButtonStartRecording.Name = "ButtonStartRecording"
        Me.ButtonStartRecording.Size = New System.Drawing.Size(172, 36)
        Me.ButtonStartRecording.TabIndex = 7
        Me.ButtonStartRecording.Text = "Start Recording"
        Me.ButtonStartRecording.UseVisualStyleBackColor = True
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Location = New System.Drawing.Point(16, 67)
        Me.RichTextBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.ReadOnly = True
        Me.RichTextBox1.Size = New System.Drawing.Size(25, 22)
        Me.RichTextBox1.TabIndex = 58
        Me.RichTextBox1.Text = ""
        '
        'GroupBox4
        '
        Me.GroupBox4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox4.Controls.Add(Me.ButtonLoad)
        Me.GroupBox4.Controls.Add(Me.ButtonSaveToExcel)
        Me.GroupBox4.Location = New System.Drawing.Point(1209, 252)
        Me.GroupBox4.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox4.Size = New System.Drawing.Size(244, 100)
        Me.GroupBox4.TabIndex = 3
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Export"
        '
        'ButtonLoad
        '
        Me.ButtonLoad.Location = New System.Drawing.Point(175, 31)
        Me.ButtonLoad.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ButtonLoad.Name = "ButtonLoad"
        Me.ButtonLoad.Size = New System.Drawing.Size(60, 64)
        Me.ButtonLoad.TabIndex = 11
        Me.ButtonLoad.Text = "Open File"
        Me.ButtonLoad.UseVisualStyleBackColor = True
        '
        'ButtonSaveToExcel
        '
        Me.ButtonSaveToExcel.Location = New System.Drawing.Point(5, 31)
        Me.ButtonSaveToExcel.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ButtonSaveToExcel.Name = "ButtonSaveToExcel"
        Me.ButtonSaveToExcel.Size = New System.Drawing.Size(164, 64)
        Me.ButtonSaveToExcel.TabIndex = 10
        Me.ButtonSaveToExcel.Text = "Save"
        Me.ButtonSaveToExcel.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox5.Controls.Add(Me.DataGridView1)
        Me.GroupBox5.Location = New System.Drawing.Point(824, 502)
        Me.GroupBox5.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox5.Size = New System.Drawing.Size(629, 289)
        Me.GroupBox5.TabIndex = 4
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Data Table View (Real-Time/Timer)"
        '
        'DataGridView1
        '
        Me.DataGridView1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.No, Me.Tegangan, Me.Arus, Me.DAYA, Me.TEMP, Me.Waktu, Me.Tanggal})
        Me.DataGridView1.Location = New System.Drawing.Point(0, 88)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 62
        Me.DataGridView1.RowTemplate.Height = 28
        Me.DataGridView1.Size = New System.Drawing.Size(614, 201)
        Me.DataGridView1.TabIndex = 57
        '
        'No
        '
        Me.No.FillWeight = 71.02273!
        Me.No.HeaderText = "No"
        Me.No.MinimumWidth = 8
        Me.No.Name = "No"
        '
        'Tegangan
        '
        Me.Tegangan.FillWeight = 107.2443!
        Me.Tegangan.HeaderText = "Tegangan (V)"
        Me.Tegangan.MinimumWidth = 8
        Me.Tegangan.Name = "Tegangan"
        '
        'Arus
        '
        Me.Arus.FillWeight = 107.2443!
        Me.Arus.HeaderText = "Arus (mA)"
        Me.Arus.MinimumWidth = 8
        Me.Arus.Name = "Arus"
        '
        'DAYA
        '
        Me.DAYA.FillWeight = 107.2443!
        Me.DAYA.HeaderText = "Daya (Watt)"
        Me.DAYA.MinimumWidth = 8
        Me.DAYA.Name = "DAYA"
        '
        'TEMP
        '
        Me.TEMP.FillWeight = 107.2443!
        Me.TEMP.HeaderText = "Suhu (Celcius)"
        Me.TEMP.MinimumWidth = 8
        Me.TEMP.Name = "TEMP"
        '
        'Waktu
        '
        Me.Waktu.HeaderText = "Waktu"
        Me.Waktu.MinimumWidth = 8
        Me.Waktu.Name = "Waktu"
        '
        'Tanggal
        '
        Me.Tanggal.HeaderText = "Tanggal"
        Me.Tanggal.MinimumWidth = 8
        Me.Tanggal.Name = "Tanggal"
        '
        'GroupBox6
        '
        Me.GroupBox6.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox6.Controls.Add(Me.ZedGraphControl2)
        Me.GroupBox6.Controls.Add(Me.ZedGraphControl1)
        Me.GroupBox6.Controls.Add(Me.Label_now)
        Me.GroupBox6.Controls.Add(Me.Label_temp)
        Me.GroupBox6.Controls.Add(Me.Label_start)
        Me.GroupBox6.Location = New System.Drawing.Point(11, 138)
        Me.GroupBox6.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox6.Size = New System.Drawing.Size(808, 653)
        Me.GroupBox6.TabIndex = 5
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Realtime Graph"
        '
        'ZedGraphControl2
        '
        Me.ZedGraphControl2.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ZedGraphControl2.Location = New System.Drawing.Point(9, 325)
        Me.ZedGraphControl2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ZedGraphControl2.Name = "ZedGraphControl2"
        Me.ZedGraphControl2.ScrollGrace = 0R
        Me.ZedGraphControl2.ScrollMaxX = 0R
        Me.ZedGraphControl2.ScrollMaxY = 0R
        Me.ZedGraphControl2.ScrollMaxY2 = 0R
        Me.ZedGraphControl2.ScrollMinX = 0R
        Me.ZedGraphControl2.ScrollMinY = 0R
        Me.ZedGraphControl2.ScrollMinY2 = 0R
        Me.ZedGraphControl2.Size = New System.Drawing.Size(793, 316)
        Me.ZedGraphControl2.TabIndex = 9
        '
        'ZedGraphControl1
        '
        Me.ZedGraphControl1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ZedGraphControl1.Location = New System.Drawing.Point(9, 20)
        Me.ZedGraphControl1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ZedGraphControl1.Name = "ZedGraphControl1"
        Me.ZedGraphControl1.ScrollGrace = 0R
        Me.ZedGraphControl1.ScrollMaxX = 0R
        Me.ZedGraphControl1.ScrollMaxY = 0R
        Me.ZedGraphControl1.ScrollMaxY2 = 0R
        Me.ZedGraphControl1.ScrollMinX = 0R
        Me.ZedGraphControl1.ScrollMinY = 0R
        Me.ZedGraphControl1.ScrollMinY2 = 0R
        Me.ZedGraphControl1.Size = New System.Drawing.Size(793, 297)
        Me.ZedGraphControl1.TabIndex = 8
        '
        'Label_now
        '
        Me.Label_now.AutoSize = True
        Me.Label_now.Location = New System.Drawing.Point(572, 189)
        Me.Label_now.Name = "Label_now"
        Me.Label_now.Size = New System.Drawing.Size(0, 17)
        Me.Label_now.TabIndex = 3
        '
        'Label_temp
        '
        Me.Label_temp.AutoSize = True
        Me.Label_temp.Location = New System.Drawing.Point(652, 200)
        Me.Label_temp.Name = "Label_temp"
        Me.Label_temp.Size = New System.Drawing.Size(0, 17)
        Me.Label_temp.TabIndex = 5
        '
        'Label_start
        '
        Me.Label_start.AutoSize = True
        Me.Label_start.Location = New System.Drawing.Point(652, 237)
        Me.Label_start.Name = "Label_start"
        Me.Label_start.Size = New System.Drawing.Size(0, 17)
        Me.Label_start.TabIndex = 4
        '
        'GroupBox7
        '
        Me.GroupBox7.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox7.AutoSize = True
        Me.GroupBox7.BackColor = System.Drawing.Color.PowderBlue
        Me.GroupBox7.Controls.Add(Me.PictureBoxUNP)
        Me.GroupBox7.Controls.Add(Me.LabelWaktu)
        Me.GroupBox7.Controls.Add(Me.LabelJudul)
        Me.GroupBox7.ForeColor = System.Drawing.SystemColors.InactiveBorder
        Me.GroupBox7.Location = New System.Drawing.Point(11, 7)
        Me.GroupBox7.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox7.Size = New System.Drawing.Size(1443, 127)
        Me.GroupBox7.TabIndex = 6
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "MES SOFTWARE DEVELOPTMENT"
        '
        'PictureBoxUNP
        '
        Me.PictureBoxUNP.Image = CType(resources.GetObject("PictureBoxUNP.Image"), System.Drawing.Image)
        Me.PictureBoxUNP.Location = New System.Drawing.Point(9, 26)
        Me.PictureBoxUNP.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBoxUNP.Name = "PictureBoxUNP"
        Me.PictureBoxUNP.Size = New System.Drawing.Size(89, 80)
        Me.PictureBoxUNP.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBoxUNP.TabIndex = 49
        Me.PictureBoxUNP.TabStop = False
        '
        'LabelWaktu
        '
        Me.LabelWaktu.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.LabelWaktu.AutoSize = True
        Me.LabelWaktu.ForeColor = System.Drawing.Color.Black
        Me.LabelWaktu.Location = New System.Drawing.Point(1284, 16)
        Me.LabelWaktu.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelWaktu.Name = "LabelWaktu"
        Me.LabelWaktu.Size = New System.Drawing.Size(146, 17)
        Me.LabelWaktu.TabIndex = 51
        Me.LabelWaktu.Text = "16 Okt 2017 16:00:00"
        Me.LabelWaktu.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'LabelJudul
        '
        Me.LabelJudul.AutoSize = True
        Me.LabelJudul.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelJudul.ForeColor = System.Drawing.Color.Black
        Me.LabelJudul.Location = New System.Drawing.Point(122, 33)
        Me.LabelJudul.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelJudul.Name = "LabelJudul"
        Me.LabelJudul.Size = New System.Drawing.Size(580, 72)
        Me.LabelJudul.TabIndex = 50
        Me.LabelJudul.Text = "INTERNET OF AUTOMATION SYSTEM" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "BLDC 1000W"
        Me.LabelJudul.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'SerialPort1
        '
        '
        'TimerSerial
        '
        Me.TimerSerial.Enabled = True
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.PaleGreen
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(337, 62)
        Me.Button1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(131, 65)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "CCW"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.PaleGreen
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(193, 62)
        Me.Button2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(131, 65)
        Me.Button2.TabIndex = 8
        Me.Button2.Text = "CW"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Yellow
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(5, 62)
        Me.Button3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(172, 65)
        Me.Button3.TabIndex = 9
        Me.Button3.Text = "KIRIM"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(150, 17)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "INPUT KECEPATAN"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(184, 28)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(127, 22)
        Me.TextBox1.TabIndex = 13
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label4.Location = New System.Drawing.Point(316, 31)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(38, 17)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "RPM"
        '
        'GroupBox8
        '
        Me.GroupBox8.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox8.Controls.Add(Me.Label5)
        Me.GroupBox8.Controls.Add(Me.Labelsuhu)
        Me.GroupBox8.Controls.Add(Me.Button4)
        Me.GroupBox8.Controls.Add(Me.Label4)
        Me.GroupBox8.Controls.Add(Me.TextBox1)
        Me.GroupBox8.Controls.Add(Me.Label2)
        Me.GroupBox8.Controls.Add(Me.Button3)
        Me.GroupBox8.Controls.Add(Me.Button2)
        Me.GroupBox8.Controls.Add(Me.Button1)
        Me.GroupBox8.Location = New System.Drawing.Point(824, 361)
        Me.GroupBox8.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox8.Size = New System.Drawing.Size(629, 137)
        Me.GroupBox8.TabIndex = 53
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "Control and Setting"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(375, 27)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(135, 25)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Temperature :"
        '
        'Labelsuhu
        '
        Me.Labelsuhu.AutoSize = True
        Me.Labelsuhu.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Labelsuhu.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Labelsuhu.Location = New System.Drawing.Point(534, 26)
        Me.Labelsuhu.Name = "Labelsuhu"
        Me.Labelsuhu.Size = New System.Drawing.Size(52, 29)
        Me.Labelsuhu.TabIndex = 16
        Me.Labelsuhu.Text = "0 C"
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.Red
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.Transparent
        Me.Button4.Location = New System.Drawing.Point(481, 62)
        Me.Button4.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(131, 65)
        Me.Button4.TabIndex = 15
        Me.Button4.Text = "STOP"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'FormTA
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1464, 840)
        Me.Controls.Add(Me.GroupBox8)
        Me.Controls.Add(Me.GroupBox7)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "FormTA"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Internet of Automation"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBoxConnectionInd, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.PictureBoxRecordInd, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        CType(Me.PictureBoxUNP, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox8.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents PictureBoxConnectionInd As PictureBox
    Friend WithEvents LabelStatus As Label
    Friend WithEvents ButtonDisconnect As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents ComboBoxPort As ComboBox
    Friend WithEvents ButtonConnect As Button
    Friend WithEvents ButtonScanPort As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents LabelArus As Label
    Friend WithEvents LabelTegangan As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents ButtonStopRecording As Button
    Friend WithEvents ButtonStartRecording As Button
    Friend WithEvents LabelRecord As Label
    Friend WithEvents PictureBoxRecordInd As PictureBox
    Friend WithEvents ButtonClear As Button
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents ButtonSaveToExcel As Button
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents GroupBox6 As GroupBox

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Friend WithEvents GroupBox7 As GroupBox
    Friend WithEvents PictureBoxUNP As PictureBox
    Friend WithEvents LabelWaktu As Label
    Friend WithEvents LabelJudul As Label
    Friend WithEvents SerialPort1 As IO.Ports.SerialPort
    Friend WithEvents TimerSerial As Timer
    Friend WithEvents TimerDataLogRecord As Timer
    Friend WithEvents ComboBoxBaudRate As ComboBox
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents ComboBox_selang As ComboBox
    Friend WithEvents ComboBox_time As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label_now As Label
    Friend WithEvents Label_temp As Label
    Friend WithEvents Label_start As Label
    Friend WithEvents ZedGraphControl1 As ZedGraph.ZedGraphControl
    Friend WithEvents ButtonLoad As Button
    Friend WithEvents ZedGraphControl2 As ZedGraph.ZedGraphControl
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents LabelIrd As Label
    Friend WithEvents LabelTemp As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents GroupBox8 As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Labelsuhu As Label
    Friend WithEvents Button4 As Button
    Friend WithEvents No As DataGridViewTextBoxColumn
    Friend WithEvents Tegangan As DataGridViewTextBoxColumn
    Friend WithEvents Arus As DataGridViewTextBoxColumn
    Friend WithEvents DAYA As DataGridViewTextBoxColumn
    Friend WithEvents TEMP As DataGridViewTextBoxColumn
    Friend WithEvents Waktu As DataGridViewTextBoxColumn
    Friend WithEvents Tanggal As DataGridViewTextBoxColumn
End Class
