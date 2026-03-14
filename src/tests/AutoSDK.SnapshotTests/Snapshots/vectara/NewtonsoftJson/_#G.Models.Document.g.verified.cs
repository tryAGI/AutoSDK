//HintName: G.Models.Document.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A document stored in a corpus, containing metadata and indexed content.<br/>
    /// Example: {"id":"manufacturing_invoice-2331","metadata":{"doc_type":"invoice","industry":"manufacturing"},"tables":[{"id":"billing_table_1","title":"Customer Billing Info","description":"Monthly billing for top manufacturing clients","data":{"headers":[[{"text_value":"Customer Name"},{"text_value":"Balance"},{"text_value":"Account Created"}]],"rows":[[{"text_value":"Acme Corp"},{"float_value":10230.25},{"text_value":"2023-01-15"}],[{"text_value":"Beta Industries"},{"float_value":8750},{"text_value":"2022-11-03"}],[{"text_value":"Zeta Manufacturing"},{"float_value":13499.99},{"text_value":"2023-06-30"}]]}}],"images":[{"id":"image_1","title":"Quarterly Sales Performance","caption":"Sales growth trends for Q1 to Q4 of 2024","description":"A bar chart showing quarterly sales growth, with Q4 outperforming all previous quarters by 15%","mime_type":"image/png","image_data":{"data":"iVBORw0KGgoAAAANSUhEUgAAAAEAAAABCAIAAACQd1PeAAAADElEQVR4nGP4//8/AAX\u002BAv4N70a4AAAAAElFTkSuQmCC"}}],"parts":[{"text":"This invoice includes customer billing history for Q1.","metadata":{"part.rank":9000}}],"storage_usage":{"bytes_used":1024,"metadata_bytes_used":256},"extraction_usage":{"table_extraction_used":3}}
    /// </summary>
    public sealed partial class Document
    {
        /// <summary>
        /// The document ID.<br/>
        /// Example: Invoice-403
        /// </summary>
        /// <example>Invoice-403</example>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public string? Id { get; set; }

        /// <summary>
        /// The document metadata.<br/>
        /// Example: {"priority":"High"}
        /// </summary>
        /// <example>{"priority":"High"}</example>
        [global::Newtonsoft.Json.JsonProperty("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// The tables that this document contains. Tables are not available when table extraction is not enabled.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tables")]
        public global::System.Collections.Generic.IList<global::G.Table>? Tables { get; set; }

        /// <summary>
        /// The images that this document contains.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("images")]
        public global::System.Collections.Generic.IList<global::G.ImageMetadata>? Images { get; set; }

        /// <summary>
        /// Parts of the document that make up the document. However, parts are not available when retrieving a list of documents or when creating a document. This property is only available when retrieving a document by ID.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("parts")]
        public global::System.Collections.Generic.IList<global::G.DocumentPart>? Parts { get; set; }

        /// <summary>
        /// How much storage the document used. This information is currently not returned when retrieving the document, and only returned when indexing a document.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("storage_usage")]
        public global::G.DocumentStorageUsage? StorageUsage { get; set; }

        /// <summary>
        /// How much extraction quota the document used. This information is currently not returned when retrieving the document, and only returned when indexing a document.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("extraction_usage")]
        public global::G.ExtractionUsage? ExtractionUsage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Document" /> class.
        /// </summary>
        /// <param name="id">
        /// The document ID.<br/>
        /// Example: Invoice-403
        /// </param>
        /// <param name="metadata">
        /// The document metadata.<br/>
        /// Example: {"priority":"High"}
        /// </param>
        /// <param name="tables">
        /// The tables that this document contains. Tables are not available when table extraction is not enabled.
        /// </param>
        /// <param name="images">
        /// The images that this document contains.
        /// </param>
        /// <param name="parts">
        /// Parts of the document that make up the document. However, parts are not available when retrieving a list of documents or when creating a document. This property is only available when retrieving a document by ID.
        /// </param>
        /// <param name="storageUsage">
        /// How much storage the document used. This information is currently not returned when retrieving the document, and only returned when indexing a document.
        /// </param>
        /// <param name="extractionUsage">
        /// How much extraction quota the document used. This information is currently not returned when retrieving the document, and only returned when indexing a document.
        /// </param>
        public Document(
            string? id,
            object? metadata,
            global::System.Collections.Generic.IList<global::G.Table>? tables,
            global::System.Collections.Generic.IList<global::G.ImageMetadata>? images,
            global::System.Collections.Generic.IList<global::G.DocumentPart>? parts,
            global::G.DocumentStorageUsage? storageUsage,
            global::G.ExtractionUsage? extractionUsage)
        {
            this.Id = id;
            this.Metadata = metadata;
            this.Tables = tables;
            this.Images = images;
            this.Parts = parts;
            this.StorageUsage = storageUsage;
            this.ExtractionUsage = extractionUsage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Document" /> class.
        /// </summary>
        public Document()
        {
        }
    }
}