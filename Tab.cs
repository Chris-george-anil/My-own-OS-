using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using Sys = Cosmos.System;
using Cosmos.System.Graphics;

namespace OSProject
{
    public class Tab
    {
        private static List<Tab> tabs = new List<Tab>();
        private static Pen outlinepen = new Pen(Color.White), xbtn=new Pen(Color.Red);

        internal const Int32 defaultWindow = 4000, windowTop = 25, xbtnSize = 25;
            public Int32 X
        {
            get;
            private set;
        }
        public Int32 Y
        {
            get;
            private set;
        }

        private protected Boolean beingDragged;
    }
}
