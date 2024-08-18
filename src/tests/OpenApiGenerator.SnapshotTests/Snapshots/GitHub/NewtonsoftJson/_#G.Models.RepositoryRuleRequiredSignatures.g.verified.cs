//HintName: G.Models.RepositoryRuleRequiredSignatures.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Commits pushed to matching refs must have verified signatures.
    /// </summary>
    public sealed partial class RepositoryRuleRequiredSignatures
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.RepositoryRuleRequiredSignaturesType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}