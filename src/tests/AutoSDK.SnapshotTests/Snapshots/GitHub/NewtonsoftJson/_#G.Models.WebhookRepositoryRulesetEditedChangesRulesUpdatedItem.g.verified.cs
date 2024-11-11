//HintName: G.Models.WebhookRepositoryRulesetEditedChangesRulesUpdatedItem.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WebhookRepositoryRulesetEditedChangesRulesUpdatedItem
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
        public global::G.WebhookRepositoryRulesetEditedChangesRulesUpdatedItemChanges? Changes { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookRepositoryRulesetEditedChangesRulesUpdatedItem" /> class.
        /// </summary>
        /// <param name="rule">
        /// A repository rule.
        /// </param>
        /// <param name="changes"></param>
        public WebhookRepositoryRulesetEditedChangesRulesUpdatedItem(
            global::G.RepositoryRule? rule,
            global::G.WebhookRepositoryRulesetEditedChangesRulesUpdatedItemChanges? changes)
        {
            this.Rule = rule;
            this.Changes = changes;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookRepositoryRulesetEditedChangesRulesUpdatedItem" /> class.
        /// </summary>
        public WebhookRepositoryRulesetEditedChangesRulesUpdatedItem()
        {
        }
    }
}