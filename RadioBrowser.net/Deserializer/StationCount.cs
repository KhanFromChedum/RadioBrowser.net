﻿namespace RadioBrowser.net.Deserializer
{
    internal class StationCount_
    {
        public string name { get; set; }
        public int stationcount { get; set; }
    }

    internal class StationCount
    {
        public StationCount(StationCount_ stationCount)
        {
            _oStationCount = stationCount;
        }

        private StationCount_ _oStationCount;

        public string name
        {
            get
            {
                return _oStationCount.name;
            }
        }

        public int stationcount
        {
            get
            {
                return _oStationCount.stationcount;
            }
        }
    }
}