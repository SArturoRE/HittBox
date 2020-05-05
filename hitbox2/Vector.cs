using System;

namespace hitbox2
{
	
	public class Vector
	{
		double vx, vy, vdis;
		public Vector()
		{
			vx = vy = vdis = 0.0;
		}
		
		public void calcvec(Box a, Box b)
		{
			vx = b.X - a.X;
			vy = b.Y - a.Y;
			
			vdis = Math.Sqrt((vx * vx) + (vy * vy)) - ( a.RetSlab - b.RetSlab);
		}
		
		public double Vd
		{
			get{ return vdis;}
		}
	}
}
