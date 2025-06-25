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
        [global::System.Text.Json.Serialization.JsonPropertyName("configuration")]
        public global::G.WebhookRepositoryRulesetEditedChangesRulesUpdatedItemChangesConfiguration? Configuration { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rule_type")]
        public global::G.WebhookRepositoryRulesetEditedChangesRulesUpdatedItemChangesRuleType? RuleType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pattern")]
        public global::G.WebhookRepositoryRulesetEditedChangesRulesUpdatedItemChangesPattern? Pattern { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookRepositoryRulesetEditedChangesRulesUpdatedItemChanges" /> class.
        /// </summary>
        /// <param name="configuration"></param>
        /// <param name="ruleType"></param>
        /// <param name="pattern"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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