<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoginPage
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
        Me.signin_label = New System.Windows.Forms.Label()
        Me.usericon_pic = New System.Windows.Forms.PictureBox()
        Me.username_bg = New System.Windows.Forms.PictureBox()
        Me.username_tb = New System.Windows.Forms.TextBox()
        Me.username_pic = New System.Windows.Forms.PictureBox()
        Me.password_pic = New System.Windows.Forms.PictureBox()
        Me.password_tb = New System.Windows.Forms.TextBox()
        Me.password_bg = New System.Windows.Forms.PictureBox()
        Me.login_btn = New System.Windows.Forms.Button()
        Me.erreur_l = New System.Windows.Forms.Label()
        CType(Me.usericon_pic, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.username_bg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.username_pic, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.password_pic, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.password_bg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'signin_label
        '
        Me.signin_label.AutoSize = True
        Me.signin_label.BackColor = System.Drawing.Color.Transparent
        Me.signin_label.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.signin_label.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.signin_label.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.signin_label.Location = New System.Drawing.Point(278, 192)
        Me.signin_label.Name = "signin_label"
        Me.signin_label.Size = New System.Drawing.Size(133, 42)
        Me.signin_label.TabIndex = 1
        Me.signin_label.Text = "Sign In"
        '
        'usericon_pic
        '
        Me.usericon_pic.BackColor = System.Drawing.Color.Transparent
        Me.usericon_pic.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.usericon2
        Me.usericon_pic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.usericon_pic.Location = New System.Drawing.Point(296, 98)
        Me.usericon_pic.Name = "usericon_pic"
        Me.usericon_pic.Size = New System.Drawing.Size(90, 90)
        Me.usericon_pic.TabIndex = 2
        Me.usericon_pic.TabStop = False
        '
        'username_bg
        '
        Me.username_bg.BackColor = System.Drawing.Color.Transparent
        Me.username_bg.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.square2_BG
        Me.username_bg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.username_bg.Location = New System.Drawing.Point(187, 251)
        Me.username_bg.Name = "username_bg"
        Me.username_bg.Size = New System.Drawing.Size(320, 60)
        Me.username_bg.TabIndex = 4
        Me.username_bg.TabStop = False
        '
        'username_tb
        '
        Me.username_tb.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.username_tb.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.username_tb.ForeColor = System.Drawing.Color.Gray
        Me.username_tb.Location = New System.Drawing.Point(253, 268)
        Me.username_tb.MaxLength = 64
        Me.username_tb.Name = "username_tb"
        Me.username_tb.Size = New System.Drawing.Size(220, 24)
        Me.username_tb.TabIndex = 5
        Me.username_tb.Text = "Username"
        '
        'username_pic
        '
        Me.username_pic.BackColor = System.Drawing.Color.White
        Me.username_pic.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.user
        Me.username_pic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.username_pic.Location = New System.Drawing.Point(200, 266)
        Me.username_pic.Name = "username_pic"
        Me.username_pic.Size = New System.Drawing.Size(30, 30)
        Me.username_pic.TabIndex = 6
        Me.username_pic.TabStop = False
        '
        'password_pic
        '
        Me.password_pic.BackColor = System.Drawing.Color.White
        Me.password_pic.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.padlock
        Me.password_pic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.password_pic.Location = New System.Drawing.Point(200, 354)
        Me.password_pic.Name = "password_pic"
        Me.password_pic.Size = New System.Drawing.Size(30, 30)
        Me.password_pic.TabIndex = 9
        Me.password_pic.TabStop = False
        '
        'password_tb
        '
        Me.password_tb.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.password_tb.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.password_tb.ForeColor = System.Drawing.Color.Gray
        Me.password_tb.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.password_tb.Location = New System.Drawing.Point(253, 356)
        Me.password_tb.MaxLength = 64
        Me.password_tb.Name = "password_tb"
        Me.password_tb.Size = New System.Drawing.Size(220, 24)
        Me.password_tb.TabIndex = 8
        Me.password_tb.Text = "Password"
        '
        'password_bg
        '
        Me.password_bg.BackColor = System.Drawing.Color.Transparent
        Me.password_bg.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.square2_BG
        Me.password_bg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.password_bg.Location = New System.Drawing.Point(187, 339)
        Me.password_bg.Name = "password_bg"
        Me.password_bg.Size = New System.Drawing.Size(320, 60)
        Me.password_bg.TabIndex = 7
        Me.password_bg.TabStop = False
        '
        'login_btn
        '
        Me.login_btn.BackColor = System.Drawing.Color.Transparent
        Me.login_btn.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.Button
        Me.login_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.login_btn.FlatAppearance.BorderSize = 0
        Me.login_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.login_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.login_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.login_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.login_btn.ForeColor = System.Drawing.Color.White
        Me.login_btn.Location = New System.Drawing.Point(187, 427)
        Me.login_btn.Name = "login_btn"
        Me.login_btn.Size = New System.Drawing.Size(320, 60)
        Me.login_btn.TabIndex = 10
        Me.login_btn.Text = "Log In"
        Me.login_btn.UseVisualStyleBackColor = False
        '
        'erreur_l
        '
        Me.erreur_l.AutoSize = True
        Me.erreur_l.BackColor = System.Drawing.Color.Transparent
        Me.erreur_l.Font = New System.Drawing.Font("Roboto Lt", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.erreur_l.ForeColor = System.Drawing.Color.Crimson
        Me.erreur_l.Location = New System.Drawing.Point(225, 318)
        Me.erreur_l.Name = "erreur_l"
        Me.erreur_l.Size = New System.Drawing.Size(242, 18)
        Me.erreur_l.TabIndex = 11
        Me.erreur_l.Text = "Sorry, your password was incorrect."
        Me.erreur_l.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.erreur_l.Visible = False
        '
        'LoginPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.BG21
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(694, 671)
        Me.Controls.Add(Me.erreur_l)
        Me.Controls.Add(Me.login_btn)
        Me.Controls.Add(Me.password_pic)
        Me.Controls.Add(Me.password_tb)
        Me.Controls.Add(Me.password_bg)
        Me.Controls.Add(Me.username_pic)
        Me.Controls.Add(Me.username_tb)
        Me.Controls.Add(Me.username_bg)
        Me.Controls.Add(Me.usericon_pic)
        Me.Controls.Add(Me.signin_label)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "LoginPage"
        Me.ShowIcon = False
        Me.Text = "Gestion des etudiants - Sign In"
        CType(Me.usericon_pic, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.username_bg, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.username_pic, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.password_pic, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.password_bg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents signin_label As System.Windows.Forms.Label
    Friend WithEvents usericon_pic As System.Windows.Forms.PictureBox
    Friend WithEvents username_bg As System.Windows.Forms.PictureBox
    Friend WithEvents username_tb As System.Windows.Forms.TextBox
    Friend WithEvents username_pic As System.Windows.Forms.PictureBox
    Friend WithEvents password_pic As System.Windows.Forms.PictureBox
    Friend WithEvents password_tb As System.Windows.Forms.TextBox
    Friend WithEvents password_bg As System.Windows.Forms.PictureBox
    Friend WithEvents login_btn As System.Windows.Forms.Button
    Friend WithEvents erreur_l As System.Windows.Forms.Label

End Class
