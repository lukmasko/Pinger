using System;
using System.Net.NetworkInformation;

namespace Pinger
{
   class AppPing
   {
      public static bool GetResult(string ip, ushort timeout, ushort retry)
      {
         Ping pingSender = new Ping();
         PingReply reply;
         int counter = 0;

         try
         {
            do
            {
               reply = pingSender.Send(ip, (int)timeout);

               if (reply.Status == IPStatus.Success)
                  return true;

               if (++counter >= retry)
                  break;
            }
            while (true);
         }
         catch (Exception) { }

         return false;
      }
   }
}
