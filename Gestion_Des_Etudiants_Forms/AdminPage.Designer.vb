<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminPage
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
        Me.AdminPageTitle_l = New System.Windows.Forms.Label()
        Me.logout_btn = New System.Windows.Forms.Button()
        Me.logout_l = New System.Windows.Forms.Label()
        Me.adminLabel_l = New System.Windows.Forms.Label()
        Me.homeIcon_img = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ajouter_l
        '
        Me.ajouter_l.AutoSize = True
        Me.ajouter_l.BackColor = System.Drawing.Color.Transparent
        Me.ajouter_l.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ajouter_l.Font = New System.Drawing.Font("Roboto", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ajouter_l.ForeColor = System.Drawing.Color.White
        Me.ajouter_l.Location = New System.Drawing.Point(68, 484)
        Me.ajouter_l.Name = "ajouter_l"
        Me.ajouter_l.Size = New System.Drawing.Size(120, 39)
        Me.ajouter_l.TabIndex = 1
        Me.ajouter_l.Text = "Ajouter"
        '
        'modifier_l
        '
        Me.modifier_l.AutoSize = True
        Me.modifier_l.BackColor = System.Drawing.Color.Transparent
        Me.modifier_l.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.modifier_l.Font = New System.Drawing.Font("Roboto", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.modifier_l.ForeColor = System.Drawing.Color.White
        Me.modifier_l.Location = New System.Drawing.Point(276, 484)
        Me.modifier_l.Name = "modifier_l"
        Me.modifier_l.Size = New System.Drawing.Size(136, 39)
        Me.modifier_l.TabIndex = 2
        Me.modifier_l.Text = "Modifier"
        '
        'supprimer_l
        '
        Me.supprimer_l.AutoSize = True
        Me.supprimer_l.BackColor = System.Drawing.Color.Transparent
        Me.supprimer_l.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.supprimer_l.Font = New System.Drawing.Font("Roboto", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.supprimer_l.ForeColor = System.Drawing.Color.White
        Me.supprimer_l.Location = New System.Drawing.Point(473, 484)
        Me.supprimer_l.Name = "supprimer_l"
        Me.supprimer_l.Size = New System.Drawing.Size(165, 39)
        Me.supprimer_l.TabIndex = 3
        Me.supprimer_l.Text = "Supprimer"
        '
        'afficher_l
        '
        Me.afficher_l.AutoSize = True
        Me.afficher_l.BackColor = System.Drawing.Color.Transparent
        Me.afficher_l.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.afficher_l.Font = New System.Drawing.Font("Roboto", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.afficher_l.ForeColor = System.Drawing.Color.White
        Me.afficher_l.Location = New System.Drawing.Point(706, 484)
        Me.afficher_l.Name = "afficher_l"
        Me.afficher_l.Size = New System.Drawing.Size(131, 39)
        Me.afficher_l.TabIndex = 4
        Me.afficher_l.Text = "Afficher"
        '
        'Ajouter_btn
        '
        Me.Ajouter_btn.BackColor = System.Drawing.Color.Transparent
        Me.Ajouter_btn.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.add_user2
        Me.Ajouter_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Ajouter_btn.FlatAppearance.BorderSize = 0
        Me.Ajouter_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Ajouter_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Ajouter_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Ajouter_btn.Location = New System.Drawing.Point(50, 321)
        Me.Ajouter_btn.Name = "Ajouter_btn"
        Me.Ajouter_btn.Size = New System.Drawing.Size(150, 150)
        Me.Ajouter_btn.TabIndex = 9
        Me.Ajouter_btn.UseVisualStyleBackColor = False
        '
        'modifier_btn
        '
        Me.modifier_btn.BackColor = System.Drawing.Color.Transparent
        Me.modifier_btn.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.edit_user
        Me.modifier_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.modifier_btn.FlatAppearance.BorderSize = 0
        Me.modifier_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.modifier_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.modifier_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.modifier_btn.Location = New System.Drawing.Point(265, 321)
        Me.modifier_btn.Name = "modifier_btn"
        Me.modifier_btn.Size = New System.Drawing.Size(150, 150)
        Me.modifier_btn.TabIndex = 10
        Me.modifier_btn.UseVisualStyleBackColor = False
        '
        'Supprimer_btn
        '
        Me.Supprimer_btn.BackColor = System.Drawing.Color.Transparent
        Me.Supprimer_btn.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.delete_user
        Me.Supprimer_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Supprimer_btn.FlatAppearance.BorderSize = 0
        Me.Supprimer_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Supprimer_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Supprimer_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Supprimer_btn.Location = New System.Drawing.Point(475, 321)
        Me.Supprimer_btn.Name = "Supprimer_btn"
        Me.Supprimer_btn.Size = New System.Drawing.Size(150, 150)
        Me.Supprimer_btn.TabIndex = 11
        Me.Supprimer_btn.UseVisualStyleBackColor = False
        '
        'Afficher_btn
        '
        Me.Afficher_btn.BackColor = System.Drawing.Color.Transparent
        Me.Afficher_btn.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.view_user
        Me.Afficher_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Afficher_btn.FlatAppearance.BorderSize = 0
        Me.Afficher_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Afficher_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Afficher_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Afficher_btn.Location = New System.Drawing.Point(690, 321)
        Me.Afficher_btn.Name = "Afficher_btn"
        Me.Afficher_btn.Size = New System.Drawing.Size(150, 150)
        Me.Afficher_btn.TabIndex = 12
        Me.Afficher_btn.UseVisualStyleBackColor = False
        '
        'AdminPageTitle_l
        '
        Me.AdminPageTitle_l.AutoSize = True
        Me.AdminPageTitle_l.BackColor = System.Drawing.Color.Transparent
        Me.AdminPageTitle_l.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AdminPageTitle_l.Font = New System.Drawing.Font("Roboto", 54.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AdminPageTitle_l.ForeColor = System.Drawing.Color.White
        Me.AdminPageTitle_l.Location = New System.Drawing.Point(72, 44)
        Me.AdminPageTitle_l.Name = "AdminPageTitle_l"
        Me.AdminPageTitle_l.Size = New System.Drawing.Size(742, 87)
        Me.AdminPageTitle_l.TabIndex = 13
        Me.AdminPageTitle_l.Text = "Gestion des etudiants"
        '
        'logout_btn
        '
        Me.logout_btn.BackColor = System.Drawing.Color.Transparent
        Me.logout_btn.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.log_out
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
        Me.logout_l.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.logout_l.ForeColor = System.Drawing.Color.White
        Me.logout_l.Location = New System.Drawing.Point(19, 837)
        Me.logout_l.Name = "logout_l"
        Me.logout_l.Size = New System.Drawing.Size(55, 16)
        Me.logout_l.TabIndex = 14
        Me.logout_l.Text = "log out"
        '
        'adminLabel_l
        '
        Me.adminLabel_l.AutoSize = True
        Me.adminLabel_l.BackColor = System.Drawing.Color.Transparent
        Me.adminLabel_l.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.adminLabel_l.Font = New System.Drawing.Font("Roboto", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.adminLabel_l.ForeColor = System.Drawing.Color.White
        Me.adminLabel_l.Location = New System.Drawing.Point(56, 177)
        Me.adminLabel_l.Name = "adminLabel_l"
        Me.adminLabel_l.Size = New System.Drawing.Size(170, 36)
        Me.adminLabel_l.TabIndex = 17
        Me.adminLabel_l.Text = "Admin Page"
        '
        'homeIcon_img
        '
        Me.homeIcon_img.BackColor = System.Drawing.Color.Transparent
        Me.homeIcon_img.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.adminpng
        Me.homeIcon_img.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.homeIcon_img.FlatAppearance.BorderSize = 0
        Me.homeIcon_img.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.homeIcon_img.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.homeIcon_img.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.homeIcon_img.Location = New System.Drawing.Point(6, 162)
        Me.homeIcon_img.Name = "homeIcon_img"
        Me.homeIcon_img.Size = New System.Drawing.Size(50, 50)
        Me.homeIcon_img.TabIndex = 18
        Me.homeIcon_img.UseVisualStyleBackColor = False
        '
        'AdminPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.BG_Home
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(884, 861)
        Me.Controls.Add(Me.homeIcon_img)
        Me.Controls.Add(Me.adminLabel_l)
        Me.Controls.Add(Me.logout_btn)
        Me.Controls.Add(Me.logout_l)
        Me.Controls.Add(Me.AdminPageTitle_l)
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
        Me.Name = "AdminPage"
        Me.ShowIcon = False
        Me.Text = "Gestion des etudiants - Admin Page"
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
    Friend WithEvents AdminPageTitle_l As System.Windows.Forms.Label
    Friend WithEvents logout_btn As System.Windows.Forms.Button
    Friend WithEvents logout_l As System.Windows.Forms.Label
    Friend WithEvents adminLabel_l As System.Windows.Forms.Label
    Friend WithEvents homeIcon_img As System.Windows.Forms.Button
End Class
