//HintName: G.Models.ChatWebSearchShorthandUserLocation.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Approximate user location for location-biased results.
    /// </summary>
    public sealed partial class ChatWebSearchShorthandUserLocation
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ChatWebSearchShorthandUserLocationTypeJsonConverter))]
        public global::G.ChatWebSearchShorthandUserLocationType? Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("city")]
        public string? City { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("region")]
        public string? Region { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("country")]
        public string? Country { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timezone")]
        public string? Timezone { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatWebSearchShorthandUserLocation" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="city"></param>
        /// <param name="region"></param>
        /// <param name="country"></param>
        /// <param name="timezone"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatWebSearchShorthandUserLocation(
            global::G.ChatWebSearchShorthandUserLocationType? type,
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
        /// Initializes a new instance of the <see cref="ChatWebSearchShorthandUserLocation" /> class.
        /// </summary>
        public ChatWebSearchShorthandUserLocation()
        {
        }
    }
}