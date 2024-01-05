using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace CreateDictionary
{
  public partial class FormMain : Form
  {
    public FormMain()
    {
      InitializeComponent();
    }

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
      return word.ToLower().Trim().Replace(".", "").Replace(",", "");
    }

    private void ButtonDelete_Click(object sender, EventArgs e)
    {
      if (listBoxWords.SelectedIndex != -1)
      {
        listBoxWords.Items.RemoveAt(listBoxWords.SelectedIndex);
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
  }
}
