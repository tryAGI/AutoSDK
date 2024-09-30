//HintName: G.Models.Document.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Document
    {
        /// <summary>
        /// The Document ID.<br/>
        /// Example: my-doc-id
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public string? Id { get; set; }

        /// <summary>
        /// The document metadata.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("metadata")]
        public global::G.DocumentMetadata? Metadata { get; set; }

        /// <summary>
        /// Parts of the document that make up the document. However, parts are not available when<br/>
        /// retrieving a list of documents or when creating a document. This property is only available<br/>
        /// when retrieving a document by id.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("parts")]
        public global::System.Collections.Generic.IList<global::G.DocumentPart>? Parts { get; set; }

        /// <summary>
        /// How much storage the document used. This information is currently not returned when<br/>
        /// retrieving the document, and only returned when indexing document.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("storage_usage")]
        public global::G.DocumentStorageUsage? StorageUsage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}