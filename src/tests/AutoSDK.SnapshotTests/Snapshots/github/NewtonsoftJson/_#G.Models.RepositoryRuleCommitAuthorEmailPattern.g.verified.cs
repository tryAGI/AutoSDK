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
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.RepositoryRuleCommitAuthorEmailPatternType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("parameters")]
        public global::G.RepositoryRuleCommitAuthorEmailPatternParameters? Parameters { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RepositoryRuleCommitAuthorEmailPattern" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="parameters"></param>
        public RepositoryRuleCommitAuthorEmailPattern(
            global::G.RepositoryRuleCommitAuthorEmailPatternType type,
            global::G.RepositoryRuleCommitAuthorEmailPatternParameters? parameters)
        {
            this.Type = type;
            this.Parameters = parameters;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RepositoryRuleCommitAuthorEmailPattern" /> class.
        /// </summary>
        public RepositoryRuleCommitAuthorEmailPattern()
        {
        }
    }
}