//HintName: G.Models.RepositoryRuleCreation.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Only allow users with bypass permission to create matching refs.
    /// </summary>
    public sealed partial class RepositoryRuleCreation
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.RepositoryRuleCreationType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}