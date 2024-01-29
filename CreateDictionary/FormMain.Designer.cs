namespace CreateDictionary
{
  partial class FormMain
  {
    /// <summary>
    /// Variable nécessaire au concepteur.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Nettoyage des ressources utilisées.
    /// </summary>
    /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Code généré par le Concepteur Windows Form

    /// <summary>
    /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
    /// le contenu de cette méthode avec l'éditeur de code.
    /// </summary>
    private void InitializeComponent()
    {
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
      this.menuStrip1 = new System.Windows.Forms.MenuStrip();
      this.fichierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.nouveauToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.ouvrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
      this.enregistrerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.enregistrersousToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
      this.imprimerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.aperçuavantimpressionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
      this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.editionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.annulerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.rétablirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
      this.couperToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.copierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.collerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
      this.sélectionnertoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.outilsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.personnaliserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.aideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.sommaireToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.indexToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.rechercherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
      this.àproposdeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.textBoxSource = new System.Windows.Forms.TextBox();
      this.buttonAdd = new System.Windows.Forms.Button();
      this.listBoxWords = new System.Windows.Forms.ListBox();
      this.labelCountWords = new System.Windows.Forms.Label();
      this.buttonDelete = new System.Windows.Forms.Button();
      this.buttonLoad = new System.Windows.Forms.Button();
      this.listBoxGeneralDico = new System.Windows.Forms.ListBox();
      this.labelGeneralCount = new System.Windows.Forms.Label();
      this.buttonSave = new System.Windows.Forms.Button();
      this.buttonCopy = new System.Windows.Forms.Button();
      this.buttonRemoveDuplicate = new System.Windows.Forms.Button();
      this.buttonDeleteWordsGeneralDico = new System.Windows.Forms.Button();
      this.buttonRemoveDuplicateGeneralDico = new System.Windows.Forms.Button();
      this.labelPasteYourText = new System.Windows.Forms.Label();
      this.labelListOfWords = new System.Windows.Forms.Label();
      this.comboBoxLanguages = new System.Windows.Forms.ComboBox();
      this.labelListOfDictionaries = new System.Windows.Forms.Label();
      this.buttonCountNewWords = new System.Windows.Forms.Button();
      this.buttonClearSource = new System.Windows.Forms.Button();
      this.labelCountSourceWords = new System.Windows.Forms.Label();
      this.buttonProperNouns = new System.Windows.Forms.Button();
      this.menuStrip1.SuspendLayout();
      this.SuspendLayout();
      // 
      // menuStrip1
      // 
      this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichierToolStripMenuItem,
            this.editionToolStripMenuItem,
            this.outilsToolStripMenuItem,
            this.aideToolStripMenuItem});
      this.menuStrip1.Location = new System.Drawing.Point(0, 0);
      this.menuStrip1.Name = "menuStrip1";
      this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
      this.menuStrip1.Size = new System.Drawing.Size(1617, 25);
      this.menuStrip1.TabIndex = 0;
      this.menuStrip1.Text = "menuStrip1";
      // 
      // fichierToolStripMenuItem
      // 
      this.fichierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nouveauToolStripMenuItem,
            this.ouvrirToolStripMenuItem,
            this.toolStripSeparator,
            this.enregistrerToolStripMenuItem,
            this.enregistrersousToolStripMenuItem,
            this.toolStripSeparator1,
            this.imprimerToolStripMenuItem,
            this.aperçuavantimpressionToolStripMenuItem,
            this.toolStripSeparator2,
            this.quitterToolStripMenuItem});
      this.fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
      this.fichierToolStripMenuItem.Size = new System.Drawing.Size(54, 19);
      this.fichierToolStripMenuItem.Text = "&Fichier";
      // 
      // nouveauToolStripMenuItem
      // 
      this.nouveauToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("nouveauToolStripMenuItem.Image")));
      this.nouveauToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.nouveauToolStripMenuItem.Name = "nouveauToolStripMenuItem";
      this.nouveauToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
      this.nouveauToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
      this.nouveauToolStripMenuItem.Text = "&Nouveau";
      // 
      // ouvrirToolStripMenuItem
      // 
      this.ouvrirToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("ouvrirToolStripMenuItem.Image")));
      this.ouvrirToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.ouvrirToolStripMenuItem.Name = "ouvrirToolStripMenuItem";
      this.ouvrirToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
      this.ouvrirToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
      this.ouvrirToolStripMenuItem.Text = "&Ouvrir";
      // 
      // toolStripSeparator
      // 
      this.toolStripSeparator.Name = "toolStripSeparator";
      this.toolStripSeparator.Size = new System.Drawing.Size(202, 6);
      // 
      // enregistrerToolStripMenuItem
      // 
      this.enregistrerToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("enregistrerToolStripMenuItem.Image")));
      this.enregistrerToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.enregistrerToolStripMenuItem.Name = "enregistrerToolStripMenuItem";
      this.enregistrerToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
      this.enregistrerToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
      this.enregistrerToolStripMenuItem.Text = "&Enregistrer";
      // 
      // enregistrersousToolStripMenuItem
      // 
      this.enregistrersousToolStripMenuItem.Name = "enregistrersousToolStripMenuItem";
      this.enregistrersousToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
      this.enregistrersousToolStripMenuItem.Text = "Enregistrer &sous";
      // 
      // toolStripSeparator1
      // 
      this.toolStripSeparator1.Name = "toolStripSeparator1";
      this.toolStripSeparator1.Size = new System.Drawing.Size(202, 6);
      // 
      // imprimerToolStripMenuItem
      // 
      this.imprimerToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("imprimerToolStripMenuItem.Image")));
      this.imprimerToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.imprimerToolStripMenuItem.Name = "imprimerToolStripMenuItem";
      this.imprimerToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
      this.imprimerToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
      this.imprimerToolStripMenuItem.Text = "&Imprimer";
      // 
      // aperçuavantimpressionToolStripMenuItem
      // 
      this.aperçuavantimpressionToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("aperçuavantimpressionToolStripMenuItem.Image")));
      this.aperçuavantimpressionToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.aperçuavantimpressionToolStripMenuItem.Name = "aperçuavantimpressionToolStripMenuItem";
      this.aperçuavantimpressionToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
      this.aperçuavantimpressionToolStripMenuItem.Text = "Aperçu a&vant impression";
      // 
      // toolStripSeparator2
      // 
      this.toolStripSeparator2.Name = "toolStripSeparator2";
      this.toolStripSeparator2.Size = new System.Drawing.Size(202, 6);
      // 
      // quitterToolStripMenuItem
      // 
      this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
      this.quitterToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
      this.quitterToolStripMenuItem.Text = "&Quitter";
      this.quitterToolStripMenuItem.Click += new System.EventHandler(this.QuitToolStripMenuItem_Click);
      // 
      // editionToolStripMenuItem
      // 
      this.editionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.annulerToolStripMenuItem,
            this.rétablirToolStripMenuItem,
            this.toolStripSeparator3,
            this.couperToolStripMenuItem,
            this.copierToolStripMenuItem,
            this.collerToolStripMenuItem,
            this.toolStripSeparator4,
            this.sélectionnertoutToolStripMenuItem});
      this.editionToolStripMenuItem.Name = "editionToolStripMenuItem";
      this.editionToolStripMenuItem.Size = new System.Drawing.Size(56, 19);
      this.editionToolStripMenuItem.Text = "&Edition";
      // 
      // annulerToolStripMenuItem
      // 
      this.annulerToolStripMenuItem.Name = "annulerToolStripMenuItem";
      this.annulerToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
      this.annulerToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
      this.annulerToolStripMenuItem.Text = "&Annuler";
      // 
      // rétablirToolStripMenuItem
      // 
      this.rétablirToolStripMenuItem.Name = "rétablirToolStripMenuItem";
      this.rétablirToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
      this.rétablirToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
      this.rétablirToolStripMenuItem.Text = "&Rétablir";
      // 
      // toolStripSeparator3
      // 
      this.toolStripSeparator3.Name = "toolStripSeparator3";
      this.toolStripSeparator3.Size = new System.Drawing.Size(161, 6);
      // 
      // couperToolStripMenuItem
      // 
      this.couperToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("couperToolStripMenuItem.Image")));
      this.couperToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.couperToolStripMenuItem.Name = "couperToolStripMenuItem";
      this.couperToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
      this.couperToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
      this.couperToolStripMenuItem.Text = "&Couper";
      // 
      // copierToolStripMenuItem
      // 
      this.copierToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("copierToolStripMenuItem.Image")));
      this.copierToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.copierToolStripMenuItem.Name = "copierToolStripMenuItem";
      this.copierToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
      this.copierToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
      this.copierToolStripMenuItem.Text = "Co&pier";
      // 
      // collerToolStripMenuItem
      // 
      this.collerToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("collerToolStripMenuItem.Image")));
      this.collerToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.collerToolStripMenuItem.Name = "collerToolStripMenuItem";
      this.collerToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
      this.collerToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
      this.collerToolStripMenuItem.Text = "Co&ller";
      // 
      // toolStripSeparator4
      // 
      this.toolStripSeparator4.Name = "toolStripSeparator4";
      this.toolStripSeparator4.Size = new System.Drawing.Size(161, 6);
      // 
      // sélectionnertoutToolStripMenuItem
      // 
      this.sélectionnertoutToolStripMenuItem.Name = "sélectionnertoutToolStripMenuItem";
      this.sélectionnertoutToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
      this.sélectionnertoutToolStripMenuItem.Text = "Sélectio&nner tout";
      // 
      // outilsToolStripMenuItem
      // 
      this.outilsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.personnaliserToolStripMenuItem,
            this.optionsToolStripMenuItem});
      this.outilsToolStripMenuItem.Name = "outilsToolStripMenuItem";
      this.outilsToolStripMenuItem.Size = new System.Drawing.Size(50, 19);
      this.outilsToolStripMenuItem.Text = "&Outils";
      // 
      // personnaliserToolStripMenuItem
      // 
      this.personnaliserToolStripMenuItem.Name = "personnaliserToolStripMenuItem";
      this.personnaliserToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
      this.personnaliserToolStripMenuItem.Text = "&Personnaliser";
      // 
      // optionsToolStripMenuItem
      // 
      this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
      this.optionsToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
      this.optionsToolStripMenuItem.Text = "&Options";
      // 
      // aideToolStripMenuItem
      // 
      this.aideToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sommaireToolStripMenuItem,
            this.indexToolStripMenuItem,
            this.rechercherToolStripMenuItem,
            this.toolStripSeparator5,
            this.àproposdeToolStripMenuItem});
      this.aideToolStripMenuItem.Name = "aideToolStripMenuItem";
      this.aideToolStripMenuItem.Size = new System.Drawing.Size(43, 19);
      this.aideToolStripMenuItem.Text = "&Aide";
      // 
      // sommaireToolStripMenuItem
      // 
      this.sommaireToolStripMenuItem.Name = "sommaireToolStripMenuItem";
      this.sommaireToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
      this.sommaireToolStripMenuItem.Text = "&Sommaire";
      // 
      // indexToolStripMenuItem
      // 
      this.indexToolStripMenuItem.Name = "indexToolStripMenuItem";
      this.indexToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
      this.indexToolStripMenuItem.Text = "&Index";
      // 
      // rechercherToolStripMenuItem
      // 
      this.rechercherToolStripMenuItem.Name = "rechercherToolStripMenuItem";
      this.rechercherToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
      this.rechercherToolStripMenuItem.Text = "&Rechercher";
      // 
      // toolStripSeparator5
      // 
      this.toolStripSeparator5.Name = "toolStripSeparator5";
      this.toolStripSeparator5.Size = new System.Drawing.Size(144, 6);
      // 
      // àproposdeToolStripMenuItem
      // 
      this.àproposdeToolStripMenuItem.Name = "àproposdeToolStripMenuItem";
      this.àproposdeToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
      this.àproposdeToolStripMenuItem.Text = "À &propos de...";
      // 
      // textBoxSource
      // 
      this.textBoxSource.Location = new System.Drawing.Point(60, 114);
      this.textBoxSource.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.textBoxSource.Multiline = true;
      this.textBoxSource.Name = "textBoxSource";
      this.textBoxSource.Size = new System.Drawing.Size(325, 770);
      this.textBoxSource.TabIndex = 1;
      this.textBoxSource.TextChanged += new System.EventHandler(this.TextBoxSource_TextChanged);
      // 
      // buttonAdd
      // 
      this.buttonAdd.Location = new System.Drawing.Point(425, 114);
      this.buttonAdd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.buttonAdd.Name = "buttonAdd";
      this.buttonAdd.Size = new System.Drawing.Size(124, 35);
      this.buttonAdd.TabIndex = 2;
      this.buttonAdd.Text = "List words";
      this.buttonAdd.UseVisualStyleBackColor = true;
      this.buttonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
      // 
      // listBoxWords
      // 
      this.listBoxWords.FormattingEnabled = true;
      this.listBoxWords.ItemHeight = 20;
      this.listBoxWords.Location = new System.Drawing.Point(581, 114);
      this.listBoxWords.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.listBoxWords.Name = "listBoxWords";
      this.listBoxWords.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
      this.listBoxWords.Size = new System.Drawing.Size(231, 764);
      this.listBoxWords.Sorted = true;
      this.listBoxWords.TabIndex = 3;
      this.listBoxWords.SelectedIndexChanged += new System.EventHandler(this.ListBoxWords_SelectedIndexChanged);
      // 
      // labelCountWords
      // 
      this.labelCountWords.AutoSize = true;
      this.labelCountWords.Location = new System.Drawing.Point(577, 902);
      this.labelCountWords.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.labelCountWords.Name = "labelCountWords";
      this.labelCountWords.Size = new System.Drawing.Size(69, 20);
      this.labelCountWords.TabIndex = 4;
      this.labelCountWords.Text = "Count: 0";
      // 
      // buttonDelete
      // 
      this.buttonDelete.Location = new System.Drawing.Point(425, 159);
      this.buttonDelete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.buttonDelete.Name = "buttonDelete";
      this.buttonDelete.Size = new System.Drawing.Size(124, 35);
      this.buttonDelete.TabIndex = 5;
      this.buttonDelete.Text = "Delete word";
      this.buttonDelete.UseVisualStyleBackColor = true;
      this.buttonDelete.Click += new System.EventHandler(this.ButtonDelete_Click);
      // 
      // buttonLoad
      // 
      this.buttonLoad.Location = new System.Drawing.Point(822, 110);
      this.buttonLoad.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.buttonLoad.Name = "buttonLoad";
      this.buttonLoad.Size = new System.Drawing.Size(124, 35);
      this.buttonLoad.TabIndex = 6;
      this.buttonLoad.Text = "Load";
      this.buttonLoad.UseVisualStyleBackColor = true;
      this.buttonLoad.Click += new System.EventHandler(this.ButtonLoad_Click);
      // 
      // listBoxGeneralDico
      // 
      this.listBoxGeneralDico.FormattingEnabled = true;
      this.listBoxGeneralDico.ItemHeight = 20;
      this.listBoxGeneralDico.Location = new System.Drawing.Point(955, 114);
      this.listBoxGeneralDico.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.listBoxGeneralDico.Name = "listBoxGeneralDico";
      this.listBoxGeneralDico.Size = new System.Drawing.Size(231, 764);
      this.listBoxGeneralDico.TabIndex = 7;
      // 
      // labelGeneralCount
      // 
      this.labelGeneralCount.AutoSize = true;
      this.labelGeneralCount.Location = new System.Drawing.Point(865, 902);
      this.labelGeneralCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.labelGeneralCount.Name = "labelGeneralCount";
      this.labelGeneralCount.Size = new System.Drawing.Size(69, 20);
      this.labelGeneralCount.TabIndex = 8;
      this.labelGeneralCount.Text = "Count: 0";
      // 
      // buttonSave
      // 
      this.buttonSave.Location = new System.Drawing.Point(822, 258);
      this.buttonSave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.buttonSave.Name = "buttonSave";
      this.buttonSave.Size = new System.Drawing.Size(124, 35);
      this.buttonSave.TabIndex = 9;
      this.buttonSave.Text = "Save";
      this.buttonSave.UseVisualStyleBackColor = true;
      this.buttonSave.Click += new System.EventHandler(this.ButtonSave_Click);
      // 
      // buttonCopy
      // 
      this.buttonCopy.Location = new System.Drawing.Point(822, 199);
      this.buttonCopy.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.buttonCopy.Name = "buttonCopy";
      this.buttonCopy.Size = new System.Drawing.Size(124, 35);
      this.buttonCopy.TabIndex = 10;
      this.buttonCopy.Text = "Copy all words";
      this.buttonCopy.UseVisualStyleBackColor = true;
      this.buttonCopy.Click += new System.EventHandler(this.ButtonCopy_Click);
      // 
      // buttonRemoveDuplicate
      // 
      this.buttonRemoveDuplicate.Location = new System.Drawing.Point(425, 218);
      this.buttonRemoveDuplicate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.buttonRemoveDuplicate.Name = "buttonRemoveDuplicate";
      this.buttonRemoveDuplicate.Size = new System.Drawing.Size(124, 55);
      this.buttonRemoveDuplicate.TabIndex = 11;
      this.buttonRemoveDuplicate.Text = "Remove duplicate";
      this.buttonRemoveDuplicate.UseVisualStyleBackColor = true;
      this.buttonRemoveDuplicate.Click += new System.EventHandler(this.ButtonRemoveDuplicate_Click);
      // 
      // buttonDeleteWordsGeneralDico
      // 
      this.buttonDeleteWordsGeneralDico.Location = new System.Drawing.Point(820, 303);
      this.buttonDeleteWordsGeneralDico.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.buttonDeleteWordsGeneralDico.Name = "buttonDeleteWordsGeneralDico";
      this.buttonDeleteWordsGeneralDico.Size = new System.Drawing.Size(124, 35);
      this.buttonDeleteWordsGeneralDico.TabIndex = 12;
      this.buttonDeleteWordsGeneralDico.Text = "Delete word";
      this.buttonDeleteWordsGeneralDico.UseVisualStyleBackColor = true;
      this.buttonDeleteWordsGeneralDico.Click += new System.EventHandler(this.ButtonDeleteWordsGeneralDico_Click);
      // 
      // buttonRemoveDuplicateGeneralDico
      // 
      this.buttonRemoveDuplicateGeneralDico.Location = new System.Drawing.Point(820, 348);
      this.buttonRemoveDuplicateGeneralDico.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.buttonRemoveDuplicateGeneralDico.Name = "buttonRemoveDuplicateGeneralDico";
      this.buttonRemoveDuplicateGeneralDico.Size = new System.Drawing.Size(124, 55);
      this.buttonRemoveDuplicateGeneralDico.TabIndex = 13;
      this.buttonRemoveDuplicateGeneralDico.Text = "Remove duplicate";
      this.buttonRemoveDuplicateGeneralDico.UseVisualStyleBackColor = true;
      this.buttonRemoveDuplicateGeneralDico.Click += new System.EventHandler(this.ButtonRemoveDuplicateGeneralDico_Click);
      // 
      // labelPasteYourText
      // 
      this.labelPasteYourText.AutoSize = true;
      this.labelPasteYourText.Location = new System.Drawing.Point(56, 75);
      this.labelPasteYourText.Name = "labelPasteYourText";
      this.labelPasteYourText.Size = new System.Drawing.Size(154, 20);
      this.labelPasteYourText.TabIndex = 14;
      this.labelPasteYourText.Text = "Paste your text here:";
      // 
      // labelListOfWords
      // 
      this.labelListOfWords.AutoSize = true;
      this.labelListOfWords.Location = new System.Drawing.Point(577, 75);
      this.labelListOfWords.Name = "labelListOfWords";
      this.labelListOfWords.Size = new System.Drawing.Size(172, 20);
      this.labelListOfWords.TabIndex = 15;
      this.labelListOfWords.Text = "List of words extracted:";
      // 
      // comboBoxLanguages
      // 
      this.comboBoxLanguages.FormattingEnabled = true;
      this.comboBoxLanguages.Location = new System.Drawing.Point(955, 75);
      this.comboBoxLanguages.Name = "comboBoxLanguages";
      this.comboBoxLanguages.Size = new System.Drawing.Size(231, 28);
      this.comboBoxLanguages.TabIndex = 16;
      this.comboBoxLanguages.SelectedIndexChanged += new System.EventHandler(this.ComboBoxLanguages_SelectedIndexChanged);
      // 
      // labelListOfDictionaries
      // 
      this.labelListOfDictionaries.AutoSize = true;
      this.labelListOfDictionaries.Location = new System.Drawing.Point(951, 52);
      this.labelListOfDictionaries.Name = "labelListOfDictionaries";
      this.labelListOfDictionaries.Size = new System.Drawing.Size(140, 20);
      this.labelListOfDictionaries.TabIndex = 17;
      this.labelListOfDictionaries.Text = "List of dictionaries:";
      // 
      // buttonCountNewWords
      // 
      this.buttonCountNewWords.Location = new System.Drawing.Point(820, 154);
      this.buttonCountNewWords.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.buttonCountNewWords.Name = "buttonCountNewWords";
      this.buttonCountNewWords.Size = new System.Drawing.Size(124, 35);
      this.buttonCountNewWords.TabIndex = 18;
      this.buttonCountNewWords.Text = "Count new";
      this.buttonCountNewWords.UseVisualStyleBackColor = true;
      this.buttonCountNewWords.Click += new System.EventHandler(this.ButtonCountNewWords_Click);
      // 
      // buttonClearSource
      // 
      this.buttonClearSource.Enabled = false;
      this.buttonClearSource.Location = new System.Drawing.Point(261, 75);
      this.buttonClearSource.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.buttonClearSource.Name = "buttonClearSource";
      this.buttonClearSource.Size = new System.Drawing.Size(124, 35);
      this.buttonClearSource.TabIndex = 19;
      this.buttonClearSource.Text = "Clear";
      this.buttonClearSource.UseVisualStyleBackColor = true;
      this.buttonClearSource.Click += new System.EventHandler(this.ButtonClearSource_Click);
      // 
      // labelCountSourceWords
      // 
      this.labelCountSourceWords.AutoSize = true;
      this.labelCountSourceWords.Location = new System.Drawing.Point(56, 902);
      this.labelCountSourceWords.Name = "labelCountSourceWords";
      this.labelCountSourceWords.Size = new System.Drawing.Size(146, 20);
      this.labelCountSourceWords.TabIndex = 20;
      this.labelCountSourceWords.Text = "Number of words: 0";
      // 
      // buttonProperNouns
      // 
      this.buttonProperNouns.Location = new System.Drawing.Point(425, 293);
      this.buttonProperNouns.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.buttonProperNouns.Name = "buttonProperNouns";
      this.buttonProperNouns.Size = new System.Drawing.Size(124, 55);
      this.buttonProperNouns.TabIndex = 21;
      this.buttonProperNouns.Text = "Add Proper Nom";
      this.buttonProperNouns.UseVisualStyleBackColor = true;
      this.buttonProperNouns.Click += new System.EventHandler(this.ButtonProperNouns_Click);
      // 
      // FormMain
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1617, 940);
      this.Controls.Add(this.buttonProperNouns);
      this.Controls.Add(this.labelCountSourceWords);
      this.Controls.Add(this.buttonClearSource);
      this.Controls.Add(this.buttonCountNewWords);
      this.Controls.Add(this.labelListOfDictionaries);
      this.Controls.Add(this.comboBoxLanguages);
      this.Controls.Add(this.labelListOfWords);
      this.Controls.Add(this.labelPasteYourText);
      this.Controls.Add(this.buttonRemoveDuplicateGeneralDico);
      this.Controls.Add(this.buttonDeleteWordsGeneralDico);
      this.Controls.Add(this.buttonRemoveDuplicate);
      this.Controls.Add(this.buttonCopy);
      this.Controls.Add(this.buttonSave);
      this.Controls.Add(this.labelGeneralCount);
      this.Controls.Add(this.listBoxGeneralDico);
      this.Controls.Add(this.buttonLoad);
      this.Controls.Add(this.buttonDelete);
      this.Controls.Add(this.labelCountWords);
      this.Controls.Add(this.listBoxWords);
      this.Controls.Add(this.buttonAdd);
      this.Controls.Add(this.textBoxSource);
      this.Controls.Add(this.menuStrip1);
      this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.MainMenuStrip = this.menuStrip1;
      this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.Name = "FormMain";
      this.Text = "Create Dictionary";
      this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormMain_FormClosed);
      this.Load += new System.EventHandler(this.FormMain_Load);
      this.menuStrip1.ResumeLayout(false);
      this.menuStrip1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.MenuStrip menuStrip1;
    private System.Windows.Forms.ToolStripMenuItem fichierToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem nouveauToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem ouvrirToolStripMenuItem;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
    private System.Windows.Forms.ToolStripMenuItem enregistrerToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem enregistrersousToolStripMenuItem;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    private System.Windows.Forms.ToolStripMenuItem imprimerToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem aperçuavantimpressionToolStripMenuItem;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
    private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem editionToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem annulerToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem rétablirToolStripMenuItem;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
    private System.Windows.Forms.ToolStripMenuItem couperToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem copierToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem collerToolStripMenuItem;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
    private System.Windows.Forms.ToolStripMenuItem sélectionnertoutToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem outilsToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem personnaliserToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem aideToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem sommaireToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem indexToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem rechercherToolStripMenuItem;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
    private System.Windows.Forms.ToolStripMenuItem àproposdeToolStripMenuItem;
    private System.Windows.Forms.TextBox textBoxSource;
    private System.Windows.Forms.Button buttonAdd;
    private System.Windows.Forms.ListBox listBoxWords;
    private System.Windows.Forms.Label labelCountWords;
    private System.Windows.Forms.Button buttonDelete;
    private System.Windows.Forms.Button buttonLoad;
    private System.Windows.Forms.ListBox listBoxGeneralDico;
    private System.Windows.Forms.Label labelGeneralCount;
    private System.Windows.Forms.Button buttonSave;
    private System.Windows.Forms.Button buttonCopy;
    private System.Windows.Forms.Button buttonRemoveDuplicate;
    private System.Windows.Forms.Button buttonDeleteWordsGeneralDico;
    private System.Windows.Forms.Button buttonRemoveDuplicateGeneralDico;
    private System.Windows.Forms.Label labelPasteYourText;
    private System.Windows.Forms.Label labelListOfWords;
    private System.Windows.Forms.ComboBox comboBoxLanguages;
    private System.Windows.Forms.Label labelListOfDictionaries;
    private System.Windows.Forms.Button buttonCountNewWords;
    private System.Windows.Forms.Button buttonClearSource;
    private System.Windows.Forms.Label labelCountSourceWords;
    private System.Windows.Forms.Button buttonProperNouns;
  }
}

