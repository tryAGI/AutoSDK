//HintName: G.Models.WebhookRepositoryRulesetEditedChangesConditionsUpdated.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WebhookRepositoryRulesetEditedChangesConditionsUpdated
    {
        /// <summary>
        /// Parameters for a repository ruleset ref name condition
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("condition")]
        public global::G.RepositoryRulesetConditions? Condition { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("changes")]
        public global::G.WebhookRepositoryRulesetEditedChangesConditionsUpdatedChanges? Changes { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}