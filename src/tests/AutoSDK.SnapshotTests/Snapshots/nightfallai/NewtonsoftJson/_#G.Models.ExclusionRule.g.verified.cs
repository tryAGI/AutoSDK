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
        [global::Newtonsoft.Json.JsonProperty("matchType", Required = global::Newtonsoft.Json.Required.Always)]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.MatchTypeJsonConverter))]
        public global::G.MatchType MatchType { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("exclusionType", Required = global::Newtonsoft.Json.Required.Always)]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.ExclusionTypeJsonConverter))]
        public global::G.ExclusionType ExclusionType { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("regex")]
        public global::G.Regex? Regex { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("wordList")]
        public global::G.WordList? WordList { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ExclusionRule" /> class.
        /// </summary>
        /// <param name="matchType"></param>
        /// <param name="exclusionType"></param>
        /// <param name="regex"></param>
        /// <param name="wordList"></param>
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