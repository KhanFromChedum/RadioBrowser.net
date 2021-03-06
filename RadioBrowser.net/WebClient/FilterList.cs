using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace RadioBrowser.net.WebClient
{
    public class FilterList_    
    {
        public string order { get; set; } = "name";
        public bool reverse { get; set; } = false;
        public bool hidebroken { get; set; } = false;
        public int offset { get; set; } = 0;
        public int limit { get; set; } = 100000;
        public string? country { get; set; } = null;

        public string ToJson()
        {
            return JsonSerializer.Serialize<FilterList_>(this);
        }

        public string ToURL()
        {
            string strUrl = "";
            var properties = typeof(FilterList_).GetProperties();

            bool bFirst = true;
            foreach (var property in properties)
            {
                if (property.GetValue(this) != null)
                {
                    if (bFirst)
                    {
                        strUrl = "?";
                        bFirst = false;
                    }
                    else
                    {
                        strUrl += "&";
                    }
                    strUrl += property.Name;
                    strUrl += "=";
                    strUrl += property.GetValue(this).ToString().ToLower();
                }
                
            }

            return strUrl;
        }
    }

    public class FilterListBase
    {
        protected FilterList_ _oFilterlist = new FilterList_();
        public bool Reverse 
        { 
            get
            {
                return _oFilterlist.reverse;
            } 
            set
            {
                _oFilterlist.reverse = value;
            }
        }
        public bool Hidebroken 
        { 
            get
            {
                return _oFilterlist.hidebroken;
            }
            set
            {
                _oFilterlist.hidebroken = value;
            }
        }
        public int Offset
        {
            get
            {
                return _oFilterlist.offset;
            }
            set
            {
                _oFilterlist.offset = value;
            }
        }
        public int Limit
        {
            get
            {
                return _oFilterlist.limit;
            }
            set
            {
                _oFilterlist.limit = value;
            }
        }

        public string ToJson()
        {
            return _oFilterlist.ToJson();
        }

        public string ToURL()
        {
            return _oFilterlist.ToURL();
        }
    }




}
