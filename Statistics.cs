using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Dynamic;

namespace examination_1
{
  class Statistics
  {
    public static dynamic DescriptiveStatistics(int[] source)
    {
      dynamic obj = new {
        Maximum = Statistics.Maximum(source),
        Minimum = Statistics.Minimum(source),
        Mean = $"{Statistics.Mean(source):f1}",
        Range = Statistics.Range(source),
        Median = Statistics.Median(source),
        StandardDeviation = Statistics.StandardDeviation(source),
        Mode = string.Join(", ", Statistics.Mode(source))
      };
    
      return obj;
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

    public static int[] Mode(int[] source)
    {
      Array.Sort(source);

      Dictionary<int, int> counts = new Dictionary<int, int>();
            int maxNumber = 0;
            List<int> modes = new List<int>();
            // int modes = new int();
            
            for (int i = 0; i < source.Length; i++)
            {
                if (counts.ContainsKey(source[i]))
                {
                    counts[source[i]]++;
                }
                else 
                {
                    counts[source[i]] = 1;
                }

                if (counts[source[i]] > maxNumber)
                {
                    modes.Clear();
                    modes.Add(source[i]);
                    maxNumber = counts[source[i]];
                } else if (counts[source[i]] == maxNumber)
                {
                    modes.Add(source[i]);
                    maxNumber = counts[source[i]];
                }
            }

            return modes.ToArray();
    }
  }
}