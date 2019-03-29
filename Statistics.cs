using System;
using System.Linq;

namespace examination_1
{
  class Statistics
  {
    public static dynamic DescriptiveStatistics(int[] source)
    {
      return source;
    }

    public static int Maximum(int[] source)
    {
      return source.Max();
    }

    public static int Minimum(int[] source)
    {
      return source.Min();
    }

    public static double Mean(int[] source)
    {
      return (double)source.Sum() / source.Length;
    }

    public static int Range(int[] source)
    {
      return Maximum(source) - Minimum(source);
    }

    public static double Median(int[] source)
    {
       Array.Sort(source);

       int halfLength = source.Length / 2;

       return (source.Length % 2 == 0) ? (source[halfLength - 1] + source[halfLength]) / 2 : source[(source.Length - 1) / 2];
    }

    public static double StandardDeviation(int[] source)
    {
      double mean = Mean(source);

      // for (int i = 0; i < source.Length; i++)
      // {
      //   double sum = source[i] - mean;
      //   Math.Pow(sum, 2);
      // }
      
      double result = source.Select(x => (x - mean) * (x - mean)).Sum();

      return Math.Sqrt(result / source.Length);
    }
  }
}