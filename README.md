# RADIOBROWSER.NET


## HOWTO use radiobrowser.net ?

There is 2 classes to use radiobrowser. 
The first one, _RadioBrowserListOf_ allows you to get all informations in ordrer to retreive radio stations.

- **GetTags**: get all tags (metal, triphop, ...)
- **GetCountries**: get all countries (ireland, poland,...)
- **GetCountryCodes**: get all country codes (US,EN,...)
- **GetCodecs**: get all codecs (MP3,OGG,...)
- **GetStates**: get all states (alabama, florida,...)
- **GetLanguages**: get all languages (english, german,...)

The second one, _RadioBrowserStations_ allows you to get all radio station.

- **GetStationsByTags**: get all station using a tag (metal, classic,...)
- **GetStationsByUUID**: get a station with a given uuid 
- **GetStationsByName**: get a station using a name (nrj, fusion,...)
- **GetStationsByCodec**: get all stations using a specific codec (mp3, ogg,...)
- **GetStationsByCountry**: get all stations from a specific country (spain, italy,...)
- **GetStationsByState**: get all stations form a specific state (wisconsin, florida,...)
- **GetStationsByLanguage**: get all stations using a specific language (french, polish,...)