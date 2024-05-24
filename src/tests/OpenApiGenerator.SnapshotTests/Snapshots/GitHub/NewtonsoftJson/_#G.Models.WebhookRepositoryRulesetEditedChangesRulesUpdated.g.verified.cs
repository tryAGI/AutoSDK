//HintName: G.Models.WebhookRepositoryRulesetEditedChangesRulesUpdated.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WebhookRepositoryRulesetEditedChangesRulesUpdated
    {
        /// <summary>
        /// A repository rule.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("rule")]
        public RepositoryRule? Rule { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("changes")]
        public WebhookRepositoryRulesetEditedChangesRulesUpdatedChanges? Changes { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}