//HintName: G.Models.StopwordsSet.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class StopwordsSet
    {
        /// <summary>
        /// Set of languages to use for stopwords. Multiple pre-defined lists of stopwords can be combined.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("languages")]
        public global::System.Collections.Generic.IList<global::G.Language>? Languages { get; set; }

        /// <summary>
        /// Custom stopwords set. Will be merged with the languages set.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("custom")]
        public global::System.Collections.Generic.IList<string>? Custom { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StopwordsSet" /> class.
        /// </summary>
        /// <param name="languages">
        /// Set of languages to use for stopwords. Multiple pre-defined lists of stopwords can be combined.
        /// </param>
        /// <param name="custom">
        /// Custom stopwords set. Will be merged with the languages set.
        /// </param>
        public StopwordsSet(
            global::System.Collections.Generic.IList<global::G.Language>? languages,
            global::System.Collections.Generic.IList<string>? custom)
        {
            this.Languages = languages;
            this.Custom = custom;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StopwordsSet" /> class.
        /// </summary>
        public StopwordsSet()
        {
        }
    }
}