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
        [global::System.Text.Json.Serialization.JsonPropertyName("corpus_key")]
        public string? CorpusKey { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="KeyedSearchCorpusVariant2" /> class.
        /// </summary>
        /// <param name="corpusKey">
        /// A user-provided key for a corpus.<br/>
        /// Example: my-corpus
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public KeyedSearchCorpusVariant2(
            string? corpusKey)
        {
            this.CorpusKey = corpusKey;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="KeyedSearchCorpusVariant2" /> class.
        /// </summary>
        public KeyedSearchCorpusVariant2()
        {
        }
    }
}