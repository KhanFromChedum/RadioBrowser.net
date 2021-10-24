using RadioBrowser.net.Deserializer;
using RadioBrowser.net.WebClient;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

[assembly: InternalsVisibleTo("TestRadioBrowser.net")]

namespace RadioBrowser
{
    /// <summary>
    /// retreive radio stations
    /// </summary>
    public class RadioBrowserStations : WebClientBase
    {
        /// <summary>
        /// retreive station by tags
        /// </summary>
        /// <param name="strTag">tag</param>
        /// <param name="filterList">filter to apply</param>
        /// <param name="bExact">true if exact tag</param>
        /// <returns>station list</returns>
        internal async Task<List<Station>> GetStationsByTags(string strTag, FilterListStation filterList =null, bool bExact = false)
        {
            string strJson;
            if (bExact)
            {
                strJson = await GetStations("bytagexact", strTag, filterList);
            }
            else
            {
                strJson = await GetStations("bytag", strTag, filterList);
            }

            return ConvertStation.GetStations(strJson);
        }

        /// <summary>
        /// retreive station by uuid
        /// </summary>
        /// <param name="strUUID">station unique identifier</param>
        /// <param name="filterList">filter to apply</param>
        /// <returns>station list</returns>
        internal async Task<List<Station>> GetStationsByUUID(string strUUID, FilterListStation filterList = null)
        {
            string strJson = await GetStations("byuuid", strUUID, filterList);
            return ConvertStation.GetStations(strJson);
        }

        /// <summary>
        /// retreive station by uuid
        /// </summary>
        /// <param name="guid">station unique identifier</param>
        /// <param name="filterList">filter to apply</param>
        /// <returns>station list</returns>
        internal async Task<List<Station>> GetStationsByUUID(Guid guid, FilterListStation filterList = null)
        {
            return await GetStationsByUUID(guid.ToString(), filterList);
        }

        /// <summary>
        /// retreive stations by name
        /// </summary>
        /// <param name="strName">name of the station</param>
        /// <param name="filterList">filter to apply</param>
        /// <param name="bExact">true if exact name</param>
        /// <returns>station list</returns>
        internal async Task<List<Station>> GetStationsByName(string strName, FilterListStation filterList =null, bool bExact = false)
        {
            string strJson;
            if (bExact)
            {
                strJson = await GetStations("bynameexact", strName, filterList);
            }
            else
            {
                strJson = await GetStations("byname", strName, filterList);
            }
            return ConvertStation.GetStations(strJson);
        }

        /// <summary>
        /// retreive station by codec
        /// </summary>
        /// <param name="strCodec">codec to find</param>
        /// <param name="filterList">filter to apply</param>
        /// <param name="bExact">true if exact name</param>
        /// <returns>station list</returns>
        internal async Task<List<Station>> GetStationsByCodec(string strCodec, FilterListStation filterList =null, bool bExact = false)
        {
            string strJson;
            if (bExact)
            {
                strJson = await GetStations("bycodecexact", strCodec, filterList);
            }
            else
            {
                strJson = await GetStations("bycodec", strCodec, filterList);
            }
            return ConvertStation.GetStations(strJson);
        }

        /// <summary>
        /// retreive station by country
        /// </summary>
        /// <param name="strCountry">country to find</param>
        /// <param name="filterList">filter to apply</param>
        /// <param name="bExact">true if exact</param>
        /// <returns>station list</returns>
        internal async Task<List<Station>> GetStationsByCountry(string strCountry, FilterListStation filterList=null, bool bExact = false)
        {
            string strJson;
            if (bExact)
            {
                strJson = await GetStations("bycountryexact", strCountry, filterList);
            }
            else
            {
                strJson = await GetStations("bycountry", strCountry, filterList);
            }
            return ConvertStation.GetStations(strJson);
        }

        /// <summary>
        /// retreive station by state
        /// </summary>
        /// <param name="strState">state to find</param>
        /// <param name="filterList">filter to apply</param>
        /// <param name="bExact">true if exact</param>
        /// <returns>station list</returns>
        internal async Task<List<Station>> GetStationsByState(string strState, FilterListStation filterList=null, bool bExact = false)
        {
            string strJson;
            if (bExact)
            {
                strJson = await GetStations("bystateexact", strState, filterList);
            }
            else
            {
                strJson = await GetStations("bystate", strState, filterList);
            }
            return ConvertStation.GetStations(strJson);
        }

        /// <summary>
        /// retreive station by language
        /// </summary>
        /// <param name="strLanguage">language to find</param>
        /// <param name="filterList">filter to apply</param>
        /// <param name="bExact">true if exact</param>
        /// <returns>station list</returns>
        internal async Task<List<Station>> GetStationsByLanguage(string strLanguage, FilterListStation filterList=null, bool bExact = false)
        {
            string strJson;
            if (bExact)
            {
                strJson = await GetStations("bylanguageexact", strLanguage, filterList);
            }
            else
            {
                strJson = await GetStations("bylanguage", strLanguage, filterList);
            }
            return ConvertStation.GetStations(strJson);
        }
    }
}