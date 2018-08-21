using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiagServerAccessor
{
    public static class CTRProductStuff
    {
        public enum Devices
        {
            None = 0,
            TalonSRX = 10,
            VictorSPX = 12,
            PigeonIMU = 20,
            CANifier = 30,
            PCM = 40,
            PDP = 50,
        };

        public enum Action
        {
            None,
            GetDeviceList,
            Blink,
            SetID,
            SetDeviceName,
            SelfTest,
            UpdateFirmware,
            CheckUpdateProgress,
            GetConfig,
            SetConfig
        }
        public static Dictionary<Action, string> ActionMap = new Dictionary<Action, string>()
        {
            { Action.None, "" },
            { Action.GetDeviceList, "?action=getdevices"},
            { Action.Blink, "?action=blink" },
            { Action.SetID, "?action=setid" },
            { Action.SetDeviceName, "?action=setid" },
            { Action.SelfTest, "?action=selftest" },
            { Action.UpdateFirmware, "?action=fieldupgrade" },
            { Action.CheckUpdateProgress, "?action=progress" },
            { Action.GetConfig, "?action=getconfig" },
            { Action.SetConfig, "?action=setconfig" },
        };
    }
}
