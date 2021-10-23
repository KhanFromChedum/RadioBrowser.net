using RadioBrowser.net.Deserializer;
using RadioBrowser.net.WebClient;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

[assembly: InternalsVisibleTo("TestRadioBrowser.net")]
namespace RadioBrowser
{
    public class RadioBrowserStations : WebClientBase
    {
        internal async Task<List<Station>> GetStationsByTags(string strTag,FilterListStation filterList)
        {
            string strJson = await GetStations("bytagexact", strTag, filterList);
            return ConvertStation.GetStations(strJson);
        }

        internal async Task<List<Station>> GetStationsByContainsTags(string strTag, FilterListStation filterList)
        {
            string strJson = await GetStations("bytag", strTag, filterList);
            return ConvertStation.GetStations(strJson);
        }
    }
}
