using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace RadioBrowser.net.Deserializer
{
    class ConvertStation
    {
        public static List<Station> GetStations(string strJson)
        {
            List<Station> oStations = new List<Station>();
            List<Station_> oStations_ = null;
            var options = new JsonSerializerOptions
            {
                ReadCommentHandling = JsonCommentHandling.Skip,
                AllowTrailingCommas = true,
            };

            oStations_ = JsonSerializer.Deserialize<List<Station_>>(strJson, options);

            foreach (var oStation_ in oStations_)
            {
                oStations.Add(new Station(oStation_));
            }
            return oStations;
        }
    }
}
