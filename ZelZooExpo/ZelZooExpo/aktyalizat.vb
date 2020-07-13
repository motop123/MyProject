Imports System.Configuration
Imports System.Data
Imports System.Data.SqlClient

Public Class aktyalizat

    Private Sub Vixod_Click(sender As Object, e As EventArgs) Handles Vixod.Click
        Close()
    End Sub

    Private Sub Pasport_Click(sender As Object, e As EventArgs) Handles Pasport.Click

    End Sub

    Private Sub Poluch_Nagrad_Click(sender As Object, e As EventArgs) Handles Poluch_Nagrad.Click

    End Sub

    Private Sub GroupBox7_add_Enter(sender As Object, e As EventArgs) Handles GroupBox7_add.Enter

    End Sub

    Private Sub aktyalizat_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: данная строка кода позволяет загрузить данные в таблицу "AnimalBDDataSet.Паспорт_животного". При необходимости она может быть перемещена или удалена.
        Me.Паспорт_животногоTableAdapter.Fill(Me.AnimalBDDataSet.Паспорт_животного)
        'TODO: данная строка кода позволяет загрузить данные в таблицу "AnimalBDDataSet.Владельцы". При необходимости она может быть перемещена или удалена.
        Me.ВладельцыTableAdapter.Fill(Me.AnimalBDDataSet.Владельцы)
        'TODO: данная строка кода позволяет загрузить данные в таблицу "AnimalBDDataSet.Породы". При необходимости она может быть перемещена или удалена.
        Me.ПородыTableAdapter.Fill(Me.AnimalBDDataSet.Породы)
        'TODO: данная строка кода позволяет загрузить данные в таблицу "AnimalBDDataSet.Место_размещения_электронного_чипа". При необходимости она может быть перемещена или удалена.
        Me.Место_размещения_электронного_чипаTableAdapter.Fill(Me.AnimalBDDataSet.Место_размещения_электронного_чипа)
        'TODO: данная строка кода позволяет загрузить данные в таблицу "AnimalBDDataSet.Прививка". При необходимости она может быть перемещена или удалена.
        Me.ПрививкаTableAdapter.Fill(Me.AnimalBDDataSet.Прививка)
        'TODO: данная строка кода позволяет загрузить данные в таблицу "AnimalBDDataSet.ОтчегоПрививка". При необходимости она может быть перемещена или удалена.
        Me.ОтчегоПрививкаTableAdapter.Fill(Me.AnimalBDDataSet.ОтчегоПрививка)
        'TODO: данная строка кода позволяет загрузить данные в таблицу "AnimalBDDataSet.Награды". При необходимости она может быть перемещена или удалена.
        Me.НаградыTableAdapter.Fill(Me.AnimalBDDataSet.Награды)
        'TODO: данная строка кода позволяет загрузить данные в таблицу "AnimalBDDataSet.Страна". При необходимости она может быть перемещена или удалена.
        Me.СтранаTableAdapter.Fill(Me.AnimalBDDataSet.Страна)



        DGV_Страна_актул.DataSource = Getdatalist()
        DGV_Награды_актул.DataSource = Getdatalist1()
        DGV_отчего_актул.DataSource = Getdatalist2()
        DGV_прививки_актул.DataSource = Getdatalist3()
        DGV_место_размещ_актул.DataSource = Getdatalist4()
        DGV_породы_актул.DataSource = Getdatalist5()
        DGV_Владельцы_актул.DataSource = Getdatalist6()
        DGV_паспорт_животного_актул.DataSource = Getdatalist7()
        DGV_получ_награды_актул.DataSource = Getdatalist8()
        DGV_ветеринарное_свидетельство.DataSource = Getdatalist9()
        KeyPreview = True
    End Sub
    Private Sub save_Click(sender As Object, e As EventArgs) Handles save.Click
        MessageBox.Show("Внимание приложение будет презапущено")
        Application.Restart()
    End Sub
    Private Sub Vladelti_Click(sender As Object, e As EventArgs) Handles Vladelti.Click
        MessageBox.Show("Внимание нажмите кнопку СОХРАНИТЬ")
    End Sub

    Private Sub Добавить_страну_Click(sender As Object, e As EventArgs) Handles Добавить_страну.Click
        If id_страны_доб.Text <> "" And название_страны_доб.Text <> "" Then
            Dim connString As String = ConfigurationManager.ConnectionStrings("ZelZooExpo.My.MySettings.animalBDConnectionString1").ConnectionString
            Using conn As New SqlConnection(connString)
                Dim query = "INSERT INTO Страна (ID_Страны,Название) VALUES(@id_str, @NazvStr)"
                Using cmd As New SqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@id_str", id_страны_доб.Text)
                    cmd.Parameters.AddWithValue("@NazvStr", название_страны_доб.Text)
                    conn.Open()
                    cmd.ExecuteNonQuery()
                    conn.Close()
                End Using
            End Using
            id_страны_доб.Clear() : название_страны_доб.Clear() : DGV_Страна_актул.DataSource = Getdatalist()
        Else
            MessageBox.Show("Заполните поле(я) данными")
        End If

    End Sub

    Private Sub Удалить_страну_Click(sender As Object, e As EventArgs) Handles Удалить_страну.Click
        If название_страны_удл.Text <> "" Then
            Dim connString As String = ConfigurationManager.ConnectionStrings("ZelZooExpo.My.MySettings.animalBDConnectionString1").ConnectionString
            Using conn As New SqlConnection(connString)
                Dim query = "delete from Страна where Название = @NazvStr_d"
                Using cmd As New SqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@NazvStr_d", название_страны_удл.Text)
                    conn.Open()
                    cmd.ExecuteNonQuery()
                    conn.Close()
                End Using
            End Using
            название_страны_удл.Clear() : DGV_Страна_актул.DataSource = Getdatalist()
        Else
            MessageBox.Show("Заполните поле(я) данными")
        End If
    End Sub


    Private Sub Изменить_страну_Click(sender As Object, e As EventArgs) Handles Изменить_страну.Click
        If id_страны_обнв.Text <> "" And название_страны_обнв.Text <> "" Then
            Dim connString As String = ConfigurationManager.ConnectionStrings("ZelZooExpo.My.MySettings.animalBDConnectionString1").ConnectionString
            Using conn As New SqlConnection(connString)
                Dim query = "update Страна set Название=@NazvStr_up where ID_Страны= @id_str_up"
                Using cmd As New SqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@id_str_up", id_страны_обнв.Text)
                    cmd.Parameters.AddWithValue("@NazvStr_up", название_страны_обнв.Text)
                    conn.Open()
                    cmd.ExecuteNonQuery()
                    conn.Close()
                End Using
            End Using
            id_страны_обнв.Clear() : название_страны_обнв.Clear() : DGV_Страна_актул.DataSource = Getdatalist()
        Else
            MessageBox.Show("Заполните поле(я) данными")
        End If
    End Sub
    Private Function Getdatalist() As DataTable
        Dim dt As New DataTable
        Dim connString As String = ConfigurationManager.ConnectionStrings("ZelZooExpo.My.MySettings.animalBDConnectionString1").ConnectionString
        Using conn As New SqlConnection(connString)
            Using cmd As New SqlCommand("select * from Страна", conn)
                conn.Open() : Dim reader As SqlDataReader = cmd.ExecuteReader() : dt.Load(reader)
            End Using
        End Using
        Return dt
    End Function

    Private Sub Добавить_награду_Click(sender As Object, e As EventArgs) Handles Добавить_награду.Click
        If id_награды_доб.Text <> "" And наименование_награды_доб.Text <> "" Then
            Dim connString As String = ConfigurationManager.ConnectionStrings("ZelZooExpo.My.MySettings.animalBDConnectionString1").ConnectionString
            Using conn As New SqlConnection(connString)
                Dim query = "INSERT INTO Награды (ID_Награды,Наименование,Количество_животных_получивших_награду) VALUES(@id_nag, @NazvNag, @kolVoNag)"
                Using cmd As New SqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@id_nag", id_награды_доб.Text)
                    cmd.Parameters.AddWithValue("@NazvNag", наименование_награды_доб.Text)
                    cmd.Parameters.AddWithValue("@kolVoNag", колживнаг_доб.Text)
                    conn.Open()
                    cmd.ExecuteNonQuery()
                    conn.Close()
                End Using
            End Using
            колживнаг_доб.Clear() : id_награды_доб.Clear() : наименование_награды_доб.Clear() : DGV_Награды_актул.DataSource = Getdatalist1()
        Else
            MessageBox.Show("Заполните поле(я) данными")
        End If
    End Sub

    Private Sub Удалить_награду_Click(sender As Object, e As EventArgs) Handles Удалить_награду.Click
        If наименование_награды_дел.Text <> "" Then
            Dim connString As String = ConfigurationManager.ConnectionStrings("ZelZooExpo.My.MySettings.animalBDConnectionString1").ConnectionString
            Using conn As New SqlConnection(connString)
                Dim query = "delete from Награды where Наименование = @NazvNag_d"
                Using cmd As New SqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@NazvNag_d", наименование_награды_дел.Text)
                    conn.Open()
                    cmd.ExecuteNonQuery()
                    conn.Close()
                End Using
            End Using
            наименование_награды_дел.Clear() : DGV_Награды_актул.DataSource = Getdatalist1()
        Else
            MessageBox.Show("Заполните поле(я) данными")
        End If

    End Sub

    Private Sub Изменить_награду_Click(sender As Object, e As EventArgs) Handles Изменить_награду.Click
        If id_награды_обнв.Text <> "" And наименование_награды_обнв.Text <> "" Then
            Dim connString As String = ConfigurationManager.ConnectionStrings("ZelZooExpo.My.MySettings.animalBDConnectionString1").ConnectionString
            Using conn As New SqlConnection(connString)
                Dim query = "update Награды set Наименование=@NazvNag_up, Количество_животных_получивших_награду=@kolvonag2 where ID_Награды= @id_nag_up"
                Using cmd As New SqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@id_nag_up", id_награды_обнв.Text)
                    cmd.Parameters.AddWithValue("@NazvNag_up", наименование_награды_обнв.Text)
                    cmd.Parameters.AddWithValue("@kolvonag2", колживнаг_обнов.Text)
                    conn.Open()
                    cmd.ExecuteNonQuery()
                    conn.Close()
                End Using
            End Using
            колживнаг_обнов.Clear() : id_награды_обнв.Clear() : наименование_награды_обнв.Clear() : DGV_Награды_актул.DataSource = Getdatalist1()
        Else
            MessageBox.Show("Заполните поле(я) данными")
        End If

    End Sub
    Private Function Getdatalist1() As DataTable
        Dim dt As New DataTable
        Dim connString As String = ConfigurationManager.ConnectionStrings("ZelZooExpo.My.MySettings.animalBDConnectionString1").ConnectionString
        Using conn As New SqlConnection(connString)
            Using cmd As New SqlCommand("select * from Награды", conn)
                conn.Open() : Dim reader As SqlDataReader = cmd.ExecuteReader() : dt.Load(reader)
            End Using
        End Using
        Return dt
    End Function

    Private Sub Добавить_отчего_прививка_Click(sender As Object, e As EventArgs) Handles Добавить_отчего_прививка.Click
        If id_отчего_прив_доб.Text <> "" And прививка_от_доб.Text <> "" Then
            Dim connString As String = ConfigurationManager.ConnectionStrings("ZelZooExpo.My.MySettings.animalBDConnectionString1").ConnectionString
            Using conn As New SqlConnection(connString)
                Dim query = "INSERT INTO ОтчегоПрививка (ID_отЧего,Прививка_от) VALUES(@id_otchego, @prirviv_ot)"
                Using cmd As New SqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@id_otchego", id_отчего_прив_доб.Text)
                    cmd.Parameters.AddWithValue("@prirviv_ot", прививка_от_доб.Text)
                    conn.Open()
                    cmd.ExecuteNonQuery()
                    conn.Close()
                End Using
            End Using
            id_отчего_прив_доб.Clear() : прививка_от_доб.Clear() : DGV_отчего_актул.DataSource = Getdatalist2()
        Else
            MessageBox.Show("Заполните поле(я) данными")
        End If

    End Sub

    Private Sub Удалить_отчего_прививка_Click(sender As Object, e As EventArgs) Handles Удалить_отчего_прививка.Click
        If прививка_от_дел.Text <> "" Then
            Dim connString As String = ConfigurationManager.ConnectionStrings("ZelZooExpo.My.MySettings.animalBDConnectionString1").ConnectionString
            Using conn As New SqlConnection(connString)
                Dim query = "delete from ОтчегоПрививка where Прививка_от = @prirviv_ot_d"
                Using cmd As New SqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@prirviv_ot_d", прививка_от_дел.Text)
                    conn.Open()
                    cmd.ExecuteNonQuery()
                    conn.Close()
                End Using
            End Using
            прививка_от_дел.Clear() : DGV_отчего_актул.DataSource = Getdatalist2()
        Else
            MessageBox.Show("Заполните поле(я) данными")
        End If

    End Sub

    Private Sub Изменить_отчего_прививка_Click(sender As Object, e As EventArgs) Handles Изменить_отчего_прививка.Click
        If id_отчего_прив_обнв.Text <> "" And прививка_от_обнв.Text <> "" Then
            Dim connString As String = ConfigurationManager.ConnectionStrings("ZelZooExpo.My.MySettings.animalBDConnectionString1").ConnectionString
            Using conn As New SqlConnection(connString)
                Dim query = "update ОтчегоПрививка set Прививка_от=@prirviv_ot_up where ID_отЧего= @id_otchego_up"
                Using cmd As New SqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@id_otchego_up", id_отчего_прив_обнв.Text)
                    cmd.Parameters.AddWithValue("@prirviv_ot_up", прививка_от_обнв.Text)
                    conn.Open()
                    cmd.ExecuteNonQuery()
                    conn.Close()
                End Using
            End Using
            id_отчего_прив_обнв.Clear() : прививка_от_обнв.Clear() : DGV_отчего_актул.DataSource = Getdatalist2()
        Else
            MessageBox.Show("Заполните поле(я) данными")
        End If
    End Sub
    Private Function Getdatalist2() As DataTable
        Dim dt As New DataTable
        Dim connString As String = ConfigurationManager.ConnectionStrings("ZelZooExpo.My.MySettings.animalBDConnectionString1").ConnectionString
        Using conn As New SqlConnection(connString)
            Using cmd As New SqlCommand("select * from ОтчегоПрививка", conn)
                conn.Open()
                Dim reader As SqlDataReader = cmd.ExecuteReader()
                dt.Load(reader)
            End Using
        End Using
        Return dt
    End Function

    Private Sub Добавить_прививку_Click(sender As Object, e As EventArgs) Handles Добавить_прививку.Click
        If id_прививки_доб.Text <> "" And наименование_прививки_доб.Text <> "" And страна_производитель_доб.Text <> "" Then
            Dim connString As String = ConfigurationManager.ConnectionStrings("ZelZooExpo.My.MySettings.animalBDConnectionString1").ConnectionString
            Using conn As New SqlConnection(connString)
                Dim query = "INSERT INTO Прививка (ID_прив,Название_прививки,Страна_производитель,Количество_привитых) VALUES(@ID_priv_ad, @nazvpriv_ad,@strana_proizv_ad,@kolovopriv)"
                Using cmd As New SqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@ID_priv_ad", id_прививки_доб.Text)
                    cmd.Parameters.AddWithValue("@nazvpriv_ad", наименование_прививки_доб.Text)
                    cmd.Parameters.AddWithValue("@strana_proizv_ad", страна_производитель_доб.Text)
                    cmd.Parameters.AddWithValue("@kolovopriv", колвоприв_доб.Text)
                    conn.Open()
                    cmd.ExecuteNonQuery()
                    conn.Close()
                End Using
            End Using
            колвоприв_доб.Clear() : id_прививки_доб.Clear() : наименование_прививки_доб.Clear() : страна_производитель_доб.Clear() : DGV_прививки_актул.DataSource = Getdatalist3()
        Else
            MessageBox.Show("Заполните поле(я) данными")
        End If
    End Sub

    Private Sub Удалить_прививку_Click(sender As Object, e As EventArgs) Handles Удалить_прививку.Click
        If наименование_прививки_дел.Text <> "" Then
            Dim connString As String = ConfigurationManager.ConnectionStrings("ZelZooExpo.My.MySettings.animalBDConnectionString1").ConnectionString
            Using conn As New SqlConnection(connString)
                Dim query = "delete from Прививка where Название_прививки = @nazvpriv_d"
                Using cmd As New SqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@nazvpriv_d", наименование_прививки_дел.Text)
                    conn.Open()
                    cmd.ExecuteNonQuery()
                    conn.Close()
                End Using
            End Using
            наименование_прививки_дел.Clear() : DGV_прививки_актул.DataSource = Getdatalist3()
        Else
            MessageBox.Show("Заполните поле(я) данными")
        End If
    End Sub

    Private Sub Изменить_прививку_Click(sender As Object, e As EventArgs) Handles Изменить_прививку.Click
        If id_прививки_обнв.Text <> "" And наименование_прививки_обнв.Text <> "" And страна_производитель_обнв.Text <> "" Then
            Dim connString As String = ConfigurationManager.ConnectionStrings("ZelZooExpo.My.MySettings.animalBDConnectionString1").ConnectionString
            Using conn As New SqlConnection(connString)
                Dim query = "update Прививка set Название_прививки= @nazvpriv_up , Страна_производитель= @strana_proizv_up, Количество_привитых=@kolvopriv where ID_прив= @ID_priv_up"
                Using cmd As New SqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@ID_priv_up", id_прививки_обнв.Text)
                    cmd.Parameters.AddWithValue("@nazvpriv_up", наименование_прививки_обнв.Text)
                    cmd.Parameters.AddWithValue("@strana_proizv_up", страна_производитель_обнв.Text)
                    cmd.Parameters.AddWithValue("@kolvopriv", колвоприв_обнов.Text)
                    conn.Open()
                    cmd.ExecuteNonQuery()
                    conn.Close()
                End Using
            End Using
            колвоприв_обнов.Clear() : id_прививки_обнв.Clear() : наименование_прививки_обнв.Clear() : страна_производитель_обнв.Clear() : DGV_прививки_актул.DataSource = Getdatalist3()
        Else
            MessageBox.Show("Заполните поле(я) данными")
        End If
    End Sub
    Private Function Getdatalist3() As DataTable
        Dim dt As New DataTable
        Dim connString As String = ConfigurationManager.ConnectionStrings("ZelZooExpo.My.MySettings.animalBDConnectionString1").ConnectionString
        Using conn As New SqlConnection(connString)
            Using cmd As New SqlCommand("select * from Прививка", conn)
                conn.Open()
                Dim reader As SqlDataReader = cmd.ExecuteReader()
                dt.Load(reader)
            End Using
        End Using
        Return dt
    End Function

    Private Sub Добавить_место_размещ_чипа_Click(sender As Object, e As EventArgs) Handles Добавить_место_размещ_чипа.Click
        If id_места_доб.Text <> "" And где_доб.Text <> "" Then
            Dim connString As String = ConfigurationManager.ConnectionStrings("ZelZooExpo.My.MySettings.animalBDConnectionString1").ConnectionString
            Using conn As New SqlConnection(connString)
                Dim query = "INSERT INTO Место_размещения_электронного_чипа (ID_Место,Где) VALUES(@id_mesta, @gde)"
                Using cmd As New SqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@id_mesta", id_места_доб.Text)
                    cmd.Parameters.AddWithValue("@gde", где_доб.Text)
                    conn.Open()
                    cmd.ExecuteNonQuery()
                    conn.Close()
                End Using
            End Using
            id_места_доб.Clear() : где_доб.Clear() : DGV_место_размещ_актул.DataSource = Getdatalist4()
        Else
            MessageBox.Show("Заполните поле(я) данными")
        End If
    End Sub

    Private Sub Удалить_место_размещ_чипа_Click(sender As Object, e As EventArgs) Handles Удалить_место_размещ_чипа.Click
        If где_дел.Text <> "" Then
            Dim connString As String = ConfigurationManager.ConnectionStrings("ZelZooExpo.My.MySettings.animalBDConnectionString1").ConnectionString
            Using conn As New SqlConnection(connString)
                Dim query = "delete from Место_размещения_электронного_чипа where Где = @gde_d"
                Using cmd As New SqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@gde_d", где_дел.Text)
                    conn.Open()
                    cmd.ExecuteNonQuery()
                    conn.Close()
                End Using
            End Using
            где_дел.Clear() : DGV_место_размещ_актул.DataSource = Getdatalist4()
        Else
            MessageBox.Show("Заполните поле(я) данными")
        End If
    End Sub

    Private Sub Изменить_место_размещ_чипа_Click(sender As Object, e As EventArgs) Handles Изменить_место_размещ_чипа.Click
        If id_места_обнв.Text <> "" And где_обнв.Text <> "" Then
            Dim connString As String = ConfigurationManager.ConnectionStrings("ZelZooExpo.My.MySettings.animalBDConnectionString1").ConnectionString
            Using conn As New SqlConnection(connString)
                Dim query = "update Место_размещения_электронного_чипа set Где=@gde_up where ID_Место= @id_mesta_up"
                Using cmd As New SqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@id_mesta_up", id_места_обнв.Text)
                    cmd.Parameters.AddWithValue("@gde_up", где_обнв.Text)
                    conn.Open()
                    cmd.ExecuteNonQuery()
                    conn.Close()
                End Using
            End Using
            id_места_обнв.Clear() : где_обнв.Clear() : DGV_место_размещ_актул.DataSource = Getdatalist4()
        Else
            MessageBox.Show("Заполните поле(я) данными")
        End If
    End Sub
    Private Function Getdatalist4() As DataTable
        Dim dt As New DataTable
        Dim connString As String = ConfigurationManager.ConnectionStrings("ZelZooExpo.My.MySettings.animalBDConnectionString1").ConnectionString
        Using conn As New SqlConnection(connString)
            Using cmd As New SqlCommand("select * from Место_размещения_электронного_чипа", conn)
                conn.Open()
                Dim reader As SqlDataReader = cmd.ExecuteReader()
                dt.Load(reader)
            End Using
        End Using
        Return dt
    End Function

    Private Sub Добавить_породу_Click(sender As Object, e As EventArgs) Handles Добавить_породу.Click
        If id_породы_доб.Text <> "" And название_породы_доб.Text <> "" Then
            Dim connString As String = ConfigurationManager.ConnectionStrings("ZelZooExpo.My.MySettings.animalBDConnectionString1").ConnectionString
            Using conn As New SqlConnection(connString)
                Dim query = "INSERT INTO Породы (ID_Породы,Название) VALUES(@id_poroda, @nazvporod)"
                Using cmd As New SqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@id_poroda", id_породы_доб.Text)
                    cmd.Parameters.AddWithValue("@nazvporod", название_породы_доб.Text)
                    conn.Open()
                    cmd.ExecuteNonQuery()
                    conn.Close()
                End Using
            End Using
            id_породы_доб.Clear() : название_породы_доб.Clear() : DGV_породы_актул.DataSource = Getdatalist5()
        Else
            MessageBox.Show("Заполните поле(я) данными")
        End If
    End Sub

    Private Sub Удалить_породу_Click(sender As Object, e As EventArgs) Handles Удалить_породу.Click
        If название_породы_дел.Text <> "" Then
            Dim connString As String = ConfigurationManager.ConnectionStrings("ZelZooExpo.My.MySettings.animalBDConnectionString1").ConnectionString
            Using conn As New SqlConnection(connString)
                Dim query = "delete from Породы where Название = @nazvporod_d"
                Using cmd As New SqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@nazvporod_d", название_породы_дел.Text)
                    conn.Open()
                    cmd.ExecuteNonQuery()
                    conn.Close()
                End Using
            End Using
            название_породы_дел.Clear() : DGV_породы_актул.DataSource = Getdatalist5()
        Else
            MessageBox.Show("Заполните поле(я) данными")
        End If
    End Sub

    Private Sub Изменить_породу_Click(sender As Object, e As EventArgs) Handles Изменить_породу.Click
        If id_породы_обнв.Text <> "" And название_породы_обнв.Text <> "" Then
            Dim connString As String = ConfigurationManager.ConnectionStrings("ZelZooExpo.My.MySettings.animalBDConnectionString1").ConnectionString
            Using conn As New SqlConnection(connString)
                Dim query = "update Породы set Название=@nazvporod_up where ID_Породы= @id_poroda_up"
                Using cmd As New SqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@id_poroda_up", id_породы_обнв.Text)
                    cmd.Parameters.AddWithValue("@nazvporod_up", название_породы_обнв.Text)
                    conn.Open()
                    cmd.ExecuteNonQuery()
                    conn.Close()
                End Using
            End Using
            id_породы_обнв.Clear() : название_породы_обнв.Clear() : DGV_породы_актул.DataSource = Getdatalist5()
        Else
            MessageBox.Show("Заполните поле(я) данными")
        End If
    End Sub
    Private Function Getdatalist5() As DataTable
        Dim dt As New DataTable
        Dim connString As String = ConfigurationManager.ConnectionStrings("ZelZooExpo.My.MySettings.animalBDConnectionString1").ConnectionString
        Using conn As New SqlConnection(connString)
            Using cmd As New SqlCommand("select * from Породы", conn)
                conn.Open()
                Dim reader As SqlDataReader = cmd.ExecuteReader()
                dt.Load(reader)
            End Using
        End Using
        Return dt
    End Function

    Private Sub Добавть_владельца_Click(sender As Object, e As EventArgs) Handles Добавть_владельца.Click
        If id_владельца_доб.Text <> "" And ФИО_доб.Text <> "" And город_доб.Text <> "" And улица_доб.Text <> "" And номер_дома_доб.Text <> "" Then
            Dim connString As String = ConfigurationManager.ConnectionStrings("ZelZooExpo.My.MySettings.animalBDConnectionString1").ConnectionString
            Using conn As New SqlConnection(connString)
                Dim query = "INSERT INTO Владельцы (ID_Владельца,ФИО,Дата_рождения,Страна,Город,Улица,Номер_дома) VALUES(@id_vlad,@fio,@data,@strana,@gorod,@ylitsa,@dom)"
                Using cmd As New SqlCommand(query, conn)
                    id_страны_влад_доб.SelectedIndex += 1

                    cmd.Parameters.AddWithValue("@id_vlad", id_владельца_доб.Text)
                    cmd.Parameters.AddWithValue("@fio", ФИО_доб.Text)
                    cmd.Parameters.AddWithValue("@data", D1.Value)
                    cmd.Parameters.AddWithValue("@strana", id_страны_влад_доб.SelectedIndex)
                    cmd.Parameters.AddWithValue("@gorod", город_доб.Text)
                    cmd.Parameters.AddWithValue("@ylitsa", улица_доб.Text)
                    cmd.Parameters.AddWithValue("@dom", номер_дома_доб.Text)

                    conn.Open()
                    cmd.ExecuteNonQuery()
                    conn.Close()
                End Using
            End Using
            id_владельца_доб.Clear() : ФИО_доб.Clear() : город_доб.Clear() : улица_доб.Clear() : номер_дома_доб.Clear() : DGV_Владельцы_актул.DataSource = Getdatalist6()
        Else
            MessageBox.Show("Заполните поле(я) данными")
        End If
    End Sub

    Private Sub GroupBox4_add_Enter(sender As Object, e As EventArgs) Handles GroupBox4_add.Enter

    End Sub

    Private Sub Удалить_владельца_Click(sender As Object, e As EventArgs) Handles Удалить_владельца.Click
        If ФИО_дел.Text <> "" Then
            Dim connString As String = ConfigurationManager.ConnectionStrings("ZelZooExpo.My.MySettings.animalBDConnectionString1").ConnectionString
            Using conn As New SqlConnection(connString)
                Dim query = "delete from Владельцы where ФИО = @fio_d"
                Using cmd As New SqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@fio_d", ФИО_дел.Text)
                    conn.Open()
                    cmd.ExecuteNonQuery()
                    conn.Close()
                End Using
            End Using
            ФИО_дел.Clear() : DGV_Владельцы_актул.DataSource = Getdatalist6()
        Else
            MessageBox.Show("Заполните поле(я) данными")
        End If
    End Sub

    Private Sub Изменить_владельца_Click(sender As Object, e As EventArgs) Handles Изменить_владельца.Click
        If id_владельца_обнв.Text <> "" And ФИО_обнв.Text <> "" And город_обнв.Text <> "" And улица_обнв.Text <> "" And номер_дома_обнв.Text <> "" Then
            Dim connString As String = ConfigurationManager.ConnectionStrings("ZelZooExpo.My.MySettings.animalBDConnectionString1").ConnectionString
            Using conn As New SqlConnection(connString)
                Dim query = "update Владельцы set ФИО =@fio_u ,Дата_рождения=@data_u,Страна=@strana_u,Город=@gorod_u,Улица=@ylitsa_u,Номер_дома=@dom_u where ID_Владельца =@id_vlad_u"
                Using cmd As New SqlCommand(query, conn)
                    id_страны_влад_обнв.SelectedIndex += 1

                    cmd.Parameters.AddWithValue("@id_vlad_u", id_владельца_обнв.Text)
                    cmd.Parameters.AddWithValue("@fio_u", ФИО_обнв.Text)
                    cmd.Parameters.AddWithValue("@data_u", D2.Value)
                    cmd.Parameters.AddWithValue("@strana_u", id_страны_влад_обнв.SelectedIndex)
                    cmd.Parameters.AddWithValue("@gorod_u", город_обнв.Text)
                    cmd.Parameters.AddWithValue("@ylitsa_u", улица_обнв.Text)
                    cmd.Parameters.AddWithValue("@dom_u", номер_дома_обнв.Text)

                    conn.Open()
                    cmd.ExecuteNonQuery()
                    conn.Close()
                End Using
            End Using
            id_владельца_обнв.Clear() : ФИО_обнв.Clear() : город_обнв.Clear() : улица_обнв.Clear() : номер_дома_обнв.Clear() : DGV_Владельцы_актул.DataSource = Getdatalist6()
        Else
            MessageBox.Show("Заполните поле(я) данными")
        End If
    End Sub
    Private Function Getdatalist6() As DataTable
        Dim dt As New DataTable
        Dim connString As String = ConfigurationManager.ConnectionStrings("ZelZooExpo.My.MySettings.animalBDConnectionString1").ConnectionString
        Using conn As New SqlConnection(connString)
            Using cmd As New SqlCommand("select  Владельцы.ID_Владельца as 'Номер Владельца', Владельцы.ФИО, Владельцы.Дата_рождения as 'Дата рождения',Страна.Название as 'Страна',Владельцы.Город,Владельцы.Улица,Владельцы.Номер_дома as 'Номер дома' from Владельцы join Страна on Владельцы.Страна=Страна.ID_Страны", conn)
                conn.Open()
                Dim reader As SqlDataReader = cmd.ExecuteReader()
                dt.Load(reader)
            End Using
        End Using
        Return dt
    End Function

    Private Sub DGV_Владельцы_актул_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV_Владельцы_актул.CellContentClick

    End Sub

    Private Sub Добавить_паспорт_Click(sender As Object, e As EventArgs) Handles Добавить_паспорт.Click
        If id_животного_доб.Text <> "" And номер_родословной_доб.Text <> "" And кличка_животного_доб.Text <> "" And группа_животного_доб.Text <> "" And окрас_животного_доб.Text <> "" And пол_животного_доб.Text <> "" And имя_мамы_доб.Text <> "" And имя_папы_доб.Text <> "" And номер_чипа_доб.Text <> "" Then
            Dim connString As String = ConfigurationManager.ConnectionStrings("ZelZooExpo.My.MySettings.animalBDConnectionString1").ConnectionString
            Using conn As New SqlConnection(connString)
                Dim query = "INSERT INTO Паспорт_животного (ID_Животного,Владелец,Номер_родословной,Кличка,Порода,Дата_рождения,Группа,Окрас,Пол,Имя_мамы,Имя_папы,Номер_чипа,Дата_имплантации,Место_размещения) VALUES(@id_zij,@vlad,@nomer_rodoslov,@klichka,@poroda,@data_roz,@gryppa,@okras,@pol,@im_mam,@im_pa,@nomer_chip,@data_implant,@mestorazm)"
                Using cmd As New SqlCommand(query, conn)
                    id_владельца_животного_доб.SelectedIndex += 1
                    id_породы_животного_доб.SelectedIndex += 1
                    место_размещения_доб.SelectedIndex += 1

                    cmd.Parameters.AddWithValue("@id_zij", id_животного_доб.Text)
                    cmd.Parameters.AddWithValue("@vlad", id_владельца_животного_доб.SelectedIndex)
                    cmd.Parameters.AddWithValue("@nomer_rodoslov", номер_родословной_доб.Text)
                    cmd.Parameters.AddWithValue("@klichka", кличка_животного_доб.Text)
                    cmd.Parameters.AddWithValue("@poroda", id_породы_животного_доб.SelectedIndex)
                    cmd.Parameters.AddWithValue("@data_roz", d3.Value)
                    cmd.Parameters.AddWithValue("@gryppa", группа_животного_доб.Text)
                    cmd.Parameters.AddWithValue("@okras", окрас_животного_доб.Text)
                    cmd.Parameters.AddWithValue("@pol", пол_животного_доб.Text)
                    cmd.Parameters.AddWithValue("@im_mam", имя_мамы_доб.Text)
                    cmd.Parameters.AddWithValue("@im_pa", имя_папы_доб.Text)
                    cmd.Parameters.AddWithValue("@nomer_chip", номер_чипа_доб.Text)
                    cmd.Parameters.AddWithValue("@data_implant", d4.Value)
                    cmd.Parameters.AddWithValue("@mestorazm", место_размещения_доб.SelectedIndex)

                    conn.Open()
                    cmd.ExecuteNonQuery()
                    conn.Close()
                End Using
            End Using
            DGV_паспорт_животного_актул.DataSource = Getdatalist7() : id_животного_доб.Clear() : номер_родословной_доб.Clear() : кличка_животного_доб.Clear() : группа_животного_доб.Clear() : окрас_животного_доб.Clear() : пол_животного_доб.Clear() : имя_мамы_доб.Clear() : имя_папы_доб.Clear() : номер_чипа_доб.Clear()
        Else
            MessageBox.Show("Заполните поле(я) данными")
        End If
    End Sub

    Private Sub Удалить_паспорт_Click(sender As Object, e As EventArgs) Handles Удалить_паспорт.Click
        If кличка_животного_дел.Text <> "" Then
            Dim connString As String = ConfigurationManager.ConnectionStrings("ZelZooExpo.My.MySettings.animalBDConnectionString1").ConnectionString
            Using conn As New SqlConnection(connString)
                Dim query = "delete from Паспорт_животного where Кличка = @klich"
                Using cmd As New SqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@klich", кличка_животного_дел.Text)
                    conn.Open()
                    cmd.ExecuteNonQuery()
                    conn.Close()
                End Using
            End Using
            DGV_паспорт_животного_актул.DataSource = Getdatalist7() : кличка_животного_дел.Clear()
        Else
            MessageBox.Show("Заполните поле(я) данными")
        End If
    End Sub

    Private Sub Изменить_паспорт_Click(sender As Object, e As EventArgs) Handles Изменить_паспорт.Click
        If id_животного_обнв.Text <> "" And номер_родословной_обнв.Text <> "" And имя_животного_обнв.Text <> "" And группа_животного_обнв.Text <> "" And окрас_животного_обнв.Text <> "" And пол_животного_обнв.Text <> "" And имя_мамы_обнв.Text <> "" And имя_папы_обнв.Text <> "" And номер_чипа_обнв.Text <> "" Then
            Dim connString As String = ConfigurationManager.ConnectionStrings("ZelZooExpo.My.MySettings.animalBDConnectionString1").ConnectionString
            Using conn As New SqlConnection(connString)
                Dim query = "update Паспорт_животного set Владелец=@vlad_u,Номер_родословной=@nomer_rodoslov_u,Кличка=@klichka_u,Порода=@poroda_u,Дата_рождения=@data_roz_u,Группа=@gryppa_u,Окрас=@okras_u,Пол=@pol_u,Имя_мамы=@im_mam_u,Имя_папы=@im_pa_u,Номер_чипа=@nomer_chip_u,Дата_имплантации=@data_implant_u,Место_размещения=@mestorazm_u where ID_Животного=@id_zij_u"
                Using cmd As New SqlCommand(query, conn)

                    id_владельца_животного_обнв.SelectedIndex += 1
                    id_породы_животного_обнв.SelectedIndex += 1
                    место_размещения_обнв.SelectedIndex += 1

                    cmd.Parameters.AddWithValue("@id_zij_u", id_животного_обнв.Text)
                    cmd.Parameters.AddWithValue("@vlad_u", id_владельца_животного_обнв.SelectedIndex)
                    cmd.Parameters.AddWithValue("@nomer_rodoslov_u", номер_родословной_обнв.Text)
                    cmd.Parameters.AddWithValue("@klichka_u", имя_животного_обнв.Text)
                    cmd.Parameters.AddWithValue("@poroda_u", id_породы_животного_обнв.SelectedIndex)
                    cmd.Parameters.AddWithValue("@data_roz_u", d5.Value)
                    cmd.Parameters.AddWithValue("@gryppa_u", группа_животного_обнв.Text)
                    cmd.Parameters.AddWithValue("@okras_u", окрас_животного_обнв.Text)
                    cmd.Parameters.AddWithValue("@pol_u", пол_животного_обнв.Text)
                    cmd.Parameters.AddWithValue("@im_mam_u", имя_мамы_обнв.Text)
                    cmd.Parameters.AddWithValue("@im_pa_u", имя_папы_обнв.Text)
                    cmd.Parameters.AddWithValue("@nomer_chip_u", номер_чипа_обнв.Text)
                    cmd.Parameters.AddWithValue("@data_implant_u", d6.Value)
                    cmd.Parameters.AddWithValue("@mestorazm_u", место_размещения_обнв.SelectedIndex)
                    conn.Open()
                    cmd.ExecuteNonQuery()
                    conn.Close()
                End Using
            End Using
            DGV_паспорт_животного_актул.DataSource = Getdatalist7() : id_животного_обнв.Clear() : номер_родословной_обнв.Clear() : имя_животного_обнв.Clear() : группа_животного_обнв.Clear() : окрас_животного_обнв.Clear() : пол_животного_обнв.Clear() : имя_мамы_обнв.Clear() : имя_папы_обнв.Clear() : номер_чипа_обнв.Clear()
        Else
            MessageBox.Show("Заполните поле(я) данными")
        End If
    End Sub
    Private Function Getdatalist7() As DataTable
        Dim dt As New DataTable
        Dim connString As String = ConfigurationManager.ConnectionStrings("ZelZooExpo.My.MySettings.animalBDConnectionString1").ConnectionString
        Using conn As New SqlConnection(connString)
            Using cmd As New SqlCommand("select   Паспорт_животного.ID_Животного as 'Номер животного',Владельцы.ФИО, Паспорт_животного.Номер_родословной as 'Номер родословной',Паспорт_животного.Кличка,Породы.Название As'Порода',Паспорт_животного.Дата_рождения as 'Дата рождения',Паспорт_животного.Группа,Паспорт_животного.Окрас,Паспорт_животного.Пол,Паспорт_животного.Имя_мамы as 'Имя мамы',Паспорт_животного.Имя_папы as 'Имя папы',Паспорт_животного.Номер_чипа as 'Номер чипа' ,Паспорт_животного.Дата_имплантации as 'Дата имплантации',Место_размещения_электронного_чипа.Где from Паспорт_животного join Владельцы on Паспорт_животного.Владелец=Владельцы.ID_Владельца join Породы on Паспорт_животного.Порода= Породы.ID_Породы join Место_размещения_электронного_чипа on Паспорт_животного.Место_размещения= Место_размещения_электронного_чипа.ID_Место", conn)
                conn.Open()
                Dim reader As SqlDataReader = cmd.ExecuteReader()
                dt.Load(reader)
            End Using
        End Using
        Return dt
    End Function

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles получ_награды_обнв.SelectedIndexChanged


    End Sub

    Private Sub Добавить_получ_награды_Click(sender As Object, e As EventArgs) Handles Добавить_получ_награды.Click
        If id_получ_награды_доб.Text <> "" Then
            Dim connString As String = ConfigurationManager.ConnectionStrings("ZelZooExpo.My.MySettings.animalBDConnectionString1").ConnectionString
            Using conn As New SqlConnection(connString)
                Dim query = "INSERT INTO Получение_награды (ID_Получ,Кличка_животного,Наименование_награды,Дата_получения,Прошлая_дата_получения) VALUES(@idPolych,@klichJiv,@imNagrd,@dataPolych,@Proshdata)"
                Using cmd As New SqlCommand(query, conn)
                    ID_клички_доб.SelectedIndex += 1
                    получ_награды_доб.SelectedIndex += 1

                    cmd.Parameters.AddWithValue("@idPolych", id_получ_награды_доб.Text)
                    cmd.Parameters.AddWithValue("@klichJiv", ID_клички_доб.SelectedIndex)
                    cmd.Parameters.AddWithValue("@imNagrd", получ_награды_доб.SelectedIndex)
                    cmd.Parameters.AddWithValue("@dataPolych", d7.Value)
                    cmd.Parameters.AddWithValue("@Proshdata", d8.Value)
                    conn.Open()
                    cmd.ExecuteNonQuery()
                    conn.Close()
                End Using
            End Using
            DGV_получ_награды_актул.DataSource = Getdatalist8() : id_получ_награды_доб.Clear()
        Else
            MessageBox.Show("Заполните поле(я) данными")
        End If
    End Sub

    Private Sub Удалить_получ_награды_Click(sender As Object, e As EventArgs) Handles Удалить_получ_награды.Click
        If id_получ_награды_уд.Text <> "" Then
            Dim connString As String = ConfigurationManager.ConnectionStrings("ZelZooExpo.My.MySettings.animalBDConnectionString1").ConnectionString
            Using conn As New SqlConnection(connString)
                Dim query = "delete from Получение_награды where ID_Получ = @iddlete"
                Using cmd As New SqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@iddlete", id_получ_награды_уд.Text)
                    conn.Open()
                    cmd.ExecuteNonQuery()
                    conn.Close()
                End Using
            End Using
            DGV_получ_награды_актул.DataSource = Getdatalist8() : id_получ_награды_уд.Clear()
        Else
            MessageBox.Show("Заполните поле(я) данными")
        End If
    End Sub

    Private Sub Изменить_получ_награды_Click(sender As Object, e As EventArgs) Handles Изменить_получ_награды.Click
        If id_получ_награды_обнв.Text <> "" Then
            Dim connString As String = ConfigurationManager.ConnectionStrings("ZelZooExpo.My.MySettings.animalBDConnectionString1").ConnectionString
            Using conn As New SqlConnection(connString)
                Dim query = "update Получение_награды set Кличка_животного =@ima_u ,Наименование_награды=@nameNagrad_u,Дата_получения=@data_polych_u,Прошлая_дата_получения=@proshla__u where ID_Получ =@id_polych_u"
                Using cmd As New SqlCommand(query, conn)
                    ID_клички_обнв.SelectedIndex += 1
                    получ_награды_обнв.SelectedIndex += 1

                    cmd.Parameters.AddWithValue("@id_polych_u", id_получ_награды_обнв.Text)
                    cmd.Parameters.AddWithValue("@ima_u", ID_клички_обнв.SelectedIndex)
                    cmd.Parameters.AddWithValue("@nameNagrad_u", получ_награды_обнв.SelectedIndex)
                    cmd.Parameters.AddWithValue("@data_polych_u", d9.Value)
                    cmd.Parameters.AddWithValue("@proshla__u", d10.Value)

                    conn.Open()
                    cmd.ExecuteNonQuery()
                    conn.Close()
                End Using
            End Using
            DGV_получ_награды_актул.DataSource = Getdatalist8() : id_получ_награды_обнв.Clear()
        Else
            MessageBox.Show("Заполните поле(я) данными")
        End If
    End Sub
    Private Function Getdatalist8() As DataTable
        Dim dt As New DataTable
        Dim connString As String = ConfigurationManager.ConnectionStrings("ZelZooExpo.My.MySettings.animalBDConnectionString1").ConnectionString
        Using conn As New SqlConnection(connString)
            Using cmd As New SqlCommand("Select Получение_награды.ID_Получ as 'Номер получения', Паспорт_животного.Кличка, Награды.Наименование, Получение_награды.Дата_получения as 'Дата получения',Получение_награды.Прошлая_дата_получения as 'Прошлая дата получения' from Получение_награды join Паспорт_животного on Получение_награды.Кличка_животного=Паспорт_животного.ID_Животного join Награды on Получение_награды.Наименование_награды= Награды.ID_Награды", conn)
                conn.Open()
                Dim reader As SqlDataReader = cmd.ExecuteReader()
                dt.Load(reader)
            End Using
        End Using
        Return dt
    End Function

    Private Sub Добавить_вет_свед_Click(sender As Object, e As EventArgs) Handles Добавить_вет_свед.Click
        If id_вет_св_доб.Text <> "" And имя_картинки_доб.Text <> "" And формат_кратинки_доб.Text <> "" Then
            Dim connString As String = ConfigurationManager.ConnectionStrings("ZelZooExpo.My.MySettings.animalBDConnectionString1").ConnectionString
            Using conn As New SqlConnection(connString)
                Dim query = "INSERT INTO Ветеринарное_свидетельство (ID_Вет,Имя_животного,Наименование_прививки,Привика_от,Дата_принятия,Срок_действия_прививки,Имя_картинки,Формат_картинки) VALUES(@idvet,@nameJiv,@namePriv,@privot,@dataprin,@srok,@nameimage,@format)"
                Using cmd As New SqlCommand(query, conn)
                    id_имя_жив_вет_доб.SelectedIndex += 1
                    id_наименов_прирв_вет_доб.SelectedIndex += 1
                    id_прив_от_вет_доб.SelectedIndex += 1
                    cmd.Parameters.AddWithValue("@idvet", id_вет_св_доб.Text)
                    cmd.Parameters.AddWithValue("@nameJiv", id_имя_жив_вет_доб.SelectedIndex)
                    cmd.Parameters.AddWithValue("@namePriv", id_наименов_прирв_вет_доб.SelectedIndex)
                    cmd.Parameters.AddWithValue("@privot", id_прив_от_вет_доб.SelectedIndex)
                    cmd.Parameters.AddWithValue("@dataprin", d11.Value)
                    cmd.Parameters.AddWithValue("@srok", d12.Value)
                    cmd.Parameters.AddWithValue("@nameimage", имя_картинки_доб.Text)
                    cmd.Parameters.AddWithValue("@format", формат_кратинки_доб.Text)
                    conn.Open()
                    cmd.ExecuteNonQuery()
                    conn.Close()
                End Using
            End Using
            DGV_ветеринарное_свидетельство.DataSource = Getdatalist9() : имя_картинки_доб.Clear() : формат_кратинки_доб.Clear()
        Else
            MessageBox.Show("Заполните поле(я) данными")
        End If
    End Sub

    Private Sub Удалить_вет_свед_Click(sender As Object, e As EventArgs) Handles Удалить_вет_свед.Click
        If id_вет_св_дел.Text <> "" Then
            Dim connString As String = ConfigurationManager.ConnectionStrings("ZelZooExpo.My.MySettings.animalBDConnectionString1").ConnectionString
            Using conn As New SqlConnection(connString)
                Dim query = "delete from Ветеринарное_свидетельство where ID_Вет = @idVet_del"
                Using cmd As New SqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@idVet_del", id_вет_св_дел.Text)
                    conn.Open()
                    cmd.ExecuteNonQuery()
                    conn.Close()
                End Using
            End Using
            DGV_ветеринарное_свидетельство.DataSource = Getdatalist9() : id_вет_св_дел.Clear()
        Else
            MessageBox.Show("Заполните поле(я) данными")
        End If
    End Sub

    Private Sub Изменить_вет_свед_Click(sender As Object, e As EventArgs) Handles Изменить_вет_свед.Click
        If id_вет_св_обнв.Text <> "" And имя_картинки_обнв.Text <> "" And формат_кратинки_обнв.Text <> "" Then
            Dim connString As String = ConfigurationManager.ConnectionStrings("ZelZooExpo.My.MySettings.animalBDConnectionString1").ConnectionString
            Using conn As New SqlConnection(connString)
                Dim query = "update  Ветеринарное_свидетельство set Имя_животного=@nameJiv_up ,Наименование_прививки=@namePriv_up,Привика_от=@privot_up,Дата_принятия=@dataprin_up ,Срок_действия_прививки=@srok_up,Имя_картинки=@nameimage_up,Формат_картинки=@format_up where ID_Вет=@idvet_up"
                Using cmd As New SqlCommand(query, conn)
                    id_имя_жив_вет_обнв.SelectedIndex += 1
                    id_наименов_прирв_вет_обнв.SelectedIndex += 1
                    id_прив_от_вет_обнв.SelectedIndex += 1
                    cmd.Parameters.AddWithValue("@idvet_up", id_вет_св_обнв.Text)
                    cmd.Parameters.AddWithValue("@nameJiv_up", id_имя_жив_вет_обнв.SelectedIndex)
                    cmd.Parameters.AddWithValue("@namePriv_up", id_наименов_прирв_вет_обнв.SelectedIndex)
                    cmd.Parameters.AddWithValue("@privot_up", id_прив_от_вет_обнв.SelectedIndex)
                    cmd.Parameters.AddWithValue("@dataprin_up", d13.Value)
                    cmd.Parameters.AddWithValue("@srok_up", d14.Value)
                    cmd.Parameters.AddWithValue("@nameimage_up", имя_картинки_обнв.Text)
                    cmd.Parameters.AddWithValue("@format_up", формат_кратинки_обнв.Text)
                    conn.Open()
                    cmd.ExecuteNonQuery()
                    conn.Close()
                End Using
            End Using
            DGV_ветеринарное_свидетельство.DataSource = Getdatalist9() : имя_картинки_обнв.Clear() : формат_кратинки_обнв.Clear()
        Else
            MessageBox.Show("Заполните поле(я) данными")
        End If
    End Sub
    Private Function Getdatalist9() As DataTable
        Dim dt As New DataTable
        Dim connString As String = ConfigurationManager.ConnectionStrings("ZelZooExpo.My.MySettings.animalBDConnectionString1").ConnectionString
        Using conn As New SqlConnection(connString)
            Using cmd As New SqlCommand("Select Ветеринарное_свидетельство.ID_Вет as 'Номер вет', Паспорт_животного.Кличка,Прививка.Название_прививки as 'Название прививки',ОтчегоПрививка.Прививка_от as 'Прививка от',Ветеринарное_свидетельство.Дата_принятия as 'Дата получения',Ветеринарное_свидетельство.Срок_действия_прививки as 'Срок действия прививки',Ветеринарное_свидетельство.Имя_картинки as 'Имя картинки',Ветеринарное_свидетельство.Формат_картинки as 'Формат картинки' from Ветеринарное_свидетельство join Паспорт_животного on  Ветеринарное_свидетельство.Имя_животного=Паспорт_животного.ID_Животного join Прививка on Ветеринарное_свидетельство.Наименование_прививки=Прививка.ID_прив join ОтчегоПрививка on Ветеринарное_свидетельство.Привика_от=ОтчегоПрививка.ID_отЧего", conn)
                conn.Open()
                Dim reader As SqlDataReader = cmd.ExecuteReader()
                dt.Load(reader)
            End Using
        End Using
        Return dt
    End Function

    Private Sub id_страны_доб_KeyPress(sender As Object, e As KeyPressEventArgs) Handles id_страны_доб.KeyPress, id_страны_обнв.KeyPress, номер_чипа_обнв.KeyPress, номер_чипа_доб.KeyPress, номер_родословной_обнв.KeyPress, номер_родословной_доб.KeyPress, номер_дома_обнв.KeyPress, номер_дома_доб.KeyPress, id_прививки_обнв.KeyPress, id_прививки_доб.KeyPress, id_породы_обнв.KeyPress, id_породы_доб.KeyPress, id_получ_награды_уд.KeyPress, id_получ_награды_обнв.KeyPress, id_получ_награды_доб.KeyPress, id_отчего_прив_обнв.KeyPress, id_отчего_прив_доб.KeyPress, id_награды_обнв.KeyPress, id_награды_доб.KeyPress, id_места_обнв.KeyPress, id_места_доб.KeyPress, id_животного_обнв.KeyPress, id_животного_доб.KeyPress, id_владельца_обнв.KeyPress, id_владельца_доб.KeyPress, id_вет_св_обнв.KeyPress, id_вет_св_доб.KeyPress, id_вет_св_дел.KeyPress, колживнаг_обнов.KeyPress, колживнаг_доб.KeyPress, колвоприв_обнов.KeyPress, колвоприв_доб.KeyPress
        If Not IsNumeric(e.KeyChar) AndAlso Asc(e.KeyChar) <> 8 Then e.Handled = True
    End Sub

    Private Sub название_страны_доб_KeyPress(sender As Object, e As KeyPressEventArgs) Handles название_страны_доб.KeyPress, название_страны_удл.KeyPress, название_страны_обнв.KeyPress, формат_кратинки_обнв.KeyPress, формат_кратинки_доб.KeyPress, ФИО_обнв.KeyPress, ФИО_доб.KeyPress, ФИО_дел.KeyPress, улица_обнв.KeyPress, улица_доб.KeyPress, страна_производитель_обнв.KeyPress, страна_производитель_доб.KeyPress, прививка_от_обнв.KeyPress, прививка_от_доб.KeyPress, прививка_от_дел.KeyPress, пол_животного_обнв.KeyPress, пол_животного_доб.KeyPress, окрас_животного_обнв.KeyPress, окрас_животного_доб.KeyPress, наименование_прививки_обнв.KeyPress, наименование_прививки_доб.KeyPress, наименование_прививки_дел.KeyPress, наименование_награды_обнв.KeyPress, наименование_награды_доб.KeyPress, наименование_награды_дел.KeyPress, название_породы_обнв.KeyPress, название_породы_доб.KeyPress, название_породы_дел.KeyPress, кличка_животного_доб.KeyPress, имя_папы_обнв.KeyPress, имя_папы_доб.KeyPress, имя_мамы_обнв.KeyPress, имя_мамы_доб.KeyPress, имя_животного_обнв.KeyPress, группа_животного_обнв.KeyPress, группа_животного_доб.KeyPress, город_обнв.KeyPress, город_доб.KeyPress, где_обнв.KeyPress, где_доб.KeyPress, где_дел.KeyPress, кличка_животного_дел.KeyPress
        Dim chr As Char = e.KeyChar
        Dim iCh As Integer = AscW(chr)
        If Not Char.IsLetter(chr) AndAlso (chr <> vbBack And chr <> ChrW(32) And iCh + iCh <> 52 And iCh + iCh <> 48 _
            And iCh + iCh <> 44 And iCh + iCh <> 2 And iCh + iCh <> 6) Then e.Handled = True
    End Sub

    Private Sub aktyalizat_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.F1 Then Help.ShowHelp(Me, "ZelZooExpo_Info.chm")
    End Sub

    Private Sub id_страны_влад_доб_SelectedIndexChanged(sender As Object, e As EventArgs) Handles id_страны_влад_доб.SelectedIndexChanged

    End Sub
End Class