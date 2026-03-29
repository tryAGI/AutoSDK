//HintName: G.Models.ApproximateLocation.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Approximate geographic location. At least one field is required.
    /// </summary>
    public sealed partial class ApproximateLocation
    {
        /// <summary>
        /// City name (e.g., "San Francisco").
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("city")]
        public string? City { get; set; }

        /// <summary>
        /// State/region code (e.g., "CA").
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("region")]
        public string? Region { get; set; }

        /// <summary>
        /// ISO 3166-1 country code (e.g., "US").
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("country")]
        public string? Country { get; set; }

        /// <summary>
        /// IANA timezone (e.g., "America/Los_Angeles").
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("timezone")]
        public string? Timezone { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ApproximateLocation" /> class.
        /// </summary>
        /// <param name="city">
        /// City name (e.g., "San Francisco").
        /// </param>
        /// <param name="region">
        /// State/region code (e.g., "CA").
        /// </param>
        /// <param name="country">
        /// ISO 3166-1 country code (e.g., "US").
        /// </param>
        /// <param name="timezone">
        /// IANA timezone (e.g., "America/Los_Angeles").
        /// </param>
        public ApproximateLocation(
            string? city,
            string? region,
            string? country,
            string? timezone)
        {
            this.City = city;
            this.Region = region;
            this.Country = country;
            this.Timezone = timezone;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApproximateLocation" /> class.
        /// </summary>
        public ApproximateLocation()
        {
        }
    }
}