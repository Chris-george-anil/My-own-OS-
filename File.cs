using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Sys = Cosmos.System;

namespace OSProject
{
   public class File
    {
        public File(String name) { }
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
                    Sys.FileSystem.VFS.VFSManager.DeleteFile(c[1]);
                    response = "File deleted ! \n";
                    break;
                case "createdir":
                    Sys.FileSystem.VFS.VFSManager.CreateDirectory(c[1]);
                    response = "Directory created ! \n";
                    break;
                case "rmdir":
                    Sys.FileSystem.VFS.VFSManager.DeleteDirectory(c[1],true);
                    response = "File created ! \n";
                    break;
                case "write":
                    FileStream fs=(FileStream) Sys.FileSystem.VFS.VFSManager.GetFile(c[1]).GetFileStream();
                    if (fs.CanWrite)
                    {
                        int cnt = 0;
                        StringBuilder sb = new StringBuilder();
                        foreach(String s in c)
                        {
                            if (cnt > 1)
                            {
                                sb.Append(s + " ");
                                ++cnt;
                            }
                        }
                        Byte[] data = Encoding.ASCII.GetBytes(sb.ToString());
                        fs.Write(data,0,data.Length);
                        fs.Close();
                    }
                    else
                    {
                        response = "Unable to write";
                    }
                    break;
                case "readstr":
                    FileStream rs = (FileStream)Sys.FileSystem.VFS.VFSManager.GetFile(c[1]).GetFileStream();
                    if (rs.CanRead)
                    {
                        Byte[] dat = new Byte[256];
                        rs.Read(dat, 0, dat.Length);
                        response = Encoding.ASCII.GetString(dat);
                    
                    }
                    else
                    {
                        response = "Cannot read file";
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
