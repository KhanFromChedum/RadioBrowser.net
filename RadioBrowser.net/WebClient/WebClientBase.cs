﻿using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

[assembly: InternalsVisibleTo("TestRadioBrowser.net")]
namespace RadioBrowser.net.WebClient
{
    public class WebClientBase
    {
        private HttpClient httpClient = new HttpClient();
        private string strClient = @"http://fr1.api.radio-browser.info/json/";

        internal async Task<string> GetList(string strSearchTerm, FilterListBase filterList)
        {
            if(filterList == null)
            {
                filterList = new FilterListBase();
            }
            var content = new StringContent(filterList.ToJson(), Encoding.UTF8, "application/json");
            var result = await httpClient.PostAsync(strClient + strSearchTerm, content);
            return await result.Content.ReadAsStringAsync();
        }

        internal async Task<string> GetStations(string strSearchItem,string strSearchTerm, FilterListBase filterList)
        {
            if(filterList == null)
            {
                filterList = new FilterListBase();
            }
            var content = new StringContent(filterList.ToJson(), Encoding.UTF8, "application/json");
            var result = await httpClient.PostAsync(strClient + @"stations/"+ strSearchItem +  @"/" +strSearchTerm, content);
            return await result.Content.ReadAsStringAsync();
        }
    }
}
