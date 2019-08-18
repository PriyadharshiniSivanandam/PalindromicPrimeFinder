using System;
using System.Collections.Generic;

namespace PalindromicPrimeFinderLogic
{
  /// <summary>
  /// Class to find Palindromic Prime within given range in given number system.
  /// </summary>
  public class Finder
  {
    readonly string numberSystem;
    readonly int lowerRange;
    readonly int upperRange;
    IPalindromicPrimeFinderHelper helper;

    public Finder(string numberSystem, int lowerRange, int upperRange, IPalindromicPrimeFinderHelper helper)
    {
      this.numberSystem = numberSystem;
      this.lowerRange = lowerRange;
      this.upperRange = upperRange;
      this.helper = helper;
    }

    public List<int> GetPalindromicPrime()
    {
      List<int> outputList = new List<int>();
      for (int i = lowerRange; i <= upperRange; i++)
      {
        if (helper.IsPrime(i) && helper.IsPalindrome(i, numberSystem))
        {
          outputList.Add(i);
        }
      }
      return outputList;
    }
  }
}
  