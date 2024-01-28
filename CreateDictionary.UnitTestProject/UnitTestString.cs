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
      string input = "A";
      string result = Helper.FirstCharacterToLowerCase(input);
      Assert.AreEqual("a", result);
    }

    [TestMethod]
    public void FirstCharacterToLowerCase_MixedCaseString_ReturnsStringWithFirstCharacterInLowerCase()
    {
      string input = "Hello";
      string result = Helper.FirstCharacterToLowerCase(input);
      Assert.AreEqual("hello", result);
    }

    [TestMethod]
    public void FirstCharacterToLowerCase_AllUppercaseString_ReturnsStringWithFirstCharacterInLowerCase()
    {
      string input = "WORLD";
      string result = Helper.FirstCharacterToLowerCase(input);
      Assert.AreEqual("wORLD", result);
    }

    [TestMethod]
    public void RemoveLastCharacterIfNeeded_NoForbiddenCharacter_ReturnsSameString()
    {
      string input = "Hello";
      string result = Helper.RemoveLastCharacterIfNeeded(input);
      Assert.AreEqual("Hello", result);
    }

    [TestMethod]
    public void RemoveLastCharacterIfNeeded_EndsWithExclamationMark_ReturnsStringWithoutExclamationMark()
    {
      string input = "Hello!";
      string result = Helper.RemoveLastCharacterIfNeeded(input);
      Assert.AreEqual("Hello", result);
    }

    [TestMethod]
    public void RemoveLastCharacterIfNeeded_EndsWithComma_ReturnsStringWithoutComma()
    {
      string input = "Hello,";
      string result = Helper.RemoveLastCharacterIfNeeded(input);
      Assert.AreEqual("Hello", result);
    }

    [TestMethod]
    public void RemoveLastCharacterIfNeeded_EndsWithSemicolon_ReturnsStringWithoutSemicolon()
    {
      string input = "Hello;";
      string result = Helper.RemoveLastCharacterIfNeeded(input);
      Assert.AreEqual("Hello", result);
    }

    [TestMethod]
    public void RemoveLastCharacterIfNeeded_EndsWithColon_ReturnsStringWithoutColon()
    {
      string input = "Hello:";
      string result = Helper.RemoveLastCharacterIfNeeded(input);
      Assert.AreEqual("Hello", result);
    }

    [TestMethod]
    public void RemoveLastCharacterIfNeeded_EndsWithDoubleAngleQuotes_ReturnsStringWithoutDoubleAngleQuotes()
    {
      string input = "Hello»";
      string result = Helper.RemoveLastCharacterIfNeeded(input);
      Assert.AreEqual("Hello", result);
    }

    [TestMethod]
    public void RemoveLastCharacterIfNeeded_EndsWithMultipleForbiddenCharacters_ReturnsStringWithoutLastCharacter()
    {
      string input = "Hello!;";
      string result = Helper.RemoveLastCharacterIfNeeded(input);
      Assert.AreEqual("Hello!", result);
    }

    [TestMethod]
    public void RemoveFirstCharacterIfNeeded_NoForbiddenCharacter_ReturnsSameString()
    {
      string input = "Hello";
      string result = Helper.RemoveFirstCharacterIfNeeded(input);
      Assert.AreEqual("Hello", result);
    }

    [TestMethod]
    public void RemoveFirstCharacterIfNeeded_StartsWithOpeningParenthesis_ReturnsStringWithoutOpeningParenthesis()
    {
      string input = "(Hello";
      string result = Helper.RemoveFirstCharacterIfNeeded(input);
      Assert.AreEqual("Hello", result);
    }

    [TestMethod]
    public void RemoveFirstCharacterIfNeeded_StartsWithDoubleAngleQuotes_ReturnsStringWithoutDoubleAngleQuotes()
    {
      string input = "«Hello";
      string result = Helper.RemoveFirstCharacterIfNeeded(input);
      Assert.AreEqual("Hello", result);
    }

    [TestMethod]
    public void RemoveFirstCharacterIfNeeded_StartsWithMultipleForbiddenCharacters_ReturnsStringWithoutFirstCharacter()
    {
      string input = "(«Hello";
      string result = Helper.RemoveFirstCharacterIfNeeded(input);
      Assert.AreEqual("Hello", result);
    }

    [TestMethod]
    public void RemoveFirstCharacterIfNeeded_StartsWithOpeningParenthesisAndDoubleAngleQuotes_ReturnsStringWithoutOpeningParenthesis()
    {
      string input = "(«Hello";
      string result = Helper.RemoveFirstCharacterIfNeeded(input);
      Assert.AreEqual("Hello", result);
    }
  }
}
