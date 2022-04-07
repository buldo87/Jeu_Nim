Imports System.Xml
Imports System.Xml.Serialization



Public Class statistique
    Private Sub statistique_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim d As System.IO.FileInfo
        'If d Then
        Lecture(My.Application.Info.DirectoryPath & "\niveau2.xlm")
            For i As Integer = 0 To 10000
            Next

            Graphique()
       ' End If

    End Sub
    Private Sub Graphique()
        Chart1.Series(1).Points.Clear()
        Chart1.Series(0).Points.Clear()

        For i As Integer = (LB_Score_IA.Items.Count - 1) To 0 Step -1
            Chart1.Series(0).Points.Add(LB_Score_IA.Items(i))
        Next

        For i As Integer = LB_Score_Humain.Items.Count - 1 To 0 Step -1
            Chart1.Series(1).Points.Add(LB_Score_Humain.Items(i))
        Next
    End Sub

    Private Sub OuvrirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OuvrirToolStripMenuItem.Click



        'générer un graphique des moyennes de l'évolution des résultats de l'humain et de l'ordinateur, résultats en fonction de l'ensemble des fichiers présent dans le dossier, classé par règles du jeu
        ' lire la liste des fichiers //option : de la règle voulu 
        For Each fichier As String In FolderBrowserDialog1.SelectedPath
            ' LB_Stats_fichiers.Items.Insert(0, fichier)
        Next
        ' qui est le gagnat à chaque incrément de partie
        ' faire la moyenne pour la partie 1, jusqu'au nombre de partie max présentes
        ' générer fichier des moyennes
        ' afficher le fichier
        OpenFichier.Filter = ("Fichier de configuration | *.xlm")
        If OpenFichier.ShowDialog = 1 Then
            ' Lecture(My.Application.Info.DirectoryPath & "\niveau2.xlm")
            Lecture(OpenFichier.FileName)
        End If

        Graphique()
    End Sub
    Private Sub Lecture(path)
        Chart1.Series(1).Points.Clear()
        Chart1.Series(0).Points.Clear()

        Dim config As New NIMConfig()
        LTexteFichier.Text = path
        Dim serializer As New XmlSerializer(config.GetType())
        Using reader = XmlReader.Create(path)
            config = CType(serializer.Deserialize(reader), NIMConfig)
        End Using

        L_Score_IA.Text = config.ScoreIA
        L_Score_Humain.Text = config.Scorehumain
        Cb_Prise.Text = config.Prise
        CB_Niveau.Text = config.QuelNiveau
        CB_Commence.Text = config.QuiCommence
        Cb_PerdGagne.Text = config.DerniereAllumette
        CB_allumette.Text = config.CombienAllumette
        L_NombrePartie.Text = (CInt(L_Score_IA.Text) + CInt(L_Score_Humain.Text))
        ' Score partie IA
        For Each val As String In config.ScorePartieIA
            LB_Score_IA.Items.Insert(0, val)
        Next

        ' Score partie Humain
        For Each val As String In config.ScorePartieHumain
            LB_Score_Humain.Items.Insert(0, val)
        Next
    End Sub


End Class