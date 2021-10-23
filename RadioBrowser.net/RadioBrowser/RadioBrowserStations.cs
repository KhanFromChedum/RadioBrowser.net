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

        internal async Task<List<Station>> GetStationsByUUID(string strUUID, FilterListStation filterList)
        {
            string strJson = await GetStations("byuuid", strUUID, filterList);
            return ConvertStation.GetStations(strJson);
        }

        internal async Task<List<Station>> GetStationsByUUID(Guid guid, FilterListStation filterList)
        {
            return await GetStationsByUUID(guid.ToString(), filterList);
        }

        internal async Task<List<Station>> GetStationsByName(string strName, FilterListStation filterList)
        {
            string strJson = await GetStations("bynameexact", strName, filterList);
            return ConvertStation.GetStations(strJson);
        }

        internal async Task<List<Station>> GetStationsByContainsName(string strName, FilterListStation filterList)
        {
            string strJson = await GetStations("byname", strName, filterList);
            return ConvertStation.GetStations(strJson);
        }

        internal async Task<List<Station>> GetStationsByCodec(string strCodec, FilterListStation filterList)
        {
            string strJson = await GetStations("bycodecexact", strCodec, filterList);
            return ConvertStation.GetStations(strJson);
        }

        internal async Task<List<Station>> GetStationsByContainsCodec(string strCodec, FilterListStation filterList)
        {
            string strJson = await GetStations("bycodec", strCodec, filterList);
            return ConvertStation.GetStations(strJson);
        }

        internal async Task<List<Station>> GetStationsByCountry(string strCountry, FilterListStation filterList)
        {
            string strJson = await GetStations("bycountryexact", strCountry, filterList);
            return ConvertStation.GetStations(strJson);
        }

        internal async Task<List<Station>> GetStationsByContainsCountry(string strCountry, FilterListStation filterList)
        {
            string strJson = await GetStations("bycountry", strCountry, filterList);
            return ConvertStation.GetStations(strJson);
        }

        internal async Task<List<Station>> GetStationsByState(string strState, FilterListStation filterList)
        {
            string strJson = await GetStations("bystateexact", strState, filterList);
            return ConvertStation.GetStations(strJson);
        }

        internal async Task<List<Station>> GetStationsByContainsState(string strState, FilterListStation filterList)
        {
            string strJson = await GetStations("bystate", strState, filterList);
            return ConvertStation.GetStations(strJson);
        }

        internal async Task<List<Station>> GetStationsByLanguage(string strLanguage, FilterListStation filterList)
        {
            string strJson = await GetStations("bylanguageexact", strLanguage, filterList);
            return ConvertStation.GetStations(strJson);
        }

        internal async Task<List<Station>> GetStationsByContainsLanguage(string strLanguage, FilterListStation filterList)
        {
            string strJson = await GetStations("bylanguage", strLanguage, filterList);
            return ConvertStation.GetStations(strJson);
        }
    }
}
