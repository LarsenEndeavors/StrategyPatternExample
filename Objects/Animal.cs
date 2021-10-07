using System;

namespace StrategyPatternExample.Objects
{
    public class Animal
    {
        public string Name { get; set; }
        public double Height { get; set; }
        private int _Weight { get; set; }
        public int Weight
        {
            get => _Weight;
            set
            {
                if (value > 0)
                {
                    _Weight = value;
                }
                else
                {
                    Console.WriteLine("Weight must be bigger than 0");
                }
            }
        }

        public string FavoriteFood { get; set; }
        public double Speed { get; set; }
        public string Sound { get; set; }

        // Implementing the interface allows for dynamic selection of methods at runtime
        public Flies FlyingType { get; set; }

        public string tryToFly()
        {
            return FlyingType.Fly();
        }
    }
}