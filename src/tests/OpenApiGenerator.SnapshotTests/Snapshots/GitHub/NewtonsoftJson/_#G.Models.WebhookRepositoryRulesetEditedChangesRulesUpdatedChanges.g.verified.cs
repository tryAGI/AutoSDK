//HintName: G.Models.WebhookRepositoryRulesetEditedChangesRulesUpdatedChanges.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WebhookRepositoryRulesetEditedChangesRulesUpdatedChanges
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("configuration")]
        public WebhookRepositoryRulesetEditedChangesRulesUpdatedChangesConfiguration? Configuration { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("rule_type")]
        public WebhookRepositoryRulesetEditedChangesRulesUpdatedChangesRuleType? RuleType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("pattern")]
        public WebhookRepositoryRulesetEditedChangesRulesUpdatedChangesPattern? Pattern { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}