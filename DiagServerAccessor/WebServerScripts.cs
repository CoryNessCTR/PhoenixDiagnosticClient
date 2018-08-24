using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Http;
using System.IO;

namespace DiagServerAccessor
{
    public static class WebServerScripts
    {
        private readonly static HttpClient _client = new HttpClient();
        public const int PingReturn = -800;

        public static string[] GetIPAddrs()
        {
            return new string[] { "localhost" };
        }

        public static async void HttpPost(string ip, Stream file)
        {
            HttpContent filestream = new StreamContent(file);
            
            var client = new HttpClient();
            try
            {
                var response = await client.PostAsync(ip, filestream);
            }
            catch(Exception e)
            {

            }
        }
        public static string HttpGet(string ip, CTRProductStuff.Devices device, uint deviceID, CTRProductStuff.Action action, string extraOptions = "")
        {
            string address = ip;
            bool startedAddress = false;
            switch (device)
            {
                case CTRProductStuff.Devices.None:
                    break; //No device selected, fall through
                default:
                    startedAddress = true;
                    address += "?deviceid=" + (CTRProductStuff.DeviceMap[device] | deviceID).ToString("X");
                    break;
            }
            if (startedAddress) address += "&";
            else address += "?";
            switch (action)
            {
                case CTRProductStuff.Action.None:
                    break; //Just calling the adderss for a ping
                case CTRProductStuff.Action.SetConfig:
                    break; //TODO: Implement this
                case CTRProductStuff.Action.SetID:
                case CTRProductStuff.Action.SetDeviceName:
                case CTRProductStuff.Action.UpdateFirmware:
                    address += CTRProductStuff.ActionMap[action] + extraOptions;
                    break;
                default:
                    address += CTRProductStuff.ActionMap[action];
                    break;
            }
            Console.WriteLine(address);
            string retval = "";
            //Request a GET at specified address
            WebRequest request = WebRequest.Create(address);
            try
            {
                //Stream malarky to get response from GET request
                WebResponse response = request.GetResponse();
                Stream dataStream = response.GetResponseStream();
                StreamReader reader = new StreamReader(dataStream);
                //Got the string resposne
                retval = reader.ReadToEnd();

                //Clean up afterwards
                reader.Close();
                dataStream.Close();
                response.Close();
            }
            catch(Exception e)
            {
                retval = "Failed";
            }

            //Return that string
            return retval;
        }
    }
}
