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
        [global::System.Text.Json.Serialization.JsonPropertyName("include")]
        public global::System.Collections.Generic.IList<RepositoryRulesetConditionsRepositoryPropertySpec>? Include { get; set; }

        /// <summary>
        /// The repository properties and values to exclude. The condition will not pass if any of these properties match.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("exclude")]
        public global::System.Collections.Generic.IList<RepositoryRulesetConditionsRepositoryPropertySpec>? Exclude { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}