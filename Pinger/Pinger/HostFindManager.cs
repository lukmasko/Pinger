using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Pinger
{
   class HostFindManager
   {
      private List<DeviceInfo> firstScanDevices;
      private List<DeviceInfo> secondScanDevices;

      public void Scan(SearchFilter searchFilter)
      {
         secondScanDevices = null;
         firstScanDevices = _scan(searchFilter);
      }

      public void ReScan(SearchFilter searchFilter)
      {
         secondScanDevices = _scan(searchFilter);
      }

      private List<DeviceInfo> _scan(SearchFilter searchFilter)
      {
         List<DeviceInfo> finded = new List<DeviceInfo>();

         var tasks = new Task<DeviceInfo>[searchFilter.SearchTo];
         for (ushort i = searchFilter.SearchFrom; i <= searchFilter.SearchTo; i++)
         {
            string ip = String.Format("192.168.{0}.{1}", searchFilter.Subnet, i);

            tasks[i - 1] = Task.Run(() => HostFind.GetInfo(new SearchFilter(ip, searchFilter.Subnet, searchFilter.SearchFrom, searchFilter.SearchTo, searchFilter.Timeout, searchFilter.RetryCount)));
         }

         Task.WaitAll(tasks);

         for (int i = 0; i < searchFilter.SearchTo; i++)
         {
            if (tasks[i].Result.PingResult == false)
               continue;

            finded.Add(tasks[i].Result);
         }

         return finded;
      }

      internal IEnumerable<DeviceInfo> getDevices()
      {
         foreach (DeviceInfo device in firstScanDevices)
         {
            yield return device;
         }
      }
   }
}
