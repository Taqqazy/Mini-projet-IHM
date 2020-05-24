<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSosie
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
        Me.picSosie = New System.Windows.Forms.PictureBox()
        Me.lblSosie = New System.Windows.Forms.Label()
        CType(Me.picSosie, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picSosie
        '
        Me.picSosie.Location = New System.Drawing.Point(80, 83)
        Me.picSosie.Name = "picSosie"
        Me.picSosie.Size = New System.Drawing.Size(293, 291)
        Me.picSosie.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picSosie.TabIndex = 0
        Me.picSosie.TabStop = False
        '
        'lblSosie
        '
        Me.lblSosie.AutoSize = True
        Me.lblSosie.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSosie.Location = New System.Drawing.Point(65, 23)
        Me.lblSosie.Name = "lblSosie"
        Me.lblSosie.Size = New System.Drawing.Size(320, 50)
        Me.lblSosie.TabIndex = 1
        Me.lblSosie.Text = "Voici le sosie associé à votre image" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "le plus proche :"
        Me.lblSosie.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'frmSosie
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(453, 450)
        Me.Controls.Add(Me.lblSosie)
        Me.Controls.Add(Me.picSosie)
        Me.Name = "frmSosie"
        Me.Text = "Sosie"
        CType(Me.picSosie, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picSosie As PictureBox
    Friend WithEvents lblSosie As Label
End Class
