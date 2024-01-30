using System;
using System.IO;

namespace HelperLibrary
{
  public static class Helper
  {
    public static string FirstCharacterToLowerCase(string word)
    {
      if (string.IsNullOrEmpty(word))
      {
        return string.Empty;
      }

      char firstLetter = word[0];
      var verification = $"{firstLetter.ToString().ToLower()}{word.Substring(1, word.Length - 1)}";
      return verification;
    }

    public static string RemoveLastCharacterIfNeeded(string word)
    {
      var result = word;
      var firstForbiddenCharacter = new char[] { '!', ',', ';', ':', '»' };
      foreach (char item in firstForbiddenCharacter)
      {
        if (word.EndsWith(item.ToString()))
        {
          result = word.Substring(0, word.Length - 1);
        }
      }

      return result;
    }

    public static string RemoveFirstCharacterIfNeeded(string word)
    {
      var result = word;
      var firstForbiddenCharacter = new char[] { '(', '«' };
      foreach (char item in firstForbiddenCharacter)
      {
        if (word.StartsWith(item.ToString()))
        {
          result = word.Substring(1, word.Length - 1);
        }
      }

      if (result.StartsWith("(") || result.StartsWith("«"))
      {
        result = Helper.RemoveFirstCharacterIfNeeded(result);
      }

      return result;
    }

    public static bool AddWordTofile(string filename, string word)
    {
      var result = false;
      try
      {
        using (StreamWriter sr = new StreamWriter(filename, true))
        {
          sr.WriteLine(word);
        }

        result = true;
      }
      catch (Exception)
      {
        result |= false;  
      }

      return result;
    }

    public static string RemoveCarriageReturnPrefix(string word)
    {
      return word.Replace("\r\n", "");
    }
  }
}
