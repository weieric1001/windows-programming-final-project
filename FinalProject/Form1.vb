Public Class Form1
    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged

    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        '--check
        If ComboBox1.SelectedIndex = -1 Then
            MsgBox("請選擇" + GroupBox2.Text + "！", 0 + 64, "參數錯誤")
            Exit Sub
        End If
        If CheckBox1.Checked = False And CheckBox2.Checked = False Then
            MsgBox("請選擇交通工具！", 0 + 64, "參數錯誤")
            Exit Sub
        End If

        '--value
        Dim week As Int16 = DateTimePicker1.Value.DayOfWeek
        Dim time As DateTime = DateTimePicker2.Value
        Dim msg As String
        Dim school As Boolean = False
        Dim bus967 As Boolean = False

        '--msg
        If RadioButton2.Checked Then
            msg = "您預計於 " + time + " 抵達" + ComboBox1.SelectedItem.ToString()
            time = time.AddMinutes(-10)
        Else
            msg = "您預計 " + time + " 出發於" + ComboBox1.SelectedItem.ToString()
        End If

        '--
        If CheckBox1.Checked Then
            school = True
        End If
        If CheckBox2.Checked Then
            bus967 = True
        End If

        '--change to form2
        Dim pForm2 As New Form2
        pForm2.msg = msg
        pForm2.time = time.ToString("HH:mm")
        pForm2.week = week
        pForm2.school = school
        pForm2.bus967 = bus967
        pForm2.c = RadioButton2.Checked
        Me.Hide()
        pForm2.ShowDialog()
        Me.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub RadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged, RadioButton1.CheckedChanged
        If RadioButton1.Checked Then
            GroupBox2.Text = "出發站"
        Else
            GroupBox2.Text = "目的地"
        End If
        Check()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Check()
    End Sub

    Private Sub Check()
        If RadioButton1.Checked = False And ComboBox1.SelectedIndex = 0 Then
            CheckBox2.Checked = False
            CheckBox2.Visible = False
        ElseIf RadioButton2.Checked = False And ComboBox1.SelectedIndex = 1 Then
            CheckBox2.Checked = False
            CheckBox2.Visible = False
        Else
            CheckBox2.Visible = True
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        DateTimePicker1.Value = DateTime.Now
        DateTimePicker2.Value = DateTime.Now
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        RadioButton2.Checked = False
        RadioButton1.Checked = True
        ComboBox1.SelectedIndex = -1
        CheckBox1.Checked = False
        CheckBox2.Checked = False
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If PictureBox1.Left > 270 Then
            PictureBox1.Left -= 1
        Else
            PictureBox1.Left = 380
        End If
    End Sub
End Class
