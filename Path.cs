﻿namespace BackToBasicsC_
{
    internal class Path
    {
        private readonly MapLocation[] _path;

        public Path(MapLocation[] path)
        {
            _path = path;
        }

        public MapLocation getLocationAt(int index)
        {
            if (index < _path.Length)
            {
                return _path[index];
            }
            else { return null; }

        }
    }
}
