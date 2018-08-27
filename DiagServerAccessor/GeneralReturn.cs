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
}

#pragma warning restore 0649
