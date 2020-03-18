using System;
using System.Collections.Generic;
using System.Text;

namespace CareBearStare.Bears
{
    

    public abstract class CareBearBase
    {
        public BearColors Color { get; protected set; }
        public string BellyBadge { get; protected set; }
        public string Name { get; protected set; }
        public string Emotion { get; set; }

        public abstract void Stare();

        public void Care(string humanToCareFor)
        {
            Console.WriteLine($"{Name} cares deeply for {humanToCareFor}.");
        }

        public virtual void Hug(CareBearBase careBearToHug)
        {
            Console.WriteLine($"{Name} runs over to {careBearToHug.Name} and squeezes them, pressing their " +
                $"{BellyBadge} and {careBearToHug.BellyBadge} together.");
        }
    }

}
