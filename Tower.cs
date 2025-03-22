using System;

namespace BackToBasicsC_
{
    internal class Tower
    {
        private readonly MapLocation _location;

        private const int _range = 1;

        private const int _power = 1;

        private const double _accuracy = .75;

        private static readonly Random _random = new Random();

        public Tower(MapLocation location)
        {
            _location = location;
        }

        public bool IsSuccessfulShot()
        {
            return _random.NextDouble() < _accuracy;
        }

        public void ShootOnInvaders(Invader[] invaders)
        {
            foreach (Invader invader in invaders)
            {
                if (invader.IsActive && _location.InRangOf(invader.Location, _range))
                {
                    if (IsSuccessfulShot())
                    {
                        Console.WriteLine("Tower has shot at an invader!");
                        invader.DecreaseHealth(_power);
                        if (invader.IsNeutralized)
                        {
                            Console.WriteLine("Neutralized an invader");
                        }

                    }
                    else { Console.WriteLine("Tower has missed!"); }
                    break;
                }
            }
        }
    }
}
