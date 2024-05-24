//HintName: G.Models.RepositoryRulesetConditionsRepositoryNameTarget.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Parameters for a repository name condition
    /// </summary>
    public sealed partial class RepositoryRulesetConditionsRepositoryNameTarget
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("repository_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required RepositoryRulesetConditionsRepositoryNameTargetRepositoryName RepositoryName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}