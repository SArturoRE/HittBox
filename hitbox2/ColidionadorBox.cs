using System;
namespace hitbox2
{
    public class ColidionadorBox
    {
        double x;
        double y;
        Vector calcvec =  new Vector();
        byte[] verde = {0x00, 0xFF, 0xFF};
        byte[] blanco = {0xFF, 0xFF, 0xFF};

        public void ColisionadorBox()
        {
            x = 0;
        }

        public void ChecarColision(Box a, Box[] b)
        {
        	for(int i=0 ; i < b.Length; i++)
        	{
        		
		            x = a.X + a.RetSlab;
		            y = a.Y + a.RetSlab;
		
		            if(!a.HayColisionX)
		            {
		               // a.Mover(1, 0);
		
		                if(x > 600)
		                {
		                    a.HayColisionX = true;
		                }
		                
		                
		            }
		            else
		            {
		                //a.Mover(-1, 0);
		                if (x-(2*a.RetSlab) < 1)
		                {
		                    a.HayColisionX = false;
		                }
		               
		            }
		
		
		            if (!a.HayColisionY)
		            {
		                a.Mover(0, 3);
		
		                if (y > 600)
		                {
		                    a.HayColisionY = true;
		                }
		            }
		            else
		            {
		                a.Mover(0, -3);
		                if (y - (2 * a.RetSlab) < 1)
		                {
		                    a.HayColisionY = false;
		                }
		
		            }
           
			         /*   calcvec.calcvec(a,b[i]);
			           if(!a.HayColisionX)
			           {
			           	//a.Mover(1,0);
			           	
			           	if(calcvec.Vd <= 70 || x > 600)
			           	{
			           		a.HayColisionX = true;
			           		b[i].colorcaja(verde);
			           	}
			           		
			           		
			           }else
			           {
			           //	a.Mover(-1,0);
			           	if(calcvec.Vd != 70 || (x-(2*a.RetSlab) < 10))
			           	{
			           		a.ColCaja = false;
			           		b[i].colorcaja(blanco);
			           	}
			           		
			           }*/
			           		

        	}

        }
        
        public void col2(Box a, Box[] b)
        {
        	for(int i = 0; i < b.Length; i++)
        	{ 
        		
        		calcvec.calcvec(a,b[i]);
	        	x = calcvec.Vd;
	        	if(x < 65)
	        	{
	        		//Console.WriteLine("Colision!!!");
	        		if(a.X < b[i].X)
	        		{
	        			//b.Mover(x * 0.1, 0);
	        			b[i].colorcaja(verde);
	        		}
	        		
	        		if(a.X > b[i].X)
	        		{
	        			//b.Mover(-x * 0.1, 0);
	        			b[i].colorcaja(verde);
	        		}
	        		//b.colorcaja(verde);
	        	}else
	        	{
	        		a.HayColisionX = false;
	        		b[i].colorcaja(blanco);
	        	}
        	}
        	
        }
    }
}