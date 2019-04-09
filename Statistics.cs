using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Dynamic;

namespace examination_1
{
  /// <summary>
  /// Represent the Statistic Class
  /// </summary>
  static class Statistics
  {
    /// <summary>
    /// Method that presents the counted values.
    /// </summary>
    /// <param name="source">Array of integers</param>
    /// <returns>A dynamic string.</returns>
    public static dynamic DescriptiveStatistics(int[] source)
    {
      Error.ErrorCheck(source);

      dynamic obj = new {
        Maximum = Statistics.Maximum(source),
        Minimum = Statistics.Minimum(source),
        Mean = Statistics.Mean(source),
        Range = Statistics.Range(source),
        Median = Statistics.Median(source),
        StandardDeviation = Statistics.StandardDeviation(source),
        Mode = Statistics.Mode(source)
      };
    
      return $"\n Maximum           :  {obj.Maximum}\n Minimum           :  {obj.Minimum}\n Medelvärde        :  {obj.Mean:f1}\n Median            :  {obj.Median}\n "
      + $"Typvärde          :  {string.Join(" & ", obj.Mode)}\n Variationsbredd   :  {obj.Range}\n Standardavikelse  :  {obj.StandardDeviation:f1}\n";
    }

    /// <summary>
    /// Method returns the max value in the array
    /// </summary>
    /// <param name="source">Array of integers</param>
    /// <returns>The max value in the array</returns>
    static int Maximum(int[] source)
    {
      Error.ErrorCheck(source);

      return source.Max();
    }

    /// <summary>
    /// Method returns the minimum value in the array
    /// </summary>
    /// <param name="source">Array of integers</param>
    /// <returns>The minimum value in the array</returns>
    static int Minimum(int[] source)
    {
      Error.ErrorCheck(source);

      return source.Min();
    }

    /// <summary>
    /// Method returns the mean value of the array
    /// </summary>
    /// <param name="source">Array of integers</param>
    /// <returns>The mean value in the array</returns>
    static double Mean(int[] source)
    {
      Error.ErrorCheck(source);

      return (double)source.Sum() / source.Length;
    }

    /// <summary>
    /// Method returns the Range value in the array
    /// </summary>
    /// <param name="source">Array of integers</param>
    /// <returns>The Range in the array</returns>
    static int Range(int[] source)
    {
      Error.ErrorCheck(source);

      return Maximum(source) - Minimum(source);
    }

    /// <summary>
    /// Method calculates the median value of the array
    /// </summary>
    /// <param name="source">Array of integers</param>
    /// <returns>The median value of the array</returns>
    static double Median(int[] source)
    {
      Error.ErrorCheck(source);

       Array.Sort(source);

       int halfLength = source.Length / 2;

      
       return (source.Length % 2 == 0) ? (source[halfLength - 1] + source[halfLength]) / 2 : source[(source.Length - 1) / 2];
    }

    /// <summary>
    /// Method calculates the StandardDeviations of the array
    /// </summary>
    /// <param name="source">Array of integers</param>
    /// <returns>The standarddeviation of the array</returns>
    static double StandardDeviation(int[] source)
    {
      Error.ErrorCheck(source);

      double mean = Mean(source);

      double result = source.Select(x => (x - mean) * (x - mean)).Sum();

      return Math.Sqrt(result / source.Length);
    }

    /// <summary>
    /// Method calculates the mode value of the array.
    /// </summary>
    /// <param name="source">Array of integers</param>
    /// <returns>The mode value of the array</returns>
    static int[] Mode(int[] source)
    {
      Error.ErrorCheck(source);

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
  }
}