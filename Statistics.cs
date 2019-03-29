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
  }
}