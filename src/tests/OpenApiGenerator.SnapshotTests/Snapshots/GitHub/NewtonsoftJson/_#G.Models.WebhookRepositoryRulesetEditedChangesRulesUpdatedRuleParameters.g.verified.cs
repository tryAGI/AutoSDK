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
        [global::Newtonsoft.Json.JsonProperty("restricted_file_paths", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<string> RestrictedFilePaths { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}