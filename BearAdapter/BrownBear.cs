using System;

namespace BearAdapter
{
    public class BrownBear : IBear
    {
        private readonly Random random;
        
        public bool Hibernating { get; private set; }

        public void GoTowards(object objectToWalkTowards)
        {
            if (!Hibernating)
            {
                Console.WriteLine($"The brown bear goes towards the {objectToWalkTowards}.");

                if (random.NextDouble() < 0.2) // 20% chance to start hibernating
                {
                    Hibernating = true;
                    Console.WriteLine("The brown bear has started hibernating.");
                }
            }
        }

        public void LookAt(object objectToLookAt)
        {
            if (!Hibernating)
            {
                Console.WriteLine($"The brown bear looks at the {objectToLookAt}.");
            }
        }

        public void Roar()
        {
            if (Hibernating && random.NextDouble() < 0.4)
            {
                Hibernating = false;
            }

            if (!Hibernating)
            {
                Console.WriteLine("The brown bear roars!");
            }
        }

        public bool TryEat(object objectToEat)
        {
            if (!Hibernating)
            {
                if (random.NextDouble() < 0.7) // 70% chance to successfully eat
                {
                    Console.WriteLine($"The brown bear eats the {objectToEat}.");
                    return true;
                }
                else
                {
                    Console.WriteLine($"The brown bear tries to eat the {objectToEat}, but fails.");
                    return false;
                }
            }
            else
            {
                Console.WriteLine("The brown bear is hibernating and cannot eat.");
                return false;
            }
        }

        public BrownBear()
        {
            random = new Random();
            Hibernating = random.NextDouble() < 0.5; // Randomly set hibernating state with 50% chance
        }
    }
}