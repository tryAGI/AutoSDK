//HintName: G.Models.BrowserbaseProxyConfig.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BrowserbaseProxyConfig
    {
        /// <summary>
        /// Type of proxy. Always use 'browserbase' for the Browserbase managed proxy network.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.BrowserbaseProxyConfigTypeJsonConverter))]
        public global::G.BrowserbaseProxyConfigType Type { get; set; }

        /// <summary>
        /// Geographic location for the proxy. Optional.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("geolocation")]
        public global::G.BrowserbaseProxyConfigGeolocation? Geolocation { get; set; }

        /// <summary>
        /// Domain pattern for which this proxy should be used. If omitted, defaults to all domains. Optional.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("domainPattern")]
        public string? DomainPattern { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BrowserbaseProxyConfig" /> class.
        /// </summary>
        /// <param name="type">
        /// Type of proxy. Always use 'browserbase' for the Browserbase managed proxy network.
        /// </param>
        /// <param name="geolocation">
        /// Geographic location for the proxy. Optional.
        /// </param>
        /// <param name="domainPattern">
        /// Domain pattern for which this proxy should be used. If omitted, defaults to all domains. Optional.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BrowserbaseProxyConfig(
            global::G.BrowserbaseProxyConfigType type,
            global::G.BrowserbaseProxyConfigGeolocation? geolocation,
            string? domainPattern)
        {
            this.Type = type;
            this.Geolocation = geolocation;
            this.DomainPattern = domainPattern;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BrowserbaseProxyConfig" /> class.
        /// </summary>
        public BrowserbaseProxyConfig()
        {
        }
    }
}