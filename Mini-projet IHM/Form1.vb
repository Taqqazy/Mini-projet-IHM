'Head Scanner v1.0
'IUT d'Orsay, 2020, Module IIHM
'Auteurs : Lecardonnel Louis et Masoud Baptiste
'https://github.com/Taqqazy/Mini-projet-IHM/

Imports System.IO
Imports System.Math
Public Class frmMain
    Private _imageName As String
    Private _fichierCsv1 As New FichierCsv
    Private cheminFichierCsv As String
    Private _partieSelectionnee As Integer = -1
    Private _cheminRepertoire As String
    'Collection des différentes valeurs que peut prendre lblPartie
    Private _listePartie As String() = {"Toutes les parties ont été" & Chr(13) & Chr(10) & "annotées", "Oeil 1", "Oeil 2", "Bord visage gauche", "Bord visage droit", "Bas du nez", "Bord du nez gauche", "Bord du nez droit", "Bas du menton", "Haut des lèvres", "Bas des lèvres", "Gauche des lèvres", "Droite des lèvres"}

    Public Property CheminRepertoire As String
        Get
            Return _cheminRepertoire
        End Get

        'Quand l'utilisateur choisi un repertoire, on clear cboImages et la rempli avec les nouveaux noms de fichier
        Set(value As String)
            _cheminRepertoire = value
            ImageName = ""
            picImage.Image = Nothing
            FichierCsv1.UnDraw_All()
            Dim RepInfo As New DirectoryInfo(value)
            cboImages.Items.Clear()
            Dim infoFichierJpg As FileInfo() = RepInfo.GetFiles("*.jpg")
            Dim infoFichierPng As FileInfo() = RepInfo.GetFiles("*.png")
            Dim infoFichierJpeg As FileInfo() = RepInfo.GetFiles("*.jpeg")
            For Each fichier In infoFichierJpg
                cboImages.Items.Add(fichier.Name)
            Next
            For Each fichier In infoFichierPng
                cboImages.Items.Add(fichier.Name)
            Next
            For Each fichier In infoFichierJpeg
                cboImages.Items.Add(fichier.Name)
            Next
        End Set
    End Property

    Public Property PartieSelectionnee As Integer
        Get
            Return _partieSelectionnee
        End Get
        Set(value As Integer)
            _partieSelectionnee = value
            lblPartie.Text = ListePartie(value + 1)
        End Set
    End Property

    Public Property FichierCsv1 As FichierCsv
        Get
            Return _fichierCsv1
        End Get
        Set(value As FichierCsv)
            _fichierCsv1 = value
        End Set
    End Property

    Public Property ImageName As String
        Get
            Return _imageName
        End Get
        Set(value As String)
            _imageName = value
        End Set
    End Property

    Public Property ListePartie As String()
        Get
            Return _listePartie
        End Get
        Set(value As String())
            _listePartie = value
        End Set
    End Property

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        EnregistrerToolStripMenuItem.Enabled = False
        EditerToolStripMenuItem.Enabled = False
        Me.Icon = My.Resources.logo
    End Sub

    'Choix repertoire images grâce à un FolderBrowserDialog et affecter chemin à CheminRepertoire
    Private Sub ChoisirRepertoireToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChoisirRepertoireToolStripMenuItem.Click
        Dim FolderBrowerDialog1 As New FolderBrowserDialog()
        If FolderBrowerDialog1.ShowDialog() = DialogResult.OK Then
            Me.CheminRepertoire = FolderBrowerDialog1.SelectedPath
        End If
    End Sub

    'Quand l'utilisateur choisi une image, on affecte ImageName, affiche l'image et actualise les annotations
    Private Sub CboImages_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboImages.SelectedIndexChanged
        lblPartie.Text = ""
        ImageName = cboImages.SelectedItem.ToString
        Dim CheminComplet As String = CheminRepertoire & "\" & ImageName
        picImage.Image = Image.FromFile(CheminComplet)
        EditerToolStripMenuItem.Enabled = True
        FichierCsv1.Draw_Update()
        btnAnnotter.Enabled = True
        btnAnnotter.BackColor = Color.Red
    End Sub

    'Ouverture fichier .csv grâce à un OpenFileDialog et si ouverture réussie, actualisation des annotations afficher sur l'image et activation bouton "Enregistrer"
    Private Sub OuvrirAnnotationsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OuvrirAnnotationsToolStripMenuItem.Click
        Dim OpenFileDialog2 As New OpenFileDialog With {
            .Filter = "csv file |*.csv"
            }

        If OpenFileDialog2.ShowDialog() = DialogResult.OK Then
            Me.cheminFichierCsv = OpenFileDialog2.FileName
            OpenFileDialog2.InitialDirectory = OpenFileDialog2.FileName
            If FichierCsv1.Load(Me.cheminFichierCsv) Then
                EnregistrerToolStripMenuItem.Enabled = True
                FichierCsv1.Draw_Update()
            End If
        End If

    End Sub

    'Quand l'utilisateur click sur l'image, et que une partie est séléctionnée, appel fonction FichierCsv.Add, actualisation de la partie séléctionné (suivante) et posibilité de la supprimer via Editer
    Private Sub PicImage_MouseClick(sender As Object, e As MouseEventArgs) Handles picImage.MouseClick
        If picImage.Image IsNot Nothing And PartieSelectionnee <> -1 Then
            FichierCsv1.Add(New Annotation(e.X.ToString, e.Y.ToString), CheminRepertoire & "\" & ImageName)
            MenuAjouterSupprimer_Check(PartieSelectionnee, 1)
            PartieSelectionnee = FichierCsv1.NextAnnotation(CheminRepertoire & "\" & ImageName)
        End If
    End Sub

    Private Sub EnregistrerSousToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EnregistrerSousToolStripMenuItem.Click
        Dim saveFileDialog1 As New SaveFileDialog With {
            .Filter = "csv files (*.csv)|*.csv"
        }

        If saveFileDialog1.ShowDialog = DialogResult.OK Then
            FichierCsv1.Save(saveFileDialog1.FileName)
            cheminFichierCsv = saveFileDialog1.FileName
            EnregistrerToolStripMenuItem.Enabled = True
            saveFileDialog1.InitialDirectory = saveFileDialog1.FileName
        End If
    End Sub

    Private Sub EnregistrerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EnregistrerToolStripMenuItem.Click
        FichierCsv1.Save(cheminFichierCsv)
    End Sub

    ' Récupère le numéro dans le nom du menu Ajouter correspondant à la partie à ajouter (ex : récupère le 3 de "MenuAjouter3BVG") et le donne comme valeurs à PartieSelectionnee 
    Private Sub MenuAjouter_Click(sender As Object, e As EventArgs) Handles MenuAjouter1Y1.Click, MenuAjouter2Y2.Click, MenuAjouter3BVG.Click, MenuAjouter4BVD.Click, MenuAjouter5BN.Click, MenuAjouter6BNG.Click, MenuAjouter7BND.Click, MenuAjouter8BM.Click, MenuAjouter9HL.Click, MenuAjouter10BL.Click, MenuAjouter11GL.Click, MenuAjouter12DL.Click
        Dim num As Integer
        If Convert.ToInt32(sender.name(12)) - 48 <= 9 Then
            num = 10 * (Convert.ToInt32(sender.name(11)) - 48) + Convert.ToInt32(sender.name(12)) - 49
        Else
            num = Convert.ToInt32(sender.name(11)) - 49
        End If
        Me.PartieSelectionnee = num
    End Sub

    ' Pareil que ci-dessus mais pour MenuSupprimer, et supprimer le passage correspondant dans le fichier csv
    Private Sub MenuSupprimer_Click(sender As Object, e As EventArgs) Handles MenuSupprimer1Y1.Click, MenuSupprimer2Y2.Click, MenuSupprimer3BVG.Click, MenuSupprimer4BVD.Click, MenuSupprimer5BN.Click, MenuSupprimer6BNG.Click, MenuSupprimer7BND.Click, MenuSupprimer8BM.Click, MenuSupprimer9HL.Click, MenuSupprimer10BL.Click, MenuSupprimer11GL.Click, MenuSupprimer12DL.Click
        Dim num As Integer
        If Convert.ToInt32(sender.name(14)) - 48 <= 9 Then
            num = 10 * (Convert.ToInt32(sender.name(13)) - 48) + Convert.ToInt32(sender.name(14)) - 49
        Else
            num = Convert.ToInt32(sender.name(13)) - 49
        End If
        FichierCsv1.Delete(CheminRepertoire & "\" & ImageName, num)
        MenuAjouterSupprimer_Check(num, 0)
        PartieSelectionnee = FichierCsv1.NextAnnotation(CheminRepertoire & "\" & ImageName)
    End Sub

    ' Active ou désactiver les menus ajouter et supprimer pour le numéro correspondant (cf PartieSelectionnee) en fonction de la valeur de bool et du numéro correspondant (bool = 0 si on supprime et vice-versa)
    Public Sub MenuAjouterSupprimer_Check(num As Integer, bool As Boolean)
        Select Case num
            Case 0
                MenuSupprimer1Y1.Enabled = bool
                MenuAjouter1Y1.Enabled = Not bool
            Case 1
                MenuSupprimer2Y2.Enabled = bool
                MenuAjouter2Y2.Enabled = Not bool
            Case 2
                MenuSupprimer3BVG.Enabled = bool
                MenuAjouter3BVG.Enabled = Not bool
            Case 3
                MenuSupprimer4BVD.Enabled = bool
                MenuAjouter4BVD.Enabled = Not bool
            Case 4
                MenuSupprimer5BN.Enabled = bool
                MenuAjouter5BN.Enabled = Not bool
            Case 5
                MenuSupprimer6BNG.Enabled = bool
                MenuAjouter6BNG.Enabled = Not bool
            Case 6
                MenuSupprimer7BND.Enabled = bool
                MenuAjouter7BND.Enabled = Not bool
            Case 7
                MenuSupprimer8BM.Enabled = bool
                MenuAjouter8BM.Enabled = Not bool
            Case 8
                MenuSupprimer9HL.Enabled = bool
                MenuAjouter9HL.Enabled = Not bool
            Case 9
                MenuSupprimer10BL.Enabled = bool
                MenuAjouter10BL.Enabled = Not bool
            Case 10
                MenuSupprimer11GL.Enabled = bool
                MenuAjouter11GL.Enabled = Not bool
            Case 11
                MenuSupprimer12DL.Enabled = bool
                MenuAjouter12DL.Enabled = Not bool
        End Select
    End Sub

    Private Sub QuitterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuitterToolStripMenuItem.Click
        Me.Close()
    End Sub

    ' Appelle la fonction Compare, si celle-ci ne renvoie pas d'erreur affiche la fenetre montrant le sosie sinon affiche message d'erreur correspondant
    Private Sub TrouverSosieToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TrouverSosieToolStripMenuItem.Click
        Dim temp As Integer = FichierCsv1.Compare(CheminRepertoire & "\" & ImageName)
        If temp <> -1 Then
            If temp <> -2 Then
                frmSosie.Show()
                frmSosie.picSosie.Image = Image.FromFile(FichierCsv1.ListFileName(temp))
            End If
        Else MsgBox("Il n'existe pas d'autres visages ayant toutes les annotations de compléter", vbOKOnly)
    End If

    End Sub

    'Quand on click sur le bouton Annoter (viseur), ajoute l'image a FichierCsv1.ListFileName si pas déjà ajouter et init la liste d'annotations, et maj partieSelectionnée
    Private Sub BtnAnnotter_Click(sender As Object, e As EventArgs) Handles btnAnnotter.Click
        If Not FichierCsv1.ListFileName.Contains(CheminRepertoire & "\" & ImageName) Then
            FichierCsv1.ListFileName.Add(CheminRepertoire & "\" & ImageName)
            FichierCsv1.ListAnnotation.Add(New List(Of Annotation))
            For index = 0 To 11
                FichierCsv1.ListAnnotation.Last.Add(Nothing)
            Next
        End If
        PartieSelectionnee = FichierCsv1.NextAnnotation(CheminRepertoire & "\" & ImageName)
    End Sub
End Class

Public Class FichierCsv
    Private _listAnnotation As New List(Of List(Of Annotation))
    Private _listFileName As New List(Of String)
    Private _listAbreviationPartie As New List(Of String) From {"Y1.x", "Y1.y", "Y2.x", "Y2.y", "BVG.x", "BVG.y", "BVD.x", "BVD.y", "BN.x", "BN.y", "BNG.x", "BNG.y", "BND.x", "BND.y", "BM.x", "BM.y", "LH.x", "LH.y", "BL.x", "BL.y", "LG.x", "LG.y", "LD.x", "LD.y"}

    Public Property ListFileName As List(Of String)
        Get
            Return _listFileName
        End Get
        Set(value As List(Of String))
            _listFileName = value
        End Set
    End Property

    Public Property ListAnnotation As List(Of List(Of Annotation))
        Get
            Return _listAnnotation
        End Get
        Set(value As List(Of List(Of Annotation)))
            _listAnnotation = value
        End Set
    End Property

    Public Property ListAbreviationPartie As List(Of String)
        Get
            Return _listAbreviationPartie
        End Get
        Set(value As List(Of String))
            _listAbreviationPartie = value
        End Set
    End Property

    'ajoute l'image a FichierCsv1.ListFileName si pas déjà ajouter et init la liste d'annotations puis ajoute une instance d'Annotation et la dessine
    Public Sub Add(annotation As Annotation, imagePath As String)
        Dim indexFileName As Integer
        If Not ListFileName.Contains(imagePath) Then
            ListFileName.Add(imagePath)
            ListAnnotation.Add(New List(Of Annotation))
            For index = 0 To 11
                ListAnnotation.Last.Add(Nothing)
            Next
            indexFileName = ListAnnotation.Count - 1
        Else
            indexFileName = ListFileName.IndexOf(imagePath)
        End If
        ListAnnotation(indexFileName)(frmMain.PartieSelectionnee) = annotation
        If frmMain.CheminRepertoire & "\" & frmMain.ImageName = imagePath Then
            annotation.Draw()
        End If

    End Sub

    'Supprime l'annotation à l'index 'indexASupprimer' de l'image 'imagePath'
    Public Sub Delete(imagePath As String, indexASupprimer As Integer)
        Dim indexFileName As Integer = ListFileName.IndexOf(imagePath)
        frmMain.picImage.Controls.Remove(ListAnnotation(indexFileName)(indexASupprimer).PicCross)
        ListAnnotation(indexFileName)(indexASupprimer) = Nothing
    End Sub

    'Boucle dans Me.ListFileName et Me.ListAnnotation et écrire grâce a un streamwriter dans le fichier 'fileName' 
    'nb: écrit null si pas d'annotation
    Public Sub Save(fileName As String)
        Try
            Dim streamCsv As StreamWriter = My.Computer.FileSystem.OpenTextFileWriter(fileName, False)
            streamCsv.Write("imagefile;")
            For Each nom As String In ListAbreviationPartie
                streamCsv.Write(nom & ";")
            Next
            streamCsv.WriteLine()

            For i = 0 To Me.ListFileName.Count - 1
                streamCsv.Write(Me.ListFileName(i) & ";")
                For y = 0 To Me.ListAnnotation(i).Count - 1
                    If Me.ListAnnotation(i)(y) Is Nothing Then
                        streamCsv.Write("null;null;")
                    Else
                        streamCsv.Write(Me.ListAnnotation(i)(y).XCoord.ToString & ";" & Me.ListAnnotation(i)(y).YCoord.ToString & ";")
                    End If
                Next
                streamCsv.WriteLine()
            Next
            streamCsv.Close()
        Catch ex As System.IO.IOException
            MessageBox.Show("Impossible de sauvegarder " & fileName & ". Essayez de fermer le fichier et vérifiez son accès en écriture", "Erreur sauvegarde", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    'Prend en paramètre une chemin d'une image 'imagePath' et renvoi l'index de la première annotation non instancier pour cette image (voir frmMain.listPartie pour ordre)
    'Retourne -1 si tout est annoté
    Public Function NextAnnotation(imagePath As String) As Integer
        Return ListAnnotation(ListFileName.IndexOf(imagePath)).IndexOf(Nothing)
    End Function

    ' Fonction chargée de lire le fichier csv et d'ajouter à partir de celui-ci et en tenant compte de son formatage les annotations des images dans le programme
    Public Function Load(fileName As String) As Boolean
        Try
            Dim numRows As Long
            Dim numCols As Long
            Dim tmpStream As StreamReader = File.OpenText(fileName)
            Dim strLines() As String
            Dim strLine() As String
            Dim strFirstLine() As String
            Dim annotation As Annotation
            Dim listCoordTemp(23) As String

            strLines = tmpStream.ReadToEnd().Split(Environment.NewLine, 50, StringSplitOptions.RemoveEmptyEntries)
            numRows = UBound(strLines)
            strFirstLine = strLines(0).Split(";", 26, StringSplitOptions.RemoveEmptyEntries)
            numCols = UBound(strFirstLine)

            For x As Integer = 1 To numRows
                strLine = strLines(x).Split(";", 26, StringSplitOptions.RemoveEmptyEntries)
                ReDim listCoordTemp(23)
                Dim y As Integer = 1
                While y <= numCols
                    If strLine(y) <> "null" Then
                        listCoordTemp(ListAbreviationPartie.IndexOf(strFirstLine(y))) = strLine(y)
                    End If
                    y += 1
                End While
                y = 0
                Dim z As Integer = 0
                While z < listCoordTemp.Count - 1
                    annotation = New Annotation(CDbl(listCoordTemp(z)), CDbl(listCoordTemp(z + 1)))
                    frmMain.PartieSelectionnee = z / 2
                    frmMain.FichierCsv1.Add(annotation, strLine(0))
                    frmMain.PartieSelectionnee = -1
                    z += 2
                End While
            Next
            tmpStream.Close()
            Return True
        Catch ex As System.IO.IOException
            MessageBox.Show("Impossible d'ouvrir " & fileName & ". Essayez de fermer le fichier et vérifiez son accès en lecture", "Erreur ouverture", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    ' Enlève toutes les croix affichées
    Public Sub UnDraw_All()
        For Each list In ListAnnotation
            For Each sousliste In list
                If sousliste IsNot Nothing Then
                    frmMain.picImage.Controls.Remove(sousliste.PicCross)
                End If
            Next
        Next
        frmMain.TrouverSosieToolStripMenuItem.Enabled = False
    End Sub

    ' Met à jour les croix affichées au changement d'image et les menus ajouter / supprimer correspondants
    Public Sub Draw_Update()
        UnDraw_All()
        If ListFileName.Contains(frmMain.CheminRepertoire & "\" & frmMain.ImageName) Then
            For i As Integer = 0 To ListAnnotation(ListFileName.IndexOf(frmMain.CheminRepertoire & "\" & frmMain.ImageName)).Count - 1
                If ListAnnotation(ListFileName.IndexOf(frmMain.CheminRepertoire & "\" & frmMain.ImageName))(i) IsNot Nothing Then
                    ListAnnotation(ListFileName.IndexOf(frmMain.CheminRepertoire & "\" & frmMain.ImageName))(i).Draw()
                    frmMain.MenuAjouterSupprimer_Check(i, 1)
                End If
            Next
        Else
            For i As Integer = 0 To 11
                frmMain.MenuAjouterSupprimer_Check(i, 0)
            Next
        End If
    End Sub

    ' Fonction chargée de trouver le sosie le plus proche si toutes les annotations du fichier csv sont remplies; 
    Public Function Compare(imagePath As String)
        Dim indImage As Integer = ListFileName.IndexOf(imagePath)
        For z As Integer = 0 To ListAnnotation(indImage).Count - 1
            If ListAnnotation(indImage)(z) Is Nothing Then
                MsgBox("Veuilliez compléter toutes les annotations du visage à comparer avant de continuer", vbOKOnly)
                Return -2
            End If
        Next

        ' liste contenant les ratios de 3 images (ratioLevre, ratioNez, ratioVisage, ratioYeux) (image à comparer et 2 autres qu'on compare à l'image à comparer pour garder la plus proche).
        Dim ratios As New List(Of List(Of Double)) From {
            New List(Of Double) From {0, 0, 0, 0},
            Nothing,
            New List(Of Double) From {0, 0, 0, 0}
        }
        Dim dist01 As Double = 0
        Dim dist02 As Double = 0
        Dim indPlusSimilaire As Integer = -1
        ratios(0)(0) = Compare_RatioCalcul(ListAnnotation(indImage)(9), ListAnnotation(indImage)(8), ListAnnotation(indImage)(11), ListAnnotation(indImage)(10))
        ratios(0)(1) = Compare_RatioCalcul(ListAnnotation(indImage)(4), New Annotation((ListAnnotation(indImage)(0).XCoord + ListAnnotation(indImage)(1).XCoord) / 2, (ListAnnotation(indImage)(0).YCoord + ListAnnotation(indImage)(1).YCoord) / 2), ListAnnotation(indImage)(6), ListAnnotation(indImage)(5))
        ratios(0)(2) = Compare_RatioCalcul(ListAnnotation(indImage)(7), New Annotation((ListAnnotation(indImage)(0).XCoord + ListAnnotation(indImage)(1).XCoord) / 2, (ListAnnotation(indImage)(0).YCoord + ListAnnotation(indImage)(1).YCoord) / 2), ListAnnotation(indImage)(3), ListAnnotation(indImage)(2))
        ratios(0)(3) = Compare_RatioCalcul(ListAnnotation(indImage)(3), ListAnnotation(indImage)(2), ListAnnotation(indImage)(1), ListAnnotation(indImage)(0))

        Dim i As Integer = 0
        ' Tant qu'on a pas testé tous les visages enregistrés, l'index 2 de la liste prend les ratios du nouveau visage. On compare ensuite au visage précédemment testé (index 1)
        ' et si la distance entre le nouveau visage (donc index 2) et le visage a comparer (index 0) est plus petite qu'avec le visage en index 1, on remplace le visage en index 1 par le nouveau visage etc
        ' Renvoie ensuite l'indice du visage différent le plus proche
        While i < ListFileName.Count
            If i <> indImage Then
                For y As Integer = 0 To ListAnnotation(i).Count - 1
                    If ListAnnotation(i)(y) Is Nothing Then
                        i += 1
                    End If
                Next
                ratios(2)(0) = Compare_RatioCalcul(ListAnnotation(i)(9), ListAnnotation(i)(8), ListAnnotation(i)(11), ListAnnotation(i)(10))
                ratios(2)(1) = Compare_RatioCalcul(ListAnnotation(i)(4), New Annotation((ListAnnotation(i)(0).XCoord + ListAnnotation(i)(1).XCoord) / 2, (ListAnnotation(i)(0).YCoord + ListAnnotation(i)(1).YCoord) / 2), ListAnnotation(i)(6), ListAnnotation(i)(5))
                ratios(2)(2) = Compare_RatioCalcul(ListAnnotation(i)(7), New Annotation((ListAnnotation(i)(0).XCoord + ListAnnotation(i)(1).XCoord) / 2, (ListAnnotation(i)(0).YCoord + ListAnnotation(i)(1).YCoord) / 2), ListAnnotation(i)(3), ListAnnotation(i)(2))
                ratios(2)(3) = Compare_RatioCalcul(ListAnnotation(i)(3), ListAnnotation(i)(2), ListAnnotation(i)(1), ListAnnotation(i)(0))

                If ratios(1) Is Nothing Then
                    ratios(1) = New List(Of Double)
                    For Each nb In ratios(2)
                        ratios(1).Add(nb)
                    Next
                    indPlusSimilaire = i
                Else
                    For y As Integer = 0 To ratios(0).Count - 1
                        dist01 += Pow((ratios(0)(y) - ratios(1)(y)), 2)
                        dist02 += Pow((ratios(0)(y) - ratios(2)(y)), 2)
                    Next
                    If dist02 < dist01 Then
                        ratios(1) = New List(Of Double)
                        For Each nb In ratios(2)
                            ratios(1).Add(nb)
                        Next
                        indPlusSimilaire = i
                    End If
                End If
            End If
            i += 1
        End While
        Return indPlusSimilaire
    End Function

    ' Renvoie le ratio correspondant
    ' Formule de calcul du ratio : ratio = (distance entre a1 et a2)/(distance entre a3 et a4)
    Public Function Compare_RatioCalcul(a1 As Annotation, a2 As Annotation, a3 As Annotation, a4 As Annotation)
        Return Sqrt(Pow((a2.XCoord - a1.XCoord), 2) + Pow((a2.YCoord - a1.YCoord), 2)) / Sqrt(Pow((a4.XCoord - a3.XCoord), 2) + Pow((a4.YCoord - a3.YCoord), 2))
    End Function
End Class

Public Class Annotation
    Private _xCoord, _yCoord As Double
    Private _picCross As PictureBox

    Public Property XCoord As Double
        Get
            Return _xCoord
        End Get
        Set(value As Double)
            _xCoord = value
        End Set
    End Property

    Public Property YCoord As Double
        Get
            Return _yCoord
        End Get
        Set(value As Double)
            _yCoord = value
        End Set
    End Property

    Public Sub New(xCoord As Double, yCoord As Double)
        Me.XCoord = xCoord
        Me.YCoord = yCoord
    End Sub

    Public Property PicCross As PictureBox
        Get
            Return _picCross
        End Get
        Set(value As PictureBox)
            _picCross = value
        End Set
    End Property

    ' Creer une picturebox piccross, et la positionne et l'affiche aux coordonnées de l'annotation
    ' Active également le menu Trouver sosie
    Public Sub Draw()
        PicCross = New PictureBox With {
            .Image = My.Resources.cross,
            .SizeMode = PictureBoxSizeMode.AutoSize,
            .Location = New Point(XCoord - 8, YCoord - 8),
            .BackColor = Color.Transparent,
            .Parent = frmMain.picImage
        }
        frmMain.picImage.Controls.Add(PicCross)
        PicCross.BringToFront()
        frmMain.TrouverSosieToolStripMenuItem.Enabled = True
    End Sub
End Class