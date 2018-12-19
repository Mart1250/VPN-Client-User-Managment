using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace userManagment
{
    public partial class UserManagment : Form
    {
        public UserManagment()
        {
            InitializeComponent();

            Serverlist serverlist = new Serverlist();
            Xml xml = new Xml();
            List<string> list = new List<string>();

            list = xml.readXML("Servers");


            foreach (string server in list)
            {
                lbServerlist.Items.Add(server);
            }

        }

        private void bUpdate_Click(object sender, EventArgs e)
        {
            Files file = new Files();
            if (lbServerlist.SelectedItem != null)
            {
                DialogResult dialogResult = MessageBox.Show("Weet u zeker dat u de configs lokaal wilt updaten?", "Bevestiging", MessageBoxButtons.YesNo);

                if (dialogResult == DialogResult.Yes)
                {
                    file.downloadFile("ftp://" + lbServerlist.SelectedItem + "/etc/ppp/chap-secrets", lbServerlist.SelectedItem + "/chap-secrets");
                    file.downloadFile("ftp://" + lbServerlist.SelectedItem + "/etc/iptables.rules", lbServerlist.SelectedItem + "/iptables.rules");

                    rtFilecontent.Text = System.IO.File.ReadAllText(lbServerlist.SelectedItem + "/" + lbServerfiles.SelectedItem);
                }
            }
            
        }

        private void lbServerlist_SelectedIndexChanged(object sender, EventArgs e)
        {
            Files file = new Files();
            string[] filenames; 

            if(lbServerlist.SelectedItem != null)

            switch (file.createFolder((string)lbServerlist.SelectedItem))
            {
                case true:

                    file.downloadFile("ftp://" + lbServerlist.SelectedItem + "/etc/ppp/chap-secrets", lbServerlist.SelectedItem + "/chap-secrets");
                    file.downloadFile("ftp://" + lbServerlist.SelectedItem + "/etc/iptables.rules", lbServerlist.SelectedItem + "/iptables.rules");

                    filenames = file.GetFileNames((string)lbServerlist.SelectedItem, "*.*");

                    foreach (string filename in filenames)
                    {

                        if (!lbServerfiles.Items.Contains(filename))
                        {
                            lbServerfiles.Items.Add(filename);
                        }
                        
                    }
                    break;

                case false:

                    filenames = file.GetFileNames((string)lbServerlist.SelectedItem, "*.*");

                    foreach (string filename in filenames)
                    {

                        if (!lbServerfiles.Items.Contains(filename))
                        {
                            lbServerfiles.Items.Add(filename);
                        }

                    }
                    break;

                default:
                    break;
            }
        }

        private void lbServerfiles_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbServerfiles.SelectedItem != null)
            {


                bUpdate.Enabled = true;
                bUpload.Enabled = true;
                bAdd.Enabled = true;
                bRemove.Enabled = true;

                rtFilecontent.Text = System.IO.File.ReadAllText(lbServerlist.SelectedItem + "/" + lbServerfiles.SelectedItem);
            }
        }

        private void bRemove_Click(object sender, EventArgs e)
        {
            User user = new User();

            DialogResult dialogResult = MessageBox.Show("Weet u zeker dat u deze gebruiker wilt verwijderen?", "Bevestiging", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {

                if ((tbInputUsername.Text != "") && (tbInputIpaddress.Text != ""))
                {

                    user.removeUser(tbInputUsername.Text, tbInputIpaddress.Text, lbServerlist.SelectedItem + "/" + "chap-secrets", lbServerlist.SelectedItem + "/" + "iptables.rules");
                    rtFilecontent.Text = System.IO.File.ReadAllText(lbServerlist.SelectedItem + "/" + lbServerfiles.SelectedItem);

                }else
                {

                    MessageBox.Show("Vul de vereiste gegevens in.", "Er is te weinig informatie opgegeven");

                }
            }
        }

        private void bAdd_Click(object sender, EventArgs e)
        {
            User user = new User();

            if (tbInputUsername.Text != "" && tbInputPassword.Text != "") { 
            user.addUser(tbInputUsername.Text, tbInputPassword.Text, lbServerlist.SelectedItem + "/chap-secrets", lbServerlist.SelectedItem + "/iptables.rules", "-A INPUT -s " + tbInputIpaddress.Text + "/32 -j ACCEPT", 6);

            rtFilecontent.Text = System.IO.File.ReadAllText(lbServerlist.SelectedItem + "/" + lbServerfiles.SelectedItem);
            }else
            {
                MessageBox.Show("Vul de vereiste gegevens in.", "Er is te weinig informatie opgegeven");
            }

        }

        private void bUpload_Click(object sender, EventArgs e)
        {
            Files file = new Files();

            file.uploadFile("ftp://" + lbServerlist.SelectedItem + "/etc/iptables.rules", lbServerlist.SelectedItem + "/iptables.rules");
            file.uploadFile("ftp://" + lbServerlist.SelectedItem + "/etc/ppp/chap-secrets", lbServerlist.SelectedItem + "/chap-secrets");
        }
    }
}
