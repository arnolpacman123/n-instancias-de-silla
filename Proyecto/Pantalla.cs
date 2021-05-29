using System;
using System.ComponentModel;
using OpenTK;
using OpenTK.Graphics;

namespace Proyecto
{
    class Pantalla : GameWindow
    {
        public Pantalla(int ancho, int alto, string titulo)
            : base(ancho, alto, GraphicsMode.Default, titulo)
        {
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
        }

        protected override void OnRenderFrame(FrameEventArgs e)
        {
            Dibujo.Clear();
            Dibujo.ClearColor();

            Dibujo silla1 = new Dibujo(new Vector2(0.0f, 0.0f));
            silla1.DibujarSilla();

            Dibujo silla2 = new Dibujo(new Vector2(-0.35f, -0.35f));
            silla2.DibujarSilla();

            Dibujo silla3 = new Dibujo(new Vector2(0.35f, 0.35f));
            silla3.DibujarSilla();

            Dibujo.Flush();
            this.SwapBuffers();
            base.OnRenderFrame(e);
        }

        protected override void OnUpdateFrame(FrameEventArgs e)
        {
            base.OnUpdateFrame(e);
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);
        }
    }
}
