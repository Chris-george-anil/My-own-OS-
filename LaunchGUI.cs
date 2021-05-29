using System;
using System.Collections.Generic;
using System.Text;

namespace OSProject
{
     public class LaunchGUI
    {

        public LaunchGUI(String name) { }
        public static String excecute() {

           // if (Kernel.gui != null)
              //  return "Already init";
            Kernel.gui = new GUI();
            Kernel.gui.handleGUIInputs();
            return "lauched";
        
        }
    }
}
