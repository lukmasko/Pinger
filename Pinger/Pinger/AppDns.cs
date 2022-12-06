using System;
using System.Net;

namespace Pinger
{
   class AppDns
   {
      static public string getHostname(string ip)
      {
         string res = string.Empty;

         try
         {
            res = Dns.GetHostByAddress(ip).HostName;
         }
         catch (Exception) { }

         return res;
      }
   }
}
