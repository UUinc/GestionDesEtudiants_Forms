<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AjouterPage
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.back_btn = New System.Windows.Forms.Button()
        Me.title_l = New System.Windows.Forms.Label()
        Me.cin_tb = New System.Windows.Forms.TextBox()
        Me.cin_bg = New System.Windows.Forms.PictureBox()
        Me.save_btn = New System.Windows.Forms.Button()
        Me.nom_tb = New System.Windows.Forms.TextBox()
        Me.name_bg = New System.Windows.Forms.PictureBox()
        Me.birthdate_bg = New System.Windows.Forms.PictureBox()
        Me.prenom_tb = New System.Windows.Forms.TextBox()
        Me.prenom_bg = New System.Windows.Forms.PictureBox()
        Me.sex_bg = New System.Windows.Forms.PictureBox()
        Me.sex_cb = New System.Windows.Forms.ComboBox()
        Me.birthdate_picker = New System.Windows.Forms.DateTimePicker()
        Me.filiere_cb = New System.Windows.Forms.ComboBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.email_tb = New System.Windows.Forms.TextBox()
        Me.email_bg = New System.Windows.Forms.PictureBox()
        Me.etudiant_l = New System.Windows.Forms.Label()
        Me.notes_l = New System.Windows.Forms.Label()
        Me.note1_tb = New System.Windows.Forms.TextBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.etudiant_img = New System.Windows.Forms.PictureBox()
        Me.notes_img = New System.Windows.Forms.PictureBox()
        Me.note1_l = New System.Windows.Forms.Label()
        Me.note2_l = New System.Windows.Forms.Label()
        Me.note2_tb = New System.Windows.Forms.TextBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.note3_l = New System.Windows.Forms.Label()
        Me.note3_tb = New System.Windows.Forms.TextBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.note4_l = New System.Windows.Forms.Label()
        Me.note4_tb = New System.Windows.Forms.TextBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.note5_l = New System.Windows.Forms.Label()
        Me.note5_tb = New System.Windows.Forms.TextBox()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.note6_l = New System.Windows.Forms.Label()
        Me.note6_tb = New System.Windows.Forms.TextBox()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.note7_l = New System.Windows.Forms.Label()
        Me.note7_tb = New System.Windows.Forms.TextBox()
        Me.PictureBox8 = New System.Windows.Forms.PictureBox()
        Me.erreur_l = New System.Windows.Forms.Label()
        Me.filiere_l = New System.Windows.Forms.Label()
        Me.sexe_l = New System.Windows.Forms.Label()
        Me.email_l = New System.Windows.Forms.Label()
        Me.prenom_l = New System.Windows.Forms.Label()
        Me.nom_l = New System.Windows.Forms.Label()
        Me.cin_l = New System.Windows.Forms.Label()
        Me.erreur_exception_l = New System.Windows.Forms.Label()
        Me.enregister_l = New System.Windows.Forms.Label()
        CType(Me.cin_bg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.name_bg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.birthdate_bg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.prenom_bg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sex_bg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.email_bg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.etudiant_img, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.notes_img, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'back_btn
        '
        Me.back_btn.BackColor = System.Drawing.Color.Transparent
        Me.back_btn.BackgroundImage = Global.GestionDesEtudiants.My.Resources.Resources.back3
        Me.back_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.back_btn.FlatAppearance.BorderSize = 0
        Me.back_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.back_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.back_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.back_btn.Location = New System.Drawing.Point(10, 10)
        Me.back_btn.Name = "back_btn"
        Me.back_btn.Size = New System.Drawing.Size(30, 30)
        Me.back_btn.TabIndex = 15
        Me.back_btn.UseVisualStyleBackColor = False
        '
        'title_l
        '
        Me.title_l.AutoSize = True
        Me.title_l.BackColor = System.Drawing.Color.Transparent
        Me.title_l.Font = New System.Drawing.Font("Roboto", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.title_l.ForeColor = System.Drawing.Color.White
        Me.title_l.Location = New System.Drawing.Point(53, 14)
        Me.title_l.Name = "title_l"
        Me.title_l.Size = New System.Drawing.Size(73, 24)
        Me.title_l.TabIndex = 16
        Me.title_l.Text = "Ajouter"
        '
        'cin_tb
        '
        Me.cin_tb.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.cin_tb.Font = New System.Drawing.Font("Roboto", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cin_tb.ForeColor = System.Drawing.Color.Black
        Me.cin_tb.Location = New System.Drawing.Point(77, 163)
        Me.cin_tb.MaxLength = 64
        Me.cin_tb.Name = "cin_tb"
        Me.cin_tb.Size = New System.Drawing.Size(170, 26)
        Me.cin_tb.TabIndex = 0
        '
        'cin_bg
        '
        Me.cin_bg.BackColor = System.Drawing.Color.Transparent
        Me.cin_bg.BackgroundImage = Global.GestionDesEtudiants.My.Resources.Resources.square2_BG
        Me.cin_bg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.cin_bg.Location = New System.Drawing.Point(50, 140)
        Me.cin_bg.Name = "cin_bg"
        Me.cin_bg.Size = New System.Drawing.Size(231, 60)
        Me.cin_bg.TabIndex = 8
        Me.cin_bg.TabStop = False
        '
        'save_btn
        '
        Me.save_btn.BackColor = System.Drawing.Color.Transparent
        Me.save_btn.BackgroundImage = Global.GestionDesEtudiants.My.Resources.Resources.Button_smaller
        Me.save_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.save_btn.FlatAppearance.BorderSize = 0
        Me.save_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.save_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.save_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.save_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.save_btn.ForeColor = System.Drawing.Color.White
        Me.save_btn.Location = New System.Drawing.Point(258, 599)
        Me.save_btn.Name = "save_btn"
        Me.save_btn.Size = New System.Drawing.Size(195, 60)
        Me.save_btn.TabIndex = 14
        Me.save_btn.Text = "Sauvegarder"
        Me.save_btn.UseVisualStyleBackColor = False
        '
        'nom_tb
        '
        Me.nom_tb.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.nom_tb.Font = New System.Drawing.Font("Roboto", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nom_tb.ForeColor = System.Drawing.Color.Black
        Me.nom_tb.Location = New System.Drawing.Point(77, 223)
        Me.nom_tb.MaxLength = 64
        Me.nom_tb.Name = "nom_tb"
        Me.nom_tb.Size = New System.Drawing.Size(170, 26)
        Me.nom_tb.TabIndex = 1
        '
        'name_bg
        '
        Me.name_bg.BackColor = System.Drawing.Color.Transparent
        Me.name_bg.BackgroundImage = Global.GestionDesEtudiants.My.Resources.Resources.square2_BG
        Me.name_bg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.name_bg.Location = New System.Drawing.Point(50, 200)
        Me.name_bg.Name = "name_bg"
        Me.name_bg.Size = New System.Drawing.Size(231, 60)
        Me.name_bg.TabIndex = 12
        Me.name_bg.TabStop = False
        '
        'birthdate_bg
        '
        Me.birthdate_bg.BackColor = System.Drawing.Color.Transparent
        Me.birthdate_bg.BackgroundImage = Global.GestionDesEtudiants.My.Resources.Resources.square2_BG
        Me.birthdate_bg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.birthdate_bg.Location = New System.Drawing.Point(50, 380)
        Me.birthdate_bg.Name = "birthdate_bg"
        Me.birthdate_bg.Size = New System.Drawing.Size(231, 60)
        Me.birthdate_bg.TabIndex = 16
        Me.birthdate_bg.TabStop = False
        '
        'prenom_tb
        '
        Me.prenom_tb.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.prenom_tb.Font = New System.Drawing.Font("Roboto", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.prenom_tb.ForeColor = System.Drawing.Color.Black
        Me.prenom_tb.Location = New System.Drawing.Point(77, 283)
        Me.prenom_tb.MaxLength = 64
        Me.prenom_tb.Name = "prenom_tb"
        Me.prenom_tb.Size = New System.Drawing.Size(170, 26)
        Me.prenom_tb.TabIndex = 2
        '
        'prenom_bg
        '
        Me.prenom_bg.BackColor = System.Drawing.Color.Transparent
        Me.prenom_bg.BackgroundImage = Global.GestionDesEtudiants.My.Resources.Resources.square2_BG
        Me.prenom_bg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.prenom_bg.Location = New System.Drawing.Point(50, 260)
        Me.prenom_bg.Name = "prenom_bg"
        Me.prenom_bg.Size = New System.Drawing.Size(231, 60)
        Me.prenom_bg.TabIndex = 14
        Me.prenom_bg.TabStop = False
        '
        'sex_bg
        '
        Me.sex_bg.BackColor = System.Drawing.Color.Transparent
        Me.sex_bg.BackgroundImage = Global.GestionDesEtudiants.My.Resources.Resources.square2_BG
        Me.sex_bg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.sex_bg.Location = New System.Drawing.Point(50, 440)
        Me.sex_bg.Name = "sex_bg"
        Me.sex_bg.Size = New System.Drawing.Size(231, 60)
        Me.sex_bg.TabIndex = 19
        Me.sex_bg.TabStop = False
        '
        'sex_cb
        '
        Me.sex_cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.sex_cb.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.sex_cb.Font = New System.Drawing.Font("Roboto", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sex_cb.ForeColor = System.Drawing.Color.Black
        Me.sex_cb.FormattingEnabled = True
        Me.sex_cb.Items.AddRange(New Object() {"Male", "Female"})
        Me.sex_cb.Location = New System.Drawing.Point(77, 456)
        Me.sex_cb.Name = "sex_cb"
        Me.sex_cb.Size = New System.Drawing.Size(185, 34)
        Me.sex_cb.TabIndex = 5
        '
        'birthdate_picker
        '
        Me.birthdate_picker.CalendarFont = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.birthdate_picker.CalendarForeColor = System.Drawing.Color.Red
        Me.birthdate_picker.CalendarMonthBackground = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.birthdate_picker.CalendarTitleBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.birthdate_picker.CalendarTitleForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.birthdate_picker.CalendarTrailingForeColor = System.Drawing.Color.Fuchsia
        Me.birthdate_picker.CustomFormat = "dd - MM - yyyy"
        Me.birthdate_picker.Font = New System.Drawing.Font("Roboto", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.birthdate_picker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.birthdate_picker.Location = New System.Drawing.Point(77, 395)
        Me.birthdate_picker.Name = "birthdate_picker"
        Me.birthdate_picker.Size = New System.Drawing.Size(185, 30)
        Me.birthdate_picker.TabIndex = 4
        Me.birthdate_picker.Value = New Date(2022, 4, 23, 0, 0, 0, 0)
        '
        'filiere_cb
        '
        Me.filiere_cb.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.filiere_cb.Font = New System.Drawing.Font("Roboto", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.filiere_cb.ForeColor = System.Drawing.Color.Black
        Me.filiere_cb.FormattingEnabled = True
        Me.filiere_cb.Items.AddRange(New Object() {"1AP", "2AP", "3IIR", "4IIR", "5IIR", "3GI", "4GI", "5GI", "3IAII", "4IAII", "5IAII", "1GC", "2GC", "3GC", "4GC", "5GC", "1IFA", "2IFA", "3IFA", "4IFA", "5IFA"})
        Me.filiere_cb.Location = New System.Drawing.Point(77, 516)
        Me.filiere_cb.Name = "filiere_cb"
        Me.filiere_cb.Size = New System.Drawing.Size(185, 34)
        Me.filiere_cb.TabIndex = 6
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = Global.GestionDesEtudiants.My.Resources.Resources.square2_BG
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Location = New System.Drawing.Point(50, 500)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(231, 60)
        Me.PictureBox1.TabIndex = 23
        Me.PictureBox1.TabStop = False
        '
        'email_tb
        '
        Me.email_tb.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.email_tb.Font = New System.Drawing.Font("Roboto", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.email_tb.ForeColor = System.Drawing.Color.Black
        Me.email_tb.Location = New System.Drawing.Point(77, 343)
        Me.email_tb.MaxLength = 64
        Me.email_tb.Name = "email_tb"
        Me.email_tb.Size = New System.Drawing.Size(170, 26)
        Me.email_tb.TabIndex = 3
        '
        'email_bg
        '
        Me.email_bg.BackColor = System.Drawing.Color.Transparent
        Me.email_bg.BackgroundImage = Global.GestionDesEtudiants.My.Resources.Resources.square2_BG
        Me.email_bg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.email_bg.Location = New System.Drawing.Point(50, 320)
        Me.email_bg.Name = "email_bg"
        Me.email_bg.Size = New System.Drawing.Size(231, 60)
        Me.email_bg.TabIndex = 26
        Me.email_bg.TabStop = False
        '
        'etudiant_l
        '
        Me.etudiant_l.AutoSize = True
        Me.etudiant_l.BackColor = System.Drawing.Color.Transparent
        Me.etudiant_l.Font = New System.Drawing.Font("Roboto", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etudiant_l.ForeColor = System.Drawing.Color.White
        Me.etudiant_l.Location = New System.Drawing.Point(117, 100)
        Me.etudiant_l.Name = "etudiant_l"
        Me.etudiant_l.Size = New System.Drawing.Size(136, 39)
        Me.etudiant_l.TabIndex = 34
        Me.etudiant_l.Text = "Etudiant"
        '
        'notes_l
        '
        Me.notes_l.AutoSize = True
        Me.notes_l.BackColor = System.Drawing.Color.Transparent
        Me.notes_l.Font = New System.Drawing.Font("Roboto", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.notes_l.ForeColor = System.Drawing.Color.White
        Me.notes_l.Location = New System.Drawing.Point(483, 100)
        Me.notes_l.Name = "notes_l"
        Me.notes_l.Size = New System.Drawing.Size(102, 39)
        Me.notes_l.TabIndex = 38
        Me.notes_l.Text = "Notes"
        '
        'note1_tb
        '
        Me.note1_tb.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.note1_tb.Font = New System.Drawing.Font("Roboto", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.note1_tb.ForeColor = System.Drawing.Color.Black
        Me.note1_tb.Location = New System.Drawing.Point(444, 164)
        Me.note1_tb.MaxLength = 5
        Me.note1_tb.Name = "note1_tb"
        Me.note1_tb.Size = New System.Drawing.Size(170, 26)
        Me.note1_tb.TabIndex = 7
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.BackgroundImage = Global.GestionDesEtudiants.My.Resources.Resources.square2_BG
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox2.Location = New System.Drawing.Point(416, 140)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(231, 60)
        Me.PictureBox2.TabIndex = 35
        Me.PictureBox2.TabStop = False
        '
        'etudiant_img
        '
        Me.etudiant_img.BackColor = System.Drawing.Color.Transparent
        Me.etudiant_img.BackgroundImage = Global.GestionDesEtudiants.My.Resources.Resources.userWhite
        Me.etudiant_img.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.etudiant_img.Location = New System.Drawing.Point(70, 92)
        Me.etudiant_img.Name = "etudiant_img"
        Me.etudiant_img.Size = New System.Drawing.Size(40, 40)
        Me.etudiant_img.TabIndex = 39
        Me.etudiant_img.TabStop = False
        '
        'notes_img
        '
        Me.notes_img.BackColor = System.Drawing.Color.Transparent
        Me.notes_img.BackgroundImage = Global.GestionDesEtudiants.My.Resources.Resources.exam
        Me.notes_img.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.notes_img.Location = New System.Drawing.Point(438, 98)
        Me.notes_img.Name = "notes_img"
        Me.notes_img.Size = New System.Drawing.Size(40, 40)
        Me.notes_img.TabIndex = 40
        Me.notes_img.TabStop = False
        '
        'note1_l
        '
        Me.note1_l.AutoSize = True
        Me.note1_l.BackColor = System.Drawing.Color.White
        Me.note1_l.Font = New System.Drawing.Font("Roboto", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.note1_l.ForeColor = System.Drawing.Color.Gray
        Me.note1_l.Location = New System.Drawing.Point(440, 149)
        Me.note1_l.Name = "note1_l"
        Me.note1_l.Size = New System.Drawing.Size(138, 15)
        Me.note1_l.TabIndex = 41
        Me.note1_l.Text = "Programmation Avancee"
        '
        'note2_l
        '
        Me.note2_l.AutoSize = True
        Me.note2_l.BackColor = System.Drawing.Color.White
        Me.note2_l.Font = New System.Drawing.Font("Roboto", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.note2_l.ForeColor = System.Drawing.Color.Gray
        Me.note2_l.Location = New System.Drawing.Point(440, 209)
        Me.note2_l.Name = "note2_l"
        Me.note2_l.Size = New System.Drawing.Size(167, 15)
        Me.note2_l.TabIndex = 44
        Me.note2_l.Text = "Programmation Evenmentielle"
        '
        'note2_tb
        '
        Me.note2_tb.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.note2_tb.Font = New System.Drawing.Font("Roboto", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.note2_tb.ForeColor = System.Drawing.Color.Black
        Me.note2_tb.Location = New System.Drawing.Point(444, 224)
        Me.note2_tb.MaxLength = 5
        Me.note2_tb.Name = "note2_tb"
        Me.note2_tb.Size = New System.Drawing.Size(170, 26)
        Me.note2_tb.TabIndex = 8
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox3.BackgroundImage = Global.GestionDesEtudiants.My.Resources.Resources.square2_BG
        Me.PictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox3.Location = New System.Drawing.Point(416, 200)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(231, 60)
        Me.PictureBox3.TabIndex = 42
        Me.PictureBox3.TabStop = False
        '
        'note3_l
        '
        Me.note3_l.AutoSize = True
        Me.note3_l.BackColor = System.Drawing.Color.White
        Me.note3_l.Font = New System.Drawing.Font("Roboto", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.note3_l.ForeColor = System.Drawing.Color.Gray
        Me.note3_l.Location = New System.Drawing.Point(440, 269)
        Me.note3_l.Name = "note3_l"
        Me.note3_l.Size = New System.Drawing.Size(98, 15)
        Me.note3_l.TabIndex = 47
        Me.note3_l.Text = "Base de donnees"
        '
        'note3_tb
        '
        Me.note3_tb.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.note3_tb.Font = New System.Drawing.Font("Roboto", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.note3_tb.ForeColor = System.Drawing.Color.Black
        Me.note3_tb.Location = New System.Drawing.Point(444, 284)
        Me.note3_tb.MaxLength = 5
        Me.note3_tb.Name = "note3_tb"
        Me.note3_tb.Size = New System.Drawing.Size(170, 26)
        Me.note3_tb.TabIndex = 9
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox4.BackgroundImage = Global.GestionDesEtudiants.My.Resources.Resources.square2_BG
        Me.PictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox4.Location = New System.Drawing.Point(416, 260)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(231, 60)
        Me.PictureBox4.TabIndex = 45
        Me.PictureBox4.TabStop = False
        '
        'note4_l
        '
        Me.note4_l.AutoSize = True
        Me.note4_l.BackColor = System.Drawing.Color.White
        Me.note4_l.Font = New System.Drawing.Font("Roboto", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.note4_l.ForeColor = System.Drawing.Color.Gray
        Me.note4_l.Location = New System.Drawing.Point(440, 329)
        Me.note4_l.Name = "note4_l"
        Me.note4_l.Size = New System.Drawing.Size(133, 15)
        Me.note4_l.TabIndex = 50
        Me.note4_l.Text = "Systemes d'exploitation"
        '
        'note4_tb
        '
        Me.note4_tb.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.note4_tb.Font = New System.Drawing.Font("Roboto", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.note4_tb.ForeColor = System.Drawing.Color.Black
        Me.note4_tb.Location = New System.Drawing.Point(444, 344)
        Me.note4_tb.MaxLength = 5
        Me.note4_tb.Name = "note4_tb"
        Me.note4_tb.Size = New System.Drawing.Size(170, 26)
        Me.note4_tb.TabIndex = 10
        '
        'PictureBox5
        '
        Me.PictureBox5.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox5.BackgroundImage = Global.GestionDesEtudiants.My.Resources.Resources.square2_BG
        Me.PictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox5.Location = New System.Drawing.Point(416, 320)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(231, 60)
        Me.PictureBox5.TabIndex = 48
        Me.PictureBox5.TabStop = False
        '
        'note5_l
        '
        Me.note5_l.AutoSize = True
        Me.note5_l.BackColor = System.Drawing.Color.White
        Me.note5_l.Font = New System.Drawing.Font("Roboto", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.note5_l.ForeColor = System.Drawing.Color.Gray
        Me.note5_l.Location = New System.Drawing.Point(440, 389)
        Me.note5_l.Name = "note5_l"
        Me.note5_l.Size = New System.Drawing.Size(49, 15)
        Me.note5_l.TabIndex = 53
        Me.note5_l.Text = "Analyse"
        '
        'note5_tb
        '
        Me.note5_tb.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.note5_tb.Font = New System.Drawing.Font("Roboto", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.note5_tb.ForeColor = System.Drawing.Color.Black
        Me.note5_tb.Location = New System.Drawing.Point(444, 404)
        Me.note5_tb.MaxLength = 5
        Me.note5_tb.Name = "note5_tb"
        Me.note5_tb.Size = New System.Drawing.Size(170, 26)
        Me.note5_tb.TabIndex = 11
        '
        'PictureBox6
        '
        Me.PictureBox6.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox6.BackgroundImage = Global.GestionDesEtudiants.My.Resources.Resources.square2_BG
        Me.PictureBox6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox6.Location = New System.Drawing.Point(416, 380)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(231, 60)
        Me.PictureBox6.TabIndex = 51
        Me.PictureBox6.TabStop = False
        '
        'note6_l
        '
        Me.note6_l.AutoSize = True
        Me.note6_l.BackColor = System.Drawing.Color.White
        Me.note6_l.Font = New System.Drawing.Font("Roboto", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.note6_l.ForeColor = System.Drawing.Color.Gray
        Me.note6_l.Location = New System.Drawing.Point(440, 449)
        Me.note6_l.Name = "note6_l"
        Me.note6_l.Size = New System.Drawing.Size(64, 15)
        Me.note6_l.TabIndex = 56
        Me.note6_l.Text = "Statistique"
        '
        'note6_tb
        '
        Me.note6_tb.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.note6_tb.Font = New System.Drawing.Font("Roboto", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.note6_tb.ForeColor = System.Drawing.Color.Black
        Me.note6_tb.Location = New System.Drawing.Point(444, 464)
        Me.note6_tb.MaxLength = 5
        Me.note6_tb.Name = "note6_tb"
        Me.note6_tb.Size = New System.Drawing.Size(170, 26)
        Me.note6_tb.TabIndex = 12
        '
        'PictureBox7
        '
        Me.PictureBox7.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox7.BackgroundImage = Global.GestionDesEtudiants.My.Resources.Resources.square2_BG
        Me.PictureBox7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox7.Location = New System.Drawing.Point(416, 440)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(231, 60)
        Me.PictureBox7.TabIndex = 54
        Me.PictureBox7.TabStop = False
        '
        'note7_l
        '
        Me.note7_l.AutoSize = True
        Me.note7_l.BackColor = System.Drawing.Color.White
        Me.note7_l.Font = New System.Drawing.Font("Roboto", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.note7_l.ForeColor = System.Drawing.Color.Gray
        Me.note7_l.Location = New System.Drawing.Point(440, 509)
        Me.note7_l.Name = "note7_l"
        Me.note7_l.Size = New System.Drawing.Size(136, 15)
        Me.note7_l.TabIndex = 59
        Me.note7_l.Text = "Electronique analogique"
        '
        'note7_tb
        '
        Me.note7_tb.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.note7_tb.Font = New System.Drawing.Font("Roboto", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.note7_tb.ForeColor = System.Drawing.Color.Black
        Me.note7_tb.Location = New System.Drawing.Point(444, 524)
        Me.note7_tb.MaxLength = 5
        Me.note7_tb.Name = "note7_tb"
        Me.note7_tb.Size = New System.Drawing.Size(170, 26)
        Me.note7_tb.TabIndex = 13
        '
        'PictureBox8
        '
        Me.PictureBox8.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox8.BackgroundImage = Global.GestionDesEtudiants.My.Resources.Resources.square2_BG
        Me.PictureBox8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox8.Location = New System.Drawing.Point(416, 500)
        Me.PictureBox8.Name = "PictureBox8"
        Me.PictureBox8.Size = New System.Drawing.Size(231, 60)
        Me.PictureBox8.TabIndex = 57
        Me.PictureBox8.TabStop = False
        '
        'erreur_l
        '
        Me.erreur_l.AutoSize = True
        Me.erreur_l.BackColor = System.Drawing.Color.Transparent
        Me.erreur_l.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.erreur_l.Font = New System.Drawing.Font("Roboto Lt", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.erreur_l.ForeColor = System.Drawing.Color.Crimson
        Me.erreur_l.Location = New System.Drawing.Point(245, 572)
        Me.erreur_l.Name = "erreur_l"
        Me.erreur_l.Size = New System.Drawing.Size(224, 23)
        Me.erreur_l.TabIndex = 60
        Me.erreur_l.Text = "Erreur vérifier votre entrée"
        Me.erreur_l.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.erreur_l.Visible = False
        '
        'filiere_l
        '
        Me.filiere_l.AutoSize = True
        Me.filiere_l.BackColor = System.Drawing.Color.White
        Me.filiere_l.Font = New System.Drawing.Font("Roboto", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.filiere_l.ForeColor = System.Drawing.Color.Gray
        Me.filiere_l.Location = New System.Drawing.Point(75, 509)
        Me.filiere_l.Name = "filiere_l"
        Me.filiere_l.Size = New System.Drawing.Size(39, 15)
        Me.filiere_l.TabIndex = 121
        Me.filiere_l.Text = "Filiere"
        '
        'sexe_l
        '
        Me.sexe_l.AutoSize = True
        Me.sexe_l.BackColor = System.Drawing.Color.White
        Me.sexe_l.Font = New System.Drawing.Font("Roboto", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sexe_l.ForeColor = System.Drawing.Color.Gray
        Me.sexe_l.Location = New System.Drawing.Point(75, 449)
        Me.sexe_l.Name = "sexe_l"
        Me.sexe_l.Size = New System.Drawing.Size(32, 15)
        Me.sexe_l.TabIndex = 120
        Me.sexe_l.Text = "Sexe"
        '
        'email_l
        '
        Me.email_l.AutoSize = True
        Me.email_l.BackColor = System.Drawing.Color.White
        Me.email_l.Font = New System.Drawing.Font("Roboto", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.email_l.ForeColor = System.Drawing.Color.Gray
        Me.email_l.Location = New System.Drawing.Point(75, 329)
        Me.email_l.Name = "email_l"
        Me.email_l.Size = New System.Drawing.Size(36, 15)
        Me.email_l.TabIndex = 119
        Me.email_l.Text = "Email"
        '
        'prenom_l
        '
        Me.prenom_l.AutoSize = True
        Me.prenom_l.BackColor = System.Drawing.Color.White
        Me.prenom_l.Font = New System.Drawing.Font("Roboto", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.prenom_l.ForeColor = System.Drawing.Color.Gray
        Me.prenom_l.Location = New System.Drawing.Point(75, 269)
        Me.prenom_l.Name = "prenom_l"
        Me.prenom_l.Size = New System.Drawing.Size(49, 15)
        Me.prenom_l.TabIndex = 118
        Me.prenom_l.Text = "Prenom"
        '
        'nom_l
        '
        Me.nom_l.AutoSize = True
        Me.nom_l.BackColor = System.Drawing.Color.White
        Me.nom_l.Font = New System.Drawing.Font("Roboto", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nom_l.ForeColor = System.Drawing.Color.Gray
        Me.nom_l.Location = New System.Drawing.Point(75, 209)
        Me.nom_l.Name = "nom_l"
        Me.nom_l.Size = New System.Drawing.Size(32, 15)
        Me.nom_l.TabIndex = 117
        Me.nom_l.Text = "Nom"
        '
        'cin_l
        '
        Me.cin_l.AutoSize = True
        Me.cin_l.BackColor = System.Drawing.Color.White
        Me.cin_l.Font = New System.Drawing.Font("Roboto", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cin_l.ForeColor = System.Drawing.Color.Gray
        Me.cin_l.Location = New System.Drawing.Point(75, 149)
        Me.cin_l.Name = "cin_l"
        Me.cin_l.Size = New System.Drawing.Size(26, 15)
        Me.cin_l.TabIndex = 116
        Me.cin_l.Text = "CIN"
        '
        'erreur_exception_l
        '
        Me.erreur_exception_l.AutoSize = True
        Me.erreur_exception_l.BackColor = System.Drawing.Color.Transparent
        Me.erreur_exception_l.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.erreur_exception_l.Font = New System.Drawing.Font("Roboto Lt", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.erreur_exception_l.ForeColor = System.Drawing.Color.Crimson
        Me.erreur_exception_l.Location = New System.Drawing.Point(147, 17)
        Me.erreur_exception_l.Name = "erreur_exception_l"
        Me.erreur_exception_l.Size = New System.Drawing.Size(0, 14)
        Me.erreur_exception_l.TabIndex = 122
        Me.erreur_exception_l.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.erreur_exception_l.Visible = False
        '
        'enregister_l
        '
        Me.enregister_l.AutoSize = True
        Me.enregister_l.BackColor = System.Drawing.Color.Transparent
        Me.enregister_l.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.enregister_l.Font = New System.Drawing.Font("Roboto Lt", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.enregister_l.ForeColor = System.Drawing.Color.LawnGreen
        Me.enregister_l.Location = New System.Drawing.Point(303, 572)
        Me.enregister_l.Name = "enregister_l"
        Me.enregister_l.Size = New System.Drawing.Size(94, 23)
        Me.enregister_l.TabIndex = 123
        Me.enregister_l.Text = "enregistré"
        Me.enregister_l.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.enregister_l.Visible = False
        '
        'AjouterPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.GestionDesEtudiants.My.Resources.Resources.BG2
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(694, 671)
        Me.Controls.Add(Me.enregister_l)
        Me.Controls.Add(Me.erreur_exception_l)
        Me.Controls.Add(Me.filiere_l)
        Me.Controls.Add(Me.sexe_l)
        Me.Controls.Add(Me.email_l)
        Me.Controls.Add(Me.prenom_l)
        Me.Controls.Add(Me.nom_l)
        Me.Controls.Add(Me.cin_l)
        Me.Controls.Add(Me.erreur_l)
        Me.Controls.Add(Me.note7_l)
        Me.Controls.Add(Me.note7_tb)
        Me.Controls.Add(Me.PictureBox8)
        Me.Controls.Add(Me.note6_l)
        Me.Controls.Add(Me.note6_tb)
        Me.Controls.Add(Me.PictureBox7)
        Me.Controls.Add(Me.note5_l)
        Me.Controls.Add(Me.note5_tb)
        Me.Controls.Add(Me.PictureBox6)
        Me.Controls.Add(Me.note4_l)
        Me.Controls.Add(Me.note4_tb)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.note3_l)
        Me.Controls.Add(Me.note3_tb)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.note2_l)
        Me.Controls.Add(Me.note2_tb)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.note1_l)
        Me.Controls.Add(Me.notes_img)
        Me.Controls.Add(Me.etudiant_img)
        Me.Controls.Add(Me.notes_l)
        Me.Controls.Add(Me.note1_tb)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.etudiant_l)
        Me.Controls.Add(Me.email_tb)
        Me.Controls.Add(Me.email_bg)
        Me.Controls.Add(Me.filiere_cb)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.sex_cb)
        Me.Controls.Add(Me.sex_bg)
        Me.Controls.Add(Me.prenom_tb)
        Me.Controls.Add(Me.prenom_bg)
        Me.Controls.Add(Me.nom_tb)
        Me.Controls.Add(Me.name_bg)
        Me.Controls.Add(Me.save_btn)
        Me.Controls.Add(Me.cin_tb)
        Me.Controls.Add(Me.cin_bg)
        Me.Controls.Add(Me.title_l)
        Me.Controls.Add(Me.back_btn)
        Me.Controls.Add(Me.birthdate_picker)
        Me.Controls.Add(Me.birthdate_bg)
        Me.DoubleBuffered = True
        Me.ForeColor = System.Drawing.Color.Gray
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "AjouterPage"
        Me.Text = "Gestion des etudiants - Ajouter"
        CType(Me.cin_bg, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.name_bg, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.birthdate_bg, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.prenom_bg, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sex_bg, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.email_bg, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.etudiant_img, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.notes_img, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents back_btn As System.Windows.Forms.Button
    Friend WithEvents title_l As System.Windows.Forms.Label
    Friend WithEvents cin_tb As System.Windows.Forms.TextBox
    Friend WithEvents cin_bg As System.Windows.Forms.PictureBox
    Friend WithEvents save_btn As System.Windows.Forms.Button
    Friend WithEvents nom_tb As System.Windows.Forms.TextBox
    Friend WithEvents name_bg As System.Windows.Forms.PictureBox
    Friend WithEvents birthdate_bg As System.Windows.Forms.PictureBox
    Friend WithEvents prenom_tb As System.Windows.Forms.TextBox
    Friend WithEvents prenom_bg As System.Windows.Forms.PictureBox
    Friend WithEvents sex_bg As System.Windows.Forms.PictureBox
    Friend WithEvents sex_cb As System.Windows.Forms.ComboBox
    Friend WithEvents birthdate_picker As System.Windows.Forms.DateTimePicker
    Friend WithEvents filiere_cb As System.Windows.Forms.ComboBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents email_tb As System.Windows.Forms.TextBox
    Friend WithEvents email_bg As System.Windows.Forms.PictureBox
    Friend WithEvents etudiant_l As System.Windows.Forms.Label
    Friend WithEvents notes_l As System.Windows.Forms.Label
    Friend WithEvents note1_tb As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents etudiant_img As System.Windows.Forms.PictureBox
    Friend WithEvents notes_img As System.Windows.Forms.PictureBox
    Friend WithEvents note1_l As System.Windows.Forms.Label
    Friend WithEvents note2_l As System.Windows.Forms.Label
    Friend WithEvents note2_tb As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents note3_l As System.Windows.Forms.Label
    Friend WithEvents note3_tb As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents note4_l As System.Windows.Forms.Label
    Friend WithEvents note4_tb As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox5 As System.Windows.Forms.PictureBox
    Friend WithEvents note5_l As System.Windows.Forms.Label
    Friend WithEvents note5_tb As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox6 As System.Windows.Forms.PictureBox
    Friend WithEvents note6_l As System.Windows.Forms.Label
    Friend WithEvents note6_tb As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox7 As System.Windows.Forms.PictureBox
    Friend WithEvents note7_l As System.Windows.Forms.Label
    Friend WithEvents note7_tb As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox8 As System.Windows.Forms.PictureBox
    Friend WithEvents erreur_l As System.Windows.Forms.Label
    Friend WithEvents filiere_l As System.Windows.Forms.Label
    Friend WithEvents sexe_l As System.Windows.Forms.Label
    Friend WithEvents email_l As System.Windows.Forms.Label
    Friend WithEvents prenom_l As System.Windows.Forms.Label
    Friend WithEvents nom_l As System.Windows.Forms.Label
    Friend WithEvents cin_l As System.Windows.Forms.Label
    Friend WithEvents erreur_exception_l As System.Windows.Forms.Label
    Friend WithEvents enregister_l As System.Windows.Forms.Label
End Class
