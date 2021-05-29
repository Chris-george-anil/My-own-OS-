using System;
using System.Collections.Generic;
using System.Text;
using Cosmos.System.Graphics;
using System.Drawing;
using Sys = Cosmos.System;
using Cosmos.System;

namespace OSProject
{
    public class GUI
    {
        private Canvas canvas;
        private Pen pen;

        private MouseState prevmouseState;
        private UInt32 px, py;
        private List<Tuple<Sys.Graphics.Point, Color>> savedPixels;
        private TabBar tabBar;

        public GUI()
        {
            this.canvas = FullScreenCanvas.GetFullScreenCanvas();
            this.canvas.Clear(Color.Green);
            this.pen = new Pen(Color.Red);
            this.prevmouseState = MouseState.None;
            MouseManager.ScreenHeight = (UInt32)this.canvas.Mode.Rows;
            MouseManager.ScreenWidth = (UInt32)this.canvas.Mode.Columns;

            this.px=3;
            this.py=3;
            this.savedPixels = new List<Tuple<Sys.Graphics.Point, Color>>();
            this.tabBar = new TabBar(this.canvas);
        }

        public void handleGUIInputs()
        {
            if(this.px!=MouseManager.X && this.py != MouseManager.Y)
            {
    if (MouseManager.X<2|| MouseManager.Y<2||MouseManager.X>(MouseManager.ScreenWidth-2)|| MouseManager.Y > (MouseManager.ScreenHeight - 2))              
                   return;

                this.px = MouseManager.X;
                this.py = MouseManager.Y;

                Sys.Graphics.Point[] points = new Sys.Graphics.Point[] { 
                
                    new Sys.Graphics.Point((Int32)MouseManager.X,(Int32)MouseManager.Y),
                    new Sys.Graphics.Point((Int32)MouseManager.X+1,(Int32)MouseManager.Y),
                    new Sys.Graphics.Point((Int32)MouseManager.X,(Int32)MouseManager.Y-1),
                    new Sys.Graphics.Point((Int32)MouseManager.X-1,(Int32)MouseManager.Y),
                    new Sys.Graphics.Point((Int32)MouseManager.X,(Int32)MouseManager.Y+1),
                };

                foreach(Tuple<Sys.Graphics.Point, Color>pixeldata in this.savedPixels)
                {
                    this.canvas.DrawPoint(new Pen(pixeldata.Item2), pixeldata.Item1);
                }

                this.savedPixels.Clear();

                foreach(Sys.Graphics.Point p in points)
                {
                    this.savedPixels.Add(new Tuple<Sys.Graphics.Point, Color>(p, this.canvas.GetPointColor(p.X, p.Y)));
                    this.canvas.DrawPoint(this.pen,p);
                }
            }

            if (MouseManager.MouseState == MouseState.Left && this.prevmouseState != MouseState.Left)
                this.tabBar.tryProcessTabbarClick((Int32)MouseManager.X,(Int32)MouseManager.Y);

            this.prevmouseState = MouseManager.MouseState;

       
        }
    }
}
