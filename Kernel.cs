using System;
using System.Collections.Generic;
using System.Text;
using Sys = Cosmos.System;
using Cosmos.Debug.Kernel;
using Cosmos.System.FileSystem;
using Cosmos.Core;



namespace OSProject
{
    public class Kernel : Sys.Kernel
    {
       // public static uint screenWidth = 680;
        //public static uint screenHeight = 680;
        

        private static Sys.FileSystem.CosmosVFS FS;
        public static string file;

        public static GUI gui;
       

        protected override void BeforeRun()
        {
            FS = new Sys.FileSystem.CosmosVFS(); 
            Sys.FileSystem.VFS.VFSManager.RegisterVFS(FS);
            FS.Initialize();
            Console.Clear();
            Console.WriteLine("Cosmos booted successfully. Check it out.");
            Commands.SayHello();
        }

        protected override void Run()
        {

            Console.WriteLine(">: ");
           
           string i;
            i = Console.ReadLine();
            if (i == "Calculator")
            {
                Commands.add();
            }
            else if(i=="Time"){

                Console.WriteLine(Commands.time());
            }

            else if(i=="File"){
                Commands.file();
            }
            else if (i == "ShutDown")
            {
                Cosmos.System.Power.Shutdown();
            }
            else if (i == "Reboot")
            {
                Cosmos.System.Power.Reboot();
            }
            else if(i=="GUI") {
                LaunchGUI.excecute();
            }
            else
            {
                Console.WriteLine("Invalid command");
            }
        }
    }
}
