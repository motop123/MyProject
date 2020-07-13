<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class aktyalizat
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(aktyalizat))
        Me.Aktyaliz = New System.Windows.Forms.TabControl()
        Me.Strana = New System.Windows.Forms.TabPage()
        Me.grup_update = New System.Windows.Forms.GroupBox()
        Me.Изменить_страну = New System.Windows.Forms.Button()
        Me.название_страны_обнв = New System.Windows.Forms.TextBox()
        Me.id_страны_обнв = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.grup_del = New System.Windows.Forms.GroupBox()
        Me.Удалить_страну = New System.Windows.Forms.Button()
        Me.название_страны_удл = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.grup_dobavit = New System.Windows.Forms.GroupBox()
        Me.Добавить_страну = New System.Windows.Forms.Button()
        Me.название_страны_доб = New System.Windows.Forms.TextBox()
        Me.id_страны_доб = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DGV_Страна_актул = New System.Windows.Forms.DataGridView()
        Me.IDСтраныDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.НазваниеDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.СтранаBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AnimalBDDataSet = New ZelZooExpo.animalBDDataSet()
        Me.Nagrada = New System.Windows.Forms.TabPage()
        Me.GrBox1_update = New System.Windows.Forms.GroupBox()
        Me.Label98 = New System.Windows.Forms.Label()
        Me.Изменить_награду = New System.Windows.Forms.Button()
        Me.колживнаг_обнов = New System.Windows.Forms.TextBox()
        Me.наименование_награды_обнв = New System.Windows.Forms.TextBox()
        Me.id_награды_обнв = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GrBox1_del = New System.Windows.Forms.GroupBox()
        Me.Удалить_награду = New System.Windows.Forms.Button()
        Me.наименование_награды_дел = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GrBox1_add = New System.Windows.Forms.GroupBox()
        Me.Label97 = New System.Windows.Forms.Label()
        Me.колживнаг_доб = New System.Windows.Forms.TextBox()
        Me.Добавить_награду = New System.Windows.Forms.Button()
        Me.наименование_награды_доб = New System.Windows.Forms.TextBox()
        Me.id_награды_доб = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.DGV_Награды_актул = New System.Windows.Forms.DataGridView()
        Me.IDНаградыDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.НаименованиеDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.КоличествоживотныхполучившихнаградуDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.НаградыBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Otchego = New System.Windows.Forms.TabPage()
        Me.GroupBox_update = New System.Windows.Forms.GroupBox()
        Me.Изменить_отчего_прививка = New System.Windows.Forms.Button()
        Me.прививка_от_обнв = New System.Windows.Forms.TextBox()
        Me.id_отчего_прив_обнв = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.GroupBox_del = New System.Windows.Forms.GroupBox()
        Me.Удалить_отчего_прививка = New System.Windows.Forms.Button()
        Me.прививка_от_дел = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.GroupBox_add = New System.Windows.Forms.GroupBox()
        Me.Добавить_отчего_прививка = New System.Windows.Forms.Button()
        Me.прививка_от_доб = New System.Windows.Forms.TextBox()
        Me.id_отчего_прив_доб = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.DGV_отчего_актул = New System.Windows.Forms.DataGridView()
        Me.IDотЧегоDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ПрививкаотDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ОтчегоПрививкаBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Privivka = New System.Windows.Forms.TabPage()
        Me.GroupBox1_update = New System.Windows.Forms.GroupBox()
        Me.Label100 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.колвоприв_обнов = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Изменить_прививку = New System.Windows.Forms.Button()
        Me.страна_производитель_обнв = New System.Windows.Forms.TextBox()
        Me.наименование_прививки_обнв = New System.Windows.Forms.TextBox()
        Me.id_прививки_обнв = New System.Windows.Forms.TextBox()
        Me.GroupBox1_del = New System.Windows.Forms.GroupBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Удалить_прививку = New System.Windows.Forms.Button()
        Me.наименование_прививки_дел = New System.Windows.Forms.TextBox()
        Me.GroupBox1_add = New System.Windows.Forms.GroupBox()
        Me.Label99 = New System.Windows.Forms.Label()
        Me.колвоприв_доб = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.страна_производитель_доб = New System.Windows.Forms.TextBox()
        Me.Добавить_прививку = New System.Windows.Forms.Button()
        Me.наименование_прививки_доб = New System.Windows.Forms.TextBox()
        Me.id_прививки_доб = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.DGV_прививки_актул = New System.Windows.Forms.DataGridView()
        Me.IDпривDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.НазваниепрививкиDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.СтранапроизводительDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.КоличествопривитыхDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ПрививкаBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Mesto = New System.Windows.Forms.TabPage()
        Me.GroupBox2_update = New System.Windows.Forms.GroupBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Изменить_место_размещ_чипа = New System.Windows.Forms.Button()
        Me.где_обнв = New System.Windows.Forms.TextBox()
        Me.id_места_обнв = New System.Windows.Forms.TextBox()
        Me.GroupBox2_del = New System.Windows.Forms.GroupBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Удалить_место_размещ_чипа = New System.Windows.Forms.Button()
        Me.где_дел = New System.Windows.Forms.TextBox()
        Me.GroupBox2_add = New System.Windows.Forms.GroupBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Добавить_место_размещ_чипа = New System.Windows.Forms.Button()
        Me.где_доб = New System.Windows.Forms.TextBox()
        Me.id_места_доб = New System.Windows.Forms.TextBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.DGV_место_размещ_актул = New System.Windows.Forms.DataGridView()
        Me.IDМестоDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ГдеDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.МесторазмещенияэлектронногочипаBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Porod = New System.Windows.Forms.TabPage()
        Me.GroupBox3_update = New System.Windows.Forms.GroupBox()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Изменить_породу = New System.Windows.Forms.Button()
        Me.название_породы_обнв = New System.Windows.Forms.TextBox()
        Me.id_породы_обнв = New System.Windows.Forms.TextBox()
        Me.GroupBox3_del = New System.Windows.Forms.GroupBox()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Удалить_породу = New System.Windows.Forms.Button()
        Me.название_породы_дел = New System.Windows.Forms.TextBox()
        Me.GroupBox3_add = New System.Windows.Forms.GroupBox()
        Me.Добавить_породу = New System.Windows.Forms.Button()
        Me.название_породы_доб = New System.Windows.Forms.TextBox()
        Me.id_породы_доб = New System.Windows.Forms.TextBox()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.DGV_породы_актул = New System.Windows.Forms.DataGridView()
        Me.IDПородыDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.НазваниеDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ПородыBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Vladelti = New System.Windows.Forms.TabPage()
        Me.DGV_Владельцы_актул = New System.Windows.Forms.DataGridView()
        Me.GroupBox4_update = New System.Windows.Forms.GroupBox()
        Me.id_страны_влад_обнв = New System.Windows.Forms.ComboBox()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.Изменить_владельца = New System.Windows.Forms.Button()
        Me.номер_дома_обнв = New System.Windows.Forms.TextBox()
        Me.Label47 = New System.Windows.Forms.Label()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.Label46 = New System.Windows.Forms.Label()
        Me.улица_обнв = New System.Windows.Forms.TextBox()
        Me.id_владельца_обнв = New System.Windows.Forms.TextBox()
        Me.Label43 = New System.Windows.Forms.Label()
        Me.ФИО_обнв = New System.Windows.Forms.TextBox()
        Me.город_обнв = New System.Windows.Forms.TextBox()
        Me.Label45 = New System.Windows.Forms.Label()
        Me.Label44 = New System.Windows.Forms.Label()
        Me.GroupBox4_del = New System.Windows.Forms.GroupBox()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.Удалить_владельца = New System.Windows.Forms.Button()
        Me.ФИО_дел = New System.Windows.Forms.TextBox()
        Me.GroupBox4_add = New System.Windows.Forms.GroupBox()
        Me.id_страны_влад_доб = New System.Windows.Forms.ComboBox()
        Me.Label42 = New System.Windows.Forms.Label()
        Me.номер_дома_доб = New System.Windows.Forms.TextBox()
        Me.Label41 = New System.Windows.Forms.Label()
        Me.улица_доб = New System.Windows.Forms.TextBox()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.город_доб = New System.Windows.Forms.TextBox()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.Добавть_владельца = New System.Windows.Forms.Button()
        Me.ФИО_доб = New System.Windows.Forms.TextBox()
        Me.id_владельца_доб = New System.Windows.Forms.TextBox()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.Pasport = New System.Windows.Forms.TabPage()
        Me.DGV_паспорт_животного_актул = New System.Windows.Forms.DataGridView()
        Me.GroupBox5_update = New System.Windows.Forms.GroupBox()
        Me.Label96 = New System.Windows.Forms.Label()
        Me.номер_чипа_обнв = New System.Windows.Forms.TextBox()
        Me.id_владельца_животного_обнв = New System.Windows.Forms.ComboBox()
        Me.ВладельцыBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.id_породы_животного_обнв = New System.Windows.Forms.ComboBox()
        Me.место_размещения_обнв = New System.Windows.Forms.ComboBox()
        Me.Изменить_паспорт = New System.Windows.Forms.Button()
        Me.Label49 = New System.Windows.Forms.Label()
        Me.имя_мамы_обнв = New System.Windows.Forms.TextBox()
        Me.окрас_животного_обнв = New System.Windows.Forms.TextBox()
        Me.Label50 = New System.Windows.Forms.Label()
        Me.Label51 = New System.Windows.Forms.Label()
        Me.группа_животного_обнв = New System.Windows.Forms.TextBox()
        Me.Label52 = New System.Windows.Forms.Label()
        Me.Label53 = New System.Windows.Forms.Label()
        Me.Label54 = New System.Windows.Forms.Label()
        Me.Label55 = New System.Windows.Forms.Label()
        Me.пол_животного_обнв = New System.Windows.Forms.TextBox()
        Me.Label69 = New System.Windows.Forms.Label()
        Me.имя_папы_обнв = New System.Windows.Forms.TextBox()
        Me.Label70 = New System.Windows.Forms.Label()
        Me.имя_животного_обнв = New System.Windows.Forms.TextBox()
        Me.Label71 = New System.Windows.Forms.Label()
        Me.номер_родословной_обнв = New System.Windows.Forms.TextBox()
        Me.Label72 = New System.Windows.Forms.Label()
        Me.id_животного_обнв = New System.Windows.Forms.TextBox()
        Me.Label73 = New System.Windows.Forms.Label()
        Me.Label74 = New System.Windows.Forms.Label()
        Me.GroupBox5_del = New System.Windows.Forms.GroupBox()
        Me.кличка_животного_дел = New System.Windows.Forms.TextBox()
        Me.Label48 = New System.Windows.Forms.Label()
        Me.Удалить_паспорт = New System.Windows.Forms.Button()
        Me.GroupBox5_add = New System.Windows.Forms.GroupBox()
        Me.Label95 = New System.Windows.Forms.Label()
        Me.номер_чипа_доб = New System.Windows.Forms.TextBox()
        Me.место_размещения_доб = New System.Windows.Forms.ComboBox()
        Me.кличка_животного_доб = New System.Windows.Forms.TextBox()
        Me.id_породы_животного_доб = New System.Windows.Forms.ComboBox()
        Me.id_владельца_животного_доб = New System.Windows.Forms.ComboBox()
        Me.Label68 = New System.Windows.Forms.Label()
        Me.имя_мамы_доб = New System.Windows.Forms.TextBox()
        Me.окрас_животного_доб = New System.Windows.Forms.TextBox()
        Me.Label67 = New System.Windows.Forms.Label()
        Me.Label66 = New System.Windows.Forms.Label()
        Me.группа_животного_доб = New System.Windows.Forms.TextBox()
        Me.Label65 = New System.Windows.Forms.Label()
        Me.Label64 = New System.Windows.Forms.Label()
        Me.Label63 = New System.Windows.Forms.Label()
        Me.Label56 = New System.Windows.Forms.Label()
        Me.пол_животного_доб = New System.Windows.Forms.TextBox()
        Me.Label57 = New System.Windows.Forms.Label()
        Me.имя_папы_доб = New System.Windows.Forms.TextBox()
        Me.Label58 = New System.Windows.Forms.Label()
        Me.Label59 = New System.Windows.Forms.Label()
        Me.номер_родословной_доб = New System.Windows.Forms.TextBox()
        Me.Label60 = New System.Windows.Forms.Label()
        Me.Добавить_паспорт = New System.Windows.Forms.Button()
        Me.id_животного_доб = New System.Windows.Forms.TextBox()
        Me.Label61 = New System.Windows.Forms.Label()
        Me.Label62 = New System.Windows.Forms.Label()
        Me.Poluch_Nagrad = New System.Windows.Forms.TabPage()
        Me.DGV_получ_награды_актул = New System.Windows.Forms.DataGridView()
        Me.GroupBox6_update = New System.Windows.Forms.GroupBox()
        Me.получ_награды_обнв = New System.Windows.Forms.ComboBox()
        Me.Label76 = New System.Windows.Forms.Label()
        Me.ID_клички_обнв = New System.Windows.Forms.ComboBox()
        Me.ПаспортживотногоBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Изменить_получ_награды = New System.Windows.Forms.Button()
        Me.id_получ_награды_обнв = New System.Windows.Forms.TextBox()
        Me.Label77 = New System.Windows.Forms.Label()
        Me.Label80 = New System.Windows.Forms.Label()
        Me.Label78 = New System.Windows.Forms.Label()
        Me.Label79 = New System.Windows.Forms.Label()
        Me.GroupBox6_del = New System.Windows.Forms.GroupBox()
        Me.id_получ_награды_уд = New System.Windows.Forms.TextBox()
        Me.Label81 = New System.Windows.Forms.Label()
        Me.Удалить_получ_награды = New System.Windows.Forms.Button()
        Me.GroupBox6_add = New System.Windows.Forms.GroupBox()
        Me.получ_награды_доб = New System.Windows.Forms.ComboBox()
        Me.ID_клички_доб = New System.Windows.Forms.ComboBox()
        Me.Label75 = New System.Windows.Forms.Label()
        Me.Label85 = New System.Windows.Forms.Label()
        Me.Label86 = New System.Windows.Forms.Label()
        Me.Добавить_получ_награды = New System.Windows.Forms.Button()
        Me.id_получ_награды_доб = New System.Windows.Forms.TextBox()
        Me.Label88 = New System.Windows.Forms.Label()
        Me.Label89 = New System.Windows.Forms.Label()
        Me.Vet_Svidetel = New System.Windows.Forms.TabPage()
        Me.DGV_ветеринарное_свидетельство = New System.Windows.Forms.DataGridView()
        Me.GroupBox7_update = New System.Windows.Forms.GroupBox()
        Me.id_прив_от_вет_обнв = New System.Windows.Forms.ComboBox()
        Me.id_наименов_прирв_вет_обнв = New System.Windows.Forms.ComboBox()
        Me.id_имя_жив_вет_обнв = New System.Windows.Forms.ComboBox()
        Me.id_вет_св_обнв = New System.Windows.Forms.TextBox()
        Me.Label94 = New System.Windows.Forms.Label()
        Me.Изменить_вет_свед = New System.Windows.Forms.Button()
        Me.Label82 = New System.Windows.Forms.Label()
        Me.Label92 = New System.Windows.Forms.Label()
        Me.Label83 = New System.Windows.Forms.Label()
        Me.имя_картинки_обнв = New System.Windows.Forms.TextBox()
        Me.Label84 = New System.Windows.Forms.Label()
        Me.Label91 = New System.Windows.Forms.Label()
        Me.формат_кратинки_обнв = New System.Windows.Forms.TextBox()
        Me.Label87 = New System.Windows.Forms.Label()
        Me.Label90 = New System.Windows.Forms.Label()
        Me.GroupBox7_del = New System.Windows.Forms.GroupBox()
        Me.Удалить_вет_свед = New System.Windows.Forms.Button()
        Me.id_вет_св_дел = New System.Windows.Forms.TextBox()
        Me.Label93 = New System.Windows.Forms.Label()
        Me.GroupBox7_add = New System.Windows.Forms.GroupBox()
        Me.id_прив_от_вет_доб = New System.Windows.Forms.ComboBox()
        Me.id_наименов_прирв_вет_доб = New System.Windows.Forms.ComboBox()
        Me.id_имя_жив_вет_доб = New System.Windows.Forms.ComboBox()
        Me.Label101 = New System.Windows.Forms.Label()
        Me.Label102 = New System.Windows.Forms.Label()
        Me.имя_картинки_доб = New System.Windows.Forms.TextBox()
        Me.Label103 = New System.Windows.Forms.Label()
        Me.формат_кратинки_доб = New System.Windows.Forms.TextBox()
        Me.Label104 = New System.Windows.Forms.Label()
        Me.Label105 = New System.Windows.Forms.Label()
        Me.Label110 = New System.Windows.Forms.Label()
        Me.Добавить_вет_свед = New System.Windows.Forms.Button()
        Me.id_вет_св_доб = New System.Windows.Forms.TextBox()
        Me.Label111 = New System.Windows.Forms.Label()
        Me.Label112 = New System.Windows.Forms.Label()
        Me.Vixod = New System.Windows.Forms.Button()
        Me.save = New System.Windows.Forms.Button()
        Me.СтранаTableAdapter = New ZelZooExpo.animalBDDataSetTableAdapters.СтранаTableAdapter()
        Me.НаградыTableAdapter = New ZelZooExpo.animalBDDataSetTableAdapters.НаградыTableAdapter()
        Me.ОтчегоПрививкаTableAdapter = New ZelZooExpo.animalBDDataSetTableAdapters.ОтчегоПрививкаTableAdapter()
        Me.ПрививкаTableAdapter = New ZelZooExpo.animalBDDataSetTableAdapters.ПрививкаTableAdapter()
        Me.Место_размещения_электронного_чипаTableAdapter = New ZelZooExpo.animalBDDataSetTableAdapters.Место_размещения_электронного_чипаTableAdapter()
        Me.ПородыTableAdapter = New ZelZooExpo.animalBDDataSetTableAdapters.ПородыTableAdapter()
        Me.ВладельцыTableAdapter = New ZelZooExpo.animalBDDataSetTableAdapters.ВладельцыTableAdapter()
        Me.Паспорт_животногоTableAdapter = New ZelZooExpo.animalBDDataSetTableAdapters.Паспорт_животногоTableAdapter()
        Me.D1 = New System.Windows.Forms.DateTimePicker()
        Me.D2 = New System.Windows.Forms.DateTimePicker()
        Me.d3 = New System.Windows.Forms.DateTimePicker()
        Me.d4 = New System.Windows.Forms.DateTimePicker()
        Me.d5 = New System.Windows.Forms.DateTimePicker()
        Me.d6 = New System.Windows.Forms.DateTimePicker()
        Me.d7 = New System.Windows.Forms.DateTimePicker()
        Me.d8 = New System.Windows.Forms.DateTimePicker()
        Me.d9 = New System.Windows.Forms.DateTimePicker()
        Me.d10 = New System.Windows.Forms.DateTimePicker()
        Me.d11 = New System.Windows.Forms.DateTimePicker()
        Me.d12 = New System.Windows.Forms.DateTimePicker()
        Me.d13 = New System.Windows.Forms.DateTimePicker()
        Me.d14 = New System.Windows.Forms.DateTimePicker()
        Me.Aktyaliz.SuspendLayout()
        Me.Strana.SuspendLayout()
        Me.grup_update.SuspendLayout()
        Me.grup_del.SuspendLayout()
        Me.grup_dobavit.SuspendLayout()
        CType(Me.DGV_Страна_актул, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.СтранаBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AnimalBDDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Nagrada.SuspendLayout()
        Me.GrBox1_update.SuspendLayout()
        Me.GrBox1_del.SuspendLayout()
        Me.GrBox1_add.SuspendLayout()
        CType(Me.DGV_Награды_актул, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.НаградыBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Otchego.SuspendLayout()
        Me.GroupBox_update.SuspendLayout()
        Me.GroupBox_del.SuspendLayout()
        Me.GroupBox_add.SuspendLayout()
        CType(Me.DGV_отчего_актул, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ОтчегоПрививкаBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Privivka.SuspendLayout()
        Me.GroupBox1_update.SuspendLayout()
        Me.GroupBox1_del.SuspendLayout()
        Me.GroupBox1_add.SuspendLayout()
        CType(Me.DGV_прививки_актул, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ПрививкаBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Mesto.SuspendLayout()
        Me.GroupBox2_update.SuspendLayout()
        Me.GroupBox2_del.SuspendLayout()
        Me.GroupBox2_add.SuspendLayout()
        CType(Me.DGV_место_размещ_актул, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.МесторазмещенияэлектронногочипаBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Porod.SuspendLayout()
        Me.GroupBox3_update.SuspendLayout()
        Me.GroupBox3_del.SuspendLayout()
        Me.GroupBox3_add.SuspendLayout()
        CType(Me.DGV_породы_актул, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ПородыBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Vladelti.SuspendLayout()
        CType(Me.DGV_Владельцы_актул, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4_update.SuspendLayout()
        Me.GroupBox4_del.SuspendLayout()
        Me.GroupBox4_add.SuspendLayout()
        Me.Pasport.SuspendLayout()
        CType(Me.DGV_паспорт_животного_актул, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox5_update.SuspendLayout()
        CType(Me.ВладельцыBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox5_del.SuspendLayout()
        Me.GroupBox5_add.SuspendLayout()
        Me.Poluch_Nagrad.SuspendLayout()
        CType(Me.DGV_получ_награды_актул, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox6_update.SuspendLayout()
        CType(Me.ПаспортживотногоBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox6_del.SuspendLayout()
        Me.GroupBox6_add.SuspendLayout()
        Me.Vet_Svidetel.SuspendLayout()
        CType(Me.DGV_ветеринарное_свидетельство, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox7_update.SuspendLayout()
        Me.GroupBox7_del.SuspendLayout()
        Me.GroupBox7_add.SuspendLayout()
        Me.SuspendLayout()
        '
        'Aktyaliz
        '
        Me.Aktyaliz.Controls.Add(Me.Strana)
        Me.Aktyaliz.Controls.Add(Me.Nagrada)
        Me.Aktyaliz.Controls.Add(Me.Otchego)
        Me.Aktyaliz.Controls.Add(Me.Privivka)
        Me.Aktyaliz.Controls.Add(Me.Mesto)
        Me.Aktyaliz.Controls.Add(Me.Porod)
        Me.Aktyaliz.Controls.Add(Me.Vladelti)
        Me.Aktyaliz.Controls.Add(Me.Pasport)
        Me.Aktyaliz.Controls.Add(Me.Poluch_Nagrad)
        Me.Aktyaliz.Controls.Add(Me.Vet_Svidetel)
        Me.Aktyaliz.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Aktyaliz.Location = New System.Drawing.Point(12, 12)
        Me.Aktyaliz.Name = "Aktyaliz"
        Me.Aktyaliz.SelectedIndex = 0
        Me.Aktyaliz.Size = New System.Drawing.Size(1229, 593)
        Me.Aktyaliz.TabIndex = 0
        '
        'Strana
        '
        Me.Strana.Controls.Add(Me.grup_update)
        Me.Strana.Controls.Add(Me.grup_del)
        Me.Strana.Controls.Add(Me.grup_dobavit)
        Me.Strana.Controls.Add(Me.DGV_Страна_актул)
        Me.Strana.Location = New System.Drawing.Point(4, 24)
        Me.Strana.Name = "Strana"
        Me.Strana.Padding = New System.Windows.Forms.Padding(3)
        Me.Strana.Size = New System.Drawing.Size(1221, 565)
        Me.Strana.TabIndex = 0
        Me.Strana.Text = "Страна"
        Me.Strana.UseVisualStyleBackColor = True
        '
        'grup_update
        '
        Me.grup_update.Controls.Add(Me.Изменить_страну)
        Me.grup_update.Controls.Add(Me.название_страны_обнв)
        Me.grup_update.Controls.Add(Me.id_страны_обнв)
        Me.grup_update.Controls.Add(Me.Label5)
        Me.grup_update.Controls.Add(Me.Label4)
        Me.grup_update.Location = New System.Drawing.Point(217, 423)
        Me.grup_update.Name = "grup_update"
        Me.grup_update.Size = New System.Drawing.Size(300, 100)
        Me.grup_update.TabIndex = 7
        Me.grup_update.TabStop = False
        Me.grup_update.Text = "Изменить"
        '
        'Изменить_страну
        '
        Me.Изменить_страну.BackColor = System.Drawing.SystemColors.Window
        Me.Изменить_страну.Location = New System.Drawing.Point(219, 72)
        Me.Изменить_страну.Name = "Изменить_страну"
        Me.Изменить_страну.Size = New System.Drawing.Size(75, 23)
        Me.Изменить_страну.TabIndex = 3
        Me.Изменить_страну.Text = "Изменить"
        Me.Изменить_страну.UseVisualStyleBackColor = False
        '
        'название_страны_обнв
        '
        Me.название_страны_обнв.Location = New System.Drawing.Point(86, 39)
        Me.название_страны_обнв.Name = "название_страны_обнв"
        Me.название_страны_обнв.Size = New System.Drawing.Size(153, 22)
        Me.название_страны_обнв.TabIndex = 5
        '
        'id_страны_обнв
        '
        Me.id_страны_обнв.Location = New System.Drawing.Point(9, 39)
        Me.id_страны_обнв.Name = "id_страны_обнв"
        Me.id_страны_обнв.Size = New System.Drawing.Size(33, 22)
        Me.id_страны_обнв.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(83, 18)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(60, 15)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Название"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 19)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 15)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "ID_Страны"
        '
        'grup_del
        '
        Me.grup_del.Controls.Add(Me.Удалить_страну)
        Me.grup_del.Controls.Add(Me.название_страны_удл)
        Me.grup_del.Controls.Add(Me.Label3)
        Me.grup_del.Location = New System.Drawing.Point(7, 423)
        Me.grup_del.Name = "grup_del"
        Me.grup_del.Size = New System.Drawing.Size(200, 100)
        Me.grup_del.TabIndex = 6
        Me.grup_del.TabStop = False
        Me.grup_del.Text = "Удалить"
        '
        'Удалить_страну
        '
        Me.Удалить_страну.BackColor = System.Drawing.SystemColors.Window
        Me.Удалить_страну.Location = New System.Drawing.Point(119, 71)
        Me.Удалить_страну.Name = "Удалить_страну"
        Me.Удалить_страну.Size = New System.Drawing.Size(75, 23)
        Me.Удалить_страну.TabIndex = 2
        Me.Удалить_страну.Text = "Удалить"
        Me.Удалить_страну.UseVisualStyleBackColor = False
        '
        'название_страны_удл
        '
        Me.название_страны_удл.Location = New System.Drawing.Point(10, 38)
        Me.название_страны_удл.Name = "название_страны_удл"
        Me.название_страны_удл.Size = New System.Drawing.Size(184, 22)
        Me.название_страны_удл.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(7, 18)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 15)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Название"
        '
        'grup_dobavit
        '
        Me.grup_dobavit.Controls.Add(Me.Добавить_страну)
        Me.grup_dobavit.Controls.Add(Me.название_страны_доб)
        Me.grup_dobavit.Controls.Add(Me.id_страны_доб)
        Me.grup_dobavit.Controls.Add(Me.Label2)
        Me.grup_dobavit.Controls.Add(Me.Label1)
        Me.grup_dobavit.Location = New System.Drawing.Point(7, 308)
        Me.grup_dobavit.Name = "grup_dobavit"
        Me.grup_dobavit.Size = New System.Drawing.Size(291, 100)
        Me.grup_dobavit.TabIndex = 1
        Me.grup_dobavit.TabStop = False
        Me.grup_dobavit.Text = "Добавить"
        '
        'Добавить_страну
        '
        Me.Добавить_страну.BackColor = System.Drawing.SystemColors.Window
        Me.Добавить_страну.Location = New System.Drawing.Point(210, 71)
        Me.Добавить_страну.Name = "Добавить_страну"
        Me.Добавить_страну.Size = New System.Drawing.Size(75, 23)
        Me.Добавить_страну.TabIndex = 4
        Me.Добавить_страну.Text = "Добавить"
        Me.Добавить_страну.UseVisualStyleBackColor = False
        '
        'название_страны_доб
        '
        Me.название_страны_доб.Location = New System.Drawing.Point(86, 38)
        Me.название_страны_доб.Name = "название_страны_доб"
        Me.название_страны_доб.Size = New System.Drawing.Size(153, 22)
        Me.название_страны_доб.TabIndex = 3
        '
        'id_страны_доб
        '
        Me.id_страны_доб.Location = New System.Drawing.Point(6, 38)
        Me.id_страны_доб.Name = "id_страны_доб"
        Me.id_страны_доб.Size = New System.Drawing.Size(33, 22)
        Me.id_страны_доб.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(83, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Название"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ID_Страны"
        '
        'DGV_Страна_актул
        '
        Me.DGV_Страна_актул.AllowUserToAddRows = False
        Me.DGV_Страна_актул.AllowUserToDeleteRows = False
        Me.DGV_Страна_актул.AutoGenerateColumns = False
        Me.DGV_Страна_актул.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DGV_Страна_актул.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_Страна_актул.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDСтраныDataGridViewTextBoxColumn1, Me.НазваниеDataGridViewTextBoxColumn1})
        Me.DGV_Страна_актул.DataSource = Me.СтранаBindingSource
        Me.DGV_Страна_актул.Location = New System.Drawing.Point(7, 7)
        Me.DGV_Страна_актул.Name = "DGV_Страна_актул"
        Me.DGV_Страна_актул.ReadOnly = True
        Me.DGV_Страна_актул.Size = New System.Drawing.Size(1208, 282)
        Me.DGV_Страна_актул.TabIndex = 0
        '
        'IDСтраныDataGridViewTextBoxColumn1
        '
        Me.IDСтраныDataGridViewTextBoxColumn1.DataPropertyName = "ID_Страны"
        Me.IDСтраныDataGridViewTextBoxColumn1.HeaderText = "ID_Страны"
        Me.IDСтраныDataGridViewTextBoxColumn1.Name = "IDСтраныDataGridViewTextBoxColumn1"
        Me.IDСтраныDataGridViewTextBoxColumn1.ReadOnly = True
        Me.IDСтраныDataGridViewTextBoxColumn1.Width = 96
        '
        'НазваниеDataGridViewTextBoxColumn1
        '
        Me.НазваниеDataGridViewTextBoxColumn1.DataPropertyName = "Название"
        Me.НазваниеDataGridViewTextBoxColumn1.HeaderText = "Название"
        Me.НазваниеDataGridViewTextBoxColumn1.Name = "НазваниеDataGridViewTextBoxColumn1"
        Me.НазваниеDataGridViewTextBoxColumn1.ReadOnly = True
        Me.НазваниеDataGridViewTextBoxColumn1.Width = 85
        '
        'СтранаBindingSource
        '
        Me.СтранаBindingSource.DataMember = "Страна"
        Me.СтранаBindingSource.DataSource = Me.AnimalBDDataSet
        '
        'AnimalBDDataSet
        '
        Me.AnimalBDDataSet.DataSetName = "animalBDDataSet"
        Me.AnimalBDDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Nagrada
        '
        Me.Nagrada.Controls.Add(Me.GrBox1_update)
        Me.Nagrada.Controls.Add(Me.GrBox1_del)
        Me.Nagrada.Controls.Add(Me.GrBox1_add)
        Me.Nagrada.Controls.Add(Me.DGV_Награды_актул)
        Me.Nagrada.Location = New System.Drawing.Point(4, 24)
        Me.Nagrada.Name = "Nagrada"
        Me.Nagrada.Padding = New System.Windows.Forms.Padding(3)
        Me.Nagrada.Size = New System.Drawing.Size(1221, 565)
        Me.Nagrada.TabIndex = 1
        Me.Nagrada.Text = "Награды"
        Me.Nagrada.UseVisualStyleBackColor = True
        '
        'GrBox1_update
        '
        Me.GrBox1_update.Controls.Add(Me.Label98)
        Me.GrBox1_update.Controls.Add(Me.Изменить_награду)
        Me.GrBox1_update.Controls.Add(Me.колживнаг_обнов)
        Me.GrBox1_update.Controls.Add(Me.наименование_награды_обнв)
        Me.GrBox1_update.Controls.Add(Me.id_награды_обнв)
        Me.GrBox1_update.Controls.Add(Me.Label6)
        Me.GrBox1_update.Controls.Add(Me.Label7)
        Me.GrBox1_update.Location = New System.Drawing.Point(6, 414)
        Me.GrBox1_update.Name = "GrBox1_update"
        Me.GrBox1_update.Size = New System.Drawing.Size(498, 100)
        Me.GrBox1_update.TabIndex = 10
        Me.GrBox1_update.TabStop = False
        Me.GrBox1_update.Text = "Изменить"
        '
        'Label98
        '
        Me.Label98.AutoSize = True
        Me.Label98.Location = New System.Drawing.Point(242, 19)
        Me.Label98.Name = "Label98"
        Me.Label98.Size = New System.Drawing.Size(248, 15)
        Me.Label98.TabIndex = 8
        Me.Label98.Text = "Кол-во животных получивших эту награду"
        '
        'Изменить_награду
        '
        Me.Изменить_награду.BackColor = System.Drawing.SystemColors.Window
        Me.Изменить_награду.Location = New System.Drawing.Point(417, 71)
        Me.Изменить_награду.Name = "Изменить_награду"
        Me.Изменить_награду.Size = New System.Drawing.Size(75, 23)
        Me.Изменить_награду.TabIndex = 3
        Me.Изменить_награду.Text = "Изменить"
        Me.Изменить_награду.UseVisualStyleBackColor = False
        '
        'колживнаг_обнов
        '
        Me.колживнаг_обнов.Location = New System.Drawing.Point(245, 39)
        Me.колживнаг_обнов.Name = "колживнаг_обнов"
        Me.колживнаг_обнов.Size = New System.Drawing.Size(76, 22)
        Me.колживнаг_обнов.TabIndex = 7
        '
        'наименование_награды_обнв
        '
        Me.наименование_награды_обнв.Location = New System.Drawing.Point(86, 39)
        Me.наименование_награды_обнв.Name = "наименование_награды_обнв"
        Me.наименование_награды_обнв.Size = New System.Drawing.Size(153, 22)
        Me.наименование_награды_обнв.TabIndex = 5
        '
        'id_награды_обнв
        '
        Me.id_награды_обнв.Location = New System.Drawing.Point(9, 39)
        Me.id_награды_обнв.Name = "id_награды_обнв"
        Me.id_награды_обнв.Size = New System.Drawing.Size(33, 22)
        Me.id_награды_обнв.TabIndex = 5
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(83, 18)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(90, 15)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Наименование"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 19)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(77, 15)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "ID_Награды"
        '
        'GrBox1_del
        '
        Me.GrBox1_del.Controls.Add(Me.Удалить_награду)
        Me.GrBox1_del.Controls.Add(Me.наименование_награды_дел)
        Me.GrBox1_del.Controls.Add(Me.Label8)
        Me.GrBox1_del.Location = New System.Drawing.Point(510, 302)
        Me.GrBox1_del.Name = "GrBox1_del"
        Me.GrBox1_del.Size = New System.Drawing.Size(200, 100)
        Me.GrBox1_del.TabIndex = 9
        Me.GrBox1_del.TabStop = False
        Me.GrBox1_del.Text = "Удалить"
        '
        'Удалить_награду
        '
        Me.Удалить_награду.BackColor = System.Drawing.SystemColors.Window
        Me.Удалить_награду.Location = New System.Drawing.Point(119, 71)
        Me.Удалить_награду.Name = "Удалить_награду"
        Me.Удалить_награду.Size = New System.Drawing.Size(75, 23)
        Me.Удалить_награду.TabIndex = 2
        Me.Удалить_награду.Text = "Удалить"
        Me.Удалить_награду.UseVisualStyleBackColor = False
        '
        'наименование_награды_дел
        '
        Me.наименование_награды_дел.Location = New System.Drawing.Point(10, 38)
        Me.наименование_награды_дел.Name = "наименование_награды_дел"
        Me.наименование_награды_дел.Size = New System.Drawing.Size(184, 22)
        Me.наименование_награды_дел.TabIndex = 1
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(7, 18)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(90, 15)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Наименование"
        '
        'GrBox1_add
        '
        Me.GrBox1_add.Controls.Add(Me.Label97)
        Me.GrBox1_add.Controls.Add(Me.колживнаг_доб)
        Me.GrBox1_add.Controls.Add(Me.Добавить_награду)
        Me.GrBox1_add.Controls.Add(Me.наименование_награды_доб)
        Me.GrBox1_add.Controls.Add(Me.id_награды_доб)
        Me.GrBox1_add.Controls.Add(Me.Label9)
        Me.GrBox1_add.Controls.Add(Me.Label10)
        Me.GrBox1_add.Location = New System.Drawing.Point(6, 294)
        Me.GrBox1_add.Name = "GrBox1_add"
        Me.GrBox1_add.Size = New System.Drawing.Size(498, 114)
        Me.GrBox1_add.TabIndex = 8
        Me.GrBox1_add.TabStop = False
        Me.GrBox1_add.Text = "Добавить"
        '
        'Label97
        '
        Me.Label97.AutoSize = True
        Me.Label97.Location = New System.Drawing.Point(242, 18)
        Me.Label97.Name = "Label97"
        Me.Label97.Size = New System.Drawing.Size(248, 15)
        Me.Label97.TabIndex = 6
        Me.Label97.Text = "Кол-во животных получивших эту награду"
        '
        'колживнаг_доб
        '
        Me.колживнаг_доб.Location = New System.Drawing.Point(245, 38)
        Me.колживнаг_доб.Name = "колживнаг_доб"
        Me.колживнаг_доб.Size = New System.Drawing.Size(76, 22)
        Me.колживнаг_доб.TabIndex = 5
        '
        'Добавить_награду
        '
        Me.Добавить_награду.BackColor = System.Drawing.SystemColors.Window
        Me.Добавить_награду.Location = New System.Drawing.Point(423, 85)
        Me.Добавить_награду.Name = "Добавить_награду"
        Me.Добавить_награду.Size = New System.Drawing.Size(75, 23)
        Me.Добавить_награду.TabIndex = 4
        Me.Добавить_награду.Text = "Добавить"
        Me.Добавить_награду.UseVisualStyleBackColor = False
        '
        'наименование_награды_доб
        '
        Me.наименование_награды_доб.Location = New System.Drawing.Point(86, 38)
        Me.наименование_награды_доб.Name = "наименование_награды_доб"
        Me.наименование_награды_доб.Size = New System.Drawing.Size(153, 22)
        Me.наименование_награды_доб.TabIndex = 3
        '
        'id_награды_доб
        '
        Me.id_награды_доб.Location = New System.Drawing.Point(6, 38)
        Me.id_награды_доб.Name = "id_награды_доб"
        Me.id_награды_доб.Size = New System.Drawing.Size(33, 22)
        Me.id_награды_доб.TabIndex = 2
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(83, 19)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(90, 15)
        Me.Label9.TabIndex = 1
        Me.Label9.Text = "Наименование"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(3, 19)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(77, 15)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "ID_Награды"
        '
        'DGV_Награды_актул
        '
        Me.DGV_Награды_актул.AllowUserToAddRows = False
        Me.DGV_Награды_актул.AllowUserToDeleteRows = False
        Me.DGV_Награды_актул.AutoGenerateColumns = False
        Me.DGV_Награды_актул.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DGV_Награды_актул.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_Награды_актул.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDНаградыDataGridViewTextBoxColumn, Me.НаименованиеDataGridViewTextBoxColumn, Me.КоличествоживотныхполучившихнаградуDataGridViewTextBoxColumn})
        Me.DGV_Награды_актул.DataSource = Me.НаградыBindingSource
        Me.DGV_Награды_актул.Location = New System.Drawing.Point(6, 6)
        Me.DGV_Награды_актул.Name = "DGV_Награды_актул"
        Me.DGV_Награды_актул.ReadOnly = True
        Me.DGV_Награды_актул.Size = New System.Drawing.Size(1208, 282)
        Me.DGV_Награды_актул.TabIndex = 1
        '
        'IDНаградыDataGridViewTextBoxColumn
        '
        Me.IDНаградыDataGridViewTextBoxColumn.DataPropertyName = "ID_Награды"
        Me.IDНаградыDataGridViewTextBoxColumn.HeaderText = "ID_Награды"
        Me.IDНаградыDataGridViewTextBoxColumn.Name = "IDНаградыDataGridViewTextBoxColumn"
        Me.IDНаградыDataGridViewTextBoxColumn.ReadOnly = True
        Me.IDНаградыDataGridViewTextBoxColumn.Width = 102
        '
        'НаименованиеDataGridViewTextBoxColumn
        '
        Me.НаименованиеDataGridViewTextBoxColumn.DataPropertyName = "Наименование"
        Me.НаименованиеDataGridViewTextBoxColumn.HeaderText = "Наименование"
        Me.НаименованиеDataGridViewTextBoxColumn.Name = "НаименованиеDataGridViewTextBoxColumn"
        Me.НаименованиеDataGridViewTextBoxColumn.ReadOnly = True
        Me.НаименованиеDataGridViewTextBoxColumn.Width = 115
        '
        'КоличествоживотныхполучившихнаградуDataGridViewTextBoxColumn
        '
        Me.КоличествоживотныхполучившихнаградуDataGridViewTextBoxColumn.DataPropertyName = "Количество_животных_получивших_награду"
        Me.КоличествоживотныхполучившихнаградуDataGridViewTextBoxColumn.HeaderText = "Количество животных получивших награду"
        Me.КоличествоживотныхполучившихнаградуDataGridViewTextBoxColumn.Name = "КоличествоживотныхполучившихнаградуDataGridViewTextBoxColumn"
        Me.КоличествоживотныхполучившихнаградуDataGridViewTextBoxColumn.ReadOnly = True
        Me.КоличествоживотныхполучившихнаградуDataGridViewTextBoxColumn.Width = 214
        '
        'НаградыBindingSource
        '
        Me.НаградыBindingSource.DataMember = "Награды"
        Me.НаградыBindingSource.DataSource = Me.AnimalBDDataSet
        '
        'Otchego
        '
        Me.Otchego.Controls.Add(Me.GroupBox_update)
        Me.Otchego.Controls.Add(Me.GroupBox_del)
        Me.Otchego.Controls.Add(Me.GroupBox_add)
        Me.Otchego.Controls.Add(Me.DGV_отчего_актул)
        Me.Otchego.Location = New System.Drawing.Point(4, 24)
        Me.Otchego.Name = "Otchego"
        Me.Otchego.Padding = New System.Windows.Forms.Padding(3)
        Me.Otchego.Size = New System.Drawing.Size(1221, 565)
        Me.Otchego.TabIndex = 2
        Me.Otchego.Text = "Отчего прививка"
        Me.Otchego.UseVisualStyleBackColor = True
        '
        'GroupBox_update
        '
        Me.GroupBox_update.Controls.Add(Me.Изменить_отчего_прививка)
        Me.GroupBox_update.Controls.Add(Me.прививка_от_обнв)
        Me.GroupBox_update.Controls.Add(Me.id_отчего_прив_обнв)
        Me.GroupBox_update.Controls.Add(Me.Label11)
        Me.GroupBox_update.Controls.Add(Me.Label12)
        Me.GroupBox_update.Location = New System.Drawing.Point(510, 357)
        Me.GroupBox_update.Name = "GroupBox_update"
        Me.GroupBox_update.Size = New System.Drawing.Size(300, 100)
        Me.GroupBox_update.TabIndex = 13
        Me.GroupBox_update.TabStop = False
        Me.GroupBox_update.Text = "Изменить"
        '
        'Изменить_отчего_прививка
        '
        Me.Изменить_отчего_прививка.BackColor = System.Drawing.SystemColors.Window
        Me.Изменить_отчего_прививка.Location = New System.Drawing.Point(219, 72)
        Me.Изменить_отчего_прививка.Name = "Изменить_отчего_прививка"
        Me.Изменить_отчего_прививка.Size = New System.Drawing.Size(75, 23)
        Me.Изменить_отчего_прививка.TabIndex = 3
        Me.Изменить_отчего_прививка.Text = "Изменить"
        Me.Изменить_отчего_прививка.UseVisualStyleBackColor = False
        '
        'прививка_от_обнв
        '
        Me.прививка_от_обнв.Location = New System.Drawing.Point(86, 39)
        Me.прививка_от_обнв.Name = "прививка_от_обнв"
        Me.прививка_от_обнв.Size = New System.Drawing.Size(153, 22)
        Me.прививка_от_обнв.TabIndex = 5
        '
        'id_отчего_прив_обнв
        '
        Me.id_отчего_прив_обнв.Location = New System.Drawing.Point(9, 39)
        Me.id_отчего_прив_обнв.Name = "id_отчего_прив_обнв"
        Me.id_отчего_прив_обнв.Size = New System.Drawing.Size(33, 22)
        Me.id_отчего_прив_обнв.TabIndex = 5
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(83, 18)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(78, 15)
        Me.Label11.TabIndex = 5
        Me.Label11.Text = "Прививка от"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(6, 19)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(68, 15)
        Me.Label12.TabIndex = 5
        Me.Label12.Text = "ID_Отчего"
        '
        'GroupBox_del
        '
        Me.GroupBox_del.Controls.Add(Me.Удалить_отчего_прививка)
        Me.GroupBox_del.Controls.Add(Me.прививка_от_дел)
        Me.GroupBox_del.Controls.Add(Me.Label13)
        Me.GroupBox_del.Location = New System.Drawing.Point(304, 358)
        Me.GroupBox_del.Name = "GroupBox_del"
        Me.GroupBox_del.Size = New System.Drawing.Size(200, 100)
        Me.GroupBox_del.TabIndex = 12
        Me.GroupBox_del.TabStop = False
        Me.GroupBox_del.Text = "Удалить"
        '
        'Удалить_отчего_прививка
        '
        Me.Удалить_отчего_прививка.BackColor = System.Drawing.SystemColors.Window
        Me.Удалить_отчего_прививка.Location = New System.Drawing.Point(119, 71)
        Me.Удалить_отчего_прививка.Name = "Удалить_отчего_прививка"
        Me.Удалить_отчего_прививка.Size = New System.Drawing.Size(75, 23)
        Me.Удалить_отчего_прививка.TabIndex = 2
        Me.Удалить_отчего_прививка.Text = "Удалить"
        Me.Удалить_отчего_прививка.UseVisualStyleBackColor = False
        '
        'прививка_от_дел
        '
        Me.прививка_от_дел.Location = New System.Drawing.Point(10, 38)
        Me.прививка_от_дел.Name = "прививка_от_дел"
        Me.прививка_от_дел.Size = New System.Drawing.Size(184, 22)
        Me.прививка_от_дел.TabIndex = 1
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(7, 18)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(78, 15)
        Me.Label13.TabIndex = 0
        Me.Label13.Text = "Прививка от"
        '
        'GroupBox_add
        '
        Me.GroupBox_add.Controls.Add(Me.Добавить_отчего_прививка)
        Me.GroupBox_add.Controls.Add(Me.прививка_от_доб)
        Me.GroupBox_add.Controls.Add(Me.id_отчего_прив_доб)
        Me.GroupBox_add.Controls.Add(Me.Label14)
        Me.GroupBox_add.Controls.Add(Me.Label15)
        Me.GroupBox_add.Location = New System.Drawing.Point(6, 357)
        Me.GroupBox_add.Name = "GroupBox_add"
        Me.GroupBox_add.Size = New System.Drawing.Size(291, 100)
        Me.GroupBox_add.TabIndex = 11
        Me.GroupBox_add.TabStop = False
        Me.GroupBox_add.Text = "Добавить"
        '
        'Добавить_отчего_прививка
        '
        Me.Добавить_отчего_прививка.BackColor = System.Drawing.SystemColors.Window
        Me.Добавить_отчего_прививка.Location = New System.Drawing.Point(210, 71)
        Me.Добавить_отчего_прививка.Name = "Добавить_отчего_прививка"
        Me.Добавить_отчего_прививка.Size = New System.Drawing.Size(75, 23)
        Me.Добавить_отчего_прививка.TabIndex = 4
        Me.Добавить_отчего_прививка.Text = "Добавить"
        Me.Добавить_отчего_прививка.UseVisualStyleBackColor = False
        '
        'прививка_от_доб
        '
        Me.прививка_от_доб.Location = New System.Drawing.Point(86, 38)
        Me.прививка_от_доб.Name = "прививка_от_доб"
        Me.прививка_от_доб.Size = New System.Drawing.Size(153, 22)
        Me.прививка_от_доб.TabIndex = 3
        '
        'id_отчего_прив_доб
        '
        Me.id_отчего_прив_доб.Location = New System.Drawing.Point(6, 38)
        Me.id_отчего_прив_доб.Name = "id_отчего_прив_доб"
        Me.id_отчего_прив_доб.Size = New System.Drawing.Size(33, 22)
        Me.id_отчего_прив_доб.TabIndex = 2
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(83, 19)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(78, 15)
        Me.Label14.TabIndex = 1
        Me.Label14.Text = "Прививка от"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(3, 19)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(68, 15)
        Me.Label15.TabIndex = 0
        Me.Label15.Text = "ID_Отчего"
        '
        'DGV_отчего_актул
        '
        Me.DGV_отчего_актул.AllowUserToAddRows = False
        Me.DGV_отчего_актул.AllowUserToDeleteRows = False
        Me.DGV_отчего_актул.AutoGenerateColumns = False
        Me.DGV_отчего_актул.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DGV_отчего_актул.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_отчего_актул.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDотЧегоDataGridViewTextBoxColumn, Me.ПрививкаотDataGridViewTextBoxColumn})
        Me.DGV_отчего_актул.DataSource = Me.ОтчегоПрививкаBindingSource
        Me.DGV_отчего_актул.Location = New System.Drawing.Point(6, 6)
        Me.DGV_отчего_актул.Name = "DGV_отчего_актул"
        Me.DGV_отчего_актул.ReadOnly = True
        Me.DGV_отчего_актул.Size = New System.Drawing.Size(1208, 282)
        Me.DGV_отчего_актул.TabIndex = 2
        '
        'IDотЧегоDataGridViewTextBoxColumn
        '
        Me.IDотЧегоDataGridViewTextBoxColumn.DataPropertyName = "ID_отЧего"
        Me.IDотЧегоDataGridViewTextBoxColumn.HeaderText = "ID_отЧего"
        Me.IDотЧегоDataGridViewTextBoxColumn.Name = "IDотЧегоDataGridViewTextBoxColumn"
        Me.IDотЧегоDataGridViewTextBoxColumn.ReadOnly = True
        Me.IDотЧегоDataGridViewTextBoxColumn.Width = 92
        '
        'ПрививкаотDataGridViewTextBoxColumn
        '
        Me.ПрививкаотDataGridViewTextBoxColumn.DataPropertyName = "Прививка_от"
        Me.ПрививкаотDataGridViewTextBoxColumn.HeaderText = "Прививка от"
        Me.ПрививкаотDataGridViewTextBoxColumn.Name = "ПрививкаотDataGridViewTextBoxColumn"
        Me.ПрививкаотDataGridViewTextBoxColumn.ReadOnly = True
        Me.ПрививкаотDataGridViewTextBoxColumn.Width = 103
        '
        'ОтчегоПрививкаBindingSource
        '
        Me.ОтчегоПрививкаBindingSource.DataMember = "ОтчегоПрививка"
        Me.ОтчегоПрививкаBindingSource.DataSource = Me.AnimalBDDataSet
        '
        'Privivka
        '
        Me.Privivka.Controls.Add(Me.GroupBox1_update)
        Me.Privivka.Controls.Add(Me.GroupBox1_del)
        Me.Privivka.Controls.Add(Me.GroupBox1_add)
        Me.Privivka.Controls.Add(Me.DGV_прививки_актул)
        Me.Privivka.Location = New System.Drawing.Point(4, 24)
        Me.Privivka.Name = "Privivka"
        Me.Privivka.Padding = New System.Windows.Forms.Padding(3)
        Me.Privivka.Size = New System.Drawing.Size(1221, 565)
        Me.Privivka.TabIndex = 3
        Me.Privivka.Text = "Прививки"
        Me.Privivka.UseVisualStyleBackColor = True
        '
        'GroupBox1_update
        '
        Me.GroupBox1_update.Controls.Add(Me.Label100)
        Me.GroupBox1_update.Controls.Add(Me.Label16)
        Me.GroupBox1_update.Controls.Add(Me.колвоприв_обнов)
        Me.GroupBox1_update.Controls.Add(Me.Label22)
        Me.GroupBox1_update.Controls.Add(Me.Label17)
        Me.GroupBox1_update.Controls.Add(Me.Изменить_прививку)
        Me.GroupBox1_update.Controls.Add(Me.страна_производитель_обнв)
        Me.GroupBox1_update.Controls.Add(Me.наименование_прививки_обнв)
        Me.GroupBox1_update.Controls.Add(Me.id_прививки_обнв)
        Me.GroupBox1_update.Location = New System.Drawing.Point(6, 400)
        Me.GroupBox1_update.Name = "GroupBox1_update"
        Me.GroupBox1_update.Size = New System.Drawing.Size(623, 100)
        Me.GroupBox1_update.TabIndex = 16
        Me.GroupBox1_update.TabStop = False
        Me.GroupBox1_update.Text = "Изменить"
        '
        'Label100
        '
        Me.Label100.AutoSize = True
        Me.Label100.Location = New System.Drawing.Point(414, 19)
        Me.Label100.Name = "Label100"
        Me.Label100.Size = New System.Drawing.Size(132, 15)
        Me.Label100.TabIndex = 10
        Me.Label100.Text = "Количество привитых"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(91, 18)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(148, 15)
        Me.Label16.TabIndex = 8
        Me.Label16.Text = "Наименование прививки"
        '
        'колвоприв_обнов
        '
        Me.колвоприв_обнов.Location = New System.Drawing.Point(417, 39)
        Me.колвоприв_обнов.Name = "колвоприв_обнов"
        Me.колвоприв_обнов.Size = New System.Drawing.Size(69, 22)
        Me.колвоприв_обнов.TabIndex = 9
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(255, 19)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(134, 15)
        Me.Label22.TabIndex = 8
        Me.Label22.Text = "Страна производитель"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(6, 19)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(84, 15)
        Me.Label17.TabIndex = 7
        Me.Label17.Text = "ID_Прививки"
        '
        'Изменить_прививку
        '
        Me.Изменить_прививку.BackColor = System.Drawing.SystemColors.Window
        Me.Изменить_прививку.Location = New System.Drawing.Point(542, 71)
        Me.Изменить_прививку.Name = "Изменить_прививку"
        Me.Изменить_прививку.Size = New System.Drawing.Size(75, 23)
        Me.Изменить_прививку.TabIndex = 3
        Me.Изменить_прививку.Text = "Изменить"
        Me.Изменить_прививку.UseVisualStyleBackColor = False
        '
        'страна_производитель_обнв
        '
        Me.страна_производитель_обнв.Location = New System.Drawing.Point(258, 39)
        Me.страна_производитель_обнв.Name = "страна_производитель_обнв"
        Me.страна_производитель_обнв.Size = New System.Drawing.Size(153, 22)
        Me.страна_производитель_обнв.TabIndex = 7
        '
        'наименование_прививки_обнв
        '
        Me.наименование_прививки_обнв.Location = New System.Drawing.Point(86, 39)
        Me.наименование_прививки_обнв.Name = "наименование_прививки_обнв"
        Me.наименование_прививки_обнв.Size = New System.Drawing.Size(153, 22)
        Me.наименование_прививки_обнв.TabIndex = 5
        '
        'id_прививки_обнв
        '
        Me.id_прививки_обнв.Location = New System.Drawing.Point(9, 39)
        Me.id_прививки_обнв.Name = "id_прививки_обнв"
        Me.id_прививки_обнв.Size = New System.Drawing.Size(33, 22)
        Me.id_прививки_обнв.TabIndex = 5
        '
        'GroupBox1_del
        '
        Me.GroupBox1_del.Controls.Add(Me.Label18)
        Me.GroupBox1_del.Controls.Add(Me.Удалить_прививку)
        Me.GroupBox1_del.Controls.Add(Me.наименование_прививки_дел)
        Me.GroupBox1_del.Location = New System.Drawing.Point(635, 294)
        Me.GroupBox1_del.Name = "GroupBox1_del"
        Me.GroupBox1_del.Size = New System.Drawing.Size(200, 100)
        Me.GroupBox1_del.TabIndex = 15
        Me.GroupBox1_del.TabStop = False
        Me.GroupBox1_del.Text = "Удалить"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(6, 17)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(148, 15)
        Me.Label18.TabIndex = 7
        Me.Label18.Text = "Наименование прививки"
        '
        'Удалить_прививку
        '
        Me.Удалить_прививку.BackColor = System.Drawing.SystemColors.Window
        Me.Удалить_прививку.Location = New System.Drawing.Point(119, 71)
        Me.Удалить_прививку.Name = "Удалить_прививку"
        Me.Удалить_прививку.Size = New System.Drawing.Size(75, 23)
        Me.Удалить_прививку.TabIndex = 2
        Me.Удалить_прививку.Text = "Удалить"
        Me.Удалить_прививку.UseVisualStyleBackColor = False
        '
        'наименование_прививки_дел
        '
        Me.наименование_прививки_дел.Location = New System.Drawing.Point(10, 38)
        Me.наименование_прививки_дел.Name = "наименование_прививки_дел"
        Me.наименование_прививки_дел.Size = New System.Drawing.Size(184, 22)
        Me.наименование_прививки_дел.TabIndex = 1
        '
        'GroupBox1_add
        '
        Me.GroupBox1_add.Controls.Add(Me.Label99)
        Me.GroupBox1_add.Controls.Add(Me.колвоприв_доб)
        Me.GroupBox1_add.Controls.Add(Me.Label21)
        Me.GroupBox1_add.Controls.Add(Me.страна_производитель_доб)
        Me.GroupBox1_add.Controls.Add(Me.Добавить_прививку)
        Me.GroupBox1_add.Controls.Add(Me.наименование_прививки_доб)
        Me.GroupBox1_add.Controls.Add(Me.id_прививки_доб)
        Me.GroupBox1_add.Controls.Add(Me.Label19)
        Me.GroupBox1_add.Controls.Add(Me.Label20)
        Me.GroupBox1_add.Location = New System.Drawing.Point(6, 294)
        Me.GroupBox1_add.Name = "GroupBox1_add"
        Me.GroupBox1_add.Size = New System.Drawing.Size(623, 100)
        Me.GroupBox1_add.TabIndex = 14
        Me.GroupBox1_add.TabStop = False
        Me.GroupBox1_add.Text = "Добавить"
        '
        'Label99
        '
        Me.Label99.AutoSize = True
        Me.Label99.Location = New System.Drawing.Point(414, 18)
        Me.Label99.Name = "Label99"
        Me.Label99.Size = New System.Drawing.Size(132, 15)
        Me.Label99.TabIndex = 8
        Me.Label99.Text = "Количество привитых"
        '
        'колвоприв_доб
        '
        Me.колвоприв_доб.Location = New System.Drawing.Point(417, 38)
        Me.колвоприв_доб.Name = "колвоприв_доб"
        Me.колвоприв_доб.Size = New System.Drawing.Size(69, 22)
        Me.колвоприв_доб.TabIndex = 7
        Me.колвоприв_доб.Text = "0"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(255, 18)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(134, 15)
        Me.Label21.TabIndex = 6
        Me.Label21.Text = "Страна производитель"
        '
        'страна_производитель_доб
        '
        Me.страна_производитель_доб.Location = New System.Drawing.Point(258, 38)
        Me.страна_производитель_доб.Name = "страна_производитель_доб"
        Me.страна_производитель_доб.Size = New System.Drawing.Size(153, 22)
        Me.страна_производитель_доб.TabIndex = 5
        '
        'Добавить_прививку
        '
        Me.Добавить_прививку.BackColor = System.Drawing.SystemColors.Window
        Me.Добавить_прививку.Location = New System.Drawing.Point(542, 71)
        Me.Добавить_прививку.Name = "Добавить_прививку"
        Me.Добавить_прививку.Size = New System.Drawing.Size(75, 23)
        Me.Добавить_прививку.TabIndex = 4
        Me.Добавить_прививку.Text = "Добавить"
        Me.Добавить_прививку.UseVisualStyleBackColor = False
        '
        'наименование_прививки_доб
        '
        Me.наименование_прививки_доб.Location = New System.Drawing.Point(86, 38)
        Me.наименование_прививки_доб.Name = "наименование_прививки_доб"
        Me.наименование_прививки_доб.Size = New System.Drawing.Size(153, 22)
        Me.наименование_прививки_доб.TabIndex = 3
        '
        'id_прививки_доб
        '
        Me.id_прививки_доб.Location = New System.Drawing.Point(6, 38)
        Me.id_прививки_доб.Name = "id_прививки_доб"
        Me.id_прививки_доб.Size = New System.Drawing.Size(33, 22)
        Me.id_прививки_доб.TabIndex = 2
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(88, 18)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(148, 15)
        Me.Label19.TabIndex = 1
        Me.Label19.Text = "Наименование прививки"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(3, 19)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(84, 15)
        Me.Label20.TabIndex = 0
        Me.Label20.Text = "ID_Прививки"
        '
        'DGV_прививки_актул
        '
        Me.DGV_прививки_актул.AllowUserToAddRows = False
        Me.DGV_прививки_актул.AllowUserToDeleteRows = False
        Me.DGV_прививки_актул.AutoGenerateColumns = False
        Me.DGV_прививки_актул.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DGV_прививки_актул.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_прививки_актул.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDпривDataGridViewTextBoxColumn, Me.НазваниепрививкиDataGridViewTextBoxColumn, Me.СтранапроизводительDataGridViewTextBoxColumn, Me.КоличествопривитыхDataGridViewTextBoxColumn})
        Me.DGV_прививки_актул.DataSource = Me.ПрививкаBindingSource
        Me.DGV_прививки_актул.Location = New System.Drawing.Point(6, 6)
        Me.DGV_прививки_актул.Name = "DGV_прививки_актул"
        Me.DGV_прививки_актул.ReadOnly = True
        Me.DGV_прививки_актул.Size = New System.Drawing.Size(1208, 282)
        Me.DGV_прививки_актул.TabIndex = 3
        '
        'IDпривDataGridViewTextBoxColumn
        '
        Me.IDпривDataGridViewTextBoxColumn.DataPropertyName = "ID_прив"
        Me.IDпривDataGridViewTextBoxColumn.HeaderText = "ID_прив"
        Me.IDпривDataGridViewTextBoxColumn.Name = "IDпривDataGridViewTextBoxColumn"
        Me.IDпривDataGridViewTextBoxColumn.ReadOnly = True
        Me.IDпривDataGridViewTextBoxColumn.Width = 79
        '
        'НазваниепрививкиDataGridViewTextBoxColumn
        '
        Me.НазваниепрививкиDataGridViewTextBoxColumn.DataPropertyName = "Название_прививки"
        Me.НазваниепрививкиDataGridViewTextBoxColumn.HeaderText = "Название прививки"
        Me.НазваниепрививкиDataGridViewTextBoxColumn.Name = "НазваниепрививкиDataGridViewTextBoxColumn"
        Me.НазваниепрививкиDataGridViewTextBoxColumn.ReadOnly = True
        Me.НазваниепрививкиDataGridViewTextBoxColumn.Width = 131
        '
        'СтранапроизводительDataGridViewTextBoxColumn
        '
        Me.СтранапроизводительDataGridViewTextBoxColumn.DataPropertyName = "Страна_производитель"
        Me.СтранапроизводительDataGridViewTextBoxColumn.HeaderText = "Страна производитель"
        Me.СтранапроизводительDataGridViewTextBoxColumn.Name = "СтранапроизводительDataGridViewTextBoxColumn"
        Me.СтранапроизводительDataGridViewTextBoxColumn.ReadOnly = True
        Me.СтранапроизводительDataGridViewTextBoxColumn.Width = 145
        '
        'КоличествопривитыхDataGridViewTextBoxColumn
        '
        Me.КоличествопривитыхDataGridViewTextBoxColumn.DataPropertyName = "Количество_привитых"
        Me.КоличествопривитыхDataGridViewTextBoxColumn.HeaderText = "Количество привитых"
        Me.КоличествопривитыхDataGridViewTextBoxColumn.Name = "КоличествопривитыхDataGridViewTextBoxColumn"
        Me.КоличествопривитыхDataGridViewTextBoxColumn.ReadOnly = True
        Me.КоличествопривитыхDataGridViewTextBoxColumn.Width = 143
        '
        'ПрививкаBindingSource
        '
        Me.ПрививкаBindingSource.DataMember = "Прививка"
        Me.ПрививкаBindingSource.DataSource = Me.AnimalBDDataSet
        '
        'Mesto
        '
        Me.Mesto.Controls.Add(Me.GroupBox2_update)
        Me.Mesto.Controls.Add(Me.GroupBox2_del)
        Me.Mesto.Controls.Add(Me.GroupBox2_add)
        Me.Mesto.Controls.Add(Me.DGV_место_размещ_актул)
        Me.Mesto.Location = New System.Drawing.Point(4, 24)
        Me.Mesto.Name = "Mesto"
        Me.Mesto.Padding = New System.Windows.Forms.Padding(3)
        Me.Mesto.Size = New System.Drawing.Size(1221, 565)
        Me.Mesto.TabIndex = 4
        Me.Mesto.Text = "Место размещения электронного чипа"
        Me.Mesto.UseVisualStyleBackColor = True
        '
        'GroupBox2_update
        '
        Me.GroupBox2_update.Controls.Add(Me.Label26)
        Me.GroupBox2_update.Controls.Add(Me.Label23)
        Me.GroupBox2_update.Controls.Add(Me.Изменить_место_размещ_чипа)
        Me.GroupBox2_update.Controls.Add(Me.где_обнв)
        Me.GroupBox2_update.Controls.Add(Me.id_места_обнв)
        Me.GroupBox2_update.Location = New System.Drawing.Point(510, 357)
        Me.GroupBox2_update.Name = "GroupBox2_update"
        Me.GroupBox2_update.Size = New System.Drawing.Size(300, 100)
        Me.GroupBox2_update.TabIndex = 11
        Me.GroupBox2_update.TabStop = False
        Me.GroupBox2_update.Text = "Изменить"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(83, 21)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(27, 15)
        Me.Label26.TabIndex = 7
        Me.Label26.Text = "Где"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(6, 18)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(62, 15)
        Me.Label23.TabIndex = 5
        Me.Label23.Text = "ID_Места"
        '
        'Изменить_место_размещ_чипа
        '
        Me.Изменить_место_размещ_чипа.BackColor = System.Drawing.SystemColors.Window
        Me.Изменить_место_размещ_чипа.Location = New System.Drawing.Point(219, 72)
        Me.Изменить_место_размещ_чипа.Name = "Изменить_место_размещ_чипа"
        Me.Изменить_место_размещ_чипа.Size = New System.Drawing.Size(75, 23)
        Me.Изменить_место_размещ_чипа.TabIndex = 3
        Me.Изменить_место_размещ_чипа.Text = "Изменить"
        Me.Изменить_место_размещ_чипа.UseVisualStyleBackColor = False
        '
        'где_обнв
        '
        Me.где_обнв.Location = New System.Drawing.Point(86, 39)
        Me.где_обнв.Name = "где_обнв"
        Me.где_обнв.Size = New System.Drawing.Size(153, 22)
        Me.где_обнв.TabIndex = 5
        '
        'id_места_обнв
        '
        Me.id_места_обнв.Location = New System.Drawing.Point(9, 39)
        Me.id_места_обнв.Name = "id_места_обнв"
        Me.id_места_обнв.Size = New System.Drawing.Size(33, 22)
        Me.id_места_обнв.TabIndex = 5
        '
        'GroupBox2_del
        '
        Me.GroupBox2_del.Controls.Add(Me.Label25)
        Me.GroupBox2_del.Controls.Add(Me.Удалить_место_размещ_чипа)
        Me.GroupBox2_del.Controls.Add(Me.где_дел)
        Me.GroupBox2_del.Location = New System.Drawing.Point(304, 358)
        Me.GroupBox2_del.Name = "GroupBox2_del"
        Me.GroupBox2_del.Size = New System.Drawing.Size(200, 100)
        Me.GroupBox2_del.TabIndex = 10
        Me.GroupBox2_del.TabStop = False
        Me.GroupBox2_del.Text = "Удалить"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(8, 20)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(27, 15)
        Me.Label25.TabIndex = 6
        Me.Label25.Text = "Где"
        '
        'Удалить_место_размещ_чипа
        '
        Me.Удалить_место_размещ_чипа.BackColor = System.Drawing.SystemColors.Window
        Me.Удалить_место_размещ_чипа.Location = New System.Drawing.Point(119, 71)
        Me.Удалить_место_размещ_чипа.Name = "Удалить_место_размещ_чипа"
        Me.Удалить_место_размещ_чипа.Size = New System.Drawing.Size(75, 23)
        Me.Удалить_место_размещ_чипа.TabIndex = 2
        Me.Удалить_место_размещ_чипа.Text = "Удалить"
        Me.Удалить_место_размещ_чипа.UseVisualStyleBackColor = False
        '
        'где_дел
        '
        Me.где_дел.Location = New System.Drawing.Point(10, 38)
        Me.где_дел.Name = "где_дел"
        Me.где_дел.Size = New System.Drawing.Size(184, 22)
        Me.где_дел.TabIndex = 1
        '
        'GroupBox2_add
        '
        Me.GroupBox2_add.Controls.Add(Me.Label24)
        Me.GroupBox2_add.Controls.Add(Me.Добавить_место_размещ_чипа)
        Me.GroupBox2_add.Controls.Add(Me.где_доб)
        Me.GroupBox2_add.Controls.Add(Me.id_места_доб)
        Me.GroupBox2_add.Controls.Add(Me.Label27)
        Me.GroupBox2_add.Location = New System.Drawing.Point(6, 357)
        Me.GroupBox2_add.Name = "GroupBox2_add"
        Me.GroupBox2_add.Size = New System.Drawing.Size(291, 100)
        Me.GroupBox2_add.TabIndex = 8
        Me.GroupBox2_add.TabStop = False
        Me.GroupBox2_add.Text = "Добавить"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(88, 20)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(27, 15)
        Me.Label24.TabIndex = 5
        Me.Label24.Text = "Где"
        '
        'Добавить_место_размещ_чипа
        '
        Me.Добавить_место_размещ_чипа.BackColor = System.Drawing.SystemColors.Window
        Me.Добавить_место_размещ_чипа.Location = New System.Drawing.Point(210, 71)
        Me.Добавить_место_размещ_чипа.Name = "Добавить_место_размещ_чипа"
        Me.Добавить_место_размещ_чипа.Size = New System.Drawing.Size(75, 23)
        Me.Добавить_место_размещ_чипа.TabIndex = 4
        Me.Добавить_место_размещ_чипа.Text = "Добавить"
        Me.Добавить_место_размещ_чипа.UseVisualStyleBackColor = False
        '
        'где_доб
        '
        Me.где_доб.Location = New System.Drawing.Point(86, 38)
        Me.где_доб.Name = "где_доб"
        Me.где_доб.Size = New System.Drawing.Size(153, 22)
        Me.где_доб.TabIndex = 3
        '
        'id_места_доб
        '
        Me.id_места_доб.Location = New System.Drawing.Point(6, 38)
        Me.id_места_доб.Name = "id_места_доб"
        Me.id_места_доб.Size = New System.Drawing.Size(33, 22)
        Me.id_места_доб.TabIndex = 2
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(3, 19)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(62, 15)
        Me.Label27.TabIndex = 0
        Me.Label27.Text = "ID_Места"
        '
        'DGV_место_размещ_актул
        '
        Me.DGV_место_размещ_актул.AllowUserToAddRows = False
        Me.DGV_место_размещ_актул.AllowUserToDeleteRows = False
        Me.DGV_место_размещ_актул.AutoGenerateColumns = False
        Me.DGV_место_размещ_актул.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_место_размещ_актул.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDМестоDataGridViewTextBoxColumn, Me.ГдеDataGridViewTextBoxColumn})
        Me.DGV_место_размещ_актул.DataSource = Me.МесторазмещенияэлектронногочипаBindingSource
        Me.DGV_место_размещ_актул.Location = New System.Drawing.Point(6, 6)
        Me.DGV_место_размещ_актул.Name = "DGV_место_размещ_актул"
        Me.DGV_место_размещ_актул.ReadOnly = True
        Me.DGV_место_размещ_актул.Size = New System.Drawing.Size(1208, 282)
        Me.DGV_место_размещ_актул.TabIndex = 4
        '
        'IDМестоDataGridViewTextBoxColumn
        '
        Me.IDМестоDataGridViewTextBoxColumn.DataPropertyName = "ID_Место"
        Me.IDМестоDataGridViewTextBoxColumn.HeaderText = "ID_Место"
        Me.IDМестоDataGridViewTextBoxColumn.Name = "IDМестоDataGridViewTextBoxColumn"
        Me.IDМестоDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ГдеDataGridViewTextBoxColumn
        '
        Me.ГдеDataGridViewTextBoxColumn.DataPropertyName = "Где"
        Me.ГдеDataGridViewTextBoxColumn.HeaderText = "Где"
        Me.ГдеDataGridViewTextBoxColumn.Name = "ГдеDataGridViewTextBoxColumn"
        Me.ГдеDataGridViewTextBoxColumn.ReadOnly = True
        '
        'МесторазмещенияэлектронногочипаBindingSource
        '
        Me.МесторазмещенияэлектронногочипаBindingSource.DataMember = "Место_размещения_электронного_чипа"
        Me.МесторазмещенияэлектронногочипаBindingSource.DataSource = Me.AnimalBDDataSet
        '
        'Porod
        '
        Me.Porod.Controls.Add(Me.GroupBox3_update)
        Me.Porod.Controls.Add(Me.GroupBox3_del)
        Me.Porod.Controls.Add(Me.GroupBox3_add)
        Me.Porod.Controls.Add(Me.DGV_породы_актул)
        Me.Porod.Location = New System.Drawing.Point(4, 24)
        Me.Porod.Name = "Porod"
        Me.Porod.Padding = New System.Windows.Forms.Padding(3)
        Me.Porod.Size = New System.Drawing.Size(1221, 565)
        Me.Porod.TabIndex = 5
        Me.Porod.Text = "Породы"
        Me.Porod.UseVisualStyleBackColor = True
        '
        'GroupBox3_update
        '
        Me.GroupBox3_update.Controls.Add(Me.Label30)
        Me.GroupBox3_update.Controls.Add(Me.Label28)
        Me.GroupBox3_update.Controls.Add(Me.Изменить_породу)
        Me.GroupBox3_update.Controls.Add(Me.название_породы_обнв)
        Me.GroupBox3_update.Controls.Add(Me.id_породы_обнв)
        Me.GroupBox3_update.Location = New System.Drawing.Point(510, 357)
        Me.GroupBox3_update.Name = "GroupBox3_update"
        Me.GroupBox3_update.Size = New System.Drawing.Size(300, 100)
        Me.GroupBox3_update.TabIndex = 17
        Me.GroupBox3_update.TabStop = False
        Me.GroupBox3_update.Text = "Изменить"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Location = New System.Drawing.Point(83, 21)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(60, 15)
        Me.Label30.TabIndex = 6
        Me.Label30.Text = "Название"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(6, 21)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(71, 15)
        Me.Label28.TabIndex = 5
        Me.Label28.Text = "ID_Породы"
        '
        'Изменить_породу
        '
        Me.Изменить_породу.BackColor = System.Drawing.SystemColors.Window
        Me.Изменить_породу.Location = New System.Drawing.Point(219, 72)
        Me.Изменить_породу.Name = "Изменить_породу"
        Me.Изменить_породу.Size = New System.Drawing.Size(75, 23)
        Me.Изменить_породу.TabIndex = 3
        Me.Изменить_породу.Text = "Изменить"
        Me.Изменить_породу.UseVisualStyleBackColor = False
        '
        'название_породы_обнв
        '
        Me.название_породы_обнв.Location = New System.Drawing.Point(86, 39)
        Me.название_породы_обнв.Name = "название_породы_обнв"
        Me.название_породы_обнв.Size = New System.Drawing.Size(153, 22)
        Me.название_породы_обнв.TabIndex = 5
        '
        'id_породы_обнв
        '
        Me.id_породы_обнв.Location = New System.Drawing.Point(9, 39)
        Me.id_породы_обнв.Name = "id_породы_обнв"
        Me.id_породы_обнв.Size = New System.Drawing.Size(33, 22)
        Me.id_породы_обнв.TabIndex = 5
        '
        'GroupBox3_del
        '
        Me.GroupBox3_del.Controls.Add(Me.Label29)
        Me.GroupBox3_del.Controls.Add(Me.Удалить_породу)
        Me.GroupBox3_del.Controls.Add(Me.название_породы_дел)
        Me.GroupBox3_del.Location = New System.Drawing.Point(304, 358)
        Me.GroupBox3_del.Name = "GroupBox3_del"
        Me.GroupBox3_del.Size = New System.Drawing.Size(200, 100)
        Me.GroupBox3_del.TabIndex = 16
        Me.GroupBox3_del.TabStop = False
        Me.GroupBox3_del.Text = "Удалить"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(7, 20)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(60, 15)
        Me.Label29.TabIndex = 5
        Me.Label29.Text = "Название"
        '
        'Удалить_породу
        '
        Me.Удалить_породу.BackColor = System.Drawing.SystemColors.Window
        Me.Удалить_породу.Location = New System.Drawing.Point(119, 71)
        Me.Удалить_породу.Name = "Удалить_породу"
        Me.Удалить_породу.Size = New System.Drawing.Size(75, 23)
        Me.Удалить_породу.TabIndex = 2
        Me.Удалить_породу.Text = "Удалить"
        Me.Удалить_породу.UseVisualStyleBackColor = False
        '
        'название_породы_дел
        '
        Me.название_породы_дел.Location = New System.Drawing.Point(10, 38)
        Me.название_породы_дел.Name = "название_породы_дел"
        Me.название_породы_дел.Size = New System.Drawing.Size(184, 22)
        Me.название_породы_дел.TabIndex = 1
        '
        'GroupBox3_add
        '
        Me.GroupBox3_add.Controls.Add(Me.Добавить_породу)
        Me.GroupBox3_add.Controls.Add(Me.название_породы_доб)
        Me.GroupBox3_add.Controls.Add(Me.id_породы_доб)
        Me.GroupBox3_add.Controls.Add(Me.Label31)
        Me.GroupBox3_add.Controls.Add(Me.Label32)
        Me.GroupBox3_add.Location = New System.Drawing.Point(6, 357)
        Me.GroupBox3_add.Name = "GroupBox3_add"
        Me.GroupBox3_add.Size = New System.Drawing.Size(291, 100)
        Me.GroupBox3_add.TabIndex = 15
        Me.GroupBox3_add.TabStop = False
        Me.GroupBox3_add.Text = "Добавить"
        '
        'Добавить_породу
        '
        Me.Добавить_породу.BackColor = System.Drawing.SystemColors.Window
        Me.Добавить_породу.Location = New System.Drawing.Point(210, 71)
        Me.Добавить_породу.Name = "Добавить_породу"
        Me.Добавить_породу.Size = New System.Drawing.Size(75, 23)
        Me.Добавить_породу.TabIndex = 4
        Me.Добавить_породу.Text = "Добавить"
        Me.Добавить_породу.UseVisualStyleBackColor = False
        '
        'название_породы_доб
        '
        Me.название_породы_доб.Location = New System.Drawing.Point(86, 38)
        Me.название_породы_доб.Name = "название_породы_доб"
        Me.название_породы_доб.Size = New System.Drawing.Size(153, 22)
        Me.название_породы_доб.TabIndex = 3
        '
        'id_породы_доб
        '
        Me.id_породы_доб.Location = New System.Drawing.Point(6, 38)
        Me.id_породы_доб.Name = "id_породы_доб"
        Me.id_породы_доб.Size = New System.Drawing.Size(33, 22)
        Me.id_породы_доб.TabIndex = 2
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Location = New System.Drawing.Point(83, 19)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(60, 15)
        Me.Label31.TabIndex = 1
        Me.Label31.Text = "Название"
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Location = New System.Drawing.Point(3, 19)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(71, 15)
        Me.Label32.TabIndex = 0
        Me.Label32.Text = "ID_Породы"
        '
        'DGV_породы_актул
        '
        Me.DGV_породы_актул.AllowUserToAddRows = False
        Me.DGV_породы_актул.AllowUserToDeleteRows = False
        Me.DGV_породы_актул.AutoGenerateColumns = False
        Me.DGV_породы_актул.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_породы_актул.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDПородыDataGridViewTextBoxColumn, Me.НазваниеDataGridViewTextBoxColumn2})
        Me.DGV_породы_актул.DataSource = Me.ПородыBindingSource
        Me.DGV_породы_актул.Location = New System.Drawing.Point(6, 6)
        Me.DGV_породы_актул.Name = "DGV_породы_актул"
        Me.DGV_породы_актул.ReadOnly = True
        Me.DGV_породы_актул.Size = New System.Drawing.Size(1208, 282)
        Me.DGV_породы_актул.TabIndex = 5
        '
        'IDПородыDataGridViewTextBoxColumn
        '
        Me.IDПородыDataGridViewTextBoxColumn.DataPropertyName = "ID_Породы"
        Me.IDПородыDataGridViewTextBoxColumn.HeaderText = "ID_Породы"
        Me.IDПородыDataGridViewTextBoxColumn.Name = "IDПородыDataGridViewTextBoxColumn"
        Me.IDПородыDataGridViewTextBoxColumn.ReadOnly = True
        '
        'НазваниеDataGridViewTextBoxColumn2
        '
        Me.НазваниеDataGridViewTextBoxColumn2.DataPropertyName = "Название"
        Me.НазваниеDataGridViewTextBoxColumn2.HeaderText = "Название"
        Me.НазваниеDataGridViewTextBoxColumn2.Name = "НазваниеDataGridViewTextBoxColumn2"
        Me.НазваниеDataGridViewTextBoxColumn2.ReadOnly = True
        '
        'ПородыBindingSource
        '
        Me.ПородыBindingSource.DataMember = "Породы"
        Me.ПородыBindingSource.DataSource = Me.AnimalBDDataSet
        '
        'Vladelti
        '
        Me.Vladelti.BackColor = System.Drawing.SystemColors.Window
        Me.Vladelti.Controls.Add(Me.DGV_Владельцы_актул)
        Me.Vladelti.Controls.Add(Me.GroupBox4_update)
        Me.Vladelti.Controls.Add(Me.GroupBox4_del)
        Me.Vladelti.Controls.Add(Me.GroupBox4_add)
        Me.Vladelti.Location = New System.Drawing.Point(4, 24)
        Me.Vladelti.Name = "Vladelti"
        Me.Vladelti.Padding = New System.Windows.Forms.Padding(3)
        Me.Vladelti.Size = New System.Drawing.Size(1221, 565)
        Me.Vladelti.TabIndex = 6
        Me.Vladelti.Text = "Владельцы"
        '
        'DGV_Владельцы_актул
        '
        Me.DGV_Владельцы_актул.AllowUserToAddRows = False
        Me.DGV_Владельцы_актул.AllowUserToDeleteRows = False
        Me.DGV_Владельцы_актул.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DGV_Владельцы_актул.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_Владельцы_актул.Location = New System.Drawing.Point(16, 7)
        Me.DGV_Владельцы_актул.Name = "DGV_Владельцы_актул"
        Me.DGV_Владельцы_актул.ReadOnly = True
        Me.DGV_Владельцы_актул.Size = New System.Drawing.Size(1193, 344)
        Me.DGV_Владельцы_актул.TabIndex = 22
        '
        'GroupBox4_update
        '
        Me.GroupBox4_update.Controls.Add(Me.D2)
        Me.GroupBox4_update.Controls.Add(Me.id_страны_влад_обнв)
        Me.GroupBox4_update.Controls.Add(Me.Label33)
        Me.GroupBox4_update.Controls.Add(Me.Изменить_владельца)
        Me.GroupBox4_update.Controls.Add(Me.номер_дома_обнв)
        Me.GroupBox4_update.Controls.Add(Me.Label47)
        Me.GroupBox4_update.Controls.Add(Me.Label34)
        Me.GroupBox4_update.Controls.Add(Me.Label46)
        Me.GroupBox4_update.Controls.Add(Me.улица_обнв)
        Me.GroupBox4_update.Controls.Add(Me.id_владельца_обнв)
        Me.GroupBox4_update.Controls.Add(Me.Label43)
        Me.GroupBox4_update.Controls.Add(Me.ФИО_обнв)
        Me.GroupBox4_update.Controls.Add(Me.город_обнв)
        Me.GroupBox4_update.Controls.Add(Me.Label45)
        Me.GroupBox4_update.Controls.Add(Me.Label44)
        Me.GroupBox4_update.Location = New System.Drawing.Point(7, 459)
        Me.GroupBox4_update.Name = "GroupBox4_update"
        Me.GroupBox4_update.Size = New System.Drawing.Size(1002, 100)
        Me.GroupBox4_update.TabIndex = 21
        Me.GroupBox4_update.TabStop = False
        Me.GroupBox4_update.Text = "Изменить"
        '
        'id_страны_влад_обнв
        '
        Me.id_страны_влад_обнв.DataSource = Me.СтранаBindingSource
        Me.id_страны_влад_обнв.DisplayMember = "Название"
        Me.id_страны_влад_обнв.FormattingEnabled = True
        Me.id_страны_влад_обнв.Location = New System.Drawing.Point(380, 37)
        Me.id_страны_влад_обнв.Name = "id_страны_влад_обнв"
        Me.id_страны_влад_обнв.Size = New System.Drawing.Size(121, 23)
        Me.id_страны_влад_обнв.TabIndex = 18
        Me.id_страны_влад_обнв.ValueMember = "ID_Страны"
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Location = New System.Drawing.Point(812, 17)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(74, 15)
        Me.Label33.TabIndex = 29
        Me.Label33.Text = "Номер дома"
        '
        'Изменить_владельца
        '
        Me.Изменить_владельца.BackColor = System.Drawing.SystemColors.Window
        Me.Изменить_владельца.Location = New System.Drawing.Point(921, 71)
        Me.Изменить_владельца.Name = "Изменить_владельца"
        Me.Изменить_владельца.Size = New System.Drawing.Size(75, 23)
        Me.Изменить_владельца.TabIndex = 3
        Me.Изменить_владельца.Text = "Изменить"
        Me.Изменить_владельца.UseVisualStyleBackColor = False
        '
        'номер_дома_обнв
        '
        Me.номер_дома_обнв.Location = New System.Drawing.Point(815, 37)
        Me.номер_дома_обнв.Name = "номер_дома_обнв"
        Me.номер_дома_обнв.Size = New System.Drawing.Size(33, 22)
        Me.номер_дома_обнв.TabIndex = 28
        '
        'Label47
        '
        Me.Label47.AutoSize = True
        Me.Label47.Location = New System.Drawing.Point(6, 18)
        Me.Label47.Name = "Label47"
        Me.Label47.Size = New System.Drawing.Size(89, 15)
        Me.Label47.TabIndex = 16
        Me.Label47.Text = "ID_Владельца"
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Location = New System.Drawing.Point(668, 19)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(43, 15)
        Me.Label34.TabIndex = 27
        Me.Label34.Text = "Улица"
        '
        'Label46
        '
        Me.Label46.AutoSize = True
        Me.Label46.Location = New System.Drawing.Point(101, 17)
        Me.Label46.Name = "Label46"
        Me.Label46.Size = New System.Drawing.Size(38, 15)
        Me.Label46.TabIndex = 17
        Me.Label46.Text = "ФИО"
        '
        'улица_обнв
        '
        Me.улица_обнв.Location = New System.Drawing.Point(668, 37)
        Me.улица_обнв.Name = "улица_обнв"
        Me.улица_обнв.Size = New System.Drawing.Size(107, 22)
        Me.улица_обнв.TabIndex = 26
        '
        'id_владельца_обнв
        '
        Me.id_владельца_обнв.Location = New System.Drawing.Point(9, 37)
        Me.id_владельца_обнв.Name = "id_владельца_обнв"
        Me.id_владельца_обнв.Size = New System.Drawing.Size(33, 22)
        Me.id_владельца_обнв.TabIndex = 18
        '
        'Label43
        '
        Me.Label43.AutoSize = True
        Me.Label43.Location = New System.Drawing.Point(516, 18)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(39, 15)
        Me.Label43.TabIndex = 25
        Me.Label43.Text = "Город"
        '
        'ФИО_обнв
        '
        Me.ФИО_обнв.Location = New System.Drawing.Point(89, 37)
        Me.ФИО_обнв.Name = "ФИО_обнв"
        Me.ФИО_обнв.Size = New System.Drawing.Size(153, 22)
        Me.ФИО_обнв.TabIndex = 19
        '
        'город_обнв
        '
        Me.город_обнв.Location = New System.Drawing.Point(519, 37)
        Me.город_обнв.Name = "город_обнв"
        Me.город_обнв.Size = New System.Drawing.Size(107, 22)
        Me.город_обнв.TabIndex = 24
        '
        'Label45
        '
        Me.Label45.AutoSize = True
        Me.Label45.Location = New System.Drawing.Point(258, 18)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(93, 15)
        Me.Label45.TabIndex = 20
        Me.Label45.Text = "Дата рождения"
        '
        'Label44
        '
        Me.Label44.AutoSize = True
        Me.Label44.Location = New System.Drawing.Point(377, 17)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(47, 15)
        Me.Label44.TabIndex = 23
        Me.Label44.Text = "Страна"
        '
        'GroupBox4_del
        '
        Me.GroupBox4_del.Controls.Add(Me.Label35)
        Me.GroupBox4_del.Controls.Add(Me.Удалить_владельца)
        Me.GroupBox4_del.Controls.Add(Me.ФИО_дел)
        Me.GroupBox4_del.Location = New System.Drawing.Point(1015, 357)
        Me.GroupBox4_del.Name = "GroupBox4_del"
        Me.GroupBox4_del.Size = New System.Drawing.Size(200, 100)
        Me.GroupBox4_del.TabIndex = 20
        Me.GroupBox4_del.TabStop = False
        Me.GroupBox4_del.Text = "Удалить"
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Location = New System.Drawing.Point(7, 20)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(38, 15)
        Me.Label35.TabIndex = 5
        Me.Label35.Text = "ФИО"
        '
        'Удалить_владельца
        '
        Me.Удалить_владельца.BackColor = System.Drawing.SystemColors.Window
        Me.Удалить_владельца.Location = New System.Drawing.Point(119, 71)
        Me.Удалить_владельца.Name = "Удалить_владельца"
        Me.Удалить_владельца.Size = New System.Drawing.Size(75, 23)
        Me.Удалить_владельца.TabIndex = 2
        Me.Удалить_владельца.Text = "Удалить"
        Me.Удалить_владельца.UseVisualStyleBackColor = False
        '
        'ФИО_дел
        '
        Me.ФИО_дел.Location = New System.Drawing.Point(10, 38)
        Me.ФИО_дел.Name = "ФИО_дел"
        Me.ФИО_дел.Size = New System.Drawing.Size(184, 22)
        Me.ФИО_дел.TabIndex = 1
        '
        'GroupBox4_add
        '
        Me.GroupBox4_add.Controls.Add(Me.D1)
        Me.GroupBox4_add.Controls.Add(Me.id_страны_влад_доб)
        Me.GroupBox4_add.Controls.Add(Me.Label42)
        Me.GroupBox4_add.Controls.Add(Me.номер_дома_доб)
        Me.GroupBox4_add.Controls.Add(Me.Label41)
        Me.GroupBox4_add.Controls.Add(Me.улица_доб)
        Me.GroupBox4_add.Controls.Add(Me.Label40)
        Me.GroupBox4_add.Controls.Add(Me.город_доб)
        Me.GroupBox4_add.Controls.Add(Me.Label39)
        Me.GroupBox4_add.Controls.Add(Me.Label38)
        Me.GroupBox4_add.Controls.Add(Me.Добавть_владельца)
        Me.GroupBox4_add.Controls.Add(Me.ФИО_доб)
        Me.GroupBox4_add.Controls.Add(Me.id_владельца_доб)
        Me.GroupBox4_add.Controls.Add(Me.Label36)
        Me.GroupBox4_add.Controls.Add(Me.Label37)
        Me.GroupBox4_add.Location = New System.Drawing.Point(7, 357)
        Me.GroupBox4_add.Name = "GroupBox4_add"
        Me.GroupBox4_add.Size = New System.Drawing.Size(1002, 100)
        Me.GroupBox4_add.TabIndex = 19
        Me.GroupBox4_add.TabStop = False
        Me.GroupBox4_add.Text = "Добавить"
        '
        'id_страны_влад_доб
        '
        Me.id_страны_влад_доб.DataSource = Me.СтранаBindingSource
        Me.id_страны_влад_доб.DisplayMember = "Название"
        Me.id_страны_влад_доб.FormattingEnabled = True
        Me.id_страны_влад_доб.Location = New System.Drawing.Point(377, 38)
        Me.id_страны_влад_доб.Name = "id_страны_влад_доб"
        Me.id_страны_влад_доб.Size = New System.Drawing.Size(121, 23)
        Me.id_страны_влад_доб.TabIndex = 17
        Me.id_страны_влад_доб.ValueMember = "ID_Страны"
        '
        'Label42
        '
        Me.Label42.AutoSize = True
        Me.Label42.Location = New System.Drawing.Point(812, 19)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(74, 15)
        Me.Label42.TabIndex = 15
        Me.Label42.Text = "Номер дома"
        '
        'номер_дома_доб
        '
        Me.номер_дома_доб.Location = New System.Drawing.Point(815, 39)
        Me.номер_дома_доб.Name = "номер_дома_доб"
        Me.номер_дома_доб.Size = New System.Drawing.Size(33, 22)
        Me.номер_дома_доб.TabIndex = 14
        '
        'Label41
        '
        Me.Label41.AutoSize = True
        Me.Label41.Location = New System.Drawing.Point(665, 19)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(43, 15)
        Me.Label41.TabIndex = 13
        Me.Label41.Text = "Улица"
        '
        'улица_доб
        '
        Me.улица_доб.Location = New System.Drawing.Point(668, 39)
        Me.улица_доб.Name = "улица_доб"
        Me.улица_доб.Size = New System.Drawing.Size(107, 22)
        Me.улица_доб.TabIndex = 12
        '
        'Label40
        '
        Me.Label40.AutoSize = True
        Me.Label40.Location = New System.Drawing.Point(516, 18)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(39, 15)
        Me.Label40.TabIndex = 11
        Me.Label40.Text = "Город"
        '
        'город_доб
        '
        Me.город_доб.Location = New System.Drawing.Point(519, 39)
        Me.город_доб.Name = "город_доб"
        Me.город_доб.Size = New System.Drawing.Size(107, 22)
        Me.город_доб.TabIndex = 10
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.Location = New System.Drawing.Point(374, 18)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(47, 15)
        Me.Label39.TabIndex = 9
        Me.Label39.Text = "Страна"
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.Location = New System.Drawing.Point(255, 19)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(93, 15)
        Me.Label38.TabIndex = 6
        Me.Label38.Text = "Дата рождения"
        '
        'Добавть_владельца
        '
        Me.Добавть_владельца.BackColor = System.Drawing.SystemColors.Window
        Me.Добавть_владельца.Location = New System.Drawing.Point(921, 71)
        Me.Добавть_владельца.Name = "Добавть_владельца"
        Me.Добавть_владельца.Size = New System.Drawing.Size(75, 23)
        Me.Добавть_владельца.TabIndex = 4
        Me.Добавть_владельца.Text = "Добавить"
        Me.Добавть_владельца.UseVisualStyleBackColor = False
        '
        'ФИО_доб
        '
        Me.ФИО_доб.Location = New System.Drawing.Point(86, 38)
        Me.ФИО_доб.Name = "ФИО_доб"
        Me.ФИО_доб.Size = New System.Drawing.Size(153, 22)
        Me.ФИО_доб.TabIndex = 3
        '
        'id_владельца_доб
        '
        Me.id_владельца_доб.Location = New System.Drawing.Point(6, 38)
        Me.id_владельца_доб.Name = "id_владельца_доб"
        Me.id_владельца_доб.Size = New System.Drawing.Size(33, 22)
        Me.id_владельца_доб.TabIndex = 2
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Location = New System.Drawing.Point(98, 18)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(38, 15)
        Me.Label36.TabIndex = 1
        Me.Label36.Text = "ФИО"
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.Location = New System.Drawing.Point(3, 19)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(89, 15)
        Me.Label37.TabIndex = 0
        Me.Label37.Text = "ID_Владельца"
        '
        'Pasport
        '
        Me.Pasport.Controls.Add(Me.DGV_паспорт_животного_актул)
        Me.Pasport.Controls.Add(Me.GroupBox5_update)
        Me.Pasport.Controls.Add(Me.GroupBox5_del)
        Me.Pasport.Controls.Add(Me.GroupBox5_add)
        Me.Pasport.Location = New System.Drawing.Point(4, 24)
        Me.Pasport.Name = "Pasport"
        Me.Pasport.Padding = New System.Windows.Forms.Padding(3)
        Me.Pasport.Size = New System.Drawing.Size(1221, 565)
        Me.Pasport.TabIndex = 7
        Me.Pasport.Text = "Паспорт животного"
        Me.Pasport.UseVisualStyleBackColor = True
        '
        'DGV_паспорт_животного_актул
        '
        Me.DGV_паспорт_животного_актул.AllowUserToAddRows = False
        Me.DGV_паспорт_животного_актул.AllowUserToDeleteRows = False
        Me.DGV_паспорт_животного_актул.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DGV_паспорт_животного_актул.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_паспорт_животного_актул.Location = New System.Drawing.Point(12, 7)
        Me.DGV_паспорт_животного_актул.Name = "DGV_паспорт_животного_актул"
        Me.DGV_паспорт_животного_актул.ReadOnly = True
        Me.DGV_паспорт_животного_актул.Size = New System.Drawing.Size(1199, 281)
        Me.DGV_паспорт_животного_актул.TabIndex = 38
        '
        'GroupBox5_update
        '
        Me.GroupBox5_update.Controls.Add(Me.d6)
        Me.GroupBox5_update.Controls.Add(Me.d5)
        Me.GroupBox5_update.Controls.Add(Me.Label96)
        Me.GroupBox5_update.Controls.Add(Me.номер_чипа_обнв)
        Me.GroupBox5_update.Controls.Add(Me.id_владельца_животного_обнв)
        Me.GroupBox5_update.Controls.Add(Me.id_породы_животного_обнв)
        Me.GroupBox5_update.Controls.Add(Me.место_размещения_обнв)
        Me.GroupBox5_update.Controls.Add(Me.Изменить_паспорт)
        Me.GroupBox5_update.Controls.Add(Me.Label49)
        Me.GroupBox5_update.Controls.Add(Me.имя_мамы_обнв)
        Me.GroupBox5_update.Controls.Add(Me.окрас_животного_обнв)
        Me.GroupBox5_update.Controls.Add(Me.Label50)
        Me.GroupBox5_update.Controls.Add(Me.Label51)
        Me.GroupBox5_update.Controls.Add(Me.группа_животного_обнв)
        Me.GroupBox5_update.Controls.Add(Me.Label52)
        Me.GroupBox5_update.Controls.Add(Me.Label53)
        Me.GroupBox5_update.Controls.Add(Me.Label54)
        Me.GroupBox5_update.Controls.Add(Me.Label55)
        Me.GroupBox5_update.Controls.Add(Me.пол_животного_обнв)
        Me.GroupBox5_update.Controls.Add(Me.Label69)
        Me.GroupBox5_update.Controls.Add(Me.имя_папы_обнв)
        Me.GroupBox5_update.Controls.Add(Me.Label70)
        Me.GroupBox5_update.Controls.Add(Me.имя_животного_обнв)
        Me.GroupBox5_update.Controls.Add(Me.Label71)
        Me.GroupBox5_update.Controls.Add(Me.номер_родословной_обнв)
        Me.GroupBox5_update.Controls.Add(Me.Label72)
        Me.GroupBox5_update.Controls.Add(Me.id_животного_обнв)
        Me.GroupBox5_update.Controls.Add(Me.Label73)
        Me.GroupBox5_update.Controls.Add(Me.Label74)
        Me.GroupBox5_update.Location = New System.Drawing.Point(7, 391)
        Me.GroupBox5_update.Name = "GroupBox5_update"
        Me.GroupBox5_update.Size = New System.Drawing.Size(1208, 96)
        Me.GroupBox5_update.TabIndex = 37
        Me.GroupBox5_update.TabStop = False
        Me.GroupBox5_update.Text = "Изменить"
        '
        'Label96
        '
        Me.Label96.AutoSize = True
        Me.Label96.Location = New System.Drawing.Point(1129, 19)
        Me.Label96.Name = "Label96"
        Me.Label96.Size = New System.Drawing.Size(73, 15)
        Me.Label96.TabIndex = 45
        Me.Label96.Text = "Номер чипа"
        '
        'номер_чипа_обнв
        '
        Me.номер_чипа_обнв.Location = New System.Drawing.Point(1141, 36)
        Me.номер_чипа_обнв.Name = "номер_чипа_обнв"
        Me.номер_чипа_обнв.Size = New System.Drawing.Size(65, 22)
        Me.номер_чипа_обнв.TabIndex = 44
        '
        'id_владельца_животного_обнв
        '
        Me.id_владельца_животного_обнв.DataSource = Me.ВладельцыBindingSource
        Me.id_владельца_животного_обнв.DisplayMember = "ФИО"
        Me.id_владельца_животного_обнв.FormattingEnabled = True
        Me.id_владельца_животного_обнв.Location = New System.Drawing.Point(55, 37)
        Me.id_владельца_животного_обнв.Name = "id_владельца_животного_обнв"
        Me.id_владельца_животного_обнв.Size = New System.Drawing.Size(121, 23)
        Me.id_владельца_животного_обнв.TabIndex = 43
        Me.id_владельца_животного_обнв.ValueMember = "ID_Владельца"
        '
        'ВладельцыBindingSource
        '
        Me.ВладельцыBindingSource.DataMember = "Владельцы"
        Me.ВладельцыBindingSource.DataSource = Me.AnimalBDDataSet
        '
        'id_породы_животного_обнв
        '
        Me.id_породы_животного_обнв.DataSource = Me.ПородыBindingSource
        Me.id_породы_животного_обнв.DisplayMember = "Название"
        Me.id_породы_животного_обнв.FormattingEnabled = True
        Me.id_породы_животного_обнв.Location = New System.Drawing.Point(342, 36)
        Me.id_породы_животного_обнв.Name = "id_породы_животного_обнв"
        Me.id_породы_животного_обнв.Size = New System.Drawing.Size(121, 23)
        Me.id_породы_животного_обнв.TabIndex = 43
        Me.id_породы_животного_обнв.ValueMember = "ID_Породы"
        '
        'место_размещения_обнв
        '
        Me.место_размещения_обнв.DataSource = Me.МесторазмещенияэлектронногочипаBindingSource
        Me.место_размещения_обнв.DisplayMember = "Где"
        Me.место_размещения_обнв.FormattingEnabled = True
        Me.место_размещения_обнв.Location = New System.Drawing.Point(1014, 36)
        Me.место_размещения_обнв.Name = "место_размещения_обнв"
        Me.место_размещения_обнв.Size = New System.Drawing.Size(121, 23)
        Me.место_размещения_обнв.TabIndex = 43
        Me.место_размещения_обнв.ValueMember = "ID_Место"
        '
        'Изменить_паспорт
        '
        Me.Изменить_паспорт.BackColor = System.Drawing.SystemColors.Window
        Me.Изменить_паспорт.Location = New System.Drawing.Point(551, 67)
        Me.Изменить_паспорт.Name = "Изменить_паспорт"
        Me.Изменить_паспорт.Size = New System.Drawing.Size(83, 23)
        Me.Изменить_паспорт.TabIndex = 3
        Me.Изменить_паспорт.Text = "Изменить"
        Me.Изменить_паспорт.UseVisualStyleBackColor = False
        '
        'Label49
        '
        Me.Label49.AutoSize = True
        Me.Label49.Location = New System.Drawing.Point(926, 4)
        Me.Label49.Name = "Label49"
        Me.Label49.Size = New System.Drawing.Size(83, 30)
        Me.Label49.TabIndex = 35
        Me.Label49.Text = "Дата" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "имплантации"
        '
        'имя_мамы_обнв
        '
        Me.имя_мамы_обнв.Location = New System.Drawing.Point(780, 37)
        Me.имя_мамы_обнв.Name = "имя_мамы_обнв"
        Me.имя_мамы_обнв.Size = New System.Drawing.Size(69, 22)
        Me.имя_мамы_обнв.TabIndex = 34
        '
        'окрас_животного_обнв
        '
        Me.окрас_животного_обнв.Location = New System.Drawing.Point(628, 37)
        Me.окрас_животного_обнв.Name = "окрас_животного_обнв"
        Me.окрас_животного_обнв.Size = New System.Drawing.Size(107, 22)
        Me.окрас_животного_обнв.TabIndex = 33
        '
        'Label50
        '
        Me.Label50.AutoSize = True
        Me.Label50.Location = New System.Drawing.Point(625, 19)
        Me.Label50.Name = "Label50"
        Me.Label50.Size = New System.Drawing.Size(42, 15)
        Me.Label50.TabIndex = 32
        Me.Label50.Text = "Окрас"
        '
        'Label51
        '
        Me.Label51.AutoSize = True
        Me.Label51.Location = New System.Drawing.Point(557, 19)
        Me.Label51.Name = "Label51"
        Me.Label51.Size = New System.Drawing.Size(46, 15)
        Me.Label51.TabIndex = 30
        Me.Label51.Text = "Группа"
        '
        'группа_животного_обнв
        '
        Me.группа_животного_обнв.Location = New System.Drawing.Point(557, 37)
        Me.группа_животного_обнв.Name = "группа_животного_обнв"
        Me.группа_животного_обнв.Size = New System.Drawing.Size(65, 22)
        Me.группа_животного_обнв.TabIndex = 31
        '
        'Label52
        '
        Me.Label52.AutoSize = True
        Me.Label52.Location = New System.Drawing.Point(466, 17)
        Me.Label52.Name = "Label52"
        Me.Label52.Size = New System.Drawing.Size(93, 15)
        Me.Label52.TabIndex = 30
        Me.Label52.Text = "Дата рождения"
        '
        'Label53
        '
        Me.Label53.AutoSize = True
        Me.Label53.Location = New System.Drawing.Point(342, 17)
        Me.Label53.Name = "Label53"
        Me.Label53.Size = New System.Drawing.Size(47, 15)
        Me.Label53.TabIndex = 17
        Me.Label53.Text = "Порода"
        '
        'Label54
        '
        Me.Label54.AutoSize = True
        Me.Label54.Location = New System.Drawing.Point(159, 18)
        Me.Label54.Name = "Label54"
        Me.Label54.Size = New System.Drawing.Size(117, 15)
        Me.Label54.TabIndex = 16
        Me.Label54.Text = "Номер родословной"
        '
        'Label55
        '
        Me.Label55.AutoSize = True
        Me.Label55.Location = New System.Drawing.Point(1011, 19)
        Me.Label55.Name = "Label55"
        Me.Label55.Size = New System.Drawing.Size(117, 15)
        Me.Label55.TabIndex = 15
        Me.Label55.Text = "Место размещения "
        '
        'пол_животного_обнв
        '
        Me.пол_животного_обнв.Location = New System.Drawing.Point(741, 37)
        Me.пол_животного_обнв.MaxLength = 1
        Me.пол_животного_обнв.Name = "пол_животного_обнв"
        Me.пол_животного_обнв.Size = New System.Drawing.Size(33, 22)
        Me.пол_животного_обнв.TabIndex = 14
        '
        'Label69
        '
        Me.Label69.AutoSize = True
        Me.Label69.Location = New System.Drawing.Point(855, 19)
        Me.Label69.Name = "Label69"
        Me.Label69.Size = New System.Drawing.Size(65, 15)
        Me.Label69.TabIndex = 13
        Me.Label69.Text = "Имя папы"
        '
        'имя_папы_обнв
        '
        Me.имя_папы_обнв.Location = New System.Drawing.Point(855, 37)
        Me.имя_папы_обнв.Name = "имя_папы_обнв"
        Me.имя_папы_обнв.Size = New System.Drawing.Size(65, 22)
        Me.имя_папы_обнв.TabIndex = 12
        '
        'Label70
        '
        Me.Label70.AutoSize = True
        Me.Label70.Location = New System.Drawing.Point(745, 17)
        Me.Label70.Name = "Label70"
        Me.Label70.Size = New System.Drawing.Size(29, 15)
        Me.Label70.TabIndex = 11
        Me.Label70.Text = "Пол"
        '
        'имя_животного_обнв
        '
        Me.имя_животного_обнв.Location = New System.Drawing.Point(258, 37)
        Me.имя_животного_обнв.Name = "имя_животного_обнв"
        Me.имя_животного_обнв.Size = New System.Drawing.Size(80, 22)
        Me.имя_животного_обнв.TabIndex = 10
        '
        'Label71
        '
        Me.Label71.AutoSize = True
        Me.Label71.Location = New System.Drawing.Point(777, 18)
        Me.Label71.Name = "Label71"
        Me.Label71.Size = New System.Drawing.Size(69, 15)
        Me.Label71.TabIndex = 9
        Me.Label71.Text = "Имя мамы"
        '
        'номер_родословной_обнв
        '
        Me.номер_родословной_обнв.Location = New System.Drawing.Point(182, 37)
        Me.номер_родословной_обнв.Name = "номер_родословной_обнв"
        Me.номер_родословной_обнв.Size = New System.Drawing.Size(70, 22)
        Me.номер_родословной_обнв.TabIndex = 8
        '
        'Label72
        '
        Me.Label72.AutoSize = True
        Me.Label72.Location = New System.Drawing.Point(286, 18)
        Me.Label72.Name = "Label72"
        Me.Label72.Size = New System.Drawing.Size(50, 15)
        Me.Label72.TabIndex = 6
        Me.Label72.Text = "Кличка"
        '
        'id_животного_обнв
        '
        Me.id_животного_обнв.Location = New System.Drawing.Point(6, 38)
        Me.id_животного_обнв.Name = "id_животного_обнв"
        Me.id_животного_обнв.Size = New System.Drawing.Size(33, 22)
        Me.id_животного_обнв.TabIndex = 2
        '
        'Label73
        '
        Me.Label73.AutoSize = True
        Me.Label73.Location = New System.Drawing.Point(98, 18)
        Me.Label73.Name = "Label73"
        Me.Label73.Size = New System.Drawing.Size(62, 15)
        Me.Label73.TabIndex = 1
        Me.Label73.Text = "Владелец"
        '
        'Label74
        '
        Me.Label74.AutoSize = True
        Me.Label74.Location = New System.Drawing.Point(3, 19)
        Me.Label74.Name = "Label74"
        Me.Label74.Size = New System.Drawing.Size(90, 15)
        Me.Label74.TabIndex = 0
        Me.Label74.Text = "ID_Животного"
        '
        'GroupBox5_del
        '
        Me.GroupBox5_del.Controls.Add(Me.кличка_животного_дел)
        Me.GroupBox5_del.Controls.Add(Me.Label48)
        Me.GroupBox5_del.Controls.Add(Me.Удалить_паспорт)
        Me.GroupBox5_del.Location = New System.Drawing.Point(6, 493)
        Me.GroupBox5_del.Name = "GroupBox5_del"
        Me.GroupBox5_del.Size = New System.Drawing.Size(316, 66)
        Me.GroupBox5_del.TabIndex = 23
        Me.GroupBox5_del.TabStop = False
        Me.GroupBox5_del.Text = "Удалить"
        '
        'кличка_животного_дел
        '
        Me.кличка_животного_дел.Location = New System.Drawing.Point(10, 38)
        Me.кличка_животного_дел.Name = "кличка_животного_дел"
        Me.кличка_животного_дел.Size = New System.Drawing.Size(184, 22)
        Me.кличка_животного_дел.TabIndex = 38
        '
        'Label48
        '
        Me.Label48.AutoSize = True
        Me.Label48.Location = New System.Drawing.Point(7, 20)
        Me.Label48.Name = "Label48"
        Me.Label48.Size = New System.Drawing.Size(50, 15)
        Me.Label48.TabIndex = 7
        Me.Label48.Text = "Кличка"
        '
        'Удалить_паспорт
        '
        Me.Удалить_паспорт.BackColor = System.Drawing.SystemColors.Window
        Me.Удалить_паспорт.Location = New System.Drawing.Point(235, 37)
        Me.Удалить_паспорт.Name = "Удалить_паспорт"
        Me.Удалить_паспорт.Size = New System.Drawing.Size(75, 23)
        Me.Удалить_паспорт.TabIndex = 2
        Me.Удалить_паспорт.Text = "Удалить"
        Me.Удалить_паспорт.UseVisualStyleBackColor = False
        '
        'GroupBox5_add
        '
        Me.GroupBox5_add.Controls.Add(Me.d4)
        Me.GroupBox5_add.Controls.Add(Me.d3)
        Me.GroupBox5_add.Controls.Add(Me.Label95)
        Me.GroupBox5_add.Controls.Add(Me.номер_чипа_доб)
        Me.GroupBox5_add.Controls.Add(Me.место_размещения_доб)
        Me.GroupBox5_add.Controls.Add(Me.кличка_животного_доб)
        Me.GroupBox5_add.Controls.Add(Me.id_породы_животного_доб)
        Me.GroupBox5_add.Controls.Add(Me.id_владельца_животного_доб)
        Me.GroupBox5_add.Controls.Add(Me.Label68)
        Me.GroupBox5_add.Controls.Add(Me.имя_мамы_доб)
        Me.GroupBox5_add.Controls.Add(Me.окрас_животного_доб)
        Me.GroupBox5_add.Controls.Add(Me.Label67)
        Me.GroupBox5_add.Controls.Add(Me.Label66)
        Me.GroupBox5_add.Controls.Add(Me.группа_животного_доб)
        Me.GroupBox5_add.Controls.Add(Me.Label65)
        Me.GroupBox5_add.Controls.Add(Me.Label64)
        Me.GroupBox5_add.Controls.Add(Me.Label63)
        Me.GroupBox5_add.Controls.Add(Me.Label56)
        Me.GroupBox5_add.Controls.Add(Me.пол_животного_доб)
        Me.GroupBox5_add.Controls.Add(Me.Label57)
        Me.GroupBox5_add.Controls.Add(Me.имя_папы_доб)
        Me.GroupBox5_add.Controls.Add(Me.Label58)
        Me.GroupBox5_add.Controls.Add(Me.Label59)
        Me.GroupBox5_add.Controls.Add(Me.номер_родословной_доб)
        Me.GroupBox5_add.Controls.Add(Me.Label60)
        Me.GroupBox5_add.Controls.Add(Me.Добавить_паспорт)
        Me.GroupBox5_add.Controls.Add(Me.id_животного_доб)
        Me.GroupBox5_add.Controls.Add(Me.Label61)
        Me.GroupBox5_add.Controls.Add(Me.Label62)
        Me.GroupBox5_add.Location = New System.Drawing.Point(3, 294)
        Me.GroupBox5_add.Name = "GroupBox5_add"
        Me.GroupBox5_add.Size = New System.Drawing.Size(1208, 91)
        Me.GroupBox5_add.TabIndex = 22
        Me.GroupBox5_add.TabStop = False
        Me.GroupBox5_add.Text = "Добавить"
        '
        'Label95
        '
        Me.Label95.AutoSize = True
        Me.Label95.Location = New System.Drawing.Point(1129, 15)
        Me.Label95.Name = "Label95"
        Me.Label95.Size = New System.Drawing.Size(73, 15)
        Me.Label95.TabIndex = 44
        Me.Label95.Text = "Номер чипа"
        '
        'номер_чипа_доб
        '
        Me.номер_чипа_доб.Location = New System.Drawing.Point(1143, 33)
        Me.номер_чипа_доб.Name = "номер_чипа_доб"
        Me.номер_чипа_доб.Size = New System.Drawing.Size(65, 22)
        Me.номер_чипа_доб.TabIndex = 43
        '
        'место_размещения_доб
        '
        Me.место_размещения_доб.DataSource = Me.МесторазмещенияэлектронногочипаBindingSource
        Me.место_размещения_доб.DisplayMember = "Где"
        Me.место_размещения_доб.FormattingEnabled = True
        Me.место_размещения_доб.Location = New System.Drawing.Point(1018, 33)
        Me.место_размещения_доб.Name = "место_размещения_доб"
        Me.место_размещения_доб.Size = New System.Drawing.Size(121, 23)
        Me.место_размещения_доб.TabIndex = 42
        Me.место_размещения_доб.ValueMember = "ID_Место"
        '
        'кличка_животного_доб
        '
        Me.кличка_животного_доб.Location = New System.Drawing.Point(259, 36)
        Me.кличка_животного_доб.Name = "кличка_животного_доб"
        Me.кличка_животного_доб.Size = New System.Drawing.Size(80, 22)
        Me.кличка_животного_доб.TabIndex = 37
        '
        'id_породы_животного_доб
        '
        Me.id_породы_животного_доб.DataSource = Me.ПородыBindingSource
        Me.id_породы_животного_доб.DisplayMember = "Название"
        Me.id_породы_животного_доб.FormattingEnabled = True
        Me.id_породы_животного_доб.Location = New System.Drawing.Point(346, 35)
        Me.id_породы_животного_доб.Name = "id_породы_животного_доб"
        Me.id_породы_животного_доб.Size = New System.Drawing.Size(121, 23)
        Me.id_породы_животного_доб.TabIndex = 41
        Me.id_породы_животного_доб.ValueMember = "ID_Породы"
        '
        'id_владельца_животного_доб
        '
        Me.id_владельца_животного_доб.DataSource = Me.ВладельцыBindingSource
        Me.id_владельца_животного_доб.DisplayMember = "ФИО"
        Me.id_владельца_животного_доб.FormattingEnabled = True
        Me.id_владельца_животного_доб.Location = New System.Drawing.Point(59, 34)
        Me.id_владельца_животного_доб.Name = "id_владельца_животного_доб"
        Me.id_владельца_животного_доб.Size = New System.Drawing.Size(121, 23)
        Me.id_владельца_животного_доб.TabIndex = 38
        Me.id_владельца_животного_доб.ValueMember = "ID_Владельца"
        '
        'Label68
        '
        Me.Label68.AutoSize = True
        Me.Label68.Location = New System.Drawing.Point(929, 5)
        Me.Label68.Name = "Label68"
        Me.Label68.Size = New System.Drawing.Size(83, 30)
        Me.Label68.TabIndex = 35
        Me.Label68.Text = "Дата" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "имплантации"
        '
        'имя_мамы_доб
        '
        Me.имя_мамы_доб.Location = New System.Drawing.Point(784, 35)
        Me.имя_мамы_доб.Name = "имя_мамы_доб"
        Me.имя_мамы_доб.Size = New System.Drawing.Size(69, 22)
        Me.имя_мамы_доб.TabIndex = 34
        '
        'окрас_животного_доб
        '
        Me.окрас_животного_доб.Location = New System.Drawing.Point(632, 36)
        Me.окрас_животного_доб.Name = "окрас_животного_доб"
        Me.окрас_животного_доб.Size = New System.Drawing.Size(107, 22)
        Me.окрас_животного_доб.TabIndex = 33
        '
        'Label67
        '
        Me.Label67.AutoSize = True
        Me.Label67.Location = New System.Drawing.Point(629, 18)
        Me.Label67.Name = "Label67"
        Me.Label67.Size = New System.Drawing.Size(42, 15)
        Me.Label67.TabIndex = 32
        Me.Label67.Text = "Окрас"
        '
        'Label66
        '
        Me.Label66.AutoSize = True
        Me.Label66.Location = New System.Drawing.Point(561, 20)
        Me.Label66.Name = "Label66"
        Me.Label66.Size = New System.Drawing.Size(46, 15)
        Me.Label66.TabIndex = 30
        Me.Label66.Text = "Группа"
        '
        'группа_животного_доб
        '
        Me.группа_животного_доб.Location = New System.Drawing.Point(561, 36)
        Me.группа_животного_доб.Name = "группа_животного_доб"
        Me.группа_животного_доб.Size = New System.Drawing.Size(65, 22)
        Me.группа_животного_доб.TabIndex = 31
        '
        'Label65
        '
        Me.Label65.AutoSize = True
        Me.Label65.Location = New System.Drawing.Point(462, 17)
        Me.Label65.Name = "Label65"
        Me.Label65.Size = New System.Drawing.Size(93, 15)
        Me.Label65.TabIndex = 30
        Me.Label65.Text = "Дата рождения"
        '
        'Label64
        '
        Me.Label64.AutoSize = True
        Me.Label64.Location = New System.Drawing.Point(343, 17)
        Me.Label64.Name = "Label64"
        Me.Label64.Size = New System.Drawing.Size(47, 15)
        Me.Label64.TabIndex = 17
        Me.Label64.Text = "Порода"
        '
        'Label63
        '
        Me.Label63.AutoSize = True
        Me.Label63.Location = New System.Drawing.Point(178, 5)
        Me.Label63.Name = "Label63"
        Me.Label63.Size = New System.Drawing.Size(78, 30)
        Me.Label63.TabIndex = 16
        Me.Label63.Text = "Номер" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "родословной"
        '
        'Label56
        '
        Me.Label56.AutoSize = True
        Me.Label56.Location = New System.Drawing.Point(1015, 17)
        Me.Label56.Name = "Label56"
        Me.Label56.Size = New System.Drawing.Size(117, 15)
        Me.Label56.TabIndex = 15
        Me.Label56.Text = "Место размещения "
        '
        'пол_животного_доб
        '
        Me.пол_животного_доб.Location = New System.Drawing.Point(745, 35)
        Me.пол_животного_доб.MaxLength = 1
        Me.пол_животного_доб.Name = "пол_животного_доб"
        Me.пол_животного_доб.Size = New System.Drawing.Size(33, 22)
        Me.пол_животного_доб.TabIndex = 14
        '
        'Label57
        '
        Me.Label57.AutoSize = True
        Me.Label57.Location = New System.Drawing.Point(859, 18)
        Me.Label57.Name = "Label57"
        Me.Label57.Size = New System.Drawing.Size(65, 15)
        Me.Label57.TabIndex = 13
        Me.Label57.Text = "Имя папы"
        '
        'имя_папы_доб
        '
        Me.имя_папы_доб.Location = New System.Drawing.Point(859, 35)
        Me.имя_папы_доб.Name = "имя_папы_доб"
        Me.имя_папы_доб.Size = New System.Drawing.Size(65, 22)
        Me.имя_папы_доб.TabIndex = 12
        '
        'Label58
        '
        Me.Label58.AutoSize = True
        Me.Label58.Location = New System.Drawing.Point(742, 18)
        Me.Label58.Name = "Label58"
        Me.Label58.Size = New System.Drawing.Size(29, 15)
        Me.Label58.TabIndex = 11
        Me.Label58.Text = "Пол"
        '
        'Label59
        '
        Me.Label59.AutoSize = True
        Me.Label59.Location = New System.Drawing.Point(784, 17)
        Me.Label59.Name = "Label59"
        Me.Label59.Size = New System.Drawing.Size(69, 15)
        Me.Label59.TabIndex = 9
        Me.Label59.Text = "Имя мамы"
        '
        'номер_родословной_доб
        '
        Me.номер_родословной_доб.Location = New System.Drawing.Point(186, 36)
        Me.номер_родословной_доб.Name = "номер_родословной_доб"
        Me.номер_родословной_доб.Size = New System.Drawing.Size(70, 22)
        Me.номер_родословной_доб.TabIndex = 8
        '
        'Label60
        '
        Me.Label60.AutoSize = True
        Me.Label60.Location = New System.Drawing.Point(272, 18)
        Me.Label60.Name = "Label60"
        Me.Label60.Size = New System.Drawing.Size(50, 15)
        Me.Label60.TabIndex = 6
        Me.Label60.Text = "Кличка"
        '
        'Добавить_паспорт
        '
        Me.Добавить_паспорт.BackColor = System.Drawing.SystemColors.Window
        Me.Добавить_паспорт.Location = New System.Drawing.Point(555, 62)
        Me.Добавить_паспорт.Name = "Добавить_паспорт"
        Me.Добавить_паспорт.Size = New System.Drawing.Size(83, 23)
        Me.Добавить_паспорт.TabIndex = 4
        Me.Добавить_паспорт.Text = "Добавить"
        Me.Добавить_паспорт.UseVisualStyleBackColor = False
        '
        'id_животного_доб
        '
        Me.id_животного_доб.Location = New System.Drawing.Point(9, 34)
        Me.id_животного_доб.Name = "id_животного_доб"
        Me.id_животного_доб.Size = New System.Drawing.Size(33, 22)
        Me.id_животного_доб.TabIndex = 2
        '
        'Label61
        '
        Me.Label61.AutoSize = True
        Me.Label61.Location = New System.Drawing.Point(101, 17)
        Me.Label61.Name = "Label61"
        Me.Label61.Size = New System.Drawing.Size(62, 15)
        Me.Label61.TabIndex = 1
        Me.Label61.Text = "Владелец"
        '
        'Label62
        '
        Me.Label62.AutoSize = True
        Me.Label62.Location = New System.Drawing.Point(6, 18)
        Me.Label62.Name = "Label62"
        Me.Label62.Size = New System.Drawing.Size(90, 15)
        Me.Label62.TabIndex = 0
        Me.Label62.Text = "ID_Животного"
        '
        'Poluch_Nagrad
        '
        Me.Poluch_Nagrad.Controls.Add(Me.DGV_получ_награды_актул)
        Me.Poluch_Nagrad.Controls.Add(Me.GroupBox6_update)
        Me.Poluch_Nagrad.Controls.Add(Me.GroupBox6_del)
        Me.Poluch_Nagrad.Controls.Add(Me.GroupBox6_add)
        Me.Poluch_Nagrad.Location = New System.Drawing.Point(4, 24)
        Me.Poluch_Nagrad.Name = "Poluch_Nagrad"
        Me.Poluch_Nagrad.Padding = New System.Windows.Forms.Padding(3)
        Me.Poluch_Nagrad.Size = New System.Drawing.Size(1221, 565)
        Me.Poluch_Nagrad.TabIndex = 8
        Me.Poluch_Nagrad.Text = "Получение награды"
        Me.Poluch_Nagrad.UseVisualStyleBackColor = True
        '
        'DGV_получ_награды_актул
        '
        Me.DGV_получ_награды_актул.AllowUserToAddRows = False
        Me.DGV_получ_награды_актул.AllowUserToDeleteRows = False
        Me.DGV_получ_награды_актул.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DGV_получ_награды_актул.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_получ_награды_актул.Location = New System.Drawing.Point(7, 7)
        Me.DGV_получ_награды_актул.Name = "DGV_получ_награды_актул"
        Me.DGV_получ_награды_актул.ReadOnly = True
        Me.DGV_получ_награды_актул.Size = New System.Drawing.Size(1208, 281)
        Me.DGV_получ_награды_актул.TabIndex = 25
        '
        'GroupBox6_update
        '
        Me.GroupBox6_update.Controls.Add(Me.d10)
        Me.GroupBox6_update.Controls.Add(Me.d9)
        Me.GroupBox6_update.Controls.Add(Me.получ_награды_обнв)
        Me.GroupBox6_update.Controls.Add(Me.Label76)
        Me.GroupBox6_update.Controls.Add(Me.ID_клички_обнв)
        Me.GroupBox6_update.Controls.Add(Me.Изменить_получ_награды)
        Me.GroupBox6_update.Controls.Add(Me.id_получ_награды_обнв)
        Me.GroupBox6_update.Controls.Add(Me.Label77)
        Me.GroupBox6_update.Controls.Add(Me.Label80)
        Me.GroupBox6_update.Controls.Add(Me.Label78)
        Me.GroupBox6_update.Controls.Add(Me.Label79)
        Me.GroupBox6_update.Location = New System.Drawing.Point(6, 396)
        Me.GroupBox6_update.Name = "GroupBox6_update"
        Me.GroupBox6_update.Size = New System.Drawing.Size(781, 100)
        Me.GroupBox6_update.TabIndex = 24
        Me.GroupBox6_update.TabStop = False
        Me.GroupBox6_update.Text = "Изменить"
        '
        'получ_награды_обнв
        '
        Me.получ_награды_обнв.DataSource = Me.НаградыBindingSource
        Me.получ_награды_обнв.DisplayMember = "Наименование"
        Me.получ_награды_обнв.FormattingEnabled = True
        Me.получ_награды_обнв.Location = New System.Drawing.Point(250, 48)
        Me.получ_награды_обнв.Name = "получ_награды_обнв"
        Me.получ_награды_обнв.Size = New System.Drawing.Size(244, 23)
        Me.получ_награды_обнв.TabIndex = 27
        Me.получ_награды_обнв.ValueMember = "ID_Награды"
        '
        'Label76
        '
        Me.Label76.AutoSize = True
        Me.Label76.Location = New System.Drawing.Point(631, 26)
        Me.Label76.Name = "Label76"
        Me.Label76.Size = New System.Drawing.Size(149, 15)
        Me.Label76.TabIndex = 23
        Me.Label76.Text = "Прошлая дата получения"
        '
        'ID_клички_обнв
        '
        Me.ID_клички_обнв.DataSource = Me.ПаспортживотногоBindingSource
        Me.ID_клички_обнв.DisplayMember = "Кличка"
        Me.ID_клички_обнв.FormattingEnabled = True
        Me.ID_клички_обнв.Location = New System.Drawing.Point(112, 49)
        Me.ID_клички_обнв.Name = "ID_клички_обнв"
        Me.ID_клички_обнв.Size = New System.Drawing.Size(121, 23)
        Me.ID_клички_обнв.TabIndex = 26
        Me.ID_клички_обнв.ValueMember = "ID_Животного"
        '
        'ПаспортживотногоBindingSource
        '
        Me.ПаспортживотногоBindingSource.DataMember = "Паспорт_животного"
        Me.ПаспортживотногоBindingSource.DataSource = Me.AnimalBDDataSet
        '
        'Изменить_получ_награды
        '
        Me.Изменить_получ_награды.BackColor = System.Drawing.SystemColors.Window
        Me.Изменить_получ_награды.Location = New System.Drawing.Point(700, 71)
        Me.Изменить_получ_награды.Name = "Изменить_получ_награды"
        Me.Изменить_получ_награды.Size = New System.Drawing.Size(75, 23)
        Me.Изменить_получ_награды.TabIndex = 3
        Me.Изменить_получ_награды.Text = "Изменить"
        Me.Изменить_получ_награды.UseVisualStyleBackColor = False
        '
        'id_получ_награды_обнв
        '
        Me.id_получ_награды_обнв.Location = New System.Drawing.Point(17, 46)
        Me.id_получ_награды_обнв.Name = "id_получ_награды_обнв"
        Me.id_получ_награды_обнв.Size = New System.Drawing.Size(33, 22)
        Me.id_получ_награды_обнв.TabIndex = 16
        '
        'Label77
        '
        Me.Label77.AutoSize = True
        Me.Label77.Location = New System.Drawing.Point(497, 26)
        Me.Label77.Name = "Label77"
        Me.Label77.Size = New System.Drawing.Size(97, 15)
        Me.Label77.TabIndex = 21
        Me.Label77.Text = "Дата получения"
        '
        'Label80
        '
        Me.Label80.AutoSize = True
        Me.Label80.Location = New System.Drawing.Point(14, 27)
        Me.Label80.Name = "Label80"
        Me.Label80.Size = New System.Drawing.Size(89, 15)
        Me.Label80.TabIndex = 14
        Me.Label80.Text = "ID_Получения"
        '
        'Label78
        '
        Me.Label78.AutoSize = True
        Me.Label78.Location = New System.Drawing.Point(247, 27)
        Me.Label78.Name = "Label78"
        Me.Label78.Size = New System.Drawing.Size(141, 15)
        Me.Label78.TabIndex = 20
        Me.Label78.Text = "Наименование награды"
        '
        'Label79
        '
        Me.Label79.AutoSize = True
        Me.Label79.Location = New System.Drawing.Point(109, 26)
        Me.Label79.Name = "Label79"
        Me.Label79.Size = New System.Drawing.Size(114, 15)
        Me.Label79.TabIndex = 15
        Me.Label79.Text = "Кличка животного"
        '
        'GroupBox6_del
        '
        Me.GroupBox6_del.Controls.Add(Me.id_получ_награды_уд)
        Me.GroupBox6_del.Controls.Add(Me.Label81)
        Me.GroupBox6_del.Controls.Add(Me.Удалить_получ_награды)
        Me.GroupBox6_del.Location = New System.Drawing.Point(793, 294)
        Me.GroupBox6_del.Name = "GroupBox6_del"
        Me.GroupBox6_del.Size = New System.Drawing.Size(200, 100)
        Me.GroupBox6_del.TabIndex = 23
        Me.GroupBox6_del.TabStop = False
        Me.GroupBox6_del.Text = "Удалить"
        '
        'id_получ_награды_уд
        '
        Me.id_получ_награды_уд.Location = New System.Drawing.Point(24, 39)
        Me.id_получ_награды_уд.Name = "id_получ_награды_уд"
        Me.id_получ_награды_уд.Size = New System.Drawing.Size(87, 22)
        Me.id_получ_награды_уд.TabIndex = 15
        '
        'Label81
        '
        Me.Label81.AutoSize = True
        Me.Label81.Location = New System.Drawing.Point(21, 20)
        Me.Label81.Name = "Label81"
        Me.Label81.Size = New System.Drawing.Size(89, 15)
        Me.Label81.TabIndex = 14
        Me.Label81.Text = "ID_Получения"
        '
        'Удалить_получ_награды
        '
        Me.Удалить_получ_награды.BackColor = System.Drawing.SystemColors.Window
        Me.Удалить_получ_награды.Location = New System.Drawing.Point(119, 71)
        Me.Удалить_получ_награды.Name = "Удалить_получ_награды"
        Me.Удалить_получ_награды.Size = New System.Drawing.Size(75, 23)
        Me.Удалить_получ_награды.TabIndex = 2
        Me.Удалить_получ_награды.Text = "Удалить"
        Me.Удалить_получ_награды.UseVisualStyleBackColor = False
        '
        'GroupBox6_add
        '
        Me.GroupBox6_add.Controls.Add(Me.d8)
        Me.GroupBox6_add.Controls.Add(Me.d7)
        Me.GroupBox6_add.Controls.Add(Me.получ_награды_доб)
        Me.GroupBox6_add.Controls.Add(Me.ID_клички_доб)
        Me.GroupBox6_add.Controls.Add(Me.Label75)
        Me.GroupBox6_add.Controls.Add(Me.Label85)
        Me.GroupBox6_add.Controls.Add(Me.Label86)
        Me.GroupBox6_add.Controls.Add(Me.Добавить_получ_награды)
        Me.GroupBox6_add.Controls.Add(Me.id_получ_награды_доб)
        Me.GroupBox6_add.Controls.Add(Me.Label88)
        Me.GroupBox6_add.Controls.Add(Me.Label89)
        Me.GroupBox6_add.Location = New System.Drawing.Point(6, 294)
        Me.GroupBox6_add.Name = "GroupBox6_add"
        Me.GroupBox6_add.Size = New System.Drawing.Size(781, 100)
        Me.GroupBox6_add.TabIndex = 22
        Me.GroupBox6_add.TabStop = False
        Me.GroupBox6_add.Text = "Добавить"
        '
        'получ_награды_доб
        '
        Me.получ_награды_доб.DataSource = Me.НаградыBindingSource
        Me.получ_награды_доб.DisplayMember = "Наименование"
        Me.получ_награды_доб.FormattingEnabled = True
        Me.получ_награды_доб.Location = New System.Drawing.Point(232, 37)
        Me.получ_награды_доб.Name = "получ_награды_доб"
        Me.получ_награды_доб.Size = New System.Drawing.Size(262, 23)
        Me.получ_награды_доб.TabIndex = 25
        Me.получ_награды_доб.ValueMember = "ID_Награды"
        '
        'ID_клички_доб
        '
        Me.ID_клички_доб.DataSource = Me.ПаспортживотногоBindingSource
        Me.ID_клички_доб.DisplayMember = "Кличка"
        Me.ID_клички_доб.FormattingEnabled = True
        Me.ID_клички_доб.Location = New System.Drawing.Point(94, 38)
        Me.ID_клички_доб.Name = "ID_клички_доб"
        Me.ID_клички_доб.Size = New System.Drawing.Size(121, 23)
        Me.ID_клички_доб.TabIndex = 14
        Me.ID_клички_доб.ValueMember = "ID_Животного"
        '
        'Label75
        '
        Me.Label75.AutoSize = True
        Me.Label75.Location = New System.Drawing.Point(631, 20)
        Me.Label75.Name = "Label75"
        Me.Label75.Size = New System.Drawing.Size(149, 15)
        Me.Label75.TabIndex = 13
        Me.Label75.Text = "Прошлая дата получения"
        '
        'Label85
        '
        Me.Label85.AutoSize = True
        Me.Label85.Location = New System.Drawing.Point(497, 20)
        Me.Label85.Name = "Label85"
        Me.Label85.Size = New System.Drawing.Size(97, 15)
        Me.Label85.TabIndex = 11
        Me.Label85.Text = "Дата получения"
        '
        'Label86
        '
        Me.Label86.AutoSize = True
        Me.Label86.Location = New System.Drawing.Point(229, 20)
        Me.Label86.Name = "Label86"
        Me.Label86.Size = New System.Drawing.Size(141, 15)
        Me.Label86.TabIndex = 9
        Me.Label86.Text = "Наименование награды"
        '
        'Добавить_получ_награды
        '
        Me.Добавить_получ_награды.BackColor = System.Drawing.SystemColors.Window
        Me.Добавить_получ_награды.Location = New System.Drawing.Point(697, 71)
        Me.Добавить_получ_награды.Name = "Добавить_получ_награды"
        Me.Добавить_получ_награды.Size = New System.Drawing.Size(75, 23)
        Me.Добавить_получ_награды.TabIndex = 4
        Me.Добавить_получ_награды.Text = "Добавить"
        Me.Добавить_получ_награды.UseVisualStyleBackColor = False
        '
        'id_получ_награды_доб
        '
        Me.id_получ_награды_доб.Location = New System.Drawing.Point(6, 38)
        Me.id_получ_награды_доб.Name = "id_получ_награды_доб"
        Me.id_получ_награды_доб.Size = New System.Drawing.Size(33, 22)
        Me.id_получ_награды_доб.TabIndex = 2
        '
        'Label88
        '
        Me.Label88.AutoSize = True
        Me.Label88.Location = New System.Drawing.Point(98, 18)
        Me.Label88.Name = "Label88"
        Me.Label88.Size = New System.Drawing.Size(114, 15)
        Me.Label88.TabIndex = 1
        Me.Label88.Text = "Кличка животного"
        '
        'Label89
        '
        Me.Label89.AutoSize = True
        Me.Label89.Location = New System.Drawing.Point(3, 19)
        Me.Label89.Name = "Label89"
        Me.Label89.Size = New System.Drawing.Size(89, 15)
        Me.Label89.TabIndex = 0
        Me.Label89.Text = "ID_Получения"
        '
        'Vet_Svidetel
        '
        Me.Vet_Svidetel.Controls.Add(Me.DGV_ветеринарное_свидетельство)
        Me.Vet_Svidetel.Controls.Add(Me.GroupBox7_update)
        Me.Vet_Svidetel.Controls.Add(Me.GroupBox7_del)
        Me.Vet_Svidetel.Controls.Add(Me.GroupBox7_add)
        Me.Vet_Svidetel.Location = New System.Drawing.Point(4, 24)
        Me.Vet_Svidetel.Name = "Vet_Svidetel"
        Me.Vet_Svidetel.Padding = New System.Windows.Forms.Padding(3)
        Me.Vet_Svidetel.Size = New System.Drawing.Size(1221, 565)
        Me.Vet_Svidetel.TabIndex = 9
        Me.Vet_Svidetel.Text = "Ветеринарное свидетельство"
        Me.Vet_Svidetel.UseVisualStyleBackColor = True
        '
        'DGV_ветеринарное_свидетельство
        '
        Me.DGV_ветеринарное_свидетельство.AllowUserToAddRows = False
        Me.DGV_ветеринарное_свидетельство.AllowUserToDeleteRows = False
        Me.DGV_ветеринарное_свидетельство.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DGV_ветеринарное_свидетельство.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_ветеринарное_свидетельство.Location = New System.Drawing.Point(12, 7)
        Me.DGV_ветеринарное_свидетельство.Name = "DGV_ветеринарное_свидетельство"
        Me.DGV_ветеринарное_свидетельство.ReadOnly = True
        Me.DGV_ветеринарное_свидетельство.Size = New System.Drawing.Size(1199, 281)
        Me.DGV_ветеринарное_свидетельство.TabIndex = 41
        '
        'GroupBox7_update
        '
        Me.GroupBox7_update.Controls.Add(Me.d14)
        Me.GroupBox7_update.Controls.Add(Me.d13)
        Me.GroupBox7_update.Controls.Add(Me.id_прив_от_вет_обнв)
        Me.GroupBox7_update.Controls.Add(Me.id_наименов_прирв_вет_обнв)
        Me.GroupBox7_update.Controls.Add(Me.id_имя_жив_вет_обнв)
        Me.GroupBox7_update.Controls.Add(Me.id_вет_св_обнв)
        Me.GroupBox7_update.Controls.Add(Me.Label94)
        Me.GroupBox7_update.Controls.Add(Me.Изменить_вет_свед)
        Me.GroupBox7_update.Controls.Add(Me.Label82)
        Me.GroupBox7_update.Controls.Add(Me.Label92)
        Me.GroupBox7_update.Controls.Add(Me.Label83)
        Me.GroupBox7_update.Controls.Add(Me.имя_картинки_обнв)
        Me.GroupBox7_update.Controls.Add(Me.Label84)
        Me.GroupBox7_update.Controls.Add(Me.Label91)
        Me.GroupBox7_update.Controls.Add(Me.формат_кратинки_обнв)
        Me.GroupBox7_update.Controls.Add(Me.Label87)
        Me.GroupBox7_update.Controls.Add(Me.Label90)
        Me.GroupBox7_update.Location = New System.Drawing.Point(6, 377)
        Me.GroupBox7_update.Name = "GroupBox7_update"
        Me.GroupBox7_update.Size = New System.Drawing.Size(1208, 76)
        Me.GroupBox7_update.TabIndex = 40
        Me.GroupBox7_update.TabStop = False
        Me.GroupBox7_update.Text = "Изменить"
        '
        'id_прив_от_вет_обнв
        '
        Me.id_прив_от_вет_обнв.DataSource = Me.ОтчегоПрививкаBindingSource
        Me.id_прив_от_вет_обнв.DisplayMember = "Прививка_от"
        Me.id_прив_от_вет_обнв.FormattingEnabled = True
        Me.id_прив_от_вет_обнв.Location = New System.Drawing.Point(337, 32)
        Me.id_прив_от_вет_обнв.Name = "id_прив_от_вет_обнв"
        Me.id_прив_от_вет_обнв.Size = New System.Drawing.Size(121, 23)
        Me.id_прив_от_вет_обнв.TabIndex = 41
        Me.id_прив_от_вет_обнв.ValueMember = "ID_отЧего"
        '
        'id_наименов_прирв_вет_обнв
        '
        Me.id_наименов_прирв_вет_обнв.DataSource = Me.ПрививкаBindingSource
        Me.id_наименов_прирв_вет_обнв.DisplayMember = "Название_прививки"
        Me.id_наименов_прирв_вет_обнв.FormattingEnabled = True
        Me.id_наименов_прирв_вет_обнв.Location = New System.Drawing.Point(198, 31)
        Me.id_наименов_прирв_вет_обнв.Name = "id_наименов_прирв_вет_обнв"
        Me.id_наименов_прирв_вет_обнв.Size = New System.Drawing.Size(121, 23)
        Me.id_наименов_прирв_вет_обнв.TabIndex = 41
        Me.id_наименов_прирв_вет_обнв.ValueMember = "ID_прив"
        '
        'id_имя_жив_вет_обнв
        '
        Me.id_имя_жив_вет_обнв.DataSource = Me.ПаспортживотногоBindingSource
        Me.id_имя_жив_вет_обнв.DisplayMember = "Кличка"
        Me.id_имя_жив_вет_обнв.FormattingEnabled = True
        Me.id_имя_жив_вет_обнв.Location = New System.Drawing.Point(71, 31)
        Me.id_имя_жив_вет_обнв.Name = "id_имя_жив_вет_обнв"
        Me.id_имя_жив_вет_обнв.Size = New System.Drawing.Size(121, 23)
        Me.id_имя_жив_вет_обнв.TabIndex = 53
        Me.id_имя_жив_вет_обнв.ValueMember = "ID_Животного"
        '
        'id_вет_св_обнв
        '
        Me.id_вет_св_обнв.Location = New System.Drawing.Point(6, 33)
        Me.id_вет_св_обнв.Name = "id_вет_св_обнв"
        Me.id_вет_св_обнв.Size = New System.Drawing.Size(33, 22)
        Me.id_вет_св_обнв.TabIndex = 42
        '
        'Label94
        '
        Me.Label94.AutoSize = True
        Me.Label94.Location = New System.Drawing.Point(6, 15)
        Me.Label94.Name = "Label94"
        Me.Label94.Size = New System.Drawing.Size(81, 15)
        Me.Label94.TabIndex = 41
        Me.Label94.Text = "ID_Вет_свед"
        '
        'Изменить_вет_свед
        '
        Me.Изменить_вет_свед.BackColor = System.Drawing.SystemColors.Window
        Me.Изменить_вет_свед.Location = New System.Drawing.Point(1126, 47)
        Me.Изменить_вет_свед.Name = "Изменить_вет_свед"
        Me.Изменить_вет_свед.Size = New System.Drawing.Size(75, 23)
        Me.Изменить_вет_свед.TabIndex = 3
        Me.Изменить_вет_свед.Text = "Изменить"
        Me.Изменить_вет_свед.UseVisualStyleBackColor = False
        '
        'Label82
        '
        Me.Label82.AutoSize = True
        Me.Label82.Location = New System.Drawing.Point(800, 14)
        Me.Label82.Name = "Label82"
        Me.Label82.Size = New System.Drawing.Size(108, 15)
        Me.Label82.TabIndex = 52
        Me.Label82.Text = "Формат картинки"
        '
        'Label92
        '
        Me.Label92.AutoSize = True
        Me.Label92.Location = New System.Drawing.Point(93, 13)
        Me.Label92.Name = "Label92"
        Me.Label92.Size = New System.Drawing.Size(96, 15)
        Me.Label92.TabIndex = 39
        Me.Label92.Text = "Имя животного"
        '
        'Label83
        '
        Me.Label83.AutoSize = True
        Me.Label83.Location = New System.Drawing.Point(687, 15)
        Me.Label83.Name = "Label83"
        Me.Label83.Size = New System.Drawing.Size(88, 15)
        Me.Label83.TabIndex = 49
        Me.Label83.Text = "Имя картинки"
        '
        'имя_картинки_обнв
        '
        Me.имя_картинки_обнв.Location = New System.Drawing.Point(690, 33)
        Me.имя_картинки_обнв.Name = "имя_картинки_обнв"
        Me.имя_картинки_обнв.Size = New System.Drawing.Size(107, 22)
        Me.имя_картинки_обнв.TabIndex = 51
        '
        'Label84
        '
        Me.Label84.AutoSize = True
        Me.Label84.Location = New System.Drawing.Point(572, 14)
        Me.Label84.Name = "Label84"
        Me.Label84.Size = New System.Drawing.Size(94, 15)
        Me.Label84.TabIndex = 50
        Me.Label84.Text = "Срок действия "
        '
        'Label91
        '
        Me.Label91.AutoSize = True
        Me.Label91.Location = New System.Drawing.Point(349, 14)
        Me.Label91.Name = "Label91"
        Me.Label91.Size = New System.Drawing.Size(78, 15)
        Me.Label91.TabIndex = 42
        Me.Label91.Text = "Прививка от"
        '
        'формат_кратинки_обнв
        '
        Me.формат_кратинки_обнв.Location = New System.Drawing.Point(803, 32)
        Me.формат_кратинки_обнв.MaxLength = 4
        Me.формат_кратинки_обнв.Name = "формат_кратинки_обнв"
        Me.формат_кратинки_обнв.ReadOnly = True
        Me.формат_кратинки_обнв.Size = New System.Drawing.Size(33, 22)
        Me.формат_кратинки_обнв.TabIndex = 47
        Me.формат_кратинки_обнв.Text = "jpg"
        '
        'Label87
        '
        Me.Label87.AutoSize = True
        Me.Label87.Location = New System.Drawing.Point(461, 14)
        Me.Label87.Name = "Label87"
        Me.Label87.Size = New System.Drawing.Size(91, 15)
        Me.Label87.TabIndex = 46
        Me.Label87.Text = "Дата принятия"
        '
        'Label90
        '
        Me.Label90.AutoSize = True
        Me.Label90.Location = New System.Drawing.Point(195, 15)
        Me.Label90.Name = "Label90"
        Me.Label90.Size = New System.Drawing.Size(148, 15)
        Me.Label90.TabIndex = 45
        Me.Label90.Text = "Наименование прививки"
        '
        'GroupBox7_del
        '
        Me.GroupBox7_del.Controls.Add(Me.Удалить_вет_свед)
        Me.GroupBox7_del.Controls.Add(Me.id_вет_св_дел)
        Me.GroupBox7_del.Controls.Add(Me.Label93)
        Me.GroupBox7_del.Location = New System.Drawing.Point(9, 459)
        Me.GroupBox7_del.Name = "GroupBox7_del"
        Me.GroupBox7_del.Size = New System.Drawing.Size(200, 100)
        Me.GroupBox7_del.TabIndex = 39
        Me.GroupBox7_del.TabStop = False
        Me.GroupBox7_del.Text = "Удалить"
        '
        'Удалить_вет_свед
        '
        Me.Удалить_вет_свед.BackColor = System.Drawing.SystemColors.Window
        Me.Удалить_вет_свед.Location = New System.Drawing.Point(119, 71)
        Me.Удалить_вет_свед.Name = "Удалить_вет_свед"
        Me.Удалить_вет_свед.Size = New System.Drawing.Size(75, 23)
        Me.Удалить_вет_свед.TabIndex = 2
        Me.Удалить_вет_свед.Text = "Удалить"
        Me.Удалить_вет_свед.UseVisualStyleBackColor = False
        '
        'id_вет_св_дел
        '
        Me.id_вет_св_дел.Location = New System.Drawing.Point(17, 52)
        Me.id_вет_св_дел.Name = "id_вет_св_дел"
        Me.id_вет_св_дел.Size = New System.Drawing.Size(33, 22)
        Me.id_вет_св_дел.TabIndex = 40
        '
        'Label93
        '
        Me.Label93.AutoSize = True
        Me.Label93.Location = New System.Drawing.Point(14, 33)
        Me.Label93.Name = "Label93"
        Me.Label93.Size = New System.Drawing.Size(81, 15)
        Me.Label93.TabIndex = 38
        Me.Label93.Text = "ID_Вет_свед"
        '
        'GroupBox7_add
        '
        Me.GroupBox7_add.Controls.Add(Me.d12)
        Me.GroupBox7_add.Controls.Add(Me.d11)
        Me.GroupBox7_add.Controls.Add(Me.id_прив_от_вет_доб)
        Me.GroupBox7_add.Controls.Add(Me.id_наименов_прирв_вет_доб)
        Me.GroupBox7_add.Controls.Add(Me.id_имя_жив_вет_доб)
        Me.GroupBox7_add.Controls.Add(Me.Label101)
        Me.GroupBox7_add.Controls.Add(Me.Label102)
        Me.GroupBox7_add.Controls.Add(Me.имя_картинки_доб)
        Me.GroupBox7_add.Controls.Add(Me.Label103)
        Me.GroupBox7_add.Controls.Add(Me.формат_кратинки_доб)
        Me.GroupBox7_add.Controls.Add(Me.Label104)
        Me.GroupBox7_add.Controls.Add(Me.Label105)
        Me.GroupBox7_add.Controls.Add(Me.Label110)
        Me.GroupBox7_add.Controls.Add(Me.Добавить_вет_свед)
        Me.GroupBox7_add.Controls.Add(Me.id_вет_св_доб)
        Me.GroupBox7_add.Controls.Add(Me.Label111)
        Me.GroupBox7_add.Controls.Add(Me.Label112)
        Me.GroupBox7_add.Location = New System.Drawing.Point(3, 294)
        Me.GroupBox7_add.Name = "GroupBox7_add"
        Me.GroupBox7_add.Size = New System.Drawing.Size(1208, 76)
        Me.GroupBox7_add.TabIndex = 38
        Me.GroupBox7_add.TabStop = False
        Me.GroupBox7_add.Text = "Добавить"
        '
        'id_прив_от_вет_доб
        '
        Me.id_прив_от_вет_доб.DataSource = Me.ОтчегоПрививкаBindingSource
        Me.id_прив_от_вет_доб.DisplayMember = "Прививка_от"
        Me.id_прив_от_вет_доб.FormattingEnabled = True
        Me.id_прив_от_вет_доб.Location = New System.Drawing.Point(340, 37)
        Me.id_прив_от_вет_доб.Name = "id_прив_от_вет_доб"
        Me.id_прив_от_вет_доб.Size = New System.Drawing.Size(121, 23)
        Me.id_прив_от_вет_доб.TabIndex = 40
        Me.id_прив_от_вет_доб.ValueMember = "ID_отЧего"
        '
        'id_наименов_прирв_вет_доб
        '
        Me.id_наименов_прирв_вет_доб.DataSource = Me.ПрививкаBindingSource
        Me.id_наименов_прирв_вет_доб.DisplayMember = "Название_прививки"
        Me.id_наименов_прирв_вет_доб.FormattingEnabled = True
        Me.id_наименов_прирв_вет_доб.Location = New System.Drawing.Point(195, 38)
        Me.id_наименов_прирв_вет_доб.Name = "id_наименов_прирв_вет_доб"
        Me.id_наименов_прирв_вет_доб.Size = New System.Drawing.Size(121, 23)
        Me.id_наименов_прирв_вет_доб.TabIndex = 39
        Me.id_наименов_прирв_вет_доб.ValueMember = "ID_прив"
        '
        'id_имя_жив_вет_доб
        '
        Me.id_имя_жив_вет_доб.DataSource = Me.ПаспортживотногоBindingSource
        Me.id_имя_жив_вет_доб.DisplayMember = "Кличка"
        Me.id_имя_жив_вет_доб.FormattingEnabled = True
        Me.id_имя_жив_вет_доб.Location = New System.Drawing.Point(65, 38)
        Me.id_имя_жив_вет_доб.Name = "id_имя_жив_вет_доб"
        Me.id_имя_жив_вет_доб.Size = New System.Drawing.Size(121, 23)
        Me.id_имя_жив_вет_доб.TabIndex = 38
        Me.id_имя_жив_вет_доб.ValueMember = "ID_Животного"
        '
        'Label101
        '
        Me.Label101.AutoSize = True
        Me.Label101.Location = New System.Drawing.Point(803, 21)
        Me.Label101.Name = "Label101"
        Me.Label101.Size = New System.Drawing.Size(108, 15)
        Me.Label101.TabIndex = 32
        Me.Label101.Text = "Формат картинки"
        '
        'Label102
        '
        Me.Label102.AutoSize = True
        Me.Label102.Location = New System.Drawing.Point(690, 21)
        Me.Label102.Name = "Label102"
        Me.Label102.Size = New System.Drawing.Size(88, 15)
        Me.Label102.TabIndex = 30
        Me.Label102.Text = "Имя картинки"
        '
        'имя_картинки_доб
        '
        Me.имя_картинки_доб.Location = New System.Drawing.Point(693, 39)
        Me.имя_картинки_доб.Name = "имя_картинки_доб"
        Me.имя_картинки_доб.Size = New System.Drawing.Size(107, 22)
        Me.имя_картинки_доб.TabIndex = 31
        '
        'Label103
        '
        Me.Label103.AutoSize = True
        Me.Label103.Location = New System.Drawing.Point(575, 23)
        Me.Label103.Name = "Label103"
        Me.Label103.Size = New System.Drawing.Size(94, 15)
        Me.Label103.TabIndex = 30
        Me.Label103.Text = "Срок действия "
        '
        'формат_кратинки_доб
        '
        Me.формат_кратинки_доб.Location = New System.Drawing.Point(806, 39)
        Me.формат_кратинки_доб.MaxLength = 4
        Me.формат_кратинки_доб.Name = "формат_кратинки_доб"
        Me.формат_кратинки_доб.ReadOnly = True
        Me.формат_кратинки_доб.Size = New System.Drawing.Size(33, 22)
        Me.формат_кратинки_доб.TabIndex = 18
        Me.формат_кратинки_доб.Text = "jpg"
        '
        'Label104
        '
        Me.Label104.AutoSize = True
        Me.Label104.Location = New System.Drawing.Point(464, 23)
        Me.Label104.Name = "Label104"
        Me.Label104.Size = New System.Drawing.Size(91, 15)
        Me.Label104.TabIndex = 17
        Me.Label104.Text = "Дата принятия"
        '
        'Label105
        '
        Me.Label105.AutoSize = True
        Me.Label105.Location = New System.Drawing.Point(192, 19)
        Me.Label105.Name = "Label105"
        Me.Label105.Size = New System.Drawing.Size(148, 15)
        Me.Label105.TabIndex = 16
        Me.Label105.Text = "Наименование прививки"
        '
        'Label110
        '
        Me.Label110.AutoSize = True
        Me.Label110.Location = New System.Drawing.Point(352, 19)
        Me.Label110.Name = "Label110"
        Me.Label110.Size = New System.Drawing.Size(78, 15)
        Me.Label110.TabIndex = 6
        Me.Label110.Text = "Прививка от"
        '
        'Добавить_вет_свед
        '
        Me.Добавить_вет_свед.BackColor = System.Drawing.SystemColors.Window
        Me.Добавить_вет_свед.Location = New System.Drawing.Point(1127, 40)
        Me.Добавить_вет_свед.Name = "Добавить_вет_свед"
        Me.Добавить_вет_свед.Size = New System.Drawing.Size(75, 23)
        Me.Добавить_вет_свед.TabIndex = 4
        Me.Добавить_вет_свед.Text = "Добавить"
        Me.Добавить_вет_свед.UseVisualStyleBackColor = False
        '
        'id_вет_св_доб
        '
        Me.id_вет_св_доб.Location = New System.Drawing.Point(6, 38)
        Me.id_вет_св_доб.Name = "id_вет_св_доб"
        Me.id_вет_св_доб.Size = New System.Drawing.Size(33, 22)
        Me.id_вет_св_доб.TabIndex = 2
        '
        'Label111
        '
        Me.Label111.AutoSize = True
        Me.Label111.Location = New System.Drawing.Point(90, 19)
        Me.Label111.Name = "Label111"
        Me.Label111.Size = New System.Drawing.Size(96, 15)
        Me.Label111.TabIndex = 1
        Me.Label111.Text = "Имя животного"
        '
        'Label112
        '
        Me.Label112.AutoSize = True
        Me.Label112.Location = New System.Drawing.Point(3, 19)
        Me.Label112.Name = "Label112"
        Me.Label112.Size = New System.Drawing.Size(81, 15)
        Me.Label112.TabIndex = 0
        Me.Label112.Text = "ID_Вет_свед"
        '
        'Vixod
        '
        Me.Vixod.BackColor = System.Drawing.SystemColors.Window
        Me.Vixod.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Vixod.Location = New System.Drawing.Point(12, 611)
        Me.Vixod.Name = "Vixod"
        Me.Vixod.Size = New System.Drawing.Size(96, 23)
        Me.Vixod.TabIndex = 1
        Me.Vixod.Text = "Закрыть"
        Me.Vixod.UseVisualStyleBackColor = False
        '
        'save
        '
        Me.save.BackColor = System.Drawing.SystemColors.Window
        Me.save.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
        Me.save.Location = New System.Drawing.Point(1079, 606)
        Me.save.Name = "save"
        Me.save.Size = New System.Drawing.Size(159, 35)
        Me.save.TabIndex = 2
        Me.save.Text = "СОХРАНИТЬ"
        Me.save.UseVisualStyleBackColor = False
        '
        'СтранаTableAdapter
        '
        Me.СтранаTableAdapter.ClearBeforeFill = True
        '
        'НаградыTableAdapter
        '
        Me.НаградыTableAdapter.ClearBeforeFill = True
        '
        'ОтчегоПрививкаTableAdapter
        '
        Me.ОтчегоПрививкаTableAdapter.ClearBeforeFill = True
        '
        'ПрививкаTableAdapter
        '
        Me.ПрививкаTableAdapter.ClearBeforeFill = True
        '
        'Место_размещения_электронного_чипаTableAdapter
        '
        Me.Место_размещения_электронного_чипаTableAdapter.ClearBeforeFill = True
        '
        'ПородыTableAdapter
        '
        Me.ПородыTableAdapter.ClearBeforeFill = True
        '
        'ВладельцыTableAdapter
        '
        Me.ВладельцыTableAdapter.ClearBeforeFill = True
        '
        'Паспорт_животногоTableAdapter
        '
        Me.Паспорт_животногоTableAdapter.ClearBeforeFill = True
        '
        'D1
        '
        Me.D1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.D1.Location = New System.Drawing.Point(258, 39)
        Me.D1.Name = "D1"
        Me.D1.Size = New System.Drawing.Size(82, 22)
        Me.D1.TabIndex = 18
        '
        'D2
        '
        Me.D2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.D2.Location = New System.Drawing.Point(261, 38)
        Me.D2.Name = "D2"
        Me.D2.Size = New System.Drawing.Size(82, 22)
        Me.D2.TabIndex = 19
        '
        'd3
        '
        Me.d3.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.d3.Location = New System.Drawing.Point(473, 36)
        Me.d3.Name = "d3"
        Me.d3.Size = New System.Drawing.Size(82, 22)
        Me.d3.TabIndex = 45
        '
        'd4
        '
        Me.d4.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.d4.Location = New System.Drawing.Point(930, 34)
        Me.d4.Name = "d4"
        Me.d4.Size = New System.Drawing.Size(82, 22)
        Me.d4.TabIndex = 46
        '
        'd5
        '
        Me.d5.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.d5.Location = New System.Drawing.Point(469, 36)
        Me.d5.Name = "d5"
        Me.d5.Size = New System.Drawing.Size(82, 22)
        Me.d5.TabIndex = 46
        '
        'd6
        '
        Me.d6.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.d6.Location = New System.Drawing.Point(926, 36)
        Me.d6.Name = "d6"
        Me.d6.Size = New System.Drawing.Size(82, 22)
        Me.d6.TabIndex = 47
        '
        'd7
        '
        Me.d7.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.d7.Location = New System.Drawing.Point(500, 38)
        Me.d7.Name = "d7"
        Me.d7.Size = New System.Drawing.Size(82, 22)
        Me.d7.TabIndex = 46
        '
        'd8
        '
        Me.d8.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.d8.Location = New System.Drawing.Point(634, 39)
        Me.d8.Name = "d8"
        Me.d8.Size = New System.Drawing.Size(82, 22)
        Me.d8.TabIndex = 47
        '
        'd9
        '
        Me.d9.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.d9.Location = New System.Drawing.Point(500, 49)
        Me.d9.Name = "d9"
        Me.d9.Size = New System.Drawing.Size(82, 22)
        Me.d9.TabIndex = 46
        '
        'd10
        '
        Me.d10.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.d10.Location = New System.Drawing.Point(634, 49)
        Me.d10.Name = "d10"
        Me.d10.Size = New System.Drawing.Size(82, 22)
        Me.d10.TabIndex = 47
        '
        'd11
        '
        Me.d11.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.d11.Location = New System.Drawing.Point(467, 38)
        Me.d11.Name = "d11"
        Me.d11.Size = New System.Drawing.Size(82, 22)
        Me.d11.TabIndex = 48
        '
        'd12
        '
        Me.d12.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.d12.Location = New System.Drawing.Point(578, 38)
        Me.d12.Name = "d12"
        Me.d12.Size = New System.Drawing.Size(82, 22)
        Me.d12.TabIndex = 49
        '
        'd13
        '
        Me.d13.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.d13.Location = New System.Drawing.Point(464, 33)
        Me.d13.Name = "d13"
        Me.d13.Size = New System.Drawing.Size(82, 22)
        Me.d13.TabIndex = 54
        '
        'd14
        '
        Me.d14.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.d14.Location = New System.Drawing.Point(575, 33)
        Me.d14.Name = "d14"
        Me.d14.Size = New System.Drawing.Size(82, 22)
        Me.d14.TabIndex = 55
        '
        'aktyalizat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(1253, 642)
        Me.Controls.Add(Me.save)
        Me.Controls.Add(Me.Vixod)
        Me.Controls.Add(Me.Aktyaliz)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(1273, 685)
        Me.MinimumSize = New System.Drawing.Size(1273, 685)
        Me.Name = "aktyalizat"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ZelZooExpo(Актуализация данных)"
        Me.Aktyaliz.ResumeLayout(False)
        Me.Strana.ResumeLayout(False)
        Me.grup_update.ResumeLayout(False)
        Me.grup_update.PerformLayout()
        Me.grup_del.ResumeLayout(False)
        Me.grup_del.PerformLayout()
        Me.grup_dobavit.ResumeLayout(False)
        Me.grup_dobavit.PerformLayout()
        CType(Me.DGV_Страна_актул, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.СтранаBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AnimalBDDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Nagrada.ResumeLayout(False)
        Me.GrBox1_update.ResumeLayout(False)
        Me.GrBox1_update.PerformLayout()
        Me.GrBox1_del.ResumeLayout(False)
        Me.GrBox1_del.PerformLayout()
        Me.GrBox1_add.ResumeLayout(False)
        Me.GrBox1_add.PerformLayout()
        CType(Me.DGV_Награды_актул, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.НаградыBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Otchego.ResumeLayout(False)
        Me.GroupBox_update.ResumeLayout(False)
        Me.GroupBox_update.PerformLayout()
        Me.GroupBox_del.ResumeLayout(False)
        Me.GroupBox_del.PerformLayout()
        Me.GroupBox_add.ResumeLayout(False)
        Me.GroupBox_add.PerformLayout()
        CType(Me.DGV_отчего_актул, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ОтчегоПрививкаBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Privivka.ResumeLayout(False)
        Me.GroupBox1_update.ResumeLayout(False)
        Me.GroupBox1_update.PerformLayout()
        Me.GroupBox1_del.ResumeLayout(False)
        Me.GroupBox1_del.PerformLayout()
        Me.GroupBox1_add.ResumeLayout(False)
        Me.GroupBox1_add.PerformLayout()
        CType(Me.DGV_прививки_актул, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ПрививкаBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Mesto.ResumeLayout(False)
        Me.GroupBox2_update.ResumeLayout(False)
        Me.GroupBox2_update.PerformLayout()
        Me.GroupBox2_del.ResumeLayout(False)
        Me.GroupBox2_del.PerformLayout()
        Me.GroupBox2_add.ResumeLayout(False)
        Me.GroupBox2_add.PerformLayout()
        CType(Me.DGV_место_размещ_актул, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.МесторазмещенияэлектронногочипаBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Porod.ResumeLayout(False)
        Me.GroupBox3_update.ResumeLayout(False)
        Me.GroupBox3_update.PerformLayout()
        Me.GroupBox3_del.ResumeLayout(False)
        Me.GroupBox3_del.PerformLayout()
        Me.GroupBox3_add.ResumeLayout(False)
        Me.GroupBox3_add.PerformLayout()
        CType(Me.DGV_породы_актул, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ПородыBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Vladelti.ResumeLayout(False)
        CType(Me.DGV_Владельцы_актул, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4_update.ResumeLayout(False)
        Me.GroupBox4_update.PerformLayout()
        Me.GroupBox4_del.ResumeLayout(False)
        Me.GroupBox4_del.PerformLayout()
        Me.GroupBox4_add.ResumeLayout(False)
        Me.GroupBox4_add.PerformLayout()
        Me.Pasport.ResumeLayout(False)
        CType(Me.DGV_паспорт_животного_актул, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox5_update.ResumeLayout(False)
        Me.GroupBox5_update.PerformLayout()
        CType(Me.ВладельцыBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox5_del.ResumeLayout(False)
        Me.GroupBox5_del.PerformLayout()
        Me.GroupBox5_add.ResumeLayout(False)
        Me.GroupBox5_add.PerformLayout()
        Me.Poluch_Nagrad.ResumeLayout(False)
        CType(Me.DGV_получ_награды_актул, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox6_update.ResumeLayout(False)
        Me.GroupBox6_update.PerformLayout()
        CType(Me.ПаспортживотногоBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox6_del.ResumeLayout(False)
        Me.GroupBox6_del.PerformLayout()
        Me.GroupBox6_add.ResumeLayout(False)
        Me.GroupBox6_add.PerformLayout()
        Me.Vet_Svidetel.ResumeLayout(False)
        CType(Me.DGV_ветеринарное_свидетельство, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox7_update.ResumeLayout(False)
        Me.GroupBox7_update.PerformLayout()
        Me.GroupBox7_del.ResumeLayout(False)
        Me.GroupBox7_del.PerformLayout()
        Me.GroupBox7_add.ResumeLayout(False)
        Me.GroupBox7_add.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Aktyaliz As TabControl
    Friend WithEvents Strana As TabPage
    Friend WithEvents Nagrada As TabPage
    Friend WithEvents Otchego As TabPage
    Friend WithEvents Privivka As TabPage
    Friend WithEvents Mesto As TabPage
    Friend WithEvents Porod As TabPage
    Friend WithEvents Vladelti As TabPage
    Friend WithEvents Pasport As TabPage
    Friend WithEvents Poluch_Nagrad As TabPage
    Friend WithEvents Vet_Svidetel As TabPage
    Friend WithEvents DGV_Страна_актул As DataGridView
    Friend WithEvents DGV_Награды_актул As DataGridView
    Friend WithEvents DGV_отчего_актул As DataGridView
    Friend WithEvents DGV_прививки_актул As DataGridView
    Friend WithEvents DGV_место_размещ_актул As DataGridView
    Friend WithEvents DGV_породы_актул As DataGridView
    Friend WithEvents grup_update As GroupBox
    Friend WithEvents Изменить_страну As Button
    Friend WithEvents название_страны_обнв As TextBox
    Friend WithEvents id_страны_обнв As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents grup_del As GroupBox
    Friend WithEvents Удалить_страну As Button
    Friend WithEvents название_страны_удл As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents grup_dobavit As GroupBox
    Friend WithEvents Добавить_страну As Button
    Friend WithEvents название_страны_доб As TextBox
    Friend WithEvents id_страны_доб As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Vixod As Button
    Friend WithEvents GrBox1_update As GroupBox
    Friend WithEvents Изменить_награду As Button
    Friend WithEvents наименование_награды_обнв As TextBox
    Friend WithEvents id_награды_обнв As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents GrBox1_del As GroupBox
    Friend WithEvents Удалить_награду As Button
    Friend WithEvents наименование_награды_дел As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents GrBox1_add As GroupBox
    Friend WithEvents Добавить_награду As Button
    Friend WithEvents наименование_награды_доб As TextBox
    Friend WithEvents id_награды_доб As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents GroupBox_update As GroupBox
    Friend WithEvents Изменить_отчего_прививка As Button
    Friend WithEvents прививка_от_обнв As TextBox
    Friend WithEvents id_отчего_прив_обнв As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents GroupBox_del As GroupBox
    Friend WithEvents Удалить_отчего_прививка As Button
    Friend WithEvents прививка_от_дел As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents GroupBox_add As GroupBox
    Friend WithEvents Добавить_отчего_прививка As Button
    Friend WithEvents прививка_от_доб As TextBox
    Friend WithEvents id_отчего_прив_доб As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents GroupBox1_update As GroupBox
    Friend WithEvents Изменить_прививку As Button
    Friend WithEvents наименование_прививки_обнв As TextBox
    Friend WithEvents id_прививки_обнв As TextBox
    Friend WithEvents GroupBox1_del As GroupBox
    Friend WithEvents Удалить_прививку As Button
    Friend WithEvents наименование_прививки_дел As TextBox
    Friend WithEvents GroupBox1_add As GroupBox
    Friend WithEvents Добавить_прививку As Button
    Friend WithEvents наименование_прививки_доб As TextBox
    Friend WithEvents id_прививки_доб As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents страна_производитель_обнв As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents страна_производитель_доб As TextBox
    Friend WithEvents GroupBox2_update As GroupBox
    Friend WithEvents Label23 As Label
    Friend WithEvents Изменить_место_размещ_чипа As Button
    Friend WithEvents где_обнв As TextBox
    Friend WithEvents id_места_обнв As TextBox
    Friend WithEvents GroupBox2_del As GroupBox
    Friend WithEvents Удалить_место_размещ_чипа As Button
    Friend WithEvents где_дел As TextBox
    Friend WithEvents GroupBox2_add As GroupBox
    Friend WithEvents Добавить_место_размещ_чипа As Button
    Friend WithEvents где_доб As TextBox
    Friend WithEvents id_места_доб As TextBox
    Friend WithEvents Label27 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents GroupBox3_update As GroupBox
    Friend WithEvents Label30 As Label
    Friend WithEvents Label28 As Label
    Friend WithEvents Изменить_породу As Button
    Friend WithEvents название_породы_обнв As TextBox
    Friend WithEvents id_породы_обнв As TextBox
    Friend WithEvents GroupBox3_del As GroupBox
    Friend WithEvents Label29 As Label
    Friend WithEvents Удалить_породу As Button
    Friend WithEvents название_породы_дел As TextBox
    Friend WithEvents GroupBox3_add As GroupBox
    Friend WithEvents Добавить_породу As Button
    Friend WithEvents название_породы_доб As TextBox
    Friend WithEvents id_породы_доб As TextBox
    Friend WithEvents Label31 As Label
    Friend WithEvents Label32 As Label
    Friend WithEvents GroupBox4_update As GroupBox
    Friend WithEvents Label33 As Label
    Friend WithEvents Изменить_владельца As Button
    Friend WithEvents номер_дома_обнв As TextBox
    Friend WithEvents Label47 As Label
    Friend WithEvents Label34 As Label
    Friend WithEvents Label46 As Label
    Friend WithEvents улица_обнв As TextBox
    Friend WithEvents id_владельца_обнв As TextBox
    Friend WithEvents Label43 As Label
    Friend WithEvents ФИО_обнв As TextBox
    Friend WithEvents город_обнв As TextBox
    Friend WithEvents Label45 As Label
    Friend WithEvents Label44 As Label
    Friend WithEvents GroupBox4_del As GroupBox
    Friend WithEvents Label35 As Label
    Friend WithEvents Удалить_владельца As Button
    Friend WithEvents ФИО_дел As TextBox
    Friend WithEvents GroupBox4_add As GroupBox
    Friend WithEvents Label42 As Label
    Friend WithEvents номер_дома_доб As TextBox
    Friend WithEvents Label41 As Label
    Friend WithEvents улица_доб As TextBox
    Friend WithEvents Label40 As Label
    Friend WithEvents город_доб As TextBox
    Friend WithEvents Label39 As Label
    Friend WithEvents Label38 As Label
    Friend WithEvents Добавть_владельца As Button
    Friend WithEvents ФИО_доб As TextBox
    Friend WithEvents id_владельца_доб As TextBox
    Friend WithEvents Label36 As Label
    Friend WithEvents Label37 As Label
    Friend WithEvents Изменить_паспорт As Button
    Friend WithEvents GroupBox5_del As GroupBox
    Friend WithEvents Удалить_паспорт As Button
    Friend WithEvents GroupBox5_add As GroupBox
    Friend WithEvents Label56 As Label
    Friend WithEvents пол_животного_доб As TextBox
    Friend WithEvents Label57 As Label
    Friend WithEvents имя_папы_доб As TextBox
    Friend WithEvents Label58 As Label
    Friend WithEvents Label59 As Label
    Friend WithEvents номер_родословной_доб As TextBox
    Friend WithEvents Label60 As Label
    Friend WithEvents Добавить_паспорт As Button
    Friend WithEvents id_животного_доб As TextBox
    Friend WithEvents Label61 As Label
    Friend WithEvents Label62 As Label
    Friend WithEvents окрас_животного_доб As TextBox
    Friend WithEvents Label67 As Label
    Friend WithEvents Label66 As Label
    Friend WithEvents группа_животного_доб As TextBox
    Friend WithEvents Label65 As Label
    Friend WithEvents Label64 As Label
    Friend WithEvents Label63 As Label
    Friend WithEvents GroupBox5_update As GroupBox
    Friend WithEvents Label49 As Label
    Friend WithEvents имя_мамы_обнв As TextBox
    Friend WithEvents окрас_животного_обнв As TextBox
    Friend WithEvents Label50 As Label
    Friend WithEvents Label51 As Label
    Friend WithEvents группа_животного_обнв As TextBox
    Friend WithEvents Label52 As Label
    Friend WithEvents Label53 As Label
    Friend WithEvents Label54 As Label
    Friend WithEvents Label55 As Label
    Friend WithEvents пол_животного_обнв As TextBox
    Friend WithEvents Label69 As Label
    Friend WithEvents имя_папы_обнв As TextBox
    Friend WithEvents Label70 As Label
    Friend WithEvents имя_животного_обнв As TextBox
    Friend WithEvents Label71 As Label
    Friend WithEvents номер_родословной_обнв As TextBox
    Friend WithEvents Label72 As Label
    Friend WithEvents id_животного_обнв As TextBox
    Friend WithEvents Label73 As Label
    Friend WithEvents Label74 As Label
    Friend WithEvents Label48 As Label
    Friend WithEvents Label68 As Label
    Friend WithEvents имя_мамы_доб As TextBox
    Friend WithEvents кличка_животного_дел As TextBox
    Friend WithEvents GroupBox6_update As GroupBox
    Friend WithEvents Label76 As Label
    Friend WithEvents Изменить_получ_награды As Button
    Friend WithEvents id_получ_награды_обнв As TextBox
    Friend WithEvents Label77 As Label
    Friend WithEvents Label80 As Label
    Friend WithEvents Label78 As Label
    Friend WithEvents Label79 As Label
    Friend WithEvents GroupBox6_del As GroupBox
    Friend WithEvents id_получ_награды_уд As TextBox
    Friend WithEvents Label81 As Label
    Friend WithEvents Удалить_получ_награды As Button
    Friend WithEvents GroupBox6_add As GroupBox
    Friend WithEvents Label75 As Label
    Friend WithEvents Label85 As Label
    Friend WithEvents Label86 As Label
    Friend WithEvents Добавить_получ_награды As Button
    Friend WithEvents id_получ_награды_доб As TextBox
    Friend WithEvents Label88 As Label
    Friend WithEvents Label89 As Label
    Friend WithEvents GroupBox7_update As GroupBox
    Friend WithEvents Изменить_вет_свед As Button
    Friend WithEvents GroupBox7_del As GroupBox
    Friend WithEvents Удалить_вет_свед As Button
    Friend WithEvents GroupBox7_add As GroupBox
    Friend WithEvents Label101 As Label
    Friend WithEvents Label102 As Label
    Friend WithEvents имя_картинки_доб As TextBox
    Friend WithEvents Label103 As Label
    Friend WithEvents формат_кратинки_доб As TextBox
    Friend WithEvents Label104 As Label
    Friend WithEvents Label105 As Label
    Friend WithEvents Label110 As Label
    Friend WithEvents Добавить_вет_свед As Button
    Friend WithEvents id_вет_св_доб As TextBox
    Friend WithEvents Label111 As Label
    Friend WithEvents Label112 As Label
    Friend WithEvents Label82 As Label
    Friend WithEvents Label92 As Label
    Friend WithEvents Label83 As Label
    Friend WithEvents имя_картинки_обнв As TextBox
    Friend WithEvents Label84 As Label
    Friend WithEvents Label91 As Label
    Friend WithEvents формат_кратинки_обнв As TextBox
    Friend WithEvents Label87 As Label
    Friend WithEvents Label90 As Label
    Friend WithEvents id_вет_св_дел As TextBox
    Friend WithEvents Label93 As Label
    Friend WithEvents id_вет_св_обнв As TextBox
    Friend WithEvents Label94 As Label
    Friend WithEvents ID_клички_доб As ComboBox
    Friend WithEvents получ_награды_доб As ComboBox
    Friend WithEvents получ_награды_обнв As ComboBox
    Friend WithEvents ID_клички_обнв As ComboBox
    Friend WithEvents id_страны_влад_доб As ComboBox
    Friend WithEvents id_владельца_животного_доб As ComboBox
    Friend WithEvents id_породы_животного_доб As ComboBox
    Friend WithEvents кличка_животного_доб As TextBox
    Friend WithEvents место_размещения_доб As ComboBox
    Friend WithEvents id_владельца_животного_обнв As ComboBox
    Friend WithEvents id_породы_животного_обнв As ComboBox
    Friend WithEvents место_размещения_обнв As ComboBox
    Friend WithEvents id_страны_влад_обнв As ComboBox
    Friend WithEvents id_имя_жив_вет_доб As ComboBox
    Friend WithEvents id_наименов_прирв_вет_доб As ComboBox
    Friend WithEvents id_прив_от_вет_обнв As ComboBox
    Friend WithEvents id_наименов_прирв_вет_обнв As ComboBox
    Friend WithEvents id_имя_жив_вет_обнв As ComboBox
    Friend WithEvents id_прив_от_вет_доб As ComboBox
    Friend WithEvents DGV_Владельцы_актул As DataGridView
    Friend WithEvents DGV_паспорт_животного_актул As DataGridView
    Friend WithEvents DGV_получ_награды_актул As DataGridView
    Friend WithEvents DGV_ветеринарное_свидетельство As DataGridView
    Friend WithEvents save As Button
    Friend WithEvents Label95 As Label
    Friend WithEvents номер_чипа_доб As TextBox
    Friend WithEvents Label96 As Label
    Friend WithEvents номер_чипа_обнв As TextBox
    Friend WithEvents AnimalBDDataSet As animalBDDataSet
    Friend WithEvents СтранаBindingSource As BindingSource
    Friend WithEvents СтранаTableAdapter As animalBDDataSetTableAdapters.СтранаTableAdapter
    Friend WithEvents IDСтраныDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents НазваниеDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents НаградыBindingSource As BindingSource
    Friend WithEvents НаградыTableAdapter As animalBDDataSetTableAdapters.НаградыTableAdapter
    Friend WithEvents Label98 As Label
    Friend WithEvents колживнаг_обнов As TextBox
    Friend WithEvents Label97 As Label
    Friend WithEvents колживнаг_доб As TextBox
    Friend WithEvents ОтчегоПрививкаBindingSource As BindingSource
    Friend WithEvents ОтчегоПрививкаTableAdapter As animalBDDataSetTableAdapters.ОтчегоПрививкаTableAdapter
    Friend WithEvents ПрививкаBindingSource As BindingSource
    Friend WithEvents ПрививкаTableAdapter As animalBDDataSetTableAdapters.ПрививкаTableAdapter
    Friend WithEvents Label100 As Label
    Friend WithEvents колвоприв_обнов As TextBox
    Friend WithEvents Label99 As Label
    Friend WithEvents колвоприв_доб As TextBox
    Friend WithEvents IDНаградыDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents НаименованиеDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents КоличествоживотныхполучившихнаградуDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IDотЧегоDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ПрививкаотDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IDпривDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents НазваниепрививкиDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents СтранапроизводительDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents КоличествопривитыхDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents МесторазмещенияэлектронногочипаBindingSource As BindingSource
    Friend WithEvents Место_размещения_электронного_чипаTableAdapter As animalBDDataSetTableAdapters.Место_размещения_электронного_чипаTableAdapter
    Friend WithEvents IDМестоDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ГдеDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ПородыBindingSource As BindingSource
    Friend WithEvents ПородыTableAdapter As animalBDDataSetTableAdapters.ПородыTableAdapter
    Friend WithEvents IDПородыDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents НазваниеDataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents ВладельцыBindingSource As BindingSource
    Friend WithEvents ВладельцыTableAdapter As animalBDDataSetTableAdapters.ВладельцыTableAdapter
    Friend WithEvents ПаспортживотногоBindingSource As BindingSource
    Friend WithEvents Паспорт_животногоTableAdapter As animalBDDataSetTableAdapters.Паспорт_животногоTableAdapter
    Friend WithEvents D2 As DateTimePicker
    Friend WithEvents D1 As DateTimePicker
    Friend WithEvents d4 As DateTimePicker
    Friend WithEvents d3 As DateTimePicker
    Friend WithEvents d6 As DateTimePicker
    Friend WithEvents d5 As DateTimePicker
    Friend WithEvents d10 As DateTimePicker
    Friend WithEvents d9 As DateTimePicker
    Friend WithEvents d8 As DateTimePicker
    Friend WithEvents d7 As DateTimePicker
    Friend WithEvents d14 As DateTimePicker
    Friend WithEvents d13 As DateTimePicker
    Friend WithEvents d12 As DateTimePicker
    Friend WithEvents d11 As DateTimePicker
End Class
