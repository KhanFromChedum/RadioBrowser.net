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
    public class RadioBrowserListOf : WebClientBase
    {
        internal async Task<List<StationCount>> GetTags(FilterListStationCount filterList)
        {
            string strJson = await GetList("tags", filterList);
            return ConvertStationCount.GetStationCounts(strJson);
        }

        internal async Task<List<StationCount>> GetCountries(FilterListStationCount filterList)
        {
            string strJson = await GetList("countries", filterList);
            return ConvertStationCount.GetStationCounts(strJson);
        }

        internal async Task<List<StationCount>> GetCountryCodes(FilterListStationCount filterList)
        {
            string strJson = await GetList("countrycodes", filterList);
            return ConvertStationCount.GetStationCounts(strJson);
        }

        internal async Task<List<StationCount>> GetCodecs(FilterListStationCount filterList)
        {
            string strJson = await GetList("codecs", filterList);
            return ConvertStationCount.GetStationCounts(strJson);
        }

        internal async Task<List<StationCount>> GetStates(FilterListStatesStationCount filterList)
        {
            string strJson = await GetList("states", filterList);
            return ConvertStationCount.GetStationCounts(strJson);
        }

        internal async Task<List<StationCount>> GetLanguages(FilterListStationCount filterList)
        {
            string strJson = await GetList("languages", filterList);
            return ConvertStationCount.GetStationCounts(strJson);
        }



    }
}
