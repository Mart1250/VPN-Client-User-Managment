namespace userManagment
{
    partial class UserManagment
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.bUpdate = new System.Windows.Forms.Button();
            this.rtFilecontent = new System.Windows.Forms.RichTextBox();
            this.lbServerlist = new System.Windows.Forms.ListBox();
            this.lServerlist = new System.Windows.Forms.Label();
            this.lbServerfiles = new System.Windows.Forms.ListBox();
            this.tbInputUsername = new System.Windows.Forms.TextBox();
            this.lbInputUsername = new System.Windows.Forms.Label();
            this.bRemove = new System.Windows.Forms.Button();
            this.bAdd = new System.Windows.Forms.Button();
            this.tbInputIpaddress = new System.Windows.Forms.TextBox();
            this.lbInputIpaddress = new System.Windows.Forms.Label();
            this.lbFiles = new System.Windows.Forms.Label();
            this.tbInputPassword = new System.Windows.Forms.TextBox();
            this.lbInputPassword = new System.Windows.Forms.Label();
            this.bUpload = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bUpdate
            // 
            this.bUpdate.Enabled = false;
            this.bUpdate.Location = new System.Drawing.Point(12, 309);
            this.bUpdate.Name = "bUpdate";
            this.bUpdate.Size = new System.Drawing.Size(75, 23);
            this.bUpdate.TabIndex = 0;
            this.bUpdate.Text = "Update";
            this.bUpdate.UseVisualStyleBackColor = true;
            this.bUpdate.Click += new System.EventHandler(this.bUpdate_Click);
            // 
            // rtFilecontent
            // 
            this.rtFilecontent.Location = new System.Drawing.Point(12, 12);
            this.rtFilecontent.Name = "rtFilecontent";
            this.rtFilecontent.ReadOnly = true;
            this.rtFilecontent.Size = new System.Drawing.Size(436, 277);
            this.rtFilecontent.TabIndex = 1;
            this.rtFilecontent.Text = "";
            // 
            // lbServerlist
            // 
            this.lbServerlist.FormattingEnabled = true;
            this.lbServerlist.Location = new System.Drawing.Point(574, 38);
            this.lbServerlist.Name = "lbServerlist";
            this.lbServerlist.Size = new System.Drawing.Size(100, 251);
            this.lbServerlist.TabIndex = 2;
            this.lbServerlist.SelectedIndexChanged += new System.EventHandler(this.lbServerlist_SelectedIndexChanged);
            // 
            // lServerlist
            // 
            this.lServerlist.AutoSize = true;
            this.lServerlist.Location = new System.Drawing.Point(571, 15);
            this.lServerlist.Name = "lServerlist";
            this.lServerlist.Size = new System.Drawing.Size(55, 13);
            this.lServerlist.TabIndex = 3;
            this.lServerlist.Text = "Serverlijst:";
            // 
            // lbServerfiles
            // 
            this.lbServerfiles.FormattingEnabled = true;
            this.lbServerfiles.Location = new System.Drawing.Point(459, 38);
            this.lbServerfiles.Name = "lbServerfiles";
            this.lbServerfiles.Size = new System.Drawing.Size(109, 251);
            this.lbServerfiles.TabIndex = 4;
            this.lbServerfiles.SelectedIndexChanged += new System.EventHandler(this.lbServerfiles_SelectedIndexChanged);
            // 
            // tbInputUsername
            // 
            this.tbInputUsername.Location = new System.Drawing.Point(336, 311);
            this.tbInputUsername.Name = "tbInputUsername";
            this.tbInputUsername.Size = new System.Drawing.Size(112, 20);
            this.tbInputUsername.TabIndex = 5;
            // 
            // lbInputUsername
            // 
            this.lbInputUsername.AutoSize = true;
            this.lbInputUsername.Location = new System.Drawing.Point(333, 296);
            this.lbInputUsername.Name = "lbInputUsername";
            this.lbInputUsername.Size = new System.Drawing.Size(87, 13);
            this.lbInputUsername.TabIndex = 6;
            this.lbInputUsername.Text = "Gebruikersnaam:";
            // 
            // bRemove
            // 
            this.bRemove.Enabled = false;
            this.bRemove.Location = new System.Drawing.Point(255, 310);
            this.bRemove.Name = "bRemove";
            this.bRemove.Size = new System.Drawing.Size(75, 23);
            this.bRemove.TabIndex = 7;
            this.bRemove.Text = "Verwijderen";
            this.bRemove.UseVisualStyleBackColor = true;
            this.bRemove.Click += new System.EventHandler(this.bRemove_Click);
            // 
            // bAdd
            // 
            this.bAdd.Enabled = false;
            this.bAdd.Location = new System.Drawing.Point(174, 310);
            this.bAdd.Name = "bAdd";
            this.bAdd.Size = new System.Drawing.Size(75, 23);
            this.bAdd.TabIndex = 8;
            this.bAdd.Text = "Toevoegen";
            this.bAdd.UseVisualStyleBackColor = true;
            this.bAdd.Click += new System.EventHandler(this.bAdd_Click);
            // 
            // tbInputIpaddress
            // 
            this.tbInputIpaddress.Location = new System.Drawing.Point(574, 311);
            this.tbInputIpaddress.Name = "tbInputIpaddress";
            this.tbInputIpaddress.Size = new System.Drawing.Size(100, 20);
            this.tbInputIpaddress.TabIndex = 9;
            // 
            // lbInputIpaddress
            // 
            this.lbInputIpaddress.AutoSize = true;
            this.lbInputIpaddress.Location = new System.Drawing.Point(571, 296);
            this.lbInputIpaddress.Name = "lbInputIpaddress";
            this.lbInputIpaddress.Size = new System.Drawing.Size(50, 13);
            this.lbInputIpaddress.TabIndex = 10;
            this.lbInputIpaddress.Text = "IP-Adres:";
            // 
            // lbFiles
            // 
            this.lbFiles.AutoSize = true;
            this.lbFiles.Location = new System.Drawing.Point(456, 15);
            this.lbFiles.Name = "lbFiles";
            this.lbFiles.Size = new System.Drawing.Size(45, 13);
            this.lbFiles.TabIndex = 11;
            this.lbFiles.Text = "Configs:";
            // 
            // tbInputPassword
            // 
            this.tbInputPassword.Location = new System.Drawing.Point(459, 311);
            this.tbInputPassword.Name = "tbInputPassword";
            this.tbInputPassword.Size = new System.Drawing.Size(109, 20);
            this.tbInputPassword.TabIndex = 13;
            // 
            // lbInputPassword
            // 
            this.lbInputPassword.AutoSize = true;
            this.lbInputPassword.Location = new System.Drawing.Point(456, 296);
            this.lbInputPassword.Name = "lbInputPassword";
            this.lbInputPassword.Size = new System.Drawing.Size(71, 13);
            this.lbInputPassword.TabIndex = 14;
            this.lbInputPassword.Text = "Wachtwoord:";
            // 
            // bUpload
            // 
            this.bUpload.Enabled = false;
            this.bUpload.Location = new System.Drawing.Point(93, 309);
            this.bUpload.Name = "bUpload";
            this.bUpload.Size = new System.Drawing.Size(75, 23);
            this.bUpload.TabIndex = 15;
            this.bUpload.Text = "Upload";
            this.bUpload.UseVisualStyleBackColor = true;
            this.bUpload.Click += new System.EventHandler(this.bUpload_Click);
            // 
            // UserManagment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 339);
            this.Controls.Add(this.bUpload);
            this.Controls.Add(this.lbInputPassword);
            this.Controls.Add(this.tbInputPassword);
            this.Controls.Add(this.lbFiles);
            this.Controls.Add(this.lbInputIpaddress);
            this.Controls.Add(this.tbInputIpaddress);
            this.Controls.Add(this.bAdd);
            this.Controls.Add(this.bRemove);
            this.Controls.Add(this.lbInputUsername);
            this.Controls.Add(this.tbInputUsername);
            this.Controls.Add(this.lbServerfiles);
            this.Controls.Add(this.lServerlist);
            this.Controls.Add(this.lbServerlist);
            this.Controls.Add(this.rtFilecontent);
            this.Controls.Add(this.bUpdate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.MaximizeBox = false;
            this.Name = "UserManagment";
            this.Text = "UserManagment";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bUpdate;
        private System.Windows.Forms.RichTextBox rtFilecontent;
        private System.Windows.Forms.ListBox lbServerlist;
        private System.Windows.Forms.Label lServerlist;
        private System.Windows.Forms.ListBox lbServerfiles;
        private System.Windows.Forms.TextBox tbInputUsername;
        private System.Windows.Forms.Label lbInputUsername;
        private System.Windows.Forms.Button bRemove;
        private System.Windows.Forms.Button bAdd;
        private System.Windows.Forms.TextBox tbInputIpaddress;
        private System.Windows.Forms.Label lbInputIpaddress;
        private System.Windows.Forms.Label lbFiles;
        private System.Windows.Forms.TextBox tbInputPassword;
        private System.Windows.Forms.Label lbInputPassword;
        private System.Windows.Forms.Button bUpload;
    }
}

