using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiagServerAccessor
{
    public partial class Form1 : Form
    {
        private ComboBox.ObjectCollection _ipAddrItems;
        private string _connectedIp;

        public Form1()
        {
            InitializeComponent();
            _ipAddrItems = ipAddrSelector.Items;
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            //On refresh poll for possible IP's and populate combobox with them
            _ipAddrItems.Clear();
            foreach(string addr in WebServerScripts.GetIPAddrs())
            {
                _ipAddrItems.Add(addr);
            }
        }

        private void connectButton_Click(object sender, EventArgs e)
        {
            //Check to see if ip address is actually good
            if (ipAddrSelector.Text == "")
                return;

            //If connecting and box is not empty, use that address
            _connectedIp = "http://" + ipAddrSelector.Text + ":8181/";
            string response = WebServerScripts.HttpGet(_connectedIp, CTRProductStuff.Devices.None, CTRProductStuff.Action.None);
            Console.WriteLine(response);


            connectedIndicator.Checked = response == WebServerScripts.PingReturn;
        }
    }
}
