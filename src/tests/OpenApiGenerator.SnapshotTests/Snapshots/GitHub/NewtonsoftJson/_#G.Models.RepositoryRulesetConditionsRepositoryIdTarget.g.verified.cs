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
        [global::Newtonsoft.Json.JsonProperty("repository_id", Required = global::Newtonsoft.Json.Required.Always)]
        public RepositoryRulesetConditionsRepositoryIdTargetRepositoryId RepositoryId { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}