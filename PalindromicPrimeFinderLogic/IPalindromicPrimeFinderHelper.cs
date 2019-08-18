namespace PalindromicPrimeFinderLogic
{
  /// <summary>
  /// Interface for the helper class for the logic to find Palindromic Prime.
  /// </summary>
  public interface IPalindromicPrimeFinderHelper
  {
    bool IsPalindrome(int number, string numberSystem);
    bool IsPrime(int number);
  }
}
