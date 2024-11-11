//HintName: G.Models.RepositoryRuleViolationErrorMetadataSecretScanning.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RepositoryRuleViolationErrorMetadataSecretScanning
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("bypass_placeholders")]
        public global::System.Collections.Generic.IList<global::G.RepositoryRuleViolationErrorMetadataSecretScanningBypassPlaceholder>? BypassPlaceholders { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RepositoryRuleViolationErrorMetadataSecretScanning" /> class.
        /// </summary>
        /// <param name="bypassPlaceholders"></param>
        public RepositoryRuleViolationErrorMetadataSecretScanning(
            global::System.Collections.Generic.IList<global::G.RepositoryRuleViolationErrorMetadataSecretScanningBypassPlaceholder>? bypassPlaceholders)
        {
            this.BypassPlaceholders = bypassPlaceholders;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RepositoryRuleViolationErrorMetadataSecretScanning" /> class.
        /// </summary>
        public RepositoryRuleViolationErrorMetadataSecretScanning()
        {
        }
    }
}