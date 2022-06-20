using System;
using System.Linq;
using System.Collections.Generic;
namespace PracticeLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> videoGameNames = new List<string>
            {
                "Fallout", "Animal Crossing", "Rocket League", "Legend of Zelda",
            };
            
            //Int32 length = videoGameNames.Count;

            //IEnumerable<string> longvideoGameNames = videoGameNames.Where(name => name.Contains("d"));

            foreach (var i in videoGameNames)
            {
                Console.WriteLine(i);
            }
        }
    }
}
