//HintName: G.Models.BrowserbaseProxyConfigGeolocation.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Geographic location for the proxy. Optional.
    /// </summary>
    public sealed partial class BrowserbaseProxyConfigGeolocation
    {
        /// <summary>
        /// Name of the city. Use spaces for multi-word city names. Optional.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("city")]
        public string? City { get; set; }

        /// <summary>
        /// US state code (2 characters). Must also specify US as the country. Optional.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("state")]
        public string? State { get; set; }

        /// <summary>
        /// Country code in ISO 3166-1 alpha-2 format
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("country")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Country { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BrowserbaseProxyConfigGeolocation" /> class.
        /// </summary>
        /// <param name="country">
        /// Country code in ISO 3166-1 alpha-2 format
        /// </param>
        /// <param name="city">
        /// Name of the city. Use spaces for multi-word city names. Optional.
        /// </param>
        /// <param name="state">
        /// US state code (2 characters). Must also specify US as the country. Optional.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BrowserbaseProxyConfigGeolocation(
            string country,
            string? city,
            string? state)
        {
            this.City = city;
            this.State = state;
            this.Country = country ?? throw new global::System.ArgumentNullException(nameof(country));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BrowserbaseProxyConfigGeolocation" /> class.
        /// </summary>
        public BrowserbaseProxyConfigGeolocation()
        {
        }
    }
}