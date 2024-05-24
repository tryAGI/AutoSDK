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
        [global::System.Text.Json.Serialization.JsonPropertyName("condition")]
        public RepositoryRulesetConditions? Condition { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("changes")]
        public WebhookRepositoryRulesetEditedChangesConditionsUpdatedChanges? Changes { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}