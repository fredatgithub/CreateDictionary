using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

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
      var firstForbiddenCharacters = new char[] { '!', ',', ';', ':', '»', '?' };
      foreach (char item in firstForbiddenCharacters)
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

    public static List<string> RemoveExceptionWords(List<string> newWords, string filename)
    {
      var result = new List<string>();
      // List<car> result = list2.Except(list1).ToList();
      var exceptionWords = ReadFile(filename);
      result = newWords.Except(exceptionWords).ToList();
      return result;
    }

    public static List<string> ReadFile(string filename)
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

      return result;
    }
  }
}
