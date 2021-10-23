using System;
using System.Collections.Generic;
using System.Text;

namespace RadioBrowser
{
    public class FilterListStatesStationCount : FilterListStationCount
    {
        public string? Country
        {
            get
            {
                return _oFilterlist.country;
            }
            set
            {
                _oFilterlist.country = value;
            }
        }
    }
}
