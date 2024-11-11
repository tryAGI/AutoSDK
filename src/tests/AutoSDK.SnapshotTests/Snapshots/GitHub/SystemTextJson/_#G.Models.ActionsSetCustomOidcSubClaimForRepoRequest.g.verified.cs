//HintName: G.Models.ActionsSetCustomOidcSubClaimForRepoRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Actions OIDC subject customization for a repository
    /// </summary>
    public sealed partial class ActionsSetCustomOidcSubClaimForRepoRequest
    {
        /// <summary>
        /// Whether to use the default template or not. If `true`, the `include_claim_keys` field is ignored.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("use_default")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool UseDefault { get; set; }

        /// <summary>
        /// Array of unique strings. Each claim key can only contain alphanumeric characters and underscores.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("include_claim_keys")]
        public global::System.Collections.Generic.IList<string>? IncludeClaimKeys { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ActionsSetCustomOidcSubClaimForRepoRequest" /> class.
        /// </summary>
        /// <param name="useDefault">
        /// Whether to use the default template or not. If `true`, the `include_claim_keys` field is ignored.
        /// </param>
        /// <param name="includeClaimKeys">
        /// Array of unique strings. Each claim key can only contain alphanumeric characters and underscores.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public ActionsSetCustomOidcSubClaimForRepoRequest(
            bool useDefault,
            global::System.Collections.Generic.IList<string>? includeClaimKeys)
        {
            this.UseDefault = useDefault;
            this.IncludeClaimKeys = includeClaimKeys;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ActionsSetCustomOidcSubClaimForRepoRequest" /> class.
        /// </summary>
        public ActionsSetCustomOidcSubClaimForRepoRequest()
        {
        }
    }
}