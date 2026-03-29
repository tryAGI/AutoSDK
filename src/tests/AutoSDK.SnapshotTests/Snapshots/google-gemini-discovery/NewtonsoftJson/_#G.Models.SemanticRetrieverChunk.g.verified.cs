//HintName: G.Models.SemanticRetrieverChunk.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Identifier for a `Chunk` retrieved via Semantic Retriever specified in the `GenerateAnswerRequest` using `SemanticRetrieverConfig`.
    /// </summary>
    public sealed partial class SemanticRetrieverChunk
    {
        /// <summary>
        /// Output only. Name of the source matching the request's `SemanticRetrieverConfig.source`. Example: `corpora/123` or `corpora/123/documents/abc`<br/>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("source")]
        public string? Source { get; set; }

        /// <summary>
        /// Output only. Name of the `Chunk` containing the attributed text. Example: `corpora/123/documents/abc/chunks/xyz`<br/>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("chunk")]
        public string? Chunk { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SemanticRetrieverChunk" /> class.
        /// </summary>
        /// <param name="source">
        /// Output only. Name of the source matching the request's `SemanticRetrieverConfig.source`. Example: `corpora/123` or `corpora/123/documents/abc`<br/>
        /// Included only in responses
        /// </param>
        /// <param name="chunk">
        /// Output only. Name of the `Chunk` containing the attributed text. Example: `corpora/123/documents/abc/chunks/xyz`<br/>
        /// Included only in responses
        /// </param>
        public SemanticRetrieverChunk(
            string? source,
            string? chunk)
        {
            this.Source = source;
            this.Chunk = chunk;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SemanticRetrieverChunk" /> class.
        /// </summary>
        public SemanticRetrieverChunk()
        {
        }
    }
}