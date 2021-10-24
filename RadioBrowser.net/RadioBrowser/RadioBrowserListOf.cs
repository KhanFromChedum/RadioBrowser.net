using RadioBrowser.net.Deserializer;
using RadioBrowser.net.WebClient;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

[assembly: InternalsVisibleTo("TestRadioBrowser.net")]

namespace RadioBrowser
{
    /// <summary>
    /// Retreive list of element associated to radio stations
    /// </summary>
    public class RadioBrowserListOf : WebClientBase
    {
        /// <summary>
        /// Get all tags available
        /// </summary>
        /// <param name="filterList">filter to apply</param>
        /// <returns>list of tags</returns>
        internal async Task<List<StationCount>> GetTags(FilterListStationCount filterList)
        {
            string strJson = await GetList("tags", filterList);
            return ConvertStationCount.GetStationCounts(strJson);
        }
        /// <summary>
        /// Get all countries available
        /// </summary>
        /// <param name="filterList">filter to apply</param>
        /// <returns>list of countries</returns>
        internal async Task<List<StationCount>> GetCountries(FilterListStationCount filterList)
        {
            string strJson = await GetList("countries", filterList);
            return ConvertStationCount.GetStationCounts(strJson);
        }
        /// <summary>
        /// Get all country codes available
        /// </summary>
        /// <param name="filterList">filter to apply</param>
        /// <returns>list of country codes</returns>
        internal async Task<List<StationCount>> GetCountryCodes(FilterListStationCount filterList)
        {
            string strJson = await GetList("countrycodes", filterList);
            return ConvertStationCount.GetStationCounts(strJson);
        }
        /// <summary>
        /// Get all codecs available
        /// </summary>
        /// <param name="filterList">filter to apply</param>
        /// <returns>list of codecs</returns>
        internal async Task<List<StationCount>> GetCodecs(FilterListStationCount filterList)
        {
            string strJson = await GetList("codecs", filterList);
            return ConvertStationCount.GetStationCounts(strJson);
        }
        /// <summary>
        /// Get all states available
        /// </summary>
        /// <param name="filterList">filter to apply</param>
        /// <returns>list of states</returns>
        internal async Task<List<StationCount>> GetStates(FilterListStatesStationCount filterList)
        {
            string strJson = await GetList("states", filterList);
            return ConvertStationCount.GetStationCounts(strJson);
        }
        /// <summary>
        /// Get all langages available
        /// </summary>
        /// <param name="filterList">filter to apply</param>
        /// <returns>list of languages</returns>
        internal async Task<List<StationCount>> GetLanguages(FilterListStationCount filterList)
        {
            string strJson = await GetList("languages", filterList);
            return ConvertStationCount.GetStationCounts(strJson);
        }
    }
}