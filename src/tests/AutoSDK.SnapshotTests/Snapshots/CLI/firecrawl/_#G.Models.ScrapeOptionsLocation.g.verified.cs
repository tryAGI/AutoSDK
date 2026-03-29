//HintName: G.Models.ScrapeOptionsLocation.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Location settings for the request. When specified, this will use an appropriate proxy if available and emulate the corresponding language and timezone settings. Defaults to 'US' if not specified.
    /// </summary>
    public sealed partial class ScrapeOptionsLocation
    {
        /// <summary>
        /// ISO 3166-1 alpha-2 country code (e.g., 'US', 'AU', 'DE', 'JP')<br/>
        /// Default Value: US
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("country")]
        public string? Country { get; set; }

        /// <summary>
        /// Preferred languages and locales for the request in order of priority. Defaults to the language of the specified location. See https://developer.mozilla.org/en-US/docs/Web/HTTP/Headers/Accept-Language
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("languages")]
        public global::System.Collections.Generic.IList<string>? Languages { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ScrapeOptionsLocation" /> class.
        /// </summary>
        /// <param name="country">
        /// ISO 3166-1 alpha-2 country code (e.g., 'US', 'AU', 'DE', 'JP')<br/>
        /// Default Value: US
        /// </param>
        /// <param name="languages">
        /// Preferred languages and locales for the request in order of priority. Defaults to the language of the specified location. See https://developer.mozilla.org/en-US/docs/Web/HTTP/Headers/Accept-Language
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ScrapeOptionsLocation(
            string? country,
            global::System.Collections.Generic.IList<string>? languages)
        {
            this.Country = country;
            this.Languages = languages;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ScrapeOptionsLocation" /> class.
        /// </summary>
        public ScrapeOptionsLocation()
        {
        }
    }
}