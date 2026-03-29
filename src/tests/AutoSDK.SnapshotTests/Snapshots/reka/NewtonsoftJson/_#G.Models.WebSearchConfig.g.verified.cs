//HintName: G.Models.WebSearchConfig.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Web search configuration for the Research model.
    /// </summary>
    public sealed partial class WebSearchConfig
    {
        /// <summary>
        /// Whether web search is enabled. Enabled by default.<br/>
        /// Default Value: true
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Maximum number of web searches per request. Once reached, the agent reasons with available information.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("max_uses")]
        public int? MaxUses { get; set; }

        /// <summary>
        /// Whitelist of domains. Cannot be used with blocked_domains.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("allowed_domains")]
        public global::System.Collections.Generic.IList<string>? AllowedDomains { get; set; }

        /// <summary>
        /// Blacklist of domains. Cannot be used with allowed_domains.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("blocked_domains")]
        public global::System.Collections.Generic.IList<string>? BlockedDomains { get; set; }

        /// <summary>
        /// Geographic context for localized search results.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("user_location")]
        public global::G.UserLocation? UserLocation { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebSearchConfig" /> class.
        /// </summary>
        /// <param name="enabled">
        /// Whether web search is enabled. Enabled by default.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="maxUses">
        /// Maximum number of web searches per request. Once reached, the agent reasons with available information.
        /// </param>
        /// <param name="allowedDomains">
        /// Whitelist of domains. Cannot be used with blocked_domains.
        /// </param>
        /// <param name="blockedDomains">
        /// Blacklist of domains. Cannot be used with allowed_domains.
        /// </param>
        /// <param name="userLocation">
        /// Geographic context for localized search results.
        /// </param>
        public WebSearchConfig(
            bool? enabled,
            int? maxUses,
            global::System.Collections.Generic.IList<string>? allowedDomains,
            global::System.Collections.Generic.IList<string>? blockedDomains,
            global::G.UserLocation? userLocation)
        {
            this.Enabled = enabled;
            this.MaxUses = maxUses;
            this.AllowedDomains = allowedDomains;
            this.BlockedDomains = blockedDomains;
            this.UserLocation = userLocation;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebSearchConfig" /> class.
        /// </summary>
        public WebSearchConfig()
        {
        }
    }
}