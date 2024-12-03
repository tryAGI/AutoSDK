//HintName: G.Models.RepositoryRuleCommitAuthorEmailPatternParameters.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RepositoryRuleCommitAuthorEmailPatternParameters
    {
        /// <summary>
        /// How this rule will appear to users.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// If true, the rule will fail if the pattern matches.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("negate")]
        public bool? Negate { get; set; }

        /// <summary>
        /// The operator to use for matching.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("operator", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.RepositoryRuleCommitAuthorEmailPatternParametersOperator Operator { get; set; } = default!;

        /// <summary>
        /// The pattern to match with.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("pattern", Required = global::Newtonsoft.Json.Required.Always)]
        public string Pattern { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RepositoryRuleCommitAuthorEmailPatternParameters" /> class.
        /// </summary>
        /// <param name="name">
        /// How this rule will appear to users.
        /// </param>
        /// <param name="negate">
        /// If true, the rule will fail if the pattern matches.
        /// </param>
        /// <param name="operator">
        /// The operator to use for matching.
        /// </param>
        /// <param name="pattern">
        /// The pattern to match with.
        /// </param>
        public RepositoryRuleCommitAuthorEmailPatternParameters(
            global::G.RepositoryRuleCommitAuthorEmailPatternParametersOperator @operator,
            string pattern,
            string? name,
            bool? negate)
        {
            this.Operator = @operator;
            this.Pattern = pattern ?? throw new global::System.ArgumentNullException(nameof(pattern));
            this.Name = name;
            this.Negate = negate;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RepositoryRuleCommitAuthorEmailPatternParameters" /> class.
        /// </summary>
        public RepositoryRuleCommitAuthorEmailPatternParameters()
        {
        }
    }
}