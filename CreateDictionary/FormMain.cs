﻿using CreateDictionary.Properties;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using System.Xml.Linq;

namespace CreateDictionary
{
  public partial class FormMain : Form
  {
    public FormMain()
    {
      InitializeComponent();
    }

    readonly Dictionary<string, string> languageDicoEn = new Dictionary<string, string>();
    readonly Dictionary<string, string> languageDicoFr = new Dictionary<string, string>();
    private const char space = ' ';
    private const char period = '.';
    private const string quote = "'";
    private const char Apostrophe = '\'';
    private const int FirstElement = 0;
    private const int SecondElement = 1;

    private void QuitToolStripMenuItem_Click(object sender, EventArgs e)
    {
      Application.Exit();
    }

    private void ButtonAdd_Click(object sender, EventArgs e)
    {
      listBoxWords.Items.Clear();
      var newWords = new List<string>();
      foreach (string word in textBoxSource.Text.Split(space))
      {
        var word3 = word.Trim().ToLower();
        if (!newWords.Contains(word3) && !string.IsNullOrEmpty(word3))
        {
          if (word3.Contains(quote))
          {
            string word1 = word3.Split(Apostrophe)[FirstElement] + "'";
            string word2 = word3.Split(Apostrophe)[SecondElement];
            newWords.Add(RemovePunctuation(word1));
            newWords.Add(RemovePunctuation(word2));
          }
          else
          {
            newWords.Add(RemovePunctuation(word3));
          }
        }
      }

      foreach (string word in newWords)
      {
        listBoxWords.Items.Add(word);
      }

      CountWords(labelCountWords, listBoxWords);
    }

    private void CountWords(Label theLabel, ListBox theListBox)
    {
      theLabel.Text = $"Count: {theListBox.Items.Count}";
    }

    private string RemovePunctuation(string word)
    {
      return word.ToLower().Trim().Replace(".", "").Replace(",", "").Trim('"');
    }

    private void ButtonDelete_Click(object sender, EventArgs e)
    {
      if (listBoxWords.SelectedIndex != -1)
      {
        listBoxWords.Items.RemoveAt(listBoxWords.SelectedIndex);
        CountWords(labelCountWords, listBoxWords);
      }
    }

    private void ButtonLoad_Click(object sender, EventArgs e)
    {
      listBoxGeneralDico.Items.Clear();
      listBoxGeneralDico.Items.AddRange(ReadFile("Dictionaries\\French.txt"));
      CountWords(labelGeneralCount, listBoxGeneralDico);
    }

    private string[] ReadFile(string filename)
    {
      var result = new List<string>();
      try
      {
        using (StreamReader sr = new StreamReader(filename))
        {
          while (!sr.EndOfStream)
          {
            result.Add(sr.ReadLine());
          }
        }
      }
      catch (Exception)
      {
      }

      return result.ToArray();
    }

    private void ButtonSave_Click(object sender, EventArgs e)
    {
      if (listBoxGeneralDico.Items.Count > 0)
      {
        var listOfWords = new List<string>();
        foreach (string word in listBoxGeneralDico.Items)
        {
          listOfWords.Add(word);
        }

        if (WriteFile("Dictionaries\\French.txt", listOfWords))
        {
          MessageBox.Show("sauvegarde ok");
        }
        else
        {
          MessageBox.Show("sauvegarde ko");
        }
      }
    }

    private bool WriteFile(string filename, List<string> items)
    {
      bool result = false;
      try
      {
        using (StreamWriter sw = new StreamWriter(filename, true))
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

    private void FormMain_Load(object sender, EventArgs e)
    {
      GetWindowValue();
      DisplayTitle();
      LoadLanguages();
      SetLanguage(Settings.Default.LastLanguageUsed);
    }

    private void SaveWindowValue()
    {
      Settings.Default.WindowHeight = Height;
      Settings.Default.WindowWidth = Width;
      Settings.Default.WindowLeft = Left;
      Settings.Default.WindowTop = Top;
      //Settings.Default.LastLanguageUsed = frenchToolStripMenuItem.Checked ? "French" : "English";
      Settings.Default.Save();
    }

    private void GetWindowValue()
    {
      Width = Settings.Default.WindowWidth;
      Height = Settings.Default.WindowHeight;
      Top = Settings.Default.WindowTop < 0 ? 0 : Settings.Default.WindowTop;
      Left = Settings.Default.WindowLeft < 0 ? 0 : Settings.Default.WindowLeft;
    }

    private void FormMain_FormClosed(object sender, FormClosedEventArgs e)
    {
      SaveWindowValue();
    }

    private void DisplayTitle()
    {
      Text += GetApplicationVersion();
    }

    private string GetApplicationVersion()
    {
      Assembly assembly = Assembly.GetExecutingAssembly();
      FileVersionInfo fvi = FileVersionInfo.GetVersionInfo(assembly.Location);
      return string.Format(" V{0}.{1}.{2}.{3}", fvi.FileMajorPart, fvi.FileMinorPart, fvi.FileBuildPart, fvi.FilePrivatePart);
    }

    private void FrenchToolStripMenuItem_Click(object sender, EventArgs e)
    {
      SetLanguage(Language.French.ToString());
    }

    private void EnglishToolStripMenuItem_Click(object sender, EventArgs e)
    {
      SetLanguage(Language.English.ToString());
    }

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

    public enum Language
    {
      French,
      English
    }

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

    private void ButtonDeleteWordsGeneralDico_Click(object sender, EventArgs e)
    {
      if (listBoxGeneralDico.SelectedIndex != -1)
      {
        listBoxGeneralDico.Items.RemoveAt(listBoxGeneralDico.SelectedIndex);
        CountWords(labelGeneralCount, listBoxGeneralDico);
      }
    }
  }
}
