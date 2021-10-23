using Microsoft.VisualStudio.TestTools.UnitTesting;
using RadioBrowser.net.Deserializer;
using System.Collections.Generic;

namespace TestRadioBrowser.net
{
    [TestClass]
    public class UnitTestConvertStationCount
    {
        [TestMethod]
        public void TestGetStationCounts()
        {
            List<StationCount> stationcounts = ConvertStationCount.GetStationCounts("[{\"name\": \"AT\",\"stationcount\":1},{\"name\": \"DE\",\"stationcount\": 5 }]");

            Assert.AreEqual(2, stationcounts.Count);
            Assert.AreEqual("AT", stationcounts[0].name);
            Assert.AreEqual(1, stationcounts[0].stationcount);

            Assert.AreEqual("DE", stationcounts[1].name);
            Assert.AreEqual(5, stationcounts[1].stationcount);
        }

        [TestMethod]
        public void TestGetStations()
        {
            List<Station> stations = ConvertStation.GetStations("[{\"changeuuid\":\"01234567-89ab-cdef-0123-456789abcdef\",\"stationuuid\":\"01234567-89ab-cdef-0123-456789abcdef\",\"name\":\"Best Radio\",\"url\":\"http://www.example.com/test.pls\",\"url_resolved\":\"http://stream.example.com/mp3_128\",\"homepage\":\"https://www.example.com\",\"favicon\":\"https://www.example.com/icon.png\",\"tags\":\"jazz,pop,rock,indie\",\"country\":\"Switzerland\",\"countrycode\":\"US\",\"iso_3166_2\": \"US-NY\",\"state\":\"\",\"language\":\"german,english\",\"languagecodes\":\"ger,eng\",\"votes\":0,\"lastchangetime\":\"2019-12-12 18:37:02\",\"lastchangetime_iso8601\":\"2019-12-12T18:37:02Z\",\"codec\":\"MP3\",\"bitrate\":128,\"hls\":0,\"lastcheckok\":1,\"lastchecktime\":\"2020-01-09 18:16:35\",\"lastchecktime_iso8601\":\"2020-01-09T18:16:35Z\",\"lastcheckoktime\":\"2020-01-09 18:16:35\",\"lastcheckoktime_iso8601\":\"2020-01-09T18:16:35Z\",\"lastlocalchecktime\":\"2020-01-08 23:18:38\",\"lastlocalchecktime_iso8601\":\"2020-01-08T23:18:38Z\",\"clicktimestamp\":\"\",\"clicktimestamp_iso8601\":null,\"clickcount\":0,\"clicktrend\":0,\"ssl_error\": 0,\"geo_lat\": 1.1,\"geo_long\": -2.2,\"has_extended_info\": false}]");
            Assert.AreEqual(1, stations.Count);
        }
    }
}