//HintName: G.Models.WebhookRepositoryRulesetEditedChangesRulesUpdatedRule.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Note: file_path_restriction is in beta and subject to change.
    /// Prevent commits that include changes in specified file paths from being pushed to the commit graph.
    /// </summary>
    public sealed partial class WebhookRepositoryRulesetEditedChangesRulesUpdatedRule
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.WebhookRepositoryRulesetEditedChangesRulesUpdatedRuleTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required WebhookRepositoryRulesetEditedChangesRulesUpdatedRuleType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parameters")]
        public WebhookRepositoryRulesetEditedChangesRulesUpdatedRuleParameters? Parameters { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}