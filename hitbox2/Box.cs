using System;
using OpenTK.Graphics.OpenGL;

namespace hitbox2
{
    public class Box
    {
        Punto centro = new Punto();
        Punto EsqA;
        Punto EsqB;
        Punto EsqC;
        Punto EsqD;
        bool HaycolisionX;
        bool HaycolisionY;
        bool colisioncaja;
        byte[] color = {0xFF, 0xFF, 0xFF};

        double Slab;

        public Box()
        {
            EsqA = new Punto();
            EsqB = new Punto();
            EsqC = new Punto();
            EsqD = new Punto();
            HaycolisionX = false;
            HaycolisionY = false;
            colisioncaja = false;
        }

        public void Datos(double centrox, double centroy, double slab)
        {
            centro.X = centrox;
            centro.Y = centroy;
            Slab = slab;

            EsqA.X = centro.X + Slab;
            EsqA.Y = centro.Y + Slab;

            EsqB.X = centro.X - Slab;
            EsqB.Y = centro.Y + Slab;

            EsqC.X = centro.X - Slab;
            EsqC.Y = centro.Y - Slab;

            EsqD.X = centro.X + Slab;
            EsqD.Y = centro.Y - Slab;


        }

        public void Dibujar()
        {
            GL.Begin(PrimitiveType.LineLoop);
            GL.Color3(color);
            GL.Vertex2(EsqA.X, EsqA.Y);
            GL.Vertex2(EsqB.X, EsqB.Y);
            GL.Vertex2(EsqC.X, EsqC.Y);
            GL.Vertex2(EsqD.X, EsqD.Y);
            GL.End();
        }

        public void Mover(double x, double y)
        {
            centro.X += x;
            centro.Y += y;

            Datos(centro.X, centro.Y, 30);
        }

        public double X
        {
            get { return centro.X; }
        }

        public double Y
        {
            get { return centro.Y; }
        }
        public double RetSlab
        {
            get { return Slab; }
        }

        public bool HayColisionX
        {
            get { return HaycolisionX; }
            set {  HaycolisionX = value; }
        }

        public bool HayColisionY
        {
            get { return HaycolisionY; }
            set { HaycolisionY = value; }
        }
        
        public bool ColCaja
        {
        	get {return colisioncaja;}
        	set {colisioncaja = value;}
        }
        public void colorcaja(byte[] a)
        {
        	color = a;
        }

    }
}
