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
        [global::Newtonsoft.Json.JsonProperty("text")]
        public string? Text { get; set; }

        /// <summary>
        /// The score of the individual result.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("score")]
        public double? Score { get; set; }

        /// <summary>
        /// The metadata for the document part.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("part_metadata")]
        public object? PartMetadata { get; set; }

        /// <summary>
        /// The metadata for the document that contains the document part.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("document_metadata")]
        public object? DocumentMetadata { get; set; }

        /// <summary>
        /// The ID of the document that contains the document part.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("document_id")]
        public string? DocumentId { get; set; }

        /// <summary>
        /// A table in a document.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("table")]
        public global::G.Table? Table { get; set; }

        /// <summary>
        /// A query request can search over multiple corpora at a time. This property <br/>
        /// is set to the index in the list of corpora in the original search request that this<br/>
        /// search result originated from.<br/>
        /// If the query request is only over one corpus, this property is 0.<br/>
        /// Example: 0
        /// </summary>
        /// <example>0</example>
        [global::Newtonsoft.Json.JsonProperty("request_corpora_index")]
        public int? RequestCorporaIndex { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="IndividualSearchResult" /> class.
        /// </summary>
        /// <param name="text">
        /// The document part altered by the context configuration that matches the query.
        /// </param>
        /// <param name="score">
        /// The score of the individual result.
        /// </param>
        /// <param name="partMetadata">
        /// The metadata for the document part.
        /// </param>
        /// <param name="documentMetadata">
        /// The metadata for the document that contains the document part.
        /// </param>
        /// <param name="documentId">
        /// The ID of the document that contains the document part.
        /// </param>
        /// <param name="table">
        /// A table in a document.
        /// </param>
        /// <param name="requestCorporaIndex">
        /// A query request can search over multiple corpora at a time. This property <br/>
        /// is set to the index in the list of corpora in the original search request that this<br/>
        /// search result originated from.<br/>
        /// If the query request is only over one corpus, this property is 0.<br/>
        /// Example: 0
        /// </param>
        public IndividualSearchResult(
            string? text,
            double? score,
            object? partMetadata,
            object? documentMetadata,
            string? documentId,
            global::G.Table? table,
            int? requestCorporaIndex)
        {
            this.Text = text;
            this.Score = score;
            this.PartMetadata = partMetadata;
            this.DocumentMetadata = documentMetadata;
            this.DocumentId = documentId;
            this.Table = table;
            this.RequestCorporaIndex = requestCorporaIndex;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IndividualSearchResult" /> class.
        /// </summary>
        public IndividualSearchResult()
        {
        }
    }
}