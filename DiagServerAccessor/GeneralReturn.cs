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
    class EmptyReturn
    {
        public StandardizedReturn GeneralReturn;
    }
}
