namespace TreehouseDefense
{
  class MapLocation : Point
  {
    public MapLocation(int x, int y, Map map) : base(x, y)
    {
      if (!map.OnMap(this))
      {
        thow new System.Exception();
      }

    }
  }
}
