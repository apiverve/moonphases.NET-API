using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace APIVerve
{
    /// <summary>
    /// Data data
    /// </summary>
    public class Data
    {
        [JsonProperty("phase")]
        public string Phase { get; set; }

        [JsonProperty("phaseEmoji")]
        public string PhaseEmoji { get; set; }

        [JsonProperty("waxing")]
        public bool Waxing { get; set; }

        [JsonProperty("waning")]
        public bool Waning { get; set; }

        [JsonProperty("lunarAge")]
        public double LunarAge { get; set; }

        [JsonProperty("lunarAgePercent")]
        public double LunarAgePercent { get; set; }

        [JsonProperty("lunationNumber")]
        public int LunationNumber { get; set; }

        [JsonProperty("lunarDistance")]
        public double LunarDistance { get; set; }

        [JsonProperty("nextFullMoon")]
        public string NextFullMoon { get; set; }

        [JsonProperty("lastFullMoon")]
        public string LastFullMoon { get; set; }

    }
    /// <summary>
    /// API Response object
    /// </summary>
    public class ResponseObj
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("error")]
        public object Error { get; set; }

        [JsonProperty("data")]
        public Data Data { get; set; }

    }
}
