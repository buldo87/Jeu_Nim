<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class statistique
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
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Title1 As System.Windows.Forms.DataVisualization.Charting.Title = New System.Windows.Forms.DataVisualization.Charting.Title()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(statistique))
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.LB_Score_Humain = New System.Windows.Forms.ListBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CB_Niveau = New System.Windows.Forms.ComboBox()
        Me.L_Niveau = New System.Windows.Forms.Label()
        Me.CB_Commence = New System.Windows.Forms.ComboBox()
        Me.Cb_PerdGagne = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Cb_Prise = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.L_NombrePartie = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.L_Score_Humain = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CB_allumette = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.LB_Score_IA = New System.Windows.Forms.ListBox()
        Me.L_Score_IA = New System.Windows.Forms.Label()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.OpenFichier = New System.Windows.Forms.OpenFileDialog()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LFichier = New System.Windows.Forms.Label()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Chart1
        '
        Me.Chart1.BackColor = System.Drawing.Color.Transparent
        Me.Chart1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.DiagonalRight
        Me.Chart1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Chart1.BorderlineColor = System.Drawing.Color.Transparent
        Me.Chart1.BorderlineWidth = 0
        Me.Chart1.BorderSkin.BackColor = System.Drawing.Color.Transparent
        Me.Chart1.BorderSkin.BackImageTransparentColor = System.Drawing.Color.Transparent
        Me.Chart1.BorderSkin.BackSecondaryColor = System.Drawing.Color.Transparent
        Me.Chart1.BorderSkin.BorderColor = System.Drawing.Color.Transparent
        Me.Chart1.BorderSkin.PageColor = System.Drawing.Color.Transparent
        Me.Chart1.BorderSkin.SkinStyle = System.Windows.Forms.DataVisualization.Charting.BorderSkinStyle.Sunken
        ChartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.DarkGray
        ChartArea1.AxisX.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot
        ChartArea1.AxisX.TitleFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ChartArea1.AxisX2.Title = "Nombre de partie terminées"
        ChartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.DarkGray
        ChartArea1.AxisY.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot
        ChartArea1.AxisY.Title = "Parties Gagnées"
        ChartArea1.AxisY.TitleFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ChartArea1.BackImageTransparentColor = System.Drawing.Color.White
        ChartArea1.BackSecondaryColor = System.Drawing.Color.Transparent
        ChartArea1.BorderColor = System.Drawing.Color.Transparent
        ChartArea1.BorderWidth = 0
        ChartArea1.Name = "ChartArea1"
        ChartArea1.Position.Auto = False
        ChartArea1.Position.Height = 100.0!
        ChartArea1.Position.Width = 100.0!
        Me.Chart1.ChartAreas.Add(ChartArea1)
        Me.Chart1.DataSource = Me.LB_Score_Humain.CustomTabOffsets
        Me.Chart1.Location = New System.Drawing.Point(0, 24)
        Me.Chart1.Margin = New System.Windows.Forms.Padding(0)
        Me.Chart1.Name = "Chart1"
        Me.Chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None
        Series1.BackImageTransparentColor = System.Drawing.Color.Red
        Series1.ChartArea = "ChartArea1"
        Series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line
        Series1.Color = System.Drawing.Color.Blue
        Series1.IsVisibleInLegend = False
        Series1.LabelForeColor = System.Drawing.Color.Red
        Series1.Legend = "Legend1"
        Series1.LegendText = "Ordinateur"
        Series1.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Diamond
        Series1.Name = "Series1"
        Series2.ChartArea = "ChartArea1"
        Series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line
        Series2.Color = System.Drawing.Color.Red
        Series2.IsVisibleInLegend = False
        Series2.LabelForeColor = System.Drawing.Color.Red
        Series2.Legend = "Legend1"
        Series2.LegendText = "Humain"
        Series2.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Diamond
        Series2.Name = "Series2"
        Me.Chart1.Series.Add(Series1)
        Me.Chart1.Series.Add(Series2)
        Me.Chart1.Size = New System.Drawing.Size(903, 528)
        Me.Chart1.TabIndex = 124
        Title1.Alignment = System.Drawing.ContentAlignment.BottomRight
        Title1.DockedToChartArea = "ChartArea1"
        Title1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom
        Title1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Title1.Name = "Title1"
        Title1.Text = "Nombre de parties terminées"
        Me.Chart1.Titles.Add(Title1)
        '
        'LB_Score_Humain
        '
        Me.LB_Score_Humain.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LB_Score_Humain.FormattingEnabled = True
        Me.LB_Score_Humain.ItemHeight = 18
        Me.LB_Score_Humain.Location = New System.Drawing.Point(1083, 230)
        Me.LB_Score_Humain.Name = "LB_Score_Humain"
        Me.LB_Score_Humain.Size = New System.Drawing.Size(57, 310)
        Me.LB_Score_Humain.TabIndex = 123
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(950, 168)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(139, 20)
        Me.Label2.TabIndex = 118
        Me.Label2.Text = "Dernière allumette"
        '
        'CB_Niveau
        '
        Me.CB_Niveau.Enabled = False
        Me.CB_Niveau.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CB_Niveau.FormattingEnabled = True
        Me.CB_Niveau.Items.AddRange(New Object() {"1", "2", "3", "4"})
        Me.CB_Niveau.Location = New System.Drawing.Point(1098, 95)
        Me.CB_Niveau.Name = "CB_Niveau"
        Me.CB_Niveau.Size = New System.Drawing.Size(86, 28)
        Me.CB_Niveau.TabIndex = 117
        Me.CB_Niveau.Text = "1"
        '
        'L_Niveau
        '
        Me.L_Niveau.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.L_Niveau.AutoSize = True
        Me.L_Niveau.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.L_Niveau.Location = New System.Drawing.Point(1032, 98)
        Me.L_Niveau.Name = "L_Niveau"
        Me.L_Niveau.Size = New System.Drawing.Size(57, 20)
        Me.L_Niveau.TabIndex = 116
        Me.L_Niveau.Text = "Niveau"
        '
        'CB_Commence
        '
        Me.CB_Commence.Enabled = False
        Me.CB_Commence.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CB_Commence.FormattingEnabled = True
        Me.CB_Commence.Items.AddRange(New Object() {"Humain", "Ordinateur", "Aléatoire", "Chacun son tour"})
        Me.CB_Commence.Location = New System.Drawing.Point(1039, 27)
        Me.CB_Commence.Name = "CB_Commence"
        Me.CB_Commence.Size = New System.Drawing.Size(145, 28)
        Me.CB_Commence.TabIndex = 114
        Me.CB_Commence.Text = "Chacun son tour"
        '
        'Cb_PerdGagne
        '
        Me.Cb_PerdGagne.Enabled = False
        Me.Cb_PerdGagne.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cb_PerdGagne.FormattingEnabled = True
        Me.Cb_PerdGagne.Items.AddRange(New Object() {"gagne", "perd"})
        Me.Cb_PerdGagne.Location = New System.Drawing.Point(1098, 160)
        Me.Cb_PerdGagne.Name = "Cb_PerdGagne"
        Me.Cb_PerdGagne.Size = New System.Drawing.Size(86, 28)
        Me.Cb_PerdGagne.TabIndex = 119
        Me.Cb_PerdGagne.Text = "perd"
        '
        'Label10
        '
        Me.Label10.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(918, 35)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(115, 20)
        Me.Label10.TabIndex = 112
        Me.Label10.Text = "Qui commence"
        '
        'Cb_Prise
        '
        Me.Cb_Prise.Enabled = False
        Me.Cb_Prise.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cb_Prise.FormattingEnabled = True
        Me.Cb_Prise.Items.AddRange(New Object() {"3", "4"})
        Me.Cb_Prise.Location = New System.Drawing.Point(1098, 61)
        Me.Cb_Prise.Name = "Cb_Prise"
        Me.Cb_Prise.Size = New System.Drawing.Size(86, 28)
        Me.Cb_Prise.TabIndex = 111
        Me.Cb_Prise.Text = "3"
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(977, 69)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(115, 20)
        Me.Label3.TabIndex = 108
        Me.Label3.Text = "Prise maximum"
        '
        'L_NombrePartie
        '
        Me.L_NombrePartie.AutoSize = True
        Me.L_NombrePartie.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.L_NombrePartie.Location = New System.Drawing.Point(464, -4)
        Me.L_NombrePartie.Name = "L_NombrePartie"
        Me.L_NombrePartie.Size = New System.Drawing.Size(25, 30)
        Me.L_NombrePartie.TabIndex = 125
        Me.L_NombrePartie.Text = "0"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Blue
        Me.Label8.Location = New System.Drawing.Point(918, 201)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(93, 21)
        Me.Label8.TabIndex = 121
        Me.Label8.Text = "Ordinateur"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Red
        Me.Label7.Location = New System.Drawing.Point(1079, 201)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(71, 21)
        Me.Label7.TabIndex = 120
        Me.Label7.Text = "Humain"
        '
        'L_Score_Humain
        '
        Me.L_Score_Humain.AutoSize = True
        Me.L_Score_Humain.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.L_Score_Humain.ForeColor = System.Drawing.Color.Red
        Me.L_Score_Humain.Location = New System.Drawing.Point(1147, 194)
        Me.L_Score_Humain.Name = "L_Score_Humain"
        Me.L_Score_Humain.Size = New System.Drawing.Size(25, 30)
        Me.L_Score_Humain.TabIndex = 113
        Me.L_Score_Humain.Text = "0"
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(233, 4)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(213, 20)
        Me.Label4.TabIndex = 107
        Me.Label4.Text = "Nombre de parties terminées"
        '
        'CB_allumette
        '
        Me.CB_allumette.Enabled = False
        Me.CB_allumette.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CB_allumette.FormattingEnabled = True
        Me.CB_allumette.Items.AddRange(New Object() {"9", "10", "11", "12"})
        Me.CB_allumette.Location = New System.Drawing.Point(1098, 126)
        Me.CB_allumette.Name = "CB_allumette"
        Me.CB_allumette.Size = New System.Drawing.Size(86, 28)
        Me.CB_allumette.TabIndex = 110
        Me.CB_allumette.Text = "12"
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(930, 129)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(162, 20)
        Me.Label6.TabIndex = 109
        Me.Label6.Text = "Nombres d'allumettes"
        '
        'LB_Score_IA
        '
        Me.LB_Score_IA.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LB_Score_IA.FormattingEnabled = True
        Me.LB_Score_IA.ItemHeight = 18
        Me.LB_Score_IA.Location = New System.Drawing.Point(934, 230)
        Me.LB_Score_IA.Name = "LB_Score_IA"
        Me.LB_Score_IA.Size = New System.Drawing.Size(55, 310)
        Me.LB_Score_IA.TabIndex = 122
        '
        'L_Score_IA
        '
        Me.L_Score_IA.AutoSize = True
        Me.L_Score_IA.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.L_Score_IA.ForeColor = System.Drawing.Color.Blue
        Me.L_Score_IA.Location = New System.Drawing.Point(1008, 194)
        Me.L_Score_IA.Name = "L_Score_IA"
        Me.L_Score_IA.Size = New System.Drawing.Size(25, 30)
        Me.L_Score_IA.TabIndex = 115
        Me.L_Score_IA.Text = "0"
        '
        'OpenFichier
        '
        Me.OpenFichier.FileName = "OpenFileDialog1"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1184, 24)
        Me.MenuStrip1.TabIndex = 126
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(977, 4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(119, 20)
        Me.Label1.TabIndex = 127
        Me.Label1.Text = "Règles du jeu"
        '
        'LFichier
        '
        Me.LFichier.AutoSize = True
        Me.LFichier.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LFichier.Location = New System.Drawing.Point(211, 2)
        Me.LFichier.Name = "LFichier"
        Me.LFichier.Size = New System.Drawing.Size(16, 16)
        Me.LFichier.TabIndex = 129
        Me.LFichier.Text = "..."
        '
        'statistique
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Jeu_Nim.My.Resources.Resources.marbre
        Me.ClientSize = New System.Drawing.Size(1184, 561)
        Me.Controls.Add(Me.LFichier)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Chart1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.CB_Niveau)
        Me.Controls.Add(Me.L_Niveau)
        Me.Controls.Add(Me.CB_Commence)
        Me.Controls.Add(Me.Cb_PerdGagne)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Cb_Prise)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.L_NombrePartie)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.L_Score_Humain)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.CB_allumette)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.LB_Score_Humain)
        Me.Controls.Add(Me.LB_Score_IA)
        Me.Controls.Add(Me.L_Score_IA)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "statistique"
        Me.Text = "Statistiques"
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Chart1 As DataVisualization.Charting.Chart
    Friend WithEvents Label2 As Label
    Friend WithEvents CB_Niveau As ComboBox
    Friend WithEvents L_Niveau As Label
    Friend WithEvents CB_Commence As ComboBox
    Friend WithEvents Cb_PerdGagne As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Cb_Prise As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents L_NombrePartie As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents L_Score_Humain As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents CB_allumette As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents LB_Score_Humain As ListBox
    Friend WithEvents LB_Score_IA As ListBox
    Friend WithEvents L_Score_IA As Label
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
    Friend WithEvents OpenFichier As OpenFileDialog
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents Label1 As Label
    Friend WithEvents LFichier As Label
End Class
