//HintName: G.Models.WebSearchUserLocation.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// User location information for web search
    /// </summary>
    public sealed partial class WebSearchUserLocation
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.WebSearchUserLocationType? Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("city")]
        public string? City { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("country")]
        public string? Country { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("region")]
        public string? Region { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("timezone")]
        public string? Timezone { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebSearchUserLocation" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="city"></param>
        /// <param name="country"></param>
        /// <param name="region"></param>
        /// <param name="timezone"></param>
        public WebSearchUserLocation(
            global::G.WebSearchUserLocationType? type,
            string? city,
            string? country,
            string? region,
            string? timezone)
        {
            this.Type = type;
            this.City = city;
            this.Country = country;
            this.Region = region;
            this.Timezone = timezone;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebSearchUserLocation" /> class.
        /// </summary>
        public WebSearchUserLocation()
        {
        }
    }
}