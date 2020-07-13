<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StartForm
    Inherits System.Windows.Forms.Form

    'Форма переопределяет dispose для очистки списка компонентов.
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

    'Является обязательной для конструктора форм Windows Forms
    Private components As System.ComponentModel.IContainer

    'Примечание: следующая процедура является обязательной для конструктора форм Windows Forms
    'Для ее изменения используйте конструктор форм Windows Form.  
    'Не изменяйте ее в редакторе исходного кода.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(StartForm))
        Me.update_INFO = New System.Windows.Forms.Button()
        Me.Read_INFO = New System.Windows.Forms.Button()
        Me.Exit_app = New System.Windows.Forms.Button()
        Me.MainMenu = New System.Windows.Forms.Label()
        Me.Spravka = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'update_INFO
        '
        Me.update_INFO.BackColor = System.Drawing.SystemColors.Window
        Me.update_INFO.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.update_INFO.Location = New System.Drawing.Point(16, 46)
        Me.update_INFO.Name = "update_INFO"
        Me.update_INFO.Size = New System.Drawing.Size(203, 45)
        Me.update_INFO.TabIndex = 0
        Me.update_INFO.Text = "Актуализация сведений"
        Me.update_INFO.UseVisualStyleBackColor = False
        '
        'Read_INFO
        '
        Me.Read_INFO.BackColor = System.Drawing.SystemColors.Window
        Me.Read_INFO.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Read_INFO.Location = New System.Drawing.Point(16, 97)
        Me.Read_INFO.Name = "Read_INFO"
        Me.Read_INFO.Size = New System.Drawing.Size(203, 44)
        Me.Read_INFO.TabIndex = 1
        Me.Read_INFO.Text = "Просмотр информации"
        Me.Read_INFO.UseVisualStyleBackColor = False
        '
        'Exit_app
        '
        Me.Exit_app.BackColor = System.Drawing.SystemColors.Window
        Me.Exit_app.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Exit_app.Location = New System.Drawing.Point(16, 197)
        Me.Exit_app.Name = "Exit_app"
        Me.Exit_app.Size = New System.Drawing.Size(203, 44)
        Me.Exit_app.TabIndex = 3
        Me.Exit_app.Text = "Выход"
        Me.Exit_app.UseVisualStyleBackColor = False
        '
        'MainMenu
        '
        Me.MainMenu.AutoSize = True
        Me.MainMenu.Font = New System.Drawing.Font("Times New Roman", 15.75!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.MainMenu.Location = New System.Drawing.Point(12, 9)
        Me.MainMenu.Name = "MainMenu"
        Me.MainMenu.Size = New System.Drawing.Size(139, 24)
        Me.MainMenu.TabIndex = 4
        Me.MainMenu.Text = "Главное меню"
        '
        'Spravka
        '
        Me.Spravka.BackColor = System.Drawing.SystemColors.Window
        Me.Spravka.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Spravka.Location = New System.Drawing.Point(16, 147)
        Me.Spravka.Name = "Spravka"
        Me.Spravka.Size = New System.Drawing.Size(203, 44)
        Me.Spravka.TabIndex = 5
        Me.Spravka.Text = "Справка"
        Me.Spravka.UseVisualStyleBackColor = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.ZelZooExpo.My.Resources.Resources.garfild_animatsionnaya_kartinka_0044
        Me.PictureBox2.Location = New System.Drawing.Point(111, 247)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(132, 104)
        Me.PictureBox2.TabIndex = 7
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.ZelZooExpo.My.Resources.Resources.panda_animatsionnaya_kartinka_0108
        Me.PictureBox1.Location = New System.Drawing.Point(12, 247)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(93, 104)
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'StartForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(245, 363)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Spravka)
        Me.Controls.Add(Me.MainMenu)
        Me.Controls.Add(Me.Exit_app)
        Me.Controls.Add(Me.Read_INFO)
        Me.Controls.Add(Me.update_INFO)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(261, 402)
        Me.MinimumSize = New System.Drawing.Size(261, 402)
        Me.Name = "StartForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ZelZooExpo"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents update_INFO As Button
    Friend WithEvents Read_INFO As Button
    Friend WithEvents Exit_app As Button
    Friend WithEvents MainMenu As Label
    Friend WithEvents Spravka As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
End Class
