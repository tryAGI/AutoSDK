//HintName: G.Models.RepositoryRuleViolationErrorMetadata.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RepositoryRuleViolationErrorMetadata
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("secret_scanning")]
        public global::G.RepositoryRuleViolationErrorMetadataSecretScanning? SecretScanning { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RepositoryRuleViolationErrorMetadata" /> class.
        /// </summary>
        /// <param name="secretScanning"></param>
        public RepositoryRuleViolationErrorMetadata(
            global::G.RepositoryRuleViolationErrorMetadataSecretScanning? secretScanning)
        {
            this.SecretScanning = secretScanning;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RepositoryRuleViolationErrorMetadata" /> class.
        /// </summary>
        public RepositoryRuleViolationErrorMetadata()
        {
        }
    }
}