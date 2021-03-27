using System;
using System.Collections.Generic;
using System.Text;
using Sys = Cosmos.System;
using Cosmos.Debug.Kernel;



namespace OSProject
{
    public class Kernel : Sys.Kernel
    {
        private static Sys.FileSystem.CosmosVFS FS;
        public static string file;
        protected override void BeforeRun()
        {
            FS = new Sys.FileSystem.CosmosVFS(); Sys.FileSystem.VFS.VFSManager.RegisterVFS(FS); FS.Initialize();
            Console.Clear();

            Console.WriteLine("Cosmos booted successfully. Check it out.");
        }

        protected override void Run()
        {
            Commands.SayHello();
            Console.WriteLine("Input: ");
            Console.BackgroundColor = ConsoleColor.Green;
           string i;
            i = Console.ReadLine();
            if (i == "Calculator")
            {
                Commands.add();
            }
            else if(i=="Editor"){

                MIV.StartMIV();
            }
            else if(i=="time"){
                //Console.WriteLine(DateTime.Now.ToString("h:mm:ss tt"));
                Commands.time();
            }
            else
            {
                Console.WriteLine("Invalid command");
            }
        }
    }
}
