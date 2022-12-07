using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Pinger
{
   class HostFindManager
   {
      private List<DeviceInfo> devices;

      public void Scan(SearchFilter searchFilter)
      {
         devices = _scan(searchFilter);
      }

      public void ReScan(SearchFilter searchFilter)
      {
         devices.RemoveAll(x => x.ScanState == -1);

         List<DeviceInfo> tmpScanDevices = _scan(searchFilter);

         foreach (var dev in devices)
         {
            if (tmpScanDevices.Exists(x => x.IP == dev.IP))
               dev.ScanState = 0;
            else dev.ScanState = -1;
         }

         foreach(var tmp in tmpScanDevices)
         {
            if(!devices.Exists(x => x.IP == tmp.IP))
            {
               tmp.ScanState = 1;
               devices.Add(tmp);
            }
         }
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
         foreach (DeviceInfo device in devices)
         {
            yield return device;
         }
      }
   }
}
