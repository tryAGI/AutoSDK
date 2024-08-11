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
        [global::Newtonsoft.Json.JsonProperty("condition_type")]
        public global::G.WebhookRepositoryRulesetEditedChangesConditionsUpdatedItemChangesConditionType? ConditionType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("target")]
        public global::G.WebhookRepositoryRulesetEditedChangesConditionsUpdatedItemChangesTarget? Target { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("include")]
        public global::G.WebhookRepositoryRulesetEditedChangesConditionsUpdatedItemChangesInclude? Include { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("exclude")]
        public global::G.WebhookRepositoryRulesetEditedChangesConditionsUpdatedItemChangesExclude? Exclude { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}