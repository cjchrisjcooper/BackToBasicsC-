namespace BackToBasicsC_
{
    internal class Map
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public Map(int width, int height)
        {
            Width = width;
            Height = height;
        }

        public bool OnMap(Point point)
        {

            return point.X >= 0 && point.X < Width && point.Y >= 0 && point.Y < Height;
        }
    }
}
