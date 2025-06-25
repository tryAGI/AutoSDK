//HintName: G.Models.WebhookRepositoryRulesetEditedChangesConditionsUpdatedItemChanges.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WebhookRepositoryRulesetEditedChangesConditionsUpdatedItemChanges
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("condition_type")]
        public global::G.WebhookRepositoryRulesetEditedChangesConditionsUpdatedItemChangesConditionType? ConditionType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("target")]
        public global::G.WebhookRepositoryRulesetEditedChangesConditionsUpdatedItemChangesTarget? Target { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("include")]
        public global::G.WebhookRepositoryRulesetEditedChangesConditionsUpdatedItemChangesInclude? Include { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("exclude")]
        public global::G.WebhookRepositoryRulesetEditedChangesConditionsUpdatedItemChangesExclude? Exclude { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookRepositoryRulesetEditedChangesConditionsUpdatedItemChanges" /> class.
        /// </summary>
        /// <param name="conditionType"></param>
        /// <param name="target"></param>
        /// <param name="include"></param>
        /// <param name="exclude"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WebhookRepositoryRulesetEditedChangesConditionsUpdatedItemChanges(
            global::G.WebhookRepositoryRulesetEditedChangesConditionsUpdatedItemChangesConditionType? conditionType,
            global::G.WebhookRepositoryRulesetEditedChangesConditionsUpdatedItemChangesTarget? target,
            global::G.WebhookRepositoryRulesetEditedChangesConditionsUpdatedItemChangesInclude? include,
            global::G.WebhookRepositoryRulesetEditedChangesConditionsUpdatedItemChangesExclude? exclude)
        {
            this.ConditionType = conditionType;
            this.Target = target;
            this.Include = include;
            this.Exclude = exclude;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookRepositoryRulesetEditedChangesConditionsUpdatedItemChanges" /> class.
        /// </summary>
        public WebhookRepositoryRulesetEditedChangesConditionsUpdatedItemChanges()
        {
        }
    }
}