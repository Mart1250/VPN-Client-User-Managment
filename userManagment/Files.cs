using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace userManagment
{
    class Files
    {

        public bool downloadFile(string externaldestination, string localname)
        {
            int bytesRead = 0;
            byte[] buffer = new byte[2048];

            Ftp ftp = new Ftp();

            FtpWebRequest request = ftp.request(externaldestination);

            ftp.setMethod(request, 0);
            ftp.setCredentials(request, "admin", "wachtwoord");

            Stream reader = ftp.getData(ftp.getResponse(request));

            
            FileStream fileStream = new FileStream(localname, FileMode.Create);


            while (true)
            {
                bytesRead = reader.Read(buffer, 0, buffer.Length);

                if (bytesRead == 0)
                    break;

                try
                {
                    fileStream.Write(buffer, 0, bytesRead);

                    
                }
                catch
                {
                    fileStream.Close();
                    return true;
                }
                
            }
            fileStream.Close();

            return false;
        }

        public bool uploadFile(string externaldestination, string localname)
        {
            Ftp ftp = new Ftp();

            FtpWebRequest request = ftp.request(externaldestination);

            ftp.setMethod(request, 1);
            ftp.setCredentials(request, "admin", "wachtwoord");

            StreamReader sourceStream = new StreamReader(localname);

            byte[] fileContents = Encoding.UTF8.GetBytes(sourceStream.ReadToEnd());
            sourceStream.Close();
            request.ContentLength = fileContents.Length;

            Stream requestStream = request.GetRequestStream();

            try
            {
                requestStream.Write(fileContents, 0, fileContents.Length);
            }
            catch (Exception)
            {

                throw;
            }

            requestStream.Close();

            FtpWebResponse response = (FtpWebResponse)request.GetResponse();

            response.Close();

            return true;
        }

        public bool createFolder(string foldername)
            {

            // Specify the directory you want to manipulate.
            string path = foldername;

                    // Determine whether the directory exists.

                    if (Directory.Exists(path)) 
                    {

                        return false;

                    }else
                    {

                        try
                        {
                                DirectoryInfo di = Directory.CreateDirectory(path);
                                
                        }
                        catch (Exception)
                        {

                                throw;
                                
                        }

                            return true;                             
                    }

            }

        public string[] GetFileNames(string path, string filter)
        {
            string[] files = Directory.GetFiles(path, filter);

            for (int i = 0; i < files.Length; i++)

                files[i] = Path.GetFileName(files[i]);

            return files;
        }
    }
}

