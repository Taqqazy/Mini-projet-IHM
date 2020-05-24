<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FichierToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChoisirRepertoireToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OuvrirAnnotationsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.EnregistrerSousToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EnregistrerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.QuitterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Oeil1ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuAjouter1Y1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuSupprimer1Y1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Oeil2ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuAjouter2Y2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuSupprimer2Y2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.BordVisageGaucheToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuAjouter3BVG = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuSupprimer3BVG = New System.Windows.Forms.ToolStripMenuItem()
        Me.BordVisageDroiteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuAjouter4BVD = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuSupprimer4BVD = New System.Windows.Forms.ToolStripMenuItem()
        Me.BasDuNezToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuAjouter5BN = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuSupprimer5BN = New System.Windows.Forms.ToolStripMenuItem()
        Me.BordNezGaucheToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuAjouter6BNG = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuSupprimer6BNG = New System.Windows.Forms.ToolStripMenuItem()
        Me.BordNezDroiteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuAjouter7BND = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuSupprimer7BND = New System.Windows.Forms.ToolStripMenuItem()
        Me.BasDuMentonToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuAjouter8BM = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuSupprimer8BM = New System.Windows.Forms.ToolStripMenuItem()
        Me.HautDesLèvresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuAjouter9HL = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuSupprimer9HL = New System.Windows.Forms.ToolStripMenuItem()
        Me.BasDesLèvresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuAjouter10BL = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuSupprimer10BL = New System.Windows.Forms.ToolStripMenuItem()
        Me.GaucheDesLèvresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuAjouter11GL = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuSupprimer11GL = New System.Windows.Forms.ToolStripMenuItem()
        Me.DroiteDesLèvresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuAjouter12DL = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuSupprimer12DL = New System.Windows.Forms.ToolStripMenuItem()
        Me.OptionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TrouverSosieToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.lblPartie = New System.Windows.Forms.Label()
        Me.cboImages = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnAnnotter = New System.Windows.Forms.Button()
        Me.picImage = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.picImage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FichierToolStripMenuItem, Me.EditerToolStripMenuItem, Me.OptionsToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(811, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FichierToolStripMenuItem
        '
        Me.FichierToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ChoisirRepertoireToolStripMenuItem, Me.OuvrirAnnotationsToolStripMenuItem, Me.ToolStripSeparator1, Me.EnregistrerSousToolStripMenuItem, Me.EnregistrerToolStripMenuItem, Me.ToolStripSeparator2, Me.QuitterToolStripMenuItem})
        Me.FichierToolStripMenuItem.Name = "FichierToolStripMenuItem"
        Me.FichierToolStripMenuItem.Size = New System.Drawing.Size(54, 20)
        Me.FichierToolStripMenuItem.Text = "Fichier"
        '
        'ChoisirRepertoireToolStripMenuItem
        '
        Me.ChoisirRepertoireToolStripMenuItem.Name = "ChoisirRepertoireToolStripMenuItem"
        Me.ChoisirRepertoireToolStripMenuItem.Size = New System.Drawing.Size(173, 22)
        Me.ChoisirRepertoireToolStripMenuItem.Text = "Choisir répertoire"
        '
        'OuvrirAnnotationsToolStripMenuItem
        '
        Me.OuvrirAnnotationsToolStripMenuItem.Name = "OuvrirAnnotationsToolStripMenuItem"
        Me.OuvrirAnnotationsToolStripMenuItem.Size = New System.Drawing.Size(173, 22)
        Me.OuvrirAnnotationsToolStripMenuItem.Text = "Ouvrir annotations"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(170, 6)
        '
        'EnregistrerSousToolStripMenuItem
        '
        Me.EnregistrerSousToolStripMenuItem.Name = "EnregistrerSousToolStripMenuItem"
        Me.EnregistrerSousToolStripMenuItem.Size = New System.Drawing.Size(173, 22)
        Me.EnregistrerSousToolStripMenuItem.Text = "Enregistrer sous..."
        '
        'EnregistrerToolStripMenuItem
        '
        Me.EnregistrerToolStripMenuItem.Name = "EnregistrerToolStripMenuItem"
        Me.EnregistrerToolStripMenuItem.Size = New System.Drawing.Size(173, 22)
        Me.EnregistrerToolStripMenuItem.Text = "Enregistrer"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(170, 6)
        '
        'QuitterToolStripMenuItem
        '
        Me.QuitterToolStripMenuItem.Name = "QuitterToolStripMenuItem"
        Me.QuitterToolStripMenuItem.Size = New System.Drawing.Size(173, 22)
        Me.QuitterToolStripMenuItem.Text = "Quitter"
        '
        'EditerToolStripMenuItem
        '
        Me.EditerToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Oeil1ToolStripMenuItem, Me.Oeil2ToolStripMenuItem, Me.BordVisageGaucheToolStripMenuItem, Me.BordVisageDroiteToolStripMenuItem, Me.BasDuNezToolStripMenuItem, Me.BordNezGaucheToolStripMenuItem, Me.BordNezDroiteToolStripMenuItem, Me.BasDuMentonToolStripMenuItem, Me.HautDesLèvresToolStripMenuItem, Me.BasDesLèvresToolStripMenuItem, Me.GaucheDesLèvresToolStripMenuItem, Me.DroiteDesLèvresToolStripMenuItem})
        Me.EditerToolStripMenuItem.Name = "EditerToolStripMenuItem"
        Me.EditerToolStripMenuItem.Size = New System.Drawing.Size(49, 20)
        Me.EditerToolStripMenuItem.Text = "Editer"
        '
        'Oeil1ToolStripMenuItem
        '
        Me.Oeil1ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuAjouter1Y1, Me.MenuSupprimer1Y1})
        Me.Oeil1ToolStripMenuItem.Name = "Oeil1ToolStripMenuItem"
        Me.Oeil1ToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
        Me.Oeil1ToolStripMenuItem.Text = "Oeil 1"
        '
        'MenuAjouter1Y1
        '
        Me.MenuAjouter1Y1.Name = "MenuAjouter1Y1"
        Me.MenuAjouter1Y1.Size = New System.Drawing.Size(129, 22)
        Me.MenuAjouter1Y1.Text = "Ajouter"
        '
        'MenuSupprimer1Y1
        '
        Me.MenuSupprimer1Y1.Enabled = False
        Me.MenuSupprimer1Y1.Name = "MenuSupprimer1Y1"
        Me.MenuSupprimer1Y1.Size = New System.Drawing.Size(129, 22)
        Me.MenuSupprimer1Y1.Text = "Supprimer"
        '
        'Oeil2ToolStripMenuItem
        '
        Me.Oeil2ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuAjouter2Y2, Me.MenuSupprimer2Y2})
        Me.Oeil2ToolStripMenuItem.Name = "Oeil2ToolStripMenuItem"
        Me.Oeil2ToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
        Me.Oeil2ToolStripMenuItem.Text = "Oeil 2"
        '
        'MenuAjouter2Y2
        '
        Me.MenuAjouter2Y2.Name = "MenuAjouter2Y2"
        Me.MenuAjouter2Y2.Size = New System.Drawing.Size(129, 22)
        Me.MenuAjouter2Y2.Text = "Ajouter"
        '
        'MenuSupprimer2Y2
        '
        Me.MenuSupprimer2Y2.Enabled = False
        Me.MenuSupprimer2Y2.Name = "MenuSupprimer2Y2"
        Me.MenuSupprimer2Y2.Size = New System.Drawing.Size(129, 22)
        Me.MenuSupprimer2Y2.Text = "Supprimer"
        '
        'BordVisageGaucheToolStripMenuItem
        '
        Me.BordVisageGaucheToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuAjouter3BVG, Me.MenuSupprimer3BVG})
        Me.BordVisageGaucheToolStripMenuItem.Name = "BordVisageGaucheToolStripMenuItem"
        Me.BordVisageGaucheToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
        Me.BordVisageGaucheToolStripMenuItem.Text = "Bord visage gauche"
        '
        'MenuAjouter3BVG
        '
        Me.MenuAjouter3BVG.Name = "MenuAjouter3BVG"
        Me.MenuAjouter3BVG.Size = New System.Drawing.Size(129, 22)
        Me.MenuAjouter3BVG.Text = "Ajouter"
        '
        'MenuSupprimer3BVG
        '
        Me.MenuSupprimer3BVG.Enabled = False
        Me.MenuSupprimer3BVG.Name = "MenuSupprimer3BVG"
        Me.MenuSupprimer3BVG.Size = New System.Drawing.Size(129, 22)
        Me.MenuSupprimer3BVG.Text = "Supprimer"
        '
        'BordVisageDroiteToolStripMenuItem
        '
        Me.BordVisageDroiteToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuAjouter4BVD, Me.MenuSupprimer4BVD})
        Me.BordVisageDroiteToolStripMenuItem.Name = "BordVisageDroiteToolStripMenuItem"
        Me.BordVisageDroiteToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
        Me.BordVisageDroiteToolStripMenuItem.Text = "Bord visage droite"
        '
        'MenuAjouter4BVD
        '
        Me.MenuAjouter4BVD.Name = "MenuAjouter4BVD"
        Me.MenuAjouter4BVD.Size = New System.Drawing.Size(129, 22)
        Me.MenuAjouter4BVD.Text = "Ajouter"
        '
        'MenuSupprimer4BVD
        '
        Me.MenuSupprimer4BVD.Enabled = False
        Me.MenuSupprimer4BVD.Name = "MenuSupprimer4BVD"
        Me.MenuSupprimer4BVD.Size = New System.Drawing.Size(129, 22)
        Me.MenuSupprimer4BVD.Text = "Supprimer"
        '
        'BasDuNezToolStripMenuItem
        '
        Me.BasDuNezToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuAjouter5BN, Me.MenuSupprimer5BN})
        Me.BasDuNezToolStripMenuItem.Name = "BasDuNezToolStripMenuItem"
        Me.BasDuNezToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
        Me.BasDuNezToolStripMenuItem.Text = "Bas du nez"
        '
        'MenuAjouter5BN
        '
        Me.MenuAjouter5BN.Name = "MenuAjouter5BN"
        Me.MenuAjouter5BN.Size = New System.Drawing.Size(129, 22)
        Me.MenuAjouter5BN.Text = "Ajouter"
        '
        'MenuSupprimer5BN
        '
        Me.MenuSupprimer5BN.Enabled = False
        Me.MenuSupprimer5BN.Name = "MenuSupprimer5BN"
        Me.MenuSupprimer5BN.Size = New System.Drawing.Size(129, 22)
        Me.MenuSupprimer5BN.Text = "Supprimer"
        '
        'BordNezGaucheToolStripMenuItem
        '
        Me.BordNezGaucheToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuAjouter6BNG, Me.MenuSupprimer6BNG})
        Me.BordNezGaucheToolStripMenuItem.Name = "BordNezGaucheToolStripMenuItem"
        Me.BordNezGaucheToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
        Me.BordNezGaucheToolStripMenuItem.Text = "Bord nez gauche"
        '
        'MenuAjouter6BNG
        '
        Me.MenuAjouter6BNG.Name = "MenuAjouter6BNG"
        Me.MenuAjouter6BNG.Size = New System.Drawing.Size(129, 22)
        Me.MenuAjouter6BNG.Text = "Ajouter"
        '
        'MenuSupprimer6BNG
        '
        Me.MenuSupprimer6BNG.Enabled = False
        Me.MenuSupprimer6BNG.Name = "MenuSupprimer6BNG"
        Me.MenuSupprimer6BNG.Size = New System.Drawing.Size(129, 22)
        Me.MenuSupprimer6BNG.Text = "Supprimer"
        '
        'BordNezDroiteToolStripMenuItem
        '
        Me.BordNezDroiteToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuAjouter7BND, Me.MenuSupprimer7BND})
        Me.BordNezDroiteToolStripMenuItem.Name = "BordNezDroiteToolStripMenuItem"
        Me.BordNezDroiteToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
        Me.BordNezDroiteToolStripMenuItem.Text = "Bord nez droite"
        '
        'MenuAjouter7BND
        '
        Me.MenuAjouter7BND.Name = "MenuAjouter7BND"
        Me.MenuAjouter7BND.Size = New System.Drawing.Size(129, 22)
        Me.MenuAjouter7BND.Text = "Ajouter"
        '
        'MenuSupprimer7BND
        '
        Me.MenuSupprimer7BND.Enabled = False
        Me.MenuSupprimer7BND.Name = "MenuSupprimer7BND"
        Me.MenuSupprimer7BND.Size = New System.Drawing.Size(129, 22)
        Me.MenuSupprimer7BND.Text = "Supprimer"
        '
        'BasDuMentonToolStripMenuItem
        '
        Me.BasDuMentonToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuAjouter8BM, Me.MenuSupprimer8BM})
        Me.BasDuMentonToolStripMenuItem.Name = "BasDuMentonToolStripMenuItem"
        Me.BasDuMentonToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
        Me.BasDuMentonToolStripMenuItem.Text = "Bas du menton"
        '
        'MenuAjouter8BM
        '
        Me.MenuAjouter8BM.Name = "MenuAjouter8BM"
        Me.MenuAjouter8BM.Size = New System.Drawing.Size(129, 22)
        Me.MenuAjouter8BM.Text = "Ajouter"
        '
        'MenuSupprimer8BM
        '
        Me.MenuSupprimer8BM.Enabled = False
        Me.MenuSupprimer8BM.Name = "MenuSupprimer8BM"
        Me.MenuSupprimer8BM.Size = New System.Drawing.Size(129, 22)
        Me.MenuSupprimer8BM.Text = "Supprimer"
        '
        'HautDesLèvresToolStripMenuItem
        '
        Me.HautDesLèvresToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuAjouter9HL, Me.MenuSupprimer9HL})
        Me.HautDesLèvresToolStripMenuItem.Name = "HautDesLèvresToolStripMenuItem"
        Me.HautDesLèvresToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
        Me.HautDesLèvresToolStripMenuItem.Text = "Haut des lèvres"
        '
        'MenuAjouter9HL
        '
        Me.MenuAjouter9HL.Name = "MenuAjouter9HL"
        Me.MenuAjouter9HL.Size = New System.Drawing.Size(129, 22)
        Me.MenuAjouter9HL.Text = "Ajouter"
        '
        'MenuSupprimer9HL
        '
        Me.MenuSupprimer9HL.Enabled = False
        Me.MenuSupprimer9HL.Name = "MenuSupprimer9HL"
        Me.MenuSupprimer9HL.Size = New System.Drawing.Size(129, 22)
        Me.MenuSupprimer9HL.Text = "Supprimer"
        '
        'BasDesLèvresToolStripMenuItem
        '
        Me.BasDesLèvresToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuAjouter10BL, Me.MenuSupprimer10BL})
        Me.BasDesLèvresToolStripMenuItem.Name = "BasDesLèvresToolStripMenuItem"
        Me.BasDesLèvresToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
        Me.BasDesLèvresToolStripMenuItem.Text = "Bas des lèvres"
        '
        'MenuAjouter10BL
        '
        Me.MenuAjouter10BL.Name = "MenuAjouter10BL"
        Me.MenuAjouter10BL.Size = New System.Drawing.Size(129, 22)
        Me.MenuAjouter10BL.Text = "Ajouter"
        '
        'MenuSupprimer10BL
        '
        Me.MenuSupprimer10BL.Enabled = False
        Me.MenuSupprimer10BL.Name = "MenuSupprimer10BL"
        Me.MenuSupprimer10BL.Size = New System.Drawing.Size(129, 22)
        Me.MenuSupprimer10BL.Text = "Supprimer"
        '
        'GaucheDesLèvresToolStripMenuItem
        '
        Me.GaucheDesLèvresToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuAjouter11GL, Me.MenuSupprimer11GL})
        Me.GaucheDesLèvresToolStripMenuItem.Name = "GaucheDesLèvresToolStripMenuItem"
        Me.GaucheDesLèvresToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
        Me.GaucheDesLèvresToolStripMenuItem.Text = "Gauche des lèvres"
        '
        'MenuAjouter11GL
        '
        Me.MenuAjouter11GL.Name = "MenuAjouter11GL"
        Me.MenuAjouter11GL.Size = New System.Drawing.Size(129, 22)
        Me.MenuAjouter11GL.Text = "Ajouter"
        '
        'MenuSupprimer11GL
        '
        Me.MenuSupprimer11GL.Enabled = False
        Me.MenuSupprimer11GL.Name = "MenuSupprimer11GL"
        Me.MenuSupprimer11GL.Size = New System.Drawing.Size(129, 22)
        Me.MenuSupprimer11GL.Text = "Supprimer"
        '
        'DroiteDesLèvresToolStripMenuItem
        '
        Me.DroiteDesLèvresToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuAjouter12DL, Me.MenuSupprimer12DL})
        Me.DroiteDesLèvresToolStripMenuItem.Name = "DroiteDesLèvresToolStripMenuItem"
        Me.DroiteDesLèvresToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
        Me.DroiteDesLèvresToolStripMenuItem.Text = "Droite des lèvres"
        '
        'MenuAjouter12DL
        '
        Me.MenuAjouter12DL.Name = "MenuAjouter12DL"
        Me.MenuAjouter12DL.Size = New System.Drawing.Size(129, 22)
        Me.MenuAjouter12DL.Text = "Ajouter"
        '
        'MenuSupprimer12DL
        '
        Me.MenuSupprimer12DL.Enabled = False
        Me.MenuSupprimer12DL.Name = "MenuSupprimer12DL"
        Me.MenuSupprimer12DL.Size = New System.Drawing.Size(129, 22)
        Me.MenuSupprimer12DL.Text = "Supprimer"
        '
        'OptionsToolStripMenuItem
        '
        Me.OptionsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TrouverSosieToolStripMenuItem})
        Me.OptionsToolStripMenuItem.Name = "OptionsToolStripMenuItem"
        Me.OptionsToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.OptionsToolStripMenuItem.Text = "Options"
        '
        'TrouverSosieToolStripMenuItem
        '
        Me.TrouverSosieToolStripMenuItem.Enabled = False
        Me.TrouverSosieToolStripMenuItem.Name = "TrouverSosieToolStripMenuItem"
        Me.TrouverSosieToolStripMenuItem.Size = New System.Drawing.Size(142, 22)
        Me.TrouverSosieToolStripMenuItem.Text = "Trouver sosie"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.Title = "Ouvrir image"
        '
        'lblPartie
        '
        Me.lblPartie.AutoSize = True
        Me.lblPartie.Location = New System.Drawing.Point(714, 122)
        Me.lblPartie.Name = "lblPartie"
        Me.lblPartie.Size = New System.Drawing.Size(0, 13)
        Me.lblPartie.TabIndex = 2
        '
        'cboImages
        '
        Me.cboImages.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboImages.FormattingEnabled = True
        Me.cboImages.Location = New System.Drawing.Point(6, 19)
        Me.cboImages.Name = "cboImages"
        Me.cboImages.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cboImages.Size = New System.Drawing.Size(223, 21)
        Me.cboImages.TabIndex = 4
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cboImages)
        Me.GroupBox1.Controls.Add(Me.btnAnnotter)
        Me.GroupBox1.Location = New System.Drawing.Point(31, 54)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(248, 147)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Choix de l'image"
        '
        'btnAnnotter
        '
        Me.btnAnnotter.Enabled = False
        Me.btnAnnotter.Location = New System.Drawing.Point(173, 58)
        Me.btnAnnotter.Name = "btnAnnotter"
        Me.btnAnnotter.Size = New System.Drawing.Size(56, 53)
        Me.btnAnnotter.TabIndex = 3
        Me.btnAnnotter.UseVisualStyleBackColor = True
        '
        'picImage
        '
        Me.picImage.Location = New System.Drawing.Point(324, 54)
        Me.picImage.Name = "picImage"
        Me.picImage.Size = New System.Drawing.Size(436, 429)
        Me.picImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picImage.TabIndex = 1
        Me.picImage.TabStop = False
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(811, 523)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lblPartie)
        Me.Controls.Add(Me.picImage)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmMain"
        Me.Text = "Head Scanner"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.picImage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents EditerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OptionsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents FichierToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ChoisirRepertoireToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents EnregistrerSousToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EnregistrerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents QuitterToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents picImage As PictureBox
    Friend WithEvents OuvrirAnnotationsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Oeil1ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Oeil2ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BordVisageGaucheToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BordVisageDroiteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BasDuNezToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BordNezGaucheToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BordNezDroiteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BasDuMentonToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HautDesLèvresToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BasDesLèvresToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GaucheDesLèvresToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DroiteDesLèvresToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MenuAjouter1Y1 As ToolStripMenuItem
    Friend WithEvents MenuSupprimer1Y1 As ToolStripMenuItem
    Friend WithEvents MenuAjouter2Y2 As ToolStripMenuItem
    Friend WithEvents MenuSupprimer2Y2 As ToolStripMenuItem
    Friend WithEvents MenuAjouter3BVG As ToolStripMenuItem
    Friend WithEvents MenuSupprimer3BVG As ToolStripMenuItem
    Friend WithEvents MenuAjouter4BVD As ToolStripMenuItem
    Friend WithEvents MenuSupprimer4BVD As ToolStripMenuItem
    Friend WithEvents MenuAjouter5BN As ToolStripMenuItem
    Friend WithEvents MenuSupprimer5BN As ToolStripMenuItem
    Friend WithEvents MenuAjouter6BNG As ToolStripMenuItem
    Friend WithEvents MenuSupprimer6BNG As ToolStripMenuItem
    Friend WithEvents MenuAjouter7BND As ToolStripMenuItem
    Friend WithEvents MenuSupprimer7BND As ToolStripMenuItem
    Friend WithEvents MenuAjouter8BM As ToolStripMenuItem
    Friend WithEvents MenuSupprimer8BM As ToolStripMenuItem
    Friend WithEvents MenuAjouter9HL As ToolStripMenuItem
    Friend WithEvents MenuSupprimer9HL As ToolStripMenuItem
    Friend WithEvents MenuAjouter10BL As ToolStripMenuItem
    Friend WithEvents MenuSupprimer10BL As ToolStripMenuItem
    Friend WithEvents MenuAjouter11GL As ToolStripMenuItem
    Friend WithEvents MenuSupprimer11GL As ToolStripMenuItem
    Friend WithEvents MenuAjouter12DL As ToolStripMenuItem
    Friend WithEvents MenuSupprimer12DL As ToolStripMenuItem
    Friend WithEvents lblPartie As Label
    Friend WithEvents TrouverSosieToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btnAnnotter As Button
    Friend WithEvents cboImages As ComboBox
    Friend WithEvents GroupBox1 As GroupBox
End Class
