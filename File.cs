using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using Sys = Cosmos.System;

namespace OSProject
{
   public class Files
    {
        public Files(String name) { }
        public  static String execute (String[] c)        {
            String response = "";

            switch (c[0])
            {
                case "create":
                    try
                    {
                        Sys.FileSystem.VFS.VFSManager.CreateFile(c[1]);
                        response = "File created ! \n";
                    }
                    catch(Exception ex)
                    {
                        response = ex.ToString();
                        break;
                    }
                    break;
                case "del":
                    try
                    {
                        Sys.FileSystem.VFS.VFSManager.DeleteFile(c[1]);
                        response = "File deleted ! \n";
                    }
                    catch (Exception ex)
                    {
                        response = ex.ToString();
                        break;
                    }
                    break;
                    
                case "createdir":
                    try
                    {
                        Sys.FileSystem.VFS.VFSManager.CreateDirectory(c[1]);
                        response = "Directory created ! \n";
                    }
                    catch (Exception ex)
                    {
                        response = ex.ToString();
                        break;
                    }
                    break;
                case "rmdir":
                    try
                    {
                        Sys.FileSystem.VFS.VFSManager.DeleteDirectory(c[1], true);
                        response = "Directory deleted ! \n";
                    }
                    catch (Exception ex)
                    {
                        response = ex.ToString();
                        break;
                    }
                    break;
                case "write":
                    try
                    {
                        FileStream fs = (FileStream)Sys.FileSystem.VFS.VFSManager.GetFile(c[1]).GetFileStream();
                        if (fs.CanWrite)
                        {
                            Console.WriteLine("Enter Text below");
                            
                            var x = Console.ReadLine();
                            
                             Utilities.WriteToFile(x, c[1]);
                            //Console.WriteLine(x);
                            response = "Written to file";
                            fs.Close();
                        }
                        else
                        {
                            response = "Unable to write";
                        }
                    }catch(Exception ex)
                    {
                        response = ex.ToString();
                        break;
                    }
                    break;
                case "read":
                    try
                    {
                        FileStream rs = (FileStream)Sys.FileSystem.VFS.VFSManager.GetFile(c[1]).GetFileStream();
                        if (rs.CanRead)
                        {

                            try
                            {
                                Byte[] dat = new Byte[256];
                                rs.Read(dat, 0, dat.Length);

                                response = Encoding.ASCII.GetString(dat);
                                //Sys.FileSystem.VFS.VFSManager.ReadFile(c[1]);
                                string text = System.IO.File.ReadAllText(c[1]);
                                Console.WriteLine(text);
                            }catch(Exception ex)
                            {
                                Console.WriteLine(ex);                            }
                            }
                        else
                        {
                            response = "Cannot read file";
                        }
                    }catch(Exception ex)
                    {
                        response = ex.ToString();
                        break;
                    }
                    break;
                default:
                    response = "Unexpected Argument";
                    break;
                                }
            return response;
            
        }
    }
}
