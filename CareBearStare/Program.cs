using System;
using System.Collections.Generic;
using System.Linq;
using CareBearStare.Bears;

namespace CareBearStare
{
    class Program
    {
        static void Main(string[] args)
        {
            var definitions = new Dictionary<string, List<string>>();
            definitions.Add("martin", new List<string> { "smart", "strong", "important" });
            Console.WriteLine(string.Join(", ", definitions["martin"].Where(word => word.StartsWith('s'))));

            var grumpyBear = new GrumpyBear();
            var tenderHeart = new TenderHeart();
            var tinderHeart = new TinderHeart();

            var careBears = new List<CareBearBase> { grumpyBear, tenderHeart, tinderHeart };

            foreach (var bear in careBears)
            {
                bear.Care("Nathan");
                bear.Stare();
            }

            var namesThatStartWithT = careBears.Where(bear => bear.Name.StartsWith('T'));
            var careBearNames = careBears.Select(bear => bear.Name);

            var careBearNamesThatStartWithT = careBears
                                             .Where(bear => bear.Name.StartsWith('T'))
                                             .Select(bear => bear.Name);

            var anyTinderHearts = careBears.Any(bear => bear is TinderHeart);  //returns true after first match            //delegates or lambtha expression
            var allTinderHearts = careBears.All(bear => bear is TinderHeart);  // returns true only if every bear matches

            var firstBear = careBears.First(); //empty param passes actualy first or pass an argument
            var firstBearStartingWithTe = careBears.First(bear => bear.Name.StartsWith("Te"));


            var otherList = new List<CareBearBase>();
            //var blowsUp = otherList.First();  // throws an exception because there is no first item in the list
            var doesntBlowUp = otherList.FirstOrDefault(); //outputs null value

            var skipGrumpy = careBears.Skip(1).Take(2); // throws an exception if your list has less than 3 items

            var longestName = careBears.Max(bear => bear.Name.Length);

            var orderBears = careBears.OrderBy(bear => bear.BellyBadge); //orders alphabetically or OrderByDescending for reverse

            //Bedtime Bear, Birthday Bear, Cheer Bear, Friend Bear, Funshine Bear, Good Luck Bear, Grumpy Bear, Love-a-lot Bear, Tenderheart Bear, and Wish Bear

            Console.ReadKey();
;        }
    }
}
