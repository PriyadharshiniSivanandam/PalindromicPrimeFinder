using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PalindromicPrimeFinderLogic.UnitTest
{
  /// <summary>
  /// Test to ensure logic to find Palindromic Prime helper.
  /// </summary>
  [TestClass]
  public class PalindromicPrimeFinderHelperTest
  {
    const string numberSystem = "Decimal";

    [TestMethod]
    public void IsPrime_Prime_True()
    {
      //Arrange
      int input = 19;
      PalindromicPrimeFinderHelper helper = new PalindromicPrimeFinderHelper();

      //Act
      var output = helper.IsPrime(input);

      //Assert
      Assert.AreEqual(true, output);
    }

    [TestMethod]
    public void IsPrime_NotPrime_False()
    {
      //Arrange
      int input = 644;
      PalindromicPrimeFinderHelper helper = new PalindromicPrimeFinderHelper();
      //Act
      var output = helper.IsPrime(input);

      //Assert
      Assert.AreEqual(false, output);
    }

    [TestMethod]
    public void ConvertToBase_Decimal_Decimal()
    {
      //Arrange
      int input = 644;
      PalindromicPrimeFinderHelper helper = new PalindromicPrimeFinderHelper();

      //Act
      var output = helper.ConvertToBase(input, numberSystem);

      //Assert
      Assert.AreEqual(input, output);
    }

    [TestMethod]
    public void ConvertToBase_Decimal_Binary()
    {
      //Arrange
      int input = 15;
      var numSystem = "Binary";
      PalindromicPrimeFinderHelper helper = new PalindromicPrimeFinderHelper();

      //Act
      var output = helper.ConvertToBase(input, numSystem);

      //Assert
      Assert.AreEqual(1111, output);
    }

    [TestMethod]
    public void ConvertToBase_DecimalToHexadecimal_Error()
    {
      //Arrange
      int input = 15;
      PalindromicPrimeFinderHelper helper = new PalindromicPrimeFinderHelper();

      //Act && //Assert
      try
      {
        helper.ConvertToBase(input, "Hexadecimal");
        Assert.Fail("No exception thrown");
      }
      catch (Exception ex)
      {
        Assert.IsTrue(ex is ArgumentOutOfRangeException);
      }
    }

    [TestMethod]
    public void IsPalindrome_Palindrome_True()
    {
      //Arrange
      int input = 717;
      PalindromicPrimeFinderHelper helper = new PalindromicPrimeFinderHelper();

      //Act
      var output = helper.IsPalindrome(input, numberSystem);

      //Assert
      Assert.AreEqual(true, output);
    }

    [TestMethod]
    public void IsPalindrome_NotPalindrome_False()
    {
      //Arrange
      int input = 536;
      PalindromicPrimeFinderHelper helper = new PalindromicPrimeFinderHelper();

      //Act
      var output = helper.IsPalindrome(input, numberSystem);

      //Assert
      Assert.AreEqual(false, output);
    }

    [TestMethod]
    public void Converter_Decimal_Binary()
    {
      //Arrange
      int input = 5;
      char[] baseCharacters = { '0', '1' };
      PalindromicPrimeFinderHelper helper = new PalindromicPrimeFinderHelper();

      //Act
      var output = helper.Converter(input, baseCharacters);

      //Assert
      Assert.AreEqual(101, output);
    }
  }
}
