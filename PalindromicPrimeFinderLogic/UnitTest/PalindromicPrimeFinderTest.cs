using System.Collections.Generic;
using System.Linq;

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PalindromicPrimeFinderLogic.UnitTest
{
  /// <summary>
  /// Test to ensure logic to find Palindromic Prime in given number system.
  /// </summary>
  [TestClass]
  public class PalindromicPrimeFinderLogicTest
  {
    const string numberSystem = "Decimal";
    const int lowerRange = 1;
    const int upperRange = 1000;

    [TestMethod]
    public void GetPalindromicPrime_PalindromicPrime_ExpectedList()
    {
      //Arrange
      PalindromicPrimeFinderHelper helper = new PalindromicPrimeFinderHelper();
      Finder finder = new Finder(numberSystem, lowerRange, upperRange, helper);
      List<int> expectedOutput = new List<int>
        {2, 3, 5, 7, 11, 101, 131, 151, 181, 191, 313, 353, 373, 383, 727, 757, 787, 797, 919, 929};
      //Act
      var output = finder.GetPalindromicPrime();

      //Assert
      Assert.IsTrue(output.SequenceEqual(expectedOutput));
      Assert.AreEqual(20, output.Count);
    }
  }
}
