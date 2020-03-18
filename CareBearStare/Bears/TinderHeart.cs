using System;
using System.Collections.Generic;
using System.Text;

namespace CareBearStare.Bears
{
    class TinderHeart : CareBearBase
    {
        public TinderHeart()
        {
            Name = "Tinder Heart";
            BellyBadge = "Cell Phone";
            Color = BearColors.Gold;
        }

        public override void Stare()
        {
            Console.WriteLine("Swipes Left");
        }

        public override void Hug(CareBearBase careBearToHug)
        {
            Console.WriteLine($"Swipes right on {careBearToHug.Name}.");
        }
    }
}
