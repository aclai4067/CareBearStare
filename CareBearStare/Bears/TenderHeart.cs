using System;
using System.Collections.Generic;
using System.Text;

namespace CareBearStare.Bears
{
    class TenderHeart : CareBearBase
    {
        public TenderHeart()
        {
            Name = "Tender Heart";
            BellyBadge = "Heart";
            Color = BearColors.Brown;
        }

        public override void Stare()
        {
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine($"{Name} shoots hearts from this belly. ♥♥♥♥♥♥♥♥♥♥♥♥");
            Console.ResetColor();
        }

        public override void Hug(CareBearBase careBearToHug)
        {
            base.Hug(careBearToHug);
        }
    }
}
