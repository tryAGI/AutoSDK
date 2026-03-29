//HintName: G.Models.PreviewWebSearchUserLocation.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PreviewWebSearchUserLocation
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.PreviewWebSearchUserLocationTypeJsonConverter))]
        public global::G.PreviewWebSearchUserLocationType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("city")]
        public string? City { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("country")]
        public string? Country { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("region")]
        public string? Region { get; set; }

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
        /// Initializes a new instance of the <see cref="PreviewWebSearchUserLocation" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="city"></param>
        /// <param name="country"></param>
        /// <param name="region"></param>
        /// <param name="timezone"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PreviewWebSearchUserLocation(
            global::G.PreviewWebSearchUserLocationType type,
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
        /// Initializes a new instance of the <see cref="PreviewWebSearchUserLocation" /> class.
        /// </summary>
        public PreviewWebSearchUserLocation()
        {
        }
    }
}