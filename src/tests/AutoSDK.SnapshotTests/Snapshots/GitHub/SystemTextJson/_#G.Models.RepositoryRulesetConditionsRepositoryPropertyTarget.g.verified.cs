//HintName: G.Models.RepositoryRulesetConditionsRepositoryPropertyTarget.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Parameters for a repository property condition
    /// </summary>
    public sealed partial class RepositoryRulesetConditionsRepositoryPropertyTarget
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("repository_property")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.RepositoryRulesetConditionsRepositoryPropertyTargetRepositoryProperty RepositoryProperty { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}