using Microsoft.VisualStudio.TestTools.UnitTesting;
using RadioBrowser;
using RadioBrowser.net.WebClient;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace TestRadioBrowser.net
{
    [TestClass]
    public class UnitTestFilterListStation
    {
        [TestMethod]
        public void OrderTest()
        {
            FilterListStation filterListStation = new FilterListStation();
            filterListStation.Order = FilterListStation.ORDERBY.bitrate;

            Assert.AreEqual(FilterListStation.ORDERBY.bitrate, filterListStation.Order);
        }
    }
}
