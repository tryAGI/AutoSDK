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
        [global::System.Text.Json.Serialization.JsonPropertyName("api_token_ttl_days")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int ApiTokenTtlDays { get; set; }

        /// <summary>
        /// Enable JWT API token authentication for this organization
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("api_tokens_enabled")]
        public bool? ApiTokensEnabled { get; set; }

        /// <summary>
        /// Enable legacy API token authentication for this organization
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("legacy_api_tokens_enabled")]
        public bool? LegacyApiTokensEnabled { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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