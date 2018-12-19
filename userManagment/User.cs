using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace userManagment
{
    class User
    {
        public void removeUser(string username, string ip, string pathuser, string pathip)
        {
            var oldLinesUser = System.IO.File.ReadAllLines(pathuser);
            var newLinesUser = oldLinesUser.Where(line => !line.Contains(username));

            var oldLinesIp = System.IO.File.ReadAllLines(pathip);
            var newLinesIp = oldLinesIp.Where(line => !line.Contains(ip));

            try
            {

                System.IO.File.WriteAllLines(pathuser, newLinesUser);
                System.IO.File.WriteAllText(pathip, string.Join("\n", newLinesIp));

            }
            catch (Exception)
            {

                throw;
            }






 

            
        }

        public void addUser(string username, string password, string pathchapsecrets, string pathiptables, string line, int position)
        {
            try
            {

                File.AppendAllText(pathchapsecrets, username + "            " + "l2tpd" + "            " + password + "            " + "*" + "\n");

                string[] linesip = System.IO.File.ReadAllLines(pathiptables);

                using (StreamWriter writer = new StreamWriter(pathiptables))
                {
                    writer.NewLine = "\n";
                    for (int i = 0; i < position; i++)
                        writer.WriteLine(linesip[i]);
                    writer.WriteLine(line);
                    for (int i = position; i < linesip.Length; i++)
                        writer.WriteLine(linesip[i]);
                }
            }
            catch (Exception)
            {

                throw;
            }
            

        }
    }
}
