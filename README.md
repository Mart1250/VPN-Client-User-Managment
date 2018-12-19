# VPN-Client-User-Managment
With this tool you can manually add users in chap-secrets and add iptable 'allow rules' for each user.

Make sure to update the XML web location in FTP.cs. In this file are all your the ipadresses of your servers listed. (Obviously this requires webhosting)

Depending on how your iptables file looks, you need to adjust the number at the end of the function in the line showed below. (Inside the 'bAdd_Click' function in 'User.cs')

"user.addUser(tbInputUsername.Text, tbInputPassword.Text, lbServerlist.SelectedItem + "/chap-secrets", lbServerlist.SelectedItem + "/iptables.rules", "-A INPUT -s " + tbInputIpaddress.Text + "/32 -j ACCEPT", 6);"

The rule will be inserted at that position.
