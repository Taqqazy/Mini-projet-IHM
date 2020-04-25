Imports System.IO
Public Class Form1
    Private imageName As String
    Private _fichierCsv1 As New FichierCsv
    Private cheminFichierCsv As String
    Private _PartieSelectionee = -1

    Public Property PartieSelectionee As Integer
        Get
            Return _PartieSelectionee
        End Get
        Set(value As Integer)
            _PartieSelectionee = value
            Label1.Text = value
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

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        EnregistrerToolStripMenuItem.Enabled = False
        EditerToolStripMenuItem.Enabled = False
    End Sub

    Private Sub OuvrirImageToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OuvrirImageToolStripMenuItem.Click
        Dim OpenFileDialog1 As New OpenFileDialog
        OpenFileDialog1.Filter = "Image |*.jpg;*.jpeg;*.png"
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            Me.imageName = OpenFileDialog1.FileName
            PictureBox1.Image = Image.FromFile(imageName)
            OpenFileDialog1.InitialDirectory = OpenFileDialog1.FileName
            EditerToolStripMenuItem.Enabled = True
        End If

    End Sub

    Private Sub OuvrirAnnotationsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OuvrirAnnotationsToolStripMenuItem.Click
        Dim OpenFileDialog2 As New OpenFileDialog
        OpenFileDialog2.Filter = "csv file |*.csv"
        If OpenFileDialog2.ShowDialog() = DialogResult.OK Then
            Me.cheminFichierCsv = OpenFileDialog2.FileName
            OpenFileDialog2.InitialDirectory = OpenFileDialog2.FileName
            FichierCsv1.Load(Me.cheminFichierCsv)
            EnregistrerToolStripMenuItem.Enabled = True
        End If
    End Sub

    Private Sub PictureBox1_MouseClick(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseClick
        If PictureBox1.Image IsNot Nothing And PartieSelectionee <> -1 Then
            fichierCsv1.Add(New Annotation(e.X.ToString, e.Y.ToString), Me.imageName)
            PartieSelectionee = -1
        End If
    End Sub

    Private Sub EnregistrerSousToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EnregistrerSousToolStripMenuItem.Click
        Dim saveFileDialog1 As New SaveFileDialog
        saveFileDialog1.Filter = "csv files (*.csv)|*.csv"

        If saveFileDialog1.ShowDialog = DialogResult.OK Then
            fichierCsv1.Save(saveFileDialog1.FileName)
            cheminFichierCsv = saveFileDialog1.FileName
            EnregistrerToolStripMenuItem.Enabled = True
            saveFileDialog1.InitialDirectory = saveFileDialog1.FileName
        End If
    End Sub

    Private Sub EnregistrerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EnregistrerToolStripMenuItem.Click
        fichierCsv1.Save(cheminFichierCsv)
    End Sub

    Private Sub MenuAjouter_Click(sender As Object, e As EventArgs) Handles MenuAjouter1Y1.Click, MenuAjouter2Y2.Click, MenuAjouter3BVG.Click, MenuAjouter4BVD.Click, MenuAjouter5BN.Click, MenuAjouter6BNG.Click, MenuAjouter7BND.Click, MenuAjouter8BM.Click, MenuAjouter9HL.Click, MenuAjouter10BL.Click, MenuAjouter11GL.Click, MenuAjouter12DL.Click
        If Convert.ToInt32(sender.name(12)) - 48 <= 9 Then
            Me.PartieSelectionee = 10 * (Convert.ToInt32(sender.name(11)) - 48) + Convert.ToInt32(sender.name(12)) - 49
        Else
            Me.PartieSelectionee = Convert.ToInt32(sender.name(11)) - 49
        End If
    End Sub
    Private Sub MenuSupprimer_Click(sender As Object, e As EventArgs) Handles MenuSupprimer1Y1.Click, MenuSupprimer2Y2.Click, MenuSupprimer3BVG.Click, MenuSupprimer4BVD.Click, MenuSupprimer5BN.Click, MenuSupprimer6BNG.Click, MenuSupprimer7BND.Click, MenuSupprimer8BM.Click, MenuSupprimer9HL.Click, MenuSupprimer10BL.Click, MenuSupprimer11GL.Click, MenuSupprimer12DL.Click
        If Convert.ToInt32(sender.name(14)) - 48 <= 9 Then
            fichierCsv1.Delete(Me.imageName, 10 * (Convert.ToInt32(sender.name(13)) - 48) + Convert.ToInt32(sender.name(14)) - 49)
        Else
            fichierCsv1.Delete(Me.imageName, Convert.ToInt32(sender.name(13)) - 49)
        End If
    End Sub
    Private Sub QuitterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuitterToolStripMenuItem.Click
        Me.Close()
    End Sub
End Class

Public Class FichierCsv
    Private _listAnnotation As New List(Of List(Of Annotation))
    Private _listFileName As New List(Of String)

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
    Public Sub Add(annotation As Annotation, imageName As String)
        Dim indexFileName As Integer
        If Not ListFileName.Contains(imageName) Then
            ListFileName.Add(imageName)
            ListAnnotation.Add(New List(Of Annotation))
            For index = 0 To 11
                ListAnnotation.Last.Add(Nothing)
            Next
            indexFileName = ListAnnotation.Count - 1
        Else
            indexFileName = ListFileName.IndexOf(imageName)
        End If
        ListAnnotation(indexFileName)(Form1.PartieSelectionee) = annotation
        annotation.Draw()

    End Sub
    Public Sub Delete(imageName As String, indexASupprimer As Integer)
        Dim indexFileName As Integer = ListFileName.IndexOf(imageName)
        Form1.Controls.Remove(ListAnnotation(indexFileName)(indexASupprimer).PictureBoxCross)
        ListAnnotation(indexFileName)(indexASupprimer) = Nothing
    End Sub
    Public Sub Save(fileName As String)
        Dim streamCsv As StreamWriter = My.Computer.FileSystem.OpenTextFileWriter(fileName, False)
        For i = 0 To Me.ListFileName.Count - 1
            streamCsv.Write(Me.ListFileName(i) + " | ")
            For y = 0 To Me.ListAnnotation(i).Count - 1
                If Me.ListAnnotation(i)(y) Is Nothing Then
                    streamCsv.Write("null | ")
                Else
                    streamCsv.Write(Me.ListAnnotation(i)(y).XCoord.ToString + " " + Me.ListAnnotation(i)(y).YCoord.ToString + " | ")
                End If

            Next
            streamCsv.WriteLine()
        Next
        streamCsv.Close()
    End Sub
    Public Function isFull(fileIndex As Integer) As Boolean
        For index = 0 To 11
            If ListAnnotation(fileIndex)(index) Is Nothing Then
                Return False
            End If
        Next
        Return True
    End Function
    Public Sub Load(fileName As String)
        Dim numRows As Long
        Dim numCols As Long
        Dim tmpstream As StreamReader = File.OpenText(fileName)
        Dim strlines() As String
        Dim strline() As String
        Dim strlinecoords() As String
        Dim annotation As Annotation

        strlines = tmpstream.ReadToEnd().Split(Environment.NewLine, 50, StringSplitOptions.RemoveEmptyEntries)
        numRows = UBound(strlines)
        strline = strlines(0).Split("|", 14, StringSplitOptions.RemoveEmptyEntries)
        numCols = UBound(strline)

        For x As Integer = 0 To numRows
            strline = strlines(x).Split("|", 14, StringSplitOptions.RemoveEmptyEntries)
            For index As Integer = 0 To strline.Length - 1
                strline(index) = strline(index).Trim()
            Next
            For y As Integer = 1 To numCols
                If strline(y) <> "null" And strline(y) <> Nothing Then
                    strlinecoords = strline(y).Split(" ", 4, StringSplitOptions.RemoveEmptyEntries)
                    annotation = New Annotation(CInt(strlinecoords(0)), CInt(strlinecoords(1)))
                    Form1.PartieSelectionee = y - 1
                    Form1.FichierCsv1.Add(annotation, strline(0))
                    Form1.PartieSelectionee = -1
                End If
            Next
        Next
    End Sub

End Class

Public Class Annotation
    Private _xCoord, _yCoord As Double
    Private _pictureBoxCross As PictureBox

    Public Sub New(xCoord As Double, yCoord As Double)
        Me.xCoord = xCoord
        Me.yCoord = yCoord
    End Sub

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

    Public Property PictureBoxCross As PictureBox
        Get
            Return _pictureBoxCross
        End Get
        Set(value As PictureBox)
            _pictureBoxCross = value
        End Set
    End Property

    Public Sub Draw()
        PictureBoxCross = New PictureBox With {
            .Image = My.Resources.cross,
            .SizeMode = PictureBoxSizeMode.AutoSize,
            .Location = New Point(Form1.PictureBox1.Location.X + XCoord - 8, Form1.PictureBox1.Location.Y + YCoord - 8)
        }
        Form1.Controls.Add(PictureBoxCross)
        PictureBoxCross.BringToFront()
    End Sub

End Class