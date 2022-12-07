using Newtonsoft.Json;
using System.IO;

namespace Pinger
{
   class SettingsManager : SearchFilter
   {
      private const string default_filename = "settings.json";

      public SettingsManager()
      {
         Load();
      }

      public void Save()
      {
         File.WriteAllText(default_filename, JsonConvert.SerializeObject(this));
      }

      public void Load()
      {
         if (!File.Exists(default_filename))
         {
            //setDefault();
            Save();xxx
            return;
         }

         var obj = JsonConvert.DeserializeObject<SearchFilter>(File.ReadAllText(default_filename));

         /*public string IP;
      public ushort Subnet;
      public ushort SearchFrom;
      public ushort SearchTo;
      public ushort Timeout;
      public ushort RetryCount;*/

         IP = obj.IP;
      }
   }
}
