//HintName: G.Models.RepositoryRuleRequiredLinearHistory.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Prevent merge commits from being pushed to matching refs.
    /// </summary>
    public sealed partial class RepositoryRuleRequiredLinearHistory
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.RepositoryRuleRequiredLinearHistoryTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.RepositoryRuleRequiredLinearHistoryType Type { get; set; } = global::G.RepositoryRuleRequiredLinearHistoryType.RequiredLinearHistory;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}