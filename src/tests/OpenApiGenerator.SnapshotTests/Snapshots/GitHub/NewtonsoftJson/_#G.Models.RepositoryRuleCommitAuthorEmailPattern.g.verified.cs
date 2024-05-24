//HintName: G.Models.RepositoryRuleCommitAuthorEmailPattern.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Parameters to be used for the commit_author_email_pattern rule
    /// </summary>
    public sealed partial class RepositoryRuleCommitAuthorEmailPattern
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type", Required = global::Newtonsoft.Json.Required.Always)]
        public RepositoryRuleCommitAuthorEmailPatternType Type { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("parameters")]
        public RepositoryRuleCommitAuthorEmailPatternParameters? Parameters { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}