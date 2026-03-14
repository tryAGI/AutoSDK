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
        /// The document part altered by the context configuration that matches the query.<br/>
        /// Example: EU banks reported a 20% increase in carbon reduction initiatives in 2023, driven by regulatory pressure.
        /// </summary>
        /// <example>EU banks reported a 20% increase in carbon reduction initiatives in 2023, driven by regulatory pressure.</example>
        [global::Newtonsoft.Json.JsonProperty("text")]
        public string? Text { get; set; }

        /// <summary>
        /// The score of the individual result.<br/>
        /// Example: 0.92
        /// </summary>
        /// <example>0.92</example>
        [global::Newtonsoft.Json.JsonProperty("score")]
        public double? Score { get; set; }

        /// <summary>
        /// The metadata for the document part.<br/>
        /// Example: {"section":"executive_summary"}
        /// </summary>
        /// <example>{"section":"executive_summary"}</example>
        [global::Newtonsoft.Json.JsonProperty("part_metadata")]
        public object? PartMetadata { get; set; }

        /// <summary>
        /// The metadata for the document that contains the document part.<br/>
        /// Example: {"industry":"banking","year":2023,"doc_type":"annual_report"}
        /// </summary>
        /// <example>{"industry":"banking","year":2023,"doc_type":"annual_report"}</example>
        [global::Newtonsoft.Json.JsonProperty("document_metadata")]
        public object? DocumentMetadata { get; set; }

        /// <summary>
        /// The ID of the document that contains the document part.<br/>
        /// Example: financial-report-2023
        /// </summary>
        /// <example>financial-report-2023</example>
        [global::Newtonsoft.Json.JsonProperty("document_id")]
        public string? DocumentId { get; set; }

        /// <summary>
        /// A table in a document.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("table")]
        public global::G.Table? Table { get; set; }

        /// <summary>
        /// An image element within a document, containing its identifying information and optional metadata.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("image")]
        public global::G.ImageMetadata? Image { get; set; }

        /// <summary>
        /// A query request can search over multiple corpora at a time. This property is set to the index in the list of corpora in the original search request that this search result originated from. If the query request is only over one corpus, this property is 0.<br/>
        /// Example: 0
        /// </summary>
        /// <example>0</example>
        [global::Newtonsoft.Json.JsonProperty("request_corpora_index")]
        public int? RequestCorporaIndex { get; set; }

        /// <summary>
        /// The corpus key that this search result originated from. For queries across multiple corpora, this identifies which corpus the result came from.<br/>
        /// Example: fin_docs
        /// </summary>
        /// <example>fin_docs</example>
        [global::Newtonsoft.Json.JsonProperty("corpus_key")]
        public string? CorpusKey { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="IndividualSearchResult" /> class.
        /// </summary>
        /// <param name="text">
        /// The document part altered by the context configuration that matches the query.<br/>
        /// Example: EU banks reported a 20% increase in carbon reduction initiatives in 2023, driven by regulatory pressure.
        /// </param>
        /// <param name="score">
        /// The score of the individual result.<br/>
        /// Example: 0.92
        /// </param>
        /// <param name="partMetadata">
        /// The metadata for the document part.<br/>
        /// Example: {"section":"executive_summary"}
        /// </param>
        /// <param name="documentMetadata">
        /// The metadata for the document that contains the document part.<br/>
        /// Example: {"industry":"banking","year":2023,"doc_type":"annual_report"}
        /// </param>
        /// <param name="documentId">
        /// The ID of the document that contains the document part.<br/>
        /// Example: financial-report-2023
        /// </param>
        /// <param name="table">
        /// A table in a document.
        /// </param>
        /// <param name="image">
        /// An image element within a document, containing its identifying information and optional metadata.
        /// </param>
        /// <param name="requestCorporaIndex">
        /// A query request can search over multiple corpora at a time. This property is set to the index in the list of corpora in the original search request that this search result originated from. If the query request is only over one corpus, this property is 0.<br/>
        /// Example: 0
        /// </param>
        /// <param name="corpusKey">
        /// The corpus key that this search result originated from. For queries across multiple corpora, this identifies which corpus the result came from.<br/>
        /// Example: fin_docs
        /// </param>
        public IndividualSearchResult(
            string? text,
            double? score,
            object? partMetadata,
            object? documentMetadata,
            string? documentId,
            global::G.Table? table,
            global::G.ImageMetadata? image,
            int? requestCorporaIndex,
            string? corpusKey)
        {
            this.Text = text;
            this.Score = score;
            this.PartMetadata = partMetadata;
            this.DocumentMetadata = documentMetadata;
            this.DocumentId = documentId;
            this.Table = table;
            this.Image = image;
            this.RequestCorporaIndex = requestCorporaIndex;
            this.CorpusKey = corpusKey;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IndividualSearchResult" /> class.
        /// </summary>
        public IndividualSearchResult()
        {
        }
    }
}