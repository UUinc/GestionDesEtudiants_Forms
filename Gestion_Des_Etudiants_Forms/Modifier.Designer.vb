<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ModifierPage
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
        Me.title_l.Size = New System.Drawing.Size(83, 24)
        Me.title_l.TabIndex = 3
        Me.title_l.Text = "Modifier"
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
        'ModifierPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.GestionDesEtudiants.My.Resources.Resources.BG2
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(694, 671)
        Me.Controls.Add(Me.title_l)
        Me.Controls.Add(Me.back_btn)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "ModifierPage"
        Me.Text = "Gestion des etudiants - Modifier"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents title_l As System.Windows.Forms.Label
    Friend WithEvents back_btn As System.Windows.Forms.Button
End Class
