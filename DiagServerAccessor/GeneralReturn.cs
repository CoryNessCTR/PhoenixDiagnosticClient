#pragma warning disable 0649

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiagServerAccessor
{
    class StandardizedReturn
    {
        public string Action;
        public string Device;
        public int Error;
        public string ErrorMessage;
        public string ID;
    }
    class DeviceDescriptor
    {
        public string BootloaderRev;
        public string CurrentVers;
        public int DynID;
        public string HardwareRev;
        public int ID;
        public string ManDate;
        public string Model;
        public string Name;
        public string SoftStatus;
        public int UniqID;
    }
    class EmptyReturn
    {
        public StandardizedReturn GeneralReturn;
    }
    class BlinkReturn
    {
        public StandardizedReturn GeneralReturn;
    }
    class IDReturn
    {
        public StandardizedReturn GeneralReturn;
        public int NewID;
    }
    class NameReturn
    {
        public StandardizedReturn GeneralReturn;
        public string NewName;
    }
    class ProgressReturn
    {
        public StandardizedReturn GeneralReturn;
        public int progress;
    }
    class SelfTestReturn
    {
        public StandardizedReturn GeneralReturn;
        public string SelfTest;
    }
    class GetDevicesReturn
    {
        public StandardizedReturn GeneralReturn;
        public DeviceDescriptor[] DeviceArray;
    }
    class GetConfigsReturn
    {
        public StandardizedReturn GeneralReturn;
        public DeviceConfigs Device;
    }
    class SetConfigReturn
    {
        public StandardizedReturn GeneralReturn;
        public DeviceConfigs Device;
    }
    class FirmwareUpdateReturn
    {
        public StandardizedReturn GeneralReturn;
        public string UpdateMessage;
        public string Path;
        public string Size;
    }
    //Config JSON's////
    class ConfigGroup
    {
        public string Name;
        public string Type;
        public string Description;
        public int Ordinal;

        public object Values;
    }
    class DeviceConfigs
    {
        public ConfigGroup[] Configs;
    }
}

#pragma warning restore 0649
