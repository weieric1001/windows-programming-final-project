<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
    '請勿使用程式碼編輯器進行修改。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.TransportationDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TransportationDataSet = New FinalProject.TransportationDataSet()
        Me.SatSchoolBusBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Sat_SchoolBusTableAdapter = New FinalProject.TransportationDataSetTableAdapters.Sat_SchoolBusTableAdapter()
        Me.SunSchoolBusBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Sun_SchoolBusTableAdapter = New FinalProject.TransportationDataSetTableAdapters.Sun_SchoolBusTableAdapter()
        Me.WeekdaysSchoolBusBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Weekdays_SchoolBusTableAdapter = New FinalProject.TransportationDataSetTableAdapters.Weekdays_SchoolBusTableAdapter()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Weekends9671BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TransportationDataSet2BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TransportationDataSet2 = New FinalProject.TransportationDataSet2()
        Me.Weekdays9671BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Weekends_9671TableAdapter = New FinalProject.TransportationDataSet2TableAdapters.Weekends_9671TableAdapter()
        Me.Weekdays_9671TableAdapter = New FinalProject.TransportationDataSet2TableAdapters.Weekdays_9671TableAdapter()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TransportationDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TransportationDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SatSchoolBusBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SunSchoolBusBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WeekdaysSchoolBusBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Weekends9671BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TransportationDataSet2BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TransportationDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Weekdays9671BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(29, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 12)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Label1"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(6, 21)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(212, 154)
        Me.DataGridView1.TabIndex = 1
        '
        'TransportationDataSetBindingSource
        '
        Me.TransportationDataSetBindingSource.DataSource = Me.TransportationDataSet
        Me.TransportationDataSetBindingSource.Position = 0
        '
        'TransportationDataSet
        '
        Me.TransportationDataSet.DataSetName = "TransportationDataSet"
        Me.TransportationDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SatSchoolBusBindingSource
        '
        Me.SatSchoolBusBindingSource.DataMember = "Sat_SchoolBus"
        Me.SatSchoolBusBindingSource.DataSource = Me.TransportationDataSet
        '
        'Sat_SchoolBusTableAdapter
        '
        Me.Sat_SchoolBusTableAdapter.ClearBeforeFill = True
        '
        'SunSchoolBusBindingSource
        '
        Me.SunSchoolBusBindingSource.DataMember = "Sun_SchoolBus"
        Me.SunSchoolBusBindingSource.DataSource = Me.TransportationDataSetBindingSource
        '
        'Sun_SchoolBusTableAdapter
        '
        Me.Sun_SchoolBusTableAdapter.ClearBeforeFill = True
        '
        'WeekdaysSchoolBusBindingSource
        '
        Me.WeekdaysSchoolBusBindingSource.DataMember = "Weekdays_SchoolBus"
        Me.WeekdaysSchoolBusBindingSource.DataSource = Me.TransportationDataSetBindingSource
        '
        'Weekdays_SchoolBusTableAdapter
        '
        Me.Weekdays_SchoolBusTableAdapter.ClearBeforeFill = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackgroundImage = CType(resources.GetObject("GroupBox1.BackgroundImage"), System.Drawing.Image)
        Me.GroupBox1.Controls.Add(Me.DataGridView1)
        Me.GroupBox1.Location = New System.Drawing.Point(14, 72)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(224, 181)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "校車"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackgroundImage = CType(resources.GetObject("GroupBox2.BackgroundImage"), System.Drawing.Image)
        Me.GroupBox2.Controls.Add(Me.DataGridView2)
        Me.GroupBox2.Location = New System.Drawing.Point(263, 72)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(228, 181)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "967"
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToAddRows = False
        Me.DataGridView2.AllowUserToDeleteRows = False
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Location = New System.Drawing.Point(6, 21)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.ReadOnly = True
        Me.DataGridView2.RowTemplate.Height = 24
        Me.DataGridView2.Size = New System.Drawing.Size(212, 154)
        Me.DataGridView2.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(374, 269)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(107, 27)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "關閉查詢結果"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Weekends9671BindingSource
        '
        Me.Weekends9671BindingSource.DataMember = "Weekends_9671"
        Me.Weekends9671BindingSource.DataSource = Me.TransportationDataSet2BindingSource
        '
        'TransportationDataSet2BindingSource
        '
        Me.TransportationDataSet2BindingSource.DataSource = Me.TransportationDataSet2
        Me.TransportationDataSet2BindingSource.Position = 0
        '
        'TransportationDataSet2
        '
        Me.TransportationDataSet2.DataSetName = "TransportationDataSet2"
        Me.TransportationDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Weekdays9671BindingSource
        '
        Me.Weekdays9671BindingSource.DataMember = "Weekdays_9671"
        Me.Weekdays9671BindingSource.DataSource = Me.TransportationDataSet2BindingSource
        '
        'Weekends_9671TableAdapter
        '
        Me.Weekends_9671TableAdapter.ClearBeforeFill = True
        '
        'Weekdays_9671TableAdapter
        '
        Me.Weekdays_9671TableAdapter.ClearBeforeFill = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(29, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(209, 12)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "以下為查詢後最接近的三筆班次資料："
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.FinalProject.My.Resources.Resources.backcolor
        Me.ClientSize = New System.Drawing.Size(503, 318)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form2"
        Me.Text = "常庚即時通-查詢結果"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TransportationDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TransportationDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SatSchoolBusBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SunSchoolBusBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WeekdaysSchoolBusBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Weekends9671BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TransportationDataSet2BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TransportationDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Weekdays9671BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents TransportationDataSetBindingSource As BindingSource
    Friend WithEvents TransportationDataSet As TransportationDataSet
    Friend WithEvents SatSchoolBusBindingSource As BindingSource
    Friend WithEvents Sat_SchoolBusTableAdapter As TransportationDataSetTableAdapters.Sat_SchoolBusTableAdapter
    Friend WithEvents SunSchoolBusBindingSource As BindingSource
    Friend WithEvents Sun_SchoolBusTableAdapter As TransportationDataSetTableAdapters.Sun_SchoolBusTableAdapter
    Friend WithEvents WeekdaysSchoolBusBindingSource As BindingSource
    Friend WithEvents Weekdays_SchoolBusTableAdapter As TransportationDataSetTableAdapters.Weekdays_SchoolBusTableAdapter
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents TransportationDataSet2BindingSource As BindingSource
    Friend WithEvents TransportationDataSet2 As TransportationDataSet2
    Friend WithEvents Weekends9671BindingSource As BindingSource
    Friend WithEvents Weekends_9671TableAdapter As TransportationDataSet2TableAdapters.Weekends_9671TableAdapter
    Friend WithEvents Weekdays9671BindingSource As BindingSource
    Friend WithEvents Weekdays_9671TableAdapter As TransportationDataSet2TableAdapters.Weekdays_9671TableAdapter
    Friend WithEvents Label2 As Label
End Class
