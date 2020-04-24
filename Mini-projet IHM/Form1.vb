Public Class Form1

    Private imageName As String
    Private fichierCsv1 As New FichierCsv
    Private cheminFichierCsv As String
    Private _PartieSelectionee As Integer

    Public Property PartieSelectionee As Integer
        Get
            Return _PartieSelectionee
        End Get
        Set(value As Integer)
            _PartieSelectionee = value
            Label1.Text = value
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
        End If
    End Sub

    Private Sub PictureBox1_MouseClick(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseClick
        If PictureBox1.Image IsNot Nothing Then
            fichierCsv1.Add(New Annotation(e.X.ToString, e.Y.ToString), Me.imageName)
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

    Private Sub Y1MenuAjouter_Click(sender As Object, e As EventArgs) Handles Y1MenuAjouter.Click
        Me.PartieSelectionee = 0
        Label1.Text = "Y1"
    End Sub

    Private Sub Y2MenuAjouter_Click(sender As Object, e As EventArgs) Handles Y2MenuAjouter.Click
        Me.PartieSelectionee = 1
        Label1.Text = "Y2"
    End Sub

    Private Sub ToolStripMenuItem4_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem4.Click

    End Sub

    Private Sub Y1MenuSupprimer_Click(sender As Object, e As EventArgs) Handles Y1MenuSupprimer.Click

    End Sub
End Class

Public Class FichierCsv
    Private _listAnnotation As New List(Of Annotation())
    Private _listFileName As New List(Of String)

    Public Property ListFileName As List(Of String)
        Get
            Return _listFileName
        End Get
        Set(value As List(Of String))
            _listFileName = value
        End Set
    End Property

    Public Property ListAnnotation As List(Of Annotation())
        Get
            Return _listAnnotation
        End Get
        Set(value As List(Of Annotation()))
            _listAnnotation = value
        End Set
    End Property

    Public Sub Add(annotation As Annotation, imageName As String)
        Dim indexFileName As Integer
        If Not ListFileName.Contains(imageName) Then
            ListFileName.Add(imageName)
            Dim a(12) As Annotation
            ListAnnotation.Add(a)
            indexFileName = ListAnnotation.Count - 1
        Else
            indexFileName = ListFileName.IndexOf(imageName)
        End If
        ListAnnotation(indexFileName)(Form1.PartieSelectionee) = annotation

    End Sub

    Public Sub Supprimer(imageName As String)
        Dim indexFileName As Integer = ListFileName.IndexOf(imageName)
        ListAnnotation(indexFileName)(Form1.PartieSelectionee) = Nothing
        'TODO supprimer éléments d'un tableau
    End Sub
    Public Sub Save(fileName As String)
        Dim streamCsv As IO.StreamWriter = My.Computer.FileSystem.OpenTextFileWriter(fileName, False)
        For i = 0 To Me.ListFileName.Count - 1
            streamCsv.Write(Me.ListFileName(i) + " | ")
            For y = 0 To Me.ListAnnotation(i).Count - 1
                If Me.ListAnnotation(i)(y) Is Nothing Then
                    streamCsv.Write("null | ")
                Else
                    streamCsv.Write(Me.ListAnnotation(i)(y).XCoord1.ToString + " " + Me.ListAnnotation(i)(y).YCoord1.ToString + " | ")
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
    'TODO fonction load(fileName As String) qui lit un fichier .csv et initialise listAnnotation et listFileName en fonction
    Public Sub Load(fileName As String)

    End Sub
End Class

Public Class Annotation
    Private xCoord, yCoord As Double

    Public Sub New(xCoord As Double, yCoord As Double)
        Me.xCoord = xCoord
        Me.yCoord = yCoord
    End Sub

    Public Property XCoord1 As Double
        Get
            Return xCoord
        End Get
        Set(value As Double)
            xCoord = value
        End Set
    End Property

    Public Property YCoord1 As Double
        Get
            Return yCoord
        End Get
        Set(value As Double)
            yCoord = value
        End Set
    End Property

    Public Sub Draw()
        'TODO fonction annotation.draw()
    End Sub
End Class