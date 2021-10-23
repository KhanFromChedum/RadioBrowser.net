using RadioBrowser.net.WebClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace RadioBrowser
{
    public class FilterListStationCount : FilterListBase
    {
        public enum ORDERBY { name, stationcount };

        public ORDERBY Order
        {
            get
            {
                return (ORDERBY)Enum.Parse(typeof(ORDERBY), _oFilterlist.order);
            }
            set
            {
                _oFilterlist.order = value.ToString();
            }
        }
    }
}
