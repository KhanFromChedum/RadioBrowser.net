using RadioBrowser.net.WebClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace RadioBrowser
{
    public class FilterListStation : FilterListBase
    {
        public enum ORDERBY { name, url, homepage, favicon, tags, country, state, language, votes, codec, bitrate, lastcheckok, lastchecktime, clicktimestamp, clickcount, clicktrend, changetimestamp, random };

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
