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
            List<StationCount> stationcounts =  ConvertStationCount.GetStationCounts(@"               [
                {
                  'name': 'AT',
                  'stationcount': '1'
                },
                {
                  'name': 'DE',
                  'stationcount': '5'
                } 
                ]");

            Assert.AreEqual(2, stationcounts.Count);

        }
    }
}
