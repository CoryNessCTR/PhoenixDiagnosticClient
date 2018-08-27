using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace DiagServerAccessor
{
    class FirmwareUpgradeWindow : Form
    {
        public FirmwareUpgradeWindow(string deviceName, string ip, CTRProductStuff.Devices device, uint deviceID) : base()
        {
            Width = 500;
            Height = 100;
            Text = deviceName + " Firmware Update Status";

            ProgressBar pr = new ProgressBar();
            TableLayoutPanel layoutPanel = new TableLayoutPanel();
            Label label = new Label();

            label.Text = "Progress";
            label.Dock = DockStyle.Fill;

            pr.Dock = DockStyle.Fill;
            pr.Minimum = 0;
            pr.Maximum = 100;

            layoutPanel.ColumnCount = 1;
            layoutPanel.RowCount = 2;
            layoutPanel.Dock = DockStyle.Fill;
            layoutPanel.Controls.Add(label);
            layoutPanel.Controls.Add(pr);

            Controls.Add(layoutPanel);

            Show();

            Thread t = new Thread(() => updateThread(ip, device, deviceID, pr));
            t.Start();            
        }

        private void updateThread(string ip, CTRProductStuff.Devices device, uint deviceID, ProgressBar updateBar)
        {
            ProgressReturn returnClass;
            bool starting = true;
            do
            {
                string ret = WebServerScripts.HttpGet(ip, device, deviceID, CTRProductStuff.Action.CheckUpdateProgress);
                returnClass = JsonConvert.DeserializeObject<ProgressReturn>(ret);
                if (returnClass != null)
                {
                    if (returnClass.progress != 0) starting = false;
                    Invoke(new Action(() => 
                        {
                        updateBar.Value = returnClass.progress; //Update in UI Thread
                    }));
                }
                Thread.Sleep(100);
            } while (returnClass == null || returnClass.progress != 0 || starting);

            Invoke(new Action(() =>
            {
                Close();
            }));
        }
    }
}
