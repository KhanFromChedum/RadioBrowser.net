using System;
using System.Collections.Generic;

namespace RadioBrowser
{
    public class Station_
    {
        public string changeuuid { get; set; }
        public string stationuuid { get; set; }
        public string name { get; set; }
        public string url { get; set; }
        public string url_resolved { get; set; }
        public string homepage { get; set; }
        public string favicon { get; set; }
        public string tags { get; set; }
        public string country { get; set; }
        public string countrycode { get; set; }
        public string state { get; set; }
        public string language { get; set; }
        public string languagecodes { get; set; }
        public uint votes { get; set; }
        public string lastchangetime { get; set; }
        public string lastchangetime_iso8601 { get; set; }
        public string codec { get; set; }
        public uint bitrate { get; set; }
        public uint hls { get; set; }
        public uint lastcheckok { get; set; }
        public string lastchecktime { get; set; }
        public string lastchecktime_iso8601 { get; set; }
        public string lastlocalchecktime { get; set; }
        public string lastlocalchecktime_iso8601 { get; set; }
        public string clicktimestamp { get; set; }
        public string clicktimestamp_iso8601 { get; set; }
        public uint clickcount { get; set; }
        public int clicktrend { get; set; }
        public uint ssl_error { get; set; }
        public double? geo_lat { get; set; }
        public double? geo_long { get; set; }
        public bool has_extended_info { get; set; }
    }

    public class Station
    {
        private Station_ _oStation;

        public Station(Station_ oStation)
        {
            _oStation = oStation;
        }

        public Guid Changeuuid
        {
            get
            {
                return Guid.Parse(_oStation.changeuuid);
            }
        }

        public Guid Stationuuid
        {
            get
            {
                return Guid.Parse(_oStation.stationuuid);
            }
        }

        public string Name { get { return _oStation.name; } }
        public string Url { get { return _oStation.url; } }
        public string Url_resolved { get { return _oStation.url_resolved; } }
        public string Homepage { get { return _oStation.homepage; } }
        public string Favicon { get { return _oStation.favicon; } }
        public List<string> Tags 
        {
            get
            {
                return new List<string>(_oStation.tags.Split(new char[]{ ','})); 
            } 
        }
        public string Country { get { return _oStation.country; } }
        public string Countrycode { get { return _oStation.countrycode; } }
        public string State { get { return _oStation.state; } }
        public string Language { get { return _oStation.language; } }
        public string Languagecodes { get { return _oStation.languagecodes; } }
        public uint Votes { 
            get
            {
                return _oStation.votes;
            }
        }
        public DateTime lastchangetime 
        { 
            get 
            { 
                return DateTime.Parse(_oStation.lastchangetime); 
            } 
        }

        public DateTime Lastchangetime_iso8601 
        {
            get
            {
                return DateTime.Parse(_oStation.lastchangetime_iso8601);
            }
        }
        public string Codec { get { return _oStation.codec; } }
        public uint Bitrate
        {
            get
            {
                return _oStation.bitrate;
            }
        }
        public bool Hls
        {
            get
            {
                return _oStation.hls == 1;
            }
        }
        public bool Lastcheckok
        {
            get
            {
                return _oStation.lastcheckok == 1;
            }
        }
        public DateTime Lastchecktime
        {
            get
            {
                return DateTime.Parse(_oStation.lastchecktime);
            }
        }
        public DateTime Lastchecktime_iso8601
        {
            get
            {
                return DateTime.Parse(_oStation.lastchecktime_iso8601);
            }
        }
        public DateTime Lastlocalchecktime 
        { 
            get
            {
                return DateTime.Parse(_oStation.lastlocalchecktime);
            }
        }
        public DateTime Lastlocalchecktime_iso8601
        {
            get
            {
                return DateTime.Parse(_oStation.lastlocalchecktime_iso8601);
            }
        }
        public DateTime Clicktimestamp
        {
            get
            {
                return DateTime.Parse(_oStation.clicktimestamp);
            }
        }
        public DateTime Clicktimestamp_iso8601
        {
            get
            {
                return DateTime.Parse(_oStation.clicktimestamp_iso8601);
            }
        }
        public uint Clickcount
        {
            get
            {
                return _oStation.clickcount;
            }
        }
        public int Clicktrend 
        { 
            get
            {
                return _oStation.clicktrend;
            }
        }
        public bool ssl_error
        {
            get
            {
                return _oStation.ssl_error == 1;
            }
        }
        public double? Geo_lat 
        { 
            get
            {
                return _oStation.geo_lat;
            }
        }
        public double? Geo_long 
        { 
            get
            {
                return _oStation.geo_long;
            }
        }
        public bool Has_extended_info 
        { 
            get
            {
                return _oStation.has_extended_info;
            }
        }
    }
}