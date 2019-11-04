namespace _02._Point_in_rectangle
{
    public class Rectangle
    {
        public Point Topleft { get; set; }
        public Point BottomRight { get; set; }

        public Rectangle(Point topLeft, Point bottomRight)
        {
            Topleft = topLeft;
            BottomRight = bottomRight;
        }
        public bool Contains(Point point)
        {
            bool insideByX = point.CoordinateX >= Topleft.CoordinateX
                && point.CoordinateX <= BottomRight.CoordinateX;

            bool insideByY = point.CoordinateY >= Topleft.CoordinateY
                && point.CoordinateY <= BottomRight.CoordinateY;

            return insideByX && insideByY;
        }
    }
}
