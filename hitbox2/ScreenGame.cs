using System;
using System.Drawing;
using OpenTK;
using OpenTK.Input;
using OpenTK.Graphics;
using OpenTK.Graphics.OpenGL;

namespace hitbox2
{
    public class ScreenGame : GameWindow
    {
        Box caja = new Box();
        Box[] caja2;
        ColidionadorBox c = new ColidionadorBox();

        public ScreenGame(int x, int y): base(x,y)
        {
        }

        protected override void OnLoad(EventArgs e)
        {
            GL.ClearColor(Color.Gray);
            GL.MatrixMode(MatrixMode.Projection);
            GL.Ortho(0,600,0,600,-1,1);
            caja2 = new Box[4];
            
            caja2[0] = new Box();
            caja2[1] = new Box();
            caja2[2] = new Box();
            caja2[3] = new Box();
            
            
            caja.Datos(300, 300, 30);
            
            caja2[0].Datos(300,550,30);
            caja2[1].Datos(300,50,30);
            caja2[2].Datos(550,300,30);
            caja2[3].Datos(50,300,30);
            
        }

        protected override void OnUpdateFrame(FrameEventArgs e)
        {
            GL.Clear(ClearBufferMask.ColorBufferBit);
        }

        protected override void OnRenderFrame(FrameEventArgs e)
        {
        	caja.Dibujar();
        	caja2[0].Dibujar();
        	caja2[1].Dibujar();
        	caja2[2].Dibujar();
        	caja2[3].Dibujar();
        	//c.ChecarColision(caja, caja2);
        	c.col2(caja,caja2);
            SwapBuffers();
        }
        
        protected override void OnMouseMove(MouseMoveEventArgs e)
        {
        	//Console.WriteLine("{0} , {1} ", e.X,e.Y);
        	caja.Datos(e.X,600-e.Y,30);
        }

    }
}
