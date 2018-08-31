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
            PigeonIMURibbon = 21,
            CANifier = 30,
            PCM = 40,
            PDP = 50,
        };
        public static readonly Dictionary<Devices, string> DeviceMap = new Dictionary<Devices, string>()
        {
            { Devices.None, "" },
            { Devices.TalonSRX, "srx" },
            { Devices.VictorSPX, "spx" },
            { Devices.PigeonIMU, "pigeon" },
            { Devices.PigeonIMURibbon, "ribbonPigeon" },
            { Devices.CANifier, "canif" },
            { Devices.PCM, "pcm" },
            { Devices.PDP, "pdp" },

        };
        public static readonly Dictionary<long, Devices> DeviceIDMap = new Dictionary<long, Devices>()
        {
            { 0, Devices.None },
            { 0x0204fc00, Devices.TalonSRX },
            { 0x0104fc00, Devices.VictorSPX },
            { 0x1504fc00, Devices.PigeonIMU },
            { 0x204f400, Devices.PigeonIMURibbon },
            { 0x0304fc00, Devices.CANifier },
            { 0x0904fc00, Devices.PCM },
            { 0x0804fc00, Devices.PDP },
        };
        public static readonly Dictionary<string, Devices> DeviceStringMap = new Dictionary<string, Devices>()
        {
            { "", Devices.None},
            { "Talon SRX", Devices.TalonSRX },
            { "Victor SPX", Devices.VictorSPX },
            { "Pigeon", Devices.PigeonIMU },
            { "Pigeon Over Ribbon", Devices.PigeonIMURibbon },
            { "CANifier", Devices.CANifier },
            { "PCM", Devices.PCM },
            { "PDP", Devices.PDP },

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
            { Action.SetDeviceName, "action=setname" },
            { Action.SelfTest, "action=selftest" },
            { Action.UpdateFirmware, "action=fieldupgrade" },
            { Action.CheckUpdateProgress, "action=progress" },
            { Action.GetConfig, "action=getconfig" },
            { Action.SetConfig, "action=setconfig" },
        };
        public static readonly List<Action> AllActions = Enum.GetValues(typeof(Action)).Cast<Action>().ToList();
    }
}
