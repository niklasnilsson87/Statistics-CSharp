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
      ErrorCheck(source);

      dynamic obj = new {
        Maximum = Statistics.Maximum(source),
        Minimum = Statistics.Minimum(source),
        Mean = Statistics.Mean(source),
        Range = Statistics.Range(source),
        Median = Statistics.Median(source),
        StandardDeviation = Statistics.StandardDeviation(source),
        Mode = string.Join(" & ", Statistics.Mode(source))
      };
    
      return $"\n Maximum           :  {obj.Maximum}\n Minimum           :  {obj.Minimum}\n Medelvärde        :  {obj.Mean:f1}\n Median            :  {obj.Median}\n "
      + $"Typvärde          :  {obj.Mode}\n Variationsbredd   :  {obj.Range}\n Standardavikelse  :  {obj.StandardDeviation:f1}\n";
    }

    static int Maximum(int[] source)
    {
      ErrorCheck(source);

      return source.Max();
    }

    static int Minimum(int[] source)
    {
      ErrorCheck(source);

      return source.Min();
    }

    static double Mean(int[] source)
    {
      ErrorCheck(source);

      return (double)source.Sum() / source.Length;
    }

    static int Range(int[] source)
    {
      ErrorCheck(source);

      return Maximum(source) - Minimum(source);
    }

    static double Median(int[] source)
    {
      ErrorCheck(source);

       Array.Sort(source);

       int halfLength = source.Length / 2;

      
       return (source.Length % 2 == 0) ? (source[halfLength - 1] + source[halfLength]) / 2 : source[(source.Length - 1) / 2];
    }

    static double StandardDeviation(int[] source)
    {
      ErrorCheck(source);

      double mean = Mean(source);

      double result = source.Select(x => (x - mean) * (x - mean)).Sum();

      return Math.Sqrt(result / source.Length);
    }

    static int[] Mode(int[] source)
    {
      ErrorCheck(source);

      int maxNumber = 0;

      Array.Sort(source);

      Dictionary<int, int> counts = new Dictionary<int, int>();
      List<int> modes = new List<int>();
            
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

    private static int[] ErrorCheck(int[] source)
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