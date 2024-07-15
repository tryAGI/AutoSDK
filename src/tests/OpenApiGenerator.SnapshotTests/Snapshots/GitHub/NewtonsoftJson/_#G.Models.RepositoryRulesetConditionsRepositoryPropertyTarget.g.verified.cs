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
        [global::Newtonsoft.Json.JsonProperty("repository_property", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.RepositoryRulesetConditionsRepositoryPropertyTargetRepositoryProperty RepositoryProperty { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}