using System;
using System.Collections.Generic;
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
        if (!newWords.Contains(word))
        {
          newWords.Add(word);
        }
      }


    }
  }
}
