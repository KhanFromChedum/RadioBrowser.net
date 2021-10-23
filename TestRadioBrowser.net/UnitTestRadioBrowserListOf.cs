using Microsoft.VisualStudio.TestTools.UnitTesting;
using RadioBrowser;
using RadioBrowser.net.Deserializer;
using RadioBrowser.net.WebClient;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace TestRadioBrowser.net
{
    [TestClass]
    public class UintTestRadioBrowserListOf
    {
        [TestMethod]
        public async Task GetTagsTest()
        {
            RadioBrowserListOf webClientListOf = new RadioBrowserListOf();
            List<StationCount> stationCounts = await webClientListOf.GetTags(null);
            Assert.IsTrue(stationCounts.Count > 0);
        }

        [TestMethod]
        public async Task GetCountriesTest()
        {
            RadioBrowserListOf webClientListOf = new RadioBrowserListOf();
            List<StationCount> stationCounts = await webClientListOf.GetCountries(null);
            Assert.IsTrue(stationCounts.Count > 0);
        }

        [TestMethod]
        public async Task GetCountryCodesTest()
        {
            RadioBrowserListOf webClientListOf = new RadioBrowserListOf();
            List<StationCount> stationCounts = await webClientListOf.GetCountryCodes(null);
            Assert.IsTrue(stationCounts.Count > 0);
        }


        [TestMethod]
        public async Task GetCodecsTest()
        {
            RadioBrowserListOf webClientListOf = new RadioBrowserListOf();
            List<StationCount> stationCounts = await webClientListOf.GetCodecs(null);
            Assert.IsTrue(stationCounts.Count > 0);
        }


        [TestMethod]
        public async Task GetStatesTest()
        {
            RadioBrowserListOf webClientListOf = new RadioBrowserListOf();
            List<StationCount> stationCounts = await webClientListOf.GetStates(null);
            Assert.IsTrue(stationCounts.Count > 0);
        }

        [TestMethod]
        public async Task GetLanguagesTest()
        {
            RadioBrowserListOf webClientListOf = new RadioBrowserListOf();
            List<StationCount> stationCounts = await webClientListOf.GetLanguages(null);
            Assert.IsTrue(stationCounts.Count > 0);
        }

    }
}
