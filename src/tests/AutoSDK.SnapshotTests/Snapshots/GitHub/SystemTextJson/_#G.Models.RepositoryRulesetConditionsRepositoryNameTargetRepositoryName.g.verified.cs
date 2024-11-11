//HintName: G.Models.RepositoryRulesetConditionsRepositoryNameTargetRepositoryName.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RepositoryRulesetConditionsRepositoryNameTargetRepositoryName
    {
        /// <summary>
        /// Array of repository names or patterns to include. One of these patterns must match for the condition to pass. Also accepts `~ALL` to include all repositories.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("include")]
        public global::System.Collections.Generic.IList<string>? Include { get; set; }

        /// <summary>
        /// Array of repository names or patterns to exclude. The condition will not pass if any of these patterns match.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("exclude")]
        public global::System.Collections.Generic.IList<string>? Exclude { get; set; }

        /// <summary>
        /// Whether renaming of target repositories is prevented.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("protected")]
        public bool? Protected { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RepositoryRulesetConditionsRepositoryNameTargetRepositoryName" /> class.
        /// </summary>
        /// <param name="include">
        /// Array of repository names or patterns to include. One of these patterns must match for the condition to pass. Also accepts `~ALL` to include all repositories.
        /// </param>
        /// <param name="exclude">
        /// Array of repository names or patterns to exclude. The condition will not pass if any of these patterns match.
        /// </param>
        /// <param name="protected">
        /// Whether renaming of target repositories is prevented.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public RepositoryRulesetConditionsRepositoryNameTargetRepositoryName(
            global::System.Collections.Generic.IList<string>? include,
            global::System.Collections.Generic.IList<string>? exclude,
            bool? @protected)
        {
            this.Include = include;
            this.Exclude = exclude;
            this.Protected = @protected;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RepositoryRulesetConditionsRepositoryNameTargetRepositoryName" /> class.
        /// </summary>
        public RepositoryRulesetConditionsRepositoryNameTargetRepositoryName()
        {
        }
    }
}