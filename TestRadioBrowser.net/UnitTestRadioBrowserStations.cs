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
            List<Station> stations = await webClientStations.GetStationsByTags("metal");
            Assert.IsTrue(stations.Count > 0);
        }

        [TestMethod]
        public async Task GetStationsByTagsfilterTest()
        {
            RadioBrowserStations webClientStations = new RadioBrowserStations();
            List<Station> stations = await webClientStations.GetStationsByTags("metal", new FilterListStation() {Limit=1 });
            Assert.IsTrue(stations.Count == 1);
        }

        [TestMethod]
        public async Task GetStationsByTagsExactTest()
        {
            RadioBrowserStations webClientStations = new RadioBrowserStations();
            List<Station> stations = await webClientStations.GetStationsByTags("hard", new FilterListStation(), true);
            Assert.IsTrue(stations.Count > 0);
        }

        [TestMethod]
        public async Task GetStationsByUUID()
        {
            RadioBrowserStations webClientStations = new RadioBrowserStations();
            List<Station> stations = await webClientStations.GetStationsByTags("metal", new FilterListStation());
            Assert.IsTrue(stations.Count > 0);
            List<Station> stationUUID = await webClientStations.GetStationsByUUID(stations[0].Stationuuid, new FilterListStation());
            Assert.IsTrue(stationUUID.Count == 1);
        }
    }
}
