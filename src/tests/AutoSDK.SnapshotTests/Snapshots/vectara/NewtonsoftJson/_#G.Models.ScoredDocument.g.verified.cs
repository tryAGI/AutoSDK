//HintName: G.Models.ScoredDocument.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A document with its relevance score and metadata.
    /// </summary>
    public sealed partial class ScoredDocument
    {
        /// <summary>
        /// The document ID.<br/>
        /// Example: document123
        /// </summary>
        /// <example>document123</example>
        [global::Newtonsoft.Json.JsonProperty("doc_id")]
        public string? DocId { get; set; }

        /// <summary>
        /// The overall relevance score for this document.<br/>
        /// Example: 0.92
        /// </summary>
        /// <example>0.92</example>
        [global::Newtonsoft.Json.JsonProperty("score")]
        public float? Score { get; set; }

        /// <summary>
        /// Document metadata object containing all document metadata fields.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ScoredDocument" /> class.
        /// </summary>
        /// <param name="docId">
        /// The document ID.<br/>
        /// Example: document123
        /// </param>
        /// <param name="score">
        /// The overall relevance score for this document.<br/>
        /// Example: 0.92
        /// </param>
        /// <param name="metadata">
        /// Document metadata object containing all document metadata fields.
        /// </param>
        public ScoredDocument(
            string? docId,
            float? score,
            object? metadata)
        {
            this.DocId = docId;
            this.Score = score;
            this.Metadata = metadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ScoredDocument" /> class.
        /// </summary>
        public ScoredDocument()
        {
        }
    }
}