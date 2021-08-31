using Newtonsoft.Json;

public class LocationRoot {
    [JsonProperty("location")]
    public Location Location { get; set; }
    [JsonProperty("current")]
    public CurrentTemp CurrentTemp { get; set; }
}

public class Location {
    [JsonProperty("name")]
    public string Name { get; set; }
    [JsonProperty("region")]
    public string Region { get; set; }
    [JsonProperty("country")]
    public string Country { get; set; }
    [JsonProperty("lat")]
    public double Latitude { get; set; }
    [JsonProperty("lon")]
    public double Longitude { get; set; }
    [JsonProperty("tz_id")]
    public string Timezone { get; set; }
    [JsonProperty("localtime")]
    public string Localtime { get; set; }
}

public class CurrentTemp {
    [JsonProperty("last_updated")]
    public string Last_Updated_Time { get; set; }
    [JsonProperty("temp_c")]
    public double Temp_C { get; set; }
    [JsonProperty("temp_f")]
    public double Temp_F { get; set; }
    [JsonProperty("uv")]
    public double UV_Index { get; set; }
}



