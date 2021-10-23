using Microsoft.VisualStudio.TestTools.UnitTesting;
using RadioBrowser;
using RadioBrowser.net.WebClient;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace TestRadioBrowser.net
{
    [TestClass]
    public class UnitTestWebClient
    {
        [TestMethod]
        public async Task TestGetList()
        {
            WebClientBase webClient = new WebClientBase();
            string str = await webClient.GetList("tags", new FilterListStationCount());
            Assert.IsFalse(string.IsNullOrEmpty(str));
        }

        [TestMethod]
        public async Task TestGetStation()
        {
            WebClientBase webClient = new WebClientBase();
            string str = await webClient.GetStations("bytag", "metal",new FilterListStation());
            Assert.IsFalse(string.IsNullOrEmpty(str));
        }
    }
}
