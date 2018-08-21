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
        public static readonly Dictionary<Devices, uint> DeviceMap = new Dictionary<Devices, uint>()
        {
            { Devices.None, 0 },
            { Devices.TalonSRX, 0x0204fc00 },

        };
        public static readonly List<Devices> AllDevices = Enum.GetValues(typeof(Devices)).Cast<Devices>().ToList();

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
        };
        public static readonly Dictionary<Action, string> ActionMap = new Dictionary<Action, string>()
        {
            { Action.None, "" },
            { Action.GetDeviceList, "action=getdevices"},
            { Action.Blink, "action=blink" },
            { Action.SetID, "action=setid" },
            { Action.SetDeviceName, "action=setid" },
            { Action.SelfTest, "action=selftest" },
            { Action.UpdateFirmware, "action=fieldupgrade" },
            { Action.CheckUpdateProgress, "action=progress" },
            { Action.GetConfig, "action=getconfig" },
            { Action.SetConfig, "action=setconfig" },
        };
        public static readonly List<Action> AllActions = Enum.GetValues(typeof(Action)).Cast<Action>().ToList();
    }
}
