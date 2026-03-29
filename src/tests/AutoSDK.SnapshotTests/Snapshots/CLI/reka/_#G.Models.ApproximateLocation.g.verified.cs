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
        [global::System.Text.Json.Serialization.JsonPropertyName("city")]
        public string? City { get; set; }

        /// <summary>
        /// State/region code (e.g., "CA").
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("region")]
        public string? Region { get; set; }

        /// <summary>
        /// ISO 3166-1 country code (e.g., "US").
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("country")]
        public string? Country { get; set; }

        /// <summary>
        /// IANA timezone (e.g., "America/Los_Angeles").
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timezone")]
        public string? Timezone { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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