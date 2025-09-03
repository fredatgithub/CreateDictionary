using Microsoft.VisualStudio.TestTools.UnitTesting;
using HelperLibrary;

namespace CreateDictionary.UnitTestProject
{
  [TestClass]
  public class UnitTestString
  {
    [TestMethod]
    public void FirstCharacterToLowerCase_EmptyString_ReturnsEmptyString()
    {
      string input = string.Empty;
      string result = Helper.FirstCharacterToLowerCase(input);
      Assert.AreEqual(string.Empty, result);
    }

    [TestMethod]
    public void FirstCharacterToLowerCase_SingleCharacterString_ReturnsLowercaseCharacter()
    {
      const string input = "A";
      string result = Helper.FirstCharacterToLowerCase(input);
      Assert.AreEqual("a", result);
    }

    [TestMethod]
    public void FirstCharacterToLowerCase_MixedCaseString_ReturnsStringWithFirstCharacterInLowerCase()
    {
      const string input = "Hello";
      string result = Helper.FirstCharacterToLowerCase(input);
      Assert.AreEqual("hello", result);
    }

    [TestMethod]
    public void FirstCharacterToLowerCase_AllUppercaseString_ReturnsStringWithFirstCharacterInLowerCase()
    {
      const string input = "WORLD";
      string result = Helper.FirstCharacterToLowerCase(input);
      Assert.AreEqual("wORLD", result);
    }

    [TestMethod]
    public void RemoveLastCharacterIfNeeded_NoForbiddenCharacter_ReturnsSameString()
    {
      const string input = "Hello";
      string result = Helper.RemoveLastCharacterIfNeeded(input);
      Assert.AreEqual("Hello", result);
    }

    [TestMethod]
    public void RemoveLastCharacterIfNeeded_EndsWithExclamationMark_ReturnsStringWithoutExclamationMark()
    {
      const string input = "Hello!";
      string result = Helper.RemoveLastCharacterIfNeeded(input);
      Assert.AreEqual("Hello", result);
    }

    [TestMethod]
    public void RemoveLastCharacterIfNeeded_EndsWithComma_ReturnsStringWithoutComma()
    {
      const string input = "Hello,";
      string result = Helper.RemoveLastCharacterIfNeeded(input);
      Assert.AreEqual("Hello", result);
    }

    [TestMethod]
    public void RemoveLastCharacterIfNeeded_EndsWithSemicolon_ReturnsStringWithoutSemicolon()
    {
      const string input = "Hello;";
      string result = Helper.RemoveLastCharacterIfNeeded(input);
      Assert.AreEqual("Hello", result);
    }

    [TestMethod]
    public void RemoveLastCharacterIfNeeded_EndsWithColon_ReturnsStringWithoutColon()
    {
      const string input = "Hello:";
      string result = Helper.RemoveLastCharacterIfNeeded(input);
      Assert.AreEqual("Hello", result);
    }

    [TestMethod]
    public void RemoveLastCharacterIfNeeded_EndsWithDoubleAngleQuotes_ReturnsStringWithoutDoubleAngleQuotes()
    {
      const string input = "Hello»";
      string result = Helper.RemoveLastCharacterIfNeeded(input);
      Assert.AreEqual("Hello", result);
    }

    [TestMethod]
    public void RemoveLastCharacterIfNeeded_EndsWithMultipleForbiddenCharacters_ReturnsStringWithoutLastCharacter()
    {
      const string input = "Hello!;";
      string result = Helper.RemoveLastCharacterIfNeeded(input);
      Assert.AreEqual("Hello!", result);
    }

    [TestMethod]
    public void RemoveFirstCharacterIfNeeded_NoForbiddenCharacter_ReturnsSameString()
    {
      const string input = "Hello";
      string result = Helper.RemoveFirstCharacterIfNeeded(input);
      Assert.AreEqual("Hello", result);
    }

    [TestMethod]
    public void RemoveFirstCharacterIfNeeded_StartsWithOpeningParenthesis_ReturnsStringWithoutOpeningParenthesis()
    {
      const string input = "(Hello";
      string result = Helper.RemoveFirstCharacterIfNeeded(input);
      Assert.AreEqual("Hello", result);
    }

    [TestMethod]
    public void RemoveFirstCharacterIfNeeded_StartsWithDoubleAngleQuotes_ReturnsStringWithoutDoubleAngleQuotes()
    {
      const string input = "«Hello";
      string result = Helper.RemoveFirstCharacterIfNeeded(input);
      Assert.AreEqual("Hello", result);
    }

    [TestMethod]
    public void RemoveFirstCharacterIfNeeded_StartsWithMultipleForbiddenCharacters_ReturnsStringWithoutFirstCharacter()
    {
      const string input = "(«Hello";
      string result = Helper.RemoveFirstCharacterIfNeeded(input);
      Assert.AreEqual("Hello", result);
    }

    [TestMethod]
    public void RemoveFirstCharacterIfNeeded_StartsWithOpeningParenthesisAndDoubleAngleQuotes_ReturnsStringWithoutOpeningParenthesis()
    {
      const string input = "(«Hello";
      string result = Helper.RemoveFirstCharacterIfNeeded(input);
      Assert.AreEqual("Hello", result);
    }

    [TestMethod]
    public void IsOnlyNumbers_EmptyString_ReturnsFalse()
    {
      string input = string.Empty;
      bool result = Helper.IsOnlyNumbers(input);
      Assert.IsFalse(result);
    }

    [TestMethod]
    public void IsOnlyNumbers_NumbersOnly_ReturnsTrue()
    {
      string input = "12345";
      bool result = Helper.IsOnlyNumbers(input);
      Assert.IsTrue(result);
    }

    [TestMethod]
    public void IsOnlyNumbers_LettersOnly_ReturnsFalse()
    {
      string input = "abcde";
      bool result = Helper.IsOnlyNumbers(input);
      Assert.IsFalse(result);
    }

    [TestMethod]
    public void IsOnlyNumbers_SpecialCharacters_ReturnsFalse()
    {
      string input = "!@#$%^";
      bool result = Helper.IsOnlyNumbers(input);
      Assert.IsFalse(result);
    }

    [TestMethod]
    public void IsOnlyNumbers_WithSpaces_ReturnsFalse()
    {
      string input = "123 456";
      bool result = Helper.IsOnlyNumbers(input);
      Assert.IsFalse(result);
    }

    [TestMethod]
    public void IsOnlyNumbers_NumbersAndLetters_ReturnsFalse()
    {
      string input = "123abc";
      bool result = Helper.IsOnlyNumbers(input);
      Assert.IsFalse(result);
    }

    [TestMethod]
    public void IsOnlyNumbers_NumbersAndSpecialChars_ReturnsFalse()
    {
      string input = "123!@#";
      bool result = Helper.IsOnlyNumbers(input);
      Assert.IsFalse(result);
    }

    [TestMethod]
    public void IsOnlyNumbers_NullInput_ReturnsFalse()
    {
      string input = null;
      bool result = Helper.IsOnlyNumbers(input);
      Assert.IsFalse(result);
    }
  }
}
