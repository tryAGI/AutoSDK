//HintName: G.Models.RepositoryRuleParamsRestrictedCommits.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Restricted commit
    /// </summary>
    public sealed partial class RepositoryRuleParamsRestrictedCommits
    {
        /// <summary>
        /// Full or abbreviated commit hash to reject
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("oid", Required = global::Newtonsoft.Json.Required.Always)]
        public string Oid { get; set; } = default!;

        /// <summary>
        /// Reason for restriction
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("reason")]
        public string? Reason { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}