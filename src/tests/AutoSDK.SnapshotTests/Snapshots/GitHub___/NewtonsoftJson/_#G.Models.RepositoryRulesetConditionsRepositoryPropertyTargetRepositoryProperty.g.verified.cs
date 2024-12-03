//HintName: G.Models.RepositoryRulesetConditionsRepositoryPropertyTargetRepositoryProperty.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RepositoryRulesetConditionsRepositoryPropertyTargetRepositoryProperty
    {
        /// <summary>
        /// The repository properties and values to include. All of these properties must match for the condition to pass.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("include")]
        public global::System.Collections.Generic.IList<global::G.RepositoryRulesetConditionsRepositoryPropertySpec>? Include { get; set; }

        /// <summary>
        /// The repository properties and values to exclude. The condition will not pass if any of these properties match.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("exclude")]
        public global::System.Collections.Generic.IList<global::G.RepositoryRulesetConditionsRepositoryPropertySpec>? Exclude { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RepositoryRulesetConditionsRepositoryPropertyTargetRepositoryProperty" /> class.
        /// </summary>
        /// <param name="include">
        /// The repository properties and values to include. All of these properties must match for the condition to pass.
        /// </param>
        /// <param name="exclude">
        /// The repository properties and values to exclude. The condition will not pass if any of these properties match.
        /// </param>
        public RepositoryRulesetConditionsRepositoryPropertyTargetRepositoryProperty(
            global::System.Collections.Generic.IList<global::G.RepositoryRulesetConditionsRepositoryPropertySpec>? include,
            global::System.Collections.Generic.IList<global::G.RepositoryRulesetConditionsRepositoryPropertySpec>? exclude)
        {
            this.Include = include;
            this.Exclude = exclude;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RepositoryRulesetConditionsRepositoryPropertyTargetRepositoryProperty" /> class.
        /// </summary>
        public RepositoryRulesetConditionsRepositoryPropertyTargetRepositoryProperty()
        {
        }
    }
}