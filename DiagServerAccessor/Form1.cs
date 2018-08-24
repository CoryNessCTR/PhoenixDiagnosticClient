using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

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
            
            foreach(CTRProductStuff.Action action in CTRProductStuff.AllActions)
            {
                actionSelector.Items.Add(action);
            }
            foreach (CTRProductStuff.Devices device in CTRProductStuff.AllDevices)
            {
                deviceSelector.Items.Add(device);
            }
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

            //Send request to root server as a form of "ping"
            string response = WebServerScripts.HttpGet(_connectedIp, CTRProductStuff.Devices.None, 0, CTRProductStuff.Action.None);
            if (response.Equals("Failed")) return;
            EmptyReturn myReponse = JsonConvert.DeserializeObject<EmptyReturn>(response);
            
            //Check the connected box if we successfully got the return message
            connectedIndicator.Checked = myReponse.GeneralReturn.Error == WebServerScripts.PingReturn;
        }

        private void executeAction_Click(object sender, EventArgs e)
        {
            CTRProductStuff.Action actionSent = (CTRProductStuff.Action)Enum.Parse(typeof(CTRProductStuff.Action), actionSelector.Text);
            CTRProductStuff.Devices deviceSent = (CTRProductStuff.Devices)Enum.Parse(typeof(CTRProductStuff.Devices), deviceSelector.Text);

            string retval = WebServerScripts.HttpGet(_connectedIp, deviceSent, (uint)deviceIDSelector.Value, actionSent);
            Console.WriteLine(retval);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "CRF Filse|*.crf";
            dialog.Title = "Select a crf file";

            if(dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                WebServerScripts.HttpPost(_connectedIp, dialog.OpenFile());
            }
        }
    }
}
