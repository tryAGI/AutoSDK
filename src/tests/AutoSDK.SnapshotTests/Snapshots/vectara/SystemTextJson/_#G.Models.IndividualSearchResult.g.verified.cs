//HintName: G.Models.IndividualSearchResult.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// An individual ranked search result from a query.
    /// </summary>
    public sealed partial class IndividualSearchResult
    {
        /// <summary>
        /// The document part altered by the context configuration that matches the query.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        public string? Text { get; set; }

        /// <summary>
        /// The score of the individual result.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("score")]
        public double? Score { get; set; }

        /// <summary>
        /// The metadata for the document part.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("part_metadata")]
        public global::G.IndividualSearchResultPartMetadata? PartMetadata { get; set; }

        /// <summary>
        /// The metadata for the document that contains the document part.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("document_metadata")]
        public global::G.IndividualSearchResultDocumentMetadata? DocumentMetadata { get; set; }

        /// <summary>
        /// The ID of the document that contains the document part.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("document_id")]
        public string? DocumentId { get; set; }

        /// <summary>
        /// A query request can search over multiple corpora at a time. This property <br/>
        /// is set to the index in the list of corpora in the original search request that this<br/>
        /// search result originated from.<br/>
        /// If the query request is only over one corpus, this property is 0.<br/>
        /// Example: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("request_corpora_index")]
        public int? RequestCorporaIndex { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}