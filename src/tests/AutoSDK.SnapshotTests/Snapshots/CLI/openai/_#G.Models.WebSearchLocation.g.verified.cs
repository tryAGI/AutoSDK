//HintName: G.Models.WebSearchLocation.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Approximate location parameters for the search.
    /// </summary>
    public sealed partial class WebSearchLocation
    {
        /// <summary>
        /// The two-letter <br/>
        /// [ISO country code](https://en.wikipedia.org/wiki/ISO_3166-1) of the user,<br/>
        /// e.g. `US`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("country")]
        public string? Country { get; set; }

        /// <summary>
        /// Free text input for the region of the user, e.g. `California`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("region")]
        public string? Region { get; set; }

        /// <summary>
        /// Free text input for the city of the user, e.g. `San Francisco`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("city")]
        public string? City { get; set; }

        /// <summary>
        /// The [IANA timezone](https://timeapi.io/documentation/iana-timezones) <br/>
        /// of the user, e.g. `America/Los_Angeles`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timezone")]
        public string? Timezone { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebSearchLocation" /> class.
        /// </summary>
        /// <param name="country">
        /// The two-letter <br/>
        /// [ISO country code](https://en.wikipedia.org/wiki/ISO_3166-1) of the user,<br/>
        /// e.g. `US`.
        /// </param>
        /// <param name="region">
        /// Free text input for the region of the user, e.g. `California`.
        /// </param>
        /// <param name="city">
        /// Free text input for the city of the user, e.g. `San Francisco`.
        /// </param>
        /// <param name="timezone">
        /// The [IANA timezone](https://timeapi.io/documentation/iana-timezones) <br/>
        /// of the user, e.g. `America/Los_Angeles`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WebSearchLocation(
            string? country,
            string? region,
            string? city,
            string? timezone)
        {
            this.Country = country;
            this.Region = region;
            this.City = city;
            this.Timezone = timezone;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebSearchLocation" /> class.
        /// </summary>
        public WebSearchLocation()
        {
        }
    }
}