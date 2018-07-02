using System;

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
    }
}