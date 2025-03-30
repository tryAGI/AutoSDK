//HintName: G.Models.KeyedSearchCorpusVariant2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class KeyedSearchCorpusVariant2
    {
        /// <summary>
        /// A user-provided key for a corpus.<br/>
        /// Example: my-corpus
        /// </summary>
        /// <example>my-corpus</example>
        [global::Newtonsoft.Json.JsonProperty("corpus_key")]
        public string? CorpusKey { get; set; }

        /// <summary>
        /// Query for a particular corpus that will override the overall query if present.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("query")]
        public string? Query { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="KeyedSearchCorpusVariant2" /> class.
        /// </summary>
        /// <param name="corpusKey">
        /// A user-provided key for a corpus.<br/>
        /// Example: my-corpus
        /// </param>
        /// <param name="query">
        /// Query for a particular corpus that will override the overall query if present.
        /// </param>
        public KeyedSearchCorpusVariant2(
            string? corpusKey,
            string? query)
        {
            this.CorpusKey = corpusKey;
            this.Query = query;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="KeyedSearchCorpusVariant2" /> class.
        /// </summary>
        public KeyedSearchCorpusVariant2()
        {
        }
    }
}