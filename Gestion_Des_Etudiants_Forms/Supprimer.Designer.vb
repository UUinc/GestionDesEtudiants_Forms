<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SupprimerPage
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
        Me.title_l = New System.Windows.Forms.Label()
        Me.back_btn = New System.Windows.Forms.Button()
        Me.etudiant_img = New System.Windows.Forms.PictureBox()
        Me.etudiant_l = New System.Windows.Forms.Label()
        Me.cin_tb = New System.Windows.Forms.TextBox()
        Me.cin_bg = New System.Windows.Forms.PictureBox()
        Me.erreur_l = New System.Windows.Forms.Label()
        Me.supprimer_btn = New System.Windows.Forms.Button()
        CType(Me.etudiant_img, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cin_bg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'title_l
        '
        Me.title_l.AutoSize = True
        Me.title_l.BackColor = System.Drawing.Color.Transparent
        Me.title_l.Font = New System.Drawing.Font("Roboto", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.title_l.ForeColor = System.Drawing.Color.White
        Me.title_l.Location = New System.Drawing.Point(53, 14)
        Me.title_l.Name = "title_l"
        Me.title_l.Size = New System.Drawing.Size(100, 24)
        Me.title_l.TabIndex = 3
        Me.title_l.Text = "Supprimer"
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
        Me.back_btn.TabIndex = 2
        Me.back_btn.UseVisualStyleBackColor = False
        '
        'etudiant_img
        '
        Me.etudiant_img.BackColor = System.Drawing.Color.Transparent
        Me.etudiant_img.BackgroundImage = Global.GestionDesEtudiants.My.Resources.Resources.userWhite
        Me.etudiant_img.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.etudiant_img.Location = New System.Drawing.Point(246, 194)
        Me.etudiant_img.Name = "etudiant_img"
        Me.etudiant_img.Size = New System.Drawing.Size(40, 40)
        Me.etudiant_img.TabIndex = 43
        Me.etudiant_img.TabStop = False
        '
        'etudiant_l
        '
        Me.etudiant_l.AutoSize = True
        Me.etudiant_l.BackColor = System.Drawing.Color.Transparent
        Me.etudiant_l.Font = New System.Drawing.Font("Roboto", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.etudiant_l.ForeColor = System.Drawing.Color.White
        Me.etudiant_l.Location = New System.Drawing.Point(293, 202)
        Me.etudiant_l.Name = "etudiant_l"
        Me.etudiant_l.Size = New System.Drawing.Size(136, 39)
        Me.etudiant_l.TabIndex = 42
        Me.etudiant_l.Text = "Etudiant"
        '
        'cin_tb
        '
        Me.cin_tb.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.cin_tb.Font = New System.Drawing.Font("Roboto", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cin_tb.ForeColor = System.Drawing.Color.Gray
        Me.cin_tb.Location = New System.Drawing.Point(253, 259)
        Me.cin_tb.MaxLength = 64
        Me.cin_tb.Name = "cin_tb"
        Me.cin_tb.Size = New System.Drawing.Size(170, 26)
        Me.cin_tb.TabIndex = 40
        Me.cin_tb.Text = "CIN"
        '
        'cin_bg
        '
        Me.cin_bg.BackColor = System.Drawing.Color.Transparent
        Me.cin_bg.BackgroundImage = Global.GestionDesEtudiants.My.Resources.Resources.square2_BG
        Me.cin_bg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.cin_bg.Location = New System.Drawing.Point(226, 242)
        Me.cin_bg.Name = "cin_bg"
        Me.cin_bg.Size = New System.Drawing.Size(231, 60)
        Me.cin_bg.TabIndex = 41
        Me.cin_bg.TabStop = False
        '
        'erreur_l
        '
        Me.erreur_l.AutoSize = True
        Me.erreur_l.BackColor = System.Drawing.Color.Transparent
        Me.erreur_l.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.erreur_l.Font = New System.Drawing.Font("Roboto Lt", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.erreur_l.ForeColor = System.Drawing.Color.Crimson
        Me.erreur_l.Location = New System.Drawing.Point(231, 308)
        Me.erreur_l.Name = "erreur_l"
        Me.erreur_l.Size = New System.Drawing.Size(224, 23)
        Me.erreur_l.TabIndex = 62
        Me.erreur_l.Text = "Erreur vérifier votre entrée"
        Me.erreur_l.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.erreur_l.Visible = False
        '
        'supprimer_btn
        '
        Me.supprimer_btn.BackColor = System.Drawing.Color.Transparent
        Me.supprimer_btn.BackgroundImage = Global.GestionDesEtudiants.My.Resources.Resources.Button_smaller
        Me.supprimer_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.supprimer_btn.FlatAppearance.BorderSize = 0
        Me.supprimer_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.supprimer_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.supprimer_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.supprimer_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.supprimer_btn.ForeColor = System.Drawing.Color.White
        Me.supprimer_btn.Location = New System.Drawing.Point(244, 335)
        Me.supprimer_btn.Name = "supprimer_btn"
        Me.supprimer_btn.Size = New System.Drawing.Size(195, 60)
        Me.supprimer_btn.TabIndex = 61
        Me.supprimer_btn.Text = "Supprimer"
        Me.supprimer_btn.UseVisualStyleBackColor = False
        '
        'SupprimerPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.GestionDesEtudiants.My.Resources.Resources.BG2
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(694, 671)
        Me.Controls.Add(Me.erreur_l)
        Me.Controls.Add(Me.supprimer_btn)
        Me.Controls.Add(Me.etudiant_img)
        Me.Controls.Add(Me.etudiant_l)
        Me.Controls.Add(Me.cin_tb)
        Me.Controls.Add(Me.cin_bg)
        Me.Controls.Add(Me.title_l)
        Me.Controls.Add(Me.back_btn)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "SupprimerPage"
        Me.Text = "Gestion des etudiants - Supprimer"
        CType(Me.etudiant_img, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cin_bg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents title_l As System.Windows.Forms.Label
    Friend WithEvents back_btn As System.Windows.Forms.Button
    Friend WithEvents etudiant_img As System.Windows.Forms.PictureBox
    Friend WithEvents etudiant_l As System.Windows.Forms.Label
    Friend WithEvents cin_tb As System.Windows.Forms.TextBox
    Friend WithEvents cin_bg As System.Windows.Forms.PictureBox
    Friend WithEvents erreur_l As System.Windows.Forms.Label
    Friend WithEvents supprimer_btn As System.Windows.Forms.Button
End Class
