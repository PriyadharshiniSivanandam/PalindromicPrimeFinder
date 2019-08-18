using System;

namespace PalindromicPrimeFinderLogic
{
  /// <summary>
  /// Helper class for the logic to find Palindromic Prime.
  /// </summary>
  public class PalindromicPrimeFinderHelper : IPalindromicPrimeFinderHelper
  {
     public int Converter(int value, char[] baseChars)
    {
      string result = string.Empty;
      int targetBase = baseChars.Length;

      do
      {
        result = baseChars[value % targetBase] + result;
        value = value / targetBase;
      } while (value > 0);

      return Convert.ToInt32(result);
    }

    public bool IsPalindrome(int number, string numberSystem)
    {
      number = ConvertToBase(number, numberSystem);
      int temp = number, sum = 0;
      while (number > 0)
      {
        int remainder = number % 10;
        number = number / 10;
        sum = sum * 10 + remainder;
      }

      return temp == sum;
    }

    public bool IsPrime(int number)
    {
      bool isPrime = true;
      for (int i = 2; i <= number / 2; i++)
      {
        if (number % i == 0)
        {
          isPrime = false;
          break;
        }
      }

      return isPrime && number != 1;
    }

    public int ConvertToBase(int number, string numberSystem)
    {
      switch (numberSystem)
      {
        case "Binary":
          return Converter(number, new char[] { '0', '1' });

        case "Decimal":
          return number;

        default:
          throw new ArgumentOutOfRangeException("Unknown NumberSystem");
      }
    }
  }
}
