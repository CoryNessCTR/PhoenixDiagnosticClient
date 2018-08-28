using System;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace DiagServerAccessor
{
    public partial class Form1 : Form
    {
        private ComboBox.ObjectCollection _ipAddrItems;
        private string _connectedIp = "";
        private GetDevicesReturn _deviceStatus;

        public Form1()
        {
            InitializeComponent();
            _ipAddrItems = ipAddrSelector.Items;
            refreshButton_Click(null, null);

            foreach (Control c in deviceSpecificControls.Controls)
            {
                c.Enabled = false;
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
            deviceView.Items.Clear();
            if (_connectedIp != "")
                _deviceStatus = JsonConvert.DeserializeObject<GetDevicesReturn>
                    (WebServerScripts.HttpGet(_connectedIp, CTRProductStuff.Devices.None, 0, CTRProductStuff.Action.GetDeviceList));
            if(_deviceStatus != null)
            {
                foreach(DeviceDescriptor d in _deviceStatus.DeviceArray)
                {
                    string[] array = new string[7];
                    array[0] = d.Name;
                    array[1] = d.Model;
                    array[2] = (d.ID & 0x3F).ToString();
                    array[3] = d.CurrentVers;
                    array[4] = d.ManDate;
                    array[5] = d.BootloaderRev;
                    array[6] = d.SoftStatus;
                    deviceView.Items.Add(new ListViewItem(array));
                }
            }
            foreach (Control c in deviceSpecificControls.Controls)
            {
                c.Enabled = false;
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
            connectedIndicator.Checked = true;//myReponse.GeneralReturn.Error == WebServerScripts.PingReturn;
            refreshButton_Click(null, null);
        }
        
        private void ipAddrSelector_TextChanged(object sender, EventArgs e)
        {
            deviceView.Items.Clear();
            connectedIndicator.Checked = false;
            _connectedIp = "";
            foreach (Control c in deviceSpecificControls.Controls)
            {
                c.Enabled = false;
            }
        }

        private void blinkButton_Click(object sender, EventArgs e)
        {
            if(deviceView.SelectedItems.Count == 1)
            {
                var descriptor = _deviceStatus.DeviceArray[deviceView.SelectedIndices[0]];
                CTRProductStuff.Devices dev = CTRProductStuff.DeviceStringMap[descriptor.Model];
                uint id = (uint)descriptor.ID & 0x3F;

                string ret = WebServerScripts.HttpGet(_connectedIp, dev, id, CTRProductStuff.Action.Blink);
            }
        }

        private void deviceView_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach(Control c in deviceSpecificControls.Controls)
            {
                c.Enabled = true;
            }

            refreshConfigs();
        }

        private void refreshConfigs()
        {
            groupedControls.TabPages.Clear();
            if (deviceView.SelectedItems.Count == 1)
            {
                var descriptor = _deviceStatus.DeviceArray[deviceView.SelectedIndices[0]];
                CTRProductStuff.Devices dev = CTRProductStuff.DeviceStringMap[descriptor.Model];
                uint id = (uint)descriptor.ID & 0x3F;

                //Populate Configs with TalonSRX.json
                FileStream configParams = File.Open("TalonSRX-Grouped.json", FileMode.Open);
                string builtIP = WebServerScripts.buildIP(_connectedIp, dev, id, CTRProductStuff.Action.GetConfig);
                string txt = WebServerScripts.HttpPost(builtIP, configParams).Result;

                GetConfigsReturn configs = JsonConvert.DeserializeObject<GetConfigsReturn>(txt);

                if (configs == null || configs.Device == null || configs.Device.Configs == null)
                {
                    configParams.Close();
                    return;
                }

                foreach (ConfigGroup group in configs.Device.Configs)
                {
                    TabPage newTab = new TabPage();
                    newTab.Text = group.Name;

                    Type t = Type.GetType("DiagServerAccessor." + group.Type);

                    IControlGroup newGroup = (IControlGroup)Activator.CreateInstance(t);

                    newGroup.SetFromValues(group.Values, group.Ordinal);

                    newTab.Controls.Add(newGroup.CreateLayout());

                    groupedControls.TabPages.Add(newTab);
                }

                configParams.Close();
            }
        }

        private void idChangeButton_Click(object sender, EventArgs e)
        {
            if (deviceView.SelectedItems.Count == 1)
            {
                var descriptor = _deviceStatus.DeviceArray[deviceView.SelectedIndices[0]];
                CTRProductStuff.Devices dev = CTRProductStuff.DeviceStringMap[descriptor.Model];
                uint id = (uint)descriptor.ID & 0x3F;
                string extraParameters = "&newid=" + ((int)idChanger.Value).ToString();

                string ret = WebServerScripts.HttpGet(_connectedIp, dev, id, CTRProductStuff.Action.SetID, extraParameters);

                refreshButton_Click(null, null); //Update GUI
            }
        }

        private void nameChangeButton_Click(object sender, EventArgs e)
        {
            if (deviceView.SelectedItems.Count == 1)
            {
                var descriptor = _deviceStatus.DeviceArray[deviceView.SelectedIndices[0]];
                CTRProductStuff.Devices dev = CTRProductStuff.DeviceStringMap[descriptor.Model];
                uint id = (uint)descriptor.ID & 0x3F;
                string extraParameters = "&newname=" + nameChanger.Text;

                string ret = WebServerScripts.HttpGet(_connectedIp, dev, id, CTRProductStuff.Action.SetDeviceName, extraParameters);

                refreshButton_Click(null, null); //Update GUI
            }
        }

        private void selftTestButton_Click(object sender, EventArgs e)
        {
            if (deviceView.SelectedItems.Count == 1)
            {
                var descriptor = _deviceStatus.DeviceArray[deviceView.SelectedIndices[0]];
                CTRProductStuff.Devices dev = CTRProductStuff.DeviceStringMap[descriptor.Model];
                uint id = (uint)descriptor.ID & 0x3F;

                string ret = WebServerScripts.HttpGet(_connectedIp, dev, id, CTRProductStuff.Action.SelfTest);
                SelfTestReturn retClass = JsonConvert.DeserializeObject<SelfTestReturn>(ret);
                selfTestBox.Text = retClass.SelfTest;
            }
        }

        private void firmwareDialogButton_Click(object sender, EventArgs e)
        {
            if (_connectedIp != "")
            {
                OpenFileDialog firmwareDialog = new OpenFileDialog();
                firmwareDialog.Filter = "CRF Firmware File|*.crf";
                firmwareDialog.Title = "Choose a CRF File";
                if (firmwareDialog.ShowDialog() == DialogResult.OK)
                {
                    fileName.Text = firmwareDialog.FileName;
                    WebServerScripts.HttpPost(_connectedIp, firmwareDialog.OpenFile());
                }
            }
        }

        private void updateDeviceButton_Click(object sender, EventArgs e)
        {
            if (deviceView.SelectedItems.Count == 1)
            {
                var descriptor = _deviceStatus.DeviceArray[deviceView.SelectedIndices[0]];
                CTRProductStuff.Devices dev = CTRProductStuff.DeviceStringMap[descriptor.Model];
                uint id = (uint)descriptor.ID & 0x3F;

                new FirmwareUpgradeWindow(descriptor.Name, _connectedIp, dev, id);
                Thread t = new Thread(() => WebServerScripts.HttpGet(_connectedIp, dev, id, CTRProductStuff.Action.UpdateFirmware));
                t.Start(); //Make a thread for firmware update because it blocks for too long otherwise
            }
        }

        private void saveConfigButton_Click(object sender, EventArgs e)
        {

        }

        private void refreshConfigButton_Click(object sender, EventArgs e)
        {
            refreshConfigs();
        }
    }
}
