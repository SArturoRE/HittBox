using System;
namespace hitbox2
{
    public class Punto
    {
        double cx, cy;
        public Punto()
        {
            cx = 0;
            cy = 0;
        }

        public double X
        {
            get { return cx; }
            set { cx = value; }
        }
        public double Y
        {
            get { return cy; }
            set { cy = value; }
        }
    }
}
