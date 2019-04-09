using System;
using System.IO;
using Newtonsoft.Json;

namespace examination_1
{
    /// <summary>
    /// Represents the main place where the program starts the execution.
    /// </summary>
    class Program
    {
        /// <summary>
        /// The starting point of the application.
        /// </summary>
        /// <param name="args">not in use</param>
        static void Main(string[] args)
        {
            try 
            {

            string json = File.ReadAllText("data.json");
            int[] numbers = JsonConvert.DeserializeObject<int[]>(json);

            dynamic result = Statistics.DescriptiveStatistics(numbers);
            Console.Write(result);

            } catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
