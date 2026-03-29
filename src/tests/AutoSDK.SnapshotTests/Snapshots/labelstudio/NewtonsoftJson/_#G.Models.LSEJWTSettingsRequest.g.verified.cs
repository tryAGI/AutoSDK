//HintName: G.Models.LSEJWTSettingsRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class LSEJWTSettingsRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("api_token_ttl_days", Required = global::Newtonsoft.Json.Required.Always)]
        public int ApiTokenTtlDays { get; set; } = default!;

        /// <summary>
        /// Enable JWT API token authentication for this organization
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("api_tokens_enabled")]
        public bool? ApiTokensEnabled { get; set; }

        /// <summary>
        /// Enable legacy API token authentication for this organization
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("legacy_api_tokens_enabled")]
        public bool? LegacyApiTokensEnabled { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LSEJWTSettingsRequest" /> class.
        /// </summary>
        /// <param name="apiTokenTtlDays"></param>
        /// <param name="apiTokensEnabled">
        /// Enable JWT API token authentication for this organization
        /// </param>
        /// <param name="legacyApiTokensEnabled">
        /// Enable legacy API token authentication for this organization
        /// </param>
        public LSEJWTSettingsRequest(
            int apiTokenTtlDays,
            bool? apiTokensEnabled,
            bool? legacyApiTokensEnabled)
        {
            this.ApiTokenTtlDays = apiTokenTtlDays;
            this.ApiTokensEnabled = apiTokensEnabled;
            this.LegacyApiTokensEnabled = legacyApiTokensEnabled;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LSEJWTSettingsRequest" /> class.
        /// </summary>
        public LSEJWTSettingsRequest()
        {
        }
    }
}