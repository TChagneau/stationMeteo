<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.comPort_ComboBox = New System.Windows.Forms.ComboBox()
        Me.connect_BTN = New System.Windows.Forms.Button()
        Me.Timer_LBL = New System.Windows.Forms.Label()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.titre = New System.Windows.Forms.Label()
        Me.tchagneau = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Logs = New System.Windows.Forms.RichTextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FichierToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RafraichirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SauvegarderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BoutonInvisibleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OuvrirLesFichierLocauxToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AideToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.LicenseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Timer1
        '
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.comPort_ComboBox)
        Me.GroupBox2.Controls.Add(Me.connect_BTN)
        Me.GroupBox2.Controls.Add(Me.Timer_LBL)
        Me.GroupBox2.Location = New System.Drawing.Point(132, 111)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(299, 89)
        Me.GroupBox2.TabIndex = 7
        Me.GroupBox2.TabStop = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(9, 46)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(90, 37)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "save data"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(155, 18)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "sélection du port com:"
        '
        'comPort_ComboBox
        '
        Me.comPort_ComboBox.FormattingEnabled = True
        Me.comPort_ComboBox.Location = New System.Drawing.Point(167, 19)
        Me.comPort_ComboBox.Name = "comPort_ComboBox"
        Me.comPort_ComboBox.Size = New System.Drawing.Size(126, 21)
        Me.comPort_ComboBox.TabIndex = 3
        '
        'connect_BTN
        '
        Me.connect_BTN.Location = New System.Drawing.Point(105, 46)
        Me.connect_BTN.Name = "connect_BTN"
        Me.connect_BTN.Size = New System.Drawing.Size(84, 37)
        Me.connect_BTN.TabIndex = 1
        Me.connect_BTN.Text = "Connect"
        Me.connect_BTN.UseVisualStyleBackColor = True
        '
        'Timer_LBL
        '
        Me.Timer_LBL.AutoSize = True
        Me.Timer_LBL.Location = New System.Drawing.Point(211, 46)
        Me.Timer_LBL.Name = "Timer_LBL"
        Me.Timer_LBL.Size = New System.Drawing.Size(82, 13)
        Me.Timer_LBL.TabIndex = 2
        Me.Timer_LBL.Text = "Reception: OFF"
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Location = New System.Drawing.Point(441, 520)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.ReadOnly = True
        Me.RichTextBox1.Size = New System.Drawing.Size(143, 42)
        Me.RichTextBox1.TabIndex = 8
        Me.RichTextBox1.Text = ""
        Me.RichTextBox1.Visible = False
        '
        'Timer2
        '
        Me.Timer2.Interval = 10800
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(74, 79)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(415, 29)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Programme de réception de données"
        '
        'titre
        '
        Me.titre.AutoSize = True
        Me.titre.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.titre.Location = New System.Drawing.Point(122, 24)
        Me.titre.Name = "titre"
        Me.titre.Size = New System.Drawing.Size(333, 55)
        Me.titre.TabIndex = 14
        Me.titre.Text = "Station Météo "
        '
        'tchagneau
        '
        Me.tchagneau.AutoSize = True
        Me.tchagneau.Location = New System.Drawing.Point(506, 206)
        Me.tchagneau.Name = "tchagneau"
        Me.tchagneau.Size = New System.Drawing.Size(66, 13)
        Me.tchagneau.TabIndex = 17
        Me.tchagneau.Text = "T.Chagneau"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Logs)
        Me.GroupBox1.Location = New System.Drawing.Point(132, 206)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(299, 314)
        Me.GroupBox1.TabIndex = 18
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "logs"
        '
        'Logs
        '
        Me.Logs.Location = New System.Drawing.Point(6, 18)
        Me.Logs.Name = "Logs"
        Me.Logs.ReadOnly = True
        Me.Logs.Size = New System.Drawing.Size(287, 290)
        Me.Logs.TabIndex = 0
        Me.Logs.Text = ""
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(501, 491)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(71, 23)
        Me.Button2.TabIndex = 19
        Me.Button2.Text = "log: visible"
        Me.Button2.UseVisualStyleBackColor = True
        Me.Button2.Visible = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FichierToolStripMenuItem, Me.EditionToolStripMenuItem, Me.AideToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(584, 24)
        Me.MenuStrip1.TabIndex = 20
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FichierToolStripMenuItem
        '
        Me.FichierToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RafraichirToolStripMenuItem, Me.SauvegarderToolStripMenuItem})
        Me.FichierToolStripMenuItem.Name = "FichierToolStripMenuItem"
        Me.FichierToolStripMenuItem.Size = New System.Drawing.Size(54, 20)
        Me.FichierToolStripMenuItem.Text = "Fichier"
        '
        'RafraichirToolStripMenuItem
        '
        Me.RafraichirToolStripMenuItem.Name = "RafraichirToolStripMenuItem"
        Me.RafraichirToolStripMenuItem.Size = New System.Drawing.Size(139, 22)
        Me.RafraichirToolStripMenuItem.Text = "Rafraichir"
        '
        'SauvegarderToolStripMenuItem
        '
        Me.SauvegarderToolStripMenuItem.Name = "SauvegarderToolStripMenuItem"
        Me.SauvegarderToolStripMenuItem.Size = New System.Drawing.Size(139, 22)
        Me.SauvegarderToolStripMenuItem.Text = "Sauvegarder"
        '
        'EditionToolStripMenuItem
        '
        Me.EditionToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BoutonInvisibleToolStripMenuItem, Me.OuvrirLesFichierLocauxToolStripMenuItem})
        Me.EditionToolStripMenuItem.Name = "EditionToolStripMenuItem"
        Me.EditionToolStripMenuItem.Size = New System.Drawing.Size(82, 20)
        Me.EditionToolStripMenuItem.Text = "Commande"
        '
        'BoutonInvisibleToolStripMenuItem
        '
        Me.BoutonInvisibleToolStripMenuItem.Name = "BoutonInvisibleToolStripMenuItem"
        Me.BoutonInvisibleToolStripMenuItem.Size = New System.Drawing.Size(197, 22)
        Me.BoutonInvisibleToolStripMenuItem.Text = "Bouton invisible"
        '
        'OuvrirLesFichierLocauxToolStripMenuItem
        '
        Me.OuvrirLesFichierLocauxToolStripMenuItem.Name = "OuvrirLesFichierLocauxToolStripMenuItem"
        Me.OuvrirLesFichierLocauxToolStripMenuItem.Size = New System.Drawing.Size(197, 22)
        Me.OuvrirLesFichierLocauxToolStripMenuItem.Text = "Ouvrir les fichier locaux"
        '
        'AideToolStripMenuItem
        '
        Me.AideToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem2, Me.LicenseToolStripMenuItem})
        Me.AideToolStripMenuItem.Name = "AideToolStripMenuItem"
        Me.AideToolStripMenuItem.Size = New System.Drawing.Size(43, 20)
        Me.AideToolStripMenuItem.Text = "Aide"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(113, 22)
        Me.ToolStripMenuItem2.Text = "?"
        '
        'LicenseToolStripMenuItem
        '
        Me.LicenseToolStripMenuItem.Name = "LicenseToolStripMenuItem"
        Me.LicenseToolStripMenuItem.Size = New System.Drawing.Size(113, 22)
        Me.LicenseToolStripMenuItem.Text = "License"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.tes2.My.Resources.Resources.icone
        Me.PictureBox1.Location = New System.Drawing.Point(492, 119)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(80, 81)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 16
        Me.PictureBox1.TabStop = False
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(584, 562)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.tchagneau)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.titre)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Station Météo"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SerialPort1 As IO.Ports.SerialPort
    Friend WithEvents Timer1 As Timer
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents comPort_ComboBox As ComboBox
    Friend WithEvents connect_BTN As Button
    Friend WithEvents Timer_LBL As Label
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Timer2 As Timer
    Friend WithEvents Label2 As Label
    Friend WithEvents titre As Label
    Friend WithEvents tchagneau As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Logs As RichTextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FichierToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RafraichirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SauvegarderToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AideToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents LicenseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BoutonInvisibleToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OuvrirLesFichierLocauxToolStripMenuItem As ToolStripMenuItem
End Class
