using System;
using System.Collections.Generic;
using System.Net;
using System.Net.NetworkInformation;
using ArpLookup;

namespace Pinger
{
   struct OrganisationData
   {
      public string registry;
      public string assignment;
      public string organisation_name;
      public string organisation_address;
   }

   class AppMac
   {
      private List<OrganisationData> organisations;
      private static AppMac _instance;

      public static AppMac GetInstance()
      {
         if(_instance == null)
         {
            _instance = new AppMac();
         }
         return _instance;
      }

      private AppMac()
      {
         organisations = new List<OrganisationData>();

         try
         {
            foreach (string line in System.IO.File.ReadLines(@"org.csv"))
            {
               var data = line.Split(',');

               OrganisationData org = new OrganisationData();
               org.registry = data[0];
               org.assignment = data[1];
               org.organisation_name = data[2];
               org.organisation_address = data[3];

               organisations.Add(org);
            }
         }
         catch (Exception) { }
      }

      public string getOrganisationName(string mac)
      {
         var tmp = mac.Split(':');
         string pmac = tmp[0] + tmp[1] + tmp[2];
         int index = organisations.FindIndex(x => x.assignment == pmac);

         if (index < 0)
            return "Brak danych";
         return organisations[index].organisation_name;
      }

      public string getMac(string ip)
      {
         string res = string.Empty;

         try
         {
            IPAddress ipaddress = IPAddress.Parse(ip);
            PhysicalAddress pa_mac = Arp.Lookup(ipaddress);

            string t = pa_mac.ToString();
            res = t.Substring(0, 2) + ":" + t.Substring(2, 2) + ":" + t.Substring(4, 2) + ":" + t.Substring(6, 2) + ":" + t.Substring(8, 2) + ":" + t.Substring(10, 2);
         }
         catch (Exception) { }

         return res;
      }
   }
}
