//HintName: G.Models.RepositoryRuleTagNamePattern.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Parameters to be used for the tag_name_pattern rule
    /// </summary>
    public sealed partial class RepositoryRuleTagNamePattern
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.RepositoryRuleTagNamePatternType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("parameters")]
        public global::G.RepositoryRuleTagNamePatternParameters? Parameters { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RepositoryRuleTagNamePattern" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="parameters"></param>
        public RepositoryRuleTagNamePattern(
            global::G.RepositoryRuleTagNamePatternType type,
            global::G.RepositoryRuleTagNamePatternParameters? parameters)
        {
            this.Type = type;
            this.Parameters = parameters;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RepositoryRuleTagNamePattern" /> class.
        /// </summary>
        public RepositoryRuleTagNamePattern()
        {
        }
    }
}