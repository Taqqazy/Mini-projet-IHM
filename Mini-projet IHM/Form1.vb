Public Class Form1

    Private imageName As String
    Private fichierCsv1 As New FichierCsv
    Private cheminFichierCsv As String

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        EnregistrerToolStripMenuItem.Enabled = False
    End Sub

    Private Sub OuvrirImageToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OuvrirImageToolStripMenuItem.Click
        Dim OpenFileDialog1 As New OpenFileDialog
        OpenFileDialog1.Filter = "Image |*.jpg;*.jpeg;*.png"
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            Me.imageName = OpenFileDialog1.FileName
            PictureBox1.Image = Image.FromFile(imageName)
            OpenFileDialog1.InitialDirectory = OpenFileDialog1.FileName
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
            Save(saveFileDialog1.FileName)
            cheminFichierCsv = saveFileDialog1.FileName
            EnregistrerToolStripMenuItem.Enabled = True
            saveFileDialog1.InitialDirectory = saveFileDialog1.FileName
        End If
    End Sub

    Private Sub EnregistrerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EnregistrerToolStripMenuItem.Click
        Save(cheminFichierCsv)
    End Sub

    Private Sub Save(fileName As String)
        Dim streamCsv As IO.StreamWriter = My.Computer.FileSystem.OpenTextFileWriter(fileName, False)
        For i = 0 To fichierCsv1.ListFileName.Count - 1
            streamCsv.Write(fichierCsv1.ListFileName(i) + " | ")
            For y = 0 To fichierCsv1.ListAnnotation(i).Count - 1
                streamCsv.Write(fichierCsv1.ListAnnotation(i)(y).XCoord1.ToString + " " + fichierCsv1.ListAnnotation(i)(y).YCoord1.ToString + " | ")
            Next
            streamCsv.WriteLine()
        Next
        streamCsv.Close()
    End Sub
End Class


Public Class FichierCsv
    Private _listAnnotation As New List(Of List(Of Annotation))
    Private _listFileName As New List(Of String)
    Public Property ListAnnotation As List(Of List(Of Annotation))
        Get
            Return _listAnnotation
        End Get
        Set(value As List(Of List(Of Annotation)))
            _listAnnotation = value
        End Set
    End Property
    Public Property ListFileName As List(Of String)
        Get
            Return _listFileName
        End Get
        Set(value As List(Of String))
            _listFileName = value
        End Set
    End Property

    Public Sub Add(annotation As Annotation, imageName As String)
        Dim indexFileName As Integer
        If Not ListFileName.Contains(imageName) Then
            ListFileName.Add(imageName)
            ListAnnotation.Add(New List(Of Annotation))
            indexFileName = ListAnnotation.Count - 1
        Else
            indexFileName = ListFileName.IndexOf(imageName)
        End If
        ListAnnotation(indexFileName).Add(annotation)
    End Sub

    Public Sub Save(cheminCsv As String)
        Dim outCsv As IO.StreamWriter = My.Computer.FileSystem.OpenTextFileWriter(cheminCsv, False)
        outCsv.WriteLine("Bonjour")
        outCsv.WriteLine("Bonjour")
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
End Class
