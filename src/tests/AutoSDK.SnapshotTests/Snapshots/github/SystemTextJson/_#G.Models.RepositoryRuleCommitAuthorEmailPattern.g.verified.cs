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
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.RepositoryRuleCommitAuthorEmailPatternTypeJsonConverter))]
        public global::G.RepositoryRuleCommitAuthorEmailPatternType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parameters")]
        public global::G.RepositoryRuleCommitAuthorEmailPatternParameters? Parameters { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RepositoryRuleCommitAuthorEmailPattern" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="parameters"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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