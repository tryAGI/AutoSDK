//HintName: G.Models.WebhookRepositoryRulesetEditedChangesRulesUpdatedRuleParameters.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WebhookRepositoryRulesetEditedChangesRulesUpdatedRuleParameters
    {
        /// <summary>
        /// The file paths that are restricted from being pushed to the commit graph.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("restricted_file_paths")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> RestrictedFilePaths { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}