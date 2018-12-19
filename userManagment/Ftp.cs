using System;
using System.IO;
using System.Net;
using System.Text;

namespace userManagment
{
    class Ftp
    {

        public FtpWebRequest request(string externaldestination)
        {
            FtpWebRequest request = (FtpWebRequest)WebRequest.Create(externaldestination);

            return request;
        }

        public void setMethod(FtpWebRequest request, int method)
        {
            switch (method)
            {
                case 0:
                    request.Method = WebRequestMethods.Ftp.DownloadFile;
                        break;

                case 1:
                    request.Method = WebRequestMethods.Ftp.UploadFile;
                    break;

                default:
                    break;
            }
        }

        public void setCredentials(FtpWebRequest request, string username, string password) {

            NetworkCredential credentials = new NetworkCredential(username, password);

            request.Credentials = credentials;
        }


        public FtpWebResponse getResponse(FtpWebRequest request)
        {
            FtpWebResponse response = (FtpWebResponse)request.GetResponse();

            return response;
        }


        public Stream getData(FtpWebResponse response)
        {
            Stream responseStream = response.GetResponseStream();

            return responseStream;
        }


    }
}
