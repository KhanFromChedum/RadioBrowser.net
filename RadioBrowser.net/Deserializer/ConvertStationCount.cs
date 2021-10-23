using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text.Json;

[assembly: InternalsVisibleTo("TestRadioBrowser.net")]

namespace RadioBrowser.net.Deserializer
{
    internal class ConvertStationCount : ConvertJson
    {
        public static List<StationCount> GetStationCounts(string strJson)
        {
            List<StationCount> oStationCounts = new List<StationCount>();
            List<StationCount_> oStationCounts_ = null;
            oStationCounts_ = JsonSerializer.Deserialize<List<StationCount_>>(strJson);

            foreach (var oStationCount_ in oStationCounts_)
            {
                oStationCounts.Add(new StationCount(oStationCount_));
            }
            return oStationCounts;
        }
    }
}