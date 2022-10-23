Public Class Form2
    Public msg As String
    Public time As String
    Public week As Int16
    Public school As Boolean = False
    Public bus967 As Boolean = False
    Public c As Boolean = False
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.BackColor = Color.FromArgb(RGB(196, 224, 226))
        Label2.BackColor = Color.FromArgb(RGB(196, 224, 226))
        msg += vbCrLf
        Label1.Text = msg
        If school Then
            If week = 6 Then
                DataGridView1.DataSource = Me.SatSchoolBusBindingSource
                Me.Sat_SchoolBusTableAdapter.FillByTime(Me.TransportationDataSet.Sat_SchoolBus, time)
                If c Then
                    Try
                        Dim id As Int16 = Convert.ToInt16(DataGridView1.Rows(0).Cells(0).Value)
                        Me.Sat_SchoolBusTableAdapter.FillByC(Me.TransportationDataSet.Sat_SchoolBus, id - 3, id - 1)
                    Catch ex As Exception

                    End Try
                End If
            ElseIf week = 0 Then
                DataGridView1.DataSource = Me.SunSchoolBusBindingSource
                Me.Sun_SchoolBusTableAdapter.FillByTime(Me.TransportationDataSet.Sun_SchoolBus, time)
                If c Then
                    Try
                        Dim id As Int16 = Convert.ToInt16(DataGridView1.Rows(0).Cells(0).Value)
                        Me.Sun_SchoolBusTableAdapter.FillByC(Me.TransportationDataSet.Sun_SchoolBus, id - 3, id - 1)
                    Catch ex As Exception

                    End Try
                End If
            Else
                DataGridView1.DataSource = Me.WeekdaysSchoolBusBindingSource
                Me.Weekdays_SchoolBusTableAdapter.FillByTime(Me.TransportationDataSet.Weekdays_SchoolBus, time)
                If c Then
                    Try
                        Dim id As Int16 = Convert.ToInt16(DataGridView1.Rows(0).Cells(0).Value)
                        Me.Weekdays_SchoolBusTableAdapter.FillByC(Me.TransportationDataSet.Weekdays_SchoolBus, id - 3, id - 1)
                    Catch ex As Exception

                    End Try
                End If
            End If
        Else
            GroupBox1.Visible = False
        End If
        If bus967 Then
            If week = 6 Or week = 0 Then
                DataGridView2.DataSource = Me.Weekends9671BindingSource
                Me.Weekends_9671TableAdapter.FillByTime(Me.TransportationDataSet2.Weekends_9671, time)
                If c Then
                    Try
                        Dim id As Int16 = Convert.ToInt16(DataGridView2.Rows(0).Cells(0).Value)
                        Me.Weekends_9671TableAdapter.FillByC(Me.TransportationDataSet2.Weekends_9671, id - 3, id - 1)
                    Catch ex As Exception

                    End Try
                End If
            Else
                DataGridView2.DataSource = Me.Weekdays9671BindingSource
                Me.Weekdays_9671TableAdapter.FillByTime(Me.TransportationDataSet2.Weekdays_9671, time)
                If c Then
                    Try
                        Dim id As Int16 = Convert.ToInt16(DataGridView2.Rows(0).Cells(0).Value)
                        Me.Weekdays_9671TableAdapter.FillByC(Me.TransportationDataSet2.Weekdays_9671, id - 3, id - 1)
                    Catch ex As Exception

                    End Try
                End If
            End If

        Else
            GroupBox2.Visible = False
        End If
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class