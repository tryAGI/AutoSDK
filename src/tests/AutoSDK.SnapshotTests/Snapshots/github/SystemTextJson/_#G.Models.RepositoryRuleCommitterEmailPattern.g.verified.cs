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
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.RepositoryRuleCommitterEmailPatternTypeJsonConverter))]
        public global::G.RepositoryRuleCommitterEmailPatternType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parameters")]
        public global::G.RepositoryRuleCommitterEmailPatternParameters? Parameters { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RepositoryRuleCommitterEmailPattern" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="parameters"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
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