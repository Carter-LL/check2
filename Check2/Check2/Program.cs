using Check2.Objects;
using Newtonsoft.Json;
using System.Text.Json.Nodes;

namespace Check2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many records do you want to add? ");
            var numberOfRecords = int.Parse(Console.ReadLine());

            var recordList = new List<Grocery>();
            for (int i = 0; i < numberOfRecords; i++)
            {
                // In this loop, populate the object's properties using Console.ReadLine()
                var myClass = new Grocery();

                Console.WriteLine("Enter the value for FoodColor");
                myClass.FoodColor = Console.ReadLine();

                recordList.Add(myClass);

                Console.WriteLine(JsonConvert.SerializeObject(recordList));
            }
        }
    }
}
