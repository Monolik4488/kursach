using System.Drawing;


namespace Bedroom.classes.BedroomObjects
{
    public class cable : GraphicElement
    {
        Pen pen = new Pen(Color.Black, 5);
        public cable(Point start, Point end) : base(start, end, "")
        {
            path = null;
        }
        public cable() {}

        public override void draw(Graphics g)
        {
            g.DrawLine(pen, start, end);
        }
    }
}
