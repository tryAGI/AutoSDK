//HintName: G.Models.RepositoryRuleCommitMessagePattern.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Parameters to be used for the commit_message_pattern rule
    /// </summary>
    public sealed partial class RepositoryRuleCommitMessagePattern
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type", Required = global::Newtonsoft.Json.Required.Always)]
        public RepositoryRuleCommitMessagePatternType Type { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("parameters")]
        public RepositoryRuleCommitMessagePatternParameters? Parameters { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}