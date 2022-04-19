<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Home
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
        Me.ajouter_l = New System.Windows.Forms.Label()
        Me.modifier_l = New System.Windows.Forms.Label()
        Me.supprimer_l = New System.Windows.Forms.Label()
        Me.afficher_l = New System.Windows.Forms.Label()
        Me.Ajouter_btn = New System.Windows.Forms.Button()
        Me.modifier_btn = New System.Windows.Forms.Button()
        Me.Supprimer_btn = New System.Windows.Forms.Button()
        Me.Afficher_btn = New System.Windows.Forms.Button()
        Me.HomeTitle_l = New System.Windows.Forms.Label()
        Me.logout_btn = New System.Windows.Forms.Button()
        Me.logout_l = New System.Windows.Forms.Label()
        Me.homeLabel_l = New System.Windows.Forms.Label()
        Me.homeIcon_img = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ajouter_l
        '
        Me.ajouter_l.AutoSize = True
        Me.ajouter_l.BackColor = System.Drawing.Color.Transparent
        Me.ajouter_l.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ajouter_l.Font = New System.Drawing.Font("Roboto Medium", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ajouter_l.ForeColor = System.Drawing.Color.White
        Me.ajouter_l.Location = New System.Drawing.Point(66, 513)
        Me.ajouter_l.Name = "ajouter_l"
        Me.ajouter_l.Size = New System.Drawing.Size(124, 38)
        Me.ajouter_l.TabIndex = 1
        Me.ajouter_l.Text = "ajouter"
        '
        'modifier_l
        '
        Me.modifier_l.AutoSize = True
        Me.modifier_l.BackColor = System.Drawing.Color.Transparent
        Me.modifier_l.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.modifier_l.Font = New System.Drawing.Font("Roboto Medium", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.modifier_l.ForeColor = System.Drawing.Color.White
        Me.modifier_l.Location = New System.Drawing.Point(271, 513)
        Me.modifier_l.Name = "modifier_l"
        Me.modifier_l.Size = New System.Drawing.Size(143, 38)
        Me.modifier_l.TabIndex = 2
        Me.modifier_l.Text = "modifier"
        '
        'supprimer_l
        '
        Me.supprimer_l.AutoSize = True
        Me.supprimer_l.BackColor = System.Drawing.Color.Transparent
        Me.supprimer_l.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.supprimer_l.Font = New System.Drawing.Font("Roboto Medium", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.supprimer_l.ForeColor = System.Drawing.Color.White
        Me.supprimer_l.Location = New System.Drawing.Point(468, 513)
        Me.supprimer_l.Name = "supprimer_l"
        Me.supprimer_l.Size = New System.Drawing.Size(172, 38)
        Me.supprimer_l.TabIndex = 3
        Me.supprimer_l.Text = "supprimer"
        '
        'afficher_l
        '
        Me.afficher_l.AutoSize = True
        Me.afficher_l.BackColor = System.Drawing.Color.Transparent
        Me.afficher_l.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.afficher_l.Font = New System.Drawing.Font("Roboto Medium", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.afficher_l.ForeColor = System.Drawing.Color.White
        Me.afficher_l.Location = New System.Drawing.Point(702, 513)
        Me.afficher_l.Name = "afficher_l"
        Me.afficher_l.Size = New System.Drawing.Size(132, 38)
        Me.afficher_l.TabIndex = 4
        Me.afficher_l.Text = "afficher"
        '
        'Ajouter_btn
        '
        Me.Ajouter_btn.BackColor = System.Drawing.Color.Transparent
        Me.Ajouter_btn.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.usericon2
        Me.Ajouter_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Ajouter_btn.FlatAppearance.BorderSize = 0
        Me.Ajouter_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Ajouter_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Ajouter_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Ajouter_btn.Location = New System.Drawing.Point(50, 350)
        Me.Ajouter_btn.Name = "Ajouter_btn"
        Me.Ajouter_btn.Size = New System.Drawing.Size(150, 150)
        Me.Ajouter_btn.TabIndex = 9
        Me.Ajouter_btn.UseVisualStyleBackColor = False
        '
        'modifier_btn
        '
        Me.modifier_btn.BackColor = System.Drawing.Color.Transparent
        Me.modifier_btn.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.usericon2
        Me.modifier_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.modifier_btn.FlatAppearance.BorderSize = 0
        Me.modifier_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.modifier_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.modifier_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.modifier_btn.Location = New System.Drawing.Point(265, 350)
        Me.modifier_btn.Name = "modifier_btn"
        Me.modifier_btn.Size = New System.Drawing.Size(150, 150)
        Me.modifier_btn.TabIndex = 10
        Me.modifier_btn.UseVisualStyleBackColor = False
        '
        'Supprimer_btn
        '
        Me.Supprimer_btn.BackColor = System.Drawing.Color.Transparent
        Me.Supprimer_btn.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.usericon2
        Me.Supprimer_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Supprimer_btn.FlatAppearance.BorderSize = 0
        Me.Supprimer_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Supprimer_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Supprimer_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Supprimer_btn.Location = New System.Drawing.Point(475, 350)
        Me.Supprimer_btn.Name = "Supprimer_btn"
        Me.Supprimer_btn.Size = New System.Drawing.Size(150, 150)
        Me.Supprimer_btn.TabIndex = 11
        Me.Supprimer_btn.UseVisualStyleBackColor = False
        '
        'Afficher_btn
        '
        Me.Afficher_btn.BackColor = System.Drawing.Color.Transparent
        Me.Afficher_btn.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.usericon2
        Me.Afficher_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Afficher_btn.FlatAppearance.BorderSize = 0
        Me.Afficher_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Afficher_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Afficher_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Afficher_btn.Location = New System.Drawing.Point(690, 350)
        Me.Afficher_btn.Name = "Afficher_btn"
        Me.Afficher_btn.Size = New System.Drawing.Size(150, 150)
        Me.Afficher_btn.TabIndex = 12
        Me.Afficher_btn.UseVisualStyleBackColor = False
        '
        'HomeTitle_l
        '
        Me.HomeTitle_l.AutoSize = True
        Me.HomeTitle_l.BackColor = System.Drawing.Color.Transparent
        Me.HomeTitle_l.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.HomeTitle_l.Font = New System.Drawing.Font("Roboto Medium", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HomeTitle_l.ForeColor = System.Drawing.Color.White
        Me.HomeTitle_l.Location = New System.Drawing.Point(110, 69)
        Me.HomeTitle_l.Name = "HomeTitle_l"
        Me.HomeTitle_l.Size = New System.Drawing.Size(672, 77)
        Me.HomeTitle_l.TabIndex = 13
        Me.HomeTitle_l.Text = "Gestion des etudiants"
        '
        'logout_btn
        '
        Me.logout_btn.BackColor = System.Drawing.Color.Transparent
        Me.logout_btn.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.usericon2
        Me.logout_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.logout_btn.FlatAppearance.BorderSize = 0
        Me.logout_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.logout_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.logout_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.logout_btn.Location = New System.Drawing.Point(19, 784)
        Me.logout_btn.Name = "logout_btn"
        Me.logout_btn.Size = New System.Drawing.Size(50, 50)
        Me.logout_btn.TabIndex = 16
        Me.logout_btn.UseVisualStyleBackColor = False
        '
        'logout_l
        '
        Me.logout_l.AutoSize = True
        Me.logout_l.BackColor = System.Drawing.Color.Transparent
        Me.logout_l.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.logout_l.Font = New System.Drawing.Font("Roboto Medium", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.logout_l.ForeColor = System.Drawing.Color.White
        Me.logout_l.Location = New System.Drawing.Point(19, 837)
        Me.logout_l.Name = "logout_l"
        Me.logout_l.Size = New System.Drawing.Size(52, 15)
        Me.logout_l.TabIndex = 14
        Me.logout_l.Text = "log out"
        '
        'homeLabel_l
        '
        Me.homeLabel_l.AutoSize = True
        Me.homeLabel_l.BackColor = System.Drawing.Color.Transparent
        Me.homeLabel_l.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.homeLabel_l.Font = New System.Drawing.Font("Roboto Medium", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.homeLabel_l.ForeColor = System.Drawing.Color.White
        Me.homeLabel_l.Location = New System.Drawing.Point(392, 181)
        Me.homeLabel_l.Name = "homeLabel_l"
        Me.homeLabel_l.Size = New System.Drawing.Size(158, 58)
        Me.homeLabel_l.TabIndex = 17
        Me.homeLabel_l.Text = "Home"
        '
        'homeIcon_img
        '
        Me.homeIcon_img.BackColor = System.Drawing.Color.Transparent
        Me.homeIcon_img.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.usericon2
        Me.homeIcon_img.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.homeIcon_img.FlatAppearance.BorderSize = 0
        Me.homeIcon_img.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.homeIcon_img.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.homeIcon_img.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.homeIcon_img.Location = New System.Drawing.Point(312, 168)
        Me.homeIcon_img.Name = "homeIcon_img"
        Me.homeIcon_img.Size = New System.Drawing.Size(80, 80)
        Me.homeIcon_img.TabIndex = 18
        Me.homeIcon_img.UseVisualStyleBackColor = False
        '
        'Home
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.BG_Home
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(884, 861)
        Me.Controls.Add(Me.homeIcon_img)
        Me.Controls.Add(Me.homeLabel_l)
        Me.Controls.Add(Me.logout_btn)
        Me.Controls.Add(Me.logout_l)
        Me.Controls.Add(Me.HomeTitle_l)
        Me.Controls.Add(Me.Afficher_btn)
        Me.Controls.Add(Me.Supprimer_btn)
        Me.Controls.Add(Me.modifier_btn)
        Me.Controls.Add(Me.Ajouter_btn)
        Me.Controls.Add(Me.afficher_l)
        Me.Controls.Add(Me.supprimer_l)
        Me.Controls.Add(Me.modifier_l)
        Me.Controls.Add(Me.ajouter_l)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "Home"
        Me.ShowIcon = False
        Me.Text = "Gestion des etudiants - Home"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ajouter_l As System.Windows.Forms.Label
    Friend WithEvents modifier_l As System.Windows.Forms.Label
    Friend WithEvents supprimer_l As System.Windows.Forms.Label
    Friend WithEvents afficher_l As System.Windows.Forms.Label
    Friend WithEvents Ajouter_btn As System.Windows.Forms.Button
    Friend WithEvents modifier_btn As System.Windows.Forms.Button
    Friend WithEvents Supprimer_btn As System.Windows.Forms.Button
    Friend WithEvents Afficher_btn As System.Windows.Forms.Button
    Friend WithEvents HomeTitle_l As System.Windows.Forms.Label
    Friend WithEvents logout_btn As System.Windows.Forms.Button
    Friend WithEvents logout_l As System.Windows.Forms.Label
    Friend WithEvents homeLabel_l As System.Windows.Forms.Label
    Friend WithEvents homeIcon_img As System.Windows.Forms.Button
End Class
