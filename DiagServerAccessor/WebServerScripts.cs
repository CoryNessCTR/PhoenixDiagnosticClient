﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Management;
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
            if (ListAllNetworkAdapters() == 0)
                return new string[] { "localhost" };
            else
                return new string[] { "localhost", "172.22.11.2" };
        }
        
        public static string HttpPost(string ip, Stream file, int timeout = 2000)
        {
            string boundary = "||-----------------||";
            WebRequest client = WebRequest.Create(ip);
            client.Method = "POST";
            client.ContentLength = file.Length + boundary.Length + 2 + boundary.Length + 4;
            client.ContentType = "multipart/form-data; boundary=\"" + boundary + "\"\r\n\r\n";
            client.Timeout = timeout;

            Form1.GetInstance().Invoke(new Action(() =>
            {
                Form1.GetInstance().returnList.Items.Add("POST: " + ip);
            }));

            string retval;
            try
            {
                using (var mpStream = (client.GetRequestStream()))
                {
                    /* Follow convention of form-data with boundaries */
                    mpStream.Write(Encoding.UTF8.GetBytes("--"), 0, 2);
                    mpStream.Write(Encoding.UTF8.GetBytes(boundary), 0, boundary.Length);
                    file.CopyTo(mpStream);
                    mpStream.Write(Encoding.UTF8.GetBytes("--"), 0, 2);
                    mpStream.Write(Encoding.UTF8.GetBytes(boundary), 0, boundary.Length);
                    mpStream.Write(Encoding.UTF8.GetBytes("--"), 0, 2);

                    mpStream.Close();
                }

                using (WebResponse response = client.GetResponse())
                {

                    Stream dataStream = response.GetResponseStream();
                    StreamReader reader = new StreamReader(dataStream);
                    //Got the string resposne
                    retval = reader.ReadToEnd();

                    //Clean up afterwards
                    reader.Close();
                    dataStream.Close();
                    response.Close();
                }
                
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                retval = "";
            }

            Form1.GetInstance().Invoke(new Action(() =>
            {
                Form1.GetInstance().returnList.Items.Add(retval);
            }));

            return retval;
        }
        public static string buildIP(string baseIP, CTRProductStuff.Devices device, uint deviceID, CTRProductStuff.Action action, string extraOptions = "")
        {
            string address = baseIP;
            address += "?";
            switch (device)
            {
                case CTRProductStuff.Devices.None:
                    break; //No device selected, fall through
                default:
                    address += "device=" + CTRProductStuff.DeviceMap[device];
                    break;
            }
            address += "&";

            address += "id=" + deviceID;

            address += "&";

            switch (action)
            {
                case CTRProductStuff.Action.None:
                    break; //Just calling the address for a ping
                case CTRProductStuff.Action.SetID:
                case CTRProductStuff.Action.SetDeviceName:
                case CTRProductStuff.Action.UpdateFirmware:
                    address += CTRProductStuff.ActionMap[action] + extraOptions;
                    break;
                default:
                    address += CTRProductStuff.ActionMap[action];
                    break;
            }
            address = Uri.EscapeUriString(address);
            return address;
        }
        public static string HttpGet(string ip, CTRProductStuff.Devices device, uint deviceID, CTRProductStuff.Action action, string extraOptions = "", int timeout = 500)
        {
            string address = buildIP(ip, device, deviceID, action, extraOptions);
            Console.WriteLine(address);
            string retval = "";
            
            Form1.GetInstance().Invoke(new Action(() =>
            {
                Form1.GetInstance().returnList.Items.Add("GET: "+address);
            }));

            //Request a GET at specified address
            WebRequest request = WebRequest.Create(address);
            request.Timeout = timeout;
            try
            {
                //Stream malarky to get response from GET request
                using (WebResponse response = request.GetResponse())
                {
                    Stream dataStream = response.GetResponseStream();
                    StreamReader reader = new StreamReader(dataStream);
                    //Got the string resposne
                    retval = reader.ReadToEnd();

                    //Clean up afterwards
                    reader.Close();
                    dataStream.Close();
                    response.Close();
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.ToString());
                retval = "Failed";
            }

            Form1.GetInstance().Invoke(new Action(() =>
            {
                Form1.GetInstance().returnList.Items.Add(retval);
            }));
            //Return that string
            return retval;
        }


        /////////////
        private static int ListAllNetworkAdapters()
        {
            int retval = 0;
            ManagementObjectSearcher networkAdapterSearcher = new ManagementObjectSearcher("root\\cimv2", "select * from Win32_NetworkAdapterConfiguration");
            ManagementObjectCollection objectCollection = networkAdapterSearcher.Get();

            //Console.WriteLine("There are {0} network adapaters: ", objectCollection.Count);

            foreach (ManagementObject networkAdapter in objectCollection)
            {
                PropertyDataCollection networkAdapterProperties = networkAdapter.Properties;

                bool caption = false;
                bool ipenabled = false;

                foreach (PropertyData networkAdapterProperty in networkAdapterProperties)
                {
                    if (networkAdapterProperty.Value != null)
                    {
                        string name = networkAdapterProperty.Name;
                        string value = networkAdapterProperty.Value.ToString();

                        // Console.WriteLine("Network adapter property name: {0}", networkAdapterProperty.Name);
                        //Console.WriteLine("Network adapter property value: {0}", networkAdapterProperty.Value);

                        name = name.ToUpper();
                        value = value.ToUpper();

                        if (name.Contains("CAPTION") && value.Contains("NATIONAL INSTRUMENTS USBLAN ADAPTER"))
                        {
                            caption = true;
                        }
                        if (name.Contains("IPENABLED") && value.Contains("TRUE"))
                        {
                            ipenabled = true;
                        }
                    }
                }

                if (caption && ipenabled)
                {
                    ++retval;
                }

                //Console.WriteLine("---------------------------------------");
            }
            return retval;
        }
    }
}
