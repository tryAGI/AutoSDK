//HintName: G.Models.RepositoryRulesetConditionsRepositoryIdTarget.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Parameters for a repository ID condition
    /// </summary>
    public sealed partial class RepositoryRulesetConditionsRepositoryIdTarget
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("repository_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required RepositoryRulesetConditionsRepositoryIdTargetRepositoryId RepositoryId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}