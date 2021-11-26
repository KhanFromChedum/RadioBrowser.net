using System;
using System.Collections.Generic;
using System.Text;

namespace RadioBrowser
{
    public class FilterListAdvanced_
    {

        public string? name { get; set; }
        public bool nameExact { get; set; } = false;
        public string? country { get; set; }
        public bool countryExact { get; set; }
        public string? countryCode { get; set; }
        public string? state { get; set; }
        public bool stateExact { get; set;}
        public string? language { get; set; }
        public bool languageExact { get; set; }
        public string? tag { get; set; }
        public bool tagExact { get; set; }
        public string? tagList { get; set; }
        public string? codec { get; set; }
        public uint? bitrateMin { get; set; }
        public uint? bitrateMax { get; set; }
        public bool? has_geo_info { get; set; }
        public bool? has_extended_info { get; set; }
        public bool? is_https { get; set; }
        public string? order { get; set; }
        public bool? reverse { get; set; }
        public uint? offset { get; set; }
        public int? limit { get; set; }
        public bool? hidebroken { get; set; } = false;

        private string _createValueUrl(string strName, object oValue)
        {
            return strName + "=" + oValue.ToString();
        }

        private void _addToUrl(ref string strUrl, string strValue)
        {
            if(strUrl == "?")
            {
                strUrl += strValue;
            }
            else
            {
                strUrl = strUrl + "&" + strValue;
            }
        }

        public string ToURL()
        {
            string strUrl = "?";
            if(name != null)
            {
                _addToUrl(ref strUrl, _createValueUrl(nameof(name), name));
                _addToUrl(ref strUrl, _createValueUrl(nameof(nameExact), nameExact));
            }
            if (country != null)
            {
                _addToUrl(ref strUrl, _createValueUrl(nameof(country), country));
                _addToUrl(ref strUrl, _createValueUrl(nameof(countryExact), countryExact));
            }
            if(state!=null)
            {
                _addToUrl(ref strUrl, _createValueUrl(nameof(state), state));
                _addToUrl(ref strUrl, _createValueUrl(nameof(stateExact), stateExact));
            }
            if (language != null)
            {
                _addToUrl(ref strUrl, _createValueUrl(nameof(language), language));
                _addToUrl(ref strUrl, _createValueUrl(nameof(languageExact), languageExact));
            }
            if (tag != null)
            {
                _addToUrl(ref strUrl, _createValueUrl(nameof(tag), tag));
                _addToUrl(ref strUrl, _createValueUrl(nameof(tagExact), tagExact));
            }
            if(tagList!=null)
            {
                _addToUrl(ref strUrl, _createValueUrl(nameof(tagList), tagList));
            }
            if (codec != null)
            {
                _addToUrl(ref strUrl, _createValueUrl(nameof(codec), codec));
            }
            if (bitrateMin != null)
            {
                _addToUrl(ref strUrl, _createValueUrl(nameof(bitrateMin), bitrateMin));
            }
            if (bitrateMax != null)
            {
                _addToUrl(ref strUrl, _createValueUrl(nameof(bitrateMax), bitrateMax));
            }
            if (has_geo_info != null)
            {
                _addToUrl(ref strUrl, _createValueUrl(nameof(has_geo_info), has_geo_info));
            }
            if (has_extended_info != null)
            {
                _addToUrl(ref strUrl, _createValueUrl(nameof(has_extended_info), has_extended_info));
            }
            if (is_https != null)
            {
                _addToUrl(ref strUrl, _createValueUrl(nameof(is_https), is_https));
            }
            if (order != null)
            {
                _addToUrl(ref strUrl, _createValueUrl(nameof(order), order));
            }
            if (reverse != null)
            {
                _addToUrl(ref strUrl, _createValueUrl(nameof(reverse), reverse));
            }
            if (offset != null)
            {
                _addToUrl(ref strUrl, _createValueUrl(nameof(offset), offset));
            }
            if (limit != null)
            {
                _addToUrl(ref strUrl, _createValueUrl(nameof(limit), limit));
            }
            if (hidebroken != null)
            {
                _addToUrl(ref strUrl, _createValueUrl(nameof(hidebroken), hidebroken));
            }

            return strUrl;
        }
    }

    public class FilterListAdvanced
    {
        public enum ORDERBY { name, url, homepage, favicon, tags, country, state, language, votes, codec, bitrate, lastcheckok, lastchecktime, clicktimestamp, clickcount, clicktrend, changetimestamp, random };
        FilterListAdvanced_ filterListAdvanced = new FilterListAdvanced_();
        public string? Name
        {
            get
            {
                return filterListAdvanced.name;
            }
            set
            {
                filterListAdvanced.name = value;
            }
        }
        public bool NameExact
        {
            get
            {
                return filterListAdvanced.nameExact;
            }
            set
            {
                filterListAdvanced.nameExact = value;
            }
        }
        public string? Country
        {
            get
            {
                return filterListAdvanced.country;
            }
            set
            {
                filterListAdvanced.country = value;
            }
        }
        public bool CountryExact
        {
            get
            {
                return filterListAdvanced.countryExact;
            }
            set
            {
                filterListAdvanced.countryExact = value;
            }
        }
        public string? CountryCode
        {
            get
            {
                return filterListAdvanced.countryCode;
            }
            set
            {
                filterListAdvanced.countryCode = value;
            }
        }
        public string? State
        {
            get
            {
                return filterListAdvanced.state;
            }
            set
            {
                filterListAdvanced.state = value;
            }
        }
        public bool StateExact
        {
            get
            {
                return filterListAdvanced.stateExact;
            }
            set
            {
                filterListAdvanced.stateExact = value;
            }
        }
        public string? Language
        {
            get
            {
                return filterListAdvanced.language;
            }
            set
            {
                filterListAdvanced.language = value;
            }
        }
        public bool LanguageExact
        {
            get
            {
                return filterListAdvanced.languageExact;
            }
            set
            {
                filterListAdvanced.languageExact = value;
            }
        }
        public string? Tag
        {
            get
            {
                return filterListAdvanced.tag;
            }
            set
            {
                filterListAdvanced.tag = value;
            }
        }
        public bool TagExact
        {
            get
            {
                return filterListAdvanced.tagExact;
            }
            set
            {
                filterListAdvanced.tagExact = value;
            }
        }
        public string? TagList
        {
            get
            {
                return filterListAdvanced.tagList;
            }
            set
            {
                filterListAdvanced.tagList = value;
            }
        }
        public string? Codec
        {
            get
            {
                return filterListAdvanced.codec;
            }
            set
            {
                filterListAdvanced.codec = value;
            }
        }
        public uint? BitrateMin
        {
            get
            {
                return filterListAdvanced.bitrateMin;
            }
            set
            {
                filterListAdvanced.bitrateMin = value;
            }
        }
        public uint? BitrateMax
        {
            get
            {
                return filterListAdvanced.bitrateMax;
            }
            set
            {
                filterListAdvanced.bitrateMax = value;
            }
        }
        public bool? Has_geo_info
        {
            get
            {
                return filterListAdvanced.has_geo_info;
            }
            set
            {
                filterListAdvanced.has_geo_info = value;
            }
        }
        public bool? Has_extended_info
        {
            get
            {
                return filterListAdvanced.has_extended_info;
            }
            set
            {
                filterListAdvanced.has_extended_info = value;
            }
        }
        public bool? Is_https
        {
            get
            {
                return filterListAdvanced.is_https;
            }
            set
            {
                filterListAdvanced.is_https = value;
            }
        }
        public ORDERBY? Order
        {
            get
            {
                return (ORDERBY)Enum.Parse(typeof(ORDERBY), filterListAdvanced.order);
            }
            set
            {
                filterListAdvanced.order = value.ToString();
            }
        }
        public bool? Reverse
        {
            get
            {
                return filterListAdvanced.reverse;
            }
            set
            {
                filterListAdvanced.reverse = value;
            }
        }
        public uint? Offset
        {
            get
            {
                return filterListAdvanced.offset;
            }
            set
            {
                filterListAdvanced.offset = value;
            }
        }
        public int? Limit
        {
            get
            {
                return filterListAdvanced.limit;
            }
            set
            {
                filterListAdvanced.limit = value;
            }
        }
        public bool? Hidebroken
        {
            get
            {
                return filterListAdvanced.hidebroken;
            }
            set
            {
                filterListAdvanced.hidebroken = value;
            }
        }

        public string ToURL()
        {
            return filterListAdvanced.ToURL();
        }
    }
}
