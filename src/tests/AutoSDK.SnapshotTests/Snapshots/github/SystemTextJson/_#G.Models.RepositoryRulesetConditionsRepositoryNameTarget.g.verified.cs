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
        public required global::G.RepositoryRulesetConditionsRepositoryNameTargetRepositoryName RepositoryName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RepositoryRulesetConditionsRepositoryNameTarget" /> class.
        /// </summary>
        /// <param name="repositoryName"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public RepositoryRulesetConditionsRepositoryNameTarget(
            global::G.RepositoryRulesetConditionsRepositoryNameTargetRepositoryName repositoryName)
        {
            this.RepositoryName = repositoryName ?? throw new global::System.ArgumentNullException(nameof(repositoryName));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RepositoryRulesetConditionsRepositoryNameTarget" /> class.
        /// </summary>
        public RepositoryRulesetConditionsRepositoryNameTarget()
        {
        }
    }
}