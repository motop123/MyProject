<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class prosmotr
    Inherits System.Windows.Forms.Form

    'Форма переопределяет dispose для очистки списка компонентов.
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

    'Является обязательной для конструктора форм Windows Forms
    Private components As System.ComponentModel.IContainer

    'Примечание: следующая процедура является обязательной для конструктора форм Windows Forms
    'Для ее изменения используйте конструктор форм Windows Form.  
    'Не изменяйте ее в редакторе исходного кода.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(prosmotr))
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.ПрививкаBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.animalBDDataSet = New ZelZooExpo.animalBDDataSet()
        Me.закрыть = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.DTP_D2 = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DTP_D1 = New System.Windows.Forms.DateTimePicker()
        Me.поиск_по_периоду = New System.Windows.Forms.Button()
        Me.report_button = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.поиск_владельцев = New System.Windows.Forms.ComboBox()
        Me.ВладельцыBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ПоискВладельцев = New System.Windows.Forms.Button()
        Me.DGV_Владельцы_просмотр = New System.Windows.Forms.DataGridView()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.DTP_паспорт_имплант2 = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.DTP_паспорт_имплант1 = New System.Windows.Forms.DateTimePicker()
        Me.паспорт_дата_имплант_поиск = New System.Windows.Forms.Button()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.DTP_паспорт_ДатаРОЖД_КОНЕЦ = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DTP_паспорт_ДатаРОЖД_НАЧАЛО = New System.Windows.Forms.DateTimePicker()
        Me.паспорт_дата_рожд_поиск = New System.Windows.Forms.Button()
        Me.report_Button2 = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.ПаспортживотногоBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.поиск_по_кличкам_животного = New System.Windows.Forms.Button()
        Me.DGV_паспорт_животного = New System.Windows.Forms.DataGridView()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.Картинка = New System.Windows.Forms.PictureBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.DTP_вет_срок2 = New System.Windows.Forms.DateTimePicker()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.DTP_вет_срок1 = New System.Windows.Forms.DateTimePicker()
        Me.поиск_срок = New System.Windows.Forms.Button()
        Me.GroupBox9 = New System.Windows.Forms.GroupBox()
        Me.DTP_вет_дата_принятия2 = New System.Windows.Forms.DateTimePicker()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.DTP_вет_дата_принятия1 = New System.Windows.Forms.DateTimePicker()
        Me.поиск_дата_прин = New System.Windows.Forms.Button()
        Me.report_button3 = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.поиск_по_кличкам_животных_вет_свид = New System.Windows.Forms.Button()
        Me.DGV_ветеринарное_свидетельство = New System.Windows.Forms.DataGridView()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.GroupBox10 = New System.Windows.Forms.GroupBox()
        Me.DTP_прошлое2 = New System.Windows.Forms.DateTimePicker()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.DTP_прошлое1 = New System.Windows.Forms.DateTimePicker()
        Me.поиск_прош = New System.Windows.Forms.Button()
        Me.GroupBox11 = New System.Windows.Forms.GroupBox()
        Me.DTP_получ2 = New System.Windows.Forms.DateTimePicker()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.DTP_получ1 = New System.Windows.Forms.DateTimePicker()
        Me.Поиск_получ = New System.Windows.Forms.Button()
        Me.report_button4 = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.ComboBox3 = New System.Windows.Forms.ComboBox()
        Me.принять_поиск_по_кличкам_награды = New System.Windows.Forms.Button()
        Me.DGV_Награды = New System.Windows.Forms.DataGridView()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.report2 = New System.Windows.Forms.Button()
        Me.report1 = New System.Windows.Forms.Button()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ПрививкаTableAdapter = New ZelZooExpo.animalBDDataSetTableAdapters.ПрививкаTableAdapter()
        Me.ВладельцыTableAdapter = New ZelZooExpo.animalBDDataSetTableAdapters.ВладельцыTableAdapter()
        Me.Паспорт_животногоTableAdapter = New ZelZooExpo.animalBDDataSetTableAdapters.Паспорт_животногоTableAdapter()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        CType(Me.ПрививкаBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.animalBDDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.ВладельцыBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGV_Владельцы_просмотр, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.ПаспортживотногоBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGV_паспорт_животного, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        CType(Me.Картинка, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox8.SuspendLayout()
        Me.GroupBox9.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.DGV_ветеринарное_свидетельство, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage4.SuspendLayout()
        Me.GroupBox10.SuspendLayout()
        Me.GroupBox11.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.DGV_Награды, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage5.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ПрививкаBindingSource
        '
        Me.ПрививкаBindingSource.DataMember = "Прививка"
        Me.ПрививкаBindingSource.DataSource = Me.animalBDDataSet
        '
        'animalBDDataSet
        '
        Me.animalBDDataSet.DataSetName = "animalBDDataSet"
        Me.animalBDDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'закрыть
        '
        Me.закрыть.BackColor = System.Drawing.SystemColors.Window
        Me.закрыть.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
        Me.закрыть.Location = New System.Drawing.Point(13, 611)
        Me.закрыть.Name = "закрыть"
        Me.закрыть.Size = New System.Drawing.Size(75, 23)
        Me.закрыть.TabIndex = 0
        Me.закрыть.Text = "Закрыть"
        Me.закрыть.UseVisualStyleBackColor = False
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Controls.Add(Me.TabPage5)
        Me.TabControl1.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
        Me.TabControl1.Location = New System.Drawing.Point(12, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1233, 593)
        Me.TabControl1.TabIndex = 1
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.GroupBox5)
        Me.TabPage1.Controls.Add(Me.report_button)
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Controls.Add(Me.DGV_Владельцы_просмотр)
        Me.TabPage1.Location = New System.Drawing.Point(4, 24)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1225, 565)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Владельцы"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.DTP_D2)
        Me.GroupBox5.Controls.Add(Me.Label2)
        Me.GroupBox5.Controls.Add(Me.Label1)
        Me.GroupBox5.Controls.Add(Me.DTP_D1)
        Me.GroupBox5.Controls.Add(Me.поиск_по_периоду)
        Me.GroupBox5.Location = New System.Drawing.Point(942, 98)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(262, 100)
        Me.GroupBox5.TabIndex = 6
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "По периоду, дата рождения Владельцев"
        '
        'DTP_D2
        '
        Me.DTP_D2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTP_D2.Location = New System.Drawing.Point(144, 22)
        Me.DTP_D2.Name = "DTP_D2"
        Me.DTP_D2.Size = New System.Drawing.Size(82, 22)
        Me.DTP_D2.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(116, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(22, 15)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "По"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(16, 15)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "С"
        '
        'DTP_D1
        '
        Me.DTP_D1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTP_D1.Location = New System.Drawing.Point(28, 22)
        Me.DTP_D1.Name = "DTP_D1"
        Me.DTP_D1.Size = New System.Drawing.Size(82, 22)
        Me.DTP_D1.TabIndex = 4
        '
        'поиск_по_периоду
        '
        Me.поиск_по_периоду.BackColor = System.Drawing.SystemColors.Window
        Me.поиск_по_периоду.Location = New System.Drawing.Point(9, 71)
        Me.поиск_по_периоду.Name = "поиск_по_периоду"
        Me.поиск_по_периоду.Size = New System.Drawing.Size(240, 23)
        Me.поиск_по_периоду.TabIndex = 3
        Me.поиск_по_периоду.Text = "Поиск"
        Me.поиск_по_периоду.UseVisualStyleBackColor = False
        '
        'report_button
        '
        Me.report_button.BackColor = System.Drawing.SystemColors.Window
        Me.report_button.Location = New System.Drawing.Point(951, 536)
        Me.report_button.Name = "report_button"
        Me.report_button.Size = New System.Drawing.Size(262, 23)
        Me.report_button.TabIndex = 2
        Me.report_button.Text = "Создать отчёт"
        Me.report_button.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.поиск_владельцев)
        Me.GroupBox1.Controls.Add(Me.ПоискВладельцев)
        Me.GroupBox1.Location = New System.Drawing.Point(936, 7)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(283, 85)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Сортирвка и Поиск"
        '
        'поиск_владельцев
        '
        Me.поиск_владельцев.DataSource = Me.ВладельцыBindingSource
        Me.поиск_владельцев.DisplayMember = "ФИО"
        Me.поиск_владельцев.FormattingEnabled = True
        Me.поиск_владельцев.Location = New System.Drawing.Point(6, 20)
        Me.поиск_владельцев.Name = "поиск_владельцев"
        Me.поиск_владельцев.Size = New System.Drawing.Size(262, 23)
        Me.поиск_владельцев.TabIndex = 7
        Me.поиск_владельцев.ValueMember = "ID_Владельца"
        '
        'ВладельцыBindingSource
        '
        Me.ВладельцыBindingSource.DataMember = "Владельцы"
        Me.ВладельцыBindingSource.DataSource = Me.animalBDDataSet
        '
        'ПоискВладельцев
        '
        Me.ПоискВладельцев.BackColor = System.Drawing.SystemColors.Window
        Me.ПоискВладельцев.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
        Me.ПоискВладельцев.Location = New System.Drawing.Point(6, 49)
        Me.ПоискВладельцев.Name = "ПоискВладельцев"
        Me.ПоискВладельцев.Size = New System.Drawing.Size(262, 23)
        Me.ПоискВладельцев.TabIndex = 3
        Me.ПоискВладельцев.Text = "Поиск / Сортировать"
        Me.ПоискВладельцев.UseVisualStyleBackColor = False
        '
        'DGV_Владельцы_просмотр
        '
        Me.DGV_Владельцы_просмотр.AllowUserToAddRows = False
        Me.DGV_Владельцы_просмотр.AllowUserToDeleteRows = False
        Me.DGV_Владельцы_просмотр.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DGV_Владельцы_просмотр.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_Владельцы_просмотр.Location = New System.Drawing.Point(7, 7)
        Me.DGV_Владельцы_просмотр.Name = "DGV_Владельцы_просмотр"
        Me.DGV_Владельцы_просмотр.Size = New System.Drawing.Size(922, 552)
        Me.DGV_Владельцы_просмотр.TabIndex = 0
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.GroupBox7)
        Me.TabPage2.Controls.Add(Me.GroupBox6)
        Me.TabPage2.Controls.Add(Me.report_Button2)
        Me.TabPage2.Controls.Add(Me.GroupBox2)
        Me.TabPage2.Controls.Add(Me.DGV_паспорт_животного)
        Me.TabPage2.Location = New System.Drawing.Point(4, 24)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1225, 565)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Паспорт животного"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.DTP_паспорт_имплант2)
        Me.GroupBox7.Controls.Add(Me.Label5)
        Me.GroupBox7.Controls.Add(Me.Label6)
        Me.GroupBox7.Controls.Add(Me.DTP_паспорт_имплант1)
        Me.GroupBox7.Controls.Add(Me.паспорт_дата_имплант_поиск)
        Me.GroupBox7.Location = New System.Drawing.Point(937, 208)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(281, 100)
        Me.GroupBox7.TabIndex = 8
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "По периоду, дата имплантации чипа"
        '
        'DTP_паспорт_имплант2
        '
        Me.DTP_паспорт_имплант2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTP_паспорт_имплант2.Location = New System.Drawing.Point(144, 22)
        Me.DTP_паспорт_имплант2.Name = "DTP_паспорт_имплант2"
        Me.DTP_паспорт_имплант2.Size = New System.Drawing.Size(82, 22)
        Me.DTP_паспорт_имплант2.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(116, 28)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(22, 15)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "По"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 28)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(16, 15)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "С"
        '
        'DTP_паспорт_имплант1
        '
        Me.DTP_паспорт_имплант1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTP_паспорт_имплант1.Location = New System.Drawing.Point(28, 22)
        Me.DTP_паспорт_имплант1.Name = "DTP_паспорт_имплант1"
        Me.DTP_паспорт_имплант1.Size = New System.Drawing.Size(82, 22)
        Me.DTP_паспорт_имплант1.TabIndex = 4
        '
        'паспорт_дата_имплант_поиск
        '
        Me.паспорт_дата_имплант_поиск.BackColor = System.Drawing.SystemColors.Window
        Me.паспорт_дата_имплант_поиск.Location = New System.Drawing.Point(9, 71)
        Me.паспорт_дата_имплант_поиск.Name = "паспорт_дата_имплант_поиск"
        Me.паспорт_дата_имплант_поиск.Size = New System.Drawing.Size(253, 23)
        Me.паспорт_дата_имплант_поиск.TabIndex = 3
        Me.паспорт_дата_имплант_поиск.Text = "Поиск"
        Me.паспорт_дата_имплант_поиск.UseVisualStyleBackColor = False
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.DTP_паспорт_ДатаРОЖД_КОНЕЦ)
        Me.GroupBox6.Controls.Add(Me.Label3)
        Me.GroupBox6.Controls.Add(Me.Label4)
        Me.GroupBox6.Controls.Add(Me.DTP_паспорт_ДатаРОЖД_НАЧАЛО)
        Me.GroupBox6.Controls.Add(Me.паспорт_дата_рожд_поиск)
        Me.GroupBox6.Location = New System.Drawing.Point(937, 102)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(281, 100)
        Me.GroupBox6.TabIndex = 7
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "По периоду, дата рождения Животных"
        '
        'DTP_паспорт_ДатаРОЖД_КОНЕЦ
        '
        Me.DTP_паспорт_ДатаРОЖД_КОНЕЦ.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTP_паспорт_ДатаРОЖД_КОНЕЦ.Location = New System.Drawing.Point(144, 22)
        Me.DTP_паспорт_ДатаРОЖД_КОНЕЦ.Name = "DTP_паспорт_ДатаРОЖД_КОНЕЦ"
        Me.DTP_паспорт_ДатаРОЖД_КОНЕЦ.Size = New System.Drawing.Size(82, 22)
        Me.DTP_паспорт_ДатаРОЖД_КОНЕЦ.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(116, 28)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(22, 15)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "По"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 28)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(16, 15)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "С"
        '
        'DTP_паспорт_ДатаРОЖД_НАЧАЛО
        '
        Me.DTP_паспорт_ДатаРОЖД_НАЧАЛО.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTP_паспорт_ДатаРОЖД_НАЧАЛО.Location = New System.Drawing.Point(28, 22)
        Me.DTP_паспорт_ДатаРОЖД_НАЧАЛО.Name = "DTP_паспорт_ДатаРОЖД_НАЧАЛО"
        Me.DTP_паспорт_ДатаРОЖД_НАЧАЛО.Size = New System.Drawing.Size(82, 22)
        Me.DTP_паспорт_ДатаРОЖД_НАЧАЛО.TabIndex = 4
        '
        'паспорт_дата_рожд_поиск
        '
        Me.паспорт_дата_рожд_поиск.BackColor = System.Drawing.SystemColors.Window
        Me.паспорт_дата_рожд_поиск.Location = New System.Drawing.Point(9, 71)
        Me.паспорт_дата_рожд_поиск.Name = "паспорт_дата_рожд_поиск"
        Me.паспорт_дата_рожд_поиск.Size = New System.Drawing.Size(253, 23)
        Me.паспорт_дата_рожд_поиск.TabIndex = 3
        Me.паспорт_дата_рожд_поиск.Text = "Поиск"
        Me.паспорт_дата_рожд_поиск.UseVisualStyleBackColor = False
        '
        'report_Button2
        '
        Me.report_Button2.BackColor = System.Drawing.SystemColors.Window
        Me.report_Button2.Location = New System.Drawing.Point(941, 534)
        Me.report_Button2.Name = "report_Button2"
        Me.report_Button2.Size = New System.Drawing.Size(262, 23)
        Me.report_Button2.TabIndex = 6
        Me.report_Button2.Text = "Создать отчёт"
        Me.report_Button2.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.ComboBox1)
        Me.GroupBox2.Controls.Add(Me.поиск_по_кличкам_животного)
        Me.GroupBox2.Location = New System.Drawing.Point(935, 6)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(283, 90)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Сортирвка и Поиск"
        '
        'ComboBox1
        '
        Me.ComboBox1.DataSource = Me.ПаспортживотногоBindingSource
        Me.ComboBox1.DisplayMember = "Кличка"
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(6, 21)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(258, 23)
        Me.ComboBox1.TabIndex = 8
        Me.ComboBox1.ValueMember = "ID_Животного"
        '
        'ПаспортживотногоBindingSource
        '
        Me.ПаспортживотногоBindingSource.DataMember = "Паспорт_животного"
        Me.ПаспортживотногоBindingSource.DataSource = Me.animalBDDataSet
        '
        'поиск_по_кличкам_животного
        '
        Me.поиск_по_кличкам_животного.BackColor = System.Drawing.SystemColors.Window
        Me.поиск_по_кличкам_животного.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
        Me.поиск_по_кличкам_животного.Location = New System.Drawing.Point(6, 49)
        Me.поиск_по_кличкам_животного.Name = "поиск_по_кличкам_животного"
        Me.поиск_по_кличкам_животного.Size = New System.Drawing.Size(258, 23)
        Me.поиск_по_кличкам_животного.TabIndex = 7
        Me.поиск_по_кличкам_животного.Text = "Поиск / Сортировать"
        Me.поиск_по_кличкам_животного.UseVisualStyleBackColor = False
        '
        'DGV_паспорт_животного
        '
        Me.DGV_паспорт_животного.AllowUserToAddRows = False
        Me.DGV_паспорт_животного.AllowUserToDeleteRows = False
        Me.DGV_паспорт_животного.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DGV_паспорт_животного.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_паспорт_животного.Location = New System.Drawing.Point(6, 6)
        Me.DGV_паспорт_животного.Name = "DGV_паспорт_животного"
        Me.DGV_паспорт_животного.ReadOnly = True
        Me.DGV_паспорт_животного.Size = New System.Drawing.Size(922, 551)
        Me.DGV_паспорт_животного.TabIndex = 4
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.Картинка)
        Me.TabPage3.Controls.Add(Me.TextBox2)
        Me.TabPage3.Controls.Add(Me.TextBox1)
        Me.TabPage3.Controls.Add(Me.GroupBox8)
        Me.TabPage3.Controls.Add(Me.GroupBox9)
        Me.TabPage3.Controls.Add(Me.report_button3)
        Me.TabPage3.Controls.Add(Me.GroupBox3)
        Me.TabPage3.Controls.Add(Me.DGV_ветеринарное_свидетельство)
        Me.TabPage3.Location = New System.Drawing.Point(4, 24)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(1225, 565)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Ветеринарное  свидетельство"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'Картинка
        '
        Me.Картинка.Location = New System.Drawing.Point(941, 347)
        Me.Картинка.Name = "Картинка"
        Me.Картинка.Size = New System.Drawing.Size(120, 120)
        Me.Картинка.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.Картинка.TabIndex = 15
        Me.Картинка.TabStop = False
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(1057, 310)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 22)
        Me.TextBox2.TabIndex = 14
        Me.TextBox2.Visible = False
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(941, 310)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 22)
        Me.TextBox1.TabIndex = 13
        Me.TextBox1.Visible = False
        '
        'GroupBox8
        '
        Me.GroupBox8.Controls.Add(Me.DTP_вет_срок2)
        Me.GroupBox8.Controls.Add(Me.Label7)
        Me.GroupBox8.Controls.Add(Me.Label8)
        Me.GroupBox8.Controls.Add(Me.DTP_вет_срок1)
        Me.GroupBox8.Controls.Add(Me.поиск_срок)
        Me.GroupBox8.Location = New System.Drawing.Point(938, 204)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(281, 100)
        Me.GroupBox8.TabIndex = 12
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "По периоду, срок дейсвия прививки"
        '
        'DTP_вет_срок2
        '
        Me.DTP_вет_срок2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTP_вет_срок2.Location = New System.Drawing.Point(144, 22)
        Me.DTP_вет_срок2.Name = "DTP_вет_срок2"
        Me.DTP_вет_срок2.Size = New System.Drawing.Size(82, 22)
        Me.DTP_вет_срок2.TabIndex = 7
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(116, 28)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(22, 15)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "По"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 28)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(16, 15)
        Me.Label8.TabIndex = 5
        Me.Label8.Text = "С"
        '
        'DTP_вет_срок1
        '
        Me.DTP_вет_срок1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTP_вет_срок1.Location = New System.Drawing.Point(28, 22)
        Me.DTP_вет_срок1.Name = "DTP_вет_срок1"
        Me.DTP_вет_срок1.Size = New System.Drawing.Size(82, 22)
        Me.DTP_вет_срок1.TabIndex = 4
        '
        'поиск_срок
        '
        Me.поиск_срок.BackColor = System.Drawing.SystemColors.Window
        Me.поиск_срок.Location = New System.Drawing.Point(9, 71)
        Me.поиск_срок.Name = "поиск_срок"
        Me.поиск_срок.Size = New System.Drawing.Size(253, 23)
        Me.поиск_срок.TabIndex = 3
        Me.поиск_срок.Text = "Поиск"
        Me.поиск_срок.UseVisualStyleBackColor = False
        '
        'GroupBox9
        '
        Me.GroupBox9.Controls.Add(Me.DTP_вет_дата_принятия2)
        Me.GroupBox9.Controls.Add(Me.Label9)
        Me.GroupBox9.Controls.Add(Me.Label10)
        Me.GroupBox9.Controls.Add(Me.DTP_вет_дата_принятия1)
        Me.GroupBox9.Controls.Add(Me.поиск_дата_прин)
        Me.GroupBox9.Location = New System.Drawing.Point(938, 98)
        Me.GroupBox9.Name = "GroupBox9"
        Me.GroupBox9.Size = New System.Drawing.Size(281, 100)
        Me.GroupBox9.TabIndex = 11
        Me.GroupBox9.TabStop = False
        Me.GroupBox9.Text = "По периоду, дата принятия"
        '
        'DTP_вет_дата_принятия2
        '
        Me.DTP_вет_дата_принятия2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTP_вет_дата_принятия2.Location = New System.Drawing.Point(144, 22)
        Me.DTP_вет_дата_принятия2.Name = "DTP_вет_дата_принятия2"
        Me.DTP_вет_дата_принятия2.Size = New System.Drawing.Size(82, 22)
        Me.DTP_вет_дата_принятия2.TabIndex = 7
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(116, 28)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(22, 15)
        Me.Label9.TabIndex = 6
        Me.Label9.Text = "По"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(6, 28)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(16, 15)
        Me.Label10.TabIndex = 5
        Me.Label10.Text = "С"
        '
        'DTP_вет_дата_принятия1
        '
        Me.DTP_вет_дата_принятия1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTP_вет_дата_принятия1.Location = New System.Drawing.Point(28, 22)
        Me.DTP_вет_дата_принятия1.Name = "DTP_вет_дата_принятия1"
        Me.DTP_вет_дата_принятия1.Size = New System.Drawing.Size(82, 22)
        Me.DTP_вет_дата_принятия1.TabIndex = 4
        '
        'поиск_дата_прин
        '
        Me.поиск_дата_прин.BackColor = System.Drawing.SystemColors.Window
        Me.поиск_дата_прин.Location = New System.Drawing.Point(9, 71)
        Me.поиск_дата_прин.Name = "поиск_дата_прин"
        Me.поиск_дата_прин.Size = New System.Drawing.Size(253, 23)
        Me.поиск_дата_прин.TabIndex = 3
        Me.поиск_дата_прин.Text = "Поиск"
        Me.поиск_дата_прин.UseVisualStyleBackColor = False
        '
        'report_button3
        '
        Me.report_button3.BackColor = System.Drawing.SystemColors.Window
        Me.report_button3.Location = New System.Drawing.Point(941, 536)
        Me.report_button3.Name = "report_button3"
        Me.report_button3.Size = New System.Drawing.Size(262, 23)
        Me.report_button3.TabIndex = 10
        Me.report_button3.Text = "Создать отчёт"
        Me.report_button3.UseVisualStyleBackColor = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.ComboBox2)
        Me.GroupBox3.Controls.Add(Me.поиск_по_кличкам_животных_вет_свид)
        Me.GroupBox3.Location = New System.Drawing.Point(935, 6)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(283, 86)
        Me.GroupBox3.TabIndex = 9
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Сортирвка и Поиск"
        '
        'ComboBox2
        '
        Me.ComboBox2.DataSource = Me.ПаспортживотногоBindingSource
        Me.ComboBox2.DisplayMember = "Кличка"
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(6, 21)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(259, 23)
        Me.ComboBox2.TabIndex = 12
        Me.ComboBox2.ValueMember = "ID_Животного"
        '
        'поиск_по_кличкам_животных_вет_свид
        '
        Me.поиск_по_кличкам_животных_вет_свид.BackColor = System.Drawing.SystemColors.Window
        Me.поиск_по_кличкам_животных_вет_свид.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
        Me.поиск_по_кличкам_животных_вет_свид.Location = New System.Drawing.Point(6, 49)
        Me.поиск_по_кличкам_животных_вет_свид.Name = "поиск_по_кличкам_животных_вет_свид"
        Me.поиск_по_кличкам_животных_вет_свид.Size = New System.Drawing.Size(259, 23)
        Me.поиск_по_кличкам_животных_вет_свид.TabIndex = 11
        Me.поиск_по_кличкам_животных_вет_свид.Text = "Поиск / Сортировать"
        Me.поиск_по_кличкам_животных_вет_свид.UseVisualStyleBackColor = False
        '
        'DGV_ветеринарное_свидетельство
        '
        Me.DGV_ветеринарное_свидетельство.AllowUserToAddRows = False
        Me.DGV_ветеринарное_свидетельство.AllowUserToDeleteRows = False
        Me.DGV_ветеринарное_свидетельство.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DGV_ветеринарное_свидетельство.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_ветеринарное_свидетельство.Location = New System.Drawing.Point(6, 6)
        Me.DGV_ветеринарное_свидетельство.Name = "DGV_ветеринарное_свидетельство"
        Me.DGV_ветеринарное_свидетельство.ReadOnly = True
        Me.DGV_ветеринарное_свидетельство.Size = New System.Drawing.Size(923, 553)
        Me.DGV_ветеринарное_свидетельство.TabIndex = 8
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.GroupBox10)
        Me.TabPage4.Controls.Add(Me.GroupBox11)
        Me.TabPage4.Controls.Add(Me.report_button4)
        Me.TabPage4.Controls.Add(Me.GroupBox4)
        Me.TabPage4.Controls.Add(Me.DGV_Награды)
        Me.TabPage4.Location = New System.Drawing.Point(4, 24)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(1225, 565)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Награды"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'GroupBox10
        '
        Me.GroupBox10.Controls.Add(Me.DTP_прошлое2)
        Me.GroupBox10.Controls.Add(Me.Label11)
        Me.GroupBox10.Controls.Add(Me.Label12)
        Me.GroupBox10.Controls.Add(Me.DTP_прошлое1)
        Me.GroupBox10.Controls.Add(Me.поиск_прош)
        Me.GroupBox10.Location = New System.Drawing.Point(937, 215)
        Me.GroupBox10.Name = "GroupBox10"
        Me.GroupBox10.Size = New System.Drawing.Size(281, 100)
        Me.GroupBox10.TabIndex = 16
        Me.GroupBox10.TabStop = False
        Me.GroupBox10.Text = "По периоду, прошлая награда"
        '
        'DTP_прошлое2
        '
        Me.DTP_прошлое2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTP_прошлое2.Location = New System.Drawing.Point(144, 22)
        Me.DTP_прошлое2.Name = "DTP_прошлое2"
        Me.DTP_прошлое2.Size = New System.Drawing.Size(82, 22)
        Me.DTP_прошлое2.TabIndex = 7
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(116, 28)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(22, 15)
        Me.Label11.TabIndex = 6
        Me.Label11.Text = "По"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(6, 28)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(16, 15)
        Me.Label12.TabIndex = 5
        Me.Label12.Text = "С"
        '
        'DTP_прошлое1
        '
        Me.DTP_прошлое1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTP_прошлое1.Location = New System.Drawing.Point(28, 22)
        Me.DTP_прошлое1.Name = "DTP_прошлое1"
        Me.DTP_прошлое1.Size = New System.Drawing.Size(82, 22)
        Me.DTP_прошлое1.TabIndex = 4
        '
        'поиск_прош
        '
        Me.поиск_прош.BackColor = System.Drawing.SystemColors.Window
        Me.поиск_прош.Location = New System.Drawing.Point(9, 71)
        Me.поиск_прош.Name = "поиск_прош"
        Me.поиск_прош.Size = New System.Drawing.Size(253, 23)
        Me.поиск_прош.TabIndex = 3
        Me.поиск_прош.Text = "Поиск"
        Me.поиск_прош.UseVisualStyleBackColor = False
        '
        'GroupBox11
        '
        Me.GroupBox11.Controls.Add(Me.DTP_получ2)
        Me.GroupBox11.Controls.Add(Me.Label13)
        Me.GroupBox11.Controls.Add(Me.Label14)
        Me.GroupBox11.Controls.Add(Me.DTP_получ1)
        Me.GroupBox11.Controls.Add(Me.Поиск_получ)
        Me.GroupBox11.Location = New System.Drawing.Point(935, 97)
        Me.GroupBox11.Name = "GroupBox11"
        Me.GroupBox11.Size = New System.Drawing.Size(281, 100)
        Me.GroupBox11.TabIndex = 15
        Me.GroupBox11.TabStop = False
        Me.GroupBox11.Text = "По периоду, получение награды"
        '
        'DTP_получ2
        '
        Me.DTP_получ2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTP_получ2.Location = New System.Drawing.Point(144, 22)
        Me.DTP_получ2.Name = "DTP_получ2"
        Me.DTP_получ2.Size = New System.Drawing.Size(82, 22)
        Me.DTP_получ2.TabIndex = 7
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(116, 28)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(22, 15)
        Me.Label13.TabIndex = 6
        Me.Label13.Text = "По"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(6, 28)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(16, 15)
        Me.Label14.TabIndex = 5
        Me.Label14.Text = "С"
        '
        'DTP_получ1
        '
        Me.DTP_получ1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTP_получ1.Location = New System.Drawing.Point(28, 22)
        Me.DTP_получ1.Name = "DTP_получ1"
        Me.DTP_получ1.Size = New System.Drawing.Size(82, 22)
        Me.DTP_получ1.TabIndex = 4
        '
        'Поиск_получ
        '
        Me.Поиск_получ.BackColor = System.Drawing.SystemColors.Window
        Me.Поиск_получ.Location = New System.Drawing.Point(9, 71)
        Me.Поиск_получ.Name = "Поиск_получ"
        Me.Поиск_получ.Size = New System.Drawing.Size(253, 23)
        Me.Поиск_получ.TabIndex = 3
        Me.Поиск_получ.Text = "Поиск"
        Me.Поиск_получ.UseVisualStyleBackColor = False
        '
        'report_button4
        '
        Me.report_button4.BackColor = System.Drawing.SystemColors.Window
        Me.report_button4.Location = New System.Drawing.Point(935, 536)
        Me.report_button4.Name = "report_button4"
        Me.report_button4.Size = New System.Drawing.Size(262, 23)
        Me.report_button4.TabIndex = 14
        Me.report_button4.Text = "Создать отчёт"
        Me.report_button4.UseVisualStyleBackColor = False
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.ComboBox3)
        Me.GroupBox4.Controls.Add(Me.принять_поиск_по_кличкам_награды)
        Me.GroupBox4.Location = New System.Drawing.Point(935, 6)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(283, 85)
        Me.GroupBox4.TabIndex = 13
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Сортирвка и Поиск"
        '
        'ComboBox3
        '
        Me.ComboBox3.DataSource = Me.ПаспортживотногоBindingSource
        Me.ComboBox3.DisplayMember = "Кличка"
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Location = New System.Drawing.Point(9, 22)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(255, 23)
        Me.ComboBox3.TabIndex = 16
        Me.ComboBox3.ValueMember = "ID_Животного"
        '
        'принять_поиск_по_кличкам_награды
        '
        Me.принять_поиск_по_кличкам_награды.BackColor = System.Drawing.SystemColors.Window
        Me.принять_поиск_по_кличкам_награды.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
        Me.принять_поиск_по_кличкам_награды.Location = New System.Drawing.Point(6, 49)
        Me.принять_поиск_по_кличкам_награды.Name = "принять_поиск_по_кличкам_награды"
        Me.принять_поиск_по_кличкам_награды.Size = New System.Drawing.Size(260, 23)
        Me.принять_поиск_по_кличкам_награды.TabIndex = 15
        Me.принять_поиск_по_кличкам_награды.Text = "Поиск / Сортировать"
        Me.принять_поиск_по_кличкам_награды.UseVisualStyleBackColor = False
        '
        'DGV_Награды
        '
        Me.DGV_Награды.AllowUserToAddRows = False
        Me.DGV_Награды.AllowUserToDeleteRows = False
        Me.DGV_Награды.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DGV_Награды.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_Награды.Location = New System.Drawing.Point(6, 6)
        Me.DGV_Награды.Name = "DGV_Награды"
        Me.DGV_Награды.ReadOnly = True
        Me.DGV_Награды.Size = New System.Drawing.Size(922, 553)
        Me.DGV_Награды.TabIndex = 12
        '
        'TabPage5
        '
        Me.TabPage5.Controls.Add(Me.ReportViewer1)
        Me.TabPage5.Controls.Add(Me.report2)
        Me.TabPage5.Controls.Add(Me.report1)
        Me.TabPage5.Controls.Add(Me.Label17)
        Me.TabPage5.Controls.Add(Me.Label16)
        Me.TabPage5.Controls.Add(Me.Label15)
        Me.TabPage5.Controls.Add(Me.DataGridView2)
        Me.TabPage5.Controls.Add(Me.DataGridView1)
        Me.TabPage5.Location = New System.Drawing.Point(4, 24)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage5.Size = New System.Drawing.Size(1225, 565)
        Me.TabPage5.TabIndex = 4
        Me.TabPage5.Text = "Статистически отчёты "
        Me.TabPage5.UseVisualStyleBackColor = True
        '
        'report2
        '
        Me.report2.BackColor = System.Drawing.SystemColors.Window
        Me.report2.Location = New System.Drawing.Point(805, 297)
        Me.report2.Name = "report2"
        Me.report2.Size = New System.Drawing.Size(130, 84)
        Me.report2.TabIndex = 8
        Me.report2.Text = "Создать отчёт"
        Me.report2.UseVisualStyleBackColor = False
        '
        'report1
        '
        Me.report1.BackColor = System.Drawing.SystemColors.Window
        Me.report1.Location = New System.Drawing.Point(156, 297)
        Me.report1.Name = "report1"
        Me.report1.Size = New System.Drawing.Size(130, 84)
        Me.report1.TabIndex = 7
        Me.report1.Text = "Создать отчёт"
        Me.report1.UseVisualStyleBackColor = False
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label17.Location = New System.Drawing.Point(623, 7)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(96, 24)
        Me.Label17.TabIndex = 6
        Me.Label17.Text = "Награды"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label16.Location = New System.Drawing.Point(7, 7)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(135, 24)
        Me.Label16.TabIndex = 5
        Me.Label16.Text = "Вакцинация "
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(607, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(10, 1080)
        Me.Label15.TabIndex = 4
        Me.Label15.Text = resources.GetString("Label15.Text")
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToAddRows = False
        Me.DataGridView2.AllowUserToDeleteRows = False
        Me.DataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Location = New System.Drawing.Point(627, 34)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.ReadOnly = True
        Me.DataGridView2.Size = New System.Drawing.Size(592, 257)
        Me.DataGridView2.TabIndex = 3
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(11, 34)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(590, 257)
        Me.DataGridView1.TabIndex = 2
        '
        'ПрививкаTableAdapter
        '
        Me.ПрививкаTableAdapter.ClearBeforeFill = True
        '
        'ВладельцыTableAdapter
        '
        Me.ВладельцыTableAdapter.ClearBeforeFill = True
        '
        'Паспорт_животногоTableAdapter
        '
        Me.Паспорт_животногоTableAdapter.ClearBeforeFill = True
        '
        'ReportViewer1
        '
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.ПрививкаBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "ZelZooExpo.Report3.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(274, 167)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(675, 327)
        Me.ReportViewer1.TabIndex = 9
        '
        'prosmotr
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(1257, 646)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.закрыть)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(1273, 685)
        Me.MinimumSize = New System.Drawing.Size(1273, 685)
        Me.Name = "prosmotr"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ZelZooExpo(просмотр информации)"
        CType(Me.ПрививкаBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.animalBDDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.ВладельцыBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGV_Владельцы_просмотр, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.ПаспортживотногоBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGV_паспорт_животного, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        CType(Me.Картинка, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox8.PerformLayout()
        Me.GroupBox9.ResumeLayout(False)
        Me.GroupBox9.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.DGV_ветеринарное_свидетельство, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage4.ResumeLayout(False)
        Me.GroupBox10.ResumeLayout(False)
        Me.GroupBox10.PerformLayout()
        Me.GroupBox11.ResumeLayout(False)
        Me.GroupBox11.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.DGV_Награды, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage5.ResumeLayout(False)
        Me.TabPage5.PerformLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents закрыть As Button
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents DGV_Владельцы_просмотр As DataGridView
    Friend WithEvents ПоискВладельцев As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents поиск_по_кличкам_животного As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents DGV_паспорт_животного As DataGridView
    Friend WithEvents поиск_по_кличкам_животных_вет_свид As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents DGV_ветеринарное_свидетельство As DataGridView
    Friend WithEvents принять_поиск_по_кличкам_награды As Button
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents DGV_Награды As DataGridView
    Friend WithEvents report_button As Button
    Friend WithEvents report_Button2 As Button
    Friend WithEvents report_button3 As Button
    Friend WithEvents report_button4 As Button
    Friend WithEvents поиск_по_периоду As Button
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents DTP_D2 As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents DTP_D1 As DateTimePicker
    Friend WithEvents GroupBox7 As GroupBox
    Friend WithEvents DTP_паспорт_имплант2 As DateTimePicker
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents DTP_паспорт_имплант1 As DateTimePicker
    Friend WithEvents паспорт_дата_имплант_поиск As Button
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents DTP_паспорт_ДатаРОЖД_КОНЕЦ As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents DTP_паспорт_ДатаРОЖД_НАЧАЛО As DateTimePicker
    Friend WithEvents паспорт_дата_рожд_поиск As Button
    Friend WithEvents GroupBox8 As GroupBox
    Friend WithEvents DTP_вет_срок2 As DateTimePicker
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents DTP_вет_срок1 As DateTimePicker
    Friend WithEvents поиск_срок As Button
    Friend WithEvents GroupBox9 As GroupBox
    Friend WithEvents DTP_вет_дата_принятия2 As DateTimePicker
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents DTP_вет_дата_принятия1 As DateTimePicker
    Friend WithEvents поиск_дата_прин As Button
    Friend WithEvents GroupBox10 As GroupBox
    Friend WithEvents DTP_прошлое2 As DateTimePicker
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents DTP_прошлое1 As DateTimePicker
    Friend WithEvents поиск_прош As Button
    Friend WithEvents GroupBox11 As GroupBox
    Friend WithEvents DTP_получ2 As DateTimePicker
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents DTP_получ1 As DateTimePicker
    Friend WithEvents Поиск_получ As Button
    Friend WithEvents TabPage5 As TabPage
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Картинка As PictureBox
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents report2 As Button
    Friend WithEvents report1 As Button
    Friend WithEvents Label17 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents ПрививкаBindingSource As BindingSource
    Friend WithEvents animalBDDataSet As animalBDDataSet
    Friend WithEvents ПрививкаTableAdapter As animalBDDataSetTableAdapters.ПрививкаTableAdapter
    Friend WithEvents поиск_владельцев As ComboBox
    Friend WithEvents ВладельцыBindingSource As BindingSource
    Friend WithEvents ВладельцыTableAdapter As animalBDDataSetTableAdapters.ВладельцыTableAdapter
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents ПаспортживотногоBindingSource As BindingSource
    Friend WithEvents Паспорт_животногоTableAdapter As animalBDDataSetTableAdapters.Паспорт_животногоTableAdapter
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents ComboBox3 As ComboBox
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
End Class
