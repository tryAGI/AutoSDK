//HintName: G.Models.RepositoryRuleParamsRestrictedCommits.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Restricted commit
    /// </summary>
    public sealed partial class RepositoryRuleParamsRestrictedCommits
    {
        /// <summary>
        /// Full or abbreviated commit hash to reject
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("oid")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Oid { get; set; }

        /// <summary>
        /// Reason for restriction
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reason")]
        public string? Reason { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}