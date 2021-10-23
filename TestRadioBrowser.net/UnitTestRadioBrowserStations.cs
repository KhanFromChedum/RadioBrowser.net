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
    public class UnitTestRadioBrowserStations
    {
        [TestMethod]
        public async Task GetStationsByTagsTest()
        {
            RadioBrowserStations webClientStations = new RadioBrowserStations();
            List<Station> stations = await webClientStations.GetStationsByTags("metal", new FilterListStation());
            Assert.IsTrue(stations.Count > 0);
        }


        [TestMethod]
        public async Task GetStationsByContainsTagsTest()
        {
            RadioBrowserStations webClientStations = new RadioBrowserStations();
            List<Station> stations = await webClientStations.GetStationsByContainsTags("hard", new FilterListStation());
            Assert.IsTrue(stations.Count > 0);
        }
    }
}
