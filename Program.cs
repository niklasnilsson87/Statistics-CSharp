using System;
using System.IO;
using Newtonsoft.Json;


namespace examination_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // int[] numbers;
            // using (var reader = File.OpenText("data.json"))
            // {
            // var serilazier = new JsonSerializer();
            // numbers = (int[])serilazier.Deserialize(reader, typeof(int[]));
            // }

            // string temp = string.Join(", ", numbers);
            // int[] test = Parse(temp);
            var json = File.ReadAllText("data.json");
            var numbers = JsonConvert.DeserializeObject<int[]>(json);

            int numbersMax = Statistics.Maximum(numbers);
            int numbersMin = Statistics.Minimum(numbers);
            double numbersMean = Statistics.Mean(numbers);
            double numbersRange = Statistics.Range(numbers);
            double numbersMedian = Statistics.Median(numbers);
            double numbersDeviation = Statistics.StandardDeviation(numbers);
            Console.WriteLine(numbersMax);
            Console.WriteLine(numbersMin);
            Console.WriteLine($"{numbersMean:f1}");
            Console.WriteLine(numbersRange);
            Console.WriteLine(numbersMedian);
            Console.WriteLine(numbersDeviation);
        }
    }
}
