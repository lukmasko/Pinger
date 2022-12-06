using System;

namespace Pinger
{
   class HostFind
   {
      public static DeviceInfo GetInfo(SearchFilter searchFilter)
      {
         DeviceInfo deviceInfo = new DeviceInfo();

         deviceInfo.IP = searchFilter.IP;

         do
         {
            Console.WriteLine(searchFilter.IP);
            bool pingRes = AppPing.GetResult(searchFilter.IP, searchFilter.Timeout, searchFilter.RetryCount);

            if (!pingRes)
               break;

            string host = AppDns.getHostname(searchFilter.IP);
            if (host == string.Empty)
               host = "Brak danych";

            AppMac appMac = AppMac.GetInstance();
            string mac = appMac.getMac(searchFilter.IP);
            if (mac == string.Empty)
               mac = "Brak danych";

            string org = (mac == string.Empty) ? "-" : appMac.getOrganisationName(mac);

            deviceInfo.PingResult = pingRes;
            deviceInfo.MacAddress = mac;
            deviceInfo.OrganisationName = org;
            deviceInfo.HostName = host;

            break;
         } while (true);

         return deviceInfo;
      }
   }
}
