//HintName: G.Models.RepositoryRuleViolationErrorMetadataSecretScanningBypassPlaceholder.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RepositoryRuleViolationErrorMetadataSecretScanningBypassPlaceholder
    {
        /// <summary>
        /// The ID of the push protection bypass placeholder. This value is returned on any push protected routes.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("placeholder_id")]
        public string? PlaceholderId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("token_type")]
        public string? TokenType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RepositoryRuleViolationErrorMetadataSecretScanningBypassPlaceholder" /> class.
        /// </summary>
        /// <param name="placeholderId">
        /// The ID of the push protection bypass placeholder. This value is returned on any push protected routes.
        /// </param>
        /// <param name="tokenType"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RepositoryRuleViolationErrorMetadataSecretScanningBypassPlaceholder(
            string? placeholderId,
            string? tokenType)
        {
            this.PlaceholderId = placeholderId;
            this.TokenType = tokenType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RepositoryRuleViolationErrorMetadataSecretScanningBypassPlaceholder" /> class.
        /// </summary>
        public RepositoryRuleViolationErrorMetadataSecretScanningBypassPlaceholder()
        {
        }
    }
}