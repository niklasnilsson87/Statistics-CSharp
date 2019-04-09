using System;

namespace examination_1
{
  /// <summary>
  /// Represents the Error class
  /// </summary>
  static class Error
  {
    /// <summary>
    ///   Checks for Errors an throws exeptions.
    /// </summary>
    /// <param name="source">Array of integers</param>
    /// <returns>Array of numbers if it passes the checks.</returns>
    public static int[] ErrorCheck(int[] source)
    {

      if (source == null)
      {
        throw new ArgumentNullException();
      }
      else if (source.Length == 0)
      {
        throw new InvalidOperationException("Sequence contains no elements");
      }

      return source;
    }
  }
}