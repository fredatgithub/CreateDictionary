using CreateDictionary.Properties;
using HelperLibrary;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using System.Xml.Linq;
using Tools;

namespace CreateDictionary
{
  /// <summary>
  /// Formulaire principal de l'application CreateDictionary.
  /// Permet de gérer un dictionnaire de mots avec des fonctionnalités d'ajout, 
  /// de suppression et de gestion des mots.
  /// </summary>
  public partial class FormMain : Form
  {
    private readonly Dictionary<string, string> languageDicoEn = new Dictionary<string, string>();
    private readonly Dictionary<string, string> languageDicoFr = new Dictionary<string, string>();
    private const int FirstElement = 0;
    private const int SecondElement = 1;
    private const string ProperNounFilename = "properNouns.txt";

    /// <summary>
    /// Initialise une nouvelle instance de la classe <see cref="FormMain"/>
    /// </summary>
    public FormMain()
    {
      InitializeComponent();
    }

    /// <summary>
    /// Gère l'événement de clic sur le menu Quitter
    /// </summary>
    private void QuitToolStripMenuItem_Click(object sender, EventArgs e)
    {
      Application.Exit();
    }

    /// <summary>
    /// Gère l'événement de clic sur le bouton Ajouter
    /// </summary>
    private void ButtonAdd_Click(object sender, EventArgs e)
    {
      listBoxWords.Items.Clear();
      var newWords = new List<string>();
      newWords = ExtractWordsFrom(textBoxSource.Text, newWords);
      newWords = Helper.RemoveExceptionWords(newWords, ProperNounFilename);
      foreach (string word in newWords)
      {
        listBoxWords.Items.Add(word);
      }

      CountWords(labelCountWords, listBoxWords);
      ListBoxWords_SelectedIndexChanged(sender, e);
    }

    /// <summary>
    /// Extrait les mots d'un texte en appliquant différents traitements
    /// </summary>
    /// <param name="text">Le texte source à analyser</param>
    /// <param name="newWords">La liste des mots existants</param>
    /// <returns>Une liste de mots traités</returns>
    private List<string> ExtractWordsFrom(string text, List<string> newWords)
    {
      var result = new List<string>();
      foreach (string word in text.Split(Punctuation.Space))
      {
        // gérer les exceptions
        // séparer un ou plusieurs mots
        // enlever la première majuscule
        // enlever les espaces vides
        var isNewWord = word;
        var isNewWord2 = string.Empty;
        var onlyOneWord = true;
        if (newWords.Contains(word) || string.IsNullOrEmpty(word))
        {
          // on ne prend pas les espaces blancs ni les mots déjà trouvés
          continue;
        }

        if (Helper.IsOnlyNumbers(isNewWord.Trim()) || Helper.IsOnlyNumbers(isNewWord.TrimEnd(Punctuation.Period)) || Helper.IsOnlyNumbers(isNewWord.TrimEnd(Punctuation.Comma)) || Helper.IsOnlyNumbers(isNewWord.TrimEnd(Punctuation.SemiColon)))
        {
          // on ne prend pas les nombres
          continue;
        }

        // remove whatever is wrong
        isNewWord = Helper.RemoveFirstCharacterIfNeeded(isNewWord);
        isNewWord = Helper.RemoveLastCharacterIfNeeded(isNewWord);
        isNewWord = Helper.FirstCharacterToLowerCase(isNewWord);
        if (isNewWord.Contains(Punctuation.Period))
        {
          onlyOneWord = false;
          var tmpWord = isNewWord;
          isNewWord = isNewWord.Split(Punctuation.Period)[FirstElement];
          isNewWord2 = tmpWord.Split(Punctuation.Period)[SecondElement];
        }

        if (isNewWord.Contains("\r\n"))
        {
          onlyOneWord = false;
          isNewWord = isNewWord.Replace("\r\n", " ");
          var tmpWord = isNewWord;
          isNewWord = isNewWord.Split(Punctuation.Space)[FirstElement];
          isNewWord2 = tmpWord.Split(Punctuation.Space)[SecondElement];
          isNewWord2 = Helper.RemoveFirstCharacterIfNeeded(isNewWord2);
        }

        if (!onlyOneWord && !string.IsNullOrEmpty(isNewWord2))
        {
          result.Add(isNewWord2);
        }

        result.Add(isNewWord);
      }

      return result;
    }

    /// <summary>
    /// Met à jour l'affichage du nombre de mots dans un contrôle Label
    /// </summary>
    /// <param name="theLabel">Le contrôle Label à mettre à jour</param>
    /// <param name="theListBox">La ListBox contenant les mots à compter</param>
    private void CountWords(Label theLabel, ListBox theListBox)
    {
      theLabel.Text = $"Count: {theListBox.Items.Count}";
    }

    /// <summary>
    /// Gère l'événement de clic sur le bouton Supprimer
    /// </summary>
    private void ButtonDelete_Click(object sender, EventArgs e)
    {
      int selectWordIndex = listBoxWords.SelectedIndex;
      if (listBoxWords.SelectedIndex != -1)
      {
        listBoxWords.Items.RemoveAt(selectWordIndex);
        // select the next item if possible
        if (listBoxWords.Items.Count > 0)
        {
          listBoxWords.SelectedIndex = selectWordIndex;
        }

        CountWords(labelCountWords, listBoxWords);
      }
    }

    /// <summary>
    /// Gère l'événement de clic sur le bouton Charger
    /// </summary>
    private void ButtonLoad_Click(object sender, EventArgs e)
    {
      listBoxGeneralDico.Items.Clear();
      //listBoxGeneralDico.Items.AddRange(ReadFile("Dictionaries\\French.txt"));
      var allWords = Helper.ReadFile("Dictionaries\\French.txt");
      foreach (string word in allWords)
      {
        listBoxGeneralDico.Items.Add(word);
      }

      CountWords(labelGeneralCount, listBoxGeneralDico);
    }

    /// <summary>
    /// Gère l'événement de clic sur le bouton Enregistrer
    /// </summary>
    private void ButtonSave_Click(object sender, EventArgs e)
    {
      if (listBoxGeneralDico.Items.Count > 0)
      {
        var listOfWords = new List<string>();
        foreach (string word in listBoxGeneralDico.Items)
        {
          listOfWords.Add(word);
        }

        listOfWords.Sort();
        if (WriteFile("Dictionaries\\French.txt", listOfWords))
        {
          MessageBox.Show("Sauvegarde ok");
        }
        else
        {
          MessageBox.Show("Sauvegarde ko");
        }
      }
    }

    /// <summary>
    /// Écrit une liste de chaînes dans un fichier
    /// </summary>
    /// <param name="filename">Le chemin du fichier de destination</param>
    /// <param name="items">La liste des chaînes à écrire</param>
    /// <returns>True si l'opération a réussi, False sinon</returns>
    private bool WriteFile(string filename, List<string> items)
    {
      bool result = false;
      try
      {
        using (StreamWriter sw = new StreamWriter(filename, false))
        {
          foreach (var word in items)
          {
            sw.WriteLine(word);
          }

          result = true;
        }
      }
      catch (Exception)
      {
        result = false;
      }

      return result;
    }

    /// <summary>
    /// Gère l'événement de clic sur le bouton Copier
    /// </summary>
    private void ButtonCopy_Click(object sender, EventArgs e)
    {
      foreach (string word in listBoxWords.Items)
      {
        if (!listBoxGeneralDico.Items.Contains(word))
        {
          listBoxGeneralDico.Items.Add(word);
        }
      }

      CountWords(labelGeneralCount, listBoxGeneralDico);
    }

    /// <summary>
    /// Gère l'événement de chargement du formulaire
    /// </summary>
    private void FormMain_Load(object sender, EventArgs e)
    {
      GetWindowValue();
      DisplayTitle();
      LoadLanguages();
      SetLanguage(Settings.Default.LastLanguageUsed);
      LoadLanguageDictionaries();
      ListBoxWords_SelectedIndexChanged(sender, e);
    }

    /// <summary>
    /// Charge les dictionnaires de langues disponibles
    /// </summary>
    private void LoadLanguageDictionaries()
    {
      comboBoxLanguages.Items.Clear();
      comboBoxLanguages.Items.Add("French");
      comboBoxLanguages.SelectedIndex = 0;
      comboBoxLanguages.Items.Add("English");
      comboBoxLanguages.Items.Add("Latin");
    }

    /// <summary>
    /// Enregistre les paramètres de la fenêtre
    /// </summary>
    private void SaveWindowValue()
    {
      Settings.Default.WindowHeight = Height;
      Settings.Default.WindowWidth = Width;
      Settings.Default.WindowLeft = Left;
      Settings.Default.WindowTop = Top;
      //Settings.Default.LastLanguageUsed = frenchToolStripMenuItem.Checked ? "French" : "English";
      Settings.Default.textBoxSource = textBoxSource.Text;
      Settings.Default.Save();
    }

    /// <summary>
    /// Récupère les paramètres de la fenêtre
    /// </summary>
    private void GetWindowValue()
    {
      Width = Settings.Default.WindowWidth;
      Height = Settings.Default.WindowHeight;
      Top = Settings.Default.WindowTop < 0 ? 0 : Settings.Default.WindowTop;
      Left = Settings.Default.WindowLeft < 0 ? 0 : Settings.Default.WindowLeft;
      textBoxSource.Text = Settings.Default.textBoxSource;
    }

    /// <summary>
    /// Gère l'événement de fermeture du formulaire
    /// </summary>
    private void FormMain_FormClosed(object sender, FormClosedEventArgs e)
    {
      SaveWindowValue();
    }

    /// <summary>
    /// Affiche le titre de la fenêtre avec la version de l'application
    /// </summary>
    private void DisplayTitle()
    {
      Text += GetApplicationVersion();
    }

    /// <summary>
    /// Obtient la version de l'application
    /// </summary>
    /// <returns>La version de l'application au format "Vx.y.z.w"</returns>
    private string GetApplicationVersion()
    {
      Assembly assembly = Assembly.GetExecutingAssembly();
      FileVersionInfo fvi = FileVersionInfo.GetVersionInfo(assembly.Location);
      return string.Format(" V{0}.{1}.{2}.{3}", fvi.FileMajorPart, fvi.FileMinorPart, fvi.FileBuildPart, fvi.FilePrivatePart);
    }

    /// <summary>
    /// Gère le changement de langue vers le français
    /// </summary>
    private void FrenchToolStripMenuItem_Click(object sender, EventArgs e)
    {
      SetLanguage(nameof(Language.French));
    }

    /// <summary>
    /// Gère le changement de langue vers l'anglais
    /// </summary>
    private void EnglishToolStripMenuItem_Click(object sender, EventArgs e)
    {
      SetLanguage(nameof(Language.English));
    }

    /// <summary>
    /// Définit la langue de l'interface
    /// </summary>
    /// <param name="myLanguage">La langue à utiliser ("French" ou "English")</param>
    private void SetLanguage(string myLanguage)
    {
      switch (myLanguage)
      {
        case "English":
          //frenchToolStripMenuItem.Checked = false;
          //englishToolStripMenuItem.Checked = true;
          //fileToolStripMenuItem.Text = languageDicoEn["MenuFile"];
          //newToolStripMenuItem.Text = languageDicoEn["MenuFileNew"];
          //openToolStripMenuItem.Text = languageDicoEn["MenuFileOpen"];
          //saveToolStripMenuItem.Text = languageDicoEn["MenuFileSave"];
          //saveasToolStripMenuItem.Text = languageDicoEn["MenuFileSaveAs"];
          //printPreviewToolStripMenuItem.Text = languageDicoEn["MenuFilePrint"];
          //printPreviewToolStripMenuItem.Text = languageDicoEn["MenufilePageSetup"];
          //quitToolStripMenuItem.Text = languageDicoEn["MenufileQuit"];
          //editToolStripMenuItem.Text = languageDicoEn["MenuEdit"];
          //cancelToolStripMenuItem.Text = languageDicoEn["MenuEditCancel"];
          //redoToolStripMenuItem.Text = languageDicoEn["MenuEditRedo"];
          //cutToolStripMenuItem.Text = languageDicoEn["MenuEditCut"];
          //copyToolStripMenuItem.Text = languageDicoEn["MenuEditCopy"];
          //pasteToolStripMenuItem.Text = languageDicoEn["MenuEditPaste"];
          //selectAllToolStripMenuItem.Text = languageDicoEn["MenuEditSelectAll"];
          //toolsToolStripMenuItem.Text = languageDicoEn["MenuTools"];
          //personalizeToolStripMenuItem.Text = languageDicoEn["MenuToolsCustomize"];
          //optionsToolStripMenuItem.Text = languageDicoEn["MenuToolsOptions"];
          //languagetoolStripMenuItem.Text = languageDicoEn["MenuLanguage"];
          //englishToolStripMenuItem.Text = languageDicoEn["MenuLanguageEnglish"];
          //frenchToolStripMenuItem.Text = languageDicoEn["MenuLanguageFrench"];
          //helpToolStripMenuItem.Text = languageDicoEn["MenuHelp"];
          //summaryToolStripMenuItem.Text = languageDicoEn["MenuHelpSummary"];
          //indexToolStripMenuItem.Text = languageDicoEn["MenuHelpIndex"];
          //searchToolStripMenuItem.Text = languageDicoEn["MenuHelpSearch"];
          //aboutToolStripMenuItem.Text = languageDicoEn["MenuHelpAbout"];

          break;
        case "French":
          //frenchToolStripMenuItem.Checked = true;
          //englishToolStripMenuItem.Checked = false;
          //fileToolStripMenuItem.Text = languageDicoFr["MenuFile"];
          //newToolStripMenuItem.Text = languageDicoFr["MenuFileNew"];
          //openToolStripMenuItem.Text = languageDicoFr["MenuFileOpen"];
          //saveToolStripMenuItem.Text = languageDicoFr["MenuFileSave"];
          //saveasToolStripMenuItem.Text = languageDicoFr["MenuFileSaveAs"];
          //printPreviewToolStripMenuItem.Text = languageDicoFr["MenuFilePrint"];
          //printPreviewToolStripMenuItem.Text = languageDicoFr["MenufilePageSetup"];
          //quitToolStripMenuItem.Text = languageDicoFr["MenufileQuit"];
          //editToolStripMenuItem.Text = languageDicoFr["MenuEdit"];
          //cancelToolStripMenuItem.Text = languageDicoFr["MenuEditCancel"];
          //redoToolStripMenuItem.Text = languageDicoFr["MenuEditRedo"];
          //cutToolStripMenuItem.Text = languageDicoFr["MenuEditCut"];
          //copyToolStripMenuItem.Text = languageDicoFr["MenuEditCopy"];
          //pasteToolStripMenuItem.Text = languageDicoFr["MenuEditPaste"];
          //selectAllToolStripMenuItem.Text = languageDicoFr["MenuEditSelectAll"];
          //toolsToolStripMenuItem.Text = languageDicoFr["MenuTools"];
          //personalizeToolStripMenuItem.Text = languageDicoFr["MenuToolsCustomize"];
          //optionsToolStripMenuItem.Text = languageDicoFr["MenuToolsOptions"];
          //languagetoolStripMenuItem.Text = languageDicoFr["MenuLanguage"];
          //englishToolStripMenuItem.Text = languageDicoFr["MenuLanguageEnglish"];
          //frenchToolStripMenuItem.Text = languageDicoFr["MenuLanguageFrench"];
          //helpToolStripMenuItem.Text = languageDicoFr["MenuHelp"];
          //summaryToolStripMenuItem.Text = languageDicoFr["MenuHelpSummary"];
          //indexToolStripMenuItem.Text = languageDicoFr["MenuHelpIndex"];
          //searchToolStripMenuItem.Text = languageDicoFr["MenuHelpSearch"];
          //aboutToolStripMenuItem.Text = languageDicoFr["MenuHelpAbout"];

          break;

      }
    }

    /// <summary>
    /// Énumération des langues disponibles
    /// </summary>
    public enum Language
    {
      /// <summary>
      /// Langue française
      /// </summary>
      French,
      
      /// <summary>
      /// Langue anglaise
      /// </summary>
      English
    }

    /// <summary>
    /// Charge les fichiers de langue
    /// </summary>
    private void LoadLanguages()
    {
      if (!File.Exists(Settings.Default.LanguageFileName))
      {
        CreateLanguageFile();
      }

      // read the translation file and feed the language
      XDocument xDoc = XDocument.Load(Settings.Default.LanguageFileName);
      var result = from node in xDoc.Descendants("term")
                   where node.HasElements
                   let xElementName = node.Element("name")
                   where xElementName != null
                   let xElementEnglish = node.Element("englishValue")
                   where xElementEnglish != null
                   let xElementFrench = node.Element("frenchValue")
                   where xElementFrench != null
                   select new
                   {
                     name = xElementName.Value,
                     englishValue = xElementEnglish.Value,
                     frenchValue = xElementFrench.Value
                   };
      foreach (var i in result)
      {
        languageDicoEn.Add(i.name, i.englishValue);
        languageDicoFr.Add(i.name, i.frenchValue);
      }
    }

    /// <summary>
    /// Crée le fichier de langue par défaut s'il n'existe pas
    /// </summary>
    private static void CreateLanguageFile()
    {
      List<string> minimumVersion = new List<string>
      {
        "<?xml version=\"1.0\" encoding=\"utf - 8\" ?>",
        "<Document>",
        "<DocumentVersion>",
        "<version> 1.0 </version>",
        "</DocumentVersion>",
        "<terms>",
         "<term>",
        "<name>MenuFile</name>",
        "<englishValue>File</englishValue>",
        "<frenchValue>Fichier</frenchValue>",
        "</term>",
        "  </terms>",
        "</Document>"
      };
      StreamWriter sw = new StreamWriter(Settings.Default.LanguageFileName);
      foreach (string item in minimumVersion)
      {
        sw.WriteLine(item);
      }

      sw.Close();
    }

    /// <summary>
    /// Supprime les doublons dans la liste des mots
    /// </summary>
    private void ButtonRemoveDuplicate_Click(object sender, EventArgs e)
    {
      var dicoWords = new Dictionary<string, string>();
      foreach (string word in listBoxWords.Items)
      {
        if (!dicoWords.ContainsKey(word))
        {
          dicoWords.Add(word, word);
        }
      }

      listBoxWords.Items.Clear();
      foreach (var word in dicoWords)
      {
        listBoxWords.Items.Add(word.Key);
      }

      CountWords(labelCountWords, listBoxWords);
    }

    /// <summary>
    /// Supprime un mot du dictionnaire général
    /// </summary>
    private void ButtonDeleteWordsGeneralDico_Click(object sender, EventArgs e)
    {
      if (listBoxGeneralDico.SelectedIndex != -1)
      {
        listBoxGeneralDico.Items.RemoveAt(listBoxGeneralDico.SelectedIndex);
        CountWords(labelGeneralCount, listBoxGeneralDico);
      }
    }

    /// <summary>
    /// Supprime les doublons dans le dictionnaire général
    /// </summary>
    private void ButtonRemoveDuplicateGeneralDico_Click(object sender, EventArgs e)
    {
      var dicoWords = new Dictionary<string, string>();
      foreach (string word in listBoxGeneralDico.Items)
      {
        if (!dicoWords.ContainsKey(word))
        {
          dicoWords.Add(word, word);
        }
      }

      listBoxGeneralDico.Items.Clear();
      foreach (var word in dicoWords)
      {
        listBoxGeneralDico.Items.Add(word.Key);
      }

      CountWords(labelGeneralCount, listBoxGeneralDico);
    }

    /// <summary>
    /// Compte le nombre de nouveaux mots à ajouter au dictionnaire général
    /// </summary>
    private void ButtonCountNewWords_Click(object sender, EventArgs e)
    {
      int newWords = 0;
      foreach (var item in listBoxWords.Items)
      {
        if (!listBoxGeneralDico.Items.Contains(item.ToString()))
        {
          newWords++;
        }
      }

      if (newWords == 0)
      {
        MessageBox.Show("There is no new word to be added.");
      }
      else
      {
        MessageBox.Show($"There is {newWords} new words to be added to the general list.");
      }
    }

    /// <summary>
    /// Gère la sélection d'un mot dans la liste des mots
    /// </summary>
    private void ListBoxWords_SelectedIndexChanged(object sender, EventArgs e)
    {
      buttonCountNewWords.Enabled = listBoxWords.Items.Count > 0;
      buttonProperNouns.Enabled = listBoxWords.Items.Count > 0; ;
    }

    /// <summary>
    /// Efface le contenu de la zone de texte source
    /// </summary>
    private void ButtonClearSource_Click(object sender, EventArgs e)
    {
      textBoxSource.Text = string.Empty;
      buttonClearSource.Enabled = false;
    }

    /// <summary>
    /// Met à jour le nombre de mots dans la zone de texte source
    /// </summary>
    private void TextBoxSource_TextChanged(object sender, EventArgs e)
    {
      buttonClearSource.Enabled = textBoxSource.Text != string.Empty;
      if (textBoxSource.Text != string.Empty)
      {
        labelCountSourceWords.Text = $"Number of words: {textBoxSource.Text.Split(Punctuation.Space).Count()}";
      }
      else
      {
        labelCountSourceWords.Text = "Number of words: 0";
      }
    }

    /// <summary>
    /// Ajoute un mot à la liste des noms propres
    /// </summary>
    private void ButtonProperNouns_Click(object sender, EventArgs e)
    {
      
      if (!File.Exists(ProperNounFilename))
      {
        try
        {
          File.Create(ProperNounFilename);
        }
        catch (Exception exception)
        {
          MessageBox.Show($"There was an error while trying to create the file {ProperNounFilename}. The error is: {exception.Message}");
          return;
        }
      }

      if (listBoxWords.SelectedIndex == -1)
      {
        MessageBox.Show("You have to choose an item first");
        return;
      }

      // add word only if it is not already in
      var exceptionWords = Helper.ReadFile(ProperNounFilename).ToList();
      string word = listBoxWords.SelectedItem.ToString();
      // word should be cleaned of carriage return before inserting into a file
      word = Helper.RemoveCarriageReturnPrefix(word);
      if (!exceptionWords.Contains(word))
      {
        if (!Helper.AddWordTofile(ProperNounFilename, word))
        {
          MessageBox.Show($"The word: {listBoxWords.SelectedItem} could not be inserted into the file : {ProperNounFilename}");
          return;
        }
      }

      listBoxWords.Items.RemoveAt(listBoxWords.SelectedIndex);
    }

    /// <summary>
    /// Copie un mot dans la zone de texte source
    /// </summary>
    private void ButtonCopyWord_Click(object sender, EventArgs e)
    {
      if (listBoxWords.SelectedIndex == -1)
      {
        MessageBox.Show("Please select a word first");
        return;
      }

      textBoxSource.Text += $" {listBoxWords.SelectedItem} "; 
    }

    /// <summary>
    /// Met un mot en minuscule
    /// </summary>
    private void ButtonToLowerCase_Click(object sender, EventArgs e)
    {
      if (listBoxWords.SelectedIndex == -1)
      {
        MessageBox.Show("Please select a word first");
        return;
      }

      var word = listBoxWords.SelectedItem.ToString().ToLower();
      listBoxWords.Items.RemoveAt(listBoxWords.SelectedIndex);
      listBoxWords.Items.Add(word);
      CountWords(labelCountWords, listBoxWords);
      ListBoxWords_SelectedIndexChanged(sender, e);

    }

    /// <summary>
    /// Gère le changement de sélection dans la ComboBox des langues
    /// </summary>
    private void ComboBoxLanguages_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (comboBoxLanguages.SelectedItem != null)
      {
        string selectedLanguage = comboBoxLanguages.SelectedItem.ToString();
        SetLanguage(selectedLanguage);
      }
    }
  }
}
