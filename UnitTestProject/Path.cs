using System;
using System.Collections.Generic;

namespace UnitTestProject
{
    public class Path
    {
        private MapLocation[] pathLocations;

        public Path(MapLocation[] pathLocations)
        {
            this.pathLocations = pathLocations;
        }

        public bool IsOnPath(MapLocation mapLocation)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<object> GetLocationAt(int v)
        {
            throw new NotImplementedException();
        }
    }
}