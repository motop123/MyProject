Public Class StartForm
    Private Sub update_INFO_Click(sender As Object, e As EventArgs) Handles update_INFO.Click
        aktyalizat.Show()

    End Sub

    Private Sub Read_INFO_Click(sender As Object, e As EventArgs) Handles Read_INFO.Click
        prosmotr.Show()
    End Sub

    Private Sub Spravka_Click(sender As Object, e As EventArgs) Handles Spravka.Click
        Process.Start("ZelZooExpo_Info.chm")
    End Sub

    Private Sub Exit_app_Click(sender As Object, e As EventArgs) Handles Exit_app.Click
        Application.Exit()
    End Sub

    Private Sub StartForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        MessageBox.Show("Добро пожаловать в программу ZelZooExpo. " & vbCrLf & "Пожалуйста перед использованием программы прочтите СПРАВКУ. " & vbCrLf & "Спарвку можно вызвать клавишей F1 или же при нажатии на кнопку СПРАВКА.")
        KeyPreview = True
    End Sub

    Private Sub StartForm_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.F1 Then Help.ShowHelp(Me, "ZelZooExpo_Info.chm")
    End Sub
End Class
