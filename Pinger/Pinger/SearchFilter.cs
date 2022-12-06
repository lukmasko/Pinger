using System;

namespace Pinger
{
   class SearchFilter
   {
      public string IP;
      public ushort Subnet;
      public ushort SearchFrom;
      public ushort SearchTo;
      public ushort Timeout;
      public ushort RetryCount;

      public SearchFilter() { }

      public SearchFilter(string _ip, ushort _subnet, ushort _from, ushort _to, ushort _timeout, ushort _retry)
      {
         IP = _ip;
         Subnet = _subnet;
         SearchFrom = _from;
         SearchTo = _to;
         Timeout = _timeout;
         RetryCount = _retry;
      }
   }
}
