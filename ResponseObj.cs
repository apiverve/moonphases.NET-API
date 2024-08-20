using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace APIVerve
{
public class data
{
    [JsonProperty("phase")]
    public string phase { get; set; }

    [JsonProperty("phaseEmoji")]
    public string phaseEmoji { get; set; }

    [JsonProperty("waxing")]
    public bool waxing { get; set; }

    [JsonProperty("waning")]
    public bool waning { get; set; }

    [JsonProperty("lunarAge")]
    public double lunarAge { get; set; }

    [JsonProperty("lunarAgePercent")]
    public double lunarAgePercent { get; set; }

    [JsonProperty("lunationNumber")]
    public int lunationNumber { get; set; }

    [JsonProperty("lunarDistance")]
    public double lunarDistance { get; set; }

    [JsonProperty("nextFullMoon")]
    public DateTime nextFullMoon { get; set; }

    [JsonProperty("lastFullMoon")]
    public DateTime lastFullMoon { get; set; }

}

public class ResponseObj
{
    [JsonProperty("status")]
    public string status { get; set; }

    [JsonProperty("error")]
    public object error { get; set; }

    [JsonProperty("data")]
    public data data { get; set; }

    [JsonProperty("code")]
    public int code { get; set; }

}

}
