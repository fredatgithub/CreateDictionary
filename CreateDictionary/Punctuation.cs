/*
The MIT License(MIT)
Copyright(c) 2015-2025 Freddy Juhel
Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:
The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.
THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.
*/
using System;
using System.Text;

namespace Tools
{
  /// <summary>
  /// Provides commonly used punctuation characters and string manipulation utilities.
  /// This class contains constants for various punctuation marks and helper methods for string operations.
  /// </summary>
  public static class Punctuation
  {
    /// <summary>String containing a single space character</summary>
    public const string OneSpace = " ";
    
    /// <summary>Space character (' ')</summary>
    public const char Space = ' ';
    
    /// <summary>Comma character (',')</summary>
    public const char Comma = ',';
    
    /// <summary>Colon character (':')</summary>
    public const char Colon = ':';
    
    /// <summary>Semicolon character (';')</summary>
    public const char SemiColon = ';';
    
    /// <summary>Underscore character ('_')</summary>
    public const char UnderScore = '_';
    
    /// <summary>At sign ('@')</summary>
    public const char SignAt = '@';
    
    /// <summary>Ampersand character ('&')</summary>
    public const char Ampersand = '&';
    
    /// <summary>Number sign ('#')</summary>
    public const char SignSharp = '#';
    
    /// <summary>Period character ('.')</summary>
    public const char Period = '.';
    
    /// <summary>Dot character ('.') - Alias for Period</summary>
    public const char Dot = '.';
    
    /// <summary>Backslash character ('\')</summary>
    public const char Backslash = '\\';
    
    /// <summary>Forward slash character ('/')</summary>
    public const char Slash = '/';
    
    /// <summary>Opening parenthesis ('(')</summary>
    public const char OpenParenthesis = '(';
    
    /// <summary>Closing parenthesis (')')</summary>
    public const char CloseParenthesis = ')';
    
    /// <summary>Opening curly brace ('{')</summary>
    public const char OpenCurlyBrace = '{';
    
    /// <summary>Closing curly brace ('}')</summary>
    public const char CloseCurlyBrace = '}';
    
    /// <summary>Opening square bracket ('[')</summary>
    public const char OpeningBracket = '[';
    
    /// <summary>Closing square bracket (']')</summary>
    public const char ClosingBracket = ']';
    
    /// <summary>Less-than sign ('<')</summary>
    public const char LessThan = '<';
    
    /// <summary>Greater-than sign ('>')</summary>
    public const char GreaterThan = '>';
    
    /// <summary>Double quote ('"')</summary>
    public const char DoubleQuote = '\"';
    
    /// <summary>Single quote (''')</summary>
    public const char SimpleQuote = '\'';
    
    /// <summary>Tilde ('~')</summary>
    public const char Tilde = '~';
    
    /// <summary>Vertical bar ('|')</summary>
    public const char Pipe = '|';
    
    /// <summary>Plus sign ('+')</summary>
    public const char Plus = '+';
    
    /// <summary>Minus sign ('-')</summary>
    public const char Minus = '-';
    
    /// <summary>Dash ('-') - Alias for Minus</summary>
    public const char Dash = '-';
    
    /// <summary>Asterisk ('*')</summary>
    public const char Multiply = '*';
    
    /// <summary>Star ('*') - Alias for Multiply</summary>
    public const char Star = '*';
    
    /// <summary>Division sign ('/')</summary>
    public const char Divide = '/';
    
    /// <summary>Equals sign ('=')</summary>
    public const char Equal = '=';
    
    /// <summary>Dollar sign ('$')</summary>
    public const char Dollar = '$';
    
    /// <summary>Pound sign ('£')</summary>
    public const char Pound = '£';
    
    /// <summary>Percent sign ('%')</summary>
    public const char Percent = '%';
    
    /// <summary>Question mark ('?')</summary>
    public const char QuestionMark = '?';
    
    /// <summary>Exclamation mark ('!')</summary>
    public const char ExclamationPoint = '!';
    
    /// <summary>Section sign ('§')</summary>
    public const char Chapter = '§';
    
    /// <summary>Micro sign ('µ')</summary>
    public const char Micro = 'µ';
    
    /// <summary>Registered trademark symbol ('®')</summary>
    public const char Copyright = '®';
    
    /// <summary>Environment's newline string</summary>
    public static string CrLf = Environment.NewLine;

    /// <summary>
    /// Creates a string of spaces with the specified number of tabulations
    /// </summary>
    /// <param name="numberOfTabulation">Number of spaces to generate (default is 1)</param>
    /// <returns>A string containing the specified number of spaces</returns>
    public static string Tabulate(ushort numberOfTabulation = 1)
    {
      string result = string.Empty;
      for (int number = 0; number < numberOfTabulation; number++)
      {
        result += " ";
      }

      return result;
    }

    /// <summary>
    /// Concatenates an array of strings into a single string
    /// </summary>
    /// <param name="listOfCharacters">Array of strings to concatenate</param>
    /// <returns>Concatenated string</returns>
    public static string CreateSentence(params string[] listOfCharacters)
    {
      StringBuilder result = new StringBuilder();
      foreach (string character in listOfCharacters)
      {
        result.Append(character);
      }

      return result.ToString();
    }

    /// <summary>
    /// Concatenates an array of PunctuationChar values into a single string
    /// </summary>
    /// <param name="listOfCharacters">Array of PunctuationChar values to concatenate</param>
    /// <returns>Concatenated string</returns>
    public static string CreateSentence(params PunctuationChar[] listOfCharacters)
    {
      StringBuilder result = new StringBuilder();
      foreach (var character in listOfCharacters)
      {
        result.Append(character);
      }

      return result.ToString();
    }

    /// <summary>
    /// Enumerates punctuation characters and their corresponding ASCII values
    /// </summary>
    public enum PunctuationChar
    {
      /// <summary>Comma (',')</summary>
      Comma = 44,
      /// <summary>Colon (':')</summary>
      Colon = 58,
      /// <summary>Semicolon (';')</summary>
      SemiColon = 59,
      /// <summary>Space (' ')</summary>
      OneSpace = 32,
      /// <summary>Underscore ('_')</summary>
      UnderScore = 95,
      /// <summary>At sign ('@')</summary>
      SignAt = 64,
      /// <summary>Ampersand ('&')</summary>
      Ampersand = 38,
      /// <summary>Number sign ('#')</summary>
      SignSharp = 35,
      /// <summary>Pound sign ('£')</summary>
      SignNumber = 163,
      /// <summary>Period ('.')</summary>
      Period = 46,
      /// <summary>Dot ('.') - Alias for Period</summary>
      Dot = 46,
      /// <summary>Backslash ('\')</summary>
      Backslash = 92,
      /// <summary>Opening parenthesis ('(')</summary>
      OpenParenthesis = 40,
      /// <summary>Closing parenthesis (')')</summary>
      CloseParenthesis = 41,
      /// <summary>Opening curly brace ('{')</summary>
      OpenCurlyBrace = 123,
      /// <summary>Opening brace ('{') - Alias for OpenCurlyBrace</summary>
      OpeningBrace = 123,
      /// <summary>Closing curly brace ('}')</summary>
      CloseCurlyBrace = 125,
      /// <summary>Closing brace ('}') - Alias for CloseCurlyBrace</summary>
      ClosingBrace = 125,
      /// <summary>Opening square bracket ('[')</summary>
      OpeningBracket = 91,
      /// <summary>Closing square bracket (']')</summary>
      ClosingBracket = 93,
      /// <summary>Less-than sign ('<')</summary>
      LessThan = 60,
      /// <summary>Greater-than sign ('>')</summary>
      GreaterThan = 62,
      /// <summary>Double quote ('"')</summary>
      DoubleQuote = 34,
      /// <summary>Single quote (''')</summary>
      SimpleQuote = 39,
      /// <summary>Tilde ('~')</summary>
      Tilde = 126,
      /// <summary>Caret ('^')</summary>
      Caret = 94,
      /// <summary>Circumflex ('^') - Alias for Caret</summary>
      Circumflex = 94,
      /// <summary>Vertical bar ('|')</summary>
      Pipe = 124,
      /// <summary>Vertical bar ('|') - Alias for Pipe</summary>
      VerticalBar = 124,
      /// <summary>Plus sign ('+')</summary>
      Plus = 43,
      /// <summary>Minus sign ('-')</summary>
      Dash = 45,
      /// <summary>Minus sign ('-') - Alias for Dash</summary>
      Minus = 45,
      /// <summary>Asterisk ('*')</summary>
      Multiply = 42,
      /// <summary>Star ('*') - Alias for Multiply</summary>
      Star = 42,
      /// <summary>Multiply sign ('×')</summary>
      SignMultiply = 215,
      /// <summary>Forward slash ('/')</summary>
      Slash = 47,
      /// <summary>Division sign ('/')</summary>
      Divide = 47,
      /// <summary>Division sign ('÷')</summary>
      SignDivision = 247,
      /// <summary>Equals sign ('=')</summary>
      Equal = 61,
      /// <summary>Dollar sign ('$')</summary>
      Dollar = 36,
      /// <summary>Pound sign ('£')</summary>
      Pound = 163,
      /// <summary>Yen sign ('¥')</summary>
      SignYen = 165,
      /// <summary>Percent sign ('%')</summary>
      Percent = 37,
      /// <summary>Question mark ('?')</summary>
      QuestionMark = 63,
      /// <summary>Exclamation mark ('!')</summary>
      ExclamationPoint = 33,
      /// <summary>Section sign ('§')</summary>
      Chapter = 167,
      /// <summary>Section sign ('§') - Alias for Chapter</summary>
      Section = 167,
      /// <summary>Registered trademark symbol ('®')</summary>
      Copyright = 169,
      /// <summary>Micro sign ('µ')</summary>
      Micro = 181,
      /// <summary>Left double angle quotes ('«')</summary>
      LeftDoubleAngleQuotes = 171,
      /// <summary>Right double angle quotes ('»')</summary>
      RightDoubleAngleQuotes = 187,
      /// <summary>Left single quotation mark ('‘')</summary>
      LeftSingleQuotationMark = 8216,
      /// <summary>Right single quotation mark ('’')</summary>
      RightSingleQuotationMark = 8217,
      /// <summary>Left double quotation mark ('“')</summary>
      LeftDoubleQuotationMark = 8220,
      /// <summary>Right double quotation mark ('”')</summary>
      RightdoubleQuotationMark = 8221,
      /// <summary>Trademark sign ('™')</summary>
      SignTradeMark = 8482,
      /// <summary>Euro sign ('€')</summary>
      SignEuro = 8364,
      /// <summary>Newline character</summary>
      CrLf = 0,
      /// <summary>Newline character - Alias for CrLf</summary>
      NewLine = 0
    }
    
    /// <summary>
    /// Returns a space if the language is French, otherwise returns an empty string
    /// </summary>
    /// <param name="language">Language to check (default is "english")</param>
    /// <returns>Space if language is French, otherwise empty string</returns>
    public static string SpaceIfFrench(string language = "english")
    {
      return language.ToLower() == "french" ? OneSpace : string.Empty;
    }
    
    /// <summary>
    /// Returns the plural form of a noun based on the number and language
    /// </summary>
    /// <param name="number">Number to determine plural form</param>
    /// <param name="irregularNoun">Irregular noun to handle special cases (default is empty string)</param>
    /// <returns>Plural form of the noun</returns>
    public static string Plural(int number, string irregularNoun = "")
    {
      switch (irregularNoun)
      {
        case "":
          return number > 1 ? "s" : string.Empty;
        case "al":
          return number > 1 ? "aux" : "al";
        case "au":
          return number > 1 ? "aux" : "au";
        case "eau":
          return number > 1 ? "eaux" : "eau";
        case "eu":
          return number > 1 ? "eux" : "eu";
        case "landau":
          return number > 1 ? "landaus" : "landau";
        case "sarrau":
          return number > 1 ? "sarraus" : "sarrau";
        case "bleu":
          return number > 1 ? "bleus" : "bleu";
        case "émeu":
          return number > 1 ? "émeus" : "émeu";
        case "lieu":
          return number > 1 ? "lieux" : "lieu";
        case "pneu":
          return number > 1 ? "pneus" : "pneu";
        case "aval":
          return number > 1 ? "avals" : "aval";
        case "bal":
          return number > 1 ? "bals" : "bal";
        case "chacal":
          return number > 1 ? "chacals" : "chacal";
        case "carnaval":
          return number > 1 ? "carnavals" : "carnaval";
        case "festival":
          return number > 1 ? "festivals" : "festival";
        case "récital":
          return number > 1 ? "récitals" : "récital";
        case "régal":
          return number > 1 ? "régals" : "régal";
        case "cal":
          return number > 1 ? "cals" : "cal";
        case "serval":
          return number > 1 ? "servals" : "serval";
        case "choral":
          return number > 1 ? "chorals" : "choral";
        case "narval":
          return number > 1 ? "narvals" : "narval";
        case "bail":
          return number > 1 ? "baux" : "bail";
        case "corail":
          return number > 1 ? "coraux" : "corail";
        case "émail":
          return number > 1 ? "émaux" : "émail";
        case "soupirail":
          return number > 1 ? "soupiraux" : "soupirail";
        case "travail":
          return number > 1 ? "travaux" : "travail";
        case "vantail":
          return number > 1 ? "vantaux" : "vantail";
        case "vitrail":
          return number > 1 ? "vitraux" : "vitrail";
        case "bijou":
          return number > 1 ? "bijoux" : "bijou";
        case "caillou":
          return number > 1 ? "cailloux" : "caillou";
        case "chou":
          return number > 1 ? "choux" : "chou";
        case "genou":
          return number > 1 ? "genoux" : "genou";
        case "hibou":
          return number > 1 ? "hiboux" : "hibou";
        case "joujou":
          return number > 1 ? "joujoux" : "joujou";
        case "pou":
          return number > 1 ? "poux" : "pou";
        case "est":
          return number > 1 ? "sont" : "est";

        // English
        case " is":
          return number > 1 ? "s are" : " is"; // with a space before
        case "is":
          return number > 1 ? "are" : "is"; // without a space before
        case "has":
          return number > 1 ? "have" : "has";
        case "The":
          return "The"; // CAPITAL, useful because of French plural
        case "the":
          return "the"; // lower case, useful because of French plural
        default:
          return number > 1 ? "s" : string.Empty;
      }
    }
    
    /// <summary>
    /// Returns the plural form of a noun based on the number and language, specifically for French
    /// </summary>
    /// <param name="number">Number to determine plural form</param>
    /// <param name="currentLanguage">Language to check (default is "english")</param>
    /// <returns>Plural form of the noun if language is French and number is greater than 1</returns>
    public static string FrenchPlural(int number, string currentLanguage = "english")
    {
      return (number > 1 && currentLanguage.ToLower() == "french") ? "s" : string.Empty;
    }
  }
}