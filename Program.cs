using System;
using System.IO;
using Newtonsoft.Json;
using System.Linq;
using System.Dynamic;
using System.Collections.Generic;

namespace examination_1
{
    class Program
    {
        static void Main(string[] args)
        {
            try 
            {

            int[] value1 = {4, 8, 2, 4, 5};
            int[] value2 = {4, 2, 6, 1, 3, 7, 5, 3, 7};
            int[] value3 = {5, 1, 1, 1, 3, -2, 2, 5, 7, 4, 5, 16};


            // string json = File.ReadAllText("data.json");
            // int[] numbers = JsonConvert.DeserializeObject<int[]>(json);

            dynamic result = Statistics.DescriptiveStatistics(value1);
            Console.Write(result);

            } catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
