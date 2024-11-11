//HintName: G.Models.RepositoryRuleCommitterEmailPattern.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Parameters to be used for the committer_email_pattern rule
    /// </summary>
    public sealed partial class RepositoryRuleCommitterEmailPattern
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.RepositoryRuleCommitterEmailPatternType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("parameters")]
        public global::G.RepositoryRuleCommitterEmailPatternParameters? Parameters { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RepositoryRuleCommitterEmailPattern" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="parameters"></param>
        public RepositoryRuleCommitterEmailPattern(
            global::G.RepositoryRuleCommitterEmailPatternType type,
            global::G.RepositoryRuleCommitterEmailPatternParameters? parameters)
        {
            this.Type = type;
            this.Parameters = parameters;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RepositoryRuleCommitterEmailPattern" /> class.
        /// </summary>
        public RepositoryRuleCommitterEmailPattern()
        {
        }
    }
}