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
        public global::G.RepositoryRule? Rule { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("changes")]
        public global::G.WebhookRepositoryRulesetEditedChangesRulesUpdatedChanges? Changes { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}