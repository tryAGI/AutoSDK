//HintName: G.Models.ChatWebSearchShorthandParametersUserLocation.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Approximate user location for location-biased results.
    /// </summary>
    public sealed partial class ChatWebSearchShorthandParametersUserLocation
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.ChatWebSearchShorthandParametersUserLocationTypeJsonConverter))]
        public global::G.ChatWebSearchShorthandParametersUserLocationType? Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("city")]
        public string? City { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("region")]
        public string? Region { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("country")]
        public string? Country { get; set; }

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
        /// Initializes a new instance of the <see cref="ChatWebSearchShorthandParametersUserLocation" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="city"></param>
        /// <param name="region"></param>
        /// <param name="country"></param>
        /// <param name="timezone"></param>
        public ChatWebSearchShorthandParametersUserLocation(
            global::G.ChatWebSearchShorthandParametersUserLocationType? type,
            string? city,
            string? region,
            string? country,
            string? timezone)
        {
            this.Type = type;
            this.City = city;
            this.Region = region;
            this.Country = country;
            this.Timezone = timezone;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatWebSearchShorthandParametersUserLocation" /> class.
        /// </summary>
        public ChatWebSearchShorthandParametersUserLocation()
        {
        }
    }
}