using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.Json;

[assembly: InternalsVisibleTo("TestRadioBrowser.net")]
namespace RadioBrowser.net.Deserializer
{
    
    internal class ConvertStationCount: ConvertJson
    {
        public static  List<StationCount> GetStationCounts(string strJson)
        {
            List<StationCount> stationCounts = null;
            JsonSerializer.Deserialize<List<StationCount>>(strJson);
            return stationCounts;
        }
    }
}
