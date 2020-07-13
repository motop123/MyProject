Imports System.Configuration
Imports System.Data
Imports System.Data.SqlClient
Imports Excel = Microsoft.Office.Interop.Excel
Imports Microsoft.Office
Imports Microsoft.Office.Interop
Imports System.IO
Imports System.Reflection

Imports Microsoft.Reporting
Imports Microsoft.ReportingServices


Public Class prosmotr
    Dim xlApp As Microsoft.Office.Interop.Excel.Application
    Dim xlWorkBook As Microsoft.Office.Interop.Excel.Workbook
    Dim xlWorkSheet As Microsoft.Office.Interop.Excel.Worksheet
    Dim misValue As Object = System.Reflection.Missing.Value
    Private Sub закрыть_Click(sender As Object, e As EventArgs) Handles закрыть.Click
        Close()
    End Sub

    Private Sub prosmotr_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: данная строка кода позволяет загрузить данные в таблицу "animalBDDataSet.Паспорт_животного". При необходимости она может быть перемещена или удалена.
        Me.Паспорт_животногоTableAdapter.Fill(Me.animalBDDataSet.Паспорт_животного)
        'TODO: данная строка кода позволяет загрузить данные в таблицу "animalBDDataSet.Владельцы". При необходимости она может быть перемещена или удалена.
        Me.ВладельцыTableAdapter.Fill(Me.animalBDDataSet.Владельцы)

        KeyPreview = True
        Search_Vlad("")
        Search_Pass("")
        Search_Vet("")
        Search_nag("")

        Dim data_segodn As Date = Now
        TextBox2.Text = data_segodn

        If TextBox2.Text > TextBox1.Text Then
            MessageBox.Show("У одного или несколько животных сошёл срок годности прививки (вкладка ветиринарное свидтетельство) . Пожалуйста сделайте новую прививку")
        End If

        DataGridView2.DataSource = Getdatalist()
        DataGridView1.DataSource = Getdatalist2()



        Me.ReportViewer1.RefreshReport
    End Sub
    Private Function Getdatalist2() As DataTable
        Dim dt As New DataTable
        Dim connString As String = ConfigurationManager.ConnectionStrings("ZelZooExpo.My.MySettings.animalBDConnectionString1").ConnectionString
        Using conn As New SqlConnection(connString)
            Using cmd As New SqlCommand("select Прививка.Название_прививки as'Название прививки',Прививка.Страна_производитель as 'Страна производитель',Прививка.Количество_привитых as 'Количество привитых' from Прививка", conn)
                conn.Open()
                Dim reader As SqlDataReader = cmd.ExecuteReader()
                dt.Load(reader)
            End Using
        End Using
        Return dt
    End Function
    Private Function Getdatalist() As DataTable
        Dim dt As New DataTable
        Dim connString As String = ConfigurationManager.ConnectionStrings("ZelZooExpo.My.MySettings.animalBDConnectionString1").ConnectionString
        Using conn As New SqlConnection(connString)
            Using cmd As New SqlCommand("select  Награды.Наименование, Награды.Количество_животных_получивших_награду as 'Количество животных получивших награду' from Награды", conn)
                conn.Open()
                Dim reader As SqlDataReader = cmd.ExecuteReader()
                dt.Load(reader)
            End Using
        End Using
        Return dt
    End Function
    Private Sub DGV_ветеринарное_свидетельство_SelectionChanged(sender As Object, e As EventArgs) Handles DGV_ветеринарное_свидетельство.SelectionChanged
        Me.TextBox1.Text = DGV_ветеринарное_свидетельство.CurrentRow.Cells(4).Value()

        Dim folder As String = "imgAnimals\"
        Dim filename As String = System.IO.Path.Combine(folder, DGV_ветеринарное_свидетельство.CurrentRow.Cells(5).Value() & ".jpg")
        Картинка.Image = Image.FromFile(filename)
    End Sub

    'ПОИСК ВЛАДЕЛЬЦы
    Public Sub Search_Vlad(valueToSearch As String)
        Dim connString As String = ConfigurationManager.ConnectionStrings("ZelZooExpo.My.MySettings.animalBDConnectionString1").ConnectionString
        Using conn As New SqlConnection(connString)
            Dim ser = "select Владельцы.ФИО, Владельцы.Дата_рождения as 'Дата рождения' ,Страна.Название as 'Страна',Владельцы.Город,Владельцы.Улица,Владельцы.Номер_дома as 'Номер дома' from Владельцы join Страна on Владельцы.Страна=Страна.ID_Страны where concat (ID_Владельца,ФИО,Дата_рождения,Страна.Название,Город,Улица,Номер_дома) like '%" & valueToSearch & "%'"
            Dim command As New SqlCommand(ser, conn)
            Dim adapter As New SqlDataAdapter(command)
            Dim table As New DataTable()
            adapter.Fill(table)
            DGV_Владельцы_просмотр.DataSource = table
        End Using
    End Sub
    Private Sub ПоискВладельцев_Click(sender As Object, e As EventArgs) Handles ПоискВладельцев.Click
        Dim connString As String = ConfigurationManager.ConnectionStrings("ZelZooExpo.My.MySettings.animalBDConnectionString1").ConnectionString
        Using conn As New SqlConnection(connString)
            Dim command As New SqlCommand("select Владельцы.ФИО, Владельцы.Дата_рождения as 'Дата рождения' ,Страна.Название as 'Страна',Владельцы.Город,Владельцы.Улица,Владельцы.Номер_дома as 'Номер дома' from Владельцы join Страна on Владельцы.Страна=Страна.ID_Страны where ФИО= @g", conn)
            command.Parameters.Add("@g", поиск_владельцев.Text)
            Dim adapter As New SqlDataAdapter(command)
            Dim table As New DataTable()
            adapter.Fill(table)
            DGV_Владельцы_просмотр.DataSource = table
        End Using
        If поиск_владельцев.Text = "" Then
            Search_Vlad(поиск_владельцев.Text)
        End If
    End Sub
    'ПОИСК ПО ДАТАМ
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles поиск_по_периоду.Click
        Dim connString As String = ConfigurationManager.ConnectionStrings("ZelZooExpo.My.MySettings.animalBDConnectionString1").ConnectionString
        Using conn As New SqlConnection(connString)
            Dim command As New SqlCommand("select Владельцы.ФИО, Владельцы.Дата_рождения as 'Дата рождения' ,Страна.Название as 'Страна',Владельцы.Город,Владельцы.Улица,Владельцы.Номер_дома as 'Номер дома' from Владельцы join Страна on Владельцы.Страна=Страна.ID_Страны where Владельцы.Дата_рождения between @d1 and @d2 ", conn)
            command.Parameters.Add("@d1", SqlDbType.Date).Value = DTP_D1.Value
            command.Parameters.Add("@d2", SqlDbType.Date).Value = DTP_D2.Value
            Dim adapter As New SqlDataAdapter(command)
            Dim table As New DataTable()
            adapter.Fill(table)
            DGV_Владельцы_просмотр.DataSource = table
        End Using
    End Sub

    'ПОИСК ПАСПОРТ
    Public Sub Search_Pass(valueToSearch1 As String)
        Dim connString As String = ConfigurationManager.ConnectionStrings("ZelZooExpo.My.MySettings.animalBDConnectionString1").ConnectionString
        Using conn As New SqlConnection(connString)
            Dim ser = "select Владельцы.ФИО, Паспорт_животного.Номер_родословной as 'Номер родословной',Паспорт_животного.Кличка,Породы.Название As'Порода',Паспорт_животного.Дата_рождения as 'Дата рождения',Паспорт_животного.Группа,Паспорт_животного.Окрас,Паспорт_животного.Пол,Паспорт_животного.Имя_мамы as 'Имя мамы',Паспорт_животного.Имя_папы as 'Имя папы',Паспорт_животного.Номер_чипа as 'Номер чипа',Паспорт_животного.Дата_имплантации as 'Дата имплантации',Место_размещения_электронного_чипа.Где from Паспорт_животного join Владельцы on Паспорт_животного.Владелец=Владельцы.ID_Владельца join Породы on Паспорт_животного.Порода= Породы.ID_Породы join Место_размещения_электронного_чипа on Паспорт_животного.Место_размещения= Место_размещения_электронного_чипа.ID_Место where concat (ID_Животного,Владельцы.ФИО,Номер_родословной,Кличка,Породы.Название,Группа,Окрас,Пол,Имя_мамы,Имя_папы,Номер_чипа,Дата_имплантации,Место_размещения_электронного_чипа.Где ) like '%" & valueToSearch1 & "%'"
            Dim command As New SqlCommand(ser, conn)
            Dim adapter As New SqlDataAdapter(command)
            Dim table As New DataTable()
            adapter.Fill(table)
            DGV_паспорт_животного.DataSource = table
        End Using
    End Sub
    Private Sub поиск_по_кличкам_животного_Click(sender As Object, e As EventArgs) Handles поиск_по_кличкам_животного.Click
        Dim connString As String = ConfigurationManager.ConnectionStrings("ZelZooExpo.My.MySettings.animalBDConnectionString1").ConnectionString
        Using conn As New SqlConnection(connString)
            Dim command As New SqlCommand("select Владельцы.ФИО, Паспорт_животного.Номер_родословной as 'Номер родословной',Паспорт_животного.Кличка,Породы.Название As'Порода',Паспорт_животного.Дата_рождения as 'Дата рождения',Паспорт_животного.Группа,Паспорт_животного.Окрас,Паспорт_животного.Пол,Паспорт_животного.Имя_мамы as 'Имя мамы',Паспорт_животного.Имя_папы as 'Имя папы',Паспорт_животного.Номер_чипа as 'Номер чипа',Паспорт_животного.Дата_имплантации as 'Дата имплантации',Место_размещения_электронного_чипа.Где from Паспорт_животного join Владельцы on Паспорт_животного.Владелец=Владельцы.ID_Владельца join Породы on Паспорт_животного.Порода= Породы.ID_Породы join Место_размещения_электронного_чипа on Паспорт_животного.Место_размещения= Место_размещения_электронного_чипа.ID_Место where Паспорт_животного.Кличка= @gg", conn)
            command.Parameters.Add("@gg", ComboBox1.Text)
            Dim adapter As New SqlDataAdapter(command)
            Dim table As New DataTable()
            adapter.Fill(table)
            DGV_паспорт_животного.DataSource = table
        End Using
        If ComboBox1.Text = "" Then
            Search_Pass(ComboBox1.Text)
        End If
    End Sub
    ' ПОИСК ПО ДАТАМ ПАСПОРТ
    Private Sub паспорт_дата_рожд_поиск_Click(sender As Object, e As EventArgs) Handles паспорт_дата_рожд_поиск.Click
        Dim connString As String = ConfigurationManager.ConnectionStrings("ZelZooExpo.My.MySettings.animalBDConnectionString1").ConnectionString
        Using conn As New SqlConnection(connString)
            Dim command As New SqlCommand("select Владельцы.ФИО, Паспорт_животного.Номер_родословной as 'Номер родословной',Паспорт_животного.Кличка,Породы.Название As'Порода',Паспорт_животного.Дата_рождения as 'Дата рождения',Паспорт_животного.Группа,Паспорт_животного.Окрас,Паспорт_животного.Пол,Паспорт_животного.Имя_мамы as 'Имя мамы',Паспорт_животного.Имя_папы as 'Имя папы',Паспорт_животного.Номер_чипа as 'Номер чипа',Паспорт_животного.Дата_имплантации as 'Дата имплантации',Место_размещения_электронного_чипа.Где from Паспорт_животного join Владельцы on Паспорт_животного.Владелец=Владельцы.ID_Владельца join Породы on Паспорт_животного.Порода= Породы.ID_Породы join Место_размещения_электронного_чипа on Паспорт_животного.Место_размещения= Место_размещения_электронного_чипа.ID_Место where Паспорт_животного.Дата_рождения  between @d3 and @d4 ", conn)
            command.Parameters.Add("@d3", SqlDbType.Date).Value = DTP_паспорт_ДатаРОЖД_НАЧАЛО.Value
            command.Parameters.Add("@d4", SqlDbType.Date).Value = DTP_паспорт_ДатаРОЖД_КОНЕЦ.Value
            Dim adapter As New SqlDataAdapter(command)
            Dim table As New DataTable()
            adapter.Fill(table)
            DGV_паспорт_животного.DataSource = table
        End Using
    End Sub
    Private Sub паспорт_дата_имплант_поиск_Click(sender As Object, e As EventArgs) Handles паспорт_дата_имплант_поиск.Click
        Dim connString As String = ConfigurationManager.ConnectionStrings("ZelZooExpo.My.MySettings.animalBDConnectionString1").ConnectionString
        Using conn As New SqlConnection(connString)
            Dim command As New SqlCommand("select Владельцы.ФИО, Паспорт_животного.Номер_родословной as 'Номер родословной',Паспорт_животного.Кличка,Породы.Название As'Порода',Паспорт_животного.Дата_рождения as 'Дата рождения',Паспорт_животного.Группа,Паспорт_животного.Окрас,Паспорт_животного.Пол,Паспорт_животного.Имя_мамы as 'Имя мамы',Паспорт_животного.Имя_папы as 'Имя папы',Паспорт_животного.Номер_чипа as 'Номер чипа',Паспорт_животного.Дата_имплантации as 'Дата имплантации',Место_размещения_электронного_чипа.Где from Паспорт_животного join Владельцы on Паспорт_животного.Владелец=Владельцы.ID_Владельца join Породы on Паспорт_животного.Порода= Породы.ID_Породы join Место_размещения_электронного_чипа on Паспорт_животного.Место_размещения= Место_размещения_электронного_чипа.ID_Место where Паспорт_животного.Дата_имплантации  between @d5 and @d6 ", conn)
            command.Parameters.Add("@d5", SqlDbType.Date).Value = DTP_паспорт_имплант1.Value
            command.Parameters.Add("@d6", SqlDbType.Date).Value = DTP_паспорт_имплант2.Value
            Dim adapter As New SqlDataAdapter(command)
            Dim table As New DataTable()
            adapter.Fill(table)
            DGV_паспорт_животного.DataSource = table
        End Using
    End Sub
    'ПОИСК ВЕТ
    Public Sub Search_Vet(valueToSearch2 As String)
        Dim connString As String = ConfigurationManager.ConnectionStrings("ZelZooExpo.My.MySettings.animalBDConnectionString1").ConnectionString
        Using conn As New SqlConnection(connString)
            Dim ser = "Select Паспорт_животного.Кличка,Прививка.Название_прививки as'Название прививки',ОтчегоПрививка.Прививка_от as'Прививка от',Ветеринарное_свидетельство.Дата_принятия as'Дата принятия',Ветеринарное_свидетельство.Срок_действия_прививки as'Срок дейстивия прививки',Ветеринарное_свидетельство.Имя_картинки as'Имя картинки' ,Ветеринарное_свидетельство.Формат_картинки as'Формат картинки' from Ветеринарное_свидетельство join Паспорт_животного on  Ветеринарное_свидетельство.Имя_животного=Паспорт_животного.ID_Животного join Прививка on Ветеринарное_свидетельство.Наименование_прививки=Прививка.ID_прив join ОтчегоПрививка on Ветеринарное_свидетельство.Привика_от=ОтчегоПрививка.ID_отЧего where concat (Паспорт_животного.Кличка,Прививка.Название_прививки,ОтчегоПрививка.Прививка_от,Ветеринарное_свидетельство.Дата_принятия,Ветеринарное_свидетельство.Срок_действия_прививки,Ветеринарное_свидетельство.Имя_картинки ,Ветеринарное_свидетельство.Формат_картинки) like '%" & valueToSearch2 & "%'"
            Dim command As New SqlCommand(ser, conn)
            Dim adapter As New SqlDataAdapter(command)
            Dim table As New DataTable()
            adapter.Fill(table)
            DGV_ветеринарное_свидетельство.DataSource = table
        End Using
    End Sub

    Private Sub поиск_по_кличкам_животных_вет_свид_Click(sender As Object, e As EventArgs) Handles поиск_по_кличкам_животных_вет_свид.Click
        Dim connString As String = ConfigurationManager.ConnectionStrings("ZelZooExpo.My.MySettings.animalBDConnectionString1").ConnectionString
        Using conn As New SqlConnection(connString)
            Dim command As New SqlCommand("Select Паспорт_животного.Кличка,Прививка.Название_прививки as'Название прививки',ОтчегоПрививка.Прививка_от as'Прививка от',Ветеринарное_свидетельство.Дата_принятия as'Дата принятия',Ветеринарное_свидетельство.Срок_действия_прививки as'Срок дейстивия прививки',Ветеринарное_свидетельство.Имя_картинки as'Имя картинки' ,Ветеринарное_свидетельство.Формат_картинки as'Формат картинки' from Ветеринарное_свидетельство join Паспорт_животного on  Ветеринарное_свидетельство.Имя_животного=Паспорт_животного.ID_Животного join Прививка on Ветеринарное_свидетельство.Наименование_прививки=Прививка.ID_прив join ОтчегоПрививка on Ветеринарное_свидетельство.Привика_от=ОтчегоПрививка.ID_отЧего where Паспорт_животного.Кличка=@ggg", conn)
            command.Parameters.Add("@ggg", ComboBox2.Text)
            Dim adapter As New SqlDataAdapter(command)
            Dim table As New DataTable()
            adapter.Fill(table)
            DGV_ветеринарное_свидетельство.DataSource = table
        End Using
        If ComboBox2.Text = "" Then
            Search_Vet(ComboBox2.Text)
        End If
    End Sub
    ' ПОИСК ПО ДАТАМ ВЕТ
    Private Sub поиск_дата_прин_Click(sender As Object, e As EventArgs) Handles поиск_дата_прин.Click
        Dim connString As String = ConfigurationManager.ConnectionStrings("ZelZooExpo.My.MySettings.animalBDConnectionString1").ConnectionString
        Using conn As New SqlConnection(connString)
            Dim command As New SqlCommand("Select Паспорт_животного.Кличка,Прививка.Название_прививки as'Название прививки',ОтчегоПрививка.Прививка_от as'Прививка от',Ветеринарное_свидетельство.Дата_принятия as'Дата принятия',Ветеринарное_свидетельство.Срок_действия_прививки as'Срок дейстивия прививки',Ветеринарное_свидетельство.Имя_картинки as'Имя картинки' ,Ветеринарное_свидетельство.Формат_картинки as'Формат картинки' from Ветеринарное_свидетельство join Паспорт_животного on  Ветеринарное_свидетельство.Имя_животного=Паспорт_животного.ID_Животного join Прививка on Ветеринарное_свидетельство.Наименование_прививки=Прививка.ID_прив join ОтчегоПрививка on Ветеринарное_свидетельство.Привика_от=ОтчегоПрививка.ID_отЧего where Ветеринарное_свидетельство.Дата_принятия between @d7 and @d8 ", conn)
            command.Parameters.Add("@d7", SqlDbType.Date).Value = DTP_вет_дата_принятия1.Value
            command.Parameters.Add("@d8", SqlDbType.Date).Value = DTP_вет_дата_принятия2.Value
            Dim adapter As New SqlDataAdapter(command)
            Dim table As New DataTable()
            adapter.Fill(table)
            DGV_ветеринарное_свидетельство.DataSource = table
        End Using
    End Sub
    Private Sub поиск_срок_Click(sender As Object, e As EventArgs) Handles поиск_срок.Click
        Dim connString As String = ConfigurationManager.ConnectionStrings("ZelZooExpo.My.MySettings.animalBDConnectionString1").ConnectionString
        Using conn As New SqlConnection(connString)
            Dim command As New SqlCommand("Select Паспорт_животного.Кличка,Прививка.Название_прививки as'Название прививки',ОтчегоПрививка.Прививка_от as'Прививка от',Ветеринарное_свидетельство.Дата_принятия as'Дата принятия',Ветеринарное_свидетельство.Срок_действия_прививки as'Срок дейстивия прививки',Ветеринарное_свидетельство.Имя_картинки as'Имя картинки' ,Ветеринарное_свидетельство.Формат_картинки as'Формат картинки' from Ветеринарное_свидетельство join Паспорт_животного on  Ветеринарное_свидетельство.Имя_животного=Паспорт_животного.ID_Животного join Прививка on Ветеринарное_свидетельство.Наименование_прививки=Прививка.ID_прив join ОтчегоПрививка on Ветеринарное_свидетельство.Привика_от=ОтчегоПрививка.ID_отЧего where Ветеринарное_свидетельство.Срок_действия_прививки between @d9 and @d10 ", conn)
            command.Parameters.Add("@d9", SqlDbType.Date).Value = DTP_вет_срок1.Value
            command.Parameters.Add("@d10", SqlDbType.Date).Value = DTP_вет_срок2.Value
            Dim adapter As New SqlDataAdapter(command)
            Dim table As New DataTable()
            adapter.Fill(table)
            DGV_ветеринарное_свидетельство.DataSource = table
        End Using
    End Sub

    'Nagrad
    Public Sub Search_nag(valueToSearch3 As String)
        Dim connString As String = ConfigurationManager.ConnectionStrings("ZelZooExpo.My.MySettings.animalBDConnectionString1").ConnectionString
        Using conn As New SqlConnection(connString)
            Dim ser = "Select Паспорт_животного.Кличка, Награды.Наименование, Получение_награды.Дата_получения as'Дата получения',Получение_награды.Прошлая_дата_получения as'Прошлая дата получения' from Получение_награды join Паспорт_животного on Получение_награды.Кличка_животного=Паспорт_животного.ID_Животного join Награды on Получение_награды.Наименование_награды= Награды.ID_Награды where concat (Паспорт_животного.Кличка, Награды.Наименование, Получение_награды.Дата_получения,Получение_награды.Прошлая_дата_получения) like '%" & valueToSearch3 & "%'"
            Dim command As New SqlCommand(ser, conn)
            Dim adapter As New SqlDataAdapter(command)
            Dim table As New DataTable()
            adapter.Fill(table)
            DGV_Награды.DataSource = table
        End Using
    End Sub
    Private Sub принять_поиск_по_кличкам_награды_Click(sender As Object, e As EventArgs) Handles принять_поиск_по_кличкам_награды.Click
        Dim connString As String = ConfigurationManager.ConnectionStrings("ZelZooExpo.My.MySettings.animalBDConnectionString1").ConnectionString
        Using conn As New SqlConnection(connString)
            Dim command As New SqlCommand("Select Паспорт_животного.Кличка, Награды.Наименование, Получение_награды.Дата_получения as'Дата получения',Получение_награды.Прошлая_дата_получения as'Прошлая дата получения' from Получение_награды join Паспорт_животного on Получение_награды.Кличка_животного=Паспорт_животного.ID_Животного join Награды on Получение_награды.Наименование_награды= Награды.ID_Награды where Паспорт_животного.Кличка=@gggg", conn)
            command.Parameters.Add("@gggg", ComboBox3.Text)
            Dim adapter As New SqlDataAdapter(command)
            Dim table As New DataTable()
            adapter.Fill(table)
            DGV_Награды.DataSource = table
        End Using
        If ComboBox3.Text = "" Then
            Search_nag(ComboBox3.Text)
        End If
    End Sub
    ' ПОИСК ПО ДАТАМ наград
    Private Sub Поиск_получ_Click(sender As Object, e As EventArgs) Handles Поиск_получ.Click
        Dim connString As String = ConfigurationManager.ConnectionStrings("ZelZooExpo.My.MySettings.animalBDConnectionString1").ConnectionString
        Using conn As New SqlConnection(connString)
            Dim command As New SqlCommand("Select Паспорт_животного.Кличка, Награды.Наименование, Получение_награды.Дата_получения as'Дата получения',Получение_награды.Прошлая_дата_получения as'Прошлая дата получения' from Получение_награды join Паспорт_животного on Получение_награды.Кличка_животного=Паспорт_животного.ID_Животного join Награды on Получение_награды.Наименование_награды= Награды.ID_Награды where Получение_награды.Дата_получения between @d11 and @d12 ", conn)
            command.Parameters.Add("@d11", SqlDbType.Date).Value = DTP_получ1.Value
            command.Parameters.Add("@d12", SqlDbType.Date).Value = DTP_получ2.Value
            Dim adapter As New SqlDataAdapter(command)
            Dim table As New DataTable()
            adapter.Fill(table)
            DGV_Награды.DataSource = table
        End Using
    End Sub

    Private Sub поиск_прош_Click(sender As Object, e As EventArgs) Handles поиск_прош.Click
        Dim connString As String = ConfigurationManager.ConnectionStrings("ZelZooExpo.My.MySettings.animalBDConnectionString1").ConnectionString
        Using conn As New SqlConnection(connString)
            Dim command As New SqlCommand("Select Паспорт_животного.Кличка, Награды.Наименование, Получение_награды.Дата_получения as'Дата получения',Получение_награды.Прошлая_дата_получения as'Прошлая дата получения' from Получение_награды join Паспорт_животного on Получение_награды.Кличка_животного=Паспорт_животного.ID_Животного join Награды on Получение_награды.Наименование_награды= Награды.ID_Награды where Получение_награды.Прошлая_дата_получения between @d13 and @d14 ", conn)
            command.Parameters.Add("@d13", SqlDbType.Date).Value = DTP_прошлое1.Value
            command.Parameters.Add("@d14", SqlDbType.Date).Value = DTP_прошлое2.Value
            Dim adapter As New SqlDataAdapter(command)
            Dim table As New DataTable()
            adapter.Fill(table)
            DGV_Награды.DataSource = table
        End Using
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles report_button.Click
        Dim i As Integer
        Dim j As Integer

        xlApp = New Microsoft.Office.Interop.Excel.Application
        xlApp.Visible = True
        xlWorkBook = xlApp.Workbooks.Add(misValue)
        xlWorkSheet = xlWorkBook.Sheets("Лист1")

        For i = 0 To DGV_Владельцы_просмотр.RowCount - 1

            For j = 0 To DGV_Владельцы_просмотр.ColumnCount - 1
                For k As Integer = 1 To DGV_Владельцы_просмотр.Columns.Count

                    xlWorkSheet.Cells(1, k) = DGV_Владельцы_просмотр.Columns(k - 1).HeaderText
                    xlWorkSheet.Cells(i + 2, j + 1) = DGV_Владельцы_просмотр(j, i).Value


                Next
            Next
        Next

        xlWorkSheet.SaveAs("D:\Владельцы.xlsx")
        xlWorkBook.Close()
        xlApp.Quit()

        ReleaseObject(xlApp)
        ReleaseObject(xlWorkBook)
        ReleaseObject(xlWorkSheet)

        MsgBox("Ваш файл сохранен в D:\Владельцы.xlsx")

    End Sub
    Private Sub ReleaseObject(ByVal obj As Object)
        'процедура выгрузки объектов из памяти
        Try
            System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
            obj = Nothing
        Catch ex As Exception
            obj = Nothing
        Finally
            GC.Collect()
        End Try
    End Sub

    Private Sub report_Button2_Click(sender As Object, e As EventArgs) Handles report_Button2.Click
        Dim i As Integer
        Dim j As Integer

        xlApp = New Microsoft.Office.Interop.Excel.Application
        xlApp.Visible = True
        xlWorkBook = xlApp.Workbooks.Add(misValue)
        xlWorkSheet = xlWorkBook.Sheets("Лист1")

        For i = 0 To DGV_паспорт_животного.RowCount - 1

            For j = 0 To DGV_паспорт_животного.ColumnCount - 1
                For k As Integer = 1 To DGV_паспорт_животного.Columns.Count

                    xlWorkSheet.Cells(1, k) = DGV_паспорт_животного.Columns(k - 1).HeaderText
                    xlWorkSheet.Cells(i + 2, j + 1) = DGV_паспорт_животного(j, i).Value


                Next
            Next
        Next

        xlWorkSheet.SaveAs("D:\Паспорт.xlsx")
        xlWorkBook.Close()
        xlApp.Quit()

        ReleaseObject(xlApp)
        ReleaseObject(xlWorkBook)
        ReleaseObject(xlWorkSheet)

        MsgBox("Ваш файл сохранен в D:\Паспорт.xlsx")
    End Sub

    Private Sub report_button3_Click(sender As Object, e As EventArgs) Handles report_button3.Click
        Dim i As Integer
        Dim j As Integer

        xlApp = New Microsoft.Office.Interop.Excel.Application
        xlApp.Visible = True
        xlWorkBook = xlApp.Workbooks.Add(misValue)
        xlWorkSheet = xlWorkBook.Sheets("Лист1")

        For i = 0 To DGV_ветеринарное_свидетельство.RowCount - 1

            For j = 0 To DGV_ветеринарное_свидетельство.ColumnCount - 1
                For k As Integer = 1 To DGV_ветеринарное_свидетельство.Columns.Count

                    xlWorkSheet.Cells(1, k) = DGV_ветеринарное_свидетельство.Columns(k - 1).HeaderText
                    xlWorkSheet.Cells(i + 2, j + 1) = DGV_ветеринарное_свидетельство(j, i).Value


                Next
            Next
        Next

        xlWorkSheet.SaveAs("D:\ветеринарное_свидетельство.xlsx")
        xlWorkBook.Close()
        xlApp.Quit()

        ReleaseObject(xlApp)
        ReleaseObject(xlWorkBook)
        ReleaseObject(xlWorkSheet)

        MsgBox("Ваш файл сохранен в D:\ветеринарное_свидетельство.xlsx")
    End Sub

    Private Sub report_button4_Click(sender As Object, e As EventArgs) Handles report_button4.Click
        Dim i As Integer
        Dim j As Integer

        xlApp = New Microsoft.Office.Interop.Excel.Application
        xlApp.Visible = True
        xlWorkBook = xlApp.Workbooks.Add(misValue)
        xlWorkSheet = xlWorkBook.Sheets("Лист1")

        For i = 0 To DGV_ветеринарное_свидетельство.RowCount - 1

            For j = 0 To DGV_Награды.ColumnCount - 1
                For k As Integer = 1 To DGV_Награды.Columns.Count

                    xlWorkSheet.Cells(1, k) = DGV_Награды.Columns(k - 1).HeaderText
                    xlWorkSheet.Cells(i + 2, j + 1) = DGV_Награды(j, i).Value


                Next
            Next
        Next

        xlWorkSheet.SaveAs("D:\Награды.xlsx")
        xlWorkBook.Close()
        xlApp.Quit()

        ReleaseObject(xlApp)
        ReleaseObject(xlWorkBook)
        ReleaseObject(xlWorkSheet)

        MsgBox("Ваш файл сохранен в D:\Награды.xlsx")
    End Sub

    Private Sub prosmotr_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.F1 Then Help.ShowHelp(Me, "ZelZooExpo_Info.chm")
    End Sub

    Private Sub report2_Click(sender As Object, e As EventArgs) Handles report2.Click
        Dim i As Integer
        Dim j As Integer

        xlApp = New Microsoft.Office.Interop.Excel.Application
        xlApp.Visible = True
        xlWorkBook = xlApp.Workbooks.Add(misValue)
        xlWorkSheet = xlWorkBook.Sheets("Лист1")

        For i = 0 To DataGridView2.RowCount - 1

            For j = 0 To DataGridView2.ColumnCount - 1
                For k As Integer = 1 To DataGridView2.Columns.Count

                    xlWorkSheet.Cells(1, k) = DataGridView2.Columns(k - 1).HeaderText
                    xlWorkSheet.Cells(i + 2, j + 1) = DataGridView2(j, i).Value


                Next
            Next
        Next

        xlWorkSheet.SaveAs("D:\Награды_статистика.xlsx")
        xlWorkBook.Close()
        xlApp.Quit()

        ReleaseObject(xlApp)
        ReleaseObject(xlWorkBook)
        ReleaseObject(xlWorkSheet)

        MsgBox("Ваш файл сохранен в D:\Награды_статистика.xlsx")
    End Sub

    Private Sub report1_Click(sender As Object, e As EventArgs) Handles report1.Click
        Dim i As Integer
        Dim j As Integer

        xlApp = New Microsoft.Office.Interop.Excel.Application
        xlApp.Visible = True
        xlWorkBook = xlApp.Workbooks.Add(misValue)
        xlWorkSheet = xlWorkBook.Sheets("Лист1")

        For i = 0 To DataGridView1.RowCount - 1

            For j = 0 To DataGridView1.ColumnCount - 1
                For k As Integer = 1 To DataGridView1.Columns.Count

                    xlWorkSheet.Cells(1, k) = DataGridView1.Columns(k - 1).HeaderText
                    xlWorkSheet.Cells(i + 2, j + 1) = DataGridView1(j, i).Value


                Next
            Next
        Next

        xlWorkSheet.SaveAs("D:\Вакцина.xlsx")
        xlWorkBook.Close()
        xlApp.Quit()

        ReleaseObject(xlApp)
        ReleaseObject(xlWorkBook)
        ReleaseObject(xlWorkSheet)

        MsgBox("Ваш файл сохранен в D:\Вакцина.xlsx")
    End Sub
End Class