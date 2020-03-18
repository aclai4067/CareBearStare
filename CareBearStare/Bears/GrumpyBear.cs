using System;
using System.Collections.Generic;
using System.Text;

namespace CareBearStare.Bears
{
    class GrumpyBear : CareBearBase
    {
        public GrumpyBear()
        {
            Name = "Grumpy Bear";
            BellyBadge = "Rain Cloud";
            Color = BearColors.Blue;
        }
        public override void Stare()
        {
            //throw new NotImplementedException();  use as placeholder before defining method
            Console.WriteLine($"Stares aggressively while shooting a beam from his {BellyBadge}.");
        }

        public override void Hug(CareBearBase careBearToHug)
        {
            Console.WriteLine($"{Name} hates hugs, and shuns {careBearToHug.Name}.");
        }
    }
}
