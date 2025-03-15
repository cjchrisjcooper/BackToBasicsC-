using System;

namespace BackToBasicsC_
{
    internal class MapLocation : Point
    {
        public MapLocation(int x, int y, Map map) : base(x, y)
        {
            if (!map.OnMap(this))
            {
                throw new Exception();
            }
        }

        public bool InRangOf(MapLocation location, int range)
        {
            return DistanceTo(location) <= range;
        }
    }
}
