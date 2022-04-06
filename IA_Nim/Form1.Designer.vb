<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Tb_allumette_restante = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.L_dialog = New System.Windows.Forms.Label()
        Me.L_Score_Humain = New System.Windows.Forms.Label()
        Me.L_Score_IA = New System.Windows.Forms.Label()
        Me.LB_Partie = New System.Windows.Forms.ListBox()
        Me.L_Dernier_choix = New System.Windows.Forms.Label()
        Me.LB_IA = New System.Windows.Forms.ListBox()
        Me.LB_Choix_IA = New System.Windows.Forms.ListBox()
        Me.GB_Choix_en_cours = New System.Windows.Forms.GroupBox()
        Me.TB_En_cours_12 = New System.Windows.Forms.TextBox()
        Me.TB_En_cours_11 = New System.Windows.Forms.TextBox()
        Me.TB_En_cours_10 = New System.Windows.Forms.TextBox()
        Me.TB_En_cours_9 = New System.Windows.Forms.TextBox()
        Me.TB_En_cours_8 = New System.Windows.Forms.TextBox()
        Me.TB_En_cours_7 = New System.Windows.Forms.TextBox()
        Me.TB_En_cours_6 = New System.Windows.Forms.TextBox()
        Me.TB_En_cours_5 = New System.Windows.Forms.TextBox()
        Me.TB_En_cours_4 = New System.Windows.Forms.TextBox()
        Me.TB_En_cours_3 = New System.Windows.Forms.TextBox()
        Me.TB_En_cours_2 = New System.Windows.Forms.TextBox()
        Me.TB_En_cours_1 = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.LB_choix_possible_7 = New System.Windows.Forms.ListBox()
        Me.LB_choix_possible_12 = New System.Windows.Forms.ListBox()
        Me.LB_choix_possible_11 = New System.Windows.Forms.ListBox()
        Me.LB_choix_possible_10 = New System.Windows.Forms.ListBox()
        Me.LB_choix_possible_9 = New System.Windows.Forms.ListBox()
        Me.LB_choix_possible_8 = New System.Windows.Forms.ListBox()
        Me.LB_choix_possible_6 = New System.Windows.Forms.ListBox()
        Me.LB_choix_possible_5 = New System.Windows.Forms.ListBox()
        Me.LB_choix_possible_4 = New System.Windows.Forms.ListBox()
        Me.LB_choix_possible_3 = New System.Windows.Forms.ListBox()
        Me.LB_choix_possible_2 = New System.Windows.Forms.ListBox()
        Me.LB_choix_possible_1 = New System.Windows.Forms.ListBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.PB_Allumette_12 = New System.Windows.Forms.PictureBox()
        Me.PB_Allumette_11 = New System.Windows.Forms.PictureBox()
        Me.PB_Allumette_10 = New System.Windows.Forms.PictureBox()
        Me.PB_Allumette_9 = New System.Windows.Forms.PictureBox()
        Me.PB_Allumette_8 = New System.Windows.Forms.PictureBox()
        Me.PB_Allumette_7 = New System.Windows.Forms.PictureBox()
        Me.PB_Allumette_6 = New System.Windows.Forms.PictureBox()
        Me.PB_Allumette_5 = New System.Windows.Forms.PictureBox()
        Me.PB_Allumette_4 = New System.Windows.Forms.PictureBox()
        Me.PB_Allumette_3 = New System.Windows.Forms.PictureBox()
        Me.PB_Allumette_2 = New System.Windows.Forms.PictureBox()
        Me.PB_Allumette_1 = New System.Windows.Forms.PictureBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.LB_dernier_choix_IA = New System.Windows.Forms.ListBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.CB_allumette = New System.Windows.Forms.ComboBox()
        Me.Cb_Prise = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.CB_Commence = New System.Windows.Forms.ComboBox()
        Me.GB_Setup = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CB_Niveau = New System.Windows.Forms.ComboBox()
        Me.L_Niveau = New System.Windows.Forms.Label()
        Me.Cb_PerdGagne = New System.Windows.Forms.ComboBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FichierToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OuvrirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EnregistrerSousToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QuitterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AProposToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.B_Rejouer = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.PBIA = New System.Windows.Forms.PictureBox()
        Me.LB_Score_IA = New System.Windows.Forms.ListBox()
        Me.LB_Score_Humain = New System.Windows.Forms.ListBox()
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.L_NombrePartie = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.GB_Choix_en_cours.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PB_Allumette_12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PB_Allumette_11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PB_Allumette_10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PB_Allumette_9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PB_Allumette_8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PB_Allumette_7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PB_Allumette_6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PB_Allumette_5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PB_Allumette_4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PB_Allumette_3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PB_Allumette_2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PB_Allumette_1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GB_Setup.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PBIA, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(10, 504)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(159, 41)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Prendre 1 allumette"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(178, 505)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(169, 41)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Prendre 2 allumettes"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(355, 504)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(170, 41)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "Prendre 3 allumettes"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Tb_allumette_restante
        '
        Me.Tb_allumette_restante.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tb_allumette_restante.Location = New System.Drawing.Point(624, 79)
        Me.Tb_allumette_restante.Name = "Tb_allumette_restante"
        Me.Tb_allumette_restante.Size = New System.Drawing.Size(56, 50)
        Me.Tb_allumette_restante.TabIndex = 42
        Me.Tb_allumette_restante.Text = "12"
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(934, 4)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(205, 20)
        Me.Label4.TabIndex = 46
        Me.Label4.Text = "Nombre de partie terminées"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(422, 116)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(101, 13)
        Me.Label11.TabIndex = 77
        Me.Label11.Text = "Mes choix possibles"
        '
        'L_dialog
        '
        Me.L_dialog.AutoSize = True
        Me.L_dialog.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.L_dialog.Location = New System.Drawing.Point(137, 354)
        Me.L_dialog.Name = "L_dialog"
        Me.L_dialog.Size = New System.Drawing.Size(19, 15)
        Me.L_dialog.TabIndex = 82
        Me.L_dialog.Text = "...."
        '
        'L_Score_Humain
        '
        Me.L_Score_Humain.AutoSize = True
        Me.L_Score_Humain.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.L_Score_Humain.ForeColor = System.Drawing.Color.Red
        Me.L_Score_Humain.Location = New System.Drawing.Point(771, 0)
        Me.L_Score_Humain.Name = "L_Score_Humain"
        Me.L_Score_Humain.Size = New System.Drawing.Size(25, 30)
        Me.L_Score_Humain.TabIndex = 85
        Me.L_Score_Humain.Text = "0"
        '
        'L_Score_IA
        '
        Me.L_Score_IA.AutoSize = True
        Me.L_Score_IA.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.L_Score_IA.ForeColor = System.Drawing.Color.Blue
        Me.L_Score_IA.Location = New System.Drawing.Point(711, 0)
        Me.L_Score_IA.Name = "L_Score_IA"
        Me.L_Score_IA.Size = New System.Drawing.Size(25, 30)
        Me.L_Score_IA.TabIndex = 86
        Me.L_Score_IA.Text = "0"
        '
        'LB_Partie
        '
        Me.LB_Partie.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LB_Partie.FormattingEnabled = True
        Me.LB_Partie.ItemHeight = 18
        Me.LB_Partie.Location = New System.Drawing.Point(823, 31)
        Me.LB_Partie.Name = "LB_Partie"
        Me.LB_Partie.Size = New System.Drawing.Size(352, 238)
        Me.LB_Partie.TabIndex = 39
        '
        'L_Dernier_choix
        '
        Me.L_Dernier_choix.AutoSize = True
        Me.L_Dernier_choix.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.L_Dernier_choix.Location = New System.Drawing.Point(112, 41)
        Me.L_Dernier_choix.Name = "L_Dernier_choix"
        Me.L_Dernier_choix.Size = New System.Drawing.Size(25, 21)
        Me.L_Dernier_choix.TabIndex = 89
        Me.L_Dernier_choix.Text = "....."
        '
        'LB_IA
        '
        Me.LB_IA.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LB_IA.FormattingEnabled = True
        Me.LB_IA.ItemHeight = 17
        Me.LB_IA.Location = New System.Drawing.Point(12, 318)
        Me.LB_IA.Name = "LB_IA"
        Me.LB_IA.Size = New System.Drawing.Size(594, 157)
        Me.LB_IA.TabIndex = 90
        '
        'LB_Choix_IA
        '
        Me.LB_Choix_IA.Font = New System.Drawing.Font("Snap ITC", 21.75!)
        Me.LB_Choix_IA.FormattingEnabled = True
        Me.LB_Choix_IA.ItemHeight = 37
        Me.LB_Choix_IA.Location = New System.Drawing.Point(59, 157)
        Me.LB_Choix_IA.Name = "LB_Choix_IA"
        Me.LB_Choix_IA.Size = New System.Drawing.Size(56, 152)
        Me.LB_Choix_IA.TabIndex = 91
        '
        'GB_Choix_en_cours
        '
        Me.GB_Choix_en_cours.Controls.Add(Me.TB_En_cours_12)
        Me.GB_Choix_en_cours.Controls.Add(Me.TB_En_cours_11)
        Me.GB_Choix_en_cours.Controls.Add(Me.TB_En_cours_10)
        Me.GB_Choix_en_cours.Controls.Add(Me.TB_En_cours_9)
        Me.GB_Choix_en_cours.Controls.Add(Me.TB_En_cours_8)
        Me.GB_Choix_en_cours.Controls.Add(Me.TB_En_cours_7)
        Me.GB_Choix_en_cours.Controls.Add(Me.TB_En_cours_6)
        Me.GB_Choix_en_cours.Controls.Add(Me.TB_En_cours_5)
        Me.GB_Choix_en_cours.Controls.Add(Me.TB_En_cours_4)
        Me.GB_Choix_en_cours.Controls.Add(Me.TB_En_cours_3)
        Me.GB_Choix_en_cours.Controls.Add(Me.TB_En_cours_2)
        Me.GB_Choix_en_cours.Controls.Add(Me.TB_En_cours_1)
        Me.GB_Choix_en_cours.Location = New System.Drawing.Point(166, 275)
        Me.GB_Choix_en_cours.Name = "GB_Choix_en_cours"
        Me.GB_Choix_en_cours.Size = New System.Drawing.Size(450, 39)
        Me.GB_Choix_en_cours.TabIndex = 92
        Me.GB_Choix_en_cours.TabStop = False
        '
        'TB_En_cours_12
        '
        Me.TB_En_cours_12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_En_cours_12.Location = New System.Drawing.Point(409, 7)
        Me.TB_En_cours_12.Name = "TB_En_cours_12"
        Me.TB_En_cours_12.Size = New System.Drawing.Size(31, 26)
        Me.TB_En_cours_12.TabIndex = 83
        '
        'TB_En_cours_11
        '
        Me.TB_En_cours_11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_En_cours_11.Location = New System.Drawing.Point(372, 7)
        Me.TB_En_cours_11.Name = "TB_En_cours_11"
        Me.TB_En_cours_11.Size = New System.Drawing.Size(31, 26)
        Me.TB_En_cours_11.TabIndex = 82
        '
        'TB_En_cours_10
        '
        Me.TB_En_cours_10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_En_cours_10.Location = New System.Drawing.Point(335, 7)
        Me.TB_En_cours_10.Name = "TB_En_cours_10"
        Me.TB_En_cours_10.Size = New System.Drawing.Size(31, 26)
        Me.TB_En_cours_10.TabIndex = 81
        '
        'TB_En_cours_9
        '
        Me.TB_En_cours_9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_En_cours_9.Location = New System.Drawing.Point(298, 7)
        Me.TB_En_cours_9.Name = "TB_En_cours_9"
        Me.TB_En_cours_9.Size = New System.Drawing.Size(31, 26)
        Me.TB_En_cours_9.TabIndex = 80
        '
        'TB_En_cours_8
        '
        Me.TB_En_cours_8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_En_cours_8.Location = New System.Drawing.Point(261, 7)
        Me.TB_En_cours_8.Name = "TB_En_cours_8"
        Me.TB_En_cours_8.Size = New System.Drawing.Size(31, 26)
        Me.TB_En_cours_8.TabIndex = 79
        '
        'TB_En_cours_7
        '
        Me.TB_En_cours_7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_En_cours_7.Location = New System.Drawing.Point(224, 7)
        Me.TB_En_cours_7.Name = "TB_En_cours_7"
        Me.TB_En_cours_7.Size = New System.Drawing.Size(31, 26)
        Me.TB_En_cours_7.TabIndex = 78
        '
        'TB_En_cours_6
        '
        Me.TB_En_cours_6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_En_cours_6.Location = New System.Drawing.Point(187, 7)
        Me.TB_En_cours_6.Name = "TB_En_cours_6"
        Me.TB_En_cours_6.Size = New System.Drawing.Size(31, 26)
        Me.TB_En_cours_6.TabIndex = 77
        '
        'TB_En_cours_5
        '
        Me.TB_En_cours_5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_En_cours_5.Location = New System.Drawing.Point(148, 7)
        Me.TB_En_cours_5.Name = "TB_En_cours_5"
        Me.TB_En_cours_5.Size = New System.Drawing.Size(31, 26)
        Me.TB_En_cours_5.TabIndex = 76
        '
        'TB_En_cours_4
        '
        Me.TB_En_cours_4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_En_cours_4.Location = New System.Drawing.Point(113, 7)
        Me.TB_En_cours_4.Name = "TB_En_cours_4"
        Me.TB_En_cours_4.Size = New System.Drawing.Size(31, 26)
        Me.TB_En_cours_4.TabIndex = 75
        '
        'TB_En_cours_3
        '
        Me.TB_En_cours_3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_En_cours_3.Location = New System.Drawing.Point(76, 7)
        Me.TB_En_cours_3.Name = "TB_En_cours_3"
        Me.TB_En_cours_3.Size = New System.Drawing.Size(31, 26)
        Me.TB_En_cours_3.TabIndex = 74
        '
        'TB_En_cours_2
        '
        Me.TB_En_cours_2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_En_cours_2.Location = New System.Drawing.Point(39, 7)
        Me.TB_En_cours_2.Name = "TB_En_cours_2"
        Me.TB_En_cours_2.Size = New System.Drawing.Size(31, 26)
        Me.TB_En_cours_2.TabIndex = 73
        '
        'TB_En_cours_1
        '
        Me.TB_En_cours_1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_En_cours_1.Location = New System.Drawing.Point(2, 7)
        Me.TB_En_cours_1.Name = "TB_En_cours_1"
        Me.TB_En_cours_1.Size = New System.Drawing.Size(31, 26)
        Me.TB_En_cours_1.TabIndex = 72
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.LB_choix_possible_7)
        Me.GroupBox1.Controls.Add(Me.LB_choix_possible_12)
        Me.GroupBox1.Controls.Add(Me.LB_choix_possible_11)
        Me.GroupBox1.Controls.Add(Me.LB_choix_possible_10)
        Me.GroupBox1.Controls.Add(Me.LB_choix_possible_9)
        Me.GroupBox1.Controls.Add(Me.LB_choix_possible_8)
        Me.GroupBox1.Controls.Add(Me.LB_choix_possible_6)
        Me.GroupBox1.Controls.Add(Me.LB_choix_possible_5)
        Me.GroupBox1.Controls.Add(Me.LB_choix_possible_4)
        Me.GroupBox1.Controls.Add(Me.LB_choix_possible_3)
        Me.GroupBox1.Controls.Add(Me.LB_choix_possible_2)
        Me.GroupBox1.Controls.Add(Me.LB_choix_possible_1)
        Me.GroupBox1.Location = New System.Drawing.Point(162, 157)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(454, 120)
        Me.GroupBox1.TabIndex = 93
        Me.GroupBox1.TabStop = False
        '
        'LB_choix_possible_7
        '
        Me.LB_choix_possible_7.Font = New System.Drawing.Font("Segoe UI", 14.25!)
        Me.LB_choix_possible_7.FormattingEnabled = True
        Me.LB_choix_possible_7.ItemHeight = 25
        Me.LB_choix_possible_7.Location = New System.Drawing.Point(227, 8)
        Me.LB_choix_possible_7.Name = "LB_choix_possible_7"
        Me.LB_choix_possible_7.Size = New System.Drawing.Size(31, 104)
        Me.LB_choix_possible_7.TabIndex = 33
        '
        'LB_choix_possible_12
        '
        Me.LB_choix_possible_12.Font = New System.Drawing.Font("Segoe UI", 14.25!)
        Me.LB_choix_possible_12.FormattingEnabled = True
        Me.LB_choix_possible_12.ItemHeight = 25
        Me.LB_choix_possible_12.Location = New System.Drawing.Point(412, 8)
        Me.LB_choix_possible_12.Name = "LB_choix_possible_12"
        Me.LB_choix_possible_12.Size = New System.Drawing.Size(31, 104)
        Me.LB_choix_possible_12.TabIndex = 38
        '
        'LB_choix_possible_11
        '
        Me.LB_choix_possible_11.Font = New System.Drawing.Font("Segoe UI", 14.25!)
        Me.LB_choix_possible_11.FormattingEnabled = True
        Me.LB_choix_possible_11.ItemHeight = 25
        Me.LB_choix_possible_11.Location = New System.Drawing.Point(375, 8)
        Me.LB_choix_possible_11.Name = "LB_choix_possible_11"
        Me.LB_choix_possible_11.Size = New System.Drawing.Size(31, 104)
        Me.LB_choix_possible_11.TabIndex = 37
        '
        'LB_choix_possible_10
        '
        Me.LB_choix_possible_10.Font = New System.Drawing.Font("Segoe UI", 14.25!)
        Me.LB_choix_possible_10.FormattingEnabled = True
        Me.LB_choix_possible_10.ItemHeight = 25
        Me.LB_choix_possible_10.Location = New System.Drawing.Point(338, 8)
        Me.LB_choix_possible_10.Name = "LB_choix_possible_10"
        Me.LB_choix_possible_10.Size = New System.Drawing.Size(31, 104)
        Me.LB_choix_possible_10.TabIndex = 36
        '
        'LB_choix_possible_9
        '
        Me.LB_choix_possible_9.Font = New System.Drawing.Font("Segoe UI", 14.25!)
        Me.LB_choix_possible_9.FormattingEnabled = True
        Me.LB_choix_possible_9.ItemHeight = 25
        Me.LB_choix_possible_9.Location = New System.Drawing.Point(301, 8)
        Me.LB_choix_possible_9.Name = "LB_choix_possible_9"
        Me.LB_choix_possible_9.Size = New System.Drawing.Size(31, 104)
        Me.LB_choix_possible_9.TabIndex = 35
        '
        'LB_choix_possible_8
        '
        Me.LB_choix_possible_8.Font = New System.Drawing.Font("Segoe UI", 14.25!)
        Me.LB_choix_possible_8.FormattingEnabled = True
        Me.LB_choix_possible_8.ItemHeight = 25
        Me.LB_choix_possible_8.Location = New System.Drawing.Point(264, 8)
        Me.LB_choix_possible_8.Name = "LB_choix_possible_8"
        Me.LB_choix_possible_8.Size = New System.Drawing.Size(31, 104)
        Me.LB_choix_possible_8.TabIndex = 34
        '
        'LB_choix_possible_6
        '
        Me.LB_choix_possible_6.Font = New System.Drawing.Font("Segoe UI", 14.25!)
        Me.LB_choix_possible_6.FormattingEnabled = True
        Me.LB_choix_possible_6.ItemHeight = 25
        Me.LB_choix_possible_6.Location = New System.Drawing.Point(190, 8)
        Me.LB_choix_possible_6.Name = "LB_choix_possible_6"
        Me.LB_choix_possible_6.Size = New System.Drawing.Size(31, 104)
        Me.LB_choix_possible_6.TabIndex = 32
        '
        'LB_choix_possible_5
        '
        Me.LB_choix_possible_5.Font = New System.Drawing.Font("Segoe UI", 14.25!)
        Me.LB_choix_possible_5.FormattingEnabled = True
        Me.LB_choix_possible_5.ItemHeight = 25
        Me.LB_choix_possible_5.Location = New System.Drawing.Point(151, 8)
        Me.LB_choix_possible_5.Name = "LB_choix_possible_5"
        Me.LB_choix_possible_5.Size = New System.Drawing.Size(31, 104)
        Me.LB_choix_possible_5.TabIndex = 31
        '
        'LB_choix_possible_4
        '
        Me.LB_choix_possible_4.Font = New System.Drawing.Font("Segoe UI", 14.25!)
        Me.LB_choix_possible_4.FormattingEnabled = True
        Me.LB_choix_possible_4.ItemHeight = 25
        Me.LB_choix_possible_4.Location = New System.Drawing.Point(116, 8)
        Me.LB_choix_possible_4.Name = "LB_choix_possible_4"
        Me.LB_choix_possible_4.Size = New System.Drawing.Size(31, 104)
        Me.LB_choix_possible_4.TabIndex = 30
        '
        'LB_choix_possible_3
        '
        Me.LB_choix_possible_3.Font = New System.Drawing.Font("Segoe UI", 14.25!)
        Me.LB_choix_possible_3.FormattingEnabled = True
        Me.LB_choix_possible_3.ItemHeight = 25
        Me.LB_choix_possible_3.Location = New System.Drawing.Point(79, 8)
        Me.LB_choix_possible_3.Name = "LB_choix_possible_3"
        Me.LB_choix_possible_3.Size = New System.Drawing.Size(31, 104)
        Me.LB_choix_possible_3.TabIndex = 29
        '
        'LB_choix_possible_2
        '
        Me.LB_choix_possible_2.Font = New System.Drawing.Font("Segoe UI", 14.25!)
        Me.LB_choix_possible_2.FormattingEnabled = True
        Me.LB_choix_possible_2.ItemHeight = 25
        Me.LB_choix_possible_2.Location = New System.Drawing.Point(42, 8)
        Me.LB_choix_possible_2.Name = "LB_choix_possible_2"
        Me.LB_choix_possible_2.Size = New System.Drawing.Size(31, 104)
        Me.LB_choix_possible_2.TabIndex = 28
        '
        'LB_choix_possible_1
        '
        Me.LB_choix_possible_1.DisplayMember = "1"
        Me.LB_choix_possible_1.Font = New System.Drawing.Font("Segoe UI", 14.25!)
        Me.LB_choix_possible_1.FormattingEnabled = True
        Me.LB_choix_possible_1.ItemHeight = 25
        Me.LB_choix_possible_1.Location = New System.Drawing.Point(5, 8)
        Me.LB_choix_possible_1.Name = "LB_choix_possible_1"
        Me.LB_choix_possible_1.Size = New System.Drawing.Size(31, 104)
        Me.LB_choix_possible_1.TabIndex = 27
        Me.LB_choix_possible_1.Tag = ""
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.GroupBox2.Controls.Add(Me.PB_Allumette_12)
        Me.GroupBox2.Controls.Add(Me.PB_Allumette_11)
        Me.GroupBox2.Controls.Add(Me.PB_Allumette_10)
        Me.GroupBox2.Controls.Add(Me.PB_Allumette_9)
        Me.GroupBox2.Controls.Add(Me.PB_Allumette_8)
        Me.GroupBox2.Controls.Add(Me.PB_Allumette_7)
        Me.GroupBox2.Controls.Add(Me.PB_Allumette_6)
        Me.GroupBox2.Controls.Add(Me.PB_Allumette_5)
        Me.GroupBox2.Controls.Add(Me.PB_Allumette_4)
        Me.GroupBox2.Controls.Add(Me.PB_Allumette_3)
        Me.GroupBox2.Controls.Add(Me.PB_Allumette_2)
        Me.GroupBox2.Controls.Add(Me.PB_Allumette_1)
        Me.GroupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox2.ForeColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Location = New System.Drawing.Point(162, 27)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(454, 136)
        Me.GroupBox2.TabIndex = 94
        Me.GroupBox2.TabStop = False
        '
        'PB_Allumette_12
        '
        Me.PB_Allumette_12.Image = Global.Jeu_Nim.My.Resources.Resources.choisie
        Me.PB_Allumette_12.Location = New System.Drawing.Point(413, 7)
        Me.PB_Allumette_12.Name = "PB_Allumette_12"
        Me.PB_Allumette_12.Size = New System.Drawing.Size(31, 125)
        Me.PB_Allumette_12.TabIndex = 26
        Me.PB_Allumette_12.TabStop = False
        '
        'PB_Allumette_11
        '
        Me.PB_Allumette_11.Image = Global.Jeu_Nim.My.Resources.Resources.choisie
        Me.PB_Allumette_11.Location = New System.Drawing.Point(376, 7)
        Me.PB_Allumette_11.Name = "PB_Allumette_11"
        Me.PB_Allumette_11.Size = New System.Drawing.Size(31, 125)
        Me.PB_Allumette_11.TabIndex = 25
        Me.PB_Allumette_11.TabStop = False
        '
        'PB_Allumette_10
        '
        Me.PB_Allumette_10.Image = Global.Jeu_Nim.My.Resources.Resources.choisie
        Me.PB_Allumette_10.Location = New System.Drawing.Point(339, 7)
        Me.PB_Allumette_10.Name = "PB_Allumette_10"
        Me.PB_Allumette_10.Size = New System.Drawing.Size(31, 125)
        Me.PB_Allumette_10.TabIndex = 24
        Me.PB_Allumette_10.TabStop = False
        '
        'PB_Allumette_9
        '
        Me.PB_Allumette_9.Image = Global.Jeu_Nim.My.Resources.Resources.choisie
        Me.PB_Allumette_9.Location = New System.Drawing.Point(302, 7)
        Me.PB_Allumette_9.Name = "PB_Allumette_9"
        Me.PB_Allumette_9.Size = New System.Drawing.Size(31, 125)
        Me.PB_Allumette_9.TabIndex = 23
        Me.PB_Allumette_9.TabStop = False
        '
        'PB_Allumette_8
        '
        Me.PB_Allumette_8.Image = Global.Jeu_Nim.My.Resources.Resources.choisie
        Me.PB_Allumette_8.Location = New System.Drawing.Point(265, 7)
        Me.PB_Allumette_8.Name = "PB_Allumette_8"
        Me.PB_Allumette_8.Size = New System.Drawing.Size(31, 125)
        Me.PB_Allumette_8.TabIndex = 22
        Me.PB_Allumette_8.TabStop = False
        '
        'PB_Allumette_7
        '
        Me.PB_Allumette_7.Image = Global.Jeu_Nim.My.Resources.Resources.choisie
        Me.PB_Allumette_7.Location = New System.Drawing.Point(228, 7)
        Me.PB_Allumette_7.Name = "PB_Allumette_7"
        Me.PB_Allumette_7.Size = New System.Drawing.Size(31, 125)
        Me.PB_Allumette_7.TabIndex = 21
        Me.PB_Allumette_7.TabStop = False
        '
        'PB_Allumette_6
        '
        Me.PB_Allumette_6.Image = Global.Jeu_Nim.My.Resources.Resources.choisie
        Me.PB_Allumette_6.Location = New System.Drawing.Point(191, 8)
        Me.PB_Allumette_6.Name = "PB_Allumette_6"
        Me.PB_Allumette_6.Size = New System.Drawing.Size(31, 125)
        Me.PB_Allumette_6.TabIndex = 20
        Me.PB_Allumette_6.TabStop = False
        '
        'PB_Allumette_5
        '
        Me.PB_Allumette_5.Image = Global.Jeu_Nim.My.Resources.Resources.choisie
        Me.PB_Allumette_5.Location = New System.Drawing.Point(154, 8)
        Me.PB_Allumette_5.Name = "PB_Allumette_5"
        Me.PB_Allumette_5.Size = New System.Drawing.Size(31, 125)
        Me.PB_Allumette_5.TabIndex = 19
        Me.PB_Allumette_5.TabStop = False
        '
        'PB_Allumette_4
        '
        Me.PB_Allumette_4.Image = Global.Jeu_Nim.My.Resources.Resources.choisie
        Me.PB_Allumette_4.Location = New System.Drawing.Point(117, 8)
        Me.PB_Allumette_4.Name = "PB_Allumette_4"
        Me.PB_Allumette_4.Size = New System.Drawing.Size(31, 125)
        Me.PB_Allumette_4.TabIndex = 18
        Me.PB_Allumette_4.TabStop = False
        '
        'PB_Allumette_3
        '
        Me.PB_Allumette_3.Image = Global.Jeu_Nim.My.Resources.Resources.choisie
        Me.PB_Allumette_3.Location = New System.Drawing.Point(80, 8)
        Me.PB_Allumette_3.Name = "PB_Allumette_3"
        Me.PB_Allumette_3.Size = New System.Drawing.Size(31, 125)
        Me.PB_Allumette_3.TabIndex = 17
        Me.PB_Allumette_3.TabStop = False
        '
        'PB_Allumette_2
        '
        Me.PB_Allumette_2.Image = Global.Jeu_Nim.My.Resources.Resources.choisie
        Me.PB_Allumette_2.Location = New System.Drawing.Point(43, 8)
        Me.PB_Allumette_2.Name = "PB_Allumette_2"
        Me.PB_Allumette_2.Size = New System.Drawing.Size(31, 125)
        Me.PB_Allumette_2.TabIndex = 16
        Me.PB_Allumette_2.TabStop = False
        '
        'PB_Allumette_1
        '
        Me.PB_Allumette_1.Image = Global.Jeu_Nim.My.Resources.Resources.choisie
        Me.PB_Allumette_1.Location = New System.Drawing.Point(6, 7)
        Me.PB_Allumette_1.Name = "PB_Allumette_1"
        Me.PB_Allumette_1.Size = New System.Drawing.Size(31, 125)
        Me.PB_Allumette_1.TabIndex = 15
        Me.PB_Allumette_1.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Red
        Me.Label7.Location = New System.Drawing.Point(817, 3)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(71, 21)
        Me.Label7.TabIndex = 95
        Me.Label7.Text = "Humain"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Blue
        Me.Label8.Location = New System.Drawing.Point(620, 5)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(93, 21)
        Me.Label8.TabIndex = 96
        Me.Label8.Text = "Ordinateur"
        '
        'LB_dernier_choix_IA
        '
        Me.LB_dernier_choix_IA.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LB_dernier_choix_IA.FormattingEnabled = True
        Me.LB_dernier_choix_IA.ItemHeight = 21
        Me.LB_dernier_choix_IA.Location = New System.Drawing.Point(21, 41)
        Me.LB_dernier_choix_IA.Name = "LB_dernier_choix_IA"
        Me.LB_dernier_choix_IA.Size = New System.Drawing.Size(85, 88)
        Me.LB_dernier_choix_IA.TabIndex = 97
        '
        'Button4
        '
        Me.Button4.Enabled = False
        Me.Button4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(534, 505)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(169, 41)
        Me.Button4.TabIndex = 98
        Me.Button4.Text = "Prendre 4 allumettes"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(38, 3)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(115, 20)
        Me.Label3.TabIndex = 76
        Me.Label3.Text = "Prise maximum"
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(261, 35)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(162, 20)
        Me.Label6.TabIndex = 79
        Me.Label6.Text = "Nombres d'allumettes"
        '
        'CB_allumette
        '
        Me.CB_allumette.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CB_allumette.FormattingEnabled = True
        Me.CB_allumette.Items.AddRange(New Object() {"9", "10", "11", "12"})
        Me.CB_allumette.Location = New System.Drawing.Point(441, 34)
        Me.CB_allumette.Name = "CB_allumette"
        Me.CB_allumette.Size = New System.Drawing.Size(86, 28)
        Me.CB_allumette.TabIndex = 80
        Me.CB_allumette.Text = "12"
        '
        'Cb_Prise
        '
        Me.Cb_Prise.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cb_Prise.FormattingEnabled = True
        Me.Cb_Prise.Items.AddRange(New Object() {"3", "4"})
        Me.Cb_Prise.Location = New System.Drawing.Point(159, 0)
        Me.Cb_Prise.Name = "Cb_Prise"
        Me.Cb_Prise.Size = New System.Drawing.Size(86, 28)
        Me.Cb_Prise.TabIndex = 81
        Me.Cb_Prise.Text = "3"
        '
        'Label10
        '
        Me.Label10.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(261, 3)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(115, 20)
        Me.Label10.TabIndex = 84
        Me.Label10.Text = "Qui commence"
        '
        'CB_Commence
        '
        Me.CB_Commence.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CB_Commence.FormattingEnabled = True
        Me.CB_Commence.Items.AddRange(New Object() {"Humain", "Ordinateur", "Aléatoire", "Chacun son tour"})
        Me.CB_Commence.Location = New System.Drawing.Point(382, 0)
        Me.CB_Commence.Name = "CB_Commence"
        Me.CB_Commence.Size = New System.Drawing.Size(145, 28)
        Me.CB_Commence.TabIndex = 85
        Me.CB_Commence.Text = "Chacun son tour"
        '
        'GB_Setup
        '
        Me.GB_Setup.Controls.Add(Me.Label2)
        Me.GB_Setup.Controls.Add(Me.CB_Niveau)
        Me.GB_Setup.Controls.Add(Me.L_Niveau)
        Me.GB_Setup.Controls.Add(Me.CB_Commence)
        Me.GB_Setup.Controls.Add(Me.Cb_PerdGagne)
        Me.GB_Setup.Controls.Add(Me.Label10)
        Me.GB_Setup.Controls.Add(Me.Cb_Prise)
        Me.GB_Setup.Controls.Add(Me.CB_allumette)
        Me.GB_Setup.Controls.Add(Me.Label6)
        Me.GB_Setup.Controls.Add(Me.Label3)
        Me.GB_Setup.Location = New System.Drawing.Point(643, 428)
        Me.GB_Setup.Name = "GB_Setup"
        Me.GB_Setup.Size = New System.Drawing.Size(536, 99)
        Me.GB_Setup.TabIndex = 99
        Me.GB_Setup.TabStop = False
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(261, 71)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(139, 20)
        Me.Label2.TabIndex = 88
        Me.Label2.Text = "Dernière allumette"
        '
        'CB_Niveau
        '
        Me.CB_Niveau.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CB_Niveau.FormattingEnabled = True
        Me.CB_Niveau.Items.AddRange(New Object() {"1", "2", "3", "4"})
        Me.CB_Niveau.Location = New System.Drawing.Point(159, 32)
        Me.CB_Niveau.Name = "CB_Niveau"
        Me.CB_Niveau.Size = New System.Drawing.Size(86, 28)
        Me.CB_Niveau.TabIndex = 87
        Me.CB_Niveau.Text = "2"
        '
        'L_Niveau
        '
        Me.L_Niveau.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.L_Niveau.AutoSize = True
        Me.L_Niveau.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.L_Niveau.Location = New System.Drawing.Point(96, 39)
        Me.L_Niveau.Name = "L_Niveau"
        Me.L_Niveau.Size = New System.Drawing.Size(57, 20)
        Me.L_Niveau.TabIndex = 86
        Me.L_Niveau.Text = "Niveau"
        '
        'Cb_PerdGagne
        '
        Me.Cb_PerdGagne.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cb_PerdGagne.FormattingEnabled = True
        Me.Cb_PerdGagne.Items.AddRange(New Object() {"gagne", "perd"})
        Me.Cb_PerdGagne.Location = New System.Drawing.Point(441, 65)
        Me.Cb_PerdGagne.Name = "Cb_PerdGagne"
        Me.Cb_PerdGagne.Size = New System.Drawing.Size(86, 28)
        Me.Cb_PerdGagne.TabIndex = 89
        Me.Cb_PerdGagne.Text = "perd"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackgroundImage = Global.Jeu_Nim.My.Resources.Resources.marbre
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FichierToolStripMenuItem, Me.AProposToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1184, 24)
        Me.MenuStrip1.TabIndex = 100
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FichierToolStripMenuItem
        '
        Me.FichierToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OuvrirToolStripMenuItem, Me.EnregistrerSousToolStripMenuItem, Me.QuitterToolStripMenuItem})
        Me.FichierToolStripMenuItem.Name = "FichierToolStripMenuItem"
        Me.FichierToolStripMenuItem.Size = New System.Drawing.Size(49, 20)
        Me.FichierToolStripMenuItem.Text = "Partie"
        '
        'OuvrirToolStripMenuItem
        '
        Me.OuvrirToolStripMenuItem.Name = "OuvrirToolStripMenuItem"
        Me.OuvrirToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.OuvrirToolStripMenuItem.Text = "Ouvrir"
        '
        'EnregistrerSousToolStripMenuItem
        '
        Me.EnregistrerSousToolStripMenuItem.Name = "EnregistrerSousToolStripMenuItem"
        Me.EnregistrerSousToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.EnregistrerSousToolStripMenuItem.Text = "Enregistrer sous"
        '
        'QuitterToolStripMenuItem
        '
        Me.QuitterToolStripMenuItem.Name = "QuitterToolStripMenuItem"
        Me.QuitterToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.QuitterToolStripMenuItem.Text = "Quitter"
        '
        'AProposToolStripMenuItem
        '
        Me.AProposToolStripMenuItem.Name = "AProposToolStripMenuItem"
        Me.AProposToolStripMenuItem.Size = New System.Drawing.Size(67, 20)
        Me.AProposToolStripMenuItem.Text = "A propos"
        '
        'B_Rejouer
        '
        Me.B_Rejouer.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.B_Rejouer.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.B_Rejouer.Location = New System.Drawing.Point(716, 504)
        Me.B_Rejouer.Name = "B_Rejouer"
        Me.B_Rejouer.Size = New System.Drawing.Size(168, 41)
        Me.B_Rejouer.TabIndex = 101
        Me.B_Rejouer.Text = "Rejouer"
        Me.B_Rejouer.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'PBIA
        '
        Me.PBIA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PBIA.Image = Global.Jeu_Nim.My.Resources.Resources.debut
        Me.PBIA.Location = New System.Drawing.Point(12, 34)
        Me.PBIA.Name = "PBIA"
        Me.PBIA.Size = New System.Drawing.Size(146, 121)
        Me.PBIA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PBIA.TabIndex = 58
        Me.PBIA.TabStop = False
        '
        'LB_Score_IA
        '
        Me.LB_Score_IA.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LB_Score_IA.FormattingEnabled = True
        Me.LB_Score_IA.ItemHeight = 18
        Me.LB_Score_IA.Location = New System.Drawing.Point(699, 32)
        Me.LB_Score_IA.Name = "LB_Score_IA"
        Me.LB_Score_IA.Size = New System.Drawing.Size(55, 238)
        Me.LB_Score_IA.TabIndex = 103
        '
        'LB_Score_Humain
        '
        Me.LB_Score_Humain.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LB_Score_Humain.FormattingEnabled = True
        Me.LB_Score_Humain.ItemHeight = 18
        Me.LB_Score_Humain.Location = New System.Drawing.Point(760, 32)
        Me.LB_Score_Humain.Name = "LB_Score_Humain"
        Me.LB_Score_Humain.Size = New System.Drawing.Size(57, 238)
        Me.LB_Score_Humain.TabIndex = 104
        '
        'Chart1
        '
        Me.Chart1.BackColor = System.Drawing.Color.Transparent
        Me.Chart1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Chart1.BorderlineColor = System.Drawing.Color.Transparent
        Me.Chart1.BorderlineWidth = 0
        Me.Chart1.BorderSkin.BackColor = System.Drawing.Color.Transparent
        Me.Chart1.BorderSkin.BackImageTransparentColor = System.Drawing.Color.Transparent
        Me.Chart1.BorderSkin.BackSecondaryColor = System.Drawing.Color.Transparent
        Me.Chart1.BorderSkin.BorderColor = System.Drawing.Color.Transparent
        Me.Chart1.BorderSkin.PageColor = System.Drawing.Color.Transparent
        ChartArea1.AxisX.TitleFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ChartArea1.BackSecondaryColor = System.Drawing.Color.Transparent
        ChartArea1.BorderColor = System.Drawing.Color.Transparent
        ChartArea1.BorderWidth = 0
        ChartArea1.Name = "ChartArea1"
        ChartArea1.Position.Auto = False
        ChartArea1.Position.Height = 100.0!
        ChartArea1.Position.Width = 100.0!
        Me.Chart1.ChartAreas.Add(ChartArea1)
        Me.Chart1.Location = New System.Drawing.Point(614, 277)
        Me.Chart1.Margin = New System.Windows.Forms.Padding(0)
        Me.Chart1.Name = "Chart1"
        Me.Chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None
        Series1.BackImageTransparentColor = System.Drawing.Color.Red
        Series1.ChartArea = "ChartArea1"
        Series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line
        Series1.Color = System.Drawing.Color.Blue
        Series1.LabelForeColor = System.Drawing.Color.Red
        Series1.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Diamond
        Series1.Name = "Series1"
        Series2.ChartArea = "ChartArea1"
        Series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line
        Series2.Color = System.Drawing.Color.Red
        Series2.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Diamond
        Series2.Name = "Series2"
        Me.Chart1.Series.Add(Series1)
        Me.Chart1.Series.Add(Series2)
        Me.Chart1.Size = New System.Drawing.Size(556, 154)
        Me.Chart1.TabIndex = 105
        '
        'L_NombrePartie
        '
        Me.L_NombrePartie.AutoSize = True
        Me.L_NombrePartie.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.L_NombrePartie.Location = New System.Drawing.Point(1145, -2)
        Me.L_NombrePartie.Name = "L_NombrePartie"
        Me.L_NombrePartie.Size = New System.Drawing.Size(25, 30)
        Me.L_NombrePartie.TabIndex = 106
        Me.L_NombrePartie.Text = "0"
        '
        'Timer1
        '
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImage = Global.Jeu_Nim.My.Resources.Resources.marbre
        Me.ClientSize = New System.Drawing.Size(1184, 561)
        Me.Controls.Add(Me.LB_Partie)
        Me.Controls.Add(Me.L_NombrePartie)
        Me.Controls.Add(Me.Tb_allumette_restante)
        Me.Controls.Add(Me.LB_Score_Humain)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.B_Rejouer)
        Me.Controls.Add(Me.LB_Score_IA)
        Me.Controls.Add(Me.LB_IA)
        Me.Controls.Add(Me.PBIA)
        Me.Controls.Add(Me.GB_Setup)
        Me.Controls.Add(Me.LB_dernier_choix_IA)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GB_Choix_en_cours)
        Me.Controls.Add(Me.LB_Choix_IA)
        Me.Controls.Add(Me.L_Dernier_choix)
        Me.Controls.Add(Me.L_Score_IA)
        Me.Controls.Add(Me.L_Score_Humain)
        Me.Controls.Add(Me.L_dialog)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.Chart1)
        Me.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(1200, 600)
        Me.Name = "Form1"
        Me.Text = "Jeu de Nim"
        Me.GB_Choix_en_cours.ResumeLayout(False)
        Me.GB_Choix_en_cours.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.PB_Allumette_12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PB_Allumette_11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PB_Allumette_10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PB_Allumette_9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PB_Allumette_8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PB_Allumette_7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PB_Allumette_6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PB_Allumette_5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PB_Allumette_4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PB_Allumette_3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PB_Allumette_2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PB_Allumette_1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GB_Setup.ResumeLayout(False)
        Me.GB_Setup.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PBIA, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Tb_allumette_restante As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents PBIA As PictureBox
    Friend WithEvents Label11 As Label
    Friend WithEvents L_dialog As Label
    Friend WithEvents L_Score_Humain As Label
    Friend WithEvents L_Score_IA As Label
    Friend WithEvents LB_Partie As ListBox
    Friend WithEvents L_Dernier_choix As Label
    Friend WithEvents LB_IA As ListBox
    Friend WithEvents LB_Choix_IA As ListBox
    Friend WithEvents GB_Choix_en_cours As GroupBox
    Friend WithEvents TB_En_cours_12 As TextBox
    Friend WithEvents TB_En_cours_11 As TextBox
    Friend WithEvents TB_En_cours_10 As TextBox
    Friend WithEvents TB_En_cours_9 As TextBox
    Friend WithEvents TB_En_cours_8 As TextBox
    Friend WithEvents TB_En_cours_7 As TextBox
    Friend WithEvents TB_En_cours_6 As TextBox
    Friend WithEvents TB_En_cours_5 As TextBox
    Friend WithEvents TB_En_cours_4 As TextBox
    Friend WithEvents TB_En_cours_3 As TextBox
    Friend WithEvents TB_En_cours_2 As TextBox
    Friend WithEvents TB_En_cours_1 As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents LB_choix_possible_12 As ListBox
    Friend WithEvents LB_choix_possible_11 As ListBox
    Friend WithEvents LB_choix_possible_10 As ListBox
    Friend WithEvents LB_choix_possible_9 As ListBox
    Friend WithEvents LB_choix_possible_8 As ListBox
    Friend WithEvents LB_choix_possible_7 As ListBox
    Friend WithEvents LB_choix_possible_6 As ListBox
    Friend WithEvents LB_choix_possible_5 As ListBox
    Friend WithEvents LB_choix_possible_4 As ListBox
    Friend WithEvents LB_choix_possible_3 As ListBox
    Friend WithEvents LB_choix_possible_2 As ListBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents PB_Allumette_12 As PictureBox
    Friend WithEvents PB_Allumette_11 As PictureBox
    Friend WithEvents PB_Allumette_10 As PictureBox
    Friend WithEvents PB_Allumette_9 As PictureBox
    Friend WithEvents PB_Allumette_8 As PictureBox
    Friend WithEvents PB_Allumette_7 As PictureBox
    Friend WithEvents PB_Allumette_6 As PictureBox
    Friend WithEvents PB_Allumette_5 As PictureBox
    Friend WithEvents PB_Allumette_4 As PictureBox
    Friend WithEvents PB_Allumette_3 As PictureBox
    Friend WithEvents PB_Allumette_2 As PictureBox
    Friend WithEvents PB_Allumette_1 As PictureBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Public WithEvents LB_choix_possible_1 As ListBox
    Friend WithEvents LB_dernier_choix_IA As ListBox
    Friend WithEvents Button4 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents CB_allumette As ComboBox
    Friend WithEvents Cb_Prise As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents CB_Commence As ComboBox
    Friend WithEvents GB_Setup As GroupBox
    Friend WithEvents CB_Niveau As ComboBox
    Friend WithEvents L_Niveau As Label
    Friend WithEvents Cb_PerdGagne As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FichierToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OuvrirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EnregistrerSousToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents QuitterToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AProposToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents B_Rejouer As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents LB_Score_IA As ListBox
    Friend WithEvents LB_Score_Humain As ListBox
    Friend WithEvents Chart1 As DataVisualization.Charting.Chart
    Friend WithEvents L_NombrePartie As Label
    Friend WithEvents Timer1 As Timer
End Class
