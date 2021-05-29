using OpenTK;
using OpenTK.Graphics.OpenGL;
using System.Drawing;

namespace Proyecto
{
    class Dibujo
    {
        private Vector2 posicion = new Vector2(0, 0);
        private float X;
        private float Y;

        public Dibujo(Vector2 posicion)
        {
            this.posicion.X = this.posicion.X + posicion.X;
            this.posicion.Y = this.posicion.Y + posicion.Y;
            X = this.posicion.X;
            Y = this.posicion.Y;
        }

        public void DibujarSilla()
        {
            this.Espaldar();
            this.Base();
            this.Pata1();
            this.Pata2();
            this.Pata3();
        }

        public void Espaldar()
        {
            GL.Begin(PrimitiveType.Polygon);
            GL.Vertex2(X - 0.250, Y + 0.275);
            GL.Vertex2(X - 0.000, Y + 0.550);
            GL.Vertex2(X - 0.000, Y + 0.250);
            GL.Vertex2(X - 0.250, Y + 0.000);
            GL.End();
        }

        private void Base()
        {
            GL.Begin(PrimitiveType.Quads);
            GL.Vertex2(X + 0.000, Y + 0.250);
            GL.Vertex2(X + 0.250, Y + 0.000);
            GL.Vertex2(X + 0.000, Y - 0.250);
            GL.Vertex2(X - 0.250, Y + 0.000);
            GL.End();
        }

        public void Pata1()
        {
            GL.Begin(PrimitiveType.Polygon);
            GL.Vertex2(X - 0.250, Y + 0.000);
            GL.Vertex2(X - 0.200, Y - 0.050);
            GL.Vertex2(X - 0.200, Y - 0.150);
            GL.Vertex2(X - 0.225, Y - 0.170);
            GL.Vertex2(X - 0.250, Y - 0.150);
            GL.End();
        }

        public void Pata2()
        {
            GL.Begin(PrimitiveType.Polygon);
            GL.Vertex2(X - 0.030, Y - 0.150);
            GL.Vertex2(X + 0.000, Y - 0.250);
            GL.Vertex2(X + 0.030, Y - 0.150);
            GL.Vertex2(X + 0.030, Y - 0.325);
            GL.Vertex2(X + 0.000, Y - 0.350);
            GL.Vertex2(X - 0.030, Y - 0.325);
            GL.End();
        }

        public void Pata3()
        {
            GL.Begin(PrimitiveType.Polygon);
            GL.Vertex2(X + 0.250, Y + 0.000);
            GL.Vertex2(X + 0.200, Y - 0.050);
            GL.Vertex2(X + 0.200, Y - 0.150);
            GL.Vertex2(X + 0.225, Y - 0.170);
            GL.Vertex2(X + 0.250, Y - 0.150);
            GL.End();
        }

        public static void Clear()
        {
            GL.Clear(ClearBufferMask.ColorBufferBit);
        }

        public static void ClearColor()
        {
            GL.ClearColor(Color.FromArgb(5, 5, 25));
        }

        public static void Flush()
        {
            GL.Flush();
        }

    }
}
