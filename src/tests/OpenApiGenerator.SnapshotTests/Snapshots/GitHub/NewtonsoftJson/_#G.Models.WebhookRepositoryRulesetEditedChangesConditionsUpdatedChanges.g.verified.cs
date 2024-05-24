//HintName: G.Models.WebhookRepositoryRulesetEditedChangesConditionsUpdatedChanges.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WebhookRepositoryRulesetEditedChangesConditionsUpdatedChanges
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("condition_type")]
        public WebhookRepositoryRulesetEditedChangesConditionsUpdatedChangesConditionType? ConditionType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("target")]
        public WebhookRepositoryRulesetEditedChangesConditionsUpdatedChangesTarget? Target { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("include")]
        public WebhookRepositoryRulesetEditedChangesConditionsUpdatedChangesInclude? Include { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("exclude")]
        public WebhookRepositoryRulesetEditedChangesConditionsUpdatedChangesExclude? Exclude { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}