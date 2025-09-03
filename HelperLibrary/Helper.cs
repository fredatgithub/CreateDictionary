using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace HelperLibrary
{
  /// <summary>
  /// Classe utilitaire fournissant des méthodes d'aide pour la manipulation de chaînes et de fichiers.
  /// </summary>
  public static class Helper
  {
    /// <summary>
    /// Convertit le premier caractère d'une chaîne en minuscule.
    /// </summary>
    /// <param name="word">La chaîne à traiter.</param>
    /// <returns>La chaîne avec le premier caractère en minuscule, ou une chaîne vide si l'entrée est nulle ou vide.</returns>
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

    /// <summary>
    /// Supprime le dernier caractère d'une chaîne s'il fait partie des caractères interdits.
    /// </summary>
    /// <param name="word">La chaîne à traiter.</param>
    /// <returns>La chaîne traitée avec le dernier caractère supprimé si nécessaire.</returns>
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

    /// <summary>
    /// Supprime le premier caractère d'une chaîne s'il fait partie des caractères interdits.
    /// La méthode est appelée récursivement tant que le premier caractère est interdit.
    /// </summary>
    /// <param name="word">La chaîne à traiter.</param>
    /// <returns>La chaîne traitée avec le premier caractère supprimé si nécessaire.</returns>
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

    /// <summary>
    /// Ajoute un mot à un fichier.
    /// </summary>
    /// <param name="filename">Le chemin du fichier dans lequel écrire.</param>
    /// <param name="word">Le mot à ajouter au fichier.</param>
    /// <returns>True si l'opération a réussi, False sinon.</returns>
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

    /// <summary>
    /// Supprime les retours à la ligne d'une chaîne.
    /// </summary>
    /// <param name="word">La chaîne à traiter.</param>
    /// <returns>La chaîne sans les retours à la ligne.</returns>
    public static string RemoveCarriageReturnPrefix(string word)
    {
      return word.Replace("\r\n", "");
    }

    /// <summary>
    /// Filtre une liste de mots en supprimant ceux qui figurent dans un fichier d'exception.
    /// </summary>
    /// <param name="newWords">La liste des mots à filtrer.</param>
    /// <param name="filename">Le chemin du fichier contenant les mots à exclure.</param>
    /// <returns>Une nouvelle liste contenant uniquement les mots qui ne figurent pas dans le fichier d'exception.</returns>
    public static List<string> RemoveExceptionWords(List<string> newWords, string filename)
    {
      var result = new List<string>();
      var exceptionWords = ReadFile(filename);
      result = newWords.Except(exceptionWords).ToList();
      return result;
    }

    /// <summary>
    /// Lit un fichier texte et retourne son contenu sous forme de liste de chaînes.
    /// </summary>
    /// <param name="filename">Le chemin du fichier à lire.</param>
    /// <returns>Une liste des lignes du fichier, ou une liste vide en cas d'erreur.</returns>
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
        // En cas d'erreur, on retourne une liste vide
      }

      return result;
    }

    /// <summary>
    /// Vérifie si une chaîne ne contient que des chiffres.
    /// </summary>
    /// <param name="word">La chaîne à vérifier.</param>
    /// <returns>True si la chaîne ne contient que des chiffres, False sinon ou si la chaîne est nulle/vide.</returns>
    public static bool IsOnlyNumbers(string word)
    {
      if (string.IsNullOrEmpty(word))
      {
        return false;
      }

      var result = true;
      foreach (char c in word)
      {
        if (!char.IsDigit(c))
        {
          result = false;
          break;
        }
      }

      return result;
    }
  }
}
