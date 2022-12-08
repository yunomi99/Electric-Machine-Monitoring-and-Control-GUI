Imports ZedGraph

Public Class FormTA
    Dim flag_masuk As Integer
    Dim flag_first As Integer
    Dim flag_terima As Integer

    Dim state_record As Boolean
    Dim state_connection As Boolean

    Dim time_last As Integer
    Dim time_temp As Integer
    Dim time_interval As Integer
    Dim time_now As Integer
    Dim time_set As Integer

    Dim tegangangraph As GraphPane
    Dim listtegangan As RollingPointPairList
    Dim tegangangraph_line As LineItem

    Dim arusgraph As GraphPane
    Dim listarus As RollingPointPairList
    Dim arusgraph_line As LineItem

    Dim starting_time As Double = 0

    Dim nilai_tegangan As Double
    Dim nilai_arus As Double
    Dim nilai_daya As Double
    Dim nilai_suhu As Double
    Dim nilai_ird As Double

    Dim s As String
    Dim sp() As String

    Dim sep As String

    Private Sub Form1_load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox_selang.Text = "1"
        ComboBox_time.Text = "Detik"

        sep = ","

        time_set = 0
        flag_terima = 0
        flag_first = 0
        flag_masuk = 0

        Me.CenterToScreen()
        ButtonDisconnect.Enabled = False
        ButtonConnect.Enabled = False
        ButtonStartRecording.Enabled = False
        ButtonStopRecording.Enabled = False
        ComboBoxBaudRate.SelectedIndex = 3

        tegangangraph = ZedGraphControl1.GraphPane
        tegangangraph.Title.Text = "Kurva Arus/time"
        tegangangraph.XAxis.Title.Text = "Time (s)"
        tegangangraph.YAxis.Title.Text = "Value of Current (I)"
        listtegangan = New RollingPointPairList(120)
        tegangangraph_line = tegangangraph.AddCurve("Voltage Graph", listtegangan, Color.Blue, SymbolType.None)
        'listtest = New RollingPointPairList(120)
        'estgraph_line = testgraph.AddCurve("Test", listtest, Color.Purple, SymbolType.None)

        arusgraph = ZedGraphControl2.GraphPane
        arusgraph.Title.Text = "Kurva Tegangan/time"
        arusgraph.XAxis.Title.Text = "Time (s)"
        arusgraph.YAxis.Title.Text = "Value of Voltage (V)"
        listarus = New RollingPointPairList(120)
        arusgraph_line = arusgraph.AddCurve("Current Graph", listarus, Color.Red, SymbolType.None)

    End Sub

    Private Sub ButtonScanPort_Click(sender As Object, e As EventArgs) Handles ButtonScanPort.Click
        ComboBoxPort.Items.Clear()
        Dim myPort As Array
        Dim i As Integer
        myPort = IO.Ports.SerialPort.GetPortNames()
        ComboBoxPort.Items.AddRange(myPort)
        i = ComboBoxPort.Items.Count
        i = i - i

        Try
            ComboBoxPort.SelectedIndex = i
            ButtonConnect.Enabled = True
        Catch ex As Exception
            MsgBox("COM PORT NOT DETECTED!", MsgBoxStyle.Critical, "Warning !!!")
            ComboBoxPort.Text = ""
            ComboBoxPort.Items.Clear()
            ButtonConnect.Enabled = False
            ButtonStartRecording.Enabled = False
            Return
        End Try
        ComboBoxPort.DroppedDown = True
    End Sub

    Private Sub ButtonConnect_Click(sender As Object, e As EventArgs) Handles ButtonConnect.Click
        PictureBoxConnectionInd.Image = My.Resources._ON
        LabelStatus.Text = "Status : Connected"
        PictureBoxConnectionInd.Visible = True
        ComboBoxPort.Enabled = False
        state_connection = True
        ComboBoxBaudRate.Enabled = False
        ButtonScanPort.Enabled = False
        ButtonConnect.Enabled = False
        ButtonDisconnect.Enabled = True
        ButtonStartRecording.Enabled = True
        ComboBox_time.Enabled = False
        ComboBox_selang.Enabled = False

        SerialPort1.BaudRate = ComboBoxBaudRate.SelectedItem
        SerialPort1.PortName = ComboBoxPort.SelectedItem
        SerialPort1.Open()
        SerialPort1.Write("c")


        flag_masuk = 1
        time_set = 0
        time_last = Val(Label_now.Text)
        If ComboBox_selang.Text = "60" Then
            time_interval = 1
        Else
            time_interval = Val(ComboBox_selang.Text)
        End If
        Label_start.Text = time_last

    End Sub

    Private Sub ButtonDisconnect_Click(sender As Object, e As EventArgs) Handles ButtonDisconnect.Click
        PictureBoxConnectionInd.Image = My.Resources.OFF
        PictureBoxConnectionInd.Visible = True
        PictureBoxRecordInd.Image = My.Resources.PAUSE
        LabelRecord.Text = "Status : Not Record"
        ComboBox_time.Enabled = True
        ComboBox_selang.Enabled = True
        LabelStatus.Text = "Status : Disconnect"
        LabelTegangan.Text = "Waiting..."
        LabelArus.Text = "Waiting..."
        LabelTemp.Text = "Waiting..."
        LabelIrd.Text = "Waiting..."
        state_connection = False
        state_record = False
        ComboBoxPort.Enabled = True
        ComboBoxBaudRate.Enabled = True
        ButtonScanPort.Enabled = True
        ButtonConnect.Enabled = True
        ButtonDisconnect.Enabled = False

        ButtonSaveToExcel.Enabled = True
        ButtonStopRecording.Enabled = False

        SerialPort1.Close()
    End Sub

    Private Sub ButtonStartRecording_Click(sender As Object, e As EventArgs) Handles ButtonStartRecording.Click
        PictureBoxRecordInd.Image = My.Resources.Record
        LabelRecord.text = "Status : Recording"
        PictureBoxRecordInd.Visible = True
        ButtonStartRecording.Enabled = False
        ButtonStopRecording.Enabled = True
        ButtonSaveToExcel.Enabled = True

        state_record = True
    End Sub

    Private Sub ButtonStopRecording_Click(sender As Object, e As EventArgs) Handles ButtonStopRecording.Click
        PictureBoxRecordInd.Image = My.Resources.PAUSE
        LabelRecord.text = "Status : Not Record"
        PictureBoxRecordInd.Visible = True
        ButtonStartRecording.Enabled = True
        ButtonStopRecording.Enabled = False
        PictureBoxRecordInd.Visible = True

        state_record = False
    End Sub

    Private Sub ButtonSaveToExcel_Click(sender As Object, e As EventArgs) Handles ButtonSaveToExcel.Click
        SaveFileDialog1.Filter = "csv files (*.csv)|*.csv"

        SaveFileDialog1.FileName = String.Format(DateTime.Now.ToString("HHmmss dd MMMM yyy"), "{0}.csv")

        If SaveFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK And SaveFileDialog1.FileName.Length > 0 Then
            RichTextBox1.SaveFile(SaveFileDialog1.FileName, RichTextBoxStreamType.PlainText)
        End If
    End Sub

    Private Sub SerialPort1_DataReceived(sender As Object, e As IO.Ports.SerialDataReceivedEventArgs) Handles SerialPort1.DataReceived
        Dim str As String
        str = SerialPort1.ReadLine()
        s = str
        sp = s.Split(";")
        nilai_tegangan = Val(sp(0))
        nilai_arus = Val(sp(1))
        nilai_daya = nilai_arus * nilai_tegangan
        nilai_suhu = Val(sp(2))
        nilai_ird = Val(sp(3))

        flag_terima = 1
    End Sub

    Private Sub ButtonClear_Click(sender As Object, e As EventArgs) Handles ButtonClear.Click
        RichTextBox1.AppendText("Tegangan (V)" + sep + "Arus (mA)" + sep + "Daya (Watt)" + sep + "Suhu (Celcius)" + sep + "Irradiation" + sep + "Waktu" + sep + "Tanggal" + vbNewLine)
        DataGridView1.Rows.Clear()
        RichTextBox1.Clear()
    End Sub

    Private Sub TimerSerial_Tick(sender As Object, e As EventArgs) Handles TimerSerial.Tick
        LabelWaktu.Text = DateTime.Now.ToString("dd MMM yyyy HH:mm:ss")



        If ComboBox_selang.Text = "60" Then
            If ComboBox_time.Text = "Menit" Then
                Label_now.Text = Val(TimeOfDay.ToString("HH"))
            Else
                Label_now.Text = Val(TimeOfDay.ToString("mm"))
            End If
        Else
            If ComboBox_time.Text = "Menit" Then
                Label_now.Text = Val(TimeOfDay.ToString("mm"))
            Else
                Label_now.Text = Val(TimeOfDay.ToString("ss"))
            End If
        End If

        If flag_masuk = 1 Then
            If flag_terima = 1 Then
                flag_terima = 0
                LabelTegangan.Text = "V   : " + nilai_tegangan.ToString("0.00")
                LabelArus.Text = " I   : " + nilai_arus.ToString("0.00")
                LabelTemp.Text = "Suhu : " + nilai_suhu.ToString("0.00")
                LabelIrd.Text = "Ird  : " + nilai_ird.ToString("0.00")

                If flag_first = 0 Then
                    flag_first = 1
                    RichTextBox1.AppendText("Tegangan (V)" + sep + "Arus (mA)" + sep + "Daya (Watt)" + sep + "Suhu (Celcius)" + sep + "Irradiation" + sep + "Waktu" + sep + "Tanggal" + vbNewLine)
                End If
            End If


            If time_set = 0 Then
                time_set = 1
                time_temp = time_last + time_interval
                If time_temp >= 60 Then
                    time_temp = time_temp - 60
                End If

                If nilai_daya > 0 Then
                    Call TimerZedgraph()
                    Call TimerZedgraph2()
                End If

                If state_record = True Then
                    Call Isi_data_log()
                    Call Isi_rich_text()
                End If

            End If

            Label_temp.Text = time_temp
            Label_start.Text = time_last
            time_now = Val(Label_now.Text)

            If time_now = time_temp Then
                Try
                    time_last = time_temp
                    SerialPort1.Write("c")
                    time_set = 0

                Catch
                    state_connection = False
                    flag_masuk = 0
                    If SerialPort1.IsOpen Then
                        SerialPort1.Close()
                    End If
                End Try
            End If
        End If
    End Sub


    Private Sub ButtonLoad_Click(sender As Object, e As EventArgs) Handles ButtonLoad.Click
        Process.Start(Environment.CurrentDirectory + "\\Backup\\")
    End Sub

    Sub Isi_data_log()
        DataGridView1.Rows.Add(New String() {DataGridView1.RowCount, nilai_tegangan, nilai_arus, nilai_daya, nilai_suhu, nilai_ird, DateTime.Now.ToString("HH:mm:ss"), DateTime.Now.ToString("dd MMM yyyy")})
        Me.DataGridView1.FirstDisplayedScrollingRowIndex = Me.DataGridView1.RowCount - 1
    End Sub

    Sub Isi_rich_text()
        RichTextBox1.AppendText(nilai_tegangan.ToString() + sep + nilai_arus.ToString() + sep + nilai_daya.toString() + sep + nilai_suhu.toString() + sep + nilai_ird.toString + sep + DateTime.Now.ToString("HH:mm:ss") + sep + DateTime.Now.ToString("dd MMM yyyy") + vbNewLine)
        RichTextBox1.ScrollToCaret()
    End Sub


    Sub TimerZedgraph()
        Dim xScale As Scale
        Dim yScale As Scale
        Dim kurvaSuhu As LineItem = ZedGraphControl1.GraphPane.CurveList(0)

        Dim list As IPointListEdit

        list = kurvaSuhu.Points

        list.Add(nilai_tegangan, nilai_arus)

        yScale = ZedGraphControl1.GraphPane.YAxis.Scale
        yScale.Min = 0

        xScale = ZedGraphControl1.GraphPane.XAxis.Scale
        xScale.Min = 0
        xScale.Max = 1

        ZedGraphControl1.AxisChange()
        ZedGraphControl1.Invalidate()
    End Sub

    Sub TimerZedgraph2()
        Dim yScale As Scale
        Dim xScale As Scale
        Dim kurvaSuhu1 As LineItem = ZedGraphControl2.GraphPane.CurveList(0)
        Dim list1 As IPointListEdit

        list1 = kurvaSuhu1.Points

        list1.Add(nilai_tegangan, nilai_daya)

        yScale = ZedGraphControl2.GraphPane.YAxis.Scale
        yScale.Min = 0

        xScale = ZedGraphControl2.GraphPane.XAxis.Scale
        xScale.Min = 0
        xScale.Max = 1

        ZedGraphControl2.AxisChange()
        ZedGraphControl2.Invalidate()
    End Sub


End Class
