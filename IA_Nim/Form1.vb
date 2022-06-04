Imports System.Threading
Imports System.Xml
Imports System.Xml.Serialization

Public Class Form1
    Private Const NB_ALLUMETTES As Integer = 11
    Private faitlagueule As Boolean = 0
    Private nbAllumetteRestante As Integer
    Private nbAllumetteDepart As Integer
    Private nbAllumettePrise As Integer

    Private scoreIA As Integer
    Private scorehumain As Integer
    Private scoreHumainA As Integer

    Private quelNiveau As String
    Private quiCommence As String
    Private finTempo As Boolean = False
    Private derniereAllumette As String
    Private aquiLeTour As Player
    Private PartieEncours As Partie
    Private listAllumettes As List(Of Allumette)

    Public Enum Player
        Humain
        IA
        debut
    End Enum

    Public Enum Partie
        Encours
        Fin
    End Enum

    Private Class Allumette
        Public image As PictureBox
        Public choix As ListBox
        Public encours As TextBox

        Public Sub New(pimage As PictureBox, pchoix As ListBox, pencours As TextBox)
            image = pimage
            choix = pchoix
            encours = pencours
        End Sub
    End Class

    Public Sub New()
        listAllumettes = New List(Of Allumette)

        ' Cet appel est requis par le concepteur.
        InitializeComponent()

        ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
        listAllumettes.Add(New Allumette(PB_Allumette_1, LB_choix_possible_1, TB_En_cours_1))
        listAllumettes.Add(New Allumette(PB_Allumette_2, LB_choix_possible_2, TB_En_cours_2))
        listAllumettes.Add(New Allumette(PB_Allumette_3, LB_choix_possible_3, TB_En_cours_3))
        listAllumettes.Add(New Allumette(PB_Allumette_4, LB_choix_possible_4, TB_En_cours_4))
        listAllumettes.Add(New Allumette(PB_Allumette_5, LB_choix_possible_5, TB_En_cours_5))
        listAllumettes.Add(New Allumette(PB_Allumette_6, LB_choix_possible_6, TB_En_cours_6))
        listAllumettes.Add(New Allumette(PB_Allumette_7, LB_choix_possible_7, TB_En_cours_7))
        listAllumettes.Add(New Allumette(PB_Allumette_8, LB_choix_possible_8, TB_En_cours_8))
        listAllumettes.Add(New Allumette(PB_Allumette_9, LB_choix_possible_9, TB_En_cours_9))
        listAllumettes.Add(New Allumette(PB_Allumette_10, LB_choix_possible_10, TB_En_cours_10))
        listAllumettes.Add(New Allumette(PB_Allumette_11, LB_choix_possible_11, TB_En_cours_11))
        listAllumettes.Add(New Allumette(PB_Allumette_12, LB_choix_possible_12, TB_En_cours_12))

        AddHandler Cb_Prise.SelectedIndexChanged, AddressOf Me.Cb_Prise_SelectedIndexChanged_1
        AddHandler CB_allumette.SelectedIndexChanged, AddressOf Me.CB_allumette_SelectedIndexChanged_1
        AddHandler CB_Niveau.SelectedIndexChanged, AddressOf Me.CB_Niveau_SelectedIndexChanged
        AddHandler CB_Commence.SelectedIndexChanged, AddressOf Me.CB_Commence_SelectedIndexChanged_1
        AddHandler Cb_PerdGagne.SelectedIndexChanged, AddressOf Me.Cb_PerdGagne_SelectedIndexChanged
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RemiseAZero()
    End Sub

    Public Sub RemiseAZero()
        ' RAZ
        LB_Partie.Items.Clear()
        LB_Choix_IA.Items.Clear()
        LB_dernier_choix_IA.Items.Clear()
        LB_Choix_IA.Items.Clear()
        LB_Score_Humain.Items.Clear()
        LB_Score_IA.Items.Clear()
        CB_Commence.DropDownStyle = ComboBoxStyle.DropDownList
        CB_Niveau.DropDownStyle = ComboBoxStyle.DropDownList
        Cb_PerdGagne.DropDownStyle = ComboBoxStyle.DropDownList
        Cb_Prise.DropDownStyle = ComboBoxStyle.DropDownList
        CB_allumette.DropDownStyle = ComboBoxStyle.DropDownList


        nbAllumetteRestante = CB_allumette.SelectedItem
        PBIA.Image = My.Resources.debut

        'efface LB_choix_possible(i)
        For i As Integer = 0 To NB_ALLUMETTES
            listAllumettes.Item(i).choix.Items.Clear()
            listAllumettes.Item(i).image.Image = Global.Jeu_Nim.My.Resources.Resources.choisie
        Next

        ' place les objets de la liste allumette
        listAllumettes.Item(0).choix.Items.AddRange(New Object() {"1"})
        listAllumettes.Item(1).choix.Items.AddRange(New Object() {"1", "2"})

        Dim obj As Object = New Object() {"1", "2", "3"} ' place les objets de la liste allumette

        If Cb_Prise.SelectedItem.ToString = "3" Then 'test du nombre de prise
            For i As Integer = 2 To NB_ALLUMETTES
                listAllumettes.Item(i).choix.Items.AddRange(obj)
            Next
            For i As Integer = 1 To 3
                LB_Choix_IA.Items.Add(i) ' place les objets de choix_ia
            Next
        Else
            listAllumettes.Item(2).choix.Items.AddRange(obj)
            obj = New Object() {"1", "2", "3", "4"}
            For i As Integer = 3 To NB_ALLUMETTES
                listAllumettes.Item(i).choix.Items.AddRange(obj)
            Next
            For i As Integer = 1 To 4
                LB_Choix_IA.Items.Add(i) ' place les objets de choix_ia
            Next
        End If
        L_Score_Humain.Text = 0
        L_Score_IA.Text = 0
        Chart1.Series(1).Points.Clear()
        Chart1.Series(0).Points.Clear()
        LB_Score_Humain.Items.Clear()
        LB_Score_IA.Items.Clear()
        L_NombrePartie.Text = Convert.ToString(Convert.ToInt32(L_Score_Humain.Text) + Convert.ToInt16(L_Score_IA.Text))
        Dim déjaperdu As Boolean = False
        Regle()
        'CQuiCommence()
        EffaceScore()
    End Sub

    Public Sub Regle()
        LB_Partie.Items.Clear()
        LB_IA.Items.Clear()

        LB_Partie.Items.Add("*** Règles en cours ***")
        LB_Partie.Items.Add("Dernière allumette = " & Cb_PerdGagne.Text)
        LB_Partie.Items.Add("Niveau = " & CB_Niveau.Text)
        LB_Partie.Items.Add("Qui commence = " & CB_Commence.Text)
        LB_Partie.Items.Add("Prise maximum = " & Cb_Prise.Text)
        LB_Partie.Items.Add("Nombre d'allumettes = " & CB_allumette.Text)
        LB_Partie.Items.Add("**** Début de partie *** ")
        LB_Choix_IA.ClearSelected()
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
    Public Sub PremierCoup_IA()
        Dim rancon As New Random
        Dim t As Integer
        Dim index As Integer = nbAllumetteRestante - 1
        Dim count_choix_possible As Integer = listAllumettes.Item(index).choix.Items.Count

        nbAllumetteRestante = CB_allumette.SelectedItem.ToString ' permet de choisir au hasard dans la liste
        L_Dernier_choix.Text = nbAllumetteRestante 'le choix  est validé
        t = listAllumettes.Item(index).choix.Items.Item(rancon.Next(count_choix_possible)) ' random des possibles
        listAllumettes.Item(index).encours.Text = t

        For i As Integer = 1 To t
            listAllumettes.Item(nbAllumetteRestante - i).image.Image = Global.Jeu_Nim.My.Resources.Resources.choisie

        Next
        Timer1.Enabled = True
        'Do Until finTempo

        'Loop
        finTempo = False
        LB_IA.Items.Insert(0, ".....................")
        LB_IA.Items.Insert(0, "Mon choix est " & t & " pour " & nbAllumetteRestante & " allumette(s)")
        LB_IA.Items.Insert(0, "A mon tour ... ")

        Dim cindex As Integer = listAllumettes.Item(index).choix.FindString(t)
        If cindex <> -1 Then listAllumettes.Item(index).choix.SelectedIndex = cindex
        LB_Choix_IA.SelectedIndex = t - 1
        nbAllumetteRestante -= t 'allumette = allumette - t
        Tb_allumette_restante.Text = nbAllumetteRestante 'afficher nouvelle valeur allumette restante
        LB_Partie.Items.Add("L'ordinateur prend " & t & " allumette(s), il en reste " & nbAllumetteRestante)
        PBIA.Image = My.Resources.a_vous
        LB_dernier_choix_IA.Items.Add(L_Dernier_choix.Text)
    End Sub
    Public Sub Premier_coup_random()
        Dim rancon As New Random
        Dim t As Integer
        Dim index As Integer = nbAllumetteRestante - 1
        Dim count_choix_possible As Integer = listAllumettes.Item(index).choix.Items.Count
        L_Dernier_choix.Text = nbAllumetteRestante
        Dim niveau As String
        niveau = CB_Niveau.SelectedItem.ToString
        If niveau = "4" Then
            nbAllumetteRestante = Tb_allumette_restante.Text ' permet de choisir au hasard dans la liste

            If Cb_PerdGagne.SelectedItem.ToString = "perd" Then
                t = Math.Min(nbAllumetteRestante, ((nbAllumetteRestante - 1) Mod (Cb_Prise.SelectedItem.ToString + 1)))
            Else
                t = Math.Min(nbAllumetteRestante, (nbAllumetteRestante) Mod (Cb_Prise.SelectedItem.ToString + 1))
            End If

            Cb_Prise.Text = (Math.Max(1, t))
        Else
            t = listAllumettes.Item(index).choix.Items.Item(rancon.Next(count_choix_possible)) ' random des possibles
        End If
        LB_IA.Items.Insert(0, ".....................")
        LB_IA.Items.Insert(0, "Mon choix est " & t & " pour " & nbAllumetteRestante & " allumette(s), il en reste " & nbAllumetteRestante)
        LB_Choix_IA.SelectedIndex = t - 1
        L_Dernier_choix.Text = nbAllumetteRestante
        LB_IA.Items.Insert(0, "A mon tour ... ")

        listAllumettes.Item(index).encours.Text = t

        Dim cindex As Integer = listAllumettes.Item(index).choix.FindString(t)
        If cindex <> -1 Then listAllumettes.Item(index).choix.SelectedIndex = cindex

        nbAllumetteRestante -= t 'allumette = allumette - t
        Tb_allumette_restante.Text = nbAllumetteRestante 'afficher nouvelle valeur allumette restante
        LB_Partie.Items.Add("L'ordinateur prend " & t & " allumette(s), il en reste " & nbAllumetteRestante)
        LB_Choix_IA.SelectedIndex = t - 1
        PBIA.Image = My.Resources.a_vous
        LB_dernier_choix_IA.Items.Add(L_Dernier_choix.Text)
    End Sub

    Public Sub CQuiCommence()
        Dim rancon As New Random

        Select Case CB_Commence.SelectedItem.ToString
            Case "Aléatoire"
                aquiLeTour = rancon.Next() Mod 2

            Case "Humain"
                aquiLeTour = Player.Humain

            Case "IA"
                aquiLeTour = Player.IA

            Case "Chacun son tour"
                aquiLeTour = 2 - aquiLeTour
            Case "debut"
                aquiLeTour = Player.debut

            Case Else

        End Select

        If aquiLeTour = Player.Humain Then
            EnableUI(True)
        ElseIf aquiLeTour = Player.debut Then 'IA Joue le 1er

            Dim niveau As String
            niveau = CB_Niveau.SelectedItem.ToString
            Select Case niveau
                Case "1"
                    PremierCoup_IA()

                Case "3"
                    PremierCoup_IA()
                Case "2"
                    IA_calculBon() ' trouve directe la bonne solution.
                Case "4"
                    IA_CalculMauvais() ' trouve directe la mauvaise solution.
                Case Else
                    PremierCoup_IA()
            End Select

            EnableUI(True)
            B_Rejouer.Enabled = False
            GB_Setup.Enabled = False

        Else

            IA()

        End If
    End Sub

    Public Sub IA()

        Dim niveau As String
        niveau = CB_Niveau.SelectedItem.ToString
        'Graphique()
        Select Case niveau
            Case "1"
                IA_Random()
            Case "3"
                IA_2()
            Case "2"
                IA_calculBon() ' trouve directe la mauvaise solution.
            Case "4"
                IA_CalculMauvais() ' trouve directe la mauvaise solution.
            Case Else
                IA_2()
        End Select

        EnableUI(True)
    End Sub

    Public Sub Humain() ' Permet au joueur humain d'entrer son coup
        'Graphique()
        EnableUI(False)
        If PartieEncours = Partie.Encours Then
            If faitlagueule Then
                PBIA.Image = My.Resources.perdu
                faitlagueule = False
            ElseIf PartieEncours = Partie.Encours Then
                PBIA.Image = My.Resources.a_moi
            End If

        End If


        Dim t As New Task(
        New Action(Sub()
                       Thread.Sleep(1500)

                       Me.Invoke(Sub()
                                     nbAllumetteRestante = Tb_allumette_restante.Text
                                     EnableUI(True)
                                     If Tb_allumette_restante.Text < 1 Then

                                         If Cb_PerdGagne.SelectedItem.ToString = "gagne" Then
                                             Perd() ' quand IA perd
                                         Else
                                             Gagne() ' quand IA gagne

                                         End If
                                         PartieEncours = Partie.Fin
                                         EnableUI(True) ' désactive les boutons allumettes
                                     Else
                                         If PartieEncours = Partie.Encours And Player.IA Then
                                             IA()
                                         End If
                                     End If
                                 End Sub)

                   End Sub))
        t.Start()
    End Sub
    Public Sub IA_Random() ' choix aléatoire à chaque fois


        Dim rancon As New Random
        Dim t As Integer

        nbAllumetteRestante = Tb_allumette_restante.Text
        ' permet de choisir au hasard dans la liste
        If nbAllumetteRestante > 0 Then
            Dim index As Integer = nbAllumetteRestante - 1
            Dim count_choix_possible As Integer = listAllumettes.Item(index).choix.Items.Count

            L_Dernier_choix.Text = nbAllumetteRestante
            t = listAllumettes.Item(index).choix.Items.Item(rancon.Next(count_choix_possible)) ' random des possibles
            LB_IA.Items.Insert(0, ".....................")
            LB_IA.Items.Insert(0, "Je vais choisir ... " & t & " pour " & nbAllumetteRestante & " allumette(s), il en reste " & nbAllumetteRestante)


            LB_Choix_IA.SelectedIndex = t - 1
            LB_IA.Items.Insert(0, "A mon tour ... ")



            listAllumettes.Item(index).encours.Text = t

            Dim cindex As Integer = listAllumettes.Item(index).choix.FindString(t)
            If cindex <> -1 Then listAllumettes.Item(index).choix.SelectedIndex = cindex

            nbAllumetteRestante -= t 'allumette = allumette - t
            Tb_allumette_restante.Text = nbAllumetteRestante 'afficher nouvelle valeur allumette restante
            LB_Partie.Items.Add("L'ordinateur prend " & t & " allumette(s), il en reste " & nbAllumetteRestante)
            LB_Choix_IA.SelectedIndex = t - 1

        End If

        If nbAllumetteRestante <= 0 Then
            If Cb_PerdGagne.SelectedItem.ToString = "perd" Then
                Perd()
            Else
                Gagne()
            End If
        End If

        LB_dernier_choix_IA.Items.Add(L_Dernier_choix.Text)
        AfficherAllumette()

        L_dialog.Text = "L'ordinateur joue " & t

    End Sub

    Public Sub IA_2() ' quand on perd les erreurs sont retiré

        Dim rancon As New Random
        Dim t As Integer

        nbAllumetteRestante = Tb_allumette_restante.Text ' permet de choisir au hasard dans la liste

        If PartieEncours = Partie.Encours Then
            Dim index As Integer = nbAllumetteRestante - 1
            Dim count_choix_possible As Integer = listAllumettes.Item(index).choix.Items.Count
            If count_choix_possible = 0 Then 'si plus de choix possible
                t = Math.Min(nbAllumetteRestante, Convert.ToInt32(LB_Choix_IA.Items.Item(rancon.Next(3))))
                LB_IA.Items.Insert(0, ".....................")
                LB_IA.Items.Insert(0, "je n'ai plus de choix, je vais certainement perdre !!!!!!")
                LB_IA.Items.Insert(0, "Mais ! Pfffff à mon tour ... ")
                faitlagueule = True
                LB_Choix_IA.SelectedIndex = t - 1
            Else
                L_Dernier_choix.Text = nbAllumetteRestante 'le choix  est validé
                t = listAllumettes.Item(index).choix.Items.Item(rancon.Next(count_choix_possible)) ' random des possibles
                listAllumettes.Item(index).encours.Text = t
                LB_IA.Items.Insert(0, ".....................")
                LB_IA.Items.Insert(0, "Je choisi " & t & " pour " & nbAllumetteRestante & " allumette(s).")
                LB_IA.Items.Insert(0, "A mon tour ... ")


                Dim cindex As Integer = listAllumettes.Item(index).choix.FindString(t)
                If cindex <> -1 Then listAllumettes.Item(index).choix.SelectedIndex = cindex
                LB_Choix_IA.SelectedIndex = t - 1

            End If

            nbAllumetteRestante -= t 'allumette = allumette - t
            Tb_allumette_restante.Text = nbAllumetteRestante 'afficher nouvelle valeur allumette restante
            LB_Partie.Items.Add("L'ordinateur prend " & t & " allumette(s), il en reste " & nbAllumetteRestante)
            PBIA.Image = My.Resources.a_vous
        End If

        If nbAllumetteRestante < 1 Then
            If Cb_PerdGagne.SelectedItem.ToString = "perd" Then
                Perd()
            Else
                Gagne()
            End If



        End If


        LB_dernier_choix_IA.Items.Add(L_Dernier_choix.Text)
        AfficherAllumette()

        L_dialog.Text = "L'ordinateur joue " & t

    End Sub

    Public Sub IA_calculBon() ' trouve directe la solution.

        Dim t As Integer
        'Dim rancon As New Random ' permet de choisir au hasard dans la liste
        nbAllumetteRestante = Tb_allumette_restante.Text

        If Cb_PerdGagne.SelectedItem.ToString = "perd" Then
            t = Math.Min(nbAllumetteRestante, (nbAllumetteRestante - 1) Mod (Cb_Prise.SelectedItem.ToString + 1))
            If t = 0 Then
                LB_IA.Items.Insert(0, ".....................")
                LB_IA.Items.Insert(0, "Mais ! Pffff Bon tanpis, je vais prendre une allumette. ")
                LB_IA.Items.Insert(0, "Calculons : mon choix est " & nbAllumetteRestante & " modulo " & Cb_Prise.SelectedItem.ToString + 1 & " = " & t & " Mince !")
                LB_IA.Items.Insert(0, "A mon tour ... ")

                t = 1
            Else
                LB_IA.Items.Insert(0, ".....................")
                LB_IA.Items.Insert(0, "Je vais prendre alors " & t & " allumette(s). ")
                LB_IA.Items.Insert(0, "Calculons : mon choix est " & nbAllumetteRestante - 1 & " modulo " & Cb_Prise.SelectedItem.ToString + 1 & " = " & t)
                LB_IA.Items.Insert(0, "A mon tour ... ")

            End If
        Else
            t = Math.Min(nbAllumetteRestante, (nbAllumetteRestante) Mod (Cb_Prise.SelectedItem.ToString + 1))
            If t = 0 Then
                LB_IA.Items.Insert(0, ".....................")
                LB_IA.Items.Insert(0, "Pffff Bon tanpis, je vais prendre une allumette. ")
                LB_IA.Items.Insert(0, "Calculons : mon choix est " & nbAllumetteRestante & " modulo " & Cb_Prise.SelectedItem.ToString + 1 & " = " & t & " Mince !")
                LB_IA.Items.Insert(0, "A mon tour ... ")

                t = 1
            Else
                LB_IA.Items.Insert(0, ".....................")
                LB_IA.Items.Insert(0, "Je vais prendre alors " & t & " allumette(s). ")
                LB_IA.Items.Insert(0, "Calculons : mon choix est " & nbAllumetteRestante & " modulo " & Cb_Prise.SelectedItem.ToString + 1 & " = " & t)
                LB_IA.Items.Insert(0, "A mon tour ... ")

            End If
        End If

        'Cb_Prise.Text = Math.Max(1, t)
        LB_Choix_IA.SelectedIndex = t - 1
        nbAllumetteRestante -= t 'allumette = allumette - t
        Tb_allumette_restante.Text = nbAllumetteRestante 'afficher nouvelle valeur allumette restante
        LB_Partie.Items.Add("L'Ordinateur prend " & t & " allumette(s), il en reste " & nbAllumetteRestante)

        If nbAllumetteRestante < 1 Then
            If Cb_PerdGagne.SelectedItem.ToString = "perd" Then
                Perd()
            Else
                Gagne()
            End If
        End If
        LB_dernier_choix_IA.Items.Add(L_Dernier_choix.Text)
        AfficherAllumette()
        L_dialog.Text = "L'Ordinateur joue " & t

    End Sub
    Public Sub IA_CalculMauvais() ' trouve directe la mauvaise solution.

        Dim t As Integer
        Dim rancon As New Random
        nbAllumetteRestante = Tb_allumette_restante.Text ' permet de choisir au hasard dans la liste

        '       If Cb_PerdGagne.SelectedItem.ToString = "perd" Then
        '       t = Math.Min(nbAllumetteRestante, ((nbAllumetteRestante) Mod (Cb_Prise.SelectedItem.ToString + 1)))
        '       LB_IA.Items.Insert(0, "Mon choix est " & nbAllumetteRestante & " modulo " & Cb_Prise.SelectedItem.ToString + 1 & " = " & t)
        '       LB_IA.Items.Insert(0, "A mon tour ... ")
        '        Else
        '        t = Math.Min(nbAllumetteRestante, (nbAllumetteRestante - 1) Mod (Cb_Prise.SelectedItem.ToString + 1))
        '       LB_IA.Items.Insert(0, "Mon choix est " & nbAllumetteRestante - 1 & " modulo " & Cb_Prise.SelectedItem.ToString + 1 & " = " & t)
        '       LB_IA.Items.Insert(0, "A mon tour ... ")
        '      End If

        If Cb_PerdGagne.SelectedItem.ToString = "perd" Then
            t = Math.Min(nbAllumetteRestante, ((nbAllumetteRestante) Mod (Cb_Prise.SelectedItem.ToString + 1)))
            If t = 0 Then
                LB_IA.Items.Insert(0, ".....................")
                LB_IA.Items.Insert(0, "Pffff Bon d'accord, tanpis, je vais prendre une allumette. ")
                LB_IA.Items.Insert(0, "Calculons : mon choix est " & nbAllumetteRestante & " modulo " & Cb_Prise.SelectedItem.ToString + 1 & " = " & t & " Mince !")
                LB_IA.Items.Insert(0, "A mon tour ... ")
                t = 1
            Else
                LB_IA.Items.Insert(0, ".....................")
                LB_IA.Items.Insert(0, "Pffff Bon d'accord, tanpis, je vais prendre une allumette. ")
                LB_IA.Items.Insert(0, "Calculons : mon choix est " & nbAllumetteRestante - 1 & " modulo " & Cb_Prise.SelectedItem.ToString + 1 & " = " & t)
                LB_IA.Items.Insert(0, "A mon tour ... ")

            End If
        Else
            t = Math.Min(nbAllumetteRestante, (nbAllumetteRestante - 1) Mod (Cb_Prise.SelectedItem.ToString + 1))
            If t = 0 Then
                LB_IA.Items.Insert(0, ".....................")
                LB_IA.Items.Insert(0, "Pffff Bon d'accord, je vais prendre une allumette. ")
                LB_IA.Items.Insert(0, "Calculons : mon choix est " & nbAllumetteRestante & " modulo " & Cb_Prise.SelectedItem.ToString + 1 & " = " & t & " Mince !")
                LB_IA.Items.Insert(0, "A mon tour ... ")

                t = 1
            Else
                LB_IA.Items.Insert(0, ".....................")
                LB_IA.Items.Insert(0, "Je vais prendre alors " & t & " allumette(s). ")
                LB_IA.Items.Insert(0, "Calculons : mon choix est " & nbAllumetteRestante & " modulo " & Cb_Prise.SelectedItem.ToString + 1 & " = " & t)
                LB_IA.Items.Insert(0, "A mon tour ... ")

            End If
        End If
        Cb_Prise.Text = (t)
        LB_Choix_IA.SelectedIndex = t - 1
        nbAllumetteRestante -= t 'allumette = allumette - t
        Tb_allumette_restante.Text = nbAllumetteRestante 'afficher nouvelle valeur allumette restante
        LB_Partie.Items.Add("L'Ordinateur prend " & t & " allumette(s), il en reste " & nbAllumetteRestante)
        If nbAllumetteRestante <= 0 Then
            If Cb_PerdGagne.SelectedItem.ToString = "perd" Then
                Perd()
            Else
                Gagne()
            End If
        End If
        LB_dernier_choix_IA.Items.Add(L_Dernier_choix.Text)
        AfficherAllumette()
        L_dialog.Text = "L'Ordinateur joue " & t

    End Sub
    Public Sub GardeLeBonChoix()
        Dim value As Integer = LB_dernier_choix_IA.Text - 1
        Dim cindex As Integer = listAllumettes.Item(value).choix.FindString(listAllumettes.Item(value).encours.Text)
        listAllumettes.Item(value).choix.Items.Clear()
        listAllumettes.Item(value).choix.Items.Add(cindex)
    End Sub
    Public Sub Gagne() ' quand IA gagne
        GB_Setup.Enabled = Enabled
        L_dialog.Text = "L'Ordinateur Gagne "

        LB_Partie.Items.Add("L'Ordinateur Gagne ")


        PBIA.Image = My.Resources.gagne
        L_Score_IA.Text = L_Score_IA.Text + 1
        LB_Score_IA.Items.Insert(0, L_Score_IA.Text)
        LB_Score_Humain.Items.Insert(0, L_Score_Humain.Text)
        If CB_Niveau.SelectedIndex.ToString = "0" Then
            LB_IA.Items.Insert(0, "---------------------")
            LB_IA.Items.Insert(0, "C'est simple ce jeu !")


        ElseIf CB_Niveau.SelectedIndex.ToString = "2" Then
            LB_IA.Items.Insert(0, "---------------------")
            LB_IA.Items.Insert(0, "Quand il restait " & L_Dernier_choix.Text & " allumette(s), j'ai fait le bon choix, mémorisons cette valeur !")
            LB_IA.Items.Insert(0, "Yes, je progresse !")

        ElseIf CB_Niveau.SelectedIndex.ToString = "1" Then ' trouve directe la solution.
            LB_IA.Items.Insert(0, "---------------------")
            LB_IA.Items.Insert(0, "I'm the best, j'adore les Maths ! ")


        ElseIf CB_Niveau.SelectedIndex.ToString = "3" Then  ' trouve directe la mauvaise solution.
            LB_IA.Items.Insert(0, "Pas possible !!!!!!!!!!!!! ! ")

        End If

        LB_IA.Items.Insert(0, "HiHAHHHHHH j'ai gagné.")

        L_NombrePartie.Text = Convert.ToString(Convert.ToInt32(L_Score_Humain.Text) + Convert.ToInt16(L_Score_IA.Text))
        PartieEncours = Partie.Fin
        EnableUI(True)
        GB_Setup.Enabled = True
        B_Rejouer.Enabled = True
        Graphique()
    End Sub

    Public Sub Perd() ' quand IA perd
        LB_Partie.Items.Add("l'Humain Gagne ")
        L_Score_Humain.Text = L_Score_Humain.Text + 1
        LB_Score_IA.Items.Insert(0, L_Score_IA.Text)
        LB_Score_Humain.Items.Insert(0, L_Score_Humain.Text)

        If CB_Niveau.SelectedIndex.ToString = "0" Then 'en fonction du niveau 1
            LB_IA.Items.Insert(0, "---------------------")
            LB_IA.Items.Insert(0, "Je n'ai pas de chance !")

        ElseIf CB_Niveau.SelectedIndex.ToString = "2" Then 'en fonction du niveau 3 ia
            Dim value As Integer = L_Dernier_choix.Text - 1 ' index de ListAllumettes
            If L_Dernier_choix.Text <> "13" Then
                Dim cindex As Integer = listAllumettes.Item(value).choix.FindString(listAllumettes.Item(value).encours.Text) 'cindex nb allumettes dans encours
                If L_Dernier_choix.Text <> 0 Then
                    nbAllumetteDepart = CB_allumette.SelectedItem
                    If cindex <> -1 And listAllumettes.Item(nbAllumetteDepart - nbAllumettePrise).choix.Items.ToString <> "" Then
                        listAllumettes.Item(value).choix.Items.RemoveAt(cindex) 'efface le dernier choix valide
                    End If
                End If
                LB_IA.Items.Insert(0, "---------------------")
                LB_IA.Items.Insert(0, "J'effaçe de mes choix possible : Prendre " & cindex + 1 & " allumette(s)")
                LB_IA.Items.Insert(0, "Mais pourquoi ai-je fait ce choix quand il restait " & L_Dernier_choix.Text & " allumette(s) ?")
                LB_IA.Items.Insert(0, "OK j'ai perdu, mais ça ne va pas durer ...")
            End If

        ElseIf CB_Niveau.SelectedIndex.ToString = "1" Then 'en fonction du niveau 2
            LB_IA.Items.Insert(0, "---------------------")
            LB_IA.Items.Insert(0, "Tu es très fort ... ")
            LB_IA.Items.Insert(0, "Félicitation Humain !")

        ElseIf CB_Niveau.SelectedIndex.ToString = "3" Then 'en fonction du niveau 4
            LB_IA.Items.Insert(0, "---------------------")
            LB_IA.Items.Insert(0, "Mince, il faudrait revoir mes calculs ! ")
            LB_IA.Items.Insert(0, "OUPPS j'ai perdu.")

        End If

        L_NombrePartie.Text = Convert.ToString(Convert.ToInt32(L_Score_Humain.Text) + Convert.ToInt16(L_Score_IA.Text))
        GB_Setup.Enabled = True
        B_Rejouer.Enabled = True
        PBIA.Image = My.Resources.perdu 'visage faire la gueule
        Graphique()
        PartieEncours = Partie.Fin
        EnableUI(True)
    End Sub

    Private Sub CB_allumette_SelectedIndexChanged(sender As Object, e As EventArgs)
        AfficherAllumette()
        nbAllumetteRestante = CB_allumette.SelectedItem
        Tb_allumette_restante.Text = CB_allumette.SelectedItem
    End Sub

    Private Sub Tb_allumette_restante_TextChanged(sender As Object, e As EventArgs) Handles Tb_allumette_restante.TextChanged
        AfficherAllumette()
    End Sub

    Private Sub AfficherAllumette()
        If listAllumettes.Count > 0 Then
            For i As Integer = 0 To NB_ALLUMETTES
                If i < nbAllumetteRestante Then
                    listAllumettes.Item(i).image.Visible = True
                Else
                    listAllumettes.Item(i).image.Visible = False
                End If
            Next
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' bouton 1 allumettes
        If Tb_allumette_restante.Text > 0 Then

            Tb_allumette_restante.Text -= 1
            nbAllumetteRestante -= 1
            LB_Partie.Items.Add("L'Humain prend 1 allumette, il en reste " & nbAllumetteRestante)
            AfficherAllumette()
            B_Rejouer.Enabled = False
            GB_Setup.Enabled = False

            If Tb_allumette_restante.Text > 0 Then
                PartieEncours = Partie.Encours

            Else
                PartieEncours = Partie.Fin
                EnableUI(True)
                GB_Setup.Enabled = True
            End If
            Humain()

        End If
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ' bouton 2 allumettes
        If Tb_allumette_restante.Text > 1 Then

            Tb_allumette_restante.Text -= 2
            nbAllumetteRestante -= 2
            LB_Partie.Items.Add("L'Humain prend 2 allumettes, il en reste " & nbAllumetteRestante)
            AfficherAllumette()
            B_Rejouer.Enabled = False
            GB_Setup.Enabled = False

            If Tb_allumette_restante.Text > 0 Then
                PartieEncours = Partie.Encours

            Else
                PartieEncours = Partie.Fin
                EnableUI(True)
                GB_Setup.Enabled = True
            End If
            Humain()

        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ' bouton 3 allumettes
        If Tb_allumette_restante.Text > 2 Then
            GB_Setup.Enabled = False
            Tb_allumette_restante.Text -= 3
            nbAllumetteRestante -= 3
            LB_Partie.Items.Add("L'Humain prend 3 allumettes, il en reste " & nbAllumetteRestante)
            AfficherAllumette()
            B_Rejouer.Enabled = False


            If Tb_allumette_restante.Text > 0 Then
                PartieEncours = Partie.Encours

            Else
                PartieEncours = Partie.Fin
                EnableUI(True)
                GB_Setup.Enabled = True
            End If
            Humain()
        End If
    End Sub


    Private Sub Button4_Click_1(sender As Object, e As EventArgs) Handles Button4.Click
        ' bouton 4 allumettes
        If Tb_allumette_restante.Text > 3 Then
            GB_Setup.Enabled = False

            Tb_allumette_restante.Text -= 4
            nbAllumetteRestante -= 4
            LB_Partie.Items.Add("L'Humain prend 4 allumette, il en reste " & nbAllumetteRestante)
            AfficherAllumette()
            B_Rejouer.Enabled = False

            If Tb_allumette_restante.Text > 0 Then
                PartieEncours = Partie.Encours

            Else
                PartieEncours = Partie.Fin
                EnableUI(True)
                GB_Setup.Enabled = True
            End If
            Humain()
        End If
    End Sub

    Private Sub B_Rejouer_Click_1(sender As Object, e As EventArgs) Handles B_Rejouer.Click
        Tb_allumette_restante.Text = CB_allumette.SelectedItem.ToString
        nbAllumetteRestante = CB_allumette.SelectedItem.ToString

        L_dialog.Text = "Rejouons "
        LB_dernier_choix_IA.ClearSelected()
        LB_dernier_choix_IA.Items.Clear()
        LB_Choix_IA.ClearSelected()
        L_Dernier_choix.Text = "13"
        For i As Integer = 0 To NB_ALLUMETTES
            listAllumettes.Item(i).encours.Clear()
            listAllumettes.Item(i).choix.ClearSelected()
        Next

        AfficherAllumette()
        Regle()

        LB_Partie.Items.Add("Rejouons, Humain " & L_Score_Humain.Text & ", Ordinateur " & L_Score_IA.Text)

        CQuiCommence()

        PartieEncours = Partie.Encours
        PBIA.Image = My.Resources.debut 'visage faire la gueule

    End Sub

    Private Sub EnableUI(enabled As Boolean)
        If Tb_allumette_restante.Text = "0" Then
            PartieEncours = Partie.Fin
            Button1.Enabled = False
            Button2.Enabled = False
            Button3.Enabled = False
            Button4.Enabled = False
            B_Rejouer.Enabled = enabled
        ElseIf Tb_allumette_restante.Text = "1" Then
            Button1.Enabled = enabled
            Button2.Enabled = False
            Button3.Enabled = False
            Button4.Enabled = False
        ElseIf Tb_allumette_restante.Text = "2" Then
            Button1.Enabled = enabled
            Button2.Enabled = enabled
            Button3.Enabled = False
            Button4.Enabled = False

        ElseIf Tb_allumette_restante.Text = "3" Then
            Button1.Enabled = enabled
            Button2.Enabled = enabled
            Button3.Enabled = enabled
            Button4.Enabled = False
        Else
            Button1.Enabled = enabled
            Button2.Enabled = enabled
            Button3.Enabled = enabled

            If Cb_Prise.SelectedItem.ToString = "3" Then
                Button4.Enabled = False
            Else
                Button4.Enabled = enabled
            End If
        End If

    End Sub

    Private Sub PBIA_Click(sender As Object, e As EventArgs) Handles PBIA.DoubleClick
        RemiseAZero()
    End Sub

    Public Sub Cb_Prise_SelectedIndexChanged_1(sender As Object, e As EventArgs)
        nbAllumettePrise = Cb_Prise.SelectedItem.ToString

        '   AfficherchoixPossible()
        If nbAllumettePrise = "3" Then
            Button4.Enabled = False
        Else
            Button4.Enabled = Enabled
        End If

        RemiseAZero()
        AfficherchoixPossible()
        EffaceScore()
    End Sub

    Private Sub CB_allumette_SelectedIndexChanged_1(sender As Object, e As EventArgs)
        'changement nombre d'allumette au départ
        nbAllumetteDepart = CB_allumette.SelectedItem
        Tb_allumette_restante.Text = CB_allumette.SelectedItem
        nbAllumetteRestante = CB_allumette.SelectedItem
        RemiseAZero()
        AfficherAllumette()
        AfficherchoixPossible()
    End Sub

    Private Sub CB_Commence_SelectedIndexChanged(sender As Object, e As EventArgs)

        'quiCommence As String
        RemiseAZero()
        AfficherchoixPossible()
        EffaceScore()

    End Sub

    Private Sub CB_Niveau_SelectedIndexChanged(sender As Object, e As EventArgs)
        'quelNiveau As String
        RemiseAZero()
        AfficherchoixPossible()
        EffaceScore()

    End Sub

    Private Sub Cb_PerdGagne_SelectedIndexChanged(sender As Object, e As EventArgs)
        ' derniereAllumette As String
        RemiseAZero()
        AfficherchoixPossible()
        EffaceScore()
    End Sub
    Private Sub CB_Commence_SelectedIndexChanged_1(sender As Object, e As EventArgs)
        RemiseAZero()
        AfficherchoixPossible()
        EffaceScore()
    End Sub
    Public Sub AfficherchoixPossible()
        ' Efface les choix possible
        For i As Integer = 0 To NB_ALLUMETTES
            listAllumettes.Item(i).choix.Items.Clear()
        Next

        ' Ajoutes les choix possibles des allumettes
        listAllumettes.Item(0).choix.Items.AddRange(New Object() {"1"})
        listAllumettes.Item(1).choix.Items.AddRange(New Object() {"1", "2"})
        listAllumettes.Item(2).choix.Items.AddRange(New Object() {"1", "2", "3"})

        ' Prise en compte du mode 3 ou 4 allumettes par prise
        Dim obj As Object
        If Cb_Prise.SelectedItem.ToString = "3" Then
            obj = New Object() {"1", "2", "3"}
        Else
            obj = New Object() {"1", "2", "3", "4"}
        End If

        ' Mise à jour des choix des allumettes restantes avec 3 ou 4
        For i As Integer = 3 To NB_ALLUMETTES
            listAllumettes.Item(i).choix.Items.AddRange(obj)
        Next

        ' Remets à jour les choix possible pour l'IA
        LB_Choix_IA.Items.Clear()
        For i As Integer = 1 To obj.Length
            LB_Choix_IA.Items.Add(i)
        Next
    End Sub

    Private Sub EnregistrerSousToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EnregistrerSousToolStripMenuItem.Click
        'Enregistrer partie
        SaveFileDialog1.Filter = ("Sauvegarde | *.xlm")

        If SaveFileDialog1.ShowDialog = 1 Then
            Dim path As String = SaveFileDialog1.FileName
            Dim config As New NIMConfig()

            ' Entregistrer l'image du chart dans le  stream    
            'Chart1.SaveImage(path, System.Drawing.Imaging.ImageFormat.Bmp)
            ' Créer un BitMap et le remplir avec le stream    
            'Dim bmp As New Bitmap(path)
            config.QuelNiveau = CB_Niveau.Text
            For i As Integer = 0 To NB_ALLUMETTES
                Dim allu As New NIMConfig.Allumette
                allu.PBVisible = listAllumettes.Item(i).image.Visible

                For Each val As String In listAllumettes.Item(i).choix.Items
                    allu.LBValues.Add(val)
                Next

                allu.LBIndex = listAllumettes.Item(i).choix.SelectedIndex
                allu.TBValue = listAllumettes.Item(i).encours.Text
                config.ListAllumettes.Add(allu)
            Next
            config.AllumetteRestante = Tb_allumette_restante.Text
            config.ScoreIA = L_Score_IA.Text
            config.Scorehumain = L_Score_Humain.Text
            config.Prise = Cb_Prise.Text

            config.QuiCommence = CB_Commence.Text
            config.DerniereAllumette = Cb_PerdGagne.Text
            config.CombienAllumette = CB_allumette.Text

            ' DeroulementPartie As List(Of String)
            For Each val As String In LB_Partie.Items
                config.DeroulementPartie.Add(val)
            Next

            ' CommentaireIA
            For Each val As String In LB_IA.Items
                config.CommentaireIA.Add(val)
            Next

            ' Score partie IA
            For Each val As String In LB_Score_IA.Items
                config.ScorePartieIA.Insert(0, val)
            Next

            ' Score partie Humain
            For Each val As String In LB_Score_Humain.Items
                config.ScorePartieHumain.Insert(0, val)
            Next
            For Each val As String In LB_dernier_choix_IA.Items
                config.Dernierchoix.Insert(0, val)
            Next
            'Dim path As String = My.Application.Info.DirectoryPath & "\mapartie.txt"

            ' Pour faire joli fichier
            Dim settings As New XmlWriterSettings()
            settings.Indent = True
            settings.IndentChars = (ControlChars.Tab)

            Dim serializer = New XmlSerializer(config.GetType())
            Using writer = XmlWriter.Create(path, settings)
                serializer.Serialize(writer, config)
            End Using


            ' Créer un memory stream    





        End If
        'Dim path As String = My.Application.Info.DirectoryPath & "\mapartie.txt"
    End Sub
    Private Sub Remplir()
        Chart1.Series(1).Points.Clear()
        Chart1.Series(0).Points.Clear()
        'Dim path As String = My.Application.Info.DirectoryPath & "\mapartie.txt"
        Dim path As String = OpenFileDialog1.FileName
        Dim config As New NIMConfig()

        Dim serializer As New XmlSerializer(config.GetType())
        Using reader = XmlReader.Create(path)
            config = CType(serializer.Deserialize(reader), NIMConfig)
        End Using
        CB_Niveau.Text = config.QuelNiveau
        For i As Integer = 0 To (config.ListAllumettes.Count - 1)
            listAllumettes.Item(i).image.Visible = config.ListAllumettes(i).PBVisible

            listAllumettes.Item(i).choix.Items.Clear()
            For Each val As String In config.ListAllumettes(i).LBValues
                listAllumettes.Item(i).choix.Items.Add(val)
            Next

            listAllumettes.Item(i).choix.SelectedIndex = config.ListAllumettes(i).LBIndex
            listAllumettes.Item(i).encours.Text = config.ListAllumettes(i).TBValue
        Next
        Tb_allumette_restante.Text = config.AllumetteRestante
        L_Score_IA.Text = config.ScoreIA
        L_Score_Humain.Text = config.Scorehumain
        Cb_Prise.Text = config.Prise

        CB_Commence.Text = config.QuiCommence
        Cb_PerdGagne.Text = config.DerniereAllumette
        CB_allumette.Text = config.CombienAllumette
        L_NombrePartie.Text = (CInt(L_Score_IA.Text) + CInt(L_Score_Humain.Text))
        ' DeroulementPartie As List(Of String)
        LB_Partie.Items.Clear()
        For Each val As String In config.DeroulementPartie
            LB_Partie.Items.Add(val)
        Next

        ' CommentaireIA
        LB_IA.Items.Clear()
        For Each val As String In config.CommentaireIA
            LB_IA.Items.Add(val)
        Next

        ' Score partie IA
        For Each val As String In config.ScorePartieIA
            LB_Score_IA.Items.Insert(0, val)
        Next

        ' Score partie Humain
        For Each val As String In config.ScorePartieHumain
            LB_Score_Humain.Items.Insert(0, val)
        Next
        For Each val As String In config.Dernierchoix
            LB_dernier_choix_IA.Items.Add(val)
        Next

    End Sub
    Private Sub Refresh()
        Dim path As String = OpenFileDialog1.FileName
        Dim config As New NIMConfig()

        Dim serializer As New XmlSerializer(config.GetType())
        Using reader = XmlReader.Create(path)
            config = CType(serializer.Deserialize(reader), NIMConfig)
        End Using
        L_Score_IA.Text = config.ScoreIA
        L_Score_Humain.Text = config.Scorehumain
        L_NombrePartie.Text = (CInt(L_Score_IA.Text) + CInt(L_Score_Humain.Text))


    End Sub
    Private Sub OuvrirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OuvrirToolStripMenuItem.Click
        'ouvrir
        RemiseAZero()

        OpenFileDialog1.Filter = ("Fichier de configuration | *.xlm")
        If OpenFileDialog1.ShowDialog = 1 Then
            Remplir()
            Refresh()
        End If
        AfficherAllumette()
        Graphique()

    End Sub

    Private Sub AProposToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AProposToolStripMenuItem.Click
        AboutBox1.ShowDialog()
    End Sub

    Private Sub QuitterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuitterToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub Chart1_Click(sender As Object, e As EventArgs) Handles Chart1.DoubleClick
        If Chart1.ChartAreas("ChartArea1").Area3DStyle.Enable3D = True Then
            Chart1.ChartAreas("ChartArea1").Area3DStyle.Enable3D = False
            Chart1.Series(1).ChartType = DataVisualization.Charting.SeriesChartType.Line
            Chart1.Series(0).ChartType = DataVisualization.Charting.SeriesChartType.Line
            Chart1.Series(1).Color = Color.Red
            Chart1.Series(0).Color = Color.Blue
        Else
            Chart1.ChartAreas("ChartArea1").Area3DStyle.Enable3D = True
            Chart1.Series(1).ChartType = DataVisualization.Charting.SeriesChartType.Line

            Chart1.Series(0).ChartType = DataVisualization.Charting.SeriesChartType.Line
            Chart1.Series(1).Color = Color.FromArgb(200, Color.Red)
            Chart1.Series(0).Color = Color.FromArgb(255, Color.Blue)

            ' 30% de perspective
            Chart1.ChartAreas("ChartArea1").Area3DStyle.Perspective = 30

            ' Rotation d'un Angle de 30
            Chart1.ChartAreas("ChartArea1").Area3DStyle.Rotation = 30

            'Inclinaison
            Chart1.ChartAreas("ChartArea1").Area3DStyle.Inclination = 45

            ' Mettre le  Point Depth à 100 (profondeur de la colonne)
            Chart1.ChartAreas("ChartArea1").Area3DStyle.PointDepth = 100

            ' Mettre le Point Gap Width à 0 (profondeur entre les series)
            Chart1.ChartAreas("ChartArea1").Area3DStyle.PointGapDepth = 0

            'Epaisseur du mur gris 
            Chart1.ChartAreas(0).Area3DStyle.WallWidth = 10

            'Projection isométrique si True (fausse 3D, pas de perspective
            'bien si profondeur, pas bien si utilisateur final peut faire pivoter)
            'Si false vrai 3D
            Chart1.ChartAreas(0).Area3DStyle.IsRightAngleAxes = True


        End If
    End Sub
    Private Sub EffaceScore()
        L_NombrePartie.Text = 0
        L_Score_Humain.Text = 0
        L_Score_IA.Text = 0

        LB_Score_IA.Items.Clear()
        LB_Score_Humain.Items.Clear()
        '    LB_Score_IA.Items.Add(0)
        '   LB_Score_Humain.Items.Add(0)
        Chart1.Series(1).Points.Clear()
        Chart1.Series(0).Points.Clear()
        Chart1.Series(0).Points.Add(0)
        Chart1.Series(1).Points.Add(0)

    End Sub


    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        finTempo = True
    End Sub


    Private Sub StatistiquesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StatistiquesToolStripMenuItem.Click
        statistique.Show()

    End Sub

End Class
