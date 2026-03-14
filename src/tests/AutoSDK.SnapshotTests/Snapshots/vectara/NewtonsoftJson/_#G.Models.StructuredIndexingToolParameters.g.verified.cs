//HintName: G.Models.StructuredIndexingToolParameters.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// LLM-exposed parameters for the structured indexing tool that indexes documents into the Vectara platform and can be filled in during execution.
    /// </summary>
    public sealed partial class StructuredIndexingToolParameters
    {
        /// <summary>
        /// The key identifying the target corpus for document indexing. If not provided, will be filled in by the agent.<br/>
        /// Example: my-knowledge-base
        /// </summary>
        /// <example>my-knowledge-base</example>
        [global::Newtonsoft.Json.JsonProperty("corpus_key")]
        public string? CorpusKey { get; set; }

        /// <summary>
        /// The unique identifier for the document within the corpus, preferably human readable IDs.<br/>
        /// Example: annual_report_2024
        /// </summary>
        /// <example>annual_report_2024</example>
        [global::Newtonsoft.Json.JsonProperty("document_id")]
        public string? DocumentId { get; set; }

        /// <summary>
        /// The title of the document being indexed.<br/>
        /// Example: 2024 Annual ESG Report
        /// </summary>
        /// <example>2024 Annual ESG Report</example>
        [global::Newtonsoft.Json.JsonProperty("title")]
        public string? Title { get; set; }

        /// <summary>
        /// A brief description or summary of the document content.<br/>
        /// Example: Comprehensive environmental, social, and governance report
        /// </summary>
        /// <example>Comprehensive environmental, social, and governance report</example>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// The metadata key-value pairs to associate with the document. If present, this gets merged with existing artifact metadata.<br/>
        /// Example: {"doc_type":"annual_report","year":2024,"department":"sustainability"}
        /// </summary>
        /// <example>{"doc_type":"annual_report","year":2024,"department":"sustainability"}</example>
        [global::Newtonsoft.Json.JsonProperty("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// The structured document to index with full hierarchical content.<br/>
        /// Example: {"id":"annual_report_2024","type":"structured","title":"2024 Annual ESG Report"}
        /// </summary>
        /// <example>{"id":"annual_report_2024","type":"structured","title":"2024 Annual ESG Report"}</example>
        [global::Newtonsoft.Json.JsonProperty("document")]
        public object? Document { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StructuredIndexingToolParameters" /> class.
        /// </summary>
        /// <param name="corpusKey">
        /// The key identifying the target corpus for document indexing. If not provided, will be filled in by the agent.<br/>
        /// Example: my-knowledge-base
        /// </param>
        /// <param name="documentId">
        /// The unique identifier for the document within the corpus, preferably human readable IDs.<br/>
        /// Example: annual_report_2024
        /// </param>
        /// <param name="title">
        /// The title of the document being indexed.<br/>
        /// Example: 2024 Annual ESG Report
        /// </param>
        /// <param name="description">
        /// A brief description or summary of the document content.<br/>
        /// Example: Comprehensive environmental, social, and governance report
        /// </param>
        /// <param name="metadata">
        /// The metadata key-value pairs to associate with the document. If present, this gets merged with existing artifact metadata.<br/>
        /// Example: {"doc_type":"annual_report","year":2024,"department":"sustainability"}
        /// </param>
        /// <param name="document">
        /// The structured document to index with full hierarchical content.<br/>
        /// Example: {"id":"annual_report_2024","type":"structured","title":"2024 Annual ESG Report"}
        /// </param>
        public StructuredIndexingToolParameters(
            string? corpusKey,
            string? documentId,
            string? title,
            string? description,
            object? metadata,
            object? document)
        {
            this.CorpusKey = corpusKey;
            this.DocumentId = documentId;
            this.Title = title;
            this.Description = description;
            this.Metadata = metadata;
            this.Document = document;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StructuredIndexingToolParameters" /> class.
        /// </summary>
        public StructuredIndexingToolParameters()
        {
        }
    }
}