//HintName: G.Models.ExclusionRule.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ExclusionRule
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("matchType")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.MatchTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.MatchType MatchType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("exclusionType")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ExclusionTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.ExclusionType ExclusionType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("regex")]
        public global::G.Regex? Regex { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("wordList")]
        public global::G.WordList? WordList { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ExclusionRule" /> class.
        /// </summary>
        /// <param name="matchType"></param>
        /// <param name="exclusionType"></param>
        /// <param name="regex"></param>
        /// <param name="wordList"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ExclusionRule(
            global::G.MatchType matchType,
            global::G.ExclusionType exclusionType,
            global::G.Regex? regex,
            global::G.WordList? wordList)
        {
            this.MatchType = matchType;
            this.ExclusionType = exclusionType;
            this.Regex = regex;
            this.WordList = wordList;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExclusionRule" /> class.
        /// </summary>
        public ExclusionRule()
        {
        }
    }
}