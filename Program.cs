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

            Console.WriteLine("Array line : "+ string.Join(",", numbers));
            Console.WriteLine(numbers);
        }
    }
}
