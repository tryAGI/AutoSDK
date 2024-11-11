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
        [global::Newtonsoft.Json.JsonProperty("placeholder_id")]
        public string? PlaceholderId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("token_type")]
        public string? TokenType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RepositoryRuleViolationErrorMetadataSecretScanningBypassPlaceholder" /> class.
        /// </summary>
        /// <param name="placeholderId">
        /// The ID of the push protection bypass placeholder. This value is returned on any push protected routes.
        /// </param>
        /// <param name="tokenType"></param>
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