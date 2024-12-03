//HintName: G.Models.RepositoryRulesetConditionsRepositoryIdTargetRepositoryId.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RepositoryRulesetConditionsRepositoryIdTargetRepositoryId
    {
        /// <summary>
        /// The repository IDs that the ruleset applies to. One of these IDs must match for the condition to pass.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("repository_ids")]
        public global::System.Collections.Generic.IList<int>? RepositoryIds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RepositoryRulesetConditionsRepositoryIdTargetRepositoryId" /> class.
        /// </summary>
        /// <param name="repositoryIds">
        /// The repository IDs that the ruleset applies to. One of these IDs must match for the condition to pass.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public RepositoryRulesetConditionsRepositoryIdTargetRepositoryId(
            global::System.Collections.Generic.IList<int>? repositoryIds)
        {
            this.RepositoryIds = repositoryIds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RepositoryRulesetConditionsRepositoryIdTargetRepositoryId" /> class.
        /// </summary>
        public RepositoryRulesetConditionsRepositoryIdTargetRepositoryId()
        {
        }
    }
}