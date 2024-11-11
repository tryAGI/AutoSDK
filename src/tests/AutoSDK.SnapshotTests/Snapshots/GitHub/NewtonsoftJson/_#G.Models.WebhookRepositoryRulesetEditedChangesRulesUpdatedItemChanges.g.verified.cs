//HintName: G.Models.WebhookRepositoryRulesetEditedChangesRulesUpdatedItemChanges.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WebhookRepositoryRulesetEditedChangesRulesUpdatedItemChanges
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("configuration")]
        public global::G.WebhookRepositoryRulesetEditedChangesRulesUpdatedItemChangesConfiguration? Configuration { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("rule_type")]
        public global::G.WebhookRepositoryRulesetEditedChangesRulesUpdatedItemChangesRuleType? RuleType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("pattern")]
        public global::G.WebhookRepositoryRulesetEditedChangesRulesUpdatedItemChangesPattern? Pattern { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookRepositoryRulesetEditedChangesRulesUpdatedItemChanges" /> class.
        /// </summary>
        /// <param name="configuration"></param>
        /// <param name="ruleType"></param>
        /// <param name="pattern"></param>
        public WebhookRepositoryRulesetEditedChangesRulesUpdatedItemChanges(
            global::G.WebhookRepositoryRulesetEditedChangesRulesUpdatedItemChangesConfiguration? configuration,
            global::G.WebhookRepositoryRulesetEditedChangesRulesUpdatedItemChangesRuleType? ruleType,
            global::G.WebhookRepositoryRulesetEditedChangesRulesUpdatedItemChangesPattern? pattern)
        {
            this.Configuration = configuration;
            this.RuleType = ruleType;
            this.Pattern = pattern;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookRepositoryRulesetEditedChangesRulesUpdatedItemChanges" /> class.
        /// </summary>
        public WebhookRepositoryRulesetEditedChangesRulesUpdatedItemChanges()
        {
        }
    }
}