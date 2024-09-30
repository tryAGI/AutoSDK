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
        [global::System.Text.Json.Serialization.JsonPropertyName("corpus_key")]
        public string? CorpusKey { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}